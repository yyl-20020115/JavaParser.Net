using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.common.collect;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util;
using java.util.concurrent;
using java.util.concurrent.locks;
using java.util.logging;
using javax.annotation;

namespace com.google.common.util.concurrent;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
public class CycleDetectingLockFactory : java.lang.Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/ThreadLocal<Ljava/util/ArrayList<Lcom/google/common/util/concurrent/CycleDetectingLockFactory$LockGraphNode;>;>;")]
	[EnclosingMethod(null, null, null)]
	internal class _1 : ThreadLocal
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/ArrayList<Lcom/google/common/util/concurrent/CycleDetectingLockFactory$LockGraphNode;>;")]
		[LineNumberTable(473)]
		protected internal new virtual ArrayList initialValue()
		{
			ArrayList result = Lists.newArrayListWithCapacity(3);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(470)]
		internal _1()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(470)]
		protected internal override object initialValue()
		{
			ArrayList result = initialValue();
			_ = null;
			return result;
		}

		[HideFromJava]
		static _1()
		{
			ThreadLocal.___003Cclinit_003E();
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Interface | Modifiers.Abstract)]
	internal interface CycleDetectingLock
	{
		virtual bool isAcquiredByCurrentThread();

		virtual LockGraphNode getLockGraphNode();
	}

	[Serializable]
	[Implements(new string[] { "com.google.common.util.concurrent.CycleDetectingLockFactory$CycleDetectingLock" })]
	internal sealed class CycleDetectingReentrantLock : ReentrantLock, CycleDetectingLock
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private LockGraphNode lockGraphNode;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal CycleDetectingLockFactory this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(747)]
		internal CycleDetectingReentrantLock(CycleDetectingLockFactory P_0, LockGraphNode P_1, bool P_2, _1 P_3)
			: this(P_0, P_1, P_2)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 158, 211, 162, 103, 105, 113 })]
		private CycleDetectingReentrantLock(CycleDetectingLockFactory P_0, LockGraphNode P_1, bool P_2)
		{
			this_00240 = P_0;
			base._002Ector(P_2);
			lockGraphNode = (LockGraphNode)Preconditions.checkNotNull(P_1);
		}

		public virtual LockGraphNode getLockGraphNode()
		{
			return lockGraphNode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(765)]
		public virtual bool isAcquiredByCurrentThread()
		{
			bool result = base.isHeldByCurrentThread();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 146, 140, 138, 102, 35, 98, 98 })]
		public override void @lock()
		{
			access_0024600(this_00240, this);
			try
			{
				base.@lock();
			}
			finally
			{
				access_0024700(this);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.InterruptedException" })]
		[LineNumberTable(new byte[] { 162, 156, 140, 138, 102, 35, 98, 98 })]
		public override void lockInterruptibly()
		{
			access_0024600(this_00240, this);
			try
			{
				base.lockInterruptibly();
			}
			finally
			{
				access_0024700(this);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 166, 140, 139, 102, 35, 2 })]
		public override bool tryLock()
		{
			access_0024600(this_00240, this);
			try
			{
				return base.tryLock();
			}
			finally
			{
				access_0024700(this);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.InterruptedException" })]
		[LineNumberTable(new byte[] { 162, 176, 140, 141, 102, 35, 2 })]
		public override bool tryLock(long P_0, TimeUnit P_1)
		{
			access_0024600(this_00240, this);
			try
			{
				return base.tryLock(P_0, P_1);
			}
			finally
			{
				access_0024700(this);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 187, 138, 102, 35, 98, 98 })]
		public override void unlock()
		{
			try
			{
				base.unlock();
			}
			finally
			{
				access_0024700(this);
			}
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected CycleDetectingReentrantLock(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private)]
	internal class CycleDetectingReentrantReadLock : ReentrantReadWriteLock.ReadLock
	{
		[Modifiers(Modifiers.Final)]
		internal CycleDetectingReentrantReadWriteLock readWriteLock;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal CycleDetectingLockFactory this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 242, 103, 105, 103 })]
		internal CycleDetectingReentrantReadLock(CycleDetectingLockFactory P_0, CycleDetectingReentrantReadWriteLock P_1)
		{
			this_00240 = P_0;
			base._002Ector(P_1);
			readWriteLock = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 249, 145, 138, 107, 35, 98, 98 })]
		public override void @lock()
		{
			access_0024600(this_00240, readWriteLock);
			try
			{
				base.@lock();
			}
			finally
			{
				access_0024700(readWriteLock);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.InterruptedException" })]
		[LineNumberTable(new byte[] { 163, 3, 145, 138, 107, 35, 98, 98 })]
		public override void lockInterruptibly()
		{
			access_0024600(this_00240, readWriteLock);
			try
			{
				base.lockInterruptibly();
			}
			finally
			{
				access_0024700(readWriteLock);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 13, 145, 139, 107, 35, 2 })]
		public override bool tryLock()
		{
			access_0024600(this_00240, readWriteLock);
			try
			{
				return base.tryLock();
			}
			finally
			{
				access_0024700(readWriteLock);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.InterruptedException" })]
		[LineNumberTable(new byte[] { 163, 23, 145, 141, 107, 35, 2 })]
		public override bool tryLock(long P_0, TimeUnit P_1)
		{
			access_0024600(this_00240, readWriteLock);
			try
			{
				return base.tryLock(P_0, P_1);
			}
			finally
			{
				access_0024700(readWriteLock);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 34, 138, 107, 35, 98, 98 })]
		public override void unlock()
		{
			try
			{
				base.unlock();
			}
			finally
			{
				access_0024700(readWriteLock);
			}
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected CycleDetectingReentrantReadLock(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Final)]
	[Implements(new string[] { "com.google.common.util.concurrent.CycleDetectingLockFactory$CycleDetectingLock" })]
	internal sealed class CycleDetectingReentrantReadWriteLock : ReentrantReadWriteLock, CycleDetectingLock
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private new CycleDetectingReentrantReadLock m_readLock;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private new CycleDetectingReentrantWriteLock m_writeLock;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private LockGraphNode lockGraphNode;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(820)]
		internal CycleDetectingReentrantReadWriteLock(CycleDetectingLockFactory P_0, LockGraphNode P_1, bool P_2, _1 P_3)
			: this(P_0, P_1, P_2)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 158, 190, 98, 105, 109, 109, 113 })]
		private CycleDetectingReentrantReadWriteLock(CycleDetectingLockFactory P_0, LockGraphNode P_1, bool P_2)
			: base(P_2)
		{
			this.m_readLock = new CycleDetectingReentrantReadLock(P_0, this);
			this.m_writeLock = new CycleDetectingReentrantWriteLock(P_0, this);
			lockGraphNode = (LockGraphNode)Preconditions.checkNotNull(P_1);
		}

		public override WriteLock writeLock()
		{
			return this.m_writeLock;
		}

		public override ReadLock readLock()
		{
			return this.m_readLock;
		}

		public virtual LockGraphNode getLockGraphNode()
		{
			return lockGraphNode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(860)]
		public virtual bool isAcquiredByCurrentThread()
		{
			return (base.isWriteLockedByCurrentThread() || base.getReadHoldCount() > 0) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(820)]
		public new virtual Lock writeLock()
		{
			WriteLock result = this.writeLock();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(820)]
		public new virtual Lock readLock()
		{
			ReadLock result = this.readLock();
			_ = null;
			return result;
		}

		[HideFromJava]
		static CycleDetectingReentrantReadWriteLock()
		{
			ReentrantReadWriteLock.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected CycleDetectingReentrantReadWriteLock(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private)]
	internal class CycleDetectingReentrantWriteLock : ReentrantReadWriteLock.WriteLock
	{
		[Modifiers(Modifiers.Final)]
		internal CycleDetectingReentrantReadWriteLock readWriteLock;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal CycleDetectingLockFactory this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 45, 103, 105, 103 })]
		internal CycleDetectingReentrantWriteLock(CycleDetectingLockFactory P_0, CycleDetectingReentrantReadWriteLock P_1)
		{
			this_00240 = P_0;
			base._002Ector(P_1);
			readWriteLock = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 52, 145, 138, 107, 35, 98, 98 })]
		public override void @lock()
		{
			access_0024600(this_00240, readWriteLock);
			try
			{
				base.@lock();
			}
			finally
			{
				access_0024700(readWriteLock);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.InterruptedException" })]
		[LineNumberTable(new byte[] { 163, 62, 145, 138, 107, 35, 98, 98 })]
		public override void lockInterruptibly()
		{
			access_0024600(this_00240, readWriteLock);
			try
			{
				base.lockInterruptibly();
			}
			finally
			{
				access_0024700(readWriteLock);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 72, 145, 139, 107, 35, 2 })]
		public override bool tryLock()
		{
			access_0024600(this_00240, readWriteLock);
			try
			{
				return base.tryLock();
			}
			finally
			{
				access_0024700(readWriteLock);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.InterruptedException" })]
		[LineNumberTable(new byte[] { 163, 82, 145, 141, 107, 35, 2 })]
		public override bool tryLock(long P_0, TimeUnit P_1)
		{
			access_0024600(this_00240, readWriteLock);
			try
			{
				return base.tryLock(P_0, P_1);
			}
			finally
			{
				access_0024700(readWriteLock);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 93, 138, 107, 35, 98, 98 })]
		public override void unlock()
		{
			try
			{
				base.unlock();
			}
			finally
			{
				access_0024700(readWriteLock);
			}
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected CycleDetectingReentrantWriteLock(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	internal class ExampleStackTrace : IllegalStateException
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static StackTraceElement[] EMPTY_STACK_TRACE;

		[Modifiers(Modifiers.Static | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/ImmutableSet<Ljava/lang/String;>;")]
		internal static ImmutableSet EXCLUDED_CLASS_NAMES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161, 131, 127, 52, 104, 113, 155, 107, 130, 118,
			118, 226, 56, 235, 75
		})]
		internal ExampleStackTrace(LockGraphNode P_0, LockGraphNode P_1)
		{
			string lockName = P_0.getLockName();
			string lockName2 = P_1.getLockName();
			base._002Ector(new StringBuilder(4 + java.lang.String.instancehelper_length(java.lang.String.valueOf(lockName)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(lockName2))).append(lockName).append(" -> ").append(lockName2)
				.toString());
			StackTraceElement[] array = Throwable.instancehelper_getStackTrace(this);
			int i = 0;
			for (int num = array.Length; i < num; i++)
			{
				if (java.lang.String.instancehelper_equals(ClassLiteral<WithExplicitOrdering>.Value.getName(), array[i].getClassName()))
				{
					Throwable.instancehelper_setStackTrace(this, EMPTY_STACK_TRACE);
					break;
				}
				if (!EXCLUDED_CLASS_NAMES.contains(array[i].getClassName()))
				{
					Throwable.instancehelper_setStackTrace(this, (StackTraceElement[])Arrays.copyOfRange(array, i, num));
					break;
				}
			}
		}

		[LineNumberTable(new byte[] { 161, 122, 139, 133, 106, 106, 229, 61, 42 })]
		static ExampleStackTrace()
		{
			EMPTY_STACK_TRACE = new StackTraceElement[0];
			EXCLUDED_CLASS_NAMES = ImmutableSet.of(ClassLiteral<CycleDetectingLockFactory>.Value.getName(), ClassLiteral<ExampleStackTrace>.Value.getName(), ClassLiteral<LockGraphNode>.Value.getName());
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected ExampleStackTrace(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	internal class LockGraphNode : java.lang.Object
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Map<Lcom/google/common/util/concurrent/CycleDetectingLockFactory$LockGraphNode;Lcom/google/common/util/concurrent/CycleDetectingLockFactory$ExampleStackTrace;>;")]
		internal Map allowedPriorLocks;

		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Map<Lcom/google/common/util/concurrent/CycleDetectingLockFactory$LockGraphNode;Lcom/google/common/util/concurrent/CycleDetectingLockFactory$PotentialDeadlockException;>;")]
		internal Map disallowedPriorLocks;

		[Modifiers(Modifiers.Final)]
		internal string lockName;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161, 234, 232, 52, 102, 239, 70, 102, 239, 69,
			113
		})]
		internal LockGraphNode(string P_0)
		{
			allowedPriorLocks = new MapMaker().weakKeys().makeMap();
			disallowedPriorLocks = new MapMaker().weakKeys().makeMap();
			lockName = (string)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/CycleDetectingLockFactory$Policy;Ljava/util/List<Lcom/google/common/util/concurrent/CycleDetectingLockFactory$LockGraphNode;>;)V")]
		[LineNumberTable(new byte[] { 161, 243, 123, 104, 98 })]
		internal virtual void checkAcquiredLocks(Policy P_0, List P_1)
		{
			Iterator iterator = P_1.iterator();
			while (iterator.hasNext())
			{
				LockGraphNode lockGraphNode = (LockGraphNode)iterator.next();
				checkAcquiredLock(P_0, lockGraphNode);
			}
		}

		internal virtual string getLockName()
		{
			return lockName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			162, 8, 173, 229, 61, 229, 69, 206, 129, 114,
			195, 136, 108, 105, 193, 102, 137, 227, 73, 214,
			139, 111, 138
		})]
		internal virtual void checkAcquiredLock(Policy P_0, LockGraphNode P_1)
		{
			Preconditions.checkState(this != P_1, "Attempted to acquire multiple locks with the same rank %s", P_1.getLockName());
			if (allowedPriorLocks.containsKey(P_1))
			{
				return;
			}
			PotentialDeadlockException ex = (PotentialDeadlockException)disallowedPriorLocks.get(P_1);
			if (ex != null)
			{
				PotentialDeadlockException.___003Cclinit_003E();
				PotentialDeadlockException cdlfpde = new PotentialDeadlockException(P_1, this, ex.getConflictingStackTrace(), null);
				P_0.handlePotentialDeadlock(cdlfpde);
				return;
			}
			Set set = Sets.newIdentityHashSet();
			ExampleStackTrace exampleStackTrace = P_1.findPathTo(this, set);
			if (exampleStackTrace == null)
			{
				allowedPriorLocks.put(P_1, new ExampleStackTrace(P_1, this));
				return;
			}
			PotentialDeadlockException ex2 = new PotentialDeadlockException(P_1, this, exampleStackTrace, null);
			disallowedPriorLocks.put(P_1, ex2);
			P_0.handlePotentialDeadlock(ex2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/CycleDetectingLockFactory$LockGraphNode;Ljava/util/Set<Lcom/google/common/util/concurrent/CycleDetectingLockFactory$LockGraphNode;>;)Lcom/google/common/util/concurrent/CycleDetectingLockFactory$ExampleStackTrace;")]
		[LineNumberTable(new byte[]
		{
			162, 64, 105, 130, 114, 99, 162, 127, 9, 108,
			105, 195, 105, 119, 105, 131, 101
		})]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private ExampleStackTrace findPathTo(LockGraphNode P_0, Set P_1)
		{
			if (!P_1.add(this))
			{
				return null;
			}
			ExampleStackTrace exampleStackTrace = (ExampleStackTrace)allowedPriorLocks.get(P_0);
			if (exampleStackTrace != null)
			{
				return exampleStackTrace;
			}
			Iterator iterator = allowedPriorLocks.entrySet().iterator();
			while (iterator.hasNext())
			{
				Map.Entry entry = (Map.Entry)iterator.next();
				LockGraphNode lockGraphNode = (LockGraphNode)entry.getKey();
				exampleStackTrace = lockGraphNode.findPathTo(P_0, P_1);
				if (exampleStackTrace != null)
				{
					ExampleStackTrace exampleStackTrace2 = new ExampleStackTrace(lockGraphNode, this);
					Throwable.instancehelper_setStackTrace(exampleStackTrace2, Throwable.instancehelper_getStackTrace((ExampleStackTrace)entry.getValue()));
					Throwable.instancehelper_initCause(exampleStackTrace2, exampleStackTrace);
					return exampleStackTrace2;
				}
			}
			return null;
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Public | Modifiers.Static | Modifiers.Abstract | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/util/concurrent/CycleDetectingLockFactory$Policies;>;Lcom/google/common/util/concurrent/CycleDetectingLockFactory$Policy;")]
	[Modifiers(Modifiers.Public | Modifiers.Super | Modifiers.Abstract | Modifiers.Enum)]
	[Implements(new string[] { "com.google.common.util.concurrent.CycleDetectingLockFactory$Policy" })]
	public abstract class Policies : java.lang.Enum, Policy
	{
		[Serializable]
		[HideFromJava]
		public enum __Enum
		{
			THROW,
			WARN,
			DISABLED
		}

		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		internal sealed class _1 : Policies
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(203)]
			internal _1(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			[LineNumberTable(206)]
			public override void handlePotentialDeadlock(PotentialDeadlockException P_0)
			{
				throw Throwable.___003Cunmap_003E(P_0);
			}

			[HideFromJava]
			static _1()
			{
				Policies.___003Cclinit_003E();
			}
		}

		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		internal sealed class _2 : Policies
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(215)]
			internal _2(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 160, 104, 119 })]
			public override void handlePotentialDeadlock(PotentialDeadlockException P_0)
			{
				access_0024100().log(Level.SEVERE, "Detected potential deadlock", P_0);
			}

			[HideFromJava]
			static _2()
			{
				Policies.___003Cclinit_003E();
			}
		}

		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		internal sealed class _3 : Policies
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(230)]
			internal _3(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			public override void handlePotentialDeadlock(PotentialDeadlockException P_0)
			{
			}

			[HideFromJava]
			static _3()
			{
				Policies.___003Cclinit_003E();
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static Policies ___003C_003ETHROW;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static Policies ___003C_003EWARN;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static Policies ___003C_003EDISABLED;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static Policies[] _0024VALUES;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static Policies THROW
		{
			[HideFromJava]
			get
			{
				return ___003C_003ETHROW;
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static Policies WARN
		{
			[HideFromJava]
			get
			{
				return ___003C_003EWARN;
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static Policies DISABLED
		{
			[HideFromJava]
			get
			{
				return ___003C_003EDISABLED;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(197)]
		private Policies(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(196)]
		private static Policies[] _0024values()
		{
			return new Policies[3] { ___003C_003ETHROW, ___003C_003EWARN, ___003C_003EDISABLED };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(196)]
		public static Policies[] values()
		{
			return (Policies[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(196)]
		public static Policies valueOf(string name)
		{
			return (Policies)java.lang.Enum.valueOf(ClassLiteral<Policies>.Value, name);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(197)]
		internal Policies(string P_0, int P_1, CycleDetectingLockFactory._1 P_2)
			: this(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[LineNumberTable(new byte[] { 160, 89, 240, 76, 240, 79, 240, 30 })]
		static Policies()
		{
			___003C_003ETHROW = new _1("THROW", 0);
			___003C_003EWARN = new _2("WARN", 1);
			___003C_003EDISABLED = new _3("DISABLED", 2);
			_0024VALUES = _0024values();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public abstract void handlePotentialDeadlock(PotentialDeadlockException P_0);
	}

	public interface Policy
	{
		virtual void handlePotentialDeadlock(PotentialDeadlockException cdlfpde);
	}

	[Serializable]
	public sealed class PotentialDeadlockException : ExampleStackTrace
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private ExampleStackTrace conflictingStackTrace;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		public virtual ExampleStackTrace getConflictingStackTrace()
		{
			return conflictingStackTrace;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(538)]
		internal PotentialDeadlockException(LockGraphNode P_0, LockGraphNode P_1, ExampleStackTrace P_2, _1 P_3)
			: this(P_0, P_1, P_2)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 174, 106, 103, 104 })]
		private PotentialDeadlockException(LockGraphNode P_0, LockGraphNode P_1, ExampleStackTrace P_2)
			: base(P_0, P_1)
		{
			conflictingStackTrace = P_2;
			base.initCause(P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 190, 118, 106, 55, 169 })]
		public override string getMessage()
		{
			StringBuilder stringBuilder = new StringBuilder((string)java.util.Objects.requireNonNull(base.getMessage()));
			for (System.Exception ex = conflictingStackTrace; ex != null; ex = Throwable.instancehelper_getCause(ex))
			{
				stringBuilder.append(", ").append(Throwable.instancehelper_getMessage(ex));
			}
			string result = stringBuilder.toString();
			_ = null;
			return result;
		}

		[HideFromJava]
		static PotentialDeadlockException()
		{
			ExampleStackTrace.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected PotentialDeadlockException(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}

		[HideFromJava]
		[NameSig("getConflictingStackTrace", "()Lcom.google.common.util.concurrent.CycleDetectingLockFactory$ExampleStackTrace;")]
		public IllegalStateException getConflictingStackTrace()
		{
			return this.getConflictingStackTrace();
		}
	}

	[Signature("<E:Ljava/lang/Enum<TE;>;>Lcom/google/common/util/concurrent/CycleDetectingLockFactory;")]
	public sealed class WithExplicitOrdering : CycleDetectingLockFactory
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/Map<TE;Lcom/google/common/util/concurrent/CycleDetectingLockFactory$LockGraphNode;>;")]
		private Map lockGraphNodes;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/CycleDetectingLockFactory$Policy;Ljava/util/Map<TE;Lcom/google/common/util/concurrent/CycleDetectingLockFactory$LockGraphNode;>;)V")]
		[LineNumberTable(new byte[] { 161, 35, 106, 103 })]
		internal WithExplicitOrdering(Policy P_0, Map P_1)
			: base(P_0, null)
		{
			lockGraphNodes = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;Z)Ljava/util/concurrent/locks/ReentrantLock;")]
		[LineNumberTable(new byte[]
		{
			159,
			37,
			162,
			109,
			168,
			byte.MaxValue,
			6,
			60
		})]
		public virtual ReentrantLock newReentrantLock(java.lang.Enum rank, bool fair)
		{
			ReentrantLock result = ((policy != Policies.___003C_003EDISABLED) ? new CycleDetectingReentrantLock(this, (LockGraphNode)java.util.Objects.requireNonNull((LockGraphNode)lockGraphNodes.get(rank)), fair, null) : new ReentrantLock(fair));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;Z)Ljava/util/concurrent/locks/ReentrantReadWriteLock;")]
		[LineNumberTable(new byte[] { 159, 31, 66, 109, 168, 109, 253, 59 })]
		public virtual ReentrantReadWriteLock newReentrantReadWriteLock(java.lang.Enum rank, bool fair)
		{
			object result;
			if (policy == Policies.___003C_003EDISABLED)
			{
				result = new ReentrantReadWriteLock(fair);
			}
			else
			{
				CycleDetectingReentrantReadWriteLock.___003Cclinit_003E();
				result = new CycleDetectingReentrantReadWriteLock(this, (LockGraphNode)java.util.Objects.requireNonNull((LockGraphNode)lockGraphNodes.get(rank)), fair, null);
			}
			_ = null;
			return (ReentrantReadWriteLock)result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Ljava/util/concurrent/locks/ReentrantLock;")]
		[LineNumberTable(411)]
		public virtual ReentrantLock newReentrantLock(java.lang.Enum rank)
		{
			ReentrantLock result = newReentrantLock(rank, fair: false);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Ljava/util/concurrent/locks/ReentrantReadWriteLock;")]
		[LineNumberTable(432)]
		public virtual ReentrantReadWriteLock newReentrantReadWriteLock(java.lang.Enum rank)
		{
			ReentrantReadWriteLock result = newReentrantReadWriteLock(rank, fair: false);
			_ = null;
			return result;
		}

		[HideFromJava]
		static WithExplicitOrdering()
		{
			CycleDetectingLockFactory.___003Cclinit_003E();
		}
	}

	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Ljava/util/concurrent/ConcurrentMap<Ljava/lang/Class<+Ljava/lang/Enum<*>;>;Ljava/util/Map<+Ljava/lang/Enum<*>;Lcom/google/common/util/concurrent/CycleDetectingLockFactory$LockGraphNode;>;>;")]
	private static ConcurrentMap lockGraphNodesPerType;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Logger logger;

	[Modifiers(Modifiers.Final)]
	internal Policy policy;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Ljava/lang/ThreadLocal<Ljava/util/ArrayList<Lcom/google/common/util/concurrent/CycleDetectingLockFactory$LockGraphNode;>;>;")]
	private static ThreadLocal acquiredLocks;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		162, 107, 104, 112, 167, 109, 106, 104, 226, 61,
		230, 71
	})]
	private static void lockStateChanged(CycleDetectingLock P_0)
	{
		if (P_0.isAcquiredByCurrentThread())
		{
			return;
		}
		ArrayList arrayList = (ArrayList)acquiredLocks.get();
		LockGraphNode lockGraphNode = P_0.getLockGraphNode();
		for (int i = arrayList.size() - 1; i >= 0; i += -1)
		{
			if (arrayList.get(i) == lockGraphNode)
			{
				arrayList.remove(i);
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 93, 104, 112, 103, 109, 136 })]
	private void aboutToAcquire(CycleDetectingLock P_0)
	{
		if (!P_0.isAcquiredByCurrentThread())
		{
			ArrayList arrayList = (ArrayList)acquiredLocks.get();
			LockGraphNode lockGraphNode = P_0.getLockGraphNode();
			lockGraphNode.checkAcquiredLocks(policy, arrayList);
			arrayList.add(lockGraphNode);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 89, 104, 113 })]
	private CycleDetectingLockFactory(Policy P_0)
	{
		policy = (Policy)Preconditions.checkNotNull(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 80, 162, 109, 104, 16 })]
	public virtual ReentrantLock newReentrantLock(string lockName, bool fair)
	{
		ReentrantLock result = ((policy != Policies.___003C_003EDISABLED) ? new CycleDetectingReentrantLock(this, new LockGraphNode(lockName), fair, null) : new ReentrantLock(fair));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 76, 162, 109, 104, 21 })]
	public virtual ReentrantReadWriteLock newReentrantReadWriteLock(string lockName, bool fair)
	{
		object result;
		if (policy == Policies.___003C_003EDISABLED)
		{
			result = new ReentrantReadWriteLock(fair);
		}
		else
		{
			CycleDetectingReentrantReadWriteLock.___003Cclinit_003E();
			result = new CycleDetectingReentrantReadWriteLock(this, new LockGraphNode(lockName), fair, null);
		}
		_ = null;
		return (ReentrantReadWriteLock)result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Enum<TE;>;>(Ljava/lang/Class<TE;>;)Ljava/util/Map<+TE;Lcom/google/common/util/concurrent/CycleDetectingLockFactory$LockGraphNode;>;")]
	[LineNumberTable(new byte[] { 160, 178, 113, 99, 130, 103, 114 })]
	private static Map getOrCreateNodes(Class P_0)
	{
		Map map = (Map)lockGraphNodesPerType.get(P_0);
		if (map != null)
		{
			return map;
		}
		Map map2 = createNodes(P_0);
		map = (Map)lockGraphNodesPerType.putIfAbsent(P_0, map2);
		return (Map)MoreObjects.firstNonNull(map, map2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Enum<TE;>;>(Ljava/lang/Class<TE;>;)Ljava/util/Map<TE;Lcom/google/common/util/concurrent/CycleDetectingLockFactory$LockGraphNode;>;")]
	[LineNumberTable(new byte[]
	{
		160, 195, 103, 108, 99, 135, 120, 110, 105, 235,
		61, 232, 70, 104, 63, 1, 200, 106, 63, 3,
		168
	})]
	internal static Map createNodes(Class P_0)
	{
		EnumMap enumMap = Maps.newEnumMap(P_0);
		java.lang.Enum[] array = (java.lang.Enum[])P_0.getEnumConstants();
		int num = array.Length;
		ArrayList arrayList = Lists.newArrayListWithCapacity(num);
		java.lang.Enum[] array2 = array;
		int num2 = array2.Length;
		for (int i = 0; i < num2; i++)
		{
			java.lang.Enum @enum = array2[i];
			LockGraphNode lockGraphNode = new LockGraphNode(getLockName(@enum));
			arrayList.add(lockGraphNode);
			enumMap.put(@enum, lockGraphNode);
		}
		for (int j = 1; j < num; j++)
		{
			((LockGraphNode)arrayList.get(j)).checkAcquiredLocks(Policies.___003C_003ETHROW, arrayList.subList(0, j));
		}
		for (int j = 0; j < num - 1; j++)
		{
			((LockGraphNode)arrayList.get(j)).checkAcquiredLocks(Policies.___003C_003EDISABLED, arrayList.subList(j + 1, num));
		}
		Map result = Collections.unmodifiableMap(enumMap);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Enum<*>;)Ljava/lang/String;")]
	[LineNumberTable(335)]
	private static string getLockName(java.lang.Enum P_0)
	{
		string simpleName = P_0.getDeclaringClass().getSimpleName();
		string text = P_0.name();
		int num = 1 + java.lang.String.instancehelper_length(java.lang.String.valueOf(simpleName)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
		num = num;
		string result = new StringBuilder(num).append(simpleName).append(".").append(text)
			.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(238)]
	public static CycleDetectingLockFactory newInstance(Policy policy)
	{
		CycleDetectingLockFactory result = new CycleDetectingLockFactory(policy);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(243)]
	public virtual ReentrantLock newReentrantLock(string lockName)
	{
		ReentrantLock result = newReentrantLock(lockName, fair: false);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(258)]
	public virtual ReentrantReadWriteLock newReentrantReadWriteLock(string lockName)
	{
		ReentrantReadWriteLock result = newReentrantReadWriteLock(lockName, fair: false);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Enum<TE;>;>(Ljava/lang/Class<TE;>;Lcom/google/common/util/concurrent/CycleDetectingLockFactory$Policy;)Lcom/google/common/util/concurrent/CycleDetectingLockFactory$WithExplicitOrdering<TE;>;")]
	[LineNumberTable(new byte[] { 160, 168, 103, 135, 103 })]
	public static WithExplicitOrdering newInstanceWithExplicitOrdering(Class enumClass, Policy policy)
	{
		Preconditions.checkNotNull(enumClass);
		Preconditions.checkNotNull(policy);
		Map orCreateNodes = getOrCreateNodes(enumClass);
		WithExplicitOrdering result = new WithExplicitOrdering(policy, orCreateNodes);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	internal static Logger access_0024100()
	{
		return logger;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Synthetic)]
	[LineNumberTable(167)]
	internal CycleDetectingLockFactory(Policy P_0, _1 P_1)
		: this(P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(167)]
	internal static void access_0024600(CycleDetectingLockFactory P_0, CycleDetectingLock P_1)
	{
		P_0.aboutToAcquire(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(167)]
	internal static void access_0024700(CycleDetectingLock P_0)
	{
		lockStateChanged(P_0);
	}

	[LineNumberTable(new byte[] { 160, 161, 244, 160, 180, 249, 78 })]
	static CycleDetectingLockFactory()
	{
		lockGraphNodesPerType = new MapMaker().weakKeys().makeMap();
		logger = Logger.getLogger(ClassLiteral<CycleDetectingLockFactory>.Value.getName(), CycleDetectingLockFactory.___003CGetCallerID_003E());
		acquiredLocks = new _1();
	}

	static CallerID ___003CGetCallerID_003E()
	{
		if (___003CcallerID_003E == null)
		{
			___003CcallerID_003E = new ___003CCallerID_003E();
		}
		return ___003CcallerID_003E;
	}
}
