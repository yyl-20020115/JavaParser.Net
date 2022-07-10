using System.Runtime.CompilerServices;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.type;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.javaparsermodel;
using com.github.javaparser.symbolsolver.model.resolution;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.symbolsolver.resolution.typeinference;

public class ExpressionHelper
{
	
	private sealed class ___003C_003EAnon0 : Predicate
	{
		internal ___003C_003EAnon0()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024isExplicitlyTyped_00240((Parameter)P_0);
			
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

	
		
	public static List getResultExpressions(BlockStmt blockStmt)
	{
		
		throw new UnsupportedOperationException();
	}

	
	
	public static bool isCompatibleInAssignmentContext(Expression expression, ResolvedType type, TypeSolver typeSolver)
	{
		bool result = type.isAssignableBy(JavaParserFacade.get(typeSolver).getType(expression, solveLambdas: false));
		
		return result;
	}

	
	
	
	private static bool lambda_0024isExplicitlyTyped_00240(Parameter P_0)
	{
		return !(P_0.getType() is UnknownType);
	}

	
	
	public ExpressionHelper()
	{
	}

	
	
	public static bool isExplicitlyTyped(LambdaExpr lambdaExpr)
	{
		bool result = lambdaExpr.getParameters().stream().allMatch(new ___003C_003EAnon0());
		
		return result;
	}
}
