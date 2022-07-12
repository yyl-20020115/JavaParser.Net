
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.model.typesystem;

using java.lang;
using java.lang.reflect;

namespace com.github.javaparser.symbolsolver.reflectionmodel;


public class ReflectionEnumConstantDeclaration: ResolvedEnumConstantDeclaration, ResolvedValueDeclaration, ResolvedDeclaration
{
	private Field enumConstant;

	private TypeSolver typeSolver;

	
	
	public ReflectionEnumConstantDeclaration(Field enumConstant, TypeSolver typeSolver)
	{
		if (!enumConstant.isEnumConstant())
		{
			
			throw new IllegalArgumentException("The given field does not represent an enum constant");
		}
		this.enumConstant = enumConstant;
		this.typeSolver = typeSolver;
	}

	
	
	public virtual string getName()
	{
		string name = enumConstant.getName();
		
		return name;
	}

	
	
	public virtual ResolvedType getType()
	{
		Class declaringClass = enumConstant.getDeclaringClass();
		ReflectionEnumDeclaration typeDeclaration = new ReflectionEnumDeclaration(declaringClass, typeSolver);
		ReferenceTypeImpl.___003Cclinit_003E();
		ReferenceTypeImpl result = new ReferenceTypeImpl(typeDeclaration, typeSolver);
		
		return result;
	}


	public virtual bool hasName()
	{
		return ResolvedDeclaration._003Cdefault_003EhasName(this);
	}


	public virtual bool isField()
	{
		return ResolvedDeclaration._003Cdefault_003EisField(this);
	}


	public virtual bool isVariable()
	{
		return ResolvedDeclaration._003Cdefault_003EisVariable(this);
	}


	public virtual bool isEnumConstant()
	{
		return ResolvedEnumConstantDeclaration._003Cdefault_003EisEnumConstant(this);
	}


	public virtual bool isPattern()
	{
		return ResolvedDeclaration._003Cdefault_003EisPattern(this);
	}


	public virtual bool isParameter()
	{
		return ResolvedDeclaration._003Cdefault_003EisParameter(this);
	}


	public virtual bool isType()
	{
		return ResolvedDeclaration._003Cdefault_003EisType(this);
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
		return ResolvedEnumConstantDeclaration._003Cdefault_003EasEnumConstant(this);
	}


	public virtual ResolvedPatternDeclaration asPattern()
	{
		return ResolvedDeclaration._003Cdefault_003EasPattern(this);
	}
}
