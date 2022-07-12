
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.model.resolution;

using java.lang;

namespace com.github.javaparser.symbolsolver.reflectionmodel;


public class ReflectionPatternDeclaration: ResolvedPatternDeclaration, ResolvedValueDeclaration, ResolvedDeclaration
{
		private Class type;

	private TypeSolver typeSolver;

	private string name;

	
		
	public ReflectionPatternDeclaration(Class type, TypeSolver typeSolver, string name)
	{
		this.type = type;
		this.typeSolver = typeSolver;
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

	public virtual bool isField()
	{
		return false;
	}

	public virtual bool isParameter()
	{
		return false;
	}

	public virtual bool isPattern()
	{
		return true;
	}

	public virtual bool isType()
	{
		return false;
	}

	
	
	public virtual ResolvedType getType()
	{
		ResolvedType result = ReflectionFactory.typeUsageFor(type, typeSolver);
		
		return result;
	}


	public virtual bool isVariable()
	{
		return ResolvedDeclaration._003Cdefault_003EisVariable(this);
	}


	public virtual bool isEnumConstant()
	{
		return ResolvedDeclaration._003Cdefault_003EisEnumConstant(this);
	}


	public virtual bool isMethod()
	{
		return ResolvedDeclaration._003Cdefault_003EisMethod(this);
	}


	public virtual ResolvedFieldDeclaration asField()
	{
		return ResolvedDeclaration._003Cdefault_003EasField(this);
	}


	public virtual ResolvedParameterDeclaration asParameter()
	{
		return ResolvedDeclaration._003Cdefault_003EasParameter(this);
	}


	public virtual ResolvedTypeDeclaration asType()
	{
		return ResolvedDeclaration._003Cdefault_003EasType(this);
	}


	public virtual ResolvedMethodDeclaration asMethod()
	{
		return ResolvedDeclaration._003Cdefault_003EasMethod(this);
	}


	public virtual ResolvedEnumConstantDeclaration asEnumConstant()
	{
		return ResolvedDeclaration._003Cdefault_003EasEnumConstant(this);
	}


	public virtual ResolvedPatternDeclaration asPattern()
	{
		return ResolvedPatternDeclaration._003Cdefault_003EasPattern(this);
	}


	public virtual string describeType()
	{
		return ResolvedPatternDeclaration._003Cdefault_003EdescribeType(this);
	}
}
