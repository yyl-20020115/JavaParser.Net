using com.github.javaparser.resolution;
using IKVM.Attributes;
using java.util;

namespace com.github.javaparser.symbolsolver.core.resolution;

public interface TypeVariableResolutionCapability
{
		virtual MethodUsage resolveTypeVariables(Context c, List l);
}
