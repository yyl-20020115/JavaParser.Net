
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;

using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.symbolsolver.logic;

public class InferenceVariableType: ResolvedType
{
	
	private sealed class ___003C_003EAnon0 : Predicate
	{
		internal ___003C_003EAnon0()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024concreteEquivalentTypesAlsoIndirectly_00240((ResolvedType)P_0);
			
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
		internal ___003C_003EAnon1()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024concreteEquivalentTypesAlsoIndirectly_00241((ResolvedType)P_0);
			
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

	
	private sealed class ___003C_003EAnon2 : Consumer
	{
		private readonly InferenceVariableType arg_00241;

		private readonly Set arg_00242;

		private readonly Set arg_00243;

		internal ___003C_003EAnon2(InferenceVariableType P_0, Set P_1, Set P_2)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024concreteEquivalentTypesAlsoIndirectly_00242(arg_00242, arg_00243, (ResolvedType)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon3 : Predicate
	{
		private readonly InferenceVariableType arg_00241;

		internal ___003C_003EAnon3(InferenceVariableType P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = arg_00241.lambda_0024equivalentType_00243((ResolvedType)P_0);
			
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

	private int id;

	private ResolvedTypeParameterDeclaration correspondingTp;

		private Set equivalentTypes;

	private ObjectProvider objectProvider;

		private Set superTypes;

	
	
	public InferenceVariableType(int id, ObjectProvider objectProvider)
	{
		equivalentTypes = new HashSet();
		superTypes = new HashSet();
		this.id = id;
		this.objectProvider = objectProvider;
	}

	public virtual void setCorrespondingTp(ResolvedTypeParameterDeclaration correspondingTp)
	{
		this.correspondingTp = correspondingTp;
	}

	
	
	public virtual void registerEquivalentType(ResolvedType type)
	{
		equivalentTypes.add(type);
	}

	
	
	public virtual ResolvedType equivalentType()
	{
		Set set = concreteEquivalentTypesAlsoIndirectly(new HashSet(), this);
		if (set.isEmpty())
		{
			if (correspondingTp == null)
			{
				ResolvedReferenceType result = objectProvider.@object();
				
				return result;
			}
			ResolvedTypeVariable result2 = new ResolvedTypeVariable(correspondingTp);
			
			return result2;
		}
		if (set.size() == 1)
		{
			return (ResolvedType)set.iterator().next();
		}
		Set set2 = (Set)equivalentTypes.stream().filter(new ___003C_003EAnon3(this)).collect(Collectors.toSet());
		if (set2.size() == 1)
		{
			return (ResolvedType)set2.iterator().next();
		}
		if (set2.size() == 0 && !superTypes.isEmpty())
		{
			if (superTypes.size() == 1)
			{
				return (ResolvedType)superTypes.iterator().next();
			}
			string s = new StringBuilder().append("Super types are: ").append(superTypes).ToString();
			
			throw new IllegalStateException(s);
		}
		string s2 = new StringBuilder().append("Equivalent types are: ").append(equivalentTypes).ToString();
		
		throw new IllegalStateException(s2);
	}

	
		
	private Set concreteEquivalentTypesAlsoIndirectly(Set P_0, InferenceVariableType P_1)
	{
		P_0.add(P_1);
		HashSet hashSet = new HashSet();
		((Set)hashSet).addAll((Collection)P_1.equivalentTypes.stream().filter(new ___003C_003EAnon0()).collect(Collectors.toSet()));
		P_1.equivalentTypes.stream().filter(new ___003C_003EAnon1()).forEach(new ___003C_003EAnon2(this, P_0, hashSet));
		return hashSet;
	}

	
	
	private bool hasInferenceVariables(ResolvedType P_0)
	{
		if (P_0 is InferenceVariableType)
		{
			return true;
		}
		if (P_0.isReferenceType())
		{
			ResolvedReferenceType resolvedReferenceType = P_0.asReferenceType();
			Iterator iterator = resolvedReferenceType.typeParametersValues().iterator();
			while (iterator.hasNext())
			{
				ResolvedType resolvedType = (ResolvedType)iterator.next();
				if (hasInferenceVariables(resolvedType))
				{
					return true;
				}
			}
			return false;
		}
		if (P_0.isWildcard())
		{
			ResolvedWildcard resolvedWildcard = P_0.asWildcard();
			bool result = hasInferenceVariables(resolvedWildcard.getBoundedType());
			
			return result;
		}
		return false;
	}

	
	
	
	private static bool lambda_0024concreteEquivalentTypesAlsoIndirectly_00240(ResolvedType P_0)
	{
		return (!P_0.isTypeVariable() && !(P_0 is InferenceVariableType)) ? true : false;
	}

	
	
	private static bool lambda_0024concreteEquivalentTypesAlsoIndirectly_00241(ResolvedType P_0)
	{
		return P_0 is InferenceVariableType;
	}

	
	
	
	private void lambda_0024concreteEquivalentTypesAlsoIndirectly_00242(Set P_0, Set P_1, ResolvedType P_2)
	{
		InferenceVariableType inferenceVariableType = (InferenceVariableType)P_2;
		if (!P_0.contains(inferenceVariableType))
		{
			P_1.addAll(concreteEquivalentTypesAlsoIndirectly(P_0, inferenceVariableType));
		}
	}

	
	
	
	private bool lambda_0024equivalentType_00243(ResolvedType P_0)
	{
		return (!P_0.isTypeVariable() && !hasInferenceVariables(P_0)) ? true : false;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("InferenceVariableType{id=").append(id).append('}')
			.ToString();
		
		return result;
	}

	
	public override bool Equals(object o)
	{
		if (this == o)
		{
			return true;
		}
		if (!(o is InferenceVariableType))
		{
			return false;
		}
		InferenceVariableType inferenceVariableType = (InferenceVariableType)o;
		return id == inferenceVariableType.id;
	}

	public override int GetHashCode()
	{
		return id;
	}

	
	
	public static InferenceVariableType fromWildcard(ResolvedWildcard wildcard, int id, ObjectProvider objectProvider)
	{
		InferenceVariableType inferenceVariableType = new InferenceVariableType(id, objectProvider);
		if (wildcard.isExtends())
		{
			inferenceVariableType.superTypes.add(wildcard.getBoundedType());
		}
		if (wildcard.isSuper())
		{
			inferenceVariableType.superTypes.add(wildcard.getBoundedType());
		}
		return inferenceVariableType;
	}

	
	
	public virtual string describe()
	{
		string result = new StringBuilder().append("InferenceVariable_").append(id).ToString();
		
		return result;
	}

	
	
	public virtual bool isAssignableBy(ResolvedType other)
	{
		
		throw new UnsupportedOperationException();
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isArray()
	{
		return ResolvedType._003Cdefault_003EisArray(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual int arrayLevel()
	{
		return ResolvedType._003Cdefault_003EarrayLevel(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isPrimitive()
	{
		return ResolvedType._003Cdefault_003EisPrimitive(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isNull()
	{
		return ResolvedType._003Cdefault_003EisNull(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isUnionType()
	{
		return ResolvedType._003Cdefault_003EisUnionType(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isReference()
	{
		return ResolvedType._003Cdefault_003EisReference(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isConstraint()
	{
		return ResolvedType._003Cdefault_003EisConstraint(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isReferenceType()
	{
		return ResolvedType._003Cdefault_003EisReferenceType(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isVoid()
	{
		return ResolvedType._003Cdefault_003EisVoid(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isTypeVariable()
	{
		return ResolvedType._003Cdefault_003EisTypeVariable(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isWildcard()
	{
		return ResolvedType._003Cdefault_003EisWildcard(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isInferenceVariable()
	{
		return ResolvedType._003Cdefault_003EisInferenceVariable(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedArrayType asArrayType()
	{
		return ResolvedType._003Cdefault_003EasArrayType(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedReferenceType asReferenceType()
	{
		return ResolvedType._003Cdefault_003EasReferenceType(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedTypeParameterDeclaration asTypeParameter()
	{
		return ResolvedType._003Cdefault_003EasTypeParameter(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedTypeVariable asTypeVariable()
	{
		return ResolvedType._003Cdefault_003EasTypeVariable(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedPrimitiveType asPrimitive()
	{
		return ResolvedType._003Cdefault_003EasPrimitive(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedWildcard asWildcard()
	{
		return ResolvedType._003Cdefault_003EasWildcard(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedLambdaConstraintType asConstraintType()
	{
		return ResolvedType._003Cdefault_003EasConstraintType(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedUnionType asUnionType()
	{
		return ResolvedType._003Cdefault_003EasUnionType(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedType replaceTypeVariables(ResolvedTypeParameterDeclaration P_0, ResolvedType P_1, Map P_2)
	{
		return ResolvedType._003Cdefault_003EreplaceTypeVariables(this, P_0, P_1, P_2);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedType replaceTypeVariables(ResolvedTypeParameterDeclaration P_0, ResolvedType P_1)
	{
		return ResolvedType._003Cdefault_003EreplaceTypeVariables(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool mention(List P_0)
	{
		return ResolvedType._003Cdefault_003Emention(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isNumericType()
	{
		return ResolvedType._003Cdefault_003EisNumericType(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedType erasure()
	{
		return ResolvedType._003Cdefault_003Eerasure(this);
	}
}
