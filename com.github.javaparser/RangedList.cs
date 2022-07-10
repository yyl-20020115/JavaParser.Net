using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using IKVM.Attributes;
using java.lang;

namespace com.github.javaparser;

internal class RangedList
{
	internal TokenRange range;

		internal NodeList list;

	
		
	
	internal RangedList(NodeList list)
	{
		TokenRange.___003Cclinit_003E();
		range = new TokenRange(JavaToken.___003C_003EINVALID, JavaToken.___003C_003EINVALID);
		this.list = list;
	}

	
	
	
	internal virtual void beginAt(JavaToken begin)
	{
		range = range.withBegin(begin);
	}

	
		
	
	internal virtual void add(Node t)
	{
		if (list == null)
		{
			list = new NodeList();
		}
		list.add(t);
	}

	
	
	
	internal virtual void endAt(JavaToken end)
	{
		range = range.withEnd(end);
	}
}
