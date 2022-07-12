
using com.github.javaparser.ast;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.model.resolution;

using IKVM.Runtime;
using java.lang;
using java.lang.reflect;
using java.util;
using javassist;
using javassist.bytecode;

namespace com.github.javaparser.symbolsolver.javassistmodel;


public class JavassistFieldDeclaration: ResolvedFieldDeclaration, ResolvedValueDeclaration, ResolvedDeclaration, HasAccessSpecifier, AssociableToAST
{
	private CtField ctField;

	private TypeSolver typeSolver;

	
	
	public JavassistFieldDeclaration(CtField ctField, TypeSolver typeSolver)
	{
		this.ctField = ctField;
		this.typeSolver = typeSolver;
	}

	
	
	public virtual ResolvedTypeDeclaration declaringType()
	{
		ResolvedReferenceTypeDeclaration result = JavassistFactory.toTypeDeclaration(ctField.getDeclaringClass(), typeSolver);
		
		return result;
	}

	
	
	public virtual ResolvedType getType()
	{
		//Discarded unreachable code: IL_003b
		BadBytecode badBytecode;
		try
		{
			string text = ctField.getGenericSignature();
			if (text == null)
			{
				text = ctField.getSignature();
			}
			javassist.bytecode.SignatureAttribute.Type type = javassist.bytecode.SignatureAttribute.toTypeSignature(text);
			return JavassistUtils.signatureTypeToType(type, typeSolver, (ResolvedTypeParametrizable)declaringType());
		}
		catch (BadBytecode x)
		{
			badBytecode = ByteCodeHelper.MapException<BadBytecode>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		BadBytecode cause = badBytecode;
		
		throw new RuntimeException(cause);
	}

	
	
	public virtual bool isStatic()
	{
		bool result = java.lang.reflect.Modifier.isStatic(ctField.getModifiers());
		
		return result;
	}

	
	
	public virtual bool isVolatile()
	{
		bool result = java.lang.reflect.Modifier.isVolatile(ctField.getModifiers());
		
		return result;
	}

	
	
	public virtual string getName()
	{
		string name = ctField.getName();
		
		return name;
	}

	public virtual bool isField()
	{
		return true;
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
		AccessSpecifier result = JavassistFactory.modifiersToAccessLevel(ctField.getModifiers());
		
		return result;
	}


	public virtual bool hasName()
	{
		return ResolvedDeclaration._003Cdefault_003EhasName(this);
	}


	public virtual bool isVariable()
	{
		return ResolvedDeclaration._003Cdefault_003EisVariable(this);
	}


	public virtual bool isEnumConstant()
	{
		return ResolvedDeclaration._003Cdefault_003EisEnumConstant(this);
	}


	public virtual bool isPattern()
	{
		return ResolvedDeclaration._003Cdefault_003EisPattern(this);
	}


	public virtual bool isMethod()
	{
		return ResolvedDeclaration._003Cdefault_003EisMethod(this);
	}


	public virtual ResolvedFieldDeclaration asField()
	{
		return ResolvedFieldDeclaration._003Cdefault_003EasField(this);
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
		return ResolvedDeclaration._003Cdefault_003EasPattern(this);
	}


	public virtual Optional toAst()
	{
		return AssociableToAST._003Cdefault_003EtoAst(this);
	}
}
