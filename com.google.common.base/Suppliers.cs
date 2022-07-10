using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;
using java.util.concurrent;
using java.util.function;
using javax.annotation;

namespace com.google.common.@base;

[ConstantPool(new object[]
{
	(byte)48,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
public sealed class Suppliers : java.lang.Object
{
	[Serializable]
	[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/base/Supplier<TT;>;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 76, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)76,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.base.Supplier", "java.io.Serializable" })]
	internal class ExpiringMemoizingSupplier : java.lang.Object, Supplier, java.util.function.Supplier, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/base/Supplier<TT;>;")]
		internal Supplier @delegate;

		[Modifiers(Modifiers.Final)]
		internal long durationNanos;

		[NonSerialized]
		[Signature("TT;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal volatile object value;

		[NonSerialized]
		internal volatile long expirationNanos;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/base/Supplier<TT;>;JLjava/util/concurrent/TimeUnit;)V")]
		[LineNumberTable(new byte[] { 160, 128, 104, 113, 109, 115 })]
		internal ExpiringMemoizingSupplier(Supplier P_0, long P_1, TimeUnit P_2)
		{
			@delegate = (Supplier)Preconditions.checkNotNull(P_0);
			durationNanos = P_2.toNanos(P_1);
			Preconditions.checkArgument(P_1 > 0, "duration (%s %s) must be > 0", P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TT;")]
		[LineNumberTable(new byte[]
		{
			160, 143, 108, 102, 111, 104, 110, 108, 110, 169,
			121, 139, 184
		})]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/base/ParametricNullness;"
		})]
		public virtual object get()
		{
			long num = ByteCodeHelper.VolatileRead(ref expirationNanos);
			long num2 = Platform.systemNanoTime();
			if (num == 0 || num2 - num >= 0)
			{
				ExpiringMemoizingSupplier obj;
				Monitor.Enter(obj = this);
				try
				{
					if (num == ByteCodeHelper.VolatileRead(ref expirationNanos))
					{
						object result = (value = @delegate.get());
						System.Threading.Thread.MemoryBarrier();
						num = num2 + durationNanos;
						long newValue = ((num != 0) ? num : 1);
						ByteCodeHelper.VolatileWrite(ref expirationNanos, newValue);
						Monitor.Exit(obj);
						return result;
					}
					Monitor.Exit(obj);
				}
				catch
				{
					//try-fault
					Monitor.Exit(obj);
					throw;
				}
			}
			return NullnessCasts.uncheckedCastNullableTToT(value);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(280)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(@delegate);
			long lng = durationNanos;
			int num = 62 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append("Suppliers.memoizeWithExpiration(").append(text).append(", ")
				.append(lng)
				.append(", NANOS)")
				.toString();
			_ = null;
			return result;
		}

		[SecurityCritical]
		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected virtual void GetObjectData(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.writeObject(this, P_0);
		}

		void ISerializable.GetObjectData(SerializationInfo P_0, StreamingContext P_1)
		{
			//ILSpy generated this explicit interface implementation from .override directive in GetObjectData
			this.GetObjectData(P_0, P_1);
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected ExpiringMemoizingSupplier(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/base/Supplier<TT;>;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 65, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)65,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.base.Supplier", "java.io.Serializable" })]
	internal class MemoizingSupplier : java.lang.Object, Supplier, java.util.function.Supplier, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/base/Supplier<TT;>;")]
		internal Supplier @delegate;

		[NonSerialized]
		internal volatile bool initialized;

		[NonSerialized]
		[Signature("TT;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal object value;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/base/Supplier<TT;>;)V")]
		[LineNumberTable(new byte[] { 76, 104, 113 })]
		internal MemoizingSupplier(Supplier P_0)
		{
			@delegate = (Supplier)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TT;")]
		[LineNumberTable(new byte[] { 84, 109, 104, 106, 108, 103, 110, 138, 183 })]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/base/ParametricNullness;"
		})]
		public virtual object get()
		{
			if (!initialized)
			{
				MemoizingSupplier obj;
				Monitor.Enter(obj = this);
				try
				{
					if (!initialized)
					{
						object result = (value = @delegate.get());
						initialized = true;
						System.Threading.Thread.MemoryBarrier();
						Monitor.Exit(obj);
						return result;
					}
					Monitor.Exit(obj);
				}
				catch
				{
					//try-fault
					Monitor.Exit(obj);
					throw;
				}
			}
			return NullnessCasts.uncheckedCastNullableTToT(value);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 101, 63, 115 })]
		public override string toString()
		{
			object obj;
			string text;
			int num;
			if (initialized)
			{
				text = java.lang.String.valueOf(value);
				num = 25 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
				num = num;
				obj = new StringBuilder(num).append("<supplier that returned ").append(text).append(">")
					.toString();
			}
			else
			{
				obj = @delegate;
			}
			text = java.lang.String.valueOf(obj);
			num = 19 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append("Suppliers.memoize(").append(text).append(")")
				.toString();
			_ = null;
			return result;
		}

		[SecurityCritical]
		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected virtual void GetObjectData(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.writeObject(this, P_0);
		}

		void ISerializable.GetObjectData(SerializationInfo P_0, StreamingContext P_1)
		{
			//ILSpy generated this explicit interface implementation from .override directive in GetObjectData
			this.GetObjectData(P_0, P_1);
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected MemoizingSupplier(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/base/Supplier<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 60, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)60,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.base.Supplier" })]
	internal class NonSerializableMemoizingSupplier : java.lang.Object, Supplier, java.util.function.Supplier
	{
		[Signature("Lcom/google/common/base/Supplier<TT;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal volatile Supplier @delegate;

		internal volatile bool initialized;

		[Signature("TT;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal object value;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/base/Supplier<TT;>;)V")]
		[LineNumberTable(new byte[] { 116, 104, 120 })]
		internal NonSerializableMemoizingSupplier(Supplier P_0)
		{
			@delegate = (Supplier)Preconditions.checkNotNull(P_0);
			System.Threading.Thread.MemoryBarrier();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TT;")]
		[LineNumberTable(new byte[]
		{
			124, 109, 104, 234, 71, 120, 103, 137, 110, 138,
			183
		})]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/base/ParametricNullness;"
		})]
		public virtual object get()
		{
			if (!initialized)
			{
				NonSerializableMemoizingSupplier obj;
				Monitor.Enter(obj = this);
				try
				{
					if (!initialized)
					{
						object result = (value = ((Supplier)java.util.Objects.requireNonNull(@delegate)).get());
						initialized = true;
						@delegate = null;
						System.Threading.Thread.MemoryBarrier();
						Monitor.Exit(obj);
						return result;
					}
					Monitor.Exit(obj);
				}
				catch
				{
					//try-fault
					Monitor.Exit(obj);
					throw;
				}
			}
			return NullnessCasts.uncheckedCastNullableTToT(value);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 84, 137, 63, 103 })]
		public override string toString()
		{
			Supplier supplier = @delegate;
			object obj;
			string text;
			int num;
			if (supplier == null)
			{
				text = java.lang.String.valueOf(value);
				num = 25 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
				num = num;
				obj = new StringBuilder(num).append("<supplier that returned ").append(text).append(">")
					.toString();
			}
			else
			{
				obj = supplier;
			}
			text = java.lang.String.valueOf(obj);
			num = 19 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append("Suppliers.memoize(").append(text).append(")")
				.toString();
			_ = null;
			return result;
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<F:Ljava/lang/Object;T:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/base/Supplier<TT;>;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 70, 0, 0,
		17, 1, 0, 0, 0, 70, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)70,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.base.Supplier", "java.io.Serializable" })]
	internal class SupplierComposition : java.lang.Object, Supplier, java.util.function.Supplier, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/base/Function<-TF;TT;>;")]
		internal Function function;

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/base/Supplier<TF;>;")]
		internal Supplier supplier;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/base/Function<-TF;TT;>;Lcom/google/common/base/Supplier<TF;>;)V")]
		[LineNumberTable(new byte[] { 9, 104, 113, 113 })]
		internal SupplierComposition(Function P_0, Supplier P_1)
		{
			function = (Function)Preconditions.checkNotNull(P_0);
			supplier = (Supplier)Preconditions.checkNotNull(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TT;")]
		[LineNumberTable(67)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/base/ParametricNullness;"
		})]
		public virtual object get()
		{
			object result = function.apply(supplier.get());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 22, 104, 103, 159, 12 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is SupplierComposition)
			{
				SupplierComposition supplierComposition = (SupplierComposition)P_0;
				return (function.equals(supplierComposition.function) && java.lang.Object.instancehelper_equals(supplier, supplierComposition.supplier)) ? true : false;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(81)]
		public override int hashCode()
		{
			int result = Objects.hashCode(function, supplier);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(86)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(function);
			string text2 = java.lang.String.valueOf(supplier);
			int num = 21 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
			num = num;
			string result = new StringBuilder(num).append("Suppliers.compose(").append(text).append(", ")
				.append(text2)
				.append(")")
				.toString();
			_ = null;
			return result;
		}

		[SecurityCritical]
		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected virtual void GetObjectData(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.writeObject(this, P_0);
		}

		void ISerializable.GetObjectData(SerializationInfo P_0, StreamingContext P_1)
		{
			//ILSpy generated this explicit interface implementation from .override directive in GetObjectData
			this.GetObjectData(P_0, P_1);
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected SupplierComposition(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Interface | Modifiers.Abstract)]
	[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/base/Function<Lcom/google/common/base/Supplier<TT;>;TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 9, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)9,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.base.Function" })]
	internal interface SupplierFunction : Function, java.util.function.Function
	{
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/base/Suppliers$SupplierFunctionImpl;>;Lcom/google/common/base/Suppliers$SupplierFunction<Ljava/lang/Object;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 16, 0, 0, 1, 3, 0, 0, 47,
		0, 0
	})]
	[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	[ConstantPool(new object[]
	{
		(byte)47,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.base.Suppliers$SupplierFunction" })]
	internal sealed class SupplierFunctionImpl : java.lang.Enum, SupplierFunction, Function, java.util.function.Function
	{
		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static SupplierFunctionImpl INSTANCE;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static SupplierFunctionImpl[] _0024VALUES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/base/Supplier<Ljava/lang/Object;>;)Ljava/lang/Object;")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 1, 22, 0, 1, 3, 0, 0, 47, 0,
			0
		})]
		[LineNumberTable(384)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object apply(Supplier P_0)
		{
			object result = P_0.get();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(377)]
		private SupplierFunctionImpl(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(377)]
		private static SupplierFunctionImpl[] _0024values()
		{
			return new SupplierFunctionImpl[1] { INSTANCE };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(377)]
		public static SupplierFunctionImpl[] values()
		{
			return (SupplierFunctionImpl[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(377)]
		public static SupplierFunctionImpl valueOf(string P_0)
		{
			return (SupplierFunctionImpl)java.lang.Enum.valueOf(ClassLiteral<SupplierFunctionImpl>.Value, P_0);
		}

		public override string toString()
		{
			return "Suppliers.supplierFunction()";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 1, 22, 0, 1, 3, 0, 0, 47, 0,
			0
		})]
		[LineNumberTable(377)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object apply(object P_0)
		{
			object result = apply((Supplier)P_0);
			_ = null;
			return result;
		}

		[LineNumberTable(new byte[] { 161, 8, 48 })]
		static SupplierFunctionImpl()
		{
			INSTANCE = new SupplierFunctionImpl("INSTANCE", 0);
			_0024VALUES = _0024values();
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

		bool Function.Function_003A_003Aequals(object P_0)
		{
			return equals(P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/base/Supplier<TT;>;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 59, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)59,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.base.Supplier", "java.io.Serializable" })]
	internal class SupplierOfInstance : java.lang.Object, Supplier, java.util.function.Supplier, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Final)]
		[Signature("TT;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/base/ParametricNullness;"
		})]
		internal object instance;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TT;)V")]
		[LineNumberTable(new byte[] { 160, 182, 104, 103 })]
		internal SupplierOfInstance([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/base/ParametricNullness;"
		})] object P_0)
		{
			instance = P_0;
		}

		[Signature("()TT;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/base/ParametricNullness;"
		})]
		public virtual object get()
		{
			return instance;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 194, 104, 103, 148 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is SupplierOfInstance)
			{
				SupplierOfInstance supplierOfInstance = (SupplierOfInstance)P_0;
				bool result = Objects.equal(instance, supplierOfInstance.instance);
				_ = null;
				return result;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(317)]
		public override int hashCode()
		{
			int result = Objects.hashCode(instance);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(322)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(instance);
			int num = 22 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append("Suppliers.ofInstance(").append(text).append(")")
				.toString();
			_ = null;
			return result;
		}

		[SecurityCritical]
		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected virtual void GetObjectData(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.writeObject(this, P_0);
		}

		void ISerializable.GetObjectData(SerializationInfo P_0, StreamingContext P_1)
		{
			//ILSpy generated this explicit interface implementation from .override directive in GetObjectData
			this.GetObjectData(P_0, P_1);
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected SupplierOfInstance(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/base/Supplier<TT;>;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 51, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)51,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.base.Supplier", "java.io.Serializable" })]
	internal class ThreadSafeSupplier : java.lang.Object, Supplier, java.util.function.Supplier, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/base/Supplier<TT;>;")]
		internal Supplier @delegate;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/base/Supplier<TT;>;)V")]
		[LineNumberTable(new byte[] { 160, 227, 104, 113 })]
		internal ThreadSafeSupplier(Supplier P_0)
		{
			@delegate = (Supplier)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TT;")]
		[LineNumberTable(new byte[] { 160, 234, 109, 113 })]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/base/ParametricNullness;"
		})]
		public virtual object get()
		{
			//Discarded unreachable code: IL_001a
			lock (@delegate)
			{
				return @delegate.get();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(355)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(@delegate);
			int num = 32 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append("Suppliers.synchronizedSupplier(").append(text).append(")")
				.toString();
			_ = null;
			return result;
		}

		[SecurityCritical]
		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected virtual void GetObjectData(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.writeObject(this, P_0);
		}

		void ISerializable.GetObjectData(SerializationInfo P_0, StreamingContext P_1)
		{
			//ILSpy generated this explicit interface implementation from .override directive in GetObjectData
			this.GetObjectData(P_0, P_1);
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected ThreadSafeSupplier(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(41)]
	private Suppliers()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<F:Ljava/lang/Object;T:Ljava/lang/Object;>(Lcom/google/common/base/Function<-TF;TT;>;Lcom/google/common/base/Supplier<TF;>;)Lcom/google/common/base/Supplier<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 48, 0, 0,
		18, 1, 0, 0, 0, 48, 0, 0
	})]
	[LineNumberTable(51)]
	public static Supplier compose(Function function, Supplier supplier)
	{
		SupplierComposition result = new SupplierComposition(function, supplier);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Lcom/google/common/base/Supplier<TT;>;)Lcom/google/common/base/Supplier<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 48, 0, 0 })]
	[LineNumberTable(new byte[] { 59, 144, 130, 104, 104, 6 })]
	public static Supplier memoize(Supplier @delegate)
	{
		if (@delegate is NonSerializableMemoizingSupplier || @delegate is MemoizingSupplier)
		{
			return @delegate;
		}
		object obj = ((!Serializable.IsInstance(@delegate)) ? ((object)new NonSerializableMemoizingSupplier(@delegate)) : ((object)new MemoizingSupplier(@delegate)));
		Supplier result = ((obj == null) ? null : ((obj as Supplier) ?? throw new java.lang.IncompatibleClassChangeError()));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Lcom/google/common/base/Supplier<TT;>;JLjava/util/concurrent/TimeUnit;)Lcom/google/common/base/Supplier<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 48, 0, 0 })]
	[LineNumberTable(229)]
	public static Supplier memoizeWithExpiration(Supplier @delegate, long duration, TimeUnit unit)
	{
		ExpiringMemoizingSupplier result = new ExpiringMemoizingSupplier(@delegate, duration, unit);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;)Lcom/google/common/base/Supplier<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 48, 0, 0 })]
	[LineNumberTable(289)]
	public static Supplier ofInstance([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/base/ParametricNullness;"
	})] object instance)
	{
		SupplierOfInstance result = new SupplierOfInstance(instance);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Lcom/google/common/base/Supplier<TT;>;)Lcom/google/common/base/Supplier<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 48, 0, 0 })]
	[LineNumberTable(334)]
	public static Supplier synchronizedSupplier(Supplier @delegate)
	{
		ThreadSafeSupplier result = new ThreadSafeSupplier(@delegate);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>()Lcom/google/common/base/Function<Lcom/google/common/base/Supplier<TT;>;TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 48, 0, 0 })]
	[LineNumberTable(new byte[] { 161, 1, 102 })]
	public static Function supplierFunction()
	{
		return SupplierFunctionImpl.INSTANCE;
	}
}
