using System.Runtime.CompilerServices;
using IKVM.Attributes;

namespace com.github.javaparser.ast.nodeTypes.modifiers;


public interface NodeWithPrivateModifier : NodeWithModifiers
{
	
	public new static class __DefaultMethods
	{
		public unsafe static bool isPrivate(NodeWithPrivateModifier P_0)
		{
			
			return _003Cdefault_003EisPrivate(P_0);
		}

		public unsafe static Node setPrivate(NodeWithPrivateModifier P_0, bool P_1)
		{
			
			return _003Cdefault_003EsetPrivate(P_0, P_1);
		}
	}

	
	virtual bool isPrivate();

	
	
	
	static bool _003Cdefault_003EisPrivate(NodeWithPrivateModifier P_0)
	{
		bool result = P_0.hasModifier(Modifier.Keyword.___003C_003EPRIVATE);
		
		return result;
	}

	
		
	virtual Node setPrivate(bool set);

	
	
	
	static Node _003Cdefault_003EsetPrivate(NodeWithPrivateModifier P_0, bool P_1)
	{
		Node result = P_0.setModifier(Modifier.Keyword.___003C_003EPRIVATE, P_1);
		
		return result;
	}
}
