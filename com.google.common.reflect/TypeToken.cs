using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.common.collect;
using com.google.common.primitives;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.lang.reflect;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.reflect;

[Serializable]
[Signature("<T:Ljava/lang/Object;>Lcom/google/common/reflect/TypeCapture<TT;>;Ljava/io/Serializable;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/reflect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Serializable" })]
public abstract class TypeToken : TypeCapture, Serializable.__Interface, ISerializable
{
	[SpecialName]
	[Signature("Lcom/google/common/reflect/Invokable$MethodInvokable<TT;>;")]
	[EnclosingMethod(null, "method", "(Ljava.lang.reflect.Method;)Lcom.google.common.reflect.Invokable;")]
	internal class _1 : Invokable.MethodInvokable
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal TypeToken this_00240;

		[Signature("()Lcom/google/common/reflect/TypeToken<TT;>;")]
		public override TypeToken getOwnerType()
		{
			return this_00240;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(600)]
		internal _1(TypeToken P_0, Method P_1)
		{
			this_00240 = P_0;
			base._002Ector(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(603)]
		internal override java.lang.reflect.Type getGenericReturnType()
		{
			java.lang.reflect.Type result = access_0024000(this_00240).resolveType(base.getGenericReturnType());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(608)]
		internal override java.lang.reflect.Type[] getGenericParameterTypes()
		{
			java.lang.reflect.Type[] result = access_0024100(this_00240).resolveTypesInPlace(base.getGenericParameterTypes());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(613)]
		internal override java.lang.reflect.Type[] getGenericExceptionTypes()
		{
			java.lang.reflect.Type[] result = access_0024000(this_00240).resolveTypesInPlace(base.getGenericExceptionTypes());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(623)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(getOwnerType());
			string text2 = base.toString();
			int num = 1 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
			num = num;
			string result = new StringBuilder(num).append(text).append(".").append(text2)
				.toString();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[Signature("Lcom/google/common/reflect/Invokable$ConstructorInvokable<TT;>;")]
	[EnclosingMethod(null, "constructor", "(Ljava.lang.reflect.Constructor;)Lcom.google.common.reflect.Invokable;")]
	internal class _2 : Invokable.ConstructorInvokable
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal TypeToken this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(640)]
		internal _2(TypeToken P_0, Constructor P_1)
		{
			this_00240 = P_0;
			base._002Ector(P_1);
		}

		[Signature("()Lcom/google/common/reflect/TypeToken<TT;>;")]
		public override TypeToken getOwnerType()
		{
			return this_00240;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(648)]
		internal override java.lang.reflect.Type[] getGenericParameterTypes()
		{
			java.lang.reflect.Type[] result = access_0024100(this_00240).resolveTypesInPlace(base.getGenericParameterTypes());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(643)]
		internal override java.lang.reflect.Type getGenericReturnType()
		{
			java.lang.reflect.Type result = access_0024000(this_00240).resolveType(base.getGenericReturnType());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(653)]
		internal override java.lang.reflect.Type[] getGenericExceptionTypes()
		{
			java.lang.reflect.Type[] result = access_0024000(this_00240).resolveTypesInPlace(base.getGenericExceptionTypes());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(663)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(getOwnerType());
			string text2 = Joiner.on(", ").join(getGenericParameterTypes());
			int num = 2 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
			num = num;
			string result = new StringBuilder(num).append(text).append("(").append(text2)
				.append(")")
				.toString();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[EnclosingMethod(null, "rejectTypeVariables", "()Lcom.google.common.reflect.TypeToken;")]
	internal class _3 : TypeVisitor
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal TypeToken this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(863)]
		internal _3(TypeToken P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/reflect/TypeVariable<*>;)V")]
		[LineNumberTable(new byte[] { 162, 240, 102 })]
		internal override void visitTypeVariable(TypeVariable P_0)
		{
			string text = java.lang.String.valueOf(access_0024500(this_00240));
			int num = 58 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string s = new StringBuilder(num).append(text).append("contains a type variable and is not safe for the operation").toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 246, 108, 110 })]
		internal override void visitWildcardType(WildcardType P_0)
		{
			visit(P_0.getLowerBounds());
			visit(P_0.getUpperBounds());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 252, 108, 119 })]
		internal override void visitParameterizedType(ParameterizedType P_0)
		{
			visit(P_0.getActualTypeArguments());
			visit(P_0.getOwnerType());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 2, 119 })]
		internal override void visitGenericArrayType(GenericArrayType P_0)
		{
			visit(P_0.getGenericComponentType());
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[EnclosingMethod(null, "getRawTypes", "()Lcom.google.common.collect.ImmutableSet;")]
	internal class _4 : TypeVisitor
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ImmutableSet.Builder val_0024builder;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1100)]
		internal _4(TypeToken P_0, ImmutableSet.Builder P_1)
		{
			val_0024builder = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/reflect/TypeVariable<*>;)V")]
		[LineNumberTable(new byte[] { 163, 221, 110 })]
		internal override void visitTypeVariable(TypeVariable P_0)
		{
			visit(P_0.getBounds());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 226, 110 })]
		internal override void visitWildcardType(WildcardType P_0)
		{
			visit(P_0.getUpperBounds());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 231, 119 })]
		internal override void visitParameterizedType(ParameterizedType P_0)
		{
			val_0024builder.add((Class)P_0.getRawType());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Class<*>;)V")]
		[LineNumberTable(new byte[] { 163, 236, 109 })]
		internal override void visitClass(Class P_0)
		{
			val_0024builder.add(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 241, 127, 2 })]
		internal override void visitGenericArrayType(GenericArrayType P_0)
		{
			val_0024builder.add(Types.getArrayClass(of(P_0.getGenericComponentType()).getRawType()));
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	internal class Bounds : java.lang.Object
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private java.lang.reflect.Type[] bounds;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private bool target;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 206, 103, 117, 112, 7, 230, 69 })]
		internal virtual bool isSupertypeOf(java.lang.reflect.Type P_0)
		{
			TypeToken typeToken = of(P_0);
			java.lang.reflect.Type[] array = bounds;
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				java.lang.reflect.Type supertype = array[i];
				if (typeToken.isSubtypeOf(supertype) == target)
				{
					return target;
				}
			}
			return (!target) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 197, 116, 116, 7, 230, 69 })]
		internal virtual bool isSubtypeOf(java.lang.reflect.Type P_0)
		{
			java.lang.reflect.Type[] array = bounds;
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				java.lang.reflect.Type type = array[i];
				if (of(type).isSubtypeOf(P_0) == target)
				{
					return target;
				}
			}
			return (!target) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 158, 130, 98, 104, 103, 103 })]
		internal Bounds(java.lang.reflect.Type[] P_0, bool P_1)
		{
			bounds = P_0;
			target = P_1;
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/reflect/TypeToken<TT;>.TypeSet;")]
	internal sealed class ClassSet : TypeSet, IObjectReference
	{
		[NonSerialized]
		[Signature("Lcom/google/common/collect/ImmutableSet<Lcom/google/common/reflect/TypeToken<-TT;>;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private new ImmutableSet m_classes;

		private const long serialVersionUID = 0L;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal new TypeToken this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(765)]
		internal ClassSet(TypeToken P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(765)]
		private ClassSet(TypeToken P_0)
		{
			this_00240 = P_0;
			base._002Ector(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<Lcom/google/common/reflect/TypeToken<-TT;>;>;")]
		[LineNumberTable(new byte[]
		{
			162, 145, 103, 131, 133, 113, 98, 106, 101, 239,
			61, 225, 69
		})]
		protected internal override Set @delegate()
		{
			ImmutableSet immutableSet = this.m_classes;
			if (immutableSet == null)
			{
				ImmutableList iterable = TypeCollector.FOR_GENERIC_TYPE.classesOnly().collectTypes(this_00240);
				ImmutableSet result = FluentIterable.from(iterable).filter(TypeFilter.IGNORE_TYPE_VARIABLE_OR_WILDCARD).toSet();
				this.m_classes = result;
				return result;
			}
			return immutableSet;
		}

		[Signature("()Lcom/google/common/reflect/TypeToken<TT;>.TypeSet;")]
		public override TypeSet classes()
		{
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<Ljava/lang/Class<-TT;>;>;")]
		[LineNumberTable(new byte[] { 162, 169, 101, 118 })]
		public override Set rawTypes()
		{
			ImmutableList elements = TypeCollector.FOR_RAW_TYPE.classesOnly().collectTypes(access_0024300(this_00240));
			ImmutableSet result = ImmutableSet.copyOf(elements);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/reflect/TypeToken<TT;>.TypeSet;")]
		[LineNumberTable(802)]
		public override TypeSet interfaces()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException("classes().interfaces() not supported.");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(806)]
		private object readResolve()
		{
			TypeSet result = this_00240.getTypes().classes();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(765)]
		protected internal new virtual Collection @delegate()
		{
			Set result = this.@delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(765)]
		protected internal new virtual object @delegate()
		{
			Set result = this.@delegate();
			_ = null;
			return result;
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected ClassSet(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}

		[SecurityCritical]
		[HideFromJava]
		object IObjectReference.GetRealObject(StreamingContext P_0)
		{
			return readResolve();
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/reflect/TypeToken<TT;>.TypeSet;")]
	internal sealed class InterfaceSet : TypeSet, IObjectReference
	{
		[SpecialName]
		private sealed class ___003C_003EAnon0 : com.google.common.@base.Predicate
		{
			internal ___003C_003EAnon0()
			{
			}

			public bool apply(object P_0)
			{
				bool result = ((Class)P_0).isInterface();
				_ = null;
				return result;
			}

			[SpecialName]
			public bool equals(object P_0)
			{
				return java.lang.Object.instancehelper_equals(this, P_0);
			}

			[SpecialName]
			public bool test(object P_0)
			{
				return com.google.common.@base.Predicate._003Cdefault_003Etest(this, P_0);
			}

			[SpecialName]
			public java.util.function.Predicate and(java.util.function.Predicate P_0)
			{
				return java.util.function.Predicate._003Cdefault_003Eand(this, P_0);
			}

			[SpecialName]
			public java.util.function.Predicate negate()
			{
				return java.util.function.Predicate._003Cdefault_003Enegate(this);
			}

			[SpecialName]
			public java.util.function.Predicate or(java.util.function.Predicate P_0)
			{
				return java.util.function.Predicate._003Cdefault_003Eor(this, P_0);
			}
		}

		[NonSerialized]
		[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
		[Signature("Lcom/google/common/reflect/TypeToken<TT;>.TypeSet;")]
		private TypeSet allTypes;

		[NonSerialized]
		[Signature("Lcom/google/common/collect/ImmutableSet<Lcom/google/common/reflect/TypeToken<-TT;>;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private new ImmutableSet m_interfaces;

		private const long serialVersionUID = 0L;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal new TypeToken this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/reflect/TypeToken<TT;>.TypeSet;)V")]
		[LineNumberTable(new byte[] { 162, 98, 112, 103 })]
		internal InterfaceSet(TypeToken P_0, TypeSet P_1)
		{
			this_00240 = P_0;
			base._002Ector(P_0);
			allTypes = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<Lcom/google/common/reflect/TypeToken<-TT;>;>;")]
		[LineNumberTable(new byte[] { 162, 104, 103, 99, 103, 62, 161 })]
		protected internal override Set @delegate()
		{
			ImmutableSet immutableSet = this.m_interfaces;
			if (immutableSet == null)
			{
				ImmutableSet result = FluentIterable.from(allTypes).filter(TypeFilter.INTERFACE_ONLY).toSet();
				this.m_interfaces = result;
				return result;
			}
			return immutableSet;
		}

		[Signature("()Lcom/google/common/reflect/TypeToken<TT;>.TypeSet;")]
		public override TypeSet interfaces()
		{
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<Ljava/lang/Class<-TT;>;>;")]
		[LineNumberTable(new byte[] { 162, 122, 107, 107 })]
		public override Set rawTypes()
		{
			ImmutableList iterable = TypeCollector.FOR_RAW_TYPE.collectTypes(access_0024300(this_00240));
			ImmutableSet result = FluentIterable.from(iterable).filter(new ___003C_003EAnon0()).toSet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/reflect/TypeToken<TT;>.TypeSet;")]
		[LineNumberTable(755)]
		public override TypeSet classes()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException("interfaces().classes() not supported.");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(759)]
		private object readResolve()
		{
			TypeSet result = this_00240.getTypes().interfaces();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(719)]
		protected internal new virtual Collection @delegate()
		{
			Set result = this.@delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(719)]
		protected internal new virtual object @delegate()
		{
			Set result = this.@delegate();
			_ = null;
			return result;
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected InterfaceSet(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}

		[SecurityCritical]
		[HideFromJava]
		object IObjectReference.GetRealObject(StreamingContext P_0)
		{
			return readResolve();
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<T:Ljava/lang/Object;>Lcom/google/common/reflect/TypeToken<TT;>;")]
	internal sealed class SimpleTypeToken : TypeToken
	{
		private new const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 164, 174, 106 })]
		internal SimpleTypeToken(java.lang.reflect.Type P_0)
			: base(P_0, null)
		{
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected SimpleTypeToken(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Abstract)]
	[Signature("<K:Ljava/lang/Object;>Ljava/lang/Object;")]
	internal abstract class TypeCollector : java.lang.Object
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/reflect/TypeToken$TypeCollector<Lcom/google/common/reflect/TypeToken<*>;>;")]
		[EnclosingMethod(null, null, null)]
		internal class _1 : TypeCollector
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(1326)]
			internal _1()
				: base(null)
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/reflect/TypeToken<*>;)Lcom/google/common/reflect/TypeToken<*>;")]
			[LineNumberTable(1340)]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			internal virtual TypeToken getSuperclass(TypeToken P_0)
			{
				TypeToken genericSuperclass = P_0.getGenericSuperclass();
				_ = null;
				return genericSuperclass;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/reflect/TypeToken<*>;)Ljava/lang/Iterable<+Lcom/google/common/reflect/TypeToken<*>;>;")]
			[LineNumberTable(1334)]
			internal virtual Iterable getInterfaces(TypeToken P_0)
			{
				ImmutableList genericInterfaces = P_0.getGenericInterfaces();
				_ = null;
				return genericInterfaces;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/reflect/TypeToken<*>;)Ljava/lang/Class<*>;")]
			[LineNumberTable(1329)]
			internal virtual Class getRawType(TypeToken P_0)
			{
				Class rawType = P_0.getRawType();
				_ = null;
				return rawType;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(1326)]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			internal override object getSuperclass(object P_0)
			{
				TypeToken superclass = getSuperclass((TypeToken)P_0);
				_ = null;
				return superclass;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(1326)]
			internal override Iterable getInterfaces(object P_0)
			{
				Iterable interfaces = getInterfaces((TypeToken)P_0);
				_ = null;
				return interfaces;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(1326)]
			internal override Class getRawType(object P_0)
			{
				Class rawType = getRawType((TypeToken)P_0);
				_ = null;
				return rawType;
			}

			[HideFromJava]
			static _1()
			{
				TypeCollector.___003Cclinit_003E();
			}
		}

		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/reflect/TypeToken$TypeCollector<Ljava/lang/Class<*>;>;")]
		[EnclosingMethod(null, null, null)]
		internal class _2 : TypeCollector
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(1345)]
			internal _2()
				: base(null)
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/lang/Class<*>;)Ljava/lang/Class<*>;")]
			[LineNumberTable(1359)]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			internal virtual Class getSuperclass(Class P_0)
			{
				Class superclass = P_0.getSuperclass();
				_ = null;
				return superclass;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/lang/Class<*>;)Ljava/lang/Iterable<+Ljava/lang/Class<*>;>;")]
			[LineNumberTable(1353)]
			internal virtual Iterable getInterfaces(Class P_0)
			{
				List result = Arrays.asList(P_0.getInterfaces());
				_ = null;
				return result;
			}

			[Signature("(Ljava/lang/Class<*>;)Ljava/lang/Class<*>;")]
			internal virtual Class getRawType(Class P_0)
			{
				return P_0;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(1345)]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			internal override object getSuperclass(object P_0)
			{
				Class superclass = getSuperclass((Class)P_0);
				_ = null;
				return superclass;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(1345)]
			internal override Iterable getInterfaces(object P_0)
			{
				Iterable interfaces = getInterfaces((Class)P_0);
				_ = null;
				return interfaces;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(1345)]
			internal override Class getRawType(object P_0)
			{
				Class rawType = getRawType((Class)P_0);
				_ = null;
				return rawType;
			}

			[HideFromJava]
			static _2()
			{
				TypeCollector.___003Cclinit_003E();
			}
		}

		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/reflect/TypeToken$TypeCollector$ForwardingTypeCollector<TK;>;")]
		[EnclosingMethod(null, "classesOnly", "()Lcom.google.common.reflect.TypeToken$TypeCollector;")]
		internal class _3 : ForwardingTypeCollector
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(1365)]
			internal _3(TypeCollector P_0, TypeCollector P_1)
				: base(P_1)
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(TK;)Ljava/lang/Iterable<+TK;>;")]
			[LineNumberTable(1368)]
			internal override Iterable getInterfaces(object P_0)
			{
				ImmutableSet result = ImmutableSet.of();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/lang/Iterable<+TK;>;)Lcom/google/common/collect/ImmutableList<TK;>;")]
			[LineNumberTable(new byte[] { 164, 235, 102, 118, 110, 136, 98 })]
			internal override ImmutableList collectTypes(Iterable P_0)
			{
				ImmutableList.Builder builder = ImmutableList.builder();
				Iterator iterator = P_0.iterator();
				while (iterator.hasNext())
				{
					object obj = iterator.next();
					if (!getRawType(obj).isInterface())
					{
						builder.add(obj);
					}
				}
				ImmutableList result = base.collectTypes(builder.build());
				_ = null;
				return result;
			}

			[HideFromJava]
			static _3()
			{
				ForwardingTypeCollector.___003Cclinit_003E();
			}
		}

		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/collect/Ordering<TK;>;")]
		[EnclosingMethod(null, "sortKeysByValue", "(Ljava.util.Map;Ljava.util.Comparator;)Lcom.google.common.collect.ImmutableList;")]
		internal class _4 : Ordering
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Comparator val_0024valueComparator;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Map val_0024map;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(1426)]
			internal _4(Comparator P_0, Map P_1)
			{
				val_0024valueComparator = P_0;
				val_0024map = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(TK;TK;)I")]
			[LineNumberTable(new byte[] { 165, 36, 109, 59 })]
			public override int compare(object P_0, object P_1)
			{
				int result = val_0024valueComparator.compare(java.util.Objects.requireNonNull(val_0024map.get(P_0)), java.util.Objects.requireNonNull(val_0024map.get(P_1)));
				_ = null;
				return result;
			}
		}

		[InnerClass(null, Modifiers.Private | Modifiers.Static)]
		[Signature("<K:Ljava/lang/Object;>Lcom/google/common/reflect/TypeToken$TypeCollector<TK;>;")]
		internal class ForwardingTypeCollector : TypeCollector
		{
			[Modifiers(Modifiers.Private | Modifiers.Final)]
			[Signature("Lcom/google/common/reflect/TypeToken$TypeCollector<TK;>;")]
			private TypeCollector @delegate;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/reflect/TypeToken$TypeCollector<TK;>;)V")]
			[LineNumberTable(new byte[] { 165, 54, 105, 103 })]
			internal ForwardingTypeCollector(TypeCollector P_0)
				: base(null)
			{
				@delegate = P_0;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(TK;)Ljava/lang/Class<*>;")]
			[LineNumberTable(1454)]
			internal override Class getRawType(object P_0)
			{
				Class rawType = @delegate.getRawType(P_0);
				_ = null;
				return rawType;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(TK;)Ljava/lang/Iterable<+TK;>;")]
			[LineNumberTable(1459)]
			internal override Iterable getInterfaces(object P_0)
			{
				Iterable interfaces = @delegate.getInterfaces(P_0);
				_ = null;
				return interfaces;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(TK;)TK;")]
			[LineNumberTable(1465)]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			internal override object getSuperclass(object P_0)
			{
				object superclass = @delegate.getSuperclass(P_0);
				_ = null;
				return superclass;
			}

			[HideFromJava]
			static ForwardingTypeCollector()
			{
				TypeCollector.___003Cclinit_003E();
			}
		}

		[Modifiers(Modifiers.Static | Modifiers.Final)]
		[Signature("Lcom/google/common/reflect/TypeToken$TypeCollector<Lcom/google/common/reflect/TypeToken<*>;>;")]
		internal static TypeCollector FOR_GENERIC_TYPE;

		[Modifiers(Modifiers.Static | Modifiers.Final)]
		[Signature("Lcom/google/common/reflect/TypeToken$TypeCollector<Ljava/lang/Class<*>;>;")]
		internal static TypeCollector FOR_RAW_TYPE;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		protected internal static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Lcom/google/common/collect/ImmutableList<TK;>;")]
		[LineNumberTable(1385)]
		internal ImmutableList collectTypes(object P_0)
		{
			ImmutableList result = collectTypes(ImmutableList.of(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Iterable<+TK;>;)Lcom/google/common/collect/ImmutableList<TK;>;")]
		[LineNumberTable(new byte[] { 164, 252, 102, 118, 105, 98 })]
		internal virtual ImmutableList collectTypes(Iterable P_0)
		{
			HashMap hashMap = Maps.newHashMap();
			Iterator iterator = P_0.iterator();
			while (iterator.hasNext())
			{
				object obj = iterator.next();
				collectTypes(obj, hashMap);
			}
			ImmutableList result = sortKeysByValue(hashMap, Ordering.natural().reverse());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/reflect/TypeToken$TypeCollector<TK;>;")]
		[LineNumberTable(1365)]
		internal TypeCollector classesOnly()
		{
			_3 result = new _3(this, this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1323)]
		private TypeCollector()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/util/Map<-TK;Ljava/lang/Integer;>;)I")]
		[LineNumberTable(new byte[]
		{
			165, 6, 109, 131, 169, 115, 124, 111, 98, 105,
			100, 240, 71, 112
		})]
		private int collectTypes(object P_0, Map P_1)
		{
			Integer integer = (Integer)P_1.get(P_0);
			if (integer != null)
			{
				int result = integer.intValue();
				_ = null;
				return result;
			}
			int num = (getRawType(P_0).isInterface() ? 1 : 0);
			Iterator iterator = getInterfaces(P_0).iterator();
			while (iterator.hasNext())
			{
				object obj = iterator.next();
				num = java.lang.Math.max(num, collectTypes(obj, P_1));
			}
			object superclass = getSuperclass(P_0);
			if (superclass != null)
			{
				num = java.lang.Math.max(num, collectTypes(superclass, P_1));
			}
			P_1.put(P_0, Integer.valueOf(num + 1));
			return num + 1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map<TK;TV;>;Ljava/util/Comparator<-TV;>;)Lcom/google/common/collect/ImmutableList<TK;>;")]
		[LineNumberTable(new byte[] { 165, 31, 232, 73 })]
		private static ImmutableList sortKeysByValue(Map P_0, Comparator P_1)
		{
			_4  = new _4(P_1, P_0);
			ImmutableList result = .immutableSortedCopy(P_0.keySet());
			_ = null;
			return result;
		}

		[Signature("(TK;)Ljava/lang/Class<*>;")]
		internal abstract Class getRawType(object P_0);

		[Signature("(TK;)Ljava/lang/Iterable<+TK;>;")]
		internal abstract Iterable getInterfaces(object P_0);

		[Signature("(TK;)TK;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal abstract object getSuperclass(object P_0);

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(1323)]
		internal TypeCollector(TypeToken._1 P_0)
			: this()
		{
		}

		[LineNumberTable(new byte[] { 164, 187, 234, 83 })]
		static TypeCollector()
		{
			FOR_GENERIC_TYPE = new _1();
			FOR_RAW_TYPE = new _2();
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Abstract | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/reflect/TypeToken$TypeFilter;>;Lcom/google/common/base/Predicate<Lcom/google/common/reflect/TypeToken<*>;>;")]
	[Modifiers(Modifiers.Super | Modifiers.Abstract | Modifiers.Enum)]
	[Implements(new string[] { "com.google.common.base.Predicate" })]
	internal abstract class TypeFilter : java.lang.Enum, com.google.common.@base.Predicate, java.util.function.Predicate
	{
		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		internal sealed class _1 : TypeFilter
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(813)]
			internal _1(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/reflect/TypeToken<*>;)Z")]
			[LineNumberTable(new byte[] { 162, 190, 110, 48 })]
			public virtual bool apply(TypeToken P_0)
			{
				return (!(access_0024500(P_0) is TypeVariable) && !(access_0024500(P_0) is WildcardType)) ? true : false;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(813)]
			public override bool apply(object P_0)
			{
				bool result = apply((TypeToken)P_0);
				_ = null;
				return result;
			}

			[HideFromJava]
			static _1()
			{
				TypeFilter.___003Cclinit_003E();
			}
		}

		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		internal sealed class _2 : TypeFilter
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(820)]
			internal _2(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/reflect/TypeToken<*>;)Z")]
			[LineNumberTable(823)]
			public virtual bool apply(TypeToken P_0)
			{
				bool result = P_0.getRawType().isInterface();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(820)]
			public override bool apply(object P_0)
			{
				bool result = apply((TypeToken)P_0);
				_ = null;
				return result;
			}

			[HideFromJava]
			static _2()
			{
				TypeFilter.___003Cclinit_003E();
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static TypeFilter IGNORE_TYPE_VARIABLE_OR_WILDCARD;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static TypeFilter INTERFACE_ONLY;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static TypeFilter[] _0024VALUES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(812)]
		private TypeFilter(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(812)]
		private static TypeFilter[] _0024values()
		{
			return new TypeFilter[2] { IGNORE_TYPE_VARIABLE_OR_WILDCARD, INTERFACE_ONLY };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(812)]
		public static TypeFilter[] values()
		{
			return (TypeFilter[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(812)]
		public static TypeFilter valueOf(string P_0)
		{
			return (TypeFilter)java.lang.Enum.valueOf(ClassLiteral<TypeFilter>.Value, P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(812)]
		internal TypeFilter(string P_0, int P_1, TypeToken._1 P_2)
			: this(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[LineNumberTable(new byte[] { 162, 187, 240, 71, 240, 56 })]
		static TypeFilter()
		{
			IGNORE_TYPE_VARIABLE_OR_WILDCARD = new _1("IGNORE_TYPE_VARIABLE_OR_WILDCARD", 0);
			INTERFACE_ONLY = new _2("INTERFACE_ONLY", 1);
			_0024VALUES = _0024values();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual bool test(object P_0)
		{
			return com.google.common.@base.Predicate._003Cdefault_003Etest(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual java.util.function.Predicate and(java.util.function.Predicate P_0)
		{
			return java.util.function.Predicate._003Cdefault_003Eand(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual java.util.function.Predicate negate()
		{
			return java.util.function.Predicate._003Cdefault_003Enegate(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual java.util.function.Predicate or(java.util.function.Predicate P_0)
		{
			return java.util.function.Predicate._003Cdefault_003Eor(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public abstract bool apply(object P_0);

		bool com.google.common.@base.Predicate.Predicate_003A_003Aequals(object P_0)
		{
			return equals(P_0);
		}
	}

	[Serializable]
	[Signature("Lcom/google/common/collect/ForwardingSet<Lcom/google/common/reflect/TypeToken<-TT;>;>;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.io.Serializable" })]
	public class TypeSet : ForwardingSet, Serializable.__Interface, ISerializable
	{
		[NonSerialized]
		[Signature("Lcom/google/common/collect/ImmutableSet<Lcom/google/common/reflect/TypeToken<-TT;>;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private ImmutableSet types;

		private const long serialVersionUID = 0L;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal TypeToken this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<Ljava/lang/Class<-TT;>;>;")]
		[LineNumberTable(new byte[] { 162, 85, 107, 107 })]
		public virtual Set rawTypes()
		{
			ImmutableList elements = TypeCollector.FOR_RAW_TYPE.collectTypes(access_0024300(this_00240));
			ImmutableSet result = ImmutableSet.copyOf(elements);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(678)]
		internal TypeSet(TypeToken P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<Lcom/google/common/reflect/TypeToken<-TT;>;>;")]
		[LineNumberTable(new byte[]
		{
			162, 66, 103, 163, 107, 102, 98, 106, 101, 239,
			61, 225, 69
		})]
		protected internal override Set @delegate()
		{
			ImmutableSet immutableSet = types;
			if (immutableSet == null)
			{
				ImmutableList iterable = TypeCollector.FOR_GENERIC_TYPE.collectTypes(this_00240);
				ImmutableSet result = FluentIterable.from(iterable).filter(TypeFilter.IGNORE_TYPE_VARIABLE_OR_WILDCARD).toSet();
				types = result;
				return result;
			}
			return immutableSet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/reflect/TypeToken<TT;>.TypeSet;")]
		[LineNumberTable(682)]
		public virtual TypeSet interfaces()
		{
			InterfaceSet result = new InterfaceSet(this_00240, this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/reflect/TypeToken<TT;>.TypeSet;")]
		[LineNumberTable(687)]
		public virtual TypeSet classes()
		{
			ClassSet result = new ClassSet(this_00240, null);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(674)]
		protected internal override Collection _003Cbridge_003Edelegate()
		{
			Set result = @delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(674)]
		protected internal override object _003Cbridge_003Edelegate()
		{
			Set result = @delegate();
			_ = null;
			return result;
		}

		[HideFromJava]
		public static implicit operator Serializable(TypeSet P_0)
		{
			Serializable result = default(Serializable);
			result.___003Cref_003E = P_0;
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
		protected TypeSet(SerializationInfo P_0, StreamingContext P_1)
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

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private java.lang.reflect.Type runtimeType;

	[NonSerialized]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private TypeResolver invariantTypeResolver;

	[NonSerialized]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private TypeResolver covariantTypeResolver;

	private const long serialVersionUID = 3637540370352322684L;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Class<TT;>;)Lcom/google/common/reflect/TypeToken<TT;>;")]
	[LineNumberTable(170)]
	public static TypeToken of(Class type)
	{
		SimpleTypeToken result = new SimpleTypeToken(type);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/reflect/TypeToken<TT;>.TypeSet;")]
	[LineNumberTable(390)]
	public TypeSet getTypes()
	{
		TypeSet result = new TypeSet(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/reflect/TypeToken<TT;>;")]
	[LineNumberTable(new byte[] { 162, 237, 245, 87, 101 })]
	internal TypeToken rejectTypeVariables()
	{
		new _3(this).visit(runtimeType);
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 207, 104, 103, 148 })]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object o)
	{
		if (o is TypeToken)
		{
			TypeToken typeToken = (TypeToken)o;
			bool result = java.lang.Object.instancehelper_equals(runtimeType, typeToken.runtimeType);
			_ = null;
			return result;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/reflect/Type;)Lcom/google/common/reflect/TypeToken<*>;")]
	[LineNumberTable(175)]
	public static TypeToken of(java.lang.reflect.Type type)
	{
		SimpleTypeToken result = new SimpleTypeToken(type);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/reflect/TypeToken<*>;)Z")]
	[LineNumberTable(454)]
	public bool isSupertypeOf(TypeToken type)
	{
		bool result = type.isSubtypeOf(getType());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(102)]
	internal static TypeResolver access_0024000(TypeToken P_0)
	{
		TypeResolver result = P_0.getCovariantTypeResolver();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(102)]
	internal static TypeResolver access_0024100(TypeToken P_0)
	{
		TypeResolver result = P_0.getInvariantTypeResolver();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 114, 104, 113 })]
	private TypeToken(java.lang.reflect.Type P_0)
	{
		runtimeType = (java.lang.reflect.Type)Preconditions.checkNotNull(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<Ljava/lang/Class<-TT;>;>;")]
	[LineNumberTable(new byte[] { 163, 217, 102, 246, 89, 165, 103 })]
	private ImmutableSet getRawTypes()
	{
		ImmutableSet.Builder builder = ImmutableSet.builder();
		new _4(this, builder).visit(runtimeType);
		return builder.build();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 63, 103, 99, 151 })]
	private TypeResolver getInvariantTypeResolver()
	{
		TypeResolver typeResolver = invariantTypeResolver;
		if (typeResolver == null)
		{
			TypeResolver typeResolver2 = TypeResolver.invariantly(runtimeType);
			invariantTypeResolver = typeResolver2;
			typeResolver = typeResolver2;
		}
		return typeResolver;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 55, 103, 99, 151 })]
	private TypeResolver getCovariantTypeResolver()
	{
		TypeResolver typeResolver = covariantTypeResolver;
		if (typeResolver == null)
		{
			TypeResolver typeResolver2 = TypeResolver.covariantly(runtimeType);
			covariantTypeResolver = typeResolver2;
			typeResolver = typeResolver2;
		}
		return typeResolver;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<X:Ljava/lang/Object;>(Lcom/google/common/reflect/TypeParameter<TX;>;Lcom/google/common/reflect/TypeToken<TX;>;)Lcom/google/common/reflect/TypeToken<TT;>;")]
	[LineNumberTable(new byte[] { 160, 122, 182, 37, 198 })]
	public TypeToken where(TypeParameter typeParam, TypeToken typeArg)
	{
		TypeResolver typeResolver = new TypeResolver().where(ImmutableMap.of(new TypeResolver.TypeVariableKey(typeParam.typeVariable), typeArg.runtimeType));
		SimpleTypeToken result = new SimpleTypeToken(typeResolver.resolveType(runtimeType));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/reflect/Type;)Lcom/google/common/reflect/TypeToken<-TT;>;")]
	[LineNumberTable(new byte[] { 160, 214, 103, 109, 162, 98 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private TypeToken boundAsSuperclass(java.lang.reflect.Type P_0)
	{
		TypeToken typeToken = of(P_0);
		if (typeToken.getRawType().isInterface())
		{
			return null;
		}
		return typeToken;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/lang/Class<-TT;>;")]
	[LineNumberTable(new byte[] { 160, 81, 150, 98 })]
	public Class getRawType()
	{
		return (Class)getRawTypes().iterator().next();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/reflect/Type;)Lcom/google/common/reflect/TypeToken<*>;")]
	[LineNumberTable(new byte[] { 160, 174, 146, 108, 108 })]
	private TypeToken resolveSupertype(java.lang.reflect.Type P_0)
	{
		TypeToken typeToken = of(getCovariantTypeResolver().resolveType(P_0));
		typeToken.covariantTypeResolver = covariantTypeResolver;
		typeToken.invariantTypeResolver = invariantTypeResolver;
		return typeToken;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("([Ljava/lang/reflect/Type;)Lcom/google/common/collect/ImmutableList<Lcom/google/common/reflect/TypeToken<-TT;>;>;")]
	[LineNumberTable(new byte[] { 160, 253, 102, 144, 105, 110, 233, 60, 230, 71 })]
	private ImmutableList boundsAsInterfaces(java.lang.reflect.Type[] P_0)
	{
		ImmutableList.Builder builder = ImmutableList.builder();
		int num = P_0.Length;
		for (int i = 0; i < num; i++)
		{
			java.lang.reflect.Type type = P_0[i];
			TypeToken typeToken = of(type);
			if (typeToken.getRawType().isInterface())
			{
				builder.add(typeToken);
			}
		}
		ImmutableList result = builder.build();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<*>;)Z")]
	[LineNumberTable(new byte[] { 163, 9, 127, 1, 105, 130, 98 })]
	private bool someRawTypeIsSubclassOf(Class P_0)
	{
		UnmodifiableIterator unmodifiableIterator = getRawTypes().iterator();
		while (((Iterator)unmodifiableIterator).hasNext())
		{
			Class cls = (Class)((Iterator)unmodifiableIterator).next();
			if (P_0.isAssignableFrom(cls))
			{
				return true;
			}
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<-TT;>;[Ljava/lang/reflect/Type;)Lcom/google/common/reflect/TypeToken<-TT;>;")]
	[LineNumberTable(new byte[] { 164, 72, 143, 104, 138, 106, 227, 58, 230, 73 })]
	private TypeToken getSupertypeFromUpperBounds(Class P_0, java.lang.reflect.Type[] P_1)
	{
		int num = P_1.Length;
		for (int i = 0; i < num; i++)
		{
			java.lang.reflect.Type type = P_1[i];
			TypeToken typeToken = of(type);
			if (typeToken.isSubtypeOf(P_0))
			{
				return typeToken.getSupertype(P_0);
			}
		}
		string text = java.lang.String.valueOf(P_0);
		string text2 = java.lang.String.valueOf(this);
		int num2 = 23 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
		num2 = num2;
		string s = new StringBuilder(num2).append(text).append(" isn't a super type of ").append(text2)
			.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new IllegalArgumentException(s);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<-TT;>;)Lcom/google/common/reflect/TypeToken<-TT;>;")]
	[LineNumberTable(new byte[]
	{
		164,
		98,
		135,
		99,
		byte.MaxValue,
		56,
		72,
		98,
		150,
		167,
		108
	})]
	private TypeToken getArraySupertype(Class P_0)
	{
		TypeToken componentType = getComponentType();
		if (componentType == null)
		{
			string text = java.lang.String.valueOf(P_0);
			string text2 = java.lang.String.valueOf(this);
			int num = 23 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
			num = num;
			string s = new StringBuilder(num).append(text).append(" isn't a super type of ").append(text2)
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
		TypeToken supertype = componentType.getSupertype((Class)java.util.Objects.requireNonNull(P_0.getComponentType()));
		return of(newArrayClassOrGenericArrayType(supertype.runtimeType));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Class<TT;>;)Lcom/google/common/reflect/TypeToken<+TT;>;")]
	[LineNumberTable(new byte[]
	{
		164, 28, 104, 161, 15, 198, 103, 130, 135, 117,
		119, 130, 150, 131, 108, 131
	})]
	internal static TypeToken toGenericType(Class P_0)
	{
		if (P_0.isArray())
		{
			java.lang.reflect.Type type = Types.newArrayType(toGenericType(P_0.getComponentType()).runtimeType);
			return of(type);
		}
		TypeVariable[] typeParameters = P_0.getTypeParameters();
		java.lang.reflect.Type type2 = ((!P_0.isMemberClass() || Modifier.isStatic(P_0.getModifiers())) ? null : toGenericType(P_0.getEnclosingClass(TypeToken.___003CGetCallerID_003E())).runtimeType);
		if ((nint)typeParameters.LongLength > 0 || (type2 != null && type2 != P_0.getEnclosingClass(TypeToken.___003CGetCallerID_003E())))
		{
			return of(Types.newParameterizedTypeWithOwner(type2, P_0, typeParameters));
		}
		TypeToken result = of(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<*>;[Ljava/lang/reflect/Type;)Lcom/google/common/reflect/TypeToken<+TT;>;")]
	[LineNumberTable(new byte[] { 164, 85, 133, 137, 138 })]
	private TypeToken getSubtypeFromLowerBounds(Class P_0, java.lang.reflect.Type[] P_1)
	{
		if ((nint)P_1.LongLength > 0)
		{
			TypeToken typeToken = of(P_1[0]);
			TypeToken subtype = typeToken.getSubtype(P_0);
			_ = null;
			return subtype;
		}
		string text = java.lang.String.valueOf(P_0);
		string text2 = java.lang.String.valueOf(this);
		int num = 21 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
		num = num;
		string s = new StringBuilder(num).append(text).append(" isn't a subclass of ").append(text2)
			.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new IllegalArgumentException(s);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(529)]
	public bool isArray()
	{
		return getComponentType() != null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<*>;)Lcom/google/common/reflect/TypeToken<+TT;>;")]
	[LineNumberTable(new byte[] { 164, 120, 103, 99, 223, 56, 97, 151, 167, 108 })]
	private TypeToken getArraySubtype(Class P_0)
	{
		Class componentType = P_0.getComponentType();
		if (componentType == null)
		{
			string text = java.lang.String.valueOf(P_0);
			string text2 = java.lang.String.valueOf(this);
			int num = 36 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
			num = num;
			string s = new StringBuilder(num).append(text).append(" does not appear to be a subtype of ").append(text2)
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
		TypeToken subtype = ((TypeToken)java.util.Objects.requireNonNull(getComponentType())).getSubtype(componentType);
		return of(newArrayClassOrGenericArrayType(subtype.runtimeType));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<*>;)Ljava/lang/reflect/Type;")]
	[LineNumberTable(new byte[]
	{
		164, 141, 110, 105, 141, 226, 73, 135, 98, 112,
		108, 107, 7
	})]
	private java.lang.reflect.Type resolveTypeArgsForSubclass(Class P_0)
	{
		if (runtimeType is Class && (P_0.getTypeParameters().Length == 0 || getRawType().getTypeParameters().Length != 0))
		{
			return P_0;
		}
		TypeToken typeToken = toGenericType(P_0);
		java.lang.reflect.Type formal = typeToken.getSupertype(getRawType()).runtimeType;
		java.lang.reflect.Type result = new TypeResolver().where(formal, runtimeType).resolveType(typeToken.runtimeType);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/reflect/TypeToken<*>;)Z")]
	[LineNumberTable(478)]
	public bool isSubtypeOf(TypeToken type)
	{
		bool result = isSubtypeOf(type.getType());
		_ = null;
		return result;
	}

	public java.lang.reflect.Type getType()
	{
		return runtimeType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 120, 103, 200, 222, 141, 222, 109, 121, 54,
		161, 109, 185, 104, 111, 104, 111, 104, 143
	})]
	public bool isSubtypeOf(java.lang.reflect.Type supertype)
	{
		Preconditions.checkNotNull(supertype);
		if (supertype is WildcardType)
		{
			bool result = any(((WildcardType)supertype).getLowerBounds()).isSupertypeOf(runtimeType);
			_ = null;
			return result;
		}
		if (runtimeType is WildcardType)
		{
			bool result2 = any(((WildcardType)runtimeType).getUpperBounds()).isSubtypeOf(supertype);
			_ = null;
			return result2;
		}
		if (runtimeType is TypeVariable)
		{
			return (java.lang.Object.instancehelper_equals(runtimeType, supertype) || any(((TypeVariable)runtimeType).getBounds()).isSubtypeOf(supertype)) ? true : false;
		}
		if (runtimeType is GenericArrayType)
		{
			bool result3 = of(supertype).isSupertypeOfArray((GenericArrayType)runtimeType);
			_ = null;
			return result3;
		}
		if (supertype is Class)
		{
			bool result4 = someRawTypeIsSubclassOf((Class)supertype);
			_ = null;
			return result4;
		}
		if (supertype is ParameterizedType)
		{
			bool result5 = isSubtypeOfParameterizedType((ParameterizedType)supertype);
			_ = null;
			return result5;
		}
		if (supertype is GenericArrayType)
		{
			bool result6 = isSubtypeOfArrayType((GenericArrayType)supertype);
			_ = null;
			return result6;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1066)]
	private static Bounds any(java.lang.reflect.Type[] P_0)
	{
		Bounds result = new Bounds(P_0, true);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		163, 59, 109, 108, 104, 142, 121, 109, 118, 44,
		161
	})]
	private bool isSupertypeOfArray(GenericArrayType P_0)
	{
		if (runtimeType is Class)
		{
			Class @class = (Class)runtimeType;
			if (!@class.isArray())
			{
				bool result = @class.isAssignableFrom(ClassLiteral<object[]>.Value);
				_ = null;
				return result;
			}
			bool result2 = of(P_0.getGenericComponentType()).isSubtypeOf(@class.getComponentType());
			_ = null;
			return result2;
		}
		if (runtimeType is GenericArrayType)
		{
			bool result3 = of(P_0.getGenericComponentType()).isSubtypeOf(((GenericArrayType)runtimeType).getGenericComponentType());
			_ = null;
			return result3;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		163, 18, 108, 105, 130, 103, 103, 103, 240, 69,
		116, 226, 57, 230, 77, 120, 105, 16
	})]
	private bool isSubtypeOfParameterizedType(ParameterizedType P_0)
	{
		Class rawType = of(P_0).getRawType();
		if (!someRawTypeIsSubclassOf(rawType))
		{
			return false;
		}
		TypeVariable[] typeParameters = rawType.getTypeParameters();
		java.lang.reflect.Type[] actualTypeArguments = P_0.getActualTypeArguments();
		for (int i = 0; i < (nint)typeParameters.LongLength; i++)
		{
			java.lang.reflect.Type type = getCovariantTypeResolver().resolveType(typeParameters[i]);
			if (!of(type).@is(actualTypeArguments[i], typeParameters[i]))
			{
				return false;
			}
		}
		return (Modifier.isStatic(((Class)P_0.getRawType()).getModifiers()) || P_0.getOwnerType() == null || isOwnedBySubtypeOf(P_0.getOwnerType())) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		163, 43, 109, 108, 104, 130, 121, 109, 108, 108,
		44, 161
	})]
	private bool isSubtypeOfArrayType(GenericArrayType P_0)
	{
		if (runtimeType is Class)
		{
			Class @class = (Class)runtimeType;
			if (!@class.isArray())
			{
				return false;
			}
			bool result = of(@class.getComponentType()).isSubtypeOf(P_0.getGenericComponentType());
			_ = null;
			return result;
		}
		if (runtimeType is GenericArrayType)
		{
			GenericArrayType genericArrayType = (GenericArrayType)runtimeType;
			bool result2 = of(genericArrayType.getGenericComponentType()).isSubtypeOf(P_0.getGenericComponentType());
			_ = null;
			return result2;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/reflect/TypeToken<*>;")]
	[LineNumberTable(new byte[] { 161, 211, 108, 99, 130 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public TypeToken getComponentType()
	{
		java.lang.reflect.Type componentType = Types.getComponentType(runtimeType);
		if (componentType == null)
		{
			return null;
		}
		TypeToken result = of(componentType);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(538)]
	public bool isPrimitive()
	{
		return (runtimeType is Class && ((Class)runtimeType).isPrimitive()) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(557)]
	private bool isWrapper()
	{
		bool result = Primitives.allWrapperTypes().contains(runtimeType);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/reflect/Type;Ljava/lang/reflect/TypeVariable<*>;)Z")]
	[LineNumberTable(new byte[] { 163, 100, 110, 130, 104, 237, 70, 121, 59, 161 })]
	private bool @is(java.lang.reflect.Type P_0, TypeVariable P_1)
	{
		if (java.lang.Object.instancehelper_equals(runtimeType, P_0))
		{
			return true;
		}
		if (P_0 is WildcardType)
		{
			WildcardType wildcardType = canonicalizeWildcardType(P_1, (WildcardType)P_0);
			return (every(wildcardType.getUpperBounds()).isSupertypeOf(runtimeType) && every(wildcardType.getLowerBounds()).isSubtypeOf(runtimeType)) ? true : false;
		}
		bool result = java.lang.Object.instancehelper_equals(canonicalizeWildcardsInType(runtimeType), canonicalizeWildcardsInType(P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 251, 127, 1, 103, 113, 130, 98 })]
	private bool isOwnedBySubtypeOf(java.lang.reflect.Type P_0)
	{
		Iterator iterator = getTypes().iterator();
		while (iterator.hasNext())
		{
			TypeToken typeToken = (TypeToken)iterator.next();
			java.lang.reflect.Type ownerTypeIfPresent = typeToken.getOwnerTypeIfPresent();
			if (ownerTypeIfPresent != null && of(ownerTypeIfPresent).isSubtypeOf(P_0))
			{
				return true;
			}
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/reflect/TypeVariable<*>;Ljava/lang/reflect/WildcardType;)Ljava/lang/reflect/WildcardType;")]
	[LineNumberTable(new byte[] { 163, 156, 103, 102, 120, 111, 14, 232, 69 })]
	private static WildcardType canonicalizeWildcardType(TypeVariable P_0, WildcardType P_1)
	{
		java.lang.reflect.Type[] bounds = P_0.getBounds();
		ArrayList arrayList = new ArrayList();
		java.lang.reflect.Type[] upperBounds = P_1.getUpperBounds();
		int num = upperBounds.Length;
		for (int i = 0; i < num; i++)
		{
			java.lang.reflect.Type type = upperBounds[i];
			if (!any(bounds).isSubtypeOf(type))
			{
				((List)arrayList).add((object)canonicalizeWildcardsInType(type));
			}
		}
		Types.WildcardTypeImpl result = new Types.WildcardTypeImpl(P_1.getLowerBounds(), (java.lang.reflect.Type[])((List)arrayList).toArray((object[])new java.lang.reflect.Type[0]));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1061)]
	private static Bounds every(java.lang.reflect.Type[] P_0)
	{
		Bounds result = new Bounds(P_0, false);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 141, 104, 142, 104, 102, 42, 168 })]
	private static java.lang.reflect.Type canonicalizeWildcardsInType(java.lang.reflect.Type P_0)
	{
		if (P_0 is ParameterizedType)
		{
			ParameterizedType result = canonicalizeWildcardsInParameterizedType((ParameterizedType)P_0);
			_ = null;
			return result;
		}
		if (P_0 is GenericArrayType)
		{
			java.lang.reflect.Type result2 = Types.newArrayType(canonicalizeWildcardsInType(((GenericArrayType)P_0).getGenericComponentType()));
			_ = null;
			return result2;
		}
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 168, 108, 103, 103, 103, 46, 166 })]
	private static ParameterizedType canonicalizeWildcardsInParameterizedType(ParameterizedType P_0)
	{
		Class @class = (Class)P_0.getRawType();
		TypeVariable[] typeParameters = @class.getTypeParameters();
		java.lang.reflect.Type[] actualTypeArguments = P_0.getActualTypeArguments();
		for (int i = 0; i < (nint)actualTypeArguments.LongLength; i++)
		{
			actualTypeArguments[i] = canonicalizeTypeArg(typeParameters[i], actualTypeArguments[i]);
		}
		ParameterizedType result = Types.newParameterizedTypeWithOwner(P_0.getOwnerType(), @class, actualTypeArguments);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/reflect/TypeVariable<*>;Ljava/lang/reflect/Type;)Ljava/lang/reflect/Type;")]
	[LineNumberTable(new byte[] { 163, 135, 104, 110, 6 })]
	private static java.lang.reflect.Type canonicalizeTypeArg(TypeVariable P_0, java.lang.reflect.Type P_1)
	{
		java.lang.reflect.Type obj = ((!(P_1 is WildcardType)) ? canonicalizeWildcardsInType(P_1) : canonicalizeWildcardType(P_0, (WildcardType)P_1));
		java.lang.reflect.Type result = ((obj == null) ? null : ((obj as java.lang.reflect.Type) ?? throw new java.lang.IncompatibleClassChangeError()));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 10, 109, 115, 109, 152 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private java.lang.reflect.Type getOwnerTypeIfPresent()
	{
		if (runtimeType is ParameterizedType)
		{
			java.lang.reflect.Type ownerType = ((ParameterizedType)runtimeType).getOwnerType();
			_ = null;
			return ownerType;
		}
		if (runtimeType is Class)
		{
			Class enclosingClass = ((Class)runtimeType).getEnclosingClass(TypeToken.___003CGetCallerID_003E());
			_ = null;
			return enclosingClass;
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<-TT;>;)Lcom/google/common/reflect/TypeToken<-TT;>;")]
	[LineNumberTable(new byte[]
	{
		161, 29, 98, 44, 229, 69, 109, 154, 109, 154,
		104, 170, 98, 112
	})]
	public TypeToken getSupertype(Class superclass)
	{
		Preconditions.checkArgument(someRawTypeIsSubclassOf(superclass), "%s is not a super class of %s", superclass, this);
		if (runtimeType is TypeVariable)
		{
			TypeToken supertypeFromUpperBounds = getSupertypeFromUpperBounds(superclass, ((TypeVariable)runtimeType).getBounds());
			_ = null;
			return supertypeFromUpperBounds;
		}
		if (runtimeType is WildcardType)
		{
			TypeToken supertypeFromUpperBounds2 = getSupertypeFromUpperBounds(superclass, ((WildcardType)runtimeType).getUpperBounds());
			_ = null;
			return supertypeFromUpperBounds2;
		}
		if (superclass.isArray())
		{
			TypeToken arraySupertype = getArraySupertype(superclass);
			_ = null;
			return arraySupertype;
		}
		return resolveSupertype(toGenericType(superclass).runtimeType);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<*>;)Lcom/google/common/reflect/TypeToken<+TT;>;")]
	[LineNumberTable(new byte[]
	{
		161, 55, 156, 109, 186, 104, 170, 97, 50, 133,
		136, 103, 98, 44, 133
	})]
	public TypeToken getSubtype(Class subclass)
	{
		Preconditions.checkArgument(!(runtimeType is TypeVariable), "Cannot get subtype of type variable <%s>", this);
		if (runtimeType is WildcardType)
		{
			TypeToken subtypeFromLowerBounds = getSubtypeFromLowerBounds(subclass, ((WildcardType)runtimeType).getLowerBounds());
			_ = null;
			return subtypeFromLowerBounds;
		}
		if (isArray())
		{
			TypeToken arraySubtype = getArraySubtype(subclass);
			_ = null;
			return arraySubtype;
		}
		Preconditions.checkArgument(getRawType().isAssignableFrom(subclass), "%s isn't a subclass of %s", subclass, this);
		java.lang.reflect.Type type = resolveTypeArgsForSubclass(subclass);
		TypeToken typeToken = of(type);
		Preconditions.checkArgument(typeToken.isSubtypeOf(this), "%s does not appear to be a subtype of %s", typeToken, this);
		return typeToken;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1306)]
	private static java.lang.reflect.Type newArrayClassOrGenericArrayType(java.lang.reflect.Type P_0)
	{
		java.lang.reflect.Type result = Types.JavaVersion.JAVA7.newArrayType(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		74,
		104,
		108,
		byte.MaxValue,
		4,
		72
	})]
	protected internal TypeToken()
	{
		runtimeType = capture();
		Preconditions.checkState(!(runtimeType is TypeVariable), "Cannot construct a TypeToken for a type variable.\nYou probably meant to call new TypeToken<%s>(getClass()) that can resolve the type variable for you.\nIf you do need to create a TypeToken of a type variable, please use TypeToken.of() instead.", runtimeType);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<*>;)V")]
	[LineNumberTable(new byte[] { 105, 104, 103, 104, 137, 146 })]
	protected internal TypeToken(Class declaringClass)
	{
		java.lang.reflect.Type type = capture();
		if (type is Class)
		{
			runtimeType = type;
		}
		else
		{
			runtimeType = TypeResolver.covariantly(declaringClass).resolveType(type);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<X:Ljava/lang/Object;>(Lcom/google/common/reflect/TypeParameter<TX;>;Ljava/lang/Class<TX;>;)Lcom/google/common/reflect/TypeToken<TT;>;")]
	[LineNumberTable(268)]
	public TypeToken where(TypeParameter typeParam, Class typeArg)
	{
		TypeToken result = where(typeParam, of(typeArg));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/reflect/Type;)Lcom/google/common/reflect/TypeToken<*>;")]
	[LineNumberTable(new byte[] { 160, 167, 167 })]
	public TypeToken resolveType(java.lang.reflect.Type type)
	{
		Preconditions.checkNotNull(type);
		TypeToken result = of(getInvariantTypeResolver().resolveType(type));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/reflect/TypeToken<-TT;>;")]
	[LineNumberTable(new byte[] { 160, 195, 141, 155, 141, 155, 108, 99, 162, 104 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal TypeToken getGenericSuperclass()
	{
		if (runtimeType is TypeVariable)
		{
			TypeToken result = boundAsSuperclass(((TypeVariable)runtimeType).getBounds()[0]);
			_ = null;
			return result;
		}
		if (runtimeType is WildcardType)
		{
			TypeToken result2 = boundAsSuperclass(((WildcardType)runtimeType).getUpperBounds()[0]);
			_ = null;
			return result2;
		}
		java.lang.reflect.Type genericSuperclass = getRawType().getGenericSuperclass();
		if (genericSuperclass == null)
		{
			return null;
		}
		return resolveSupertype(genericSuperclass);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableList<Lcom/google/common/reflect/TypeToken<-TT;>;>;")]
	[LineNumberTable(new byte[]
	{
		160, 236, 109, 153, 109, 153, 102, 154, 99, 103,
		233, 60, 230, 70
	})]
	internal ImmutableList getGenericInterfaces()
	{
		if (runtimeType is TypeVariable)
		{
			ImmutableList result = boundsAsInterfaces(((TypeVariable)runtimeType).getBounds());
			_ = null;
			return result;
		}
		if (runtimeType is WildcardType)
		{
			ImmutableList result2 = boundsAsInterfaces(((WildcardType)runtimeType).getUpperBounds());
			_ = null;
			return result2;
		}
		ImmutableList.Builder builder = ImmutableList.builder();
		java.lang.reflect.Type[] genericInterfaces = getRawType().getGenericInterfaces();
		int num = genericInterfaces.Length;
		for (int i = 0; i < num; i++)
		{
			java.lang.reflect.Type type = genericInterfaces[i];
			TypeToken element = resolveSupertype(type);
			builder.add(element);
		}
		ImmutableList result3 = builder.build();
		_ = null;
		return result3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(466)]
	public bool isSupertypeOf(java.lang.reflect.Type type)
	{
		bool result = of(type).isSubtypeOf(getType());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/reflect/TypeToken<TT;>;")]
	[LineNumberTable(new byte[] { 161, 178, 136, 108, 142 })]
	public TypeToken wrap()
	{
		if (isPrimitive())
		{
			Class type = (Class)runtimeType;
			TypeToken result = of(Primitives.wrap(type));
			_ = null;
			return result;
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/reflect/TypeToken<TT;>;")]
	[LineNumberTable(new byte[] { 161, 197, 136, 108, 142 })]
	public TypeToken unwrap()
	{
		if (isWrapper())
		{
			Class type = (Class)runtimeType;
			TypeToken result = of(Primitives.unwrap(type));
			_ = null;
			return result;
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/reflect/Method;)Lcom/google/common/reflect/Invokable<TT;Ljava/lang/Object;>;")]
	[LineNumberTable(new byte[] { 161, 225, 98, 49, 229, 69 })]
	public Invokable method(Method method)
	{
		Preconditions.checkArgument(someRawTypeIsSubclassOf(method.getDeclaringClass()), "%s not declared by %s", method, this);
		_1 result = new _1(this, method);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/reflect/Constructor<*>;)Lcom/google/common/reflect/Invokable<TT;TT;>;")]
	[LineNumberTable(new byte[] { 162, 9, 97, 180, 229, 60, 229, 69 })]
	public Invokable constructor(Constructor constructor)
	{
		Preconditions.checkArgument(constructor.getDeclaringClass() == getRawType(), "%s not declared by %s", constructor, getRawType());
		_2 result = new _2(this, constructor);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(842)]
	public override int hashCode()
	{
		int result = java.lang.Object.instancehelper_hashCode(runtimeType);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(847)]
	public override string toString()
	{
		string result = Types.toString(runtimeType);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(854)]
	protected internal virtual object writeReplace()
	{
		TypeToken result = of(new TypeResolver().resolveType(runtimeType));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(102)]
	internal static ImmutableSet access_0024300(TypeToken P_0)
	{
		ImmutableSet rawTypes = P_0.getRawTypes();
		_ = null;
		return rawTypes;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(102)]
	internal static java.lang.reflect.Type access_0024500(TypeToken P_0)
	{
		return P_0.runtimeType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Synthetic)]
	[LineNumberTable(102)]
	internal TypeToken(java.lang.reflect.Type P_0, _1 P_1)
		: this(P_0)
	{
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
	public static implicit operator Serializable(TypeToken P_0)
	{
		Serializable result = default(Serializable);
		result.___003Cref_003E = P_0;
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
	protected TypeToken(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.readObject(this, P_0);
	}
}
