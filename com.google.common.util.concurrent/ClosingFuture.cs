using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Threading;
using com.google.common.@base;
using com.google.common.collect;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;
using java.util.concurrent;
using java.util.concurrent.atomic;
using java.util.function;
using java.util.logging;
using javax.annotation;

namespace com.google.common.util.concurrent;

[Signature("<V:Ljava/lang/Object;>Ljava/lang/Object;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 173, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)173,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[DoNotMock(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/DoNotMock;",
	"value",
	"Use ClosingFuture.from(Futures.immediate*Future)"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
public sealed class ClosingFuture : java.lang.Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Lcom/google/common/util/concurrent/FutureCallback<Ljava/lang/AutoCloseable;>;")]
	[EnclosingMethod(null, "eventuallyClosing", "(Lcom.google.common.util.concurrent.ListenableFuture;Ljava.util.concurrent.Executor;)Lcom.google.common.util.concurrent.ClosingFuture;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 16, 0, 0, 1, 3, 0, 0, 40,
		0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)40,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class _1 : java.lang.Object, FutureCallback
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ClosingFuture val_0024closingFuture;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Executor val_0024closingExecutor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 77, 125 })]
		public virtual void onSuccess([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] IDisposable P_0)
		{
			CloseableList.access_0024300(access_0024200(val_0024closingFuture)).eventuallyClose(P_0, val_0024closingExecutor);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(444)]
		internal _1(ClosingFuture P_0, Executor P_1)
		{
			val_0024closingFuture = P_0;
			val_0024closingExecutor = P_1;
			base._002Ector();
		}

		public virtual void onFailure(System.Exception P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(444)]
		public virtual void onSuccess([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			onSuccess((IDisposable)P_0);
		}
	}

	[SpecialName]
	[EnclosingMethod(null, "finishToValueAndCloser", "(Lcom.google.common.util.concurrent.ClosingFuture$ValueAndCloserConsumer;Ljava.util.concurrent.Executor;)V")]
	internal class _10 : java.lang.Object, Runnable
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ValueAndCloserConsumer val_0024consumer;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ClosingFuture this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1090)]
		internal _10(ClosingFuture P_0, ValueAndCloserConsumer P_1)
		{
			this_00240 = P_0;
			val_0024consumer = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 211, 115 })]
		public virtual void run()
		{
			access_00241200(val_0024consumer, this_00240);
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[EnclosingMethod(null, "closeQuietly", "(Ljava.lang.AutoCloseable;Ljava.util.concurrent.Executor;)V")]
	internal class _11 : java.lang.Object, Runnable
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal IDisposable val_0024closeable;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(2166)]
		internal _11(IDisposable P_0)
		{
			val_0024closeable = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 168, 8, 191, 3, 2, 97, 149 })]
		public virtual void run()
		{
			java.lang.Exception ex2;
			try
			{
				val_0024closeable.Dispose();
				return;
			}
			catch (System.Exception x)
			{
				java.lang.Exception ex = ByteCodeHelper.MapException<java.lang.Exception>(x, ByteCodeHelper.MapFlags.None);
				if (ex == null)
				{
					throw;
				}
				ex2 = ex;
			}
			java.lang.Exception thrown = ex2;
			access_00243200().log(Level.WARNING, "thrown by close()", thrown);
		}
	}

	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal class _12 : java.lang.Object
	{
		[Modifiers(Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		internal static int[] _0024SwitchMap_0024com_0024google_0024common_0024util_0024concurrent_0024ClosingFuture_0024State;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[LineNumberTable(1034)]
		static _12()
		{
			_0024SwitchMap_0024com_0024google_0024common_0024util_0024concurrent_0024ClosingFuture_0024State = new int[(nint)State.values().LongLength];
			try
			{
				_0024SwitchMap_0024com_0024google_0024common_0024util_0024concurrent_0024ClosingFuture_0024State[State.SUBSUMED.ordinal()] = 1;
			}
			catch (System.Exception x)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0033;
			}
			goto IL_0039;
			IL_0033:
			_ = null;
			goto IL_0039;
			IL_0039:
			try
			{
				_0024SwitchMap_0024com_0024google_0024common_0024util_0024concurrent_0024ClosingFuture_0024State[State.WILL_CREATE_VALUE_AND_CLOSER.ordinal()] = 2;
			}
			catch (System.Exception x2)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x2, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_005c;
			}
			goto IL_0062;
			IL_005c:
			_ = null;
			goto IL_0062;
			IL_0062:
			try
			{
				_0024SwitchMap_0024com_0024google_0024common_0024util_0024concurrent_0024ClosingFuture_0024State[State.WILL_CLOSE.ordinal()] = 3;
			}
			catch (System.Exception x3)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x3, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0085;
			}
			goto IL_008b;
			IL_0085:
			_ = null;
			goto IL_008b;
			IL_008b:
			try
			{
				_0024SwitchMap_0024com_0024google_0024common_0024util_0024concurrent_0024ClosingFuture_0024State[State.CLOSING.ordinal()] = 4;
			}
			catch (System.Exception x4)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x4, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_00ae;
			}
			goto IL_00b4;
			IL_00ae:
			_ = null;
			goto IL_00b4;
			IL_00b4:
			try
			{
				_0024SwitchMap_0024com_0024google_0024common_0024util_0024concurrent_0024ClosingFuture_0024State[State.CLOSED.ordinal()] = 5;
			}
			catch (System.Exception x5)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x5, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_00d7;
			}
			goto IL_00dd;
			IL_00d7:
			_ = null;
			goto IL_00dd;
			IL_00dd:
			try
			{
				_0024SwitchMap_0024com_0024google_0024common_0024util_0024concurrent_0024ClosingFuture_0024State[State.OPEN.ordinal()] = 6;
				return;
			}
			catch (System.Exception x6)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x6, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
			}
			_ = null;
		}

		_12()
		{
			throw null;
		}
	}

	[SpecialName]
	[Signature("Ljava/lang/Object;Ljava/util/concurrent/Callable<TV;>;")]
	[EnclosingMethod(null, "<init>", "(Lcom.google.common.util.concurrent.ClosingFuture$ClosingCallable;Ljava.util.concurrent.Executor;)V")]
	internal class _2 : java.lang.Object, Callable
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ClosingCallable val_0024callable;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ClosingFuture this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(601)]
		internal _2(ClosingFuture P_0, ClosingCallable P_1)
		{
			this_00240 = P_0;
			val_0024callable = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Signature("()TV;")]
		[LineNumberTable(605)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/util/concurrent/ParametricNullness;"
		})]
		public virtual object call()
		{
			object result = val_0024callable.call(CloseableList.access_0024300(access_0024200(this_00240)));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(610)]
		public override string toString()
		{
			string result = java.lang.Object.instancehelper_toString(val_0024callable);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[Signature("Ljava/lang/Object;Lcom/google/common/util/concurrent/AsyncCallable<TV;>;")]
	[EnclosingMethod(null, "<init>", "(Lcom.google.common.util.concurrent.ClosingFuture$AsyncClosingCallable;Ljava.util.concurrent.Executor;)V")]
	internal class _3 : java.lang.Object, AsyncCallable
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AsyncClosingCallable val_0024callable;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ClosingFuture this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(621)]
		internal _3(ClosingFuture P_0, AsyncClosingCallable P_1)
		{
			this_00240 = P_0;
			val_0024callable = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Signature("()Lcom/google/common/util/concurrent/ListenableFuture<TV;>;")]
		[LineNumberTable(new byte[] { 161, 254, 135, 114, 113, 139, 118, 35, 2 })]
		public virtual ListenableFuture call()
		{
			CloseableList closeableList = new CloseableList(null);
			try
			{
				ClosingFuture closingFuture = val_0024callable.call(CloseableList.access_0024300(closeableList));
				access_00241000(closingFuture, access_0024200(this_00240));
				return access_0024000(closingFuture);
			}
			finally
			{
				access_0024200(this_00240).add(closeableList, MoreExecutors.directExecutor());
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(636)]
		public override string toString()
		{
			string result = java.lang.Object.instancehelper_toString(val_0024callable);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[Signature("Ljava/lang/Object;Lcom/google/common/util/concurrent/AsyncFunction<TV;TU;>;")]
	[EnclosingMethod(null, "transform", "(Lcom.google.common.util.concurrent.ClosingFuture$ClosingFunction;Ljava.util.concurrent.Executor;)Lcom.google.common.util.concurrent.ClosingFuture;")]
	internal class _4 : java.lang.Object, AsyncFunction
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ClosingFunction val_0024function;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ClosingFuture this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(695)]
		internal _4(ClosingFuture P_0, ClosingFunction P_1)
		{
			this_00240 = P_0;
			val_0024function = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Signature("(TV;)Lcom/google/common/util/concurrent/ListenableFuture<TU;>;")]
		[LineNumberTable(698)]
		public virtual ListenableFuture apply(object P_0)
		{
			ListenableFuture result = access_0024200(this_00240).applyClosingFunction(val_0024function, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(703)]
		public override string toString()
		{
			string result = java.lang.Object.instancehelper_toString(val_0024function);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[Signature("Ljava/lang/Object;Lcom/google/common/util/concurrent/AsyncFunction<TV;TU;>;")]
	[EnclosingMethod(null, "transformAsync", "(Lcom.google.common.util.concurrent.ClosingFuture$AsyncClosingFunction;Ljava.util.concurrent.Executor;)Lcom.google.common.util.concurrent.ClosingFuture;")]
	internal class _5 : java.lang.Object, AsyncFunction
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AsyncClosingFunction val_0024function;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ClosingFuture this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(789)]
		internal _5(ClosingFuture P_0, AsyncClosingFunction P_1)
		{
			this_00240 = P_0;
			val_0024function = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Signature("(TV;)Lcom/google/common/util/concurrent/ListenableFuture<TU;>;")]
		[LineNumberTable(792)]
		public virtual ListenableFuture apply(object P_0)
		{
			FluentFuture result = access_0024200(this_00240).applyAsyncClosingFunction(val_0024function, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(797)]
		public override string toString()
		{
			string result = java.lang.Object.instancehelper_toString(val_0024function);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Lcom/google/common/util/concurrent/ClosingFuture$AsyncClosingFunction<TV;TU;>;")]
	[EnclosingMethod(null, "withoutCloser", "(Lcom.google.common.util.concurrent.AsyncFunction;)Lcom.google.common.util.concurrent.ClosingFuture$AsyncClosingFunction;")]
	internal class _6 : java.lang.Object, AsyncClosingFunction
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AsyncFunction val_0024function;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(832)]
		internal _6(AsyncFunction P_0)
		{
			val_0024function = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Signature("(Lcom/google/common/util/concurrent/ClosingFuture$DeferredCloser;TV;)Lcom/google/common/util/concurrent/ClosingFuture<TU;>;")]
		[LineNumberTable(835)]
		public virtual ClosingFuture apply(DeferredCloser P_0, object P_1)
		{
			ClosingFuture result = from(val_0024function.apply(P_1));
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[Signature("Ljava/lang/Object;Lcom/google/common/util/concurrent/AsyncFunction<TX;TW;>;")]
	[EnclosingMethod(null, "catchingMoreGeneric", "(Ljava.lang.Class;Lcom.google.common.util.concurrent.ClosingFuture$ClosingFunction;Ljava.util.concurrent.Executor;)Lcom.google.common.util.concurrent.ClosingFuture;")]
	internal class _7 : java.lang.Object, AsyncFunction
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ClosingFunction val_0024fallback;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ClosingFuture this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(891)]
		internal _7(ClosingFuture P_0, ClosingFunction P_1)
		{
			this_00240 = P_0;
			val_0024fallback = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Signature("(TX;)Lcom/google/common/util/concurrent/ListenableFuture<TW;>;")]
		[LineNumberTable(894)]
		public virtual ListenableFuture apply(System.Exception P_0)
		{
			ListenableFuture result = access_0024200(this_00240).applyClosingFunction(val_0024fallback, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(899)]
		public override string toString()
		{
			string result = java.lang.Object.instancehelper_toString(val_0024fallback);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(891)]
		public virtual ListenableFuture apply(object P_0)
		{
			ListenableFuture result = apply((System.Exception)P_0);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[Signature("Ljava/lang/Object;Lcom/google/common/util/concurrent/AsyncFunction<TX;TW;>;")]
	[EnclosingMethod(null, "catchingAsyncMoreGeneric", "(Ljava.lang.Class;Lcom.google.common.util.concurrent.ClosingFuture$AsyncClosingFunction;Ljava.util.concurrent.Executor;)Lcom.google.common.util.concurrent.ClosingFuture;")]
	internal class _8 : java.lang.Object, AsyncFunction
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AsyncClosingFunction val_0024fallback;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ClosingFuture this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(990)]
		internal _8(ClosingFuture P_0, AsyncClosingFunction P_1)
		{
			this_00240 = P_0;
			val_0024fallback = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Signature("(TX;)Lcom/google/common/util/concurrent/ListenableFuture<TW;>;")]
		[LineNumberTable(993)]
		public virtual ListenableFuture apply(System.Exception P_0)
		{
			FluentFuture result = access_0024200(this_00240).applyAsyncClosingFunction(val_0024fallback, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(998)]
		public override string toString()
		{
			string result = java.lang.Object.instancehelper_toString(val_0024fallback);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(990)]
		public virtual ListenableFuture apply(object P_0)
		{
			ListenableFuture result = apply((System.Exception)P_0);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[EnclosingMethod(null, "finishToFuture", "()Lcom.google.common.util.concurrent.FluentFuture;")]
	internal class _9 : java.lang.Object, Runnable
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ClosingFuture this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1024)]
		internal _9(ClosingFuture P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 145, 117, 107, 119 })]
		public virtual void run()
		{
			access_00241100(this_00240, State.WILL_CLOSE, State.CLOSING);
			access_0024100(this_00240);
			access_00241100(this_00240, State.CLOSING, State.CLOSED);
		}
	}

	[Signature("<V:Ljava/lang/Object;>Ljava/lang/Object;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 18, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)18,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[FunctionalInterface(new object[]
	{
		(byte)64,
		"Ljava/lang/FunctionalInterface;"
	})]
	public interface AsyncClosingCallable
	{
		[Throws(new string[] { "java.lang.Exception" })]
		[Signature("(Lcom/google/common/util/concurrent/ClosingFuture$DeferredCloser;)Lcom/google/common/util/concurrent/ClosingFuture<TV;>;")]
		virtual ClosingFuture call(DeferredCloser cfdc);
	}

	[Signature("<T:Ljava/lang/Object;U:Ljava/lang/Object;>Ljava/lang/Object;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 20, 0, 0,
		17, 1, 0, 0, 0, 20, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)20,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[FunctionalInterface(new object[]
	{
		(byte)64,
		"Ljava/lang/FunctionalInterface;"
	})]
	public interface AsyncClosingFunction
	{
		[Throws(new string[] { "java.lang.Exception" })]
		[Signature("(Lcom/google/common/util/concurrent/ClosingFuture$DeferredCloser;TT;)Lcom/google/common/util/concurrent/ClosingFuture<TU;>;")]
		virtual ClosingFuture apply(DeferredCloser cfdc, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/util/concurrent/ParametricNullness;"
		})] object obj);
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Ljava/util/IdentityHashMap<Ljava/lang/AutoCloseable;Ljava/util/concurrent/Executor;>;Ljava/io/Closeable;")]
	[ConstantPool(new object[]
	{
		(byte)73,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.io.Closeable" })]
	internal sealed class CloseableList : IdentityHashMap, Closeable, AutoCloseable
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private DeferredCloser closer;

		private volatile bool closed;

		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private volatile CountDownLatch whenClosed;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(2198)]
		internal static DeferredCloser access_0024300(CloseableList P_0)
		{
			return P_0.closer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(2198)]
		internal CloseableList(_1 P_0)
			: this()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			168, 72, 106, 129, 104, 106, 136, 110, 118, 127,
			1, 123, 98, 102, 106, 141
		})]
		public virtual void close()
		{
			if (closed)
			{
				return;
			}
			CloseableList obj;
			System.Threading.Monitor.Enter(obj = this);
			try
			{
				if (closed)
				{
					System.Threading.Monitor.Exit(obj);
					return;
				}
				closed = true;
				System.Threading.Thread.MemoryBarrier();
				System.Threading.Monitor.Exit(obj);
			}
			catch
			{
				//try-fault
				System.Threading.Monitor.Exit(obj);
				throw;
			}
			Iterator iterator = entrySet().iterator();
			while (iterator.hasNext())
			{
				Map.Entry entry = (Map.Entry)iterator.next();
				access_00243300((IDisposable)entry.getKey(), (Executor)entry.getValue());
			}
			clear();
			if (whenClosed != null)
			{
				whenClosed.countDown();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			168, 91, 103, 99, 129, 104, 106, 105, 136, 118,
			103
		})]
		internal virtual void add([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] IDisposable P_0, Executor P_1)
		{
			Preconditions.checkNotNull(P_1);
			if (P_0 == null)
			{
				return;
			}
			CloseableList obj;
			System.Threading.Monitor.Enter(obj = this);
			try
			{
				if (!closed)
				{
					put(P_0, P_1);
					System.Threading.Monitor.Exit(obj);
					return;
				}
				System.Threading.Monitor.Exit(obj);
			}
			catch
			{
				//try-fault
				System.Threading.Monitor.Exit(obj);
				throw;
			}
			access_00243300(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 168, 108, 106, 135, 104, 106, 143, 115, 127, 5 })]
		internal virtual CountDownLatch whenClosedCountDown()
		{
			//Discarded unreachable code: IL_0065
			if (closed)
			{
				return new CountDownLatch(0);
			}
			CloseableList obj;
			System.Threading.Monitor.Enter(obj = this);
			try
			{
				if (closed)
				{
					CountDownLatch result = new CountDownLatch(0);
					System.Threading.Monitor.Exit(obj);
					return result;
				}
				Preconditions.checkState(whenClosed == null);
				CountDownLatch countDownLatch = new CountDownLatch(1);
				CountDownLatch result2 = countDownLatch;
				whenClosed = countDownLatch;
				System.Threading.Thread.MemoryBarrier();
				System.Threading.Monitor.Exit(obj);
				return result2;
			}
			catch
			{
				//try-fault
				System.Threading.Monitor.Exit(obj);
				throw;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Signature("<V:Ljava/lang/Object;U:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/ClosingFuture$ClosingFunction<-TV;TU;>;TV;)Lcom/google/common/util/concurrent/ListenableFuture<TU;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 2, 18, 0, 0, 0, 0, 73, 0, 0,
			18, 1, 0, 0, 0, 73, 0, 0
		})]
		[LineNumberTable(new byte[] { 168, 47, 134, 151, 108, 35, 2 })]
		internal virtual ListenableFuture applyClosingFunction(ClosingFunction P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/util/concurrent/ParametricNullness;"
		})] object P_1)
		{
			CloseableList closeableList = new CloseableList();
			try
			{
				return Futures.immediateFuture(P_0.apply(closeableList.closer, P_1));
			}
			finally
			{
				add(closeableList, MoreExecutors.directExecutor());
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Signature("<V:Ljava/lang/Object;U:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/ClosingFuture$AsyncClosingFunction<TV;TU;>;TV;)Lcom/google/common/util/concurrent/FluentFuture<TU;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 2, 18, 0, 0, 0, 0, 73, 0, 0,
			18, 1, 0, 0, 0, 73, 0, 0
		})]
		[LineNumberTable(new byte[] { 168, 60, 134, 110, 103, 139, 108, 35, 2 })]
		internal virtual FluentFuture applyAsyncClosingFunction(AsyncClosingFunction P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/util/concurrent/ParametricNullness;"
		})] object P_1)
		{
			CloseableList closeableList = new CloseableList();
			try
			{
				ClosingFuture closingFuture = P_0.apply(closeableList.closer, P_1);
				access_00241000(closingFuture, closeableList);
				return access_0024000(closingFuture);
			}
			finally
			{
				add(closeableList, MoreExecutors.directExecutor());
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 168, 36, 136 })]
		private CloseableList()
		{
			closer = new DeferredCloser(this);
		}

		[HideFromJava]
		static CloseableList()
		{
			IdentityHashMap.___003Cclinit_003E();
		}

		void IDisposable.AutoCloseable_003A_003Aclose()
		{
			close();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected CloseableList(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Signature("<V:Ljava/lang/Object;>Ljava/lang/Object;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 19, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)19,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[FunctionalInterface(new object[]
	{
		(byte)64,
		"Ljava/lang/FunctionalInterface;"
	})]
	public interface ClosingCallable
	{
		[Throws(new string[] { "java.lang.Exception" })]
		[Signature("(Lcom/google/common/util/concurrent/ClosingFuture$DeferredCloser;)TV;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/util/concurrent/ParametricNullness;"
		})]
		virtual object call(DeferredCloser cfdc);
	}

	[Signature("<T:Ljava/lang/Object;U:Ljava/lang/Object;>Ljava/lang/Object;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 20, 0, 0,
		17, 1, 0, 0, 0, 20, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)20,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[FunctionalInterface(new object[]
	{
		(byte)64,
		"Ljava/lang/FunctionalInterface;"
	})]
	public interface ClosingFunction
	{
		[Throws(new string[] { "java.lang.Exception" })]
		[Signature("(Lcom/google/common/util/concurrent/ClosingFuture$DeferredCloser;TT;)TU;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/util/concurrent/ParametricNullness;"
		})]
		virtual object apply(DeferredCloser cfdc, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/util/concurrent/ParametricNullness;"
		})] object obj);
	}

	[ConstantPool(new object[]
	{
		(byte)85,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[DoNotMock(new object[]
	{
		(byte)64,
		"Lcom/google/errorprone/annotations/DoNotMock;",
		"value",
		"Use ClosingFuture.whenAllSucceed() or .whenAllComplete() instead."
	})]
	public class Combiner : java.lang.Object
	{
		[SpecialName]
		[Signature("Ljava/lang/Object;Ljava/util/concurrent/Callable<TV;>;")]
		[EnclosingMethod(null, "call", "(Lcom.google.common.util.concurrent.ClosingFuture$Combiner$CombiningCallable;Ljava.util.concurrent.Executor;)Lcom.google.common.util.concurrent.ClosingFuture;")]
		internal class _1 : java.lang.Object, Callable
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal CombiningCallable val_0024combiningCallable;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Combiner this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(1306)]
			internal _1(Combiner P_0, CombiningCallable P_1)
			{
				this_00240 = P_0;
				val_0024combiningCallable = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Throws(new string[] { "java.lang.Exception" })]
			[Signature("()TV;")]
			[LineNumberTable(1310)]
			[ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/util/concurrent/ParametricNullness;"
			})]
			public virtual object call()
			{
				object result = Peeker.access_00241500(new Peeker(this_00240.___003C_003Einputs, null), val_0024combiningCallable, access_00241300(this_00240));
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(1315)]
			public override string toString()
			{
				string result = java.lang.Object.instancehelper_toString(val_0024combiningCallable);
				_ = null;
				return result;
			}
		}

		[SpecialName]
		[Signature("Ljava/lang/Object;Lcom/google/common/util/concurrent/AsyncCallable<TV;>;")]
		[EnclosingMethod(null, "callAsync", "(Lcom.google.common.util.concurrent.ClosingFuture$Combiner$AsyncCombiningCallable;Ljava.util.concurrent.Executor;)Lcom.google.common.util.concurrent.ClosingFuture;")]
		internal class _2 : java.lang.Object, AsyncCallable
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal AsyncCombiningCallable val_0024combiningCallable;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Combiner this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(1363)]
			internal _2(Combiner P_0, AsyncCombiningCallable P_1)
			{
				this_00240 = P_0;
				val_0024combiningCallable = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Throws(new string[] { "java.lang.Exception" })]
			[Signature("()Lcom/google/common/util/concurrent/ListenableFuture<TV;>;")]
			[LineNumberTable(1366)]
			public virtual ListenableFuture call()
			{
				FluentFuture result = Peeker.access_00241700(new Peeker(this_00240.___003C_003Einputs, null), val_0024combiningCallable, access_00241300(this_00240));
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(1371)]
			public override string toString()
			{
				string result = java.lang.Object.instancehelper_toString(val_0024combiningCallable);
				_ = null;
				return result;
			}
		}

		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Ljava/lang/Object;Lcom/google/common/base/Function<Lcom/google/common/util/concurrent/ClosingFuture<*>;Lcom/google/common/util/concurrent/FluentFuture<*>;>;")]
		[EnclosingMethod(null, null, null)]
		[Implements(new string[] { "com.google.common.base.Function" })]
		internal class _3 : java.lang.Object, com.google.common.@base.Function, java.util.function.Function
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(1387)]
			internal _3()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/util/concurrent/ClosingFuture<*>;)Lcom/google/common/util/concurrent/FluentFuture<*>;")]
			[LineNumberTable(1390)]
			public virtual FluentFuture apply(ClosingFuture P_0)
			{
				FluentFuture result = access_0024000(P_0);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(1387)]
			public virtual object apply(object P_0)
			{
				FluentFuture result = apply((ClosingFuture)P_0);
				_ = null;
				return result;
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual java.util.function.Function compose(java.util.function.Function P_0)
			{
				return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual java.util.function.Function andThen(java.util.function.Function P_0)
			{
				return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
			}

			bool com.google.common.@base.Function.Function_003A_003Aequals(object P_0)
			{
				return java.lang.Object.instancehelper_equals(this, P_0);
			}
		}

		[Signature("<V:Ljava/lang/Object;>Ljava/lang/Object;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 20, 0, 0 })]
		[ConstantPool(new object[]
		{
			(byte)20,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		[FunctionalInterface(new object[]
		{
			(byte)64,
			"Ljava/lang/FunctionalInterface;"
		})]
		public interface AsyncCombiningCallable
		{
			[Throws(new string[] { "java.lang.Exception" })]
			[Signature("(Lcom/google/common/util/concurrent/ClosingFuture$DeferredCloser;Lcom/google/common/util/concurrent/ClosingFuture$Peeker;)Lcom/google/common/util/concurrent/ClosingFuture<TV;>;")]
			virtual ClosingFuture call(DeferredCloser cfdc, Peeker cfp);
		}

		[Signature("<V:Ljava/lang/Object;>Ljava/lang/Object;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 21, 0, 0 })]
		[ConstantPool(new object[]
		{
			(byte)21,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		[FunctionalInterface(new object[]
		{
			(byte)64,
			"Ljava/lang/FunctionalInterface;"
		})]
		public interface CombiningCallable
		{
			[Throws(new string[] { "java.lang.Exception" })]
			[Signature("(Lcom/google/common/util/concurrent/ClosingFuture$DeferredCloser;Lcom/google/common/util/concurrent/ClosingFuture$Peeker;)TV;")]
			[ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/util/concurrent/ParametricNullness;"
			})]
			virtual object call(DeferredCloser cfdc, Peeker cfp);
		}

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private CloseableList closeables;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private bool allMustSucceed;

		[Signature("Lcom/google/common/collect/ImmutableList<Lcom/google/common/util/concurrent/ClosingFuture<*>;>;")]
		internal ImmutableList ___003C_003Einputs;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
		[Signature("Lcom/google/common/base/Function<Lcom/google/common/util/concurrent/ClosingFuture<*>;Lcom/google/common/util/concurrent/FluentFuture<*>;>;")]
		private static com.google.common.@base.Function INNER_FUTURE;

		[Modifiers(Modifiers.Protected | Modifiers.Final)]
		protected internal ImmutableList inputs
		{
			[HideFromJava]
			get
			{
				return ___003C_003Einputs;
			}
			[HideFromJava]
			private set
			{
				___003C_003Einputs = value;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(1233)]
		internal Combiner(bool P_0, Iterable P_1, ClosingFuture._1 P_2)
			: this(P_0, P_1)
		{
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(1233)]
		internal static CloseableList access_00241300(Combiner P_0)
		{
			return P_0.closeables;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(ZLjava/lang/Iterable<+Lcom/google/common/util/concurrent/ClosingFuture<*>;>;)V")]
		[LineNumberTable(new byte[]
		{
			158, 78, 98, 232, 18, 236, 111, 103, 108, 123,
			108, 98
		})]
		private Combiner(bool P_0, Iterable P_1)
		{
			closeables = new CloseableList(null);
			allMustSucceed = P_0;
			___003C_003Einputs = ImmutableList.copyOf(P_1);
			Iterator iterator = P_1.iterator();
			while (iterator.hasNext())
			{
				ClosingFuture closingFuture = (ClosingFuture)iterator.next();
				access_00241000(closingFuture, closeables);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/util/concurrent/Futures$FutureCombiner<Ljava/lang/Object;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 0, 0, 85, 0, 0 })]
		[LineNumberTable(new byte[] { 164, 243, 104, 109, 13 })]
		private Futures.FutureCombiner futureCombiner()
		{
			Futures.FutureCombiner result = ((!allMustSucceed) ? Futures.whenAllComplete(inputFutures()) : Futures.whenAllSucceed(inputFutures()));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableList<Lcom/google/common/util/concurrent/FluentFuture<*>;>;")]
		[LineNumberTable(1395)]
		private ImmutableList inputFutures()
		{
			ImmutableList result = FluentIterable.from(___003C_003Einputs).transform(INNER_FUTURE).toList();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<V:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/ClosingFuture$Combiner$CombiningCallable<TV;>;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/ClosingFuture<TV;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 85, 0, 0 })]
		[LineNumberTable(new byte[] { 164, 167, 232, 77, 121, 118 })]
		public virtual ClosingFuture call(CombiningCallable combiningCallable, Executor executor)
		{
			_1 combiner = new _1(this, combiningCallable);
			ClosingFuture.___003Cclinit_003E();
			ClosingFuture closingFuture = new ClosingFuture(futureCombiner().call(combiner, executor), null);
			access_0024200(closingFuture).add(closeables, MoreExecutors.directExecutor());
			return closingFuture;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<V:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/ClosingFuture$Combiner$AsyncCombiningCallable<TV;>;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/ClosingFuture<TV;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 85, 0, 0 })]
		[LineNumberTable(new byte[] { 164, 224, 232, 76, 102, 115, 118 })]
		public virtual ClosingFuture callAsync(AsyncCombiningCallable combiningCallable, Executor executor)
		{
			_2 combiner = new _2(this, combiningCallable);
			ClosingFuture.___003Cclinit_003E();
			ClosingFuture closingFuture = new ClosingFuture(futureCombiner().callAsync(combiner, executor), null);
			access_0024200(closingFuture).add(closeables, MoreExecutors.directExecutor());
			return closingFuture;
		}

		[LineNumberTable(1386)]
		static Combiner()
		{
			INNER_FUTURE = new _3();
		}
	}

	[Signature("<V1:Ljava/lang/Object;V2:Ljava/lang/Object;>Lcom/google/common/util/concurrent/ClosingFuture$Combiner;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 45, 0, 0,
		17, 1, 0, 0, 0, 45, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)45,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	public sealed class Combiner2 : Combiner
	{
		[SpecialName]
		[Signature("Ljava/lang/Object;Lcom/google/common/util/concurrent/ClosingFuture$Combiner$CombiningCallable<TU;>;")]
		[EnclosingMethod(null, "call", "(Lcom.google.common.util.concurrent.ClosingFuture$Combiner2$ClosingFunction2;Ljava.util.concurrent.Executor;)Lcom.google.common.util.concurrent.ClosingFuture;")]
		internal new class _1 : java.lang.Object, CombiningCallable
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal ClosingFunction2 val_0024function;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Combiner2 this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(1485)]
			internal _1(Combiner2 P_0, ClosingFunction2 P_1)
			{
				this_00240 = P_0;
				val_0024function = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Throws(new string[] { "java.lang.Exception" })]
			[Signature("(Lcom/google/common/util/concurrent/ClosingFuture$DeferredCloser;Lcom/google/common/util/concurrent/ClosingFuture$Peeker;)TU;")]
			[LineNumberTable(1489)]
			[ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/util/concurrent/ParametricNullness;"
			})]
			public virtual object call(DeferredCloser P_0, Peeker P_1)
			{
				object result = val_0024function.apply(P_0, P_1.getDone(access_00241800(this_00240)), P_1.getDone(access_00241900(this_00240)));
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(1494)]
			public override string toString()
			{
				string result = java.lang.Object.instancehelper_toString(val_0024function);
				_ = null;
				return result;
			}
		}

		[SpecialName]
		[Signature("Ljava/lang/Object;Lcom/google/common/util/concurrent/ClosingFuture$Combiner$AsyncCombiningCallable<TU;>;")]
		[EnclosingMethod(null, "callAsync", "(Lcom.google.common.util.concurrent.ClosingFuture$Combiner2$AsyncClosingFunction2;Ljava.util.concurrent.Executor;)Lcom.google.common.util.concurrent.ClosingFuture;")]
		internal new class _2 : java.lang.Object, AsyncCombiningCallable
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal AsyncClosingFunction2 val_0024function;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Combiner2 this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(1539)]
			internal _2(Combiner2 P_0, AsyncClosingFunction2 P_1)
			{
				this_00240 = P_0;
				val_0024function = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Throws(new string[] { "java.lang.Exception" })]
			[Signature("(Lcom/google/common/util/concurrent/ClosingFuture$DeferredCloser;Lcom/google/common/util/concurrent/ClosingFuture$Peeker;)Lcom/google/common/util/concurrent/ClosingFuture<TU;>;")]
			[LineNumberTable(1542)]
			public virtual ClosingFuture call(DeferredCloser P_0, Peeker P_1)
			{
				ClosingFuture result = val_0024function.apply(P_0, P_1.getDone(access_00241800(this_00240)), P_1.getDone(access_00241900(this_00240)));
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(1547)]
			public override string toString()
			{
				string result = java.lang.Object.instancehelper_toString(val_0024function);
				_ = null;
				return result;
			}
		}

		[Signature("<V1:Ljava/lang/Object;V2:Ljava/lang/Object;U:Ljava/lang/Object;>Ljava/lang/Object;")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 3, 17, 0, 0, 0, 0, 20, 0, 0,
			17, 1, 0, 0, 0, 20, 0, 0, 17, 2,
			0, 0, 0, 20, 0, 0
		})]
		[ConstantPool(new object[]
		{
			(byte)20,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		[FunctionalInterface(new object[]
		{
			(byte)64,
			"Ljava/lang/FunctionalInterface;"
		})]
		public interface AsyncClosingFunction2
		{
			[Throws(new string[] { "java.lang.Exception" })]
			[Signature("(Lcom/google/common/util/concurrent/ClosingFuture$DeferredCloser;TV1;TV2;)Lcom/google/common/util/concurrent/ClosingFuture<TU;>;")]
			virtual ClosingFuture apply(DeferredCloser cfdc, [ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/util/concurrent/ParametricNullness;"
			})] object obj1, [ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/util/concurrent/ParametricNullness;"
			})] object obj2);
		}

		[Signature("<V1:Ljava/lang/Object;V2:Ljava/lang/Object;U:Ljava/lang/Object;>Ljava/lang/Object;")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 3, 17, 0, 0, 0, 0, 20, 0, 0,
			17, 1, 0, 0, 0, 20, 0, 0, 17, 2,
			0, 0, 0, 20, 0, 0
		})]
		[ConstantPool(new object[]
		{
			(byte)20,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		[FunctionalInterface(new object[]
		{
			(byte)64,
			"Ljava/lang/FunctionalInterface;"
		})]
		public interface ClosingFunction2
		{
			[Throws(new string[] { "java.lang.Exception" })]
			[Signature("(Lcom/google/common/util/concurrent/ClosingFuture$DeferredCloser;TV1;TV2;)TU;")]
			[ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/util/concurrent/ParametricNullness;"
			})]
			virtual object apply(DeferredCloser cfdc, [ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/util/concurrent/ParametricNullness;"
			})] object obj1, [ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/util/concurrent/ParametricNullness;"
			})] object obj2);
		}

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/util/concurrent/ClosingFuture<TV1;>;")]
		private ClosingFuture future1;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/util/concurrent/ClosingFuture<TV2;>;")]
		private ClosingFuture future2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(1407)]
		internal Combiner2(ClosingFuture P_0, ClosingFuture P_1, ClosingFuture._1 P_2)
			: this(P_0, P_1)
		{
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(1407)]
		internal static ClosingFuture access_00241800(Combiner2 P_0)
		{
			return P_0.future1;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(1407)]
		internal static ClosingFuture access_00241900(Combiner2 P_0)
		{
			return P_0.future2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/ClosingFuture<TV1;>;Lcom/google/common/util/concurrent/ClosingFuture<TV2;>;)V")]
		[LineNumberTable(new byte[] { 165, 70, 113, 103, 103 })]
		private Combiner2(ClosingFuture P_0, ClosingFuture P_1)
			: base(true, ImmutableList.of(P_0, P_1), null)
		{
			future1 = P_0;
			future2 = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<U:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/ClosingFuture$Combiner2$ClosingFunction2<TV1;TV2;TU;>;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/ClosingFuture<TU;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 45, 0, 0 })]
		[LineNumberTable(1484)]
		public virtual ClosingFuture call(ClosingFunction2 function, Executor executor)
		{
			ClosingFuture result = base.call(new _1(this, function), executor);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<U:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/ClosingFuture$Combiner2$AsyncClosingFunction2<TV1;TV2;TU;>;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/ClosingFuture<TU;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 45, 0, 0 })]
		[LineNumberTable(1538)]
		public virtual ClosingFuture callAsync(AsyncClosingFunction2 function, Executor executor)
		{
			ClosingFuture result = base.callAsync(new _2(this, function), executor);
			_ = null;
			return result;
		}

		[HideFromJava]
		static Combiner2()
		{
			Combiner.___003Cclinit_003E();
		}
	}

	[Signature("<V1:Ljava/lang/Object;V2:Ljava/lang/Object;V3:Ljava/lang/Object;>Lcom/google/common/util/concurrent/ClosingFuture$Combiner;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 17, 0, 0, 0, 0, 48, 0, 0,
		17, 1, 0, 0, 0, 48, 0, 0, 17, 2,
		0, 0, 0, 48, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)48,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	public sealed class Combiner3 : Combiner
	{
		[SpecialName]
		[Signature("Ljava/lang/Object;Lcom/google/common/util/concurrent/ClosingFuture$Combiner$CombiningCallable<TU;>;")]
		[EnclosingMethod(null, "call", "(Lcom.google.common.util.concurrent.ClosingFuture$Combiner3$ClosingFunction3;Ljava.util.concurrent.Executor;)Lcom.google.common.util.concurrent.ClosingFuture;")]
		internal new class _1 : java.lang.Object, CombiningCallable
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal ClosingFunction3 val_0024function;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Combiner3 this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(1657)]
			internal _1(Combiner3 P_0, ClosingFunction3 P_1)
			{
				this_00240 = P_0;
				val_0024function = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Throws(new string[] { "java.lang.Exception" })]
			[Signature("(Lcom/google/common/util/concurrent/ClosingFuture$DeferredCloser;Lcom/google/common/util/concurrent/ClosingFuture$Peeker;)TU;")]
			[LineNumberTable(new byte[] { 166, 11, 142, 113, 113, 234, 60 })]
			[ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/util/concurrent/ParametricNullness;"
			})]
			public virtual object call(DeferredCloser P_0, Peeker P_1)
			{
				object result = val_0024function.apply(P_0, P_1.getDone(access_00242000(this_00240)), P_1.getDone(access_00242100(this_00240)), P_1.getDone(access_00242200(this_00240)));
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(1670)]
			public override string toString()
			{
				string result = java.lang.Object.instancehelper_toString(val_0024function);
				_ = null;
				return result;
			}
		}

		[SpecialName]
		[Signature("Ljava/lang/Object;Lcom/google/common/util/concurrent/ClosingFuture$Combiner$AsyncCombiningCallable<TU;>;")]
		[EnclosingMethod(null, "callAsync", "(Lcom.google.common.util.concurrent.ClosingFuture$Combiner3$AsyncClosingFunction3;Ljava.util.concurrent.Executor;)Lcom.google.common.util.concurrent.ClosingFuture;")]
		internal new class _2 : java.lang.Object, AsyncCombiningCallable
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal AsyncClosingFunction3 val_0024function;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Combiner3 this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(1715)]
			internal _2(Combiner3 P_0, AsyncClosingFunction3 P_1)
			{
				this_00240 = P_0;
				val_0024function = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Throws(new string[] { "java.lang.Exception" })]
			[Signature("(Lcom/google/common/util/concurrent/ClosingFuture$DeferredCloser;Lcom/google/common/util/concurrent/ClosingFuture$Peeker;)Lcom/google/common/util/concurrent/ClosingFuture<TU;>;")]
			[LineNumberTable(new byte[] { 166, 68, 142, 113, 113, 234, 60 })]
			public virtual ClosingFuture call(DeferredCloser P_0, Peeker P_1)
			{
				ClosingFuture result = val_0024function.apply(P_0, P_1.getDone(access_00242000(this_00240)), P_1.getDone(access_00242100(this_00240)), P_1.getDone(access_00242200(this_00240)));
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(1727)]
			public override string toString()
			{
				string result = java.lang.Object.instancehelper_toString(val_0024function);
				_ = null;
				return result;
			}
		}

		[Signature("<V1:Ljava/lang/Object;V2:Ljava/lang/Object;V3:Ljava/lang/Object;U:Ljava/lang/Object;>Ljava/lang/Object;")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 4, 17, 0, 0, 0, 0, 20, 0, 0,
			17, 1, 0, 0, 0, 20, 0, 0, 17, 2,
			0, 0, 0, 20, 0, 0, 17, 3, 0, 0,
			0, 20, 0, 0
		})]
		[ConstantPool(new object[]
		{
			(byte)20,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		[FunctionalInterface(new object[]
		{
			(byte)64,
			"Ljava/lang/FunctionalInterface;"
		})]
		public interface AsyncClosingFunction3
		{
			[Throws(new string[] { "java.lang.Exception" })]
			[Signature("(Lcom/google/common/util/concurrent/ClosingFuture$DeferredCloser;TV1;TV2;TV3;)Lcom/google/common/util/concurrent/ClosingFuture<TU;>;")]
			virtual ClosingFuture apply(DeferredCloser cfdc, [ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/util/concurrent/ParametricNullness;"
			})] object obj1, [ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/util/concurrent/ParametricNullness;"
			})] object obj2, [ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/util/concurrent/ParametricNullness;"
			})] object obj3);
		}

		[Signature("<V1:Ljava/lang/Object;V2:Ljava/lang/Object;V3:Ljava/lang/Object;U:Ljava/lang/Object;>Ljava/lang/Object;")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 4, 17, 0, 0, 0, 0, 20, 0, 0,
			17, 1, 0, 0, 0, 20, 0, 0, 17, 2,
			0, 0, 0, 20, 0, 0, 17, 3, 0, 0,
			0, 20, 0, 0
		})]
		[ConstantPool(new object[]
		{
			(byte)20,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		[FunctionalInterface(new object[]
		{
			(byte)64,
			"Ljava/lang/FunctionalInterface;"
		})]
		public interface ClosingFunction3
		{
			[Throws(new string[] { "java.lang.Exception" })]
			[Signature("(Lcom/google/common/util/concurrent/ClosingFuture$DeferredCloser;TV1;TV2;TV3;)TU;")]
			[ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/util/concurrent/ParametricNullness;"
			})]
			virtual object apply(DeferredCloser cfdc, [ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/util/concurrent/ParametricNullness;"
			})] object obj1, [ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/util/concurrent/ParametricNullness;"
			})] object obj2, [ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/util/concurrent/ParametricNullness;"
			})] object obj3);
		}

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/util/concurrent/ClosingFuture<TV1;>;")]
		private ClosingFuture future1;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/util/concurrent/ClosingFuture<TV2;>;")]
		private ClosingFuture future2;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/util/concurrent/ClosingFuture<TV3;>;")]
		private ClosingFuture future3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(1563)]
		internal Combiner3(ClosingFuture P_0, ClosingFuture P_1, ClosingFuture P_2, ClosingFuture._1 P_3)
			: this(P_0, P_1, P_2)
		{
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(1563)]
		internal static ClosingFuture access_00242000(Combiner3 P_0)
		{
			return P_0.future1;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(1563)]
		internal static ClosingFuture access_00242100(Combiner3 P_0)
		{
			return P_0.future2;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(1563)]
		internal static ClosingFuture access_00242200(Combiner3 P_0)
		{
			return P_0.future3;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/ClosingFuture<TV1;>;Lcom/google/common/util/concurrent/ClosingFuture<TV2;>;Lcom/google/common/util/concurrent/ClosingFuture<TV3;>;)V")]
		[LineNumberTable(new byte[] { 165, 241, 114, 103, 103, 103 })]
		private Combiner3(ClosingFuture P_0, ClosingFuture P_1, ClosingFuture P_2)
			: base(true, ImmutableList.of(P_0, P_1, P_2), null)
		{
			future1 = P_0;
			future2 = P_1;
			future3 = P_2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<U:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/ClosingFuture$Combiner3$ClosingFunction3<TV1;TV2;TV3;TU;>;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/ClosingFuture<TU;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 48, 0, 0 })]
		[LineNumberTable(1656)]
		public virtual ClosingFuture call(ClosingFunction3 function, Executor executor)
		{
			ClosingFuture result = base.call(new _1(this, function), executor);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<U:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/ClosingFuture$Combiner3$AsyncClosingFunction3<TV1;TV2;TV3;TU;>;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/ClosingFuture<TU;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 48, 0, 0 })]
		[LineNumberTable(1714)]
		public virtual ClosingFuture callAsync(AsyncClosingFunction3 function, Executor executor)
		{
			ClosingFuture result = base.callAsync(new _2(this, function), executor);
			_ = null;
			return result;
		}

		[HideFromJava]
		static Combiner3()
		{
			Combiner.___003Cclinit_003E();
		}
	}

	[Signature("<V1:Ljava/lang/Object;V2:Ljava/lang/Object;V3:Ljava/lang/Object;V4:Ljava/lang/Object;>Lcom/google/common/util/concurrent/ClosingFuture$Combiner;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 4, 17, 0, 0, 0, 0, 51, 0, 0,
		17, 1, 0, 0, 0, 51, 0, 0, 17, 2,
		0, 0, 0, 51, 0, 0, 17, 3, 0, 0,
		0, 51, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)51,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	public sealed class Combiner4 : Combiner
	{
		[SpecialName]
		[Signature("Ljava/lang/Object;Lcom/google/common/util/concurrent/ClosingFuture$Combiner$CombiningCallable<TU;>;")]
		[EnclosingMethod(null, "call", "(Lcom.google.common.util.concurrent.ClosingFuture$Combiner4$ClosingFunction4;Ljava.util.concurrent.Executor;)Lcom.google.common.util.concurrent.ClosingFuture;")]
		internal new class _1 : java.lang.Object, CombiningCallable
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal ClosingFunction4 val_0024function;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Combiner4 this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(1853)]
			internal _1(Combiner4 P_0, ClosingFunction4 P_1)
			{
				this_00240 = P_0;
				val_0024function = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Throws(new string[] { "java.lang.Exception" })]
			[Signature("(Lcom/google/common/util/concurrent/ClosingFuture$DeferredCloser;Lcom/google/common/util/concurrent/ClosingFuture$Peeker;)TU;")]
			[LineNumberTable(new byte[] { 166, 207, 142, 113, 113, 113, 234, 59 })]
			[ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/util/concurrent/ParametricNullness;"
			})]
			public virtual object call(DeferredCloser P_0, Peeker P_1)
			{
				object result = val_0024function.apply(P_0, P_1.getDone(access_00242300(this_00240)), P_1.getDone(access_00242400(this_00240)), P_1.getDone(access_00242500(this_00240)), P_1.getDone(access_00242600(this_00240)));
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(1867)]
			public override string toString()
			{
				string result = java.lang.Object.instancehelper_toString(val_0024function);
				_ = null;
				return result;
			}
		}

		[SpecialName]
		[Signature("Ljava/lang/Object;Lcom/google/common/util/concurrent/ClosingFuture$Combiner$AsyncCombiningCallable<TU;>;")]
		[EnclosingMethod(null, "callAsync", "(Lcom.google.common.util.concurrent.ClosingFuture$Combiner4$AsyncClosingFunction4;Ljava.util.concurrent.Executor;)Lcom.google.common.util.concurrent.ClosingFuture;")]
		internal new class _2 : java.lang.Object, AsyncCombiningCallable
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal AsyncClosingFunction4 val_0024function;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Combiner4 this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(1912)]
			internal _2(Combiner4 P_0, AsyncClosingFunction4 P_1)
			{
				this_00240 = P_0;
				val_0024function = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Throws(new string[] { "java.lang.Exception" })]
			[Signature("(Lcom/google/common/util/concurrent/ClosingFuture$DeferredCloser;Lcom/google/common/util/concurrent/ClosingFuture$Peeker;)Lcom/google/common/util/concurrent/ClosingFuture<TU;>;")]
			[LineNumberTable(new byte[] { 167, 9, 142, 113, 113, 113, 234, 59 })]
			public virtual ClosingFuture call(DeferredCloser P_0, Peeker P_1)
			{
				ClosingFuture result = val_0024function.apply(P_0, P_1.getDone(access_00242300(this_00240)), P_1.getDone(access_00242400(this_00240)), P_1.getDone(access_00242500(this_00240)), P_1.getDone(access_00242600(this_00240)));
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(1925)]
			public override string toString()
			{
				string result = java.lang.Object.instancehelper_toString(val_0024function);
				_ = null;
				return result;
			}
		}

		[Signature("<V1:Ljava/lang/Object;V2:Ljava/lang/Object;V3:Ljava/lang/Object;V4:Ljava/lang/Object;U:Ljava/lang/Object;>Ljava/lang/Object;")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 5, 17, 0, 0, 0, 0, 20, 0, 0,
			17, 1, 0, 0, 0, 20, 0, 0, 17, 2,
			0, 0, 0, 20, 0, 0, 17, 3, 0, 0,
			0, 20, 0, 0, 17, 4, 0, 0, 0, 20,
			0, 0
		})]
		[ConstantPool(new object[]
		{
			(byte)20,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		[FunctionalInterface(new object[]
		{
			(byte)64,
			"Ljava/lang/FunctionalInterface;"
		})]
		public interface AsyncClosingFunction4
		{
			[Throws(new string[] { "java.lang.Exception" })]
			[Signature("(Lcom/google/common/util/concurrent/ClosingFuture$DeferredCloser;TV1;TV2;TV3;TV4;)Lcom/google/common/util/concurrent/ClosingFuture<TU;>;")]
			virtual ClosingFuture apply(DeferredCloser cfdc, [ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/util/concurrent/ParametricNullness;"
			})] object obj1, [ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/util/concurrent/ParametricNullness;"
			})] object obj2, [ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/util/concurrent/ParametricNullness;"
			})] object obj3, [ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/util/concurrent/ParametricNullness;"
			})] object obj4);
		}

		[Signature("<V1:Ljava/lang/Object;V2:Ljava/lang/Object;V3:Ljava/lang/Object;V4:Ljava/lang/Object;U:Ljava/lang/Object;>Ljava/lang/Object;")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 5, 17, 0, 0, 0, 0, 20, 0, 0,
			17, 1, 0, 0, 0, 20, 0, 0, 17, 2,
			0, 0, 0, 20, 0, 0, 17, 3, 0, 0,
			0, 20, 0, 0, 17, 4, 0, 0, 0, 20,
			0, 0
		})]
		[ConstantPool(new object[]
		{
			(byte)20,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		[FunctionalInterface(new object[]
		{
			(byte)64,
			"Ljava/lang/FunctionalInterface;"
		})]
		public interface ClosingFunction4
		{
			[Throws(new string[] { "java.lang.Exception" })]
			[Signature("(Lcom/google/common/util/concurrent/ClosingFuture$DeferredCloser;TV1;TV2;TV3;TV4;)TU;")]
			[ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/util/concurrent/ParametricNullness;"
			})]
			virtual object apply(DeferredCloser cfdc, [ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/util/concurrent/ParametricNullness;"
			})] object obj1, [ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/util/concurrent/ParametricNullness;"
			})] object obj2, [ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/util/concurrent/ParametricNullness;"
			})] object obj3, [ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/util/concurrent/ParametricNullness;"
			})] object obj4);
		}

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/util/concurrent/ClosingFuture<TV1;>;")]
		private ClosingFuture future1;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/util/concurrent/ClosingFuture<TV2;>;")]
		private ClosingFuture future2;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/util/concurrent/ClosingFuture<TV3;>;")]
		private ClosingFuture future3;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/util/concurrent/ClosingFuture<TV4;>;")]
		private ClosingFuture future4;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(1744)]
		internal Combiner4(ClosingFuture P_0, ClosingFuture P_1, ClosingFuture P_2, ClosingFuture P_3, ClosingFuture._1 P_4)
			: this(P_0, P_1, P_2, P_3)
		{
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(1744)]
		internal static ClosingFuture access_00242300(Combiner4 P_0)
		{
			return P_0.future1;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(1744)]
		internal static ClosingFuture access_00242400(Combiner4 P_0)
		{
			return P_0.future2;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(1744)]
		internal static ClosingFuture access_00242500(Combiner4 P_0)
		{
			return P_0.future3;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(1744)]
		internal static ClosingFuture access_00242600(Combiner4 P_0)
		{
			return P_0.future4;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/ClosingFuture<TV1;>;Lcom/google/common/util/concurrent/ClosingFuture<TV2;>;Lcom/google/common/util/concurrent/ClosingFuture<TV3;>;Lcom/google/common/util/concurrent/ClosingFuture<TV4;>;)V")]
		[LineNumberTable(new byte[] { 166, 180, 116, 103, 103, 103, 104 })]
		private Combiner4(ClosingFuture P_0, ClosingFuture P_1, ClosingFuture P_2, ClosingFuture P_3)
			: base(true, ImmutableList.of(P_0, P_1, P_2, P_3), null)
		{
			future1 = P_0;
			future2 = P_1;
			future3 = P_2;
			future4 = P_3;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<U:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/ClosingFuture$Combiner4$ClosingFunction4<TV1;TV2;TV3;TV4;TU;>;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/ClosingFuture<TU;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 51, 0, 0 })]
		[LineNumberTable(1852)]
		public virtual ClosingFuture call(ClosingFunction4 function, Executor executor)
		{
			ClosingFuture result = base.call(new _1(this, function), executor);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<U:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/ClosingFuture$Combiner4$AsyncClosingFunction4<TV1;TV2;TV3;TV4;TU;>;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/ClosingFuture<TU;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 51, 0, 0 })]
		[LineNumberTable(1911)]
		public virtual ClosingFuture callAsync(AsyncClosingFunction4 function, Executor executor)
		{
			ClosingFuture result = base.callAsync(new _2(this, function), executor);
			_ = null;
			return result;
		}

		[HideFromJava]
		static Combiner4()
		{
			Combiner.___003Cclinit_003E();
		}
	}

	[Signature("<V1:Ljava/lang/Object;V2:Ljava/lang/Object;V3:Ljava/lang/Object;V4:Ljava/lang/Object;V5:Ljava/lang/Object;>Lcom/google/common/util/concurrent/ClosingFuture$Combiner;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 5, 17, 0, 0, 0, 0, 54, 0, 0,
		17, 1, 0, 0, 0, 54, 0, 0, 17, 2,
		0, 0, 0, 54, 0, 0, 17, 3, 0, 0,
		0, 54, 0, 0, 17, 4, 0, 0, 0, 54,
		0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)54,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	public sealed class Combiner5 : Combiner
	{
		[SpecialName]
		[Signature("Ljava/lang/Object;Lcom/google/common/util/concurrent/ClosingFuture$Combiner$CombiningCallable<TU;>;")]
		[EnclosingMethod(null, "call", "(Lcom.google.common.util.concurrent.ClosingFuture$Combiner5$ClosingFunction5;Ljava.util.concurrent.Executor;)Lcom.google.common.util.concurrent.ClosingFuture;")]
		internal new class _1 : java.lang.Object, CombiningCallable
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal ClosingFunction5 val_0024function;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Combiner5 this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(2064)]
			internal _1(Combiner5 P_0, ClosingFunction5 P_1)
			{
				this_00240 = P_0;
				val_0024function = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Throws(new string[] { "java.lang.Exception" })]
			[Signature("(Lcom/google/common/util/concurrent/ClosingFuture$DeferredCloser;Lcom/google/common/util/concurrent/ClosingFuture$Peeker;)TU;")]
			[LineNumberTable(new byte[] { 167, 162, 142, 113, 113, 113, 113, 234, 58 })]
			[ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/util/concurrent/ParametricNullness;"
			})]
			public virtual object call(DeferredCloser P_0, Peeker P_1)
			{
				object result = val_0024function.apply(P_0, P_1.getDone(access_00242700(this_00240)), P_1.getDone(access_00242800(this_00240)), P_1.getDone(access_00242900(this_00240)), P_1.getDone(access_00243000(this_00240)), P_1.getDone(access_00243100(this_00240)));
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(2079)]
			public override string toString()
			{
				string result = java.lang.Object.instancehelper_toString(val_0024function);
				_ = null;
				return result;
			}
		}

		[SpecialName]
		[Signature("Ljava/lang/Object;Lcom/google/common/util/concurrent/ClosingFuture$Combiner$AsyncCombiningCallable<TU;>;")]
		[EnclosingMethod(null, "callAsync", "(Lcom.google.common.util.concurrent.ClosingFuture$Combiner5$AsyncClosingFunction5;Ljava.util.concurrent.Executor;)Lcom.google.common.util.concurrent.ClosingFuture;")]
		internal new class _2 : java.lang.Object, AsyncCombiningCallable
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal AsyncClosingFunction5 val_0024function;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Combiner5 this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(2125)]
			internal _2(Combiner5 P_0, AsyncClosingFunction5 P_1)
			{
				this_00240 = P_0;
				val_0024function = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Throws(new string[] { "java.lang.Exception" })]
			[Signature("(Lcom/google/common/util/concurrent/ClosingFuture$DeferredCloser;Lcom/google/common/util/concurrent/ClosingFuture$Peeker;)Lcom/google/common/util/concurrent/ClosingFuture<TU;>;")]
			[LineNumberTable(new byte[] { 167, 222, 142, 113, 113, 113, 113, 234, 58 })]
			public virtual ClosingFuture call(DeferredCloser P_0, Peeker P_1)
			{
				ClosingFuture result = val_0024function.apply(P_0, P_1.getDone(access_00242700(this_00240)), P_1.getDone(access_00242800(this_00240)), P_1.getDone(access_00242900(this_00240)), P_1.getDone(access_00243000(this_00240)), P_1.getDone(access_00243100(this_00240)));
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(2139)]
			public override string toString()
			{
				string result = java.lang.Object.instancehelper_toString(val_0024function);
				_ = null;
				return result;
			}
		}

		[Signature("<V1:Ljava/lang/Object;V2:Ljava/lang/Object;V3:Ljava/lang/Object;V4:Ljava/lang/Object;V5:Ljava/lang/Object;U:Ljava/lang/Object;>Ljava/lang/Object;")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 6, 17, 0, 0, 0, 0, 20, 0, 0,
			17, 1, 0, 0, 0, 20, 0, 0, 17, 2,
			0, 0, 0, 20, 0, 0, 17, 3, 0, 0,
			0, 20, 0, 0, 17, 4, 0, 0, 0, 20,
			0, 0, 17, 5, 0, 0, 0, 20, 0, 0
		})]
		[ConstantPool(new object[]
		{
			(byte)20,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		[FunctionalInterface(new object[]
		{
			(byte)64,
			"Ljava/lang/FunctionalInterface;"
		})]
		public interface AsyncClosingFunction5
		{
			[Throws(new string[] { "java.lang.Exception" })]
			[Signature("(Lcom/google/common/util/concurrent/ClosingFuture$DeferredCloser;TV1;TV2;TV3;TV4;TV5;)Lcom/google/common/util/concurrent/ClosingFuture<TU;>;")]
			virtual ClosingFuture apply(DeferredCloser cfdc, [ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/util/concurrent/ParametricNullness;"
			})] object obj1, [ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/util/concurrent/ParametricNullness;"
			})] object obj2, [ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/util/concurrent/ParametricNullness;"
			})] object obj3, [ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/util/concurrent/ParametricNullness;"
			})] object obj4, [ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/util/concurrent/ParametricNullness;"
			})] object obj5);
		}

		[Signature("<V1:Ljava/lang/Object;V2:Ljava/lang/Object;V3:Ljava/lang/Object;V4:Ljava/lang/Object;V5:Ljava/lang/Object;U:Ljava/lang/Object;>Ljava/lang/Object;")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 6, 17, 0, 0, 0, 0, 20, 0, 0,
			17, 1, 0, 0, 0, 20, 0, 0, 17, 2,
			0, 0, 0, 20, 0, 0, 17, 3, 0, 0,
			0, 20, 0, 0, 17, 4, 0, 0, 0, 20,
			0, 0, 17, 5, 0, 0, 0, 20, 0, 0
		})]
		[ConstantPool(new object[]
		{
			(byte)20,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		[FunctionalInterface(new object[]
		{
			(byte)64,
			"Ljava/lang/FunctionalInterface;"
		})]
		public interface ClosingFunction5
		{
			[Throws(new string[] { "java.lang.Exception" })]
			[Signature("(Lcom/google/common/util/concurrent/ClosingFuture$DeferredCloser;TV1;TV2;TV3;TV4;TV5;)TU;")]
			[ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/util/concurrent/ParametricNullness;"
			})]
			virtual object apply(DeferredCloser cfdc, [ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/util/concurrent/ParametricNullness;"
			})] object obj1, [ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/util/concurrent/ParametricNullness;"
			})] object obj2, [ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/util/concurrent/ParametricNullness;"
			})] object obj3, [ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/util/concurrent/ParametricNullness;"
			})] object obj4, [ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/util/concurrent/ParametricNullness;"
			})] object obj5);
		}

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/util/concurrent/ClosingFuture<TV1;>;")]
		private ClosingFuture future1;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/util/concurrent/ClosingFuture<TV2;>;")]
		private ClosingFuture future2;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/util/concurrent/ClosingFuture<TV3;>;")]
		private ClosingFuture future3;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/util/concurrent/ClosingFuture<TV4;>;")]
		private ClosingFuture future4;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/util/concurrent/ClosingFuture<TV5;>;")]
		private ClosingFuture future5;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(1943)]
		internal Combiner5(ClosingFuture P_0, ClosingFuture P_1, ClosingFuture P_2, ClosingFuture P_3, ClosingFuture P_4, ClosingFuture._1 P_5)
			: this(P_0, P_1, P_2, P_3, P_4)
		{
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(1943)]
		internal static ClosingFuture access_00242700(Combiner5 P_0)
		{
			return P_0.future1;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(1943)]
		internal static ClosingFuture access_00242800(Combiner5 P_0)
		{
			return P_0.future2;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(1943)]
		internal static ClosingFuture access_00242900(Combiner5 P_0)
		{
			return P_0.future3;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(1943)]
		internal static ClosingFuture access_00243000(Combiner5 P_0)
		{
			return P_0.future4;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(1943)]
		internal static ClosingFuture access_00243100(Combiner5 P_0)
		{
			return P_0.future5;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/ClosingFuture<TV1;>;Lcom/google/common/util/concurrent/ClosingFuture<TV2;>;Lcom/google/common/util/concurrent/ClosingFuture<TV3;>;Lcom/google/common/util/concurrent/ClosingFuture<TV4;>;Lcom/google/common/util/concurrent/ClosingFuture<TV5;>;)V")]
		[LineNumberTable(new byte[] { 167, 133, 118, 103, 103, 103, 104, 104 })]
		private Combiner5(ClosingFuture P_0, ClosingFuture P_1, ClosingFuture P_2, ClosingFuture P_3, ClosingFuture P_4)
			: base(true, ImmutableList.of(P_0, P_1, P_2, P_3, P_4), null)
		{
			future1 = P_0;
			future2 = P_1;
			future3 = P_2;
			future4 = P_3;
			future5 = P_4;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<U:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/ClosingFuture$Combiner5$ClosingFunction5<TV1;TV2;TV3;TV4;TV5;TU;>;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/ClosingFuture<TU;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 54, 0, 0 })]
		[LineNumberTable(2063)]
		public virtual ClosingFuture call(ClosingFunction5 function, Executor executor)
		{
			ClosingFuture result = base.call(new _1(this, function), executor);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<U:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/ClosingFuture$Combiner5$AsyncClosingFunction5<TV1;TV2;TV3;TV4;TV5;TU;>;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/ClosingFuture<TU;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 54, 0, 0 })]
		[LineNumberTable(2124)]
		public virtual ClosingFuture callAsync(AsyncClosingFunction5 function, Executor executor)
		{
			ClosingFuture result = base.callAsync(new _2(this, function), executor);
			_ = null;
			return result;
		}

		[HideFromJava]
		static Combiner5()
		{
			Combiner.___003Cclinit_003E();
		}
	}

	[ConstantPool(new object[]
	{
		(byte)38,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	public sealed class DeferredCloser : java.lang.Object
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private CloseableList list;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<C:Ljava/lang/Object;:Ljava/lang/AutoCloseable;>(TC;Ljava/util/concurrent/Executor;)TC;")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 2, 18, 0, 0, 0, 0, 38, 0, 0,
			18, 0, 1, 0, 0, 38, 0, 0
		})]
		[LineNumberTable(new byte[] { 160, 123, 103, 99, 146 })]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/util/concurrent/ParametricNullness;"
		})]
		public virtual object eventuallyClose([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/util/concurrent/ParametricNullness;"
		})] object closeable, Executor closingExecutor)
		{
			Preconditions.checkNotNull(closingExecutor);
			if (closeable != null)
			{
				list.add((IDisposable)closeable, closingExecutor);
			}
			return closeable;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 92, 104, 103 })]
		internal DeferredCloser(CloseableList P_0)
		{
			list = P_0;
		}
	}

	[ConstantPool(new object[]
	{
		(byte)52,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	public sealed class Peeker : java.lang.Object
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/ImmutableList<Lcom/google/common/util/concurrent/ClosingFuture<*>;>;")]
		private ImmutableList futures;

		private volatile bool beingCalled;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(1152)]
		internal Peeker(ImmutableList P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(1152)]
		internal static object access_00241500(Peeker P_0, Combiner.CombiningCallable P_1, CloseableList P_2)
		{
			object result = P_0.call(P_1, P_2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(1152)]
		internal static FluentFuture access_00241700(Peeker P_0, Combiner.AsyncCombiningCallable P_1, CloseableList P_2)
		{
			FluentFuture result = P_0.callAsync(P_1, P_2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.util.concurrent.ExecutionException" })]
		[Signature("<D:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/ClosingFuture<TD;>;)TD;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 52, 0, 0 })]
		[LineNumberTable(new byte[] { 164, 36, 109, 113 })]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/util/concurrent/ParametricNullness;"
		})]
		public object getDone(ClosingFuture closingFuture)
		{
			Preconditions.checkState(beingCalled);
			Preconditions.checkArgument(futures.contains(closingFuture));
			object done = Futures.getDone(access_0024000(closingFuture));
			_ = null;
			return done;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Signature("<V:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/ClosingFuture$Combiner$AsyncCombiningCallable<TV;>;Lcom/google/common/util/concurrent/ClosingFuture$CloseableList;)Lcom/google/common/util/concurrent/FluentFuture<TV;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 52, 0, 0 })]
		[LineNumberTable(new byte[]
		{
			164, 56, 110, 135, 110, 103, 139, 108, 110, 3,
			2
		})]
		private FluentFuture callAsync(Combiner.AsyncCombiningCallable P_0, CloseableList P_1)
		{
			beingCalled = true;
			System.Threading.Thread.MemoryBarrier();
			CloseableList closeableList = new CloseableList(null);
			try
			{
				ClosingFuture closingFuture = P_0.call(CloseableList.access_0024300(closeableList), this);
				access_00241000(closingFuture, P_1);
				return access_0024000(closingFuture);
			}
			finally
			{
				P_1.add(closeableList, MoreExecutors.directExecutor());
				beingCalled = false;
				System.Threading.Thread.MemoryBarrier();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Signature("<V:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/ClosingFuture$Combiner$CombiningCallable<TV;>;Lcom/google/common/util/concurrent/ClosingFuture$CloseableList;)TV;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 52, 0, 0 })]
		[LineNumberTable(new byte[] { 164, 44, 110, 135, 146, 108, 110, 3, 2 })]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/util/concurrent/ParametricNullness;"
		})]
		private object call(Combiner.CombiningCallable P_0, CloseableList P_1)
		{
			beingCalled = true;
			System.Threading.Thread.MemoryBarrier();
			CloseableList closeableList = new CloseableList(null);
			try
			{
				return P_0.call(CloseableList.access_0024300(closeableList), this);
			}
			finally
			{
				P_1.add(closeableList, MoreExecutors.directExecutor());
				beingCalled = false;
				System.Threading.Thread.MemoryBarrier();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableList<Lcom/google/common/util/concurrent/ClosingFuture<*>;>;)V")]
		[LineNumberTable(new byte[] { 164, 18, 104, 113 })]
		private Peeker(ImmutableList P_0)
		{
			futures = (ImmutableList)Preconditions.checkNotNull(P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/util/concurrent/ClosingFuture$State;>;")]
	[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	internal sealed class State : java.lang.Enum
	{
		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static State OPEN;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static State SUBSUMED;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static State WILL_CLOSE;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static State CLOSING;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static State CLOSED;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static State WILL_CREATE_VALUE_AND_CLOSER;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static State[] _0024VALUES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(2293)]
		public static State[] values()
		{
			return (State[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(2293)]
		private State(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(2293)]
		private static State[] _0024values()
		{
			return new State[6] { OPEN, SUBSUMED, WILL_CLOSE, CLOSING, CLOSED, WILL_CREATE_VALUE_AND_CLOSER };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(2293)]
		public static State valueOf(string P_0)
		{
			return (State)java.lang.Enum.valueOf(ClassLiteral<State>.Value, P_0);
		}

		[LineNumberTable(new byte[]
		{
			168, 133, 240, 70, 240, 70, 240, 70, 176, 240,
			70, 240, 35
		})]
		static State()
		{
			OPEN = new State("OPEN", 0);
			SUBSUMED = new State("SUBSUMED", 1);
			WILL_CLOSE = new State("WILL_CLOSE", 2);
			CLOSING = new State("CLOSING", 3);
			CLOSED = new State("CLOSED", 4);
			WILL_CREATE_VALUE_AND_CLOSER = new State("WILL_CREATE_VALUE_AND_CLOSER", 5);
			_0024VALUES = _0024values();
		}
	}

	[Signature("<V:Ljava/lang/Object;>Ljava/lang/Object;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 39, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)39,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	public sealed class ValueAndCloser : java.lang.Object
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/util/concurrent/ClosingFuture<+TV;>;")]
		private ClosingFuture closingFuture;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/ClosingFuture<+TV;>;)V")]
		[LineNumberTable(new byte[] { 160, 219, 104, 113 })]
		internal ValueAndCloser(ClosingFuture P_0)
		{
			closingFuture = (ClosingFuture)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.util.concurrent.ExecutionException" })]
		[Signature("()TV;")]
		[LineNumberTable(349)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/util/concurrent/ParametricNullness;"
		})]
		public virtual object get()
		{
			object done = Futures.getDone(access_0024000(closingFuture));
			_ = null;
			return done;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 249, 109 })]
		public virtual void closeAsync()
		{
			access_0024100(closingFuture);
		}
	}

	[Signature("<V:Ljava/lang/Object;>Ljava/lang/Object;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 16, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)16,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[FunctionalInterface(new object[]
	{
		(byte)64,
		"Ljava/lang/FunctionalInterface;"
	})]
	public interface ValueAndCloserConsumer
	{
		[Signature("(Lcom/google/common/util/concurrent/ClosingFuture$ValueAndCloser<TV;>;)V")]
		virtual void accept(ValueAndCloser cfvac);
	}

	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Logger logger;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Ljava/util/concurrent/atomic/AtomicReference<Lcom/google/common/util/concurrent/ClosingFuture$State;>;")]
	private AtomicReference state;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private CloseableList closeables;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/util/concurrent/FluentFuture<TV;>;")]
	private FluentFuture future;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(195)]
	internal static CloseableList access_0024200(ClosingFuture P_0)
	{
		return P_0.closeables;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		167,
		byte.MaxValue,
		99,
		161,
		254,
		81,
		226,
		58,
		97,
		113,
		121,
		38,
		165,
		139
	})]
	private static void closeQuietly([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] IDisposable P_0, Executor P_1)
	{
		if (P_0 != null)
		{
			RejectedExecutionException ex;
			try
			{
				P_1.execute(new _11(P_0));
				return;
			}
			catch (RejectedExecutionException x)
			{
				ex = ByteCodeHelper.MapException<RejectedExecutionException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			RejectedExecutionException thrown = ex;
			if (logger.isLoggable(Level.WARNING))
			{
				logger.log(Level.WARNING, java.lang.String.format("while submitting close to %s; will close inline", P_1), thrown);
			}
			closeQuietly(P_0, MoreExecutors.directExecutor());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/util/concurrent/ListenableFuture<TV;>;)V")]
	[LineNumberTable(new byte[] { 161, 223, 232, 60, 112, 204, 108 })]
	private ClosingFuture(ListenableFuture P_0)
	{
		state = new AtomicReference(State.OPEN);
		closeables = new CloseableList(null);
		future = FluentFuture.from(P_0);
		GC.KeepAlive(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<C:Ljava/lang/Object;V:TC;>(Lcom/google/common/util/concurrent/ClosingFuture$ValueAndCloserConsumer<TC;>;Lcom/google/common/util/concurrent/ClosingFuture<TV;>;)V")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 173, 0, 0 })]
	[LineNumberTable(new byte[] { 163, 219, 110 })]
	private static void provideValueAndCloser(ValueAndCloserConsumer P_0, ClosingFuture P_1)
	{
		P_0.accept(new ValueAndCloser(P_1));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 168, 24, 99, 44, 231, 69 })]
	private void checkAndUpdateState(State P_0, State P_1)
	{
		Preconditions.checkState(compareAndUpdateState(P_0, P_1), "Expected state to be %s, but it was %s", P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 4, 112, 115 })]
	private void becomeSubsumedInto(CloseableList P_0)
	{
		checkAndUpdateState(State.OPEN, State.SUBSUMED);
		P_0.add(closeables, MoreExecutors.directExecutor());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 249, 117, 109 })]
	private void close()
	{
		logger.log(Level.FINER, "closing {0}", this);
		closeables.close();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/util/concurrent/ClosingFuture$ClosingCallable<TV;>;Ljava/util/concurrent/Executor;)V")]
	[LineNumberTable(new byte[]
	{
		161, 227, 232, 56, 112, 236, 72, 103, 103, 230,
		77, 103, 103
	})]
	private ClosingFuture(ClosingCallable P_0, Executor P_1)
	{
		state = new AtomicReference(State.OPEN);
		closeables = new CloseableList(null);
		Preconditions.checkNotNull(P_0);
		TrustedListenableFutureTask command = TrustedListenableFutureTask.create(new _2(this, P_0));
		P_1.execute(command);
		future = command;
		GC.KeepAlive(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/util/concurrent/ClosingFuture$AsyncClosingCallable<TV;>;Ljava/util/concurrent/Executor;)V")]
	[LineNumberTable(new byte[]
	{
		161, 247, 232, 36, 112, 236, 92, 103, 103, 230,
		83, 103, 103
	})]
	private ClosingFuture(AsyncClosingCallable P_0, Executor P_1)
	{
		state = new AtomicReference(State.OPEN);
		closeables = new CloseableList(null);
		Preconditions.checkNotNull(P_0);
		TrustedListenableFutureTask command = TrustedListenableFutureTask.create(new _3(this, P_0));
		P_1.execute(command);
		future = command;
		GC.KeepAlive(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<+Lcom/google/common/util/concurrent/ClosingFuture<*>;>;)Lcom/google/common/util/concurrent/ClosingFuture$Combiner;")]
	[LineNumberTable(464)]
	public static Combiner whenAllComplete(Iterable futures)
	{
		Combiner result = new Combiner(false, futures, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<+Lcom/google/common/util/concurrent/ClosingFuture<*>;>;)Lcom/google/common/util/concurrent/ClosingFuture$Combiner;")]
	[LineNumberTable(486)]
	public static Combiner whenAllSucceed(Iterable futures)
	{
		Combiner result = new Combiner(true, futures, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<U:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/FluentFuture<TU;>;)Lcom/google/common/util/concurrent/ClosingFuture<TU;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 173, 0, 0 })]
	[LineNumberTable(new byte[] { 163, 254, 103, 108 })]
	private ClosingFuture derive(FluentFuture P_0)
	{
		ClosingFuture closingFuture = new ClosingFuture(P_0);
		becomeSubsumedInto(closingFuture.closeables);
		return closingFuture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<X:Ljava/lang/Throwable;W:TV;>(Ljava/lang/Class<TX;>;Lcom/google/common/util/concurrent/ClosingFuture$ClosingFunction<-TX;TW;>;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/ClosingFuture<TV;>;")]
	[LineNumberTable(new byte[] { 163, 7, 103, 232, 77 })]
	private ClosingFuture catchingMoreGeneric(Class P_0, ClosingFunction P_1, Executor P_2)
	{
		Preconditions.checkNotNull(P_1);
		_7 fallback = new _7(this, P_1);
		ClosingFuture result = derive(future.catchingAsync(P_0, fallback, P_2));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<X:Ljava/lang/Throwable;W:TV;>(Ljava/lang/Class<TX;>;Lcom/google/common/util/concurrent/ClosingFuture$AsyncClosingFunction<-TX;TW;>;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/ClosingFuture<TV;>;")]
	[LineNumberTable(new byte[] { 163, 106, 103, 232, 76 })]
	private ClosingFuture catchingAsyncMoreGeneric(Class P_0, AsyncClosingFunction P_1, Executor P_2)
	{
		Preconditions.checkNotNull(P_1);
		_8 fallback = new _8(this, P_1);
		ClosingFuture result = derive(future.catchingAsync(P_0, fallback, P_2));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(2194)]
	private bool compareAndUpdateState(State P_0, State P_1)
	{
		bool result = state.compareAndSet(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/util/concurrent/FluentFuture<TV;>;")]
	[LineNumberTable(new byte[]
	{
		163, 139, 114, 117, 236, 73, 229, 55, 231, 75,
		159, 29, 208, 240, 70, 176, 171
	})]
	public virtual FluentFuture finishToFuture()
	{
		if (compareAndUpdateState(State.OPEN, State.WILL_CLOSE))
		{
			logger.log(Level.FINER, "will close {0}", this);
			future.addListener(new _9(this), MoreExecutors.directExecutor());
		}
		else
		{
			switch (_12._0024SwitchMap_0024com_0024google_0024common_0024util_0024concurrent_0024ClosingFuture_0024State[((State)state.get()).ordinal()])
			{
			case 1:
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new IllegalStateException("Cannot call finishToFuture() after deriving another step");
			case 2:
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new IllegalStateException("Cannot call finishToFuture() after calling finishToValueAndCloser()");
			case 3:
			case 4:
			case 5:
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new IllegalStateException("Cannot call finishToFuture() twice");
			case 6:
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new AssertionError();
			}
		}
		return future;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/ClosingFuture$ClosingCallable<TV;>;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/ClosingFuture<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 173, 0, 0 })]
	[LineNumberTable(389)]
	public static ClosingFuture submit(ClosingCallable callable, Executor executor)
	{
		ClosingFuture result = new ClosingFuture(callable, executor);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/ClosingFuture$AsyncClosingCallable<TV;>;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/ClosingFuture<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 173, 0, 0 })]
	[LineNumberTable(401)]
	public static ClosingFuture submitAsync(AsyncClosingCallable callable, Executor executor)
	{
		ClosingFuture result = new ClosingFuture(callable, executor);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/ListenableFuture<TV;>;)Lcom/google/common/util/concurrent/ClosingFuture<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 173, 0, 0 })]
	[LineNumberTable(412)]
	public static ClosingFuture from(ListenableFuture future)
	{
		ClosingFuture result = new ClosingFuture(future);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<C:Ljava/lang/Object;:Ljava/lang/AutoCloseable;>(Lcom/google/common/util/concurrent/ListenableFuture<TC;>;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/ClosingFuture<TC;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 173, 0, 0,
		18, 0, 1, 0, 0, 173, 0, 0
	})]
	[LineNumberTable(new byte[] { 161, 70, 103, 108, 232, 75, 229, 53, 229, 76 })]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static ClosingFuture eventuallyClosing(ListenableFuture future, Executor closingExecutor)
	{
		Preconditions.checkNotNull(closingExecutor);
		ClosingFuture closingFuture = new ClosingFuture(Futures.nonCancellationPropagating(future));
		Futures.addCallback(future, new _1(closingFuture, closingExecutor), MoreExecutors.directExecutor());
		return closingFuture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/util/concurrent/ClosingFuture<*>;[Lcom/google/common/util/concurrent/ClosingFuture<*>;)Lcom/google/common/util/concurrent/ClosingFuture$Combiner;")]
	[LineNumberTable(475)]
	public static Combiner whenAllComplete(ClosingFuture future1, params ClosingFuture[] moreFutures)
	{
		Combiner result = whenAllComplete(Lists.asList(future1, moreFutures));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V1:Ljava/lang/Object;V2:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/ClosingFuture<TV1;>;Lcom/google/common/util/concurrent/ClosingFuture<TV2;>;)Lcom/google/common/util/concurrent/ClosingFuture$Combiner2<TV1;TV2;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 173, 0, 0,
		18, 1, 0, 0, 0, 173, 0, 0
	})]
	[LineNumberTable(501)]
	public static Combiner2 whenAllSucceed(ClosingFuture future1, ClosingFuture future2)
	{
		Combiner2 result = new Combiner2(future1, future2, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V1:Ljava/lang/Object;V2:Ljava/lang/Object;V3:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/ClosingFuture<TV1;>;Lcom/google/common/util/concurrent/ClosingFuture<TV2;>;Lcom/google/common/util/concurrent/ClosingFuture<TV3;>;)Lcom/google/common/util/concurrent/ClosingFuture$Combiner3<TV1;TV2;TV3;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 18, 0, 0, 0, 0, 173, 0, 0,
		18, 1, 0, 0, 0, 173, 0, 0, 18, 2,
		0, 0, 0, 173, 0, 0
	})]
	[LineNumberTable(518)]
	public static Combiner3 whenAllSucceed(ClosingFuture future1, ClosingFuture future2, ClosingFuture future3)
	{
		Combiner3 result = new Combiner3(future1, future2, future3, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V1:Ljava/lang/Object;V2:Ljava/lang/Object;V3:Ljava/lang/Object;V4:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/ClosingFuture<TV1;>;Lcom/google/common/util/concurrent/ClosingFuture<TV2;>;Lcom/google/common/util/concurrent/ClosingFuture<TV3;>;Lcom/google/common/util/concurrent/ClosingFuture<TV4;>;)Lcom/google/common/util/concurrent/ClosingFuture$Combiner4<TV1;TV2;TV3;TV4;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 4, 18, 0, 0, 0, 0, 173, 0, 0,
		18, 1, 0, 0, 0, 173, 0, 0, 18, 2,
		0, 0, 0, 173, 0, 0, 18, 3, 0, 0,
		0, 173, 0, 0
	})]
	[LineNumberTable(541)]
	public static Combiner4 whenAllSucceed(ClosingFuture future1, ClosingFuture future2, ClosingFuture future3, ClosingFuture future4)
	{
		Combiner4 result = new Combiner4(future1, future2, future3, future4, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V1:Ljava/lang/Object;V2:Ljava/lang/Object;V3:Ljava/lang/Object;V4:Ljava/lang/Object;V5:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/ClosingFuture<TV1;>;Lcom/google/common/util/concurrent/ClosingFuture<TV2;>;Lcom/google/common/util/concurrent/ClosingFuture<TV3;>;Lcom/google/common/util/concurrent/ClosingFuture<TV4;>;Lcom/google/common/util/concurrent/ClosingFuture<TV5;>;)Lcom/google/common/util/concurrent/ClosingFuture$Combiner5<TV1;TV2;TV3;TV4;TV5;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 5, 18, 0, 0, 0, 0, 173, 0, 0,
		18, 1, 0, 0, 0, 173, 0, 0, 18, 2,
		0, 0, 0, 173, 0, 0, 18, 3, 0, 0,
		0, 173, 0, 0, 18, 4, 0, 0, 0, 173,
		0, 0
	})]
	[LineNumberTable(566)]
	public static Combiner5 whenAllSucceed(ClosingFuture future1, ClosingFuture future2, ClosingFuture future3, ClosingFuture future4, ClosingFuture future5)
	{
		Combiner5 result = new Combiner5(future1, future2, future3, future4, future5, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/util/concurrent/ClosingFuture<*>;Lcom/google/common/util/concurrent/ClosingFuture<*>;Lcom/google/common/util/concurrent/ClosingFuture<*>;Lcom/google/common/util/concurrent/ClosingFuture<*>;Lcom/google/common/util/concurrent/ClosingFuture<*>;Lcom/google/common/util/concurrent/ClosingFuture<*>;[Lcom/google/common/util/concurrent/ClosingFuture<*>;)Lcom/google/common/util/concurrent/ClosingFuture$Combiner;")]
	[LineNumberTable(new byte[] { 161, 214, 125, 103, 5 })]
	public static Combiner whenAllSucceed(ClosingFuture future1, ClosingFuture future2, ClosingFuture future3, ClosingFuture future4, ClosingFuture future5, ClosingFuture future6, params ClosingFuture[] moreFutures)
	{
		Combiner result = whenAllSucceed(FluentIterable.of(future1, future2, future3, future4, future5, future6).append(moreFutures));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/util/concurrent/ListenableFuture<*>;")]
	[LineNumberTable(655)]
	public virtual ListenableFuture statusFuture()
	{
		ListenableFuture result = Futures.nonCancellationPropagating(future.transform(Functions.constant(null), MoreExecutors.directExecutor()));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<U:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/ClosingFuture$ClosingFunction<-TV;TU;>;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/ClosingFuture<TU;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 173, 0, 0 })]
	[LineNumberTable(new byte[] { 162, 67, 103, 232, 77 })]
	public virtual ClosingFuture transform(ClosingFunction function, Executor executor)
	{
		Preconditions.checkNotNull(function);
		_4 function2 = new _4(this, function);
		ClosingFuture result = derive(future.transformAsync(function2, executor));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<U:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/ClosingFuture$AsyncClosingFunction<-TV;TU;>;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/ClosingFuture<TU;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 173, 0, 0 })]
	[LineNumberTable(new byte[] { 162, 161, 103, 232, 76 })]
	public virtual ClosingFuture transformAsync(AsyncClosingFunction function, Executor executor)
	{
		Preconditions.checkNotNull(function);
		_5 function2 = new _5(this, function);
		ClosingFuture result = derive(future.transformAsync(function2, executor));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;U:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/AsyncFunction<TV;TU;>;)Lcom/google/common/util/concurrent/ClosingFuture$AsyncClosingFunction<TV;TU;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 173, 0, 0,
		18, 1, 0, 0, 0, 173, 0, 0
	})]
	[LineNumberTable(new byte[] { 162, 205, 103 })]
	public static AsyncClosingFunction withoutCloser(AsyncFunction function)
	{
		Preconditions.checkNotNull(function);
		_6 result = new _6(function);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<X:Ljava/lang/Throwable;>(Ljava/lang/Class<TX;>;Lcom/google/common/util/concurrent/ClosingFuture$ClosingFunction<-TX;+TV;>;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/ClosingFuture<TV;>;")]
	[LineNumberTable(883)]
	public virtual ClosingFuture catching(Class exceptionType, ClosingFunction fallback, Executor executor)
	{
		ClosingFuture result = catchingMoreGeneric(exceptionType, fallback, executor);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<X:Ljava/lang/Throwable;>(Ljava/lang/Class<TX;>;Lcom/google/common/util/concurrent/ClosingFuture$AsyncClosingFunction<-TX;+TV;>;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/ClosingFuture<TV;>;")]
	[LineNumberTable(980)]
	public virtual ClosingFuture catchingAsync(Class exceptionType, AsyncClosingFunction fallback, Executor executor)
	{
		ClosingFuture result = catchingAsyncMoreGeneric(exceptionType, fallback, executor);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/util/concurrent/ClosingFuture$ValueAndCloserConsumer<-TV;>;Ljava/util/concurrent/Executor;)V")]
	[LineNumberTable(new byte[]
	{
		163, 186, 103, 117, 159, 29, 240, 70, 208, 240,
		69, 145, 245, 72
	})]
	public virtual void finishToValueAndCloser(ValueAndCloserConsumer consumer, Executor executor)
	{
		Preconditions.checkNotNull(consumer);
		if (!compareAndUpdateState(State.OPEN, State.WILL_CREATE_VALUE_AND_CLOSER))
		{
			switch (_12._0024SwitchMap_0024com_0024google_0024common_0024util_0024concurrent_0024ClosingFuture_0024State[((State)state.get()).ordinal()])
			{
			case 1:
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new IllegalStateException("Cannot call finishToValueAndCloser() after deriving another step");
			case 3:
			case 4:
			case 5:
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new IllegalStateException("Cannot call finishToValueAndCloser() after calling finishToFuture()");
			case 2:
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new IllegalStateException("Cannot call finishToValueAndCloser() twice");
			default:
			{
				AtomicReference detailMessage = state;
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new AssertionError(detailMessage);
			}
			}
		}
		future.addListener(new _10(this, consumer), executor);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 158, 118, 130, 117, 109, 99, 134 })]
	public virtual bool cancel(bool mayInterruptIfRunning)
	{
		logger.log(Level.FINER, "cancelling {0}", this);
		int num = (future.cancel(mayInterruptIfRunning) ? 1 : 0);
		if (num != 0)
		{
			close();
		}
		return (byte)num != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(2149)]
	public override string toString()
	{
		string result = MoreObjects.toStringHelper(this).add("state", state.get()).addValue(future)
			.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 167, 248, 124, 117, 135 })]
	protected internal override void finalize()
	{
		if (((State)state.get()).equals(State.OPEN))
		{
			logger.log(Level.SEVERE, "Uh oh! An open ClosingFuture has leaked and will close: {0}", this);
			finishToFuture();
		}
	}

	[HideFromJava]
	~ClosingFuture()
	{
		if (!ByteCodeHelper.SkipFinalizer())
		{
			try
			{
				finalize();
			}
			catch
			{
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(2289)]
	internal virtual CountDownLatch whenClosedCountDown()
	{
		CountDownLatch result = closeables.whenClosedCountDown();
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(195)]
	internal static FluentFuture access_0024000(ClosingFuture P_0)
	{
		return P_0.future;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(195)]
	internal static void access_0024100(ClosingFuture P_0)
	{
		P_0.close();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(195)]
	internal static void access_00241000(ClosingFuture P_0, CloseableList P_1)
	{
		P_0.becomeSubsumedInto(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(195)]
	internal static void access_00241100(ClosingFuture P_0, State P_1, State P_2)
	{
		P_0.checkAndUpdateState(P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(195)]
	internal static void access_00241200(ValueAndCloserConsumer P_0, ClosingFuture P_1)
	{
		provideValueAndCloser(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Synthetic)]
	[LineNumberTable(195)]
	internal ClosingFuture(ListenableFuture P_0, _1 P_1)
		: this(P_0)
	{
		GC.KeepAlive(this);
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	internal static Logger access_00243200()
	{
		return logger;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(195)]
	internal static void access_00243300(IDisposable P_0, Executor P_1)
	{
		closeQuietly(P_0, P_1);
	}

	[LineNumberTable(197)]
	static ClosingFuture()
	{
		logger = Logger.getLogger(ClassLiteral<ClosingFuture>.Value.getName(), ClosingFuture.___003CGetCallerID_003E());
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
