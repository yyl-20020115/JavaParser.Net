using com.github.javaparser.resolution.types;


namespace com.github.javaparser.resolution.declarations;


public interface ResolvedValueDeclaration : ResolvedDeclaration
{
	ResolvedType getType();
}
