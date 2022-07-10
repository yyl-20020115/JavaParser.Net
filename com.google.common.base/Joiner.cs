using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.@base;

[ConstantPool(new object[]
{
	(byte)73,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
public class Joiner : Object
{
	[SpecialName]
	[EnclosingMethod(null, "useForNull", "(Ljava.lang.String;)Lcom.google.common.base.Joiner;")]
	internal class _1 : Joiner
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal string val_0024nullText;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Joiner this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(241)]
		internal _1(Joiner P_0, Joiner P_1, string P_2)
		{
			this_00240 = P_0;
			val_0024nullText = P_2;
			base._002Ector(P_1, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(244)]
		internal override CharSequence toString([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			CharSequence charSequence = default(CharSequence);
			object obj = (charSequence.___003Cref_003E = ((P_0 != null) ? this_00240.toString(P_0).___003Cref_003E : val_0024nullText));
			CharSequence result = charSequence;
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(249)]
		public override Joiner useForNull(string P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException("already specified useForNull");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(254)]
		public override Joiner skipNulls()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException("already specified useForNull");
		}
	}

	[SpecialName]
	[EnclosingMethod(null, "skipNulls", "()Lcom.google.common.base.Joiner;")]
	[ConstantPool(new object[]
	{
		(byte)45,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class _2 : Joiner
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Joiner this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(264)]
		internal _2(Joiner P_0, Joiner P_1)
		{
			this_00240 = P_0;
			base._002Ector(P_1, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[Signature("<A::Ljava/lang/Appendable;>(TA;Ljava/util/Iterator<+Ljava/lang/Object;>;)TA;")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 1, 22, 1, 2, 3, 0, 2, 0, 0,
			45, 0, 0
		})]
		[LineNumberTable(new byte[]
		{
			160, 154, 108, 108, 104, 103, 99, 127, 12, 130,
			98, 107, 103, 99, 127, 3, 159, 13, 101
		})]
		public override Appendable appendTo(Appendable P_0, Iterator P_1)
		{
			Preconditions.checkNotNull((object)P_0, (object)"appendable");
			Preconditions.checkNotNull((object)P_1, (object)"parts");
			CharSequence csq = default(CharSequence);
			while (P_1.hasNext())
			{
				object obj = P_1.next();
				if (obj != null)
				{
					object obj2 = (csq.___003Cref_003E = this_00240.toString(obj).___003Cref_003E);
					P_0.append(csq);
					break;
				}
			}
			while (P_1.hasNext())
			{
				object obj = P_1.next();
				if (obj != null)
				{
					object obj2 = (csq.___003Cref_003E = access_0024100(this_00240));
					P_0.append(csq);
					obj2 = (csq.___003Cref_003E = this_00240.toString(obj).___003Cref_003E);
					P_0.append(csq);
				}
			}
			return P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(289)]
		public override Joiner useForNull(string P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException("already specified skipNulls");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(294)]
		public override MapJoiner withKeyValueSeparator(string P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException("can't use .skipNulls() with maps");
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/util/AbstractList<Ljava/lang/Object;>;")]
	[EnclosingMethod(null, "iterable", "(Ljava.lang.Object;Ljava.lang.Object;[Ljava.lang.Object;)Ljava.lang.Iterable;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0,
		1,
		16,
		byte.MaxValue,
		byte.MaxValue,
		1,
		3,
		0,
		0,
		34,
		0,
		0
	})]
	[ConstantPool(new object[]
	{
		(byte)34,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class _3 : AbstractList
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal object[] val_0024rest;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal object val_0024first;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal object val_0024second;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(498)]
		internal _3(object[] P_0, object P_1, object P_2)
		{
			val_0024rest = P_0;
			val_0024first = P_1;
			val_0024second = P_2;
			base._002Ector();
		}

		[LineNumberTable(501)]
		public override int size()
		{
			return (int)((nint)val_0024rest.LongLength + 2);
		}

		[LineNumberTable(new byte[] { 161, 137, 146, 135, 135 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override object get(int P_0)
		{
			return P_0 switch
			{
				0 => val_0024first, 
				1 => val_0024second, 
				_ => val_0024rest[P_0 - 2], 
			};
		}
	}

	public sealed class MapJoiner : Object
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private Joiner joiner;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private string keyValueSeparator;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(335)]
		internal MapJoiner(Joiner P_0, string P_1, _1 P_2)
			: this(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 225, 104, 103, 113 })]
		private MapJoiner(Joiner P_0, string P_1)
		{
			joiner = P_0;
			keyValueSeparator = (string)Preconditions.checkNotNull(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[Signature("<A::Ljava/lang/Appendable;>(TA;Ljava/lang/Iterable<+Ljava/util/Map$Entry<**>;>;)TA;")]
		[LineNumberTable(373)]
		public virtual Appendable appendTo(Appendable appendable, Iterable entries)
		{
			Appendable result = appendTo(appendable, entries.iterator());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/StringBuilder;Ljava/lang/Iterable<+Ljava/util/Map$Entry<**>;>;)Ljava/lang/StringBuilder;")]
		[LineNumberTable(413)]
		public virtual StringBuilder appendTo(StringBuilder builder, Iterable entries)
		{
			StringBuilder result = appendTo(builder, entries.iterator());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[Signature("<A::Ljava/lang/Appendable;>(TA;Ljava/util/Iterator<+Ljava/util/Map$Entry<**>;>;)TA;")]
		[LineNumberTable(new byte[]
		{
			161, 16, 103, 107, 108, 127, 17, 125, 127, 18,
			107, 127, 3, 109, 127, 19, 125, 127, 19, 133
		})]
		public virtual Appendable appendTo(Appendable appendable, Iterator parts)
		{
			Preconditions.checkNotNull(appendable);
			if (parts.hasNext())
			{
				Map.Entry entry = (Map.Entry)parts.next();
				CharSequence csq = default(CharSequence);
				object obj = (csq.___003Cref_003E = joiner.toString(entry.getKey()).___003Cref_003E);
				appendable.append(csq);
				obj = (csq.___003Cref_003E = keyValueSeparator);
				appendable.append(csq);
				obj = (csq.___003Cref_003E = joiner.toString(entry.getValue()).___003Cref_003E);
				appendable.append(csq);
				while (parts.hasNext())
				{
					obj = (csq.___003Cref_003E = access_0024100(joiner));
					appendable.append(csq);
					Map.Entry entry2 = (Map.Entry)parts.next();
					obj = (csq.___003Cref_003E = joiner.toString(entry2.getKey()).___003Cref_003E);
					appendable.append(csq);
					obj = (csq.___003Cref_003E = keyValueSeparator);
					appendable.append(csq);
					obj = (csq.___003Cref_003E = joiner.toString(entry2.getValue()).___003Cref_003E);
					appendable.append(csq);
				}
			}
			return appendable;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/StringBuilder;Ljava/util/Iterator<+Ljava/util/Map$Entry<**>;>;)Ljava/lang/StringBuilder;")]
		[LineNumberTable(new byte[] { 161, 57, 187, 2, 97, 140 })]
		public virtual StringBuilder appendTo(StringBuilder builder, Iterator entries)
		{
			IOException ex;
			try
			{
				appendTo((Appendable)builder, entries);
				return builder;
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			IOException detailMessage = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError(detailMessage);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Iterable<+Ljava/util/Map$Entry<**>;>;)Ljava/lang/String;")]
		[LineNumberTable(450)]
		public virtual string join(Iterable entries)
		{
			string result = join(entries.iterator());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Iterator<+Ljava/util/Map$Entry<**>;>;)Ljava/lang/String;")]
		[LineNumberTable(461)]
		public virtual string join(Iterator entries)
		{
			string result = appendTo(new StringBuilder(), entries).toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[Signature("<A::Ljava/lang/Appendable;>(TA;Ljava/util/Map<**>;)TA;")]
		[LineNumberTable(350)]
		public virtual Appendable appendTo(Appendable appendable, Map map)
		{
			Appendable result = appendTo(appendable, map.entrySet());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/StringBuilder;Ljava/util/Map<**>;)Ljava/lang/StringBuilder;")]
		[LineNumberTable(360)]
		public virtual StringBuilder appendTo(StringBuilder builder, Map map)
		{
			StringBuilder result = appendTo(builder, map.entrySet());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map<**>;)Ljava/lang/String;")]
		[LineNumberTable(439)]
		public virtual string join(Map map)
		{
			string result = join(map.entrySet());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(469)]
		public virtual MapJoiner useForNull(string nullText)
		{
			MapJoiner result = new MapJoiner(joiner.useForNull(nullText), keyValueSeparator);
			_ = null;
			return result;
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private string separator;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 36, 104, 108 })]
	private Joiner(Joiner P_0)
	{
		separator = P_0.separator;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 32, 104, 113 })]
	private Joiner(string P_0)
	{
		separator = (string)Preconditions.checkNotNull(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[Signature("<A::Ljava/lang/Appendable;>(TA;Ljava/util/Iterator<+Ljava/lang/Object;>;)TA;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 1, 2, 3, 0, 2, 0, 0,
		73, 0, 0
	})]
	[LineNumberTable(new byte[] { 65, 103, 107, 127, 12, 104, 125, 191, 14 })]
	public virtual Appendable appendTo(Appendable appendable, Iterator parts)
	{
		Preconditions.checkNotNull(appendable);
		if (parts.hasNext())
		{
			CharSequence csq = default(CharSequence);
			object obj = (csq.___003Cref_003E = toString(parts.next()).___003Cref_003E);
			appendable.append(csq);
			while (parts.hasNext())
			{
				obj = (csq.___003Cref_003E = separator);
				appendable.append(csq);
				obj = (csq.___003Cref_003E = toString(parts.next()).___003Cref_003E);
				appendable.append(csq);
			}
		}
		return appendable;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 121, 103 })]
	internal virtual CharSequence toString([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		java.util.Objects.requireNonNull(P_0);
		object obj;
		if (CharSequence.IsInstance(P_0))
		{
			obj = P_0;
			CharSequence.Cast(obj);
		}
		else
		{
			obj = Object.instancehelper_toString(P_0);
		}
		CharSequence charSequence = default(CharSequence);
		object obj2 = (charSequence.___003Cref_003E = obj);
		CharSequence result = charSequence;
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[Signature("<A::Ljava/lang/Appendable;>(TA;Ljava/lang/Iterable<+Ljava/lang/Object;>;)TA;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 1, 2, 3, 0, 2, 0, 0,
		73, 0, 0
	})]
	[LineNumberTable(103)]
	public virtual Appendable appendTo(Appendable appendable, Iterable parts)
	{
		Appendable result = appendTo(appendable, parts.iterator());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Iterable<Ljava/lang/Object;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 20, 1, 3, 0, 0, 73, 0, 0,
		22, 2, 1, 0, 0, 0, 73, 0, 0
	})]
	[LineNumberTable(new byte[] { 161, 127, 103 })]
	private static Iterable iterable([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1, object[] P_2)
	{
		Preconditions.checkNotNull(P_2);
		_3 result = new _3(P_2, P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/StringBuilder;Ljava/util/Iterator<+Ljava/lang/Object;>;)Ljava/lang/StringBuilder;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 1, 2, 3, 0, 2, 0, 0,
		73, 0, 0
	})]
	[LineNumberTable(new byte[] { 119, 187, 2, 97, 140 })]
	public StringBuilder appendTo(StringBuilder builder, Iterator parts)
	{
		IOException ex;
		try
		{
			appendTo((Appendable)builder, parts);
			return builder;
		}
		catch (IOException x)
		{
			ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		IOException detailMessage = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new AssertionError(detailMessage);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/StringBuilder;Ljava/lang/Iterable<+Ljava/lang/Object;>;)Ljava/lang/StringBuilder;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 1, 2, 3, 0, 2, 0, 0,
		73, 0, 0
	})]
	[LineNumberTable(155)]
	public StringBuilder appendTo(StringBuilder builder, Iterable parts)
	{
		StringBuilder result = appendTo(builder, parts.iterator());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Iterator<+Ljava/lang/Object;>;)Ljava/lang/String;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 0, 2, 3, 0, 2, 0, 0,
		73, 0, 0
	})]
	[LineNumberTable(215)]
	public string join(Iterator parts)
	{
		string result = appendTo(new StringBuilder(), parts).toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<+Ljava/lang/Object;>;)Ljava/lang/String;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 0, 2, 3, 0, 2, 0, 0,
		73, 0, 0
	})]
	[LineNumberTable(205)]
	public string join(Iterable parts)
	{
		string result = join(parts.iterator());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(314)]
	public virtual MapJoiner withKeyValueSeparator(string keyValueSeparator)
	{
		MapJoiner result = new MapJoiner(this, keyValueSeparator, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(72)]
	public static Joiner on(string separator)
	{
		Joiner result = new Joiner(separator);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(77)]
	public static Joiner on(char separator)
	{
		Joiner result = new Joiner(String.valueOf(separator));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[Signature("<A::Ljava/lang/Appendable;>(TA;[Ljava/lang/Object;)TA;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 1, 1, 0, 0, 0, 73, 0,
		0
	})]
	[LineNumberTable(133)]
	public Appendable appendTo(Appendable appendable, object[] parts)
	{
		Appendable result = appendTo(appendable, Arrays.asList(parts));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[Signature("<A::Ljava/lang/Appendable;>(TA;Ljava/lang/Object;Ljava/lang/Object;[Ljava/lang/Object;)TA;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 3, 1, 0, 0, 0, 73, 0,
		0
	})]
	[LineNumberTable(144)]
	public Appendable appendTo(Appendable appendable, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object first, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object second, params object[] rest)
	{
		Appendable result = appendTo(appendable, iterable(first, second, rest));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 1, 1, 0, 0, 0, 73, 0,
		0
	})]
	[LineNumberTable(183)]
	public StringBuilder appendTo(StringBuilder builder, object[] parts)
	{
		StringBuilder result = appendTo(builder, Arrays.asList(parts));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 3, 1, 0, 0, 0, 73, 0,
		0
	})]
	[LineNumberTable(197)]
	public StringBuilder appendTo(StringBuilder builder, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object first, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object second, params object[] rest)
	{
		StringBuilder result = appendTo(builder, iterable(first, second, rest));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 0, 1, 0, 0, 0, 73, 0,
		0
	})]
	[LineNumberTable(223)]
	public string join(object[] parts)
	{
		string result = join(Arrays.asList(parts));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 2, 1, 0, 0, 0, 73, 0,
		0
	})]
	[LineNumberTable(232)]
	public string join([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object first, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object second, params object[] rest)
	{
		string result = join(iterable(first, second, rest));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 126, 103 })]
	public virtual Joiner useForNull(string nullText)
	{
		Preconditions.checkNotNull(nullText);
		_1 result = new _1(this, this, nullText);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(264)]
	public virtual Joiner skipNulls()
	{
		_2 result = new _2(this, this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(306)]
	public virtual MapJoiner withKeyValueSeparator(char keyValueSeparator)
	{
		MapJoiner result = withKeyValueSeparator(String.valueOf(keyValueSeparator));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Synthetic)]
	[LineNumberTable(69)]
	internal Joiner(Joiner P_0, _1 P_1)
		: this(P_0)
	{
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(69)]
	internal static string access_0024100(Joiner P_0)
	{
		return P_0.separator;
	}
}
