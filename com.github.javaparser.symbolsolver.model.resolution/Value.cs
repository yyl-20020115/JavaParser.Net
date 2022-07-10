using System.Runtime.CompilerServices;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using IKVM.Attributes;
using java.lang;

namespace com.github.javaparser.symbolsolver.model.resolution;

public class Value
{
	private ResolvedType type;

	private string name;

	
	
	public static Value from(ResolvedValueDeclaration decl)
	{
		ResolvedType resolvedType = decl.getType();
		Value result = new Value(resolvedType, decl.getName());
		
		return result;
	}

	
	
	public Value(ResolvedType type, string name)
	{
		this.type = type;
		this.name = name;
	}

	public virtual ResolvedType getType()
	{
		return type;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("Value{type=").append(type).append(", name='")
			.append(name)
			.append('\'')
			.append('}')
			.ToString();
		
		return result;
	}

	public virtual string getName()
	{
		return name;
	}
}
