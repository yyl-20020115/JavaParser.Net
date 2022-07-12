using System;

using System.Threading;
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.symbolsolver.cache;
using com.github.javaparser.symbolsolver.javaparser;
using com.github.javaparser.symbolsolver.javaparsermodel;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.utils;
using com.google.common.cache;

using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.nio.file;
using java.util;
using java.util.function;

namespace com.github.javaparser.symbolsolver.resolution.typesolvers;

public class JavaParserTypeSolver :  TypeSolver
{
	
	private sealed class ___003C_003EAnon0 : Function
	{
		private readonly Path arg_00241;

		internal ___003C_003EAnon0(Path P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			CompilationUnit result = lambda_0024parse_00240(arg_00241, (CompilationUnit)P_0);
			
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

	
	private sealed class ___003C_003EAnon1 : Consumer
	{
		private readonly JavaParserTypeSolver arg_00241;

		private readonly List arg_00242;

		private readonly bool arg_00243;

		internal ___003C_003EAnon1(JavaParserTypeSolver P_0, List P_1, bool P_2)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024parseDirectory_00241(arg_00242, arg_00243, (Path)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon2 : Consumer
	{
		private readonly List arg_00241;

		internal ___003C_003EAnon2(List P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.add((CompilationUnit)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private Path srcDir;

	
	private JavaParser javaParser;

	private TypeSolver parent;

	
		private com.github.javaparser.symbolsolver.cache.Cache parsedFiles;

	
		private com.github.javaparser.symbolsolver.cache.Cache parsedDirectories;

	
		private com.github.javaparser.symbolsolver.cache.Cache foundTypes;

	private const int CACHE_SIZE_UNSET = -1;

	
	
	public JavaParserTypeSolver(Path srcDir)
		: this(srcDir, new ParserConfiguration().setLanguageLevel(ParserConfiguration.LanguageLevel.BLEEDING_EDGE))
	{
	}

	
	
	public JavaParserTypeSolver(File srcDir)
		: this(srcDir.toPath())
	{
	}

	
	
	public JavaParserTypeSolver(Path srcDir, ParserConfiguration parserConfiguration)
		: this(srcDir, parserConfiguration, -1L)
	{
	}

	
	
	public JavaParserTypeSolver(File srcDir, ParserConfiguration parserConfiguration)
		: this(srcDir.toPath(), parserConfiguration)
	{
	}

	
	
	public JavaParserTypeSolver(Path srcDir, ParserConfiguration parserConfiguration, long cacheSizeLimit)
	{
		if (!Files.exists(srcDir) || !Files.isDirectory(srcDir))
		{
			string s = new StringBuilder().append("SrcDir does not exist or is not a directory: ").append(srcDir).ToString();
			
			throw new IllegalStateException(s);
		}
		this.srcDir = srcDir;
		javaParser = new JavaParser(parserConfiguration);
		parsedFiles = BuildCache(cacheSizeLimit);
		parsedDirectories = BuildCache(cacheSizeLimit);
		foundTypes = BuildCache(cacheSizeLimit);
	}

	
		
	private com.github.javaparser.symbolsolver.cache.Cache BuildCache(long P_0)
	{
		CacheBuilder cacheBuilder = CacheBuilder.newBuilder().softValues();
		if (P_0 != -1)
		{
			cacheBuilder.maximumSize(P_0);
		}
		GuavaCache result = new GuavaCache(cacheBuilder.build());
		
		return result;
	}

	
		
	private List parseDirectory(Path P_0, bool P_1)
	{
		//Discarded unreachable code: IL_01fe
		ArrayList arrayList;
		DirectoryStream directoryStream;
		System.Exception ex;
		System.Exception ex2;
		System.Exception ex3;
		System.Exception ex4;
		IOException ex5;
		try
		{
			Optional optional = parsedDirectories.get(P_0.toAbsolutePath());
			if (optional.isPresent())
			{
				return (List)optional.get();
			}
			arrayList = new ArrayList();
			if (Files.exists(P_0))
			{
				directoryStream = Files.newDirectoryStream(P_0);
				ex = null;
				try
				{
					try
					{
						directoryStream.forEach(new ___003C_003EAnon1(this, arrayList, P_1));
					}
					catch (System.Exception x)
					{
						ex2 = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
						goto IL_00b2;
					}
				}
				catch (System.Exception x2)
				{
					ex3 = ByteCodeHelper.MapException<System.Exception>(x2, ByteCodeHelper.MapFlags.None);
					goto IL_00b9;
				}
				if (directoryStream != null)
				{
					if ((object)null == null)
					{
						goto IL_00f5;
					}
					try
					{
						directoryStream.close();
					}
					catch (System.Exception x3)
					{
						ex4 = ByteCodeHelper.MapException<System.Exception>(x3, ByteCodeHelper.MapFlags.None);
						goto IL_00c2;
					}
				}
			}
		}
		catch (IOException x4)
		{
			ex5 = ByteCodeHelper.MapException<IOException>(x4, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_00c6;
		}
		goto IL_01e9;
		IL_00c6:
		IOException ex6 = ex5;
		goto IL_0217;
		IL_00f5:
		IOException ex7;
		try
		{
			directoryStream.close();
		}
		catch (IOException x5)
		{
			ex7 = ByteCodeHelper.MapException<IOException>(x5, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_010f;
		}
		goto IL_01e9;
		IL_010f:
		ex6 = ex7;
		goto IL_0217;
		IL_00c2:
		System.Exception ex8 = ex4;
		IOException ex9;
		try
		{
			System.Exception exception = ex8;
			Throwable.instancehelper_addSuppressed(null, exception);
		}
		catch (IOException x6)
		{
			ex9 = ByteCodeHelper.MapException<IOException>(x6, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_00ee;
		}
		goto IL_01e9;
		IL_00ee:
		ex6 = ex9;
		goto IL_0217;
		IL_01e9:
		IOException ex10;
		try
		{
			parsedDirectories.put(P_0.toAbsolutePath(), arrayList);
			return arrayList;
		}
		catch (IOException x7)
		{
			ex10 = ByteCodeHelper.MapException<IOException>(x7, ByteCodeHelper.MapFlags.NoRemapping);
		}
		ex6 = ex10;
		goto IL_0217;
		IL_01b1:
		IOException ex11;
		ex6 = ex11;
		goto IL_0217;
		IL_0217:
		IOException cause = ex6;
		string message = new StringBuilder().append("Unable to parse directory due to an exception. Directory:").append(P_0.toAbsolutePath()).ToString();
		
		throw new RuntimeException(message, cause);
		IL_00b9:
		System.Exception ex12 = ex3;
		goto IL_014b;
		IL_00b2:
		ex8 = ex2;
		IOException ex13;
		try
		{
			ex8 = ex8;
			try
			{
				System.Exception exception = ex8;
				ex = exception;
				throw (exception);
			}
			catch (System.Exception x8)
			{
				ex8 = ByteCodeHelper.MapException<System.Exception>(x8, ByteCodeHelper.MapFlags.None);
			}
		}
		catch (IOException x9)
		{
			ex13 = ByteCodeHelper.MapException<IOException>(x9, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0144;
		}
		ex12 = ex8;
		goto IL_014b;
		IL_0144:
		ex6 = ex13;
		goto IL_0217;
		IL_01d3:
		System.Exception ex14;
		IOException ex15;
		try
		{
			throw (ex14);
		}
		catch (IOException x10)
		{
			ex15 = ByteCodeHelper.MapException<IOException>(x10, ByteCodeHelper.MapFlags.NoRemapping);
		}
		ex6 = ex15;
		goto IL_0217;
		IL_014b:
		System.Exception ex16 = ex12;
		IOException ex17;
		try
		{
			ex14 = ex16;
			if (directoryStream != null)
			{
				if (ex == null)
				{
					goto IL_01b8;
				}
				try
				{
					directoryStream.close();
				}
				catch (System.Exception x11)
				{
					ex16 = ByteCodeHelper.MapException<System.Exception>(x11, ByteCodeHelper.MapFlags.None);
					goto IL_0187;
				}
			}
		}
		catch (IOException x12)
		{
			ex17 = ByteCodeHelper.MapException<IOException>(x12, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_018b;
		}
		goto IL_01d3;
		IL_018b:
		ex6 = ex17;
		goto IL_0217;
		IL_01b8:
		IOException ex18;
		try
		{
			directoryStream.close();
		}
		catch (IOException x13)
		{
			ex18 = ByteCodeHelper.MapException<IOException>(x13, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_01cf;
		}
		goto IL_01d3;
		IL_01cf:
		ex6 = ex18;
		goto IL_0217;
		IL_0187:
		System.Exception ex19 = ex16;
		try
		{
			System.Exception exception2 = ex19;
			Throwable.instancehelper_addSuppressed(ex, exception2);
		}
		catch (IOException x14)
		{
			ex11 = ByteCodeHelper.MapException<IOException>(x14, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_01b1;
		}
		goto IL_01d3;
	}

	
		
	private SymbolReference tryToSolveTypeUncached(string P_0)
	{
		string[] array = java.lang.String.instancehelper_split(P_0, "\\.");
		for (int i = array.Length; i > 0; i += -1)
		{
			StringBuilder stringBuilder = new StringBuilder(srcDir.toAbsolutePath().ToString());
			for (int j = 0; j < i; j++)
			{
				stringBuilder.append(File.separator).append(array[j]);
			}
			stringBuilder.append(".java");
			StringBuilder stringBuilder2 = new StringBuilder();
			for (int k = i - 1; k < (nint)array.LongLength; k++)
			{
				if (k != i - 1)
				{
					stringBuilder2.append(".");
				}
				stringBuilder2.append(array[k]);
			}
			
			string text;
			if (FileUtils.isValidPath(stringBuilder.ToString()))
			{
				Path path = Paths.get(stringBuilder.ToString());
				Optional optional = parse(path);
				if (optional.isPresent())
				{
					Optional optional2 = Navigator.findType((CompilationUnit)optional.get(), stringBuilder2.ToString());
					if (optional2.isPresent())
					{
						SymbolReference result = SymbolReference.solved(JavaParserFacade.get(this).getTypeDeclaration((TypeDeclaration)optional2.get()));
						
						return result;
					}
				}
				text = path.getParent().normalize().ToString();
			}
			else
			{
				text = FileUtils.getParentPath(stringBuilder.ToString());
			}
			if (!FileUtils.isValidPath(text))
			{
				continue;
			}
			List list = parseDirectory(Paths.get(text));
			Iterator iterator = list.iterator();
			while (iterator.hasNext())
			{
				CompilationUnit cu = (CompilationUnit)iterator.next();
				Optional optional3 = Navigator.findType(cu, stringBuilder2.ToString());
				if (optional3.isPresent())
				{
					SymbolReference result2 = SymbolReference.solved(JavaParserFacade.get(this).getTypeDeclaration((TypeDeclaration)optional3.get()));
					
					return result2;
				}
			}
		}
		SymbolReference result3 = SymbolReference.unsolved(ClassLiteral<ResolvedReferenceTypeDeclaration>.Value);
		
		return result3;
	}

	
		
	private Optional parse(Path P_0)
	{
		//Discarded unreachable code: IL_00cc
		JavaParser obj;
		System.Exception ex;
		IOException ex2;
		try
		{
			Optional optional = parsedFiles.get(P_0.toAbsolutePath());
			if (optional.isPresent())
			{
				return (Optional)optional.get();
			}
			if (!Files.exists(P_0) || !Files.isRegularFile(P_0))
			{
				parsedFiles.put(P_0.toAbsolutePath(), Optional.empty());
				return Optional.empty();
			}
			Monitor.Enter(obj = javaParser);
			try
			{
				Optional optional2 = javaParser.parse(ParseStart.COMPILATION_UNIT, Providers.provider(P_0, javaParser.getParserConfiguration().getCharacterEncoding())).getResult().map(new ___003C_003EAnon0(P_0));
				parsedFiles.put(P_0.toAbsolutePath(), optional2);
				Monitor.Exit(obj);
				return optional2;
			}
			catch (System.Exception x)
			{
				ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
			}
		}
		catch (IOException x2)
		{
			ex2 = ByteCodeHelper.MapException<IOException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_00f6;
		}
		System.Exception ex3 = ex;
		IOException ex5;
		try
		{
			System.Exception ex4 = ex3;
			Monitor.Exit(obj);
			throw (ex4);
		}
		catch (IOException x3)
		{
			ex5 = ByteCodeHelper.MapException<IOException>(x3, ByteCodeHelper.MapFlags.NoRemapping);
		}
		IOException ex6 = ex5;
		goto IL_011c;
		IL_00f6:
		ex6 = ex2;
		goto IL_011c;
		IL_011c:
		IOException cause = ex6;
		string message = new StringBuilder().append("Issue while parsing while type solving: ").append(P_0.toAbsolutePath()).ToString();
		
		throw new RuntimeException(message, cause);
	}

	
		
	private List parseDirectory(Path P_0)
	{
		List result = parseDirectory(P_0, false);
		
		return result;
	}

	
		
	private List parseDirectoryRecursively(Path P_0)
	{
		List result = parseDirectory(P_0, true);
		
		return result;
	}

	
	
	
	private static CompilationUnit lambda_0024parse_00240(Path P_0, CompilationUnit P_1)
	{
		CompilationUnit result = P_1.setStorage(P_0);
		
		return result;
	}

	
	
	
	private unsafe void lambda_0024parseDirectory_00241(List P_0, bool P_1, Path P_2)
	{
		if (java.lang.String.instancehelper_endsWith(java.lang.String.instancehelper_toLowerCase(P_2.getFileName().ToString()), ".java"))
		{
			Optional optional = parse(P_2);
			
			optional.ifPresent(new ___003C_003EAnon2(P_0));
		}
		else if (P_1 && P_2.toFile().isDirectory())
		{
			P_0.addAll(parseDirectoryRecursively(P_2));
		}
	}

	
	
	public JavaParserTypeSolver(string srcDir)
		: this(new File(srcDir))
	{
	}

	
	
	public JavaParserTypeSolver(string srcDir, ParserConfiguration parserConfiguration)
		: this(new File(srcDir), parserConfiguration)
	{
	}

	
		
	public JavaParserTypeSolver(Path srcDir, JavaParser javaParser, com.github.javaparser.symbolsolver.cache.Cache parsedFilesCache, com.github.javaparser.symbolsolver.cache.Cache parsedDirectoriesCache, com.github.javaparser.symbolsolver.cache.Cache foundTypesCache)
	{
		Objects.requireNonNull(srcDir, "The srcDir can't be null.");
		Objects.requireNonNull(javaParser, "The javaParser can't be null.");
		Objects.requireNonNull(parsedFilesCache, "The parsedFilesCache can't be null.");
		Objects.requireNonNull(parsedDirectoriesCache, "The parsedDirectoriesCache can't be null.");
		Objects.requireNonNull(foundTypesCache, "The foundTypesCache can't be null.");
		if (!Files.exists(srcDir) || !Files.isDirectory(srcDir))
		{
			string s = new StringBuilder().append("SrcDir does not exist or is not a directory: ").append(srcDir).ToString();
			
			throw new IllegalStateException(s);
		}
		this.srcDir = srcDir;
		this.javaParser = javaParser;
		parsedFiles = parsedFilesCache;
		parsedDirectories = parsedDirectoriesCache;
		foundTypes = foundTypesCache;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("JavaParserTypeSolver{srcDir=").append(srcDir).append(", parent=")
			.append(parent)
			.append('}')
			.ToString();
		
		return result;
	}

	public virtual TypeSolver getParent()
	{
		return parent;
	}

	
	
	public virtual void setParent(TypeSolver parent)
	{
		Objects.requireNonNull(parent);
		if (this.parent != null)
		{
			
			throw new IllegalStateException("This TypeSolver already has a parent.");
		}
		if (parent == this)
		{
			
			throw new IllegalStateException("The parent of this TypeSolver cannot be itself.");
		}
		this.parent = parent;
	}

	
		
	public virtual SymbolReference tryToSolveType(string name)
	{
		Optional optional = foundTypes.get(name);
		if (optional.isPresent())
		{
			return (SymbolReference)optional.get();
		}
		SymbolReference symbolReference = tryToSolveTypeUncached(name);
		foundTypes.put(name, symbolReference);
		return symbolReference;
	}


	public virtual TypeSolver getRoot()
	{
		return TypeSolver._003Cdefault_003EgetRoot(this);
	}


	public virtual ResolvedReferenceTypeDeclaration solveType(string P_0)
	{
		return TypeSolver._003Cdefault_003EsolveType(this, P_0);
	}


	public virtual ResolvedReferenceTypeDeclaration getSolvedJavaLangObject()
	{
		return TypeSolver._003Cdefault_003EgetSolvedJavaLangObject(this);
	}


	public virtual bool hasType(string P_0)
	{
		return TypeSolver._003Cdefault_003EhasType(this, P_0);
	}
}
