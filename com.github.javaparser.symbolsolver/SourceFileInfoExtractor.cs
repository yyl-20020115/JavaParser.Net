using System;

using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.javaparser;
using com.github.javaparser.symbolsolver.javaparsermodel;
using com.github.javaparser.symbolsolver.model.resolution;

using IKVM.Runtime;
using java.io;
using java.lang;
using java.nio.file;
using java.nio.file.attribute;
using java.util;
using java.util.function;

namespace com.github.javaparser.symbolsolver;

public class SourceFileInfoExtractor
{
	
		[EnclosingMethod(null, "solve", "(Ljava.nio.file.Path;)V")]
	internal class _1 : SimpleFileVisitor
	{
		
		private sealed class ___003C_003EAnon0 : Consumer
		{
			private readonly _1 arg_00241;

			internal ___003C_003EAnon0(_1 P_0)
			{
				arg_00241 = P_0;
			}

			public void accept(object P_0)
			{
				arg_00241.lambda_0024visitFile_00240((Node)P_0);
				
			}

			
			public Consumer andThen(Consumer P_0)
			{
				return Consumer._003Cdefault_003EandThen(this, P_0);
			}
		}

		
		internal SourceFileInfoExtractor this_00240;

		
		
		
		public virtual FileVisitResult visitFile(Path P_0, BasicFileAttributes P_1)
		{
			if (java.lang.String.instancehelper_endsWith(P_0.ToString(), ".java"))
			{
				if (access_0024000(this_00240))
				{
					access_0024100(this_00240).println(new StringBuilder().append("- parsing ").append(P_0.toAbsolutePath()).ToString());
				}
				CompilationUnit compilationUnit = StaticJavaParser.parse(P_0);
				List list = access_0024200(this_00240, compilationUnit);
				list.forEach(new ___003C_003EAnon0(this));
			}
			return FileVisitResult.CONTINUE;
		}

		
		
		
		private void lambda_0024visitFile_00240(Node P_0)
		{
			access_0024300(this_00240, P_0);
		}

		
		
		internal _1(SourceFileInfoExtractor P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		
		
		
		
		public override FileVisitResult visitFile(object P_0, BasicFileAttributes P_1)
		{
			FileVisitResult result = visitFile((Path)P_0, P_1);
			
			return result;
		}
	}

	
		[EnclosingMethod(null, "solveMethodCalls", "(Ljava.nio.file.Path;)V")]
	internal class _2 : SimpleFileVisitor
	{
		
		internal SourceFileInfoExtractor this_00240;

		
		
