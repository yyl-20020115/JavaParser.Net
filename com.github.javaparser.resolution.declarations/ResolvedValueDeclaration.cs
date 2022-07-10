using com.github.javaparser.resolution.types;
using IKVM.Attributes;

namespace com.github.javaparser.resolution.declarations;


public interface ResolvedValueDeclaration : ResolvedDeclaration
{
	ResolvedType getType();
}
