
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.type;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.javaparsermodel;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.model.typesystem;
using com.github.javaparser.symbolsolver.resolution.typeinference.bounds;
using com.github.javaparser.symbolsolver.resolution.typeinference.constraintformulas;

using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.symbolsolver.resolution.typeinference;

public class TypeInference
{
	
	private sealed class ___003C_003EAnon0 : Predicate
	{
		internal ___003C_003EAnon0()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024isImplicitlyTyped_00240((Parameter)P_0);
			
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

	
	private ResolvedType @object;

	private TypeSolver typeSolver;

	
	
	public TypeInference(TypeSolver typeSolver)
	{
		if (typeSolver == null)
		{
			
			throw new NullPointerException();
		}
		this.typeSolver = typeSolver;
		ReferenceTypeImpl.___003Cclinit_003E();
		@object = new ReferenceTypeImpl(typeSolver.getSolvedJavaLangObject(), typeSolver);
	}

	
	
	public virtual BoundSet invocationTypeInferenceBoundsSetB3()
	{
		
		throw new UnsupportedOperationException();
	}

	
		
	public virtual Optional instantiationInference(MethodCallExpr methodCallExpr, ResolvedMethodDeclaration methodDeclaration)
	{
		Optional result = instantiationInference(methodCallExpr.getArguments(), methodDeclaration);
		
		return result;
	}

	
	
	private static MethodUsage instantiationSetToMethodUsage(ResolvedMethodDeclaration P_0, InstantiationSet P_1)
	{
		if (P_1.isEmpty())
		{
			MethodUsage result = new MethodUsage(P_0);
			
			return result;
		}
		LinkedList linkedList = new LinkedList();
		for (int i = 0; i < P_0.getNumberOfParams(); i++)
		{
			((List)linkedList).add((object)P_1.apply(P_0.getParam(i).getType()));
		}
		ResolvedType returnType = P_1.apply(P_0.getReturnType());
		MethodUsage result2 = new MethodUsage(P_0, linkedList, returnType);
		
		return result2;
	}

	
		
	public virtual Optional instantiationInference(List argumentExpressions, ResolvedMethodDeclaration methodDeclaration)
	{
		List typeParameters = methodDeclaration.getTypeParameters();
		List list = InferenceVariable.instantiate(typeParameters);
		Substitution substitution = Substitution.empty();
		for (int i = 0; i < typeParameters.size(); i++)
		{
			substitution = substitution.withPair((ResolvedTypeParameterDeclaration)typeParameters.get(0), (ResolvedType)list.get(0));
		}
		BoundSet boundSet = boundSetup(typeParameters, list);
		BoundSet boundSet2 = boundSet;
		for (int j = 0; j < typeParameters.size(); j++)
		{
			ResolvedTypeParameterDeclaration resolvedTypeParameterDeclaration = (ResolvedTypeParameterDeclaration)typeParameters.get(j);
			if (appearInThrowsClause(resolvedTypeParameterDeclaration, methodDeclaration))
			{
				boundSet2 = boundSet2.withBound(new ThrowsBound((InferenceVariable)list.get(j)));
			}
		}
		List list2 = formalParameterTypes(methodDeclaration);
		Optional optional = Optional.empty();
		if (!optional.isPresent())
		{
			optional = testForApplicabilityByStrictInvocation(list2, argumentExpressions, substitution);
		}
		if (!optional.isPresent())
		{
			optional = testForApplicabilityByLooseInvocation(list2, argumentExpressions, substitution);
		}
		if (!optional.isPresent())
		{
			optional = testForApplicabilityByVariableArityInvocation(list2, argumentExpressions, substitution);
		}
		if (!optional.isPresent())
		{
			Optional result = Optional.empty();
			
			return result;
		}
		BoundSet otherBounds = ((ConstraintFormulaSet)optional.get()).reduce(typeSolver);
		BoundSet boundSet3 = boundSet2.incorporate(otherBounds, typeSolver);
		if (boundSet3.containsFalse())
		{
			Optional result2 = Optional.empty();
			
			return result2;
		}
		return boundSet3.performResolution(list, typeSolver);
	}

	
		
