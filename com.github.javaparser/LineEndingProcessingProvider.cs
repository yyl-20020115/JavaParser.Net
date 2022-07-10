using System;
using System.Runtime.CompilerServices;
using com.github.javaparser.utils;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;

namespace com.github.javaparser;


public class LineEndingProcessingProvider :  Provider, Closeable, AutoCloseable
{
	private const int EOF = -1;

	private const int DEFAULT_BUFFER_SIZE = 2048;

	
	private Provider _input;

	
	private char[] _data;

	private int _len;

	private int _pos;

	
		private Map eolCounts;

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public LineEndingProcessingProvider(int bufferSize, Provider input)
	{
		_len = 0;
		_pos = 0;
		eolCounts = new HashMap();
		_input = input;
		_data = new char[bufferSize];
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

	
	
	
	public LineEndingProcessingProvider(Provider input)
		: this(2048, input)
	{
	}

	
	
	
	public virtual void close()
	{
		_input.close();
	}

	
	
	public virtual LineSeparator getDetectedLineEnding()
	{
		LineSeparator lineEnding = LineSeparator.getLineEnding(((Integer)eolCounts.getOrDefault(LineSeparator.___003C_003ECR, Integer.valueOf(0))).intValue(), ((Integer)eolCounts.getOrDefault(LineSeparator.___003C_003ELF, Integer.valueOf(0))).intValue(), ((Integer)eolCounts.getOrDefault(LineSeparator.___003C_003ECRLF, Integer.valueOf(0))).intValue());
		
		return lineEnding;
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		Modifiers.Final,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		63,
		98,
		100,
		98,
		103,
		103,
		100,
		135,
		226,
		69,
		105,
		137,
		108,
		174,
		116,
		223,
		13,
		105,
		104,
		119,
		byte.MaxValue,
		19,
		69,
		99,
		130,
		194,
		137,
		101
	})]
	public virtual int read(char[] buffer, int offset, int len)
	{
		int num = offset;
		int num2 = offset + len;
		LineSeparator lineSeparator = null;
		while (num < num2)
		{
			int num3 = nextBufferedChar();
			if (num3 < 0)
			{
				if (num != offset)
				{
					break;
				}
				return -1;
			}
			string ending = java.lang.String.valueOf((char)num3);
			Optional optional = LineSeparator.lookup(ending);
			if (optional.isPresent())
			{
				LineSeparator lineSeparator2 = (LineSeparator)optional.get();
				eolCounts.putIfAbsent(lineSeparator2, Integer.valueOf(0));
				eolCounts.put(lineSeparator2, Integer.valueOf(((Integer)eolCounts.get(lineSeparator2)).intValue() + 1));
				if (lineSeparator2 == LineSeparator.___003C_003ELF && lineSeparator == LineSeparator.___003C_003ECR)
				{
					eolCounts.putIfAbsent(LineSeparator.___003C_003ECRLF, Integer.valueOf(0));
					eolCounts.put(LineSeparator.___003C_003ECRLF, Integer.valueOf(((Integer)eolCounts.get(LineSeparator.___003C_003ECRLF)).intValue() + 1));
				}
				lineSeparator = lineSeparator2;
			}
			else
			{
				lineSeparator = null;
			}
			int num4 = num;
			num++;
			buffer[num4] = (char)num3;
		}
		return num - offset;
	}

	void IDisposable.AutoCloseable_003A_003Aclose()
	{
		close();
	}
}
