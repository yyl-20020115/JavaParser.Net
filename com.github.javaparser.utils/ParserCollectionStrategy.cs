

using IKVM.Runtime;
using java.io;
using java.lang;
using java.nio.file;
using java.nio.file.attribute;
using java.util;
using java.util.function;

namespace com.github.javaparser.utils;

public class ParserCollectionStrategy: CollectionStrategy
{
	
		[EnclosingMethod(null, "collect", "(Ljava.nio.file.Path;)Lcom.github.javaparser.utils.ProjectRoot;")]
	internal class _1 : SimpleFileVisitor
	{
		internal Path current_root;

		
		internal PathMatcher javaMatcher;

		
		internal ProjectRoot val_0024projectRoot;

		
		internal ParserCollectionStrategy this_00240;

		
		
		
		
		public virtual FileVisitResult postVisitDirectory(Path dir, IOException e)
		{
			if (current_root != null && Files.isSameFile(dir, current_root))
			{
				val_0024projectRoot.addSourceRoot(dir);
				current_root = null;
			}
			return FileVisitResult.CONTINUE;
		}

		
		
		
		public virtual FileVisitResult visitFile(Path file, BasicFileAttributes attrs)
		{
			if (String.instancehelper_equals(file.getFileName().ToString(), "module-info.java"))
			{
				return FileVisitResult.CONTINUE;
			}
			if (javaMatcher.matches(file))
			{
				current_root = (Path)this_00240.getRoot(file).orElse(null);
				if (current_root != null)
				{
					return FileVisitResult.SKIP_SIBLINGS;
				}
			}
			return FileVisitResult.CONTINUE;
		}

		
		
		
		
		public virtual FileVisitResult preVisitDirectory(Path dir, BasicFileAttributes attrs)
		{
			if (Files.isHidden(dir) || (current_root != null && dir.startsWith(current_root)))
			{
				return FileVisitResult.SKIP_SUBTREE;
			}
			return FileVisitResult.CONTINUE;
		}

		
		
		
		internal _1(ParserCollectionStrategy this_00240, ProjectRoot val_0024projectRoot)
		{
			this.this_00240 = this_00240;
			this.val_0024projectRoot = val_0024projectRoot;
			
			javaMatcher = this.this_00240.getPathMatcher("glob:**.java");
		}

		
		
		
		
		
		public override FileVisitResult postVisitDirectory(object dir, IOException e)
		{
			FileVisitResult result = postVisitDirectory((Path)dir, e);
			
			return result;
		}

		
		
		
		
		
		public override FileVisitResult visitFile(object file, BasicFileAttributes attrs)
		{
			FileVisitResult result = visitFile((Path)file, attrs);
			
			return result;
		}

		
		
		
		
		
		public override FileVisitResult preVisitDirectory(object dir, BasicFileAttributes attrs)
		{
			FileVisitResult result = preVisitDirectory((Path)dir, attrs);
			
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


	public virtual PathMatcher getPathMatcher(string P_0)
	{
		return CollectionStrategy._003Cdefault_003EgetPathMatcher(this, P_0);
	}


	public virtual Optional getRoot(Path P_0)
	{
		return CollectionStrategy._003Cdefault_003EgetRoot(this, P_0);
	}

	
	
	
	public ParserCollectionStrategy(ParserConfiguration parserConfiguration)
	{
		this.parserConfiguration = parserConfiguration;
	}

	
	
	private static object lambda_0024collect_00240(Path path)
	{
		return path;
	}

	
	
	public ParserCollectionStrategy()
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
