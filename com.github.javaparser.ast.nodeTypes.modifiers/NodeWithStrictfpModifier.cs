


namespace com.github.javaparser.ast.nodeTypes.modifiers;


public class NodeWithStrictfpModifier : NodeWithModifiers
{
	
	public new static class __DefaultMethods
	{
		public unsafe static bool isStrictfp(NodeWithStrictfpModifier P_0)
		{
			
			return _003Cdefault_003EisStrictfp(P_0);
		}

		public unsafe static Node setStrictfp(NodeWithStrictfpModifier P_0, bool P_1)
		{
			
			return _003Cdefault_003EsetStrictfp(P_0, P_1);
		}
	}

	
	virtual bool isStrictfp();

	
	
	
	static bool _003Cdefault_003EisStrictfp(NodeWithStrictfpModifier P_0)
	{
		bool result = P_0.hasModifier(Modifier.Keyword.___003C_003ESTRICTFP);
		
		return result;
	}

	
		
	virtual Node setStrictfp(bool set);

	
	
	
	static Node _003Cdefault_003EsetStrictfp(NodeWithStrictfpModifier P_0, bool P_1)
	{
		Node result = P_0.setModifier(Modifier.Keyword.___003C_003ESTRICTFP, P_1);
		
		return result;
	}
}
