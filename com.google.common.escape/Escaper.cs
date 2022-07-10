using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using java.lang;
using java.util.function;

namespace com.google.common.escape;

[DoNotMock(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/DoNotMock;",
	"value",
	"Use Escapers.nullEscaper() or another methods from the *Escapers classes"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/escape/ElementTypesAreNonnullByDefault;"
})]
public abstract class Escaper : Object
{
	[SpecialName]
	private sealed class ___003C_003EAnon0 : com.google.common.@base.Function
	{
		private readonly Escaper arg_00241;

		internal ___003C_003EAnon0(Escaper P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			string result = arg_00241.escape((string)P_0);
			_ = null;
			return result;
		}

		[SpecialName]
		public bool equals(object P_0)
		{
			return Object.instancehelper_equals(this, P_0);
		}

		[SpecialName]
		public java.util.function.Function compose(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
		}

		[SpecialName]
		public java.util.function.Function andThen(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/base/Function<Ljava/lang/String;Ljava/lang/String;>;")]
	private com.google.common.@base.Function m_asFunction;

	public abstract string escape(string str);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 13, 232, 89, 241, 39 })]
	protected internal Escaper()
	{
		this.m_asFunction = new ___003C_003EAnon0(this);
	}

	[Signature("()Lcom/google/common/base/Function<Ljava/lang/String;Ljava/lang/String;>;")]
	public com.google.common.@base.Function asFunction()
	{
		return this.m_asFunction;
	}
}
