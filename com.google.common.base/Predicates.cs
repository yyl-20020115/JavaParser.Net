using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;
using java.util.function;
using java.util.regex;
using javax.annotation;

namespace com.google.common.@base;

[ConstantPool(new object[]
{
	(byte)83,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
public sealed class Predicates : java.lang.Object
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
	[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/base/Predicate<TT;>;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 66, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)66,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.base.Predicate", "java.io.Serializable" })]
	internal class AndPredicate : java.lang.Object, Predicate, java.util.function.Predicate, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/List<+Lcom/google/common/base/Predicate<-TT;>;>;")]
		private List components;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(351)]
		internal AndPredicate(List P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/List<+Lcom/google/common/base/Predicate<-TT;>;>;)V")]
		[LineNumberTable(new byte[] { 160, 241, 104, 103 })]
		private AndPredicate(List P_0)
		{
			components = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TT;)Z")]
		[LineNumberTable(new byte[] { 160, 248, 112, 121, 2, 230, 69 })]
		public virtual bool apply([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/base/ParametricNullness;"
		})] object P_0)
		{
			for (int i = 0; i < components.size(); i++)
			{
				if (!((Predicate)components.get(i)).apply(P_0))
				{
					return false;
				}
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(373)]
		public override int hashCode()
		{
			return components.hashCode() + 306654252;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 8, 104, 103, 148 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is AndPredicate)
			{
				AndPredicate andPredicate = (AndPredicate)P_0;
				bool result = components.equals(andPredicate.components);
				_ = null;
				return result;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(387)]
		public override string toString()
		{
			string result = access_0024800("and", components);
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
		protected AndPredicate(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<A:Ljava/lang/Object;B:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/base/Predicate<TA;>;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 76, 0, 0,
		17, 1, 0, 0, 0, 76, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)76,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.base.Predicate", "java.io.Serializable" })]
	internal class CompositionPredicate : java.lang.Object, Predicate, java.util.function.Predicate, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/base/Predicate<TB;>;")]
		internal Predicate p;

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/base/Function<TA;+TB;>;")]
		internal Function f;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(603)]
		internal CompositionPredicate(Predicate P_0, Function P_1, _1 P_2)
			: this(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/base/Predicate<TB;>;Lcom/google/common/base/Function<TA;+TB;>;)V")]
		[LineNumberTable(new byte[] { 161, 238, 104, 113, 113 })]
		private CompositionPredicate(Predicate P_0, Function P_1)
		{
			p = (Predicate)Preconditions.checkNotNull(P_0);
			f = (Function)Preconditions.checkNotNull(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TA;)Z")]
		[LineNumberTable(615)]
		public virtual bool apply([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/base/ParametricNullness;"
		})] object P_0)
		{
			bool result = p.apply(f.apply(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 250, 104, 103, 159, 12 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is CompositionPredicate)
			{
				CompositionPredicate compositionPredicate = (CompositionPredicate)P_0;
				return (f.equals(compositionPredicate.f) && p.equals(compositionPredicate.p)) ? true : false;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(629)]
		public override int hashCode()
		{
			return java.lang.Object.instancehelper_hashCode(f) ^ java.lang.Object.instancehelper_hashCode(p);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(635)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(p);
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
		protected CompositionPredicate(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	internal class ContainsPatternFromStringPredicate : ContainsPatternPredicate
	{
		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 68, 110 })]
		internal ContainsPatternFromStringPredicate(string P_0)
			: base(Platform.compilePattern(P_0))
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(699)]
		public override string toString()
		{
			string text = pattern.pattern();
			int num = 28 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append("Predicates.containsPattern(").append(text).append(")")
				.toString();
			_ = null;
			return result;
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected ContainsPatternFromStringPredicate(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("Ljava/lang/Object;Lcom/google/common/base/Predicate<Ljava/lang/CharSequence;>;Ljava/io/Serializable;")]
	[Implements(new string[] { "com.google.common.base.Predicate", "java.io.Serializable" })]
	internal class ContainsPatternPredicate : java.lang.Object, Predicate, java.util.function.Predicate, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Final)]
		internal CommonPattern pattern;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 20, 104, 113 })]
		internal ContainsPatternPredicate(CommonPattern P_0)
		{
			pattern = (CommonPattern)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(652)]
		public virtual bool apply(CharSequence P_0)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CommonPattern commonPattern = pattern;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			bool result = commonPattern.matcher(charSequence2).find();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(660)]
		public override int hashCode()
		{
			int result = Objects.hashCode(pattern.pattern(), Integer.valueOf(pattern.flags()));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 39, 104, 199, 127, 4, 54, 161 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is ContainsPatternPredicate)
			{
				ContainsPatternPredicate containsPatternPredicate = (ContainsPatternPredicate)P_0;
				return (Objects.equal(pattern.pattern(), containsPatternPredicate.pattern.pattern()) && pattern.flags() == containsPatternPredicate.pattern.flags()) ? true : false;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 52, 102, 112, 117, 106, 102 })]
		public override string toString()
		{
			string text = MoreObjects.toStringHelper(pattern).add("pattern", pattern.pattern()).add("pattern.flags", pattern.flags())
				.toString();
			int num = 21 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append("Predicates.contains(").append(text).append(")")
				.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(642)]
		public virtual bool apply(object P_0)
		{
			CharSequence.Cast(P_0);
			CharSequence charSequence = default(CharSequence);
			object obj = (charSequence.___003Cref_003E = P_0);
			bool result = apply(charSequence);
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
		protected ContainsPatternPredicate(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/base/Predicate<TT;>;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 74, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)74,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.base.Predicate", "java.io.Serializable" })]
	internal class InPredicate : java.lang.Object, Predicate, java.util.function.Predicate, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/Collection<*>;")]
		private Collection target;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(563)]
		internal InPredicate(Collection P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<*>;)V")]
		[LineNumberTable(new byte[] { 161, 197, 104, 113 })]
		private InPredicate(Collection P_0)
		{
			target = (Collection)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TT;)Z")]
		[LineNumberTable(new byte[] { 161, 204, 127, 21, 97 })]
		public virtual bool apply([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/base/ParametricNullness;"
		})] object P_0)
		{
			//Discarded unreachable code: IL_000e
			try
			{
				try
				{
					return target.contains(P_0);
				}
				catch (System.Exception x)
				{
					if (ByteCodeHelper.MapException<NullPointerException>(x, ByteCodeHelper.MapFlags.Unused) == null)
					{
						throw;
					}
				}
			}
			catch (System.Exception x2)
			{
				if (ByteCodeHelper.MapException<ClassCastException>(x2, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0030;
			}
			object obj = null;
			goto IL_0034;
			IL_0030:
			obj = null;
			goto IL_0034;
			IL_0034:
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 212, 104, 103, 148 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is InPredicate)
			{
				InPredicate inPredicate = (InPredicate)P_0;
				bool result = target.equals(inPredicate.target);
				_ = null;
				return result;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(591)]
		public override int hashCode()
		{
			int result = target.hashCode();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(596)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(target);
			int num = 15 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append("Predicates.in(").append(text).append(")")
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
		protected InPredicate(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/base/Predicate<TT;>;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 71, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)71,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.base.Predicate", "java.io.Serializable" })]
	internal class InstanceOfPredicate : java.lang.Object, Predicate, java.util.function.Predicate, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/lang/Class<*>;")]
		private Class clazz;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(491)]
		internal InstanceOfPredicate(Class P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Class<*>;)V")]
		[LineNumberTable(new byte[] { 161, 125, 104, 113 })]
		private InstanceOfPredicate(Class P_0)
		{
			clazz = (Class)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TT;)Z")]
		[LineNumberTable(501)]
		public virtual bool apply([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/base/ParametricNullness;"
		})] object P_0)
		{
			bool result = clazz.isInstance(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(506)]
		public override int hashCode()
		{
			int result = java.lang.Object.instancehelper_hashCode(clazz);
			_ = null;
			return result;
		}

		[LineNumberTable(new byte[] { 161, 141, 104, 103, 143 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is InstanceOfPredicate)
			{
				InstanceOfPredicate instanceOfPredicate = (InstanceOfPredicate)P_0;
				return clazz == instanceOfPredicate.clazz;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(520)]
		public override string toString()
		{
			string name = clazz.getName();
			int num = 23 + java.lang.String.instancehelper_length(java.lang.String.valueOf(name));
			num = num;
			string result = new StringBuilder(num).append("Predicates.instanceOf(").append(name).append(")")
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
		protected InstanceOfPredicate(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("Ljava/lang/Object;Lcom/google/common/base/Predicate<Ljava/lang/Object;>;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 16, 0, 0, 1, 3, 0, 0, 52,
		0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)52,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.base.Predicate", "java.io.Serializable" })]
	internal class IsEqualToPredicate : java.lang.Object, Predicate, java.util.function.Predicate, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private object target;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(450)]
		internal IsEqualToPredicate(object P_0, _1 P_1)
			: this(P_0)
		{
		}

		[Signature("<T:Ljava/lang/Object;>()Lcom/google/common/base/Predicate<TT;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 52, 0, 0 })]
		internal virtual Predicate withNarrowedType()
		{
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 83, 104, 103 })]
		private IsEqualToPredicate(object P_0)
		{
			target = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(459)]
		public virtual bool apply([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = java.lang.Object.instancehelper_equals(target, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(464)]
		public override int hashCode()
		{
			int result = java.lang.Object.instancehelper_hashCode(target);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 99, 104, 103, 148 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is IsEqualToPredicate)
			{
				IsEqualToPredicate isEqualToPredicate = (IsEqualToPredicate)P_0;
				bool result = java.lang.Object.instancehelper_equals(target, isEqualToPredicate.target);
				_ = null;
				return result;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(478)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(target);
			int num = 20 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append("Predicates.equalTo(").append(text).append(")")
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
		protected IsEqualToPredicate(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/base/Predicate<TT;>;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 62, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)62,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.base.Predicate", "java.io.Serializable" })]
	internal class NotPredicate : java.lang.Object, Predicate, java.util.function.Predicate, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/base/Predicate<TT;>;")]
		internal Predicate predicate;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/base/Predicate<TT;>;)V")]
		[LineNumberTable(new byte[] { 160, 205, 104, 113 })]
		internal NotPredicate(Predicate P_0)
		{
			predicate = (Predicate)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TT;)Z")]
		[LineNumberTable(325)]
		public virtual bool apply([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/base/ParametricNullness;"
		})] object P_0)
		{
			return (!predicate.apply(P_0)) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(330)]
		public override int hashCode()
		{
			return java.lang.Object.instancehelper_hashCode(predicate) ^ -1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 221, 104, 103, 148 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is NotPredicate)
			{
				NotPredicate notPredicate = (NotPredicate)P_0;
				bool result = predicate.equals(notPredicate.predicate);
				_ = null;
				return result;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(344)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(predicate);
			int num = 16 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append("Predicates.not(").append(text).append(")")
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
		protected NotPredicate(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Static | Modifiers.Abstract | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/base/Predicates$ObjectPredicate;>;Lcom/google/common/base/Predicate<Ljava/lang/Object;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 16, 0, 0, 1, 3, 0, 0, 54,
		0, 0
	})]
	[Modifiers(Modifiers.Super | Modifiers.Abstract | Modifiers.Enum)]
	[ConstantPool(new object[]
	{
		(byte)54,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.base.Predicate" })]
	internal abstract class ObjectPredicate : java.lang.Enum, Predicate, java.util.function.Predicate
	{
		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		internal sealed class _1 : ObjectPredicate
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(260)]
			internal _1(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			public override bool apply([CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})] object P_0)
			{
				return true;
			}

			public override string toString()
			{
				return "Predicates.alwaysTrue()";
			}

			[HideFromJava]
			static _1()
			{
				ObjectPredicate.___003Cclinit_003E();
			}
		}

		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		internal sealed class _2 : ObjectPredicate
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(272)]
			internal _2(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			public override bool apply([CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})] object P_0)
			{
				return false;
			}

			public override string toString()
			{
				return "Predicates.alwaysFalse()";
			}

			[HideFromJava]
			static _2()
			{
				ObjectPredicate.___003Cclinit_003E();
			}
		}

		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		internal sealed class _3 : ObjectPredicate
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(284)]
			internal _3(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			public override bool apply([CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})] object P_0)
			{
				return P_0 == null;
			}

			public override string toString()
			{
				return "Predicates.isNull()";
			}

			[HideFromJava]
			static _3()
			{
				ObjectPredicate.___003Cclinit_003E();
			}
		}

		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		internal sealed class _4 : ObjectPredicate
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(296)]
			internal _4(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			public override bool apply([CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})] object P_0)
			{
				return P_0 != null;
			}

			public override string toString()
			{
				return "Predicates.notNull()";
			}

			[HideFromJava]
			static _4()
			{
				ObjectPredicate.___003Cclinit_003E();
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static ObjectPredicate ALWAYS_TRUE;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static ObjectPredicate ALWAYS_FALSE;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static ObjectPredicate IS_NULL;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static ObjectPredicate NOT_NULL;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static ObjectPredicate[] _0024VALUES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[Signature("<T:Ljava/lang/Object;>()Lcom/google/common/base/Predicate<TT;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 54, 0, 0 })]
		internal virtual Predicate withNarrowedType()
		{
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(258)]
		private ObjectPredicate(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(258)]
		private static ObjectPredicate[] _0024values()
		{
			return new ObjectPredicate[4] { ALWAYS_TRUE, ALWAYS_FALSE, IS_NULL, NOT_NULL };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(258)]
		public static ObjectPredicate[] values()
		{
			return (ObjectPredicate[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(258)]
		public static ObjectPredicate valueOf(string P_0)
		{
			return (ObjectPredicate)java.lang.Enum.valueOf(ClassLiteral<ObjectPredicate>.Value, P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(258)]
		internal ObjectPredicate(string P_0, int P_1, Predicates._1 P_2)
			: this(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[LineNumberTable(new byte[] { 160, 146, 240, 76, 240, 76, 240, 76, 240, 26 })]
		static ObjectPredicate()
		{
			ALWAYS_TRUE = new _1("ALWAYS_TRUE", 0);
			ALWAYS_FALSE = new _2("ALWAYS_FALSE", 1);
			IS_NULL = new _3("IS_NULL", 2);
			NOT_NULL = new _4("NOT_NULL", 3);
			_0024VALUES = _0024values();
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

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public abstract bool apply(object P_0);

		bool Predicate.Predicate_003A_003Aequals(object P_0)
		{
			return equals(P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/base/Predicate<TT;>;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 66, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)66,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.base.Predicate", "java.io.Serializable" })]
	internal class OrPredicate : java.lang.Object, Predicate, java.util.function.Predicate, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/List<+Lcom/google/common/base/Predicate<-TT;>;>;")]
		private List components;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(394)]
		internal OrPredicate(List P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/List<+Lcom/google/common/base/Predicate<-TT;>;>;)V")]
		[LineNumberTable(new byte[] { 161, 28, 104, 103 })]
		private OrPredicate(List P_0)
		{
			components = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TT;)Z")]
		[LineNumberTable(new byte[] { 161, 35, 112, 121, 2, 230, 69 })]
		public virtual bool apply([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/base/ParametricNullness;"
		})] object P_0)
		{
			for (int i = 0; i < components.size(); i++)
			{
				if (((Predicate)components.get(i)).apply(P_0))
				{
					return true;
				}
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(416)]
		public override int hashCode()
		{
			return components.hashCode() + 87855567;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 51, 104, 103, 148 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is OrPredicate)
			{
				OrPredicate orPredicate = (OrPredicate)P_0;
				bool result = components.equals(orPredicate.components);
				_ = null;
				return result;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(430)]
		public override string toString()
		{
			string result = access_0024800("or", components);
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
		protected OrPredicate(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("Ljava/lang/Object;Lcom/google/common/base/Predicate<Ljava/lang/Class<*>;>;Ljava/io/Serializable;")]
	[Implements(new string[] { "com.google.common.base.Predicate", "java.io.Serializable" })]
	internal class SubtypeOfPredicate : java.lang.Object, Predicate, java.util.function.Predicate, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/lang/Class<*>;")]
		private Class clazz;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(528)]
		internal SubtypeOfPredicate(Class P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Class<*>;)V")]
		[LineNumberTable(new byte[] { 161, 161, 104, 113 })]
		private SubtypeOfPredicate(Class P_0)
		{
			clazz = (Class)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Class<*>;)Z")]
		[LineNumberTable(537)]
		public virtual bool apply(Class P_0)
		{
			bool result = clazz.isAssignableFrom(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(542)]
		public override int hashCode()
		{
			int result = java.lang.Object.instancehelper_hashCode(clazz);
			_ = null;
			return result;
		}

		[LineNumberTable(new byte[] { 161, 177, 104, 103, 143 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is SubtypeOfPredicate)
			{
				SubtypeOfPredicate subtypeOfPredicate = (SubtypeOfPredicate)P_0;
				return clazz == subtypeOfPredicate.clazz;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(556)]
		public override string toString()
		{
			string name = clazz.getName();
			int num = 22 + java.lang.String.instancehelper_length(java.lang.String.valueOf(name));
			num = num;
			string result = new StringBuilder(num).append("Predicates.subtypeOf(").append(name).append(")")
				.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(527)]
		public virtual bool apply(object P_0)
		{
			bool result = apply((Class)P_0);
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
		protected SubtypeOfPredicate(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/String;Ljava/lang/Iterable<*>;)Ljava/lang/String;")]
	[LineNumberTable(new byte[] { 161, 67, 120, 98, 118, 99, 137, 104, 98, 98 })]
	private static string toStringHelper(string P_0, Iterable P_1)
	{
		StringBuilder stringBuilder = new StringBuilder("Predicates.").append(P_0).append('(');
		int num = 1;
		Iterator iterator = P_1.iterator();
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			if (num == 0)
			{
				stringBuilder.append(',');
			}
			stringBuilder.append(obj);
			num = 0;
		}
		string result = stringBuilder.append(')').toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<TT;>;)Ljava/util/List<TT;>;")]
	[LineNumberTable(new byte[] { 162, 90, 102, 118, 109, 98 })]
	internal static List defensiveCopy(Iterable P_0)
	{
		ArrayList arrayList = new ArrayList();
		Iterator iterator = P_0.iterator();
		while (iterator.hasNext())
		{
			object reference = iterator.next();
			arrayList.add(Preconditions.checkNotNull(reference));
		}
		return arrayList;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>([TT;)Ljava/util/List<TT;>;")]
	[LineNumberTable(712)]
	private static List defensiveCopy(params object[] P_0)
	{
		List result = defensiveCopy(Arrays.asList(P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Lcom/google/common/base/Predicate<-TT;>;Lcom/google/common/base/Predicate<-TT;>;)Ljava/util/List<Lcom/google/common/base/Predicate<-TT;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 83, 0, 0 })]
	[LineNumberTable(708)]
	private static List asList(Predicate P_0, Predicate P_1)
	{
		List result = Arrays.asList(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>()Lcom/google/common/base/Predicate<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 83, 0, 0 })]
	[LineNumberTable(68)]
	public static Predicate isNull()
	{
		Predicate result = ObjectPredicate.IS_NULL.withNarrowedType();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(45)]
	private Predicates()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>()Lcom/google/common/base/Predicate<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 83, 0, 0 })]
	[LineNumberTable(53)]
	public static Predicate alwaysTrue()
	{
		Predicate result = ObjectPredicate.ALWAYS_TRUE.withNarrowedType();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>()Lcom/google/common/base/Predicate<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 83, 0, 0 })]
	[LineNumberTable(59)]
	public static Predicate alwaysFalse()
	{
		Predicate result = ObjectPredicate.ALWAYS_FALSE.withNarrowedType();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>()Lcom/google/common/base/Predicate<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 83, 0, 0 })]
	[LineNumberTable(77)]
	public static Predicate notNull()
	{
		Predicate result = ObjectPredicate.NOT_NULL.withNarrowedType();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Lcom/google/common/base/Predicate<TT;>;)Lcom/google/common/base/Predicate<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 83, 0, 0 })]
	[LineNumberTable(85)]
	public static Predicate not(Predicate predicate)
	{
		NotPredicate result = new NotPredicate(predicate);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<+Lcom/google/common/base/Predicate<-TT;>;>;)Lcom/google/common/base/Predicate<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 83, 0, 0 })]
	[LineNumberTable(97)]
	public static Predicate and(Iterable components)
	{
		AndPredicate result = new AndPredicate(defensiveCopy(components), null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>([Lcom/google/common/base/Predicate<-TT;>;)Lcom/google/common/base/Predicate<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 83, 0, 0 })]
	[LineNumberTable(109)]
	[SafeVarargs(new object[]
	{
		(byte)64,
		"Ljava/lang/SafeVarargs;"
	})]
	public static Predicate and(params Predicate[] components)
	{
		AndPredicate result = new AndPredicate(defensiveCopy(components), null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Lcom/google/common/base/Predicate<-TT;>;Lcom/google/common/base/Predicate<-TT;>;)Lcom/google/common/base/Predicate<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 83, 0, 0 })]
	[LineNumberTable(119)]
	public static Predicate and(Predicate first, Predicate second)
	{
		AndPredicate result = new AndPredicate(asList((Predicate)Preconditions.checkNotNull(first), (Predicate)Preconditions.checkNotNull(second)), null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<+Lcom/google/common/base/Predicate<-TT;>;>;)Lcom/google/common/base/Predicate<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 83, 0, 0 })]
	[LineNumberTable(131)]
	public static Predicate or(Iterable components)
	{
		OrPredicate result = new OrPredicate(defensiveCopy(components), null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>([Lcom/google/common/base/Predicate<-TT;>;)Lcom/google/common/base/Predicate<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 83, 0, 0 })]
	[LineNumberTable(143)]
	[SafeVarargs(new object[]
	{
		(byte)64,
		"Ljava/lang/SafeVarargs;"
	})]
	public static Predicate or(params Predicate[] components)
	{
		OrPredicate result = new OrPredicate(defensiveCopy(components), null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Lcom/google/common/base/Predicate<-TT;>;Lcom/google/common/base/Predicate<-TT;>;)Lcom/google/common/base/Predicate<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 83, 0, 0 })]
	[LineNumberTable(153)]
	public static Predicate or(Predicate first, Predicate second)
	{
		OrPredicate result = new OrPredicate(asList((Predicate)Preconditions.checkNotNull(first), (Predicate)Preconditions.checkNotNull(second)), null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;)Lcom/google/common/base/Predicate<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 83, 0, 0 })]
	[LineNumberTable(new byte[] { 111, 99, 103, 14 })]
	public static Predicate equalTo([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/base/ParametricNullness;"
	})] object target)
	{
		Predicate result = ((target != null) ? new IsEqualToPredicate(target, null).withNarrowedType() : isNull());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Class<*>;)Lcom/google/common/base/Predicate<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 83, 0, 0 })]
	[LineNumberTable(181)]
	public static Predicate instanceOf(Class clazz)
	{
		InstanceOfPredicate result = new InstanceOfPredicate(clazz, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<*>;)Lcom/google/common/base/Predicate<Ljava/lang/Class<*>;>;")]
	[LineNumberTable(201)]
	public static Predicate subtypeOf(Class clazz)
	{
		SubtypeOfPredicate result = new SubtypeOfPredicate(clazz, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Collection<+TT;>;)Lcom/google/common/base/Predicate<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 83, 0, 0 })]
	[LineNumberTable(216)]
	public static Predicate @in(Collection target)
	{
		InPredicate result = new InPredicate(target, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<A:Ljava/lang/Object;B:Ljava/lang/Object;>(Lcom/google/common/base/Predicate<TB;>;Lcom/google/common/base/Function<TA;+TB;>;)Lcom/google/common/base/Predicate<TA;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 83, 0, 0,
		18, 1, 0, 0, 0, 83, 0, 0
	})]
	[LineNumberTable(227)]
	public static Predicate compose(Predicate predicate, Function function)
	{
		CompositionPredicate result = new CompositionPredicate(predicate, function, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/String;)Lcom/google/common/base/Predicate<Ljava/lang/CharSequence;>;")]
	[LineNumberTable(240)]
	public static Predicate containsPattern(string pattern)
	{
		ContainsPatternFromStringPredicate result = new ContainsPatternFromStringPredicate(pattern);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/regex/Pattern;)Lcom/google/common/base/Predicate<Ljava/lang/CharSequence;>;")]
	[LineNumberTable(252)]
	public static Predicate contains(Pattern pattern)
	{
		ContainsPatternPredicate result = new ContainsPatternPredicate(new JdkPattern(pattern));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(44)]
	internal static string access_0024800(string P_0, Iterable P_1)
	{
		string result = toStringHelper(P_0, P_1);
		_ = null;
		return result;
	}
}
