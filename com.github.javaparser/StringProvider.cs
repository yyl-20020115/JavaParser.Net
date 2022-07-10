using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.lang;

namespace com.github.javaparser;


public class StringProvider :  Provider, Closeable, AutoCloseable
{
	private string m_sStr;

	private int m_nPos;

	
	private int m_nLen;

	
	
	
	public StringProvider(string sStr)
	{
		m_nPos = 0;
		m_sStr = sStr;
		m_nLen = java.lang.String.instancehelper_length(sStr);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		159, 184, 110, 100, 130, 101, 100, 98, 100, 130,
		123, 142
	})]
	public virtual int read(char[] aDest, int nOfs, int nLen)
	{
		int num = m_nLen - m_nPos;
		if (num <= 0)
		{
			return -1;
		}
		int num2 = (int)((nint)aDest.LongLength - nOfs);
		if (nLen < num2)
		{
			num2 = nLen;
		}
		if (num < num2)
		{
			num2 = num;
		}
		java.lang.String.instancehelper_getChars(m_sStr, m_nPos, m_nPos + num2, aDest, nOfs);
		m_nPos += num2;
		return num2;
	}

	public virtual void close()
	{
		m_sStr = null;
	}

	void IDisposable.AutoCloseable_003A_003Aclose()
	{
		close();
	}
}
