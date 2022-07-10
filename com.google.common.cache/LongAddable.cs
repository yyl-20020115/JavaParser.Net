namespace com.google.common.cache;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/cache/ElementTypesAreNonnullByDefault;"
})]
internal interface LongAddable
{
	virtual void add(long P_0);

	virtual void increment();

	virtual long sum();
}
