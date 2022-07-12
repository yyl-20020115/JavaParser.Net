
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.model.typesystem;
using com.github.javaparser.symbolsolver.resolution.typeinference.bounds;
using com.github.javaparser.symbolsolver.resolution.typeinference.constraintformulas;
using com.github.javaparser.utils;

using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.symbolsolver.resolution.typeinference;

public class BoundSet
{
		internal interface Processor
	{
				virtual object process(Bound P_0, Bound P_1, object P_2);
	}

	[InnerClass(null, Modifiers.Private)]
	internal class VariableDependency
	{
		private InferenceVariable depending;

		private InferenceVariable dependedOn;

		
		internal BoundSet this_00240;

		
		
		internal static InferenceVariable access_0024100(VariableDependency P_0)
		{
			return P_0.dependedOn;
		}

		
		
		internal static InferenceVariable access_0024000(VariableDependency P_0)
		{
			return P_0.depending;
		}

		public virtual InferenceVariable getDepending()
		{
			return depending;
		}

		public virtual InferenceVariable getDependedOn()
		{
			return dependedOn;
		}

		
		
		public VariableDependency(BoundSet P_0, InferenceVariable P_1, InferenceVariable P_2)
		{
			this_00240 = P_0;
			
			depending = P_1;
			dependedOn = P_2;
		}

		
		
