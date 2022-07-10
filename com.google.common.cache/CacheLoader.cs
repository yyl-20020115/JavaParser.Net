using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.common.util.concurrent;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.util;
using java.util.concurrent;

namespace com.google.common.cache;

[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/cache/ElementTypesAreNonnullByDefault;"
})]
public abstract class CacheLoader : java.lang.Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/cache/CacheLoader<TK;TV;>;")]
	[EnclosingMethod(null, "asyncReloading", "(Lcom.google.common.cache.CacheLoader;Ljava.util.concurrent.Executor;)Lcom.google.common.cache.CacheLoader;")]
	internal class _1 : CacheLoader
	{
		[SpecialName]
		[Signature("Ljava/lang/Object;Ljava/util/concurrent/Callable<TV;>;")]
		[EnclosingMethod(null, "reload", "(Ljava.lang.Object;Ljava.lang.Object;)Lcom.google.common.util.concurrent.ListenableFuture;")]
		internal new class _1 : java.lang.Object, Callable
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal object val_0024key;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal object val_0024oldValue;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal CacheLoader._1 this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(200)]
			internal _1(CacheLoader._1 P_0, object P_1, object P_2)
			{
				this_00240 = P_0;
				val_0024key = P_1;
				val_0024oldValue = P_2;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Throws(new string[] { "java.lang.Exception" })]
			[Signature("()TV;")]
			[LineNumberTable(203)]
			public virtual object call()
			{
				object result = this_00240.val_0024loader.reload(val_0024key, val_0024oldValue).get();
				_ = null;
				return result;
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal CacheLoader val_0024loader;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Executor val_0024executor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(190)]
		internal _1(CacheLoader P_0, Executor P_1)
		{
			val_0024loader = P_0;
			val_0024executor = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Signature("(TK;)TV;")]
		[LineNumberTable(193)]
		public override object load(object P_0)
		{
			object result = val_0024loader.load(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Signature("(TK;TV;)Lcom/google/common/util/concurrent/ListenableFuture<TV;>;")]
		[LineNumberTable(new byte[] { 160, 84, 104, 230, 71, 108 })]
		public override ListenableFuture reload(object P_0, object P_1)
		{
			ListenableFutureTask listenableFutureTask = ListenableFutureTask.create(new _1(this, P_0, P_1));
			val_0024executor.execute(listenableFutureTask);
			return listenableFutureTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Signature("(Ljava/lang/Iterable<+TK;>;)Ljava/util/Map<TK;TV;>;")]
		[LineNumberTable(212)]
		public override Map loadAll(Iterable P_0)
		{
			Map result = val_0024loader.loadAll(P_0);
			_ = null;
			return result;
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/cache/CacheLoader<TK;TV;>;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.io.Serializable" })]
	internal sealed class FunctionToCacheLoader : CacheLoader, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/base/Function<TK;TV;>;")]
		private Function computingFunction;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/base/Function<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 113, 104, 113 })]
		public FunctionToCacheLoader(Function P_0)
		{
			computingFunction = (Function)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)TV;")]
		[LineNumberTable(169)]
		public override object load(object P_0)
		{
			object result = computingFunction.apply(Preconditions.checkNotNull(P_0));
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
		protected FunctionToCacheLoader(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	public sealed class InvalidCacheLoadException : RuntimeException
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 139, 105 })]
		public InvalidCacheLoadException(string message)
			: base(message)
		{
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected InvalidCacheLoadException(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<V:Ljava/lang/Object;>Lcom/google/common/cache/CacheLoader<Ljava/lang/Object;TV;>;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.io.Serializable" })]
	internal sealed class SupplierToCacheLoader : CacheLoader, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/base/Supplier<TV;>;")]
		private Supplier computingSupplier;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/base/Supplier<TV;>;)V")]
		[LineNumberTable(new byte[] { 160, 107, 104, 113 })]
		public SupplierToCacheLoader(Supplier P_0)
		{
			computingSupplier = (Supplier)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)TV;")]
		[LineNumberTable(new byte[] { 160, 113, 103 })]
		public override object load(object P_0)
		{
			Preconditions.checkNotNull(P_0);
			object result = computingSupplier.get();
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
		protected SupplierToCacheLoader(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	public sealed class UnsupportedLoadingOperationException : UnsupportedOperationException
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(243)]
		internal UnsupportedLoadingOperationException()
		{
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected UnsupportedLoadingOperationException(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Exception" })]
	[Signature("(TK;TV;)Lcom/google/common/util/concurrent/ListenableFuture<TV;>;")]
	[LineNumberTable(new byte[] { 50, 103, 103 })]
	public virtual ListenableFuture reload(object key, object oldValue)
	{
		Preconditions.checkNotNull(key);
		Preconditions.checkNotNull(oldValue);
		ListenableFuture result = Futures.immediateFuture(load(key));
		_ = null;
		return result;
	}

	[Throws(new string[] { "java.lang.Exception" })]
	[Signature("(TK;)TV;")]
	public abstract object load(object obj);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(63)]
	protected internal CacheLoader()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Exception" })]
	[Signature("(Ljava/lang/Iterable<+TK;>;)Ljava/util/Map<TK;TV;>;")]
	[LineNumberTable(130)]
	public virtual Map loadAll(Iterable keys)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedLoadingOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/base/Function<TK;TV;>;)Lcom/google/common/cache/CacheLoader<TK;TV;>;")]
	[LineNumberTable(142)]
	[CheckReturnValue(new object[]
	{
		(byte)64,
		"Lcom/google/errorprone/annotations/CheckReturnValue;"
	})]
	public static CacheLoader from(Function function)
	{
		FunctionToCacheLoader result = new FunctionToCacheLoader(function);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>(Lcom/google/common/base/Supplier<TV;>;)Lcom/google/common/cache/CacheLoader<Ljava/lang/Object;TV;>;")]
	[LineNumberTable(156)]
	[CheckReturnValue(new object[]
	{
		(byte)64,
		"Lcom/google/errorprone/annotations/CheckReturnValue;"
	})]
	public static CacheLoader from(Supplier supplier)
	{
		SupplierToCacheLoader result = new SupplierToCacheLoader(supplier);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/cache/CacheLoader<TK;TV;>;Ljava/util/concurrent/Executor;)Lcom/google/common/cache/CacheLoader<TK;TV;>;")]
	[LineNumberTable(new byte[] { 160, 74, 103, 103 })]
	[CheckReturnValue(new object[]
	{
		(byte)64,
		"Lcom/google/errorprone/annotations/CheckReturnValue;"
	})]
	public static CacheLoader asyncReloading(CacheLoader loader, Executor executor)
	{
		Preconditions.checkNotNull(loader);
		Preconditions.checkNotNull(executor);
		_1 result = new _1(loader, executor);
		_ = null;
		return result;
	}
}
