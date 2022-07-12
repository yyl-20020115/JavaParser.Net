
using com.github.javaparser.ast;

using java.lang;

namespace com.github.javaparser.printer.lexicalpreservation;

[NonNestedOuterClass("com.github.javaparser.printer.lexicalpreservation.DifferenceElementCalculator")]
[InnerClass("com.github.javaparser.printer.lexicalpreservation.DifferenceElementCalculator$ChildPositionInfo", Modifiers.Public | Modifiers.Static)]
public class DifferenceElementCalculator_0024ChildPositionInfo
{
	internal Node node;

	internal Integer position;

	
	
	
	internal DifferenceElementCalculator_0024ChildPositionInfo(Node node, Integer position)
	{
		this.node = node;
		this.position = position;
	}

	
	
	
	public override bool equals(object other)
	{
		if (other == null || !(other is DifferenceElementCalculator_0024ChildPositionInfo))
		{
			return false;
		}
		DifferenceElementCalculator_0024ChildPositionInfo differenceElementCalculator_0024ChildPositionInfo = (DifferenceElementCalculator_0024ChildPositionInfo)other;
		return (node.equals(differenceElementCalculator_0024ChildPositionInfo.node) && node.hasRange() && differenceElementCalculator_0024ChildPositionInfo.node.hasRange() && ((Range)node.getRange().get()).contains((Range)differenceElementCalculator_0024ChildPositionInfo.node.getRange().get())) ? true : false;
	}

	
	
	public override int GetHashCode()
	{
		return node.GetHashCode() + position.GetHashCode();
	}
}
