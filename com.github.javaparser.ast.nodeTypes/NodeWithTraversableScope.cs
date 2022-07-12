
using java.util;

namespace com.github.javaparser.ast.nodeTypes;

public interface NodeWithTraversableScope
{
		virtual Optional traverseScope();
}
