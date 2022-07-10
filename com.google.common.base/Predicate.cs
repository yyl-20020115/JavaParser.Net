using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util.function;
using javax.annotation;

namespace com.google.common.@base;

[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/function/Predicate<TT;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 34, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)34,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[FunctionalInterface(new object[]
{
	(byte)64,
	"Ljava/lang/FunctionalInterface;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.util.function.Predicate" })]
public interface Predicate : java.util.function.Predicate
{
	[HideFromJava]
	public new static class __DefaultMethods
	{
		public unsafe static bool test(Predicate P_0, object P_1)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003Etest(P_0, P_1);
		}
	}

	[Signature("(TT;)Z")]
	virtual bool apply([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/base/ParametricNullness;"
	})] object obj);

	virtual bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj);

	[Modifiers(Modifiers.Public)]
	[Signature("(TT;)Z")]
	bool test([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/base/ParametricNullness;"
	})] object input);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(81)]
	static bool _003Cdefault_003Etest(Predicate P_0, object P_1)
	{
		bool result = P_0.apply(P_1);
		_ = null;
		return result;
	}
}
