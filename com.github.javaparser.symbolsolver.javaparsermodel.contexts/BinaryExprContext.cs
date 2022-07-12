
using com.github.javaparser.ast;
using com.github.javaparser.ast.expr;
using com.github.javaparser.symbolsolver.core.resolution;
using com.github.javaparser.symbolsolver.model.resolution;

using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.symbolsolver.javaparsermodel.contexts;

public class BinaryExprContext : AbstractJavaParserContext
{
	
	private sealed class ___003C_003EAnon0 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon0(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024patternExprInScope_00240(arg_00241, (PatternExpr)P_0);
			
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

	
		
	private List patternExprsExposedToDirectParentFromBranch(Expression P_0)
	{
		if (P_0.isEnclosedExpr() || P_0.isBinaryExpr() || P_0.isUnaryExpr() || P_0.isInstanceOfExpr())
		{
			Context context = JavaParserFactory.getContext(P_0, typeSolver);
			List result = context.patternExprsExposedFromChildren();
			
			return result;
		}
		ArrayList result2 = new ArrayList();
		
		return result2;
	}

	
	
	private bool isDefinitivelyTrue(Expression P_0)
	{
		if (P_0.isBooleanLiteralExpr() && P_0.asBooleanLiteralExpr().getValue())
		{
			return true;
		}
		return false;
	}

	
		
	private List negatedPatternExprsExposedToDirectParentFromBranch(Expression P_0)
	{
		if (P_0.isEnclosedExpr() || P_0.isBinaryExpr() || P_0.isUnaryExpr() || P_0.isInstanceOfExpr())
		{
			Context context = JavaParserFactory.getContext(P_0, typeSolver);
			List result = context.negatedPatternExprsExposedFromChildren();
			
			return result;
		}
		ArrayList result2 = new ArrayList();
		
		return result2;
	}

	
	
	
	private static bool lambda_0024patternExprInScope_00240(string P_0, PatternExpr P_1)
	{
		bool result = String.instancehelper_equals(P_1.getNameAsString(), P_0);
		
		return result;
	}

	
	
	public BinaryExprContext(BinaryExpr wrappedNode, TypeSolver typeSolver)
		: base(wrappedNode, typeSolver)
	{
	}

	
		
	public override List patternExprsExposedFromChildren()
	{
		BinaryExpr binaryExpr = (BinaryExpr)wrappedNode;
		Expression left = binaryExpr.getLeft();
		Expression right = binaryExpr.getRight();
		ArrayList arrayList = new ArrayList();
		if (binaryExpr.getOperator().equals(BinaryExpr.Operator.___003C_003EEQUALS))
		{
			if (right.isBooleanLiteralExpr())
			{
				if (right.asBooleanLiteralExpr().getValue())
				{
					((List)arrayList).addAll((Collection)patternExprsExposedToDirectParentFromBranch(left));
				}
			}
			else if (left.isBooleanLiteralExpr() && left.asBooleanLiteralExpr().getValue())
			{
				((List)arrayList).addAll((Collection)patternExprsExposedToDirectParentFromBranch(right));
			}
		}
		else if (binaryExpr.getOperator().equals(BinaryExpr.Operator.___003C_003ENOT_EQUALS))
		{
			if (right.isBooleanLiteralExpr())
			{
				if (!right.asBooleanLiteralExpr().getValue())
				{
					((List)arrayList).addAll((Collection)patternExprsExposedToDirectParentFromBranch(left));
				}
			}
			else if (left.isBooleanLiteralExpr() && !left.asBooleanLiteralExpr().getValue())
			{
				((List)arrayList).addAll((Collection)patternExprsExposedToDirectParentFromBranch(right));
			}
		}
		else
		{
			if (!binaryExpr.getOperator().equals(BinaryExpr.Operator.___003C_003EAND))
			{
				ArrayList result = new ArrayList();
				
				return result;
			}
			((List)arrayList).addAll((Collection)patternExprsExposedToDirectParentFromBranch(left));
			((List)arrayList).addAll((Collection)patternExprsExposedToDirectParentFromBranch(right));
		}
		return arrayList;
	}

	
		
	public override List negatedPatternExprsExposedFromChildren()
	{
		BinaryExpr binaryExpr = (BinaryExpr)wrappedNode;
		Expression left = binaryExpr.getLeft();
		Expression right = binaryExpr.getRight();
		ArrayList arrayList = new ArrayList();
		if (binaryExpr.getOperator().equals(BinaryExpr.Operator.___003C_003EEQUALS))
		{
			if (right.isBooleanLiteralExpr())
			{
				if (!isDefinitivelyTrue(right))
				{
					((List)arrayList).addAll((Collection)patternExprsExposedToDirectParentFromBranch(left));
				}
			}
			else if (left.isBooleanLiteralExpr() && !isDefinitivelyTrue(left))
			{
				((List)arrayList).addAll((Collection)patternExprsExposedToDirectParentFromBranch(right));
			}
		}
		else if (binaryExpr.getOperator().equals(BinaryExpr.Operator.___003C_003ENOT_EQUALS))
		{
			if (right.isBooleanLiteralExpr())
			{
				if (isDefinitivelyTrue(right))
				{
					((List)arrayList).addAll((Collection)patternExprsExposedToDirectParentFromBranch(left));
				}
			}
			else if (left.isBooleanLiteralExpr() && isDefinitivelyTrue(left))
			{
				((List)arrayList).addAll((Collection)patternExprsExposedToDirectParentFromBranch(right));
			}
		}
		else
		{
			if (!binaryExpr.getOperator().equals(BinaryExpr.Operator.___003C_003EAND))
			{
				ArrayList result = new ArrayList();
				
				return result;
			}
			((List)arrayList).addAll((Collection)negatedPatternExprsExposedToDirectParentFromBranch(left));
			((List)arrayList).addAll((Collection)negatedPatternExprsExposedToDirectParentFromBranch(right));
		}
		return arrayList;
	}

	
		
	public override List patternExprsExposedToChild(Node child)
	{
		BinaryExpr binaryExpr = (BinaryExpr)wrappedNode;
		Expression left = binaryExpr.getLeft();
		Expression right = binaryExpr.getRight();
		ArrayList arrayList = new ArrayList();
		if (child == left)
		{
			((List)arrayList).addAll((Collection)patternExprsExposedToDirectParentFromBranch(left));
		}
		else if (child == right && binaryExpr.getOperator().equals(BinaryExpr.Operator.___003C_003EAND))
		{
			((List)arrayList).addAll((Collection)patternExprsExposedToDirectParentFromBranch(left));
		}
		return arrayList;
	}

	
		
	public override Optional patternExprInScope(string name)
	{
		BinaryExpr binaryExpr = (BinaryExpr)wrappedNode;
		Expression left = binaryExpr.getLeft();
		binaryExpr.getRight();
		List list = patternExprsExposedToDirectParentFromBranch(left);
		Optional optional = list.stream().filter(new ___003C_003EAnon0(name)).findFirst();
		if (optional.isPresent())
		{
			return optional;
		}
		if (!getParent().isPresent())
		{
			Optional result = Optional.empty();
			
			return result;
		}
		Context context = (Context)getParent().get();
		Optional result2 = context.patternExprInScope(name);
		
		return result2;
	}

	
	
	private bool isDefinitivelyFalse(Expression P_0)
	{
		if (P_0.isBooleanLiteralExpr() && !P_0.asBooleanLiteralExpr().getValue())
		{
			return true;
		}
		return false;
	}
}
