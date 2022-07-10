using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableCollection<TV;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal sealed class ImmutableMapValues : ImmutableCollection
{
	[SpecialName]
	[Signature("Lcom/google/common/collect/UnmodifiableIterator<TV;>;")]
	[EnclosingMethod(null, "iterator", "()Lcom.google.common.collect.UnmodifiableIterator;")]
	internal class _1 : UnmodifiableIterator
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/collect/UnmodifiableIterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
		internal UnmodifiableIterator entryItr;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ImmutableMapValues this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 1, 111 })]
		internal _1(ImmutableMapValues P_0)
		{
			this_00240 = P_0;
			base._002Ector();
			entryItr = access_0024000(this_00240).entrySet().iterator();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(56)]
		public override bool hasNext()
		{
			bool result = entryItr.hasNext();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TV;")]
		[LineNumberTable(61)]
		public override object next()
		{
			object value = ((Map.Entry)entryItr.next()).getValue();
			_ = null;
			return value;
		}
	}

	[Serializable]
	[SpecialName]
	[Signature("Lcom/google/common/collect/ImmutableAsList<TV;>;")]
	[EnclosingMethod(null, "asList", "()Lcom.google.common.collect.ImmutableList;")]
	internal class _2 : ImmutableAsList
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ImmutableList val_0024entryList;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ImmutableMapValues this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(84)]
		internal _2(ImmutableMapValues P_0, ImmutableList P_1)
		{
			this_00240 = P_0;
			val_0024entryList = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)TV;")]
		[LineNumberTable(87)]
		public override object get(int P_0)
		{
			object value = ((Map.Entry)val_0024entryList.get(P_0)).getValue();
			_ = null;
			return value;
		}

		[Signature("()Lcom/google/common/collect/ImmutableCollection<TV;>;")]
		internal override ImmutableCollection delegateCollection()
		{
			return this_00240;
		}

		[HideFromJava]
		static _2()
		{
			ImmutableAsList.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected _2(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<V:Ljava/lang/Object;>Ljava/lang/Object;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.io.Serializable" })]
	internal class SerializedForm : java.lang.Object, Serializable.__Interface, ISerializable, IObjectReference
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/collect/ImmutableMap<*TV;>;")]
		internal ImmutableMap map;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableMap<*TV;>;)V")]
		[LineNumberTable(new byte[] { 60, 104, 103 })]
		internal SerializedForm(ImmutableMap P_0)
		{
			map = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(115)]
		internal virtual object readResolve()
		{
			ImmutableCollection result = map.values();
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

	[SpecialName]
	private sealed class ___003C_003EAnon0 : java.util.function.Function
	{
		internal ___003C_003EAnon0()
		{
		}

		public object apply(object P_0)
		{
			object value = ((Map.Entry)P_0).getValue();
			_ = null;
			return value;
		}

		[SpecialName]
		public java.util.function.Function compose(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
		}

		[SpecialName]
		public java.util.function.Function andThen(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon1 : BiConsumer
	{
		private readonly Consumer arg_00241;

		internal ___003C_003EAnon1(Consumer P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024forEach_00240(arg_00241, P_0, P_1);
			_ = null;
		}

		[SpecialName]
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
	private ImmutableMap map;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/ImmutableMap<TK;TV;>;)V")]
	[LineNumberTable(new byte[] { 159, 182, 104, 103 })]
	internal ImmutableMapValues(ImmutableMap P_0)
	{
		map = P_0;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(37)]
	internal static ImmutableMap access_0024000(ImmutableMapValues P_0)
	{
		return P_0.map;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TV;>;")]
	[LineNumberTable(51)]
	public override UnmodifiableIterator iterator()
	{
		_1 result = new _1(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(101)]
	private static void lambda_0024forEach_00240(Consumer P_0, object P_1, object P_2)
	{
		P_0.accept(P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(46)]
	public override int size()
	{
		int result = map.size();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Spliterator<TV;>;")]
	[LineNumberTable(68)]
	public override Spliterator spliterator()
	{
		Spliterator result = CollectSpliterators.map(map.entrySet().spliterator(), new ___003C_003EAnon0());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(73)]
	public override bool contains([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		return (P_0 != null && Iterators.contains(this.iterator(), P_0)) ? true : false;
	}

	internal override bool isPartialView()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableList<TV;>;")]
	[LineNumberTable(new byte[] { 33, 113 })]
	public override ImmutableList asList()
	{
		ImmutableList immutableList = map.entrySet().asList();
		_2 result = new _2(this, immutableList);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/function/Consumer<-TV;>;)V")]
	[LineNumberTable(new byte[] { 50, 103, 120 })]
	public override void forEach(Consumer P_0)
	{
		Preconditions.checkNotNull(P_0);
		map.forEach(new ___003C_003EAnon1(P_0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(35)]
	public new virtual Iterator iterator()
	{
		UnmodifiableIterator result = this.iterator();
		_ = null;
		return result;
	}

	[HideFromJava]
	static ImmutableMapValues()
	{
		ImmutableCollection.___003Cclinit_003E();
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected ImmutableMapValues(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
