using System;


using IKVM.Runtime;
using java.io;
using java.lang;
using java.util.function;

namespace com.github.javaparser.utils;

public class Log
{
	public interface Adapter
	{
				
		virtual void info(Supplier message);

				
		virtual void trace(Supplier message);

		virtual void error(Supplier throwableSupplier, Supplier messageSupplier);
	}

	public class SilentAdapter :  Adapter
	{
		
		
		public SilentAdapter()
		{
		}

				
		public virtual void info(Supplier messageSupplier)
		{
		}

				
		public virtual void trace(Supplier messageSupplier)
		{
		}

		public virtual void error(Supplier throwableSupplier, Supplier messageSupplier)
		{
		}
	}

	public class StandardOutStandardErrorAdapter :  Adapter
	{
		
		private sealed class ___003C_003EAnon0 : Supplier
		{
			private readonly StringWriter arg_00241;

			internal ___003C_003EAnon0(StringWriter P_0)
			{
				arg_00241 = P_0;
			}

			public object get()
			{
				string result = arg_00241.ToString();
				
				return result;
			}
		}

		
		
		public StandardOutStandardErrorAdapter()
		{
		}

		
		
		private unsafe void printStackTrace(System.Exception throwable)
		{
			StringWriter stringWriter;
			System.Exception ex;
			PrintWriter printWriter;
			System.Exception ex2;
			System.Exception ex3;
			System.Exception ex4;
			System.Exception ex5;
			System.Exception ex6;
			System.Exception ex7;
			try
			{
				stringWriter = new StringWriter();
				ex = null;
				try
				{
					try
					{
						printWriter = new PrintWriter(stringWriter);
						ex2 = null;
						try
						{
							try
							{
								Throwable.instancehelper_printStackTrace(throwable, printWriter);
								
								trace(new ___003C_003EAnon0(stringWriter));
							}
							catch (System.Exception x)
							{
								ex3 = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
								goto end_IL_0008;
							}
						}
						catch (System.Exception x2)
						{
							ex4 = ByteCodeHelper.MapException<System.Exception>(x2, ByteCodeHelper.MapFlags.None);
							goto IL_008c;
						}
						if (printWriter != null)
						{
							if ((object)null == null)
							{
								goto IL_00fe;
							}
							try
							{
								printWriter.close();
							}
							catch (System.Exception x3)
							{
								ex5 = ByteCodeHelper.MapException<System.Exception>(x3, ByteCodeHelper.MapFlags.None);
								goto IL_009d;
							}
						}
						goto IL_02a2;
						end_IL_0008:;
					}
					catch (System.Exception x4)
					{
						ex6 = ByteCodeHelper.MapException<System.Exception>(x4, ByteCodeHelper.MapFlags.None);
						goto IL_00a1;
					}
				}
				catch (System.Exception x5)
				{
					ex7 = ByteCodeHelper.MapException<System.Exception>(x5, ByteCodeHelper.MapFlags.None);
					goto IL_00a8;
				}
			}
			catch (IOException)
			{
				goto IL_00af;
			}
			System.Exception ex9 = ex3;
			System.Exception ex11;
			System.Exception ex12;
			try
			{
				ex9 = ex9;
				try
				{
					ex9 = ex9;
					try
					{
						ex9 = ex9;
						try
						{
							System.Exception ex10 = ex9;
							ex2 = ex10;
							throw ex10;
						}
						catch (System.Exception x6)
						{
							ex9 = ByteCodeHelper.MapException<System.Exception>(x6, ByteCodeHelper.MapFlags.None);
						}
					}
					catch (System.Exception x7)
					{
						ex11 = ByteCodeHelper.MapException<System.Exception>(x7, ByteCodeHelper.MapFlags.None);
						goto IL_0178;
					}
				}
				catch (System.Exception x8)
				{
					ex12 = ByteCodeHelper.MapException<System.Exception>(x8, ByteCodeHelper.MapFlags.None);
					goto IL_017f;
				}
			}
			catch (IOException)
			{
				goto IL_0186;
			}
			System.Exception ex14 = ex9;
			goto IL_018c;
			IL_00af:
			object obj = null;
			goto IL_03a6;
			IL_00a8:
			System.Exception ex15 = ex7;
			goto IL_0338;
			IL_00a1:
			System.Exception ex16 = ex6;
			goto IL_030d;
			IL_00fe:
			System.Exception ex17;
			System.Exception ex18;
			try
			{
				try
				{
					try
					{
						printWriter.close();
					}
					catch (System.Exception x9)
					{
						ex17 = ByteCodeHelper.MapException<System.Exception>(x9, ByteCodeHelper.MapFlags.None);
						goto IL_0123;
					}
				}
				catch (System.Exception x10)
				{
					ex18 = ByteCodeHelper.MapException<System.Exception>(x10, ByteCodeHelper.MapFlags.None);
					goto IL_012a;
				}
			}
			catch (IOException)
			{
				goto IL_0131;
			}
			goto IL_02a2;
			IL_0131:
			obj = null;
			goto IL_03a6;
			IL_012a:
			ex15 = ex18;
			goto IL_0338;
			IL_0123:
			ex16 = ex17;
			goto IL_030d;
			IL_009d:
			System.Exception ex20 = ex5;
			System.Exception ex21;
			try
			{
				ex20 = ex20;
				try
				{
					ex20 = ex20;
					try
					{
						System.Exception ex10 = ex20;
						Throwable.instancehelper_addSuppressed(null, ex10);
					}
					catch (System.Exception x11)
					{
						ex20 = ByteCodeHelper.MapException<System.Exception>(x11, ByteCodeHelper.MapFlags.None);
						goto IL_00ea;
					}
				}
				catch (System.Exception x12)
				{
					ex21 = ByteCodeHelper.MapException<System.Exception>(x12, ByteCodeHelper.MapFlags.None);
					goto IL_00f1;
				}
			}
			catch (IOException)
			{
				goto IL_00f8;
			}
			goto IL_02a2;
			IL_00f8:
			obj = null;
			goto IL_03a6;
			IL_00f1:
			ex15 = ex21;
			goto IL_0338;
			IL_00ea:
			ex16 = ex20;
			goto IL_030d;
			IL_02a2:
			System.Exception ex23;
			try
			{
				if (stringWriter == null)
				{
					return;
				}
				if ((object)null != null)
				{
					try
					{
						stringWriter.close();
						return;
					}
					catch (System.Exception x13)
					{
						ex23 = ByteCodeHelper.MapException<System.Exception>(x13, ByteCodeHelper.MapFlags.None);
					}
					goto IL_02cd;
				}
			}
			catch (IOException)
			{
				goto IL_02d1;
			}
			try
			{
				stringWriter.close();
				return;
			}
			catch (IOException)
			{
			}
			obj = null;
			goto IL_03a6;
			IL_02d1:
			obj = null;
			goto IL_03a6;
			IL_0394:
			obj = null;
			goto IL_03a6;
			IL_0366:
			System.Exception ex26;
			System.Exception ex27 = ex26;
			try
			{
				System.Exception exception = ex27;
				Throwable.instancehelper_addSuppressed(ex, exception);
			}
			catch (IOException)
			{
				goto IL_0383;
			}
			goto IL_0397;
			IL_02cd:
			System.Exception ex29 = ex23;
			try
			{
				System.Exception exception2 = ex29;
				Throwable.instancehelper_addSuppressed(null, exception2);
				return;
			}
			catch (IOException)
			{
			}
			obj = null;
			goto IL_03a6;
			IL_0383:
			obj = null;
			goto IL_03a6;
			IL_008c:
			ex14 = ex4;
			goto IL_018c;
			IL_036a:
			obj = null;
			goto IL_03a6;
			IL_0186:
			obj = null;
			goto IL_03a6;
			IL_017f:
			ex15 = ex12;
			goto IL_0338;
			IL_0178:
			ex16 = ex11;
			goto IL_030d;
			IL_0386:
			try
			{
				stringWriter.close();
			}
			catch (IOException)
			{
				goto IL_0394;
			}
			goto IL_0397;
			IL_018c:
			System.Exception ex32 = ex14;
			System.Exception ex33;
			System.Exception ex34;
			System.Exception ex35;
			try
			{
				ex32 = ex32;
				try
				{
					ex32 = ex32;
					try
					{
						ex33 = ex32;
						if (printWriter != null)
						{
							if (ex2 == null)
							{
								goto IL_023a;
							}
							try
							{
								printWriter.close();
							}
							catch (System.Exception x14)
							{
								ex32 = ByteCodeHelper.MapException<System.Exception>(x14, ByteCodeHelper.MapFlags.None);
								goto IL_01dc;
							}
						}
					}
					catch (System.Exception x15)
					{
						ex34 = ByteCodeHelper.MapException<System.Exception>(x15, ByteCodeHelper.MapFlags.None);
						goto IL_01e0;
					}
				}
				catch (System.Exception x16)
				{
					ex35 = ByteCodeHelper.MapException<System.Exception>(x16, ByteCodeHelper.MapFlags.None);
					goto IL_01e7;
				}
			}
			catch (IOException)
			{
				goto IL_01ee;
			}
			goto IL_0270;
			IL_01ee:
			obj = null;
			goto IL_03a6;
			IL_01e7:
			ex15 = ex35;
			goto IL_0338;
			IL_01e0:
			ex16 = ex34;
			goto IL_030d;
			IL_023a:
			System.Exception ex37;
			System.Exception ex38;
			try
			{
				try
				{
					try
					{
						printWriter.close();
					}
					catch (System.Exception x17)
					{
						ex37 = ByteCodeHelper.MapException<System.Exception>(x17, ByteCodeHelper.MapFlags.None);
						goto IL_025c;
					}
				}
				catch (System.Exception x18)
				{
					ex38 = ByteCodeHelper.MapException<System.Exception>(x18, ByteCodeHelper.MapFlags.None);
					goto IL_0263;
				}
			}
			catch (IOException)
			{
				goto IL_026a;
			}
			goto IL_0270;
			IL_026a:
			obj = null;
			goto IL_03a6;
			IL_0263:
			ex15 = ex38;
			goto IL_0338;
			IL_025c:
			ex16 = ex37;
			goto IL_030d;
			IL_01dc:
			System.Exception ex40 = ex32;
			System.Exception ex41;
			try
			{
				ex40 = ex40;
				try
				{
					ex40 = ex40;
					try
					{
						System.Exception exception3 = ex40;
						Throwable.instancehelper_addSuppressed(ex2, exception3);
					}
					catch (System.Exception x19)
					{
						ex40 = ByteCodeHelper.MapException<System.Exception>(x19, ByteCodeHelper.MapFlags.None);
						goto IL_0226;
					}
				}
				catch (System.Exception x20)
				{
					ex41 = ByteCodeHelper.MapException<System.Exception>(x20, ByteCodeHelper.MapFlags.None);
					goto IL_022d;
				}
			}
			catch (IOException)
			{
				goto IL_0234;
			}
			goto IL_0270;
			IL_0234:
			obj = null;
			goto IL_03a6;
			IL_022d:
			ex15 = ex41;
			goto IL_0338;
			IL_0226:
			ex16 = ex40;
			goto IL_030d;
			IL_0270:
			System.Exception ex43;
			System.Exception ex44;
			try
			{
				try
				{
					try
					{
						throw (ex33);
					}
					catch (System.Exception x21)
					{
						ex43 = ByteCodeHelper.MapException<System.Exception>(x21, ByteCodeHelper.MapFlags.None);
					}
				}
				catch (System.Exception x22)
				{
					ex44 = ByteCodeHelper.MapException<System.Exception>(x22, ByteCodeHelper.MapFlags.None);
					goto IL_0295;
				}
			}
			catch (IOException)
			{
				goto IL_029c;
			}
			ex16 = ex43;
			goto IL_030d;
			IL_029c:
			obj = null;
			goto IL_03a6;
			IL_0295:
			ex15 = ex44;
			goto IL_0338;
			IL_0397:
			System.Exception ex46;
			try
			{
				throw ex46;
			}
			catch (IOException)
			{
			}
			obj = null;
			goto IL_03a6;
			IL_030d:
			ex29 = ex16;
			try
			{
				ex29 = ex29;
				try
				{
					System.Exception exception2 = ex29;
					ex = exception2;
					throw exception2;
				}
				catch (System.Exception x23)
				{
					ex29 = ByteCodeHelper.MapException<System.Exception>(x23, ByteCodeHelper.MapFlags.None);
				}
			}
			catch (IOException)
			{
				goto IL_0332;
			}
			ex15 = ex29;
			goto IL_0338;
			IL_0332:
			obj = null;
			goto IL_03a6;
			IL_03a6:
			
			throw new AssertionError("Error in logging library");
			IL_0338:
			ex26 = ex15;
			try
			{
				ex46 = ex26;
				if (stringWriter != null)
				{
					if (ex == null)
					{
						goto IL_0386;
					}
					try
					{
						stringWriter.close();
					}
					catch (System.Exception x24)
					{
						ex26 = ByteCodeHelper.MapException<System.Exception>(x24, ByteCodeHelper.MapFlags.None);
						goto IL_0366;
					}
				}
			}
			catch (IOException)
			{
				goto IL_036a;
			}
			goto IL_0397;
		}

		
				
		
		public virtual void trace(Supplier messageSupplier)
		{
			System.Console.WriteLine((string)messageSupplier.get());
		}

		
				
		
		public virtual void info(Supplier messageSupplier)
		{
			System.Console.WriteLine((string)messageSupplier.get());
		}
		public virtual void error(Supplier throwableSupplier, Supplier messageSupplier)
		{
			System.Exception ex = (System.Exception)throwableSupplier.get();
			string text = (string)messageSupplier.get();
			if (text == null)
			{
				java.lang.System.err.println(Throwable.instancehelper_getMessage(ex));
				printStackTrace(ex);
			}
			else if (ex == null)
			{
				java.lang.System.err.println(text);
			}
			else
			{
				java.lang.System.err.println(new StringBuilder().append(text).append(":").append(Throwable.instancehelper_getMessage(ex))
					.ToString());
				printStackTrace(ex);
			}
		}
	}

	
	private sealed class ___003C_003EAnon0 : Supplier
	{
		private readonly Supplier[] arg_00241;

