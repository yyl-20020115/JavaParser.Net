


namespace com.github.javaparser.ast.nodeTypes.modifiers;


public class NodeWithProtectedModifier : NodeWithModifiers
{
	
	public new static class __DefaultMethods
	{
		public unsafe static bool isProtected(NodeWithProtectedModifier P_0)
		{
			
			return _003Cdefault_003EisProtected(P_0);
		}

		public unsafe static Node setProtected(NodeWithProtectedModifier P_0, bool P_1)
		{
			
			return _003Cdefault_003EsetProtected(P_0, P_1);
		}
	}

	
	virtual bool isProtected();

	
	
	
	static bool _003Cdefault_003EisProtected(NodeWithProtectedModifier P_0)
	{
		bool result = P_0.hasModifier(Modifier.Keyword.___003C_003EPROTECTED);
		
		return result;
	}

	
		
	virtual Node setProtected(bool set);

	
	
	
	static Node _003Cdefault_003EsetProtected(NodeWithProtectedModifier P_0, bool P_1)
	{
		Node result = P_0.setModifier(Modifier.Keyword.___003C_003EPROTECTED, P_1);
		
		return result;
	}
}
