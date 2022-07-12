
using com.github.javaparser.ast;
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

using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.symbolsolver.javaparsermodel.contexts;

public class LambdaExprContext : AbstractJavaParserContext
{
	
	private sealed class ___003C_003EAnon0 : Consumer
	{
		private readonly LambdaExprContext arg_00241;

		private readonly InferenceContext arg_00242;

		private readonly ResolvedType arg_00243;

		internal ___003C_003EAnon0(LambdaExprContext P_0, InferenceContext P_1, ResolvedType P_2)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024solveSymbolAsValue_00240(arg_00242, arg_00243, (ResolvedReferenceTypeDeclaration)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
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

	
	
	
	private void lambda_0024solveSymbolAsValue_00240(InferenceContext P_0, ResolvedType P_1, ResolvedReferenceTypeDeclaration P_2)
	{
		ReferenceTypeImpl.___003Cclinit_003E();
		P_0.addPair(P_1, new ReferenceTypeImpl(P_2, typeSolver));
	}

	
	
	public LambdaExprContext(LambdaExpr wrappedNode, TypeSolver typeSolver)
		: base(wrappedNode, typeSolver)
	{
	}

	
		
	public override Optional solveSymbolAsValue(string name)
	{
		int num = -1;
		Iterator iterator = ((LambdaExpr)wrappedNode).getParameters().iterator();
		while (iterator.hasNext())
		{
			Parameter node = (Parameter)iterator.next();
			num++;
			SymbolDeclarator symbolDeclarator = JavaParserFactory.getSymbolDeclarator(node, typeSolver);
			Iterator iterator2 = symbolDeclarator.getSymbolDeclarations().iterator();
			while (iterator2.hasNext())
			{
				ResolvedValueDeclaration resolvedValueDeclaration = (ResolvedValueDeclaration)iterator2.next();
				if (!String.instancehelper_equals(resolvedValueDeclaration.getName(), name))
				{
					continue;
				}
				Node node2 = Navigator.demandParentNode(wrappedNode);
				if (node2 is MethodCallExpr)
				{
					MethodCallExpr methodCallExpr = (MethodCallExpr)node2;
					MethodUsage methodUsage = JavaParserFacade.get(typeSolver).solveMethodAsUsage(methodCallExpr);
					int index = pos(methodCallExpr, (Expression)wrappedNode);
					ResolvedType resolvedType = (ResolvedType)methodUsage.getParamTypes().get(index);
					Optional functionalMethod = FunctionalInterfaceLogic.getFunctionalMethod(resolvedType);
					if (functionalMethod.isPresent())
					{
						MethodUsage methodUsage2 = (MethodUsage)functionalMethod.get();
						InferenceContext inferenceContext = new InferenceContext(MyObjectProvider.___003C_003EINSTANCE);
						resolvedType.asReferenceType().getTypeDeclaration().ifPresent(new ___003C_003EAnon0(this, inferenceContext, resolvedType));
						int num2 = 0;
						int i;
						for (i = 0; i < ((LambdaExpr)wrappedNode).getParameters().size(); i++)
						{
							if (String.instancehelper_equals(((LambdaExpr)wrappedNode).getParameter(i).getName().getIdentifier(), name))
							{
								num2 = 1;
								break;
							}
						}
						if (num2 == 0)
						{
							Optional result = Optional.empty();
							
							return result;
						}
						ResolvedType resolvedType2 = inferenceContext.resolve(inferenceContext.addSingle(methodUsage2.getParamType(i)));
						ResolvedLambdaConstraintType type = ((!resolvedType2.isWildcard()) ? ResolvedLambdaConstraintType.bound(resolvedType2) : ResolvedLambdaConstraintType.bound(resolvedType2.asWildcard().getBoundedType()));
						Value value = new Value(type, name);
						Optional result2 = Optional.of(value);
						
						return result2;
					}
					Optional result3 = Optional.empty();
					
					return result3;
				}
				if (node2 is VariableDeclarator)
				{
					VariableDeclarator var = (VariableDeclarator)node2;
					ResolvedType resolvedType3 = JavaParserFacade.get(typeSolver).convertToUsageVariableType(var);
					Optional functionalMethod2 = FunctionalInterfaceLogic.getFunctionalMethod(resolvedType3);
					if (functionalMethod2.isPresent())
					{
						ResolvedType resolvedType = ((MethodUsage)functionalMethod2.get()).getParamType(num);
						HashMap inferredTypes = new HashMap();
						if (resolvedType.isReferenceType())
						{
							Iterator iterator3 = resolvedType.asReferenceType().getTypeParametersMap().iterator();
							while (iterator3.hasNext())
							{
								Pair pair = (Pair)iterator3.next();
								if (((ResolvedType)pair.___003C_003Eb).isTypeVariable() && ((ResolvedType)pair.___003C_003Eb).asTypeParameter().declaredOnType())
								{
									ResolvedType value2 = resolvedType3.asReferenceType().typeParametersMap().getValue((ResolvedTypeParameterDeclaration)pair.___003C_003Ea);
									resolvedType = resolvedType.replaceTypeVariables((ResolvedTypeParameterDeclaration)pair.___003C_003Ea, value2, inferredTypes);
								}
							}
						}
						else if (resolvedType.isTypeVariable() && resolvedType.asTypeParameter().declaredOnType())
						{
							resolvedType = resolvedType3.asReferenceType().typeParametersMap().getValue(resolvedType.asTypeParameter());
						}
						Value value3 = new Value(resolvedType, name);
						Optional result4 = Optional.of(value3);
						
						return result4;
					}
					
					throw new UnsupportedOperationException();
				}
				if (node2 is ReturnStmt)
				{
					ReturnStmt returnStmt = (ReturnStmt)node2;
					Optional optional = returnStmt.findAncestor(new Class[1] { ClassLiteral<MethodDeclaration>.Value });
					if (!optional.isPresent())
					{
						continue;
					}
					ResolvedType resolvedType4 = JavaParserFacade.get(typeSolver).convertToUsage(((MethodDeclaration)optional.get()).asMethodDeclaration().getType());
					Optional functionalMethod3 = FunctionalInterfaceLogic.getFunctionalMethod(resolvedType4);
					if (functionalMethod3.isPresent())
					{
						ResolvedType resolvedType5 = ((MethodUsage)functionalMethod3.get()).getParamType(num);
						HashMap inferredTypes2 = new HashMap();
						if (resolvedType5.isReferenceType())
						{
							Iterator iterator4 = resolvedType5.asReferenceType().getTypeParametersMap().iterator();
							while (iterator4.hasNext())
							{
								Pair pair2 = (Pair)iterator4.next();
								if (((ResolvedType)pair2.___003C_003Eb).isTypeVariable() && ((ResolvedType)pair2.___003C_003Eb).asTypeParameter().declaredOnType())
								{
									ResolvedType value4 = resolvedType4.asReferenceType().typeParametersMap().getValue((ResolvedTypeParameterDeclaration)pair2.___003C_003Ea);
									resolvedType5 = resolvedType5.replaceTypeVariables((ResolvedTypeParameterDeclaration)pair2.___003C_003Ea, value4, inferredTypes2);
								}
							}
						}
						else if (resolvedType5.isTypeVariable() && resolvedType5.asTypeParameter().declaredOnType())
						{
							resolvedType5 = resolvedType4.asReferenceType().typeParametersMap().getValue(resolvedType5.asTypeParameter());
						}
						Value value5 = new Value(resolvedType5, name);
						Optional result5 = Optional.of(value5);
						
						return result5;
					}
					
					throw new UnsupportedOperationException();
				}
				if (node2 is CastExpr)
				{
					CastExpr castExpr = (CastExpr)node2;
					ResolvedType resolvedType3 = JavaParserFacade.get(typeSolver).convertToUsage(castExpr.getType());
					Optional functionalMethod2 = FunctionalInterfaceLogic.getFunctionalMethod(resolvedType3);
					if (functionalMethod2.isPresent())
					{
						ResolvedType resolvedType = ((MethodUsage)functionalMethod2.get()).getParamType(num);
						HashMap inferredTypes = new HashMap();
						if (resolvedType.isReferenceType())
						{
							Iterator iterator3 = resolvedType.asReferenceType().getTypeParametersMap().iterator();
							while (iterator3.hasNext())
							{
								Pair pair = (Pair)iterator3.next();
								if (((ResolvedType)pair.___003C_003Eb).isTypeVariable() && ((ResolvedType)pair.___003C_003Eb).asTypeParameter().declaredOnType())
								{
									ResolvedType value2 = resolvedType3.asReferenceType().typeParametersMap().getValue((ResolvedTypeParameterDeclaration)pair.___003C_003Ea);
									resolvedType = resolvedType.replaceTypeVariables((ResolvedTypeParameterDeclaration)pair.___003C_003Ea, value2, inferredTypes);
								}
							}
						}
						else if (resolvedType.isTypeVariable() && resolvedType.asTypeParameter().declaredOnType())
						{
							resolvedType = resolvedType3.asReferenceType().typeParametersMap().getValue(resolvedType.asTypeParameter());
						}
						Value value3 = new Value(resolvedType, name);
						Optional result6 = Optional.of(value3);
						
						return result6;
					}
					
					throw new UnsupportedOperationException();
				}
				
				throw new UnsupportedOperationException();
			}
		}
		Optional result7 = solveSymbolAsValueInParentContext(name);
		
		return result7;
	}

	
		
	public override SymbolReference solveSymbol(string name)
	{
		Iterator iterator = ((LambdaExpr)wrappedNode).getParameters().iterator();
		while (iterator.hasNext())
		{
			Parameter node = (Parameter)iterator.next();
			SymbolDeclarator symbolDeclarator = JavaParserFactory.getSymbolDeclarator(node, typeSolver);
			SymbolReference symbolReference = AbstractJavaParserContext.solveWith(symbolDeclarator, name);
			if (symbolReference.isSolved())
			{
				return symbolReference;
			}
		}
		SymbolReference result = solveSymbolInParentContext(name);
		
		return result;
	}

	
		
	public override SymbolReference solveMethod(string name, List argumentsTypes, bool staticOnly)
	{
		SymbolReference result = solveMethodInParentContext(name, argumentsTypes, false);
		
		return result;
	}

	
		
	public override List parametersExposedToChild(Node child)
	{
		if (child == ((LambdaExpr)wrappedNode).getBody())
		{
			NodeList parameters = ((LambdaExpr)wrappedNode).getParameters();
			
			return parameters;
		}
		List result = Collections.emptyList();
		
		return result;
	}

	
		
	protected internal sealed override Optional solveWithAsValue(SymbolDeclarator symbolDeclarator, string name)
	{
		Iterator iterator = symbolDeclarator.getSymbolDeclarations().iterator();
		while (iterator.hasNext())
		{
			ResolvedValueDeclaration resolvedValueDeclaration = (ResolvedValueDeclaration)iterator.next();
			if (String.instancehelper_equals(resolvedValueDeclaration.getName(), name))
			{
				
				throw new UnsupportedOperationException();
			}
		}
		Optional result = Optional.empty();
		
		return result;
	}
}