		internal _2(SourceFileInfoExtractor P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		
		
		
		public virtual FileVisitResult visitFile(Path P_0, BasicFileAttributes P_1)
		{
			if (java.lang.String.instancehelper_endsWith(P_0.ToString(), ".java"))
			{
				if (access_0024000(this_00240))
				{
					access_0024100(this_00240).println(new StringBuilder().append("- parsing ").append(P_0.toAbsolutePath()).ToString());
				}
				CompilationUnit compilationUnit = StaticJavaParser.parse(P_0);
				access_0024400(this_00240, compilationUnit);
			}
			return FileVisitResult.CONTINUE;
		}

		
		
		
		
		public override FileVisitResult visitFile(object P_0, BasicFileAttributes P_1)
		{
			FileVisitResult result = visitFile((Path)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon0 : Consumer
	{
		private readonly List arg_00241;

		internal ___003C_003EAnon0(List P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.add((Node)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Function
	{
		internal ___003C_003EAnon1()
		{
		}

		public object apply(object P_0)
		{
			Position result = lambda_0024collectAllNodes_00240((Node)P_0);
			
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
			Integer result = lambda_0024lineNr_00241((Range)P_0);
			
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

	
	private sealed class ___003C_003EAnon3 : Supplier
	{
		internal ___003C_003EAnon3()
		{
		}

		public object get()
		{
			IllegalStateException result = new IllegalStateException();
			
			return result;
		}
	}

	
	private TypeSolver typeSolver;

	private int successes;

	private int failures;

	private int unsupported;

	private bool printFileName;

	private PrintStream @out;

	private PrintStream err;

	private bool verbose;

	
	
	internal static bool access_0024000(SourceFileInfoExtractor P_0)
	{
		return P_0.printFileName;
	}

	
	
	internal static PrintStream access_0024100(SourceFileInfoExtractor P_0)
	{
		return P_0.@out;
	}

	
	
	
	internal static List access_0024200(SourceFileInfoExtractor P_0, Node P_1)
	{
		List result = P_0.collectAllNodes(P_1);
		
		return result;
	}

	
	
	
	internal static void access_0024300(SourceFileInfoExtractor P_0, Node P_1)
	{
		P_0.solve(P_1);
	}

	
	
	private void solveMethodCalls(Node P_0)
	{
		if (P_0 is MethodCallExpr)
		{
			@out.println(new StringBuilder().append("  Line ").append(lineNr(P_0)).append(") ")
				.append(P_0)
				.append(" ==> ")
				.append(toString((MethodCallExpr)P_0))
				.ToString());
		}
		Iterator iterator = P_0.getChildNodes().iterator();
		while (iterator.hasNext())
		{
			Node node = (Node)iterator.next();
			solveMethodCalls(node);
		}
	}

	
	
	private void solve(Node P_0)
	{
		RuntimeException ex3;
		if (P_0 is ClassOrInterfaceDeclaration)
		{
			solveTypeDecl((ClassOrInterfaceDeclaration)P_0);
		}
		else
		{
			if (!(P_0 is Expression))
			{
				return;
			}
			Node node = Navigator.demandParentNode(P_0);
			if (node is ImportDeclaration || node is Expression || node is MethodDeclaration || node is PackageDeclaration || (!(node is Statement) && !(node is VariableDeclarator) && !(node is SwitchEntry)))
			{
				return;
			}
			UnsupportedOperationException ex;
			try
			{
				try
				{
					ResolvedType type = JavaParserFacade.get(typeSolver).getType(P_0);
					@out.println(new StringBuilder().append("  Line ").append(lineNr(P_0)).append(") ")
						.append(P_0)
						.append(" ==> ")
						.append(type.describe())
						.ToString());
					successes++;
					return;
				}
				catch (UnsupportedOperationException x)
				{
					ex = ByteCodeHelper.MapException<UnsupportedOperationException>(x, ByteCodeHelper.MapFlags.NoRemapping);
				}
			}
			catch (System.Exception x2)
			{
				RuntimeException ex2 = ByteCodeHelper.MapException<RuntimeException>(x2, ByteCodeHelper.MapFlags.None);
				if (ex2 == null)
				{
					throw;
				}
				ex3 = ex2;
				goto IL_00f7;
			}
			UnsupportedOperationException ex4 = ex;
			unsupported++;
			err.println(Throwable.instancehelper_getMessage(ex4));
			throw (ex4);
		}
		return;
		IL_00f7:
		RuntimeException ex5 = ex3;
		failures++;
		err.println(Throwable.instancehelper_getMessage(ex5));
		throw (ex5);
	}

	
		
	private unsafe List collectAllNodes(Node P_0)
	{
		ArrayList arrayList = new ArrayList();
		
		P_0.walk(new ___003C_003EAnon0(arrayList));
		((List)arrayList).sort(Comparator.comparing(new ___003C_003EAnon1()));
		return arrayList;
	}

	
	
	private void solveTypeDecl(ClassOrInterfaceDeclaration P_0)
	{
		ResolvedReferenceTypeDeclaration typeDeclaration = JavaParserFacade.get(typeSolver).getTypeDeclaration(P_0);
		if (typeDeclaration.isClass())
		{
			@out.println(new StringBuilder().append("\n[ Class ").append(typeDeclaration.getQualifiedName()).append(" ]")
				.ToString());
			Iterator iterator = typeDeclaration.asClass().getAllSuperClasses().iterator();
			while (iterator.hasNext())
			{
				ResolvedReferenceType resolvedReferenceType = (ResolvedReferenceType)iterator.next();
				@out.println(new StringBuilder().append("  superclass: ").append(resolvedReferenceType.getQualifiedName()).ToString());
			}
			iterator = typeDeclaration.asClass().getAllInterfaces().iterator();
			while (iterator.hasNext())
			{
				ResolvedReferenceType resolvedReferenceType = (ResolvedReferenceType)iterator.next();
				@out.println(new StringBuilder().append("  interface: ").append(resolvedReferenceType.getQualifiedName()).ToString());
			}
		}
	}

	
	
	private int lineNr(Node P_0)
	{
		int result = ((Integer)P_0.getRange().map(new ___003C_003EAnon2()).orElseThrow(new ___003C_003EAnon3())).intValue();
		
		return result;
	}

	
	
	private string toString(MethodCallExpr P_0)
	{
		//Discarded unreachable code: IL_0019
		System.Exception ex2;
		try
		{
			return toString(JavaParserFacade.get(typeSolver).solve(P_0));
		}
		catch (System.Exception x)
		{
			System.Exception ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
			if (ex == null)
			{
				throw;
			}
			ex2 = ex;
		}
		System.Exception @this = ex2;
		if (verbose)
		{
			java.lang.System.err.println(new StringBuilder().append("Error resolving call at L").append(lineNr(P_0)).append(": ")
				.append(P_0)
				.ToString());
			Throwable.instancehelper_printStackTrace(@this);
		}
		return "ERROR";
	}

	
		
	private string toString(SymbolReference P_0)
	{
		if (P_0.isSolved())
		{
			string qualifiedSignature = ((ResolvedMethodDeclaration)P_0.getCorrespondingDeclaration()).getQualifiedSignature();
			
			return qualifiedSignature;
		}
		return "UNSOLVED";
	}

	
	
	
	private static Position lambda_0024collectAllNodes_00240(Node P_0)
	{
		return (Position)P_0.getBegin().get();
	}

	
	
	
	private static Integer lambda_0024lineNr_00241(Range P_0)
	{
		Integer result = Integer.valueOf(P_0.___003C_003Ebegin.___003C_003Eline);
		
		return result;
	}

	
	
	public SourceFileInfoExtractor(TypeSolver typeSolver)
	{
		successes = 0;
		failures = 0;
		unsupported = 0;
		printFileName = true;
		@out = java.lang.System.@out;
		err = java.lang.System.err;
		verbose = false;
		this.typeSolver = typeSolver;
	}

	public virtual void setVerbose(bool verbose)
	{
		int num = ((this.verbose = verbose) ? 1 : 0);
	}

	public virtual void setPrintFileName(bool printFileName)
	{
		int num = ((this.printFileName = printFileName) ? 1 : 0);
	}

	public virtual void setOut(PrintStream @out)
	{
		this.@out = @out;
	}

	public virtual void setErr(PrintStream err)
	{
		this.err = err;
	}

	public virtual int getSuccesses()
	{
		return successes;
	}

	public virtual int getUnsupported()
	{
		return unsupported;
	}

	public virtual int getFailures()
	{
		return failures;
	}

	
	
	
	public virtual void solve(Path path)
	{
		Files.walkFileTree(path, new _1(this));
	}

	
	
	
	public virtual void solveMethodCalls(Path path)
	{
		Files.walkFileTree(path, new _2(this));
	}

	
	
	
	internal static void access_0024400(SourceFileInfoExtractor P_0, Node P_1)
	{
		P_0.solveMethodCalls(P_1);
	}
}
