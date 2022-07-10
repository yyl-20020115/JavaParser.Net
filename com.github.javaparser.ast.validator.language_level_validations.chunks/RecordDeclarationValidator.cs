using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast.body;
using IKVM.Attributes;
using java.lang;
using java.util.function;

namespace com.github.javaparser.ast.validator.language_level_validations.chunks;


public class RecordDeclarationValidator: TypedValidator, BiConsumer
{
	
	private sealed class ___003C_003EAnon0 : Predicate
	{
		internal ___003C_003EAnon0()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024forbidNonStaticFieldsInRecords_00240((FieldDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon1 : Consumer
	{
		private readonly RecordDeclaration arg_00241;

		private readonly ProblemReporter arg_00242;

		internal ___003C_003EAnon1(RecordDeclaration P_0, ProblemReporter P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			lambda_0024validateRecordComponentAccessorMethods_00243(arg_00241, arg_00242, (Parameter)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon2 : Predicate
	{
		internal ___003C_003EAnon2()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024null_00241((MethodDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon3 : Consumer
	{
		private readonly Parameter arg_00241;

		private readonly ProblemReporter arg_00242;

		private readonly RecordDeclaration arg_00243;

		internal ___003C_003EAnon3(Parameter P_0, ProblemReporter P_1, RecordDeclaration P_2)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
		}

		public void accept(object P_0)
		{
			lambda_0024null_00242(arg_00241, arg_00242, arg_00243, (MethodDeclaration)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	private void forbidAbstractModifier(RecordDeclaration n, ProblemReporter reporter)
	{
		if (n.getModifiers().contains(Modifier.abstractModifier()))
		{
			reporter.report(n, "Record Declarations must not be declared as abstract.");
		}
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	private void forbidNonStaticFieldsInRecords(RecordDeclaration n, ProblemReporter reporter)
	{
		long num = n.getFields().stream().filter(new ___003C_003EAnon0())
			.count();
		if (num > 0)
		{
			reporter.report(n, "Record Declarations must have zero non-static fields.");
		}
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	private void validateRecordComponentAccessorMethods(RecordDeclaration n, ProblemReporter reporter)
	{
		n.getParameters().forEach(new ___003C_003EAnon1(n, reporter));
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual void accept(RecordDeclaration node, ProblemReporter reporter)
	{
		forbidAbstractModifier(node, reporter);
		forbidNonStaticFieldsInRecords(node, reporter);
		validateRecordComponentAccessorMethods(node, reporter);
	}

	
	
	
	
	private static bool lambda_0024forbidNonStaticFieldsInRecords_00240(FieldDeclaration fieldDeclaration)
	{
		return (!fieldDeclaration.isStatic()) ? true : false;
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private static void lambda_0024validateRecordComponentAccessorMethods_00243(RecordDeclaration n, ProblemReporter reporter, Parameter parameter)
	{
		n.getMethodsByName(parameter.getNameAsString()).stream().filter(new ___003C_003EAnon2())
			.forEach(new ___003C_003EAnon3(parameter, reporter, n));
	}

	
	
	
	
	private static bool lambda_0024null_00241(MethodDeclaration methodDeclaration)
	{
		bool result = methodDeclaration.getParameters().isEmpty();
		
		return result;
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private static void lambda_0024null_00242(Parameter parameter, ProblemReporter reporter, RecordDeclaration n, MethodDeclaration methodDeclaration)
	{
		if (!methodDeclaration.getType().equals(parameter.getType()))
		{
			reporter.report(n, String.format("Incorrect component accessor return type. Expected: '%s', found: '%s'.", parameter.getTypeAsString(), methodDeclaration.getTypeAsString()));
		}
	}

	
	
	public RecordDeclarationValidator()
	{
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	public virtual void accept(Node node, ProblemReporter reporter)
	{
		accept((RecordDeclaration)node, reporter);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	public virtual void accept(object node, object reporter)
	{
		accept((RecordDeclaration)node, (ProblemReporter)reporter);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual BiConsumer andThen(BiConsumer P_0)
	{
		return BiConsumer._003Cdefault_003EandThen(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Processor processor()
	{
		return TypedValidator._003Cdefault_003Eprocessor(this);
	}
}
