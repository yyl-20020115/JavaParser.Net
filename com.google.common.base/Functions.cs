using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.@base;

[ConstantPool(new object[]
{
	(byte)44,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
public sealed class Functions : java.lang.Object
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
	[Signature("<E:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/base/Function<Ljava/lang/Object;TE;>;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 16, 0, 0, 1, 3, 0, 0, 60,
		0, 0, 17, 0, 0, 0, 0, 60, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)60,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.base.Function", "java.io.Serializable" })]
	internal class ConstantFunction : java.lang.Object, Function, java.util.function.Function, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("TE;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/base/ParametricNullness;"
		})]
		private object value;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)V")]
		[LineNumberTable(new byte[] { 160, 233, 104, 103 })]
		public ConstantFunction([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/base/ParametricNullness;"
		})] object P_0)
		{
			value = P_0;
		}

		[Signature("(Ljava/lang/Object;)TE;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/base/ParametricNullness;"
		})]
		public virtual object apply([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 245, 104, 103, 148 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is ConstantFunction)
			{
				ConstantFunction constantFunction = (ConstantFunction)P_0;
				bool result = Objects.equal(value, constantFunction.value);
				_ = null;
				return result;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(368)]
		public override int hashCode()
		{
			int result = ((value != null) ? java.lang.Object.instancehelper_hashCode(value) : 0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(373)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(value);
			int num = 20 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append("Functions.constant(").append(text).append(")")
				.toString();
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
		protected ConstantFunction(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/base/Function<TK;TV;>;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 73, 0, 0,
		17, 1, 0, 0, 0, 73, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)73,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.base.Function", "java.io.Serializable" })]
	internal class ForMapWithDefault : java.lang.Object, Function, java.util.function.Function, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Map<TK;+TV;>;")]
		internal Map map;

		[Modifiers(Modifiers.Final)]
		[Signature("TV;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/base/ParametricNullness;"
		})]
		internal object defaultValue;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map<TK;+TV;>;TV;)V")]
		[LineNumberTable(new byte[] { 160, 72, 104, 113, 103 })]
		internal ForMapWithDefault(Map P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/base/ParametricNullness;"
		})] object P_1)
		{
			map = (Map)Preconditions.checkNotNull(P_0);
			defaultValue = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)TV;")]
		[LineNumberTable(new byte[] { 160, 80, 141, 113, 104, 6 })]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/base/ParametricNullness;"
		})]
		public virtual object apply([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/base/ParametricNullness;"
		})] object P_0)
		{
			object obj = map.get(P_0);
			return (obj == null && !map.containsKey(P_0)) ? defaultValue : NullnessCasts.uncheckedCastNullableTToT(obj);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 89, 104, 103, 159, 12 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is ForMapWithDefault)
			{
				ForMapWithDefault forMapWithDefault = (ForMapWithDefault)P_0;
				return (map.equals(forMapWithDefault.map) && Objects.equal(defaultValue, forMapWithDefault.defaultValue)) ? true : false;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(212)]
		public override int hashCode()
		{
			int result = Objects.hashCode(map, defaultValue);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(218)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(map);
			string text2 = java.lang.String.valueOf(defaultValue);
			int num = 33 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
			num = num;
			string result = new StringBuilder(num).append("Functions.forMap(").append(text).append(", defaultValue=")
				.append(text2)
				.append(")")
				.toString();
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
		protected ForMapWithDefault(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<A:Ljava/lang/Object;B:Ljava/lang/Object;C:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/base/Function<TA;TC;>;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 17, 0, 0, 0, 0, 67, 0, 0,
		17, 1, 0, 0, 0, 67, 0, 0, 17, 2,
		0, 0, 0, 67, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)67,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.base.Function", "java.io.Serializable" })]
	internal class FunctionComposition : java.lang.Object, Function, java.util.function.Function, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/base/Function<TB;TC;>;")]
		private Function g;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/base/Function<TA;+TB;>;")]
		private Function f;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/base/Function<TB;TC;>;Lcom/google/common/base/Function<TA;+TB;>;)V")]
		[LineNumberTable(new byte[] { 160, 133, 104, 113, 113 })]
		public FunctionComposition(Function P_0, Function P_1)
		{
			g = (Function)Preconditions.checkNotNull(P_0);
			f = (Function)Preconditions.checkNotNull(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TA;)TC;")]
		[LineNumberTable(255)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/base/ParametricNullness;"
		})]
		public virtual object apply([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/base/ParametricNullness;"
		})] object P_0)
		{
			object result = g.apply(f.apply(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 146, 104, 103, 159, 12 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is FunctionComposition)
			{
				FunctionComposition functionComposition = (FunctionComposition)P_0;
				return (f.equals(functionComposition.f) && g.equals(functionComposition.g)) ? true : false;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(269)]
		public override int hashCode()
		{
			return java.lang.Object.instancehelper_hashCode(f) ^ java.lang.Object.instancehelper_hashCode(g);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(275)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(g);
			string text2 = java.lang.String.valueOf(f);
			int num = 2 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
			num = num;
			string result = new StringBuilder(num).append(text).append("(").append(text2)
				.append(")")
				.toString();
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
		protected FunctionComposition(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/base/Function<TK;TV;>;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 71, 0, 0,
		17, 1, 0, 0, 0, 71, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)71,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.base.Function", "java.io.Serializable" })]
	internal class FunctionForMapNoDefault : java.lang.Object, Function, java.util.function.Function, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Map<TK;TV;>;")]
		internal Map map;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 96, 104, 113 })]
		internal FunctionForMapNoDefault(Map P_0)
		{
			map = (Map)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)TV;")]
		[LineNumberTable(new byte[] { 103, 109, 159, 1 })]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/base/ParametricNullness;"
		})]
		public virtual object apply([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/base/ParametricNullness;"
		})] object P_0)
		{
			object obj = map.get(P_0);
			Preconditions.checkArgument((obj != null || map.containsKey(P_0)) ? true : false, "Key '%s' not present in map", P_0);
			object result = NullnessCasts.uncheckedCastNullableTToT(obj);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 111, 104, 103, 148 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is FunctionForMapNoDefault)
			{
				FunctionForMapNoDefault functionForMapNoDefault = (FunctionForMapNoDefault)P_0;
				bool result = map.equals(functionForMapNoDefault.map);
				_ = null;
				return result;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(170)]
		public override int hashCode()
		{
			int result = map.hashCode();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(175)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(map);
			int num = 18 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append("Functions.forMap(").append(text).append(")")
				.toString();
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
		protected FunctionForMapNoDefault(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/base/Functions$IdentityFunction;>;Lcom/google/common/base/Function<Ljava/lang/Object;Ljava/lang/Object;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 16, 0, 0, 1, 3, 0, 0, 49,
		0, 0, 16, 0, 0, 1, 3, 1, 0, 49,
		0, 0
	})]
	[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	[ConstantPool(new object[]
	{
		(byte)49,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.base.Function" })]
	internal sealed class IdentityFunction : java.lang.Enum, Function, java.util.function.Function
	{
		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static IdentityFunction INSTANCE;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static IdentityFunction[] _0024VALUES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(90)]
		private IdentityFunction(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(90)]
		private static IdentityFunction[] _0024values()
		{
			return new IdentityFunction[1] { INSTANCE };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(90)]
		public static IdentityFunction[] values()
		{
			return (IdentityFunction[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(90)]
		public static IdentityFunction valueOf(string P_0)
		{
			return (IdentityFunction)java.lang.Enum.valueOf(ClassLiteral<IdentityFunction>.Value, P_0);
		}

		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object apply([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return P_0;
		}

		public override string toString()
		{
			return "Functions.identity()";
		}

		[LineNumberTable(new byte[] { 41, 48 })]
		static IdentityFunction()
		{
			INSTANCE = new IdentityFunction("INSTANCE", 0);
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
	[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/base/Function<TT;Ljava/lang/Boolean;>;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 73, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)73,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.base.Function", "java.io.Serializable" })]
	internal class PredicateFunction : java.lang.Object, Function, java.util.function.Function, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/base/Predicate<TT;>;")]
		private Predicate predicate;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(295)]
		internal PredicateFunction(Predicate P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/base/Predicate<TT;>;)V")]
		[LineNumberTable(new byte[] { 160, 185, 104, 113 })]
		private PredicateFunction(Predicate P_0)
		{
			predicate = (Predicate)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TT;)Ljava/lang/Boolean;")]
		[LineNumberTable(305)]
		public virtual java.lang.Boolean apply([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/base/ParametricNullness;"
		})] object P_0)
		{
			java.lang.Boolean result = java.lang.Boolean.valueOf(predicate.apply(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 196, 104, 103, 148 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is PredicateFunction)
			{
				PredicateFunction predicateFunction = (PredicateFunction)P_0;
				bool result = predicate.equals(predicateFunction.predicate);
				_ = null;
				return result;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(319)]
		public override int hashCode()
		{
			int result = java.lang.Object.instancehelper_hashCode(predicate);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(324)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(predicate);
			int num = 24 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append("Functions.forPredicate(").append(text).append(")")
				.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(295)]
		public virtual object apply([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/base/ParametricNullness;"
		})] object P_0)
		{
			java.lang.Boolean result = this.apply(P_0);
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
		protected PredicateFunction(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<F:Ljava/lang/Object;T:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/base/Function<TF;TT;>;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 71, 0, 0,
		17, 1, 0, 0, 0, 71, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)71,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.base.Function", "java.io.Serializable" })]
	internal class SupplierFunction : java.lang.Object, Function, java.util.function.Function, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/base/Supplier<TT;>;")]
		private Supplier supplier;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(392)]
		internal SupplierFunction(Supplier P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/base/Supplier<TT;>;)V")]
		[LineNumberTable(new byte[] { 161, 27, 104, 113 })]
		private SupplierFunction(Supplier P_0)
		{
			supplier = (Supplier)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TF;)TT;")]
		[LineNumberTable(404)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/base/ParametricNullness;"
		})]
		public virtual object apply([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/base/ParametricNullness;"
		})] object P_0)
		{
			object result = supplier.get();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 39, 104, 103, 148 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is SupplierFunction)
			{
				SupplierFunction supplierFunction = (SupplierFunction)P_0;
				bool result = java.lang.Object.instancehelper_equals(supplier, supplierFunction.supplier);
				_ = null;
				return result;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(418)]
		public override int hashCode()
		{
			int result = java.lang.Object.instancehelper_hashCode(supplier);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(423)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(supplier);
			int num = 23 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append("Functions.forSupplier(").append(text).append(")")
				.toString();
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
		protected SupplierFunction(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/base/Functions$ToStringFunction;>;Lcom/google/common/base/Function<Ljava/lang/Object;Ljava/lang/String;>;")]
	[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	[Implements(new string[] { "com.google.common.base.Function" })]
	internal sealed class ToStringFunction : java.lang.Enum, Function, java.util.function.Function
	{
		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static ToStringFunction INSTANCE;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static ToStringFunction[] _0024VALUES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 22, 103 })]
		public virtual string apply(object P_0)
		{
			Preconditions.checkNotNull(P_0);
			string result = java.lang.Object.instancehelper_toString(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(67)]
		private ToStringFunction(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(67)]
		private static ToStringFunction[] _0024values()
		{
			return new ToStringFunction[1] { INSTANCE };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(67)]
		public static ToStringFunction[] values()
		{
			return (ToStringFunction[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(67)]
		public static ToStringFunction valueOf(string P_0)
		{
			return (ToStringFunction)java.lang.Enum.valueOf(ClassLiteral<ToStringFunction>.Value, P_0);
		}

		public override string toString()
		{
			return "Functions.toStringFunction()";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(67)]
		public virtual object apply(object P_0)
		{
			string result = this.apply(P_0);
			_ = null;
			return result;
		}

		[LineNumberTable(new byte[] { 18, 48 })]
		static ToStringFunction()
		{
			INSTANCE = new ToStringFunction("INSTANCE", 0);
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(43)]
	private Functions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/base/Function<Ljava/lang/Object;Ljava/lang/String;>;")]
	[LineNumberTable(63)]
	public static Function toStringFunction()
	{
		return ToStringFunction.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>()Lcom/google/common/base/Function<TE;TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 44, 0, 0 })]
	[LineNumberTable(86)]
	public static Function identity()
	{
		return IdentityFunction.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map<TK;TV;>;)Lcom/google/common/base/Function<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 44, 0, 0,
		18, 1, 0, 0, 0, 44, 0, 0
	})]
	[LineNumberTable(120)]
	public static Function forMap(Map map)
	{
		FunctionForMapNoDefault result = new FunctionForMapNoDefault(map);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map<TK;+TV;>;TV;)Lcom/google/common/base/Function<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 44, 0, 0,
		18, 1, 0, 0, 0, 44, 0, 0
	})]
	[LineNumberTable(138)]
	public static Function forMap(Map map, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/base/ParametricNullness;"
	})] object defaultValue)
	{
		ForMapWithDefault result = new ForMapWithDefault(map, defaultValue);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<A:Ljava/lang/Object;B:Ljava/lang/Object;C:Ljava/lang/Object;>(Lcom/google/common/base/Function<TB;TC;>;Lcom/google/common/base/Function<TA;+TB;>;)Lcom/google/common/base/Function<TA;TC;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 18, 0, 0, 0, 0, 44, 0, 0,
		18, 1, 0, 0, 0, 44, 0, 0, 18, 2,
		0, 0, 0, 44, 0, 0
	})]
	[LineNumberTable(238)]
	public static Function compose(Function g, Function f)
	{
		FunctionComposition result = new FunctionComposition(g, f);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Lcom/google/common/base/Predicate<TT;>;)Lcom/google/common/base/Function<TT;Ljava/lang/Boolean;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 44, 0, 0 })]
	[LineNumberTable(291)]
	public static Function forPredicate(Predicate predicate)
	{
		PredicateFunction result = new PredicateFunction(predicate, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(TE;)Lcom/google/common/base/Function<Ljava/lang/Object;TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 20, 1, 3, 0, 0, 44, 0, 0,
		18, 0, 0, 0, 0, 44, 0, 0
	})]
	[LineNumberTable(340)]
	public static Function constant([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/base/ParametricNullness;"
	})] object value)
	{
		ConstantFunction result = new ConstantFunction(value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<F:Ljava/lang/Object;T:Ljava/lang/Object;>(Lcom/google/common/base/Supplier<TT;>;)Lcom/google/common/base/Function<TF;TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 44, 0, 0,
		18, 1, 0, 0, 0, 44, 0, 0
	})]
	[LineNumberTable(388)]
	public static Function forSupplier(Supplier supplier)
	{
		SupplierFunction result = new SupplierFunction(supplier, null);
		_ = null;
		return result;
	}
}
