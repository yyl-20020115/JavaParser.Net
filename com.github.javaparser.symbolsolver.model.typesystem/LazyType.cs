
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;

using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.symbolsolver.model.typesystem;

public class LazyType: ResolvedType
{
	private ResolvedType concrete;

		private Function provider;

	
		
	public LazyType(Function provider)
	{
		this.provider = provider;
	}

	
	
	private ResolvedType getType()
	{
		if (concrete == null)
		{
			concrete = (ResolvedType)provider.apply(null);
		}
		return concrete;
	}

	
	
	public virtual bool isArray()
	{
		bool result = getType().isArray();
		
		return result;
	}

	
	
	public virtual int arrayLevel()
	{
		int result = getType().arrayLevel();
		
		return result;
	}

	
	
	public virtual bool isPrimitive()
	{
		bool result = getType().isPrimitive();
		
		return result;
	}

	
	
	public virtual bool isNull()
	{
		bool result = getType().isNull();
		
		return result;
	}

	
	
	public virtual bool isReference()
	{
		bool result = getType().isReference();
		
		return result;
	}

	
	
	public virtual bool isReferenceType()
	{
		bool result = getType().isReferenceType();
		
		return result;
	}

	
	
	public virtual bool isVoid()
	{
		bool result = getType().isVoid();
		
		return result;
	}

	
	
	public virtual bool isTypeVariable()
	{
		bool result = getType().isTypeVariable();
		
		return result;
	}

	
	
	public virtual bool isWildcard()
	{
		bool result = getType().isWildcard();
		
		return result;
	}

	
	
	public virtual ResolvedArrayType asArrayType()
	{
		ResolvedArrayType result = getType().asArrayType();
		
		return result;
	}

	
	
	public virtual ResolvedReferenceType asReferenceType()
	{
		ResolvedReferenceType result = getType().asReferenceType();
		
		return result;
	}

	
	
	public virtual ResolvedTypeParameterDeclaration asTypeParameter()
	{
		ResolvedTypeParameterDeclaration result = getType().asTypeParameter();
		
		return result;
	}

	
	
	public virtual ResolvedTypeVariable asTypeVariable()
	{
		ResolvedTypeVariable result = getType().asTypeVariable();
		
		return result;
	}

	
	
	public virtual ResolvedPrimitiveType asPrimitive()
	{
		ResolvedPrimitiveType result = getType().asPrimitive();
		
		return result;
	}

	
	
	public virtual ResolvedWildcard asWildcard()
	{
		ResolvedWildcard result = getType().asWildcard();
		
		return result;
	}

	
	
	public virtual string describe()
	{
		string result = getType().describe();
		
		return result;
	}

	
		
	public virtual ResolvedType replaceTypeVariables(ResolvedTypeParameterDeclaration tp, ResolvedType replaced, Map inferredTypes)
	{
		ResolvedType result = getType().replaceTypeVariables(tp, replaced, inferredTypes);
		
		return result;
	}

	
	
	public virtual ResolvedType replaceTypeVariables(ResolvedTypeParameterDeclaration tp, ResolvedType replaced)
	{
		ResolvedType result = getType().replaceTypeVariables(tp, replaced);
		
		return result;
	}

	
	
	public virtual bool isAssignableBy(ResolvedType other)
	{
		bool result = getType().isAssignableBy(other);
		
		return result;
	}


	public virtual bool isUnionType()
	{
		return ResolvedType._003Cdefault_003EisUnionType(this);
	}


	public virtual bool isConstraint()
	{
		return ResolvedType._003Cdefault_003EisConstraint(this);
	}


	public virtual bool isInferenceVariable()
	{
		return ResolvedType._003Cdefault_003EisInferenceVariable(this);
	}


	public virtual ResolvedLambdaConstraintType asConstraintType()
	{
		return ResolvedType._003Cdefault_003EasConstraintType(this);
	}


	public virtual ResolvedUnionType asUnionType()
	{
		return ResolvedType._003Cdefault_003EasUnionType(this);
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
