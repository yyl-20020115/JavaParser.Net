using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.model.resolution;
using IKVM.Attributes;
using java.lang;
using java.lang.reflect;
using java.util;

namespace com.github.javaparser.symbolsolver.reflectionmodel;


public class ReflectionFieldDeclaration: ResolvedFieldDeclaration, ResolvedValueDeclaration, ResolvedDeclaration, HasAccessSpecifier, AssociableToAST
{
	private Field field;

	private TypeSolver typeSolver;

	private ResolvedType type;

	
	
	public ReflectionFieldDeclaration(Field field, TypeSolver typeSolver)
	{
		this.field = field;
		this.typeSolver = typeSolver;
		type = calcType();
	}

	
	
	public virtual ResolvedFieldDeclaration replaceType(ResolvedType fieldType)
	{
		ReflectionFieldDeclaration result = new ReflectionFieldDeclaration(field, typeSolver, fieldType);
		
		return result;
	}

	
	
	private ResolvedType calcType()
	{
		ResolvedType result = ReflectionFactory.typeUsageFor(field.getGenericType(), typeSolver);
		
		return result;
	}

	
	
	private ReflectionFieldDeclaration(Field P_0, TypeSolver P_1, ResolvedType P_2)
	{
		field = P_0;
		typeSolver = P_1;
		type = P_2;
	}

	public virtual ResolvedType getType()
	{
		return type;
	}

	
	
	public virtual string getName()
	{
		string name = field.getName();
		
		return name;
	}

	
	
	public virtual bool isStatic()
	{
		bool result = java.lang.reflect.Modifier.isStatic(field.getModifiers());
		
		return result;
	}

	
	
	public virtual bool isVolatile()
	{
		bool result = java.lang.reflect.Modifier.isVolatile(field.getModifiers());
		
		return result;
	}

	public virtual bool isField()
	{
		return true;
	}

	
	
	public virtual ResolvedTypeDeclaration declaringType()
	{
		ResolvedReferenceTypeDeclaration result = ReflectionFactory.typeDeclarationFor(field.getDeclaringClass(), typeSolver);
		
		return result;
	}

	public virtual bool isParameter()
	{
		return false;
	}

	public virtual bool isType()
	{
		return false;
	}

	
	
	public virtual AccessSpecifier accessSpecifier()
	{
		AccessSpecifier result = ReflectionFactory.modifiersToAccessLevel(field.getModifiers());
		
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool hasName()
	{
		return ResolvedDeclaration._003Cdefault_003EhasName(this);
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
		return ResolvedFieldDeclaration._003Cdefault_003EasField(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedParameterDeclaration asParameter()
	{
		return ResolvedDeclaration._003Cdefault_003EasParameter(this);
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
	public virtual Optional toAst()
	{
		return AssociableToAST._003Cdefault_003EtoAst(this);
	}
}
