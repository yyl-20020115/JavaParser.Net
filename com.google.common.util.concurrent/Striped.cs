using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.common.collect;
using com.google.common.math;
using IKVM.Attributes;
using java.lang;
using java.lang.@ref;
using java.math;
using java.util;
using java.util.concurrent;
using java.util.concurrent.atomic;
using java.util.concurrent.locks;

namespace com.google.common.util.concurrent;

[Signature("<L:Ljava/lang/Object;>Ljava/lang/Object;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
public abstract class Striped : java.lang.Object
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

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<L:Ljava/lang/Object;>Lcom/google/common/util/concurrent/Striped$PowerOfTwoStriped<TL;>;")]
	internal class CompactStriped : PowerOfTwoStriped
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private object[] array;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(363)]
		internal CompactStriped(int P_0, Supplier P_1, _1 P_2)
			: this(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(ILcom/google/common/base/Supplier<TL;>;)V")]
		[LineNumberTable(new byte[] { 160, 254, 105, 149, 115, 108, 46, 166 })]
		private CompactStriped(int P_0, Supplier P_1)
			: base(P_0)
		{
			Preconditions.checkArgument(P_0 <= 1073741824, (object)"Stripes must be <= 2^30)");
			array = new object[mask + 1];
			for (int i = 0; i < (nint)array.LongLength; i++)
			{
				array[i] = P_1.get();
			}
		}

		[Signature("(I)TL;")]
		[LineNumberTable(380)]
		public override object getAt(int P_0)
		{
			return array[P_0];
		}

		[LineNumberTable(385)]
		public override int size()
		{
			return array.Length;
		}
	}

	[Signature("<L:Ljava/lang/Object;>Lcom/google/common/util/concurrent/Striped$PowerOfTwoStriped<TL;>;")]
	internal class LargeLazyStriped : PowerOfTwoStriped
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/concurrent/ConcurrentMap<Ljava/lang/Integer;TL;>;")]
		internal ConcurrentMap locks;

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/base/Supplier<TL;>;")]
		internal Supplier supplier;

		[Modifiers(Modifiers.Final)]
		internal new int size;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(ILcom/google/common/base/Supplier<TL;>;)V")]
		[LineNumberTable(new byte[] { 161, 103, 105, 126, 103, 117 })]
		internal LargeLazyStriped(int P_0, Supplier P_1)
			: base(P_0)
		{
			this.size = ((mask != -1) ? (mask + 1) : int.MaxValue);
			supplier = P_1;
			locks = new MapMaker().weakValues().makeMap();
		}

		public override int size()
		{
			return this.size;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)TL;")]
		[LineNumberTable(new byte[] { 161, 111, 109, 141, 114, 99, 130, 108, 115 })]
		public override object getAt(int P_0)
		{
			if (this.size != int.MaxValue)
			{
				Preconditions.checkElementIndex(P_0, size());
			}
			object obj = locks.get(Integer.valueOf(P_0));
			if (obj != null)
			{
				return obj;
			}
			object obj2 = supplier.get();
			obj = locks.putIfAbsent(Integer.valueOf(P_0), obj2);
			object result = MoreObjects.firstNonNull(obj, obj2);
			_ = null;
			return result;
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	internal class PaddedLock : ReentrantLock
	{
		internal long unused1;

		internal long unused2;

		internal long unused3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 161, 105 })]
		internal PaddedLock()
			: base(fair: false)
		{
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected PaddedLock(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	internal class PaddedSemaphore : Semaphore
	{
		internal long unused1;

		internal long unused2;

		internal long unused3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 172, 106 })]
		internal PaddedSemaphore(int P_0)
			: base(P_0, fair: false)
		{
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected PaddedSemaphore(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Abstract)]
	[Signature("<L:Ljava/lang/Object;>Lcom/google/common/util/concurrent/Striped<TL;>;")]
	internal abstract class PowerOfTwoStriped : Striped
	{
		[Modifiers(Modifiers.Final)]
		internal int mask;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 235, 108 })]
		internal sealed override int indexFor(object P_0)
		{
			int num = access_0024300(java.lang.Object.instancehelper_hashCode(P_0));
			return num & mask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 228, 105, 110, 121 })]
		internal PowerOfTwoStriped(int P_0)
			: base(null)
		{
			Preconditions.checkArgument(P_0 > 0, (object)"Stripes must be positive");
			mask = ((P_0 <= 1073741824) ? (access_0024200(P_0) - 1) : (-1));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)TL;")]
		[LineNumberTable(355)]
		public sealed override object get(object P_0)
		{
			object at = getAt(indexFor(P_0));
			_ = null;
			return at;
		}
	}

	[Signature("<L:Ljava/lang/Object;>Lcom/google/common/util/concurrent/Striped$PowerOfTwoStriped<TL;>;")]
	[ConstantPool(new object[]
	{
		(byte)35,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class SmallLazyStriped : PowerOfTwoStriped
	{
		[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
		[Signature("<L:Ljava/lang/Object;>Ljava/lang/ref/WeakReference<TL;>;")]
		internal sealed class ArrayReference : java.lang.@ref.WeakReference
		{
			[Modifiers(Modifiers.Final)]
			internal int index;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(TL;ILjava/lang/ref/ReferenceQueue<TL;>;)V")]
			[LineNumberTable(new byte[] { 161, 85, 106, 103 })]
			internal ArrayReference(object P_0, int P_1, ReferenceQueue P_2)
				: base(P_0, P_2)
			{
				index = P_1;
			}
		}

		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/concurrent/atomic/AtomicReferenceArray<Lcom/google/common/util/concurrent/Striped$SmallLazyStriped$ArrayReference<+TL;>;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 1, 3, 0, 0, 35, 0, 0 })]
		internal AtomicReferenceArray locks;

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/base/Supplier<TL;>;")]
		internal Supplier supplier;

		[Modifiers(Modifiers.Final)]
		internal new int size;

		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/lang/ref/ReferenceQueue<TL;>;")]
		internal ReferenceQueue queue;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(ILcom/google/common/base/Supplier<TL;>;)V")]
		[LineNumberTable(new byte[] { 161, 32, 233, 61, 203, 126, 118, 103 })]
		internal SmallLazyStriped(int P_0, Supplier P_1)
			: base(P_0)
		{
			queue = new ReferenceQueue();
			this.size = ((mask != -1) ? (mask + 1) : int.MaxValue);
			AtomicReferenceArray.___003Cclinit_003E();
			locks = new AtomicReferenceArray(this.size);
			supplier = P_1;
		}

		public override int size()
		{
			return this.size;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 67, 143, 167, 116, 98 })]
		private void drainQueue()
		{
			Reference reference;
			while ((reference = queue.poll()) != null)
			{
				ArrayReference arrayReference = (ArrayReference)reference;
				locks.compareAndSet(arrayReference.index, arrayReference, null);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)TL;")]
		[LineNumberTable(new byte[]
		{
			161, 40, 109, 141, 114, 109, 99, 130, 108, 110,
			144, 114, 109, 99, 162, 102
		})]
		public override object getAt(int P_0)
		{
			if (this.size != int.MaxValue)
			{
				Preconditions.checkElementIndex(P_0, size());
			}
			ArrayReference arrayReference = (ArrayReference)locks.get(P_0);
			object obj = arrayReference?.get();
			if (obj != null)
			{
				return obj;
			}
			object obj2 = supplier.get();
			ArrayReference update = new ArrayReference(obj2, P_0, queue);
			while (!locks.compareAndSet(P_0, arrayReference, update))
			{
				arrayReference = (ArrayReference)locks.get(P_0);
				obj = arrayReference?.get();
				if (obj != null)
				{
					return obj;
				}
			}
			drainQueue();
			return obj2;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class WeakSafeCondition : ForwardingCondition
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private new Condition m_delegate;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private WeakSafeReadWriteLock strongReference;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 213, 104, 103, 103 })]
		internal WeakSafeCondition(Condition P_0, WeakSafeReadWriteLock P_1)
		{
			this.m_delegate = P_0;
			strongReference = P_1;
		}

		internal override Condition @delegate()
		{
			return this.m_delegate;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class WeakSafeLock : ForwardingLock
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private new Lock m_delegate;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private WeakSafeReadWriteLock strongReference;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 190, 104, 103, 103 })]
		internal WeakSafeLock(Lock P_0, WeakSafeReadWriteLock P_1)
		{
			this.m_delegate = P_0;
			strongReference = P_1;
		}

		internal override Lock @delegate()
		{
			return this.m_delegate;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(316)]
		public override Condition newCondition()
		{
			WeakSafeCondition result = new WeakSafeCondition(this.m_delegate.newCondition(), strongReference);
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class WeakSafeReadWriteLock : java.lang.Object, ReadWriteLock
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private ReadWriteLock @delegate;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 168, 104, 107 })]
		internal WeakSafeReadWriteLock()
		{
			@delegate = new ReentrantReadWriteLock();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(288)]
		public virtual Lock readLock()
		{
			WeakSafeLock result = new WeakSafeLock(@delegate.readLock(), this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(293)]
		public virtual Lock writeLock()
		{
			WeakSafeLock result = new WeakSafeLock(@delegate.writeLock(), this);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon0 : Supplier
	{
		internal ___003C_003EAnon0()
		{
		}

		public object get()
		{
			Lock result = new PaddedLock();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon1 : Supplier
	{
		internal ___003C_003EAnon1()
		{
		}

		public object get()
		{
			Lock result = lambda_0024lazyWeakLock_00240();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon2 : Supplier
	{
		private readonly int arg_00241;

		internal ___003C_003EAnon2(int P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			Semaphore result = lambda_0024semaphore_00241(arg_00241);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon3 : Supplier
	{
		private readonly int arg_00241;

		internal ___003C_003EAnon3(int P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			Semaphore result = lambda_0024lazyWeakSemaphore_00242(arg_00241);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon4 : Supplier
	{
		internal ___003C_003EAnon4()
		{
		}

		public object get()
		{
			ReadWriteLock result = new ReentrantReadWriteLock();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon5 : Supplier
	{
		internal ___003C_003EAnon5()
		{
		}

		public object get()
		{
			ReadWriteLock result = new WeakSafeReadWriteLock();
			_ = null;
			return result;
		}
	}

	private const int LARGE_LAZY_CUTOFF = 1024;

	private const int ALL_SET = -1;

	private static int smear(int P_0)
	{
		P_0 ^= (int)(((uint)P_0 >> 20) ^ ((uint)P_0 >> 12));
		return P_0 ^ (int)((uint)P_0 >> 7) ^ (int)((uint)P_0 >> 4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(503)]
	private static int ceilToPowerOfTwo(int P_0)
	{
		return 1 << IntMath.log2(P_0, RoundingMode.CEILING);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(96)]
	private Striped()
	{
	}

	[Modifiers(Modifiers.Abstract)]
	internal virtual int indexFor(object P_0)
	{
		throw new AbstractMethodError("com.google.common.util.concurrent.Striped.indexFor(Ljava.lang.Object;)I");
	}

	[Signature("(I)TL;")]
	public abstract object getAt(int i);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<L:Ljava/lang/Object;>(ILcom/google/common/base/Supplier<TL;>;)Lcom/google/common/util/concurrent/Striped<TL;>;")]
	[LineNumberTable(198)]
	internal static Striped custom(int P_0, Supplier P_1)
	{
		CompactStriped result = new CompactStriped(P_0, P_1, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<L:Ljava/lang/Object;>(ILcom/google/common/base/Supplier<TL;>;)Lcom/google/common/util/concurrent/Striped<TL;>;")]
	[LineNumberTable(new byte[] { 160, 110, 104, 105, 9 })]
	private static Striped lazy(int P_0, Supplier P_1)
	{
		PowerOfTwoStriped result = ((P_0 >= 1024) ? ((PowerOfTwoStriped)new LargeLazyStriped(P_0, P_1)) : ((PowerOfTwoStriped)new SmallLazyStriped(P_0, P_1)));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(220)]
	private static Lock lambda_0024lazyWeakLock_00240()
	{
		ReentrantLock result = new ReentrantLock(fair: false);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(238)]
	private static Semaphore lambda_0024semaphore_00241(int P_0)
	{
		PaddedSemaphore result = new PaddedSemaphore(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(250)]
	private static Semaphore lambda_0024lazyWeakSemaphore_00242(int P_0)
	{
		Semaphore result = new Semaphore(P_0, fair: false);
		_ = null;
		return result;
	}

	[Signature("(Ljava/lang/Object;)TL;")]
	public abstract object get(object obj);

	public abstract int size();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<+Ljava/lang/Object;>;)Ljava/lang/Iterable<TL;>;")]
	[LineNumberTable(new byte[]
	{
		94, 103, 104, 136, 108, 107, 48, 166, 134, 100,
		111, 107, 101, 101, 147, 112, 227, 58, 230, 91,
		99
	})]
	public virtual Iterable bulkGet(Iterable keys)
	{
		ArrayList arrayList = Lists.newArrayList(keys);
		if (((List)arrayList).isEmpty())
		{
			ImmutableList result = ImmutableList.of();
			_ = null;
			return result;
		}
		int[] array = new int[((List)arrayList).size()];
		int i;
		for (i = 0; i < ((List)arrayList).size(); i++)
		{
			array[i] = indexFor(((List)arrayList).get(i));
		}
		Arrays.sort(array);
		i = array[0];
		((List)arrayList).set(0, getAt(i));
		for (int j = 1; j < ((List)arrayList).size(); j++)
		{
			int num = array[j];
			if (num == i)
			{
				((List)arrayList).set(j, ((List)arrayList).get(j - 1));
				continue;
			}
			((List)arrayList).set(j, getAt(num));
			i = num;
		}
		ArrayList list = arrayList;
		List result2 = Collections.unmodifiableList(list);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)Lcom/google/common/util/concurrent/Striped<Ljava/util/concurrent/locks/Lock;>;")]
	[LineNumberTable(209)]
	public static Striped @lock(int stripes)
	{
		Striped result = custom(stripes, new ___003C_003EAnon0());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)Lcom/google/common/util/concurrent/Striped<Ljava/util/concurrent/locks/Lock;>;")]
	[LineNumberTable(220)]
	public static Striped lazyWeakLock(int stripes)
	{
		Striped result = lazy(stripes, new ___003C_003EAnon1());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(II)Lcom/google/common/util/concurrent/Striped<Ljava/util/concurrent/Semaphore;>;")]
	[LineNumberTable(238)]
	public static Striped semaphore(int stripes, int permits)
	{
		Striped result = custom(stripes, new ___003C_003EAnon2(permits));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(II)Lcom/google/common/util/concurrent/Striped<Ljava/util/concurrent/Semaphore;>;")]
	[LineNumberTable(250)]
	public static Striped lazyWeakSemaphore(int stripes, int permits)
	{
		Striped result = lazy(stripes, new ___003C_003EAnon3(permits));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)Lcom/google/common/util/concurrent/Striped<Ljava/util/concurrent/locks/ReadWriteLock;>;")]
	[LineNumberTable(261)]
	public static Striped readWriteLock(int stripes)
	{
		Striped result = custom(stripes, new ___003C_003EAnon4());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)Lcom/google/common/util/concurrent/Striped<Ljava/util/concurrent/locks/ReadWriteLock;>;")]
	[LineNumberTable(272)]
	public static Striped lazyWeakReadWriteLock(int stripes)
	{
		Striped result = lazy(stripes, new ___003C_003EAnon5());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Synthetic)]
	[LineNumberTable(88)]
	internal Striped(_1 P_0)
		: this()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(88)]
	internal static int access_0024200(int P_0)
	{
		int result = ceilToPowerOfTwo(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(88)]
	internal static int access_0024300(int P_0)
	{
		int result = smear(P_0);
		_ = null;
		return result;
	}
}
