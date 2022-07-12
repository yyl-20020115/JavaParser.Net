
using com.github.javaparser.ast.expr;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.model.typesystem;

using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.util;
using java.util.function;
using javassist;
using javassist.bytecode;
using javassist.bytecode.annotation;

namespace com.github.javaparser.symbolsolver.javassistmodel;


public class JavassistAnnotationMemberDeclaration: ResolvedAnnotationMemberDeclaration, ResolvedValueDeclaration, ResolvedDeclaration
{
	
	private sealed class ___003C_003EAnon0 : Function
	{
		internal ___003C_003EAnon0()
		{
		}

		public object apply(object P_0)
		{
			Expression result = lambda_0024static_00240((MemberValue)P_0);
			
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
			Expression result = lambda_0024static_00241((MemberValue)P_0);
			
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
			Expression result = lambda_0024static_00242((MemberValue)P_0);
			
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
			Expression result = lambda_0024static_00243((MemberValue)P_0);
			
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
			Expression result = lambda_0024static_00244((MemberValue)P_0);
			
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
			Expression result = lambda_0024static_00245((MemberValue)P_0);
			
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

	[IKVM.Attributes.Signature("Ljava/util/Map<Ljava/lang/Class<+Ljavassist/bytecode/annotation/MemberValue;>;Ljava/util/function/Function<Ljavassist/bytecode/annotation/MemberValue;+Lcom/github/javaparser/ast/expr/Expression;>;>;")]
	private static Map memberValueAsExressionConverter;

	private CtMethod annotationMember;

	private TypeSolver typeSolver;

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
	
	public JavassistAnnotationMemberDeclaration(CtMethod annotationMember, TypeSolver typeSolver)
	{
		this.annotationMember = annotationMember;
		this.typeSolver = typeSolver;
	}

	
		
	private static Expression lambda_0024static_00240(MemberValue P_0)
	{
		BooleanLiteralExpr.___003Cclinit_003E();
		BooleanLiteralExpr result = new BooleanLiteralExpr(((BooleanMemberValue)ClassLiteral<BooleanMemberValue>.Value.cast(P_0)).getValue());
		
		return result;
	}

	
		
	private static Expression lambda_0024static_00241(MemberValue P_0)
	{
		CharLiteralExpr.___003Cclinit_003E();
		CharLiteralExpr result = new CharLiteralExpr(((CharMemberValue)ClassLiteral<CharMemberValue>.Value.cast(P_0)).getValue());
		
		return result;
	}

	
	
	
	private static Expression lambda_0024static_00242(MemberValue P_0)
	{
		DoubleLiteralExpr.___003Cclinit_003E();
		DoubleLiteralExpr result = new DoubleLiteralExpr(((DoubleMemberValue)ClassLiteral<DoubleMemberValue>.Value.cast(P_0)).getValue());
		
		return result;
	}

	
	
	
	private static Expression lambda_0024static_00243(MemberValue P_0)
	{
		IntegerLiteralExpr.___003Cclinit_003E();
		IntegerLiteralExpr result = new IntegerLiteralExpr(((IntegerMemberValue)ClassLiteral<IntegerMemberValue>.Value.cast(P_0)).getValue());
		
		return result;
	}

	
	
	
	private static Expression lambda_0024static_00244(MemberValue P_0)
	{
		LongLiteralExpr.___003Cclinit_003E();
		LongLiteralExpr result = new LongLiteralExpr(((LongMemberValue)ClassLiteral<LongMemberValue>.Value.cast(P_0)).getValue());
		
		return result;
	}

	
	
	
	private static Expression lambda_0024static_00245(MemberValue P_0)
	{
		StringLiteralExpr.___003Cclinit_003E();
		StringLiteralExpr result = new StringLiteralExpr(((StringMemberValue)ClassLiteral<StringMemberValue>.Value.cast(P_0)).getValue());
		
		return result;
	}

	
	
	public virtual Expression getDefaultValue()
	{
		javassist.bytecode.AnnotationDefaultAttribute annotationDefaultAttribute = (javassist.bytecode.AnnotationDefaultAttribute)annotationMember.getMethodInfo().getAttribute("AnnotationDefault");
		if (annotationDefaultAttribute == null)
		{
			return null;
		}
		MemberValue defaultValue = annotationDefaultAttribute.getDefaultValue();
		Function function = (Function)memberValueAsExressionConverter.get(Object.instancehelper_getClass(defaultValue));
		if (function == null)
		{
			string message = String.format("Obtaining the type of the annotation member %s is not supported yet.", annotationMember.getName());
			
			throw new UnsupportedOperationException(message);
		}
		return (Expression)function.apply(defaultValue);
	}

	
	
	public virtual ResolvedType getType()
	{
		//Discarded unreachable code: IL_0056
		BadBytecode badBytecode;
		try
		{
			string descriptor = annotationMember.getMethodInfo().getDescriptor();
			javassist.bytecode.SignatureAttribute.MethodSignature methodSignature = javassist.bytecode.SignatureAttribute.toMethodSignature(descriptor);
			SymbolReference symbolReference = typeSolver.tryToSolveType(methodSignature.getReturnType().jvmTypeName());
			if (symbolReference.isSolved())
			{
				ReferenceTypeImpl.___003Cclinit_003E();
				return new ReferenceTypeImpl((ResolvedReferenceTypeDeclaration)symbolReference.getCorrespondingDeclaration(), typeSolver);
			}
		}
		catch (BadBytecode x)
		{
			badBytecode = ByteCodeHelper.MapException<BadBytecode>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0069;
		}
		string message = String.format("Obtaining the type of the annotation member %s is not supported yet.", annotationMember.getLongName());
		
		throw new UnsupportedOperationException(message);
		IL_0069:
		BadBytecode cause = badBytecode;
		
		throw new IllegalStateException("An invalid descriptor was received from JavaAssist.", cause);
	}

	
	
	public virtual string getName()
	{
		string name = annotationMember.getName();
		
		return name;
	}

	
	static JavassistAnnotationMemberDeclaration()
	{
		memberValueAsExressionConverter = new HashMap();
		memberValueAsExressionConverter.put(ClassLiteral<BooleanMemberValue>.Value, (Function)new ___003C_003EAnon0());
		memberValueAsExressionConverter.put(ClassLiteral<CharMemberValue>.Value, (Function)new ___003C_003EAnon1());
		memberValueAsExressionConverter.put(ClassLiteral<DoubleMemberValue>.Value, (Function)new ___003C_003EAnon2());
		memberValueAsExressionConverter.put(ClassLiteral<IntegerMemberValue>.Value, (Function)new ___003C_003EAnon3());
		memberValueAsExressionConverter.put(ClassLiteral<LongMemberValue>.Value, (Function)new ___003C_003EAnon4());
		memberValueAsExressionConverter.put(ClassLiteral<StringMemberValue>.Value, (Function)new ___003C_003EAnon5());
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
