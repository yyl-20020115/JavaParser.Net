using System.Runtime.CompilerServices;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.model.resolution;
using IKVM.Attributes;
using java.lang;
using javassist;

namespace com.github.javaparser.symbolsolver.javassistmodel;


public class JavassistParameterDeclaration: ResolvedParameterDeclaration, ResolvedValueDeclaration, ResolvedDeclaration
{
	private ResolvedType type;

	private TypeSolver typeSolver;

	private bool variadic;

	private string name;

	
	
	public JavassistParameterDeclaration(ResolvedType type, TypeSolver typeSolver, bool variadic, string name)
	{
		this.name = name;
		this.type = type;
		this.typeSolver = typeSolver;
		this.variadic = variadic;
	}

	
	
	public JavassistParameterDeclaration(CtClass type, TypeSolver typeSolver, bool variadic, string name)
		: this(JavassistFactory.typeUsageFor(type, typeSolver), typeSolver, variadic, name)
	{
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("JavassistParameterDeclaration{type=").append(type).append(", typeSolver=")
			.append(typeSolver)
			.append(", variadic=")
			.append(variadic)
			.append('}')
			.ToString();
		
		return result;
	}

	public virtual bool hasName()
	{
		return name != null;
	}

	public virtual string getName()
	{
		return name;
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
		return type;
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
