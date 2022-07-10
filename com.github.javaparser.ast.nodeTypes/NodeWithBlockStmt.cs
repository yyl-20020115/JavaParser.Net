using System.Runtime.CompilerServices;
using com.github.javaparser.ast.stmt;
using IKVM.Attributes;

namespace com.github.javaparser.ast.nodeTypes;

public interface NodeWithBlockStmt
{
	
	public static class __DefaultMethods
	{
		public unsafe static BlockStmt createBody(NodeWithBlockStmt P_0)
		{
			
			return _003Cdefault_003EcreateBody(P_0);
		}
	}

		
	virtual Node setBody(BlockStmt block);

	virtual BlockStmt getBody();

	
	virtual BlockStmt createBody();

	
	
	
	static BlockStmt _003Cdefault_003EcreateBody(NodeWithBlockStmt P_0)
	{
		BlockStmt blockStmt = new BlockStmt();
		P_0.setBody(blockStmt);
		return blockStmt;
	}
}
