
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.stmt;

using java.util;

namespace com.github.javaparser.ast.nodeTypes;

public interface SwitchNode
{
	
	public static class __DefaultMethods
	{
		public unsafe static bool isEmpty(SwitchNode P_0)
		{
			
			return _003Cdefault_003EisEmpty(P_0);
		}
	}

		virtual NodeList getEntries();

	
	virtual SwitchEntry getEntry(int i);

	virtual Expression getSelector();

		
	virtual SwitchNode setEntries(NodeList entries);

	
	virtual SwitchNode setSelector(Expression selector);

	
	virtual bool remove(Node node);

	virtual SwitchNode clone();

	
	virtual bool replace(Node node, Node replacementNode);

		virtual Optional getComment();

	
	virtual bool isEmpty();

	
	
	
	static bool _003Cdefault_003EisEmpty(SwitchNode P_0)
	{
		bool result = P_0.getEntries().isEmpty();
		
		return result;
	}
}
