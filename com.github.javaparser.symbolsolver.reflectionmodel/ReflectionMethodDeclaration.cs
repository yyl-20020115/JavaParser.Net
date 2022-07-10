using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.core.resolution;
using com.github.javaparser.symbolsolver.declarations.common;
using com.github.javaparser.symbolsolver.model.resolution;
using IKVM.Attributes;
using java.lang;
using java.lang.reflect;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.symbolsolver.reflectionmodel;


public class ReflectionMethodDeclaration: ResolvedMethodDeclaration, ResolvedMethodLikeDeclaration, ResolvedDeclaration, ResolvedTypeParametrizable, HasAccessSpecifier, AssociableToAST, TypeVariableResolutionCapability
{
	
	private sealed class ___003C_003EAnon0 : Function
	{
		private readonly ReflectionMethodDeclaration arg_00241;

		internal ___003C_003EAnon0(ReflectionMethodDeclaration P_0)
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

	private Method method;

	private TypeSolver typeSolver;

	
	
	public ReflectionMethodDeclaration(Method method, TypeSolver typeSolver)
	{
		this.method = method;
		if (method.isSynthetic() || method.isBridge())
		{
			
			throw new IllegalArgumentException();
		}
		this.typeSolver = typeSolver;
	}

	
	
	public virtual int getNumberOfSpecifiedExceptions()
	{
		return method.getExceptionTypes().Length;
	}

	
	
	
	private ReflectionTypeParameter lambda_0024getTypeParameters_00240(TypeVariable P_0)
	{
		ReflectionTypeParameter result = new ReflectionTypeParameter(P_0, declaredOnClass: false, typeSolver);
		
		return result;
	}

	
	
	public virtual string getName()
	{
		string name = method.getName();
		
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

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("ReflectionMethodDeclaration{method=").append(method).append('}')
			.ToString();
		
		return result;
	}

	public virtual bool isType()
	{
		return false;
	}

	
	
	public virtual ResolvedReferenceTypeDeclaration declaringType()
	{
		if (method.getDeclaringClass().isInterface())
		{
			ReflectionInterfaceDeclaration result = new ReflectionInterfaceDeclaration(method.getDeclaringClass(), typeSolver);
			
			return result;
		}
		if (method.getDeclaringClass().isEnum())
		{
			ReflectionEnumDeclaration result2 = new ReflectionEnumDeclaration(method.getDeclaringClass(), typeSolver);
			
			return result2;
		}
		ReflectionClassDeclaration result3 = new ReflectionClassDeclaration(method.getDeclaringClass(), typeSolver);
		
		return result3;
	}

	
	
	public virtual ResolvedType getReturnType()
	{
		ResolvedType result = ReflectionFactory.typeUsageFor(method.getGenericReturnType(), typeSolver);
		
		return result;
	}

	
	
	public virtual int getNumberOfParams()
	{
		return method.getParameterTypes().Length;
	}

	
	
	public virtual ResolvedParameterDeclaration getParam(int i)
	{
		int variadic = 0;
		if (method.isVarArgs())
		{
			variadic = ((i == method.getParameterCount() - 1) ? 1 : 0);
		}
		ReflectionParameterDeclaration result = new ReflectionParameterDeclaration(method.getParameterTypes()[i], method.getGenericParameterTypes()[i], typeSolver, (byte)variadic != 0, method.getParameters()[i].getName());
		
		return result;
	}

	
		
	public virtual List getTypeParameters()
	{
		return (List)Arrays.stream(method.getTypeParameters()).map(new ___003C_003EAnon0(this)).collect(Collectors.toList());
	}

	
		
	public virtual MethodUsage resolveTypeVariables(Context context, List parameterTypes)
	{
		MethodUsage result = new MethodDeclarationCommonLogic(this, typeSolver).resolveTypeVariables(context, parameterTypes);
		
		return result;
	}

	
	
	public virtual bool isAbstract()
	{
		bool result = java.lang.reflect.Modifier.isAbstract(method.getModifiers());
		
		return result;
	}

	
	
	public virtual bool isDefaultMethod()
	{
		bool result = method.isDefault();
		
		return result;
	}

	
	
	public virtual bool isStatic()
	{
		bool result = java.lang.reflect.Modifier.isStatic(method.getModifiers());
		
		return result;
	}

	
	
	public virtual AccessSpecifier accessSpecifier()
	{
		AccessSpecifier result = ReflectionFactory.modifiersToAccessLevel(method.getModifiers());
		
		return result;
	}

	
	
	public virtual ResolvedType getSpecifiedException(int index)
	{
		if (index < 0 || index >= getNumberOfSpecifiedExceptions())
		{
			
			throw new IllegalArgumentException();
		}
		ResolvedType result = ReflectionFactory.typeUsageFor(method.getExceptionTypes()[index], typeSolver);
		
		return result;
	}

	
		
	public virtual Optional toAst()
	{
		Optional result = Optional.empty();
		
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
		return ResolvedDeclaration._003Cdefault_003EasField(this);
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
	public virtual Optional findTypeParameter(string P_0)
	{
		return ResolvedMethodLikeDeclaration._003Cdefault_003EfindTypeParameter(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isGeneric()
	{
		return ResolvedTypeParametrizable._003Cdefault_003EisGeneric(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual string getPackageName()
	{
		return ResolvedMethodLikeDeclaration._003Cdefault_003EgetPackageName(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual string getClassName()
	{
		return ResolvedMethodLikeDeclaration._003Cdefault_003EgetClassName(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual string getQualifiedName()
	{
		return ResolvedMethodLikeDeclaration._003Cdefault_003EgetQualifiedName(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual string getSignature()
	{
		return ResolvedMethodLikeDeclaration._003Cdefault_003EgetSignature(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual string getQualifiedSignature()
	{
		return ResolvedMethodLikeDeclaration._003Cdefault_003EgetQualifiedSignature(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedParameterDeclaration getLastParam()
	{
		return ResolvedMethodLikeDeclaration._003Cdefault_003EgetLastParam(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool hasVariadicParameter()
	{
		return ResolvedMethodLikeDeclaration._003Cdefault_003EhasVariadicParameter(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual List getSpecifiedExceptions()
	{
		return ResolvedMethodLikeDeclaration._003Cdefault_003EgetSpecifiedExceptions(this);
	}
}
