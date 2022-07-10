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
using java.util.zip;

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
internal sealed class ChecksumHashFunction : AbstractHashFunction, Serializable.__Interface, ISerializable
{
	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal class _1 : java.lang.Object
	{
		_1()
		{
			throw null;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Final)]
	internal sealed class ChecksumHasher : AbstractByteHasher
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private Checksum checksum;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ChecksumHashFunction this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(60)]
		internal ChecksumHasher(ChecksumHashFunction P_0, Checksum P_1, _1 P_2)
			: this(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 13, 111, 113 })]
		private ChecksumHasher(ChecksumHashFunction P_0, Checksum P_1)
		{
			this_00240 = P_0;
			base._002Ector();
			checksum = (Checksum)Preconditions.checkNotNull(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 159, 125, 99, 110 })]
		protected internal override void update(byte P_0)
		{
			int b = (sbyte)P_0;
			checksum.update(b);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 24, 112 })]
		protected internal override void update(byte[] P_0, int P_1, int P_2)
		{
			checksum.update(P_0, P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 29, 108, 239, 70, 138 })]
		public override HashCode hash()
		{
			long value = checksum.getValue();
			if (access_0024100(this_00240) == 32)
			{
				HashCode result = HashCode.fromInt((int)value);
				_ = null;
				return result;
			}
			HashCode result2 = HashCode.fromLong(value);
			_ = null;
			return result2;
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/hash/ImmutableSupplier<+Ljava/util/zip/Checksum;>;")]
	private ImmutableSupplier checksumSupplier;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private new int m_bits;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private new string m_toString;

	private const long serialVersionUID = 0L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/hash/ImmutableSupplier<+Ljava/util/zip/Checksum;>;ILjava/lang/String;)V")]
	[LineNumberTable(new byte[] { 159, 179, 104, 113, 121, 103, 113 })]
	internal ChecksumHashFunction(ImmutableSupplier P_0, int P_1, string P_2)
	{
		checksumSupplier = (ImmutableSupplier)Preconditions.checkNotNull(P_0);
		Preconditions.checkArgument((P_1 == 32 || P_1 == 64) ? true : false, "bits (%s) must be either 32 or 64", P_1);
		this.m_bits = P_1;
		this.m_toString = (string)Preconditions.checkNotNull(P_2);
	}

	public override int bits()
	{
		return this.m_bits;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(51)]
	public override Hasher newHasher()
	{
		ChecksumHasher result = new ChecksumHasher(this, (Checksum)checksumSupplier.get(), null);
		_ = null;
		return result;
	}

	public override string toString()
	{
		return this.m_toString;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(31)]
	internal static int access_0024100(ChecksumHashFunction P_0)
	{
		return P_0.m_bits;
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
	protected ChecksumHashFunction(SerializationInfo P_0, StreamingContext P_1)
	{
		Serialization.readObject(this, P_0);
	}
}
