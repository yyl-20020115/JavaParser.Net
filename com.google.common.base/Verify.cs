using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using javax.annotation;

namespace com.google.common.@base;

[ConstantPool(new object[]
{
	(byte)27,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
public sealed class Verify : Object
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;Ljava/lang/String;[Ljava/lang/Object;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 2, 1, 0, 0, 0, 27, 0,
		0
	})]
	[LineNumberTable(new byte[] { 161, 132, 99, 146 })]
	public static object verifyNotNull([CheckForNull(new object[]
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
			string message = Strings.lenientFormat(errorMessageTemplate, errorMessageArgs);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new VerifyException(message);
		}
		return reference;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 117, 98, 99, 139 })]
	public static void verify(bool expression)
	{
		if (!expression)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new VerifyException();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 2, 1, 0, 0, 0, 27, 0,
		0
	})]
	[LineNumberTable(new byte[] { 159, 111, 98, 99, 146 })]
	public static void verify(bool expression, string errorMessageTemplate, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] params object[] errorMessageArgs)
	{
		if (!expression)
		{
			string message = Strings.lenientFormat(errorMessageTemplate, errorMessageArgs);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new VerifyException(message);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 108, 164, 99, 159, 1 })]
	public static void verify(bool expression, string errorMessageTemplate, char p1)
	{
		if (!expression)
		{
			string message = Strings.lenientFormat(errorMessageTemplate, Character.valueOf(p1));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new VerifyException(message);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 104, 98, 99, 159, 1 })]
	public static void verify(bool expression, string errorMessageTemplate, int p1)
	{
		if (!expression)
		{
			string message = Strings.lenientFormat(errorMessageTemplate, Integer.valueOf(p1));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new VerifyException(message);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 101, 162, 99, 159, 1 })]
	public static void verify(bool expression, string errorMessageTemplate, long p1)
	{
		if (!expression)
		{
			string message = Strings.lenientFormat(errorMessageTemplate, Long.valueOf(p1));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new VerifyException(message);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 97, 130, 99, 155 })]
	public static void verify(bool expression, string errorMessageTemplate, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p1)
	{
		if (!expression)
		{
			string message = Strings.lenientFormat(errorMessageTemplate, p1);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new VerifyException(message);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 93, 70, 99, 159, 10 })]
	public static void verify(bool expression, string errorMessageTemplate, char p1, char p2)
	{
		if (!expression)
		{
			string message = Strings.lenientFormat(errorMessageTemplate, Character.valueOf(p1), Character.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new VerifyException(message);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 90, 132, 99, 159, 10 })]
	public static void verify(bool expression, string errorMessageTemplate, int p1, char p2)
	{
		if (!expression)
		{
			string message = Strings.lenientFormat(errorMessageTemplate, Integer.valueOf(p1), Character.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new VerifyException(message);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 86, 68, 99, 159, 10 })]
	public static void verify(bool expression, string errorMessageTemplate, long p1, char p2)
	{
		if (!expression)
		{
			string message = Strings.lenientFormat(errorMessageTemplate, Long.valueOf(p1), Character.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new VerifyException(message);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 83, 164, 99, 159, 5 })]
	public static void verify(bool expression, string errorMessageTemplate, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p1, char p2)
	{
		if (!expression)
		{
			string message = Strings.lenientFormat(errorMessageTemplate, p1, Character.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new VerifyException(message);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 79, 100, 99, 159, 10 })]
	public static void verify(bool expression, string errorMessageTemplate, char p1, int p2)
	{
		if (!expression)
		{
			string message = Strings.lenientFormat(errorMessageTemplate, Character.valueOf(p1), Integer.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new VerifyException(message);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 76, 162, 99, 159, 10 })]
	public static void verify(bool expression, string errorMessageTemplate, int p1, int p2)
	{
		if (!expression)
		{
			string message = Strings.lenientFormat(errorMessageTemplate, Integer.valueOf(p1), Integer.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new VerifyException(message);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 72, 98, 99, 159, 10 })]
	public static void verify(bool expression, string errorMessageTemplate, long p1, int p2)
	{
		if (!expression)
		{
			string message = Strings.lenientFormat(errorMessageTemplate, Long.valueOf(p1), Integer.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new VerifyException(message);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 68, 66, 99, 159, 5 })]
	public static void verify(bool expression, string errorMessageTemplate, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p1, int p2)
	{
		if (!expression)
		{
			string message = Strings.lenientFormat(errorMessageTemplate, p1, Integer.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new VerifyException(message);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 65, 132, 99, 159, 10 })]
	public static void verify(bool expression, string errorMessageTemplate, char p1, long p2)
	{
		if (!expression)
		{
			string message = Strings.lenientFormat(errorMessageTemplate, Character.valueOf(p1), Long.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new VerifyException(message);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 61, 66, 99, 159, 10 })]
	public static void verify(bool expression, string errorMessageTemplate, int p1, long p2)
	{
		if (!expression)
		{
			string message = Strings.lenientFormat(errorMessageTemplate, Integer.valueOf(p1), Long.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new VerifyException(message);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 58, 130, 99, 159, 10 })]
	public static void verify(bool expression, string errorMessageTemplate, long p1, long p2)
	{
		if (!expression)
		{
			string message = Strings.lenientFormat(errorMessageTemplate, Long.valueOf(p1), Long.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new VerifyException(message);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 54, 98, 99, 159, 5 })]
	public static void verify(bool expression, string errorMessageTemplate, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p1, long p2)
	{
		if (!expression)
		{
			string message = Strings.lenientFormat(errorMessageTemplate, p1, Long.valueOf(p2));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new VerifyException(message);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 50, 68, 99, 159, 5 })]
	public static void verify(bool expression, string errorMessageTemplate, char p1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p2)
	{
		if (!expression)
		{
			string message = Strings.lenientFormat(errorMessageTemplate, Character.valueOf(p1), p2);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new VerifyException(message);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 47, 162, 99, 159, 5 })]
	public static void verify(bool expression, string errorMessageTemplate, int p1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p2)
	{
		if (!expression)
		{
			string message = Strings.lenientFormat(errorMessageTemplate, Integer.valueOf(p1), p2);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new VerifyException(message);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 43, 130, 99, 159, 5 })]
	public static void verify(bool expression, string errorMessageTemplate, long p1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p2)
	{
		if (!expression)
		{
			string message = Strings.lenientFormat(errorMessageTemplate, Long.valueOf(p1), p2);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new VerifyException(message);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 38, 66, 99, 159, 0 })]
	public static void verify(bool expression, string errorMessageTemplate, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object p2)
	{
		if (!expression)
		{
			string message = Strings.lenientFormat(errorMessageTemplate, p1, p2);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new VerifyException(message);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 34, 162, 99, 159, 5 })]
	public static void verify(bool expression, string errorMessageTemplate, [CheckForNull(new object[]
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
		if (!expression)
		{
			string message = Strings.lenientFormat(errorMessageTemplate, p1, p2, p3);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new VerifyException(message);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 29, 162, 99, 159, 10 })]
	public static void verify(bool expression, string errorMessageTemplate, [CheckForNull(new object[]
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
		if (!expression)
		{
			string message = Strings.lenientFormat(errorMessageTemplate, p1, p2, p3, p4);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new VerifyException(message);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;)TT;")]
	[LineNumberTable(479)]
	public static object verifyNotNull([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object reference)
	{
		object result = verifyNotNull(reference, "expected a non-null reference");
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(511)]
	private Verify()
	{
	}
}
