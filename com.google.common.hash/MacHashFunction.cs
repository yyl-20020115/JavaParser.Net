using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.nio;
using java.security;
using javax.crypto;

namespace com.google.common.hash;

[Immutable(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/Immutable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/hash/ElementTypesAreNonnullByDefault;"
})]
internal sealed class MacHashFunction : AbstractHashFunction
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

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class MacHasher : AbstractByteHasher
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private Mac mac;

		private bool done;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(98)]
		internal MacHasher(Mac P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 52, 104, 103 })]
		private MacHasher(Mac P_0)
		{
			mac = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 82, 120 })]
		private void checkNotDone()
		{
			Preconditions.checkState((!done) ? true : false, (object)"Cannot re-use a Hasher after calling hash() on it");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 159, 115, 67, 102, 110 })]
		protected internal override void update(byte P_0)
		{
			int input = (sbyte)P_0;
			checkNotDone();
			mac.update((byte)input);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 64, 102, 110 })]
		protected internal override void update(byte[] P_0)
		{
			checkNotDone();
			mac.update(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 70, 102, 112 })]
		protected internal override void update(byte[] P_0, int P_1, int P_2)
		{
			checkNotDone();
			mac.update(P_0, P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 76, 102, 103, 110 })]
		protected internal override void update(ByteBuffer P_0)
		{
			checkNotDone();
			Preconditions.checkNotNull(P_0);
			mac.update(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 87, 102, 103 })]
		public override HashCode hash()
		{
			checkNotDone();
			done = true;
			HashCode result = HashCode.fromBytesNoCopy(mac.doFinal());
			_ = null;
			return result;
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private Mac prototype;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private Key key;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private new string m_toString;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private new int m_bits;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private bool m_supportsClone;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 188, 104, 109, 113, 113, 115, 113 })]
	internal MacHashFunction(string P_0, Key P_1, string P_2)
	{
		prototype = getMac(P_0, P_1);
		key = (Key)Preconditions.checkNotNull(P_1);
		this.m_toString = (string)Preconditions.checkNotNull(P_2);
		this.m_bits = prototype.getMacLength() * 8;
		this.m_supportsClone = supportsClone(prototype);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 20, 103, 103, 127, 4, 98, 109, 98 })]
	private static Mac getMac(string P_0, Key P_1)
	{
		//Discarded unreachable code: IL_0011
		NoSuchAlgorithmException ex;
		InvalidKeyException ex2;
		try
		{
			try
			{
				Mac instance = Mac.getInstance(P_0);
				instance.init(P_1);
				return instance;
			}
			catch (NoSuchAlgorithmException x)
			{
				ex = ByteCodeHelper.MapException<NoSuchAlgorithmException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
		}
		catch (InvalidKeyException x2)
		{
			ex2 = ByteCodeHelper.MapException<InvalidKeyException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_002d;
		}
		NoSuchAlgorithmException cause = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new IllegalStateException(cause);
		IL_002d:
		InvalidKeyException cause2 = ex2;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new IllegalArgumentException(cause2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 11, 103, 112, 97 })]
	private static bool supportsClone(Mac P_0)
	{
		//Discarded unreachable code: IL_000a
		try
		{
			P_0.clone();
			return true;
		}
		catch (CloneNotSupportedException)
		{
		}
		_ = null;
		return false;
	}

	public override int bits()
	{
		return this.m_bits;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 32, 136, 127, 6, 193 })]
	public override Hasher newHasher()
	{
		//Discarded unreachable code: IL_0020
		if (this.m_supportsClone)
		{
			try
			{
				return new MacHasher((Mac)prototype.clone(), null);
			}
			catch (CloneNotSupportedException)
			{
			}
			_ = null;
		}
		return new MacHasher(getMac(prototype.getAlgorithm(), key), null);
	}

	public override string toString()
	{
		return this.m_toString;
	}
}
