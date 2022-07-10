using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace com.google.common.collect;

[Signature("<E:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/collect/Multiset<TE;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 25, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)25,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.collect.Multiset" })]
internal interface SortedMultisetBridge : Multiset, Collection, Iterable
{
	[HideFromJava]
	public new static class __DefaultMethods
	{
		public unsafe static Set elementSet(SortedMultisetBridge P_0)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003EelementSet(P_0);
		}
	}

	[Signature("()Ljava/util/SortedSet<TE;>;")]
	SortedSet elementSet();

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	Set elementSet();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(30)]
	static Set _003Cdefault_003EelementSet(SortedMultisetBridge P_0)
	{
		SortedSet result = P_0.elementSet();
		_ = null;
		return result;
	}
}
