using System.Runtime.CompilerServices;
using com.github.javaparser.resolution.declarations;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace com.github.javaparser.resolution.types.parametrization;

public class ResolvedTypeParametersMap
{
	
	
	
	
	internal class _1
	{
		_1()
		{
			throw null;
		}
	}

	public class Builder
	{
				private Map nameToValue;

				private Map nameToDeclaration;

		
		[MethodParameters(new Modifiers[]
		{
			(Modifiers)0,
			(Modifiers)0
		})]
		
		public virtual Builder setValue(ResolvedTypeParameterDeclaration typeParameter, ResolvedType value)
		{
			string qualifiedName = typeParameter.getQualifiedName();
			nameToValue.put(qualifiedName, value);
			nameToDeclaration.put(qualifiedName, typeParameter);
			return this;
		}

		
		
		public virtual ResolvedTypeParametersMap build()
		{
			ResolvedTypeParametersMap result = new ResolvedTypeParametersMap(nameToValue, nameToDeclaration, null);
			
			return result;
		}

		
		
		public Builder()
		{
			nameToValue = new HashMap();
			nameToDeclaration = new HashMap();
		}

		
		
		
		internal Builder(Map P_0, Map P_1, _1 P_2)
			: this(P_0, P_1)
		{
		}

		
				[MethodParameters(new Modifiers[]
		{
			(Modifiers)0,
			(Modifiers)0
		})]
		
		private Builder(Map nameToValue, Map nameToDeclaration)
		{
			this.nameToValue = new HashMap();
			this.nameToValue.putAll(nameToValue);
			this.nameToDeclaration = new HashMap();
			this.nameToDeclaration.putAll(nameToDeclaration);
		}
	}

		private Map nameToValue;

		private Map nameToDeclaration;

	
	
	public static ResolvedTypeParametersMap empty()
	{
		ResolvedTypeParametersMap result = new Builder().build();
		
		return result;
	}

	
	
	public virtual Builder toBuilder()
	{
		Builder result = new Builder(nameToValue, nameToDeclaration, null);
		
		return result;
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	private ResolvedTypeParametersMap(Map nameToValue, Map nameToDeclaration)
	{
		this.nameToValue = new HashMap();
		this.nameToValue.putAll(nameToValue);
		this.nameToDeclaration = new HashMap();
		this.nameToDeclaration.putAll(nameToDeclaration);
	}

	
	
	
	public virtual ResolvedType getValue(ResolvedTypeParameterDeclaration typeParameter)
	{
		string qualifiedName = typeParameter.getQualifiedName();
		if (nameToValue.containsKey(qualifiedName))
		{
			return (ResolvedType)nameToValue.get(qualifiedName);
		}
		ResolvedTypeVariable result = new ResolvedTypeVariable(typeParameter);
		
		return result;
	}

	
	
	
	public override bool Equals(object o)
	{
		if (this == o)
		{
			return true;
		}
		if (!(o is ResolvedTypeParametersMap))
		{
			return false;
		}
		ResolvedTypeParametersMap resolvedTypeParametersMap = (ResolvedTypeParametersMap)o;
		return (nameToValue.equals(resolvedTypeParametersMap.nameToValue) && nameToDeclaration.equals(resolvedTypeParametersMap.nameToDeclaration)) ? true : false;
	}

	
	
	public override int GetHashCode()
	{
		int result = nameToValue.GetHashCode();
		
		return result;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("TypeParametersMap{nameToValue=").append(nameToValue).append('}')
			.ToString();
		
		return result;
	}

	
		
	
	public virtual Optional getValueBySignature(string signature)
	{
		if (nameToValue.containsKey(signature))
		{
			Optional result = Optional.of(nameToValue.get(signature));
			
			return result;
		}
		Optional result2 = Optional.empty();
		
		return result2;
	}

	
		
	public virtual List getNames()
	{
		
		ArrayList result = new ArrayList(nameToValue.keySet());
		
		return result;
	}

	
		
	public virtual List getTypes()
	{
		
		ArrayList result = new ArrayList(nameToValue.values());
		
		return result;
	}

	
	
	public virtual bool isEmpty()
	{
		bool result = nameToValue.isEmpty();
		
		return result;
	}

	
	
	
	public virtual ResolvedType replaceAll(ResolvedType type)
	{
		HashMap inferredTypes = new HashMap();
		Iterator iterator = nameToDeclaration.values().iterator();
		while (iterator.hasNext())
		{
			ResolvedTypeParameterDeclaration resolvedTypeParameterDeclaration = (ResolvedTypeParameterDeclaration)iterator.next();
			type = type.replaceTypeVariables(resolvedTypeParameterDeclaration, getValue(resolvedTypeParameterDeclaration), inferredTypes);
		}
		return type;
	}

	
	
	
	internal ResolvedTypeParametersMap(Map P_0, Map P_1, _1 P_2)
		: this(P_0, P_1)
	{
	}
}
