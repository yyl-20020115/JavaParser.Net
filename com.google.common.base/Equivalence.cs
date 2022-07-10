using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.util.function;
using javax.annotation;

namespace com.google.common.@base;

[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/function/BiPredicate<TT;TT;>;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 16, 0, 0, 1, 3, 0, 0, 66,
	0, 0, 16, 0, 0, 1, 3, 1, 0, 66,
	0, 0
})]
[ConstantPool(new object[]
{
	(byte)66,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
public abstract class Equivalence : java.lang.Object, BiPredicate
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
	[Signature("Lcom/google/common/base/Equivalence<Ljava/lang/Object;>;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.io.Serializable" })]
	internal new sealed class Equals : Equivalence, Serializable.__Interface, ISerializable, IObjectReference
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static Equals INSTANCE;

		private const long serialVersionUID = 1L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(381)]
		internal Equals()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(387)]
		protected internal override bool doEquivalent(object P_0, object P_1)
		{
			bool result = java.lang.Object.instancehelper_equals(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(392)]
		protected internal override int doHash(object P_0)
		{
			int result = java.lang.Object.instancehelper_hashCode(P_0);
			_ = null;
			return result;
		}

		private object readResolve()
		{
			return INSTANCE;
		}

		[LineNumberTable(383)]
		static Equals()
		{
			INSTANCE = new Equals();
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
		protected Equals(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
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
	[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/base/Predicate<TT;>;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 16, 0, 0, 1, 3, 0, 0, 66,
		0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)66,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.base.Predicate", "java.io.Serializable" })]
	internal sealed class EquivalentToPredicate : java.lang.Object, Predicate, java.util.function.Predicate, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/base/Equivalence<TT;>;")]
		private Equivalence equivalence;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("TT;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private object target;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/base/Equivalence<TT;>;TT;)V")]
		[LineNumberTable(new byte[] { 160, 206, 104, 113, 103 })]
		internal EquivalentToPredicate(Equivalence P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
		{
			equivalence = (Equivalence)Preconditions.checkNotNull(P_0);
			target = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TT;)Z")]
		[LineNumberTable(327)]
		public virtual bool apply([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = equivalence.equivalent(P_0, target);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 218, 100, 130, 104, 103, 159, 12 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (this == P_0)
			{
				return true;
			}
			if (P_0 is EquivalentToPredicate)
			{
				EquivalentToPredicate equivalentToPredicate = (EquivalentToPredicate)P_0;
				return (java.lang.Object.instancehelper_equals(equivalence, equivalentToPredicate.equivalence) && Objects.equal(target, equivalentToPredicate.target)) ? true : false;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(344)]
		public override int hashCode()
		{
			int result = Objects.hashCode(equivalence, target);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(349)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(equivalence);
			string text2 = java.lang.String.valueOf(target);
			int num = 15 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
			num = num;
			string result = new StringBuilder(num).append(text).append(".equivalentTo(").append(text2)
				.append(")")
				.toString();
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual bool test(object P_0)
		{
			return Predicate._003Cdefault_003Etest(this, P_0);
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

		[SecurityCritical]
		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		void ISerializable.GetObjectData(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.writeObject(this, P_0);
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected EquivalentToPredicate(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	[Signature("Lcom/google/common/base/Equivalence<Ljava/lang/Object;>;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.io.Serializable" })]
	internal sealed class Identity : Equivalence, Serializable.__Interface, ISerializable, IObjectReference
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static Identity INSTANCE;

		private const long serialVersionUID = 1L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(402)]
		internal Identity()
		{
		}

		protected internal override bool doEquivalent(object P_0, object P_1)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(413)]
		protected internal override int doHash(object P_0)
		{
			int result = java.lang.System.identityHashCode(P_0);
			_ = null;
			return result;
		}

		private object readResolve()
		{
			return INSTANCE;
		}

		[LineNumberTable(404)]
		static Identity()
		{
			INSTANCE = new Identity();
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
		protected Identity(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}

		[SecurityCritical]
		[HideFromJava]
		object IObjectReference.GetRealObject(StreamingContext P_0)
		{
			return readResolve();
		}
	}

	[Serializable]
	[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 73, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)73,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.io.Serializable" })]
	public sealed class Wrapper : java.lang.Object, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/base/Equivalence<-TT;>;")]
		private Equivalence equivalence;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("TT;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/base/ParametricNullness;"
		})]
		private object reference;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(227)]
		internal Wrapper(Equivalence P_0, object P_1, _1 P_2)
			: this(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/base/Equivalence<-TT;>;TT;)V")]
		[LineNumberTable(new byte[] { 160, 117, 104, 113, 103 })]
		private Wrapper(Equivalence P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/base/ParametricNullness;"
		})] object P_1)
		{
			equivalence = (Equivalence)Preconditions.checkNotNull(P_0);
			reference = P_1;
		}

		[Signature("()TT;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/base/ParametricNullness;"
		})]
		public virtual object get()
		{
			return reference;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 135, 100, 130, 104, 135, 243, 70, 103, 181 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object obj)
		{
			if (obj == this)
			{
				return true;
			}
			if (obj is Wrapper)
			{
				Wrapper wrapper = (Wrapper)obj;
				if (java.lang.Object.instancehelper_equals(this.equivalence, wrapper.equivalence))
				{
					Equivalence equivalence = this.equivalence;
					bool result = equivalence.equivalent(reference, wrapper.reference);
					_ = null;
					return result;
				}
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(271)]
		public override int hashCode()
		{
			int result = equivalence.hash(reference);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(280)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(equivalence);
			string text2 = java.lang.String.valueOf(reference);
			int num = 7 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
			num = num;
			string result = new StringBuilder(num).append(text).append(".wrap(").append(text2)
				.append(")")
				.toString();
			_ = null;
			return result;
		}

		[HideFromJava]
		public static implicit operator Serializable(Wrapper P_0)
		{
			Serializable result = default(Serializable);
			result.___003Cref_003E = P_0;
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
		protected Wrapper(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[Signature("(TT;TT;)Z")]
	protected internal abstract bool doEquivalent(object obj1, object obj2);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TT;TT;)Z")]
	[LineNumberTable(new byte[] { 15, 100, 130, 102, 130 })]
	public bool equivalent([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object a, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object b)
	{
		if (a == b)
		{
			return true;
		}
		if (a == null || b == null)
		{
			return false;
		}
		bool result = doEquivalent(a, b);
		_ = null;
		return result;
	}

	[Signature("(TT;)I")]
	protected internal abstract int doHash(object obj);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(45)]
	protected internal Equivalence()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(TT;TT;)Z")]
	[LineNumberTable(82)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public bool test([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object t, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object u)
	{
		bool result = equivalent(t, u);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TT;)I")]
	[LineNumberTable(new byte[] { 65, 99, 130 })]
	public int hash([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object t)
	{
		if (t == null)
		{
			return 0;
		}
		int result = doHash(t);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<F:Ljava/lang/Object;>(Lcom/google/common/base/Function<-TF;+TT;>;)Lcom/google/common/base/Equivalence<TF;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 0, 2, 3, 1, 2, 0, 0,
		66, 0, 0
	})]
	[LineNumberTable(157)]
	public Equivalence onResultOf(Function function)
	{
		FunctionalEquivalence result = new FunctionalEquivalence(function, this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<S:TT;>(TS;)Lcom/google/common/base/Equivalence$Wrapper<TS;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 66, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 89, 105 })]
	public Wrapper wrap([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/base/ParametricNullness;"
	})] object reference)
	{
		return new Wrapper(this, reference, null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<S:TT;>()Lcom/google/common/base/Equivalence<Ljava/lang/Iterable<TS;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 66, 0, 0 })]
	[LineNumberTable(301)]
	public Equivalence pairwise()
	{
		PairwiseEquivalence result = new PairwiseEquivalence(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TT;)Lcom/google/common/base/Predicate<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 0, 0, 66, 0, 0 })]
	[LineNumberTable(311)]
	public Predicate equivalentTo([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object target)
	{
		EquivalentToPredicate result = new EquivalentToPredicate(this, target);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/base/Equivalence<Ljava/lang/Object;>;")]
	[LineNumberTable(366)]
	public static Equivalence equals()
	{
		return Equals.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/base/Equivalence<Ljava/lang/Object;>;")]
	[LineNumberTable(378)]
	public static Equivalence identity()
	{
		return Identity.INSTANCE;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual BiPredicate and(BiPredicate P_0)
	{
		return BiPredicate._003Cdefault_003Eand(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual BiPredicate negate()
	{
		return BiPredicate._003Cdefault_003Enegate(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual BiPredicate or(BiPredicate P_0)
	{
		return BiPredicate._003Cdefault_003Eor(this, P_0);
	}
}
