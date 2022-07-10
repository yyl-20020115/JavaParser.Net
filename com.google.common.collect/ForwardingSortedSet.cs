using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.lang;
using IKVM.Runtime;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingSet<TE;>;Ljava/util/SortedSet<TE;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 70, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)70,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.util.SortedSet" })]
public abstract class ForwardingSortedSet : ForwardingSet, SortedSet, Set, Collection, Iterable, IEnumerable
{
	[Signature("()Ljava/util/SortedSet<TE;>;")]
	protected internal new abstract SortedSet @delegate();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Comparator<-TE;>;")]
	[LineNumberTable(71)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Comparator comparator()
	{
		Comparator result = @delegate().comparator();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)Ljava/util/SortedSet<TE;>;")]
	[LineNumberTable(98)]
	public virtual SortedSet tailSet([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object fromElement)
	{
		SortedSet result = @delegate().tailSet(fromElement);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(63)]
	protected internal ForwardingSortedSet()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(77)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public virtual object first()
	{
		object result = @delegate().first();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)Ljava/util/SortedSet<TE;>;")]
	[LineNumberTable(82)]
	public virtual SortedSet headSet([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object toElement)
	{
		SortedSet result = @delegate().headSet(toElement);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(88)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public virtual object last()
	{
		object result = @delegate().last();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;TE;)Ljava/util/SortedSet<TE;>;")]
	[LineNumberTable(93)]
	public virtual SortedSet subSet([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object fromElement, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object toElement)
	{
		SortedSet result = @delegate().subSet(fromElement, toElement);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 64, 98, 109, 127, 33, 97 })]
	protected internal override bool standardContains([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object @object)
	{
		//Discarded unreachable code: IL_0024
		try
		{
			try
			{
				try
				{
					object obj = ((SortedSet)this).tailSet(@object).first();
					return (ForwardingSortedMap.unsafeCompare(comparator(), obj, @object) == 0) ? true : false;
				}
				catch (System.Exception x)
				{
					if (ByteCodeHelper.MapException<ClassCastException>(x, ByteCodeHelper.MapFlags.Unused) == null)
					{
						throw;
					}
				}
			}
			catch (NoSuchElementException)
			{
				goto IL_0048;
			}
		}
		catch (System.Exception x2)
		{
			if (ByteCodeHelper.MapException<NullPointerException>(x2, ByteCodeHelper.MapFlags.Unused) == null)
			{
				throw;
			}
			goto IL_004b;
		}
		object obj2 = null;
		goto IL_004f;
		IL_004b:
		obj2 = null;
		goto IL_004f;
		IL_0048:
		obj2 = null;
		goto IL_004f;
		IL_004f:
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		85,
		98,
		109,
		104,
		103,
		111,
		102,
		byte.MaxValue,
		14,
		69,
		2,
		97,
		130
	})]
	protected internal override bool standardRemove([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object @object)
	{
		//Discarded unreachable code: IL_0038
		try
		{
			try
			{
				Iterator iterator = ((SortedSet)this).tailSet(@object).iterator();
				if (iterator.hasNext())
				{
					object obj = iterator.next();
					if (ForwardingSortedMap.unsafeCompare(comparator(), obj, @object) == 0)
					{
						iterator.remove();
						return true;
					}
				}
			}
			catch (System.Exception x)
			{
				if (ByteCodeHelper.MapException<ClassCastException>(x, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0059;
			}
		}
		catch (System.Exception x2)
		{
			if (ByteCodeHelper.MapException<NullPointerException>(x2, ByteCodeHelper.MapFlags.Unused) == null)
			{
				throw;
			}
			goto IL_005c;
		}
		return false;
		IL_005c:
		object obj2 = null;
		goto IL_0062;
		IL_0059:
		obj2 = null;
		goto IL_0062;
		IL_0062:
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;TE;)Ljava/util/SortedSet<TE;>;")]
	[LineNumberTable(160)]
	protected internal virtual SortedSet standardSubSet([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object fromElement, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object toElement)
	{
		SortedSet result = tailSet(fromElement).headSet(toElement);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(57)]
	protected internal new virtual Set _003Cbridge_003Edelegate()
	{
		SortedSet result = @delegate();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(57)]
	protected internal override Collection _003Cbridge_003Edelegate()
	{
		SortedSet result = @delegate();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(57)]
	protected internal override object _003Cbridge_003Edelegate()
	{
		SortedSet result = @delegate();
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override void forEach(Consumer P_0)
	{
		Iterable._003Cdefault_003EforEach(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Spliterator spliterator()
	{
		return SortedSet._003Cdefault_003Espliterator(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool removeIf(Predicate P_0)
	{
		return Collection._003Cdefault_003EremoveIf(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Stream stream()
	{
		return Collection._003Cdefault_003Estream(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Stream parallelStream()
	{
		return Collection._003Cdefault_003EparallelStream(this);
	}

	[SpecialName]
	[HideFromJava]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return new IterableEnumerator(this);
	}
}
