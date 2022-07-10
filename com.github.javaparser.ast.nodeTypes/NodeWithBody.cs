using System.Runtime.CompilerServices;
using com.github.javaparser.ast.stmt;
using IKVM.Attributes;
using java.lang;
using java.util.function;

namespace com.github.javaparser.ast.nodeTypes;

public interface NodeWithBody
{
	private static class ___003C_003EPIM
	{
		
		
		
		
		internal static Boolean lambda_0024hasEmptyBody_00240(BlockStmt bs)
		{
			Boolean result = Boolean.valueOf(bs.isEmpty());
			
			return result;
		}
	}

	
	public static class __DefaultMethods
	{
		public unsafe static BlockStmt createBlockStatementAsBody(NodeWithBody P_0)
		{
			
			return _003Cdefault_003EcreateBlockStatementAsBody(P_0);
		}

		public unsafe static bool hasEmptyBody(NodeWithBody P_0)
		{
			
			return _003Cdefault_003EhasEmptyBody(P_0);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Function
	{
		internal ___003C_003EAnon1()
		{
		}

		public object apply(object P_0)
		{
			Boolean result = ___003C_003EPIM.lambda_0024hasEmptyBody_00240((BlockStmt)P_0);
			
			return result;
		}

		
		public Function compose(Function P_0)
		{
			return Function._003Cdefault_003Ecompose(this, P_0);
		}

		
		public Function andThen(Function P_0)
		{
			return Function._003Cdefault_003EandThen(this, P_0);
		}
	}

		
	virtual Node setBody(Statement body);

	virtual Statement getBody();

	
	 BlockStmt createBlockStatementAsBody();

	
	
	
	static BlockStmt _003Cdefault_003EcreateBlockStatementAsBody(NodeWithBody P_0)
	{
		BlockStmt blockStmt = new BlockStmt();
		P_0.setBody(blockStmt);
		return blockStmt;
	}

	
	virtual bool hasEmptyBody();

	
	
	
	static bool _003Cdefault_003EhasEmptyBody(NodeWithBody P_0)
	{
		Statement body = P_0.getBody();
		bool result = ((Boolean)body.toBlockStmt().map(new ___003C_003EAnon1()).orElse(Boolean.valueOf(body.isEmptyStmt()))).booleanValue();
		
		return result;
	}
}
