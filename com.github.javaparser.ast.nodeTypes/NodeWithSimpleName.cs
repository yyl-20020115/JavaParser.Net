
using com.github.javaparser.ast.expr;
using com.github.javaparser.utils;


namespace com.github.javaparser.ast.nodeTypes;

public interface NodeWithSimpleName
{
	
	public static class __DefaultMethods
	{
		public unsafe static Node setName(NodeWithSimpleName P_0, string P_1)
		{
			
			return _003Cdefault_003EsetName(P_0, P_1);
		}

		public unsafe static string getNameAsString(NodeWithSimpleName P_0)
		{
			
			return _003Cdefault_003EgetNameAsString(P_0);
		}

		public unsafe static NameExpr getNameAsExpression(NodeWithSimpleName P_0)
		{
			
			return _003Cdefault_003EgetNameAsExpression(P_0);
		}
	}

	
	virtual string getNameAsString();

	
	
	
	static string _003Cdefault_003EgetNameAsString(NodeWithSimpleName P_0)
	{
		string identifier = P_0.getName().getIdentifier();
		
		return identifier;
	}

	
		
	virtual Node setName(string name);

	
	
	
	static Node _003Cdefault_003EsetName(NodeWithSimpleName P_0, string P_1)
	{
		Utils.assertNonEmpty(P_1);
		Node result = P_0.setName(new SimpleName(P_1));
		
		return result;
	}

		
	virtual Node setName(SimpleName name);

	virtual SimpleName getName();

	
	virtual NameExpr getNameAsExpression();

	
	
	
	static NameExpr _003Cdefault_003EgetNameAsExpression(NodeWithSimpleName P_0)
	{
		NameExpr.___003Cclinit_003E();
		NameExpr result = new NameExpr(P_0.getName());
		
		return result;
	}
}
