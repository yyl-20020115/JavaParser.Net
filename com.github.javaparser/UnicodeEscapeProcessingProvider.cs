using System;


using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;

namespace com.github.javaparser;


public class UnicodeEscapeProcessingProvider :  Provider, Closeable, AutoCloseable
{
	public class LineCounter
	{
		private bool _crSeen;

		private int _line;

		private int _column;

		public virtual int getLine()
		{
			return _line;
		}

		public virtual int getColumn()
		{
			return _column;
		}

		
		private void incLine()
		{
			_line++;
			_column = 1;
		}

		
		
		public LineCounter()
		{
			_line = 1;
			_column = 1;
		}

		
		
		public virtual Position getPosition()
		{
			Position.___003Cclinit_003E();
			Position result = new Position(getLine(), getColumn());
			
			return result;
		}

		
		
		
		public virtual int process(int ch)
		{
			switch (ch)
			{
			case 13:
				incLine();
				_crSeen = true;
				break;
			case 10:
				if (_crSeen)
				{
					_crSeen = false;
				}
				else
				{
					incLine();
				}
				break;
			default:
				_crSeen = false;
				_column++;
				break;
			case -1:
				break;
			}
			return ch;
		}
	}

	public class PositionMapping
	{
		[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
		
		internal sealed class DeltaInfo : Position, PositionUpdate
		{
			
			private int _lineDelta;

			
			private int _columnDelta;

			
			
			public new static void ___003Cclinit_003E()
			{
			}

			
			
			
			public DeltaInfo(int line, int column, int lineDelta, int columnDelta)
				: base(line, column)
			{
				_lineDelta = lineDelta;
				_columnDelta = columnDelta;
			}

			
			public virtual int transformLine(int sourceLine)
			{
				return sourceLine + _lineDelta;
			}

			
			public virtual int transformColumn(int sourceColumn)
			{
				return sourceColumn + _columnDelta;
			}

			
			
			public override string ToString()
			{
				string result = new StringBuilder().append("(").append(___003C_003Eline).append(", ")
					.append(___003C_003Ecolumn)
					.append(": ")
					.append(_lineDelta)
					.append(", ")
					.append(_columnDelta)
					.append(")")
					.ToString();
				
				return result;
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual Position transform(Position P_0)
			{
				return PositionUpdate._003Cdefault_003Etransform(this, P_0);
			}

			
			static DeltaInfo()
			{
				Position.___003Cclinit_003E();
			}
		}

		public interface PositionUpdate
		{
			
			
			internal sealed class _1 :  PositionUpdate
			{
				
				
				internal _1()
				{
				}

				
				public virtual int transformLine(int line)
				{
					return line;
				}

				
				public virtual int transformColumn(int column)
				{
					return column;
				}

				
				public virtual Position transform(Position pos)
				{
					return pos;
				}
			}

			
			public static class __DefaultMethods
			{
				public unsafe static Position transform(PositionUpdate P_0, Position P_1)
				{
					
					return _003Cdefault_003Etransform(P_0, P_1);
				}
			}

			
			public static class __Fields
			{
				public static readonly PositionUpdate NONE;

				static __Fields()
				{
					NONE = PositionUpdate.NONE;
				}
			}

			static readonly PositionUpdate NONE;

			
			
			static void ___003Cclinit_003E()
			{
			}

			
			virtual int transformLine(int line);

			
			virtual int transformColumn(int column);

			
			
			virtual Position transform(Position pos);

			
			
			
			static Position _003Cdefault_003Etransform(PositionUpdate P_0, Position P_1)
			{
				int __003C_003Eline = P_1.___003C_003Eline;
				int __003C_003Ecolumn = P_1.___003C_003Ecolumn;
				int line = P_0.transformLine(__003C_003Eline);
				int column = P_0.transformColumn(__003C_003Ecolumn);
				Position result = new Position(line, column);
				
				return result;
			}

			
			static PositionUpdate()
			{
				NONE = new _1();
			}
		}

		
				private List _deltas;

		
		
		public virtual bool isEmpty()
		{
			bool result = _deltas.isEmpty();
			
			return result;
		}

		
		
		
		public virtual Range transform(Range range)
		{
			Position position = transform(range.___003C_003Ebegin);
			Position position2 = transform(range.___003C_003Eend);
			if (position == range.___003C_003Ebegin && position2 == range.___003C_003Eend)
			{
				return range;
			}
			Range result = new Range(position, position2);
			
			return result;
		}

		
		
		
		public virtual PositionUpdate lookup(Position position)
		{
			int num = Collections.binarySearch(_deltas, position);
			if (num >= 0)
			{
				return (PositionUpdate)_deltas.get(num);
			}
			int num2 = -num - 1;
			if (num2 == 0)
			{
				return PositionUpdate.NONE;
			}
			return (PositionUpdate)_deltas.get(num2 - 1);
		}

		
		
		
		public virtual Position transform(Position pos)
		{
			Position result = lookup(pos).transform(pos);
			
			return result;
		}

		
		
		public PositionMapping()
		{
			_deltas = new ArrayList();
		}

		
		
		
		internal virtual void add(int line, int column, int lineDelta, int columnDelta)
		{
			_deltas.add(new DeltaInfo(line, column, lineDelta, columnDelta));
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class PositionMappingBuilder
	{
		private LineCounter _left;

		private LineCounter _right;

		
		private PositionMapping _mapping;

		private int _lineDelta;

		private int _columnDelta;

		
		
		
		public PositionMappingBuilder(LineCounter left, LineCounter right)
		{
			_mapping = new PositionMapping();
			_lineDelta = 0;
			_columnDelta = 0;
			_left = left;
			_right = right;
			update();
		}

		
		
		public virtual void update()
		{
			int num = _right.getLine() - _left.getLine();
			int num2 = _right.getColumn() - _left.getColumn();
			if (num != _lineDelta || num2 != _columnDelta)
			{
				_mapping.add(_left.getLine(), _left.getColumn(), num, num2);
				_lineDelta = num;
				_columnDelta = num2;
			}
		}

		public virtual PositionMapping getMapping()
		{
			return _mapping;
		}
	}

	private const char LF = '\n';

	private const char CR = '\r';

	private const char BACKSLASH = '\\';

	private const int EOF = -1;

	private char[] _data;

	private int _len;

	private int _pos;

	private bool _backslashSeen;

	
	private LineCounter _inputLine;

	
	private LineCounter _outputLine;

	
	private PositionMappingBuilder _mappingBuilder;

	private Provider _input;

	
	
	
	public UnicodeEscapeProcessingProvider(Provider input)
		: this(2048, input)
	{
	}

	
	
	public virtual PositionMapping getPositionMapping()
	{
		PositionMapping mapping = _mappingBuilder.getMapping();
		
		return mapping;
	}

	
	
	
	public UnicodeEscapeProcessingProvider(int bufferSize, Provider input)
	{
		_len = 0;
		_pos = 0;
		_inputLine = new LineCounter();
		_outputLine = new LineCounter();
		_mappingBuilder = new PositionMappingBuilder(_outputLine, _inputLine);
		_input = input;
		_data = new char[bufferSize];
	}

	
	
	
	private int nextOutputChar()
	{
		int num = nextInputChar();
		switch (num)
		{
		case -1:
			return -1;
		case 92:
		{
			if (_backslashSeen)
			{
				int result2 = clearBackSlashSeen(num);
				
				return result2;
			}
			int result3 = backSlashSeen();
			
			return result3;
		}
		default:
		{
			int result = clearBackSlashSeen(num);
			
			return result;
		}
		}
	}

	
	
	
	private int nextInputChar()
	{
		int ch = nextBufferedChar();
		int result = _inputLine.process(ch);
		
		return result;
	}

	
	private int clearBackSlashSeen(int next)
	{
		_backslashSeen = false;
		return next;
	}

	
	
	
	private int backSlashSeen()
	{
		_backslashSeen = true;
		int num = nextInputChar();
		switch (num)
		{
		case -1:
			return 92;
		case 117:
		{
			int result = unicodeStartSeen();
			
			return result;
		}
		default:
			pushBack(num);
			return 92;
		}
	}

	
	
	
	private int unicodeStartSeen()
	{
		int num = 1;
		while (true)
		{
			int num2 = nextInputChar();
			switch (num2)
			{
			case -1:
				pushBackUs(num);
				return 92;
			case 117:
				break;
			default:
			{
				int result = readDigits(num, num2);
				
				return result;
			}
			}
			num++;
		}
	}

	
	
	
	private void pushBack(int ch)
	{
		if (ch < 0)
		{
			return;
		}
		if (isBufferEmpty())
		{
			_pos = _data.Length;
			_len = _data.Length;
		}
		else if (_pos == 0)
		{
			if ((nint)_len == (nint)_data.LongLength)
			{
				char[] array = new char[(nint)_data.LongLength + 1024];
				_len = array.Length;
				_pos = (int)((nint)array.LongLength - (nint)_data.LongLength);
				ByteCodeHelper.arraycopy_primitive_2(_data, 0, array, _pos, _data.Length);
				_data = array;
			}
			else
			{
				int len = _len - _pos;
				_pos = (int)((nint)_data.LongLength - _len);
				_len = _data.Length;
				ByteCodeHelper.arraycopy_primitive_2(_data, 0, _data, _pos, len);
			}
		}
		char[] data = _data;
		int num = _pos - 1;
		_pos = num;
		data[num] = (char)ch;
	}

	
	
	
	private void pushBackUs(int cnt)
	{
		for (int i = 0; i < cnt; i++)
		{
			pushBack(117);
		}
	}

	
	
	
	
	private int readDigits(int uCnt, int next3)
	{
		int num = digit(next3);
		if (num < 0)
		{
			pushBack(next3);
			pushBackUs(uCnt);
			return 92;
		}
		int ch = nextInputChar();
		int num2 = digit(ch);
		if (num2 < 0)
		{
			pushBack(ch);
			pushBack(next3);
			pushBackUs(uCnt);
			return 92;
		}
		int ch2 = nextInputChar();
		int num3 = digit(ch2);
		if (num3 < 0)
		{
			pushBack(ch2);
			pushBack(ch);
			pushBack(next3);
			pushBackUs(uCnt);
			return 92;
		}
		int ch3 = nextInputChar();
		int num4 = digit(ch3);
		if (num4 < 0)
		{
			pushBack(ch3);
			pushBack(ch2);
			pushBack(ch);
			pushBack(next3);
			pushBackUs(uCnt);
			return 92;
		}
		int next4 = (num << 12) | (num2 << 8) | (num3 << 4) | num4;
		int result = clearBackSlashSeen(next4);
		
		return result;
	}

	
	private static int digit(int ch)
	{
		if (ch >= 48 && ch <= 57)
		{
			return ch - 48;
		}
		if (ch >= 65 && ch <= 70)
		{
			return 10 + ch - 65;
		}
		if (ch >= 97 && ch <= 102)
		{
			return 10 + ch - 97;
		}
		return -1;
	}

	
	
	
	private int nextBufferedChar()
	{
		while (isBufferEmpty())
		{
			int num = fillBuffer();
			if (num < 0)
			{
				return -1;
			}
		}
		char[] data = _data;
		int pos = _pos;
		_pos = pos + 1;
		return data[pos];
	}

	private bool isBufferEmpty()
	{
		return _pos >= _len;
	}

	
	
	
	private int fillBuffer()
	{
		_pos = 0;
		int num = _input.read(_data, 0, _data.Length);
		if (num != 0)
		{
			_len = num;
		}
		return num;
	}

	public virtual LineCounter getInputCounter()
	{
		return _inputLine;
	}

	public virtual LineCounter getOutputCounter()
	{
		return _outputLine;
	}

	
	
	
	
	public virtual int read(char[] buffer, int offset, int len)
	{
		int num = offset;
		int num2 = offset + len;
		while (num < num2)
		{
			int num3 = _outputLine.process(nextOutputChar());
			if (num3 < 0)
			{
				if (num != offset)
				{
					break;
				}
				return -1;
			}
			_mappingBuilder.update();
			int num4 = num;
			num++;
			buffer[num4] = (char)num3;
		}
		return num - offset;
	}

	
	
	
	public virtual void close()
	{
		_input.close();
	}

	void IDisposable.AutoCloseable_003A_003Aclose()
	{
		close();
	}
}
