using System.Runtime.CompilerServices;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.javaparser;
using com.github.javaparser.symbolsolver.logic;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.model.typesystem;
using com.github.javaparser.symbolsolver.reflectionmodel;
using com.github.javaparser.symbolsolver.resolution;
using com.github.javaparser.utils;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.javaparsermodel.contexts;

public class MethodReferenceExprContext : AbstractJavaParserContext
{
	
		[LineNumberTable(new byte[]
	{
		56, 117, 113, 114, 115, 178, 104, 108, 142, 135,
		127, 9, 204, 191, 1, 178, 105, 149, 169, 106,
		133, 131, 139, 117, 114, 116, 105, 108, 103, 159,
		19, 103, 108, 127, 14, 127, 12, 127, 0, 153,
		103, 119, 154, 106, 133, 131, 139, 117, 114, 119,
		108, 127, 9, 105, 108, 103, 159, 19, 103, 108,
		127, 14, 127, 12, 127, 0, 153, 103, 119, 154,
		106, 133, 131, 171, 139
	})]
	private List inferArgumentTypes()
	{
		if (Navigator.demandParentNode(wrappedNode) is MethodCallExpr)
		{
			MethodCallExpr methodCallExpr = (MethodCallExpr)Navigator.demandParentNode(wrappedNode);
			MethodUsage methodUsage = JavaParserFacade.get(typeSolver).solveMethodAsUsage(methodCallExpr);
			int index = pos(methodCallExpr, (Expression)wrappedNode);
			ResolvedType resolvedType = (ResolvedType)methodUsage.getParamTypes().get(index);
			Optional functionalMethod = FunctionalInterfaceLogic.getFunctionalMethod(resolvedType);
			if (functionalMethod.isPresent())
			{
				MethodUsage methodUsage2 = (MethodUsage)functionalMethod.get();
				ArrayList arrayList = new ArrayList();
				Iterator iterator = methodUsage2.getParamTypes().iterator();
				while (iterator.hasNext())
				{
					ResolvedType actual = (ResolvedType)iterator.next();
					InferenceContext inferenceContext = new InferenceContext(MyObjectProvider.___003C_003EINSTANCE);
					ReferenceTypeImpl.___003Cclinit_003E();
					inferenceContext.addPair(new ReferenceTypeImpl(methodUsage2.declaringType(), typeSolver), resolvedType);
					ResolvedType resolvedType2 = inferenceContext.resolve(inferenceContext.addSingle(actual));
					ResolvedLambdaConstraintType e = ((!resolvedType2.isWildcard()) ? ResolvedLambdaConstraintType.bound(resolvedType2) : ResolvedLambdaConstraintType.bound(resolvedType2.asWildcard().getBoundedType()));
					((List)arrayList).add((object)e);
				}
				return arrayList;
			}
			
			throw new UnsupportedOperationException();
		}
		if (Navigator.demandParentNode(wrappedNode) is VariableDeclarator)
		{
			VariableDeclarator var = (VariableDeclarator)Navigator.demandParentNode(wrappedNode);
			ResolvedType resolvedType3 = JavaParserFacade.get(typeSolver).convertToUsageVariableType(var);
			Optional functionalMethod2 = FunctionalInterfaceLogic.getFunctionalMethod(resolvedType3);
			if (functionalMethod2.isPresent())
			{
				ArrayList arrayList2 = new ArrayList();
				Iterator iterator2 = ((MethodUsage)functionalMethod2.get()).getParamTypes().iterator();
				while (iterator2.hasNext())
				{
					ResolvedType resolvedType4 = (ResolvedType)iterator2.next();
					HashMap inferredTypes = new HashMap();
					if (resolvedType4.isReferenceType())
					{
						Iterator iterator = resolvedType4.asReferenceType().getTypeParametersMap().iterator();
						while (iterator.hasNext())
						{
							Pair pair = (Pair)iterator.next();
							if (((ResolvedType)pair.___003C_003Eb).isTypeVariable() && ((ResolvedType)pair.___003C_003Eb).asTypeParameter().declaredOnType())
							{
								ResolvedType value = resolvedType3.asReferenceType().typeParametersMap().getValue((ResolvedTypeParameterDeclaration)pair.___003C_003Ea);
								resolvedType4 = resolvedType4.replaceTypeVariables((ResolvedTypeParameterDeclaration)pair.___003C_003Ea, value, inferredTypes);
							}
						}
					}
					else if (resolvedType4.isTypeVariable() && resolvedType4.asTypeParameter().declaredOnType())
					{
						resolvedType4 = resolvedType3.asReferenceType().typeParametersMap().getValue(resolvedType4.asTypeParameter());
					}
					((List)arrayList2).add((object)resolvedType4);
				}
				return arrayList2;
			}
			
			throw new UnsupportedOperationException();
		}
		if (Navigator.demandParentNode(wrappedNode) is ReturnStmt)
		{
			ReturnStmt returnStmt = (ReturnStmt)Navigator.demandParentNode(wrappedNode);
			Optional optional = returnStmt.findAncestor(new Class[1] { ClassLiteral<MethodDeclaration>.Value });
			if (optional.isPresent())
			{
				ResolvedType resolvedType5 = JavaParserFacade.get(typeSolver).convertToUsage(((MethodDeclaration)optional.get()).asMethodDeclaration().getType());
				Optional functionalMethod3 = FunctionalInterfaceLogic.getFunctionalMethod(resolvedType5);
				if (functionalMethod3.isPresent())
				{
					ArrayList arrayList3 = new ArrayList();
					Iterator iterator3 = ((MethodUsage)functionalMethod3.get()).getParamTypes().iterator();
					while (iterator3.hasNext())
					{
						ResolvedType resolvedType6 = (ResolvedType)iterator3.next();
						HashMap inferredTypes2 = new HashMap();
						if (resolvedType6.isReferenceType())
						{
							Iterator iterator4 = resolvedType6.asReferenceType().getTypeParametersMap().iterator();
							while (iterator4.hasNext())
							{
								Pair pair2 = (Pair)iterator4.next();
								if (((ResolvedType)pair2.___003C_003Eb).isTypeVariable() && ((ResolvedType)pair2.___003C_003Eb).asTypeParameter().declaredOnType())
								{
									ResolvedType resolvedType2 = resolvedType5.asReferenceType().typeParametersMap().getValue((ResolvedTypeParameterDeclaration)pair2.___003C_003Ea);
									resolvedType6 = resolvedType6.replaceTypeVariables((ResolvedTypeParameterDeclaration)pair2.___003C_003Ea, resolvedType2, inferredTypes2);
								}
							}
						}
						else if (resolvedType6.isTypeVariable() && resolvedType6.asTypeParameter().declaredOnType())
						{
							resolvedType6 = resolvedType5.asReferenceType().typeParametersMap().getValue(resolvedType6.asTypeParameter());
						}
						((List)arrayList3).add((object)resolvedType6);
					}
					return arrayList3;
				}
				
				throw new UnsupportedOperationException();
			}
			
			throw new UnsupportedOperationException();
		}
		
		throw new UnsupportedOperationException();
	}

	
	
