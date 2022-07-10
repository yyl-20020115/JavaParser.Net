using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using javax.annotation;

namespace com.google.common.@base;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
public sealed class Defaults : Object
{
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Double DOUBLE_DEFAULT;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Float FLOAT_DEFAULT;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(31)]
	private Defaults()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Class<TT;>;)TT;")]
	[LineNumberTable(new byte[]
	{
		159, 186, 103, 107, 104, 102, 104, 105, 104, 105,
		104, 105, 104, 105, 104, 106, 104, 102, 104, 166
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public static object defaultValue(Class type)
	{
		Preconditions.checkNotNull(type);
		if (type.isPrimitive())
		{
			if (type == Boolean.TYPE)
			{
				return Boolean.FALSE;
			}
			if (type == Character.TYPE)
			{
				Character result = Character.valueOf('\0');
				_ = null;
				return result;
			}
			if (type == Byte.TYPE)
			{
				Byte result2 = Byte.valueOf(0);
				_ = null;
				return result2;
			}
			if (type == Short.TYPE)
			{
				Short result3 = Short.valueOf(0);
				_ = null;
				return result3;
			}
			if (type == Integer.TYPE)
			{
				Integer result4 = Integer.valueOf(0);
				_ = null;
				return result4;
			}
			if (type == Long.TYPE)
			{
				Long result5 = Long.valueOf(0L);
				_ = null;
				return result5;
			}
			if (type == Float.TYPE)
			{
				return FLOAT_DEFAULT;
			}
			if (type == Double.TYPE)
			{
				return DOUBLE_DEFAULT;
			}
		}
		return null;
	}

	[LineNumberTable(new byte[] { 159, 175, 111 })]
	static Defaults()
	{
		DOUBLE_DEFAULT = Double.valueOf(0.0);
		FLOAT_DEFAULT = Float.valueOf(0f);
	}
}
