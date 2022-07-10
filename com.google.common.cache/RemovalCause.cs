using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace com.google.common.cache;

[Serializable]
[Signature("Ljava/lang/Enum<Lcom/google/common/cache/RemovalCause;>;")]
[Modifiers(Modifiers.Public | Modifiers.Super | Modifiers.Abstract | Modifiers.Enum)]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/cache/ElementTypesAreNonnullByDefault;"
})]
public abstract class RemovalCause : java.lang.Enum
{
	[Serializable]
	[HideFromJava]
	public enum __Enum
	{
		EXPLICIT,
		REPLACED,
		COLLECTED,
		EXPIRED,
		SIZE
	}

	[Serializable]
	[SpecialName]
	[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	internal sealed class _1 : RemovalCause
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(36)]
		internal _1(string P_0, int P_1)
			: base(P_0, P_1, null)
		{
			GC.KeepAlive(this);
		}

		internal override bool wasEvicted()
		{
			return false;
		}

		[HideFromJava]
		static _1()
		{
			RemovalCause.___003Cclinit_003E();
		}
	}

	[Serializable]
	[SpecialName]
	[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	internal sealed class _2 : RemovalCause
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(49)]
		internal _2(string P_0, int P_1)
			: base(P_0, P_1, null)
		{
			GC.KeepAlive(this);
		}

		internal override bool wasEvicted()
		{
			return false;
		}

		[HideFromJava]
		static _2()
		{
			RemovalCause.___003Cclinit_003E();
		}
	}

	[Serializable]
	[SpecialName]
	[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	internal sealed class _3 : RemovalCause
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(61)]
		internal _3(string P_0, int P_1)
			: base(P_0, P_1, null)
		{
			GC.KeepAlive(this);
		}

		internal override bool wasEvicted()
		{
			return true;
		}

		[HideFromJava]
		static _3()
		{
			RemovalCause.___003Cclinit_003E();
		}
	}

	[Serializable]
	[SpecialName]
	[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	internal sealed class _4 : RemovalCause
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(72)]
		internal _4(string P_0, int P_1)
			: base(P_0, P_1, null)
		{
			GC.KeepAlive(this);
		}

		internal override bool wasEvicted()
		{
			return true;
		}

		[HideFromJava]
		static _4()
		{
			RemovalCause.___003Cclinit_003E();
		}
	}

	[Serializable]
	[SpecialName]
	[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	internal sealed class _5 : RemovalCause
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(83)]
		internal _5(string P_0, int P_1)
			: base(P_0, P_1, null)
		{
			GC.KeepAlive(this);
		}

		internal override bool wasEvicted()
		{
			return true;
		}

		[HideFromJava]
		static _5()
		{
			RemovalCause.___003Cclinit_003E();
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static RemovalCause ___003C_003EEXPLICIT;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static RemovalCause ___003C_003EREPLACED;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static RemovalCause ___003C_003ECOLLECTED;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static RemovalCause ___003C_003EEXPIRED;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static RemovalCause ___003C_003ESIZE;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
	private static RemovalCause[] _0024VALUES;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static RemovalCause EXPLICIT
	{
		[HideFromJava]
		get
		{
			return ___003C_003EEXPLICIT;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static RemovalCause REPLACED
	{
		[HideFromJava]
		get
		{
			return ___003C_003EREPLACED;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static RemovalCause COLLECTED
	{
		[HideFromJava]
		get
		{
			return ___003C_003ECOLLECTED;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static RemovalCause EXPIRED
	{
		[HideFromJava]
		get
		{
			return ___003C_003EEXPIRED;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static RemovalCause SIZE
	{
		[HideFromJava]
		get
		{
			return ___003C_003ESIZE;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[Modifiers(Modifiers.Abstract)]
	internal virtual bool wasEvicted()
	{
		throw new AbstractMethodError("com.google.common.cache.RemovalCause.wasEvicted()Z");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()V")]
	[LineNumberTable(30)]
	private RemovalCause(string P_0, int P_1)
		: base(P_0, P_1)
	{
		GC.KeepAlive(this);
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(28)]
	private static RemovalCause[] _0024values()
	{
		return new RemovalCause[5] { ___003C_003EEXPLICIT, ___003C_003EREPLACED, ___003C_003ECOLLECTED, ___003C_003EEXPIRED, ___003C_003ESIZE };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(28)]
	public static RemovalCause[] values()
	{
		return (RemovalCause[])_0024VALUES.Clone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(28)]
	public static RemovalCause valueOf(string name)
	{
		return (RemovalCause)java.lang.Enum.valueOf(ClassLiteral<RemovalCause>.Value, name);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Synthetic)]
	[LineNumberTable(30)]
	internal RemovalCause(string P_0, int P_1, _1 P_2)
		: this(P_0, P_1)
	{
		GC.KeepAlive(this);
	}

	[LineNumberTable(new byte[]
	{
		159, 178, 240, 77, 240, 76, 240, 75, 240, 75,
		240, 9
	})]
	static RemovalCause()
	{
		___003C_003EEXPLICIT = new _1("EXPLICIT", 0);
		___003C_003EREPLACED = new _2("REPLACED", 1);
		___003C_003ECOLLECTED = new _3("COLLECTED", 2);
		___003C_003EEXPIRED = new _4("EXPIRED", 3);
		___003C_003ESIZE = new _5("SIZE", 4);
		_0024VALUES = _0024values();
	}
}
