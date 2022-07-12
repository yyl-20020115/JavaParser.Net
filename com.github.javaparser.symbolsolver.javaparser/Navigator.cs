using System;

using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.stmt;

using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.symbolsolver.javaparser;

public class Navigator
{
	
	private sealed class ___003C_003EAnon0 : Function
	{
		internal ___003C_003EAnon0()
		{
		}

		public object apply(object P_0)
		{
			ClassOrInterfaceDeclaration result = lambda_0024demandClassOrInterface_00241((TypeDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon1 : Supplier
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon1(string P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			IllegalStateException result = lambda_0024demandClassOrInterface_00242(arg_00241);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon2 : Supplier
	{
		internal ___003C_003EAnon2()
		{
		}

		public object get()
		{
			IllegalArgumentException result = new IllegalArgumentException();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon3 : Supplier
	{
		internal ___003C_003EAnon3()
		{
		}

		public object get()
		{
			IllegalStateException result = lambda_0024demandParentNode_00243();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon4 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon4(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024demandVariableDeclaration_00244(arg_00241, (VariableDeclarator)P_0);
			
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

	
	private sealed class ___003C_003EAnon5 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon5(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024findMethodCall_00245(arg_00241, (MethodCallExpr)P_0);
			
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

	
	private sealed class ___003C_003EAnon6 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon6(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024findNameExpression_00246(arg_00241, (NameExpr)P_0);
			
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

	
	private sealed class ___003C_003EAnon7 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon7(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024findSimpleName_00247(arg_00241, (SimpleName)P_0);
			
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

	
	private sealed class ___003C_003EAnon8 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon8(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024findType_00248(arg_00241, (TypeDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon9 : Supplier
	{
		private readonly TypeDeclaration arg_00241;

		internal ___003C_003EAnon9(TypeDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			IllegalStateException result = lambda_0024null_00240(arg_00241);
			
			return result;
		}
	}

	
	
	public static ClassOrInterfaceDeclaration demandClassOrInterface(CompilationUnit compilationUnit, string qualifiedName)
	{
		return (ClassOrInterfaceDeclaration)findType(compilationUnit, qualifiedName).map(new ___003C_003EAnon0()).orElseThrow(new ___003C_003EAnon1(qualifiedName));
	}

	
		
	public static Optional findType(CompilationUnit cu, string qualifiedName)
	{
		if (cu.getTypes().isEmpty())
		{
			Optional result = Optional.empty();
			
			return result;
		}
		string outerTypeName = getOuterTypeName(qualifiedName);
		Optional optional = cu.getTypes().stream().filter(new ___003C_003EAnon8(outerTypeName))
			.findFirst();
		string innerTypeName = getInnerTypeName(qualifiedName);
		if (optional.isPresent() && !java.lang.String.instancehelper_isEmpty(innerTypeName))
		{
			Optional result2 = findType((TypeDeclaration)optional.get(), innerTypeName);
			
			return result2;
		}
		return optional;
	}

	
		
	public static Node demandNodeOfGivenClass(Node node, Class clazz)
	{
		return (Node)node.findFirst(clazz).orElseThrow(new ___003C_003EAnon2());
	}

	
		
	private static Optional findSwitchHelper(Node P_0)
	{
		if (P_0 is SwitchStmt)
		{
			Optional result = Optional.of((SwitchStmt)P_0);
			
			return result;
		}
		Optional result2 = P_0.findFirst(ClassLiteral<SwitchStmt>.Value);
		
		return result2;
	}

	
	
	public static ReturnStmt demandReturnStmt(MethodDeclaration method)
	{
		return (ReturnStmt)demandNodeOfGivenClass(method, ClassLiteral<ReturnStmt>.Value);
	}

	
	
	public static SwitchStmt demandSwitch(Node node)
	{
		return (SwitchStmt)findSwitchHelper(node).orElseThrow(new ___003C_003EAnon2());
	}

	
	
	private static string getOuterTypeName(string P_0)
	{
		return java.lang.String.instancehelper_split(P_0, "\\.", 2)[0];
	}

	
	
	private static string getInnerTypeName(string P_0)
	{
		CharSequence s = default(CharSequence);
		object obj = (s.___003Cref_003E = ".");
		if (java.lang.String.instancehelper_contains(P_0, s))
		{
			return java.lang.String.instancehelper_split(P_0, "\\.", 2)[1];
		}
		return "";
	}

	
		
	public static Optional findType(TypeDeclaration td, string qualifiedName)
	{
		string outerTypeName = getOuterTypeName(qualifiedName);
		Optional optional = Optional.empty();
		Iterator iterator = td.getMembers().iterator();
		while (iterator.hasNext())
		{
			Node node = (Node)iterator.next();
			if (node is TypeDeclaration && java.lang.String.instancehelper_equals(((TypeDeclaration)node).getName().getId(), outerTypeName))
			{
				optional = Optional.of((TypeDeclaration)node);
				break;
			}
		}
		string innerTypeName = getInnerTypeName(qualifiedName);
		if (optional.isPresent() && !java.lang.String.instancehelper_isEmpty(innerTypeName))
		{
			Optional result = findType((TypeDeclaration)optional.get(), innerTypeName);
			
			return result;
		}
		return optional;
	}

	
	
	public static Node demandParentNode(Node node)
	{
		return (Node)node.getParentNode().orElseThrow(new ___003C_003EAnon3());
	}

	
	
	
	private static ClassOrInterfaceDeclaration lambda_0024demandClassOrInterface_00241(TypeDeclaration P_0)
	{
		return (ClassOrInterfaceDeclaration)P_0.toClassOrInterfaceDeclaration().orElseThrow(new ___003C_003EAnon9(P_0));
	}

	
	
	
	private static IllegalStateException lambda_0024demandClassOrInterface_00242(string P_0)
	{
		IllegalStateException result = new IllegalStateException(new StringBuilder().append("No type named '").append(P_0).append("'found")
			.ToString());
		
		return result;
	}

	
	
	
	private static IllegalStateException lambda_0024demandParentNode_00243()
	{
		IllegalStateException result = new IllegalStateException("Parent not found, the node does not appear to be inserted in a correct AST");
		
		return result;
	}

	
	
	
	private static bool lambda_0024demandVariableDeclaration_00244(string P_0, VariableDeclarator P_1)
	{
		bool result = java.lang.String.instancehelper_equals(P_1.getNameAsString(), P_0);
		
		return result;
	}

	
	
	
	private static bool lambda_0024findMethodCall_00245(string P_0, MethodCallExpr P_1)
	{
		bool result = java.lang.String.instancehelper_equals(P_1.getNameAsString(), P_0);
		
		return result;
	}

	
	
	
	private static bool lambda_0024findNameExpression_00246(string P_0, NameExpr P_1)
	{
		bool result = java.lang.String.instancehelper_equals(P_1.getNameAsString(), P_0);
		
		return result;
	}

	
	
	
	private static bool lambda_0024findSimpleName_00247(string P_0, SimpleName P_1)
	{
		bool result = java.lang.String.instancehelper_equals(P_1.asString(), P_0);
		
		return result;
	}

	
	
	
	private static bool lambda_0024findType_00248(string P_0, TypeDeclaration P_1)
	{
		bool result = java.lang.String.instancehelper_equals(P_1.getName().getId(), P_0);
		
		return result;
	}

	
	
	
	private static IllegalStateException lambda_0024null_00240(TypeDeclaration P_0)
	{
		IllegalStateException result = new IllegalStateException(new StringBuilder().append("Type is not a class or an interface, it is ").append(java.lang.Object.instancehelper_getClass(P_0).getCanonicalName()).ToString());
		
		return result;
	}

	
	
	private Navigator()
	{
	}

	
	
	public static ClassOrInterfaceDeclaration demandClass(CompilationUnit cu, string qualifiedName)
	{
		ClassOrInterfaceDeclaration classOrInterfaceDeclaration = demandClassOrInterface(cu, qualifiedName);
		if (classOrInterfaceDeclaration.isInterface())
		{
			
			throw new IllegalStateException("Type is not a class");
		}
		return classOrInterfaceDeclaration;
	}

	
		
	public static ConstructorDeclaration demandConstructor(TypeDeclaration td, int index)
	{
		ConstructorDeclaration constructorDeclaration = null;
		int num = 0;
		Iterator iterator = td.getMembers().iterator();
		while (iterator.hasNext())
		{
			BodyDeclaration bodyDeclaration = (BodyDeclaration)iterator.next();
			if (bodyDeclaration is ConstructorDeclaration)
			{
				ConstructorDeclaration constructorDeclaration2 = (ConstructorDeclaration)bodyDeclaration;
				if (num == index)
				{
					constructorDeclaration = constructorDeclaration2;
					break;
				}
				num++;
			}
		}
		if (constructorDeclaration == null)
		{
			string s = new StringBuilder().append("No constructor with index ").append(index).ToString();
			
			throw new IllegalStateException(s);
		}
		return constructorDeclaration;
	}

	
	
	public static EnumDeclaration demandEnum(CompilationUnit cu, string qualifiedName)
	{
		Optional optional = findType(cu, qualifiedName);
		if (!optional.isPresent())
		{
			
			throw new IllegalStateException("No type found");
		}
		if (!(optional.get() is EnumDeclaration))
		{
			
			throw new IllegalStateException("Type is not an enum");
		}
		return (EnumDeclaration)optional.get();
	}

	
	
	public static VariableDeclarator demandField(ClassOrInterfaceDeclaration cd, string name)
	{
		Iterator iterator = cd.getMembers().iterator();
		while (iterator.hasNext())
		{
			BodyDeclaration bodyDeclaration = (BodyDeclaration)iterator.next();
			if (!(bodyDeclaration is FieldDeclaration))
			{
				continue;
			}
			FieldDeclaration fieldDeclaration = (FieldDeclaration)bodyDeclaration;
			Iterator iterator2 = fieldDeclaration.getVariables().iterator();
			while (iterator2.hasNext())
			{
				VariableDeclarator variableDeclarator = (VariableDeclarator)iterator2.next();
				if (java.lang.String.instancehelper_equals(variableDeclarator.getName().getId(), name))
				{
					return variableDeclarator;
				}
			}
		}
		
		throw new IllegalStateException("No field with given name");
	}

	
	
	public static ClassOrInterfaceDeclaration demandInterface(CompilationUnit cu, string qualifiedName)
	{
		ClassOrInterfaceDeclaration classOrInterfaceDeclaration = demandClassOrInterface(cu, qualifiedName);
		if (!classOrInterfaceDeclaration.isInterface())
		{
			
			throw new IllegalStateException("Type is not an interface");
		}
		return classOrInterfaceDeclaration;
	}

	
		
	public static MethodDeclaration demandMethod(TypeDeclaration cd, string name)
	{
		MethodDeclaration methodDeclaration = null;
		Iterator iterator = cd.getMembers().iterator();
		while (iterator.hasNext())
		{
			BodyDeclaration bodyDeclaration = (BodyDeclaration)iterator.next();
			if (!(bodyDeclaration is MethodDeclaration))
			{
				continue;
			}
			MethodDeclaration methodDeclaration2 = (MethodDeclaration)bodyDeclaration;
			if (java.lang.String.instancehelper_equals(methodDeclaration2.getNameAsString(), name))
			{
				if (methodDeclaration != null)
				{
					
					throw new IllegalStateException("Ambiguous getName");
				}
				methodDeclaration = methodDeclaration2;
			}
		}
		if (methodDeclaration == null)
		{
			string s = new StringBuilder().append("No method called ").append(name).ToString();
			
			throw new IllegalStateException(s);
		}
		return methodDeclaration;
	}

	
		
	public static Optional demandVariableDeclaration(Node node, string name)
	{
		Optional result = node.findFirst(ClassLiteral<VariableDeclarator>.Value, new ___003C_003EAnon4(name));
		
		return result;
	}

	
		
	public static Optional findMethodCall(Node node, string methodName)
	{
		Optional result = node.findFirst(ClassLiteral<MethodCallExpr>.Value, new ___003C_003EAnon5(methodName));
		
		return result;
	}

	
		
	public static Optional findNameExpression(Node node, string name)
	{
		Optional result = node.findFirst(ClassLiteral<NameExpr>.Value, new ___003C_003EAnon6(name));
		
		return result;
	}

	
	
		
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static Node findNodeOfGivenClass(Node node, Class clazz)
	{
		Node result = demandNodeOfGivenClass(node, clazz);
		
		return result;
	}

	
	
	
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static ReturnStmt findReturnStmt(MethodDeclaration method)
	{
		ReturnStmt result = demandReturnStmt(method);
		
		return result;
	}

	
		
	public static Optional findSimpleName(Node node, string name)
	{
		Optional result = node.findFirst(ClassLiteral<SimpleName>.Value, new ___003C_003EAnon7(name));
		
		return result;
	}

	
	
	
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static SwitchStmt findSwitch(Node node)
	{
		SwitchStmt result = demandSwitch(node);
		
		return result;
	}

	
	
	
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static Node requireParentNode(Node node)
	{
		Node result = demandParentNode(node);
		
		return result;
	}
}
