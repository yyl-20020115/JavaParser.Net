using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.type;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.core.resolution;
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

public class MethodCallExprContext : AbstractJavaParserContext
{
	
	[LineNumberTable(new byte[]
	{
		92, 122, 102, 127, 21, 115, 130, 108, 110, 109,
		63, 3, 232, 70
	})]
	private MethodUsage resolveMethodTypeParametersFromExplicitList(TypeSolver P_0, MethodUsage P_1)
	{
		if (((MethodCallExpr)wrappedNode).getTypeArguments().isPresent())
		{
			ArrayList arrayList = new ArrayList();
			Iterator iterator = ((NodeList)((MethodCallExpr)wrappedNode).getTypeArguments().get()).iterator();
			while (iterator.hasNext())
			{
				Type type = (Type)iterator.next();
				((List)arrayList).add((object)JavaParserFacade.get(P_0).convertToUsage(type));
			}
			List typeParameters = P_1.getDeclaration().getTypeParameters();
			if (typeParameters.size() == ((List)arrayList).size())
			{
				for (int i = 0; i < typeParameters.size(); i++)
				{
					P_1 = P_1.replaceTypeParameter((ResolvedTypeParameterDeclaration)typeParameters.get(i), (ResolvedType)((List)arrayList).get(i));
				}
			}
		}
		return P_1;
	}

	
		[LineNumberTable(new byte[]
	{
		160, 235, 134, 112, 150, 97, 154, 98, 122, 127,
		0, 114, 105, 127, 7, 111, 130, 137, 214, 234,
		61, 240, 71, 105, 98, 194, 110, 106, 135, 105,
		106, 111, 235, 61, 232, 69, 127, 5, 119, 98
	})]
	private MethodUsage resolveMethodTypeParameters(MethodUsage P_0, List P_1)
	{
		HashMap hashMap = new HashMap();
		if (P_0.getDeclaration().hasVariadicParameter())
		{
			if (P_1.size() != P_0.getDeclaration().getNumberOfParams())
			{
				return P_0;
			}
			ResolvedType resolvedType = P_0.getDeclaration().getLastParam().getType()
				.asArrayType()
				.getComponentType();
			ResolvedType resolvedType2 = ((!((ResolvedType)P_1.get(P_1.size() - 1)).isArray()) ? ((ResolvedType)P_1.get(P_1.size() - 1)) : ((ResolvedType)P_1.get(P_1.size() - 1)).asArrayType().getComponentType());
			if (!resolvedType.isAssignableBy(resolvedType2))
			{
				Iterator iterator = P_0.getDeclaration().getTypeParameters().iterator();
				while (iterator.hasNext())
				{
					ResolvedTypeParameterDeclaration tp = (ResolvedTypeParameterDeclaration)iterator.next();
					resolvedType = MethodResolutionLogic.replaceTypeParam(resolvedType, tp, typeSolver);
				}
			}
			if (!resolvedType.isAssignableBy(resolvedType2))
			{
				string message = String.format("Unable to resolve the type typeParametersValues in a MethodUsage. Expected type: %s, Actual type: %s. Method Declaration: %s. MethodUsage: %s", resolvedType, resolvedType2, P_0.getDeclaration(), P_0);
				
				throw new UnsupportedOperationException(message);
			}
			matchTypeParameters(resolvedType, resolvedType2, hashMap);
		}
		int num = ((!P_0.getDeclaration().hasVariadicParameter()) ? P_1.size() : (P_1.size() - 1));
		for (int i = 0; i < num; i++)
		{
			ResolvedType paramType = P_0.getParamType(i);
			ResolvedType resolvedType3 = (ResolvedType)P_1.get(i);
			matchTypeParameters(paramType, resolvedType3, hashMap);
		}
		Iterator iterator2 = ((Map)hashMap).keySet().iterator();
		while (iterator2.hasNext())
		{
			ResolvedTypeParameterDeclaration resolvedTypeParameterDeclaration = (ResolvedTypeParameterDeclaration)iterator2.next();
			P_0 = P_0.replaceTypeParameter(resolvedTypeParameterDeclaration, (ResolvedType)((Map)hashMap).get((object)resolvedTypeParameterDeclaration));
		}
		return P_0;
	}

	
		[LineNumberTable(new byte[]
	{
		161, 128, 107, 127, 9, 127, 29, 159, 26, 101,
		130
	})]
	private ResolvedType usingParameterTypesFromScope(ResolvedType P_0, ResolvedType P_1, Map P_2)
	{
		if (P_1.isReferenceType())
		{
			Iterator iterator = P_1.asReferenceType().getTypeParametersMap().iterator();
			while (iterator.hasNext())
			{
				Pair pair = (Pair)iterator.next();
				if (((ResolvedTypeParameterDeclaration)pair.___003C_003Ea).declaredOnType() && P_0.isReferenceType() && P_0.asReferenceType().getGenericParameterByName(((ResolvedTypeParameterDeclaration)pair.___003C_003Ea).getName()).isPresent())
				{
					P_1 = P_1.replaceTypeVariables((ResolvedTypeParameterDeclaration)pair.___003C_003Ea, (ResolvedType)P_0.asReferenceType().getGenericParameterByName(((ResolvedTypeParameterDeclaration)pair.___003C_003Ea).getName()).get(), P_2);
				}
			}
			return P_1;
		}
		return P_1;
	}

	
		
