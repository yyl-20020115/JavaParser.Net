
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;

using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.symbolsolver.logic;

public class InferenceContext
{
	
	private sealed class ___003C_003EAnon0 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon0(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024registerCorrespondance_00240(arg_00241, (ResolvedReferenceType)P_0);
			
			return result;
		}

		
		public Predicate and(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public Predicate negate()
		{
			return Predicate._003Cdefault_003Enegate(this);
		}

		
		public Predicate or(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon1(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024registerCorrespondance_00241(arg_00241, (ResolvedReferenceType)P_0);
			
			return result;
		}

		
		public Predicate and(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public Predicate negate()
		{
			return Predicate._003Cdefault_003Enegate(this);
		}

		
		public Predicate or(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon2 : ResolvedTypeTransformer
	{
		private readonly InferenceContext arg_00241;

		internal ___003C_003EAnon2(InferenceContext P_0)
		{
			arg_00241 = P_0;
		}

		public ResolvedType transform(ResolvedType P_0)
		{
			ResolvedType result = arg_00241.lambda_0024placeInferenceVariables_00242(P_0);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon3 : ResolvedTypeTransformer
	{
		private readonly InferenceContext arg_00241;

		internal ___003C_003EAnon3(InferenceContext P_0)
		{
			arg_00241 = P_0;
		}

		public ResolvedType transform(ResolvedType P_0)
		{
			ResolvedType result = arg_00241.lambda_0024resolve_00243(P_0);
			
			return result;
		}
	}

	private int nextInferenceVariableId;

	private ObjectProvider objectProvider;

		private List inferenceVariableTypes;

		private Map inferenceVariableTypeMap;

	
	
	public InferenceContext(ObjectProvider objectProvider)
	{
		nextInferenceVariableId = 0;
		inferenceVariableTypes = new ArrayList();
		inferenceVariableTypeMap = new HashMap();
		this.objectProvider = objectProvider;
	}

	
	
	public virtual ResolvedType addPair(ResolvedType target, ResolvedType actual)
	{
		target = placeInferenceVariables(target);
		actual = placeInferenceVariables(actual);
		registerCorrespondance(target, actual);
		return target;
	}

	
	
	public virtual ResolvedType addSingle(ResolvedType actual)
	{
		ResolvedType result = placeInferenceVariables(actual);
		
		return result;
	}

	
	
	public virtual ResolvedType resolve(ResolvedType type)
	{
		if (type is InferenceVariableType)
		{
			InferenceVariableType inferenceVariableType = (InferenceVariableType)type;
			ResolvedType result = inferenceVariableType.equivalentType();
			
			return result;
		}
		if (type.isReferenceType())
		{
			ResolvedType result2 = type.asReferenceType().transformTypeParameters(new ___003C_003EAnon3(this));
			
			return result2;
		}
		if (type.isNull() || type.isPrimitive() || type.isVoid())
		{
			return type;
		}
		if (type.isArray())
		{
			ResolvedArrayType result3 = new ResolvedArrayType(resolve(type.asArrayType().getComponentType()));
			
			return result3;
		}
		if (type.isWildcard())
		{
			if (type.asWildcard().isExtends())
			{
				ResolvedWildcard result4 = ResolvedWildcard.extendsBound(resolve(type.asWildcard().getBoundedType()));
				
				return result4;
			}
			if (type.asWildcard().isSuper())
			{
				ResolvedWildcard result5 = ResolvedWildcard.superBound(resolve(type.asWildcard().getBoundedType()));
				
				return result5;
			}
			return type;
		}
		string message = type.describe();
		
		throw new UnsupportedOperationException(message);
	}

	
	
	private ResolvedType placeInferenceVariables(ResolvedType P_0)
	{
		if (P_0.isWildcard())
		{
			if (P_0.asWildcard().isExtends())
			{
				ResolvedWildcard result = ResolvedWildcard.extendsBound(placeInferenceVariables(P_0.asWildcard().getBoundedType()));
				
				return result;
			}
			if (P_0.asWildcard().isSuper())
			{
				ResolvedWildcard result2 = ResolvedWildcard.superBound(placeInferenceVariables(P_0.asWildcard().getBoundedType()));
				
				return result2;
			}
			return P_0;
		}
		if (P_0.isTypeVariable())
		{
			InferenceVariableType result3 = inferenceVariableTypeForTp(P_0.asTypeParameter());
			
			return result3;
		}
		if (P_0.isReferenceType())
		{
			ResolvedType result4 = P_0.asReferenceType().transformTypeParameters(new ___003C_003EAnon2(this));
			
			return result4;
		}
		if (P_0.isArray())
		{
			ResolvedArrayType result5 = new ResolvedArrayType(placeInferenceVariables(P_0.asArrayType().getComponentType()));
			
			return result5;
		}
		if (P_0.isNull() || P_0.isPrimitive() || P_0.isVoid())
		{
			return P_0;
		}
		if (P_0.isConstraint())
		{
			ResolvedLambdaConstraintType result6 = ResolvedLambdaConstraintType.bound(placeInferenceVariables(P_0.asConstraintType().getBound()));
			
			return result6;
		}
		if (P_0 is InferenceVariableType)
		{
			return P_0;
		}
		string message = P_0.describe();
		
		throw new UnsupportedOperationException(message);
	}

	
	
	private void registerCorrespondance(ResolvedType P_0, ResolvedType P_1)
	{
		if (P_0.isReferenceType() && P_1.isReferenceType())
		{
			ResolvedReferenceType resolvedReferenceType = P_0.asReferenceType();
			ResolvedReferenceType resolvedReferenceType2 = P_1.asReferenceType();
			if (!String.instancehelper_equals(resolvedReferenceType.getQualifiedName(), resolvedReferenceType2.getQualifiedName()))
			{
				List allAncestors = resolvedReferenceType2.getAllAncestors();
				string qualifiedName = resolvedReferenceType.getQualifiedName();
				List list = (List)allAncestors.stream().filter(new ___003C_003EAnon0(qualifiedName)).collect(Collectors.toList());
				if (list.isEmpty())
				{
					allAncestors = resolvedReferenceType.getAllAncestors();
					string qualifiedName2 = resolvedReferenceType2.getQualifiedName();
					List list2 = (List)allAncestors.stream().filter(new ___003C_003EAnon1(qualifiedName2)).collect(Collectors.toList());
					if (list2.isEmpty())
					{
						
						throw new ConfilictingGenericTypesException(P_0, P_1);
					}
					list = list2;
				}
				resolvedReferenceType2 = ((ResolvedType)list.get(0)).asReferenceType();
			}
			if (String.instancehelper_equals(resolvedReferenceType.getQualifiedName(), resolvedReferenceType2.getQualifiedName()) && !resolvedReferenceType.typeParametersValues().isEmpty() && !resolvedReferenceType2.isRawType())
			{
				int num = 0;
				Iterator iterator = resolvedReferenceType.typeParametersValues().iterator();
				while (iterator.hasNext())
				{
					ResolvedType resolvedType = (ResolvedType)iterator.next();
					registerCorrespondance(resolvedType, (ResolvedType)resolvedReferenceType2.typeParametersValues().get(num));
					num++;
				}
			}
		}
		else if (P_0 is InferenceVariableType && !P_1.isPrimitive())
		{
			((InferenceVariableType)P_0).registerEquivalentType(P_1);
			if (P_1 is InferenceVariableType)
			{
				((InferenceVariableType)P_1).registerEquivalentType(P_0);
			}
		}
		else
		{
			if (P_1.isNull() || Object.instancehelper_equals(P_1, P_0))
			{
				return;
			}
			if (P_1.isArray() && P_0.isArray())
			{
				registerCorrespondance(P_0.asArrayType().getComponentType(), P_1.asArrayType().getComponentType());
			}
			else if (P_0.isWildcard())
			{
				if (P_1 is InferenceVariableType && P_0.asWildcard().isBounded())
				{
					((InferenceVariableType)P_1).registerEquivalentType(P_0.asWildcard().getBoundedType());
					if (P_0.asWildcard().getBoundedType() is InferenceVariableType)
					{
						((InferenceVariableType)P_0.asWildcard().getBoundedType()).registerEquivalentType(P_1);
					}
				}
				if (P_1.isWildcard())
				{
					ResolvedWildcard resolvedWildcard = P_0.asWildcard();
					ResolvedWildcard resolvedWildcard2 = P_1.asWildcard();
					if (resolvedWildcard.isBounded() && resolvedWildcard.getBoundedType() is InferenceVariableType)
					{
						if (resolvedWildcard.isSuper() && resolvedWildcard2.isSuper())
						{
							((InferenceVariableType)P_0.asWildcard().getBoundedType()).registerEquivalentType(resolvedWildcard2.getBoundedType());
						}
						else if (resolvedWildcard.isExtends() && resolvedWildcard2.isExtends())
						{
							((InferenceVariableType)P_0.asWildcard().getBoundedType()).registerEquivalentType(resolvedWildcard2.getBoundedType());
						}
					}
				}
				if (P_1.isReferenceType() && P_0.asWildcard().isBounded())
				{
					registerCorrespondance(P_0.asWildcard().getBoundedType(), P_1);
				}
			}
			else if (P_1 is InferenceVariableType)
			{
				if (P_0 is ResolvedReferenceType)
				{
					((InferenceVariableType)P_1).registerEquivalentType(P_0);
				}
				else if (P_0 is InferenceVariableType)
				{
					((InferenceVariableType)P_1).registerEquivalentType(P_0);
				}
			}
			else if (P_1.isConstraint())
			{
				ResolvedLambdaConstraintType resolvedLambdaConstraintType = P_1.asConstraintType();
				if (resolvedLambdaConstraintType.getBound() is InferenceVariableType)
				{
					((InferenceVariableType)resolvedLambdaConstraintType.getBound()).registerEquivalentType(P_0);
				}
			}
			else if (P_1.isPrimitive())
			{
				if (!P_0.isPrimitive())
				{
					registerCorrespondance(P_0, objectProvider.byName(P_1.asPrimitive().getBoxTypeQName()));
				}
			}
			else if (P_1.isReferenceType())
			{
				if (P_0.isPrimitive() && String.instancehelper_equals(P_0.asPrimitive().getBoxTypeQName(), P_1.describe()))
				{
					registerCorrespondance(objectProvider.byName(P_0.asPrimitive().getBoxTypeQName()), P_1);
				}
			}
			else
			{
				if (!P_0.isReferenceType())
				{
					string message = new StringBuilder().append(P_0.describe()).append(" ").append(P_1.describe())
						.ToString();
					
					throw new UnsupportedOperationException(message);
				}
				ResolvedReferenceType resolvedReferenceType = P_0.asReferenceType();
				if (!resolvedReferenceType.isJavaLangObject())
				{
					string message2 = new StringBuilder().append(P_0.describe()).append(" ").append(P_1.describe())
						.ToString();
					
					throw new UnsupportedOperationException(message2);
				}
			}
		}
	}

	
	
	private InferenceVariableType inferenceVariableTypeForTp(ResolvedTypeParameterDeclaration P_0)
	{
		if (!inferenceVariableTypeMap.containsKey(P_0.getName()))
		{
			int num = nextInferenceVariableId;
			nextInferenceVariableId = num + 1;
			InferenceVariableType inferenceVariableType = new InferenceVariableType(num, objectProvider);
			inferenceVariableTypes.add(inferenceVariableType);
			inferenceVariableType.setCorrespondingTp(P_0);
			inferenceVariableTypeMap.put(P_0.getName(), inferenceVariableType);
		}
		return (InferenceVariableType)inferenceVariableTypeMap.get(P_0.getName());
	}

	
	
	
	private static bool lambda_0024registerCorrespondance_00240(string P_0, ResolvedReferenceType P_1)
	{
		bool result = String.instancehelper_equals(P_1.getQualifiedName(), P_0);
		
		return result;
	}

	
	
	
	private static bool lambda_0024registerCorrespondance_00241(string P_0, ResolvedReferenceType P_1)
	{
		bool result = String.instancehelper_equals(P_1.getQualifiedName(), P_0);
		
		return result;
	}

	
	
	
	private ResolvedType lambda_0024placeInferenceVariables_00242(ResolvedType P_0)
	{
		ResolvedType result = placeInferenceVariables(P_0);
		
		return result;
	}

	
	
	
	private ResolvedType lambda_0024resolve_00243(ResolvedType P_0)
	{
		ResolvedType result = resolve(P_0);
		
		return result;
	}
}
