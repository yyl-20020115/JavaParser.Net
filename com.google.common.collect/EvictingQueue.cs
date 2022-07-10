using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.util;

namespace com.google.common.collect;

[Serializable]
[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingQueue<TE;>;Ljava/io/Serializable;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Serializable" })]
public sealed class EvictingQueue : ForwardingQueue, Serializable.__Interface, ISerializable
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Ljava/util/Queue<TE;>;")]
	private new Queue m_delegate;

	[Modifiers(Modifiers.Final)]
	internal int maxSize;

	private const long serialVersionUID = 0L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 5, 104, 114, 108, 103 })]
	private EvictingQueue(int P_0)
	{
		Preconditions.checkArgument(P_0 >= 0, "maxSize (%s) must >= 0", P_0);
		this.m_delegate = new ArrayDeque(P_0);
		maxSize = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)Z")]
	[LineNumberTable(new byte[] { 57, 103, 104, 130, 110, 140, 109 })]
	public override bool add(object e)
	{
		Preconditions.checkNotNull(e);
		if (maxSize == 0)
		{
			return true;
		}
		if (base.size() == maxSize)
		{
			this.m_delegate.remove();
		}
		this.m_delegate.add(e);
		return true;
	}

	[Signature("()Ljava/util/Queue<TE;>;")]
	protected internal override Queue @delegate()
	{
		return this.m_delegate;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(I)Lcom/google/common/collect/EvictingQueue<TE;>;")]
	[LineNumberTable(68)]
	public static EvictingQueue create(int maxSize)
	{
		EvictingQueue result = new EvictingQueue(maxSize);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(78)]
	public virtual int remainingCapacity()
	{
		return maxSize - base.size();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)Z")]
	[LineNumberTable(95)]
	public override bool offer(object e)
	{
		bool result = add(e);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Collection<+TE;>;)Z")]
	[LineNumberTable(new byte[] { 71, 103, 105, 102, 151 })]
	public override bool addAll(Collection collection)
	{
		int num = collection.size();
		if (num >= maxSize)
		{
			base.clear();
			bool result = Iterables.addAll(this, Iterables.skip(collection, num - maxSize));
			_ = null;
			return result;
		}
		bool result2 = base.standardAddAll(collection);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(141)]
	public override object[] toArray()
	{
		object[] result = base.toArray();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(46)]
	protected internal override Collection _003Cbridge_003Edelegate()
	{
		Queue result = @delegate();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(46)]
	protected internal override object _003Cbridge_003Edelegate()
	{
		Queue result = @delegate();
		_ = null;
		return result;
	}

	[HideFromJava]
	public static implicit operator Serializable(EvictingQueue P_0)
	{
		Serializable result = default(Serializable);
		result.___003Cref_003E = P_0;
		return result;
	}

	[SecurityCritical]
	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	void ISerializable.GetObjectData(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.writeObject(this, P_0);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected EvictingQueue(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.readObject(this, P_0);
	}
}
