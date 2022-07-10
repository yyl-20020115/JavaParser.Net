using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;

namespace com.github.javaparser;

public abstract class AbstractCharStream : CharStream
{
	public const int DEFAULT_BUF_SIZE = 4096;

	private int m_nTabSize;

	protected internal char[] buffer;

	protected internal int bufsize;

	protected internal int bufpos;

	protected internal int available;

	protected internal int tokenBegin;

	protected internal int inBuf;

	protected internal int maxNextCharInd;

	private int[] m_aBufLine;

	private int[] m_aBufColumn;

	private int m_nLineNo;

	private int m_nColumnNo;

	private bool m_bPrevCharIsCR;

	private bool m_bPrevCharIsLF;

	private bool m_bTrackLineColumn;

	public void reInit(int nStartLine, int nStartColumn, int nBufferSize)
	{
		m_nLineNo = nStartLine;
		m_nColumnNo = nStartColumn - 1;
		m_bPrevCharIsCR = false;
		m_bPrevCharIsLF = false;
		if (buffer == null || (nint)nBufferSize != (nint)buffer.LongLength)
		{
			bufsize = nBufferSize;
			available = nBufferSize;
			buffer = new char[nBufferSize];
			m_aBufLine = new int[nBufferSize];
			m_aBufColumn = new int[nBufferSize];
		}
		maxNextCharInd = 0;
		inBuf = 0;
		tokenBegin = 0;
		bufpos = -1;
	}

	protected internal virtual int getBufSizeAfterExpansion()
	{
		return bufsize * 2;
	}

	
	
