using com.google.errorprone.annotations;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<B:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Map<Ljava/lang/Class<+TB;>;TB;>;")]
[DoNotMock(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/DoNotMock;",
	"value",
	"Use ImmutableClassToInstanceMap or MutableClassToInstanceMap"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.util.Map" })]
public interface ClassToInstanceMap : Map
{
	[Signature("<T:TB;>(Ljava/lang/Class<TT;>;)TT;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	virtual object getInstance(Class c);

	[Signature("<T:TB;>(Ljava/lang/Class<TT;>;TT;)TT;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	virtual object putInstance(Class c, object obj);
}
