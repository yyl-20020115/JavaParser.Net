using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using com.google.common.@base;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util.concurrent.atomic;
using java.util.function;

namespace com.google.common.cache;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/cache/ElementTypesAreNonnullByDefault;"
})]
internal sealed class LongAddables : java.lang.Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Lcom/google/common/base/Supplier<Lcom/google/common/cache/LongAddable;>;")]
	[EnclosingMethod(null, null, null)]
	[Implements(new string[] { "com.google.common.base.Supplier" })]
	internal class _1 : java.lang.Object, com.google.common.@base.Supplier, java.util.function.Supplier
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(40)]
		public virtual LongAddable get()
		{
			LongAdder result = new LongAdder();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(37)]
		internal _1()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(37)]
		public virtual object get()
		{
			LongAddable result = this.get();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Lcom/google/common/base/Supplier<Lcom/google/common/cache/LongAddable;>;")]
	[EnclosingMethod(null, null, null)]
	[Implements(new string[] { "com.google.common.base.Supplier" })]
	internal class _2 : java.lang.Object, com.google.common.@base.Supplier, java.util.function.Supplier
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(45)]
		internal _2()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(48)]
		public virtual LongAddable get()
		{
			PureJavaLongAddable result = new PureJavaLongAddable(null);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(45)]
		public virtual object get()
		{
			LongAddable result = this.get();
			_ = null;
			return result;
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Implements(new string[] { "com.google.common.cache.LongAddable" })]
	internal sealed class PureJavaLongAddable : AtomicLong, LongAddable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(59)]
		internal PureJavaLongAddable(_1 P_0)
			: this()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(59)]
		private PureJavaLongAddable()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 12, 103 })]
		public virtual void increment()
		{
			getAndIncrement();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 17, 104 })]
		public virtual void add(long P_0)
		{
			getAndAdd(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(72)]
		public virtual long sum()
		{
			long result = get();
			_ = null;
			return result;
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected PureJavaLongAddable(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/base/Supplier<Lcom/google/common/cache/LongAddable;>;")]
	private static com.google.common.@base.Supplier SUPPLIER;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(56)]
	public static LongAddable create()
	{
		return (LongAddable)SUPPLIER.get();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(28)]
	internal LongAddables()
	{
	}

	[LineNumberTable(new byte[]
	{
		159, 177, 102, 247, 79, 226, 56, 97, 230, 72,
		121
	})]
	static LongAddables()
	{
		object obj;
		try
		{
			new LongAdder();
			obj = new _1();
		}
		catch (System.Exception x)
		{
			ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.Unused);
			goto IL_001a;
		}
		goto IL_0026;
		IL_001a:
		_ = null;
		obj = new _2();
		goto IL_0026;
		IL_0026:
		object obj2 = obj;
		SUPPLIER = ((obj2 == null) ? null : ((obj2 as com.google.common.@base.Supplier) ?? throw new java.lang.IncompatibleClassChangeError()));
	}
}