	private ResolvedType applyInferredTypes(ResolvedType P_0, Map P_1)
	{
		Iterator iterator = P_1.keySet().iterator();
		while (iterator.hasNext())
		{
			ResolvedTypeParameterDeclaration resolvedTypeParameterDeclaration = (ResolvedTypeParameterDeclaration)iterator.next();
			P_0 = P_0.replaceTypeVariables(resolvedTypeParameterDeclaration, (ResolvedType)P_1.get(resolvedTypeParameterDeclaration), P_1);
		}
		return P_0;
	}

	
		[LineNumberTable(new byte[]
	{
		161, 96, 104, 115, 104, 115, 107, 103, 104, 115,
		104, 147, 159, 14, 104, 103, 115, 136, 127, 14,
		104, 108, 104, 152, 191, 11
	})]
	private Optional solveMethodAsUsage(ResolvedType P_0, string P_1, List P_2, Context P_3)
	{
		if (P_0 is ResolvedReferenceType)
		{
			Optional result = solveMethodAsUsage((ResolvedReferenceType)P_0, P_1, P_2, P_3);
			
			return result;
		}
		if (P_0 is ResolvedTypeVariable)
		{
			Optional result2 = solveMethodAsUsage((ResolvedTypeVariable)P_0, P_1, P_2, P_3);
			
			return result2;
		}
		if (P_0 is ResolvedWildcard)
		{
			ResolvedWildcard resolvedWildcard = (ResolvedWildcard)P_0;
			if (resolvedWildcard.isSuper())
			{
				Optional result3 = solveMethodAsUsage(resolvedWildcard.getBoundedType(), P_1, P_2, P_3);
				
				return result3;
			}
			if (resolvedWildcard.isExtends())
			{
				Optional result4 = solveMethodAsUsage(resolvedWildcard.getBoundedType(), P_1, P_2, P_3);
				
				return result4;
			}
			ReferenceTypeImpl.___003Cclinit_003E();
			Optional result5 = solveMethodAsUsage(new ReferenceTypeImpl(new ReflectionClassDeclaration(ClassLiteral<Object>.Value, typeSolver), typeSolver), P_1, P_2, P_3);
			
			return result5;
		}
		if (P_0 is ResolvedLambdaConstraintType)
		{
			ResolvedLambdaConstraintType resolvedLambdaConstraintType = (ResolvedLambdaConstraintType)P_0;
			Optional result6 = solveMethodAsUsage(resolvedLambdaConstraintType.getBound(), P_1, P_2, P_3);
			
			return result6;
		}
		if (P_0 is ResolvedArrayType)
		{
			ReferenceTypeImpl.___003Cclinit_003E();
			Optional result7 = solveMethodAsUsage(new ReferenceTypeImpl(new ReflectionClassDeclaration(ClassLiteral<Object>.Value, typeSolver), typeSolver), P_1, P_2, P_3);
			
			return result7;
		}
		if (P_0 is ResolvedUnionType)
		{
			Optional commonAncestor = P_0.asUnionType().getCommonAncestor();
			if (commonAncestor.isPresent())
			{
				Optional result8 = solveMethodAsUsage((ResolvedReferenceType)commonAncestor.get(), P_1, P_2, P_3);
				
				return result8;
			}
			string message = new StringBuilder().append("no common ancestor available for ").append(P_0.describe()).ToString();
			
			throw new UnsupportedOperationException(message);
		}
		string message2 = new StringBuilder().append("type usage: ").append(Object.instancehelper_getClass(P_0).getCanonicalName()).ToString();
		
		throw new UnsupportedOperationException(message2);
	}

	
		[LineNumberTable(new byte[]
	{
		160, 141, 105, 129, 118, 103, 103, 115, 112, 112,
		63, 10, 230, 69, 129, 112, 109, 117, 129, 129,
		112, 122, 159, 0, 129, 112, 110, 129, 112, 110,
		129, 112, 108, 109, 108, 129, 112, 109, 117, 129,
		129, 112, 110, 161, 112, 109, 149, 129, 112, 117,
		161, 112, 117, 129, 112, 110, 129, 104, 107, 129,
		112, 129, 104, 161, 104, 103, 104, 161
	})]
	private void inferTypes(ResolvedType P_0, ResolvedType P_1, Map P_2)
	{
		if (Object.instancehelper_equals(P_0, P_1))
		{
			return;
		}
		if (P_0.isReferenceType() && P_1.isReferenceType())
		{
			ResolvedReferenceType resolvedReferenceType = P_0.asReferenceType();
			ResolvedReferenceType resolvedReferenceType2 = P_1.asReferenceType();
			if (String.instancehelper_equals(resolvedReferenceType.getQualifiedName(), resolvedReferenceType2.getQualifiedName()) && !resolvedReferenceType.isRawType() && !resolvedReferenceType2.isRawType())
			{
				for (int i = 0; i < resolvedReferenceType.typeParametersValues().size(); i++)
				{
					inferTypes((ResolvedType)resolvedReferenceType.typeParametersValues().get(i), (ResolvedType)resolvedReferenceType2.typeParametersValues().get(i), P_2);
				}
			}
		}
		else if (P_0.isReferenceType() && P_1.isWildcard())
		{
			if (P_1.asWildcard().isBounded())
			{
				inferTypes(P_0, P_1.asWildcard().getBoundedType(), P_2);
			}
		}
		else if (P_0.isWildcard() && P_1.isWildcard())
		{
			if (P_0.asWildcard().isBounded() && P_1.asWildcard().isBounded())
			{
				inferTypes(P_0.asWildcard().getBoundedType(), P_1.asWildcard().getBoundedType(), P_2);
			}
		}
		else if (P_0.isReferenceType() && P_1.isTypeVariable())
		{
			P_2.put(P_1.asTypeParameter(), P_0);
		}
		else if (P_0.isWildcard() && P_1.isTypeVariable())
		{
			P_2.put(P_1.asTypeParameter(), P_0);
		}
		else if (P_0.isArray() && P_1.isArray())
		{
			ResolvedType componentType = P_0.asArrayType().getComponentType();
			ResolvedType componentType2 = P_1.asArrayType().getComponentType();
			inferTypes(componentType, componentType2, P_2);
		}
		else if (P_0.isArray() && P_1.isWildcard())
		{
			if (P_1.asWildcard().isBounded())
			{
				inferTypes(P_0, P_1.asWildcard().getBoundedType(), P_2);
			}
		}
		else if (P_0.isArray() && P_1.isTypeVariable())
		{
			P_2.put(P_1.asTypeParameter(), P_0);
		}
		else if (P_0.isWildcard() && P_1.isReferenceType())
		{
			if (P_0.asWildcard().isBounded())
			{
				inferTypes(P_0.asWildcard().getBoundedType(), P_1, P_2);
			}
		}
		else if (P_0.isConstraint() && P_1.isReferenceType())
		{
			inferTypes(P_0.asConstraintType().getBound(), P_1, P_2);
		}
		else if (P_0.isConstraint() && P_1.isTypeVariable())
		{
			inferTypes(P_0.asConstraintType().getBound(), P_1, P_2);
		}
		else if (P_0.isTypeVariable() && P_1.isTypeVariable())
		{
			P_2.put(P_1.asTypeParameter(), P_0);
		}
		else if (P_0.isTypeVariable())
		{
			inferTypes(P_1, P_0, P_2);
		}
		else
		{
			if (P_0.isPrimitive() || P_1.isPrimitive() || P_0.isNull())
			{
				return;
			}
			if (P_1.isReferenceType())
			{
				ResolvedReferenceType resolvedReferenceType = P_1.asReferenceType();
				if (resolvedReferenceType.isJavaLangObject())
				{
					return;
				}
			}
			string message = new StringBuilder().append(P_0.describe()).append(" ").append(P_1.describe())
				.ToString();
			
			throw new RuntimeException(message);
		}
	}

	
		[LineNumberTable(new byte[]
	{
		161, 28, 107, 130, 109, 251, 70, 123, 139, 127,
		23, 150, 110, 141, 112, 150, 98, 107, 22, 202,
		139, 127, 2, 98, 127, 6, 126, 100, 98, 98,
		138, 170, 150
	})]
	private void matchTypeParameters(ResolvedType P_0, ResolvedType P_1, Map P_2)
	{
		if (P_0.isTypeVariable())
		{
			object obj = P_1;
			if (((ResolvedType)obj).isPrimitive())
			{
				obj = MyObjectProvider.___003C_003EINSTANCE.byName(((ResolvedType)obj).asPrimitive().getBoxTypeQName());
			}
			object obj2 = obj;
			if (((obj2 == null) ? null : ((obj2 as ResolvedType) ?? throw new java.lang.IncompatibleClassChangeError())).isNull())
			{
				obj = MyObjectProvider.___003C_003EINSTANCE.@object();
			}
			object obj3 = obj;
			if (!((obj3 == null) ? null : ((obj3 as ResolvedType) ?? throw new java.lang.IncompatibleClassChangeError())).isTypeVariable())
			{
				object obj4 = obj;
				if (!((obj4 == null) ? null : ((obj4 as ResolvedType) ?? throw new java.lang.IncompatibleClassChangeError())).isReferenceType())
				{
					string canonicalName = Object.instancehelper_getClass(obj).getCanonicalName();
					
					throw new UnsupportedOperationException(canonicalName);
				}
			}
			P_2.put(P_0.asTypeParameter(), obj);
		}
		else if (P_0.isArray())
		{
			if (!P_1.isArray() && !P_1.isNull())
			{
				string canonicalName2 = Object.instancehelper_getClass(P_1).getCanonicalName();
				
				throw new UnsupportedOperationException(canonicalName2);
			}
			matchTypeParameters(P_0.asArrayType().getComponentType(), (!P_1.isNull()) ? P_1.asArrayType().getComponentType() : P_1, P_2);
		}
		else if (P_0.isReferenceType())
		{
			if (P_1.isReferenceType() && P_1.asReferenceType().typeParametersValues().size() > 0)
			{
				int num = 0;
				Iterator iterator = P_0.asReferenceType().typeParametersValues().iterator();
				while (iterator.hasNext())
				{
					ResolvedType resolvedType = (ResolvedType)iterator.next();
					matchTypeParameters(resolvedType, (ResolvedType)P_1.asReferenceType().typeParametersValues().get(num), P_2);
					num++;
				}
			}
		}
		else if (!P_0.isPrimitive() && !P_0.isWildcard())
		{
			string canonicalName3 = Object.instancehelper_getClass(P_0).getCanonicalName();
			
			throw new UnsupportedOperationException(canonicalName3);
		}
	}

	
		[LineNumberTable(new byte[]
	{
		160, 79, 109, 168, 127, 1, 107, 140, 238, 84,
		102, 115, 110, 137, 119, 130, 124, 142, 245, 54,
		233, 77, 127, 5, 127, 0, 130, 142, 115, 137,
		114, 122, 11, 200, 137
	})]
	private Optional solveMethodAsUsage(ResolvedReferenceType P_0, string P_1, List P_2, Context P_3)
	{
		if (!P_0.getTypeDeclaration().isPresent())
		{
			Optional result = Optional.empty();
			
			return result;
		}
		Optional optional = ContextHelper.solveMethodAsUsage((ResolvedTypeDeclaration)P_0.getTypeDeclaration().get(), P_1, P_2, P_3, P_0.typeParametersValues());
		if (optional.isPresent())
		{
			MethodUsage methodUsage = (MethodUsage)optional.get();
			methodUsage = resolveMethodTypeParametersFromExplicitList(typeSolver, methodUsage);
			HashMap hashMap = new HashMap();
			for (int i = 0; i < methodUsage.getParamTypes().size(); i++)
			{
				ResolvedParameterDeclaration param = methodUsage.getDeclaration().getParam(i);
				ResolvedType resolvedType = param.getType();
				if (param.isVariadic() && P_2.size() < methodUsage.getNoParams())
				{
					break;
				}
				if (!((ResolvedType)P_2.get(i)).isArray() && param.isVariadic())
				{
					resolvedType = resolvedType.asArrayType().getComponentType();
				}
				inferTypes((ResolvedType)P_2.get(i), resolvedType, hashMap);
			}
			Iterator iterator = ((Map)hashMap).entrySet().iterator();
			while (iterator.hasNext())
			{
				Map.Entry entry = (Map.Entry)iterator.next();
				methodUsage = methodUsage.replaceTypeParameter((ResolvedTypeParameterDeclaration)entry.getKey(), (ResolvedType)entry.getValue());
			}
			ResolvedType resolvedType2 = P_0.useThisTypeParametersOnTheGivenType(methodUsage.returnType());
			if (resolvedType2 != methodUsage.returnType() && resolvedType2 != ResolvedWildcard.UNBOUNDED)
			{
				methodUsage = methodUsage.replaceReturnType(resolvedType2);
			}
			for (int j = 0; j < methodUsage.getParamTypes().size(); j++)
			{
				ResolvedType resolvedType = P_0.useThisTypeParametersOnTheGivenType((ResolvedType)methodUsage.getParamTypes().get(j));
				methodUsage = methodUsage.replaceParamType(j, resolvedType);
			}
			Optional result2 = Optional.of(methodUsage);
			
			return result2;
		}
		return optional;
	}

	
		[LineNumberTable(new byte[]
	{
		161, 73, 140, 232, 69, 134, 47, 37, 230, 69,
		123, 113, 104, 130, 130
	})]
	private Optional solveMethodAsUsage(ResolvedTypeVariable P_0, string P_1, List P_2, Context P_3)
	{
		List list = P_0.asTypeParameter().getBounds();
		if (list.isEmpty())
		{
			list = Collections.singletonList(ResolvedTypeParameterDeclaration.Bound.extendsBound(JavaParserFacade.get(typeSolver).classToResolvedType(ClassLiteral<Object>.Value)));
		}
		Iterator iterator = list.iterator();
		while (iterator.hasNext())
		{
			ResolvedTypeParameterDeclaration.Bound bound = (ResolvedTypeParameterDeclaration.Bound)iterator.next();
			Optional optional = solveMethodAsUsage(bound.getType(), P_1, P_2, P_3);
			if (optional.isPresent())
			{
				return optional;
			}
		}
		Optional result = Optional.empty();
		
		return result;
	}

	
	
