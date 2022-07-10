using System.Runtime.CompilerServices;
using com.github.javaparser.utils;
using IKVM.Attributes;

namespace com.github.javaparser.ast.nodeTypes;

public interface NodeWithIdentifier
{
	
	public static class __DefaultMethods
	{
		public unsafe static string getId(NodeWithIdentifier P_0)
		{
			
			return _003Cdefault_003EgetId(P_0);
		}

		public unsafe static Node setId(NodeWithIdentifier P_0, string P_1)
		{
			
			return _003Cdefault_003EsetId(P_0, P_1);
		}
	}

	virtual string getIdentifier();

		
	virtual Node setIdentifier(string identifier);

	
	virtual string getId();

	
	
	
	static string _003Cdefault_003EgetId(NodeWithIdentifier P_0)
	{
		string identifier = P_0.getIdentifier();
		
		return identifier;
	}

	
		
	virtual Node setId(string identifier);

	
	
	
	static Node _003Cdefault_003EsetId(NodeWithIdentifier P_0, string P_1)
	{
		Utils.assertNonEmpty(P_1);
		Node result = P_0.setIdentifier(P_1);
		
		return result;
	}
}
