using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using com.google.common.@base;
using IKVM.Attributes;
using java.util;
using java.util.function;

namespace com.google.common.collect;

[Serializable]
[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableSet$CachingAsList<TE;>;")]
[ConstantPool(new object[]
{
	(byte)55,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal abstract class IndexedImmutableSet : ImmutableSet.CachingAsList
{
	[Serializable]
	[SpecialName]
	[Signature("Lcom/google/common/collect/ImmutableAsList<TE;>;")]
	[EnclosingMethod(null, "createAsList", "()Lcom.google.common.collect.ImmutableList;")]
	internal class _1 : ImmutableAsList
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal IndexedImmutableSet this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(59)]
		internal _1(IndexedImmutableSet P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)TE;")]
		[LineNumberTable(62)]
		public override object get(int P_0)
		{
			object result = this_00240.get(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(67)]
		internal override bool isPartialView()
		{
			bool result = this_00240.isPartialView();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(72)]
		public override int size()
		{
			int result = this_00240.size();
			_ = null;
			return result;
		}

		[Signature("()Lcom/google/common/collect/ImmutableCollection<TE;>;")]
		internal override ImmutableCollection delegateCollection()
		{
			return this_00240;
		}

		[HideFromJava]
		static _1()
		{
			ImmutableAsList.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected _1(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon0 : IntFunction
	{
		private readonly IndexedImmutableSet arg_00241;

		internal ___003C_003EAnon0(IndexedImmutableSet P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(int P_0)
		{
			object result = arg_00241.get(P_0);
			_ = null;
			return result;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	protected internal new static void ___003Cclinit_003E()
	{
	}

	[Signature("(I)TE;")]
	internal abstract object get(int P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TE;>;")]
	[LineNumberTable(34)]
	public override UnmodifiableIterator iterator()
	{
		UnmodifiableIterator result = asList().iterator();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(29)]
	internal IndexedImmutableSet()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Spliterator<TE;>;")]
	[LineNumberTable(39)]
	public override Spliterator spliterator()
	{
		Spliterator result = CollectSpliterators.indexed(size(), 1297, new ___003C_003EAnon0(this));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/function/Consumer<-TE;>;)V")]
	[LineNumberTable(new byte[] { 159, 186, 103, 103, 102, 45, 166 })]
	public override void forEach(Consumer P_0)
	{
		Preconditions.checkNotNull(P_0);
		int num = size();
		for (int i = 0; i < num; i++)
		{
			P_0.accept(get(i));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 0, 1, 0, 0, 0, 55, 0,
		0
	})]
	[LineNumberTable(54)]
	internal override int copyIntoArray(object[] P_0, int P_1)
	{
		int result = asList().copyIntoArray(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableList<TE;>;")]
	[LineNumberTable(59)]
	internal override ImmutableList createAsList()
	{
		_1 result = new _1(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(27)]
	public override Iterator iterator()
	{
		UnmodifiableIterator result = this.iterator();
		_ = null;
		return result;
	}

	[HideFromJava]
	static IndexedImmutableSet()
	{
		CachingAsList.___003Cclinit_003E();
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected IndexedImmutableSet(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
