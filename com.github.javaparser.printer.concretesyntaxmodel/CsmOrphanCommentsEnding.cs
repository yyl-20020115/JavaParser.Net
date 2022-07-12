
using com.github.javaparser.ast;
using com.github.javaparser.ast.comments;
using com.github.javaparser.utils;

using java.lang;
using java.util;

namespace com.github.javaparser.printer.concretesyntaxmodel;

public class CsmOrphanCommentsEnding: CsmElement
{
	
	
	public CsmOrphanCommentsEnding()
	{
	}

	
	
	
	public virtual void prettyPrint(Node node, SourcePrinter printer)
	{
		LinkedList linkedList = new LinkedList();
		((List)linkedList).addAll((Collection)node.getChildNodes());
		PositionUtils.sortByBeginPosition(linkedList);
		if (((List)linkedList).isEmpty())
		{
			return;
		}
		int num = 0;
		int num2 = 1;
		while (num2 != 0 && num < ((List)linkedList).size())
		{
			Node node2 = (Node)((List)linkedList).get(((List)linkedList).size() - 1 - num);
			num2 = ((node2 is Comment) ? 1 : 0);
			if (num2 != 0)
			{
				num++;
			}
		}
		for (int i = 0; i < num; i++)
		{
			Comment comment = (Comment)((List)linkedList).get(((List)linkedList).size() - num + i);
			CsmComment.process(comment, printer);
		}
	}
}
