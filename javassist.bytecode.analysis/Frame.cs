using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;

namespace javassist.bytecode.analysis;

public class Frame : Object
{
	private Type[] locals;

	private Type[] stack;

	private int top;

	private bool jsrMerged;

	private bool retMerged;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 102, 116, 122, 122, 108 })]
	public virtual Frame copy()
	{
		Frame frame = new Frame(locals.Length, stack.Length);
		ByteCodeHelper.arraycopy(locals, 0, frame.locals, 0, locals.Length);
		ByteCodeHelper.arraycopy(stack, 0, frame.stack, 0, stack.Length);
		frame.top = top;
		return frame;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 179, 104, 108, 108 })]
	public Frame(int locals, int stack)
	{
		this.locals = new Type[locals];
		this.stack = new Type[stack];
	}

	[LineNumberTable(new byte[] { 9, 105 })]
	public virtual void setLocal(int index, Type type)
	{
		locals[index] = type;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 96, 162, 111, 106, 105, 143, 105, 113, 130,
		108, 112, 226, 53, 233, 79, 106
	})]
	public virtual bool merge(Frame frame)
	{
		int num = 0;
		for (int i = 0; i < (nint)locals.LongLength; i++)
		{
			if (locals[i] != null)
			{
				Type type = locals[i];
				Type type2 = type.merge(frame.locals[i]);
				locals[i] = type2;
				if (!type2.equals(type) || type2.popChanged())
				{
					num = 1;
				}
			}
			else if (frame.locals[i] != null)
			{
				locals[i] = frame.locals[i];
				num = 1;
			}
		}
		return (byte)((uint)num | (mergeStack(frame) ? 1u : 0u)) != 0;
	}

	public virtual void clearStack()
	{
		top = 0;
	}

	[LineNumberTable(new byte[] { 91, 123 })]
	public virtual void push(Type type)
	{
		Type[] array = stack;
		int num = top;
		top = num + 1;
		array[num] = type;
	}

	[LineNumberTable(109)]
	public virtual int localsLength()
	{
		return locals.Length;
	}

	[LineNumberTable(49)]
	public virtual Type getLocal(int index)
	{
		return locals[index];
	}

	internal virtual bool isJsrMerged()
	{
		return jsrMerged;
	}

	internal virtual void setJsrMerged(bool P_0)
	{
		int num = ((jsrMerged = P_0) ? 1 : 0);
	}

	internal virtual bool isRetMerged()
	{
		return retMerged;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 116, 116, 122, 108 })]
	public virtual Frame copyStack()
	{
		Frame frame = new Frame(locals.Length, stack.Length);
		ByteCodeHelper.arraycopy(stack, 0, frame.stack, 0, stack.Length);
		frame.top = top;
		return frame;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 66, 98, 110, 144, 110, 109, 105, 111, 104,
		159, 6, 137, 113, 226, 54, 233, 79
	})]
	public virtual bool mergeStack(Frame frame)
	{
		int result = 0;
		if (top != frame.top)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException("Operand stacks could not be merged, they are different sizes!");
		}
		for (int i = 0; i < top; i++)
		{
			if (stack[i] != null)
			{
				Type type = stack[i];
				Type type2 = type.merge(frame.stack[i]);
				if (type2 == Type.___003C_003EBOGUS)
				{
					string message = new StringBuilder().append("Operand stacks could not be merged due to differing primitive types: pos = ").append(i).toString();
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new RuntimeException(message);
				}
				stack[i] = type2;
				if (!type2.equals(type) || type2.popChanged())
				{
					result = 1;
				}
			}
		}
		return (byte)result != 0;
	}

	internal virtual void setRetMerged(bool P_0)
	{
		int num = ((retMerged = P_0) ? 1 : 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 80, 105, 112 })]
	public virtual Type pop()
	{
		if (top < 1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IndexOutOfBoundsException("Stack is empty");
		}
		Type[] array = stack;
		int num = top - 1;
		top = num;
		return array[num];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 68, 105, 144 })]
	public virtual Type peek()
	{
		if (top < 1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IndexOutOfBoundsException("Stack is empty");
		}
		return stack[top - 1];
	}

	public virtual int getTopIndex()
	{
		return top - 1;
	}

	[LineNumberTable(70)]
	public virtual Type getStack(int index)
	{
		return stack[index];
	}

	[LineNumberTable(new byte[] { 30, 105 })]
	public virtual void setStack(int index, Type type)
	{
		stack[index] = type;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 120, 134, 108, 108, 127, 6, 108, 236, 61,
		230, 69, 108, 107, 111, 107, 236, 61, 230, 69,
		137
	})]
	public override string toString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.append("locals = [");
		for (int i = 0; i < (nint)locals.LongLength; i++)
		{
			stringBuilder.append((locals[i] != null) ? locals[i].toString() : "empty");
			if (i < (nint)locals.LongLength - 1)
			{
				stringBuilder.append(", ");
			}
		}
		stringBuilder.append("] stack = [");
		for (int i = 0; i < top; i++)
		{
			stringBuilder.append(stack[i]);
			if (i < top - 1)
			{
				stringBuilder.append(", ");
			}
		}
		stringBuilder.append(']');
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}
}
