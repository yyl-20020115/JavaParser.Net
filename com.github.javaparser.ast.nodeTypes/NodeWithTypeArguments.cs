using System.Runtime.CompilerServices;
using com.github.javaparser.ast.type;
using com.github.javaparser.metamodel;
using IKVM.Attributes;
using java.util;

namespace com.github.javaparser.ast.nodeTypes;

public interface NodeWithTypeArguments
{
	
	public static class __DefaultMethods
	{
		public unsafe static bool isUsingDiamondOperator(NodeWithTypeArguments P_0)
		{
			
			return _003Cdefault_003EisUsingDiamondOperator(P_0);
		}

		public unsafe static Node setDiamondOperator(NodeWithTypeArguments P_0)
		{
			
			return _003Cdefault_003EsetDiamondOperator(P_0);
		}

		public unsafe static Node removeTypeArguments(NodeWithTypeArguments P_0)
		{
			
			return _003Cdefault_003EremoveTypeArguments(P_0);
		}

		public unsafe static Node setTypeArguments(NodeWithTypeArguments P_0, Type[] P_1)
		{
			
			return _003Cdefault_003EsetTypeArguments(P_0, P_1);
		}
	}

		
	virtual Node setTypeArguments(NodeList typeArguments);

		virtual Optional getTypeArguments();

	
	[DerivedProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/DerivedProperty;"
	})]
	virtual bool isUsingDiamondOperator();

	
	
	
	static bool _003Cdefault_003EisUsingDiamondOperator(NodeWithTypeArguments P_0)
	{
		return (P_0.getTypeArguments().isPresent() && ((NodeList)P_0.getTypeArguments().get()).isEmpty()) ? true : false;
	}

	
		virtual Node setDiamondOperator();

	
	
	
	static Node _003Cdefault_003EsetDiamondOperator(NodeWithTypeArguments P_0)
	{
		Node result = P_0.setTypeArguments(new NodeList());
		
		return result;
	}

	
		virtual Node removeTypeArguments();

	
	
	
	static Node _003Cdefault_003EremoveTypeArguments(NodeWithTypeArguments P_0)
	{
		Node result = P_0.setTypeArguments((NodeList)null);
		
		return result;
	}

	
		
	virtual Node setTypeArguments(params Type[] typeArguments);

	
	
	
	static Node _003Cdefault_003EsetTypeArguments(NodeWithTypeArguments P_0, Type[] P_1)
	{
		Node result = P_0.setTypeArguments(NodeList.nodeList(P_1));
		
		return result;
	}
}
