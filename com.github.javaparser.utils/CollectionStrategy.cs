using System;

using com.github.javaparser.ast;

using IKVM.Runtime;
using java.io;
using java.lang;
using java.nio.file;
using java.util;
using java.util.function;

namespace com.github.javaparser.utils;

public interface CollectionStrategy
{
	private static class ___003C_003EPIM
	{
		
		
		
		
		internal static object lambda_0024getRoot_00240(ParseResult parseResult)
		{
			Integer result = Integer.valueOf(parseResult.getProblems().size());
			
			return result;
		}

		
		
		internal static object lambda_0024getRoot_00241(Path file)
		{
			return file;
		}

		
		
		
		
		internal static object lambda_0024getRoot_00242(ParseProblemException e)
		{
			string result = Throwable.instancehelper_getLocalizedMessage(e);
			
			return result;
		}

		
		
		internal static object lambda_0024getRoot_00243(Path file)
		{
			return file;
		}

		
		
		
		
		internal static object lambda_0024getRoot_00244(RuntimeException e)
		{
			string result = Throwable.instancehelper_getLocalizedMessage(e);
			
			return result;
		}

		
		
		internal static object lambda_0024getRoot_00245(Path file)
		{
			return file;
		}

		
		
		
		
		internal static object lambda_0024getRoot_00246(IOException e)
		{
			string result = Throwable.instancehelper_getLocalizedMessage(e);
			
			return result;
		}
	}

	
	public static class __DefaultMethods
	{
		public unsafe static Optional getRoot(CollectionStrategy P_0, Path P_1)
		{
			
			return _003Cdefault_003EgetRoot(P_0, P_1);
		}

		public unsafe static PathMatcher getPathMatcher(CollectionStrategy P_0, string P_1)
		{
			
			return _003Cdefault_003EgetPathMatcher(P_0, P_1);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Function
	{
		internal ___003C_003EAnon1()
		{
		}

		public object apply(object P_0)
		{
			Optional storage = ((CompilationUnit)P_0).getStorage();
			
			return storage;
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
			Path sourceRoot = ((CompilationUnit.Storage)P_0).getSourceRoot();
			
			return sourceRoot;
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
		private readonly ParseResult arg_00241;

		internal ___003C_003EAnon3(ParseResult P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			object result = ___003C_003EPIM.lambda_0024getRoot_00240(arg_00241);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon4 : Supplier
	{
		private readonly ParseResult arg_00241;

		internal ___003C_003EAnon4(ParseResult P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			object result = arg_00241.getProblems();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon5 : Supplier
	{
		private readonly Path arg_00241;

		internal ___003C_003EAnon5(Path P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			object result = ___003C_003EPIM.lambda_0024getRoot_00241(arg_00241);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon6 : Supplier
	{
		private readonly ParseProblemException arg_00241;

		internal ___003C_003EAnon6(ParseProblemException P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			object result = ___003C_003EPIM.lambda_0024getRoot_00242(arg_00241);
			
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
			object result = ___003C_003EPIM.lambda_0024getRoot_00243(arg_00241);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon8 : Supplier
	{
		private readonly RuntimeException arg_00241;

		internal ___003C_003EAnon8(RuntimeException P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			object result = ___003C_003EPIM.lambda_0024getRoot_00244(arg_00241);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon9 : Supplier
	{
		private readonly Path arg_00241;

		internal ___003C_003EAnon9(Path P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			object result = ___003C_003EPIM.lambda_0024getRoot_00245(arg_00241);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon10 : Supplier
	{
		private readonly IOException arg_00241;

		internal ___003C_003EAnon10(IOException P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			object result = ___003C_003EPIM.lambda_0024getRoot_00246(arg_00241);
			
			return result;
		}
	}

	virtual ParserConfiguration getParserConfiguration();

	
	virtual ProjectRoot collect(Path path);

	
		
	virtual Optional getRoot(Path file);

	
	
	
	static unsafe Optional _003Cdefault_003EgetRoot(CollectionStrategy P_0, Path P_1)
	{
		ParseProblemException ex;
		RuntimeException ex3;
		IOException ex4;
		try
		{
			try
			{
				try
				{
					JavaParser javaParser = new JavaParser(P_0.getParserConfiguration());
					ParseResult parseResult = javaParser.parse(P_1);
					if (parseResult.isSuccessful())
					{
						if (parseResult.getResult().isPresent())
						{
							Optional optional = parseResult.getResult().flatMap(new ___003C_003EAnon1());
							if (optional.isPresent())
							{
								if (java.lang.String.instancehelper_equals(((CompilationUnit.Storage)optional.get()).getFileName(), "module-info.java"))
								{
									return Optional.empty();
								}
								return optional.map(new ___003C_003EAnon2());
							}
							Log.info("Storage information not present -- an issue with providing a string rather than file reference?");
						}
						else
						{
							Log.info("Parse result not present");
						}
					}
					else
					{
						Log.info("Parsing was not successful.");
						Supplier[] obj = new Supplier[2]
						{
							new ___003C_003EAnon3(parseResult),
							null
						};
						
						obj[1] = new ___003C_003EAnon4(parseResult);
						Log.info("There were (%d) problems parsing file: %s", obj);
					}
				}
				catch (ParseProblemException x)
				{
					ex = ByteCodeHelper.MapException<ParseProblemException>(x, ByteCodeHelper.MapFlags.NoRemapping);
					goto IL_0121;
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
				goto IL_0125;
			}
		}
		catch (IOException x3)
		{
			ex4 = ByteCodeHelper.MapException<IOException>(x3, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0129;
		}
		goto IL_01c3;
		IL_0129:
		IOException ex5 = ex4;
		Log.info("Could not read file %s : %s", new ___003C_003EAnon9(P_1), new ___003C_003EAnon10(ex5));
		goto IL_01c3;
		IL_0125:
		RuntimeException ex6 = ex3;
		Log.info("Could not parse file %s : %s", new ___003C_003EAnon7(P_1), new ___003C_003EAnon8(ex6));
		goto IL_01c3;
		IL_0121:
		ParseProblemException ex7 = ex;
		Log.info("Problem parsing file %s : %s", new ___003C_003EAnon5(P_1), new ___003C_003EAnon6(ex7));
		goto IL_01c3;
		IL_01c3:
		return Optional.empty();
	}

	
	
	virtual PathMatcher getPathMatcher(string pattern);

	
	
	
	static PathMatcher _003Cdefault_003EgetPathMatcher(CollectionStrategy P_0, string P_1)
	{
		PathMatcher pathMatcher = FileSystems.getDefault().getPathMatcher(P_1);
		
		return pathMatcher;
	}
}
