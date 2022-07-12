using System;
using System.ComponentModel;

using com.github.javaparser.utils;

using java.lang;
using java.util;

namespace com.github.javaparser;


public class Position :  Comparable
{
	internal int ___003C_003Eline;

	internal int ___003C_003Ecolumn;

	public const int FIRST_LINE = 1;

	public const int FIRST_COLUMN = 1;

	internal static Position ___003C_003EHOME;

	public const int ABSOLUTE_BEGIN_LINE = -1;

	public const int ABSOLUTE_END_LINE = -2;

	
	public int line
	{
		
		get
		{
			return ___003C_003Eline;
		}
		
		private set
		{
			___003C_003Eline = value;
		}
	}

	
	public int column
	{
		
		get
		{
			return ___003C_003Ecolumn;
		}
		
		private set
		{
			___003C_003Ecolumn = value;
		}
	}

	
	public static Position HOME
	{
		
		get
		{
			return ___003C_003EHOME;
		}
	}

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
	
	
	public virtual int compareTo(Position otherPosition)
	{
		Utils.assertNotNull(otherPosition);
		if (isBefore(otherPosition))
		{
			return -1;
		}
		if (isAfter(otherPosition))
		{
			return 1;
		}
		return 0;
	}

	
	
	
	public override bool Equals(object o)
	{
		if (this == o)
		{
			return true;
		}
		if (o == null || ((object)this).GetType() != o.GetType())
		{
			return false;
		}
		Position position = (Position)o;
		return (Objects.equals(Integer.valueOf(___003C_003Eline), Integer.valueOf(position.___003C_003Eline)) && Objects.equals(Integer.valueOf(___003C_003Ecolumn), Integer.valueOf(position.___003C_003Ecolumn))) ? true : false;
	}

	
	
	
	public virtual Position right(int characters)
	{
		Position result = new Position(___003C_003Eline, ___003C_003Ecolumn + characters);
		
		return result;
	}

	
	
	public virtual Position nextLine()
	{
		Position result = new Position(___003C_003Eline + 1, 1);
		
		return result;
	}

	
	
	
	public Position(int line, int column)
	{
		if (line < -2)
		{
			string s = new StringBuilder().append("Can't position at line ").append(line).ToString();
			
			throw new IllegalArgumentException(s);
		}
		if (column < -1)
		{
			string s2 = new StringBuilder().append("Can't position at column ").append(column).ToString();
			
			throw new IllegalArgumentException(s2);
		}
		___003C_003Eline = line;
		___003C_003Ecolumn = column;
	}

	public virtual bool valid()
	{
		return (___003C_003Eline >= 1 && ___003C_003Ecolumn >= 1) ? true : false;
	}

	
	
	public virtual bool invalid()
	{
		return (!valid()) ? true : false;
	}

	
	
	
	public virtual bool isAfter(Position otherPosition)
	{
		Utils.assertNotNull(otherPosition);
		if (otherPosition.___003C_003Eline == -1)
		{
			return true;
		}
		if (___003C_003Eline > otherPosition.___003C_003Eline)
		{
			return true;
		}
		if (___003C_003Eline == otherPosition.___003C_003Eline)
		{
			return ___003C_003Ecolumn > otherPosition.___003C_003Ecolumn;
		}
		return false;
	}

	
	
	
	public virtual bool isBefore(Position otherPosition)
	{
		Utils.assertNotNull(otherPosition);
		if (otherPosition.___003C_003Eline == -2)
		{
			return true;
		}
		if (___003C_003Eline < otherPosition.___003C_003Eline)
		{
			return true;
		}
		if (___003C_003Eline == otherPosition.___003C_003Eline)
		{
			return ___003C_003Ecolumn < otherPosition.___003C_003Ecolumn;
		}
		return false;
	}

	
	
	
	
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static Position pos(int line, int column)
	{
		Position result = new Position(line, column);
		
		return result;
	}

	
	
	
	public virtual Position withColumn(int column)
	{
		Position result = new Position(___003C_003Eline, column);
		
		return result;
	}

	
	
	
	public virtual Position withLine(int line)
	{
		Position result = new Position(line, ___003C_003Ecolumn);
		
		return result;
	}

	
	
	
	public virtual Position orIfInvalid(Position alternativePosition)
	{
		Utils.assertNotNull(alternativePosition);
		if (valid() || alternativePosition.invalid())
		{
			return this;
		}
		return alternativePosition;
	}

	
	
	
	public virtual bool isAfterOrEqual(Position otherPosition)
	{
		Utils.assertNotNull(otherPosition);
		return (isAfter(otherPosition) || equals(otherPosition)) ? true : false;
	}

	
	
	
	public virtual bool isBeforeOrEqual(Position otherPosition)
	{
		Utils.assertNotNull(otherPosition);
		return (isBefore(otherPosition) || equals(otherPosition)) ? true : false;
	}

	
	
	public override int GetHashCode()
	{
		int result = Objects.hash(Integer.valueOf(___003C_003Eline), Integer.valueOf(___003C_003Ecolumn));
		
		return result;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("(line ").append(___003C_003Eline).append(",col ")
			.append(___003C_003Ecolumn)
			.append(")")
			.ToString();
		
		return result;
	}

	
	
	
	
	
	public virtual int compareTo(object otherPosition)
	{
		int result = compareTo((Position)otherPosition);
		
		return result;
	}

	
	static Position()
	{
		___003C_003EHOME = new Position(1, 1);
	}

	int IComparable.Comparable_003A_003AcompareTo(object P_0)
	{
		return compareTo(P_0);
	}
}
