
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.comments;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.printer.lexicalpreservation;
using com.github.javaparser.utils;

using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.generator;

public abstract class AbstractGenerator
{
	
	private sealed class ___003C_003EAnon0 : Runnable
	{
		private readonly AbstractGenerator arg_00241;

		private readonly CallableDeclaration arg_00242;

		private readonly ClassOrInterfaceDeclaration arg_00243;

		internal ___003C_003EAnon0(AbstractGenerator P_0, CallableDeclaration P_1, ClassOrInterfaceDeclaration P_2)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
		}

		public void run()
		{
			arg_00241.lambda_0024addOrReplaceWhenSameSignature_00240(arg_00242, arg_00243);
			
		}
	}

	
	private sealed class ___003C_003EAnon1 : Predicate
	{
		private readonly Class arg_00241;

		internal ___003C_003EAnon1(Class P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024annotate_00241(arg_00241, (AnnotationExpr)P_0);
			
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

	
	private sealed class ___003C_003EAnon2 : Predicate
	{
		private readonly Class arg_00241;

		internal ___003C_003EAnon2(Class P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024removeAnnotation_00242(arg_00241, (AnnotationExpr)P_0);
			
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
		private readonly AbstractGenerator arg_00241;

		private readonly Class arg_00242;

		internal ___003C_003EAnon3(AbstractGenerator P_0, Class P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024removeAnnotation_00243(arg_00242, (CompilationUnit)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon4 : Predicate
	{
		private readonly Class arg_00241;

		internal ___003C_003EAnon4(Class P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024removeAnnotationImportIfUnused_00244(arg_00241, (AnnotationExpr)P_0);
			
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
		private readonly Class arg_00241;

		internal ___003C_003EAnon5(Class P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024removeAnnotationImportIfUnused_00245(arg_00241, (ImportDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon6 : Runnable
	{
		private readonly CallableDeclaration arg_00241;

		private readonly ClassOrInterfaceDeclaration arg_00242;

		internal ___003C_003EAnon6(CallableDeclaration P_0, ClassOrInterfaceDeclaration P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void run()
		{
			lambda_0024replaceWhenSameSignature_00246(arg_00241, arg_00242);
			
		}
	}

	
	private sealed class ___003C_003EAnon7 : Predicate
	{
		internal ___003C_003EAnon7()
		{
		}

		public bool test(object P_0)
		{
			bool result = ((ParseResult)P_0).isSuccessful();
			
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
		internal ___003C_003EAnon8()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024getParsedCompilationUnitsFromSourceRoot_00247((ParseResult)P_0);
			
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
			Optional result = ((ParseResult)P_0).getResult();
			
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

	
	private sealed class ___003C_003EAnon10 : Function
	{
		internal ___003C_003EAnon10()
		{
		}

		public object apply(object P_0)
		{
			CompilationUnit result = (CompilationUnit)((Optional)P_0).get();
			
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

	protected internal const string COPYRIGHT_NOTICE_JP_CORE = "\n * Copyright (C) 2007-2010 Júlio Vilmar Gesser.\n * Copyright (C) 2011, 2013-2021 The JavaParser Team.\n *\n * This file is part of JavaParser.\n *\n * JavaParser can be used either under the terms of\n * a) the GNU Lesser General Public License as published by\n *     the Free Software Foundation, either version 3 of the License, or\n *     (at your option) any later version.\n * b) the terms of the Apache License\n *\n * You should have received a copy of both licenses in LICENCE.LGPL and\n * LICENCE.APACHE. Please refer to those files for details.\n *\n * JavaParser is distributed in the hope that it will be useful,\n * but WITHOUT ANY WARRANTY; without even the implied warranty of\n * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the\n * GNU Lesser General Public License for more details.\n ";

	protected internal const string COPYRIGHT_NOTICE_JP_SS = "\n * Copyright (C) 2015-2016 Federico Tomassetti\n * Copyright (C) 2017-2020 The JavaParser Team.\n *\n * This file is part of JavaParser.\n *\n * JavaParser can be used either under the terms of\n * a) the GNU Lesser General Public License as published by\n *     the Free Software Foundation, either version 3 of the License, or\n *     (at your option) any later version.\n * b) the terms of the Apache License\n *\n * You should have received a copy of both licenses in LICENCE.LGPL and\n * LICENCE.APACHE. Please refer to those files for details.\n *\n * JavaParser is distributed in the hope that it will be useful,\n * but WITHOUT ANY WARRANTY; without even the implied warranty of\n * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the\n * GNU Lesser General Public License for more details.\n ";

	internal SourceRoot ___003C_003EsourceRoot;

	
	protected internal SourceRoot sourceRoot
	{
		
		get
		{
			return ___003C_003EsourceRoot;
		}
		
		private set
		{
			___003C_003EsourceRoot = value;
		}
	}

	
		
	protected internal virtual void annotateGenerated(Node node)
	{
		NodeWithAnnotations obj = (NodeWithAnnotations)node;
		Class value = ClassLiteral<Generated>.Value;
		StringLiteralExpr.___003Cclinit_003E();
		annotate(obj, value, new StringLiteralExpr(Object.instancehelper_getClass(this).getName()));
	}

	
	
	protected internal virtual MethodDeclaration prettyPrint(MethodDeclaration methodDeclaration, string indent)
	{
		string methodDeclaration2 = new StringBuilder().append(indent).append(String.instancehelper_replaceAll(methodDeclaration.ToString(), "(\\R)", new StringBuilder().append("$1").append(indent).ToString())).ToString();
		return StaticJavaParser.parseMethodDeclaration(methodDeclaration2);
	}

	
		
	private void addOrReplaceMethod(ClassOrInterfaceDeclaration P_0, CallableDeclaration P_1, Runnable P_2)
	{
		List callablesWithSignature = P_0.getCallablesWithSignature(P_1.getSignature());
		if (callablesWithSignature.isEmpty())
		{
			P_2.run();
			return;
		}
		if (callablesWithSignature.size() > 1)
		{
			string detailMessage = CodeGenerationUtils.f("Wanted to regenerate a method with signature %s in %s, but found more than one, and unable to disambiguate.", P_1.getSignature(), P_0.getNameAsString());
			
			throw new AssertionError(detailMessage);
		}
		CallableDeclaration callableDeclaration = (CallableDeclaration)callablesWithSignature.get(0);
		P_1.getJavadocComment();
		callableDeclaration.getJavadocComment();
		Optional comment = P_1.getComment();
		callableDeclaration.getComment();
		P_1.setComment((Comment)comment.orElse(callableDeclaration.getComment().orElse(null)));
		annotateGenerated(P_1);
		if (P_1.isMethodDeclaration())
		{
			MethodDeclaration replacement = prettyPrint(P_1.asMethodDeclaration(), "    ");
			P_0.getMembers().replace(callableDeclaration, replacement);
		}
		else
		{
			P_0.getMembers().replace(callableDeclaration, P_1);
		}
	}

	
		
	private void annotate(NodeWithAnnotations P_0, Class P_1, Expression P_2)
	{
		NodeList annotations = (NodeList)P_0.getAnnotations().stream().filter(new ___003C_003EAnon1(P_1))
			.collect(NodeList.toNodeList());
		P_0.setAnnotations(annotations);
		if (P_2 != null)
		{
			P_0.addSingleMemberAnnotation(P_1.getSimpleName(), P_2);
		}
		else
		{
			P_0.addMarkerAnnotation(P_1.getSimpleName());
		}
		P_0.tryAddImportToParentCompilationUnit(P_1);
	}

	
		
	protected internal virtual void removeAnnotation(Node node, Class annotation)
	{
		((NodeWithAnnotations)node).getAnnotations().removeIf(new ___003C_003EAnon2(annotation));
		node.findAncestor(new Class[1] { ClassLiteral<CompilationUnit>.Value }).ifPresent(new ___003C_003EAnon3(this, annotation));
	}

	
	
	protected internal virtual EnumDeclaration prettyPrint(EnumDeclaration enumDeclaration, string indent)
	{
		string typeDeclaration = new StringBuilder().append(indent).append(String.instancehelper_replaceAll(enumDeclaration.ToString(), "(\\R)", new StringBuilder().append("$1").append(indent).ToString())).ToString();
		TypeDeclaration typeDeclaration2 = StaticJavaParser.parseTypeDeclaration(typeDeclaration);
		LexicalPreservingPrinter.setup(typeDeclaration2);
		EnumDeclaration result = typeDeclaration2.asEnumDeclaration();
		
		return result;
	}

	
	
	protected internal virtual SwitchStmt prettyPrint(SwitchStmt switchStmt, string indent)
	{
		string statement = new StringBuilder().append(indent).append(String.instancehelper_replaceAll(switchStmt.ToString(), "(\\R)", new StringBuilder().append("$1").append(indent).ToString())).ToString();
		Statement statement2 = StaticJavaParser.parseStatement(statement);
		LexicalPreservingPrinter.setup(statement2);
		SwitchStmt result = statement2.asSwitchStmt();
		
		return result;
	}

	
		
	protected internal virtual void removeAnnotationImportIfUnused(CompilationUnit compilationUnit, Class annotation)
	{
		List list = (List)compilationUnit.findAll(ClassLiteral<AnnotationExpr>.Value).stream().filter(new ___003C_003EAnon4(annotation))
			.collect(Collectors.toList());
		if (list.isEmpty())
		{
			compilationUnit.getImports().removeIf(new ___003C_003EAnon5(annotation));
		}
	}

	
	
	
	private void lambda_0024addOrReplaceWhenSameSignature_00240(CallableDeclaration P_0, ClassOrInterfaceDeclaration P_1)
	{
		annotateGenerated(P_0);
		P_1.addMember(P_0);
	}

	
	
	
	private static bool lambda_0024annotate_00241(Class P_0, AnnotationExpr P_1)
	{
		return (!String.instancehelper_equals(P_1.getNameAsString(), P_0.getSimpleName())) ? true : false;
	}

	
	
	
	private static bool lambda_0024removeAnnotation_00242(Class P_0, AnnotationExpr P_1)
	{
		bool result = String.instancehelper_equals(P_1.getName().asString(), P_0.getSimpleName());
		
		return result;
	}

	
	
	
	private void lambda_0024removeAnnotation_00243(Class P_0, CompilationUnit P_1)
	{
		removeAnnotationImportIfUnused(P_1, P_0);
	}

	
	
	
	private static bool lambda_0024removeAnnotationImportIfUnused_00244(Class P_0, AnnotationExpr P_1)
	{
		bool result = String.instancehelper_equals(P_1.getName().asString(), P_0.getSimpleName());
		
		return result;
	}

	
	
	
	private static bool lambda_0024removeAnnotationImportIfUnused_00245(Class P_0, ImportDeclaration P_1)
	{
		bool result = String.instancehelper_equals(P_1.getNameAsString(), P_0.getCanonicalName());
		
		return result;
	}

	
	
	
	private static void lambda_0024replaceWhenSameSignature_00246(CallableDeclaration P_0, ClassOrInterfaceDeclaration P_1)
	{
		string detailMessage = CodeGenerationUtils.f("Wanted to regenerate a method with signature %s in %s, but it wasn't there.", P_0.getSignature(), P_1.getNameAsString());
		
		throw new AssertionError(detailMessage);
	}

	
	
	
	private static bool lambda_0024getParsedCompilationUnitsFromSourceRoot_00247(ParseResult P_0)
	{
		return (!P_0.isSuccessful()) ? true : false;
	}

	
	
	protected internal AbstractGenerator(SourceRoot sourceRoot)
	{
		___003C_003EsourceRoot = sourceRoot;
	}

	
		
	protected internal virtual void addOrReplaceWhenSameSignature(ClassOrInterfaceDeclaration containingClassOrInterface, CallableDeclaration callable)
	{
		addOrReplaceMethod(containingClassOrInterface, callable, new ___003C_003EAnon0(this, callable, containingClassOrInterface));
	}

	
	protected internal virtual void after()
	{
	}

	
		
	protected internal virtual void removeGenerated(Node node)
	{
		removeAnnotation(node, ClassLiteral<Generated>.Value);
	}

	
	
	protected internal virtual void annotateOverridden(MethodDeclaration method)
	{
		annotate(method, ClassLiteral<Override>.Value, null);
	}

	
		
	protected internal virtual void annotateSuppressWarnings(NodeWithAnnotations node, string warningType)
	{
		annotate(node, ClassLiteral<SuppressWarnings>.Value, new StringLiteralExpr(warningType));
	}

	
		
	protected internal virtual void removeMethodWithSameSignature(ClassOrInterfaceDeclaration containingClassOrInterface, CallableDeclaration callable)
	{
		Iterator iterator = containingClassOrInterface.getCallablesWithSignature(callable.getSignature()).iterator();
		while (iterator.hasNext())
		{
			CallableDeclaration node = (CallableDeclaration)iterator.next();
			containingClassOrInterface.remove(node);
		}
	}

	
		
	protected internal virtual void replaceWhenSameSignature(ClassOrInterfaceDeclaration containingClassOrInterface, CallableDeclaration callable)
	{
		addOrReplaceMethod(containingClassOrInterface, callable, new ___003C_003EAnon6(callable, containingClassOrInterface));
	}

	
	
		
	protected internal virtual List getParsedCompilationUnitsFromSourceRoot(SourceRoot sourceRoot)
	{
		sourceRoot.getCompilationUnits();
		List list = sourceRoot.tryToParse();
		if (!list.stream().allMatch(new ___003C_003EAnon7()))
		{
			List list2 = (List)list.stream().filter(new ___003C_003EAnon8()).collect(Collectors.toList());
			for (int i = 0; i < list2.size(); i++)
			{
				ParseResult parseResult = (ParseResult)list2.get(i);
				List problems = parseResult.getProblems();
				Log.info("");
				Log.info(new StringBuilder().append("Problems (").append(i + 1).append(" of ")
					.append(list2.size())
					.append("): ")
					.ToString());
				Log.info(Object.instancehelper_toString(problems));
			}
			
			throw new IllegalStateException("Expected all files to parse.");
		}
		Log.info(new StringBuilder().append("parseResults.size() = ").append(list.size()).ToString());
		return (List)list.stream().map(new ___003C_003EAnon9()).map(new ___003C_003EAnon10())
			.collect(Collectors.toList());
	}

	
	
	protected internal virtual MethodDeclaration prettyPrint(MethodDeclaration methodDeclaration)
	{
		MethodDeclaration result = prettyPrint(methodDeclaration, "");
		
		return result;
	}

	
	
	protected internal virtual EnumDeclaration prettyPrint(EnumDeclaration enumDeclaration)
	{
		EnumDeclaration result = prettyPrint(enumDeclaration, "");
		
		return result;
	}

	
	
	protected internal virtual SwitchStmt prettyPrint(SwitchStmt switchStmt)
	{
		SwitchStmt result = prettyPrint(switchStmt, "");
		
		return result;
	}
}
