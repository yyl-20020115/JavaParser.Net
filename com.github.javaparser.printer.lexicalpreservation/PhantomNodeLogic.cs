using System;

using com.github.javaparser.ast;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.type;

using java.lang;
using java.util;

namespace com.github.javaparser.printer.lexicalpreservation;


[Deprecated(new object[]
{
	(byte)64,
	"Ljava/lang/Deprecated;"
})]
public class PhantomNodeLogic
{
	
	
	internal sealed class _1 : AstObserverAdapter
	{
		
		
		internal _1()
		{
		}

		
		
		
		public override void parentChange(Node observedNode, Node previousParent, Node newParent)
		{
			access_0024000().remove(observedNode);
		}
	}

	private const int LEVELS_TO_EXPLORE = 3;

	
		private static Map isPhantomNodeCache;

	
	private static AstObserver cacheCleaner;

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
	internal static Map access_0024000()
	{
		return isPhantomNodeCache;
	}

	
	
	
	private static bool inPhantomNode(Node node, int levels)
	{
		return (node.getParentNode().isPresent() && (isPhantomNode((Node)node.getParentNode().get()) || inPhantomNode((Node)node.getParentNode().get(), levels - 1))) ? true : false;
	}

	
	
	
	internal static bool isPhantomNode(Node node)
	{
		if (isPhantomNodeCache.containsKey(node))
		{
			bool result = ((java.lang.Boolean)isPhantomNodeCache.get(node)).booleanValue();
			
			return result;
		}
		if (node is UnknownType)
		{
			return true;
		}
		int num = (((node.getParentNode().isPresent() && ((Node)node.getParentNode().get()).hasRange() && node.hasRange() && !((Range)((Node)node.getParentNode().get()).getRange().get()).contains((Range)node.getRange().get())) || inPhantomNode(node, 3)) ? 1 : 0);
		isPhantomNodeCache.put(node, java.lang.Boolean.valueOf((byte)num != 0));
		node.register(cacheCleaner);
		return (byte)num != 0;
	}

	
	
	public PhantomNodeLogic()
	{
	}

	
	
	public static void cleanUpCache()
	{
		isPhantomNodeCache.clear();
	}

	
	static PhantomNodeLogic()
	{
		isPhantomNodeCache = Collections.synchronizedMap(new IdentityHashMap());
		cacheCleaner = new _1();
	}
}
