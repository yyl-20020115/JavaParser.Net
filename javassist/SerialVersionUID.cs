using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.security;
using java.util;
using java.util.function;
using javassist.bytecode;

namespace javassist;

public class SerialVersionUID : Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[IKVM.Attributes.Signature("Ljava/lang/Object;Ljava/util/Comparator<Ljavassist/CtField;>;")]
	[IKVM.Attributes.EnclosingMethod(null, "calculateDefault", "(Ljavassist.CtClass;)J")]
	internal class _1 : Object, Comparator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(119)]
		public virtual int compare(CtField P_0, CtField P_1)
		{
			int result = String.instancehelper_compareTo(P_0.getName(), P_1.getName());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(116)]
		internal _1()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(116)]
		public virtual int compare(object P_0, object P_1)
		{
			int result = compare((CtField)P_0, (CtField)P_1);
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator thenComparing(Comparator P_0)
		{
			return Comparator._003Cdefault_003EthenComparing(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator reversed()
		{
			return Comparator._003Cdefault_003Ereversed(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator thenComparing(Function P_0, Comparator P_1)
		{
			return Comparator._003Cdefault_003EthenComparing(this, P_0, P_1);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator thenComparing(Function P_0)
		{
			return Comparator._003Cdefault_003EthenComparing(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator thenComparingInt(ToIntFunction P_0)
		{
			return Comparator._003Cdefault_003EthenComparingInt(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator thenComparingLong(ToLongFunction P_0)
		{
			return Comparator._003Cdefault_003EthenComparingLong(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator thenComparingDouble(ToDoubleFunction P_0)
		{
			return Comparator._003Cdefault_003EthenComparingDouble(this, P_0);
		}

		bool Comparator.Comparator_003A_003Aequals(object P_0)
		{
			return Object.instancehelper_equals(this, P_0);
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[IKVM.Attributes.Signature("Ljava/lang/Object;Ljava/util/Comparator<Ljavassist/CtConstructor;>;")]
	[IKVM.Attributes.EnclosingMethod(null, "calculateDefault", "(Ljavassist.CtClass;)J")]
	internal class _2 : Object, Comparator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(143)]
		internal _2()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 96, 108, 42 })]
		public virtual int compare(CtConstructor P_0, CtConstructor P_1)
		{
			int result = String.instancehelper_compareTo(P_0.getMethodInfo2().getDescriptor(), P_1.getMethodInfo2().getDescriptor());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(143)]
		public virtual int compare(object P_0, object P_1)
		{
			int result = compare((CtConstructor)P_0, (CtConstructor)P_1);
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator thenComparing(Comparator P_0)
		{
			return Comparator._003Cdefault_003EthenComparing(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator reversed()
		{
			return Comparator._003Cdefault_003Ereversed(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator thenComparing(Function P_0, Comparator P_1)
		{
			return Comparator._003Cdefault_003EthenComparing(this, P_0, P_1);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator thenComparing(Function P_0)
		{
			return Comparator._003Cdefault_003EthenComparing(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator thenComparingInt(ToIntFunction P_0)
		{
			return Comparator._003Cdefault_003EthenComparingInt(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator thenComparingLong(ToLongFunction P_0)
		{
			return Comparator._003Cdefault_003EthenComparingLong(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator thenComparingDouble(ToDoubleFunction P_0)
		{
			return Comparator._003Cdefault_003EthenComparingDouble(this, P_0);
		}

		bool Comparator.Comparator_003A_003Aequals(object P_0)
		{
			return Object.instancehelper_equals(this, P_0);
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[IKVM.Attributes.Signature("Ljava/lang/Object;Ljava/util/Comparator<Ljavassist/CtMethod;>;")]
	[IKVM.Attributes.EnclosingMethod(null, "calculateDefault", "(Ljavassist.CtClass;)J")]
	internal class _3 : Object, Comparator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(163)]
		internal _3()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 116, 114, 99, 108, 144 })]
		public virtual int compare(CtMethod P_0, CtMethod P_1)
		{
			int num = String.instancehelper_compareTo(P_0.getName(), P_1.getName());
			if (num == 0)
			{
				num = String.instancehelper_compareTo(P_0.getMethodInfo2().getDescriptor(), P_1.getMethodInfo2().getDescriptor());
			}
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(163)]
		public virtual int compare(object P_0, object P_1)
		{
			int result = compare((CtMethod)P_0, (CtMethod)P_1);
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator thenComparing(Comparator P_0)
		{
			return Comparator._003Cdefault_003EthenComparing(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator reversed()
		{
			return Comparator._003Cdefault_003Ereversed(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator thenComparing(Function P_0, Comparator P_1)
		{
			return Comparator._003Cdefault_003EthenComparing(this, P_0, P_1);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator thenComparing(Function P_0)
		{
			return Comparator._003Cdefault_003EthenComparing(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator thenComparingInt(ToIntFunction P_0)
		{
			return Comparator._003Cdefault_003EthenComparingInt(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator thenComparingLong(ToLongFunction P_0)
		{
			return Comparator._003Cdefault_003EthenComparingLong(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator thenComparingDouble(ToDoubleFunction P_0)
		{
			return Comparator._003Cdefault_003EthenComparingDouble(this, P_0);
		}

		bool Comparator.Comparator_003A_003Aequals(object P_0)
		{
			return Object.instancehelper_equals(this, P_0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 21, 103 })]
	private static bool isSerializable(CtClass P_0)
	{
		ClassPool classPool = P_0.getClassPool();
		bool result = P_0.subtypeOf(classPool.get("java.io.Serializable"));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		35, 102, 103, 167, 103, 135, 168, 104, 106, 102,
		140, 138, 168, 104, 106, 47, 168, 103, 106, 43,
		200, 104, 236, 71, 106, 103, 105, 144, 109, 104,
		242, 57, 235, 76, 104, 107, 103, 203, 104, 236,
		72, 106, 103, 105, 102, 107, 104, 104, 46, 229,
		58, 232, 76, 236, 76, 106, 103, 239, 69, 102,
		109, 104, 104, 46, 229, 54, 235, 80, 102, 108,
		111, 100, 114, 45, 168, 159, 12, 98, 141, 98
	})]
	public static long calculateDefault(CtClass clazz)
	{
		//Discarded unreachable code: IL_0269
		IOException ex;
		NoSuchAlgorithmException ex2;
		try
		{
			try
			{
				ByteArrayOutputStream byteArrayOutputStream = new ByteArrayOutputStream();
				DataOutputStream dataOutputStream = new DataOutputStream(byteArrayOutputStream);
				ClassFile classFile = clazz.getClassFile();
				string str = javaName(clazz);
				dataOutputStream.writeUTF(str);
				CtMethod[] declaredMethods = clazz.getDeclaredMethods();
				int num = clazz.getModifiers();
				if (((uint)num & 0x200u) != 0)
				{
					num = (((nint)declaredMethods.LongLength <= 0) ? (num & -1025) : (num | 0x400));
				}
				dataOutputStream.writeInt(num);
				string[] interfaces = classFile.getInterfaces();
				for (int i = 0; i < (nint)interfaces.LongLength; i++)
				{
					interfaces[i] = javaName(interfaces[i]);
				}
				Arrays.sort(interfaces);
				for (int i = 0; i < (nint)interfaces.LongLength; i++)
				{
					dataOutputStream.writeUTF(interfaces[i]);
				}
				CtField[] declaredFields = clazz.getDeclaredFields();
				Arrays.sort(declaredFields, new _1());
				for (int j = 0; j < (nint)declaredFields.LongLength; j++)
				{
					CtField ctField = declaredFields[j];
					int modifiers = ctField.getModifiers();
					if ((modifiers & 2) == 0 || (modifiers & 0x88) == 0)
					{
						dataOutputStream.writeUTF(ctField.getName());
						dataOutputStream.writeInt(modifiers);
						dataOutputStream.writeUTF(ctField.getFieldInfo2().getDescriptor());
					}
				}
				if (classFile.getStaticInitializer() != null)
				{
					dataOutputStream.writeUTF("<clinit>");
					dataOutputStream.writeInt(8);
					dataOutputStream.writeUTF("()V");
				}
				CtConstructor[] declaredConstructors = clazz.getDeclaredConstructors();
				Arrays.sort(declaredConstructors, new _2());
				for (int k = 0; k < (nint)declaredConstructors.LongLength; k++)
				{
					CtConstructor ctConstructor = declaredConstructors[k];
					int modifiers2 = ctConstructor.getModifiers();
					if ((modifiers2 & 2) == 0)
					{
						dataOutputStream.writeUTF("<init>");
						dataOutputStream.writeInt(modifiers2);
						dataOutputStream.writeUTF(String.instancehelper_replace(ctConstructor.getMethodInfo2().getDescriptor(), '/', '.'));
					}
				}
				Arrays.sort(declaredMethods, new _3());
				for (int k = 0; k < (nint)declaredMethods.LongLength; k++)
				{
					CtMethod ctMethod = declaredMethods[k];
					int modifiers2 = ctMethod.getModifiers() & 0xD3F;
					if ((modifiers2 & 2) == 0)
					{
						dataOutputStream.writeUTF(ctMethod.getName());
						dataOutputStream.writeInt(modifiers2);
						dataOutputStream.writeUTF(String.instancehelper_replace(ctMethod.getMethodInfo2().getDescriptor(), '/', '.'));
					}
				}
				dataOutputStream.flush();
				MessageDigest instance = MessageDigest.getInstance("SHA");
				byte[] array = instance.digest(byteArrayOutputStream.toByteArray());
				long num2 = 0L;
				for (int l = Math.min(array.Length, 8) - 1; l >= 0; l += -1)
				{
					num2 = (num2 << 8) | (int)array[l];
				}
				return num2;
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
		}
		catch (NoSuchAlgorithmException x2)
		{
			ex2 = ByteCodeHelper.MapException<NoSuchAlgorithmException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_028b;
		}
		IOException e = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
		IL_028b:
		NoSuchAlgorithmException e2 = ex2;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(209)]
	private static string javaName(CtClass P_0)
	{
		string result = Descriptor.toJavaName(Descriptor.toJvmName(P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(213)]
	private static string javaName(string P_0)
	{
		string result = Descriptor.toJavaName(Descriptor.toJvmName(P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(37)]
	public SerialVersionUID()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException", "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		159, 190, 119, 129, 161, 104, 161, 145, 136, 127,
		7
	})]
	public static void setSerialVersionUID(CtClass clazz)
	{
		try
		{
			clazz.getDeclaredField("serialVersionUID");
			return;
		}
		catch (NotFoundException)
		{
		}
		_ = null;
		if (isSerializable(clazz))
		{
			CtField ctField = new CtField(CtClass.longType, "serialVersionUID", clazz);
			ctField.setModifiers(26);
			clazz.addField(ctField, new StringBuilder().append(calculateDefault(clazz)).append("L").toString());
		}
	}
}
