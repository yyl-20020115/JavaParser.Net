using System;
using System.Runtime.CompilerServices;
using com.github.javaparser.utils;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.nio.charset;
using java.nio.file;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.generator.core.other;

public class BndGenerator : Generator
{
	
	private sealed class ___003C_003EAnon0 : Supplier
	{
		private readonly BndGenerator arg_00241;

		internal ___003C_003EAnon0(BndGenerator P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			object result = arg_00241.lambda_0024generate_00240();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon1 : Predicate
	{
		internal ___003C_003EAnon1()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024generate_00241((Path)P_0);
			
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

	
	private sealed class ___003C_003EAnon2 : Function
	{
		private readonly Path arg_00241;

		internal ___003C_003EAnon2(Path P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			string result = lambda_0024generate_00242(arg_00241, (Path)P_0);
			
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

	
	private sealed class ___003C_003EAnon3 : BinaryOperator
	{
		private readonly BndGenerator arg_00241;

		private readonly string arg_00242;

		internal ___003C_003EAnon3(BndGenerator P_0, string P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0, object P_1)
		{
			string result = arg_00241.lambda_0024generate_00243(arg_00242, (string)P_0, (string)P_1);
			
			return result;
		}

		
		public BiFunction andThen(Function P_0)
		{
			return BiFunction._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	
	public BndGenerator(SourceRoot sourceRoot)
		: base(sourceRoot)
	{
	}

	
	
	[LineNumberTable(new byte[]
	{
		159,
		187,
		126,
		108,
		113,
		107,
		112,
		107,
		112,
		101,
		101,
		114,
		140,
		109,
		114,
		109,
		115,
		127,
		62,
		159,
		27,
		95,
		91,
		95,
		57,
		byte.MaxValue,
		48,
		58,
		byte.MaxValue,
		3,
		70,
		31,
		43,
		159,
		21,
		95,
		78,
		95,
		57,
		95,
		51,
		63,
		31,
		127,
		21,
		95,
		30,
		byte.MaxValue,
		39,
		49,
		238,
		79,
		127,
		24
	})]
	public override void generate()
	{
		Log.info("Running %s", new ___003C_003EAnon0(this));
		Path root = ___003C_003EsourceRoot.getRoot();
		Path parent = root.getParent().getParent().getParent();
		string property = java.lang.System.getProperty("line.separator");
		Stream stream = Files.walk(root);
		System.Exception ex = null;
		Path path;
		BufferedWriter bufferedWriter;
		System.Exception ex2;
		System.Exception ex3;
		System.Exception ex4;
		System.Exception ex5;
		System.Exception ex6;
		try
		{
			try
			{
				string text = (string)stream.filter(new ___003C_003EAnon1()).map(new ___003C_003EAnon2(root)).distinct()
					.sorted()
					.reduce(null, new ___003C_003EAnon3(this, property));
				path = parent.resolve("bnd.bnd");
				bufferedWriter = Files.newBufferedWriter(path);
				ex2 = null;
				try
				{
					try
					{
						Path path2 = parent.resolve("bnd.bnd.template");
						string @this = java.lang.String.newhelper(Files.readAllBytes(path2), StandardCharsets.UTF_8);
						object __003Cref_003E = text;
						CharSequence charSequence = default(CharSequence);
						object obj = (charSequence.___003Cref_003E = "{exportedPackages}");
						CharSequence target = charSequence;
						obj = (charSequence.___003Cref_003E = __003Cref_003E);
						bufferedWriter.write(java.lang.String.instancehelper_replace(@this, target, charSequence));
					}
					catch (System.Exception x)
					{
						ex3 = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
						goto end_IL_0056;
					}
				}
				catch (System.Exception x2)
				{
					ex4 = ByteCodeHelper.MapException<System.Exception>(x2, ByteCodeHelper.MapFlags.None);
					goto IL_01ad;
				}
				if (bufferedWriter != null)
				{
					if ((object)null == null)
					{
						goto IL_022c;
					}
					try
					{
						bufferedWriter.close();
					}
					catch (System.Exception x3)
					{
						ex5 = ByteCodeHelper.MapException<System.Exception>(x3, ByteCodeHelper.MapFlags.None);
						goto IL_01be;
					}
				}
				goto IL_0485;
				end_IL_0056:;
			}
			catch (System.Exception x4)
			{
				ex6 = ByteCodeHelper.MapException<System.Exception>(x4, ByteCodeHelper.MapFlags.None);
				goto IL_01c2;
			}
		}
		catch
		{
			//try-fault
			System.Exception ex7;
			if (stream != null)
			{
				if (ex != null)
				{
					try
					{
						stream.close();
					}
					catch (System.Exception x5)
					{
						ex7 = ByteCodeHelper.MapException<System.Exception>(x5, ByteCodeHelper.MapFlags.None);
						goto IL_018c;
					}
				}
				else
				{
					stream.close();
				}
			}
			goto end_IL_016f;
			IL_018c:
			System.Exception exception = ex7;
			Throwable.instancehelper_addSuppressed(ex, exception);
			end_IL_016f:
			throw;
		}
		System.Exception ex8 = ex3;
		System.Exception ex10;
		try
		{
			ex8 = ex8;
			try
			{
				ex8 = ex8;
				try
				{
					System.Exception ex9 = ex8;
					ex2 = ex9;
					throw Throwable.___003Cunmap_003E(ex9);
				}
				catch (System.Exception x6)
				{
					ex8 = ByteCodeHelper.MapException<System.Exception>(x6, ByteCodeHelper.MapFlags.None);
				}
			}
			catch (System.Exception x7)
			{
				ex10 = ByteCodeHelper.MapException<System.Exception>(x7, ByteCodeHelper.MapFlags.None);
				goto IL_02ed;
			}
		}
		catch
		{
			//try-fault
			System.Exception ex11;
			if (stream != null)
			{
				if (ex != null)
				{
					try
					{
						stream.close();
					}
					catch (System.Exception x8)
					{
						ex11 = ByteCodeHelper.MapException<System.Exception>(x8, ByteCodeHelper.MapFlags.None);
						goto IL_02cf;
					}
				}
				else
				{
					stream.close();
				}
			}
			goto end_IL_02b2;
			IL_02cf:
			System.Exception exception = ex11;
			Throwable.instancehelper_addSuppressed(ex, exception);
			end_IL_02b2:
			throw;
		}
		System.Exception ex12 = ex8;
		goto IL_02f4;
		IL_01c2:
		System.Exception ex13 = ex6;
		goto IL_0538;
		IL_022c:
		System.Exception ex14;
		try
		{
			try
			{
				bufferedWriter.close();
			}
			catch (System.Exception x9)
			{
				ex14 = ByteCodeHelper.MapException<System.Exception>(x9, ByteCodeHelper.MapFlags.None);
				goto IL_027d;
			}
		}
		catch
		{
			//try-fault
			System.Exception ex15;
			if (stream != null)
			{
				if (ex != null)
				{
					try
					{
						stream.close();
					}
					catch (System.Exception x10)
					{
						ex15 = ByteCodeHelper.MapException<System.Exception>(x10, ByteCodeHelper.MapFlags.None);
						goto IL_025e;
					}
				}
				else
				{
					stream.close();
				}
			}
			goto end_IL_0241;
			IL_025e:
			System.Exception exception = ex15;
			Throwable.instancehelper_addSuppressed(ex, exception);
			end_IL_0241:
			throw;
		}
		goto IL_0485;
		IL_027d:
		ex13 = ex14;
		goto IL_0538;
		IL_01be:
		System.Exception ex16 = ex5;
		try
		{
			ex16 = ex16;
			try
			{
				System.Exception ex9 = ex16;
				Throwable.instancehelper_addSuppressed(null, ex9);
			}
			catch (System.Exception x11)
			{
				ex16 = ByteCodeHelper.MapException<System.Exception>(x11, ByteCodeHelper.MapFlags.None);
				goto IL_0225;
			}
		}
		catch
		{
			//try-fault
			System.Exception ex17;
			if (stream != null)
			{
				if (ex != null)
				{
					try
					{
						stream.close();
					}
					catch (System.Exception x12)
					{
						ex17 = ByteCodeHelper.MapException<System.Exception>(x12, ByteCodeHelper.MapFlags.None);
						goto IL_0206;
					}
				}
				else
				{
					stream.close();
				}
			}
			goto end_IL_01e9;
			IL_0206:
			System.Exception exception = ex17;
			Throwable.instancehelper_addSuppressed(ex, exception);
			end_IL_01e9:
			throw;
		}
		goto IL_0485;
		IL_0225:
		ex13 = ex16;
		goto IL_0538;
		IL_0485:
		System.Exception ex18;
		try
		{
			try
			{
				Log.info(new StringBuilder().append("Written ").append(path).ToString());
			}
			catch (System.Exception x13)
			{
				ex18 = ByteCodeHelper.MapException<System.Exception>(x13, ByteCodeHelper.MapFlags.None);
				goto IL_04f2;
			}
		}
		catch
		{
			//try-fault
			System.Exception ex19;
			if (stream != null)
			{
				if (ex != null)
				{
					try
					{
						stream.close();
					}
					catch (System.Exception x14)
					{
						ex19 = ByteCodeHelper.MapException<System.Exception>(x14, ByteCodeHelper.MapFlags.None);
						goto IL_04d6;
					}
				}
				else
				{
					stream.close();
				}
			}
			goto end_IL_04b9;
			IL_04d6:
			System.Exception exception = ex19;
			Throwable.instancehelper_addSuppressed(ex, exception);
			end_IL_04b9:
			throw;
		}
		if (stream == null)
		{
			return;
		}
		if ((object)null != null)
		{
			System.Exception ex20;
			try
			{
				stream.close();
				return;
			}
			catch (System.Exception x15)
			{
				ex20 = ByteCodeHelper.MapException<System.Exception>(x15, ByteCodeHelper.MapFlags.None);
			}
			System.Exception exception2 = ex20;
			Throwable.instancehelper_addSuppressed(null, exception2);
		}
		else
		{
			stream.close();
		}
		return;
		IL_04f2:
		ex13 = ex18;
		goto IL_0538;
		IL_042e:
		System.Exception ex21;
		ex13 = ex21;
		goto IL_0538;
		IL_0371:
		System.Exception ex22;
		System.Exception ex23 = ex22;
		try
		{
			ex23 = ex23;
			try
			{
				System.Exception exception3 = ex23;
				Throwable.instancehelper_addSuppressed(ex2, exception3);
			}
			catch (System.Exception x16)
			{
				ex23 = ByteCodeHelper.MapException<System.Exception>(x16, ByteCodeHelper.MapFlags.None);
				goto IL_03d9;
			}
		}
		catch
		{
			//try-fault
			System.Exception ex24;
			if (stream != null)
			{
				if (ex != null)
				{
					try
					{
						stream.close();
					}
					catch (System.Exception x17)
					{
						ex24 = ByteCodeHelper.MapException<System.Exception>(x17, ByteCodeHelper.MapFlags.None);
						goto IL_03ba;
					}
				}
				else
				{
					stream.close();
				}
			}
			goto end_IL_039d;
			IL_03ba:
			System.Exception exception = ex24;
			Throwable.instancehelper_addSuppressed(ex, exception);
			end_IL_039d:
			throw;
		}
		goto IL_0435;
		IL_03d9:
		ex13 = ex23;
		goto IL_0538;
		IL_0538:
		System.Exception ex25 = ex13;
		try
		{
			System.Exception exception2 = ex25;
			ex = exception2;
			throw Throwable.___003Cunmap_003E(exception2);
		}
		catch
		{
			//try-fault
			if (stream != null)
			{
				if (ex != null)
				{
					try
					{
						stream.close();
					}
					catch (System.Exception x18)
					{
						ex25 = ByteCodeHelper.MapException<System.Exception>(x18, ByteCodeHelper.MapFlags.None);
						goto IL_0567;
					}
				}
				else
				{
					stream.close();
				}
			}
			goto end_IL_054a;
			IL_0567:
			System.Exception exception = ex25;
			Throwable.instancehelper_addSuppressed(ex, exception);
			end_IL_054a:
			throw;
		}
		IL_0435:
		System.Exception ex26;
		System.Exception ex27;
		try
		{
			try
			{
				throw Throwable.___003Cunmap_003E(ex26);
			}
			catch (System.Exception x19)
			{
				ex27 = ByteCodeHelper.MapException<System.Exception>(x19, ByteCodeHelper.MapFlags.None);
			}
		}
		catch
		{
			//try-fault
			System.Exception ex28;
			if (stream != null)
			{
				if (ex != null)
				{
					try
					{
						stream.close();
					}
					catch (System.Exception x20)
					{
						ex28 = ByteCodeHelper.MapException<System.Exception>(x20, ByteCodeHelper.MapFlags.None);
						goto IL_0464;
					}
				}
				else
				{
					stream.close();
				}
			}
			goto end_IL_0447;
			IL_0464:
			System.Exception exception = ex28;
			Throwable.instancehelper_addSuppressed(ex, exception);
			end_IL_0447:
			throw;
		}
		ex13 = ex27;
		goto IL_0538;
		IL_01ad:
		ex12 = ex4;
		goto IL_02f4;
		IL_0375:
		System.Exception ex29;
		ex13 = ex29;
		goto IL_0538;
		IL_02ed:
		ex13 = ex10;
		goto IL_0538;
		IL_03e0:
		try
		{
			try
			{
				bufferedWriter.close();
			}
			catch (System.Exception x21)
			{
				ex21 = ByteCodeHelper.MapException<System.Exception>(x21, ByteCodeHelper.MapFlags.None);
				goto IL_042e;
			}
		}
		catch
		{
			//try-fault
			System.Exception ex30;
			if (stream != null)
			{
				if (ex != null)
				{
					try
					{
						stream.close();
					}
					catch (System.Exception x22)
					{
						ex30 = ByteCodeHelper.MapException<System.Exception>(x22, ByteCodeHelper.MapFlags.None);
						goto IL_0412;
					}
				}
				else
				{
					stream.close();
				}
			}
			goto end_IL_03f5;
			IL_0412:
			System.Exception exception = ex30;
			Throwable.instancehelper_addSuppressed(ex, exception);
			end_IL_03f5:
			throw;
		}
		goto IL_0435;
		IL_02f4:
		ex22 = ex12;
		try
		{
			ex22 = ex22;
			try
			{
				ex26 = ex22;
				if (bufferedWriter != null)
				{
					if (ex2 == null)
					{
						goto IL_03e0;
					}
					try
					{
						bufferedWriter.close();
					}
					catch (System.Exception x23)
					{
						ex22 = ByteCodeHelper.MapException<System.Exception>(x23, ByteCodeHelper.MapFlags.None);
						goto IL_0371;
					}
				}
			}
			catch (System.Exception x24)
			{
				ex29 = ByteCodeHelper.MapException<System.Exception>(x24, ByteCodeHelper.MapFlags.None);
				goto IL_0375;
			}
		}
		catch
		{
			//try-fault
			System.Exception ex31;
			if (stream != null)
			{
				if (ex != null)
				{
					try
					{
						stream.close();
					}
					catch (System.Exception x25)
					{
						ex31 = ByteCodeHelper.MapException<System.Exception>(x25, ByteCodeHelper.MapFlags.None);
						goto IL_034d;
					}
				}
				else
				{
					stream.close();
				}
			}
			goto end_IL_0330;
			IL_034d:
			System.Exception exception = ex31;
			Throwable.instancehelper_addSuppressed(ex, exception);
			end_IL_0330:
			throw;
		}
		goto IL_0435;
	}

	
	
	private string concatPackageName(string P_0, string P_1, string P_2)
	{
		string result = new StringBuilder().append((P_1 != null) ? new StringBuilder().append(P_1).append(", \\").append(P_2)
			.ToString() : new StringBuilder().append("\\").append(P_2).ToString()).append("    ").append(P_0)
			.ToString();
		
		return result;
	}

	
	
	private static string getPackageName(Path P_0, Path P_1)
	{
		string result = java.lang.String.instancehelper_replace(P_0.relativize(P_1.getParent()).ToString(), File.separatorChar, '.');
		
		return result;
	}

	
	
	
	private object lambda_0024generate_00240()
	{
		string simpleName = java.lang.Object.instancehelper_getClass(this).getSimpleName();
		
		return simpleName;
	}

	
	
	
	private static bool lambda_0024generate_00241(Path P_0)
	{
		bool result = Files.isRegularFile(P_0);
		
		return result;
	}

	
	
	
	private static string lambda_0024generate_00242(Path P_0, Path P_1)
	{
		string packageName = getPackageName(P_0, P_1);
		
		return packageName;
	}

	
	
	
	private string lambda_0024generate_00243(string P_0, string P_1, string P_2)
	{
		string result = concatPackageName(P_2, P_1, P_0);
		
		return result;
	}
}
