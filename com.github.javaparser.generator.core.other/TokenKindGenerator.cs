using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.comments;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.utils;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.generator.core.other;

public class TokenKindGenerator : Generator
{
	
	private sealed class ___003C_003EAnon0 : Supplier
	{
		private readonly TokenKindGenerator arg_00241;

		internal ___003C_003EAnon0(TokenKindGenerator P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			object result = arg_00241.lambda_0024generate_00240();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon1 : Supplier
	{
		internal ___003C_003EAnon1()
		{
		}

		public object get()
		{
			AssertionError result = lambda_0024generate_00241();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon2 : Predicate
	{
		internal ___003C_003EAnon2()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024generate_00242((EnumDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon3 : Supplier
	{
		internal ___003C_003EAnon3()
		{
		}

		public object get()
		{
			AssertionError result = lambda_0024generate_00243();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon4 : Supplier
	{
		internal ___003C_003EAnon4()
		{
		}

		public object get()
		{
			AssertionError result = lambda_0024generate_00244();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon5 : Predicate
	{
		internal ___003C_003EAnon5()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024generate_00245((SwitchEntry)P_0);
			
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

	
	private sealed class ___003C_003EAnon6 : Consumer
	{
		internal ___003C_003EAnon6()
		{
		}

		public void accept(object P_0)
		{
			((SwitchEntry)P_0).remove();
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon7 : Supplier
	{
		internal ___003C_003EAnon7()
		{
		}

		public object get()
		{
			AssertionError result = lambda_0024generate_00246();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon8 : Predicate
	{
		internal ___003C_003EAnon8()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024generate_00247((FieldDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon9 : Function
	{
		internal ___003C_003EAnon9()
		{
		}

		public object apply(object P_0)
		{
			VariableDeclarator result = lambda_0024generate_00248((FieldDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon10 : Consumer
	{
		private readonly TokenKindGenerator arg_00241;

		private readonly EnumDeclaration arg_00242;

		private readonly SwitchStmt arg_00243;

		internal ___003C_003EAnon10(TokenKindGenerator P_0, EnumDeclaration P_1, SwitchStmt P_2)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024generate_00249(arg_00242, arg_00243, (VariableDeclarator)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private SourceRoot generatedJavaCcSourceRoot;

	
	
	public TokenKindGenerator(SourceRoot sourceRoot, SourceRoot generatedJavaCcSourceRoot)
		: base(sourceRoot)
	{
		this.generatedJavaCcSourceRoot = generatedJavaCcSourceRoot;
	}

	
	[LineNumberTable(new byte[]
	{
		2, 158, 118, 127, 1, 159, 11, 107, 135, 127,
		1, 159, 15, 119, 127, 3, 127, 6, 113, 207,
		114, 229, 70, 98
	})]
	public override void generate()
	{
		Log.info("Running %s", new ___003C_003EAnon0(this));
		CompilationUnit compilationUnit = ___003C_003EsourceRoot.parse("com.github.javaparser", "JavaToken.java");
		ClassOrInterfaceDeclaration classOrInterfaceDeclaration = (ClassOrInterfaceDeclaration)compilationUnit.getClassByName("JavaToken").orElseThrow(new ___003C_003EAnon1());
		EnumDeclaration enumDeclaration = (EnumDeclaration)classOrInterfaceDeclaration.findFirst(ClassLiteral<EnumDeclaration>.Value, new ___003C_003EAnon2()).orElseThrow(new ___003C_003EAnon3());
		enumDeclaration.getEntries().clear();
		annotateGenerated(enumDeclaration);
		SwitchStmt switchStmt = (SwitchStmt)enumDeclaration.findFirst(ClassLiteral<SwitchStmt>.Value).orElseThrow(new ___003C_003EAnon4());
		switchStmt.findAll(ClassLiteral<SwitchEntry>.Value).stream().filter(new ___003C_003EAnon5())
			.forEach(new ___003C_003EAnon6());
		CompilationUnit compilationUnit2 = generatedJavaCcSourceRoot.parse("com.github.javaparser", "GeneratedJavaParserConstants.java");
		ClassOrInterfaceDeclaration classOrInterfaceDeclaration2 = (ClassOrInterfaceDeclaration)compilationUnit2.getInterfaceByName("GeneratedJavaParserConstants").orElseThrow(new ___003C_003EAnon7());
		Iterator iterator = classOrInterfaceDeclaration2.getMembers().iterator();
		while (iterator.hasNext())
		{
			BodyDeclaration bodyDeclaration = (BodyDeclaration)iterator.next();
			bodyDeclaration.toFieldDeclaration().filter(new ___003C_003EAnon8()).map(new ___003C_003EAnon9())
				.ifPresent(new ___003C_003EAnon10(this, enumDeclaration, switchStmt));
		}
	}

	
	
	private void generateEnumEntry(EnumDeclaration P_0, string P_1, IntegerLiteralExpr P_2)
	{
		EnumConstantDeclaration enumConstantDeclaration = new EnumConstantDeclaration(P_1);
		enumConstantDeclaration.getArguments().add(P_2);
		P_0.addEntry(enumConstantDeclaration);
	}

	
	
	private void generateValueOfEntry(SwitchStmt P_0, string P_1, IntegerLiteralExpr P_2)
	{
		SwitchEntry.___003Cclinit_003E();
		SwitchEntry node = new SwitchEntry(new NodeList(P_2), SwitchEntry.Type.___003C_003ESTATEMENT_GROUP, new NodeList(new ReturnStmt(P_1)));
		P_0.getEntries().addFirst(node);
	}

	
	
	
	private object lambda_0024generate_00240()
	{
		string simpleName = Object.instancehelper_getClass(this).getSimpleName();
		
		return simpleName;
	}

	
	
	
	private static AssertionError lambda_0024generate_00241()
	{
		AssertionError result = new AssertionError("Can't find class in java file.");
		
		return result;
	}

	
	
	
	private static bool lambda_0024generate_00242(EnumDeclaration P_0)
	{
		bool result = String.instancehelper_equals(P_0.getNameAsString(), "Kind");
		
		return result;
	}

	
	
	
	private static AssertionError lambda_0024generate_00243()
	{
		AssertionError result = new AssertionError("Can't find class in java file.");
		
		return result;
	}

	
	
	
	private static AssertionError lambda_0024generate_00244()
	{
		AssertionError result = new AssertionError("Can't find valueOf switch.");
		
		return result;
	}

	
	
	
	private static bool lambda_0024generate_00245(SwitchEntry P_0)
	{
		bool result = P_0.getLabels().isNonEmpty();
		
		return result;
	}

	
	
	
	private static AssertionError lambda_0024generate_00246()
	{
		AssertionError result = new AssertionError("Can't find class in java file.");
		
		return result;
	}

	
	
	
	private static bool lambda_0024generate_00247(FieldDeclaration P_0)
	{
		string content = ((JavadocComment)P_0.getJavadocComment().get()).getContent();
		CharSequence s = default(CharSequence);
		object obj = (s.___003Cref_003E = "RegularExpression Id");
		int result;
		if (!String.instancehelper_contains(content, s))
		{
			obj = (s.___003Cref_003E = "End of File");
			if (!String.instancehelper_contains(content, s))
			{
				result = 0;
				goto IL_0054;
			}
		}
		result = 1;
		goto IL_0054;
		IL_0054:
		return (byte)result != 0;
	}

	
	
	
	private static VariableDeclarator lambda_0024generate_00248(FieldDeclaration P_0)
	{
		VariableDeclarator variable = P_0.getVariable(0);
		
		return variable;
	}

	
	
	
	private void lambda_0024generate_00249(EnumDeclaration P_0, SwitchStmt P_1, VariableDeclarator P_2)
	{
		string nameAsString = P_2.getNameAsString();
		IntegerLiteralExpr integerLiteralExpr = ((Expression)P_2.getInitializer().get()).asIntegerLiteralExpr();
		generateEnumEntry(P_0, nameAsString, integerLiteralExpr);
		generateValueOfEntry(P_1, nameAsString, integerLiteralExpr);
	}
}
