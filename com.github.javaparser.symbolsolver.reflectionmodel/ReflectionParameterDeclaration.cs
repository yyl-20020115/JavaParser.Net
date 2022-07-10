using System.Runtime.CompilerServices;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.model.resolution;
using IKVM.Attributes;
using java.lang;
using java.lang.reflect;
using java.util;

namespace com.github.javaparser.symbolsolver.reflectionmodel;


public class ReflectionParameterDeclaration: ResolvedParameterDeclaration, ResolvedValueDeclaration, ResolvedDeclaration
{
		private Class type;

	private Type genericType;

	private TypeSolver typeSolver;

	private bool variadic;

	private string name;

	
		
	public ReflectionParameterDeclaration(Class type, Type genericType, TypeSolver typeSolver, bool variadic, string name)
	{
		this.type = type;
		this.genericType = genericType;
		this.typeSolver = typeSolver;
		this.variadic = variadic;
		this.name = name;
	}

	public virtual string getName()
	{
		return name;
	}

	public virtual bool hasName()
	{
		return name != null;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("ReflectionParameterDeclaration{type=").append(type).append(", name=")
			.append(name)
			.append('}')
			.ToString();
		
		return result;
	}

	public virtual bool isField()
	{
		return false;
	}

	public virtual bool isParameter()
	{
		return true;
	}

	public virtual bool isVariadic()
	{
		return variadic;
	}

	public virtual bool isType()
	{
		return false;
	}

	
	
	public virtual ResolvedType getType()
	{
		ResolvedType result = ReflectionFactory.typeUsageFor(genericType, typeSolver);
		
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
		ReflectionParameterDeclaration reflectionParameterDeclaration = (ReflectionParameterDeclaration)o;
		return (variadic == reflectionParameterDeclaration.variadic && Objects.equals(type, reflectionParameterDeclaration.type) && Objects.equals(genericType, reflectionParameterDeclaration.genericType) && Objects.equals(typeSolver, reflectionParameterDeclaration.typeSolver) && Objects.equals(name, reflectionParameterDeclaration.name)) ? true : false;
	}

	
	
	public override int GetHashCode()
	{
		int result = Objects.hash(type, genericType, typeSolver, Boolean.valueOf(variadic), name);
		
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isVariable()
	{
		return ResolvedDeclaration._003Cdefault_003EisVariable(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isEnumConstant()
	{
		return ResolvedDeclaration._003Cdefault_003EisEnumConstant(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isPattern()
	{
		return ResolvedDeclaration._003Cdefault_003EisPattern(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isMethod()
	{
		return ResolvedDeclaration._003Cdefault_003EisMethod(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedFieldDeclaration asField()
	{
		return ResolvedDeclaration._003Cdefault_003EasField(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedParameterDeclaration asParameter()
	{
		return ResolvedParameterDeclaration._003Cdefault_003EasParameter(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedTypeDeclaration asType()
	{
		return ResolvedDeclaration._003Cdefault_003EasType(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedMethodDeclaration asMethod()
	{
		return ResolvedDeclaration._003Cdefault_003EasMethod(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedEnumConstantDeclaration asEnumConstant()
	{
		return ResolvedDeclaration._003Cdefault_003EasEnumConstant(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedPatternDeclaration asPattern()
	{
		return ResolvedDeclaration._003Cdefault_003EasPattern(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual string describeType()
	{
		return ResolvedParameterDeclaration._003Cdefault_003EdescribeType(this);
	}
}