	public MethodCallExprContext(MethodCallExpr wrappedNode, TypeSolver typeSolver)
		: base(wrappedNode, typeSolver)
	{
	}

	
		
	public override Optional solveGenericType(string name)
	{
		Optional scope = ((MethodCallExpr)wrappedNode).getScope();
		if (!scope.isPresent())
		{
			Optional result = Optional.empty();
			
			return result;
		}
		ResolvedType type = JavaParserFacade.get(typeSolver).getType((Node)scope.get());
		return type.asReferenceType().getGenericParameterByName(name);
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("MethodCallExprContext{wrapped=").append(wrappedNode).append("}")
			.ToString();
		
		return result;
	}

	
		[LineNumberTable(new byte[]
	{
		47,
		117,
		155,
		107,
		113,
		104,
		107,
		115,
		104,
		114,
		112,
		107,
		138,
		byte.MaxValue,
		38,
		71,
		115,
		130,
		216,
		103,
		173,
		111,
		110,
		235,
		59,
		232,
		71,
		109,
		119,
		11,
		232,
		69
	})]
	public override Optional solveMethodAsUsage(string name, List argumentsTypes)
	{
		ResolvedType resolvedType;
		if (((MethodCallExpr)wrappedNode).hasScope())
		{
			Expression expression = (Expression)((MethodCallExpr)wrappedNode).getScope().get();
			if (expression is NameExpr)
			{
				string id = ((NameExpr)expression).getName().getId();
				SymbolReference symbolReference = solveType(id);
				if (symbolReference.isSolved())
				{
					SymbolReference symbolReference2 = MethodResolutionLogic.solveMethodInType((ResolvedTypeDeclaration)symbolReference.getCorrespondingDeclaration(), name, argumentsTypes);
					if (symbolReference2.isSolved())
					{
						MethodUsage methodUsage = new MethodUsage((ResolvedMethodDeclaration)symbolReference2.getCorrespondingDeclaration());
						methodUsage = resolveMethodTypeParametersFromExplicitList(typeSolver, methodUsage);
						methodUsage = resolveMethodTypeParameters(methodUsage, argumentsTypes);
						Optional result = Optional.of(methodUsage);
						
						return result;
					}
					string name2 = Object.instancehelper_toString((ResolvedTypeDeclaration)symbolReference.getCorrespondingDeclaration());
					string context = new StringBuilder().append("Method '").append(name).append("' with parameterTypes ")
						.append(argumentsTypes)
						.ToString();
					
					throw new UnsolvedSymbolException(name2, context);
				}
			}
			resolvedType = JavaParserFacade.get(typeSolver).getType(expression);
		}
		else
		{
			resolvedType = JavaParserFacade.get(typeSolver).getTypeOfThisIn(wrappedNode);
		}
		HashMap hashMap = new HashMap();
		for (int i = 0; i < argumentsTypes.size(); i++)
		{
			ResolvedType resolvedType2 = (ResolvedType)argumentsTypes.get(i);
			ResolvedType element = usingParameterTypesFromScope(resolvedType, resolvedType2, hashMap);
			argumentsTypes.set(i, element);
		}
		for (int i = 0; i < argumentsTypes.size(); i++)
		{
			ResolvedType resolvedType2 = applyInferredTypes((ResolvedType)argumentsTypes.get(i), hashMap);
			argumentsTypes.set(i, resolvedType2);
		}
		Optional result2 = solveMethodAsUsage(resolvedType, name, argumentsTypes, this);
		
		return result2;
	}

	
		
	public override Optional solveSymbolAsValue(string name)
	{
		Optional result = solveSymbolAsValueInParentContext(name);
		
		return result;
	}

	
		[LineNumberTable(new byte[]
	{
		116, 151, 237, 69, 177, 127, 15, 106, 104, 130,
		130
	})]
	public override SymbolReference solveMethod(string name, List argumentsTypes, bool staticOnly)
	{
		object obj = findTypeDeclarations(((MethodCallExpr)wrappedNode).getScope());
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
		}
		SymbolReference result = SymbolReference.unsolved(ClassLiteral<ResolvedMethodDeclaration>.Value);
		
		return result;
	}
}
