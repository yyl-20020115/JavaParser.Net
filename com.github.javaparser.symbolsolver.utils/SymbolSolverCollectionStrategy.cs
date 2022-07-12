
using com.github.javaparser.symbolsolver.resolution.typesolvers;
using com.github.javaparser.utils;

using IKVM.Runtime;
using java.io;
using java.lang;
using java.nio.file;
using java.nio.file.attribute;
using java.util;
using java.util.function;

namespace com.github.javaparser.symbolsolver.utils;

public class SymbolSolverCollectionStrategy: CollectionStrategy
{
	
		[EnclosingMethod(null, "collect", "(Ljava.nio.file.Path;)Lcom.github.javaparser.utils.ProjectRoot;")]
	internal class _1 : SimpleFileVisitor
	{
		
		private sealed class ___003C_003EAnon0 : Supplier
		{
			private readonly Path arg_00241;

			internal ___003C_003EAnon0(Path P_0)
			{
				arg_00241 = P_0;
			}

			public object get()
			{
				object result = lambda_0024visitFile_00240(arg_00241);
				
				return result;
			}
		}

		
		private sealed class ___003C_003EAnon1 : Supplier
		{
			private readonly _1 arg_00241;

			internal ___003C_003EAnon1(_1 P_0)
			{
				arg_00241 = P_0;
			}

			public object get()
			{
				object result = arg_00241.lambda_0024visitFile_00241();
				
				return result;
			}
		}

		
		private sealed class ___003C_003EAnon2 : Supplier
		{
			private readonly Path arg_00241;

			internal ___003C_003EAnon2(Path P_0)
			{
				arg_00241 = P_0;
			}

			public object get()
			{
				object result = lambda_0024visitFile_00242(arg_00241);
				
				return result;
			}
		}

		
		private sealed class ___003C_003EAnon3 : Supplier
		{
			private readonly Path arg_00241;

			internal ___003C_003EAnon3(Path P_0)
			{
				arg_00241 = P_0;
			}

			public object get()
			{
				object result = lambda_0024preVisitDirectory_00243(arg_00241);
				
				return result;
			}
		}

		
		private sealed class ___003C_003EAnon4 : Supplier
		{
			private readonly Path arg_00241;

			internal ___003C_003EAnon4(Path P_0)
			{
				arg_00241 = P_0;
			}

			public object get()
			{
				object result = lambda_0024postVisitDirectory_00244(arg_00241);
				
				return result;
			}
		}

		private Path current_root;

		private Path currentProjectDir;

		private string previousSourceDirectory;

		
		private PathMatcher javaMatcher;

		
		private PathMatcher jarMatcher;

		
		internal ProjectRoot val_0024projectRoot;

		
		internal SymbolSolverCollectionStrategy this_00240;

		
		
		
		public virtual FileVisitResult postVisitDirectory(Path P_0, IOException P_1)
		{
			if (current_root != null && Files.isSameFile(P_0, current_root))
			{
				Log.info("Adding source root %s", new ___003C_003EAnon4(P_0));
				val_0024projectRoot.addSourceRoot(P_0);
				access_0024000(this_00240).add(new JavaParserTypeSolver(current_root.toFile(), access_0024100(this_00240)));
				current_root = null;
			}
			return FileVisitResult.CONTINUE;
		}

		
		
		
		public virtual FileVisitResult visitFile(Path P_0, BasicFileAttributes P_1)
		{
			if (javaMatcher.matches(P_0))
			{
				string @this = P_0.getParent().ToString();
				if (!String.instancehelper_equals(@this, previousSourceDirectory))
				{
					Log.info("Trying to compute the source root from %s", new ___003C_003EAnon0(P_0));
					previousSourceDirectory = @this;
					currentProjectDir = (Path)this_00240.getRoot(P_0).orElse(null);
				}
				if (current_root == null || (currentProjectDir != null && !currentProjectDir.equals(current_root)))
				{
					current_root = currentProjectDir;
					if (current_root != null)
					{
						Log.info("New current source root is %s", new ___003C_003EAnon1(this));
					}
				}
			}
			else if (jarMatcher.matches(P_0))
			{
				Log.info("Jar file is found %s", new ___003C_003EAnon2(P_0));
				access_0024000(this_00240).add(new JarTypeSolver(P_0.ToString()));
			}
			return FileVisitResult.CONTINUE;
		}

		
		
		
		public virtual FileVisitResult preVisitDirectory(Path P_0, BasicFileAttributes P_1)
		{
			if (Files.isHidden(P_0))
			{
				Log.info("Skipping sub-tree %s", new ___003C_003EAnon3(P_0));
				return FileVisitResult.SKIP_SUBTREE;
			}
			return FileVisitResult.CONTINUE;
		}

		
		
		
		private static object lambda_0024visitFile_00240(Path P_0)
		{
			string result = P_0.ToString();
			
