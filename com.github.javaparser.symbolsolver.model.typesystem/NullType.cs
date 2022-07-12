
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;

using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.model.typesystem;

public class NullType: ResolvedType
{
	internal static NullType ___003C_003EINSTANCE;

	
	public static NullType INSTANCE
	{
		
		get
		{
			return ___003C_003EINSTANCE;
		}
	}

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
	
	private NullType()
	{
	}

	public virtual bool isArray()
	{
		return false;
	}

	public virtual bool isPrimitive()
	{
		return false;
	}

	public virtual bool isNull()
	{
		return true;
	}

	public virtual bool isReferenceType()
	{
		return false;
	}

	public virtual string describe()
	{
		return "null";
	}

	public virtual bool isTypeVariable()
	{
		return false;
	}

	
	
	public virtual bool isAssignableBy(ResolvedType other)
	{
		
		throw new UnsupportedOperationException("It does not make sense to assign a value to null, it can only be assigned");
	}

	
	static NullType()
	{
		___003C_003EINSTANCE = new NullType();
	}


	public virtual int arrayLevel()
	{
		return ResolvedType._003Cdefault_003EarrayLevel(this);
	}


	public virtual bool isUnionType()
	{
		return ResolvedType._003Cdefault_003EisUnionType(this);
	}


	public virtual bool isReference()
	{
		return ResolvedType._003Cdefault_003EisReference(this);
	}


	public virtual bool isConstraint()
	{
		return ResolvedType._003Cdefault_003EisConstraint(this);
	}


	public virtual bool isVoid()
	{
		return ResolvedType._003Cdefault_003EisVoid(this);
	}


	public virtual bool isWildcard()
	{
		return ResolvedType._003Cdefault_003EisWildcard(this);
	}


	public virtual bool isInferenceVariable()
	{
		return ResolvedType._003Cdefault_003EisInferenceVariable(this);
	}


	public virtual ResolvedArrayType asArrayType()
	{
		return ResolvedType._003Cdefault_003EasArrayType(this);
	}


	public virtual ResolvedReferenceType asReferenceType()
	{
		return ResolvedType._003Cdefault_003EasReferenceType(this);
	}


	public virtual ResolvedTypeParameterDeclaration asTypeParameter()
	{
		return ResolvedType._003Cdefault_003EasTypeParameter(this);
	}


	public virtual ResolvedTypeVariable asTypeVariable()
	{
		return ResolvedType._003Cdefault_003EasTypeVariable(this);
	}


	public virtual ResolvedPrimitiveType asPrimitive()
	{
		return ResolvedType._003Cdefault_003EasPrimitive(this);
	}


	public virtual ResolvedWildcard asWildcard()
	{
		return ResolvedType._003Cdefault_003EasWildcard(this);
	}


	public virtual ResolvedLambdaConstraintType asConstraintType()
	{
		return ResolvedType._003Cdefault_003EasConstraintType(this);
	}


	public virtual ResolvedUnionType asUnionType()
	{
		return ResolvedType._003Cdefault_003EasUnionType(this);
	}


	public virtual ResolvedType replaceTypeVariables(ResolvedTypeParameterDeclaration P_0, ResolvedType P_1, Map P_2)
	{
		return ResolvedType._003Cdefault_003EreplaceTypeVariables(this, P_0, P_1, P_2);
	}


	public virtual ResolvedType replaceTypeVariables(ResolvedTypeParameterDeclaration P_0, ResolvedType P_1)
	{
		return ResolvedType._003Cdefault_003EreplaceTypeVariables(this, P_0, P_1);
	}


	public virtual bool mention(List P_0)
	{
		return ResolvedType._003Cdefault_003Emention(this, P_0);
	}


	public virtual bool isNumericType()
	{
		return ResolvedType._003Cdefault_003EisNumericType(this);
	}


	public virtual ResolvedType erasure()
	{
		return ResolvedType._003Cdefault_003Eerasure(this);
	}
}
