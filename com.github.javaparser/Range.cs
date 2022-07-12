

using java.lang;

namespace com.github.javaparser;

public class Range
{
	internal Position ___003C_003Ebegin;

	internal Position ___003C_003Eend;

	
	public Position begin
	{
		
		get
		{
			return ___003C_003Ebegin;
		}
		
		private set
		{
			___003C_003Ebegin = value;
		}
	}

	
	public Position end
	{
		
		get
		{
			return ___003C_003Eend;
		}
		
		private set
		{
			___003C_003Eend = value;
		}
	}

	
	
	
	public virtual bool contains(Range other)
	{
		int num = (___003C_003Ebegin.isBeforeOrEqual(other.___003C_003Ebegin) ? 1 : 0);
		int num2 = (___003C_003Eend.isAfterOrEqual(other.___003C_003Eend) ? 1 : 0);
		return (num != 0 && num2 != 0) ? true : false;
	}

	
	
	
	public Range(Position begin, Position end)
	{
		if (begin == null)
		{
			
			throw new IllegalArgumentException("begin can't be null");
		}
		if (end == null)
		{
			
			throw new IllegalArgumentException("end can't be null");
		}
		if (begin.isBefore(end))
		{
			___003C_003Ebegin = begin;
			___003C_003Eend = end;
		}
		else
		{
			___003C_003Ebegin = end;
			___003C_003Eend = begin;
		}
	}

	
	
	
	public static Range range(Position begin, Position end)
	{
		Range result = new Range(begin, end);
		
		return result;
	}

	
	
	
	public static Range range(int beginLine, int beginColumn, int endLine, int endColumn)
	{
		Range result = new Range(new Position(beginLine, beginColumn), new Position(endLine, endColumn));
		
		return result;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append(___003C_003Ebegin).append("-").append(___003C_003Eend)
			.ToString();
		
		return result;
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
		Range range = (Range)o;
		return (___003C_003Ebegin.equals(range.___003C_003Ebegin) && ___003C_003Eend.equals(range.___003C_003Eend)) ? true : false;
	}

	
	
	
	public virtual bool strictlyContains(Position position)
	{
		return (position.isAfter(___003C_003Ebegin) && position.isBefore(___003C_003Eend)) ? true : false;
	}

	
	
	
	public virtual bool contains(Position position)
	{
		return (strictlyContains(position) || ___003C_003Ebegin.equals(position) || ___003C_003Eend.equals(position)) ? true : false;
	}

	
	
	
	public virtual Range withBeginColumn(int beginColumn)
	{
		Range result = range(___003C_003Ebegin.withColumn(beginColumn), ___003C_003Eend);
		
		return result;
	}

	
	
	
	public virtual Range withBeginLine(int beginLine)
	{
		Range result = range(___003C_003Ebegin.withLine(beginLine), ___003C_003Eend);
		
		return result;
	}

	
	
	
	public virtual Range withEndColumn(int endColumn)
	{
		Range result = range(___003C_003Ebegin, ___003C_003Eend.withColumn(endColumn));
		
		return result;
	}

	
	
	
	public virtual Range withEndLine(int endLine)
	{
		Range result = range(___003C_003Ebegin, ___003C_003Eend.withLine(endLine));
		
		return result;
	}

	
	
	
	public virtual Range withBegin(Position begin)
	{
		Range result = range(begin, ___003C_003Eend);
		
		return result;
	}

	
	
	
	public virtual Range withEnd(Position end)
	{
		Range result = range(___003C_003Ebegin, end);
		
		return result;
	}

	
	
	
	public virtual bool strictlyContains(Range other)
	{
		int num = (___003C_003Ebegin.isBefore(other.___003C_003Ebegin) ? 1 : 0);
		int num2 = (___003C_003Eend.isAfter(other.___003C_003Eend) ? 1 : 0);
		return (num != 0 && num2 != 0) ? true : false;
	}

	
	
	
	public virtual bool overlapsWith(Range other)
	{
		return (contains(other.___003C_003Ebegin) || contains(other.___003C_003Eend) || other.contains(___003C_003Ebegin) || other.contains(___003C_003Eend)) ? true : false;
	}

	
	
	
	public virtual bool isBefore(Position position)
	{
		bool result = ___003C_003Eend.isBefore(position);
		
		return result;
	}

	
	
	
	public virtual bool isBefore(Range other)
	{
		bool result = ___003C_003Eend.isBefore(other.___003C_003Ebegin);
		
		return result;
	}

	
	
	
	public virtual bool isAfter(Position position)
	{
		bool result = ___003C_003Ebegin.isAfter(position);
		
		return result;
	}

	
	
	
	public virtual bool isAfter(Range other)
	{
		bool result = ___003C_003Ebegin.isAfter(other.___003C_003Eend);
		
		return result;
	}

	
	
	public override int GetHashCode()
	{
		return 31 * ___003C_003Ebegin.GetHashCode() + ___003C_003Eend.GetHashCode();
	}

	
	public virtual int getLineCount()
	{
		return ___003C_003Eend.___003C_003Eline - ___003C_003Ebegin.___003C_003Eline + 1;
	}
}