		public virtual bool isReflexive()
		{
			bool result = dependedOn.equals(depending);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon0 : Processor
	{
		private readonly BoundSet arg_00241;

		internal ___003C_003EAnon0(BoundSet P_0)
		{
			arg_00241 = P_0;
		}

		public object process(Bound P_0, Bound P_1, object P_2)
		{
			ConstraintFormulaSet result = arg_00241.lambda_0024deriveImpliedBounds_00240((SameAsBound)P_0, (SameAsBound)P_1, (ConstraintFormulaSet)P_2);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon1 : Processor
	{
		private readonly BoundSet arg_00241;

		private readonly TypeSolver arg_00242;

		internal ___003C_003EAnon1(BoundSet P_0, TypeSolver P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object process(Bound P_0, Bound P_1, object P_2)
		{
			ConstraintFormulaSet result = arg_00241.lambda_0024deriveImpliedBounds_00241(arg_00242, (SameAsBound)P_0, (SubtypeOfBound)P_1, (ConstraintFormulaSet)P_2);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon2 : Processor
	{
		private readonly BoundSet arg_00241;

		private readonly TypeSolver arg_00242;

		internal ___003C_003EAnon2(BoundSet P_0, TypeSolver P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object process(Bound P_0, Bound P_1, object P_2)
		{
			ConstraintFormulaSet result = arg_00241.lambda_0024deriveImpliedBounds_00242(arg_00242, (SameAsBound)P_0, (SubtypeOfBound)P_1, (ConstraintFormulaSet)P_2);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon3 : Processor
	{
		private readonly BoundSet arg_00241;

		private readonly TypeSolver arg_00242;

		internal ___003C_003EAnon3(BoundSet P_0, TypeSolver P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object process(Bound P_0, Bound P_1, object P_2)
		{
			ConstraintFormulaSet result = arg_00241.lambda_0024deriveImpliedBounds_00243(arg_00242, (SubtypeOfBound)P_0, (SubtypeOfBound)P_1, (ConstraintFormulaSet)P_2);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon4 : Processor
	{
		internal ___003C_003EAnon4()
		{
		}

		public object process(Bound P_0, Bound P_1, object P_2)
		{
			ConstraintFormulaSet result = lambda_0024deriveImpliedBounds_00244((SameAsBound)P_0, (SameAsBound)P_1, (ConstraintFormulaSet)P_2);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon5 : Processor
	{
		private readonly TypeSolver arg_00241;

		internal ___003C_003EAnon5(TypeSolver P_0)
		{
			arg_00241 = P_0;
		}

		public object process(Bound P_0, Bound P_1, object P_2)
		{
			ConstraintFormulaSet result = lambda_0024deriveImpliedBounds_00245(arg_00241, (SameAsBound)P_0, (SubtypeOfBound)P_1, (ConstraintFormulaSet)P_2);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon6 : Processor
	{
		private readonly BoundSet arg_00241;

		internal ___003C_003EAnon6(BoundSet P_0)
		{
			arg_00241 = P_0;
		}

		public object process(Bound P_0, Bound P_1, object P_2)
		{
			ConstraintFormulaSet result = arg_00241.lambda_0024deriveImpliedBounds_00246((SubtypeOfBound)P_0, (SubtypeOfBound)P_1, (ConstraintFormulaSet)P_2);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon7 : Predicate
	{
		internal ___003C_003EAnon7()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024deriveImpliedBounds_00247((Bound)P_0);
			
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

	
	private sealed class ___003C_003EAnon8 : Predicate
	{
		internal ___003C_003EAnon8()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024containsFalse_00248((Bound)P_0);
			
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

	
	private sealed class ___003C_003EAnon9 : Predicate
	{
		private readonly InferenceVariable arg_00241;

		internal ___003C_003EAnon9(InferenceVariable P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024hasProperty_00249(arg_00241, (VariableDependency)P_0);
			
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

	
	private sealed class ___003C_003EAnon10 : Predicate
	{
		internal ___003C_003EAnon10()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024hasProperty_002410((VariableDependency)P_0);
			
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

	
	private sealed class ___003C_003EAnon11 : Function
	{
		internal ___003C_003EAnon11()
		{
		}

		public object apply(object P_0)
		{
			InferenceVariable result = lambda_0024hasProperty_002411((VariableDependency)P_0);
			
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

	
	private sealed class ___003C_003EAnon12 : Predicate
	{
		private readonly BoundSet arg_00241;

		internal ___003C_003EAnon12(BoundSet P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = arg_00241.lambda_0024performResolution_002412((InferenceVariable)P_0);
			
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

	
	private sealed class ___003C_003EAnon13 : Predicate
	{
		private readonly InferenceVariable arg_00241;

		internal ___003C_003EAnon13(InferenceVariable P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024performResolution_002413(arg_00241, (Bound)P_0);
			
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

	
	private sealed class ___003C_003EAnon14 : Function
	{
		private readonly InferenceVariable arg_00241;

		internal ___003C_003EAnon14(InferenceVariable P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			ResolvedType result = lambda_0024performResolution_002414(arg_00241, (Bound)P_0);
			
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

	
	private sealed class ___003C_003EAnon15 : Predicate
	{
		private readonly InferenceVariable arg_00241;

		internal ___003C_003EAnon15(InferenceVariable P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024performResolution_002415(arg_00241, (Bound)P_0);
			
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

	
	private sealed class ___003C_003EAnon16 : Predicate
	{
		private readonly InferenceVariable arg_00241;

		internal ___003C_003EAnon16(InferenceVariable P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024performResolution_002416(arg_00241, (Bound)P_0);
			
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

	
	private sealed class ___003C_003EAnon17 : Function
	{
		private readonly InferenceVariable arg_00241;

		internal ___003C_003EAnon17(InferenceVariable P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			ResolvedType result = lambda_0024performResolution_002417(arg_00241, (Bound)P_0);
			
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

	
	private sealed class ___003C_003EAnon18 : Predicate
	{
		private readonly InferenceVariable arg_00241;

		internal ___003C_003EAnon18(InferenceVariable P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024getProperUpperBoundsFor_002418(arg_00241, (Bound)P_0);
			
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

	private static string JAVA_LANG_RUNTIME_EXCEPTION;

	
	private static BoundSet EMPTY;

		private List bounds;

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
	
	public BoundSet()
	{
		bounds = new LinkedList();
	}

	
	
	public virtual BoundSet withBound(Bound bound)
	{
		if (bounds.contains(bound))
		{
			return this;
		}
		BoundSet boundSet = new BoundSet();
		boundSet.bounds.addAll(bounds);
		boundSet.bounds.add(bound);
		return boundSet;
	}

	
	
	public virtual BoundSet deriveImpliedBounds(TypeSolver typeSolver)
	{
		ConstraintFormulaSet constraintFormulaSet = ConstraintFormulaSet.empty();
		constraintFormulaSet = (ConstraintFormulaSet)forEachPairSameAs(new ___003C_003EAnon0(this), constraintFormulaSet);
		constraintFormulaSet = (ConstraintFormulaSet)forEachPairSameAndSubtype(new ___003C_003EAnon1(this, typeSolver), constraintFormulaSet);
		constraintFormulaSet = (ConstraintFormulaSet)forEachPairSameAndSubtype(new ___003C_003EAnon2(this, typeSolver), constraintFormulaSet);
		constraintFormulaSet = (ConstraintFormulaSet)forEachPairSubtypeAndSubtype(new ___003C_003EAnon3(this, typeSolver), constraintFormulaSet);
		constraintFormulaSet = (ConstraintFormulaSet)forEachPairSameAs(new ___003C_003EAnon4(), constraintFormulaSet);
		constraintFormulaSet = (ConstraintFormulaSet)forEachPairSameAndSubtype(new ___003C_003EAnon5(typeSolver), constraintFormulaSet);
		constraintFormulaSet = (ConstraintFormulaSet)forEachPairSubtypeAndSubtype(new ___003C_003EAnon6(this), constraintFormulaSet);
		Iterator iterator = ((List)bounds.stream().filter(new ___003C_003EAnon7()).collect(Collectors.toList())).iterator();
		if (iterator.hasNext())
		{
			Bound bound = (Bound)iterator.next();
			_ = (CapturesBound)bound;
			
			throw new UnsupportedOperationException();
		}
		if (constraintFormulaSet.isEmpty())
		{
			return this;
		}
		BoundSet boundSet = constraintFormulaSet.reduce(typeSolver);
		if (boundSet.isEmpty())
		{
			return this;
		}
		BoundSet result = incorporate(boundSet, typeSolver);
		
		return result;
	}

	
		
	private object forEachPairSameAs(Processor P_0, object P_1)
	{
		object obj = P_1;
		for (int i = 0; i < bounds.size(); i++)
		{
			Bound bound = (Bound)bounds.get(i);
			if (!(bound is SameAsBound))
			{
				continue;
			}
			SameAsBound sameAsBound = (SameAsBound)bound;
			for (int j = i + 1; j < bounds.size(); j++)
			{
				Bound bound2 = (Bound)bounds.get(j);
				if (bound2 is SameAsBound)
				{
					SameAsBound sameAsBound2 = (SameAsBound)bound2;
					obj = P_0.process(sameAsBound, sameAsBound2, obj);
				}
			}
		}
		return obj;
	}

	
		
	private object forEachPairSameAndSubtype(Processor P_0, object P_1)
	{
		object obj = P_1;
		for (int i = 0; i < bounds.size(); i++)
		{
			Bound bound = (Bound)bounds.get(i);
			if (!(bound is SameAsBound))
			{
				continue;
			}
			SameAsBound sameAsBound = (SameAsBound)bound;
			for (int j = i + 1; j < bounds.size(); j++)
			{
				Bound bound2 = (Bound)bounds.get(j);
				if (bound2 is SubtypeOfBound)
				{
					SubtypeOfBound subtypeOfBound = (SubtypeOfBound)bound2;
					obj = P_0.process(sameAsBound, subtypeOfBound, obj);
				}
			}
		}
		return obj;
	}

	
		
	private object forEachPairSubtypeAndSubtype(Processor P_0, object P_1)
	{
		object obj = P_1;
		for (int i = 0; i < bounds.size(); i++)
		{
			Bound bound = (Bound)bounds.get(i);
			if (!(bound is SubtypeOfBound))
			{
				continue;
			}
			SubtypeOfBound subtypeOfBound = (SubtypeOfBound)bound;
			for (int j = i + 1; j < bounds.size(); j++)
			{
				Bound bound2 = (Bound)bounds.get(j);
				if (bound2 is SubtypeOfBound)
				{
					SubtypeOfBound subtypeOfBound2 = (SubtypeOfBound)bound2;
					obj = P_0.process(subtypeOfBound, subtypeOfBound2, obj);
				}
			}
		}
		return obj;
	}

	
	
	public virtual bool isEmpty()
	{
		bool result = bounds.isEmpty();
		
		return result;
	}

	
	
	public virtual BoundSet incorporate(BoundSet otherBounds, TypeSolver typeSolver)
	{
		BoundSet boundSet = this;
		Iterator iterator = otherBounds.bounds.iterator();
		while (iterator.hasNext())
		{
			Bound bound = (Bound)iterator.next();
			boundSet = boundSet.withBound(bound);
		}
		BoundSet result = boundSet.deriveImpliedBounds(typeSolver);
		
		return result;
	}

	
		
	private Set allButOne(Set P_0, object P_1)
	{
		HashSet hashSet = new HashSet(P_0);
		((Set)hashSet).remove(P_1);
		return hashSet;
	}

	
		
	private List buildAllSubsetsOfSize(Set P_0, int P_1)
	{
		if (P_1 == P_0.size())
		{
			List result = Arrays.asList(P_0);
			
			return result;
		}
		LinkedList linkedList = new LinkedList();
		Iterator iterator = P_0.iterator();
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			Set set = allButOne(P_0, obj);
			((List)linkedList).addAll((Collection)buildAllSubsetsOfSize(set, P_1));
		}
		return linkedList;
	}

	
		
	private bool hasProperty(Set P_0, List P_1)
	{
		Iterator iterator = P_0.iterator();
		while (iterator.hasNext())
		{
			InferenceVariable inferenceVariable = (InferenceVariable)iterator.next();
			Iterator iterator2 = ((List)P_1.stream().filter(new ___003C_003EAnon9(inferenceVariable)).filter(new ___003C_003EAnon10())
				.map(new ___003C_003EAnon11())
				.collect(Collectors.toList())).iterator();
			while (iterator2.hasNext())
			{
				InferenceVariable inferenceVariable2 = (InferenceVariable)iterator2.next();
				if (!hasInstantiationFor(inferenceVariable2) && !thereIsSomeJSuchThatβequalAlphaJ(P_0, inferenceVariable2))
				{
					return false;
				}
			}
		}
		return true;
	}

	
	
	private bool hasInstantiationFor(InferenceVariable P_0)
	{
		Iterator iterator = bounds.iterator();
		while (iterator.hasNext())
		{
			Bound bound = (Bound)iterator.next();
			if (bound.isAnInstantiationFor(P_0))
			{
				return true;
			}
		}
		return false;
	}

	
		
	private bool thereIsSomeJSuchThatβequalAlphaJ(Set P_0, InferenceVariable P_1)
	{
		Iterator iterator = P_0.iterator();
		while (iterator.hasNext())
		{
			InferenceVariable obj = (InferenceVariable)iterator.next();
			Iterator iterator2 = bounds.iterator();
			while (iterator2.hasNext())
			{
				Bound bound = (Bound)iterator2.next();
				if (bound is SameAsBound)
				{
					SameAsBound sameAsBound = (SameAsBound)bound;
					if (Object.instancehelper_equals(sameAsBound.getS(), obj) && Object.instancehelper_equals(sameAsBound.getT(), P_1))
					{
						return true;
					}
					if (Object.instancehelper_equals(sameAsBound.getT(), obj) && Object.instancehelper_equals(sameAsBound.getS(), P_1))
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	
	
	public virtual bool containsFalse()
	{
		bool result = bounds.stream().anyMatch(new ___003C_003EAnon8());
		
		return result;
	}

	
		
	private Set allInferenceVariables()
	{
		HashSet hashSet = new HashSet();
		Iterator iterator = bounds.iterator();
		while (iterator.hasNext())
		{
			Bound bound = (Bound)iterator.next();
			((Set)hashSet).addAll((Collection)bound.usedInferenceVariables());
		}
		return hashSet;
	}

	
	
	private Instantiation getInstantiationFor(InferenceVariable P_0)
	{
		Iterator iterator = bounds.iterator();
		while (iterator.hasNext())
		{
			Bound bound = (Bound)iterator.next();
			if (bound.isAnInstantiationFor(P_0))
			{
				return (Instantiation)bound.isAnInstantiation().get();
			}
		}
		
		throw new IllegalArgumentException();
	}

	
		
	private Set allSetsWithProperty(Set P_0, List P_1)
	{
		Set set = allPossibleSetsWithProperty(P_0, P_1);
		HashSet hashSet = new HashSet();
		Iterator iterator = set.iterator();
		while (iterator.hasNext())
		{
			Set set2 = (Set)iterator.next();
			if (!thereAreProperSubsets(set2, set))
			{
				((Set)hashSet).add((object)set2);
			}
		}
		return hashSet;
	}

	public static BoundSet empty()
	{
		return EMPTY;
	}

	
	
	private bool properUpperBoundsAreAtMostExceptionThrowableAndObject(InferenceVariable P_0)
	{
		
		throw new UnsupportedOperationException();
	}

	
		
	public virtual Optional performResolution(List variablesToResolve, TypeSolver typeSolver)
	{
		if (containsFalse())
		{
			Optional result = Optional.empty();
			
			return result;
		}
		LinkedList linkedList = new LinkedList();
		Iterator iterator = bounds.iterator();
		while (iterator.hasNext())
		{
			Bound bound = (Bound)iterator.next();
			if (bound is CapturesBound)
			{
				
				throw new UnsupportedOperationException();
			}
		}
		iterator = bounds.iterator();
		while (iterator.hasNext())
		{
			Bound bound = (Bound)iterator.next();
			if (bound is CapturesBound)
			{
				
				throw new UnsupportedOperationException();
			}
		}
		for (int i = 0; i < ((List)linkedList).size(); i++)
		{
			VariableDependency variableDependency = (VariableDependency)((List)linkedList).get(i);
			for (int j = i + 1; j < ((List)linkedList).size(); j++)
			{
				VariableDependency variableDependency2 = (VariableDependency)((List)linkedList).get(j);
				if (VariableDependency.access_0024100(variableDependency).equals(VariableDependency.access_0024000(variableDependency2)))
				{
					((List)linkedList).add((object)new VariableDependency(this, variableDependency.getDepending(), variableDependency2.getDependedOn()));
				}
			}
		}
		iterator = allInferenceVariables().iterator();
		while (iterator.hasNext())
		{
			InferenceVariable inferenceVariable = (InferenceVariable)iterator.next();
			((List)linkedList).add((object)new VariableDependency(this, inferenceVariable, inferenceVariable));
		}
		HashSet hashSet = new HashSet();
		((Set)hashSet).addAll((Collection)variablesToResolve);
		Iterator iterator2 = ((List)linkedList).iterator();
		while (iterator2.hasNext())
		{
			VariableDependency variableDependency3 = (VariableDependency)iterator2.next();
			if (variablesToResolve.contains(VariableDependency.access_0024000(variableDependency3)))
			{
				((Set)hashSet).add((object)VariableDependency.access_0024100(variableDependency3));
			}
		}
		int num = 1;
		Iterator iterator3 = ((Set)hashSet).iterator();
		while (iterator3.hasNext())
		{
			InferenceVariable inferenceVariable2 = (InferenceVariable)iterator3.next();
			if (!hasInstantiationFor(inferenceVariable2))
			{
				num = 0;
			}
		}
		Iterator iterator4;
		if (num != 0)
		{
			InstantiationSet instantiationSet = InstantiationSet.empty();
			iterator4 = ((Set)hashSet).iterator();
			while (iterator4.hasNext())
			{
				InferenceVariable inferenceVariable3 = (InferenceVariable)iterator4.next();
				instantiationSet = instantiationSet.withInstantiation(getInstantiationFor(inferenceVariable3));
			}
			Optional result2 = Optional.of(instantiationSet);
			
			return result2;
		}
		HashSet hashSet2 = new HashSet();
		iterator4 = ((Set)hashSet).iterator();
		while (iterator4.hasNext())
		{
			InferenceVariable inferenceVariable3 = (InferenceVariable)iterator4.next();
			if (!hasInstantiationFor(inferenceVariable3))
			{
				((Set)hashSet2).add((object)inferenceVariable3);
			}
		}
		iterator4 = allSetsWithProperty(hashSet2, linkedList).iterator();
		if (iterator4.hasNext())
		{
			Set set = (Set)iterator4.next();
			if (!set.stream().anyMatch(new ___003C_003EAnon12(this)))
			{
				BoundSet boundSet = empty();
				Iterator iterator5 = set.iterator();
				while (iterator5.hasNext())
				{
					InferenceVariable inferenceVariable4 = (InferenceVariable)iterator5.next();
					Set set2 = (Set)bounds.stream().filter(new ___003C_003EAnon13(inferenceVariable4)).map(new ___003C_003EAnon14(inferenceVariable4))
						.collect(Collectors.toSet());
					object obj = null;
					if (set2.size() > 0)
					{
						obj = TypeHelper.leastUpperBound(set2);
					}
					int num2 = (bounds.stream().anyMatch(new ___003C_003EAnon15(inferenceVariable4)) ? 1 : 0);
					if ((ResolvedType)obj == null && num2 != 0 && properUpperBoundsAreAtMostExceptionThrowableAndObject(inferenceVariable4))
					{
						ReferenceTypeImpl.___003Cclinit_003E();
						obj = new ReferenceTypeImpl(typeSolver.solveType(JAVA_LANG_RUNTIME_EXCEPTION), typeSolver);
					}
					if (obj == null)
					{
						Set set3 = (Set)bounds.stream().filter(new ___003C_003EAnon16(inferenceVariable4)).map(new ___003C_003EAnon17(inferenceVariable4))
							.collect(Collectors.toSet());
						if (set3.size() == 0)
						{
							
							throw new IllegalStateException();
						}
						obj = TypeHelper.glb(set3);
					}
					BoundSet boundSet2 = boundSet;
					object obj2 = obj;
					boundSet = boundSet2.withBound(new SameAsBound(inferenceVariable4, (obj2 == null) ? null : ((obj2 as ResolvedType) ?? throw new java.lang.IncompatibleClassChangeError())));
				}
				BoundSet boundSet3 = incorporate(boundSet, typeSolver);
				if (!boundSet3.containsFalse())
				{
					Optional result3 = boundSet3.performResolution(variablesToResolve, typeSolver);
					
					return result3;
				}
				
				throw new UnsupportedOperationException();
			}
			
			throw new UnsupportedOperationException();
		}
		Optional result4 = Optional.empty();
		
		return result4;
	}

	
		
	private bool isTheFirstAProperSubsetOfTheSecond(Set P_0, Set P_1)
	{
		return (P_1.containsAll(P_0) && P_1.size() > P_0.size()) ? true : false;
	}

	
		
	private Set allPossibleSetsWithProperty(Set P_0, List P_1)
	{
		HashSet hashSet = new HashSet();
		for (int i = 1; i <= P_0.size(); i++)
		{
			Iterator iterator = buildAllSubsetsOfSize(P_0, i).iterator();
			while (iterator.hasNext())
			{
				Set set = (Set)iterator.next();
				if (hasProperty(set, P_1))
				{
					((Set)hashSet).add((object)set);
				}
			}
		}
		return hashSet;
	}

	
		
	private bool thereAreProperSubsets(Set P_0, Set P_1)
	{
		Iterator iterator = P_1.iterator();
		while (iterator.hasNext())
		{
			Set set = (Set)iterator.next();
			if (!set.equals(P_0) && isTheFirstAProperSubsetOfTheSecond(set, P_0))
			{
				return true;
			}
		}
		return false;
	}

	
	
	private bool appearInLeftPartOfCapture(InferenceVariable P_0)
	{
		Iterator iterator = bounds.iterator();
		while (iterator.hasNext())
		{
			Bound bound = (Bound)iterator.next();
			if (bound is CapturesBound)
			{
				CapturesBound capturesBound = (CapturesBound)bound;
				if (capturesBound.getInferenceVariables().contains(P_0))
				{
					return true;
				}
			}
		}
		return false;
	}

	
		
	private List findPairsOfCommonAncestors(ResolvedReferenceType P_0, ResolvedReferenceType P_1)
	{
		LinkedList linkedList = new LinkedList();
		((List)linkedList).add((object)P_0);
		((List)linkedList).addAll((Collection)P_0.getAllAncestors());
		LinkedList linkedList2 = new LinkedList();
		((List)linkedList2).add((object)P_1);
		((List)linkedList2).addAll((Collection)P_1.getAllAncestors());
		LinkedList linkedList3 = new LinkedList();
		Iterator iterator = ((List)linkedList).iterator();
		while (iterator.hasNext())
		{
			ResolvedReferenceType resolvedReferenceType = (ResolvedReferenceType)iterator.next();
			Iterator iterator2 = ((List)linkedList2).iterator();
			while (iterator2.hasNext())
			{
				ResolvedReferenceType resolvedReferenceType2 = (ResolvedReferenceType)iterator2.next();
				Optional typeDeclaration = resolvedReferenceType.getTypeDeclaration();
				Optional typeDeclaration2 = resolvedReferenceType2.getTypeDeclaration();
				if (typeDeclaration.isPresent() && typeDeclaration2.isPresent() && Object.instancehelper_equals((ResolvedReferenceTypeDeclaration)typeDeclaration.get(), typeDeclaration2.get()))
				{
					((List)linkedList3).add((object)new Pair(resolvedReferenceType, resolvedReferenceType2));
				}
			}
		}
		return linkedList3;
	}

	
	
	private bool areSameTypeInference(ResolvedType P_0, ResolvedType P_1)
	{
		return (P_0.isInferenceVariable() && P_1.isInferenceVariable() && Object.instancehelper_equals(P_0, P_1)) ? true : false;
	}

	
	
	
	private ConstraintFormulaSet lambda_0024deriveImpliedBounds_00240(SameAsBound P_0, SameAsBound P_1, ConstraintFormulaSet P_2)
	{
		if (areSameTypeInference(P_0.getS(), P_1.getS()))
		{
			P_2 = P_2.withConstraint(new TypeSameAsType(P_0.getT(), P_1.getT()));
		}
		if (areSameTypeInference(P_0.getS(), P_1.getT()))
		{
			P_2 = P_2.withConstraint(new TypeSameAsType(P_0.getS(), P_1.getT()));
		}
		if (areSameTypeInference(P_0.getT(), P_1.getS()))
		{
			P_2 = P_2.withConstraint(new TypeSameAsType(P_0.getT(), P_1.getS()));
		}
		if (areSameTypeInference(P_0.getT(), P_1.getT()))
		{
			P_2 = P_2.withConstraint(new TypeSameAsType(P_0.getS(), P_1.getS()));
		}
		return P_2;
	}

	
	
	
	private ConstraintFormulaSet lambda_0024deriveImpliedBounds_00241(TypeSolver P_0, SameAsBound P_1, SubtypeOfBound P_2, ConstraintFormulaSet P_3)
	{
		if (areSameTypeInference(P_1.getS(), P_2.getS()))
		{
			P_3 = P_3.withConstraint(new TypeSubtypeOfType(P_0, P_1.getT(), P_2.getT()));
		}
		if (areSameTypeInference(P_1.getT(), P_2.getS()))
		{
			P_3 = P_3.withConstraint(new TypeSubtypeOfType(P_0, P_1.getS(), P_2.getT()));
		}
		return P_3;
	}

	
	
	
	private ConstraintFormulaSet lambda_0024deriveImpliedBounds_00242(TypeSolver P_0, SameAsBound P_1, SubtypeOfBound P_2, ConstraintFormulaSet P_3)
	{
		if (areSameTypeInference(P_1.getS(), P_2.getT()))
		{
			P_3 = P_3.withConstraint(new TypeSubtypeOfType(P_0, P_2.getS(), P_1.getT()));
		}
		if (areSameTypeInference(P_1.getT(), P_2.getT()))
		{
			P_3 = P_3.withConstraint(new TypeSubtypeOfType(P_0, P_2.getS(), P_1.getS()));
		}
		return P_3;
	}

	
	
	
	private ConstraintFormulaSet lambda_0024deriveImpliedBounds_00243(TypeSolver P_0, SubtypeOfBound P_1, SubtypeOfBound P_2, ConstraintFormulaSet P_3)
	{
		if (areSameTypeInference(P_1.getT(), P_2.getS()))
		{
			P_3 = P_3.withConstraint(new TypeSubtypeOfType(P_0, P_2.getS(), P_1.getT()));
		}
		return P_3;
	}

	
	
	
	private static ConstraintFormulaSet lambda_0024deriveImpliedBounds_00244(SameAsBound P_0, SameAsBound P_1, ConstraintFormulaSet P_2)
	{
		if (P_0.getS().isInferenceVariable() && TypeHelper.isProperType(P_0.getT()))
		{
			InferenceVariable inferenceVariable = (InferenceVariable)P_0.getS();
			ResolvedType t = P_0.getT();
			ResolvedType s = P_1.getS();
			ResolvedType t2 = P_1.getT();
			Substitution substitution = Substitution.empty().withPair(inferenceVariable.getTypeParameterDeclaration(), t);
			P_2 = P_2.withConstraint(new TypeSameAsType(substitution.apply(s), substitution.apply(t2)));
		}
		if (P_0.getT().isInferenceVariable() && TypeHelper.isProperType(P_0.getS()))
		{
			InferenceVariable inferenceVariable = (InferenceVariable)P_0.getT();
			ResolvedType t = P_0.getS();
			ResolvedType s = P_1.getS();
			ResolvedType t2 = P_1.getT();
			Substitution substitution = Substitution.empty().withPair(inferenceVariable.getTypeParameterDeclaration(), t);
			P_2 = P_2.withConstraint(new TypeSameAsType(substitution.apply(s), substitution.apply(t2)));
		}
		if (P_1.getS().isInferenceVariable() && TypeHelper.isProperType(P_1.getT()))
		{
			InferenceVariable inferenceVariable = (InferenceVariable)P_1.getS();
			ResolvedType t = P_1.getT();
			ResolvedType s = P_0.getS();
			ResolvedType t2 = P_0.getT();
			Substitution substitution = Substitution.empty().withPair(inferenceVariable.getTypeParameterDeclaration(), t);
			P_2 = P_2.withConstraint(new TypeSameAsType(substitution.apply(s), substitution.apply(t2)));
		}
		if (P_1.getT().isInferenceVariable() && TypeHelper.isProperType(P_1.getS()))
		{
			InferenceVariable inferenceVariable = (InferenceVariable)P_1.getT();
			ResolvedType t = P_1.getS();
			ResolvedType s = P_0.getS();
			ResolvedType t2 = P_0.getT();
			Substitution substitution = Substitution.empty().withPair(inferenceVariable.getTypeParameterDeclaration(), t);
			P_2 = P_2.withConstraint(new TypeSameAsType(substitution.apply(s), substitution.apply(t2)));
		}
		return P_2;
	}

	
	
	
	private static ConstraintFormulaSet lambda_0024deriveImpliedBounds_00245(TypeSolver P_0, SameAsBound P_1, SubtypeOfBound P_2, ConstraintFormulaSet P_3)
	{
		if (P_1.getS().isInferenceVariable() && TypeHelper.isProperType(P_1.getT()))
		{
			InferenceVariable inferenceVariable = (InferenceVariable)P_1.getS();
			ResolvedType t = P_1.getT();
			ResolvedType s = P_2.getS();
			ResolvedType t2 = P_2.getT();
			Substitution substitution = Substitution.empty().withPair(inferenceVariable.getTypeParameterDeclaration(), t);
			P_3 = P_3.withConstraint(new TypeSubtypeOfType(P_0, substitution.apply(s), substitution.apply(t2)));
		}
		if (P_1.getT().isInferenceVariable() && TypeHelper.isProperType(P_1.getS()))
		{
			InferenceVariable inferenceVariable = (InferenceVariable)P_1.getT();
			ResolvedType t = P_1.getS();
			ResolvedType s = P_2.getS();
			ResolvedType t2 = P_2.getT();
			Substitution substitution = Substitution.empty().withPair(inferenceVariable.getTypeParameterDeclaration(), t);
			P_3 = P_3.withConstraint(new TypeSubtypeOfType(P_0, substitution.apply(s), substitution.apply(t2)));
		}
		return P_3;
	}

	
	
	
	private ConstraintFormulaSet lambda_0024deriveImpliedBounds_00246(SubtypeOfBound P_0, SubtypeOfBound P_1, ConstraintFormulaSet P_2)
	{
		if (P_0.getS().isInferenceVariable() && P_1.getS().isInferenceVariable() && P_0.getT().isReferenceType() && P_1.getT().isReferenceType())
		{
			ResolvedReferenceType resolvedReferenceType = P_0.getT().asReferenceType();
			ResolvedReferenceType resolvedReferenceType2 = P_1.getT().asReferenceType();
			List list = findPairsOfCommonAncestors(resolvedReferenceType, resolvedReferenceType2);
			Iterator iterator = list.iterator();
			while (iterator.hasNext())
			{
				Pair pair = (Pair)iterator.next();
				for (int i = 0; i < Math.min(((ResolvedReferenceType)pair.___003C_003Ea).typeParametersValues().size(), ((ResolvedReferenceType)pair.___003C_003Eb).typeParametersValues().size()); i++)
				{
					ResolvedType resolvedType = (ResolvedType)((ResolvedReferenceType)pair.___003C_003Ea).typeParametersValues().get(i);
					ResolvedType resolvedType2 = (ResolvedType)((ResolvedReferenceType)pair.___003C_003Eb).typeParametersValues().get(i);
					if (!resolvedType.isWildcard() && !resolvedType2.isWildcard())
					{
						P_2 = P_2.withConstraint(new TypeSameAsType(resolvedType, resolvedType2));
					}
				}
			}
		}
		return P_2;
	}

	
	
	private static bool lambda_0024deriveImpliedBounds_00247(Bound P_0)
	{
		return P_0 is CapturesBound;
	}

	
	
	private static bool lambda_0024containsFalse_00248(Bound P_0)
	{
		return P_0 is FalseBound;
	}

	
	
	
	private static bool lambda_0024hasProperty_00249(InferenceVariable P_0, VariableDependency P_1)
	{
		bool result = VariableDependency.access_0024000(P_1).equals(P_0);
		
		return result;
	}

	
	
	
	private static bool lambda_0024hasProperty_002410(VariableDependency P_0)
	{
		return (!P_0.isReflexive()) ? true : false;
	}

	
	
	
	private static InferenceVariable lambda_0024hasProperty_002411(VariableDependency P_0)
	{
		InferenceVariable result = VariableDependency.access_0024100(P_0);
		
		return result;
	}

	
	
	
	private bool lambda_0024performResolution_002412(InferenceVariable P_0)
	{
		bool result = appearInLeftPartOfCapture(P_0);
		
		return result;
	}

	
	
	
	private static bool lambda_0024performResolution_002413(InferenceVariable P_0, Bound P_1)
	{
		bool result = P_1.isProperLowerBoundFor(P_0).isPresent();
		
		return result;
	}

	
	
	
	private static ResolvedType lambda_0024performResolution_002414(InferenceVariable P_0, Bound P_1)
	{
		ResolvedType properType = ((ProperLowerBound)P_1.isProperLowerBoundFor(P_0).get()).getProperType();
		
		return properType;
	}

	
	
	
	private static bool lambda_0024performResolution_002415(InferenceVariable P_0, Bound P_1)
	{
		bool result = P_1.isThrowsBoundOn(P_0);
		
		return result;
	}

	
	
	
	private static bool lambda_0024performResolution_002416(InferenceVariable P_0, Bound P_1)
	{
		bool result = P_1.isProperUpperBoundFor(P_0).isPresent();
		
		return result;
	}

	
	
	
	private static ResolvedType lambda_0024performResolution_002417(InferenceVariable P_0, Bound P_1)
	{
		ResolvedType properType = ((ProperUpperBound)P_1.isProperUpperBoundFor(P_0).get()).getProperType();
		
		return properType;
	}

	
	
	
	private static bool lambda_0024getProperUpperBoundsFor_002418(InferenceVariable P_0, Bound P_1)
	{
		bool result = P_1.isProperUpperBoundFor(P_0).isPresent();
		
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
		BoundSet boundSet = (BoundSet)o;
		HashSet.___003Cclinit_003E();
		HashSet hashSet = new HashSet(bounds);
		HashSet.___003Cclinit_003E();
		bool result = hashSet.equals(new HashSet(boundSet.bounds));
		
		return result;
	}

	
	
	public override int GetHashCode()
	{
		int result = bounds.GetHashCode();
		
		return result;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("BoundSet{bounds=").append(bounds).append('}')
			.ToString();
		
		return result;
	}

	
	
	public virtual bool isTrue()
	{
		bool result = bounds.isEmpty();
		
		return result;
	}

	
		
	private Optional findPairSameAs(Predicate P_0)
	{
		for (int i = 0; i < bounds.size(); i++)
		{
			Bound bound = (Bound)bounds.get(i);
			if (!(bound is SameAsBound))
			{
				continue;
			}
			SameAsBound a = (SameAsBound)bound;
			for (int j = i + 1; j < bounds.size(); j++)
			{
				Bound bound2 = (Bound)bounds.get(j);
				if (bound2 is SameAsBound)
				{
					SameAsBound b = (SameAsBound)bound2;
					Pair pair = new Pair(a, b);
					if (P_0.test(pair))
					{
						Optional result = Optional.of(pair);
						
						return result;
					}
				}
			}
		}
		Optional result2 = Optional.empty();
		
		return result2;
	}

	
		
	private Optional smallestSetWithProperty(Set P_0, List P_1)
	{
		for (int i = 1; i <= P_0.size(); i++)
		{
			Iterator iterator = buildAllSubsetsOfSize(P_0, i).iterator();
			while (iterator.hasNext())
			{
				Set set = (Set)iterator.next();
				if (hasProperty(set, P_1))
				{
					Optional result = Optional.of(set);
					
					return result;
				}
			}
		}
		Optional result2 = Optional.empty();
		
		return result2;
	}

	
		
	public virtual List getProperUpperBoundsFor(InferenceVariable inferenceVariable)
	{
		return (List)bounds.stream().filter(new ___003C_003EAnon18(inferenceVariable)).collect(Collectors.toList());
	}

	
	static BoundSet()
	{
		JAVA_LANG_RUNTIME_EXCEPTION = ClassLiteral<RuntimeException>.Value.getCanonicalName();
		EMPTY = new BoundSet();
	}
}
