using IKVM.Attributes;
using javax.annotation;

namespace com.google.common.cache;

[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/cache/ElementTypesAreNonnullByDefault;"
})]
internal interface ReferenceEntry
{
	virtual int getHash();

	[Signature("()TK;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	virtual object getKey();

	[Signature("()Lcom/google/common/cache/LocalCache$ValueReference<TK;TV;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	virtual LocalCache.ValueReference getValueReference();

	virtual long getAccessTime();

	virtual long getWriteTime();

	[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
	virtual void setNextInAccessQueue(ReferenceEntry P_0);

	[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
	virtual void setPreviousInAccessQueue(ReferenceEntry P_0);

	[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
	virtual void setNextInWriteQueue(ReferenceEntry P_0);

	[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
	virtual void setPreviousInWriteQueue(ReferenceEntry P_0);

	[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	virtual ReferenceEntry getNext();

	[Signature("(Lcom/google/common/cache/LocalCache$ValueReference<TK;TV;>;)V")]
	virtual void setValueReference(LocalCache.ValueReference P_0);

	virtual void setAccessTime(long P_0);

	[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
	virtual ReferenceEntry getNextInAccessQueue();

	[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
	virtual ReferenceEntry getPreviousInAccessQueue();

	virtual void setWriteTime(long P_0);

	[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
	virtual ReferenceEntry getNextInWriteQueue();

	[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
	virtual ReferenceEntry getPreviousInWriteQueue();
}
