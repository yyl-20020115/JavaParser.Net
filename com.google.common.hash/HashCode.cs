using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.common.primitives;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using javax.annotation;

namespace com.google.common.hash;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/hash/ElementTypesAreNonnullByDefault;"
})]
public abstract class HashCode : java.lang.Object
{
	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Implements(new string[] { "java.io.Serializable" })]
	internal sealed class BytesHashCode : HashCode, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Final)]
		internal byte[] bytes;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 140, 104, 113 })]
		internal BytesHashCode(byte[] P_0)
		{
			bytes = (byte[])Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 177, 106, 114, 51, 166 })]
		public override long padToLong()
		{
			long num = (int)bytes[0];
			for (int i = 1; i < java.lang.Math.min(bytes.Length, 8); i++)
			{
				num |= (long)(int)bytes[i] << i * 8;
			}
			return num;
		}

		[LineNumberTable(260)]
		public override int bits()
		{
			return (int)((nint)bytes.LongLength * 8);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(265)]
		public override byte[] asBytes()
		{
			return (byte[])bytes.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 156, 222 })]
		public override int asInt()
		{
			Preconditions.checkState((nint)bytes.LongLength >= 4, "HashCode#asInt() requires >= 4 bytes (it only has %s bytes).", bytes.Length);
			return bytes[0] | (bytes[1] << 8) | (bytes[2] << 16) | (bytes[3] << 24);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 168, 222 })]
		public override long asLong()
		{
			Preconditions.checkState((nint)bytes.LongLength >= 8, "HashCode#asLong() requires >= 8 bytes (it only has %s bytes).", bytes.Length);
			long result = padToLong();
			_ = null;
			return result;
		}

		[LineNumberTable(new byte[] { 160, 186, 113 })]
		internal override void writeBytesToImpl(byte[] P_0, int P_1, int P_2)
		{
			ByteCodeHelper.arraycopy_primitive_1(bytes, 0, P_0, P_1, P_2);
		}

		internal override byte[] getBytesInternal()
		{
			return bytes;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 198, 112, 162, 98, 108, 53, 166 })]
		internal override bool equalsSameBits(HashCode P_0)
		{
			if ((nint)bytes.LongLength != (nint)P_0.getBytesInternal().LongLength)
			{
				return false;
			}
			int num = 1;
			for (int i = 0; i < (nint)bytes.LongLength; i++)
			{
				num &= ((bytes[i] == P_0.getBytesInternal()[i]) ? 1 : 0);
			}
			return (byte)num != 0;
		}

		[HideFromJava]
		static BytesHashCode()
		{
			HashCode.___003Cclinit_003E();
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
		protected BytesHashCode(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Implements(new string[] { "java.io.Serializable" })]
	internal sealed class IntHashCode : HashCode, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Final)]
		internal int hash;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 72, 104, 103 })]
		internal IntHashCode(int P_0)
		{
			hash = P_0;
		}

		public override int bits()
		{
			return 32;
		}

		[LineNumberTable(133)]
		public override byte[] asBytes()
		{
			return new byte[4]
			{
				(byte)(sbyte)hash,
				(byte)(sbyte)(hash >> 8),
				(byte)(sbyte)(hash >> 16),
				(byte)(sbyte)(hash >> 24)
			};
		}

		public override int asInt()
		{
			return hash;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(143)]
		public override long asLong()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException("this HashCode only has 32 bits; cannot create a long");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(148)]
		public override long padToLong()
		{
			long result = UnsignedInts.toLong(hash);
			_ = null;
			return result;
		}

		[LineNumberTable(new byte[] { 103, 102, 51, 166 })]
		internal override void writeBytesToImpl(byte[] P_0, int P_1, int P_2)
		{
			for (int i = 0; i < P_2; i++)
			{
				P_0[P_1 + i] = (byte)(sbyte)(hash >> i * 8);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(160)]
		internal override bool equalsSameBits(HashCode P_0)
		{
			return hash == P_0.asInt();
		}

		[HideFromJava]
		static IntHashCode()
		{
			HashCode.___003Cclinit_003E();
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
		protected IntHashCode(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Implements(new string[] { "java.io.Serializable" })]
	internal sealed class LongHashCode : HashCode, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Final)]
		internal long hash;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 65, 104, 103 })]
		internal LongHashCode(long P_0)
		{
			hash = P_0;
		}

		public override int bits()
		{
			return 64;
		}

		[LineNumberTable(190)]
		public override byte[] asBytes()
		{
			return new byte[8]
			{
				(byte)(sbyte)hash,
				(byte)(sbyte)(hash >> 8),
				(byte)(sbyte)(hash >> 16),
				(byte)(sbyte)(hash >> 24),
				(byte)(sbyte)(hash >> 32),
				(byte)(sbyte)(hash >> 40),
				(byte)(sbyte)(hash >> 48),
				(byte)(sbyte)(hash >> 56)
			};
		}

		public override int asInt()
		{
			return (int)hash;
		}

		public override long asLong()
		{
			return hash;
		}

		public override long padToLong()
		{
			return hash;
		}

		[LineNumberTable(new byte[] { 160, 105, 102, 52, 166 })]
		internal override void writeBytesToImpl(byte[] P_0, int P_1, int P_2)
		{
			for (int i = 0; i < P_2; i++)
			{
				P_0[P_1 + i] = (byte)(sbyte)(hash >> i * 8);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(226)]
		internal override bool equalsSameBits(HashCode P_0)
		{
			return hash == P_0.asLong();
		}

		[HideFromJava]
		static LongHashCode()
		{
			HashCode.___003Cclinit_003E();
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
		protected LongHashCode(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static char[] hexDigits;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	protected internal static void ___003Cclinit_003E()
	{
	}

	public abstract long asLong();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(100)]
	internal virtual byte[] getBytesInternal()
	{
		byte[] result = asBytes();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(116)]
	public static HashCode fromInt(int hash)
	{
		IntHashCode result = new IntHashCode(hash);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(173)]
	public static HashCode fromLong(long hash)
	{
		LongHashCode result = new LongHashCode(hash);
		_ = null;
		return result;
	}

	public abstract int bits();

	[Modifiers(Modifiers.Abstract)]
	internal virtual void writeBytesToImpl(byte[] P_0, int P_1, int P_2)
	{
		throw new AbstractMethodError("com.google.common.hash.HashCode.writeBytesToImpl([BII)V");
	}

	public abstract byte[] asBytes();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(248)]
	internal static HashCode fromBytesNoCopy(byte[] P_0)
	{
		BytesHashCode result = new BytesHashCode(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 54, 130, 106, 133, 106, 136 })]
	private static int decode(char P_0)
	{
		if (P_0 >= '0' && P_0 <= '9')
		{
			return P_0 - 48;
		}
		if (P_0 >= 'a' && P_0 <= 'f')
		{
			return P_0 - 97 + 10;
		}
		int num = 32;
		num = num;
		string s = new StringBuilder(num).append("Illegal hexadecimal character: ").append(P_0).toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new IllegalArgumentException(s);
	}

	[Modifiers(Modifiers.Abstract)]
	internal virtual bool equalsSameBits(HashCode P_0)
	{
		throw new AbstractMethodError("com.google.common.hash.HashCode.equalsSameBits(Lcom.google.common.hash.HashCode;)Z");
	}

	public abstract int asInt();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(37)]
	internal HashCode()
	{
	}

	public abstract long padToLong();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 36, 124, 107, 105 })]
	public virtual int writeBytesTo(byte[] dest, int offset, int maxLength)
	{
		maxLength = Ints.min(maxLength, bits() / 8);
		Preconditions.checkPositionIndexes(offset, offset + maxLength, dest.Length);
		writeBytesToImpl(dest, offset, maxLength);
		return maxLength;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 125, 114 })]
	public static HashCode fromBytes(byte[] bytes)
	{
		Preconditions.checkArgument((nint)bytes.LongLength >= 1, (object)"A HashCode must contain at least 1 byte.");
		HashCode result = fromBytesNoCopy((byte[])bytes.Clone());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 223, 97, 49, 133, 97, 60, 229, 69, 110,
		107, 111, 111, 233, 61, 230, 69
	})]
	public static HashCode fromString(string @string)
	{
		Preconditions.checkArgument(java.lang.String.instancehelper_length(@string) >= 2, "input string (%s) must have at least 2 characters", @string);
		int num = java.lang.String.instancehelper_length(@string);
		Preconditions.checkArgument((2 == -1 || num % 2 == 0) ? true : false, "input string (%s) must have an even number of characters", @string);
		byte[] array = new byte[java.lang.String.instancehelper_length(@string) / 2];
		for (int i = 0; i < java.lang.String.instancehelper_length(@string); i += 2)
		{
			int num2 = decode(java.lang.String.instancehelper_charAt(@string, i)) << 4;
			int num3 = decode(java.lang.String.instancehelper_charAt(@string, i + 1));
			array[i / 2] = (byte)(sbyte)(num2 + num3);
		}
		HashCode result = fromBytesNoCopy(array);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 2, 104, 103, 156 })]
	public sealed override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object @object)
	{
		if (@object is HashCode)
		{
			HashCode hashCode = (HashCode)@object;
			return (bits() == hashCode.bits() && equalsSameBits(hashCode)) ? true : false;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 18, 106, 169, 103, 100, 103, 45, 166 })]
	public sealed override int hashCode()
	{
		if (bits() >= 32)
		{
			int result = asInt();
			_ = null;
			return result;
		}
		byte[] bytesInternal = getBytesInternal();
		int num = bytesInternal[0];
		for (int i = 1; i < (nint)bytesInternal.LongLength; i++)
		{
			num |= bytesInternal[i] << i * 8;
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 43, 103, 106, 115, 63, 5, 168 })]
	public sealed override string toString()
	{
		byte[] bytesInternal = getBytesInternal();
		StringBuilder stringBuilder = new StringBuilder((int)(2 * (nint)bytesInternal.LongLength));
		byte[] array = bytesInternal;
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			int num2 = array[i];
			stringBuilder.append(hexDigits[(num2 >> 4) & 0xF]).append(hexDigits[num2 & 0xF]);
		}
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[LineNumberTable(421)]
	static HashCode()
	{
		hexDigits = java.lang.String.instancehelper_toCharArray("0123456789abcdef");
	}
}