		private readonly string arg_00242;

		internal ___003C_003EAnon0(Supplier[] P_0, string P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object get()
		{
			string result = lambda_0024makeFormattingSupplier_00240(arg_00241, arg_00242);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon1 : Supplier
	{
		private readonly System.Exception arg_00241;

		internal ___003C_003EAnon1(System.Exception P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			System.Exception result = lambda_0024error_00241(arg_00241);
			
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
			string result = lambda_0024error_00242();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon3 : Supplier
	{
		private readonly System.Exception arg_00241;

		internal ___003C_003EAnon3(System.Exception P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			System.Exception result = lambda_0024error_00243(arg_00241);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon4 : Supplier
	{
		internal ___003C_003EAnon4()
		{
		}

		public object get()
		{
			System.Exception result = lambda_0024error_00244();
			
			return result;
		}
	}

	private static Adapter CURRENT_ADAPTER;

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
	public static void setAdapter(Adapter adapter)
	{
		CURRENT_ADAPTER = adapter;
	}

	
		
	
	[SafeVarargs(new object[]
	{
		(byte)64,
		"Ljava/lang/SafeVarargs;"
	})]
	public static void info(string format, params Supplier[] args)
	{
		CURRENT_ADAPTER.info(makeFormattingSupplier(format, args));
	}

	
		
	
	private static Supplier makeFormattingSupplier(string format, Supplier[] args)
	{
		return new ___003C_003EAnon0(args, format);
	}

	
	
	
	
	private static string lambda_0024makeFormattingSupplier_00240(Supplier[] args, string format)
	{
		object[] array = new object[(nint)args.LongLength];
		for (int i = 0; i < (nint)args.LongLength; i++)
		{
			array[i] = args[i].get();
		}
		string result = CodeGenerationUtils.f(format, array);
		
		return result;
	}

	
	
	private static System.Exception lambda_0024error_00241(System.Exception throwable)
	{
		return throwable;
	}

	
	private static string lambda_0024error_00242()
	{
		return null;
	}

	
	
	private static System.Exception lambda_0024error_00243(System.Exception throwable)
	{
		return throwable;
	}

	
	private static System.Exception lambda_0024error_00244()
	{
		return null;
	}

	
	
	public Log()
	{
	}

	
		
	
	[SafeVarargs(new object[]
	{
		(byte)64,
		"Ljava/lang/SafeVarargs;"
	})]
	public static void trace(string format, params Supplier[] args)
	{
		CURRENT_ADAPTER.trace(makeFormattingSupplier(format, args));
	}

	
	
	
	public static void error(System.Exception throwable)
	{
		CURRENT_ADAPTER.error(new ___003C_003EAnon1(throwable), new ___003C_003EAnon2());
	}

	
		
	
	[SafeVarargs(new object[]
	{
		(byte)64,
		"Ljava/lang/SafeVarargs;"
	})]
	public static void error(System.Exception throwable, string format, params Supplier[] args)
	{
		CURRENT_ADAPTER.error(new ___003C_003EAnon3(throwable), makeFormattingSupplier(format, args));
	}

	
		
	
	[SafeVarargs(new object[]
	{
		(byte)64,
		"Ljava/lang/SafeVarargs;"
	})]
	public static void error(string format, params Supplier[] args)
	{
		CURRENT_ADAPTER.error(new ___003C_003EAnon4(), makeFormattingSupplier(format, args));
	}

	
	static Log()
	{
		CURRENT_ADAPTER = new SilentAdapter();
	}
}
