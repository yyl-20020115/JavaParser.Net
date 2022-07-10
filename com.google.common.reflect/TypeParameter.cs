using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.lang.reflect;
using javax.annotation;

namespace com.google.common.reflect;

[Signature("<T:Ljava/lang/Object;>Lcom/google/common/reflect/TypeCapture<TT;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/reflect/ElementTypesAreNonnullByDefault;"
})]
public abstract class TypeParameter : TypeCapture
{
	[Modifiers(Modifiers.Final)]
	[Signature("Ljava/lang/reflect/TypeVariable<*>;")]
	internal TypeVariable typeVariable;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 1, 104, 103, 116, 108 })]
	protected internal TypeParameter()
	{
		Type type = capture();
		Preconditions.checkArgument(type is TypeVariable, "%s should be a type variable.", type);
		typeVariable = (TypeVariable)type;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(59)]
	public sealed override int hashCode()
	{
		int result = Object.instancehelper_hashCode(typeVariable);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 14, 104, 103, 148 })]
	public sealed override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object o)
	{
		if (o is TypeParameter)
		{
			TypeParameter typeParameter = (TypeParameter)o;
			bool result = Object.instancehelper_equals(typeVariable, typeParameter.typeVariable);
			_ = null;
			return result;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(73)]
	public override string toString()
	{
		string result = Object.instancehelper_toString(typeVariable);
		_ = null;
		return result;
	}
}
