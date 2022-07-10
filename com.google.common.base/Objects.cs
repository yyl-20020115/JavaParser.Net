using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.@base;

[ConstantPool(new object[]
{
	(byte)26,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
public sealed class Objects : ExtraObjectsMethodsForWeb
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(54)]
	public static bool equal([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object a, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object b)
	{
		return (a == b || (a != null && Object.instancehelper_equals(a, b))) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 0, 1, 0, 0, 0, 26, 0,
		0
	})]
	[LineNumberTable(79)]
	public static int hashCode([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] params object[] objects)
	{
		int result = Arrays.hashCode(objects);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(35)]
	private Objects()
	{
	}
}
