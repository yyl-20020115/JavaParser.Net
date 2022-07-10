using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.google.common.collect;

[ConstantPool(new object[]
{
	(byte)30,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public sealed class MoreCollectors : Object
{
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[ConstantPool(new object[]
	{
		(byte)42,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal sealed class ToOptionalState : Object
	{
		internal const int MAX_EXTRAS = 4;

		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 0, 42, 0, 0 })]
		internal object element;

		[Signature("Ljava/util/List<Ljava/lang/Object;>;")]
		internal List extras;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			159, 116, 98, 106, 113, 123, 114, 98, 99, 140,
			105
		})]
		internal virtual IllegalArgumentException multiples(bool P_0)
		{
			StringBuilder stringBuilder = new StringBuilder().append("expected one element but was: <").append(element);
			Iterator iterator = extras.iterator();
			while (iterator.hasNext())
			{
				object obj = iterator.next();
				stringBuilder.append(", ").append(obj);
			}
			if (P_0)
			{
				stringBuilder.append(", ...");
			}
			stringBuilder.append('>');
			string s = stringBuilder.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 49, 104, 103, 107 })]
		internal ToOptionalState()
		{
			element = null;
			extras = Collections.emptyList();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 68, 103, 104, 105, 141, 108, 111, 110, 143, 141 })]
		internal virtual void add(object P_0)
		{
			Preconditions.checkNotNull(P_0);
			if (element == null)
			{
				element = P_0;
				return;
			}
			if (extras.isEmpty())
			{
				extras = new ArrayList(4);
				extras.add(P_0);
				return;
			}
			if (extras.size() < 4)
			{
				extras.add(P_0);
				return;
			}
			throw Throwable.___003Cunmap_003E(multiples(true));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			83, 104, 98, 104, 130, 141, 139, 114, 114, 110,
			124, 141
		})]
		internal virtual ToOptionalState combine(ToOptionalState P_0)
		{
			if (element == null)
			{
				return P_0;
			}
			if (P_0.element == null)
			{
				return this;
			}
			if (extras.isEmpty())
			{
				extras = new ArrayList();
			}
			extras.add(P_0.element);
			extras.addAll(P_0.extras);
			if (extras.size() > 4)
			{
				extras.subList(4, extras.size()).clear();
				throw Throwable.___003Cunmap_003E(multiples(true));
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Optional<Ljava/lang/Object;>;")]
		[LineNumberTable(new byte[] { 103, 109, 142 })]
		internal virtual java.util.Optional getOptional()
		{
			if (extras.isEmpty())
			{
				java.util.Optional result = java.util.Optional.ofNullable(element);
				_ = null;
				return result;
			}
			throw Throwable.___003Cunmap_003E(multiples(false));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 111, 104, 107, 109, 135 })]
		internal virtual object getElement()
		{
			if (element == null)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new NoSuchElementException();
			}
			if (extras.isEmpty())
			{
				return element;
			}
			throw Throwable.___003Cunmap_003E(multiples(false));
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon0 : java.util.function.Supplier
	{
		internal ___003C_003EAnon0()
		{
		}

		public object get()
		{
			ToOptionalState result = new ToOptionalState();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon1 : BiConsumer
	{
		internal ___003C_003EAnon1()
		{
		}

		public void accept(object P_0, object P_1)
		{
			((ToOptionalState)P_0).add(P_1);
			_ = null;
		}

		[SpecialName]
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon2 : BinaryOperator
	{
		internal ___003C_003EAnon2()
		{
		}

		public object apply(object P_0, object P_1)
		{
			ToOptionalState result = ((ToOptionalState)P_0).combine((ToOptionalState)P_1);
			_ = null;
			return result;
		}

		[SpecialName]
		public BiFunction andThen(java.util.function.Function P_0)
		{
			return BiFunction._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon3 : java.util.function.Function
	{
		internal ___003C_003EAnon3()
		{
		}

		public object apply(object P_0)
		{
			java.util.Optional optional = ((ToOptionalState)P_0).getOptional();
			_ = null;
			return optional;
		}

		[SpecialName]
		public java.util.function.Function compose(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
		}

		[SpecialName]
		public java.util.function.Function andThen(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon4 : BiConsumer
	{
		internal ___003C_003EAnon4()
		{
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024static_00240((ToOptionalState)P_0, P_1);
			_ = null;
		}

		[SpecialName]
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon5 : java.util.function.Function
	{
		internal ___003C_003EAnon5()
		{
		}

		public object apply(object P_0)
		{
			object result = lambda_0024static_00241((ToOptionalState)P_0);
			_ = null;
			return result;
		}

		[SpecialName]
		public java.util.function.Function compose(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
		}

		[SpecialName]
		public java.util.function.Function andThen(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Ljava/util/stream/Collector<Ljava/lang/Object;*Ljava/util/Optional<Ljava/lang/Object;>;>;")]
	private static Collector TO_OPTIONAL;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static object NULL_PLACEHOLDER;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Ljava/util/stream/Collector<Ljava/lang/Object;*Ljava/lang/Object;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 19, 1, 3, 0, 0, 30, 0, 0,
		19, 1, 3, 2, 0, 30, 0, 0
	})]
	private static Collector ONLY_ELEMENT;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(71)]
	private static void lambda_0024static_00240(ToOptionalState P_0, object P_1)
	{
		P_0.add((P_1 != null) ? P_1 : NULL_PLACEHOLDER);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(new byte[] { 24, 103 })]
	private static object lambda_0024static_00241(ToOptionalState P_0)
	{
		object element = P_0.getElement();
		return (element != NULL_PLACEHOLDER) ? element : null;
	}

	[Signature("<T:Ljava/lang/Object;>()Ljava/util/stream/Collector<TT;*Ljava/util/Optional<TT;>;>;")]
	public static Collector toOptional()
	{
		return TO_OPTIONAL;
	}

	[Signature("<T:Ljava/lang/Object;>()Ljava/util/stream/Collector<TT;*TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 30, 0, 0 })]
	public static Collector onlyElement()
	{
		return ONLY_ELEMENT;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(171)]
	private MoreCollectors()
	{
	}

	[LineNumberTable(new byte[] { 159, 187, 127, 23, 234, 84, 138, 127, 23, 42 })]
	static MoreCollectors()
	{
		TO_OPTIONAL = Collector.of(new ___003C_003EAnon0(), new ___003C_003EAnon1(), new ___003C_003EAnon2(), new ___003C_003EAnon3(), Collector.Characteristics.UNORDERED);
		NULL_PLACEHOLDER = new Object();
		ONLY_ELEMENT = Collector.of(new ___003C_003EAnon0(), new ___003C_003EAnon4(), new ___003C_003EAnon2(), new ___003C_003EAnon5(), Collector.Characteristics.UNORDERED);
	}
}
