using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.nio;
using java.security;
using java.util;

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
internal sealed class MessageDigestHashFunction : AbstractHashFunction, Serializable.__Interface, ISerializable
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

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class MessageDigestHasher : AbstractByteHasher
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private MessageDigest digest;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private int bytes;

		private bool done;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(124)]
		internal MessageDigestHasher(MessageDigest P_0, int P_1, _1 P_2)
			: this(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 79, 104, 103, 103 })]
		private MessageDigestHasher(MessageDigest P_0, int P_1)
		{
			digest = P_0;
			bytes = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 103, 120 })]
		private void checkNotDone()
		{
			Preconditions.checkState((!done) ? true : false, (object)"Cannot re-use a Hasher after calling hash() on it");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 159, 108, 67, 102, 110 })]
		protected internal override void update(byte P_0)
		{
			int input = (sbyte)P_0;
			checkNotDone();
			digest.update((byte)input);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 92, 102, 112 })]
		protected internal override void update(byte[] P_0, int P_1, int P_2)
		{
			checkNotDone();
			digest.update(P_0, P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 98, 102, 110 })]
		protected internal override void update(ByteBuffer P_0)
		{
			checkNotDone();
			digest.update(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 108, 102, 103, 115, 114, 29 })]
		public override HashCode hash()
		{
			checkNotDone();
			done = true;
			HashCode result = ((bytes != digest.getDigestLength()) ? HashCode.fromBytesNoCopy(Arrays.copyOf(digest.digest(), bytes)) : HashCode.fromBytesNoCopy(digest.digest()));
			_ = null;
			return result;
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Implements(new string[] { "java.io.Serializable" })]
	internal sealed class SerializedForm : java.lang.Object, Serializable.__Interface, ISerializable, IObjectReference
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private string algorithmName;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private int bytes;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private new string toString;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(101)]
		internal SerializedForm(string P_0, int P_1, string P_2, _1 P_3)
			: this(P_0, P_1, P_2)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 56, 104, 103, 103, 103 })]
		private SerializedForm(string P_0, int P_1, string P_2)
		{
			algorithmName = P_0;
			bytes = P_1;
			toString = P_2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(113)]
		private object readResolve()
		{
			MessageDigestHashFunction result = new MessageDigestHashFunction(algorithmName, bytes, toString);
			_ = null;
			return result;
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
		protected SerializedForm(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}

		[SecurityCritical]
		[HideFromJava]
		object IObjectReference.GetRealObject(StreamingContext P_0)
		{
			return readResolve();
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private MessageDigest prototype;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private int bytes;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private bool m_supportsClone;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private new string m_toString;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 187, 104, 108, 113, 113, 113 })]
	internal MessageDigestHashFunction(string P_0, string P_1)
	{
		prototype = getMessageDigest(P_0);
		bytes = prototype.getDigestLength();
		this.m_toString = (string)Preconditions.checkNotNull(P_1);
		this.m_supportsClone = supportsClone(prototype);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 33, 124, 97 })]
	private static MessageDigest getMessageDigest(string P_0)
	{
		//Discarded unreachable code: IL_0008
		NoSuchAlgorithmException ex;
		try
		{
			return MessageDigest.getInstance(P_0);
		}
		catch (NoSuchAlgorithmException x)
		{
			ex = ByteCodeHelper.MapException<NoSuchAlgorithmException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		NoSuchAlgorithmException detailMessage = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new AssertionError(detailMessage);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 14, 103, 112, 97 })]
	private static bool supportsClone(MessageDigest P_0)
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 2, 104, 113, 108, 108, 152, 103, 113 })]
	internal MessageDigestHashFunction(string P_0, int P_1, string P_2)
	{
		this.m_toString = (string)Preconditions.checkNotNull(P_2);
		prototype = getMessageDigest(P_0);
		int digestLength = prototype.getDigestLength();
		Preconditions.checkArgument((P_1 >= 4 && P_1 <= digestLength) ? true : false, "bytes (%s) must be >= 4 and < %s", P_1, digestLength);
		bytes = P_1;
		this.m_supportsClone = supportsClone(prototype);
	}

	public override int bits()
	{
		return bytes * 8;
	}

	public override string toString()
	{
		return this.m_toString;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 41, 136, 127, 12, 193 })]
	public override Hasher newHasher()
	{
		//Discarded unreachable code: IL_0026
		if (this.m_supportsClone)
		{
			try
			{
				return new MessageDigestHasher((MessageDigest)prototype.clone(), bytes, null);
			}
			catch (CloneNotSupportedException)
			{
			}
			_ = null;
		}
		return new MessageDigestHasher(getMessageDigest(prototype.getAlgorithm()), bytes, null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(120)]
	internal virtual object writeReplace()
	{
		SerializedForm result = new SerializedForm(prototype.getAlgorithm(), bytes, this.m_toString, null);
		_ = null;
		return result;
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
	protected MessageDigestHashFunction(SerializationInfo P_0, StreamingContext P_1)
	{
		Serialization.readObject(this, P_0);
	}
}
