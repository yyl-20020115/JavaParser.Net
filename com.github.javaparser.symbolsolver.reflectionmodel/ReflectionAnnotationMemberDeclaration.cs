
using com.github.javaparser.ast.expr;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.model.typesystem;

using ikvm.@internal;
using java.lang;
using java.lang.reflect;
using java.util;
using java.util.function;

namespace com.github.javaparser.symbolsolver.reflectionmodel;


public class ReflectionAnnotationMemberDeclaration: ResolvedAnnotationMemberDeclaration, ResolvedValueDeclaration, ResolvedDeclaration
{
	
	private sealed class ___003C_003EAnon0 : Function
	{
		internal ___003C_003EAnon0()
		{
		}

		public object apply(object P_0)
		{
			Expression result = lambda_0024static_00240(P_0);
			
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

	
	private sealed class ___003C_003EAnon1 : Function
	{
		internal ___003C_003EAnon1()
		{
		}

		public object apply(object P_0)
		{
			Expression result = lambda_0024static_00241(P_0);
			
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

	
	private sealed class ___003C_003EAnon2 : Function
	{
		internal ___003C_003EAnon2()
		{
		}

		public object apply(object P_0)
		{
			Expression result = lambda_0024static_00242(P_0);
			
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

	
	private sealed class ___003C_003EAnon3 : Function
	{
		internal ___003C_003EAnon3()
		{
		}

		public object apply(object P_0)
		{
			Expression result = lambda_0024static_00243(P_0);
			
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

	
	private sealed class ___003C_003EAnon4 : Function
	{
		internal ___003C_003EAnon4()
		{
		}

		public object apply(object P_0)
		{
			Expression result = lambda_0024static_00244(P_0);
			
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

	
	private sealed class ___003C_003EAnon5 : Function
	{
		internal ___003C_003EAnon5()
		{
		}

		public object apply(object P_0)
		{
			Expression result = lambda_0024static_00245(P_0);
			
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

		private static Map valueAsExressionConverter;

	private Method annotationMember;

	private TypeSolver typeSolver;

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
	
	public ReflectionAnnotationMemberDeclaration(Method annotationMember, TypeSolver typeSolver)
	{
		this.annotationMember = annotationMember;
		this.typeSolver = typeSolver;
	}

	
	
	
	private static Expression lambda_0024static_00240(object P_0)
	{
		BooleanLiteralExpr.___003Cclinit_003E();
		BooleanLiteralExpr result = new BooleanLiteralExpr(((Boolean)ClassLiteral<Boolean>.Value.cast(P_0)).booleanValue());
		
		return result;
	}

	
	
	
	private static Expression lambda_0024static_00241(object P_0)
	{
		CharLiteralExpr.___003Cclinit_003E();
		CharLiteralExpr result = new CharLiteralExpr(((Character)ClassLiteral<Character>.Value.cast(P_0)).charValue());
		
		return result;
	}

	
	
	
	private static Expression lambda_0024static_00242(object P_0)
	{
		DoubleLiteralExpr.___003Cclinit_003E();
		DoubleLiteralExpr result = new DoubleLiteralExpr(((Double)ClassLiteral<Double>.Value.cast(P_0)).doubleValue());
		
		return result;
	}

	
	
	
	private static Expression lambda_0024static_00243(object P_0)
	{
		IntegerLiteralExpr.___003Cclinit_003E();
		IntegerLiteralExpr result = new IntegerLiteralExpr(((Integer)ClassLiteral<Integer>.Value.cast(P_0)).intValue());
		
		return result;
	}

	
	
	
	private static Expression lambda_0024static_00244(object P_0)
	{
		LongLiteralExpr.___003Cclinit_003E();
		LongLiteralExpr result = new LongLiteralExpr(((Long)ClassLiteral<Long>.Value.cast(P_0)).longValue());
		
		return result;
	}

	
	
	
	private static Expression lambda_0024static_00245(object P_0)
	{
		StringLiteralExpr.___003Cclinit_003E();
		StringLiteralExpr result = new StringLiteralExpr((string)ClassLiteral<String>.Value.cast(P_0));
		
		return result;
	}

	
	
	public virtual Expression getDefaultValue()
	{
		object defaultValue = annotationMember.getDefaultValue();
		Function function = (Function)valueAsExressionConverter.get(Object.instancehelper_getClass(defaultValue));
		if (function == null)
		{
			string message = String.format("Obtaining the type of the annotation member %s is not supported yet.", annotationMember.getName());
			
			throw new UnsupportedOperationException(message);
		}
		return (Expression)function.apply(defaultValue);
	}

	
	
	public virtual ResolvedType getType()
	{
		Class returnType = annotationMember.getReturnType();
		if (returnType.isPrimitive())
		{
			ResolvedType result = ResolvedPrimitiveType.byName(returnType.getName());
			
			return result;
		}
		SymbolReference symbolReference = typeSolver.tryToSolveType(returnType.getName());
		if (symbolReference.isSolved())
		{
			ReferenceTypeImpl.___003Cclinit_003E();
			ReferenceTypeImpl result2 = new ReferenceTypeImpl((ResolvedReferenceTypeDeclaration)symbolReference.getCorrespondingDeclaration(), typeSolver);
			
			return result2;
		}
		string message = String.format("Obtaining the type of the annotation member %s is not supported yet.", annotationMember.getName());
		
		throw new UnsupportedOperationException(message);
	}

	
	
	public virtual string getName()
	{
		string name = annotationMember.getName();
		
		return name;
	}

	
	static ReflectionAnnotationMemberDeclaration()
	{
		valueAsExressionConverter = new HashMap();
		valueAsExressionConverter.put(ClassLiteral<Boolean>.Value, (Function)new ___003C_003EAnon0());
		valueAsExressionConverter.put(ClassLiteral<Character>.Value, (Function)new ___003C_003EAnon1());
		valueAsExressionConverter.put(ClassLiteral<Double>.Value, (Function)new ___003C_003EAnon2());
		valueAsExressionConverter.put(ClassLiteral<Integer>.Value, (Function)new ___003C_003EAnon3());
		valueAsExressionConverter.put(ClassLiteral<Long>.Value, (Function)new ___003C_003EAnon4());
		valueAsExressionConverter.put(ClassLiteral<String>.Value, (Function)new ___003C_003EAnon5());
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool hasName()
	{
		return ResolvedDeclaration._003Cdefault_003EhasName(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isField()
	{
		return ResolvedDeclaration._003Cdefault_003EisField(this);
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
	public virtual bool isParameter()
	{
		return ResolvedDeclaration._003Cdefault_003EisParameter(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isType()
	{
		return ResolvedDeclaration._003Cdefault_003EisType(this);
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
}