	private BoundSet boundSetup(List P_0, List P_1)
	{
		if (P_0.size() != P_1.size())
		{
			
			throw new IllegalArgumentException();
		}
		BoundSet boundSet = BoundSet.empty();
		for (int i = 0; i < P_0.size(); i++)
		{
			ResolvedTypeParameterDeclaration resolvedTypeParameterDeclaration = (ResolvedTypeParameterDeclaration)P_0.get(i);
			InferenceVariable inferenceVariable = (InferenceVariable)P_1.get(i);
			if (resolvedTypeParameterDeclaration.getBounds().isEmpty())
			{
				boundSet = boundSet.withBound(new SubtypeOfBound(inferenceVariable, @object));
				continue;
			}
			Iterator iterator = resolvedTypeParameterDeclaration.getBounds().iterator();
			while (iterator.hasNext())
			{
				ResolvedTypeParameterDeclaration.Bound bound = (ResolvedTypeParameterDeclaration.Bound)iterator.next();
				ResolvedType type = bound.getType();
				Substitution substitution = Substitution.empty();
				for (int j = 0; j < P_0.size(); j++)
				{
					substitution = substitution.withPair((ResolvedTypeParameterDeclaration)P_0.get(j), (ResolvedType)P_1.get(j));
				}
				ResolvedType t = substitution.apply(type);
				boundSet = boundSet.withBound(new SubtypeOfBound(inferenceVariable, t));
				if (boundSet.getProperUpperBoundsFor(inferenceVariable).isEmpty())
				{
					boundSet = boundSet.withBound(new SubtypeOfBound(inferenceVariable, @object));
				}
			}
		}
		return boundSet;
	}

	
	
	private bool appearInThrowsClause(ResolvedTypeParameterDeclaration P_0, ResolvedMethodDeclaration P_1)
	{
		for (int i = 0; i < P_1.getNumberOfSpecifiedExceptions(); i++)
		{
			ResolvedType specifiedException = P_1.getSpecifiedException(i);
			if (specifiedException.isTypeVariable() && Object.instancehelper_equals(specifiedException.asTypeVariable().asTypeParameter(), P_0))
			{
				return true;
			}
		}
		return false;
	}

	
		
	private List formalParameterTypes(ResolvedMethodDeclaration P_0)
	{
		LinkedList linkedList = new LinkedList();
		for (int i = 0; i < P_0.getNumberOfParams(); i++)
		{
			((List)linkedList).add((object)P_0.getParam(i).getType());
		}
		return linkedList;
	}

	
		
	private Optional testForApplicabilityByStrictInvocation(List P_0, List P_1, Substitution P_2)
	{
		int num = P_0.size();
		int num2 = P_1.size();
		if (num2 != num)
		{
			Optional result = Optional.empty();
			
			return result;
		}
		for (int i = 0; i < num; i++)
		{
			Expression expression = (Expression)P_1.get(i);
			ResolvedType resolvedType = (ResolvedType)P_0.get(i);
			if (isPertinentToApplicability(expression))
			{
				if (expression.isStandaloneExpression() && JavaParserFacade.get(typeSolver).getType(expression).isPrimitive() && resolvedType.isReferenceType())
				{
					Optional result2 = Optional.empty();
					
					return result2;
				}
				if (resolvedType.isPrimitive() && (!expression.isStandaloneExpression() || !JavaParserFacade.get(typeSolver).getType(expression).isPrimitive()))
				{
					Optional result3 = Optional.empty();
					
					return result3;
				}
			}
		}
		Optional result4 = Optional.of(constraintSetFromArgumentsSubstitution(P_0, P_1, P_2, num2));
		
		return result4;
	}

	
		
	private Optional testForApplicabilityByLooseInvocation(List P_0, List P_1, Substitution P_2)
	{
		int num = P_0.size();
		int num2 = P_1.size();
		if (num2 != num)
		{
			Optional result = Optional.empty();
			
			return result;
		}
		Optional result2 = Optional.of(constraintSetFromArgumentsSubstitution(P_0, P_1, P_2, num2));
		
		return result2;
	}

	
		
	private Optional testForApplicabilityByVariableArityInvocation(List P_0, List P_1, Substitution P_2)
	{
		int num = P_1.size();
		LinkedList linkedList = new LinkedList();
		for (int i = 0; i < num; i++)
		{
			ResolvedType e = ((i >= P_0.size()) ? ((ResolvedType)P_0.get(P_0.size() - 1)) : ((ResolvedType)P_0.get(i)));
			((List)linkedList).add((object)e);
		}
		Optional result = Optional.of(constraintSetFromArgumentsSubstitution(linkedList, P_1, P_2, num));
		
		return result;
	}

	
	
	private bool isImplicitlyTyped(LambdaExpr P_0)
	{
		bool result = P_0.getParameters().stream().anyMatch(new ___003C_003EAnon0());
		
		return result;
	}

	
	
	private bool isInexact(MethodReferenceExpr P_0)
	{
		
		throw new UnsupportedOperationException();
	}

	
	
