
using java.lang;

namespace com.github.javaparser.resolution.types;

[FunctionalInterface(new object[]
{
	(byte)64,
	"Ljava/lang/FunctionalInterface;"
})]
public interface ResolvedTypeTransformer
{
	
	virtual ResolvedType transform(ResolvedType type);
}
