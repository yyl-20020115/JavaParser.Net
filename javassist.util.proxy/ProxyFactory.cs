using System;
using System.Runtime.CompilerServices;
using System.Threading;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.lang.invoke;
using java.lang.@ref;
using java.lang.reflect;
using java.security;
using java.util;
using java.util.function;
using javassist.bytecode;

namespace javassist.util.proxy;

public class ProxyFactory : java.lang.Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[IKVM.Attributes.EnclosingMethod(null, null, null)]
	internal class _1 : java.lang.Object, ClassLoaderProvider
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(758)]
		internal _1()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(761)]
		public virtual ClassLoader get(ProxyFactory P_0)
		{
			ClassLoader classLoader = P_0.getClassLoader0();
			_ = null;
			return classLoader;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[IKVM.Attributes.EnclosingMethod(null, null, null)]
	internal class _2 : java.lang.Object, UniqueName
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private string sep;

		private int counter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 250, 104, 127, 27 })]
		internal _2()
		{
			sep = new StringBuilder().append("_$$_jvst").append(Integer.toHexString(java.lang.Object.instancehelper_hashCode(this) & 0xFFF)).append("_")
				.toString();
			counter = 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(882)]
		public virtual string get(string P_0)
		{
			StringBuilder stringBuilder = new StringBuilder().append(P_0).append(sep);
			int num = counter;
			counter = num + 1;
			string result = stringBuilder.append(Integer.toHexString(num)).toString();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[IKVM.Attributes.Signature("Ljava/lang/Object;Ljava/util/Comparator<Ljava/util/Map$Entry<Ljava/lang/String;Ljava/lang/reflect/Method;>;>;")]
	[IKVM.Attributes.EnclosingMethod(null, null, null)]
	internal class _3 : java.lang.Object, Comparator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(980)]
		internal _3()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IKVM.Attributes.Signature("(Ljava/util/Map$Entry<Ljava/lang/String;Ljava/lang/reflect/Method;>;Ljava/util/Map$Entry<Ljava/lang/String;Ljava/lang/reflect/Method;>;)I")]
		[LineNumberTable(983)]
		public virtual int compare(Map.Entry P_0, Map.Entry P_1)
		{
			int result = java.lang.String.instancehelper_compareTo((string)P_0.getKey(), (string)P_1.getKey());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(980)]
		public virtual int compare(object P_0, object P_1)
		{
			int result = compare((Map.Entry)P_0, (Map.Entry)P_1);
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
			return java.lang.Object.instancehelper_equals(this, P_0);
		}
	}

	public interface ClassLoaderProvider
	{
		virtual ClassLoader get(ProxyFactory pf);
	}

	internal class Find2MethodsArgs : java.lang.Object
	{
		internal string methodName;

		internal string delegatorName;

		internal string descriptor;

		internal int origIndex;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 165, 103, 104, 103, 103, 103, 104 })]
		internal Find2MethodsArgs(string P_0, string P_1, string P_2, int P_3)
		{
			methodName = P_0;
			delegatorName = P_1;
			descriptor = P_2;
			origIndex = P_3;
		}
	}

	internal class ProxyDetails : java.lang.Object
	{
		internal byte[] signature;

		[IKVM.Attributes.Signature("Ljava/lang/ref/Reference<Ljava/lang/Class<*>;>;")]
		internal Reference proxyClass;

		internal bool isUseWriteReplace;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IKVM.Attributes.Signature("([BLjava/lang/Class<*>;Z)V")]
		[LineNumberTable(new byte[] { 159, 48, 66, 104, 103, 108, 103 })]
		internal ProxyDetails(byte[] P_0, Class P_1, bool P_2)
		{
			signature = P_0;
			proxyClass = new java.lang.@ref.WeakReference(P_1);
			isUseWriteReplace = P_2;
		}
	}

	public interface UniqueName
	{
		virtual string get(string str);
	}

	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	[IKVM.Attributes.Signature("Ljava/lang/Class<*>;")]
	private Class superClass;

	[IKVM.Attributes.Signature("[Ljava/lang/Class<*>;")]
	private Class[] interfaces;

	private MethodFilter methodFilter;

	private MethodHandler handler;

	[IKVM.Attributes.Signature("Ljava/util/List<Ljava/util/Map$Entry<Ljava/lang/String;Ljava/lang/reflect/Method;>;>;")]
	private List signatureMethods;

	private bool hasGetHandler;

	private byte[] signature;

	private string classname;

	private string basename;

	private string superName;

	[IKVM.Attributes.Signature("Ljava/lang/Class<*>;")]
	private Class thisClass;

	private string genericSignature;

	private bool factoryUseCache;

	private bool factoryWriteReplace;

	public static bool onlyPublicMethods;

	public string writeDirectory;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[IKVM.Attributes.Signature("Ljava/lang/Class<*>;")]
	private static Class OBJECT_TYPE;

	private const string HOLDER = "_methods_";

	private const string HOLDER_TYPE = "[Ljava/lang/reflect/Method;";

	private const string FILTER_SIGNATURE_FIELD = "_filter_signature";

	private const string FILTER_SIGNATURE_TYPE = "[B";

	private const string HANDLER = "handler";

	private const string NULL_INTERCEPTOR_HOLDER = "javassist.util.proxy.RuntimeSupport";

	private const string DEFAULT_INTERCEPTOR = "default_interceptor";

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static string HANDLER_TYPE;

	private const string HANDLER_SETTER = "setHandler";

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static string HANDLER_SETTER_TYPE;

	private const string HANDLER_GETTER = "getHandler";

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static string HANDLER_GETTER_TYPE;

	private const string SERIAL_VERSION_UID_FIELD = "serialVersionUID";

	private const string SERIAL_VERSION_UID_TYPE = "J";

	private const long SERIAL_VERSION_UID_VALUE = -1L;

	public static volatile bool useCache;

	public static volatile bool useWriteReplace;

	[IKVM.Attributes.Signature("Ljava/util/Map<Ljava/lang/ClassLoader;Ljava/util/Map<Ljava/lang/String;Ljavassist/util/proxy/ProxyFactory$ProxyDetails;>;>;")]
	private static Map proxyCache;

	private static char[] hexDigits;

	public static ClassLoaderProvider classLoaderProvider;

	public static UniqueName nameGenerator;

	private const string packageForJavaBase = "javassist.util.proxy.";

	[IKVM.Attributes.Signature("Ljava/util/Comparator<Ljava/util/Map$Entry<Ljava/lang/String;Ljava/lang/reflect/Method;>;>;")]
	private static Comparator sorter;

	private const string HANDLER_GETTER_KEY = "getHandler:()";

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		162, 144, 98, 127, 0, 115, 114, 147, 99, 145,
		99, 107, 99, 203
	})]
	protected internal virtual ClassLoader getClassLoader0()
	{
		ClassLoader classLoader = null;
		if (superClass != null && !java.lang.String.instancehelper_equals(superClass.getName(), "java.lang.Object"))
		{
			classLoader = superClass.getClassLoader(ProxyFactory.___003CGetCallerID_003E());
		}
		else if (interfaces != null && (nint)interfaces.LongLength > 0)
		{
			classLoader = interfaces[0].getClassLoader(ProxyFactory.___003CGetCallerID_003E());
		}
		if (classLoader == null)
		{
			classLoader = java.lang.Object.instancehelper_getClass(this).getClassLoader(ProxyFactory.___003CGetCallerID_003E());
			if (classLoader == null)
			{
				classLoader = java.lang.Thread.currentThread().getContextClassLoader();
				if (classLoader == null)
				{
					classLoader = ClassLoader.getSystemClassLoader(ProxyFactory.___003CGetCallerID_003E());
				}
			}
		}
		return classLoader;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		163, 116, 134, 108, 102, 108, 137, 124, 104, 123,
		115, 237, 58, 233, 73
	})]
	private void computeSignature(MethodFilter P_0)
	{
		makeSortedMethodList();
		int num = signatureMethods.size();
		int num2 = num + 7 >> 3;
		signature = new byte[num2];
		for (int i = 0; i < num; i++)
		{
			Method method = (Method)((Map.Entry)signatureMethods.get(i)).getValue();
			int modifiers = method.getModifiers();
			if (!java.lang.reflect.Modifier.isFinal(modifiers) && !java.lang.reflect.Modifier.isStatic(modifiers) && isVisible(modifiers, basename, method) && (P_0 == null || P_0.isHandled(method)))
			{
				setBit(signature, i);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/lang/invoke/MethodHandles$Lookup;)Ljava/lang/Class<*>;")]
	[LineNumberTable(new byte[]
	{
		161, 185, 103, 99, 103, 108, 104, 138, 136, 135,
		103, 175
	})]
	private Class createClass1(MethodHandles.Lookup P_0)
	{
		Class @class = thisClass;
		if (@class == null)
		{
			ClassLoader classLoader = getClassLoader();
			lock (proxyCache)
			{
				if (factoryUseCache)
				{
					createClass2(classLoader, P_0);
				}
				else
				{
					createClass3(classLoader, P_0);
				}
				@class = thisClass;
				thisClass = null;
				return @class;
			}
		}
		return @class;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 134, 134, 108, 102, 101, 176, 103 })]
	private void installSignature(byte[] P_0)
	{
		makeSortedMethodList();
		int num = signatureMethods.size();
		int num2 = num + 7 >> 3;
		if ((nint)P_0.LongLength != num2)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException("invalid filter signature length for deserialized proxy class");
		}
		signature = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(766)]
	protected internal virtual ClassLoader getClassLoader()
	{
		ClassLoader result = classLoaderProvider.get(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161,
		233,
		byte.MaxValue,
		0,
		71,
		145,
		104,
		102,
		146,
		127,
		3,
		99,
		104,
		114,
		104,
		161,
		104,
		120,
		159,
		3
	})]
	private void createClass2(ClassLoader P_0, MethodHandles.Lookup P_1)
	{
		string key = getKey(superClass, interfaces, signature, factoryWriteReplace);
		object obj = (Map)proxyCache.get(P_0);
		if ((Map)obj == null)
		{
			obj = new HashMap();
			proxyCache.put(P_0, (HashMap)obj);
		}
		object obj2 = obj;
		object key2 = key;
		ProxyDetails proxyDetails = (ProxyDetails)((obj2 == null) ? null : ((obj2 as Map) ?? throw new java.lang.IncompatibleClassChangeError())).get(key2);
		if (proxyDetails != null)
		{
			Reference proxyClass = proxyDetails.proxyClass;
			thisClass = (Class)proxyClass.get();
			if (thisClass != null)
			{
				return;
			}
		}
		createClass3(P_0, P_1);
		proxyDetails = new ProxyDetails(signature, thisClass, factoryWriteReplace);
		object obj3 = obj;
		object value = proxyDetails;
		key2 = key;
		((obj3 == null) ? null : ((obj3 as Map) ?? throw new java.lang.IncompatibleClassChangeError())).put(key2, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		162,
		6,
		166,
		103,
		104,
		140,
		99,
		155,
		141,
		145,
		104,
		byte.MaxValue,
		4,
		69,
		2,
		97,
		178
	})]
	private void createClass3(ClassLoader P_0, MethodHandles.Lookup P_1)
	{
		allocateClassName();
		CannotCompileException ex;
		try
		{
			ClassFile cf = make();
			if (writeDirectory != null)
			{
				FactoryHelper.writeFile(cf, writeDirectory);
			}
			if (P_1 == null)
			{
				thisClass = FactoryHelper.toClass(cf, getClassInTheSamePackage(), P_0, getDomain());
			}
			else
			{
				thisClass = FactoryHelper.toClass(cf, P_1);
			}
			setField("_filter_signature", signature);
			if (!factoryUseCache)
			{
				setField("default_interceptor", handler);
			}
			return;
		}
		catch (CannotCompileException x)
		{
			ex = ByteCodeHelper.MapException<CannotCompileException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		CannotCompileException ex2 = ex;
		string message = Throwable.instancehelper_getMessage(ex2);
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(message, ex2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/lang/Class<*>;[Ljava/lang/Class<*>;[BZ)Ljava/lang/String;")]
	[LineNumberTable(new byte[]
	{
		158, 254, 163, 102, 99, 141, 105, 103, 111, 9,
		198, 103, 100, 102, 104, 111, 239, 59, 230, 71,
		99, 172
	})]
	public virtual string getKey(Class superClass, Class[] interfaces, byte[] signature, bool useWriteReplace)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (superClass != null)
		{
			stringBuilder.append(superClass.getName());
		}
		stringBuilder.append(':');
		for (int i = 0; i < (nint)interfaces.LongLength; i++)
		{
			stringBuilder.append(interfaces[i].getName());
			stringBuilder.append(':');
		}
		for (int i = 0; i < (nint)signature.LongLength; i++)
		{
			int num = signature[i];
			int num2 = num & 0xF;
			int num3 = (num >> 4) & 0xF;
			stringBuilder.append(hexDigits[num2]);
			stringBuilder.append(hexDigits[num3]);
		}
		if (useWriteReplace)
		{
			stringBuilder.append(":w");
		}
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 94, 113 })]
	private void allocateClassName()
	{
		classname = makeProxyName(basename);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		163, 11, 120, 103, 127, 1, 167, 104, 113, 104,
		199, 113, 103, 167, 113, 104, 167, 114, 105, 136,
		104, 110, 232, 69, 148, 103, 114, 113, 109, 104,
		141, 136, 215, 2, 225, 69, 103
	})]
	private ClassFile make()
	{
		ClassFile.___003Cclinit_003E();
		ClassFile classFile = new ClassFile(isInterface: false, classname, superName);
		classFile.setAccessFlags(1);
		setInterfaces(classFile, interfaces, (!hasGetHandler) ? ClassLiteral<ProxyObject>.Value : ClassLiteral<Proxy>.Value);
		ConstPool constPool = classFile.getConstPool();
		FieldInfo fieldInfo;
		if (!factoryUseCache)
		{
			fieldInfo = new FieldInfo(constPool, "default_interceptor", HANDLER_TYPE);
			fieldInfo.setAccessFlags(9);
			classFile.addField(fieldInfo);
		}
		fieldInfo = new FieldInfo(constPool, "handler", HANDLER_TYPE);
		fieldInfo.setAccessFlags(2);
		classFile.addField(fieldInfo);
		FieldInfo fieldInfo2 = new FieldInfo(constPool, "_filter_signature", "[B");
		fieldInfo2.setAccessFlags(9);
		classFile.addField(fieldInfo2);
		FieldInfo fieldInfo3 = new FieldInfo(constPool, "serialVersionUID", "J");
		fieldInfo3.setAccessFlags(25);
		classFile.addField(fieldInfo3);
		if (genericSignature != null)
		{
			javassist.bytecode.SignatureAttribute info = new javassist.bytecode.SignatureAttribute(constPool, genericSignature);
			classFile.addAttribute(info);
		}
		makeConstructors(classname, classFile, constPool, classname);
		ArrayList arrayList = new ArrayList();
		int num = overrideMethods(classFile, constPool, classname, arrayList);
		addClassInitializer(classFile, constPool, classname, num, arrayList);
		addSetter(classname, classFile, constPool);
		if (!hasGetHandler)
		{
			addGetter(classname, classFile, constPool);
		}
		if (factoryWriteReplace)
		{
			try
			{
				classFile.addMethod(makeWriteReplace(constPool));
			}
			catch (DuplicateMemberException)
			{
				goto IL_016a;
			}
		}
		goto IL_0170;
		IL_016a:
		_ = null;
		goto IL_0170;
		IL_0170:
		thisClass = null;
		return classFile;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("()Ljava/lang/Class<*>;")]
	[LineNumberTable(new byte[] { 162, 36, 114, 105, 117, 103, 114, 137 })]
	private Class getClassInTheSamePackage()
	{
		if (java.lang.String.instancehelper_startsWith(basename, "javassist.util.proxy."))
		{
			Class result = java.lang.Object.instancehelper_getClass(this);
			_ = null;
			return result;
		}
		if (superClass != null && superClass != OBJECT_TYPE)
		{
			return superClass;
		}
		if (interfaces != null && (nint)interfaces.LongLength > 0)
		{
			return interfaces[0];
		}
		Class result2 = java.lang.Object.instancehelper_getClass(this);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 165, 127, 0, 105, 114, 139, 135 })]
	protected internal virtual ProtectionDomain getDomain()
	{
		Class @class = ((superClass != null && !java.lang.String.instancehelper_equals(superClass.getName(), "java.lang.Object")) ? superClass : ((interfaces == null || (nint)interfaces.LongLength <= 0) ? java.lang.Object.instancehelper_getClass(this) : interfaces[0]));
		ProtectionDomain protectionDomain = @class.getProtectionDomain();
		_ = null;
		return protectionDomain;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 47, 145, 114, 103, 109, 222, 2, 97, 140 })]
	private void setField(string P_0, object P_1)
	{
		if (thisClass == null || P_1 == null)
		{
			return;
		}
		java.lang.Exception ex2;
		try
		{
			Field field = thisClass.getField(P_0, ProxyFactory.___003CGetCallerID_003E());
			SecurityActions.setAccessible(field, true);
			field.set(null, P_1, ProxyFactory.___003CGetCallerID_003E());
			SecurityActions.setAccessible(field, false);
			return;
		}
		catch (System.Exception x)
		{
			java.lang.Exception ex = ByteCodeHelper.MapException<java.lang.Exception>(x, ByteCodeHelper.MapFlags.None);
			if (ex == null)
			{
				throw;
			}
			ex2 = ex;
		}
		java.lang.Exception cause = ex2;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(cause);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/lang/Class<*>;Ljava/lang/String;)Ljava/lang/Object;")]
	[LineNumberTable(new byte[] { 162, 65, 109, 103, 109, 103, 156, 98 })]
	private static object getField(Class P_0, string P_1)
	{
		//Discarded unreachable code: IL_002b
		java.lang.Exception ex2;
		try
		{
			Field field = P_0.getField(P_1, ProxyFactory.___003CGetCallerID_003E());
			field.setAccessible(flag: true);
			object result = field.get(null, ProxyFactory.___003CGetCallerID_003E());
			field.setAccessible(flag: false);
			return result;
		}
		catch (System.Exception x)
		{
			java.lang.Exception ex = ByteCodeHelper.MapException<java.lang.Exception>(x, ByteCodeHelper.MapFlags.None);
			if (ex == null)
			{
				throw;
			}
			ex2 = ex;
		}
		java.lang.Exception cause = ex2;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(cause);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.NoSuchMethodException", "java.lang.IllegalArgumentException", "java.lang.InstantiationException", "java.lang.IllegalAccessException", "java.lang.reflect.InvocationTargetException" })]
	[IKVM.Attributes.Signature("([Ljava/lang/Class<*>;[Ljava/lang/Object;)Ljava/lang/Object;")]
	[LineNumberTable(new byte[] { 162, 202, 103, 109 })]
	public virtual object create(Class[] paramTypes, object[] args)
	{
		Class @class = createClass();
		Constructor constructor = @class.getConstructor(paramTypes, ProxyFactory.___003CGetCallerID_003E());
		object result = constructor.newInstance(args, ProxyFactory.___003CGetCallerID_003E());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("()Ljava/lang/Class<*>;")]
	[LineNumberTable(new byte[] { 161, 108, 104, 140 })]
	public virtual Class createClass()
	{
		if (signature == null)
		{
			computeSignature(methodFilter);
		}
		Class result = createClass1(null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ClassFile;[Ljava/lang/Class<*>;Ljava/lang/Class<*>;)V")]
	[LineNumberTable(new byte[]
	{
		163, 166, 135, 103, 141, 106, 103, 43, 166, 165,
		105
	})]
	private static void setInterfaces(ClassFile P_0, Class[] P_1, Class P_2)
	{
		string name = P_2.getName();
		string[] array;
		if (P_1 == null || P_1.Length == 0)
		{
			array = new string[1] { name };
		}
		else
		{
			array = new string[(nint)P_1.LongLength + 1];
			for (int i = 0; i < (nint)P_1.LongLength; i++)
			{
				array[i] = P_1[i].getName();
			}
			array[(nint)P_1.LongLength] = name;
		}
		P_0.setInterfaces(array);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		164, 65, 140, 109, 106, 100, 104, 123, 103, 113,
		232, 58, 233, 73
	})]
	private void makeConstructors(string P_0, ClassFile P_1, ConstPool P_2, string P_3)
	{
		Constructor[] declaredConstructors = SecurityActions.getDeclaredConstructors(superClass);
		int num = ((!factoryUseCache) ? 1 : 0);
		for (int i = 0; i < (nint)declaredConstructors.LongLength; i++)
		{
			Constructor constructor = declaredConstructors[i];
			int modifiers = constructor.getModifiers();
			if (!java.lang.reflect.Modifier.isFinal(modifiers) && !java.lang.reflect.Modifier.isPrivate(modifiers) && isVisible(modifiers, basename, constructor))
			{
				MethodInfo minfo = makeConstructor(P_0, constructor, P_2, superClass, (byte)num != 0);
				P_1.addMethod(minfo);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ClassFile;Ljavassist/bytecode/ConstPool;Ljava/lang/String;Ljava/util/List<Ljavassist/util/proxy/ProxyFactory$Find2MethodsArgs;>;)I")]
	[LineNumberTable(new byte[]
	{
		164, 18, 113, 108, 98, 107, 108, 123, 111, 112,
		62, 197, 100, 133
	})]
	private int overrideMethods(ClassFile P_0, ConstPool P_1, string P_2, List P_3)
	{
		string text = makeUniqueName("_d", signatureMethods);
		Iterator iterator = signatureMethods.iterator();
		int num = 0;
		while (iterator.hasNext())
		{
			Map.Entry entry = (Map.Entry)iterator.next();
			if ((ClassFile.___003C_003EMAJOR_VERSION < 49 || !isBridge((Method)entry.getValue())) && testBit(signature, num))
			{
				@override(P_2, (Method)entry.getValue(), text, num, keyToDesc((string)entry.getKey(), (Method)entry.getValue()), P_0, P_1, P_3);
			}
			num++;
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ClassFile;Ljavassist/bytecode/ConstPool;Ljava/lang/String;ILjava/util/List<Ljavassist/util/proxy/ProxyFactory$Find2MethodsArgs;>;)V")]
	[LineNumberTable(new byte[]
	{
		163, 185, 113, 104, 103, 113, 103, 149, 105, 105,
		107, 98, 199, 103, 149, 98, 135, 125, 191, 7,
		103, 145, 104, 113, 107, 108, 105
	})]
	private static void addClassInitializer(ClassFile P_0, ConstPool P_1, string P_2, int P_3, List P_4)
	{
		FieldInfo fieldInfo = new FieldInfo(P_1, "_methods_", "[Ljava/lang/reflect/Method;");
		fieldInfo.setAccessFlags(10);
		P_0.addField(fieldInfo);
		MethodInfo methodInfo = new MethodInfo(P_1, "<clinit>", "()V");
		methodInfo.setAccessFlags(8);
		setThrows(methodInfo, P_1, new Class[1] { ClassLiteral<java.lang.ClassNotFoundException>.Value });
		Bytecode bytecode = new Bytecode(P_1, 0, 2);
		bytecode.addIconst(P_3 * 2);
		bytecode.addAnewarray("java.lang.reflect.Method");
		_ = 0;
		bytecode.addAstore(0);
		bytecode.addLdc(P_2);
		bytecode.addInvokestatic("java.lang.Class", "forName", "(Ljava/lang/String;)Ljava/lang/Class;");
		_ = 1;
		bytecode.addAstore(1);
		Iterator iterator = P_4.iterator();
		while (iterator.hasNext())
		{
			Find2MethodsArgs find2MethodsArgs = (Find2MethodsArgs)iterator.next();
			callFind2Methods(bytecode, find2MethodsArgs.methodName, find2MethodsArgs.delegatorName, find2MethodsArgs.origIndex, find2MethodsArgs.descriptor, 1, 0);
		}
		bytecode.addAload(0);
		bytecode.addPutstatic(P_2, "_methods_", "[Ljava/lang/reflect/Method;");
		bytecode.addLconst(-1L);
		bytecode.addPutstatic(P_2, "serialVersionUID", "J");
		bytecode.addOpcode(177);
		methodInfo.setCodeAttribute(bytecode.toCodeAttribute());
		P_0.addMethod(methodInfo);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		163, 245, 145, 103, 105, 103, 103, 113, 107, 108,
		105
	})]
	private static void addSetter(string P_0, ClassFile P_1, ConstPool P_2)
	{
		MethodInfo methodInfo = new MethodInfo(P_2, "setHandler", HANDLER_SETTER_TYPE);
		methodInfo.setAccessFlags(1);
		Bytecode bytecode = new Bytecode(P_2, 2, 2);
		bytecode.addAload(0);
		bytecode.addAload(1);
		bytecode.addPutfield(P_0, "handler", HANDLER_TYPE);
		bytecode.addOpcode(177);
		methodInfo.setCodeAttribute(bytecode.toCodeAttribute());
		P_1.addMethod(methodInfo);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 164, 4, 145, 103, 105, 103, 113, 107, 108, 105 })]
	private static void addGetter(string P_0, ClassFile P_1, ConstPool P_2)
	{
		MethodInfo methodInfo = new MethodInfo(P_2, "getHandler", HANDLER_GETTER_TYPE);
		methodInfo.setAccessFlags(1);
		Bytecode bytecode = new Bytecode(P_2, 1, 1);
		bytecode.addAload(0);
		bytecode.addGetfield(P_0, "handler", HANDLER_TYPE);
		bytecode.addOpcode(176);
		methodInfo.setCodeAttribute(bytecode.toCodeAttribute());
		P_1.addMethod(methodInfo);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		165, 235, 113, 103, 104, 103, 103, 103, 105, 103,
		181, 107, 108
	})]
	private static MethodInfo makeWriteReplace(ConstPool P_0)
	{
		MethodInfo methodInfo = new MethodInfo(P_0, "writeReplace", "()Ljava/lang/Object;");
		string[] exceptions = new string[1] { "java.io.ObjectStreamException" };
		ExceptionsAttribute exceptionsAttribute = new ExceptionsAttribute(P_0);
		exceptionsAttribute.setExceptions(exceptions);
		methodInfo.setExceptionsAttribute(exceptionsAttribute);
		Bytecode bytecode = new Bytecode(P_0, 0, 1);
		bytecode.addAload(0);
		bytecode.addInvokestatic("javassist.util.proxy.RuntimeSupport", "makeSerializedProxy", "(Ljava/lang/Object;)Ljavassist/util/proxy/SerializedProxy;");
		bytecode.addOpcode(176);
		methodInfo.setCodeAttribute(bytecode.toCodeAttribute());
		return methodInfo;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 5, 108, 113 })]
	private static string makeProxyName(string P_0)
	{
		//Discarded unreachable code: IL_0019
		lock (nameGenerator)
		{
			return nameGenerator.get(P_0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		163,
		68,
		104,
		140,
		104,
		107,
		113,
		114,
		148,
		113,
		172,
		114,
		byte.MaxValue,
		11,
		69,
		127,
		12,
		127,
		15
	})]
	private void checkClassAndSuperName()
	{
		if (interfaces == null)
		{
			interfaces = new Class[0];
		}
		if (superClass == null)
		{
			superClass = OBJECT_TYPE;
			superName = superClass.getName();
			basename = ((interfaces.Length != 0) ? interfaces[0].getName() : superName);
		}
		else
		{
			superName = superClass.getName();
			basename = superName;
		}
		if (java.lang.reflect.Modifier.isFinal(superClass.getModifiers()))
		{
			string message = new StringBuilder().append(superName).append(" is final").toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException(message);
		}
		if (java.lang.String.instancehelper_startsWith(basename, "java.") || java.lang.String.instancehelper_startsWith(basename, "jdk.") || onlyPublicMethods)
		{
			basename = new StringBuilder().append("javassist.util.proxy.").append(java.lang.String.instancehelper_replace(basename, '.', '_')).toString();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/lang/Class<*>;[Ljava/lang/Class<*>;)Ljava/util/Map<Ljava/lang/String;Ljava/lang/reflect/Method;>;")]
	[LineNumberTable(new byte[] { 164, 128, 102, 102, 103, 43, 166, 105 })]
	private Map getMethods(Class P_0, Class[] P_1)
	{
		HashMap hashMap = new HashMap();
		HashSet hashSet = new HashSet();
		for (int i = 0; i < (nint)P_1.LongLength; i++)
		{
			getMethods(hashMap, P_1[i], hashSet);
		}
		getMethods(hashMap, P_0, hashSet);
		return hashMap;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 106, 134, 103, 115, 118, 114 })]
	private void makeSortedMethodList()
	{
		checkClassAndSuperName();
		hasGetHandler = false;
		Map methods = getMethods(superClass, interfaces);
		ArrayList.___003Cclinit_003E();
		signatureMethods = new ArrayList(methods.entrySet());
		Collections.sort(signatureMethods, sorter);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 105, 101, 98, 101, 130, 103, 113, 99, 104 })]
	private static bool isVisible(int P_0, string P_1, Member P_2)
	{
		if (((uint)P_0 & 2u) != 0)
		{
			return false;
		}
		if (((uint)P_0 & 5u) != 0)
		{
			return true;
		}
		string packageName = getPackageName(P_1);
		string packageName2 = getPackageName(P_2.getDeclaringClass().getName());
		if (packageName == null)
		{
			return packageName2 == null;
		}
		bool result = java.lang.String.instancehelper_equals(packageName, packageName2);
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 163, 156, 100, 101, 100, 103, 100, 135 })]
	private void setBit(byte[] P_0, int P_1)
	{
		int num = P_1 >> 3;
		if (num < (nint)P_0.LongLength)
		{
			int num2 = P_1 & 7;
			int num3 = 1 << num2;
			int num4 = P_0[num];
			P_0[num] = (byte)(sbyte)(num4 | num3);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/MethodInfo;Ljavassist/bytecode/ConstPool;[Ljava/lang/Class<*>;)V")]
	[LineNumberTable(new byte[]
	{
		165, 118, 100, 129, 104, 103, 43, 166, 103, 103,
		105
	})]
	private static void setThrows(MethodInfo P_0, ConstPool P_1, Class[] P_2)
	{
		if (P_2.Length != 0)
		{
			string[] array = new string[(nint)P_2.LongLength];
			for (int i = 0; i < (nint)P_2.LongLength; i++)
			{
				array[i] = P_2[i].getName();
			}
			ExceptionsAttribute exceptionsAttribute = new ExceptionsAttribute(P_1);
			exceptionsAttribute.setExceptions(array);
			P_0.setExceptionsAttribute(exceptionsAttribute);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		163, 225, 107, 166, 104, 103, 99, 137, 135, 103,
		104, 104, 111
	})]
	private static void callFind2Methods(Bytecode P_0, string P_1, string P_2, int P_3, string P_4, int P_5, int P_6)
	{
		string name = ClassLiteral<RuntimeSupport>.Value.getName();
		string desc = "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;[Ljava/lang/reflect/Method;)V";
		P_0.addAload(P_5);
		P_0.addLdc(P_1);
		if (P_2 == null)
		{
			P_0.addOpcode(1);
		}
		else
		{
			P_0.addLdc(P_2);
		}
		P_0.addIconst(P_3);
		P_0.addLdc(P_4);
		P_0.addAload(P_6);
		P_0.addInvokestatic(name, "find2Methods", desc);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/lang/String;Ljava/util/List<Ljava/util/Map$Entry<Ljava/lang/String;Ljava/lang/reflect/Method;>;>;)Ljava/lang/String;")]
	[LineNumberTable(new byte[]
	{
		164, 80, 110, 130, 107, 119, 110, 226, 61, 230,
		70
	})]
	private static string makeUniqueName(string P_0, List P_1)
	{
		if (makeUniqueName0(P_0, P_1.iterator()))
		{
			return P_0;
		}
		for (int i = 100; i < 999; i++)
		{
			string text = new StringBuilder().append(P_0).append(i).toString();
			if (makeUniqueName0(text, P_1.iterator()))
			{
				return text;
			}
		}
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException("cannot make a unique method name");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1174)]
	private static bool isBridge(Method P_0)
	{
		bool result = P_0.isBridge();
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 163, 146, 100, 101, 98, 100, 103, 100 })]
	private bool testBit(byte[] P_0, int P_1)
	{
		int num = P_1 >> 3;
		if (num > (nint)P_0.LongLength)
		{
			return false;
		}
		int num2 = P_1 & 7;
		int num3 = 1 << num2;
		int num4 = P_0[num];
		return ((num4 & num3) != 0) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1353)]
	private static string keyToDesc(string P_0, Method P_1)
	{
		string result = java.lang.String.instancehelper_substring(P_0, java.lang.String.instancehelper_indexOf(P_0, 58) + 1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[IKVM.Attributes.Signature("(Ljava/lang/String;Ljava/lang/reflect/Method;Ljava/lang/String;ILjava/lang/String;Ljavassist/bytecode/ClassFile;Ljavassist/bytecode/ConstPool;Ljava/util/List<Ljavassist/util/proxy/ProxyFactory$Find2MethodsArgs;>;)V")]
	[LineNumberTable(new byte[]
	{
		164, 44, 103, 127, 4, 109, 132, 104, 134, 111,
		168, 108, 134, 106
	})]
	private void @override(string P_0, Method P_1, string P_2, int P_3, string P_4, ClassFile P_5, ConstPool P_6, List P_7)
	{
		Class declaringClass = P_1.getDeclaringClass();
		string text = new StringBuilder().append(P_2).append(P_3).append(P_1.getName())
			.toString();
		MethodInfo methodInfo;
		if (java.lang.reflect.Modifier.isAbstract(P_1.getModifiers()))
		{
			text = null;
		}
		else
		{
			methodInfo = makeDelegator(P_1, P_4, P_6, declaringClass, text);
			methodInfo.setAccessFlags(methodInfo.getAccessFlags() & -65);
			P_5.addMethod(methodInfo);
		}
		methodInfo = makeForwarder(P_0, P_1, P_4, P_6, declaringClass, text, P_3, P_7);
		P_5.addMethod(methodInfo);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/lang/reflect/Method;Ljava/lang/String;Ljavassist/bytecode/ConstPool;Ljava/lang/Class<*>;Ljava/lang/String;)Ljavassist/bytecode/MethodInfo;")]
	[LineNumberTable(new byte[]
	{
		165, 5, 106, 100, 44, 229, 70, 104, 105, 103,
		110, 105, 116, 38, 133, 109, 107, 108
	})]
	private MethodInfo makeDelegator(Method P_0, string P_1, ConstPool P_2, Class P_3, string P_4)
	{
		MethodInfo methodInfo = new MethodInfo(P_2, P_4, P_1);
		methodInfo.setAccessFlags(0x11 | (P_0.getModifiers() & -1319));
		setThrows(methodInfo, P_2, P_0);
		Bytecode bytecode = new Bytecode(P_2, 0, 0);
		bytecode.addAload(0);
		int num = addLoadParameters(bytecode, P_0.getParameterTypes(), 1);
		Class @class = invokespecialTarget(P_3);
		bytecode.addInvokespecial(@class.isInterface(), P_2.addClassInfo(@class.getName()), P_0.getName(), P_1);
		addReturn(bytecode, P_0.getReturnType());
		num++;
		bytecode.setMaxLocals(num);
		methodInfo.setCodeAttribute(bytecode.toCodeAttribute());
		return methodInfo;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/lang/String;Ljava/lang/reflect/Method;Ljava/lang/String;Ljavassist/bytecode/ConstPool;Ljava/lang/Class<*>;Ljava/lang/String;ILjava/util/List<Ljavassist/util/proxy/ProxyFactory$Find2MethodsArgs;>;)Ljavassist/bytecode/MethodInfo;")]
	[LineNumberTable(new byte[]
	{
		165, 46, 110, 100, 44, 197, 104, 103, 235, 77,
		101, 104, 101, 113, 136, 151, 103, 113, 135, 104,
		103, 136, 104, 104, 136, 108, 187, 104, 104, 137,
		104, 104
	})]
	private static MethodInfo makeForwarder(string P_0, Method P_1, string P_2, ConstPool P_3, Class P_4, string P_5, int P_6, List P_7)
	{
		MethodInfo methodInfo = new MethodInfo(P_3, P_1.getName(), P_2);
		methodInfo.setAccessFlags(0x10 | (P_1.getModifiers() & -1313));
		setThrows(methodInfo, P_3, P_1);
		int num = Descriptor.paramSize(P_2);
		Bytecode bytecode = new Bytecode(P_3, 0, num + 2);
		int num2 = P_6 * 2;
		int n = P_6 * 2 + 1;
		int n2 = num + 1;
		bytecode.addGetstatic(P_0, "_methods_", "[Ljava/lang/reflect/Method;");
		bytecode.addAstore(n2);
		P_7.add(new Find2MethodsArgs(P_1.getName(), P_5, P_2, num2));
		bytecode.addAload(0);
		bytecode.addGetfield(P_0, "handler", HANDLER_TYPE);
		bytecode.addAload(0);
		bytecode.addAload(n2);
		bytecode.addIconst(num2);
		bytecode.addOpcode(50);
		bytecode.addAload(n2);
		bytecode.addIconst(n);
		bytecode.addOpcode(50);
		makeParameterList(bytecode, P_1.getParameterTypes());
		bytecode.addInvokeinterface(ClassLiteral<MethodHandler>.Value.getName(), "invoke", "(Ljava/lang/Object;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Object;", 5);
		Class returnType = P_1.getReturnType();
		addUnwrapper(bytecode, returnType);
		addReturn(bytecode, returnType);
		CodeAttribute codeAttribute = bytecode.toCodeAttribute();
		methodInfo.setCodeAttribute(codeAttribute);
		return methodInfo;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/lang/String;Ljava/lang/reflect/Constructor<*>;Ljavassist/bytecode/ConstPool;Ljava/lang/Class<*>;Z)Ljavassist/bytecode/MethodInfo;")]
	[LineNumberTable(new byte[]
	{
		158, 59, 131, 145, 109, 103, 109, 233, 69, 99,
		103, 113, 113, 113, 107, 200, 103, 117, 113, 136,
		103, 111, 114, 107, 106, 104, 136, 105, 105, 111
	})]
	private static MethodInfo makeConstructor(string P_0, Constructor P_1, ConstPool P_2, Class P_3, bool P_4)
	{
		string desc = RuntimeSupport.makeDescriptor(P_1.getParameterTypes(), java.lang.Void.TYPE);
		MethodInfo methodInfo = new MethodInfo(P_2, "<init>", desc);
		methodInfo.setAccessFlags(1);
		setThrows(methodInfo, P_2, P_1.getExceptionTypes());
		Bytecode bytecode = new Bytecode(P_2, 0, 0);
		if (P_4)
		{
			bytecode.addAload(0);
			bytecode.addGetstatic(P_0, "default_interceptor", HANDLER_TYPE);
			bytecode.addPutfield(P_0, "handler", HANDLER_TYPE);
			bytecode.addGetstatic(P_0, "default_interceptor", HANDLER_TYPE);
			bytecode.addOpcode(199);
			bytecode.addIndex(10);
		}
		bytecode.addAload(0);
		bytecode.addGetstatic("javassist.util.proxy.RuntimeSupport", "default_interceptor", HANDLER_TYPE);
		bytecode.addPutfield(P_0, "handler", HANDLER_TYPE);
		int offsetDelta = bytecode.currentPc();
		bytecode.addAload(0);
		int num = addLoadParameters(bytecode, P_1.getParameterTypes(), 1);
		bytecode.addInvokespecial(P_3.getName(), "<init>", desc);
		bytecode.addOpcode(177);
		bytecode.setMaxLocals(num + 1);
		CodeAttribute codeAttribute = bytecode.toCodeAttribute();
		methodInfo.setCodeAttribute(codeAttribute);
		StackMapTable.Writer writer = new StackMapTable.Writer(32);
		writer.sameFrame(offsetDelta);
		codeAttribute.setAttribute(writer.toStackMapTable(P_2));
		return methodInfo;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/lang/String;Ljava/util/Iterator<Ljava/util/Map$Entry<Ljava/lang/String;Ljava/lang/reflect/Method;>;>;)Z")]
	[LineNumberTable(new byte[] { 164, 93, 104, 125, 98 })]
	private static bool makeUniqueName0(string P_0, Iterator P_1)
	{
		while (P_1.hasNext())
		{
			if (java.lang.String.instancehelper_startsWith((string)((Map.Entry)P_1.next()).getKey(), P_0))
			{
				return false;
			}
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 119, 105, 100, 98 })]
	private static string getPackageName(string P_0)
	{
		int num = java.lang.String.instancehelper_lastIndexOf(P_0, 46);
		if (num < 0)
		{
			return null;
		}
		string result = java.lang.String.instancehelper_substring(P_0, 0, num);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/util/Map<Ljava/lang/String;Ljava/lang/reflect/Method;>;Ljava/lang/Class<*>;Ljava/util/Set<Ljava/lang/Class<*>;>;)V")]
	[LineNumberTable(new byte[]
	{
		164, 140, 105, 129, 103, 103, 43, 166, 103, 99,
		233, 71, 103, 108, 115, 102, 127, 12, 110, 199,
		209, 112, 115, 118, 171, 117, 172, 235, 41, 235,
		90
	})]
	private void getMethods(Map P_0, Class P_1, Set P_2)
	{
		if (!P_2.add(P_1))
		{
			return;
		}
		Class[] array = P_1.getInterfaces();
		for (int i = 0; i < (nint)array.LongLength; i++)
		{
			getMethods(P_0, array[i], P_2);
		}
		Class superclass = P_1.getSuperclass();
		if (superclass != null)
		{
			getMethods(P_0, superclass, P_2);
		}
		Method[] declaredMethods = SecurityActions.getDeclaredMethods(P_1);
		for (int j = 0; j < (nint)declaredMethods.LongLength; j++)
		{
			if (!java.lang.reflect.Modifier.isPrivate(declaredMethods[j].getModifiers()))
			{
				Method method = declaredMethods[j];
				string text = new StringBuilder().append(method.getName()).append(':').append(RuntimeSupport.makeDescriptor(method))
					.toString();
				if (java.lang.String.instancehelper_startsWith(text, "getHandler:()"))
				{
					hasGetHandler = true;
				}
				Method method2 = (Method)P_0.put(text, method);
				if (null != method2 && isBridge(method) && !java.lang.reflect.Modifier.isPublic(method2.getDeclaringClass().getModifiers()) && !java.lang.reflect.Modifier.isAbstract(method2.getModifiers()) && !isDuplicated(j, declaredMethods))
				{
					P_0.put(text, method2);
				}
				if (null != method2 && java.lang.reflect.Modifier.isPublic(method2.getModifiers()) && !java.lang.reflect.Modifier.isPublic(method.getModifiers()))
				{
					P_0.put(text, method2);
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 186, 105, 103, 100, 125, 226, 61, 230, 69 })]
	private static bool isDuplicated(int P_0, Method[] P_1)
	{
		string name = P_1[P_0].getName();
		for (int i = 0; i < (nint)P_1.LongLength; i++)
		{
			if (i != P_0 && java.lang.String.instancehelper_equals(name, P_1[i].getName()) && areParametersSame(P_1[P_0], P_1[i]))
			{
				return true;
			}
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		164, 196, 103, 103, 102, 103, 119, 130, 226, 60,
		230, 71, 130
	})]
	private static bool areParametersSame(Method P_0, Method P_1)
	{
		Class[] parameterTypes = P_0.getParameterTypes();
		Class[] parameterTypes2 = P_1.getParameterTypes();
		if ((nint)parameterTypes.LongLength == (nint)parameterTypes2.LongLength)
		{
			for (int i = 0; i < (nint)parameterTypes.LongLength; i++)
			{
				if (!java.lang.String.instancehelper_equals(parameterTypes[i].getName(), parameterTypes2[i].getName()))
				{
					return false;
				}
			}
			return true;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/Bytecode;[Ljava/lang/Class<*>;I)I")]
	[LineNumberTable(new byte[] { 165, 132, 98, 99, 102, 47, 166 })]
	private static int addLoadParameters(Bytecode P_0, Class[] P_1, int P_2)
	{
		int num = 0;
		int num2 = P_1.Length;
		for (int i = 0; i < num2; i++)
		{
			num += addLoad(P_0, num + P_2, P_1[i]);
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 165, 112, 103, 106 })]
	private static void setThrows(MethodInfo P_0, ConstPool P_1, Method P_2)
	{
		Class[] exceptionTypes = P_2.getExceptionTypes();
		setThrows(P_0, P_1, exceptionTypes);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/lang/Class<*>;)Ljava/lang/Class<*>;")]
	[LineNumberTable(new byte[] { 165, 31, 104, 116, 105, 2, 198 })]
	private Class invokespecialTarget(Class P_0)
	{
		if (P_0.isInterface())
		{
			Class[] array = interfaces;
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				Class @class = array[i];
				if (P_0.isAssignableFrom(@class))
				{
					return @class;
				}
			}
		}
		return superClass;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/Bytecode;Ljava/lang/Class<*>;)I")]
	[LineNumberTable(new byte[]
	{
		165, 162, 104, 104, 107, 130, 104, 109, 104, 107,
		130, 104, 107, 162, 173, 139
	})]
	private static int addReturn(Bytecode P_0, Class P_1)
	{
		if (P_1.isPrimitive())
		{
			if (P_1 == Long.TYPE)
			{
				P_0.addOpcode(173);
				return 2;
			}
			if (P_1 == Float.TYPE)
			{
				P_0.addOpcode(174);
			}
			else
			{
				if (P_1 == java.lang.Double.TYPE)
				{
					P_0.addOpcode(175);
					return 2;
				}
				if (P_1 == java.lang.Void.TYPE)
				{
					P_0.addOpcode(177);
					return 0;
				}
				P_0.addOpcode(172);
			}
		}
		else
		{
			P_0.addOpcode(176);
		}
		return 1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/Bytecode;[Ljava/lang/Class<*>;)V")]
	[LineNumberTable(new byte[]
	{
		165, 187, 98, 99, 103, 107, 102, 104, 103, 100,
		104, 139, 103, 164, 232, 53, 230, 77
	})]
	private static void makeParameterList(Bytecode P_0, Class[] P_1)
	{
		int num = 1;
		int num2 = P_1.Length;
		P_0.addIconst(num2);
		P_0.addAnewarray("java/lang/Object");
		for (int i = 0; i < num2; i++)
		{
			P_0.addOpcode(89);
			P_0.addIconst(i);
			Class @class = P_1[i];
			if (@class.isPrimitive())
			{
				num = makeWrapper(P_0, @class, num);
			}
			else
			{
				P_0.addAload(num);
				num++;
			}
			P_0.addOpcode(83);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/Bytecode;Ljava/lang/Class<*>;)V")]
	[LineNumberTable(new byte[]
	{
		165, 218, 104, 104, 138, 103, 104, 103, 181, 162,
		110
	})]
	private static void addUnwrapper(Bytecode P_0, Class P_1)
	{
		if (P_1.isPrimitive())
		{
			if (P_1 == java.lang.Void.TYPE)
			{
				P_0.addOpcode(87);
				return;
			}
			int num = FactoryHelper.typeIndex(P_1);
			string text = FactoryHelper.___003C_003EwrapperTypes[num];
			P_0.addCheckcast(text);
			P_0.addInvokevirtual(text, FactoryHelper.___003C_003EunwarpMethods[num], FactoryHelper.___003C_003EunwrapDesc[num]);
		}
		else
		{
			P_0.addCheckcast(P_1.getName());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/Bytecode;ILjava/lang/Class<*>;)I")]
	[LineNumberTable(new byte[]
	{
		165, 141, 104, 104, 103, 130, 104, 105, 104, 103,
		162, 169, 135
	})]
	private static int addLoad(Bytecode P_0, int P_1, Class P_2)
	{
		if (P_2.isPrimitive())
		{
			if (P_2 == Long.TYPE)
			{
				P_0.addLload(P_1);
				return 2;
			}
			if (P_2 == Float.TYPE)
			{
				P_0.addFload(P_1);
			}
			else
			{
				if (P_2 == java.lang.Double.TYPE)
				{
					P_0.addDload(P_1);
					return 2;
				}
				P_0.addIload(P_1);
			}
		}
		else
		{
			P_0.addAload(P_1);
		}
		return 1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/Bytecode;Ljava/lang/Class<*>;I)I")]
	[LineNumberTable(new byte[] { 165, 207, 103, 104, 103, 104, 105, 147 })]
	private static int makeWrapper(Bytecode P_0, Class P_1, int P_2)
	{
		int num = FactoryHelper.typeIndex(P_1);
		string clazz = FactoryHelper.___003C_003EwrapperTypes[num];
		P_0.addNew(clazz);
		P_0.addOpcode(89);
		addLoad(P_0, P_2, P_1);
		P_0.addInvokespecial(clazz, "<init>", FactoryHelper.___003C_003EwrapperDesc[num]);
		return P_2 + FactoryHelper.___003C_003EdataSize[num];
	}

	public virtual bool isUseCache()
	{
		return factoryUseCache;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 64, 98, 107, 144, 103 })]
	public virtual void setUseCache(bool useCache)
	{
		if (handler != null && useCache)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException("caching cannot be enabled if the factory default interceptor has been set");
		}
		factoryUseCache = useCache;
	}

	public virtual bool isUseWriteReplace()
	{
		return factoryWriteReplace;
	}

	public virtual void setUseWriteReplace(bool useWriteReplace)
	{
		int num = ((factoryWriteReplace = useWriteReplace) ? 1 : 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/lang/Class<*>;)Z")]
	[LineNumberTable(349)]
	public static bool isProxyClass(Class cl)
	{
		bool result = ClassLiteral<Proxy>.Value.isAssignableFrom(cl);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 16, 104, 103, 103, 103, 103, 103, 103, 103,
		103, 103, 103, 109, 109
	})]
	public ProxyFactory()
	{
		superClass = null;
		interfaces = null;
		methodFilter = null;
		handler = null;
		signature = null;
		signatureMethods = null;
		hasGetHandler = false;
		thisClass = null;
		genericSignature = null;
		writeDirectory = null;
		factoryUseCache = useCache;
		factoryWriteReplace = useWriteReplace;
	}

	[IKVM.Attributes.Signature("(Ljava/lang/Class<*>;)V")]
	public virtual void setSuperclass(Class clazz)
	{
		superClass = clazz;
		signature = null;
	}

	[IKVM.Attributes.Signature("()Ljava/lang/Class<*>;")]
	public virtual Class getSuperclass()
	{
		return superClass;
	}

	[IKVM.Attributes.Signature("([Ljava/lang/Class<*>;)V")]
	public virtual void setInterfaces(Class[] ifs)
	{
		interfaces = ifs;
		signature = null;
	}

	[IKVM.Attributes.Signature("()[Ljava/lang/Class<*>;")]
	public virtual Class[] getInterfaces()
	{
		return interfaces;
	}

	public virtual void setFilter(MethodFilter mf)
	{
		methodFilter = mf;
		signature = null;
	}

	public virtual void setGenericSignature(string sig)
	{
		genericSignature = sig;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/util/proxy/MethodFilter;)Ljava/lang/Class<*>;")]
	[LineNumberTable(new byte[] { 161, 120, 103 })]
	public virtual Class createClass(MethodFilter filter)
	{
		computeSignature(filter);
		Class result = createClass1(null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("([B)Ljava/lang/Class<*>;")]
	[LineNumberTable(new byte[] { 161, 131, 103 })]
	internal virtual Class createClass(byte[] P_0)
	{
		installSignature(P_0);
		Class result = createClass1(null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/lang/invoke/MethodHandles$Lookup;)Ljava/lang/Class<*>;")]
	[LineNumberTable(new byte[] { 161, 148, 104, 140 })]
	public virtual Class createClass(MethodHandles.Lookup lookup)
	{
		if (signature == null)
		{
			computeSignature(methodFilter);
		}
		Class result = createClass1(lookup);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/lang/invoke/MethodHandles$Lookup;Ljavassist/util/proxy/MethodFilter;)Ljava/lang/Class<*>;")]
	[LineNumberTable(new byte[] { 161, 165, 103 })]
	public virtual Class createClass(MethodHandles.Lookup lookup, MethodFilter filter)
	{
		computeSignature(filter);
		Class result = createClass1(lookup);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/lang/invoke/MethodHandles$Lookup;[B)Ljava/lang/Class<*>;")]
	[LineNumberTable(new byte[] { 161, 180, 103 })]
	internal virtual Class createClass(MethodHandles.Lookup P_0, byte[] P_1)
	{
		installSignature(P_1);
		Class result = createClass1(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/lang/Class<*>;)[B")]
	[LineNumberTable(686)]
	internal static byte[] getFilterSignature(Class P_0)
	{
		return (byte[])getField(P_0, "_filter_signature");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 85, 118, 103, 109, 103, 159, 2, 98 })]
	public static MethodHandler getHandler(Proxy p)
	{
		//Discarded unreachable code: IL_0039
		java.lang.Exception ex2;
		try
		{
			Field declaredField = java.lang.Object.instancehelper_getClass(p).getDeclaredField("handler", ProxyFactory.___003CGetCallerID_003E());
			declaredField.setAccessible(flag: true);
			object obj = declaredField.get(p, ProxyFactory.___003CGetCallerID_003E());
			declaredField.setAccessible(flag: false);
			return (MethodHandler)obj;
		}
		catch (System.Exception x)
		{
			java.lang.Exception ex = ByteCodeHelper.MapException<java.lang.Exception>(x, ByteCodeHelper.MapFlags.None);
			if (ex == null)
			{
				throw;
			}
			ex2 = ex;
		}
		java.lang.Exception cause = ex2;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(cause);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.NoSuchMethodException", "java.lang.IllegalArgumentException", "java.lang.InstantiationException", "java.lang.IllegalAccessException", "java.lang.reflect.InvocationTargetException" })]
	[IKVM.Attributes.Signature("([Ljava/lang/Class<*>;[Ljava/lang/Object;Ljavassist/util/proxy/MethodHandler;)Ljava/lang/Object;")]
	[LineNumberTable(new byte[] { 162, 187, 105, 108 })]
	public virtual object create(Class[] paramTypes, object[] args, MethodHandler mh)
	{
		object obj = create(paramTypes, args);
		((Proxy)obj).setHandler(mh);
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[LineNumberTable(new byte[] { 162, 220, 107, 135, 135, 167, 115 })]
	[java.lang.Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual void setHandler(MethodHandler mi)
	{
		if (factoryUseCache && mi != null)
		{
			factoryUseCache = false;
			thisClass = null;
		}
		handler = mi;
		setField("default_interceptor", handler);
	}

	[LineNumberTable(new byte[]
	{
		160,
		109,
		230,
		77,
		234,
		73,
		113,
		159,
		5,
		191,
		14,
		byte.MaxValue,
		4,
		81,
		232,
		85,
		237,
		113,
		234,
		160,
		235,
		byte.MaxValue,
		68,
		160,
		184,
		234,
		160,
		119,
		234,
		160,
		103
	})]
	static ProxyFactory()
	{
		onlyPublicMethods = false;
		OBJECT_TYPE = ClassLiteral<java.lang.Object>.Value;
		HANDLER_TYPE = new StringBuilder().append('L').append(java.lang.String.instancehelper_replace(ClassLiteral<MethodHandler>.Value.getName(), '.', '/')).append(';')
			.toString();
		HANDLER_SETTER_TYPE = new StringBuilder().append("(").append(HANDLER_TYPE).append(")V")
			.toString();
		HANDLER_GETTER_TYPE = new StringBuilder().append("()").append(HANDLER_TYPE).toString();
		useCache = true;
		useWriteReplace = true;
		System.Threading.Thread.MemoryBarrier();
		proxyCache = new WeakHashMap();
		hexDigits = new char[16]
		{
			'0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
			'a', 'b', 'c', 'd', 'e', 'f'
		};
		classLoaderProvider = new _1();
		nameGenerator = new _2();
		sorter = new _3();
	}

	static CallerID ___003CGetCallerID_003E()
	{
		if (___003CcallerID_003E == null)
		{
			___003CcallerID_003E = new ___003CCallerID_003E();
		}
		return ___003CcallerID_003E;
	}
}
