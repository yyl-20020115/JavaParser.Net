using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.lang.reflect;
using java.util;

namespace com.google.common.collect;

[ConstantPool(new object[]
{
	(byte)70,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal sealed class Serialization : Object
{
	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal class _1 : Object
	{
		_1()
		{
			throw null;
		}
	}

	[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;")]
	internal sealed class FieldSetter : Object
	{
		private sealed class ___003CCallerID_003E : CallerID
		{
			internal ___003CCallerID_003E()
			{
			}
		}

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private Field field;

		[SpecialName]
		private static CallerID ___003CcallerID_003E;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TT;Ljava/lang/Object;)V")]
		[LineNumberTable(new byte[] { 160, 96, 191, 5, 2, 97, 140 })]
		internal virtual void set(object P_0, object P_1)
		{
			IllegalAccessException ex;
			try
			{
				field.set(P_0, P_1, FieldSetter.___003CGetCallerID_003E());
				return;
			}
			catch (IllegalAccessException x)
			{
				ex = ByteCodeHelper.MapException<IllegalAccessException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			IllegalAccessException detailMessage = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError(detailMessage);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TT;I)V")]
		[LineNumberTable(new byte[] { 160, 104, 191, 10, 2, 97, 140 })]
		internal virtual void set(object P_0, int P_1)
		{
			IllegalAccessException ex;
			try
			{
				field.set(P_0, Integer.valueOf(P_1), FieldSetter.___003CGetCallerID_003E());
				return;
			}
			catch (IllegalAccessException x)
			{
				ex = ByteCodeHelper.MapException<IllegalAccessException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			IllegalAccessException detailMessage = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError(detailMessage);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(200)]
		internal FieldSetter(Field P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 89, 104, 103, 105 })]
		private FieldSetter(Field P_0)
		{
			field = P_0;
			P_0.setAccessible(flag: true);
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

	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/Multimap<TK;TV;>;Ljava/io/ObjectOutputStream;)V")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 70, 0, 0,
		18, 1, 0, 0, 0, 70, 0, 0
	})]
	[LineNumberTable(new byte[]
	{
		97, 113, 127, 9, 108, 118, 127, 1, 103, 98,
		101
	})]
	internal static void writeMultimap(Multimap P_0, ObjectOutputStream P_1)
	{
		P_1.writeInt(P_0.asMap().size());
		Iterator iterator = P_0.asMap().entrySet().iterator();
		while (iterator.hasNext())
		{
			Map.Entry entry = (Map.Entry)iterator.next();
			P_1.writeObject(entry.getKey());
			P_1.writeInt(((Collection)entry.getValue()).size());
			Iterator iterator2 = ((Collection)entry.getValue()).iterator();
			while (iterator2.hasNext())
			{
				object obj = iterator2.next();
				P_1.writeObject(obj);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(49)]
	internal static int readCount(ObjectInputStream P_0)
	{
		int result = P_0.readInt();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "java.lang.ClassNotFoundException" })]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/Multimap<TK;TV;>;Ljava/io/ObjectInputStream;I)V")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 70, 0, 0,
		18, 1, 0, 0, 0, 70, 0, 0
	})]
	[LineNumberTable(new byte[]
	{
		126, 134, 103, 104, 103, 136, 104, 233, 61, 232,
		59, 230, 75
	})]
	internal static void populateMultimap(Multimap P_0, ObjectInputStream P_1, int P_2)
	{
		for (int i = 0; i < P_2; i++)
		{
			object obj = P_1.readObject();
			Collection collection = P_0.get(obj);
			int num = P_1.readInt();
			for (int j = 0; j < num; j++)
			{
				object e = P_1.readObject();
				collection.add(e);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Class<TT;>;Ljava/lang/String;)Lcom/google/common/collect/Serialization$FieldSetter<TT;>;")]
	[LineNumberTable(new byte[] { 160, 78, 109, 125, 97 })]
	internal static FieldSetter getFieldSetter(Class P_0, string P_1)
	{
		//Discarded unreachable code: IL_0016
		NoSuchFieldException ex;
		try
		{
			Field declaredField = P_0.getDeclaredField(P_1, Serialization.___003CGetCallerID_003E());
			return new FieldSetter(declaredField, null);
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
	[Throws(new string[] { "java.io.IOException" })]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map<TK;TV;>;Ljava/io/ObjectOutputStream;)V")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 70, 0, 0,
		18, 1, 0, 0, 0, 70, 0, 0
	})]
	[LineNumberTable(new byte[] { 11, 108, 127, 1, 108, 108, 98 })]
	internal static void writeMap(Map P_0, ObjectOutputStream P_1)
	{
		P_1.writeInt(P_0.size());
		Iterator iterator = P_0.entrySet().iterator();
		while (iterator.hasNext())
		{
			Map.Entry entry = (Map.Entry)iterator.next();
			P_1.writeObject(entry.getKey());
			P_1.writeObject(entry.getValue());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "java.lang.ClassNotFoundException" })]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map<TK;TV;>;Ljava/io/ObjectInputStream;)V")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 70, 0, 0,
		18, 1, 0, 0, 0, 70, 0, 0
	})]
	[LineNumberTable(new byte[] { 24, 103, 106 })]
	internal static void populateMap(Map P_0, ObjectInputStream P_1)
	{
		int num = P_1.readInt();
		populateMap(P_0, P_1, num);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[Signature("<E:Ljava/lang/Object;>(Lcom/google/common/collect/Multiset<TE;>;Ljava/io/ObjectOutputStream;)V")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 70, 0, 0 })]
	[LineNumberTable(new byte[] { 53, 108, 103, 127, 1, 108, 108, 98 })]
	internal static void writeMultiset(Multiset P_0, ObjectOutputStream P_1)
	{
		int val = P_0.entrySet().size();
		P_1.writeInt(val);
		Iterator iterator = P_0.entrySet().iterator();
		while (iterator.hasNext())
		{
			Multiset.Entry entry = (Multiset.Entry)iterator.next();
			P_1.writeObject(entry.getElement());
			P_1.writeInt(entry.getCount());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "java.lang.ClassNotFoundException" })]
	[Signature("<E:Ljava/lang/Object;>(Lcom/google/common/collect/Multiset<TE;>;Ljava/io/ObjectInputStream;)V")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 70, 0, 0 })]
	[LineNumberTable(new byte[] { 67, 103, 106 })]
	internal static void populateMultiset(Multiset P_0, ObjectInputStream P_1)
	{
		int num = P_1.readInt();
		populateMultiset(P_0, P_1, num);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "java.lang.ClassNotFoundException" })]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map<TK;TV;>;Ljava/io/ObjectInputStream;I)V")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 70, 0, 0,
		18, 1, 0, 0, 0, 70, 0, 0
	})]
	[LineNumberTable(new byte[] { 35, 134, 135, 103, 233, 59, 230, 71 })]
	internal static void populateMap(Map P_0, ObjectInputStream P_1, int P_2)
	{
		for (int i = 0; i < P_2; i++)
		{
			object key = P_1.readObject();
			object value = P_1.readObject();
			P_0.put(key, value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "java.lang.ClassNotFoundException" })]
	[Signature("<E:Ljava/lang/Object;>(Lcom/google/common/collect/Multiset<TE;>;Ljava/io/ObjectInputStream;I)V")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 70, 0, 0 })]
	[LineNumberTable(new byte[] { 79, 134, 103, 103, 233, 60, 230, 70 })]
	internal static void populateMultiset(Multiset P_0, ObjectInputStream P_1, int P_2)
	{
		for (int i = 0; i < P_2; i++)
		{
			object obj = P_1.readObject();
			int i2 = P_1.readInt();
			P_0.add(obj, i2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(39)]
	private Serialization()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "java.lang.ClassNotFoundException" })]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/Multimap<TK;TV;>;Ljava/io/ObjectInputStream;)V")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 70, 0, 0,
		18, 1, 0, 0, 0, 70, 0, 0
	})]
	[LineNumberTable(new byte[] { 114, 103, 106 })]
	internal static void populateMultimap(Multimap P_0, ObjectInputStream P_1)
	{
		int num = P_1.readInt();
		populateMultimap(P_0, P_1, num);
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
