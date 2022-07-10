using IKVM.Attributes;
using java.util;

namespace com.github.javaparser.ast.nodeTypes;

public interface NodeWithTokenRange
{
		virtual Optional getTokenRange();

		
	virtual object setTokenRange(TokenRange range);
}
