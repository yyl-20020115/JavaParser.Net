using com.github.javaparser.symbolsolver.model.resolution;
using IKVM.Attributes;
using java.util;

namespace com.github.javaparser.symbolsolver.logic;

public interface MethodResolutionCapability
{
		virtual SymbolReference solveMethod(string str, List l, bool b);
}
