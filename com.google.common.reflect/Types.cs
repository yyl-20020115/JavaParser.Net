using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.common.collect;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.lang.reflect;
using java.security;
using java.util;
using java.util.concurrent.atomic;
using java.util.function;
using javax.annotation;

namespace com.google.common.reflect;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/reflect/ElementTypesAreNonnullByDefault;"
})]
internal sealed class Types : java.lang.Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[EnclosingMethod(null, "getComponentType", "(Ljava.lang.reflect.Type;)Ljava.lang.reflect.Type;")]
	internal class _1 : TypeVisitor
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AtomicReference val_0024result;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(175)]
		internal _1(AtomicReference P_0)
		{
			val_0024result = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/reflect/TypeVariable<*>;)V")]
		[LineNumberTable(new byte[] { 160, 64, 120 })]
		internal override void visitTypeVariable(TypeVariable P_0)
		{
			val_0024result.set(access_0024100(P_0.getBounds()));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 69, 120 })]
		internal override void visitWildcardType(WildcardType P_0)
		{
			val_0024result.set(access_0024100(P_0.getUpperBounds()));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 74, 115 })]
		internal override void visitGenericArrayType(GenericArrayType P_0)
		{
			val_0024result.set(P_0.getGenericComponentType());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Class<*>;)V")]
		[LineNumberTable(new byte[] { 160, 79, 115 })]
		internal override void visitClass(Class P_0)
		{
			val_0024result.set(P_0.getComponentType());
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Abstract | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/reflect/Types$ClassOwnership;>;")]
	[Modifiers(Modifiers.Super | Modifiers.Abstract | Modifiers.Enum)]
	internal abstract class ClassOwnership : java.lang.Enum
	{
		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		internal sealed class _1 : ClassOwnership
		{
			private sealed class ___003CCallerID_003E : CallerID
			{
				internal ___003CCallerID_003E()
				{
				}
			}

			[SpecialName]
			private static CallerID ___003CcallerID_003E;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(101)]
			internal _1(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/lang/Class<*>;)Ljava/lang/Class<*>;")]
			[LineNumberTable(105)]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			internal override Class getOwnerType(Class P_0)
			{
				Class enclosingClass = P_0.getEnclosingClass(_1.___003CGetCallerID_003E());
				_ = null;
				return enclosingClass;
			}

			static CallerID ___003CGetCallerID_003E()
			{
				if (___003CcallerID_003E == null)
				{
					___003CcallerID_003E = new ___003CCallerID_003E();
				}
				return ___003CcallerID_003E;
			}

			[HideFromJava]
			static _1()
			{
				ClassOwnership.___003Cclinit_003E();
			}
		}

		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;")]
		[EnclosingMethod(null, "detectJvmBehavior", "()Lcom.google.common.reflect.Types$ClassOwnership;")]
		internal class _1LocalClass : java.lang.Object
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(126)]
			internal _1LocalClass()
			{
			}
		}

		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		internal sealed class _2 : ClassOwnership
		{
			private sealed class ___003CCallerID_003E : CallerID
			{
				internal ___003CCallerID_003E()
				{
				}
			}

			[SpecialName]
			private static CallerID ___003CcallerID_003E;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(108)]
			internal _2(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/lang/Class<*>;)Ljava/lang/Class<*>;")]
			[LineNumberTable(new byte[] { 62, 104, 130 })]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			internal override Class getOwnerType(Class P_0)
			{
				if (P_0.isLocalClass())
				{
					return null;
				}
				Class enclosingClass = P_0.getEnclosingClass(_2.___003CGetCallerID_003E());
				_ = null;
				return enclosingClass;
			}

			static CallerID ___003CGetCallerID_003E()
			{
				if (___003CcallerID_003E == null)
				{
					___003CcallerID_003E = new ___003CCallerID_003E();
				}
				return ___003CcallerID_003E;
			}

			[HideFromJava]
			static _2()
			{
				ClassOwnership.___003Cclinit_003E();
			}
		}

		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/reflect/Types$ClassOwnership$1LocalClass<Ljava/lang/String;>;")]
		[EnclosingMethod(null, "detectJvmBehavior", "()Lcom.google.common.reflect.Types$ClassOwnership;")]
		internal class _3 : _1LocalClass
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(127)]
			internal _3()
			{
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static ClassOwnership OWNED_BY_ENCLOSING_CLASS;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static ClassOwnership LOCAL_CLASS_HAS_NO_OWNER;

		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static ClassOwnership JVM_BEHAVIOR;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static ClassOwnership[] _0024VALUES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[Signature("(Ljava/lang/Class<*>;)Ljava/lang/Class<*>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal abstract Class getOwnerType(Class P_0);

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(100)]
		private ClassOwnership(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(100)]
		public static ClassOwnership[] values()
		{
			return (ClassOwnership[])_0024VALUES.Clone();
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(100)]
		private static ClassOwnership[] _0024values()
		{
			return new ClassOwnership[2] { OWNED_BY_ENCLOSING_CLASS, LOCAL_CLASS_HAS_NO_OWNER };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 77, 139, 97, 117, 119, 116, 3, 232, 69 })]
		private static ClassOwnership detectJvmBehavior()
		{
			Class @class = java.lang.Object.instancehelper_getClass(new _3());
			ParameterizedType parameterizedType = (ParameterizedType)java.util.Objects.requireNonNull((ParameterizedType)@class.getGenericSuperclass());
			ClassOwnership[] array = values();
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				ClassOwnership classOwnership = array[i];
				if (classOwnership.getOwnerType(ClassLiteral<_1LocalClass>.Value) == parameterizedType.getOwnerType())
				{
					return classOwnership;
				}
			}
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(100)]
		public static ClassOwnership valueOf(string P_0)
		{
			return (ClassOwnership)java.lang.Enum.valueOf(ClassLiteral<ClassOwnership>.Value, P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(100)]
		internal ClassOwnership(string P_0, int P_1, Types._1 P_2)
			: this(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[LineNumberTable(new byte[] { 51, 240, 71, 240, 56, 234, 87 })]
		static ClassOwnership()
		{
			OWNED_BY_ENCLOSING_CLASS = new _1("OWNED_BY_ENCLOSING_CLASS", 0);
			LOCAL_CLASS_HAS_NO_OWNER = new _2("LOCAL_CLASS_HAS_NO_OWNER", 1);
			_0024VALUES = _0024values();
			JVM_BEHAVIOR = detectJvmBehavior();
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Implements(new string[] { "java.lang.reflect.GenericArrayType", "java.io.Serializable" })]
	internal sealed class GenericArrayTypeImpl : java.lang.Object, GenericArrayType, java.lang.reflect.Type, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private java.lang.reflect.Type componentType;

		private const long serialVersionUID = 0L;

		public virtual java.lang.reflect.Type getGenericComponentType()
		{
			return componentType;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 112, 104, 113 })]
		internal GenericArrayTypeImpl(java.lang.reflect.Type P_0)
		{
			componentType = JavaVersion.CURRENT.usedInGenericType(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(237)]
		public override string toString()
		{
			string result = java.lang.String.instancehelper_concat(java.lang.String.valueOf(Types.toString(componentType)), "[]");
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(242)]
		public override int hashCode()
		{
			int result = java.lang.Object.instancehelper_hashCode(componentType);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 133, 104, 103, 148 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is GenericArrayType)
			{
				GenericArrayType genericArrayType = (GenericArrayType)P_0;
				bool result = com.google.common.@base.Objects.equal(getGenericComponentType(), genericArrayType.getGenericComponentType());
				_ = null;
				return result;
			}
			return false;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual string getTypeName()
		{
			return java.lang.reflect.Type._003Cdefault_003EgetTypeName(this);
		}

		[SecurityCritical]
		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		void ISerializable.GetObjectData(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.writeObject(this, P_0);
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected GenericArrayTypeImpl(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Static | Modifiers.Abstract | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/reflect/Types$JavaVersion;>;")]
	[Modifiers(Modifiers.Super | Modifiers.Abstract | Modifiers.Enum)]
	internal abstract class JavaVersion : java.lang.Enum
	{
		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		internal sealed class _1 : JavaVersion
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(547)]
			internal _1(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(550)]
			internal new virtual GenericArrayType newArrayType(java.lang.reflect.Type P_0)
			{
				GenericArrayTypeImpl result = new GenericArrayTypeImpl(P_0);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 161, 185, 103, 104, 103, 104, 174 })]
			internal override java.lang.reflect.Type usedInGenericType(java.lang.reflect.Type P_0)
			{
				Preconditions.checkNotNull(P_0);
				if (P_0 is Class)
				{
					Class @class = (Class)P_0;
					if (@class.isArray())
					{
						GenericArrayTypeImpl result = new GenericArrayTypeImpl(@class.getComponentType());
						_ = null;
						return result;
					}
				}
				return P_0;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(547)]
			internal override java.lang.reflect.Type newArrayType(java.lang.reflect.Type P_0)
			{
				GenericArrayType result = newArrayType(P_0);
				_ = null;
				return result;
			}

			[HideFromJava]
			static _1()
			{
				JavaVersion.___003Cclinit_003E();
			}
		}

		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		internal sealed class _2 : JavaVersion
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(565)]
			internal _2(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 161, 198, 104, 142 })]
			internal override java.lang.reflect.Type newArrayType(java.lang.reflect.Type P_0)
			{
				if (P_0 is Class)
				{
					Class arrayClass = getArrayClass((Class)P_0);
					_ = null;
					return arrayClass;
				}
				GenericArrayTypeImpl result = new GenericArrayTypeImpl(P_0);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(577)]
			internal override java.lang.reflect.Type usedInGenericType(java.lang.reflect.Type P_0)
			{
				return (java.lang.reflect.Type)Preconditions.checkNotNull(P_0);
			}

			[HideFromJava]
			static _2()
			{
				JavaVersion.___003Cclinit_003E();
			}
		}

		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		internal sealed class _3 : JavaVersion
		{
			private sealed class ___003CCallerID_003E : CallerID
			{
				internal ___003CCallerID_003E()
				{
				}
			}

			[SpecialName]
			private static CallerID ___003CcallerID_003E;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(580)]
			internal _3(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(583)]
			internal override java.lang.reflect.Type newArrayType(java.lang.reflect.Type P_0)
			{
				java.lang.reflect.Type result = JAVA7.newArrayType(P_0);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(588)]
			internal override java.lang.reflect.Type usedInGenericType(java.lang.reflect.Type P_0)
			{
				java.lang.reflect.Type result = JAVA7.usedInGenericType(P_0);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[]
			{
				161, 224, 123, 127, 31, 97, 240, 70, 98, 109,
				98
			})]
			internal override string typeName(java.lang.reflect.Type P_0)
			{
				//Discarded unreachable code: IL_0034
				InvocationTargetException ex2;
				IllegalAccessException ex3;
				try
				{
					try
					{
						try
						{
							Method method = ClassLiteral<java.lang.reflect.Type>.Value.getMethod("getTypeName", new Class[0], _3.___003CGetCallerID_003E());
							return (string)method.invoke(P_0, new object[0], _3.___003CGetCallerID_003E());
						}
						catch (NoSuchMethodException)
						{
						}
					}
					catch (InvocationTargetException x)
					{
						ex2 = ByteCodeHelper.MapException<InvocationTargetException>(x, ByteCodeHelper.MapFlags.NoRemapping);
						goto IL_0052;
					}
				}
				catch (IllegalAccessException x2)
				{
					ex3 = ByteCodeHelper.MapException<IllegalAccessException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
					goto IL_0055;
				}
				_ = null;
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new AssertionError("Type.getTypeName should be available in Java 8");
				IL_0055:
				IllegalAccessException cause = ex3;
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new RuntimeException(cause);
				IL_0052:
				InvocationTargetException cause2 = ex2;
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new RuntimeException(cause2);
			}

			static CallerID ___003CGetCallerID_003E()
			{
				if (___003CcallerID_003E == null)
				{
					___003CcallerID_003E = new ___003CCallerID_003E();
				}
				return ___003CcallerID_003E;
			}

			[HideFromJava]
			static _3()
			{
				JavaVersion.___003Cclinit_003E();
			}
		}

		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		internal sealed class _4 : JavaVersion
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(610)]
			internal _4(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(613)]
			internal override java.lang.reflect.Type newArrayType(java.lang.reflect.Type P_0)
			{
				java.lang.reflect.Type result = JAVA8.newArrayType(P_0);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(618)]
			internal override java.lang.reflect.Type usedInGenericType(java.lang.reflect.Type P_0)
			{
				java.lang.reflect.Type result = JAVA8.usedInGenericType(P_0);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(623)]
			internal override string typeName(java.lang.reflect.Type P_0)
			{
				string result = JAVA8.typeName(P_0);
				_ = null;
				return result;
			}

			internal override bool jdkTypeDuplicatesOwnerName()
			{
				return false;
			}

			[HideFromJava]
			static _4()
			{
				JavaVersion.___003Cclinit_003E();
			}
		}

		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/reflect/TypeCapture<Ljava/util/Map$Entry<Ljava/lang/String;[[I>;>;")]
		[EnclosingMethod(null, null, null)]
		internal class _5 : TypeCapture
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(636)]
			internal _5()
			{
			}
		}

		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/reflect/TypeCapture<[I>;")]
		[EnclosingMethod(null, null, null)]
		internal class _6 : TypeCapture
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(643)]
			internal _6()
			{
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static JavaVersion JAVA6;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static JavaVersion JAVA7;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static JavaVersion JAVA8;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static JavaVersion JAVA9;

		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static JavaVersion CURRENT;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static JavaVersion[] _0024VALUES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		internal abstract java.lang.reflect.Type newArrayType(java.lang.reflect.Type P_0);

		internal abstract java.lang.reflect.Type usedInGenericType(java.lang.reflect.Type P_0);

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(546)]
		private JavaVersion(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(546)]
		private static JavaVersion[] _0024values()
		{
			return new JavaVersion[4] { JAVA6, JAVA7, JAVA8, JAVA9 };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(546)]
		public static JavaVersion[] values()
		{
			return (JavaVersion[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(546)]
		public static JavaVersion valueOf(string P_0)
		{
			return (JavaVersion)java.lang.Enum.valueOf(ClassLiteral<JavaVersion>.Value, P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("([Ljava/lang/reflect/Type;)Lcom/google/common/collect/ImmutableList<Ljava/lang/reflect/Type;>;")]
		[LineNumberTable(new byte[] { 162, 29, 102, 112, 47, 166 })]
		internal ImmutableList usedInGenericType(java.lang.reflect.Type[] P_0)
		{
			ImmutableList.Builder builder = ImmutableList.builder();
			int num = P_0.Length;
			for (int i = 0; i < num; i++)
			{
				java.lang.reflect.Type type = P_0[i];
				builder.add(usedInGenericType(type));
			}
			ImmutableList result = builder.build();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(663)]
		internal virtual string typeName(java.lang.reflect.Type P_0)
		{
			string result = Types.toString(P_0);
			_ = null;
			return result;
		}

		internal virtual bool jdkTypeDuplicatesOwnerName()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(546)]
		internal JavaVersion(string P_0, int P_1, Types._1 P_2)
			: this(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[LineNumberTable(new byte[]
		{
			161, 177, 240, 82, 240, 79, 240, 94, 240, 0,
			234, 160, 89, 113, 106, 106, 119, 140, 140, 113,
			140, 138
		})]
		static JavaVersion()
		{
			JAVA6 = new _1("JAVA6", 0);
			JAVA7 = new _2("JAVA7", 1);
			JAVA8 = new _3("JAVA8", 2);
			JAVA9 = new _4("JAVA9", 3);
			_0024VALUES = _0024values();
			if (ClassLiteral<AnnotatedElement>.Value.isAssignableFrom(ClassLiteral<TypeVariable>.Value))
			{
				string @this = java.lang.Object.instancehelper_toString(new _5().capture());
				CharSequence s = default(CharSequence);
				object obj = (s.___003Cref_003E = "java.util.Map.java.util.Map");
				if (java.lang.String.instancehelper_contains(@this, s))
				{
					CURRENT = JAVA8;
				}
				else
				{
					CURRENT = JAVA9;
				}
			}
			else if (new _6().capture() is Class)
			{
				CURRENT = JAVA7;
			}
			else
			{
				CURRENT = JAVA6;
			}
		}
	}

	[Signature("<X:Ljava/lang/Object;>Ljava/lang/Object;")]
	internal sealed class NativeTypeVariableEquals : java.lang.Object
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static bool NATIVE_TYPE_VARIABLE_ONLY;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(681)]
		internal NativeTypeVariableEquals()
		{
		}

		[LineNumberTable(new byte[] { 162, 56, 101, 119, 37, 48 })]
		static NativeTypeVariableEquals()
		{
			NATIVE_TYPE_VARIABLE_ONLY = ((!java.lang.Object.instancehelper_equals(ClassLiteral<NativeTypeVariableEquals>.Value.getTypeParameters()[0], newArtificialTypeVariable(ClassLiteral<NativeTypeVariableEquals>.Value, "X"))) ? true : false);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Implements(new string[] { "java.lang.reflect.ParameterizedType", "java.io.Serializable" })]
	internal sealed class ParameterizedTypeImpl : java.lang.Object, ParameterizedType, java.lang.reflect.Type, Serializable.__Interface, ISerializable
	{
		[SpecialName]
		private sealed class ___003C_003EAnon0 : com.google.common.@base.Function
		{
			private readonly JavaVersion arg_00241;

			internal ___003C_003EAnon0(JavaVersion P_0)
			{
				arg_00241 = P_0;
			}

			public object apply(object P_0)
			{
				string result = arg_00241.typeName((java.lang.reflect.Type)P_0);
				_ = null;
				return result;
			}

			[SpecialName]
			public bool equals(object P_0)
			{
				return java.lang.Object.instancehelper_equals(this, P_0);
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

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private java.lang.reflect.Type ownerType;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/ImmutableList<Ljava/lang/reflect/Type;>;")]
		private ImmutableList argumentsList;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/lang/Class<*>;")]
		private Class rawType;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/reflect/Type;Ljava/lang/Class<*>;[Ljava/lang/reflect/Type;)V")]
		[LineNumberTable(new byte[] { 160, 149, 104, 103, 112, 107, 103, 103, 113 })]
		internal ParameterizedTypeImpl([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] java.lang.reflect.Type P_0, Class P_1, java.lang.reflect.Type[] P_2)
		{
			Preconditions.checkNotNull(P_1);
			Preconditions.checkArgument((nint)P_2.LongLength == (nint)P_1.getTypeParameters().LongLength);
			access_0024200(P_2, "type parameter");
			ownerType = P_0;
			rawType = P_1;
			argumentsList = JavaVersion.CURRENT.usedInGenericType(P_2);
		}

		public virtual java.lang.reflect.Type getRawType()
		{
			return rawType;
		}

		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual java.lang.reflect.Type getOwnerType()
		{
			return ownerType;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(274)]
		public virtual java.lang.reflect.Type[] getActualTypeArguments()
		{
			java.lang.reflect.Type[] result = access_0024300(argumentsList);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			160, 176, 102, 116, 158, 103, 108, 101, 127, 19,
			101, 231, 59
		})]
		public override string toString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (ownerType != null && JavaVersion.CURRENT.jdkTypeDuplicatesOwnerName())
			{
				stringBuilder.append(JavaVersion.CURRENT.typeName(ownerType)).append('.');
			}
			StringBuilder stringBuilder2 = stringBuilder.append(rawType.getName()).append('<');
			Joiner joiner = access_0024400();
			ImmutableList fromIterable = argumentsList;
			JavaVersion cURRENT = JavaVersion.CURRENT;
			java.util.Objects.requireNonNull(cURRENT);
			string result = stringBuilder2.append(joiner.join(Iterables.transform(fromIterable, new ___003C_003EAnon0(cURRENT)))).append('>').toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 190, 124, 108, 6 })]
		public override int hashCode()
		{
			return ((ownerType != null) ? java.lang.Object.instancehelper_hashCode(ownerType) : 0) ^ argumentsList.hashCode() ^ java.lang.Object.instancehelper_hashCode(rawType);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 197, 104, 130, 103, 116, 115, 22 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (!(P_0 is ParameterizedType))
			{
				return false;
			}
			ParameterizedType parameterizedType = (ParameterizedType)P_0;
			return (java.lang.Object.instancehelper_equals(getRawType(), parameterizedType.getRawType()) && com.google.common.@base.Objects.equal(getOwnerType(), parameterizedType.getOwnerType()) && Arrays.equals(getActualTypeArguments(), parameterizedType.getActualTypeArguments())) ? true : false;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual string getTypeName()
		{
			return java.lang.reflect.Type._003Cdefault_003EgetTypeName(this);
		}

		[SecurityCritical]
		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		void ISerializable.GetObjectData(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.writeObject(this, P_0);
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected ParameterizedTypeImpl(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<D::Ljava/lang/reflect/GenericDeclaration;>Ljava/lang/Object;")]
	internal sealed class TypeVariableImpl : java.lang.Object
	{
		private sealed class ___003CCallerID_003E : CallerID
		{
			internal ___003CCallerID_003E()
			{
			}
		}

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("TD;")]
		private GenericDeclaration genericDeclaration;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private string name;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/ImmutableList<Ljava/lang/reflect/Type;>;")]
		private ImmutableList bounds;

		[SpecialName]
		private static CallerID ___003CcallerID_003E;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TD;Ljava/lang/String;[Ljava/lang/reflect/Type;)V")]
		[LineNumberTable(new byte[] { 161, 38, 104, 107, 113, 113, 108 })]
		internal TypeVariableImpl(GenericDeclaration P_0, string P_1, java.lang.reflect.Type[] P_2)
		{
			access_0024200(P_2, "bound for type variable");
			genericDeclaration = (GenericDeclaration)Preconditions.checkNotNull(P_0);
			name = (string)Preconditions.checkNotNull(P_1);
			bounds = ImmutableList.copyOf(P_2);
		}

		public virtual string getName()
		{
			return name;
		}

		[Signature("()TD;")]
		public virtual GenericDeclaration getGenericDeclaration()
		{
			return genericDeclaration;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(416)]
		public virtual java.lang.reflect.Type[] getBounds()
		{
			java.lang.reflect.Type[] result = access_0024300(bounds);
			_ = null;
			return result;
		}

		public virtual string getTypeName()
		{
			return name;
		}

		public override string toString()
		{
			return name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(438)]
		public override int hashCode()
		{
			return java.lang.Object.instancehelper_hashCode(genericDeclaration) ^ java.lang.String.instancehelper_hashCode(name);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161, 73, 138, 103, 112, 113, 97, 112, 103, 122,
			120, 11, 193, 162, 104, 103, 122, 48, 161
		})]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (NativeTypeVariableEquals.NATIVE_TYPE_VARIABLE_ONLY)
			{
				if (P_0 != null && Proxy.isProxyClass(java.lang.Object.instancehelper_getClass(P_0)) && Proxy.getInvocationHandler(P_0, TypeVariableImpl.___003CGetCallerID_003E()) is TypeVariableInvocationHandler)
				{
					TypeVariableInvocationHandler typeVariableInvocationHandler = (TypeVariableInvocationHandler)Proxy.getInvocationHandler(P_0, TypeVariableImpl.___003CGetCallerID_003E());
					TypeVariableImpl typeVariableImpl = TypeVariableInvocationHandler.access_0024500(typeVariableInvocationHandler);
					return (java.lang.String.instancehelper_equals(name, typeVariableImpl.getName()) && java.lang.Object.instancehelper_equals(genericDeclaration, typeVariableImpl.getGenericDeclaration()) && bounds.equals(typeVariableImpl.bounds)) ? true : false;
				}
				return false;
			}
			if (P_0 is TypeVariable)
			{
				TypeVariable typeVariable = (TypeVariable)P_0;
				return (java.lang.String.instancehelper_equals(name, typeVariable.getName()) && java.lang.Object.instancehelper_equals(genericDeclaration, typeVariable.getGenericDeclaration())) ? true : false;
			}
			return false;
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

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[ConstantPool(new object[]
	{
		(byte)63,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal sealed class TypeVariableInvocationHandler : java.lang.Object, InvocationHandler
	{
		private sealed class ___003CCallerID_003E : CallerID
		{
			internal ___003CCallerID_003E()
			{
			}
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/ImmutableMap<Ljava/lang/String;Ljava/lang/reflect/Method;>;")]
		private static ImmutableMap typeVariableMethods;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/reflect/Types$TypeVariableImpl<*>;")]
		private TypeVariableImpl typeVariableImpl;

		[SpecialName]
		private static CallerID ___003CcallerID_003E;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/reflect/Types$TypeVariableImpl<*>;)V")]
		[LineNumberTable(new byte[] { 161, 10, 104, 103 })]
		internal TypeVariableInvocationHandler(TypeVariableImpl P_0)
		{
			typeVariableImpl = P_0;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(359)]
		internal static TypeVariableImpl access_0024500(TypeVariableInvocationHandler P_0)
		{
			return P_0.typeVariableImpl;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Throwable" })]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 1, 22, 2, 1, 0, 0, 0, 63, 0,
			0
		})]
		[LineNumberTable(new byte[] { 161, 18, 103, 113, 99, 172, 127, 9, 98 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object invoke(object P_0, Method P_1, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object[] P_2)
		{
			//Discarded unreachable code: IL_003b
			string name = P_1.getName();
			Method method = (Method)typeVariableMethods.get(name);
			if (method == null)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new UnsupportedOperationException(name);
			}
			InvocationTargetException ex;
			try
			{
				return method.invoke(typeVariableImpl, P_2, TypeVariableInvocationHandler.___003CGetCallerID_003E());
			}
			catch (InvocationTargetException x)
			{
				ex = ByteCodeHelper.MapException<InvocationTargetException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			InvocationTargetException ex2 = ex;
			throw Throwable.___003Cunmap_003E(ex2.getCause());
		}

		[LineNumberTable(new byte[]
		{
			160, 249, 102, 126, 147, 211, 226, 61, 193, 240,
			56, 230, 75, 107
		})]
		static TypeVariableInvocationHandler()
		{
			ImmutableMap.Builder builder = ImmutableMap.builder();
			Method[] methods = ClassLiteral<TypeVariableImpl>.Value.getMethods(TypeVariableInvocationHandler.___003CGetCallerID_003E());
			int num = methods.Length;
			for (int i = 0; i < num; i++)
			{
				Method method = methods[i];
				if (!java.lang.Object.instancehelper_equals(method.getDeclaringClass(), ClassLiteral<TypeVariableImpl>.Value))
				{
					continue;
				}
				try
				{
					method.setAccessible(flag: true);
				}
				catch (AccessControlException)
				{
					goto IL_0047;
				}
				goto IL_004d;
				IL_004d:
				builder.put(method.getName(), method);
				continue;
				IL_0047:
				_ = null;
				goto IL_004d;
			}
			typeVariableMethods = builder.buildKeepingLast();
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

	[Serializable]
	[Implements(new string[] { "java.lang.reflect.WildcardType", "java.io.Serializable" })]
	internal sealed class WildcardTypeImpl : java.lang.Object, WildcardType, java.lang.reflect.Type, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/ImmutableList<Ljava/lang/reflect/Type;>;")]
		private ImmutableList lowerBounds;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/ImmutableList<Ljava/lang/reflect/Type;>;")]
		private ImmutableList upperBounds;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 103, 104, 107, 107, 113, 113 })]
		internal WildcardTypeImpl(java.lang.reflect.Type[] P_0, java.lang.reflect.Type[] P_1)
		{
			access_0024200(P_0, "lower bound for wildcard");
			access_0024200(P_1, "upper bound for wildcard");
			lowerBounds = JavaVersion.CURRENT.usedInGenericType(P_0);
			upperBounds = JavaVersion.CURRENT.usedInGenericType(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(482)]
		public virtual java.lang.reflect.Type[] getLowerBounds()
		{
			java.lang.reflect.Type[] result = access_0024300(lowerBounds);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(487)]
		public virtual java.lang.reflect.Type[] getUpperBounds()
		{
			java.lang.reflect.Type[] result = access_0024300(upperBounds);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 122, 104, 103, 127, 0, 53, 161 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is WildcardType)
			{
				WildcardType wildcardType = (WildcardType)P_0;
				return (lowerBounds.equals(Arrays.asList(wildcardType.getLowerBounds())) && upperBounds.equals(Arrays.asList(wildcardType.getUpperBounds()))) ? true : false;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(502)]
		public override int hashCode()
		{
			return lowerBounds.hashCode() ^ upperBounds.hashCode();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161, 137, 107, 127, 1, 124, 98, 127, 6, 124,
			98
		})]
		public override string toString()
		{
			StringBuilder stringBuilder = new StringBuilder("?");
			UnmodifiableIterator unmodifiableIterator = lowerBounds.iterator();
			while (((Iterator)unmodifiableIterator).hasNext())
			{
				java.lang.reflect.Type type = (java.lang.reflect.Type)((Iterator)unmodifiableIterator).next();
				stringBuilder.append(" super ").append(JavaVersion.CURRENT.typeName(type));
			}
			Iterator iterator = access_0024600(upperBounds).iterator();
			while (iterator.hasNext())
			{
				java.lang.reflect.Type type = (java.lang.reflect.Type)iterator.next();
				stringBuilder.append(" extends ").append(JavaVersion.CURRENT.typeName(type));
			}
			string result = stringBuilder.toString();
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual string getTypeName()
		{
			return java.lang.reflect.Type._003Cdefault_003EgetTypeName(this);
		}

		[SecurityCritical]
		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		void ISerializable.GetObjectData(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.writeObject(this, P_0);
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected WildcardTypeImpl(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}
	}

	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Joiner COMMA_JOINER;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<*>;[Ljava/lang/reflect/Type;)Ljava/lang/reflect/ParameterizedType;")]
	[LineNumberTable(new byte[] { 45, 102, 46 })]
	internal static ParameterizedType newParameterizedType(Class P_0, params java.lang.reflect.Type[] P_1)
	{
		ParameterizedTypeImpl result = new ParameterizedTypeImpl(ClassOwnership.JVM_BEHAVIOR.getOwnerType(P_0), P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 123, 103, 102, 240, 84, 101 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal static java.lang.reflect.Type getComponentType(java.lang.reflect.Type P_0)
	{
		Preconditions.checkNotNull(P_0);
		AtomicReference atomicReference = new AtomicReference();
		new _1(atomicReference).visit(P_0);
		return (java.lang.reflect.Type)atomicReference.get();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 13, 104, 103, 103, 114, 101, 144, 103, 111, 176 })]
	internal static java.lang.reflect.Type newArrayType(java.lang.reflect.Type P_0)
	{
		if (P_0 is WildcardType)
		{
			WildcardType wildcardType = (WildcardType)P_0;
			java.lang.reflect.Type[] lowerBounds = wildcardType.getLowerBounds();
			Preconditions.checkArgument((nint)lowerBounds.LongLength <= 1, (object)"Wildcard cannot have more than one lower bounds.");
			if ((nint)lowerBounds.LongLength == 1)
			{
				WildcardType result = supertypeOf(newArrayType(lowerBounds[0]));
				_ = null;
				return result;
			}
			java.lang.reflect.Type[] upperBounds = wildcardType.getUpperBounds();
			Preconditions.checkArgument((nint)upperBounds.LongLength == 1, (object)"Wildcard should have only one upper bound.");
			WildcardType result2 = subtypeOf(newArrayType(upperBounds[0]));
			_ = null;
			return result2;
		}
		java.lang.reflect.Type result3 = JavaVersion.CURRENT.newArrayType(P_0);
		_ = null;
		return result3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/reflect/Type;Ljava/lang/Class<*>;[Ljava/lang/reflect/Type;)Ljava/lang/reflect/ParameterizedType;")]
	[LineNumberTable(new byte[] { 34, 99, 170, 103, 124 })]
	internal static ParameterizedType newParameterizedTypeWithOwner([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] java.lang.reflect.Type P_0, Class P_1, params java.lang.reflect.Type[] P_2)
	{
		if (P_0 == null)
		{
			ParameterizedType result = newParameterizedType(P_1, P_2);
			_ = null;
			return result;
		}
		Preconditions.checkNotNull(P_2);
		Preconditions.checkArgument(P_1.getEnclosingClass(Types.___003CGetCallerID_003E()) != null, "Owner type for unenclosed %s", P_1);
		ParameterizedTypeImpl result2 = new ParameterizedTypeImpl(P_0, P_1, P_2);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<D::Ljava/lang/reflect/GenericDeclaration;>(TD;Ljava/lang/String;[Ljava/lang/reflect/Type;)Ljava/lang/reflect/TypeVariable<TD;>;")]
	[LineNumberTable(new byte[] { 96, 98, 53 })]
	internal static TypeVariable newArtificialTypeVariable(GenericDeclaration P_0, string P_1, params java.lang.reflect.Type[] P_2)
	{
		TypeVariable result = newTypeVariableImpl(P_0, P_1, (P_2.Length != 0) ? P_2 : new java.lang.reflect.Type[1] { ClassLiteral<java.lang.Object>.Value });
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(168)]
	internal static string toString(java.lang.reflect.Type P_0)
	{
		string result = ((!(P_0 is Class)) ? java.lang.Object.instancehelper_toString(P_0) : ((Class)P_0).getName());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<*>;)Ljava/lang/Class<*>;")]
	[LineNumberTable(542)]
	internal static Class getArrayClass(Class P_0)
	{
		Class result = java.lang.Object.instancehelper_getClass(java.lang.reflect.Array.newInstance(P_0, 0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(56)]
	internal static java.lang.reflect.Type access_0024100(java.lang.reflect.Type[] P_0)
	{
		java.lang.reflect.Type result = subtypeOfComponentType(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<Ljava/lang/reflect/Type;>;)Ljava/lang/Iterable<Ljava/lang/reflect/Type;>;")]
	[LineNumberTable(525)]
	private static Iterable filterUpperBounds(Iterable P_0)
	{
		Iterable result = Iterables.filter(P_0, Predicates.not(Predicates.equalTo(ClassLiteral<java.lang.Object>.Value)));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Collection<Ljava/lang/reflect/Type;>;)[Ljava/lang/reflect/Type;")]
	[LineNumberTable(521)]
	private static java.lang.reflect.Type[] toArray(Collection P_0)
	{
		return (java.lang.reflect.Type[])P_0.toArray(new java.lang.reflect.Type[0]);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 159, 111, 104, 104, 250, 61, 230, 70 })]
	private static void disallowPrimitiveType(java.lang.reflect.Type[] P_0, string P_1)
	{
		int num = P_0.Length;
		for (int i = 0; i < num; i++)
		{
			java.lang.reflect.Type type = P_0[i];
			if (type is Class)
			{
				Class @class = (Class)type;
				Preconditions.checkArgument((!@class.isPrimitive()) ? true : false, "Primitive type '%s' used as %s", @class, P_1);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 91, 111, 104, 164, 105, 105, 105, 163, 234,
		53, 230, 78
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private static java.lang.reflect.Type subtypeOfComponentType(java.lang.reflect.Type[] P_0)
	{
		int num = P_0.Length;
		for (int i = 0; i < num; i++)
		{
			java.lang.reflect.Type type = P_0[i];
			java.lang.reflect.Type componentType = getComponentType(type);
			if (componentType == null)
			{
				continue;
			}
			if (componentType is Class)
			{
				Class @class = (Class)componentType;
				if (@class.isPrimitive())
				{
					return @class;
				}
			}
			WildcardType result = subtypeOf(componentType);
			_ = null;
			return result;
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(159)]
	internal static WildcardType supertypeOf(java.lang.reflect.Type P_0)
	{
		WildcardTypeImpl result = new WildcardTypeImpl(new java.lang.reflect.Type[1] { P_0 }, new java.lang.reflect.Type[1] { ClassLiteral<java.lang.Object>.Value });
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(153)]
	internal static WildcardType subtypeOf(java.lang.reflect.Type P_0)
	{
		WildcardTypeImpl result = new WildcardTypeImpl(new java.lang.reflect.Type[0], new java.lang.reflect.Type[1] { P_0 });
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<D::Ljava/lang/reflect/GenericDeclaration;>(TD;Ljava/lang/String;[Ljava/lang/reflect/Type;)Ljava/lang/reflect/TypeVariable<TD;>;")]
	[LineNumberTable(new byte[] { 160, 211, 137, 107, 139 })]
	private static TypeVariable newTypeVariableImpl(GenericDeclaration P_0, string P_1, java.lang.reflect.Type[] P_2)
	{
		TypeVariableImpl typeVariableImpl = new TypeVariableImpl(P_0, P_1, P_2);
		return (TypeVariable)Reflection.newProxy(ClassLiteral<TypeVariable>.Value, new TypeVariableInvocationHandler(typeVariableImpl));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(687)]
	private Types()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(56)]
	internal static void access_0024200(java.lang.reflect.Type[] P_0, string P_1)
	{
		disallowPrimitiveType(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(56)]
	internal static java.lang.reflect.Type[] access_0024300(Collection P_0)
	{
		java.lang.reflect.Type[] result = toArray(P_0);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	internal static Joiner access_0024400()
	{
		return COMMA_JOINER;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(56)]
	internal static Iterable access_0024600(Iterable P_0)
	{
		Iterable result = filterUpperBounds(P_0);
		_ = null;
		return result;
	}

	[LineNumberTable(59)]
	static Types()
	{
		COMMA_JOINER = Joiner.on(", ").useForNull("null");
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
