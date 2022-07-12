
using com.github.javaparser.ast.expr;
using com.github.javaparser.utils;


namespace com.github.javaparser.ast.nodeTypes;

public interface NodeWithName
{
	
	public static class __DefaultMethods
	{
		public unsafe static Node setName(NodeWithName P_0, string P_1)
		{
			
			return _003Cdefault_003EsetName(P_0, P_1);
		}

		public unsafe static string getNameAsString(NodeWithName P_0)
		{
			
			return _003Cdefault_003EgetNameAsString(P_0);
		}
	}

	
	virtual string getNameAsString();

	
	
	
	static string _003Cdefault_003EgetNameAsString(NodeWithName P_0)
	{
		string result = P_0.getName().asString();
		
		return result;
	}

		
	virtual Node setName(Name name);

	virtual Name getName();

	
		
	virtual Node setName(string name);

	
	
	
	static Node _003Cdefault_003EsetName(NodeWithName P_0, string P_1)
	{
		Utils.assertNonEmpty(P_1);
		Node result = P_0.setName(StaticJavaParser.parseName(P_1));
		
		return result;
	}
}
