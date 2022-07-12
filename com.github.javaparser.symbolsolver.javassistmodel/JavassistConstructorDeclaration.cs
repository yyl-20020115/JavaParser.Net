
using com.github.javaparser.ast;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.model.resolution;

using java.lang;
using java.util;
using javassist;

namespace com.github.javaparser.symbolsolver.javassistmodel;


public class JavassistConstructorDeclaration: ResolvedConstructorDeclaration, ResolvedMethodLikeDeclaration, ResolvedDeclaration, ResolvedTypeParametrizable, HasAccessSpecifier, AssociableToAST
{
	
	private CtConstructor ctConstructor;

	
	private TypeSolver typeSolver;

	
	private JavassistMethodLikeDeclarationAdapter methodLikeAdaper;

	
	
	public JavassistConstructorDeclaration(CtConstructor ctConstructor, TypeSolver typeSolver)
	{
		this.ctConstructor = ctConstructor;
		this.typeSolver = typeSolver;
		methodLikeAdaper = new JavassistMethodLikeDeclarationAdapter(ctConstructor, typeSolver, this);
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append(Object.instancehelper_getClass(this).getSimpleName()).append("{ctConstructor=").append(ctConstructor.getName())
			.append(", typeSolver=")
			.append(typeSolver)
			.append('}')
			.ToString();
		
		return result;
	}

	
	
	public virtual string getName()
	{
		string name = ctConstructor.getName();
		
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
		ResolvedReferenceTypeDeclaration result = JavassistFactory.toTypeDeclaration(ctConstructor.getDeclaringClass(), typeSolver);
		
		return result;
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

	
		
	public virtual List getTypeParameters()
	{
		List typeParameters = methodLikeAdaper.getTypeParameters();
		
		return typeParameters;
	}

	
	
	public virtual AccessSpecifier accessSpecifier()
	{
		AccessSpecifier result = JavassistFactory.modifiersToAccessLevel(ctConstructor.getModifiers());
		
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
