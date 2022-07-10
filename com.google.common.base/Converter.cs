using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.errorprone.annotations;
using com.google.errorprone.annotations.concurrent;
using IKVM.Attributes;
using ikvm.@internal;
using ikvm.lang;
using java.io;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.@base;

[Signature("<A:Ljava/lang/Object;B:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/base/Function<TA;TB;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.base.Function" })]
public abstract class Converter : java.lang.Object, Function, java.util.function.Function
{
	[SpecialName]
	[Signature("Ljava/lang/Object;Ljava/lang/Iterable<TB;>;")]
	[EnclosingMethod(null, "convertAll", "(Ljava.lang.Iterable;)Ljava.lang.Iterable;")]
	[Implements(new string[] { "java.lang.Iterable" })]
	internal class _1 : java.lang.Object, Iterable, IEnumerable
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Ljava/lang/Object;Ljava/util/Iterator<TB;>;")]
		[EnclosingMethod(null, "iterator", "()Ljava.util.Iterator;")]
		internal class _1 : java.lang.Object, Iterator
		{
			[Modifiers(Modifiers.Private | Modifiers.Final)]
			[Signature("Ljava/util/Iterator<+TA;>;")]
			private Iterator fromIterator;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Converter._1 this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 160, 166, 111 })]
			internal _1(Converter._1 P_0)
			{
				this_00241 = P_0;
				base._002Ector();
				fromIterator = this_00241.val_0024fromIterable.iterator();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(285)]
			public virtual bool hasNext()
			{
				bool result = fromIterator.hasNext();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()TB;")]
			[LineNumberTable(292)]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			public virtual object next()
			{
				object result = this_00241.this_00240.convert(fromIterator.next());
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 160, 183, 109 })]
			public virtual void remove()
			{
				fromIterator.remove();
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual void forEachRemaining(Consumer P_0)
			{
				Iterator._003Cdefault_003EforEachRemaining(this, P_0);
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Iterable val_0024fromIterable;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Converter this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(277)]
		internal _1(Converter P_0, Iterable P_1)
		{
			this_00240 = P_0;
			val_0024fromIterable = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TB;>;")]
		[LineNumberTable(280)]
		public virtual Iterator iterator()
		{
			_1 result = new _1(this);
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEach(Consumer P_0)
		{
			Iterable._003Cdefault_003EforEach(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Spliterator spliterator()
		{
			return Iterable._003Cdefault_003Espliterator(this);
		}

		[SpecialName]
		[HideFromJava]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new IterableEnumerator(this);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<A:Ljava/lang/Object;B:Ljava/lang/Object;C:Ljava/lang/Object;>Lcom/google/common/base/Converter<TA;TC;>;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.io.Serializable" })]
	internal sealed class ConverterComposition : Converter, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/base/Converter<TA;TB;>;")]
		internal Converter first;

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/base/Converter<TB;TC;>;")]
		internal Converter second;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/base/Converter<TA;TB;>;Lcom/google/common/base/Converter<TB;TC;>;)V")]
		[LineNumberTable(new byte[] { 161, 33, 104, 103, 103 })]
		internal ConverterComposition(Converter P_0, Converter P_1)
		{
			first = P_0;
			second = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TA;)TC;")]
		[LineNumberTable(417)]
		protected internal override object doForward(object P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TC;)TA;")]
		[LineNumberTable(422)]
		protected internal override object doBackward(object P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TA;)TC;")]
		[LineNumberTable(428)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal override object correctedDoForward([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			object result = second.correctedDoForward(first.correctedDoForward(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TC;)TA;")]
		[LineNumberTable(434)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal override object correctedDoBackward([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			object result = first.correctedDoBackward(second.correctedDoBackward(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 69, 104, 103, 159, 12 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is ConverterComposition)
			{
				ConverterComposition converterComposition = (ConverterComposition)P_0;
				return (first.equals(converterComposition.first) && second.equals(converterComposition.second)) ? true : false;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(448)]
		public override int hashCode()
		{
			return 31 * java.lang.Object.instancehelper_hashCode(first) + java.lang.Object.instancehelper_hashCode(second);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(453)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(first);
			string text2 = java.lang.String.valueOf(second);
			int num = 10 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
			num = num;
			string result = new StringBuilder(num).append(text).append(".andThen(").append(text2)
				.append(")")
				.toString();
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
		protected ConverterComposition(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<A:Ljava/lang/Object;B:Ljava/lang/Object;>Lcom/google/common/base/Converter<TA;TB;>;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.io.Serializable" })]
	internal sealed class FunctionBasedConverter : Converter, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/base/Function<-TA;+TB;>;")]
		private Function forwardFunction;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/base/Function<-TB;+TA;>;")]
		private Function backwardFunction;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(540)]
		internal FunctionBasedConverter(Function P_0, Function P_1, _1 P_2)
			: this(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/base/Function<-TA;+TB;>;Lcom/google/common/base/Function<-TB;+TA;>;)V")]
		[LineNumberTable(new byte[] { 161, 177, 104, 113, 113 })]
		private FunctionBasedConverter(Function P_0, Function P_1)
		{
			forwardFunction = (Function)Preconditions.checkNotNull(P_0);
			backwardFunction = (Function)Preconditions.checkNotNull(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TA;)TB;")]
		[LineNumberTable(554)]
		protected internal override object doForward(object P_0)
		{
			object result = forwardFunction.apply(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TB;)TA;")]
		[LineNumberTable(559)]
		protected internal override object doBackward(object P_0)
		{
			object result = backwardFunction.apply(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 194, 104, 103, 127, 0, 43, 161 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is FunctionBasedConverter)
			{
				FunctionBasedConverter functionBasedConverter = (FunctionBasedConverter)P_0;
				return (forwardFunction.equals(functionBasedConverter.forwardFunction) && backwardFunction.equals(functionBasedConverter.backwardFunction)) ? true : false;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(574)]
		public override int hashCode()
		{
			return java.lang.Object.instancehelper_hashCode(forwardFunction) * 31 + java.lang.Object.instancehelper_hashCode(backwardFunction);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(579)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(forwardFunction);
			string text2 = java.lang.String.valueOf(backwardFunction);
			int num = 18 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
			num = num;
			string result = new StringBuilder(num).append("Converter.from(").append(text).append(", ")
				.append(text2)
				.append(")")
				.toString();
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
		protected FunctionBasedConverter(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<T:Ljava/lang/Object;>Lcom/google/common/base/Converter<TT;TT;>;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.io.Serializable" })]
	internal sealed class IdentityConverter : Converter, Serializable.__Interface, ISerializable, IObjectReference
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		[Signature("Lcom/google/common/base/Converter$IdentityConverter<*>;")]
		internal static IdentityConverter INSTANCE;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[Signature("()Lcom/google/common/base/Converter$IdentityConverter<TT;>;")]
		public new virtual IdentityConverter reverse()
		{
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(593)]
		private IdentityConverter()
		{
		}

		[Signature("(TT;)TT;")]
		protected internal override object doForward(object P_0)
		{
			return P_0;
		}

		[Signature("(TT;)TT;")]
		protected internal override object doBackward(object P_0)
		{
			return P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<S:Ljava/lang/Object;>(Lcom/google/common/base/Converter<TT;TS;>;)Lcom/google/common/base/Converter<TT;TS;>;")]
		[LineNumberTable(613)]
		internal override Converter doAndThen(Converter P_0)
		{
			return (Converter)Preconditions.checkNotNull((object)P_0, (object)"otherConverter");
		}

		public override string toString()
		{
			return "Converter.identity()";
		}

		private object readResolve()
		{
			return INSTANCE;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(593)]
		public override Converter reverse()
		{
			IdentityConverter result = reverse();
			_ = null;
			return result;
		}

		[LineNumberTable(594)]
		static IdentityConverter()
		{
			INSTANCE = new IdentityConverter();
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
		protected IdentityConverter(SerializationInfo P_0, StreamingContext P_1)
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
	[Signature("<A:Ljava/lang/Object;B:Ljava/lang/Object;>Lcom/google/common/base/Converter<TB;TA;>;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.io.Serializable" })]
	internal sealed class ReverseConverter : Converter, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/base/Converter<TA;TB;>;")]
		internal Converter original;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/base/Converter<TA;TB;>;)V")]
		[LineNumberTable(new byte[] { 160, 208, 104, 103 })]
		internal ReverseConverter(Converter P_0)
		{
			original = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TB;)TA;")]
		[LineNumberTable(335)]
		protected internal override object doForward(object P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TA;)TB;")]
		[LineNumberTable(340)]
		protected internal override object doBackward(object P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TB;)TA;")]
		[LineNumberTable(346)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal override object correctedDoForward([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			object result = original.correctedDoBackward(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TA;)TB;")]
		[LineNumberTable(352)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal override object correctedDoBackward([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			object result = original.correctedDoForward(P_0);
			_ = null;
			return result;
		}

		[Signature("()Lcom/google/common/base/Converter<TA;TB;>;")]
		public override Converter reverse()
		{
			return original;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 248, 104, 103, 148 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is ReverseConverter)
			{
				ReverseConverter reverseConverter = (ReverseConverter)P_0;
				bool result = original.equals(reverseConverter.original);
				_ = null;
				return result;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(371)]
		public override int hashCode()
		{
			return java.lang.Object.instancehelper_hashCode(original) ^ -1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(376)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(original);
			int num = 10 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append(text).append(".reverse()").toString();
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
		protected ReverseConverter(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private bool handleNullAutomatically;

	[NonSerialized]
	[Signature("Lcom/google/common/base/Converter<TB;TA;>;")]
	[LazyInit(new object[]
	{
		(byte)64,
		"Lcom/google/errorprone/annotations/concurrent/LazyInit;"
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private Converter m_reverse;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 103, 66, 104, 103 })]
	internal Converter(bool P_0)
	{
		handleNullAutomatically = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TA;)TB;")]
	[LineNumberTable(new byte[] { 160, 88, 136, 149 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal virtual object correctedDoForward([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		if (!handleNullAutomatically)
		{
			object result = unsafeDoForward(P_0);
			_ = null;
			return result;
		}
		object result2 = ((P_0 != null) ? Preconditions.checkNotNull(doForward(P_0)) : null);
		_ = null;
		return result2;
	}

	[Signature("(TA;)TB;")]
	protected internal abstract object doForward(object obj);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TA;)TB;")]
	[LineNumberTable(248)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private object unsafeDoForward([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		object result = doForward(NullnessCasts.uncheckedCastNullableTToT(P_0));
		_ = null;
		return result;
	}

	[Signature("(TB;)TA;")]
	protected internal abstract object doBackward(object obj);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TB;)TA;")]
	[LineNumberTable(253)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private object unsafeDoBackward([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		object result = doBackward(NullnessCasts.uncheckedCastNullableTToT(P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<C:Ljava/lang/Object;>(Lcom/google/common/base/Converter<TB;TC;>;)Lcom/google/common/base/Converter<TA;TC;>;")]
	[LineNumberTable(395)]
	internal virtual Converter doAndThen(Converter P_0)
	{
		ConverterComposition result = new ConverterComposition(this, (Converter)Preconditions.checkNotNull(P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TA;)TB;")]
	[LineNumberTable(197)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public object convert([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object a)
	{
		object result = correctedDoForward(a);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 102, 105 })]
	protected internal Converter()
		: this(true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TB;)TA;")]
	[LineNumberTable(new byte[] { 160, 98, 136, 149 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal virtual object correctedDoBackward([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		if (!handleNullAutomatically)
		{
			object result = unsafeDoBackward(P_0);
			_ = null;
			return result;
		}
		object result2 = ((P_0 != null) ? Preconditions.checkNotNull(doBackward(P_0)) : null);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<+TA;>;)Ljava/lang/Iterable<TB;>;")]
	[LineNumberTable(new byte[] { 160, 162, 108 })]
	public virtual Iterable convertAll(Iterable fromIterable)
	{
		Preconditions.checkNotNull((object)fromIterable, (object)"fromIterable");
		_1 result = new _1(this, fromIterable);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/base/Converter<TB;TA;>;")]
	[LineNumberTable(new byte[] { 160, 200, 103 })]
	[com.google.errorprone.annotations.CheckReturnValue(new object[]
	{
		(byte)64,
		"Lcom/google/errorprone/annotations/CheckReturnValue;"
	})]
	public virtual Converter reverse()
	{
		Converter converter = this.m_reverse;
		object result;
		if (converter == null)
		{
			ReverseConverter reverseConverter = new ReverseConverter(this);
			result = reverseConverter;
			this.m_reverse = reverseConverter;
		}
		else
		{
			result = converter;
		}
		return (Converter)result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<C:Ljava/lang/Object;>(Lcom/google/common/base/Converter<TB;TC;>;)Lcom/google/common/base/Converter<TA;TC;>;")]
	[LineNumberTable(390)]
	public Converter andThen(Converter secondConverter)
	{
		Converter result = doAndThen(secondConverter);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(TA;)TB;")]
	[LineNumberTable(499)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public object apply([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object a)
	{
		object result = convert(a);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(515)]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object @object)
	{
		bool result = base.equals(@object);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<A:Ljava/lang/Object;B:Ljava/lang/Object;>(Lcom/google/common/base/Function<-TA;+TB;>;Lcom/google/common/base/Function<-TB;+TA;>;)Lcom/google/common/base/Converter<TA;TB;>;")]
	[LineNumberTable(537)]
	public static Converter from(Function forwardFunction, Function backwardFunction)
	{
		FunctionBasedConverter result = new FunctionBasedConverter(forwardFunction, backwardFunction, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>()Lcom/google/common/base/Converter<TT;TT;>;")]
	[LineNumberTable(586)]
	public static Converter identity()
	{
		return IdentityConverter.INSTANCE;
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
}
