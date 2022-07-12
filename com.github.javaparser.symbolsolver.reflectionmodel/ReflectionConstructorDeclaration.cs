using System.ComponentModel;

using com.github.javaparser.ast;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.model.resolution;

using java.lang;
using java.lang.reflect;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.symbolsolver.reflectionmodel;


public class ReflectionConstructorDeclaration: ResolvedConstructorDeclaration, ResolvedMethodLikeDeclaration, ResolvedDeclaration, ResolvedTypeParametrizable, HasAccessSpecifier, AssociableToAST
{
	
	private sealed class ___003C_003EAnon0 : Function
	{
		private readonly ReflectionConstructorDeclaration arg_00241;

		internal ___003C_003EAnon0(ReflectionConstructorDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			ReflectionTypeParameter result = arg_00241.lambda_0024getTypeParameters_00240((TypeVariable)P_0);
			
			return result;
		}

		
		public Function compose(Function P_0)
		{
			return Function._003Cdefault_003Ecompose(this, P_0);
		}

		
		public Function andThen(Function P_0)
		{
			return Function._003Cdefault_003EandThen(this, P_0);
		}
	}

		private Constructor constructor;

	private TypeSolver typeSolver;

	
		
	public ReflectionConstructorDeclaration(Constructor constructor, TypeSolver typeSolver)
	{
		this.constructor = constructor;
		this.typeSolver = typeSolver;
	}

	
	
	public virtual int getNumberOfParams()
	{
		int parameterCount = constructor.getParameterCount();
		
		return parameterCount;
	}

	
	
	public virtual int getNumberOfSpecifiedExceptions()
	{
		return constructor.getExceptionTypes().Length;
	}

	
	
	public virtual ResolvedClassDeclaration declaringType()
	{
		ReflectionClassDeclaration result = new ReflectionClassDeclaration(constructor.getDeclaringClass(), typeSolver);
		
		return result;
	}

	
	
	
	private ReflectionTypeParameter lambda_0024getTypeParameters_00240(TypeVariable P_0)
	{
		ReflectionTypeParameter result = new ReflectionTypeParameter(P_0, declaredOnClass: false, typeSolver);
		
		return result;
	}

	
	
	public virtual ResolvedParameterDeclaration getParam(int i)
	{
		if (i < 0 || i >= getNumberOfParams())
		{
			string s = String.format("No param with index %d. Number of params: %d", Integer.valueOf(i), Integer.valueOf(getNumberOfParams()));
			
			throw new IllegalArgumentException(s);
		}
		int variadic = 0;
		if (constructor.isVarArgs())
		{
			variadic = ((i == constructor.getParameterCount() - 1) ? 1 : 0);
		}
		ReflectionParameterDeclaration result = new ReflectionParameterDeclaration(constructor.getParameterTypes()[i], constructor.getGenericParameterTypes()[i], typeSolver, (byte)variadic != 0, constructor.getParameters()[i].getName());
		
		return result;
	}

	
	
	public virtual string getName()
	{
		string simpleName = constructor.getDeclaringClass().getSimpleName();
		
		return simpleName;
	}

	
	
	public virtual AccessSpecifier accessSpecifier()
	{
		AccessSpecifier result = ReflectionFactory.modifiersToAccessLevel(constructor.getModifiers());
		
		return result;
	}

	
		
	public virtual List getTypeParameters()
	{
		return (List)Arrays.stream(constructor.getTypeParameters()).map(new ___003C_003EAnon0(this)).collect(Collectors.toList());
	}

	
	
	public virtual ResolvedType getSpecifiedException(int index)
	{
		if (index < 0 || index >= getNumberOfSpecifiedExceptions())
		{
			
			throw new IllegalArgumentException();
		}
		ResolvedType result = ReflectionFactory.typeUsageFor(constructor.getExceptionTypes()[index], typeSolver);
		
		return result;
	}

	
		
	public virtual Optional toAst()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
	
	
	
	public virtual ResolvedReferenceTypeDeclaration _003Cbridge_003EdeclaringType()
	{
		ResolvedClassDeclaration result = declaringType();
		
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
		return ResolvedDeclaration._003Cdefault_003EisEnumConstant(this);
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

	ResolvedReferenceTypeDeclaration ResolvedConstructorDeclaration.ResolvedConstructorDeclaration_003A_003AdeclaringType()
	{
		return _003Cbridge_003EdeclaringType();
	}

	ResolvedReferenceTypeDeclaration ResolvedMethodLikeDeclaration.ResolvedMethodLikeDeclaration_003A_003AdeclaringType()
	{
		return _003Cbridge_003EdeclaringType();
	}
}
