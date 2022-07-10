using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.nio.charset;
using java.util;
using javax.annotation;

namespace com.google.common.hash;

[ConstantPool(new object[]
{
	(byte)54,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/hash/ElementTypesAreNonnullByDefault;"
})]
public sealed class Funnels : java.lang.Object
{
	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/hash/Funnels$ByteArrayFunnel;>;Lcom/google/common/hash/Funnel<[B>;")]
	[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	[Implements(new string[] { "com.google.common.hash.Funnel" })]
	internal sealed class ByteArrayFunnel : java.lang.Enum, Funnel, Serializable.__Interface
	{
		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static ByteArrayFunnel INSTANCE;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static ByteArrayFunnel[] _0024VALUES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 159, 188, 104 })]
		public virtual void funnel(byte[] P_0, PrimitiveSink P_1)
		{
			P_1.putBytes(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(41)]
		private ByteArrayFunnel(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(41)]
		private static ByteArrayFunnel[] _0024values()
		{
			return new ByteArrayFunnel[1] { INSTANCE };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(41)]
		public static ByteArrayFunnel[] values()
		{
			return (ByteArrayFunnel[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(41)]
		public static ByteArrayFunnel valueOf(string P_0)
		{
			return (ByteArrayFunnel)java.lang.Enum.valueOf(ClassLiteral<ByteArrayFunnel>.Value, P_0);
		}

		public override string toString()
		{
			return "Funnels.byteArrayFunnel()";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(41)]
		public virtual void funnel(object P_0, PrimitiveSink P_1)
		{
			funnel((byte[])P_0, P_1);
		}

		[LineNumberTable(new byte[] { 159, 184, 48 })]
		static ByteArrayFunnel()
		{
			INSTANCE = new ByteArrayFunnel("INSTANCE", 0);
			_0024VALUES = _0024values();
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/hash/Funnels$IntegerFunnel;>;Lcom/google/common/hash/Funnel<Ljava/lang/Integer;>;")]
	[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	[Implements(new string[] { "com.google.common.hash.Funnel" })]
	internal sealed class IntegerFunnel : java.lang.Enum, Funnel, Serializable.__Interface
	{
		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static IntegerFunnel INSTANCE;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static IntegerFunnel[] _0024VALUES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 104, 109 })]
		public virtual void funnel(Integer P_0, PrimitiveSink P_1)
		{
			P_1.putInt(P_0.intValue());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(149)]
		private IntegerFunnel(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(149)]
		private static IntegerFunnel[] _0024values()
		{
			return new IntegerFunnel[1] { INSTANCE };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(149)]
		public static IntegerFunnel[] values()
		{
			return (IntegerFunnel[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(149)]
		public static IntegerFunnel valueOf(string P_0)
		{
			return (IntegerFunnel)java.lang.Enum.valueOf(ClassLiteral<IntegerFunnel>.Value, P_0);
		}

		public override string toString()
		{
			return "Funnels.integerFunnel()";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(149)]
		public virtual void funnel(object P_0, PrimitiveSink P_1)
		{
			funnel((Integer)P_0, P_1);
		}

		[LineNumberTable(new byte[] { 100, 48 })]
		static IntegerFunnel()
		{
			INSTANCE = new IntegerFunnel("INSTANCE", 0);
			_0024VALUES = _0024values();
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/hash/Funnels$LongFunnel;>;Lcom/google/common/hash/Funnel<Ljava/lang/Long;>;")]
	[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	[Implements(new string[] { "com.google.common.hash.Funnel" })]
	internal sealed class LongFunnel : java.lang.Enum, Funnel, Serializable.__Interface
	{
		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static LongFunnel INSTANCE;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static LongFunnel[] _0024VALUES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 109, 109 })]
		public virtual void funnel(Long P_0, PrimitiveSink P_1)
		{
			P_1.putLong(P_0.longValue());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(218)]
		private LongFunnel(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(218)]
		private static LongFunnel[] _0024values()
		{
			return new LongFunnel[1] { INSTANCE };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(218)]
		public static LongFunnel[] values()
		{
			return (LongFunnel[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(218)]
		public static LongFunnel valueOf(string P_0)
		{
			return (LongFunnel)java.lang.Enum.valueOf(ClassLiteral<LongFunnel>.Value, P_0);
		}

		public override string toString()
		{
			return "Funnels.longFunnel()";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(218)]
		public virtual void funnel(object P_0, PrimitiveSink P_1)
		{
			funnel((Long)P_0, P_1);
		}

		[LineNumberTable(new byte[] { 160, 105, 48 })]
		static LongFunnel()
		{
			INSTANCE = new LongFunnel("INSTANCE", 0);
			_0024VALUES = _0024values();
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<E:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/hash/Funnel<Ljava/lang/Iterable<+TE;>;>;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 68, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)68,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.hash.Funnel", "java.io.Serializable" })]
	internal class SequentialFunnel : java.lang.Object, Funnel, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/hash/Funnel<TE;>;")]
		private Funnel elementFunnel;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/hash/Funnel<TE;>;)V")]
		[LineNumberTable(new byte[] { 160, 64, 104, 113 })]
		internal SequentialFunnel(Funnel P_0)
		{
			elementFunnel = (Funnel)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Iterable<+TE;>;Lcom/google/common/hash/PrimitiveSink;)V")]
		[LineNumberTable(new byte[] { 160, 70, 118, 109, 98 })]
		public virtual void funnel(Iterable P_0, PrimitiveSink P_1)
		{
			Iterator iterator = P_0.iterator();
			while (iterator.hasNext())
			{
				object obj = iterator.next();
				elementFunnel.funnel(obj, P_1);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(191)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(elementFunnel);
			int num = 26 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append("Funnels.sequentialFunnel(").append(text).append(")")
				.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 82, 104, 103, 148 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is SequentialFunnel)
			{
				SequentialFunnel sequentialFunnel = (SequentialFunnel)P_0;
				bool result = java.lang.Object.instancehelper_equals(elementFunnel, sequentialFunnel.elementFunnel);
				_ = null;
				return result;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(205)]
		public override int hashCode()
		{
			return java.lang.Object.instancehelper_hashCode(ClassLiteral<SequentialFunnel>.Value) ^ java.lang.Object.instancehelper_hashCode(elementFunnel);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(174)]
		public virtual void funnel(object P_0, PrimitiveSink P_1)
		{
			funnel((Iterable)P_0, P_1);
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
		protected SequentialFunnel(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	internal class SinkAsStream : OutputStream
	{
		[Modifiers(Modifiers.Final)]
		internal PrimitiveSink sink;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 135, 104, 113 })]
		internal SinkAsStream(PrimitiveSink P_0)
		{
			sink = (PrimitiveSink)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 141, 110 })]
		public override void write(int P_0)
		{
			sink.putByte((byte)(sbyte)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 146, 109 })]
		public override void write(byte[] P_0)
		{
			sink.putBytes(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 151, 111 })]
		public override void write(byte[] P_0, int P_1, int P_2)
		{
			sink.putBytes(P_0, P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(270)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(sink);
			int num = 24 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append("Funnels.asOutputStream(").append(text).append(")")
				.toString();
			_ = null;
			return result;
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("Ljava/lang/Object;Lcom/google/common/hash/Funnel<Ljava/lang/CharSequence;>;Ljava/io/Serializable;")]
	[Implements(new string[] { "com.google.common.hash.Funnel", "java.io.Serializable" })]
	internal class StringCharsetFunnel : java.lang.Object, Funnel, Serializable.__Interface, ISerializable
	{
		[Serializable]
		[InnerClass(null, Modifiers.Private | Modifiers.Static)]
		[Implements(new string[] { "java.io.Serializable" })]
		internal class SerializedForm : java.lang.Object, Serializable.__Interface, ISerializable, IObjectReference
		{
			[Modifiers(Modifiers.Private | Modifiers.Final)]
			private string charsetCanonicalName;

			private const long serialVersionUID = 0L;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 78, 104, 108 })]
			internal SerializedForm(Charset P_0)
			{
				charsetCanonicalName = P_0.name();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(133)]
			private object readResolve()
			{
				Funnel result = stringFunnel(Charset.forName(charsetCanonicalName));
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
			protected SerializedForm(SerializationInfo P_0, StreamingContext P_1)
			{
				Serialization.readObject(this, P_0);
			}

			[SecurityCritical]
			[HideFromJava]
			object IObjectReference.GetRealObject(StreamingContext P_0)
			{
				if (((object)this).GetType() != typeof(SerializedForm))
				{
					return this;
				}
				return readResolve();
			}
		}

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private Charset charset;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 43, 104, 113 })]
		internal StringCharsetFunnel(Charset P_0)
		{
			charset = (Charset)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 159, 118, 170, 127, 1 })]
		public virtual void funnel(CharSequence P_0, PrimitiveSink P_1)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			Charset c = charset;
			CharSequence cs = default(CharSequence);
			object obj = (cs.___003Cref_003E = __003Cref_003E);
			P_1.putString(cs, c);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(104)]
		public override string toString()
		{
			string text = charset.name();
			int num = 22 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append("Funnels.stringFunnel(").append(text).append(")")
				.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 59, 104, 103, 148 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is StringCharsetFunnel)
			{
				StringCharsetFunnel stringCharsetFunnel = (StringCharsetFunnel)P_0;
				bool result = charset.equals(stringCharsetFunnel.charset);
				_ = null;
				return result;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(118)]
		public override int hashCode()
		{
			return java.lang.Object.instancehelper_hashCode(ClassLiteral<StringCharsetFunnel>.Value) ^ charset.hashCode();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(122)]
		internal virtual object writeReplace()
		{
			SerializedForm result = new SerializedForm(charset);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(90)]
		public virtual void funnel(object P_0, PrimitiveSink P_1)
		{
			CharSequence.Cast(P_0);
			CharSequence charSequence = default(CharSequence);
			object obj = (charSequence.___003Cref_003E = P_0);
			funnel(charSequence, P_1);
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
		protected StringCharsetFunnel(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/hash/Funnels$UnencodedCharsFunnel;>;Lcom/google/common/hash/Funnel<Ljava/lang/CharSequence;>;")]
	[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	[Implements(new string[] { "com.google.common.hash.Funnel" })]
	internal sealed class UnencodedCharsFunnel : java.lang.Enum, Funnel, Serializable.__Interface
	{
		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static UnencodedCharsFunnel INSTANCE;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static UnencodedCharsFunnel[] _0024VALUES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 159, 125, 170, 120 })]
		public virtual void funnel(CharSequence P_0, PrimitiveSink P_1)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CharSequence cs = default(CharSequence);
			object obj = (cs.___003Cref_003E = __003Cref_003E);
			P_1.putUnencodedChars(cs);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(66)]
		private UnencodedCharsFunnel(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(66)]
		private static UnencodedCharsFunnel[] _0024values()
		{
			return new UnencodedCharsFunnel[1] { INSTANCE };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(66)]
		public static UnencodedCharsFunnel[] values()
		{
			return (UnencodedCharsFunnel[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(66)]
		public static UnencodedCharsFunnel valueOf(string P_0)
		{
			return (UnencodedCharsFunnel)java.lang.Enum.valueOf(ClassLiteral<UnencodedCharsFunnel>.Value, P_0);
		}

		public override string toString()
		{
			return "Funnels.unencodedCharsFunnel()";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(66)]
		public virtual void funnel(object P_0, PrimitiveSink P_1)
		{
			CharSequence.Cast(P_0);
			CharSequence charSequence = default(CharSequence);
			object obj = (charSequence.___003Cref_003E = P_0);
			funnel(charSequence, P_1);
		}

		[LineNumberTable(new byte[] { 17, 48 })]
		static UnencodedCharsFunnel()
		{
			INSTANCE = new UnencodedCharsFunnel("INSTANCE", 0);
			_0024VALUES = _0024values();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(34)]
	private Funnels()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/hash/Funnel<[B>;")]
	[LineNumberTable(38)]
	public static Funnel byteArrayFunnel()
	{
		return ByteArrayFunnel.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/hash/Funnel<Ljava/lang/CharSequence;>;")]
	[LineNumberTable(63)]
	public static Funnel unencodedCharsFunnel()
	{
		return UnencodedCharsFunnel.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/nio/charset/Charset;)Lcom/google/common/hash/Funnel<Ljava/lang/CharSequence;>;")]
	[LineNumberTable(87)]
	public static Funnel stringFunnel(Charset charset)
	{
		StringCharsetFunnel result = new StringCharsetFunnel(charset);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/hash/Funnel<Ljava/lang/Integer;>;")]
	[LineNumberTable(146)]
	public static Funnel integerFunnel()
	{
		return IntegerFunnel.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Lcom/google/common/hash/Funnel<TE;>;)Lcom/google/common/hash/Funnel<Ljava/lang/Iterable<+TE;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 54, 0, 0 })]
	[LineNumberTable(171)]
	public static Funnel sequentialFunnel(Funnel elementFunnel)
	{
		SequentialFunnel result = new SequentialFunnel(elementFunnel);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/hash/Funnel<Ljava/lang/Long;>;")]
	[LineNumberTable(215)]
	public static Funnel longFunnel()
	{
		return LongFunnel.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(243)]
	public static OutputStream asOutputStream(PrimitiveSink sink)
	{
		SinkAsStream result = new SinkAsStream(sink);
		_ = null;
		return result;
	}
}
