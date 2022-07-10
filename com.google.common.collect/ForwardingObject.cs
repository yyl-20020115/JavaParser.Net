using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace com.google.common.collect;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public abstract class ForwardingObject : Object
{
	protected internal abstract object @delegate();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(51)]
	protected internal ForwardingObject()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(64)]
	public override string toString()
	{
		string result = Object.instancehelper_toString(@delegate());
		_ = null;
		return result;
	}
}
