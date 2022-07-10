using System.Runtime.CompilerServices;
using IKVM.Attributes;

namespace com.github.javaparser.ast.nodeTypes.modifiers;


public class NodeWithStaticModifier : NodeWithModifiers
{
	
	public new static class __DefaultMethods
	{
		public unsafe static bool isStatic(NodeWithStaticModifier P_0)
		{
			
			return _003Cdefault_003EisStatic(P_0);
		}

		public unsafe static Node setStatic(NodeWithStaticModifier P_0, bool P_1)
		{
			
			return _003Cdefault_003EsetStatic(P_0, P_1);
		}
	}

	
	virtual bool isStatic();

	
	
	
	static bool _003Cdefault_003EisStatic(NodeWithStaticModifier P_0)
	{
		bool result = P_0.hasModifier(Modifier.Keyword.___003C_003ESTATIC);
		
		return result;
	}

	
		
	virtual Node setStatic(bool set);

	
	
	
	static Node _003Cdefault_003EsetStatic(NodeWithStaticModifier P_0, bool P_1)
	{
		Node result = P_0.setModifier(Modifier.Keyword.___003C_003ESTATIC, P_1);
		
		return result;
	}
}
