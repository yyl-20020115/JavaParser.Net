using System.Runtime.CompilerServices;
using com.github.javaparser.resolution.types;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.resolution.typeinference;

public class InstantiationSet
{
		private List instantiations;

	
	private static InstantiationSet EMPTY;

	
	
	public static void ___003Cclinit_003E()
	{
	}

	public static InstantiationSet empty()
	{
		return EMPTY;
	}

	
	
	public virtual InstantiationSet withInstantiation(Instantiation instantiation)
	{
		InstantiationSet instantiationSet = new InstantiationSet();
		instantiationSet.instantiations.addAll(instantiations);
		instantiationSet.instantiations.add(instantiation);
		return instantiationSet;
	}

	
	
	private InstantiationSet()
	{
		instantiations = new LinkedList();
	}

	
	
	public virtual bool allInferenceVariablesAreResolved(BoundSet boundSet)
	{
		
		throw new UnsupportedOperationException();
	}

	
	
	public virtual bool isEmpty()
	{
		bool result = instantiations.isEmpty();
		
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
		InstantiationSet instantiationSet = (InstantiationSet)o;
		bool result = instantiations.equals(instantiationSet.instantiations);
		
		return result;
	}

	
	
	public override int GetHashCode()
	{
		int result = instantiations.GetHashCode();
		
		return result;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("InstantiationSet{instantiations=").append(instantiations).append('}')
			.ToString();
		
		return result;
	}

	
	
	public virtual ResolvedType apply(ResolvedType type)
	{
		Iterator iterator = instantiations.iterator();
		while (iterator.hasNext())
		{
			Instantiation instantiation = (Instantiation)iterator.next();
			type = type.replaceTypeVariables(instantiation.getInferenceVariable().getTypeParameterDeclaration(), instantiation.getProperType());
		}
		return type;
	}

	
	static InstantiationSet()
	{
		EMPTY = new InstantiationSet();
	}
}