			return result;
		}

		
		
		
		private object lambda_0024visitFile_00241()
		{
			string result = current_root.ToString();
			
			return result;
		}

		
		
		
		private static object lambda_0024visitFile_00242(Path P_0)
		{
			string result = P_0.ToString();
			
			return result;
		}

		
		
		
		private static object lambda_0024preVisitDirectory_00243(Path P_0)
		{
			string result = P_0.ToString();
			
			return result;
		}

		
		
		
		private static object lambda_0024postVisitDirectory_00244(Path P_0)
		{
			string result = P_0.ToString();
			
			return result;
		}

		
		
		internal _1(SymbolSolverCollectionStrategy P_0, ProjectRoot P_1)
		{
			this_00240 = P_0;
			val_0024projectRoot = P_1;
			
			javaMatcher = this_00240.getPathMatcher("glob:**.java");
			jarMatcher = this_00240.getPathMatcher("glob:**.jar");
		}

		
		
		
		
		public override FileVisitResult postVisitDirectory(object P_0, IOException P_1)
		{
			FileVisitResult result = postVisitDirectory((Path)P_0, P_1);
			
			return result;
		}

		
		
		
		
		public override FileVisitResult visitFile(object P_0, BasicFileAttributes P_1)
		{
			FileVisitResult result = visitFile((Path)P_0, P_1);
			
			return result;
		}

		
		
		
		
		public override FileVisitResult preVisitDirectory(object P_0, BasicFileAttributes P_1)
		{
			FileVisitResult result = preVisitDirectory((Path)P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon0 : Supplier
	{
		private readonly Path arg_00241;

		internal ___003C_003EAnon0(Path P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			object result = lambda_0024collect_00240(arg_00241);
			
			return result;
		}
	}

	
	private ParserConfiguration parserConfiguration;

	
	private CombinedTypeSolver typeSolver;

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual PathMatcher getPathMatcher(string P_0)
	{
		return CollectionStrategy._003Cdefault_003EgetPathMatcher(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional getRoot(Path P_0)
	{
		return CollectionStrategy._003Cdefault_003EgetRoot(this, P_0);
	}

	
	
	internal static CombinedTypeSolver access_0024000(SymbolSolverCollectionStrategy P_0)
	{
		return P_0.typeSolver;
	}

	
	
	internal static ParserConfiguration access_0024100(SymbolSolverCollectionStrategy P_0)
	{
		return P_0.parserConfiguration;
	}

	
	
	public SymbolSolverCollectionStrategy(ParserConfiguration parserConfiguration)
	{
		typeSolver = new CombinedTypeSolver(new ReflectionTypeSolver(jreOnly: false));
		this.parserConfiguration = parserConfiguration;
		if (!parserConfiguration.getSymbolResolver().isPresent())
		{
			this.parserConfiguration.setSymbolResolver(new JavaSymbolSolver(typeSolver));
		}
	}

	
	private static object lambda_0024collect_00240(Path P_0)
	{
		return P_0;
	}

	
	
	public SymbolSolverCollectionStrategy()
		: this(new ParserConfiguration())
	{
	}

	public virtual ParserConfiguration getParserConfiguration()
	{
		return parserConfiguration;
	}

	
	
	public virtual ProjectRoot collect(Path path)
	{
		ProjectRoot projectRoot = new ProjectRoot(path, parserConfiguration);
		IOException ex;
		try
		{
			Files.walkFileTree(path, new _1(this, projectRoot));
			return projectRoot;
		}
		catch (IOException x)
		{
			ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		IOException throwable = ex;
		Log.error(throwable, "Unable to walk %s", new ___003C_003EAnon0(path));
		return projectRoot;
	}
}
