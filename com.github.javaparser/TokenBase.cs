using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace com.github.javaparser;

public abstract class TokenBase
{
	internal int realKind;

	internal JavaToken javaToken;

	
	
	internal TokenBase()
	{
		realKind = 146;
		javaToken = null;
	}
}
