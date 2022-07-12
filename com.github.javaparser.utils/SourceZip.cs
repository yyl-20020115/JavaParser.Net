using System;


using IKVM.Runtime;
using java.lang;
using java.nio.file;
using java.util;
using java.util.function;
using java.util.zip;

namespace com.github.javaparser.utils;

public class SourceZip
{
	[FunctionalInterface(new object[]
	{
		(byte)64,
		"Ljava/lang/FunctionalInterface;"
	})]
	public interface Callback
	{
				
		virtual void process(Path relativeZipEntryPath, ParseResult result);
	}

	
	private sealed class ___003C_003EAnon0 : Supplier
	{
		private readonly SourceZip arg_00241;

		internal ___003C_003EAnon0(SourceZip P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			object result = arg_00241.lambda_0024new_00240();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon1 : Supplier
	{
		private readonly SourceZip arg_00241;

		internal ___003C_003EAnon1(SourceZip P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			object result = arg_00241.lambda_0024parse_00241();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon2 : Callback
	{
		private readonly List arg_00241;

		internal ___003C_003EAnon2(List P_0)
		{
			arg_00241 = P_0;
		}

		public void process(Path P_0, ParseResult P_1)
		{
			lambda_0024parse_00242(arg_00241, P_0, P_1);
			
		}
	}

	
	private sealed class ___003C_003EAnon3 : Supplier
	{
		private readonly SourceZip arg_00241;

		internal ___003C_003EAnon3(SourceZip P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			object result = arg_00241.lambda_0024parse_00243();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon4 : Supplier
	{
		private readonly ZipEntry arg_00241;

		internal ___003C_003EAnon4(ZipEntry P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			object result = lambda_0024parse_00244(arg_00241);
			
			return result;
		}
	}

	
	private Path zipPath;

	private ParserConfiguration parserConfiguration;

	
	
	
	public SourceZip(Path zipPath, ParserConfiguration configuration)
	{
		Utils.assertNotNull(zipPath);
		Utils.assertNotNull(configuration);
		this.zipPath = zipPath.normalize();
		parserConfiguration = configuration;
		Log.info("New source zip at \"%s\"", new ___003C_003EAnon0(this));
	}

	
	
	
	
	public virtual SourceZip parse(Callback callback)
	{
		Log.info("Parsing zip at \"%s\"", new ___003C_003EAnon3(this));
		JavaParser javaParser = new JavaParser(parserConfiguration);
		ZipFile.___003Cclinit_003E();
		ZipFile zipFile = new ZipFile(zipPath.toFile());
		System.Exception ex = null;
		System.Exception ex2;
		try
		{
			try
			{
				Iterator iterator = Collections.list(zipFile.entries()).iterator();
				while (iterator.hasNext())
				{
					ZipEntry zipEntry = (ZipEntry)iterator.next();
					if (!zipEntry.isDirectory() && java.lang.String.instancehelper_endsWith(zipEntry.getName(), ".java"))
					{
						Log.info("Parsing zip entry \"%s\"", new ___003C_003EAnon4(zipEntry));
						ParseResult result = javaParser.parse(ParseStart.COMPILATION_UNIT, Providers.provider(zipFile.getInputStream(zipEntry)));
						callback.process(Paths.get(zipEntry.getName()), result);
					}
				}
			}
			catch (System.Exception x)
			{
				ex2 = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
				goto IL_0122;
			}
		}
		catch
		{
			//try-fault
			System.Exception ex3;
			if (zipFile != null)
			{
				if (ex != null)
				{
					try
					{
						zipFile.close();
					}
					catch (System.Exception x2)
					{
						ex3 = ByteCodeHelper.MapException<System.Exception>(x2, ByteCodeHelper.MapFlags.None);
						goto IL_0107;
					}
				}
				else
				{
					zipFile.close();
				}
			}
			goto end_IL_00eb;
			IL_0107:
			System.Exception exception = ex3;
			Throwable.instancehelper_addSuppressed(ex, exception);
			end_IL_00eb:
			throw;
		}
		if (zipFile != null)
		{
			if ((object)null != null)
			{
				System.Exception ex4;
				try
				{
					zipFile.close();
					return this;
				}
				catch (System.Exception x3)
				{
					ex4 = ByteCodeHelper.MapException<System.Exception>(x3, ByteCodeHelper.MapFlags.None);
				}
				System.Exception exception2 = ex4;
				Throwable.instancehelper_addSuppressed(null, exception2);
			}
			else
			{
				zipFile.close();
			}
		}
		return this;
		IL_0122:
		System.Exception ex5 = ex2;
		try
		{
			System.Exception exception2 = ex5;
			ex = exception2;
			throw (exception2);
		}
		catch
		{
			//try-fault
			if (zipFile != null)
			{
				if (ex != null)
				{
					try
					{
						zipFile.close();
					}
					catch (System.Exception x4)
					{
						ex5 = ByteCodeHelper.MapException<System.Exception>(x4, ByteCodeHelper.MapFlags.None);
						goto IL_0195;
					}
				}
				else
				{
					zipFile.close();
				}
			}
			goto end_IL_0179;
			IL_0195:
			System.Exception exception = ex5;
			Throwable.instancehelper_addSuppressed(ex, exception);
			end_IL_0179:
			throw;
		}
	}

	
	private object lambda_0024new_00240()
	{
		return zipPath;
	}

	
	private object lambda_0024parse_00241()
	{
		return zipPath;
	}

	
	
	
	
	private static void lambda_0024parse_00242(List results, Path path, ParseResult result)
	{
		results.add(new Pair(path, result));
	}

	
	private object lambda_0024parse_00243()
	{
		return zipPath;
	}

	
	
	
	
	private static object lambda_0024parse_00244(ZipEntry entry)
	{
		string name = entry.getName();
		
		return name;
	}

	
	
	
	public SourceZip(Path zipPath)
		: this(zipPath, new ParserConfiguration())
	{
	}

	
	
		
	public virtual List parse()
	{
		Log.info("Parsing zip at \"%s\"", new ___003C_003EAnon1(this));
		ArrayList arrayList = new ArrayList();
		parse(new ___003C_003EAnon2(arrayList));
		return arrayList;
	}

	public virtual Path getZipPath()
	{
		return zipPath;
	}

	public virtual ParserConfiguration getParserConfiguration()
	{
		return parserConfiguration;
	}

	
	
	
	public virtual SourceZip setParserConfiguration(ParserConfiguration parserConfiguration)
	{
		Utils.assertNotNull(parserConfiguration);
		this.parserConfiguration = parserConfiguration;
		return this;
	}
}
