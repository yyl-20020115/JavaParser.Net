using System.Runtime.CompilerServices;
using IKVM.Attributes;

namespace com.github.javaparser.ast.nodeTypes.modifiers;


public interface NodeWithFinalModifier : NodeWithModifiers
{
	
	public new static class __DefaultMethods
	{
		public unsafe static bool isFinal(NodeWithFinalModifier P_0)
		{
			
			return _003Cdefault_003EisFinal(P_0);
		}

		public unsafe static Node setFinal(NodeWithFinalModifier P_0, bool P_1)
		{
			
			return _003Cdefault_003EsetFinal(P_0, P_1);
		}
	}

	
		
	virtual Node setFinal(bool set);

	
	
	
	static Node _003Cdefault_003EsetFinal(NodeWithFinalModifier P_0, bool P_1)
	{
		Node result = P_0.setModifier(Modifier.Keyword.___003C_003EFINAL, P_1);
		
		return result;
	}

	
	virtual bool isFinal();

	
	
	
	static bool _003Cdefault_003EisFinal(NodeWithFinalModifier P_0)
	{
		bool result = P_0.hasModifier(Modifier.Keyword.___003C_003EFINAL);
		
		return result;
	}
}
