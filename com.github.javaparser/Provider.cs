
using java.io;
using java.lang;

namespace com.github.javaparser;


public interface Provider : Closeable, AutoCloseable
{
	
	
	int read(char[] aDest, int nOfs, int nLen);
}
