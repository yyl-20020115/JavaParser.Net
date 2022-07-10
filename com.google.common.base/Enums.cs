using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.lang.@ref;
using java.lang.reflect;
using java.util;
using javax.annotation;

namespace com.google.common.@base;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
public sealed class Enums : java.lang.Object
{
	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<T:Ljava/lang/Enum<TT;>;>Lcom/google/common/base/Converter<Ljava/lang/String;TT;>;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.io.Serializable" })]
	internal sealed class StringConverter : Converter, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/lang/Class<TT;>;")]
		private Class enumClass;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TT;)Ljava/lang/String;")]
		[LineNumberTable(128)]
		protected internal virtual string doBackward(java.lang.Enum P_0)
		{
			string result = P_0.name();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/String;)TT;")]
		[LineNumberTable(123)]
		protected internal virtual java.lang.Enum doForward(string P_0)
		{
			java.lang.Enum result = java.lang.Enum.valueOf(enumClass, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Class<TT;>;)V")]
		[LineNumberTable(new byte[] { 67, 104, 113 })]
		internal StringConverter(Class P_0)
		{
			enumClass = (Class)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 83, 104, 103, 148 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is StringConverter)
			{
				StringConverter stringConverter = (StringConverter)P_0;
				bool result = java.lang.Object.instancehelper_equals(enumClass, stringConverter.enumClass);
				_ = null;
				return result;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(142)]
		public override int hashCode()
		{
			int result = java.lang.Object.instancehelper_hashCode(enumClass);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(147)]
		public override string toString()
		{
			string name = enumClass.getName();
			int num = 29 + java.lang.String.instancehelper_length(java.lang.String.valueOf(name));
			num = num;
			string result = new StringBuilder(num).append("Enums.stringConverter(").append(name).append(".class)")
				.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(112)]
		protected internal override object doBackward(object P_0)
		{
			string result = doBackward((java.lang.Enum)P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(112)]
		protected internal override object doForward(object P_0)
		{
			java.lang.Enum result = doForward((string)P_0);
			_ = null;
			return result;
		}

		[SecurityCritical]
		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		void ISerializable.GetObjectData(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.writeObject(this, P_0);
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected StringConverter(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Ljava/util/Map<Ljava/lang/Class<+Ljava/lang/Enum<*>;>;Ljava/util/Map<Ljava/lang/String;Ljava/lang/ref/WeakReference<+Ljava/lang/Enum<*>;>;>;>;")]
	private static Map enumConstantCache;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Enum<TT;>;>(Ljava/lang/Class<TT;>;)Ljava/util/Map<Ljava/lang/String;Ljava/lang/ref/WeakReference<+Ljava/lang/Enum<*>;>;>;")]
	[LineNumberTable(new byte[] { 30, 102, 127, 1, 115, 98, 109 })]
	private static Map populateCache(Class P_0)
	{
		HashMap hashMap = new HashMap();
		Iterator iterator = EnumSet.allOf(P_0).iterator();
		while (iterator.hasNext())
		{
			java.lang.Enum @enum = (java.lang.Enum)iterator.next();
			((Map)hashMap).put((object)@enum.name(), (object)new java.lang.@ref.WeakReference(@enum));
		}
		enumConstantCache.put(P_0, hashMap);
		return hashMap;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(40)]
	private Enums()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Enum<*>;)Ljava/lang/reflect/Field;")]
	[LineNumberTable(new byte[] { 1, 135, 127, 8, 97 })]
	public static Field getField(java.lang.Enum enumValue)
	{
		//Discarded unreachable code: IL_001a
		Class declaringClass = enumValue.getDeclaringClass();
		NoSuchFieldException ex;
		try
		{
			return declaringClass.getDeclaredField(enumValue.name(), Enums.___003CGetCallerID_003E());
		}
		catch (NoSuchFieldException x)
		{
			ex = ByteCodeHelper.MapException<NoSuchFieldException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		NoSuchFieldException detailMessage = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new AssertionError(detailMessage);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Enum<TT;>;>(Ljava/lang/Class<TT;>;Ljava/lang/String;)Lcom/google/common/base/Optional<TT;>;")]
	[LineNumberTable(new byte[] { 18, 103, 103 })]
	public static Optional getIfPresent(Class enumClass, string value)
	{
		Preconditions.checkNotNull(enumClass);
		Preconditions.checkNotNull(value);
		Optional enumIfPresent = Platform.getEnumIfPresent(enumClass, value);
		_ = null;
		return enumIfPresent;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Enum<TT;>;>(Ljava/lang/Class<TT;>;)Ljava/util/Map<Ljava/lang/String;Ljava/lang/ref/WeakReference<+Ljava/lang/Enum<*>;>;>;")]
	[LineNumberTable(new byte[] { 41, 108, 113, 99, 135, 103 })]
	internal static Map getEnumConstants(Class P_0)
	{
		//Discarded unreachable code: IL_002a
		lock (enumConstantCache)
		{
			Map map = (Map)enumConstantCache.get(P_0);
			if (map == null)
			{
				map = populateCache(P_0);
			}
			return map;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Enum<TT;>;>(Ljava/lang/Class<TT;>;)Lcom/google/common/base/Converter<Ljava/lang/String;TT;>;")]
	[LineNumberTable(109)]
	public static Converter stringConverter(Class enumClass)
	{
		StringConverter result = new StringConverter(enumClass);
		_ = null;
		return result;
	}

	[LineNumberTable(75)]
	static Enums()
	{
		enumConstantCache = new WeakHashMap();
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
