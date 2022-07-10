using System.Runtime.CompilerServices;
using com.github.javaparser.resolution.declarations;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace com.github.javaparser.resolution.types;

public class ResolvedArrayType: ResolvedType
{
	private ResolvedType baseType;

	public virtual ResolvedType getComponentType()
	{
		return baseType;
	}

	
	
	
	public ResolvedArrayType(ResolvedType baseType)
	{
		this.baseType = baseType;
	}

	
	
	
	public override bool Equals(object o)
	{
		if (this == o)
		{
			return true;
		}
		if (o == null || ((object)this).GetType() != o.GetType())
		{
			return false;
		}
		ResolvedArrayType resolvedArrayType = (ResolvedArrayType)o;
		if (!Object.instancehelper_equals(baseType, resolvedArrayType.baseType))
		{
			return false;
		}
		return true;
	}

	
	
	public override int GetHashCode()
	{
		int result = Object.instancehelper_hashCode(baseType);
		
		return result;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("ResolvedArrayType{").append(baseType).append("}")
			.ToString();
		
		return result;
	}

	public virtual ResolvedArrayType asArrayType()
	{
		return this;
	}

	public virtual bool isArray()
	{
		return true;
	}

	
	
	public virtual string describe()
	{
		string result = new StringBuilder().append(baseType.describe()).append("[]").ToString();
		
		return result;
	}

	
	
	
	public virtual bool isAssignableBy(ResolvedType other)
	{
		if (other.isArray())
		{
			if (baseType.isPrimitive() && other.asArrayType().getComponentType().isPrimitive())
			{
				bool result = Object.instancehelper_equals(baseType, other.asArrayType().getComponentType());
				
				return result;
			}
			bool result2 = baseType.isAssignableBy(other.asArrayType().getComponentType());
			
			return result2;
		}
		if (other.isNull())
		{
			return true;
		}
		return false;
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual ResolvedType replaceTypeVariables(ResolvedTypeParameterDeclaration tpToReplace, ResolvedType replaced, Map inferredTypes)
	{
		ResolvedType resolvedType = baseType.replaceTypeVariables(tpToReplace, replaced, inferredTypes);
		if (resolvedType == baseType)
		{
			return this;
		}
		ResolvedArrayType result = new ResolvedArrayType(resolvedType);
		
		return result;
	}

	
	
	public virtual ResolvedType erasure()
	{
		ResolvedArrayType result = new ResolvedArrayType(baseType.erasure());
		
		return result;
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
}
