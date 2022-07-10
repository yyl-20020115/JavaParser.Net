namespace com.google.common.@base;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
internal interface PatternCompiler
{
	virtual CommonPattern compile(string P_0);

	virtual bool isPcreLike();
}
