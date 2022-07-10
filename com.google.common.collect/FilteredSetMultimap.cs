using System.Runtime.CompilerServices;
using IKVM.Attributes;

namespace com.google.common.collect;

[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/collect/FilteredMultimap<TK;TV;>;Lcom/google/common/collect/SetMultimap<TK;TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 26, 0, 0,
	17, 1, 0, 0, 0, 26, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)26,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.collect.FilteredMultimap", "com.google.common.collect.SetMultimap" })]
internal interface FilteredSetMultimap : FilteredMultimap, Multimap, SetMultimap
{
	[HideFromJava]
	public new static class __DefaultMethods
	{
		public unsafe static Multimap unfiltered(FilteredSetMultimap P_0)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003Eunfiltered(P_0);
		}
	}

	[Signature("()Lcom/google/common/collect/SetMultimap<TK;TV;>;")]
	SetMultimap unfiltered();

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	Multimap unfiltered();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(27)]
	static Multimap _003Cdefault_003Eunfiltered(FilteredSetMultimap P_0)
	{
		SetMultimap result = P_0.unfiltered();
		_ = null;
		return result;
	}
}
