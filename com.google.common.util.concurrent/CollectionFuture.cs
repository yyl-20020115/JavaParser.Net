using System.Runtime.CompilerServices;
using com.google.common.collect;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.util.concurrent;

[Signature("<V:Ljava/lang/Object;C:Ljava/lang/Object;>Lcom/google/common/util/concurrent/AggregateFuture<TV;TC;>;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 27, 0, 0,
	17, 1, 0, 0, 0, 27, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)27,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
internal abstract class CollectionFuture : AggregateFuture
{
	[Signature("<V:Ljava/lang/Object;>Lcom/google/common/util/concurrent/CollectionFuture<TV;Ljava/util/List<TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0,
		2,
		16,
		byte.MaxValue,
		byte.MaxValue,
		2,
		3,
		1,
		3,
		0,
		0,
		49,
		0,
		0,
		17,
		0,
		0,
		0,
		0,
		49,
		0,
		0
	})]
	[ConstantPool(new object[]
	{
		(byte)49,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal sealed class ListFuture : CollectionFuture
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/List<Lcom/google/common/util/concurrent/CollectionFuture$Present<TV;>;>;)Ljava/util/List<TV;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 2, 20, 1, 3, 0, 0, 49, 0, 0,
			22, 0, 1, 3, 0, 0, 49, 0, 0
		})]
		[LineNumberTable(new byte[] { 45, 108, 123, 115, 98 })]
		public new virtual List combine(List P_0)
		{
			ArrayList arrayList = Lists.newArrayListWithCapacity(P_0.size());
			Iterator iterator = P_0.iterator();
			while (iterator.hasNext())
			{
				((List)arrayList).add(((Present)iterator.next())?.value);
			}
			List result = Collections.unmodifiableList(arrayList);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableCollection<+Lcom/google/common/util/concurrent/ListenableFuture<+TV;>;>;Z)V")]
		[LineNumberTable(new byte[] { 159, 120, 98, 106, 104 })]
		internal ListFuture(ImmutableCollection P_0, bool P_1)
			: base(P_0, P_1)
		{
			init();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 2, 20, 1, 3, 0, 0, 49, 0, 0,
			22, 0, 1, 3, 0, 0, 49, 0, 0
		})]
		[LineNumberTable(84)]
		public override object combine(List P_0)
		{
			List result = combine(P_0);
			_ = null;
			return result;
		}

		[HideFromJava]
		static ListFuture()
		{
			CollectionFuture.___003Cclinit_003E();
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<V:Ljava/lang/Object;>Ljava/lang/Object;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 25, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)25,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal sealed class Present : Object
	{
		[Signature("TV;")]
		internal object value;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV;)V")]
		[LineNumberTable(new byte[] { 57, 104, 103 })]
		internal Present(object P_0)
		{
			value = P_0;
		}
	}

	[Signature("Ljava/util/List<Lcom/google/common/util/concurrent/CollectionFuture$Present<TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 1, 3, 0, 0, 27, 0, 0 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private List values;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	protected internal new static void ___003Cclinit_003E()
	{
	}

	[Signature("(Ljava/util/List<Lcom/google/common/util/concurrent/CollectionFuture$Present<TV;>;>;)TC;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 0, 1, 3, 0, 0, 27, 0,
		0
	})]
	internal abstract object combine(List P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/ImmutableCollection<+Lcom/google/common/util/concurrent/ListenableFuture<+TV;>;>;Z)V")]
	[LineNumberTable(new byte[]
	{
		159, 131, 66, 171, 104, 103, 172, 107, 63, 0,
		198, 122
	})]
	internal CollectionFuture(ImmutableCollection P_0, bool P_1)
		: base(P_0, P_1, true)
	{
		object obj = ((!P_0.isEmpty()) ? Lists.newArrayListWithCapacity(P_0.size()) : Collections.emptyList());
		for (int i = 0; i < P_0.size(); i++)
		{
			object e = null;
			((obj == null) ? null : ((obj as List) ?? throw new java.lang.IncompatibleClassChangeError())).add(e);
		}
		values = ((obj == null) ? null : ((obj as List) ?? throw new java.lang.IncompatibleClassChangeError()));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(ITV;)V")]
	[LineNumberTable(new byte[] { 11, 103, 99, 142 })]
	internal sealed override void collectOneValue(int P_0, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})] object P_1)
	{
		values?.set(P_0, new Present(P_1));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 19, 103, 99, 142 })]
	internal sealed override void handleAllCompleted()
	{
		List list = values;
		if (list != null)
		{
			set(combine(list));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 27, 103, 103 })]
	internal override void releaseResources(ReleaseResourcesReason P_0)
	{
		base.releaseResources(P_0);
		values = null;
	}

	[HideFromJava]
	static CollectionFuture()
	{
		AggregateFuture.___003Cclinit_003E();
	}
}
