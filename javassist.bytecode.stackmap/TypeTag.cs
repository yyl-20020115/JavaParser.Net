using System.Runtime.CompilerServices;
using IKVM.Attributes;

namespace javassist.bytecode.stackmap;

public interface TypeTag
{
	[HideFromJava]
	public static class __Fields
	{
		public const string TOP_TYPE = "*top*";

		public static readonly TypeData.BasicType TOP;

		public static readonly TypeData.BasicType INTEGER;

		public static readonly TypeData.BasicType FLOAT;

		public static readonly TypeData.BasicType DOUBLE;

		public static readonly TypeData.BasicType LONG;

		static __Fields()
		{
			TOP = TypeTag.TOP;
			INTEGER = TypeTag.INTEGER;
			FLOAT = TypeTag.FLOAT;
			DOUBLE = TypeTag.DOUBLE;
			LONG = TypeTag.LONG;
		}
	}

	const string TOP_TYPE = "*top*";

	static readonly TypeData.BasicType TOP;

	static readonly TypeData.BasicType INTEGER;

	static readonly TypeData.BasicType FLOAT;

	static readonly TypeData.BasicType DOUBLE;

	static readonly TypeData.BasicType LONG;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	static void ___003Cclinit_003E()
	{
	}

	[LineNumberTable(new byte[] { 159, 165, 114, 114, 114, 114 })]
	static TypeTag()
	{
		TOP = new TypeData.BasicType("*top*", 0, ' ');
		INTEGER = new TypeData.BasicType("int", 1, 'I');
		FLOAT = new TypeData.BasicType("float", 2, 'F');
		DOUBLE = new TypeData.BasicType("double", 3, 'D');
		LONG = new TypeData.BasicType("long", 4, 'J');
	}
}
