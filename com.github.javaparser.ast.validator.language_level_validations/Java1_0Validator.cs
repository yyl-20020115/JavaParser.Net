
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.modules;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.type;
using com.github.javaparser.ast.validator.language_level_validations.chunks;

using ikvm.@internal;
using java.util.function;

namespace com.github.javaparser.ast.validator.language_level_validations;

public class Java1_0Validator : Validators
{
	
	private sealed class ___003C_003EAnon0 : Predicate
	{
		internal ___003C_003EAnon0()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024new_00240((AssertStmt)P_0);
			
			return result;
		}

		
		public Predicate and(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public Predicate negate()
		{
			return Predicate._003Cdefault_003Enegate(this);
		}

		
		public Predicate or(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon1 : BiConsumer
	{
		internal ___003C_003EAnon1()
		{
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024new_00241((AssertStmt)P_0, (ProblemReporter)P_1);
			
		}

		
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon2 : Predicate
	{
		internal ___003C_003EAnon2()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024new_00242((ClassOrInterfaceDeclaration)P_0);
			
			return result;
		}

		
		public Predicate and(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public Predicate negate()
		{
			return Predicate._003Cdefault_003Enegate(this);
		}

		
		public Predicate or(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon3 : BiConsumer
	{
		internal ___003C_003EAnon3()
		{
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024new_00243((ClassOrInterfaceDeclaration)P_0, (ProblemReporter)P_1);
			
		}

		
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon4 : Predicate
	{
		internal ___003C_003EAnon4()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024new_00244((ClassExpr)P_0);
			
			return result;
		}

		
		public Predicate and(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public Predicate negate()
		{
			return Predicate._003Cdefault_003Enegate(this);
		}

		
		public Predicate or(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon5 : BiConsumer
	{
		internal ___003C_003EAnon5()
		{
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024new_00245((ClassExpr)P_0, (ProblemReporter)P_1);
			
		}

		
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon6 : Validator
	{
		internal ___003C_003EAnon6()
		{
		}

		public void accept(Node P_0, ProblemReporter P_1)
		{
			lambda_0024new_00246(P_0, P_1);
			
		}

		
		public void accept(object P_0, object P_1)
		{
			Validator._003Cdefault_003Eaccept(this, P_0, P_1);
		}

		
		public Processor processor()
		{
			return TypedValidator._003Cdefault_003Eprocessor(this);
		}

		
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon7 : TypedValidator
	{
		internal ___003C_003EAnon7()
		{
		}

		public void accept(Node P_0, ProblemReporter P_1)
		{
			lambda_0024new_00247((TryStmt)P_0, P_1);
			
		}

		
		public Processor processor()
		{
			return TypedValidator._003Cdefault_003Eprocessor(this);
		}

		
		public void accept(object P_0, object P_1)
		{
			TypedValidator._003Cdefault_003Eaccept(this, P_0, P_1);
		}

		
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon8 : Validator
	{
		internal ___003C_003EAnon8()
		{
		}

		public void accept(Node P_0, ProblemReporter P_1)
		{
			lambda_0024new_00248(P_0, P_1);
			
		}

		
		public void accept(object P_0, object P_1)
		{
			Validator._003Cdefault_003Eaccept(this, P_0, P_1);
		}

		
		public Processor processor()
		{
			return TypedValidator._003Cdefault_003Eprocessor(this);
		}

		
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon9 : Predicate
	{
		internal ___003C_003EAnon9()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024new_00249((EnumDeclaration)P_0);
			
			return result;
		}

		
		public Predicate and(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public Predicate negate()
		{
			return Predicate._003Cdefault_003Enegate(this);
		}

		
		public Predicate or(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon10 : BiConsumer
	{
		internal ___003C_003EAnon10()
		{
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024new_002410((EnumDeclaration)P_0, (ProblemReporter)P_1);
			
		}

		
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon11 : Predicate
	{
		internal ___003C_003EAnon11()
		{
		}

		public bool test(object P_0)
		{
			bool result = ((Parameter)P_0).isVarArgs();
			
			return result;
		}

		
		public Predicate and(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public Predicate negate()
		{
			return Predicate._003Cdefault_003Enegate(this);
		}

		
		public Predicate or(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon12 : BiConsumer
	{
		internal ___003C_003EAnon12()
		{
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024new_002411((Parameter)P_0, (ProblemReporter)P_1);
			
		}

		
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon13 : Predicate
	{
		internal ___003C_003EAnon13()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024new_002412((ForEachStmt)P_0);
			
			return result;
		}

		
		public Predicate and(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public Predicate negate()
		{
			return Predicate._003Cdefault_003Enegate(this);
		}

		
		public Predicate or(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon14 : BiConsumer
	{
		internal ___003C_003EAnon14()
		{
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024new_002413((ForEachStmt)P_0, (ProblemReporter)P_1);
			
		}

		
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon15 : Predicate
	{
		internal ___003C_003EAnon15()
		{
		}

		public bool test(object P_0)
		{
			bool result = ((ImportDeclaration)P_0).isStatic();
			
			return result;
		}

		
		public Predicate and(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public Predicate negate()
		{
			return Predicate._003Cdefault_003Enegate(this);
		}

		
		public Predicate or(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon16 : BiConsumer
	{
		internal ___003C_003EAnon16()
		{
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024new_002414((ImportDeclaration)P_0, (ProblemReporter)P_1);
			
		}

		
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon17 : Predicate
	{
		internal ___003C_003EAnon17()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024new_002415((SwitchEntry)P_0);
			
			return result;
		}

		
		public Predicate and(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public Predicate negate()
		{
			return Predicate._003Cdefault_003Enegate(this);
		}

		
		public Predicate or(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon18 : BiConsumer
	{
		internal ___003C_003EAnon18()
		{
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024new_002416((SwitchEntry)P_0, (ProblemReporter)P_1);
			
		}

		
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon19 : Predicate
	{
		internal ___003C_003EAnon19()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024new_002417((YieldStmt)P_0);
			
			return result;
		}

		
		public Predicate and(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public Predicate negate()
		{
			return Predicate._003Cdefault_003Enegate(this);
		}

		
		public Predicate or(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon20 : BiConsumer
	{
		internal ___003C_003EAnon20()
		{
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024new_002418((YieldStmt)P_0, (ProblemReporter)P_1);
			
		}

		
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon21 : Predicate
	{
		internal ___003C_003EAnon21()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024new_002419((UnionType)P_0);
			
			return result;
		}

		
		public Predicate and(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public Predicate negate()
		{
			return Predicate._003Cdefault_003Enegate(this);
		}

		
		public Predicate or(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon22 : BiConsumer
	{
		internal ___003C_003EAnon22()
		{
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024new_002420((UnionType)P_0, (ProblemReporter)P_1);
			
		}

		
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon23 : Predicate
	{
		internal ___003C_003EAnon23()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024new_002421((LambdaExpr)P_0);
			
			return result;
		}

		
		public Predicate and(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public Predicate negate()
		{
			return Predicate._003Cdefault_003Enegate(this);
		}

		
		public Predicate or(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon24 : BiConsumer
	{
		internal ___003C_003EAnon24()
		{
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024new_002422((LambdaExpr)P_0, (ProblemReporter)P_1);
			
		}

		
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon25 : Predicate
	{
		internal ___003C_003EAnon25()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024new_002423((ModuleDeclaration)P_0);
			
			return result;
		}

		
		public Predicate and(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public Predicate negate()
		{
			return Predicate._003Cdefault_003Enegate(this);
		}

		
		public Predicate or(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon26 : BiConsumer
	{
		internal ___003C_003EAnon26()
		{
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024new_002424((ModuleDeclaration)P_0, (ProblemReporter)P_1);
			
		}

		
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon27 : Predicate
	{
		internal ___003C_003EAnon27()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024new_002425((SwitchExpr)P_0);
			
			return result;
		}

		
		public Predicate and(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public Predicate negate()
		{
			return Predicate._003Cdefault_003Enegate(this);
		}

		
		public Predicate or(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon28 : BiConsumer
	{
		internal ___003C_003EAnon28()
		{
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024new_002426((SwitchExpr)P_0, (ProblemReporter)P_1);
			
		}

		
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon29 : Predicate
	{
		internal ___003C_003EAnon29()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024new_002427((InstanceOfExpr)P_0);
			
			return result;
		}

		
		public Predicate and(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public Predicate negate()
		{
			return Predicate._003Cdefault_003Enegate(this);
		}

		
		public Predicate or(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon30 : BiConsumer
	{
		internal ___003C_003EAnon30()
		{
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024new_002428((InstanceOfExpr)P_0, (ProblemReporter)P_1);
			
		}

		
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon31 : Predicate
	{
		internal ___003C_003EAnon31()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024new_002429((TextBlockLiteralExpr)P_0);
			
			return result;
		}

		
		public Predicate and(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public Predicate negate()
		{
			return Predicate._003Cdefault_003Enegate(this);
		}

		
		public Predicate or(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon32 : BiConsumer
	{
		internal ___003C_003EAnon32()
		{
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024new_002430((TextBlockLiteralExpr)P_0, (ProblemReporter)P_1);
			
		}

		
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon33 : Predicate
	{
		internal ___003C_003EAnon33()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024new_002431((RecordDeclaration)P_0);
			
			return result;
		}

		
		public Predicate and(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public Predicate negate()
		{
			return Predicate._003Cdefault_003Enegate(this);
		}

		
		public Predicate or(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon34 : BiConsumer
	{
		internal ___003C_003EAnon34()
		{
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024new_002432((RecordDeclaration)P_0, (ProblemReporter)P_1);
			
		}

		
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	internal Validator modifiersWithoutStrictfpAndDefaultAndStaticInterfaceMethodsAndPrivateInterfaceMethods;

	
	internal Validator noAssertKeyword;

	
	internal Validator noInnerClasses;

	
	internal Validator noReflection;

	
	internal Validator noGenerics;

	
		internal SingleNodeTypeValidator tryWithoutResources;

	
	internal Validator noAnnotations;

	
	internal Validator noEnums;

	
	internal Validator noVarargs;

	
	internal Validator noForEach;

	
	internal Validator noStaticImports;

	
	internal Validator onlyOneLabelInSwitchCase;

	
	internal Validator noYield;

	
	internal Validator noBinaryIntegerLiterals;

	
	internal Validator noUnderscoresInIntegerLiterals;

	
	internal Validator noMultiCatch;

	
	internal Validator noLambdas;

	
	internal Validator noModules;

	
	internal Validator noSwitchExpressions;

	
	internal Validator noPatternMatchingInstanceOf;

	
	internal Validator noTextBlockLiteral;

	
	internal Validator noRecordDeclaration;

	
	
	private static bool lambda_0024new_00240(AssertStmt n)
	{
		return true;
	}

	
	
	
	
	private static void lambda_0024new_00241(AssertStmt n, ProblemReporter reporter)
	{
		reporter.report(n, "'assert' keyword is not supported.");
	}

	
	
	
	
	private static bool lambda_0024new_00242(ClassOrInterfaceDeclaration n)
	{
		return (!n.isTopLevelType()) ? true : false;
	}

	
	
	
	
	private static void lambda_0024new_00243(ClassOrInterfaceDeclaration n, ProblemReporter reporter)
	{
		reporter.report(n, "inner classes or interfaces are not supported.");
	}

	
	
	private static bool lambda_0024new_00244(ClassExpr n)
	{
		return true;
	}

	
	
	
	
	private static void lambda_0024new_00245(ClassExpr n, ProblemReporter reporter)
	{
		reporter.report(n, "Reflection is not supported.");
	}

	
	
	
	
	private static void lambda_0024new_00246(Node node, ProblemReporter reporter)
	{
		if (node is NodeWithTypeArguments && ((NodeWithTypeArguments)node).getTypeArguments().isPresent())
		{
			reporter.report(node, "Generics are not supported.");
		}
		if (node is NodeWithTypeParameters && ((NodeWithTypeParameters)node).getTypeParameters().isNonEmpty())
		{
			reporter.report(node, "Generics are not supported.");
		}
	}

	
	
	
	
	private static void lambda_0024new_00247(TryStmt n, ProblemReporter reporter)
	{
		if (n.getCatchClauses().isEmpty() && !n.getFinallyBlock().isPresent())
		{
			reporter.report(n, "Try has no finally and no catch.");
		}
		if (n.getResources().isNonEmpty())
		{
			reporter.report(n, "Catch with resource is not supported.");
		}
	}

	
	
	
	
	private static void lambda_0024new_00248(Node node, ProblemReporter reporter)
	{
		if (node is AnnotationExpr || node is AnnotationDeclaration)
		{
			reporter.report(node, "Annotations are not supported.");
		}
	}

	
	
	private static bool lambda_0024new_00249(EnumDeclaration n)
	{
		return true;
	}

	
	
	
	
	private static void lambda_0024new_002410(EnumDeclaration n, ProblemReporter reporter)
	{
		reporter.report(n, "Enumerations are not supported.");
	}

	
	
	
	
	private static void lambda_0024new_002411(Parameter n, ProblemReporter reporter)
	{
		reporter.report(n, "Varargs are not supported.");
	}

	
	
	private static bool lambda_0024new_002412(ForEachStmt n)
	{
		return true;
	}

	
	
	
	
	private static void lambda_0024new_002413(ForEachStmt n, ProblemReporter reporter)
	{
		reporter.report(n, "For-each loops are not supported.");
	}

	
	
	
	
	private static void lambda_0024new_002414(ImportDeclaration n, ProblemReporter reporter)
	{
		reporter.report(n, "Static imports are not supported.");
	}

	
	
	
	
	private static bool lambda_0024new_002415(SwitchEntry n)
	{
		return n.getLabels().size() > 1;
	}

	
	
	
	
	private static void lambda_0024new_002416(SwitchEntry n, ProblemReporter reporter)
	{
		reporter.report((NodeWithTokenRange)n.getLabels().getParentNode().get(), "Only one label allowed in a switch-case.");
	}

	
	
	private static bool lambda_0024new_002417(YieldStmt n)
	{
		return true;
	}

	
	
	
	
	private static void lambda_0024new_002418(YieldStmt n, ProblemReporter reporter)
	{
		reporter.report(n, "Only labels allowed in break statements.");
	}

	
	
	private static bool lambda_0024new_002419(UnionType n)
	{
		return true;
	}

	
	
	
	
	private static void lambda_0024new_002420(UnionType n, ProblemReporter reporter)
	{
		reporter.report(n, "Multi-catch is not supported.");
	}

	
	
	private static bool lambda_0024new_002421(LambdaExpr n)
	{
		return true;
	}

	
	
	
	
	private static void lambda_0024new_002422(LambdaExpr n, ProblemReporter reporter)
	{
		reporter.report(n, "Lambdas are not supported.");
	}

	
	
	private static bool lambda_0024new_002423(ModuleDeclaration n)
	{
		return true;
	}

	
	
	
	
	private static void lambda_0024new_002424(ModuleDeclaration n, ProblemReporter reporter)
	{
		reporter.report(n, "Modules are not supported.");
	}

	
	
	private static bool lambda_0024new_002425(SwitchExpr n)
	{
		return true;
	}

	
	
	
	
	private static void lambda_0024new_002426(SwitchExpr n, ProblemReporter reporter)
	{
		reporter.report(n, "Switch expressions are not supported.");
	}

	
	
	
	
	private static bool lambda_0024new_002427(InstanceOfExpr n)
	{
		bool result = n.getPattern().isPresent();
		
		return result;
	}

	
	
	
	
	private static void lambda_0024new_002428(InstanceOfExpr n, ProblemReporter reporter)
	{
		reporter.report(n, "Use of patterns with instanceof is not supported.");
	}

	
	
	private static bool lambda_0024new_002429(TextBlockLiteralExpr n)
	{
		return true;
	}

	
	
	
	
	private static void lambda_0024new_002430(TextBlockLiteralExpr n, ProblemReporter reporter)
	{
		reporter.report(n, "Text Block Literals are not supported.");
	}

	
	
	private static bool lambda_0024new_002431(RecordDeclaration n)
	{
		return true;
	}

	
	
	
	
	private static void lambda_0024new_002432(RecordDeclaration n, ProblemReporter reporter)
	{
		reporter.report(n, "Record Declarations are not supported.");
	}

	
	
	public Java1_0Validator()
		: base(new CommonValidators())
	{
		modifiersWithoutStrictfpAndDefaultAndStaticInterfaceMethodsAndPrivateInterfaceMethods = new ModifierValidator(hasStrictfp: false, hasDefaultAndStaticInterfaceMethods: false, hasPrivateInterfaceMethods: false);
		noAssertKeyword = new SimpleValidator(ClassLiteral<AssertStmt>.Value, new ___003C_003EAnon0(), new ___003C_003EAnon1());
		noInnerClasses = new SimpleValidator(ClassLiteral<ClassOrInterfaceDeclaration>.Value, new ___003C_003EAnon2(), new ___003C_003EAnon3());
		noReflection = new SimpleValidator(ClassLiteral<ClassExpr>.Value, new ___003C_003EAnon4(), new ___003C_003EAnon5());
		noGenerics = new TreeVisitorValidator(new ___003C_003EAnon6());
		tryWithoutResources = new SingleNodeTypeValidator(ClassLiteral<TryStmt>.Value, new ___003C_003EAnon7());
		noAnnotations = new TreeVisitorValidator(new ___003C_003EAnon8());
		noEnums = new SimpleValidator(ClassLiteral<EnumDeclaration>.Value, new ___003C_003EAnon9(), new ___003C_003EAnon10());
		noVarargs = new SimpleValidator(ClassLiteral<Parameter>.Value, new ___003C_003EAnon11(), new ___003C_003EAnon12());
		noForEach = new SimpleValidator(ClassLiteral<ForEachStmt>.Value, new ___003C_003EAnon13(), new ___003C_003EAnon14());
		noStaticImports = new SimpleValidator(ClassLiteral<ImportDeclaration>.Value, new ___003C_003EAnon15(), new ___003C_003EAnon16());
		onlyOneLabelInSwitchCase = new SimpleValidator(ClassLiteral<SwitchEntry>.Value, new ___003C_003EAnon17(), new ___003C_003EAnon18());
		noYield = new SimpleValidator(ClassLiteral<YieldStmt>.Value, new ___003C_003EAnon19(), new ___003C_003EAnon20());
		noBinaryIntegerLiterals = new NoBinaryIntegerLiteralsValidator();
		noUnderscoresInIntegerLiterals = new NoUnderscoresInIntegerLiteralsValidator();
		noMultiCatch = new SimpleValidator(ClassLiteral<UnionType>.Value, new ___003C_003EAnon21(), new ___003C_003EAnon22());
		noLambdas = new SimpleValidator(ClassLiteral<LambdaExpr>.Value, new ___003C_003EAnon23(), new ___003C_003EAnon24());
		noModules = new SimpleValidator(ClassLiteral<ModuleDeclaration>.Value, new ___003C_003EAnon25(), new ___003C_003EAnon26());
		noSwitchExpressions = new SimpleValidator(ClassLiteral<SwitchExpr>.Value, new ___003C_003EAnon27(), new ___003C_003EAnon28());
		noPatternMatchingInstanceOf = new SimpleValidator(ClassLiteral<InstanceOfExpr>.Value, new ___003C_003EAnon29(), new ___003C_003EAnon30());
		noTextBlockLiteral = new SimpleValidator(ClassLiteral<TextBlockLiteralExpr>.Value, new ___003C_003EAnon31(), new ___003C_003EAnon32());
		noRecordDeclaration = new SimpleValidator(ClassLiteral<RecordDeclaration>.Value, new ___003C_003EAnon33(), new ___003C_003EAnon34());
		add(modifiersWithoutStrictfpAndDefaultAndStaticInterfaceMethodsAndPrivateInterfaceMethods);
		add(noAssertKeyword);
		add(noInnerClasses);
		add(noReflection);
		add(noGenerics);
		add(tryWithoutResources);
		add(noAnnotations);
		add(noEnums);
		add(noVarargs);
		add(noForEach);
		add(noStaticImports);
		add(noYield);
		add(onlyOneLabelInSwitchCase);
		add(noBinaryIntegerLiterals);
		add(noUnderscoresInIntegerLiterals);
		add(noMultiCatch);
		add(noLambdas);
		add(noModules);
		add(noSwitchExpressions);
		add(noPatternMatchingInstanceOf);
		add(noTextBlockLiteral);
		add(noRecordDeclaration);
	}
}
