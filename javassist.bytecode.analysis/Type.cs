using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;

namespace javassist.bytecode.analysis;

public class Type : java.lang.Object
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private CtClass clazz;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private bool special;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[IKVM.Attributes.Signature("Ljava/util/Map<Ljavassist/CtClass;Ljavassist/bytecode/analysis/Type;>;")]
	private static Map prims;

	internal static Type ___003C_003EDOUBLE;

	internal static Type ___003C_003EBOOLEAN;

	internal static Type ___003C_003ELONG;

	internal static Type ___003C_003ECHAR;

	internal static Type ___003C_003EBYTE;

	internal static Type ___003C_003ESHORT;

	internal static Type ___003C_003EINTEGER;

	internal static Type ___003C_003EFLOAT;

	internal static Type ___003C_003EVOID;

	internal static Type ___003C_003EUNINIT;

	internal static Type ___003C_003ERETURN_ADDRESS;

	internal static Type ___003C_003ETOP;

	internal static Type ___003C_003EBOGUS;

	internal static Type ___003C_003EOBJECT;

	internal static Type ___003C_003ESERIALIZABLE;

	internal static Type ___003C_003ECLONEABLE;

	internal static Type ___003C_003ETHROWABLE;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static Type DOUBLE
	{
		[HideFromJava]
		get
		{
			return ___003C_003EDOUBLE;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static Type BOOLEAN
	{
		[HideFromJava]
		get
		{
			return ___003C_003EBOOLEAN;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static Type LONG
	{
		[HideFromJava]
		get
		{
			return ___003C_003ELONG;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static Type CHAR
	{
		[HideFromJava]
		get
		{
			return ___003C_003ECHAR;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static Type BYTE
	{
		[HideFromJava]
		get
		{
			return ___003C_003EBYTE;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static Type SHORT
	{
		[HideFromJava]
		get
		{
			return ___003C_003ESHORT;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static Type INTEGER
	{
		[HideFromJava]
		get
		{
			return ___003C_003EINTEGER;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static Type FLOAT
	{
		[HideFromJava]
		get
		{
			return ___003C_003EFLOAT;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static Type VOID
	{
		[HideFromJava]
		get
		{
			return ___003C_003EVOID;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static Type UNINIT
	{
		[HideFromJava]
		get
		{
			return ___003C_003EUNINIT;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static Type RETURN_ADDRESS
	{
		[HideFromJava]
		get
		{
			return ___003C_003ERETURN_ADDRESS;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static Type TOP
	{
		[HideFromJava]
		get
		{
			return ___003C_003ETOP;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static Type BOGUS
	{
		[HideFromJava]
		get
		{
			return ___003C_003EBOGUS;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static Type OBJECT
	{
		[HideFromJava]
		get
		{
			return ___003C_003EOBJECT;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static Type SERIALIZABLE
	{
		[HideFromJava]
		get
		{
			return ___003C_003ESERIALIZABLE;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static Type CLONEABLE
	{
		[HideFromJava]
		get
		{
			return ___003C_003ECLONEABLE;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static Type THROWABLE
	{
		[HideFromJava]
		get
		{
			return ___003C_003ETHROWABLE;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 73, 113 })]
	public static Type get(CtClass clazz)
	{
		Type type = (Type)prims.get(clazz);
		Type result = ((type == null) ? new Type(clazz) : type);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(156)]
	public virtual int getSize()
	{
		return (clazz != CtClass.doubleType && clazz != CtClass.longType && this != ___003C_003ETOP) ? 1 : 2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 168, 100, 98, 99, 98, 104, 98, 104, 162,
		112, 166, 104, 136, 112, 168, 125, 97
	})]
	public virtual Type merge(Type type)
	{
		//Discarded unreachable code: IL_0066
		if (type == this)
		{
			return this;
		}
		if (type == null)
		{
			return this;
		}
		if (type == ___003C_003EUNINIT)
		{
			return this;
		}
		if (this == ___003C_003EUNINIT)
		{
			return type;
		}
		if (!type.isReference() || !isReference())
		{
			return ___003C_003EBOGUS;
		}
		if (type is MultiType)
		{
			return type.merge(this);
		}
		if (type.isArray() && isArray())
		{
			return mergeArray(type);
		}
		NotFoundException ex;
		try
		{
			return mergeClasses(type);
		}
		catch (NotFoundException x)
		{
			ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		NotFoundException cause = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(cause);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 203, 104, 130 })]
	public override bool equals(object o)
	{
		if (!(o is Type))
		{
			return false;
		}
		return (o.GetType() == ((object)this).GetType() && eq(clazz, ((Type)o).clazz)) ? true : false;
	}

	internal virtual bool popChanged()
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(193)]
	public virtual bool isArray()
	{
		return (clazz != null && clazz.isArray()) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 109, 117, 194, 190, 2, 97, 172, 113 })]
	public virtual Type getComponent()
	{
		if (clazz == null || !clazz.isArray())
		{
			return null;
		}
		CtClass componentType;
		NotFoundException ex;
		try
		{
			componentType = clazz.getComponentType();
		}
		catch (NotFoundException x)
		{
			ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0032;
		}
		Type type = (Type)prims.get(componentType);
		return (type == null) ? new Type(componentType) : type;
		IL_0032:
		NotFoundException cause = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(cause);
	}

	public virtual CtClass getCtClass()
	{
		return clazz;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 132, 100, 130, 127, 1, 130, 104, 141, 104,
		205, 117, 162, 127, 13, 97
	})]
	public virtual bool isAssignableFrom(Type type)
	{
		//Discarded unreachable code: IL_007c
		if (this == type)
		{
			return true;
		}
		if ((type == ___003C_003EUNINIT && isReference()) || (this == ___003C_003EUNINIT && type.isReference()))
		{
			return true;
		}
		if (type is MultiType)
		{
			return ((MultiType)type).isAssignableTo(this);
		}
		if (type is MultiArrayType)
		{
			return ((MultiArrayType)type).isAssignableTo(this);
		}
		if (clazz == null || clazz.isPrimitive())
		{
			return false;
		}
		java.lang.Exception ex2;
		try
		{
			return type.clazz.subtypeOf(clazz);
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
	[LineNumberTable(new byte[] { 161, 215, 104, 102, 104, 102, 104, 102, 104, 134 })]
	public override string toString()
	{
		if (this == ___003C_003EBOGUS)
		{
			return "BOGUS";
		}
		if (this == ___003C_003EUNINIT)
		{
			return "UNINIT";
		}
		if (this == ___003C_003ERETURN_ADDRESS)
		{
			return "RETURN ADDRESS";
		}
		if (this == ___003C_003ETOP)
		{
			return "TOP";
		}
		string result = ((clazz != null) ? clazz.getName() : "null");
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 86, 106 })]
	internal Type(CtClass P_0)
		: this(P_0, false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 108, 162, 104, 103, 103 })]
	private Type(CtClass P_0, bool P_1)
	{
		clazz = P_0;
		special = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(174)]
	public virtual bool isReference()
	{
		return (!special && (clazz == null || !clazz.isPrimitive())) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 239, 104, 104, 103, 167, 100, 201, 105, 134,
		236, 70, 100, 99, 133, 99, 195, 127, 17, 141
	})]
	private Type mergeArray(Type P_0)
	{
		Type rootComponent = getRootComponent(P_0);
		Type rootComponent2 = getRootComponent(this);
		int dimensions = P_0.getDimensions();
		int dimensions2 = getDimensions();
		Type type;
		if (dimensions == dimensions2)
		{
			type = rootComponent2.merge(rootComponent);
			if (type == ___003C_003EBOGUS)
			{
				return ___003C_003EOBJECT;
			}
			Type result = createArray(type, dimensions2);
			_ = null;
			return result;
		}
		int num;
		if (dimensions < dimensions2)
		{
			type = rootComponent;
			num = dimensions;
		}
		else
		{
			type = rootComponent2;
			num = dimensions2;
		}
		if (eq(___003C_003ECLONEABLE.clazz, type.clazz) || eq(___003C_003ESERIALIZABLE.clazz, type.clazz))
		{
			Type result2 = createArray(type, num);
			_ = null;
			return result2;
		}
		Type result3 = createArray(___003C_003EOBJECT, num);
		_ = null;
		return result3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		161, 76, 178, 104, 104, 105, 125, 105, 169, 201,
		105, 105, 180
	})]
	private Type mergeClasses(Type P_0)
	{
		CtClass ctClass = findCommonSuperClass(clazz, P_0.clazz);
		Map map;
		if (ctClass.getSuperclass() == null)
		{
			map = findCommonInterfaces(P_0);
			if (map.size() == 1)
			{
				Type result = new Type((CtClass)map.values().iterator().next());
				_ = null;
				return result;
			}
			if (map.size() > 1)
			{
				MultiType result2 = new MultiType(map);
				_ = null;
				return result2;
			}
			Type result3 = new Type(ctClass);
			_ = null;
			return result3;
		}
		map = findExclusiveDeclaredInterfaces(P_0, ctClass);
		if (map.size() > 0)
		{
			MultiType.___003Cclinit_003E();
			MultiType result4 = new MultiType(map, new Type(ctClass));
			_ = null;
			return result4;
		}
		Type result5 = new Type(ctClass);
		_ = null;
		return result5;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 221, 103, 102, 103, 106, 100, 105, 139, 104 })]
	internal virtual string arrayName(string P_0, int P_1)
	{
		int num = java.lang.String.instancehelper_length(P_0);
		int num2 = num + P_1 * 2;
		char[] array = new char[num2];
		java.lang.String.instancehelper_getChars(P_0, 0, num, array, 0);
		while (num < num2)
		{
			int num3 = num;
			num++;
			array[num3] = '[';
			int num4 = num;
			num++;
			array[num4] = ']';
		}
		P_0 = java.lang.String.newhelper(array);
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 234, 108 })]
	private ClassPool getClassPool(Type P_0)
	{
		ClassPool classPool = P_0.clazz.getClassPool();
		ClassPool result = ((classPool == null) ? ClassPool.getDefault() : classPool);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 196, 104, 138 })]
	internal virtual Type getRootComponent(Type P_0)
	{
		while (P_0.isArray())
		{
			P_0 = P_0.getComponent();
		}
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 89, 138, 108, 105, 98, 107, 101, 166 })]
	public virtual int getDimensions()
	{
		if (!isArray())
		{
			return 0;
		}
		string name = clazz.getName();
		int num = java.lang.String.instancehelper_length(name) - 1;
		int num2 = 0;
		while (java.lang.String.instancehelper_charAt(name, num) == ']')
		{
			num += -2;
			num2++;
		}
		return num2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 203, 104, 146, 211, 191, 6, 2, 97, 172 })]
	private Type createArray(Type P_0, int P_1)
	{
		if (P_0 is MultiType)
		{
			MultiArrayType.___003Cclinit_003E();
			return new MultiArrayType((MultiType)P_0, P_1);
		}
		string classname = arrayName(P_0.clazz.getName(), P_1);
		NotFoundException ex;
		try
		{
			return get(getClassPool(P_0).get(classname));
		}
		catch (NotFoundException x)
		{
			ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		NotFoundException cause = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(cause);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(580)]
	internal static bool eq(CtClass P_0, CtClass P_1)
	{
		return (P_0 == P_1 || (P_0 != null && P_1 != null && java.lang.String.instancehelper_equals(P_0.getName(), P_1.getName()))) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		161, 19, 98, 98, 98, 226, 69, 113, 130, 104,
		136, 132, 98, 162, 132, 98, 98, 130, 98, 98,
		162, 99, 99, 197, 103, 99, 130, 169, 194, 105,
		103, 169
	})]
	private static CtClass findCommonSuperClass(CtClass P_0, CtClass P_1)
	{
		CtClass ctClass = P_0;
		CtClass ctClass2 = P_1;
		CtClass ctClass3 = ctClass2;
		CtClass ctClass4 = ctClass;
		while (true)
		{
			if (eq(ctClass, ctClass2) && ctClass.getSuperclass() != null)
			{
				return ctClass;
			}
			CtClass superclass = ctClass.getSuperclass();
			CtClass superclass2 = ctClass2.getSuperclass();
			if (superclass2 == null)
			{
				ctClass2 = ctClass3;
				break;
			}
			if (superclass == null)
			{
				ctClass = ctClass4;
				ctClass4 = ctClass3;
				ctClass3 = ctClass;
				ctClass = ctClass2;
				ctClass2 = ctClass3;
				break;
			}
			ctClass = superclass;
			ctClass2 = superclass2;
		}
		while (true)
		{
			ctClass = ctClass.getSuperclass();
			if (ctClass == null)
			{
				break;
			}
			ctClass4 = ctClass4.getSuperclass();
		}
		ctClass = ctClass4;
		while (!eq(ctClass, ctClass2))
		{
			ctClass = ctClass.getSuperclass();
			ctClass2 = ctClass2.getSuperclass();
		}
		return ctClass;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/analysis/Type;)Ljava/util/Map<Ljava/lang/String;Ljavassist/CtClass;>;")]
	[LineNumberTable(new byte[] { 161, 100, 110, 142 })]
	private Map findCommonInterfaces(Type P_0)
	{
		Map allInterfaces = getAllInterfaces(P_0.clazz, null);
		Map allInterfaces2 = getAllInterfaces(clazz, null);
		Map result = findCommonInterfaces(allInterfaces, allInterfaces2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/analysis/Type;Ljavassist/CtClass;)Ljava/util/Map<Ljava/lang/String;Ljavassist/CtClass;>;")]
	[LineNumberTable(new byte[] { 161, 107, 110, 110, 137, 127, 2, 105, 105, 130 })]
	private Map findExclusiveDeclaredInterfaces(Type P_0, CtClass P_1)
	{
		Map declaredInterfaces = getDeclaredInterfaces(P_0.clazz, null);
		Map declaredInterfaces2 = getDeclaredInterfaces(clazz, null);
		Map allInterfaces = getAllInterfaces(P_1, null);
		Iterator iterator = allInterfaces.keySet().iterator();
		while (iterator.hasNext())
		{
			string key = (string)iterator.next();
			declaredInterfaces.remove(key);
			declaredInterfaces2.remove(key);
		}
		Map result = findCommonInterfaces(declaredInterfaces, declaredInterfaces2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/CtClass;Ljava/util/Map<Ljava/lang/String;Ljavassist/CtClass;>;)Ljava/util/Map<Ljava/lang/String;Ljavassist/CtClass;>;")]
	[LineNumberTable(new byte[]
	{
		159, 12, 130, 104, 134, 104, 191, 6, 103, 123,
		127, 8, 29, 235, 69, 188, 2, 98, 141, 134
	})]
	internal virtual Map getAllInterfaces(CtClass P_0, Map P_1)
	{
		object obj = P_1;
		if ((Map)obj == null)
		{
			obj = new HashMap();
		}
		if (P_0.isInterface())
		{
			object obj2 = obj;
			string name = P_0.getName();
			object value = P_0;
			object key = name;
			((obj2 == null) ? null : ((obj2 as Map) ?? throw new java.lang.IncompatibleClassChangeError())).put(key, value);
		}
		do
		{
			NotFoundException ex;
			try
			{
				CtClass[] interfaces = P_0.getInterfaces();
				CtClass[] array = interfaces;
				int num = array.Length;
				for (int i = 0; i < num; i++)
				{
					CtClass ctClass = array[i];
					object obj3 = obj;
					string name2 = ctClass.getName();
					object value = ctClass;
					object key = name2;
					((obj3 == null) ? null : ((obj3 as Map) ?? throw new java.lang.IncompatibleClassChangeError())).put(key, value);
					object obj4 = obj;
					getAllInterfaces(ctClass, (obj4 == null) ? null : ((obj4 as Map) ?? throw new java.lang.IncompatibleClassChangeError()));
				}
				P_0 = P_0.getSuperclass();
			}
			catch (NotFoundException x)
			{
				ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_00c6;
			}
			continue;
			IL_00c6:
			NotFoundException cause = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException(cause);
		}
		while (P_0 != null);
		object obj5 = obj;
		return (obj5 == null) ? null : ((obj5 as Map) ?? throw new java.lang.IncompatibleClassChangeError());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/util/Map<Ljava/lang/String;Ljavassist/CtClass;>;Ljava/util/Map<Ljava/lang/String;Ljavassist/CtClass;>;)Ljava/util/Map<Ljava/lang/String;Ljavassist/CtClass;>;")]
	[LineNumberTable(new byte[]
	{
		159, 20, 162, 104, 134, 107, 153, 127, 0, 104,
		108, 105, 102, 226, 69, 102, 159, 24, 191, 8,
		2, 98, 141, 98, 127, 0, 159, 8
	})]
	internal virtual Map findCommonInterfaces(Map P_0, Map P_1)
	{
		object obj = P_1;
		if ((Map)obj == null)
		{
			obj = new HashMap();
		}
		if (P_0 == null || P_0.isEmpty())
		{
			object obj2 = obj;
			((obj2 == null) ? null : ((obj2 as Map) ?? throw new java.lang.IncompatibleClassChangeError())).clear();
		}
		object obj3 = obj;
		Iterator iterator = ((obj3 == null) ? null : ((obj3 as Map) ?? throw new java.lang.IncompatibleClassChangeError())).keySet().iterator();
		while (iterator.hasNext())
		{
			string key = (string)iterator.next();
			if (!P_0.containsKey(key))
			{
				iterator.remove();
			}
		}
		ArrayList arrayList = new ArrayList();
		object obj4 = obj;
		Iterator iterator2 = ((obj4 == null) ? null : ((obj4 as Map) ?? throw new java.lang.IncompatibleClassChangeError())).values().iterator();
		while (iterator2.hasNext())
		{
			CtClass ctClass = (CtClass)iterator2.next();
			NotFoundException ex;
			try
			{
				((Collection)arrayList).addAll((Collection)Arrays.asList(ctClass.getInterfaces()));
			}
			catch (NotFoundException x)
			{
				ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_00d8;
			}
			continue;
			IL_00d8:
			NotFoundException cause = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException(cause);
		}
		iterator2 = ((Collection)arrayList).iterator();
		while (iterator2.hasNext())
		{
			CtClass ctClass = (CtClass)iterator2.next();
			object obj5 = obj;
			object name = ctClass.getName();
			((obj5 == null) ? null : ((obj5 as Map) ?? throw new java.lang.IncompatibleClassChangeError())).remove(name);
		}
		object obj6 = obj;
		return (obj6 == null) ? null : ((obj6 as Map) ?? throw new java.lang.IncompatibleClassChangeError());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/CtClass;Ljava/util/Map<Ljava/lang/String;Ljavassist/CtClass;>;)Ljava/util/Map<Ljava/lang/String;Ljavassist/CtClass;>;")]
	[LineNumberTable(new byte[]
	{
		159, 6, 98, 104, 134, 104, 223, 6, 187, 2,
		98, 173, 123, 127, 8, 29, 235, 69
	})]
	internal virtual Map getDeclaredInterfaces(CtClass P_0, Map P_1)
	{
		object obj = P_1;
		if ((Map)obj == null)
		{
			obj = new HashMap();
		}
		if (P_0.isInterface())
		{
			object obj2 = obj;
			string name = P_0.getName();
			object value = P_0;
			object key = name;
			((obj2 == null) ? null : ((obj2 as Map) ?? throw new java.lang.IncompatibleClassChangeError())).put(key, value);
		}
		CtClass[] interfaces;
		NotFoundException ex;
		try
		{
			interfaces = P_0.getInterfaces();
		}
		catch (NotFoundException x)
		{
			ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0054;
		}
		CtClass[] array = interfaces;
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			CtClass ctClass = array[i];
			object obj3 = obj;
			string name2 = ctClass.getName();
			object value = ctClass;
			object key = name2;
			((obj3 == null) ? null : ((obj3 as Map) ?? throw new java.lang.IncompatibleClassChangeError())).put(key, value);
			object obj4 = obj;
			getDeclaredInterfaces(ctClass, (obj4 == null) ? null : ((obj4 as Map) ?? throw new java.lang.IncompatibleClassChangeError()));
		}
		object obj5 = obj;
		return (obj5 == null) ? null : ((obj5 as Map) ?? throw new java.lang.IncompatibleClassChangeError());
		IL_0054:
		NotFoundException cause = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(cause);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 79, 127, 7, 97 })]
	private static Type lookupType(string P_0)
	{
		//Discarded unreachable code: IL_0012
		NotFoundException ex;
		try
		{
			return new Type(ClassPool.getDefault().get(P_0));
		}
		catch (NotFoundException x)
		{
			ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		NotFoundException cause = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(cause);
	}

	public virtual bool isSpecial()
	{
		return special;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(568)]
	public override int hashCode()
	{
		return java.lang.Object.instancehelper_hashCode(java.lang.Object.instancehelper_getClass(this)) + java.lang.Object.instancehelper_hashCode(clazz);
	}

	[LineNumberTable(new byte[]
	{
		159, 185, 138, 143, 143, 143, 143, 143, 143, 143,
		143, 239, 75, 235, 70, 172, 236, 73, 172, 143,
		143, 143, 175, 117, 117, 117, 117, 117, 117, 117,
		117, 149
	})]
	static Type()
	{
		prims = new IdentityHashMap();
		___003C_003EDOUBLE = new Type(CtClass.doubleType);
		___003C_003EBOOLEAN = new Type(CtClass.booleanType);
		___003C_003ELONG = new Type(CtClass.longType);
		___003C_003ECHAR = new Type(CtClass.charType);
		___003C_003EBYTE = new Type(CtClass.byteType);
		___003C_003ESHORT = new Type(CtClass.shortType);
		___003C_003EINTEGER = new Type(CtClass.intType);
		___003C_003EFLOAT = new Type(CtClass.floatType);
		___003C_003EVOID = new Type(CtClass.voidType);
		___003C_003EUNINIT = new Type(null);
		___003C_003ERETURN_ADDRESS = new Type(null, true);
		___003C_003ETOP = new Type(null, true);
		___003C_003EBOGUS = new Type(null, true);
		___003C_003EOBJECT = lookupType("java.lang.Object");
		___003C_003ESERIALIZABLE = lookupType("java.io.Serializable");
		___003C_003ECLONEABLE = lookupType("java.lang.Cloneable");
		___003C_003ETHROWABLE = lookupType("java.lang.Throwable");
		prims.put(CtClass.doubleType, ___003C_003EDOUBLE);
		prims.put(CtClass.longType, ___003C_003ELONG);
		prims.put(CtClass.charType, ___003C_003ECHAR);
		prims.put(CtClass.shortType, ___003C_003ESHORT);
		prims.put(CtClass.intType, ___003C_003EINTEGER);
		prims.put(CtClass.floatType, ___003C_003EFLOAT);
		prims.put(CtClass.byteType, ___003C_003EBYTE);
		prims.put(CtClass.booleanType, ___003C_003EBOOLEAN);
		prims.put(CtClass.voidType, ___003C_003EVOID);
	}
}
