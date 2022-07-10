using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using javax.annotation;

namespace com.google.common.@base;

[ConstantPool(new object[]
{
	(byte)61,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
public sealed class Preconditions : Object
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 106, 66, 99, 145 })]
	public static void checkArgument(bool expression, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object errorMessage)
	{
		if (!expression)
		{
			string s = String.valueOf(errorMessage);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 110, 130, 99, 139 })]
	public static void checkArgument(bool expression)
	{
		if (!expression)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;)TT;")]
	[LineNumberTable(new byte[] { 163, 6, 99, 139 })]
	public static object checkNotNull([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object reference)
	{
		if (reference == null)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NullPointerException();
		}
		return reference;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;Ljava/lang/Object;)TT;")]
	[LineNumberTable(new byte[] { 163, 24, 99, 145 })]
	public static object checkNotNull([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object reference, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object errorMessage)
	{
		if (reference == null)
		{
			string s = String.valueOf(errorMessage);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NullPointerException(s);
		}
		return reference;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 21, 98, 99, 139 })]
	public static void checkState(bool expression)
	{
		if (!expression)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 68, 130, 99, 159, 10 })]
	public static void checkArgument(bool b, string errorMessageTemplate, int p1, int p2)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Integer.valueOf(p1), Integer.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1382)]
	public static int checkPositionIndex(int index, int size)
	{
		int result = checkPositionIndex(index, size, "index");
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 88, 162, 99, 155 })]
	public static void checkArgument(bool b, string errorMessageTemplate, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p1)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, p1);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 216, 104, 147 })]
	public static int checkElementIndex(int index, int size, string desc)
	{
		if (index < 0 || index >= size)
		{
			string s = badElementIndex(index, size, desc);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IndexOutOfBoundsException(s);
		}
		return index;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 223, 100, 127, 1, 100, 159, 12 })]
	private static string badElementIndex(int P_0, int P_1, string P_2)
	{
		if (P_0 < 0)
		{
			string result = Strings.lenientFormat("%s (%s) must not be negative", P_2, Integer.valueOf(P_0));
			_ = null;
			return result;
		}
		if (P_1 < 0)
		{
			int num = 26;
			num = num;
			string s = new StringBuilder(num).append("negative size: ").append(P_1).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
		string result2 = Strings.lenientFormat("%s (%s) must be less than size (%s)", P_2, Integer.valueOf(P_0), Integer.valueOf(P_1));
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 165, 5, 104, 147 })]
	public static int checkPositionIndex(int index, int size, string desc)
	{
		if (index < 0 || index > size)
		{
			string s = badPositionIndex(index, size, desc);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IndexOutOfBoundsException(s);
		}
		return index;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 165, 12, 100, 127, 1, 100, 159, 12 })]
	private static string badPositionIndex(int P_0, int P_1, string P_2)
	{
		if (P_0 < 0)
		{
			string result = Strings.lenientFormat("%s (%s) must not be negative", P_2, Integer.valueOf(P_0));
			_ = null;
			return result;
		}
		if (P_1 < 0)
		{
			int num = 26;
			num = num;
			string s = new StringBuilder(num).append("negative size: ").append(P_1).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
		string result2 = Strings.lenientFormat("%s (%s) must not be greater than size (%s)", P_2, Integer.valueOf(P_0), Integer.valueOf(P_1));
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 165, 41, 104, 143, 104, 175 })]
	private static string badPositionIndexes(int P_0, int P_1, int P_2)
	{
		if (P_0 < 0 || P_0 > P_2)
		{
			string result = badPositionIndex(P_0, P_2, "start index");
			_ = null;
			return result;
		}
		if (P_1 < 0 || P_1 > P_2)
		{
			string result2 = badPositionIndex(P_1, P_2, "end index");
			_ = null;
			return result2;
		}
		string result3 = Strings.lenientFormat("end index (%s) must not be less than start index (%s)", Integer.valueOf(P_1), Integer.valueOf(P_0));
		_ = null;
		return result3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(119)]
	private Preconditions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 2, 1, 0, 0, 0, 61, 0,
		0
	})]
	[LineNumberTable(new byte[] { 159, 101, 130, 99, 146 })]
	public static void checkArgument(bool expression, string errorMessageTemplate, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] params object[] errorMessageArgs)
	{
		if (!expression)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, errorMessageArgs);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 98, 164, 99, 159, 1 })]
	public static void checkArgument(bool b, string errorMessageTemplate, char p1)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Character.valueOf(p1));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 94, 66, 99, 159, 1 })]
	public static void checkArgument(bool b, string errorMessageTemplate, int p1)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Integer.valueOf(p1));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 91, 98, 99, 159, 1 })]
	public static void checkArgument(bool b, string errorMessageTemplate, long p1)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Long.valueOf(p1));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 84, 70, 99, 159, 10 })]
	public static void checkArgument(bool b, string errorMessageTemplate, char p1, char p2)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Character.valueOf(p1), Character.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 81, 100, 99, 159, 10 })]
	public static void checkArgument(bool b, string errorMessageTemplate, char p1, int p2)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Character.valueOf(p1), Integer.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 78, 132, 99, 159, 10 })]
	public static void checkArgument(bool b, string errorMessageTemplate, char p1, long p2)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Character.valueOf(p1), Long.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 74, 68, 99, 159, 5 })]
	public static void checkArgument(bool b, string errorMessageTemplate, char p1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p2)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Character.valueOf(p1), p2);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 71, 100, 99, 159, 10 })]
	public static void checkArgument(bool b, string errorMessageTemplate, int p1, char p2)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Integer.valueOf(p1), Character.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 65, 162, 99, 159, 10 })]
	public static void checkArgument(bool b, string errorMessageTemplate, int p1, long p2)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Integer.valueOf(p1), Long.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 61, 98, 99, 159, 5 })]
	public static void checkArgument(bool b, string errorMessageTemplate, int p1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p2)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Integer.valueOf(p1), p2);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 58, 132, 99, 159, 10 })]
	public static void checkArgument(bool b, string errorMessageTemplate, long p1, char p2)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Long.valueOf(p1), Character.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 55, 162, 99, 159, 10 })]
	public static void checkArgument(bool b, string errorMessageTemplate, long p1, int p2)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Long.valueOf(p1), Integer.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 51, 66, 99, 159, 10 })]
	public static void checkArgument(bool b, string errorMessageTemplate, long p1, long p2)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Long.valueOf(p1), Long.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 48, 130, 99, 159, 5 })]
	public static void checkArgument(bool b, string errorMessageTemplate, long p1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p2)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Long.valueOf(p1), p2);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 44, 68, 99, 159, 5 })]
	public static void checkArgument(bool b, string errorMessageTemplate, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p1, char p2)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, p1, Character.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 41, 130, 99, 159, 5 })]
	public static void checkArgument(bool b, string errorMessageTemplate, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p1, int p2)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, p1, Integer.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 37, 66, 99, 159, 5 })]
	public static void checkArgument(bool b, string errorMessageTemplate, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p1, long p2)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, p1, Long.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 34, 130, 99, 159, 0 })]
	public static void checkArgument(bool b, string errorMessageTemplate, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p2)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, p1, p2);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 29, 66, 99, 159, 5 })]
	public static void checkArgument(bool b, string errorMessageTemplate, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p2, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p3)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, p1, p2, p3);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 25, 162, 99, 159, 10 })]
	public static void checkArgument(bool b, string errorMessageTemplate, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p2, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p3, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p4)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, p1, p2, p3, p4);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 17, 98, 99, 145 })]
	public static void checkState(bool expression, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object errorMessage)
	{
		if (!expression)
		{
			string s = String.valueOf(errorMessage);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 2, 1, 0, 0, 0, 61, 0,
		0
	})]
	[LineNumberTable(new byte[] { 159, 9, 98, 99, 146 })]
	public static void checkState(bool expression, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] string errorMessageTemplate, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] params object[] errorMessageArgs)
	{
		if (!expression)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, errorMessageArgs);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 6, 164, 99, 159, 1 })]
	public static void checkState(bool b, string errorMessageTemplate, char p1)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Character.valueOf(p1));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 2, 98, 99, 159, 1 })]
	public static void checkState(bool b, string errorMessageTemplate, int p1)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Integer.valueOf(p1));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		158,
		byte.MaxValue,
		162,
		99,
		159,
		1
	})]
	public static void checkState(bool b, string errorMessageTemplate, long p1)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Long.valueOf(p1));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 158, 251, 98, 99, 155 })]
	public static void checkState(bool b, string errorMessageTemplate, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p1)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, p1);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 158, 248, 166, 99, 159, 10 })]
	public static void checkState(bool b, string errorMessageTemplate, char p1, char p2)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Character.valueOf(p1), Character.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 158, 244, 100, 99, 159, 10 })]
	public static void checkState(bool b, string errorMessageTemplate, char p1, int p2)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Character.valueOf(p1), Integer.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 158, 241, 164, 99, 159, 10 })]
	public static void checkState(bool b, string errorMessageTemplate, char p1, long p2)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Character.valueOf(p1), Long.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 158, 237, 132, 99, 159, 5 })]
	public static void checkState(bool b, string errorMessageTemplate, char p1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p2)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Character.valueOf(p1), p2);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 158, 233, 68, 99, 159, 10 })]
	public static void checkState(bool b, string errorMessageTemplate, int p1, char p2)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Integer.valueOf(p1), Character.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 158, 230, 130, 99, 159, 10 })]
	public static void checkState(bool b, string errorMessageTemplate, int p1, int p2)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Integer.valueOf(p1), Integer.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 158, 226, 66, 99, 159, 10 })]
	public static void checkState(bool b, string errorMessageTemplate, int p1, long p2)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Integer.valueOf(p1), Long.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 158, 223, 162, 99, 159, 5 })]
	public static void checkState(bool b, string errorMessageTemplate, int p1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p2)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Integer.valueOf(p1), p2);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 158, 219, 100, 99, 159, 10 })]
	public static void checkState(bool b, string errorMessageTemplate, long p1, char p2)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Long.valueOf(p1), Character.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 158, 216, 162, 99, 159, 10 })]
	public static void checkState(bool b, string errorMessageTemplate, long p1, int p2)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Long.valueOf(p1), Integer.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 158, 212, 98, 99, 159, 10 })]
	public static void checkState(bool b, string errorMessageTemplate, long p1, long p2)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Long.valueOf(p1), Long.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 158, 208, 66, 99, 159, 5 })]
	public static void checkState(bool b, string errorMessageTemplate, long p1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p2)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Long.valueOf(p1), p2);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 158, 205, 164, 99, 159, 5 })]
	public static void checkState(bool b, string errorMessageTemplate, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p1, char p2)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, p1, Character.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 158, 201, 130, 99, 159, 5 })]
	public static void checkState(bool b, string errorMessageTemplate, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p1, int p2)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, p1, Integer.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 158, 197, 98, 99, 159, 5 })]
	public static void checkState(bool b, string errorMessageTemplate, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p1, long p2)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, p1, Long.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 158, 193, 66, 99, 159, 0 })]
	public static void checkState(bool b, string errorMessageTemplate, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p2)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, p1, p2);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 158, 189, 162, 99, 159, 5 })]
	public static void checkState(bool b, string errorMessageTemplate, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p2, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p3)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, p1, p2, p3);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 158, 184, 162, 99, 159, 10 })]
	public static void checkState(bool b, string errorMessageTemplate, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p2, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p3, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p4)
	{
		if (!b)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, p1, p2, p3, p4);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;Ljava/lang/String;[Ljava/lang/Object;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 2, 1, 0, 0, 0, 61, 0,
		0
	})]
	[LineNumberTable(new byte[] { 163, 50, 99, 146 })]
	public static object checkNotNull([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object reference, string errorMessageTemplate, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] params object[] errorMessageArgs)
	{
		if (reference == null)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, errorMessageArgs);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NullPointerException(s);
		}
		return reference;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;Ljava/lang/String;C)TT;")]
	[LineNumberTable(new byte[] { 158, 162, 162, 99, 159, 1 })]
	public static object checkNotNull([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj, string errorMessageTemplate, char p1)
	{
		if (obj == null)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Character.valueOf(p1));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NullPointerException(s);
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;Ljava/lang/String;I)TT;")]
	[LineNumberTable(new byte[] { 163, 80, 99, 159, 1 })]
	public static object checkNotNull([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj, string errorMessageTemplate, int p1)
	{
		if (obj == null)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Integer.valueOf(p1));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NullPointerException(s);
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;Ljava/lang/String;J)TT;")]
	[LineNumberTable(new byte[] { 163, 95, 99, 159, 1 })]
	public static object checkNotNull([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj, string errorMessageTemplate, long p1)
	{
		if (obj == null)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Long.valueOf(p1));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NullPointerException(s);
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;Ljava/lang/String;Ljava/lang/Object;)TT;")]
	[LineNumberTable(new byte[] { 163, 111, 99, 155 })]
	public static object checkNotNull([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj, string errorMessageTemplate, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p1)
	{
		if (obj == null)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, p1);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NullPointerException(s);
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;Ljava/lang/String;CC)TT;")]
	[LineNumberTable(new byte[] { 158, 146, 100, 99, 159, 10 })]
	public static object checkNotNull([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj, string errorMessageTemplate, char p1, char p2)
	{
		if (obj == null)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Character.valueOf(p1), Character.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NullPointerException(s);
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;Ljava/lang/String;CI)TT;")]
	[LineNumberTable(new byte[] { 158, 142, 98, 99, 159, 10 })]
	public static object checkNotNull([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj, string errorMessageTemplate, char p1, int p2)
	{
		if (obj == null)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Character.valueOf(p1), Integer.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NullPointerException(s);
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;Ljava/lang/String;CJ)TT;")]
	[LineNumberTable(new byte[] { 158, 138, 98, 99, 159, 10 })]
	public static object checkNotNull([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj, string errorMessageTemplate, char p1, long p2)
	{
		if (obj == null)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Character.valueOf(p1), Long.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NullPointerException(s);
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;Ljava/lang/String;CLjava/lang/Object;)TT;")]
	[LineNumberTable(new byte[] { 158, 134, 98, 99, 159, 5 })]
	public static object checkNotNull([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj, string errorMessageTemplate, char p1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p2)
	{
		if (obj == null)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Character.valueOf(p1), p2);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NullPointerException(s);
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;Ljava/lang/String;IC)TT;")]
	[LineNumberTable(new byte[] { 158, 130, 98, 99, 159, 10 })]
	public static object checkNotNull([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj, string errorMessageTemplate, int p1, char p2)
	{
		if (obj == null)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Integer.valueOf(p1), Character.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NullPointerException(s);
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;Ljava/lang/String;II)TT;")]
	[LineNumberTable(new byte[] { 163, 207, 99, 159, 10 })]
	public static object checkNotNull([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj, string errorMessageTemplate, int p1, int p2)
	{
		if (obj == null)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Integer.valueOf(p1), Integer.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NullPointerException(s);
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;Ljava/lang/String;IJ)TT;")]
	[LineNumberTable(new byte[] { 163, 223, 99, 159, 10 })]
	public static object checkNotNull([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj, string errorMessageTemplate, int p1, long p2)
	{
		if (obj == null)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Integer.valueOf(p1), Long.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NullPointerException(s);
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;Ljava/lang/String;ILjava/lang/Object;)TT;")]
	[LineNumberTable(new byte[] { 163, 239, 99, 159, 5 })]
	public static object checkNotNull([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj, string errorMessageTemplate, int p1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p2)
	{
		if (obj == null)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Integer.valueOf(p1), p2);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NullPointerException(s);
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;Ljava/lang/String;JC)TT;")]
	[LineNumberTable(new byte[] { 158, 114, 98, 99, 159, 10 })]
	public static object checkNotNull([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj, string errorMessageTemplate, long p1, char p2)
	{
		if (obj == null)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Long.valueOf(p1), Character.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NullPointerException(s);
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;Ljava/lang/String;JI)TT;")]
	[LineNumberTable(new byte[] { 164, 15, 99, 159, 10 })]
	public static object checkNotNull([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj, string errorMessageTemplate, long p1, int p2)
	{
		if (obj == null)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Long.valueOf(p1), Integer.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NullPointerException(s);
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;Ljava/lang/String;JJ)TT;")]
	[LineNumberTable(new byte[] { 164, 31, 99, 159, 10 })]
	public static object checkNotNull([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj, string errorMessageTemplate, long p1, long p2)
	{
		if (obj == null)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Long.valueOf(p1), Long.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NullPointerException(s);
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;Ljava/lang/String;JLjava/lang/Object;)TT;")]
	[LineNumberTable(new byte[] { 164, 47, 99, 159, 5 })]
	public static object checkNotNull([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj, string errorMessageTemplate, long p1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p2)
	{
		if (obj == null)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, Long.valueOf(p1), p2);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NullPointerException(s);
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;Ljava/lang/String;Ljava/lang/Object;C)TT;")]
	[LineNumberTable(new byte[] { 158, 98, 98, 99, 159, 5 })]
	public static object checkNotNull([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj, string errorMessageTemplate, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p1, char p2)
	{
		if (obj == null)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, p1, Character.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NullPointerException(s);
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;Ljava/lang/String;Ljava/lang/Object;I)TT;")]
	[LineNumberTable(new byte[] { 164, 79, 99, 159, 5 })]
	public static object checkNotNull([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj, string errorMessageTemplate, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p1, int p2)
	{
		if (obj == null)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, p1, Integer.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NullPointerException(s);
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;Ljava/lang/String;Ljava/lang/Object;J)TT;")]
	[LineNumberTable(new byte[] { 164, 95, 99, 159, 5 })]
	public static object checkNotNull([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj, string errorMessageTemplate, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p1, long p2)
	{
		if (obj == null)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, p1, Long.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NullPointerException(s);
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)TT;")]
	[LineNumberTable(new byte[] { 164, 114, 99, 159, 0 })]
	public static object checkNotNull([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj, string errorMessageTemplate, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p2)
	{
		if (obj == null)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, p1, p2);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NullPointerException(s);
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)TT;")]
	[LineNumberTable(new byte[] { 164, 134, 99, 159, 5 })]
	public static object checkNotNull([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj, string errorMessageTemplate, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p2, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p3)
	{
		if (obj == null)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, p1, p2, p3);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NullPointerException(s);
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)TT;")]
	[LineNumberTable(new byte[] { 164, 155, 99, 159, 10 })]
	public static object checkNotNull([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj, string errorMessageTemplate, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p2, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p3, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p4)
	{
		if (obj == null)
		{
			string s = Strings.lenientFormat(errorMessageTemplate, p1, p2, p3, p4);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NullPointerException(s);
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1337)]
	public static int checkElementIndex(int index, int size)
	{
		int result = checkElementIndex(index, size, "index");
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 165, 35, 108, 147 })]
	public static void checkPositionIndexes(int start, int end, int size)
	{
		if (start < 0 || end < start || end > size)
		{
			string s = badPositionIndexes(start, end, size);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IndexOutOfBoundsException(s);
		}
	}
}
