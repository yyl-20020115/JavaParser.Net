
using com.github.javaparser.ast;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.core.resolution;
using com.github.javaparser.symbolsolver.declarations.common;
using com.github.javaparser.symbolsolver.model.resolution;

using java.lang;
using java.lang.reflect;
using java.util;
using javassist;

namespace com.github.javaparser.symbolsolver.javassistmodel;


public class JavassistMethodDeclaration: ResolvedMethodDeclaration, ResolvedMethodLikeDeclaration, ResolvedDeclaration, ResolvedTypeParametrizable, HasAccessSpecifier, AssociableToAST, TypeVariableResolutionCapability
{
	private CtMethod ctMethod;

	private TypeSolver typeSolver;

	
	private JavassistMethodLikeDeclarationAdapter methodLikeAdaper;

	
	
	public JavassistMethodDeclaration(CtMethod ctMethod, TypeSolver typeSolver)
	{
		this.ctMethod = ctMethod;
		this.typeSolver = typeSolver;
		methodLikeAdaper = new JavassistMethodLikeDeclarationAdapter(ctMethod, typeSolver, this);
	}

	
	
	public virtual bool isAbstract()
	{
		bool result = java.lang.reflect.Modifier.isAbstract(ctMethod.getModifiers());
		
		return result;
	}

	
	
	public virtual bool isDefaultMethod()
	{
		return (ctMethod.getDeclaringClass().isInterface() && !isAbstract()) ? true : false;
	}

	
	
	public virtual bool isStatic()
	{
		bool result = java.lang.reflect.Modifier.isStatic(ctMethod.getModifiers());
		
		return result;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("JavassistMethodDeclaration{ctMethod=").append(ctMethod).append('}')
			.ToString();
		
		return result;
	}

	
	
	public virtual string getName()
	{
		string name = ctMethod.getName();
		
		return name;
	}

	public virtual bool isField()
	{
		return false;
	}

	public virtual bool isParameter()
	{
		return false;
	}

	public virtual bool isType()
	{
		return false;
	}

	
	
	public virtual ResolvedReferenceTypeDeclaration declaringType()
	{
		ResolvedReferenceTypeDeclaration result = JavassistFactory.toTypeDeclaration(ctMethod.getDeclaringClass(), typeSolver);
		
		return result;
	}

	
	
	public virtual ResolvedType getReturnType()
	{
		ResolvedType returnType = methodLikeAdaper.getReturnType();
		
		return returnType;
	}

	
	
	public virtual int getNumberOfParams()
	{
		int numberOfParams = methodLikeAdaper.getNumberOfParams();
		
		return numberOfParams;
	}

	
	
	public virtual ResolvedParameterDeclaration getParam(int i)
	{
		ResolvedParameterDeclaration param = methodLikeAdaper.getParam(i);
		
		return param;
	}

	
	
	public virtual MethodUsage getUsage(Node node)
	{
		
		throw new UnsupportedOperationException();
	}

	
		
	public virtual MethodUsage resolveTypeVariables(Context context, List parameterTypes)
	{
		MethodUsage result = new MethodDeclarationCommonLogic(this, typeSolver).resolveTypeVariables(context, parameterTypes);
		
		return result;
	}

	
		
	public virtual List getTypeParameters()
	{
		List typeParameters = methodLikeAdaper.getTypeParameters();
		
		return typeParameters;
	}

	
	
	public virtual AccessSpecifier accessSpecifier()
	{
		AccessSpecifier result = JavassistFactory.modifiersToAccessLevel(ctMethod.getModifiers());
		
		return result;
	}

	
	
	public virtual int getNumberOfSpecifiedExceptions()
	{
		int numberOfSpecifiedExceptions = methodLikeAdaper.getNumberOfSpecifiedExceptions();
		
		return numberOfSpecifiedExceptions;
	}

	
	
	public virtual ResolvedType getSpecifiedException(int index)
	{
		ResolvedType specifiedException = methodLikeAdaper.getSpecifiedException(index);
		
		return specifiedException;
	}

	
		
	public virtual Optional toAst()
	{
		Optional result = Optional.empty();
		
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
		return ResolvedDeclaration._003Cdefault_003EasPattern(this);
	}


	public virtual Optional findTypeParameter(string P_0)
	{
		return ResolvedMethodLikeDeclaration._003Cdefault_003EfindTypeParameter(this, P_0);
	}


	public virtual bool isGeneric()
	{
		return ResolvedTypeParametrizable._003Cdefault_003EisGeneric(this);
	}


	public virtual string getPackageName()
	{
		return ResolvedMethodLikeDeclaration._003Cdefault_003EgetPackageName(this);
	}


	public virtual string getClassName()
	{
		return ResolvedMethodLikeDeclaration._003Cdefault_003EgetClassName(this);
	}


	public virtual string getQualifiedName()
	{
		return ResolvedMethodLikeDeclaration._003Cdefault_003EgetQualifiedName(this);
	}


	public virtual string getSignature()
	{
		return ResolvedMethodLikeDeclaration._003Cdefault_003EgetSignature(this);
	}


	public virtual string getQualifiedSignature()
	{
		return ResolvedMethodLikeDeclaration._003Cdefault_003EgetQualifiedSignature(this);
	}


	public virtual ResolvedParameterDeclaration getLastParam()
	{
		return ResolvedMethodLikeDeclaration._003Cdefault_003EgetLastParam(this);
	}


	public virtual bool hasVariadicParameter()
	{
		return ResolvedMethodLikeDeclaration._003Cdefault_003EhasVariadicParameter(this);
	}


	public virtual List getSpecifiedExceptions()
	{
		return ResolvedMethodLikeDeclaration._003Cdefault_003EgetSpecifiedExceptions(this);
	}
}
