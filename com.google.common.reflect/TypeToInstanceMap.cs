using com.google.errorprone.annotations;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.reflect;

[Signature("<B:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Map<Lcom/google/common/reflect/TypeToken<+TB;>;TB;>;")]
[DoNotMock(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/DoNotMock;",
	"value",
	"Use ImmutableTypeToInstanceMap or MutableTypeToInstanceMap"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/reflect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.util.Map" })]
public interface TypeToInstanceMap : Map
{
	[Signature("<T:TB;>(Ljava/lang/Class<TT;>;)TT;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	virtual object getInstance(Class c);

	[Signature("<T:TB;>(Lcom/google/common/reflect/TypeToken<TT;>;)TT;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	virtual object getInstance(TypeToken tt);

	[Signature("<T:TB;>(Ljava/lang/Class<TT;>;TT;)TT;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	virtual object putInstance(Class c, object obj);

	[Signature("<T:TB;>(Lcom/google/common/reflect/TypeToken<TT;>;TT;)TT;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	virtual object putInstance(TypeToken tt, object obj);
}