	private int pos(MethodCallExpr P_0, Expression P_1)
	{
		int num = 0;
		Iterator iterator = P_0.getArguments().iterator();
		while (iterator.hasNext())
		{
			Expression expression = (Expression)iterator.next();
			if (expression == P_1)
			{
				return num;
			}
			num++;
		}
		
		throw new IllegalArgumentException();
	}

	
	
	public MethodReferenceExprContext(MethodReferenceExpr wrappedNode, TypeSolver typeSolver)
		: base(wrappedNode, typeSolver)
	{
	}

	
		[LineNumberTable(new byte[]
	{
		18, 109, 176, 141, 156, 237, 69, 177, 127, 15,
		106, 104, 194, 111, 105, 163, 130
	})]
	public override SymbolReference solveMethod(string name, List argumentsTypes, bool staticOnly)
	{
		if (String.instancehelper_equals("new", name))
		{
			
			throw new UnsupportedOperationException("Constructor calls not yet resolvable");
		}
		argumentsTypes.addAll(inferArgumentTypes());
		object obj = findTypeDeclarations(Optional.of(((MethodReferenceExpr)wrappedNode).getScope()));
		if (((Collection)obj).isEmpty())
		{
			obj = Collections.singleton(typeSolver.getSolvedJavaLangObject());
		}
		object obj2 = obj;
		Iterator iterator = ((obj2 == null) ? null : ((obj2 as Collection) ?? throw new java.lang.IncompatibleClassChangeError())).iterator();
		while (iterator.hasNext())
		{
			ResolvedReferenceTypeDeclaration typeDeclaration = (ResolvedReferenceTypeDeclaration)iterator.next();
			SymbolReference symbolReference = MethodResolutionLogic.solveMethodInType(typeDeclaration, name, argumentsTypes, staticOnly: false);
			if (symbolReference.isSolved())
			{
				return symbolReference;
			}
			SymbolReference symbolReference2 = MethodResolutionLogic.solveMethodInType(typeDeclaration, name, Collections.emptyList(), staticOnly: false);
			if (symbolReference2.isSolved())
			{
				return symbolReference2;
			}
		}
		SymbolReference result = SymbolReference.unsolved(ClassLiteral<ResolvedMethodDeclaration>.Value);
		
		return result;
	}
}
