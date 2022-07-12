
using com.github.javaparser.symbolsolver.model.resolution;

using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.resolution.typeinference;

public class ConstraintFormulaSet
{
		private List constraintFormulas;

	
	private static ConstraintFormulaSet EMPTY;

	
	
	public static void ___003Cclinit_003E()
	{
	}

	public static ConstraintFormulaSet empty()
	{
		return EMPTY;
	}

	
	
	public virtual bool isEmpty()
	{
		bool result = constraintFormulas.isEmpty();
		
		return result;
	}

	
	
	public virtual BoundSet reduce(TypeSolver typeSolver)
	{
		LinkedList linkedList = new LinkedList(constraintFormulas);
		BoundSet boundSet = BoundSet.empty();
		while (((List)linkedList).size() > 0)
		{
			ConstraintFormula constraintFormula = (ConstraintFormula)((List)linkedList).remove(0);
			ConstraintFormula.ReductionResult reductionResult = constraintFormula.reduce(boundSet);
			((List)linkedList).addAll((Collection)reductionResult.getConstraintFormulas());
			boundSet.incorporate(reductionResult.getBoundSet(), typeSolver);
		}
		return boundSet;
	}

	
	
	public virtual ConstraintFormulaSet withConstraint(ConstraintFormula constraintFormula)
	{
		ConstraintFormulaSet constraintFormulaSet = new ConstraintFormulaSet();
		constraintFormulaSet.constraintFormulas.addAll(constraintFormulas);
		constraintFormulaSet.constraintFormulas.add(constraintFormula);
		return constraintFormulaSet;
	}

	
	
	private ConstraintFormulaSet()
	{
		constraintFormulas = new LinkedList();
	}

	
	static ConstraintFormulaSet()
	{
		EMPTY = new ConstraintFormulaSet();
	}
}
