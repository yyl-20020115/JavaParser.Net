using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableList<TE;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal abstract class ImmutableAsList : ImmutableList
{
	[Serializable]
	[Implements(new string[] { "java.io.Serializable" })]
	internal new class SerializedForm : java.lang.Object, Serializable.__Interface, ISerializable, IObjectReference
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/collect/ImmutableCollection<*>;")]
		internal ImmutableCollection collection;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableCollection<*>;)V")]
		[LineNumberTable(new byte[] { 16, 104, 103 })]
		internal SerializedForm(ImmutableCollection P_0)
		{
			collection = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(71)]
		internal virtual object readResolve()
		{
			ImmutableList result = collection.asList();
			_ = null;
			return result;
		}

		[SecurityCritical]
		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected virtual void GetObjectData(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.writeObject(this, P_0);
		}

		void ISerializable.GetObjectData(SerializationInfo P_0, StreamingContext P_1)
		{
			//ILSpy generated this explicit interface implementation from .override directive in GetObjectData
			this.GetObjectData(P_0, P_1);
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected SerializedForm(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}

		[SecurityCritical]
		[HideFromJava]
		object IObjectReference.GetRealObject(StreamingContext P_0)
		{
			if (((object)this).GetType() != typeof(SerializedForm))
			{
				return this;
			}
			return readResolve();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	protected internal new static void ___003Cclinit_003E()
	{
	}

	[Signature("()Lcom/google/common/collect/ImmutableCollection<TE;>;")]
	internal abstract ImmutableCollection delegateCollection();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(36)]
	internal ImmutableAsList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(43)]
	public override bool contains([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		bool result = delegateCollection().contains(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(48)]
	public override int size()
	{
		int result = delegateCollection().size();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(53)]
	public override bool isEmpty()
	{
		bool result = delegateCollection().isEmpty();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(58)]
	internal override bool isPartialView()
	{
		bool result = delegateCollection().isPartialView();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.InvalidObjectException" })]
	[LineNumberTable(79)]
	private void readObject(ObjectInputStream P_0)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new InvalidObjectException("Use SerializedForm");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(85)]
	internal override object writeReplace()
	{
		SerializedForm result = new SerializedForm(delegateCollection());
		_ = null;
		return result;
	}

	[HideFromJava]
	static ImmutableAsList()
	{
		ImmutableList.___003Cclinit_003E();
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected ImmutableAsList(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
