using System.ComponentModel;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.util;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Map<TK;TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 39, 0, 0,
	17, 1, 0, 0, 0, 39, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)39,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.util.Map" })]
public interface BiMap : Map
{
	[HideFromJava]
	public new static class __DefaultMethods
	{
		public unsafe static Collection values(BiMap P_0)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003E_003Cbridge_003Evalues(P_0);
		}
	}

	[Signature("()Ljava/util/Set<TV;>;")]
	Set values();

	[Signature("(TK;TV;)TV;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	object put([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj1, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj2);

	[Signature("(TK;TV;)TV;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	virtual object forcePut([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj1, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj2);

	[Signature("(Ljava/util/Map<+TK;+TV;>;)V")]
	void putAll(Map m);

	[Signature("()Lcom/google/common/collect/BiMap<TV;TK;>;")]
	virtual BiMap inverse();

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	virtual Collection _003Cbridge_003Evalues();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(37)]
	static Collection _003Cdefault_003E_003Cbridge_003Evalues(BiMap P_0)
	{
		Set result = P_0.values();
		_ = null;
		return result;
	}
}
