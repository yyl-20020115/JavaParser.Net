
using com.github.javaparser.ast.expr;
using com.github.javaparser.resolution.types;

using java.lang;

namespace com.github.javaparser.symbolsolver.resolution.typeinference.constraintformulas;

public class LambdaThrowsCompatibleWithType : ConstraintFormula
{
	private LambdaExpr lambdaExpression;

	private ResolvedType T;

	
	
	public LambdaThrowsCompatibleWithType()
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
		LambdaThrowsCompatibleWithType lambdaThrowsCompatibleWithType = (LambdaThrowsCompatibleWithType)o;
		if (!lambdaExpression.equals(lambdaThrowsCompatibleWithType.lambdaExpression))
		{
			return false;
		}
		bool result = Object.instancehelper_equals(T, lambdaThrowsCompatibleWithType.T);
		
		return result;
	}

	
	
	public override int GetHashCode()
	{
		int num = lambdaExpression.GetHashCode();
		return 31 * num + Object.instancehelper_hashCode(T);
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("LambdaThrowsCompatibleWithType{lambdaExpression=").append(lambdaExpression).append(", T=")
			.append(T)
			.append('}')
			.ToString();
		
		return result;
	}
}
