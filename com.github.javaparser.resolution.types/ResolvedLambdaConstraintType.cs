using System.Runtime.CompilerServices;
using com.github.javaparser.resolution.declarations;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace com.github.javaparser.resolution.types;

public class ResolvedLambdaConstraintType: ResolvedType
{
	private ResolvedType m_bound;

	
	
	
	private ResolvedLambdaConstraintType(ResolvedType bound)
	{
		this.m_bound = bound;
	}

	
	
	public virtual string describe()
	{
		string result = new StringBuilder().append("? super ").append(this.m_bound.describe()).ToString();
		
		return result;
	}

	public virtual ResolvedType getBound()
	{
		return this.m_bound;
	}

	public virtual bool isConstraint()
	{
		return true;
	}

	public virtual ResolvedLambdaConstraintType asConstraintType()
	{
		return this;
	}

	
	
	
	public static ResolvedLambdaConstraintType bound(ResolvedType bound)
	{
		ResolvedLambdaConstraintType result = new ResolvedLambdaConstraintType(bound);
		
		return result;
	}

	
	
	
	public virtual bool isAssignableBy(ResolvedType other)
	{
		bool result = this.m_bound.isAssignableBy(other);
		
		return result;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("LambdaConstraintType{bound=").append(this.m_bound).append('}')
			.ToString();
		
		return result;
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