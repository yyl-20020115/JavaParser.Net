using System;
using System.Runtime.CompilerServices;
using System.Threading;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.lang.@ref;
using java.net;
using java.util;
using javassist.bytecode;
using javassist.bytecode.annotation;
using javassist.compiler;
using javassist.expr;

namespace javassist;

internal class CtClassType : CtClass
{
	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	internal ClassPool classPool;

	internal bool wasChanged;

	private bool wasFrozen;

	internal bool wasPruned;

	internal bool gcConstPool;

	internal ClassFile classfile;

	internal byte[] rawClassfile;

	[IKVM.Attributes.Signature("Ljava/lang/ref/Reference<Ljavassist/CtMember$Cache;>;")]
	private Reference memberCache;

	private AccessorMaker accessors;

	private FieldInitLink fieldInitializers;

	[IKVM.Attributes.Signature("Ljava/util/Map<Ljavassist/CtMethod;Ljava/lang/String;>;")]
	private Map hiddenMethods;

	private int uniqueNumberSeed;

	private bool doPruning;

	private int getCount;

	private const int GET_THRESHOLD = 2;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	internal virtual void setClassPool(ClassPool P_0)
	{
		classPool = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		33, 233, 59, 235, 70, 103, 127, 9, 103, 103,
		103, 103, 103, 103, 103, 103
	})]
	internal CtClassType(string P_0, ClassPool P_1)
		: base(P_0)
	{
		doPruning = ClassPool.doPruning;
		classPool = P_1;
		int num = 0;
		int num2 = num;
		gcConstPool = (byte)num != 0;
		num = num2;
		int num3 = num;
		wasPruned = (byte)num != 0;
		num = num3;
		int num4 = num;
		wasFrozen = (byte)num != 0;
		wasChanged = (byte)num4 != 0;
		classfile = null;
		rawClassfile = null;
		memberCache = null;
		accessors = null;
		fieldInitializers = null;
		hiddenMethods = null;
		uniqueNumberSeed = 0;
		getCount = 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 47, 111, 118, 113 })]
	internal CtClassType(InputStream P_0, ClassPool P_1)
		: this((string)null, P_1)
	{
		ClassFile.___003Cclinit_003E();
		classfile = new ClassFile(new DataInputStream(P_0));
		qualifiedName = classfile.getName();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 53, 111, 103, 113 })]
	internal CtClassType(ClassFile P_0, ClassPool P_1)
		: this((string)null, P_1)
	{
		classfile = P_0;
		qualifiedName = classfile.getName();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 203, 99, 132, 135, 99, 132, 135, 99, 103,
		112, 2, 198, 99, 103, 112, 2, 198
	})]
	internal static bool hasAnnotationType(string P_0, ClassPool P_1, AnnotationsAttribute P_2, AnnotationsAttribute P_3)
	{
		Annotation[] array = P_2?.getAnnotations();
		Annotation[] array2 = P_3?.getAnnotations();
		if (array != null)
		{
			for (int i = 0; i < (nint)array.LongLength; i++)
			{
				if (java.lang.String.instancehelper_equals(array[i].getTypeName(), P_0))
				{
					return true;
				}
			}
		}
		if (array2 != null)
		{
			for (int i = 0; i < (nint)array2.LongLength; i++)
			{
				if (java.lang.String.instancehelper_equals(array2[i].getTypeName(), P_0))
				{
					return true;
				}
			}
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.ClassNotFoundException" })]
	[IKVM.Attributes.Signature("(Ljava/lang/Class<*>;Ljavassist/ClassPool;Ljavassist/bytecode/AnnotationsAttribute;Ljavassist/bytecode/AnnotationsAttribute;)Ljava/lang/Object;")]
	[LineNumberTable(new byte[]
	{
		161, 242, 99, 132, 135, 99, 132, 135, 103, 99,
		103, 112, 12, 198, 99, 103, 112, 12, 198
	})]
	internal static object getAnnotationType(Class P_0, ClassPool P_1, AnnotationsAttribute P_2, AnnotationsAttribute P_3)
	{
		Annotation[] array = P_2?.getAnnotations();
		Annotation[] array2 = P_3?.getAnnotations();
		string name = P_0.getName();
		if (array != null)
		{
			for (int i = 0; i < (nint)array.LongLength; i++)
			{
				if (java.lang.String.instancehelper_equals(array[i].getTypeName(), name))
				{
					object result = toAnnoType(array[i], P_1);
					_ = null;
					return result;
				}
			}
		}
		if (array2 != null)
		{
			for (int i = 0; i < (nint)array2.LongLength; i++)
			{
				if (java.lang.String.instancehelper_equals(array2[i].getTypeName(), name))
				{
					object result2 = toAnnoType(array2[i], P_1);
					_ = null;
					return result2;
				}
			}
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.ClassNotFoundException" })]
	[LineNumberTable(new byte[]
	{
		158, 231, 98, 99, 98, 164, 103, 163, 99, 98,
		165, 103, 164, 102, 107, 104, 47, 168, 105, 49,
		168, 131, 103, 136, 157, 227, 60, 232, 69, 137,
		157, 227, 60, 232, 70
	})]
	internal static object[] toAnnotationType(bool P_0, ClassPool P_1, AnnotationsAttribute P_2, AnnotationsAttribute P_3)
	{
		Annotation[] array;
		int num;
		if (P_2 == null)
		{
			array = null;
			num = 0;
		}
		else
		{
			array = P_2.getAnnotations();
			num = array.Length;
		}
		Annotation[] array2;
		int num2;
		if (P_3 == null)
		{
			array2 = null;
			num2 = 0;
		}
		else
		{
			array2 = P_3.getAnnotations();
			num2 = array2.Length;
		}
		if (!P_0)
		{
			object[] array3 = new object[num + num2];
			for (int i = 0; i < num; i++)
			{
				array3[i] = toAnnoType(array[i], P_1);
			}
			for (int i = 0; i < num2; i++)
			{
				array3[i + num] = toAnnoType(array2[i], P_1);
			}
			return array3;
		}
		ArrayList arrayList = new ArrayList();
		for (int i = 0; i < num; i++)
		{
			try
			{
				((List)arrayList).add(toAnnoType(array[i], P_1));
			}
			catch (java.lang.ClassNotFoundException)
			{
				goto IL_00a8;
			}
			continue;
			IL_00a8:
			_ = null;
		}
		for (int i = 0; i < num2; i++)
		{
			try
			{
				((List)arrayList).add(toAnnoType(array2[i], P_1));
			}
			catch (java.lang.ClassNotFoundException)
			{
				goto IL_00d9;
			}
			continue;
			IL_00d9:
			_ = null;
		}
		return ((List)arrayList).toArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.ClassNotFoundException" })]
	[LineNumberTable(new byte[]
	{
		158, 219, 130, 98, 99, 105, 99, 137, 141, 103,
		201, 99, 99, 165, 106, 165, 99, 99, 165, 106,
		165, 102, 109, 105, 49, 168, 105, 52, 205, 103,
		137, 158, 227, 60, 232, 70, 137, 158, 227, 60,
		232, 71, 234, 19, 233, 113
	})]
	internal static object[][] toAnnotationType(bool P_0, ClassPool P_1, ParameterAnnotationsAttribute P_2, ParameterAnnotationsAttribute P_3, MethodInfo P_4)
	{
		_ = 0;
		int num = P_2?.numParameters() ?? P_3?.numParameters() ?? Descriptor.numOfParameters(P_4.getDescriptor());
		object[][] array = new object[num][];
		for (int i = 0; i < num; i++)
		{
			Annotation[] array2;
			int num2;
			if (P_2 == null)
			{
				array2 = null;
				num2 = 0;
			}
			else
			{
				array2 = P_2.getAnnotations()[i];
				num2 = array2.Length;
			}
			Annotation[] array3;
			int num3;
			if (P_3 == null)
			{
				array3 = null;
				num3 = 0;
			}
			else
			{
				array3 = P_3.getAnnotations()[i];
				num3 = array3.Length;
			}
			if (!P_0)
			{
				array[i] = new object[num2 + num3];
				for (int j = 0; j < num2; j++)
				{
					array[i][j] = toAnnoType(array2[j], P_1);
				}
				for (int j = 0; j < num3; j++)
				{
					array[i][j + num2] = toAnnoType(array3[j], P_1);
				}
				continue;
			}
			ArrayList arrayList = new ArrayList();
			for (int k = 0; k < num2; k++)
			{
				try
				{
					((List)arrayList).add(toAnnoType(array2[k], P_1));
				}
				catch (java.lang.ClassNotFoundException)
				{
					goto IL_00f7;
				}
				continue;
				IL_00f7:
				_ = null;
			}
			for (int k = 0; k < num3; k++)
			{
				try
				{
					((List)arrayList).add(toAnnoType(array3[k], P_1));
				}
				catch (java.lang.ClassNotFoundException)
				{
					goto IL_0129;
				}
				continue;
				IL_0129:
				_ = null;
			}
			array[i] = ((List)arrayList).toArray();
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 88, 103, 103, 105, 103, 100, 101, 100, 101,
		134, 101, 101, 102, 101, 164
	})]
	public override int getModifiers()
	{
		ClassFile classFile = getClassFile2();
		int accessFlags = classFile.getAccessFlags();
		accessFlags = AccessFlag.clear(accessFlags, 32);
		int innerAccessFlags = classFile.getInnerAccessFlags();
		if (innerAccessFlags != -1)
		{
			if (((uint)innerAccessFlags & 8u) != 0)
			{
				accessFlags |= 8;
			}
			if (((uint)innerAccessFlags & (true ? 1u : 0u)) != 0)
			{
				accessFlags |= 1;
			}
			else
			{
				accessFlags &= -2;
				if (((uint)innerAccessFlags & 4u) != 0)
				{
					accessFlags |= 4;
				}
				else if (((uint)innerAccessFlags & 2u) != 0)
				{
					accessFlags |= 2;
				}
			}
		}
		int result = AccessFlag.toModifier(accessFlags);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 162, 200, 108, 99, 98 })]
	public override CtClass getSuperclass()
	{
		string superclass = getClassFile2().getSuperclass();
		if (superclass == null)
		{
			return null;
		}
		CtClass result = classPool.get(superclass);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 162, 217, 108, 99, 103, 102, 49, 166 })]
	public override CtClass[] getInterfaces()
	{
		string[] interfaces = getClassFile2().getInterfaces();
		int num = interfaces.Length;
		CtClass[] array = new CtClass[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = classPool.get(interfaces[i]);
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 88, 98, 110, 110, 103, 103, 103, 172 })]
	protected internal virtual CtMember.Cache getMembers()
	{
		_ = null;
		CtMember.Cache cache;
		if (memberCache == null || (cache = (CtMember.Cache)memberCache.get()) == null)
		{
			cache = new CtMember.Cache(this);
			makeFieldCache(cache);
			makeBehaviorCache(cache);
			memberCache = new java.lang.@ref.WeakReference(cache);
		}
		return cache;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 110, 104, 101, 104, 104, 142 })]
	private void exToString(StringBuilder P_0, string P_1, CtMember P_2, CtMember P_3)
	{
		P_0.append(P_1);
		while (P_2 != P_3)
		{
			P_2 = P_2.next();
			P_0.append(P_2);
			P_0.append(", ");
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159,
		97,
		162,
		103,
		99,
		130,
		99,
		171,
		136,
		103,
		99,
		138,
		104,
		151,
		167,
		223,
		13,
		2,
		98,
		148,
		103,
		105,
		103,
		117,
		172,
		131,
		115,
		100,
		145,
		105,
		120,
		116,
		127,
		7,
		126,
		159,
		5,
		byte.MaxValue,
		3,
		73,
		132,
		146,
		99,
		238,
		59,
		137,
		151,
		227,
		51,
		135,
		98,
		244,
		70,
		132,
		146,
		99,
		229,
		55,
		98,
		180,
		132,
		146,
		99
	})]
	public virtual ClassFile getClassFile3(bool P_0)
	{
		//Discarded unreachable code: IL_00ca
		ClassFile classFile = classfile;
		if (classFile != null)
		{
			return classFile;
		}
		if (P_0)
		{
			classPool.compress();
		}
		CtClassType obj;
		Monitor.Enter(obj = this);
		byte[] array;
		try
		{
			classFile = classfile;
			if (classFile != null)
			{
				ClassFile result = classFile;
				Monitor.Exit(obj);
				return result;
			}
			array = rawClassfile;
			Monitor.Exit(obj);
		}
		catch
		{
			//try-fault
			Monitor.Exit(obj);
			throw;
		}
		IOException ex;
		if (array != null)
		{
			ClassFile classFile2;
			try
			{
				ClassFile.___003Cclinit_003E();
				classFile2 = new ClassFile(new DataInputStream(new ByteArrayInputStream(array)));
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_0086;
			}
			getCount = 2;
			CtClassType obj2;
			Monitor.Enter(obj2 = this);
			try
			{
				rawClassfile = null;
				ClassFile result2 = setClassFile(classFile2);
				Monitor.Exit(obj2);
				return result2;
			}
			catch
			{
				//try-fault
				Monitor.Exit(obj2);
				throw;
			}
		}
		InputStream inputStream = null;
		ClassFile result3;
		NotFoundException ex2;
		IOException ex3;
		try
		{
			try
			{
				try
				{
					inputStream = classPool.openClassfile(getName());
					if (inputStream == null)
					{
						string name = getName();
						Throwable.___003CsuppressFillInStackTrace_003E();
						throw new NotFoundException(name);
					}
					inputStream = new BufferedInputStream(inputStream);
					ClassFile.___003Cclinit_003E();
					ClassFile classFile3 = new ClassFile(new DataInputStream((BufferedInputStream)inputStream));
					if (!java.lang.String.instancehelper_equals(classFile3.getName(), qualifiedName))
					{
						string message = new StringBuilder().append("cannot find ").append(qualifiedName).append(": ")
							.append(classFile3.getName())
							.append(" found in ")
							.append(java.lang.String.instancehelper_replace(qualifiedName, '.', '/'))
							.append(".class")
							.toString();
						Throwable.___003CsuppressFillInStackTrace_003E();
						throw new RuntimeException(message);
					}
					result3 = setClassFile(classFile3);
				}
				catch (NotFoundException x2)
				{
					ex2 = ByteCodeHelper.MapException<NotFoundException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
					goto IL_01e0;
				}
			}
			catch (IOException x3)
			{
				ex3 = ByteCodeHelper.MapException<IOException>(x3, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_01e4;
			}
		}
		catch
		{
			//try-fault
			if (inputStream != null)
			{
				try
				{
					inputStream.close();
				}
				catch (IOException)
				{
					goto IL_01d7;
				}
			}
			goto end_IL_01c4;
			IL_01d7:
			_ = null;
			end_IL_01c4:
			throw;
		}
		if ((BufferedInputStream)inputStream != null)
		{
			try
			{
				((BufferedInputStream)inputStream).close();
				return result3;
			}
			catch (IOException)
			{
			}
			_ = null;
		}
		return result3;
		IL_01e0:
		NotFoundException ex6 = ex2;
		try
		{
			NotFoundException ex7 = ex6;
			string message2 = Throwable.instancehelper_toString(ex7);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException(message2, ex7);
		}
		catch
		{
			//try-fault
			if (inputStream != null)
			{
				try
				{
					inputStream.close();
				}
				catch (IOException)
				{
					goto IL_023e;
				}
			}
			goto end_IL_022b;
			IL_023e:
			_ = null;
			end_IL_022b:
			throw;
		}
		IL_01e4:
		IOException ex9 = ex3;
		IOException ex10;
		try
		{
			ex10 = ex9;
			string message3 = Throwable.instancehelper_toString(ex10);
			IOException cause = ex10;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException(message3, cause);
		}
		catch
		{
			//try-fault
			if (inputStream != null)
			{
				try
				{
					inputStream.close();
				}
				catch (IOException)
				{
					goto IL_0272;
				}
			}
			goto end_IL_025f;
			IL_0272:
			_ = null;
			end_IL_025f:
			throw;
		}
		IL_0086:
		ex10 = ex;
		string message4 = Throwable.instancehelper_toString(ex10);
		IOException cause2 = ex10;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(message4, cause2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	private ClassFile setClassFile(ClassFile P_0)
	{
		if (classfile == null)
		{
			classfile = P_0;
		}
		return classfile;
	}

	public override bool isModified()
	{
		return wasChanged;
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 177, 120, 103 })]
	private void removeClassFile()
	{
		if (classfile != null && !isModified() && hasMemberCache() == null)
		{
			classfile = null;
		}
	}

	public override bool isFrozen()
	{
		return wasFrozen;
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 162, 112, 129, 102, 135, 108, 102, 108, 146,
		99
	})]
	private void saveClassFile()
	{
		if (classfile != null && hasMemberCache() == null)
		{
			ByteArrayOutputStream byteArrayOutputStream = new ByteArrayOutputStream();
			DataOutputStream @out = new DataOutputStream(byteArrayOutputStream);
			try
			{
				classfile.write(@out);
				byteArrayOutputStream.close();
				rawClassfile = byteArrayOutputStream.toByteArray();
				classfile = null;
				return;
			}
			catch (IOException)
			{
			}
			_ = null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 82, 104, 113 })]
	protected internal virtual CtMember.Cache hasMemberCache()
	{
		if (memberCache != null)
		{
			return (CtMember.Cache)memberCache.get();
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 165, 239, 104, 159, 27 })]
	private void checkPruned(string P_0)
	{
		if (wasPruned)
		{
			string message = new StringBuilder().append(P_0).append("(): ").append(getName())
				.append(" was pruned.")
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException(message);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(178)]
	public override ClassFile getClassFile2()
	{
		ClassFile classFile = getClassFile3(true);
		_ = null;
		return classFile;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 67, 103, 99, 103, 103, 100, 103, 168 })]
	private void nameReplaced()
	{
		CtMember.Cache cache = hasMemberCache();
		if (cache != null)
		{
			CtMember ctMember = cache.methodHead();
			CtMember ctMember2 = cache.lastMethod();
			while (ctMember != ctMember2)
			{
				ctMember = ctMember.next();
				ctMember.nameReplaced();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.RuntimeException" })]
	[LineNumberTable(new byte[]
	{
		161, 6, 103, 105, 161, 108, 103, 103, 103, 102,
		111
	})]
	public override void setName(string P_0)
	{
		string name = getName();
		if (!java.lang.String.instancehelper_equals(P_0, name))
		{
			classPool.checkNotFrozen(P_0);
			ClassFile classFile = getClassFile2();
			base.setName(P_0);
			classFile.setName(P_0);
			nameReplaced();
			classPool.classNameChanged(name, this);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.RuntimeException" })]
	[LineNumberTable(new byte[] { 160, 215, 104, 127, 1, 104, 155, 172, 103 })]
	internal override void checkModify()
	{
		if (isFrozen())
		{
			string text = new StringBuilder().append(getName()).append(" class is frozen").toString();
			if (wasPruned)
			{
				text = new StringBuilder().append(text).append(" and pruned").toString();
			}
			string message = text;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException(message);
		}
		wasChanged = true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159, 15, 162, 103, 102, 107, 198, 101, 105, 104,
		108, 111, 102, 113, 106, 135, 111, 245, 69, 226,
		61, 97, 223, 7, 225, 69, 104, 159, 21
	})]
	private static void updateInnerEntry(int P_0, string P_1, CtClass P_2, bool P_3)
	{
		ClassFile classFile = P_2.getClassFile2();
		InnerClassesAttribute innerClassesAttribute = (InnerClassesAttribute)classFile.getAttribute("InnerClasses");
		if (innerClassesAttribute != null)
		{
			int num = P_0 & -9;
			int num2 = innerClassesAttribute.find(P_1);
			if (num2 >= 0)
			{
				int num3 = innerClassesAttribute.accessFlags(num2) & 8;
				if (num3 != 0 || !Modifier.isStatic(P_0))
				{
					P_2.checkModify();
					innerClassesAttribute.setAccessFlags(num2, AccessFlag.of(num) | num3);
					string text = innerClassesAttribute.outerClass(num2);
					if (text != null && P_3)
					{
						try
						{
							CtClass ctClass = P_2.getClassPool().get(text);
							updateInnerEntry(num, P_1, ctClass, false);
							return;
						}
						catch (NotFoundException)
						{
						}
						_ = null;
						string message = new StringBuilder().append("cannot find the declaring class: ").append(text).toString();
						Throwable.___003CsuppressFillInStackTrace_003E();
						throw new RuntimeException(message);
					}
					return;
				}
			}
		}
		if (Modifier.isStatic(P_0))
		{
			string message2 = new StringBuilder().append("cannot change ").append(Descriptor.toJavaName(P_1)).append(" into a static class")
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException(message2);
		}
	}

	public override ClassPool getClassPool()
	{
		return classPool;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.ClassNotFoundException" })]
	[LineNumberTable(new byte[]
	{
		162, 157, 103, 151, 97, 145, 151, 129, 115, 98,
		46, 221, 97
	})]
	private static object toAnnoType(Annotation P_0, ClassPool P_1)
	{
		//Discarded unreachable code: IL_0011, IL_003a, IL_0072
		try
		{
			ClassLoader classLoader = P_1.getClassLoader();
			return P_0.toAnnotationType(classLoader, P_1);
		}
		catch (java.lang.ClassNotFoundException)
		{
		}
		_ = null;
		ClassLoader classLoader2 = java.lang.Object.instancehelper_getClass(P_1).getClassLoader(CtClassType.___003CGetCallerID_003E());
		try
		{
			return P_0.toAnnotationType(classLoader2, P_1);
		}
		catch (java.lang.ClassNotFoundException)
		{
		}
		_ = null;
		try
		{
			Class @class = P_1.get(P_0.getTypeName()).toClass();
			return AnnotationImpl.make(@class.getClassLoader(CtClassType.___003CGetCallerID_003E()), @class, P_1, P_0);
		}
		catch (System.Exception x)
		{
			ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.Unused);
		}
		_ = null;
		string typeName = P_0.getTypeName();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new java.lang.ClassNotFoundException(typeName);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.ClassNotFoundException" })]
	[LineNumberTable(new byte[] { 158, 235, 130, 103, 102, 107, 102, 107 })]
	private object[] getAnnotations(bool P_0)
	{
		ClassFile classFile = getClassFile2();
		AnnotationsAttribute annotationsAttribute = (AnnotationsAttribute)classFile.getAttribute("RuntimeInvisibleAnnotations");
		AnnotationsAttribute annotationsAttribute2 = (AnnotationsAttribute)classFile.getAttribute("RuntimeVisibleAnnotations");
		object[] result = toAnnotationType(P_0, getClassPool(), annotationsAttribute, annotationsAttribute2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(443)]
	public override bool isInterface()
	{
		bool result = Modifier.isInterface(getModifiers());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 244, 102, 99, 115 })]
	public override void addInterface(CtClass P_0)
	{
		checkModify();
		if (P_0 != null)
		{
			getClassFile2().addInterface(P_0.getName());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 101, 109, 123, 111 })]
	private void makeFieldCache(CtMember.Cache P_0)
	{
		List fields = getClassFile3(false).getFields();
		Iterator iterator = fields.iterator();
		while (iterator.hasNext())
		{
			FieldInfo fieldInfo = (FieldInfo)iterator.next();
			P_0.addField(new CtField(fieldInfo, this));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 107, 109, 123, 104, 143, 237, 61, 194 })]
	private void makeBehaviorCache(CtMember.Cache P_0)
	{
		List methods = getClassFile3(false).getMethods();
		Iterator iterator = methods.iterator();
		while (iterator.hasNext())
		{
			MethodInfo methodInfo = (MethodInfo)iterator.next();
			if (methodInfo.isMethod())
			{
				P_0.addMethod(new CtMethod(methodInfo, this));
			}
			else
			{
				P_0.addConstructor(new CtConstructor(methodInfo, this));
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/util/List<Ljavassist/CtMember;>;Ljavassist/CtClass;)V")]
	[LineNumberTable(new byte[]
	{
		163, 123, 99, 161, 151, 163, 103, 112, 40, 175,
		131, 109, 105, 105, 102, 105, 110, 139
	})]
	private static void getFields(List P_0, CtClass P_1)
	{
		if (P_1 == null)
		{
			return;
		}
		try
		{
			getFields(P_0, P_1.getSuperclass());
		}
		catch (NotFoundException)
		{
			goto IL_0018;
		}
		goto IL_001e;
		IL_004f:
		CtMember.Cache members = ((CtClassType)P_1).getMembers();
		CtMember ctMember = members.fieldHead();
		CtMember ctMember2 = members.lastField();
		while (ctMember != ctMember2)
		{
			ctMember = ctMember.next();
			if (!Modifier.isPrivate(ctMember.getModifiers()))
			{
				P_0.add(ctMember);
			}
		}
		return;
		IL_0018:
		_ = null;
		goto IL_001e;
		IL_001e:
		try
		{
			CtClass[] interfaces = P_1.getInterfaces();
			CtClass[] array = interfaces;
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				CtClass ctClass = array[i];
				getFields(P_0, ctClass);
			}
		}
		catch (NotFoundException)
		{
			goto IL_0049;
		}
		goto IL_004f;
		IL_0049:
		_ = null;
		goto IL_004f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		163, 169, 105, 99, 162, 103, 115, 107, 100, 230,
		61, 232, 70, 104, 100, 159, 3, 99
	})]
	internal override CtField getField2(string P_0, string P_1)
	{
		//Discarded unreachable code: IL_005e
		CtField declaredField = getDeclaredField2(P_0, P_1);
		if (declaredField != null)
		{
			return declaredField;
		}
		try
		{
			CtClass[] interfaces = getInterfaces();
			CtClass[] array = interfaces;
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				CtClass ctClass = array[i];
				CtField field = ctClass.getField2(P_0, P_1);
				if (field != null)
				{
					return field;
				}
			}
			CtClass superclass = getSuperclass();
			if (superclass != null)
			{
				return superclass.getField2(P_0, P_1);
			}
		}
		catch (NotFoundException)
		{
			goto IL_006f;
		}
		goto IL_0076;
		IL_006f:
		_ = null;
		goto IL_0076;
		IL_0076:
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 163, 157, 102, 123, 99, 159, 2, 159, 17 })]
	private CtField checkGetField(CtField P_0, string P_1, string P_2)
	{
		if (P_0 == null)
		{
			string str = new StringBuilder().append("field: ").append(P_1).toString();
			if (P_2 != null)
			{
				str = new StringBuilder().append(str).append(" type ").append(P_2)
					.toString();
			}
			string msg = new StringBuilder().append(str).append(" in ").append(getName())
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NotFoundException(msg);
		}
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 217, 103, 103, 103, 100, 103, 115, 108, 167 })]
	private CtField getDeclaredField2(string P_0, string P_1)
	{
		CtMember.Cache members = getMembers();
		CtMember ctMember = members.fieldHead();
		CtMember ctMember2 = members.lastField();
		while (ctMember != ctMember2)
		{
			ctMember = ctMember.next();
			if (java.lang.String.instancehelper_equals(ctMember.getName(), P_0) && (P_1 == null || java.lang.String.instancehelper_equals(P_1, ctMember.getSignature())))
			{
				return (CtField)ctMember;
			}
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 163, 212, 105 })]
	public override CtField getDeclaredField(string P_0, string P_1)
	{
		CtField declaredField = getDeclaredField2(P_0, P_1);
		CtField result = checkGetField(declaredField, P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 27, 110, 43 })]
	private static bool isPubCons(CtConstructor P_0)
	{
		return (!Modifier.isPrivate(P_0.getModifiers()) && P_0.isConstructor()) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/util/Map<Ljava/lang/String;Ljavassist/CtMember;>;Ljavassist/CtClass;)V")]
	[LineNumberTable(new byte[]
	{
		164, 103, 103, 112, 40, 175, 163, 104, 100, 147,
		131, 104, 109, 105, 137, 102, 105, 110, 183
	})]
	private static void getMethods0(Map P_0, CtClass P_1)
	{
		try
		{
			CtClass[] interfaces = P_1.getInterfaces();
			CtClass[] array = interfaces;
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				CtClass ctClass = array[i];
				getMethods0(P_0, ctClass);
			}
		}
		catch (NotFoundException)
		{
			goto IL_002b;
		}
		goto IL_0031;
		IL_002b:
		_ = null;
		goto IL_0031;
		IL_0031:
		try
		{
			CtClass superclass = P_1.getSuperclass();
			if (superclass != null)
			{
				getMethods0(P_0, superclass);
			}
		}
		catch (NotFoundException)
		{
			goto IL_004d;
		}
		goto IL_0053;
		IL_004d:
		_ = null;
		goto IL_0053;
		IL_0053:
		if (!(P_1 is CtClassType))
		{
			return;
		}
		CtMember.Cache members = ((CtClassType)P_1).getMembers();
		CtMember ctMember = members.methodHead();
		CtMember ctMember2 = members.lastMethod();
		while (ctMember != ctMember2)
		{
			ctMember = ctMember.next();
			if (!Modifier.isPrivate(ctMember.getModifiers()))
			{
				P_0.put(((CtMethod)ctMember).getStringRep(), ctMember);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		164, 142, 107, 108, 103, 135, 100, 103, 116, 114,
		231, 69, 103, 99, 106, 100, 184, 163, 104, 121,
		107, 100, 230, 61, 244, 70, 99
	})]
	private static CtMethod getMethod0(CtClass P_0, string P_1, string P_2)
	{
		//Discarded unreachable code: IL_007b
		if (P_0 is CtClassType)
		{
			CtMember.Cache members = ((CtClassType)P_0).getMembers();
			CtMember ctMember = members.methodHead();
			CtMember ctMember2 = members.lastMethod();
			while (ctMember != ctMember2)
			{
				ctMember = ctMember.next();
				if (java.lang.String.instancehelper_equals(ctMember.getName(), P_1) && java.lang.String.instancehelper_equals(((CtMethod)ctMember).getMethodInfo2().getDescriptor(), P_2))
				{
					return (CtMethod)ctMember;
				}
			}
		}
		try
		{
			CtClass superclass = P_0.getSuperclass();
			if (superclass != null)
			{
				CtMethod method = getMethod0(superclass, P_1, P_2);
				if (method != null)
				{
					return method;
				}
			}
		}
		catch (NotFoundException)
		{
			goto IL_0089;
		}
		goto IL_0090;
		IL_0090:
		try
		{
			CtClass[] interfaces = P_0.getInterfaces();
			CtClass[] array = interfaces;
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				CtClass ctClass = array[i];
				CtMethod method2 = getMethod0(ctClass, P_1, P_2);
				if (method2 != null)
				{
					return method2;
				}
			}
		}
		catch (NotFoundException)
		{
			goto IL_00d7;
		}
		goto IL_00dd;
		IL_0089:
		_ = null;
		goto IL_0090;
		IL_00dd:
		return null;
		IL_00d7:
		_ = null;
		goto IL_00dd;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		164, 252, 102, 105, 144, 99, 136, 102, 108, 103,
		144, 108, 110, 99, 114, 174, 163, 108, 145, 99,
		104, 104, 100, 137, 105, 139, 168
	})]
	public override void addField(CtField P_0, CtField.Initializer P_1)
	{
		checkModify();
		if (P_0.getDeclaringClass() != this)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CannotCompileException("cannot add");
		}
		if (P_1 == null)
		{
			P_1 = P_0.getInit();
		}
		if (P_1 != null)
		{
			P_1.check(P_0.getSignature());
			int modifiers = P_0.getModifiers();
			if (Modifier.isStatic(modifiers) && Modifier.isFinal(modifiers))
			{
				try
				{
					ConstPool constPool = getClassFile2().getConstPool();
					int constantValue = P_1.getConstantValue(constPool, P_0.getType());
					if (constantValue != 0)
					{
						P_0.getFieldInfo2().addAttribute(new ConstantAttribute(constPool, constantValue));
						P_1 = null;
					}
				}
				catch (NotFoundException)
				{
					goto IL_008d;
				}
			}
		}
		goto IL_0093;
		IL_008d:
		_ = null;
		goto IL_0093;
		IL_0093:
		getMembers().addField(P_0);
		getClassFile2().addField(P_0.getFieldInfo2());
		if (P_1 == null)
		{
			return;
		}
		FieldInitLink next = new FieldInitLink(P_0, P_1);
		FieldInitLink next2 = fieldInitializers;
		if (next2 == null)
		{
			fieldInitializers = next;
			return;
		}
		while (next2.next != null)
		{
			next2 = next2.next;
		}
		next2.next = next;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		164, 80, 103, 103, 135, 100, 103, 103, 104, 98,
		130
	})]
	public override CtConstructor getClassInitializer()
	{
		CtMember.Cache members = getMembers();
		CtMember ctMember = members.consHead();
		CtMember ctMember2 = members.lastCons();
		while (ctMember != ctMember2)
		{
			ctMember = ctMember.next();
			CtConstructor ctConstructor = (CtConstructor)ctMember;
			if (ctConstructor.isClassInitializer())
			{
				return ctConstructor;
			}
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		166, 25, 103, 102, 107, 103, 104, 118, 103, 108,
		103, 103, 99, 109, 133, 103, 99, 176, 103, 110,
		110, 104, 101, 135, 104, 102, 220, 2, 98, 237,
		69, 223, 2, 2, 98, 141
	})]
	private void modifyClassConstructor(ClassFile P_0, Bytecode P_1, int P_2, int P_3)
	{
		MethodInfo methodInfo = P_0.getStaticInitializer();
		BadBytecode badBytecode;
		if (methodInfo == null)
		{
			P_1.add(177);
			P_1.setMaxStack(P_2);
			P_1.setMaxLocals(P_3);
			methodInfo = new MethodInfo(P_0.getConstPool(), "<clinit>", "()V");
			methodInfo.setAccessFlags(8);
			methodInfo.setCodeAttribute(P_1.toCodeAttribute());
			P_0.addMethod(methodInfo);
			hasMemberCache()?.addConstructor(new CtConstructor(methodInfo, this));
		}
		else
		{
			CodeAttribute codeAttribute = methodInfo.getCodeAttribute();
			if (codeAttribute == null)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new CannotCompileException("empty <clinit>");
			}
			try
			{
				CodeIterator codeIterator = codeAttribute.iterator();
				int offset = codeIterator.insertEx(P_1.get());
				codeIterator.insert(P_1.getExceptionTable(), offset);
				int maxStack = codeAttribute.getMaxStack();
				if (maxStack < P_2)
				{
					codeAttribute.setMaxStack(P_2);
				}
				int maxLocals = codeAttribute.getMaxLocals();
				if (maxLocals < P_3)
				{
					codeAttribute.setMaxLocals(P_3);
				}
			}
			catch (BadBytecode x)
			{
				badBytecode = ByteCodeHelper.MapException<BadBytecode>(x, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_00ea;
			}
		}
		BadBytecode badBytecode2;
		try
		{
			methodInfo.rebuildStackMapIf6(classPool, P_0);
			return;
		}
		catch (BadBytecode x2)
		{
			badBytecode2 = ByteCodeHelper.MapException<BadBytecode>(x2, ByteCodeHelper.MapFlags.NoRemapping);
		}
		BadBytecode e = badBytecode2;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
		IL_00ea:
		BadBytecode e2 = badBytecode;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 134, 102, 110, 103, 113 })]
	public override void setModifiers(int P_0)
	{
		checkModify();
		updateInnerEntry(P_0, getName(), this, true);
		ClassFile classFile = getClassFile2();
		classFile.setAccessFlags(AccessFlag.of(P_0 & -9));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException", "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		165,
		byte.MaxValue,
		104,
		129,
		115,
		104,
		98,
		98,
		108,
		105,
		110,
		98,
		158,
		101,
		227,
		57,
		235,
		75,
		99,
		108
	})]
	private void modifyClassConstructor(ClassFile P_0)
	{
		if (fieldInitializers == null)
		{
			return;
		}
		Bytecode.___003Cclinit_003E();
		Bytecode bytecode = new Bytecode(P_0.getConstPool(), 0, 0);
		Javac javac = new Javac(bytecode, this);
		int num = 0;
		int num2 = 0;
		for (FieldInitLink next = fieldInitializers; next != null; next = next.next)
		{
			CtField field = next.field;
			if (Modifier.isStatic(field.getModifiers()))
			{
				num2 = 1;
				int num3 = next.init.compileIfStatic(field.getType(), field.getName(), bytecode, javac);
				if (num < num3)
				{
					num = num3;
				}
			}
		}
		if (num2 != 0)
		{
			modifyClassConstructor(P_0, bytecode, num, 0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException", "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		166, 71, 104, 129, 103, 103, 126, 107, 104, 135,
		105, 108, 129, 43, 167, 108, 107, 223, 2, 2,
		98, 173, 101
	})]
	private void modifyConstructors(ClassFile P_0)
	{
		if (fieldInitializers == null)
		{
			return;
		}
		ConstPool constPool = P_0.getConstPool();
		List methods = P_0.getMethods();
		Iterator iterator = methods.iterator();
		while (iterator.hasNext())
		{
			MethodInfo methodInfo = (MethodInfo)iterator.next();
			if (!methodInfo.isConstructor())
			{
				continue;
			}
			CodeAttribute codeAttribute = methodInfo.getCodeAttribute();
			BadBytecode badBytecode;
			if (codeAttribute != null)
			{
				try
				{
					Bytecode.___003Cclinit_003E();
					Bytecode bytecode = new Bytecode(constPool, 0, codeAttribute.getMaxLocals());
					CtClass[] parameterTypes = Descriptor.getParameterTypes(methodInfo.getDescriptor(), classPool);
					int num = makeFieldInitializer(bytecode, parameterTypes);
					insertAuxInitializer(codeAttribute, bytecode, num);
					methodInfo.rebuildStackMapIf6(classPool, P_0);
				}
				catch (BadBytecode x)
				{
					badBytecode = ByteCodeHelper.MapException<BadBytecode>(x, ByteCodeHelper.MapFlags.NoRemapping);
					goto IL_00ab;
				}
			}
			continue;
			IL_00ab:
			BadBytecode e = badBytecode;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CannotCompileException(e);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 165, 226, 140, 171, 102, 35, 98, 98 })]
	private void dumpClassFile(ClassFile P_0)
	{
		DataOutputStream dataOutputStream = makeFileOutput(CtClass.debugDump);
		try
		{
			P_0.write(dataOutputStream);
		}
		finally
		{
			dataOutputStream.close();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException", "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		166, 123, 98, 136, 219, 2, 97, 172, 108, 105,
		110, 159, 0, 101, 227, 58, 235, 74
	})]
	private int makeFieldInitializer(Bytecode P_0, CtClass[] P_1)
	{
		int num = 0;
		Javac javac = new Javac(P_0, this);
		CompileError compileError;
		try
		{
			javac.recordParams(P_1, isStatic: false);
		}
		catch (CompileError x)
		{
			compileError = ByteCodeHelper.MapException<CompileError>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0022;
		}
		for (FieldInitLink next = fieldInitializers; next != null; next = next.next)
		{
			CtField field = next.field;
			if (!Modifier.isStatic(field.getModifiers()))
			{
				int num2 = next.init.compile(field.getType(), field.getName(), P_0, P_1, javac);
				if (num < num2)
				{
					num = num2;
				}
			}
		}
		return num;
		IL_0022:
		CompileError e = compileError;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		166, 103, 103, 103, 100, 103, 100, 225, 69, 109,
		109, 103, 100, 105
	})]
	private static void insertAuxInitializer(CodeAttribute P_0, Bytecode P_1, int P_2)
	{
		CodeIterator codeIterator = P_0.iterator();
		int num = codeIterator.skipSuperConstructor();
		if (num < 0)
		{
			num = codeIterator.skipThisConstructor();
			if (num >= 0)
			{
				return;
			}
		}
		int offset = codeIterator.insertEx(P_1.get());
		codeIterator.insert(P_1.getExceptionTable(), offset);
		int maxStack = P_0.getMaxStack();
		if (maxStack < P_2)
		{
			P_0.setMaxStack(P_2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/util/Map<Ljava/lang/Object;Ljavassist/CtClassType;>;)V")]
	[LineNumberTable(new byte[]
	{
		166, 188, 103, 147, 103, 115, 109, 13, 209, 163,
		104, 109, 152, 131, 109, 127, 1, 145, 109, 127,
		1, 113
	})]
	private void makeMemberList(Map P_0)
	{
		int modifiers = getModifiers();
		if (Modifier.isAbstract(modifiers) || Modifier.isInterface(modifiers))
		{
			try
			{
				CtClass[] interfaces = getInterfaces();
				CtClass[] array = interfaces;
				int num = array.Length;
				for (int i = 0; i < num; i++)
				{
					CtClass ctClass = array[i];
					if (ctClass != null && ctClass is CtClassType)
					{
						((CtClassType)ctClass).makeMemberList(P_0);
					}
				}
			}
			catch (NotFoundException)
			{
				goto IL_005c;
			}
		}
		goto IL_0062;
		IL_0092:
		List methods = getClassFile2().getMethods();
		Iterator iterator = methods.iterator();
		while (iterator.hasNext())
		{
			MethodInfo methodInfo = (MethodInfo)iterator.next();
			P_0.put(methodInfo.getName(), this);
		}
		List fields = getClassFile2().getFields();
		Iterator iterator2 = fields.iterator();
		while (iterator2.hasNext())
		{
			FieldInfo fieldInfo = (FieldInfo)iterator2.next();
			P_0.put(fieldInfo.getName(), this);
		}
		return;
		IL_008c:
		_ = null;
		goto IL_0092;
		IL_005c:
		_ = null;
		goto IL_0062;
		IL_0062:
		try
		{
			CtClass superclass = getSuperclass();
			if (superclass != null && superclass is CtClassType)
			{
				((CtClassType)superclass).makeMemberList(P_0);
			}
		}
		catch (NotFoundException)
		{
			goto IL_008c;
		}
		goto IL_0092;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 166, 179, 99, 102, 107, 2, 198 })]
	private static bool notFindInArray(string P_0, string[] P_1)
	{
		int num = P_1.Length;
		for (int i = 0; i < num; i++)
		{
			if (java.lang.String.instancehelper_startsWith(P_1[i], P_0))
			{
				return false;
			}
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		60,
		104,
		140,
		104,
		140,
		104,
		140,
		114,
		108,
		173,
		103,
		99,
		103,
		109,
		byte.MaxValue,
		3,
		69,
		2,
		97,
		204,
		103,
		101,
		140,
		103,
		111,
		12,
		239,
		71,
		2,
		97,
		172,
		104,
		105,
		44,
		133,
		105,
		44,
		133,
		105,
		44,
		133
	})]
	protected internal override void extendToString(StringBuilder P_0)
	{
		if (wasChanged)
		{
			P_0.append("changed ");
		}
		if (wasFrozen)
		{
			P_0.append("frozen ");
		}
		if (wasPruned)
		{
			P_0.append("pruned ");
		}
		P_0.append(Modifier.toString(getModifiers()));
		P_0.append(" class ");
		P_0.append(getName());
		try
		{
			CtClass superclass = getSuperclass();
			if (superclass != null)
			{
				string name = superclass.getName();
				if (!java.lang.String.instancehelper_equals(name, "java.lang.Object"))
				{
					P_0.append(" extends ").append(superclass.getName());
				}
			}
		}
		catch (NotFoundException)
		{
			goto IL_00a4;
		}
		goto IL_00b6;
		IL_00fc:
		_ = null;
		P_0.append(" extends ??");
		goto IL_010e;
		IL_010e:
		CtMember.Cache members = getMembers();
		exToString(P_0, " fields=", members.fieldHead(), members.lastField());
		exToString(P_0, " constructors=", members.consHead(), members.lastCons());
		exToString(P_0, " methods=", members.methodHead(), members.lastMethod());
		return;
		IL_00b6:
		try
		{
			CtClass[] interfaces = getInterfaces();
			if ((nint)interfaces.LongLength > 0)
			{
				P_0.append(" implements ");
			}
			for (int i = 0; i < (nint)interfaces.LongLength; i++)
			{
				P_0.append(interfaces[i].getName());
				P_0.append(", ");
			}
		}
		catch (NotFoundException)
		{
			goto IL_00fc;
		}
		goto IL_010e;
		IL_00a4:
		_ = null;
		P_0.append(" extends ??");
		goto IL_00b6;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 120, 104, 140 })]
	public override AccessorMaker getAccessorMaker()
	{
		if (accessors == null)
		{
			accessors = new AccessorMaker(this);
		}
		return accessors;
	}

	[LineNumberTable(251)]
	internal sealed override void incGetCounter()
	{
		getCount++;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 146, 105, 111, 104, 112, 134, 103 })]
	internal override void compress()
	{
		if (getCount < 2)
		{
			if (!isModified() && ClassPool.releaseUnmodifiedClassFile)
			{
				removeClassFile();
			}
			else if (isFrozen() && !wasPruned)
			{
				saveClassFile();
			}
		}
		getCount = 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 160, 198, 114, 99, 113 })]
	public override URL getURL()
	{
		URL uRL = classPool.find(getName());
		if (uRL == null)
		{
			string name = getName();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NotFoundException(name);
		}
		return uRL;
	}

	public override void freeze()
	{
		wasFrozen = true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 228, 107, 103 })]
	public override void defrost()
	{
		checkPruned("defrost");
		wasFrozen = false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		160, 235, 103, 114, 130, 103, 103, 108, 130, 103,
		100, 105, 108, 2, 200, 119, 130, 105, 119, 2,
		200
	})]
	public override bool subtypeOf(CtClass P_0)
	{
		string name = P_0.getName();
		if (this == P_0 || java.lang.String.instancehelper_equals(getName(), name))
		{
			return true;
		}
		ClassFile classFile = getClassFile2();
		string superclass = classFile.getSuperclass();
		if (superclass != null && java.lang.String.instancehelper_equals(superclass, name))
		{
			return true;
		}
		string[] interfaces = classFile.getInterfaces();
		int num = interfaces.Length;
		for (int i = 0; i < num; i++)
		{
			if (java.lang.String.instancehelper_equals(interfaces[i], name))
			{
				return true;
			}
		}
		if (superclass != null && classPool.get(superclass).subtypeOf(P_0))
		{
			return true;
		}
		for (int i = 0; i < num; i++)
		{
			if (classPool.get(interfaces[i]).subtypeOf(P_0))
			{
				return true;
			}
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 21, 97, 117 })]
	public override string getGenericSignature()
	{
		string result = ((javassist.bytecode.SignatureAttribute)getClassFile2().getAttribute("Signature"))?.getSignature();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 28, 103, 109, 105 })]
	public override void setGenericSignature(string P_0)
	{
		ClassFile classFile = getClassFile();
		javassist.bytecode.SignatureAttribute info = new javassist.bytecode.SignatureAttribute(classFile.getConstPool(), P_0);
		classFile.addAttribute(info);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.RuntimeException" })]
	[LineNumberTable(new byte[]
	{
		161, 37, 103, 98, 107, 99, 135, 172, 103, 103,
		103, 134, 99, 103, 143
	})]
	public override void replaceClassName(ClassMap P_0)
	{
		string name = getName();
		string text = P_0.get(Descriptor.toJvmName(name));
		if (text != null)
		{
			text = Descriptor.toJavaName(text);
			classPool.checkNotFrozen(text);
		}
		base.replaceClassName(P_0);
		ClassFile classFile = getClassFile2();
		classFile.renameClass(P_0);
		nameReplaced();
		if (text != null)
		{
			base.setName(text);
			classPool.classNameChanged(name, this);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.RuntimeException" })]
	[LineNumberTable(new byte[] { 161, 61, 103, 105, 137, 104, 109, 136 })]
	public override void replaceClassName(string P_0, string P_1)
	{
		string name = getName();
		if (java.lang.String.instancehelper_equals(name, P_0))
		{
			setName(P_1);
			return;
		}
		base.replaceClassName(P_0, P_1);
		getClassFile2().renameClass(P_0, P_1);
		nameReplaced();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(448)]
	public override bool isAnnotation()
	{
		bool result = Modifier.isAnnotation(getModifiers());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(453)]
	public override bool isEnum()
	{
		bool result = Modifier.isEnum(getModifiers());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		161, 110, 103, 102, 107, 99, 135, 127, 1, 103,
		104, 104, 106, 100, 138, 113, 245, 58, 232, 74
	})]
	public override CtClass[] getNestedClasses()
	{
		ClassFile classFile = getClassFile2();
		InnerClassesAttribute innerClassesAttribute = (InnerClassesAttribute)classFile.getAttribute("InnerClasses");
		if (innerClassesAttribute == null)
		{
			return new CtClass[0];
		}
		string text = new StringBuilder().append(classFile.getName()).append("$").toString();
		int num = innerClassesAttribute.tableLength();
		ArrayList arrayList = new ArrayList(num);
		for (int i = 0; i < num; i++)
		{
			string text2 = innerClassesAttribute.innerClass(i);
			if (text2 != null && java.lang.String.instancehelper_startsWith(text2, text) && java.lang.String.instancehelper_lastIndexOf(text2, 36) < java.lang.String.instancehelper_length(text))
			{
				((List)arrayList).add((object)classPool.get(text2));
			}
		}
		return (CtClass[])((List)arrayList).toArray((object[])new CtClass[((List)arrayList).size()]);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 178, 103, 102, 107, 102, 107 })]
	public override bool hasAnnotation(string P_0)
	{
		ClassFile classFile = getClassFile2();
		AnnotationsAttribute annotationsAttribute = (AnnotationsAttribute)classFile.getAttribute("RuntimeInvisibleAnnotations");
		AnnotationsAttribute annotationsAttribute2 = (AnnotationsAttribute)classFile.getAttribute("RuntimeVisibleAnnotations");
		bool result = hasAnnotationType(P_0, getClassPool(), annotationsAttribute, annotationsAttribute2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[IKVM.Attributes.Signature("(Ljava/lang/Class<*>;Ljavassist/ClassPool;Ljavassist/bytecode/AnnotationsAttribute;Ljavassist/bytecode/AnnotationsAttribute;)Z")]
	[LineNumberTable(564)]
	[java.lang.Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	internal static bool hasAnnotationType(Class P_0, ClassPool P_1, AnnotationsAttribute P_2, AnnotationsAttribute P_3)
	{
		bool result = hasAnnotationType(P_0.getName(), P_1, P_2, P_3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.ClassNotFoundException" })]
	[IKVM.Attributes.Signature("(Ljava/lang/Class<*>;)Ljava/lang/Object;")]
	[LineNumberTable(new byte[] { 161, 228, 103, 102, 107, 102, 107 })]
	public override object getAnnotation(Class P_0)
	{
		ClassFile classFile = getClassFile2();
		AnnotationsAttribute annotationsAttribute = (AnnotationsAttribute)classFile.getAttribute("RuntimeInvisibleAnnotations");
		AnnotationsAttribute annotationsAttribute2 = (AnnotationsAttribute)classFile.getAttribute("RuntimeVisibleAnnotations");
		object annotationType = getAnnotationType(P_0, getClassPool(), annotationsAttribute, annotationsAttribute2);
		_ = null;
		return annotationType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.ClassNotFoundException" })]
	[LineNumberTable(638)]
	public override object[] getAnnotations()
	{
		object[] annotations = getAnnotations(false);
		_ = null;
		return annotations;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 18, 157, 97 })]
	public override object[] getAvailableAnnotations()
	{
		//Discarded unreachable code: IL_0009
		java.lang.ClassNotFoundException ex;
		try
		{
			return getAnnotations(true);
		}
		catch (java.lang.ClassNotFoundException x)
		{
			ex = ByteCodeHelper.MapException<java.lang.ClassNotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		java.lang.ClassNotFoundException cause = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException("Unexpected exception ", cause);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		162, 181, 99, 130, 103, 130, 99, 110, 132, 190,
		99
	})]
	public override bool subclassOf(CtClass P_0)
	{
		if (P_0 == null)
		{
			return false;
		}
		string name = P_0.getName();
		CtClass ctClass = this;
		try
		{
			while (ctClass != null)
			{
				if (java.lang.String.instancehelper_equals(ctClass.getName(), name))
				{
					return true;
				}
				ctClass = ctClass.getSuperclass();
			}
		}
		catch (System.Exception x)
		{
			if (ByteCodeHelper.MapException<java.lang.Exception>(x, ByteCodeHelper.MapFlags.Unused) == null)
			{
				throw;
			}
			goto IL_003e;
		}
		goto IL_0044;
		IL_003e:
		_ = null;
		goto IL_0044;
		IL_0044:
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 162, 208, 102, 104, 137, 115 })]
	public override void setSuperclass(CtClass P_0)
	{
		checkModify();
		if (isInterface())
		{
			addInterface(P_0);
		}
		else
		{
			getClassFile2().setSuperclass(P_0.getName());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		162, 228, 134, 99, 137, 99, 103, 102, 43, 198,
		110
	})]
	public override void setInterfaces(CtClass[] P_0)
	{
		checkModify();
		string[] array;
		if (P_0 == null)
		{
			array = new string[0];
		}
		else
		{
			int num = P_0.Length;
			array = new string[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = P_0[i].getName();
			}
		}
		getClassFile2().setInterfaces(array);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		162, 251, 103, 145, 99, 130, 103, 103, 107, 112,
		106, 100, 176, 102, 140, 100, 245, 53, 235, 79
	})]
	public override CtClass getDeclaringClass()
	{
		ClassFile classFile = getClassFile2();
		InnerClassesAttribute innerClassesAttribute = (InnerClassesAttribute)classFile.getAttribute("InnerClasses");
		if (innerClassesAttribute == null)
		{
			return null;
		}
		string name = getName();
		int num = innerClassesAttribute.tableLength();
		for (int i = 0; i < num; i++)
		{
			if (java.lang.String.instancehelper_equals(name, innerClassesAttribute.innerClass(i)))
			{
				string text = innerClassesAttribute.outerClass(i);
				if (text != null)
				{
					CtClass result = classPool.get(text);
					_ = null;
					return result;
				}
				javassist.bytecode.EnclosingMethodAttribute enclosingMethodAttribute = (javassist.bytecode.EnclosingMethodAttribute)classFile.getAttribute("EnclosingMethod");
				if (enclosingMethodAttribute != null)
				{
					CtClass result2 = classPool.get(enclosingMethodAttribute.className());
					_ = null;
					return result2;
				}
			}
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		163, 24, 103, 102, 139, 99, 98, 114, 103, 109,
		111, 109, 137
	})]
	public override CtBehavior getEnclosingBehavior()
	{
		ClassFile classFile = getClassFile2();
		javassist.bytecode.EnclosingMethodAttribute enclosingMethodAttribute = (javassist.bytecode.EnclosingMethodAttribute)classFile.getAttribute("EnclosingMethod");
		if (enclosingMethodAttribute == null)
		{
			return null;
		}
		CtClass ctClass = classPool.get(enclosingMethodAttribute.className());
		string text = enclosingMethodAttribute.methodName();
		if (java.lang.String.instancehelper_equals("<init>", text))
		{
			CtConstructor constructor = ctClass.getConstructor(enclosingMethodAttribute.methodDescriptor());
			_ = null;
			return constructor;
		}
		if (java.lang.String.instancehelper_equals("<clinit>", text))
		{
			CtConstructor classInitializer = ctClass.getClassInitializer();
			_ = null;
			return classInitializer;
		}
		CtMethod method = ctClass.getMethod(text, enclosingMethodAttribute.methodDescriptor());
		_ = null;
		return method;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		158, 167, 98, 99, 176, 102, 127, 18, 103, 103,
		146, 100, 109, 168, 112, 42, 133, 116
	})]
	public override CtClass makeNestedClass(string P_0, bool P_1)
	{
		if (!P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException("sorry, only nested static class is supported");
		}
		checkModify();
		CtClass ctClass = classPool.makeNestedClass(new StringBuilder().append(getName()).append("$").append(P_0)
			.toString());
		ClassFile classFile = getClassFile2();
		ClassFile classFile2 = ctClass.getClassFile2();
		InnerClassesAttribute innerClassesAttribute = (InnerClassesAttribute)classFile.getAttribute("InnerClasses");
		if (innerClassesAttribute == null)
		{
			innerClassesAttribute = new InnerClassesAttribute(classFile.getConstPool());
			classFile.addAttribute(innerClassesAttribute);
		}
		innerClassesAttribute.append(ctClass.getName(), getName(), P_0, (classFile2.getAccessFlags() & -33) | 8);
		classFile2.addAttribute(innerClassesAttribute.copy(classFile2.getConstPool(), null));
		return ctClass;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 117, 102, 103 })]
	public override CtField[] getFields()
	{
		ArrayList arrayList = new ArrayList();
		getFields(arrayList, this);
		return (CtField[])((List)arrayList).toArray((object[])new CtField[((List)arrayList).size()]);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 163, 150, 105 })]
	public override CtField getField(string P_0, string P_1)
	{
		CtField field = getField2(P_0, P_1);
		CtField result = checkGetField(field, P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		163, 191, 103, 103, 103, 104, 104, 99, 100, 103,
		179
	})]
	public override CtField[] getDeclaredFields()
	{
		CtMember.Cache members = getMembers();
		CtMember ctMember = members.fieldHead();
		CtMember ctMember2 = members.lastField();
		int num = CtMember.Cache.count(ctMember, ctMember2);
		CtField[] array = new CtField[num];
		int num2 = 0;
		while (ctMember != ctMember2)
		{
			ctMember = ctMember.next();
			int num3 = num2;
			num2++;
			array[num3] = (CtField)ctMember;
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(1089)]
	public override CtField getDeclaredField(string P_0)
	{
		CtField declaredField = getDeclaredField(P_0, null);
		_ = null;
		return declaredField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		163, 232, 103, 103, 103, 104, 104, 104, 139, 107,
		99, 100, 103, 179, 102, 105, 180
	})]
	public override CtBehavior[] getDeclaredBehaviors()
	{
		CtMember.Cache members = getMembers();
		CtMember ctMember = members.consHead();
		CtMember ctMember2 = members.lastCons();
		int num = CtMember.Cache.count(ctMember, ctMember2);
		CtMember ctMember3 = members.methodHead();
		CtMember ctMember4 = members.lastMethod();
		int num2 = CtMember.Cache.count(ctMember3, ctMember4);
		CtBehavior[] array = new CtBehavior[num + num2];
		int num3 = 0;
		while (ctMember != ctMember2)
		{
			ctMember = ctMember.next();
			int num4 = num3;
			num3++;
			array[num4] = (CtBehavior)ctMember;
		}
		while (ctMember3 != ctMember4)
		{
			ctMember3 = ctMember3.next();
			int num5 = num3;
			num3++;
			array[num5] = (CtBehavior)ctMember3;
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		164, 1, 103, 103, 135, 98, 99, 101, 105, 110,
		166, 104, 99, 99, 101, 105, 105, 105, 109, 130
	})]
	public override CtConstructor[] getConstructors()
	{
		CtMember.Cache members = getMembers();
		CtMember ctMember = members.consHead();
		CtMember ctMember2 = members.lastCons();
		int num = 0;
		CtMember ctMember3 = ctMember;
		while (ctMember3 != ctMember2)
		{
			ctMember3 = ctMember3.next();
			if (isPubCons((CtConstructor)ctMember3))
			{
				num++;
			}
		}
		CtConstructor[] array = new CtConstructor[num];
		int num2 = 0;
		ctMember3 = ctMember;
		while (ctMember3 != ctMember2)
		{
			ctMember3 = ctMember3.next();
			CtConstructor ctConstructor = (CtConstructor)ctMember3;
			if (isPubCons(ctConstructor))
			{
				int num3 = num2;
				num2++;
				array[num3] = ctConstructor;
			}
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		164, 35, 103, 103, 135, 100, 103, 103, 116, 103,
		98, 130
	})]
	public override CtConstructor getConstructor(string P_0)
	{
		CtMember.Cache members = getMembers();
		CtMember ctMember = members.consHead();
		CtMember ctMember2 = members.lastCons();
		while (ctMember != ctMember2)
		{
			ctMember = ctMember.next();
			CtConstructor ctConstructor = (CtConstructor)ctMember;
			if (java.lang.String.instancehelper_equals(ctConstructor.getMethodInfo2().getDescriptor(), P_0) && ctConstructor.isConstructor())
			{
				return ctConstructor;
			}
		}
		CtConstructor constructor = base.getConstructor(P_0);
		_ = null;
		return constructor;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		164, 52, 103, 103, 135, 98, 99, 101, 105, 105,
		105, 100, 130, 104, 99, 99, 101, 105, 105, 105,
		109, 130
	})]
	public override CtConstructor[] getDeclaredConstructors()
	{
		CtMember.Cache members = getMembers();
		CtMember ctMember = members.consHead();
		CtMember ctMember2 = members.lastCons();
		int num = 0;
		CtMember ctMember3 = ctMember;
		while (ctMember3 != ctMember2)
		{
			ctMember3 = ctMember3.next();
			CtConstructor ctConstructor = (CtConstructor)ctMember3;
			if (ctConstructor.isConstructor())
			{
				num++;
			}
		}
		CtConstructor[] array = new CtConstructor[num];
		int num2 = 0;
		ctMember3 = ctMember;
		while (ctMember3 != ctMember2)
		{
			ctMember3 = ctMember3.next();
			CtConstructor ctConstructor2 = (CtConstructor)ctMember3;
			if (ctConstructor2.isConstructor())
			{
				int num3 = num2;
				num2++;
				array[num3] = ctConstructor2;
			}
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 96, 102, 103 })]
	public override CtMethod[] getMethods()
	{
		HashMap hashMap = new HashMap();
		getMethods0(hashMap, this);
		return (CtMethod[])((Map)hashMap).values().toArray(new CtMethod[((Map)hashMap).size()]);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 164, 133, 105, 99, 98, 118 })]
	public override CtMethod getMethod(string P_0, string P_1)
	{
		CtMethod method = getMethod0(this, P_0, P_1);
		if (method != null)
		{
			return method;
		}
		string msg = new StringBuilder().append(P_0).append("(..) is not found in ").append(getName())
			.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new NotFoundException(msg);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 179, 103, 103, 103, 102, 100, 103, 170 })]
	public override CtMethod[] getDeclaredMethods()
	{
		CtMember.Cache members = getMembers();
		CtMember ctMember = members.methodHead();
		CtMember ctMember2 = members.lastMethod();
		ArrayList arrayList = new ArrayList();
		while (ctMember != ctMember2)
		{
			ctMember = ctMember.next();
			((List)arrayList).add((object)ctMember);
		}
		return (CtMethod[])((List)arrayList).toArray((object[])new CtMethod[((List)arrayList).size()]);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 164, 193, 103, 103, 103, 102, 100, 103, 110, 170 })]
	public override CtMethod[] getDeclaredMethods(string P_0)
	{
		CtMember.Cache members = getMembers();
		CtMember ctMember = members.methodHead();
		CtMember ctMember2 = members.lastMethod();
		ArrayList arrayList = new ArrayList();
		while (ctMember != ctMember2)
		{
			ctMember = ctMember.next();
			if (java.lang.String.instancehelper_equals(ctMember.getName(), P_0))
			{
				((List)arrayList).add((object)ctMember);
			}
		}
		return (CtMethod[])((List)arrayList).toArray((object[])new CtMethod[((List)arrayList).size()]);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 164, 208, 103, 103, 103, 100, 103, 110, 167, 118 })]
	public override CtMethod getDeclaredMethod(string P_0)
	{
		CtMember.Cache members = getMembers();
		CtMember ctMember = members.methodHead();
		CtMember ctMember2 = members.lastMethod();
		while (ctMember != ctMember2)
		{
			ctMember = ctMember.next();
			if (java.lang.String.instancehelper_equals(ctMember.getName(), P_0))
			{
				return (CtMethod)ctMember;
			}
		}
		string msg = new StringBuilder().append(P_0).append("(..) is not found in ").append(getName())
			.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new NotFoundException(msg);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		164, 225, 103, 103, 103, 135, 100, 103, 116, 114,
		167, 118
	})]
	public override CtMethod getDeclaredMethod(string P_0, CtClass[] P_1)
	{
		string prefix = Descriptor.ofParameters(P_1);
		CtMember.Cache members = getMembers();
		CtMember ctMember = members.methodHead();
		CtMember ctMember2 = members.lastMethod();
		while (ctMember != ctMember2)
		{
			ctMember = ctMember.next();
			if (java.lang.String.instancehelper_equals(ctMember.getName(), P_0) && java.lang.String.instancehelper_startsWith(((CtMethod)ctMember).getMethodInfo2().getDescriptor(), prefix))
			{
				return (CtMethod)ctMember;
			}
		}
		string msg = new StringBuilder().append(P_0).append("(..) is not found in ").append(getName())
			.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new NotFoundException(msg);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 164, 245, 111 })]
	public override void addField(CtField P_0, string P_1)
	{
		addField(P_0, CtField.Initializer.byExpr(P_1));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 165, 37, 102, 103, 103, 110, 108, 169, 113 })]
	public override void removeField(CtField P_0)
	{
		checkModify();
		FieldInfo fieldInfo = P_0.getFieldInfo2();
		ClassFile classFile = getClassFile2();
		if (classFile.getFields().remove(fieldInfo))
		{
			getMembers().remove(P_0);
			gcConstPool = true;
			return;
		}
		string msg = P_0.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new NotFoundException(msg);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 165, 52, 103, 99, 130, 102, 103, 115, 106 })]
	public override CtConstructor makeClassInitializer()
	{
		CtConstructor classInitializer = getClassInitializer();
		if (classInitializer != null)
		{
			return classInitializer;
		}
		checkModify();
		ClassFile classFile = getClassFile2();
		Bytecode.___003Cclinit_003E();
		Bytecode bytecode = new Bytecode(classFile.getConstPool(), 0, 0);
		modifyClassConstructor(classFile, bytecode, 0, 0);
		CtConstructor classInitializer2 = getClassInitializer();
		_ = null;
		return classInitializer2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 165, 67, 102, 105, 144, 108, 115 })]
	public override void addConstructor(CtConstructor P_0)
	{
		checkModify();
		if (P_0.getDeclaringClass() != this)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CannotCompileException("cannot add");
		}
		getMembers().addConstructor(P_0);
		getClassFile2().addMethod(P_0.getMethodInfo2());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 165, 77, 102, 103, 103, 110, 108, 169, 113 })]
	public override void removeConstructor(CtConstructor P_0)
	{
		checkModify();
		MethodInfo methodInfo = P_0.getMethodInfo2();
		ClassFile classFile = getClassFile2();
		if (classFile.getMethods().remove(methodInfo))
		{
			getMembers().remove(P_0);
			gcConstPool = true;
			return;
		}
		string msg = P_0.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new NotFoundException(msg);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		165, 90, 102, 105, 144, 103, 110, 112, 112, 154,
		169, 108, 113, 105, 116
	})]
	public override void addMethod(CtMethod P_0)
	{
		checkModify();
		if (P_0.getDeclaringClass() != this)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CannotCompileException("bad declaring class");
		}
		int modifiers = P_0.getModifiers();
		if (((uint)getModifiers() & 0x200u) != 0)
		{
			if (Modifier.isProtected(modifiers) || Modifier.isPrivate(modifiers))
			{
				string msg = new StringBuilder().append("an interface method must be public: ").append(P_0.toString()).toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new CannotCompileException(msg);
			}
			P_0.setModifiers(modifiers | 1);
		}
		getMembers().addMethod(P_0);
		getClassFile2().addMethod(P_0.getMethodInfo2());
		if (((uint)modifiers & 0x400u) != 0)
		{
			setModifiers(getModifiers() | 0x400);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 165, 112, 102, 103, 103, 110, 108, 169, 113 })]
	public override void removeMethod(CtMethod P_0)
	{
		checkModify();
		MethodInfo methodInfo = P_0.getMethodInfo2();
		ClassFile classFile = getClassFile2();
		if (classFile.getMethods().remove(methodInfo))
		{
			getMembers().remove(P_0);
			gcConstPool = true;
			return;
		}
		string msg = P_0.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new NotFoundException(msg);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 165, 126, 109, 99, 98 })]
	public override byte[] getAttribute(string P_0)
	{
		AttributeInfo attribute = getClassFile2().getAttribute(P_0);
		if (attribute == null)
		{
			return null;
		}
		byte[] result = attribute.get();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 165, 135, 102, 103, 117 })]
	public override void setAttribute(string P_0, byte[] P_1)
	{
		checkModify();
		ClassFile classFile = getClassFile2();
		classFile.addAttribute(new AttributeInfo(classFile.getConstPool(), P_0, P_1));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 165, 144, 102, 103, 103, 103, 127, 11, 42, 136 })]
	public override void instrument(CodeConverter P_0)
	{
		checkModify();
		ClassFile classFile = getClassFile2();
		ConstPool constPool = classFile.getConstPool();
		List methods = classFile.getMethods();
		MethodInfo[] array = (MethodInfo[])methods.toArray(new MethodInfo[methods.size()]);
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			MethodInfo minfo = array[i];
			P_0.doit(this, minfo, constPool);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 165, 156, 102, 103, 103, 127, 9, 42, 136 })]
	public override void instrument(ExprEditor P_0)
	{
		checkModify();
		ClassFile classFile = getClassFile2();
		List methods = classFile.getMethods();
		MethodInfo[] array = (MethodInfo[])methods.toArray(new MethodInfo[methods.size()]);
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			MethodInfo minfo = array[i];
			P_0.doit(this, minfo);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 165, 170, 104, 129, 114, 109 })]
	public override void prune()
	{
		if (!wasPruned)
		{
			int num = 1;
			wasFrozen = (byte)num != 0;
			wasPruned = (byte)num != 0;
			getClassFile2().prune();
		}
	}

	public override void rebuildClassFile()
	{
		gcConstPool = true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException", "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		165,
		185,
		107,
		107,
		103,
		104,
		102,
		167,
		103,
		103,
		103,
		135,
		103,
		102,
		103,
		136,
		102,
		135,
		130,
		242,
		69,
		103,
		byte.MaxValue,
		6,
		71,
		226,
		59,
		97,
		140,
		98,
		141
	})]
	public override void toBytecode(DataOutputStream P_0)
	{
		NotFoundException ex;
		IOException ex2;
		try
		{
			try
			{
				if (isModified())
				{
					checkPruned("toBytecode");
					ClassFile classFile = getClassFile2();
					if (gcConstPool)
					{
						classFile.compact();
						gcConstPool = false;
					}
					modifyClassConstructor(classFile);
					modifyConstructors(classFile);
					if (CtClass.debugDump != null)
					{
						dumpClassFile(classFile);
					}
					classFile.write(P_0);
					P_0.flush();
					fieldInitializers = null;
					if (doPruning)
					{
						classFile.prune();
						wasPruned = true;
					}
				}
				else
				{
					classPool.writeClassfile(getName(), P_0);
				}
				getCount = 0;
				wasFrozen = true;
				return;
			}
			catch (NotFoundException x)
			{
				ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
		}
		catch (IOException x2)
		{
			ex2 = ByteCodeHelper.MapException<IOException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_00b4;
		}
		NotFoundException e = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
		IL_00b4:
		IOException e2 = ex2;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e2);
	}

	public override bool stopPruning(bool P_0)
	{
		int result = ((!doPruning) ? 1 : 0);
		doPruning = ((!P_0) ? true : false);
		return (byte)result != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("()Ljava/util/Map<Ljavassist/CtMethod;Ljava/lang/String;>;")]
	[LineNumberTable(new byte[] { 166, 148, 104, 139 })]
	internal virtual Map getHiddenMethods()
	{
		if (hiddenMethods == null)
		{
			hiddenMethods = new Hashtable();
		}
		return hiddenMethods;
	}

	[LineNumberTable(1804)]
	internal virtual int getUniqueNumber()
	{
		int num = uniqueNumberSeed;
		uniqueNumberSeed = num + 1;
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		166, 158, 102, 103, 103, 108, 136, 105, 130, 163,
		104, 144, 124, 106
	})]
	public override string makeUniqueName(string P_0)
	{
		HashMap hashMap = new HashMap();
		makeMemberList(hashMap);
		Set set = ((Map)hashMap).keySet();
		string[] array = new string[set.size()];
		set.toArray(array);
		if (notFindInArray(P_0, array))
		{
			return P_0;
		}
		int num = 100;
		string text;
		do
		{
			if (num > 999)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new RuntimeException("too many unique name");
			}
			StringBuilder stringBuilder = new StringBuilder().append(P_0);
			int i = num;
			num++;
			text = stringBuilder.append(i).toString();
		}
		while (!notFindInArray(text, array));
		return text;
	}

	static CallerID ___003CGetCallerID_003E()
	{
		if (___003CcallerID_003E == null)
		{
			___003CcallerID_003E = new ___003CCallerID_003E();
		}
		return ___003CcallerID_003E;
	}

	[HideFromJava]
	static CtClassType()
	{
		CtClass.___003Cclinit_003E();
	}
}
