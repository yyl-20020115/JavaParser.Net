using com.github.javaparser.ast.expr;


namespace com.github.javaparser.ast.nodeTypes;

public interface NodeWithCondition
{
	virtual Expression getCondition();

		
	virtual Node setCondition(Expression condition);
}
