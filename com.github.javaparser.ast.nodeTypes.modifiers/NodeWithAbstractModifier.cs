using System.Runtime.CompilerServices;
using IKVM.Attributes;

namespace com.github.javaparser.ast.nodeTypes.modifiers;


public interface NodeWithAbstractModifier : NodeWithModifiers
{
	
	public new static class __DefaultMethods
	{
		public unsafe static bool isAbstract(NodeWithAbstractModifier P_0)
		{
			
			return _003Cdefault_003EisAbstract(P_0);
		}

		public unsafe static Node setAbstract(NodeWithAbstractModifier P_0, bool P_1)
		{
			
			return _003Cdefault_003EsetAbstract(P_0, P_1);
		}
	}

	
	virtual bool isAbstract();

	
	
	
	static bool _003Cdefault_003EisAbstract(NodeWithAbstractModifier P_0)
	{
		bool result = P_0.hasModifier(Modifier.Keyword.___003C_003EABSTRACT);
		
		return result;
	}

	
		
	virtual Node setAbstract(bool set);

	
	
	
	static Node _003Cdefault_003EsetAbstract(NodeWithAbstractModifier P_0, bool P_1)
	{
		Node result = P_0.setModifier(Modifier.Keyword.___003C_003EABSTRACT, P_1);
		
		return result;
	}
}
