using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.nio;
using javax.annotation;

namespace com.google.common.hash;

[Serializable]
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
[Implements(new string[] { "java.io.Serializable" })]
internal sealed class SipHashFunction : AbstractHashFunction, Serializable.__Interface, ISerializable
{
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class SipHasher : AbstractStreamingHasher
	{
		private const int CHUNK_SIZE = 8;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private int c;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private int d;

		private long v0;

		private long v1;

		private long v2;

		private long v3;

		private long b;

		private long finalM;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 109, 110, 108, 110 })]
		private void processM(long P_0)
		{
			v3 ^= P_0;
			sipRound(c);
			v0 ^= P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			115, 105, 115, 115, 115, 115, 115, 115, 115, 115,
			115, 115, 115, 115, 115, 243, 50, 233, 80
		})]
		private void sipRound(int P_0)
		{
			for (int i = 0; i < P_0; i++)
			{
				v0 += v1;
				v2 += v3;
				v1 = Long.rotateLeft(v1, 13);
				v3 = Long.rotateLeft(v3, 16);
				v1 ^= v0;
				v3 ^= v2;
				v0 = Long.rotateLeft(v0, 32);
				v2 += v1;
				v0 += v3;
				v1 = Long.rotateLeft(v1, 17);
				v3 = Long.rotateLeft(v3, 21);
				v1 ^= v2;
				v3 ^= v0;
				v2 = Long.rotateLeft(v2, 32);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			73, 233, 51, 111, 111, 111, 175, 200, 200, 103,
			103, 110, 111, 110, 111
		})]
		internal SipHasher(int P_0, int P_1, long P_2, long P_3)
			: base(8)
		{
			v0 = 8317987319222330741L;
			v1 = 7237128888997146477L;
			v2 = 7816392313619706465L;
			v3 = 8387220255154660723L;
			b = 0L;
			finalM = 0L;
			c = P_0;
			d = P_1;
			v0 ^= P_2;
			v1 ^= P_3;
			v2 ^= P_2;
			v3 ^= P_3;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 84, 111, 110 })]
		protected internal override void process(ByteBuffer P_0)
		{
			b += 8L;
			processM(P_0.getLong());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 90, 116, 106, 63, 2, 166 })]
		protected internal override void processRemaining(ByteBuffer P_0)
		{
			b += P_0.remaining();
			int num = 0;
			while (P_0.hasRemaining())
			{
				finalM ^= ((sbyte)P_0.get() & 0xFFu) << num;
				num += 8;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 99, 118, 172, 115, 108 })]
		protected internal override HashCode makeHash()
		{
			finalM ^= b << 56;
			processM(finalM);
			v2 ^= 255L;
			sipRound(d);
			HashCode result = HashCode.fromLong(v0 ^ v1 ^ v2 ^ v3);
			_ = null;
			return result;
		}
	}

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	internal static HashFunction SIP_HASH_24;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private int c;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private int d;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private long k0;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private long k1;

	private const long serialVersionUID = 0L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 6, 104, 143, 143, 103, 103, 103, 104 })]
	internal SipHashFunction(int P_0, int P_1, long P_2, long P_3)
	{
		Preconditions.checkArgument(P_0 > 0, "The number of SipRound iterations (c=%s) during Compression must be positive.", P_0);
		Preconditions.checkArgument(P_1 > 0, "The number of SipRound iterations (d=%s) during Finalization must be positive.", P_1);
		c = P_0;
		d = P_1;
		k0 = P_2;
		k1 = P_3;
	}

	public override int bits()
	{
		return 64;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(74)]
	public override Hasher newHasher()
	{
		SipHasher result = new SipHasher(c, d, k0, k1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(81)]
	public override string toString()
	{
		int i = c;
		int i2 = d;
		long lng = k0;
		long lng2 = k1;
		int num = 81;
		num = num;
		string result = new StringBuilder(num).append("Hashing.sipHash").append(i).append(i2)
			.append("(")
			.append(lng)
			.append(", ")
			.append(lng2)
			.append(")")
			.toString();
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 36, 104, 103, 159, 30 })]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		if (P_0 is SipHashFunction)
		{
			SipHashFunction sipHashFunction = (SipHashFunction)P_0;
			return (c == sipHashFunction.c && d == sipHashFunction.d && k0 == sipHashFunction.k0 && k1 == sipHashFunction.k1) ? true : false;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(95)]
	public override int hashCode()
	{
		return (int)(java.lang.Object.instancehelper_hashCode(java.lang.Object.instancehelper_getClass(this)) ^ c ^ d ^ k0 ^ k1);
	}

	[LineNumberTable(39)]
	static SipHashFunction()
	{
		SIP_HASH_24 = new SipHashFunction(2, 4, 506097522914230528L, 1084818905618843912L);
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
	protected SipHashFunction(SerializationInfo P_0, StreamingContext P_1)
	{
		Serialization.readObject(this, P_0);
	}
}
