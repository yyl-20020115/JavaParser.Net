using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<E:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Collection<TE;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 99, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)99,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.util.Collection" })]
public interface Multiset : Collection, Iterable
{
	[Signature("<E:Ljava/lang/Object;>Ljava/lang/Object;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 22, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)22,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	public interface Entry
	{
		[Signature("()TE;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		virtual object getElement();

		virtual int getCount();

		virtual bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object obj);

		virtual int hashCode();

		virtual string toString();
	}

	private static class ___003C_003EPIM
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(345)]
		internal static void lambda_0024forEachEntry_00240(ObjIntConsumer P_0, Entry P_1)
		{
			P_0.accept(P_1.getElement(), P_1.getCount());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(new byte[] { 161, 99, 103, 103, 102, 39, 166 })]
		internal static void lambda_0024forEach_00241(Consumer P_0, Entry P_1)
		{
			object element = P_1.getElement();
			int count = P_1.getCount();
			for (int i = 0; i < count; i++)
			{
				P_0.accept(element);
			}
		}
	}

	[HideFromJava]
	public new static class __DefaultMethods
	{
		public unsafe static void forEachEntry(Multiset P_0, ObjIntConsumer P_1)
		{
			__ldvirtftn(object.ToString);
			_003Cdefault_003EforEachEntry(P_0, P_1);
		}

		public unsafe static void forEach(Multiset P_0, Consumer P_1)
		{
			__ldvirtftn(object.ToString);
			_003Cdefault_003EforEach(P_0, P_1);
		}

		public unsafe static Spliterator spliterator(Multiset P_0)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003Espliterator(P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon1 : Consumer
	{
		private readonly ObjIntConsumer arg_00241;

		internal ___003C_003EAnon1(ObjIntConsumer P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			___003C_003EPIM.lambda_0024forEachEntry_00240(arg_00241, (Entry)P_0);
			_ = null;
		}

		[SpecialName]
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon2 : Consumer
	{
		private readonly Consumer arg_00241;

		internal ___003C_003EAnon2(Consumer P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			___003C_003EPIM.lambda_0024forEach_00241(arg_00241, (Entry)P_0);
			_ = null;
		}

		[SpecialName]
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[Signature("()Ljava/util/Set<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
	virtual Set entrySet();

	int size();

	virtual int count([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj);

	[Signature("(TE;I)I")]
	virtual int add([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj, int i);

	[Signature("(TE;)Z")]
	bool add([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj);

	virtual int remove([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj, int i);

	bool remove([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj);

	[Signature("(TE;I)I")]
	virtual int setCount([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj, int i);

	[Signature("(TE;II)Z")]
	virtual bool setCount([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj, int i1, int i2);

	[Signature("()Ljava/util/Set<TE;>;")]
	virtual Set elementSet();

	[Modifiers(Modifiers.Public)]
	[Signature("(Ljava/util/function/ObjIntConsumer<-TE;>;)V")]
	virtual void forEachEntry(ObjIntConsumer action);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(new byte[] { 160, 230, 103, 120 })]
	static void _003Cdefault_003EforEachEntry(Multiset P_0, ObjIntConsumer P_1)
	{
		Preconditions.checkNotNull(P_1);
		P_0.entrySet().forEach(new ___003C_003EAnon1(P_1));
	}

	bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj);

	int hashCode();

	virtual string toString();

	[Signature("()Ljava/util/Iterator<TE;>;")]
	Iterator iterator();

	bool contains([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj);

	[Signature("(Ljava/util/Collection<*>;)Z")]
	bool containsAll(Collection c);

	[Signature("(Ljava/util/Collection<*>;)Z")]
	bool removeAll(Collection c);

	[Signature("(Ljava/util/Collection<*>;)Z")]
	bool retainAll(Collection c);

	[Modifiers(Modifiers.Public)]
	[Signature("(Ljava/util/function/Consumer<-TE;>;)V")]
	void forEach(Consumer action);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(new byte[] { 161, 95, 103, 113, 231, 72 })]
	static void _003Cdefault_003EforEach(Multiset P_0, Consumer P_1)
	{
		Preconditions.checkNotNull(P_1);
		P_0.entrySet().forEach(new ___003C_003EAnon2(P_1));
	}

	[Modifiers(Modifiers.Public)]
	[Signature("()Ljava/util/Spliterator<TE;>;")]
	Spliterator spliterator();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(479)]
	static Spliterator _003Cdefault_003Espliterator(Multiset P_0)
	{
		Spliterator result = Multisets.spliteratorImpl(P_0);
		_ = null;
		return result;
	}
}
