using System;



using com.github.javaparser.ast;
using com.github.javaparser.printer;

using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.nio.charset;
using java.nio.file;
using java.nio.file.attribute;
using java.util;
using java.util.concurrent;
using java.util.function;
using java.util.regex;
using java.util.stream;

namespace com.github.javaparser.utils;

public class SourceRoot
{
	
		[EnclosingMethod(null, "tryToParse", "(Ljava.lang.String;)Ljava.util.List;")]
	internal class _1 : SimpleFileVisitor
	{
		
		internal SourceRoot this_00240;

		
		
		
		
		public virtual FileVisitResult visitFile(Path file, BasicFileAttributes attrs)
		{
			if (!attrs.isDirectory() && java.lang.String.instancehelper_endsWith(file.ToString(), ".java"))
			{
				Path path = access_0024000(this_00240).relativize(file.getParent());
				this_00240.tryToParse(path.ToString(), file.getFileName().ToString());
			}
			return FileVisitResult.CONTINUE;
		}

		
		
		
		
		public virtual FileVisitResult preVisitDirectory(Path dir, BasicFileAttributes attrs)
		{
			return (!this_00240.isSensibleDirectoryToEnter(dir)) ? FileVisitResult.SKIP_SUBTREE : FileVisitResult.CONTINUE;
		}

		
		
		
		internal _1(SourceRoot this_00240)
		{
			this.this_00240 = this_00240;
			base._002Ector();
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

	
		[EnclosingMethod(null, "parse", "(Ljava.lang.String;Lcom.github.javaparser.ParserConfiguration;Lcom.github.javaparser.utils.SourceRoot$Callback;)Lcom.github.javaparser.utils.SourceRoot;")]
	internal class _2 : SimpleFileVisitor
	{
		
		internal ParserConfiguration val_0024configuration;

		
		internal Callback val_0024callback;

		
		internal SourceRoot this_00240;

		
		
		
		internal _2(SourceRoot this_00240, ParserConfiguration val_0024callback, Callback val_0024configuration)
		{
			this.this_00240 = this_00240;
			this.val_0024configuration = val_0024callback;
			this.val_0024callback = val_0024configuration;
			base._002Ector();
		}

		
		
		
		
		public virtual FileVisitResult visitFile(Path absolutePath, BasicFileAttributes attrs)
		{
			if (!attrs.isDirectory() && java.lang.String.instancehelper_endsWith(absolutePath.ToString(), ".java"))
			{
				FileVisitResult result = access_0024100(this_00240, absolutePath, val_0024configuration, val_0024callback);
				
				return result;
			}
			return FileVisitResult.CONTINUE;
		}

		
		
		
		
		public virtual FileVisitResult preVisitDirectory(Path dir, BasicFileAttributes attrs)
		{
			return (!this_00240.isSensibleDirectoryToEnter(dir)) ? FileVisitResult.SKIP_SUBTREE : FileVisitResult.CONTINUE;
		}

		
		
		
		
		
		public override FileVisitResult visitFile(object absolutePath, BasicFileAttributes attrs)
		{
			FileVisitResult result = visitFile((Path)absolutePath, attrs);
			
			return result;
		}

		
		
		
		
		
		public override FileVisitResult preVisitDirectory(object dir, BasicFileAttributes attrs)
		{
			FileVisitResult result = preVisitDirectory((Path)dir, attrs);
			
			return result;
		}
	}

	
	
	
	
	internal class _3
	{
		
		internal static int[] _0024SwitchMap_0024com_0024github_0024javaparser_0024utils_0024SourceRoot_0024Callback_0024Result;

		
		
		public static void ___003Cclinit_003E()
		{
		}

		
		static _3()
		{
			_0024SwitchMap_0024com_0024github_0024javaparser_0024utils_0024SourceRoot_0024Callback_0024Result = new int[(nint)Callback.Result.values().LongLength];
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024utils_0024SourceRoot_0024Callback_0024Result[Callback.Result.___003C_003ESAVE.ordinal()] = 1;
			}
			catch (System.Exception x)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0033;
			}
			goto IL_0039;
			IL_0033:
			
			goto IL_0039;
			IL_0039:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024utils_0024SourceRoot_0024Callback_0024Result[Callback.Result.___003C_003EDONT_SAVE.ordinal()] = 2;
			}
			catch (System.Exception x2)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x2, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_005c;
			}
			goto IL_0062;
			IL_005c:
			
