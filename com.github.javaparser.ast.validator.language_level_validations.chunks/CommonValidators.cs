
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.metamodel;

using ikvm.@internal;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.validator.language_level_validations.chunks;

public class CommonValidators : Validators
{
	
	private sealed class ___003C_003EAnon0 : Predicate
	{
		internal ___003C_003EAnon0()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024new_00240((ClassOrInterfaceDeclaration)P_0);
			
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
			lambda_0024new_00241((ClassOrInterfaceDeclaration)P_0, (ProblemReporter)P_1);
			
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

	
	private sealed class ___003C_003EAnon4 : TypedValidator
	{
		internal ___003C_003EAnon4()
		{
		}

		public void accept(Node P_0, ProblemReporter P_1)
		{
			lambda_0024new_00245((ClassOrInterfaceDeclaration)P_0, P_1);
			
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

	
	private sealed class ___003C_003EAnon5 : TypedValidator
	{
		internal ___003C_003EAnon5()
		{
		}

		public void accept(Node P_0, ProblemReporter P_1)
		{
			lambda_0024new_00246((AssignExpr)P_0, P_1);
			
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

	
	private sealed class ___003C_003EAnon6 : Validator
	{
		internal ___003C_003EAnon6()
		{
		}

		public void accept(Node P_0, ProblemReporter P_1)
		{
			lambda_0024new_00247(P_0, P_1);
			
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

	
	private sealed class ___003C_003EAnon7 : Consumer
	{
		private readonly ProblemReporter arg_00241;

		internal ___003C_003EAnon7(ProblemReporter P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			lambda_0024null_00244(arg_00241, (BodyDeclaration)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	
	
	
	private static bool lambda_0024new_00240(ClassOrInterfaceDeclaration n)
	{
		return (!n.isInterface() && n.getExtendedTypes().size() > 1) ? true : false;
	}

	
	
	
	
	private static void lambda_0024new_00241(ClassOrInterfaceDeclaration n, ProblemReporter reporter)
	{
		reporter.report(n.getExtendedTypes(1), "A class cannot extend more than one other class.");
	}

	
	
	
	
	private static bool lambda_0024new_00242(ClassOrInterfaceDeclaration n)
	{
		return (n.isInterface() && !n.getImplementedTypes().isEmpty()) ? true : false;
	}

	
	
	
	
	private static void lambda_0024new_00243(ClassOrInterfaceDeclaration n, ProblemReporter reporter)
	{
		reporter.report(n.getImplementedTypes(0), "An interface cannot implement other interfaces.");
	}

	
	
	
	
	private static void lambda_0024new_00245(ClassOrInterfaceDeclaration n, ProblemReporter reporter)
	{
		if (n.isInterface())
		{
			n.getMembers().forEach(new ___003C_003EAnon7(reporter));
		}
	}

	
	
	
	
	private static void lambda_0024new_00246(AssignExpr n, ProblemReporter reporter)
	{
		Expression expression = n.getTarget();
		while (expression is EnclosedExpr)
		{
			expression = ((EnclosedExpr)expression).getInner();
		}
		if (!(expression is NameExpr) && !(expression is ArrayAccessExpr) && !(expression is FieldAccessExpr))
		{
			reporter.report(n.getTarget(), "Illegal left hand side of an assignment.");
		}
	}

	
	
	
	
	private static void lambda_0024new_00247(Node node, ProblemReporter problemReporter)
	{
		NodeMetaModel metaModel = node.getMetaModel();
		Iterator iterator = metaModel.getAllPropertyMetaModels().iterator();
		while (iterator.hasNext())
		{
			PropertyMetaModel propertyMetaModel = (PropertyMetaModel)iterator.next();
			if (propertyMetaModel.isNonEmpty() && propertyMetaModel.isNodeList())
			{
				NodeList nodeList = (NodeList)propertyMetaModel.getValue(node);
				if (nodeList.isEmpty())
				{
					problemReporter.report(node, "%s.%s can not be empty.", metaModel.getTypeName(), propertyMetaModel.getName());
				}
			}
		}
	}

	
	
	
	
	private static void lambda_0024null_00244(ProblemReporter reporter, BodyDeclaration mem)
	{
		if (mem is InitializerDeclaration)
		{
			reporter.report(mem, "An interface cannot have initializers.");
		}
	}

	
	
	public CommonValidators()
		: base(new SimpleValidator(ClassLiteral<ClassOrInterfaceDeclaration>.Value, new ___003C_003EAnon0(), new ___003C_003EAnon1()), new SimpleValidator(ClassLiteral<ClassOrInterfaceDeclaration>.Value, new ___003C_003EAnon2(), new ___003C_003EAnon3()), new SingleNodeTypeValidator(ClassLiteral<ClassOrInterfaceDeclaration>.Value, new ___003C_003EAnon4()), new SingleNodeTypeValidator(ClassLiteral<AssignExpr>.Value, new ___003C_003EAnon5()), new TreeVisitorValidator(new ___003C_003EAnon6()))
	{
	}
}
