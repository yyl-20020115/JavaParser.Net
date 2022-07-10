using System;
using IKVM.Attributes;

namespace com.google.common.util.concurrent;

[Signature("<V:Ljava/lang/Object;>Ljava/lang/Object;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 19, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)19,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
public interface FutureCallback
{
	[Signature("(TV;)V")]
	virtual void onSuccess([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})] object obj);

	virtual void onFailure(Exception t);
}
