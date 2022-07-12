

using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.resolution.typeinference;

public abstract class ConstraintFormula
{
	public class ReductionResult
	{
		private BoundSet boundSet;

				private List constraintFormulas;

		
		
		private ReductionResult()
		{
			boundSet = BoundSet.empty();
			constraintFormulas = new LinkedList();
		}

		
		
		public static ReductionResult empty()
		{
			ReductionResult result = new ReductionResult();
			
			return result;
		}

		
		
		public virtual ReductionResult withBound(Bound bound)
		{
			ReductionResult reductionResult = new ReductionResult();
			reductionResult.boundSet = boundSet.withBound(bound);
			reductionResult.constraintFormulas = constraintFormulas;
			return reductionResult;
		}

		
		
		public virtual ReductionResult withConstraint(ConstraintFormula constraintFormula)
		{
			ReductionResult reductionResult = new ReductionResult();
			reductionResult.boundSet = boundSet;
			reductionResult.constraintFormulas = new LinkedList();
			reductionResult.constraintFormulas.addAll(constraintFormulas);
			reductionResult.constraintFormulas.add(constraintFormula);
			return reductionResult;
		}

		
				
		public static ReductionResult withConstraints(List constraints)
		{
			ReductionResult reductionResult = new ReductionResult();
			reductionResult.constraintFormulas.addAll(constraints);
			return reductionResult;
		}

		public virtual BoundSet getBoundSet()
		{
			return boundSet;
		}

				public virtual List getConstraintFormulas()
		{
			return constraintFormulas;
		}

		
		
		public static ReductionResult trueResult()
		{
			ReductionResult result = empty();
			
			return result;
		}

		
		
		public static ReductionResult falseResult()
		{
			ReductionResult result = empty().withBound(Bound.falseBound());
			
			return result;
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
			ReductionResult reductionResult = (ReductionResult)o;
			if (!boundSet.equals(reductionResult.boundSet))
			{
				return false;
			}
			bool result = constraintFormulas.equals(reductionResult.constraintFormulas);
			
			return result;
		}

		
		
		public override int GetHashCode()
		{
			int num = boundSet.GetHashCode();
			return 31 * num + constraintFormulas.GetHashCode();
		}

		
		
		public override string ToString()
		{
			string result = new StringBuilder().append("ReductionResult{boundSet=").append(boundSet).append(", constraintFormulas=")
				.append(constraintFormulas)
				.append('}')
				.ToString();
			
			return result;
		}

		
		
		public virtual ConstraintFormula getConstraint(int index)
		{
			if (constraintFormulas.size() <= index)
			{
				string s = new StringBuilder().append("Constraint with index ").append(index).append(" is not available as there are ")
					.append(constraintFormulas.size())
					.append(" constraints")
					.ToString();
				
				throw new IllegalArgumentException(s);
			}
			return (ConstraintFormula)constraintFormulas.get(index);
		}

		
		
		public static ReductionResult oneConstraint(ConstraintFormula constraintFormula)
		{
			ReductionResult result = empty().withConstraint(constraintFormula);
			
			return result;
		}

		
		
		public static ReductionResult withConstraints(params ConstraintFormula[] constraints)
		{
			ReductionResult result = withConstraints(Arrays.asList(constraints));
			
			return result;
		}

		
		
		public static ReductionResult oneBound(Bound bound)
		{
			ReductionResult result = empty().withBound(bound);
			
			return result;
		}

		
		
		public static ReductionResult bounds(BoundSet bounds)
		{
			ReductionResult reductionResult = new ReductionResult();
			reductionResult.boundSet = bounds;
			return reductionResult;
		}
	}

	
	
	public ConstraintFormula()
	{
	}

	public abstract ReductionResult reduce(BoundSet bs);
}
