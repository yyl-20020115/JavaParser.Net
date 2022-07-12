
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.type;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.javaparsermodel;
using com.github.javaparser.symbolsolver.logic;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.utils;

using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.symbolsolver.resolution.typeinference.constraintformulas;

public class ExpressionCompatibleWithType : ConstraintFormula
{
	
	private sealed class ___003C_003EAnon0 : Predicate
	{
		internal ___003C_003EAnon0()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024reduce_00240((Parameter)P_0);
			
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

	
	private sealed class ___003C_003EAnon1 : Consumer
	{
		private readonly ExpressionCompatibleWithType arg_00241;

		private readonly List arg_00242;

		private readonly ResolvedType arg_00243;

		internal ___003C_003EAnon1(ExpressionCompatibleWithType P_0, List P_1, ResolvedType P_2)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024reduce_00241(arg_00242, arg_00243, (Expression)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon2 : Predicate
	{
		internal ___003C_003EAnon2()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024getAllReturnExpressions_00242((ReturnStmt)P_0);
			
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

	
	private sealed class ___003C_003EAnon3 : Function
	{
		internal ___003C_003EAnon3()
		{
		}

		public object apply(object P_0)
		{
			Expression result = lambda_0024getAllReturnExpressions_00243((ReturnStmt)P_0);
			
			return result;
		}

		
		public Function compose(Function P_0)
		{
			return Function._003Cdefault_003Ecompose(this, P_0);
		}

		
		public Function andThen(Function P_0)
		{
			return Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon4 : Predicate
	{
		internal ___003C_003EAnon4()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024isValueCompatibleBlock_00244((ReturnStmt)P_0);
			
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

	private TypeSolver typeSolver;

	private Expression expression;

	private ResolvedType T;

	
	
	public ExpressionCompatibleWithType(TypeSolver typeSolver, Expression expression, ResolvedType T)
	{
		this.typeSolver = typeSolver;
		this.expression = expression;
		this.T = T;
	}

	
	
	private MethodType replaceTypeVariablesWithInferenceVariables(MethodType P_0)
	{
		HashMap hashMap = new HashMap();
		LinkedList linkedList = new LinkedList();
		Iterator iterator = P_0.getFormalArgumentTypes().iterator();
		while (iterator.hasNext())
		{
			ResolvedType resolvedType = (ResolvedType)iterator.next();
			((List)linkedList).add((object)replaceTypeVariablesWithInferenceVariables(resolvedType, hashMap));
		}
		ResolvedType returnType = replaceTypeVariablesWithInferenceVariables(P_0.getReturnType(), hashMap);
		MethodType result = new MethodType(P_0.getTypeParameters(), linkedList, returnType, P_0.getExceptionTypes());
		
		return result;
	}

	
	
	private bool isValueCompatibleBlock(Statement P_0)
	{
		if (P_0 is BlockStmt)
		{
			if (!ControlFlowLogic.getInstance().canCompleteNormally(P_0))
			{
				return true;
			}
			List list = P_0.findAll(ClassLiteral<ReturnStmt>.Value);
			bool result = list.stream().allMatch(new ___003C_003EAnon4());
			
			return result;
		}
		return false;
	}

	
		
	private List getAllReturnExpressions(BlockStmt P_0)
	{
		return (List)P_0.findAll(ClassLiteral<ReturnStmt>.Value).stream().filter(new ___003C_003EAnon2())
			.map(new ___003C_003EAnon3())
			.collect(Collectors.toList());
	}

	
		
	private ResolvedType replaceTypeVariablesWithInferenceVariables(ResolvedType P_0, Map P_1)
	{
		if (P_0.isTypeVariable())
		{
			if (!P_1.containsKey(P_0.asTypeVariable()))
			{
				P_1.put(P_0.asTypeVariable(), InferenceVariable.unnamed(P_0.asTypeVariable().asTypeParameter()));
			}
			return (ResolvedType)P_1.get(P_0.asTypeVariable());
		}
		if (P_0.isPrimitive())
		{
			return P_0;
		}
		string message = Object.instancehelper_toString(P_0);
		
		throw new UnsupportedOperationException(message);
	}

	
	
	
	private static bool lambda_0024reduce_00240(Parameter P_0)
	{
		return !(P_0.getType() is UnknownType);
	}

	
	
	
	private void lambda_0024reduce_00241(List P_0, ResolvedType P_1, Expression P_2)
	{
		P_0.add(new ExpressionCompatibleWithType(typeSolver, P_2, P_1));
	}

	
	
	
	private static bool lambda_0024getAllReturnExpressions_00242(ReturnStmt P_0)
	{
		bool result = P_0.getExpression().isPresent();
		
		return result;
	}

	
	
	
	private static Expression lambda_0024getAllReturnExpressions_00243(ReturnStmt P_0)
	{
		return (Expression)P_0.getExpression().get();
	}

	
	
	
	private static bool lambda_0024isValueCompatibleBlock_00244(ReturnStmt P_0)
	{
		bool result = P_0.getExpression().isPresent();
		
		return result;
	}

	
	
	public override ReductionResult reduce(BoundSet currentBoundSet)
	{
		if (TypeHelper.isProperType(T))
		{
			if (TypeHelper.isCompatibleInALooseInvocationContext(typeSolver, this.expression, T))
			{
				ReductionResult result = ReductionResult.trueResult();
				
				return result;
			}
			ReductionResult result2 = ReductionResult.falseResult();
			
			return result2;
		}
		if (this.expression.isStandaloneExpression())
		{
			ResolvedType type = JavaParserFacade.get(typeSolver).getType(this.expression, solveLambdas: false);
			ReductionResult result3 = ReductionResult.empty().withConstraint(new TypeCompatibleWithType(typeSolver, type, T));
			
			return result3;
		}
		if (this.expression.isPolyExpression())
		{
			if (this.expression is EnclosedExpr)
			{
				EnclosedExpr enclosedExpr = (EnclosedExpr)this.expression;
				ReductionResult result4 = ReductionResult.oneConstraint(new ExpressionCompatibleWithType(typeSolver, enclosedExpr.getInner(), T));
				
				return result4;
			}
			if (this.expression is ObjectCreationExpr)
			{
				BoundSet bounds = new TypeInference(typeSolver).invocationTypeInferenceBoundsSetB3();
				ReductionResult result5 = ReductionResult.bounds(bounds);
				
				return result5;
			}
			if (this.expression is MethodCallExpr)
			{
				
				throw new UnsupportedOperationException();
			}
			if (this.expression is ConditionalExpr)
			{
				ConditionalExpr conditionalExpr = (ConditionalExpr)this.expression;
				ReductionResult result6 = ReductionResult.withConstraints(new ExpressionCompatibleWithType(typeSolver, conditionalExpr.getThenExpr(), T), new ExpressionCompatibleWithType(typeSolver, conditionalExpr.getElseExpr(), T));
				
				return result6;
			}
			if (this.expression is LambdaExpr)
			{
				LambdaExpr lambdaExpr = (LambdaExpr)this.expression;
				if (!FunctionalInterfaceLogic.isFunctionalInterfaceType(T))
				{
					ReductionResult result7 = ReductionResult.falseResult();
					
					return result7;
				}
				Pair pair = TypeHelper.groundTargetTypeOfLambda(lambdaExpr, T, typeSolver);
				ResolvedType type2 = (ResolvedType)pair.___003C_003Ea;
				MethodType functionType = TypeHelper.getFunctionType(type2);
				functionType = replaceTypeVariablesWithInferenceVariables(functionType);
				if (((Boolean)pair.___003C_003Eb).booleanValue())
				{
					
					throw new UnsupportedOperationException();
				}
				if (functionType.getFormalArgumentTypes().size() != lambdaExpr.getParameters().size())
				{
					ReductionResult result8 = ReductionResult.falseResult();
					
					return result8;
				}
				if (functionType.getReturnType().isVoid())
				{
					
					throw new UnsupportedOperationException();
				}
				if (!functionType.getReturnType().isVoid() && lambdaExpr.getBody() is BlockStmt && !isValueCompatibleBlock(lambdaExpr.getBody()))
				{
					ReductionResult result9 = ReductionResult.falseResult();
					
					return result9;
				}
				LinkedList linkedList = new LinkedList();
				if (lambdaExpr.getParameters().stream().anyMatch(new ___003C_003EAnon0()))
				{
					
					throw new UnsupportedOperationException();
				}
				if (!functionType.getReturnType().isVoid())
				{
					ResolvedType returnType = functionType.getReturnType();
					if (TypeHelper.isProperType(returnType))
					{
						if (lambdaExpr.getBody() is BlockStmt)
						{
							List resultExpressions = ExpressionHelper.getResultExpressions((BlockStmt)lambdaExpr.getBody());
							Iterator iterator = resultExpressions.iterator();
							while (iterator.hasNext())
							{
								Expression expression = (Expression)iterator.next();
								if (!ExpressionHelper.isCompatibleInAssignmentContext(expression, returnType, typeSolver))
								{
									ReductionResult result10 = ReductionResult.falseResult();
									
									return result10;
								}
							}
						}
						else
						{
							Expression expression2 = ((ExpressionStmt)lambdaExpr.getBody()).getExpression();
							if (!ExpressionHelper.isCompatibleInAssignmentContext(expression2, returnType, typeSolver))
							{
								ReductionResult result11 = ReductionResult.falseResult();
								
								return result11;
							}
						}
					}
					else if (lambdaExpr.getBody() is BlockStmt)
					{
						getAllReturnExpressions((BlockStmt)lambdaExpr.getBody()).forEach(new ___003C_003EAnon1(this, linkedList, returnType));
					}
					else
					{
						for (int i = 0; i < lambdaExpr.getParameters().size(); i++)
						{
							ResolvedType type3 = (ResolvedType)functionType.getFormalArgumentTypes().get(i);
							TypeInferenceCache.addRecord(typeSolver, lambdaExpr, lambdaExpr.getParameter(i).getNameAsString(), type3);
						}
						Expression expression2 = ((ExpressionStmt)lambdaExpr.getBody()).getExpression();
						((List)linkedList).add((object)new ExpressionCompatibleWithType(typeSolver, expression2, returnType));
					}
				}
				ReductionResult result12 = ReductionResult.withConstraints(linkedList);
				
				return result12;
			}
			if (this.expression is MethodReferenceExpr)
			{
				
				throw new UnsupportedOperationException();
			}
			
			throw new RuntimeException("This should not happen");
		}
		
		throw new RuntimeException("This should not happen");
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
		ExpressionCompatibleWithType expressionCompatibleWithType = (ExpressionCompatibleWithType)o;
		if (!Object.instancehelper_equals(typeSolver, expressionCompatibleWithType.typeSolver))
		{
			return false;
		}
		if (!expression.equals(expressionCompatibleWithType.expression))
		{
			return false;
		}
		bool result = Object.instancehelper_equals(T, expressionCompatibleWithType.T);
		
		return result;
	}

	
	
	public override int GetHashCode()
	{
		int num = Object.instancehelper_hashCode(typeSolver);
		num = 31 * num + expression.GetHashCode();
		return 31 * num + Object.instancehelper_hashCode(T);
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("ExpressionCompatibleWithType{typeSolver=").append(typeSolver).append(", expression=")
			.append(expression)
			.append(", T=")
			.append(T)
			.append('}')
			.ToString();
		
		return result;
	}
}