	private bool isPertinentToApplicability(Expression P_0)
	{
		if (P_0 is LambdaExpr)
		{
			LambdaExpr lambdaExpr = (LambdaExpr)P_0;
			if (isImplicitlyTyped(lambdaExpr))
			{
				return false;
			}
		}
		if (P_0 is MethodReferenceExpr)
		{
			MethodReferenceExpr methodReferenceExpr = (MethodReferenceExpr)P_0;
			if (isInexact(methodReferenceExpr))
			{
				return false;
			}
		}
		if (P_0 is LambdaExpr)
		{
			
			throw new UnsupportedOperationException();
		}
		if (P_0 is MethodReferenceExpr)
		{
			
			throw new UnsupportedOperationException();
		}
		if (P_0 is LambdaExpr)
		{
			
			throw new UnsupportedOperationException();
		}
		if (P_0 is LambdaExpr)
		{
			
			throw new UnsupportedOperationException();
		}
		if (P_0 is EnclosedExpr)
		{
			EnclosedExpr enclosedExpr = (EnclosedExpr)P_0;
			bool result = isPertinentToApplicability(enclosedExpr.getInner());
			
			return result;
		}
		if (P_0 is ConditionalExpr)
		{
			ConditionalExpr conditionalExpr = (ConditionalExpr)P_0;
			return (isPertinentToApplicability(conditionalExpr.getThenExpr()) && isPertinentToApplicability(conditionalExpr.getElseExpr())) ? true : false;
		}
		return true;
	}

	
		
	private ConstraintFormulaSet constraintSetFromArgumentsSubstitution(List P_0, List P_1, Substitution P_2, int P_3)
	{
		ConstraintFormulaSet constraintFormulaSet = ConstraintFormulaSet.empty();
		for (int i = 0; i < P_3; i++)
		{
			Expression expression = (Expression)P_1.get(i);
			ResolvedType resolvedType = (ResolvedType)P_0.get(i);
			ResolvedType t = typeWithSubstitution(resolvedType, P_2);
			constraintFormulaSet = constraintFormulaSet.withConstraint(new ExpressionCompatibleWithType(typeSolver, expression, t));
		}
		return constraintFormulaSet;
	}

	
	
	private ResolvedType typeWithSubstitution(ResolvedType P_0, Substitution P_1)
	{
		ResolvedType result = P_1.apply(P_0);
		
		return result;
	}

	
	
	
	private static bool lambda_0024isImplicitlyTyped_00240(Parameter P_0)
	{
		return P_0.getType() is UnknownType;
	}

	
	
	public static MethodUsage toMethodUsage(MethodCallExpr call, ResolvedMethodDeclaration methodDeclaration, TypeSolver typeSolver)
	{
		TypeInference typeInference = new TypeInference(typeSolver);
		Optional optional = typeInference.instantiationInference(call, methodDeclaration);
		if (optional.isPresent())
		{
			MethodUsage result = instantiationSetToMethodUsage(methodDeclaration, (InstantiationSet)optional.get());
			
			return result;
		}
		
		throw new IllegalArgumentException();
	}

	
	
	public virtual bool invocationApplicabilityInference(MethodCallExpr methodCallExpr, ResolvedMethodDeclaration methodDeclaration)
	{
		if (!String.instancehelper_equals(methodCallExpr.getNameAsString(), methodDeclaration.getName()))
		{
			
			throw new IllegalArgumentException();
		}
		Optional optional = instantiationInference(methodCallExpr, methodDeclaration);
		if (!optional.isPresent())
		{
			return false;
		}
		int num = methodCallExpr.getArguments().size();
		int numberOfParams = methodDeclaration.getNumberOfParams();
		if (num != numberOfParams)
		{
			if (!methodDeclaration.hasVariadicParameter())
			{
				return false;
			}
			if (num < numberOfParams - 1)
			{
				return false;
			}
		}
		return true;
	}

	
	
	public virtual void invocationTypeInference()
	{
		invocationTypeInferenceBoundsSetB3();
		
		throw new UnsupportedOperationException();
	}

	
	
	public virtual void functionalInterfaceParameterizationInference(LambdaExpr lambdaExpr, ResolvedInterfaceDeclaration interfaceDeclaration)
	{
		int num = lambdaExpr.getParameters().size();
		if (interfaceDeclaration.getTypeParameters().isEmpty())
		{
			
			throw new IllegalArgumentException("Functional Interface without type arguments");
		}
		int num2 = interfaceDeclaration.getTypeParameters().size();
		List inferenceVariables = InferenceVariable.instantiate(interfaceDeclaration.getTypeParameters());
		TypeInferenceCache.recordInferenceVariables(typeSolver, lambdaExpr, inferenceVariables);
		if (num != num2)
		{
			string s = new StringBuilder().append("No valida parameterization can exist has n= and k=").append(num2).ToString();
			
			throw new IllegalArgumentException(s);
		}
		ConstraintFormulaSet constraintFormulaSet = ConstraintFormulaSet.empty();
		int num3 = 0;
		if (num3 < num)
		{
			
			throw new UnsupportedOperationException();
		}
		constraintFormulaSet.reduce(typeSolver);
		
		throw new UnsupportedOperationException();
	}

	
	
	public virtual bool moreSpecificMethodInference(MethodCallExpr methodCall, ResolvedMethodDeclaration m1, ResolvedMethodDeclaration m2)
	{
		if (!m2.isGeneric())
		{
			string s = new StringBuilder().append("M2 is not generic (m2: ").append(m2).append(")")
				.ToString();
			
			throw new IllegalArgumentException(s);
		}
		
		throw new UnsupportedOperationException();
	}
}
