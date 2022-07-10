using com.github.javaparser.resolution.types;

namespace com.github.javaparser.symbolsolver.logic;

public interface ObjectProvider
{
	 ResolvedReferenceType byName(string str);

	 ResolvedReferenceType @object();
}
