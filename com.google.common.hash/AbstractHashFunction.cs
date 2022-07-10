using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using java.lang;
using java.nio;
using java.nio.charset;

namespace com.google.common.hash;

[ConstantPool(new object[]
{
	(byte)40,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[Immutable(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/Immutable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/hash/ElementTypesAreNonnullByDefault;"
})]
internal abstract class AbstractHashFunction : Object, HashFunction
{
	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract Hasher newHasher();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 28, 146 })]
	public virtual Hasher newHasher(int P_0)
	{
		Preconditions.checkArgument(P_0 >= 0, "expectedInputSize must be >= 0 but was %s", P_0);
		Hasher result = newHasher();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 17, 107 })]
	public virtual HashCode hashBytes(byte[] P_0, int P_1, int P_2)
	{
		Preconditions.checkPositionIndexes(P_1, P_1 + P_2, P_0.Length);
		HashCode result = newHasher(P_2).putBytes(P_0, P_1, P_2).hash();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(32)]
	internal AbstractHashFunction()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;Lcom/google/common/hash/Funnel<-TT;>;)Lcom/google/common/hash/HashCode;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 40, 0, 0 })]
	[LineNumberTable(36)]
	public virtual HashCode hashObject([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/hash/ParametricNullness;"
	})] object P_0, Funnel P_1)
	{
		HashCode result = newHasher().putObject(P_0, P_1).hash();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 132, 106, 115 })]
	public virtual HashCode hashUnencodedChars(CharSequence P_0)
	{
		CharSequence charSequence = P_0;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSequence cs = default(CharSequence);
		object obj = (cs.___003Cref_003E = __003Cref_003E);
		int num = cs.length();
		Hasher hasher = newHasher(num * 2);
		obj = (cs.___003Cref_003E = __003Cref_003E);
		HashCode result = hasher.putUnencodedChars(cs).hash();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(47)]
	public virtual HashCode hashString(CharSequence P_0, Charset P_1)
	{
		CharSequence charSequence = P_0;
		object __003Cref_003E = charSequence.___003Cref_003E;
		Hasher hasher = newHasher();
		CharSequence cs = default(CharSequence);
		object obj = (cs.___003Cref_003E = __003Cref_003E);
		HashCode result = hasher.putString(cs, P_1).hash();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(52)]
	public virtual HashCode hashInt(int P_0)
	{
		HashCode result = newHasher(4).putInt(P_0).hash();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(57)]
	public virtual HashCode hashLong(long P_0)
	{
		HashCode result = newHasher(8).putLong(P_0).hash();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(62)]
	public virtual HashCode hashBytes(byte[] P_0)
	{
		HashCode result = hashBytes(P_0, 0, P_0.Length);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(73)]
	public virtual HashCode hashBytes(ByteBuffer P_0)
	{
		HashCode result = newHasher(P_0.remaining()).putBytes(P_0).hash();
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract int bits();
}
