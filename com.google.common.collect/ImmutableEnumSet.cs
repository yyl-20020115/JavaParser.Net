using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.errorprone.annotations.concurrent;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<E:Ljava/lang/Enum<TE;>;>Lcom/google/common/collect/ImmutableSet<TE;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal sealed class ImmutableEnumSet : ImmutableSet
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

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<E:Ljava/lang/Enum<TE;>;>Ljava/lang/Object;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.io.Serializable" })]
	internal class EnumSerializedForm : java.lang.Object, Serializable.__Interface, ISerializable, IObjectReference
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/EnumSet<TE;>;")]
		internal EnumSet @delegate;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/EnumSet<TE;>;)V")]
		[LineNumberTable(new byte[] { 97, 104, 103 })]
		internal EnumSerializedForm(EnumSet P_0)
		{
			@delegate = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(153)]
		internal virtual object readResolve()
		{
			___003Cclinit_003E();
			ImmutableEnumSet result = new ImmutableEnumSet(@delegate.clone(), null);
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
		protected EnumSerializedForm(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}

		[SecurityCritical]
		[HideFromJava]
		object IObjectReference.GetRealObject(StreamingContext P_0)
		{
			if (((object)this).GetType() != typeof(EnumSerializedForm))
			{
				return this;
			}
			return readResolve();
		}
	}

	[NonSerialized]
	[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
	[Signature("Ljava/util/EnumSet<TE;>;")]
	private EnumSet @delegate;

	[NonSerialized]
	[LazyInit(new object[]
	{
		(byte)64,
		"Lcom/google/errorprone/annotations/concurrent/LazyInit;"
	})]
	private new int m_hashCode;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 181, 151, 136, 142 })]
	internal static ImmutableSet asImmutable(EnumSet P_0)
	{
		switch (P_0.size())
		{
		case 0:
		{
			ImmutableSet result3 = ImmutableSet.of();
			_ = null;
			return result3;
		}
		case 1:
		{
			ImmutableSet result2 = ImmutableSet.of(Iterables.getOnlyElement(P_0));
			_ = null;
			return result2;
		}
		default:
		{
			ImmutableEnumSet result = new ImmutableEnumSet(P_0);
			_ = null;
			return result;
		}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/EnumSet<TE;>;)V")]
	[LineNumberTable(new byte[] { 9, 104, 103 })]
	private ImmutableEnumSet(EnumSet P_0)
	{
		@delegate = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TE;>;")]
	[LineNumberTable(70)]
	public override UnmodifiableIterator iterator()
	{
		UnmodifiableIterator result = Iterators.unmodifiableIterator(@delegate.iterator());
		_ = null;
		return result;
	}

	internal override bool isPartialView()
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Spliterator<TE;>;")]
	[LineNumberTable(75)]
	public override Spliterator spliterator()
	{
		Spliterator result = @delegate.spliterator();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/function/Consumer<-TE;>;)V")]
	[LineNumberTable(new byte[] { 30, 110 })]
	public override void forEach(Consumer P_0)
	{
		@delegate.forEach(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(85)]
	public override int size()
	{
		int result = @delegate.size();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(90)]
	public override bool contains([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		bool result = @delegate.contains(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Collection<*>;)Z")]
	[LineNumberTable(new byte[] { 159, 119, 162, 109, 145 })]
	public override bool containsAll(Collection P_0)
	{
		object obj = P_0;
		if (((Collection)obj) is ImmutableEnumSet)
		{
			obj = ((ImmutableEnumSet)(Collection)obj).@delegate;
		}
		EnumSet enumSet = @delegate;
		object obj2 = obj;
		bool result = enumSet.containsAll((obj2 == null) ? null : ((obj2 as Collection) ?? throw new java.lang.IncompatibleClassChangeError()));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(103)]
	public override bool isEmpty()
	{
		bool result = @delegate.isEmpty();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 58, 100, 130, 104, 141 })]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		if (P_0 == this)
		{
			return true;
		}
		if (P_0 is ImmutableEnumSet)
		{
			P_0 = ((ImmutableEnumSet)P_0).@delegate;
		}
		bool result = @delegate.equals(P_0);
		_ = null;
		return result;
	}

	internal override bool isHashCodeFast()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 76, 103 })]
	public override int hashCode()
	{
		int num = this.m_hashCode;
		int result;
		if (num == 0)
		{
			int num2 = @delegate.hashCode();
			result = num2;
			this.m_hashCode = num2;
		}
		else
		{
			result = num;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(132)]
	public override string toString()
	{
		string result = @delegate.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(138)]
	internal override object writeReplace()
	{
		EnumSerializedForm result = new EnumSerializedForm(@delegate);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(33)]
	public new virtual Iterator iterator()
	{
		UnmodifiableIterator result = this.iterator();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Synthetic)]
	[LineNumberTable(36)]
	internal ImmutableEnumSet(EnumSet P_0, _1 P_1)
		: this(P_0)
	{
	}

	[HideFromJava]
	static ImmutableEnumSet()
	{
		ImmutableSet.___003Cclinit_003E();
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected ImmutableEnumSet(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
