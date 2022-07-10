using IKVM.Attributes;
using java.io;
using java.lang;

namespace com.github.javaparser;


public interface Provider : Closeable, AutoCloseable
{
	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	int read(char[] aDest, int nOfs, int nLen);
}
