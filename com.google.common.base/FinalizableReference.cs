using com.google.errorprone.annotations;

namespace com.google.common.@base;

[DoNotMock(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/DoNotMock;",
	"value",
	"Use an instance of one of the Finalizable*Reference classes"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
public interface FinalizableReference
{
	virtual void finalizeReferent();
}
