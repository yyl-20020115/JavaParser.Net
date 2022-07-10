using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<T:Ljava/lang/Object;>Lcom/google/common/collect/UnmodifiableIterator<TT;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 59, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)59,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public abstract class AbstractIterator : UnmodifiableIterator
{
	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal class _1 : java.lang.Object
	{
		[Modifiers(Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		internal static int[] _0024SwitchMap_0024com_0024google_0024common_0024collect_0024AbstractIterator_0024State;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[LineNumberTable(134)]
		static _1()
		{
			_0024SwitchMap_0024com_0024google_0024common_0024collect_0024AbstractIterator_0024State = new int[(nint)State.values().LongLength];
			try
			{
				_0024SwitchMap_0024com_0024google_0024common_0024collect_0024AbstractIterator_0024State[State.DONE.ordinal()] = 1;
			}
			catch (System.Exception x)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0033;
			}
			goto IL_0039;
			IL_0033:
			_ = null;
			goto IL_0039;
			IL_0039:
			try
			{
				_0024SwitchMap_0024com_0024google_0024common_0024collect_0024AbstractIterator_0024State[State.READY.ordinal()] = 2;
				return;
			}
			catch (System.Exception x2)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x2, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
			}
			_ = null;
		}

		_1()
		{
			throw null;
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/collect/AbstractIterator$State;>;")]
	[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	internal sealed class State : java.lang.Enum
	{
		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static State READY;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static State NOT_READY;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static State DONE;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static State FAILED;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static State[] _0024VALUES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(73)]
		public static State[] values()
		{
			return (State[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(73)]
		private State(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(73)]
		private static State[] _0024values()
		{
			return new State[4] { READY, NOT_READY, DONE, FAILED };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(73)]
		public static State valueOf(string P_0)
		{
			return (State)java.lang.Enum.valueOf(ClassLiteral<State>.Value, P_0);
		}

		[LineNumberTable(new byte[] { 25, 176, 176, 176, 240, 53 })]
		static State()
		{
			READY = new State("READY", 0);
			NOT_READY = new State("NOT_READY", 1);
			DONE = new State("DONE", 2);
			FAILED = new State("FAILED", 3);
			_0024VALUES = _0024values();
		}
	}

	private State state;

	[Signature("TT;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private new object m_next;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 95, 107, 108, 109, 107, 130 })]
	private bool tryToComputeNext()
	{
		state = State.FAILED;
		this.m_next = computeNext();
		if (state != State.DONE)
		{
			state = State.READY;
			return true;
		}
		return false;
	}

	[Signature("()TT;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal abstract object computeNext();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 83, 117, 159, 3, 130, 162 })]
	public sealed override bool hasNext()
	{
		Preconditions.checkState(state != State.FAILED);
		switch (_1._0024SwitchMap_0024com_0024google_0024common_0024collect_0024AbstractIterator_0024State[state.ordinal()])
		{
		case 1:
			return false;
		case 2:
			return true;
		default:
		{
			bool result = tryToComputeNext();
			_ = null;
			return result;
		}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 21, 232, 61, 171 })]
	protected internal AbstractIterator()
	{
		state = State.NOT_READY;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TT;")]
	[LineNumberTable(new byte[] { 76, 107 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal object endOfData()
	{
		state = State.DONE;
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TT;")]
	[LineNumberTable(new byte[] { 108, 104, 139, 139, 108, 103 })]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public sealed override object next()
	{
		if (!hasNext())
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NoSuchElementException();
		}
		state = State.NOT_READY;
		object result = NullnessCasts.uncheckedCastNullableTToT(this.m_next);
		this.m_next = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TT;")]
	[LineNumberTable(new byte[] { 127, 104, 171 })]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public object peek()
	{
		if (!hasNext())
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NoSuchElementException();
		}
		object result = NullnessCasts.uncheckedCastNullableTToT(this.m_next);
		_ = null;
		return result;
	}
}