			goto IL_0062;
			IL_0062:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024utils_0024SourceRoot_0024Callback_0024Result[Callback.Result.___003C_003ETERMINATE.ordinal()] = 3;
				return;
			}
			catch (System.Exception x3)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x3, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
			}
			
		}

		_3()
		{
			throw null;
		}
	}

	[FunctionalInterface(new object[]
	{
		(byte)64,
		"Ljava/lang/FunctionalInterface;"
	})]
	public interface Callback
	{
		
		
				
		public class Result : java.lang.Enum
		{
			
			
			public enum __Enum
			{
				SAVE,
				DONT_SAVE,
				TERMINATE
			}

			
			internal static Result ___003C_003ESAVE;

			
			internal static Result ___003C_003EDONT_SAVE;

			
			internal static Result ___003C_003ETERMINATE;

			
			private static Result[] _0024VALUES;

			
			public static Result SAVE
			{
				
				get
				{
					return ___003C_003ESAVE;
				}
			}

			
			public static Result DONT_SAVE
			{
				
				get
				{
					return ___003C_003EDONT_SAVE;
				}
			}

			
			public static Result TERMINATE
			{
				
				get
				{
					return ___003C_003ETERMINATE;
				}
			}

			
			
			public static void ___003Cclinit_003E()
			{
			}

			
			
			public static Result[] values()
			{
				return (Result[])_0024VALUES.Clone();
			}

			
						
			
			private Result(string _0024enum_0024name, int _0024enum_0024ordinal)
				: base(_0024enum_0024name, _0024enum_0024ordinal)
			{
				GC.KeepAlive(this);
			}

			
			
			
			public static Result valueOf(string name)
			{
				return (Result)java.lang.Enum.valueOf(ClassLiteral<Result>.Value, name);
			}

			
			static Result()
			{
				___003C_003ESAVE = new Result("SAVE", 0);
				___003C_003EDONT_SAVE = new Result("DONT_SAVE", 1);
				___003C_003ETERMINATE = new Result("TERMINATE", 2);
				_0024VALUES = new Result[3] { ___003C_003ESAVE, ___003C_003EDONT_SAVE, ___003C_003ETERMINATE };
			}
		}

				
		virtual Result process(Path localPath, Path absolutePath, ParseResult result);
	}

	
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	internal class ParallelParse : RecursiveAction
	{
		
				[EnclosingMethod(null, "compute", "()V")]
		internal class _1 : SimpleFileVisitor
		{
			
			internal Path val_0024path;

			
			internal List val_0024walks;

			
			internal ParallelParse this_00240;

			
			
			
			public virtual FileVisitResult visitFile(Path file, BasicFileAttributes attrs)
			{
				FileVisitResult result = access_0024300(this_00240).process(file, attrs);
				
				return result;
			}

			
			
			
			
			public virtual FileVisitResult preVisitDirectory(Path dir, BasicFileAttributes attrs)
			{
				if (!access_0024200(this_00240).isSensibleDirectoryToEnter(dir))
				{
					return FileVisitResult.SKIP_SUBTREE;
				}
				if (!dir.equals(val_0024path))
				{
					___003Cclinit_003E();
					ParallelParse parallelParse = new ParallelParse(dir, access_0024300(this_00240));
					parallelParse.fork();
					val_0024walks.add(parallelParse);
					return FileVisitResult.SKIP_SUBTREE;
				}
				return FileVisitResult.CONTINUE;
			}

			
			
			
			internal _1(ParallelParse this_00240, Path val_0024walks, List val_0024path)
			{
				this.this_00240 = this_00240;
				this.val_0024path = val_0024walks;
				this.val_0024walks = val_0024path;
				base._002Ector();
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

		internal interface VisitFileCallback
		{
			
			virtual FileVisitResult process(Path file, BasicFileAttributes attrs);
		}

		private const long serialVersionUID = 1L;

		
		private SourceRoot root;

		
		private VisitFileCallback callback;

		
		
		public new static void ___003Cclinit_003E()
		{
		}

		
		
		
		internal ParallelParse(Path path, VisitFileCallback callback)
		{
			root = new SourceRoot(path);
			this.callback = callback;
		}

		
		
		internal static SourceRoot access_0024200(ParallelParse P_0)
		{
			return P_0.root;
		}

		
		
		internal static VisitFileCallback access_0024300(ParallelParse P_0)
		{
			return P_0.callback;
		}

		
		
		protected internal override void compute()
		{
			ArrayList arrayList = new ArrayList();
			Path path = root.getRoot();
			IOException ex;
			try
			{
				Files.walkFileTree(path, new _1(this, path, arrayList));
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_0030;
			}
			goto IL_003c;
			IL_0030:
			IOException throwable = ex;
			Log.error(throwable);
			goto IL_003c;
			IL_003c:
			Iterator iterator = ((List)arrayList).iterator();
			while (iterator.hasNext())
			{
				ParallelParse parallelParse = (ParallelParse)iterator.next();
				parallelParse.join();
			}
		}

		
		static ParallelParse()
		{
			RecursiveAction.___003Cclinit_003E();
		}

		
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected ParallelParse(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	
	private sealed class ___003C_003EAnon0 : Function
	{
		private readonly DefaultPrettyPrinter arg_00241;

		internal ___003C_003EAnon0(DefaultPrettyPrinter P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			string result = arg_00241.print((CompilationUnit)P_0);
			
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
		private readonly SourceRoot arg_00241;

		internal ___003C_003EAnon1(SourceRoot P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			object result = arg_00241.lambda_0024new_00240();
			
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
			object result = lambda_0024tryToParse_00241(arg_00241);
			
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
			object result = lambda_0024tryToParse_00242(arg_00241);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon4 : Consumer
	{
		private readonly Path arg_00241;

		private readonly ParserConfiguration arg_00242;

		internal ___003C_003EAnon4(Path P_0, ParserConfiguration P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			lambda_0024tryToParse_00243(arg_00241, arg_00242, (CompilationUnit)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon5 : Supplier
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon5(string P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			object result = lambda_0024isSensibleDirectoryToEnter_00244(arg_00241);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon6 : ParallelParse.VisitFileCallback
	{
		private readonly SourceRoot arg_00241;

		internal ___003C_003EAnon6(SourceRoot P_0)
		{
			arg_00241 = P_0;
		}

		public FileVisitResult process(Path P_0, BasicFileAttributes P_1)
		{
			FileVisitResult result = arg_00241.lambda_0024tryToParseParallelized_00245(P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon7 : Supplier
	{
		private readonly Path arg_00241;

		internal ___003C_003EAnon7(Path P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			object result = lambda_0024callback_00246(arg_00241);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon8 : Consumer
	{
		private readonly Path arg_00241;

		private readonly ParserConfiguration arg_00242;

		internal ___003C_003EAnon8(Path P_0, ParserConfiguration P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			lambda_0024callback_00247(arg_00241, arg_00242, (CompilationUnit)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon9 : Consumer
	{
		private readonly SourceRoot arg_00241;

		private readonly Path arg_00242;

		internal ___003C_003EAnon9(SourceRoot P_0, Path P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024callback_00248(arg_00242, (CompilationUnit)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon10 : Supplier
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon10(string P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			object result = lambda_0024logPackage_00249(arg_00241);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon11 : ParallelParse.VisitFileCallback
	{
		private readonly SourceRoot arg_00241;

		private readonly ParserConfiguration arg_00242;

		private readonly Callback arg_00243;

		internal ___003C_003EAnon11(SourceRoot P_0, ParserConfiguration P_1, Callback P_2)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
		}

		public FileVisitResult process(Path P_0, BasicFileAttributes P_1)
		{
			FileVisitResult result = arg_00241.lambda_0024parseParallelized_002410(arg_00242, arg_00243, P_0, P_1);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon12 : Supplier
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon12(string P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			object result = lambda_0024add_002411(arg_00241);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon13 : Supplier
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon13(string P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			object result = lambda_0024add_002412(arg_00241);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon14 : Supplier
	{
		private readonly Path arg_00241;

		internal ___003C_003EAnon14(Path P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			object result = lambda_0024add_002413(arg_00241);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon15 : Supplier
	{
		private readonly Map arg_00241;

		internal ___003C_003EAnon15(Map P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			//IL_000e: Expected O, but got I4
			int num = arg_00241.size();
			
			return num;
		}
	}

	
	private sealed class ___003C_003EAnon16 : Supplier
	{
		private readonly Path arg_00241;

		internal ___003C_003EAnon16(Path P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			object result = lambda_0024saveAll_002414(arg_00241);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon17 : Supplier
	{
		private readonly Path arg_00241;

		internal ___003C_003EAnon17(Path P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			object result = lambda_0024saveAll_002415(arg_00241);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon18 : Predicate
	{
		internal ___003C_003EAnon18()
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

	
	private sealed class ___003C_003EAnon19 : Function
	{
		internal ___003C_003EAnon19()
		{
		}

		public object apply(object P_0)
		{
			CompilationUnit result = lambda_0024getCompilationUnits_002416((ParseResult)P_0);
			
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

	
	private Path root;

	
		private Map cache;

	private ParserConfiguration parserConfiguration;

		private Function printer;

	
	private static Pattern JAVA_IDENTIFIER;

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
	
	
	public SourceRoot(Path root, ParserConfiguration parserConfiguration)
		: this(root)
	{
		setParserConfiguration(parserConfiguration);
	}

	
	
	public virtual SourceRoot saveAll()
	{
		SourceRoot result = saveAll(root);
		
		return result;
	}

	
	
	
	public virtual CompilationUnit parse(string startPackage, string filename)
	{
		Utils.assertNotNull(startPackage);
		Utils.assertNotNull(filename);
		IOException ex;
		try
		{
			ParseResult parseResult = tryToParse(startPackage, filename);
			if (parseResult.isSuccessful())
			{
				return (CompilationUnit)parseResult.getResult().get();
			}
			List problems = parseResult.getProblems();
			
			throw new ParseProblemException(problems);
		}
		catch (IOException x)
		{
			ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		IOException throwable = ex;
		
		throw new ParseProblemException(throwable);
	}

	
	
		
	
	public virtual ParseResult tryToParse(string startPackage, string filename)
	{
		ParseResult result = tryToParse(startPackage, filename, parserConfiguration);
		
		return result;
	}

	public virtual Path getRoot()
	{
		return root;
	}

	
	
	
	public unsafe SourceRoot(Path root)
	{
		cache = new ConcurrentHashMap();
		parserConfiguration = new ParserConfiguration();
		DefaultPrettyPrinter defaultPrettyPrinter = new DefaultPrettyPrinter();
		
		printer = new ___003C_003EAnon0(defaultPrettyPrinter);
		Utils.assertNotNull(root);
		if (!Files.isDirectory(root))
		{
			string s = new StringBuilder().append("Only directories are allowed as root path: ").append(root).ToString();
			
			throw new IllegalArgumentException(s);
		}
		this.root = root.normalize();
		Log.info("New source root at \"%s\"", new ___003C_003EAnon1(this));
	}

	
	
	
	public virtual SourceRoot setParserConfiguration(ParserConfiguration parserConfiguration)
	{
		Utils.assertNotNull(parserConfiguration);
		this.parserConfiguration = parserConfiguration;
		return this;
	}

	
	
	internal static Path access_0024000(SourceRoot P_0)
	{
		return P_0.root;
	}

	
	
	
	
	internal virtual bool isSensibleDirectoryToEnter(Path dir)
	{
		string text = dir.getFileName().ToString();
		Pattern jAVA_IDENTIFIER = JAVA_IDENTIFIER;
		CharSequence input = default(CharSequence);
		object obj = (input.___003Cref_003E = text);
		int num = (jAVA_IDENTIFIER.matcher(input).matches() ? 1 : 0);
		if (!root.equals(dir) && (Files.isHidden(dir) || num == 0))
		{
			Log.trace("Not processing directory \"%s\"", new ___003C_003EAnon5(text));
			return false;
		}
		return true;
	}

	
	
	
	
	private FileVisitResult callback(Path absolutePath, ParserConfiguration configuration, Callback callback)
	{
		Path path = root.relativize(absolutePath);
		Log.trace("Parsing %s", new ___003C_003EAnon7(path));
		ParseResult parseResult = new JavaParser(configuration).parse(ParseStart.COMPILATION_UNIT, Providers.provider(absolutePath, configuration.getCharacterEncoding()));
		parseResult.getResult().ifPresent(new ___003C_003EAnon8(absolutePath, configuration));
		switch (_3._0024SwitchMap_0024com_0024github_0024javaparser_0024utils_0024SourceRoot_0024Callback_0024Result[callback.process(path, absolutePath, parseResult).ordinal()])
		{
		case 1:
			parseResult.getResult().ifPresent(new ___003C_003EAnon9(this, absolutePath));
			goto case 2;
		case 2:
			return FileVisitResult.CONTINUE;
		case 3:
			return FileVisitResult.TERMINATE;
		default:
			
			throw new AssertionError("Return an enum defined in SourceRoot.Callback.Result");
		}
	}

	
	
		
	
	public virtual ParseResult tryToParse(string startPackage, string filename, ParserConfiguration configuration)
	{
		Utils.assertNotNull(startPackage);
		Utils.assertNotNull(filename);
		Path path = CodeGenerationUtils.fileInPackageRelativePath(startPackage, filename);
		if (cache.containsKey(path))
		{
			Log.trace("Retrieving cached %s", new ___003C_003EAnon2(path));
			return (ParseResult)cache.get(path);
		}
		Path path2 = root.resolve(path);
		Log.trace("Parsing %s", new ___003C_003EAnon3(path2));
		ParseResult parseResult = new JavaParser(configuration).parse(ParseStart.COMPILATION_UNIT, Providers.provider(path2, configuration.getCharacterEncoding()));
		parseResult.getResult().ifPresent(new ___003C_003EAnon4(path2, configuration));
		cache.put(path, parseResult);
		return parseResult;
	}

	
	
	
	private void logPackage(string startPackage)
	{
		if (!java.lang.String.instancehelper_isEmpty(startPackage))
		{
			Log.info("Parsing package \"%s\"", new ___003C_003EAnon10(startPackage));
		}
	}

	
		
	public virtual List getCache()
	{
		
		ArrayList result = new ArrayList(cache.values());
		
		return result;
	}

	
	
		
	
	public virtual List tryToParse(string startPackage)
	{
		Utils.assertNotNull(startPackage);
		logPackage(startPackage);
		Path start = CodeGenerationUtils.packageAbsolutePath(root, startPackage);
		Files.walkFileTree(start, new _1(this));
		List result = getCache();
		
		return result;
	}

	
		
	
	public virtual List tryToParseParallelized(string startPackage)
	{
		Utils.assertNotNull(startPackage);
		logPackage(startPackage);
		Path path = CodeGenerationUtils.packageAbsolutePath(root, startPackage);
		ParallelParse.___003Cclinit_003E();
		ParallelParse task = new ParallelParse(path, new ___003C_003EAnon6(this));
		ForkJoinPool forkJoinPool = new ForkJoinPool();
		forkJoinPool.invoke(task);
		List result = getCache();
		
		return result;
	}

	
	
	
	
	public virtual SourceRoot parse(string startPackage, string filename, ParserConfiguration configuration, Callback callback)
	{
		Utils.assertNotNull(startPackage);
		Utils.assertNotNull(filename);
		Utils.assertNotNull(configuration);
		Utils.assertNotNull(callback);
		this.callback(CodeGenerationUtils.fileInPackageAbsolutePath(root, startPackage, filename), configuration, callback);
		return this;
	}

	
	
	
	
	public virtual SourceRoot parse(string startPackage, ParserConfiguration configuration, Callback callback)
	{
		Utils.assertNotNull(startPackage);
		Utils.assertNotNull(configuration);
		Utils.assertNotNull(callback);
		logPackage(startPackage);
		Path path = CodeGenerationUtils.packageAbsolutePath(root, startPackage);
		if (Files.exists(path))
		{
			Files.walkFileTree(path, new _2(this, configuration, callback));
		}
		return this;
	}

	
	
	
	public virtual SourceRoot parseParallelized(string startPackage, ParserConfiguration configuration, Callback callback)
	{
		Utils.assertNotNull(startPackage);
		Utils.assertNotNull(configuration);
		Utils.assertNotNull(callback);
		logPackage(startPackage);
		Path path = CodeGenerationUtils.packageAbsolutePath(root, startPackage);
		if (Files.exists(path))
		{
			ParallelParse.___003Cclinit_003E();
			ParallelParse task = new ParallelParse(path, new ___003C_003EAnon11(this, configuration, callback));
			ForkJoinPool forkJoinPool = new ForkJoinPool();
			forkJoinPool.invoke(task);
		}
		return this;
	}

	
	
	
	private SourceRoot save(CompilationUnit cu, Path path, Charset encoding)
	{
		Utils.assertNotNull(cu);
		Utils.assertNotNull(path);
		cu.setStorage(path, encoding);
		((CompilationUnit.Storage)cu.getStorage().get()).save(printer);
		return this;
	}

	
	
	
	public unsafe virtual SourceRoot saveAll(Path root, Charset encoding)
	{
		Utils.assertNotNull(root);
		Supplier[] array = new Supplier[2];
		Map map = cache;
		
		array[0] = new ___003C_003EAnon15(map);
		array[1] = new ___003C_003EAnon16(root);
		Log.info("Saving all files (%s) to %s", array);
		Iterator iterator = cache.entrySet().iterator();
		while (iterator.hasNext())
		{
			Map.Entry entry = (Map.Entry)iterator.next();
			Path path = root.resolve((Path)entry.getKey());
			if (((ParseResult)entry.getValue()).getResult().isPresent())
			{
				Log.trace("Saving %s", new ___003C_003EAnon17(path));
				save((CompilationUnit)((ParseResult)entry.getValue()).getResult().get(), path, encoding);
			}
		}
		return this;
	}

	
	
	
	public virtual SourceRoot saveAll(Path root)
	{
		SourceRoot result = saveAll(root, parserConfiguration.getCharacterEncoding());
		
		return result;
	}

	
	
	
	private SourceRoot save(CompilationUnit cu, Path path)
	{
		SourceRoot result = save(cu, path, parserConfiguration.getCharacterEncoding());
		
		return result;
	}

	
	private object lambda_0024new_00240()
	{
		return root;
	}

	
	
	private static object lambda_0024tryToParse_00241(Path relativePath)
	{
		return relativePath;
	}

	
	
	private static object lambda_0024tryToParse_00242(Path path)
	{
		return path;
	}

	
	
	
	
	private static void lambda_0024tryToParse_00243(Path path, ParserConfiguration configuration, CompilationUnit cu)
	{
		cu.setStorage(path, configuration.getCharacterEncoding());
	}

	
	
	private static object lambda_0024isSensibleDirectoryToEnter_00244(string dirToEnter)
	{
		return dirToEnter;
	}

	
	
	
	
	private FileVisitResult lambda_0024tryToParseParallelized_00245(Path file, BasicFileAttributes attrs)
	{
		IOException ex;
		if (!attrs.isDirectory() && java.lang.String.instancehelper_endsWith(file.ToString(), ".java"))
		{
			Path path = root.relativize(file.getParent());
			try
			{
				tryToParse(path.ToString(), file.getFileName().ToString(), parserConfiguration);
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_005c;
			}
		}
		goto IL_0068;
		IL_005c:
		IOException throwable = ex;
		Log.error(throwable);
		goto IL_0068;
		IL_0068:
		return FileVisitResult.CONTINUE;
	}

	
	
	private static object lambda_0024callback_00246(Path localPath)
	{
		return localPath;
	}

	
	
	
	
	private static void lambda_0024callback_00247(Path absolutePath, ParserConfiguration configuration, CompilationUnit cu)
	{
		cu.setStorage(absolutePath, configuration.getCharacterEncoding());
	}

	
	
	
	
	private void lambda_0024callback_00248(Path absolutePath, CompilationUnit cu)
	{
		save(cu, absolutePath);
	}

	
	
	private static object lambda_0024logPackage_00249(string startPackage)
	{
		return startPackage;
	}

	
	
	
	
	private FileVisitResult lambda_0024parseParallelized_002410(ParserConfiguration configuration, Callback callback, Path absolutePath, BasicFileAttributes attrs)
	{
		//Discarded unreachable code: IL_0026
		if (!attrs.isDirectory() && java.lang.String.instancehelper_endsWith(absolutePath.ToString(), ".java"))
		{
			IOException ex;
			try
			{
				return this.callback(absolutePath, configuration, callback);
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			IOException throwable = ex;
			Log.error(throwable);
		}
		return FileVisitResult.CONTINUE;
	}

	
	
	private static object lambda_0024add_002411(string startPackage)
	{
		return startPackage;
	}

	
	
	private static object lambda_0024add_002412(string filename)
	{
		return filename;
	}

	
	
	private static object lambda_0024add_002413(Path path)
	{
		return path;
	}

	
	
	private static object lambda_0024saveAll_002414(Path root)
	{
		return root;
	}

	
	
	private static object lambda_0024saveAll_002415(Path path)
	{
		return path;
	}

	
	
	
	
	private static CompilationUnit lambda_0024getCompilationUnits_002416(ParseResult p)
	{
		return (CompilationUnit)p.getResult().get();
	}

	
	
		
	public virtual List tryToParse()
	{
		List result = tryToParse("");
		
		return result;
	}

	
		
	public virtual List tryToParseParallelized()
	{
		List result = tryToParseParallelized("");
		
		return result;
	}

	
	
	
	
	public virtual SourceRoot parse(string startPackage, string filename, Callback callback)
	{
		parse(startPackage, filename, parserConfiguration, callback);
		return this;
	}

	
	
	
	
	public virtual SourceRoot parse(string startPackage, Callback callback)
	{
		parse(startPackage, parserConfiguration, callback);
		return this;
	}

	
	
	
	
	public virtual SourceRoot parseParallelized(string startPackage, Callback callback)
	{
		SourceRoot result = parseParallelized(startPackage, parserConfiguration, callback);
		
		return result;
	}

	
	
	
	
	public virtual SourceRoot parseParallelized(Callback callback)
	{
		SourceRoot result = parseParallelized("", parserConfiguration, callback);
		
		return result;
	}

	
	
	
	public virtual SourceRoot add(string startPackage, string filename, CompilationUnit compilationUnit)
	{
		Utils.assertNotNull(startPackage);
		Utils.assertNotNull(filename);
		Utils.assertNotNull(compilationUnit);
		Log.trace("Adding new file %s.%s", new ___003C_003EAnon12(startPackage), new ___003C_003EAnon13(filename));
		Path key = CodeGenerationUtils.fileInPackageRelativePath(startPackage, filename);
		ParseResult value = new ParseResult(compilationUnit, new ArrayList(), null);
		cache.put(key, value);
		return this;
	}

	
	
	
	public virtual SourceRoot add(CompilationUnit compilationUnit)
	{
		Utils.assertNotNull(compilationUnit);
		if (compilationUnit.getStorage().isPresent())
		{
			Path path = ((CompilationUnit.Storage)compilationUnit.getStorage().get()).getPath();
			Log.trace("Adding new file %s", new ___003C_003EAnon14(path));
			ParseResult value = new ParseResult(compilationUnit, new ArrayList(), null);
			cache.put(path, value);
			return this;
		}
		
		throw new AssertionError("Files added with this method should have their path set.");
	}

	
	
	
	public virtual SourceRoot saveAll(Charset encoding)
	{
		SourceRoot result = saveAll(root, encoding);
		
		return result;
	}

	
		
	public virtual List getCompilationUnits()
	{
		return (List)cache.values().stream().filter(new ___003C_003EAnon18())
			.map(new ___003C_003EAnon19())
			.collect(Collectors.toList());
	}

	public virtual ParserConfiguration getParserConfiguration()
	{
		return parserConfiguration;
	}

	
		
	
	public virtual SourceRoot setPrinter(Function printer)
	{
		Utils.assertNotNull(printer);
		this.printer = printer;
		return this;
	}

		public virtual Function getPrinter()
	{
		return printer;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("SourceRoot at ").append(root).ToString();
		
		return result;
	}

	
	
	
	
	internal static FileVisitResult access_0024100(SourceRoot P_0, Path P_1, ParserConfiguration P_2, Callback P_3)
	{
		FileVisitResult result = P_0.callback(P_1, P_2, P_3);
		
		return result;
	}

	
	static SourceRoot()
	{
		JAVA_IDENTIFIER = Pattern.compile("\\p{javaJavaIdentifierStart}\\p{javaJavaIdentifierPart}*");
	}
}