	protected internal virtual void expandBuff(bool bWrapAround)
	{
		int bufSizeAfterExpansion = getBufSizeAfterExpansion();
		char[] dest = new char[bufSizeAfterExpansion];
		int[] array = new int[bufSizeAfterExpansion];
		int[] array2 = new int[bufSizeAfterExpansion];
		int num = bufsize - tokenBegin;
		if (bWrapAround)
		{
			ByteCodeHelper.arraycopy_primitive_2(buffer, tokenBegin, dest, 0, num);
			ByteCodeHelper.arraycopy_primitive_2(buffer, 0, dest, num, bufpos);
			buffer = dest;
			ByteCodeHelper.arraycopy_primitive_4(m_aBufLine, tokenBegin, array, 0, num);
			ByteCodeHelper.arraycopy_primitive_4(m_aBufLine, 0, array, num, bufpos);
			m_aBufLine = array;
			ByteCodeHelper.arraycopy_primitive_4(m_aBufColumn, tokenBegin, array2, 0, num);
			ByteCodeHelper.arraycopy_primitive_4(m_aBufColumn, 0, array2, num, bufpos);
			m_aBufColumn = array2;
			bufpos += num;
			maxNextCharInd = bufpos;
		}
		else
		{
			ByteCodeHelper.arraycopy_primitive_2(buffer, tokenBegin, dest, 0, num);
			buffer = dest;
			ByteCodeHelper.arraycopy_primitive_4(m_aBufLine, tokenBegin, array, 0, num);
			m_aBufLine = array;
			ByteCodeHelper.arraycopy_primitive_4(m_aBufColumn, tokenBegin, array2, 0, num);
			m_aBufColumn = array2;
			bufpos -= tokenBegin;
			maxNextCharInd = bufpos;
		}
		bufsize = bufSizeAfterExpansion;
		available = bufSizeAfterExpansion;
		tokenBegin = 0;
	}

	
	protected internal void internalAdjustBuffSize()
	{
		int num = bufsize / 2;
		if (available == bufsize)
		{
			if (tokenBegin < 0)
			{
				bufpos = 0;
				maxNextCharInd = 0;
			}
			else if (tokenBegin > num)
			{
				bufpos = 0;
				maxNextCharInd = 0;
				available = tokenBegin;
			}
			else
			{
				expandBuff(bWrapAround: false);
			}
		}
		else if (available > tokenBegin)
		{
			available = bufsize;
		}
		else if (tokenBegin - available < num)
		{
			expandBuff(bWrapAround: true);
		}
		else
		{
			available = tokenBegin;
		}
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	protected internal abstract int streamRead(char[] aBuf, int nOfs, int nLen);

	
	protected internal abstract void streamClose();

	
	
	
	public virtual void backup(int nAmount)
	{
		if (nAmount > bufsize)
		{
			string s = new StringBuilder().append("Cannot back ").append(nAmount).append(" chars which is larger than the internal buffer size (")
				.append(bufsize)
				.append(")")
				.ToString();
			
			throw new IllegalStateException(s);
		}
		inBuf += nAmount;
		bufpos -= nAmount;
		if (bufpos < 0)
		{
			bufpos += bufsize;
		}
	}

	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	protected internal void internalSetBufLineColumn(int nLine, int nColumn)
	{
		m_aBufLine[bufpos] = nLine;
		m_aBufColumn[bufpos] = nColumn;
	}

	
	
	[LineNumberTable(new byte[]
	{
		160,
		172,
		110,
		230,
		69,
		127,
		1,
		164,
		166,
		144,
		byte.MaxValue,
		1,
		77,
		226,
		53,
		129,
		142,
		103,
		169,
		140,
		135
	})]
	protected internal virtual void fillBuff()
	{
		if (maxNextCharInd == available)
		{
			internalAdjustBuffSize();
		}
		IOException ex;
		try
		{
			int num = streamRead(buffer, maxNextCharInd, available - maxNextCharInd);
			if (num == -1)
			{
				streamClose();
				
				throw new IOException("PGCC end of stream");
			}
			maxNextCharInd += num;
			return;
		}
		catch (IOException x)
		{
			ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		IOException ex2 = ex;
		bufpos--;
		backup(0);
		if (tokenBegin == -1)
		{
			tokenBegin = bufpos;
		}
		throw ex2;
	}

	
	
	[LineNumberTable(new byte[]
	{
		159, 61, 98, 142, 200, 103, 103, 176, 136, 103,
		165, 233, 69, 103, 206, 191, 0, 103, 130, 103,
		130, 110, 223, 11, 116
	})]
	protected internal void internalUpdateLineColumn(char c)
	{
		m_nColumnNo++;
		if (m_bPrevCharIsLF)
		{
			m_bPrevCharIsLF = false;
			m_nColumnNo = 1;
			m_nLineNo++;
		}
		else if (m_bPrevCharIsCR)
		{
			m_bPrevCharIsCR = false;
			if (c == '\n')
			{
				m_bPrevCharIsLF = true;
			}
			else
			{
				m_nColumnNo = 1;
				m_nLineNo++;
			}
		}
		switch (c)
		{
		case '\r':
			m_bPrevCharIsCR = true;
			break;
		case '\n':
			m_bPrevCharIsLF = true;
			break;
		case '\t':
		{
			m_nColumnNo--;
			int nColumnNo = m_nColumnNo;
			int nTabSize = m_nTabSize;
			int nColumnNo2 = m_nColumnNo;
			int nTabSize2 = m_nTabSize;
			m_nColumnNo = nColumnNo + (nTabSize - ((nTabSize2 != -1) ? (nColumnNo2 % nTabSize2) : 0));
			break;
		}
		}
		internalSetBufLineColumn(m_nLineNo, m_nColumnNo);
	}

	
	
	[LineNumberTable(new byte[]
	{
		161, 1, 169, 142, 110, 174, 167, 174, 110, 110,
		134, 142, 104, 103
	})]
	public virtual char readChar()
	{
		if (inBuf > 0)
		{
			inBuf--;
			bufpos++;
			if (bufpos == bufsize)
			{
				bufpos = 0;
			}
			return buffer[bufpos];
		}
		bufpos++;
		if (bufpos >= maxNextCharInd)
		{
			fillBuff();
		}
		int num = buffer[bufpos];
		if (m_bTrackLineColumn)
		{
			internalUpdateLineColumn((char)num);
		}
		return (char)num;
	}

	
	
	
	
	[LineNumberTable(new byte[]
	{
		159, 133, 162, 191, 160, 136, 130, 130, 130, 130,
		130, 130, 130, 130, 130, 163, 163, 163, 163, 163,
		163, 131
	})]
	internal static int hexval(char c)
	{
		switch (c)
		{
		case '0':
			return 0;
		case '1':
			return 1;
		case '2':
			return 2;
		case '3':
			return 3;
		case '4':
			return 4;
		case '5':
			return 5;
		case '6':
			return 6;
		case '7':
			return 7;
		case '8':
			return 8;
		case '9':
			return 9;
		case 'A':
		case 'a':
			return 10;
		case 'B':
		case 'b':
			return 11;
		case 'C':
		case 'c':
			return 12;
		case 'D':
		case 'd':
			return 13;
		case 'E':
		case 'e':
			return 14;
		case 'F':
		case 'f':
			return 15;
		default:
		{
			string message = new StringBuilder().append("Invalid hex char '").append(c).append("' (=")
				.append((int)c)
				.append(") provided!")
				.ToString();
			
			throw new IOException(message);
		}
		}
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public AbstractCharStream(int nStartLine, int nStartColumn, int nBufferSize)
	{
		m_nTabSize = 1;
		m_bTrackLineColumn = true;
		reInit(nStartLine, nStartColumn, nBufferSize);
	}

	
	
	
	public virtual char beginToken()
	{
		tokenBegin = -1;
		int result = readChar();
		tokenBegin = bufpos;
		return (char)result;
	}

	
	public virtual int getBeginColumn()
	{
		return m_aBufColumn[tokenBegin];
	}

	
	public virtual int getBeginLine()
	{
		return m_aBufLine[tokenBegin];
	}

	
	public virtual int getEndColumn()
	{
		return m_aBufColumn[bufpos];
	}

	
	public virtual int getEndLine()
	{
		return m_aBufLine[bufpos];
	}

	
	
	public virtual string getImage()
	{
		if (bufpos >= tokenBegin)
		{
			string result = String.newhelper(buffer, tokenBegin, bufpos - tokenBegin + 1);
			
			return result;
		}
		string result2 = new StringBuilder().append(String.newhelper(buffer, tokenBegin, bufsize - tokenBegin)).append(String.newhelper(buffer, 0, bufpos + 1)).ToString();
		
		return result2;
	}

	
	
	public virtual char[] getSuffix(int len)
	{
		char[] array = new char[len];
		if (bufpos + 1 >= len)
		{
			ByteCodeHelper.arraycopy_primitive_2(buffer, bufpos - len + 1, array, 0, len);
		}
		else
		{
			int num = len - bufpos - 1;
			ByteCodeHelper.arraycopy_primitive_2(buffer, bufsize - num, array, 0, num);
			ByteCodeHelper.arraycopy_primitive_2(buffer, 0, array, num, bufpos + 1);
		}
		return array;
	}

	public virtual void done()
	{
		buffer = null;
		m_aBufLine = null;
		m_aBufColumn = null;
	}

	public int getTabSize()
	{
		return m_nTabSize;
	}

	
	public void setTabSize(int nTabSize)
	{
		m_nTabSize = nTabSize;
	}

	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		161, 123, 103, 162, 142, 217, 190, 98, 99, 98,
		98, 163, 159, 36, 106, 120, 109, 100, 169, 135,
		110, 141, 171, 127, 26, 147, 207, 111, 111
	})]
	public void adjustBeginLineColumn(int nNewLine, int newCol)
	{
		int num = tokenBegin;
		int num2 = nNewLine;
		int num3 = ((bufpos < tokenBegin) ? (bufsize - tokenBegin + bufpos + 1 + inBuf) : (bufpos - tokenBegin + inBuf + 1));
		int i = 0;
		int num4 = 0;
		_ = 0;
		_ = 0;
		int num5 = 0;
		for (; i < num3; i++)
		{
			int[] aBufLine = m_aBufLine;
			int num6 = num;
			int num7 = bufsize;
			int num8 = aBufLine[num4 = ((num7 != -1) ? (num6 % num7) : 0)];
			int[] aBufLine2 = m_aBufLine;
			num++;
			int num9 = num;
			int num10 = bufsize;
			int num11;
			if (num8 != aBufLine2[num11 = ((num10 != -1) ? (num9 % num10) : 0)])
			{
				break;
			}
			m_aBufLine[num4] = num2;
			int num12 = num5 + m_aBufColumn[num11] - m_aBufColumn[num4];
			m_aBufColumn[num4] = newCol + num5;
			num5 = num12;
		}
		if (i < num3)
		{
			int[] aBufLine3 = m_aBufLine;
			int num13 = num4;
			int num14 = num2;
			num2++;
			aBufLine3[num13] = num14;
			m_aBufColumn[num4] = newCol + num5;
			while (true)
			{
				int num15 = i;
				i++;
				if (num15 >= num3)
				{
					break;
				}
				int[] aBufLine4 = m_aBufLine;
				int num16 = num;
				int num17 = bufsize;
				int num18 = aBufLine4[num4 = ((num17 != -1) ? (num16 % num17) : 0)];
				int[] aBufLine5 = m_aBufLine;
				num++;
				int num19 = num;
				int num20 = bufsize;
				if (num18 != aBufLine5[(num20 != -1) ? (num19 % num20) : 0])
				{
					int[] aBufLine6 = m_aBufLine;
					int num21 = num4;
					int num22 = num2;
					num2++;
					aBufLine6[num21] = num22;
				}
				else
				{
					m_aBufLine[num4] = num2;
				}
			}
		}
		m_nLineNo = m_aBufLine[num4];
		m_nColumnNo = m_aBufColumn[num4];
	}

	protected internal int getLine()
	{
		return m_nLineNo;
	}

	protected internal int getColumn()
	{
		return m_nColumnNo;
	}

	public bool isTrackLineColumn()
	{
		return m_bTrackLineColumn;
	}

	
	public void setTrackLineColumn(bool bTrackLineColumn)
	{
		int num = ((m_bTrackLineColumn = bTrackLineColumn) ? 1 : 0);
	}
}
