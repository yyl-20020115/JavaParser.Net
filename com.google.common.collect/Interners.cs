using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public sealed class Interners : Object
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

	public class InternerBuilder : Object
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private MapMaker mapMaker;

		private bool m_strong;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(43)]
		internal InternerBuilder(_1 P_0)
			: this()
		{
		}

		public virtual InternerBuilder strong()
		{
			this.m_strong = true;
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<E:Ljava/lang/Object;>()Lcom/google/common/collect/Interner<TE;>;")]
		[LineNumberTable(new byte[] { 31, 104, 140 })]
		public virtual Interner build()
		{
			if (!this.m_strong)
			{
				mapMaker.weakKeys();
			}
			InternerImpl result = new InternerImpl(mapMaker, null);
			_ = null;
			return result;
		}

		public virtual InternerBuilder weak()
		{
			this.m_strong = false;
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 159, 189, 232, 61, 107, 135 })]
		private InternerBuilder()
		{
			mapMaker = new MapMaker();
			this.m_strong = true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 26, 109 })]
		public virtual InternerBuilder concurrencyLevel(int concurrencyLevel)
		{
			mapMaker.concurrencyLevel(concurrencyLevel);
			return this;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<E:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/base/Function<TE;TE;>;")]
	[Implements(new string[] { "com.google.common.base.Function" })]
	internal class InternerFunction : Object, com.google.common.@base.Function, java.util.function.Function
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/Interner<TE;>;")]
		private Interner interner;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Interner<TE;>;)V")]
		[LineNumberTable(new byte[] { 118, 104, 103 })]
		public InternerFunction(Interner P_0)
		{
			interner = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)TE;")]
		[LineNumberTable(174)]
		public virtual object apply(object P_0)
		{
			object result = interner.intern(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(179)]
		public override int hashCode()
		{
			int result = Object.instancehelper_hashCode(interner);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 70, 104, 103, 180 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is InternerFunction)
			{
				InternerFunction internerFunction = (InternerFunction)P_0;
				bool result = Object.instancehelper_equals(interner, internerFunction.interner);
				_ = null;
				return result;
			}
			return false;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual java.util.function.Function compose(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual java.util.function.Function andThen(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	[Signature("<E:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/collect/Interner<TE;>;")]
	internal sealed class InternerImpl : Object, Interner
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/collect/MapMakerInternalMap<TE;Lcom/google/common/collect/MapMaker$Dummy;**>;")]
		internal MapMakerInternalMap map;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(114)]
		internal InternerImpl(MapMaker P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 68, 104, 98, 116 })]
		private InternerImpl(MapMaker P_0)
		{
			map = MapMakerInternalMap.createWithDummyValues(P_0.keyEquivalence(Equivalence.equals()));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)TE;")]
		[LineNumberTable(new byte[]
		{
			78, 109, 99, 103, 163, 98, 226, 69, 119, 99,
			226, 73
		})]
		public virtual object intern(object P_0)
		{
			MapMaker.Dummy dummy;
			do
			{
				MapMakerInternalMap.InternalEntry entry = map.getEntry(P_0);
				if (entry != null)
				{
					object key = entry.getKey();
					if (key != null)
					{
						return key;
					}
				}
				dummy = (MapMaker.Dummy)map.putIfAbsent(P_0, MapMaker.Dummy.VALUE);
			}
			while (dummy != null);
			return P_0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(90)]
	public static InternerBuilder newBuilder()
	{
		InternerBuilder result = new InternerBuilder(null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(36)]
	private Interners()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>()Lcom/google/common/collect/Interner<TE;>;")]
	[LineNumberTable(99)]
	public static Interner newStrongInterner()
	{
		Interner result = newBuilder().strong().build();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>()Lcom/google/common/collect/Interner<TE;>;")]
	[LineNumberTable(110)]
	public static Interner newWeakInterner()
	{
		Interner result = newBuilder().weak().build();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Lcom/google/common/collect/Interner<TE;>;)Lcom/google/common/base/Function<TE;TE;>;")]
	[LineNumberTable(161)]
	public static com.google.common.@base.Function asFunction(Interner interner)
	{
		InternerFunction result = new InternerFunction((Interner)Preconditions.checkNotNull(interner));
		_ = null;
		return result;
	}
}
