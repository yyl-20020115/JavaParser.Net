using System.Runtime.CompilerServices;
using com.github.javaparser.ast.stmt;
using IKVM.Attributes;
using java.util;

namespace com.github.javaparser.ast.nodeTypes;

public interface NodeWithOptionalBlockStmt
{
	
	public static class __DefaultMethods
	{
		public unsafe static BlockStmt createBody(NodeWithOptionalBlockStmt P_0)
		{
			
			return _003Cdefault_003EcreateBody(P_0);
		}
	}

		
	virtual Node setBody(BlockStmt block);

		virtual Optional getBody();

		virtual Node removeBody();

	
	virtual BlockStmt createBody();

	
	
	
	static BlockStmt _003Cdefault_003EcreateBody(NodeWithOptionalBlockStmt P_0)
	{
		BlockStmt blockStmt = new BlockStmt();
		P_0.setBody(blockStmt);
		return blockStmt;
	}
}
