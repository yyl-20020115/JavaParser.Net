using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace com.github.javaparser.printer.configuration;

public class Indentation
{
	[Serializable]
	[InnerClass(null, Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		
	public class IndentType : java.lang.Enum
	{
		[Serializable]
		
		public enum __Enum
		{
			SPACES,
			TABS,
			TABS_WITH_SPACE_ALIGN
		}

		
		internal static IndentType ___003C_003ESPACES;

		
		internal static IndentType ___003C_003ETABS;

		
		internal static IndentType ___003C_003ETABS_WITH_SPACE_ALIGN;

		private Character car;

		private int width;

		
		private static IndentType[] _0024VALUES;

		
		public static IndentType SPACES
		{
			
			get
			{
				return ___003C_003ESPACES;
			}
		}

		
		public static IndentType TABS
		{
			
			get
			{
				return ___003C_003ETABS;
			}
		}

		
		public static IndentType TABS_WITH_SPACE_ALIGN
		{
			
			get
			{
				return ___003C_003ETABS_WITH_SPACE_ALIGN;
			}
		}

		
		
		public static void ___003Cclinit_003E()
		{
		}

		
				[MethodParameters(new Modifiers[]
		{
			Modifiers.Synthetic,
			Modifiers.Synthetic,
			(Modifiers)0,
			(Modifiers)0
		})]
		
		private IndentType(string _0024enum_0024name, int _0024enum_0024ordinal, Character c, int width)
			: base(_0024enum_0024name, _0024enum_0024ordinal)
		{
			car = c;
			this.width = width;
			GC.KeepAlive(this);
		}

		
		
		public static IndentType[] values()
		{
			return (IndentType[])_0024VALUES.Clone();
		}

		
		
		
		public static IndentType valueOf(string name)
		{
			return (IndentType)java.lang.Enum.valueOf(ClassLiteral<IndentType>.Value, name);
		}

		public virtual Character getCar()
		{
			return car;
		}

		public virtual int getWidth()
		{
			return width;
		}

		
		
		internal static Character access_0024000(IndentType P_0)
		{
			return P_0.car;
		}

		
		static IndentType()
		{
			___003C_003ESPACES = new IndentType("SPACES", 0, Character.valueOf(' '), 1);
			___003C_003ETABS = new IndentType("TABS", 1, Character.valueOf('\t'), 4);
			___003C_003ETABS_WITH_SPACE_ALIGN = new IndentType("TABS_WITH_SPACE_ALIGN", 2, Character.valueOf('\t'), 4);
			_0024VALUES = new IndentType[3] { ___003C_003ESPACES, ___003C_003ETABS, ___003C_003ETABS_WITH_SPACE_ALIGN };
		}
	}

	private const int DEFAULT_SIZE = 4;

	private IndentType type;

	private int size;

	private string formattedIndentation;

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public Indentation(IndentType type, int size)
	{
		formattedIndentation = "";
		this.type = type;
		this.size = size;
		format();
	}

	
	
	private void format()
	{
		StringBuilder stringBuilder = new StringBuilder();
		int c = IndentType.access_0024000(type).charValue();
		for (int i = 0; i < size; i++)
		{
			stringBuilder.append((char)c);
		}
		formattedIndentation = stringBuilder.ToString();
	}

	
	
	
	public Indentation(IndentType type)
		: this(type, 4)
	{
	}

	
	
	
	public virtual Indentation setSize(int size)
	{
		this.size = size;
		format();
		return this;
	}

	public virtual int getSize()
	{
		return size;
	}

	
	
	
	public virtual Indentation setType(IndentType type)
	{
		this.type = type;
		format();
		return this;
	}

	public virtual IndentType getType()
	{
		return type;
	}

	public virtual string getIndent()
	{
		return formattedIndentation;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append(type.name()).append(" size=").append(size)
			.ToString();
		
		return result;
	}
}
