using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using com.github.javaparser.resolution.types;
using IKVM.Attributes;
using java.lang;

namespace com.github.javaparser.symbolsolver.resolution.typeinference.constraintformulas;

public class MethodReferenceThrowsCompatibleWithType : ConstraintFormula
{
	private MethodReferenceExpr methodReference;

	private ResolvedType T;

	
	
	public MethodReferenceThrowsCompatibleWithType()
	{
	}

	
	
	public override ReductionResult reduce(BoundSet currentBoundSet)
	{
		
		throw new UnsupportedOperationException();
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
		MethodReferenceThrowsCompatibleWithType methodReferenceThrowsCompatibleWithType = (MethodReferenceThrowsCompatibleWithType)o;
		if (!methodReference.equals(methodReferenceThrowsCompatibleWithType.methodReference))
		{
			return false;
		}
		bool result = Object.instancehelper_equals(T, methodReferenceThrowsCompatibleWithType.T);
		
		return result;
	}

	
	
	public override int GetHashCode()
	{
		int num = methodReference.GetHashCode();
		return 31 * num + Object.instancehelper_hashCode(T);
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("MethodReferenceThrowsCompatibleWithType{methodReference=").append(methodReference).append(", T=")
			.append(T)
			.append('}')
			.ToString();
		
		return result;
	}
}
