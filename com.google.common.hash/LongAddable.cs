namespace com.google.common.hash;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/hash/ElementTypesAreNonnullByDefault;"
})]
internal interface LongAddable
{
	virtual void add(long P_0);

	virtual void increment();

	virtual long sum();
}
