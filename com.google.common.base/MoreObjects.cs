using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.lang.reflect;
using java.util;
using javax.annotation;

namespace com.google.common.@base;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
public sealed class MoreObjects : Object
{
	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal class _1 : Object
	{
		_1()
		{
			throw null;
		}
	}

	public sealed class ToStringHelper : Object
	{
		[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
		internal sealed class UnconditionalValueHolder : ValueHolder
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(466)]
			private UnconditionalValueHolder()
				: base(null)
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Synthetic)]
			[LineNumberTable(466)]
			internal UnconditionalValueHolder(_1 P_0)
				: this()
			{
			}
		}

		[InnerClass(null, Modifiers.Private | Modifiers.Static)]
		internal class ValueHolder : Object
		{
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			internal string name;

			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			internal object value;

			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			internal ValueHolder next;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(455)]
			private ValueHolder()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Synthetic)]
			[LineNumberTable(455)]
			internal ValueHolder(_1 P_0)
				: this()
			{
			}
		}

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private string className;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private ValueHolder holderHead;

		private ValueHolder holderTail;

		private bool m_omitNullValues;

		private bool omitEmptyValues;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(167)]
		internal ToStringHelper(string P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 125, 232, 58, 108, 108, 103, 199, 113 })]
		private ToStringHelper(string P_0)
		{
			holderHead = new ValueHolder(null);
			holderTail = holderHead;
			this.m_omitNullValues = false;
			omitEmptyValues = false;
			className = (string)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 59, 103, 103, 113 })]
		private ToStringHelper addHolder(string P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
		{
			ValueHolder valueHolder = addHolder();
			valueHolder.value = P_1;
			valueHolder.name = (string)Preconditions.checkNotNull(P_0);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 78, 103, 103, 113 })]
		private ToStringHelper addUnconditionalHolder(string P_0, object P_1)
		{
			UnconditionalValueHolder unconditionalValueHolder = addUnconditionalHolder();
			unconditionalValueHolder.value = P_1;
			unconditionalValueHolder.name = (string)Preconditions.checkNotNull(P_0);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 53, 103, 103 })]
		private ToStringHelper addHolder([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			ValueHolder valueHolder = addHolder();
			valueHolder.value = P_0;
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 72, 103, 103 })]
		private ToStringHelper addUnconditionalHolder(object P_0)
		{
			UnconditionalValueHolder unconditionalValueHolder = addUnconditionalHolder();
			unconditionalValueHolder.value = P_0;
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			160, 239, 104, 127, 0, 104, 110, 104, 110, 104,
			114, 104, 114, 104, 114, 104, 114, 104, 114, 109,
			141
		})]
		private static bool isEmpty(object P_0)
		{
			if (CharSequence.IsInstance(P_0))
			{
				CharSequence.Cast(P_0);
				CharSequence charSequence = default(CharSequence);
				object obj = (charSequence.___003Cref_003E = P_0);
				return (charSequence.length() == 0) ? true : false;
			}
			if (P_0 is Collection)
			{
				bool result = ((Collection)P_0).isEmpty();
				_ = null;
				return result;
			}
			if (P_0 is Map)
			{
				bool result2 = ((Map)P_0).isEmpty();
				_ = null;
				return result2;
			}
			if (P_0 is java.util.Optional)
			{
				return (!((java.util.Optional)P_0).isPresent()) ? true : false;
			}
			if (P_0 is OptionalInt)
			{
				return (!((OptionalInt)P_0).isPresent()) ? true : false;
			}
			if (P_0 is OptionalLong)
			{
				return (!((OptionalLong)P_0).isPresent()) ? true : false;
			}
			if (P_0 is OptionalDouble)
			{
				return (!((OptionalDouble)P_0).isPresent()) ? true : false;
			}
			if (P_0 is Optional)
			{
				return (!((Optional)P_0).isPresent()) ? true : false;
			}
			if (Object.instancehelper_getClass(P_0).isArray())
			{
				return (Array.getLength(P_0) == 0) ? true : false;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 47, 103, 119 })]
		private ValueHolder addHolder()
		{
			ValueHolder valueHolder = new ValueHolder(null);
			ValueHolder valueHolder2 = holderTail;
			ValueHolder next = valueHolder;
			ValueHolder valueHolder3 = valueHolder2;
			valueHolder3.next = next;
			holderTail = next;
			return valueHolder;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 66, 103, 119 })]
		private UnconditionalValueHolder addUnconditionalHolder()
		{
			UnconditionalValueHolder unconditionalValueHolder = new UnconditionalValueHolder(null);
			ValueHolder valueHolder = holderTail;
			UnconditionalValueHolder next = unconditionalValueHolder;
			ValueHolder valueHolder2 = valueHolder;
			valueHolder2.next = next;
			holderTail = next;
			return unconditionalValueHolder;
		}

		public virtual ToStringHelper omitNullValues()
		{
			this.m_omitNullValues = true;
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(199)]
		public virtual ToStringHelper add(string name, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object value)
		{
			ToStringHelper result = addHolder(name, value);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(209)]
		public virtual ToStringHelper add(string name, bool value)
		{
			ToStringHelper result = addUnconditionalHolder(name, String.valueOf(value));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(219)]
		public virtual ToStringHelper add(string name, char value)
		{
			ToStringHelper result = addUnconditionalHolder(name, String.valueOf(value));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(229)]
		public virtual ToStringHelper add(string name, double value)
		{
			ToStringHelper result = addUnconditionalHolder(name, String.valueOf(value));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(239)]
		public virtual ToStringHelper add(string name, float value)
		{
			ToStringHelper result = addUnconditionalHolder(name, String.valueOf(value));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(249)]
		public virtual ToStringHelper add(string name, int value)
		{
			ToStringHelper result = addUnconditionalHolder(name, String.valueOf(value));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(259)]
		public virtual ToStringHelper add(string name, long value)
		{
			ToStringHelper result = addUnconditionalHolder(name, String.valueOf(value));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(270)]
		public virtual ToStringHelper addValue([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object value)
		{
			ToStringHelper result = addHolder(value);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(283)]
		public virtual ToStringHelper addValue(bool value)
		{
			ToStringHelper result = addUnconditionalHolder(String.valueOf(value));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(296)]
		public virtual ToStringHelper addValue(char value)
		{
			ToStringHelper result = addUnconditionalHolder(String.valueOf(value));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(309)]
		public virtual ToStringHelper addValue(double value)
		{
			ToStringHelper result = addUnconditionalHolder(String.valueOf(value));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(322)]
		public virtual ToStringHelper addValue(float value)
		{
			ToStringHelper result = addUnconditionalHolder(String.valueOf(value));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(335)]
		public virtual ToStringHelper addValue(int value)
		{
			ToStringHelper result = addUnconditionalHolder(String.valueOf(value));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(348)]
		public virtual ToStringHelper addValue(long value)
		{
			ToStringHelper result = addUnconditionalHolder(String.valueOf(value));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161, 16, 103, 103, 102, 122, 109, 135, 105, 186,
			106, 104, 134, 105, 149, 114, 109, 105, 127, 14,
			98, 233, 47, 238, 85
		})]
		public override string toString()
		{
			int num = (this.m_omitNullValues ? 1 : 0);
			int num2 = (omitEmptyValues ? 1 : 0);
			string str = "";
			StringBuilder stringBuilder = new StringBuilder(32).append(className).append('{');
			CharSequence s = default(CharSequence);
			for (ValueHolder next = holderHead.next; next != null; next = next.next)
			{
				object value = next.value;
				if (!(next is UnconditionalValueHolder))
				{
					if (value == null)
					{
						if (num != 0)
						{
							continue;
						}
					}
					else if (num2 != 0 && isEmpty(value))
					{
						continue;
					}
				}
				stringBuilder.append(str);
				str = ", ";
				if (next.name != null)
				{
					stringBuilder.append(next.name).append('=');
				}
				if (value != null && Object.instancehelper_getClass(value).isArray())
				{
					object[] a = new object[1] { value };
					string text = Arrays.deepToString(a);
					int end = String.instancehelper_length(text) - 1;
					int start = 1;
					object obj = (s.___003Cref_003E = text);
					stringBuilder.append(s, start, end);
				}
				else
				{
					stringBuilder.append(value);
				}
			}
			string result = stringBuilder.append('}').toString();
			_ = null;
			return result;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;TT;)TT;")]
	[LineNumberTable(new byte[] { 32, 99, 130, 99, 130 })]
	public static object firstNonNull([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object first, object second)
	{
		if (first != null)
		{
			return first;
		}
		if (second != null)
		{
			return second;
		}
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new NullPointerException("Both parameters are null");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(132)]
	public static ToStringHelper toStringHelper(object self)
	{
		ToStringHelper result = new ToStringHelper(Object.instancehelper_getClass(self).getSimpleName(), null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<*>;)Lcom/google/common/base/MoreObjects$ToStringHelper;")]
	[LineNumberTable(146)]
	public static ToStringHelper toStringHelper(Class clazz)
	{
		ToStringHelper result = new ToStringHelper(clazz.getSimpleName(), null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(158)]
	public static ToStringHelper toStringHelper(string className)
	{
		ToStringHelper result = new ToStringHelper(className, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(469)]
	private MoreObjects()
	{
	}
}
