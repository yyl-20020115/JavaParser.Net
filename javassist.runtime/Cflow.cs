using System.ComponentModel;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace javassist.runtime;

[Signature("Ljava/lang/ThreadLocal<Ljavassist/runtime/Cflow$Depth;>;")]
public class Cflow : ThreadLocal
{
	[InnerClass(null, Modifiers.Protected | Modifiers.Static)]
	public class Depth : Object
	{
		private int depth;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(29)]
		internal Depth()
		{
			depth = 0;
		}

		internal virtual int value()
		{
			return depth;
		}

		[LineNumberTable(31)]
		internal virtual void inc()
		{
			depth++;
		}

		[LineNumberTable(32)]
		internal virtual void dec()
		{
			depth--;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[LineNumberTable(37)]
	protected internal new virtual Depth initialValue()
	{
		Depth result = new Depth();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(26)]
	public Cflow()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(43)]
	public virtual void enter()
	{
		((Depth)get()).inc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(48)]
	public virtual void exit()
	{
		((Depth)get()).dec();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(53)]
	public virtual int value()
	{
		int result = ((Depth)get()).value();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(26)]
	protected internal virtual object _003Cbridge_003EinitialValue()
	{
		Depth result = initialValue();
		_ = null;
		return result;
	}

	[HideFromJava]
	static Cflow()
	{
		ThreadLocal.___003Cclinit_003E();
	}
}
