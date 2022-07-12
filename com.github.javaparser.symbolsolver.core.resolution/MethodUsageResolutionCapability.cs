
using java.util;

namespace com.github.javaparser.symbolsolver.core.resolution;

public interface MethodUsageResolutionCapability
{
		virtual Optional solveMethodAsUsage(string str, List l1, Context c, List l2);
}
