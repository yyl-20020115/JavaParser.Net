
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;

using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.resolution.typeinference;

public class InferenceVariable: ResolvedType
{
	private static int unnamedInstantiated;

	private string name;

	private ResolvedTypeParameterDeclaration typeParameterDeclaration;

	
	
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
		InferenceVariable inferenceVariable = (InferenceVariable)o;
		if (!String.instancehelper_equals(name, inferenceVariable.name))
		{
			return false;
		}
		return (typeParameterDeclaration != null) ? Object.instancehelper_equals(typeParameterDeclaration, inferenceVariable.typeParameterDeclaration) : (inferenceVariable.typeParameterDeclaration == null);
	}

	
	
	public override int GetHashCode()
	{
		int num = String.instancehelper_hashCode(name);
		return 31 * num + ((typeParameterDeclaration != null) ? Object.instancehelper_hashCode(typeParameterDeclaration) : 0);
	}

	
	
	public virtual ResolvedTypeParameterDeclaration getTypeParameterDeclaration()
	{
		if (typeParameterDeclaration == null)
		{
			
			throw new IllegalStateException("The type parameter declaration was not specified");
		}
		return typeParameterDeclaration;
	}

	
	
	public static InferenceVariable unnamed(ResolvedTypeParameterDeclaration typeParameterDeclaration)
	{
		InferenceVariable result = new InferenceVariable(new StringBuilder().append("__unnamed__").append(unnamedInstantiated++).ToString(), typeParameterDeclaration);
		
		return result;
	}

	
	
	public InferenceVariable(string name, ResolvedTypeParameterDeclaration typeParameterDeclaration)
	{
		this.name = name;
		this.typeParameterDeclaration = typeParameterDeclaration;
	}

	
		
	public static List instantiate(List typeParameterDeclarations)
	{
		LinkedList linkedList = new LinkedList();
		Iterator iterator = typeParameterDeclarations.iterator();
		while (iterator.hasNext())
		{
			ResolvedTypeParameterDeclaration resolvedTypeParameterDeclaration = (ResolvedTypeParameterDeclaration)iterator.next();
			((List)linkedList).add((object)unnamed(resolvedTypeParameterDeclaration));
		}
		return linkedList;
	}

	public virtual bool isInferenceVariable()
	{
		return true;
	}

	public virtual string describe()
	{
		return name;
	}

	
	
	public virtual bool isAssignableBy(ResolvedType other)
	{
		if (Object.instancehelper_equals(other, this))
		{
			return true;
		}
		
		throw new UnsupportedOperationException("We are unable to determine the assignability of an inference variable without knowing the bounds and constraints");
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("InferenceVariable{name='").append(name).append('\'')
			.append(", typeParameterDeclaration=")
			.append(typeParameterDeclaration)
			.append('}')
			.ToString();
		
		return result;
	}

		public virtual bool mention(List typeParameters)
	{
		return false;
	}


	public virtual bool isArray()
	{
		return ResolvedType._003Cdefault_003EisArray(this);
	}


	public virtual int arrayLevel()
	{
		return ResolvedType._003Cdefault_003EarrayLevel(this);
	}


	public virtual bool isPrimitive()
	{
		return ResolvedType._003Cdefault_003EisPrimitive(this);
	}


	public virtual bool isNull()
	{
		return ResolvedType._003Cdefault_003EisNull(this);
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


	public virtual bool isReferenceType()
	{
		return ResolvedType._003Cdefault_003EisReferenceType(this);
	}


	public virtual bool isVoid()
	{
		return ResolvedType._003Cdefault_003EisVoid(this);
	}


	public virtual bool isTypeVariable()
	{
		return ResolvedType._003Cdefault_003EisTypeVariable(this);
	}


	public virtual bool isWildcard()
	{
		return ResolvedType._003Cdefault_003EisWildcard(this);
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


	public virtual bool isNumericType()
	{
		return ResolvedType._003Cdefault_003EisNumericType(this);
	}


	public virtual ResolvedType erasure()
	{
		return ResolvedType._003Cdefault_003Eerasure(this);
	}
}
