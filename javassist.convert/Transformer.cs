using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using javassist.bytecode;

namespace javassist.convert;

public abstract class Transformer : Object, Opcode
{
	private Transformer next;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 159, 188, 111 })]
	public virtual void initialize(ConstPool cp, CtClass clazz, MethodInfo minfo)
	{
		initialize(cp, minfo.getCodeAttribute());
	}

	public virtual Transformer getNext()
	{
		return next;
	}

	[Throws(new string[] { "javassist.CannotCompileException", "javassist.bytecode.BadBytecode" })]
	public abstract int transform(CtClass cc, int i, CodeIterator ci, ConstPool cp);

	public virtual int extraLocals()
	{
		return 0;
	}

	public virtual int extraStack()
	{
		return 0;
	}

	public virtual void clean()
	{
	}

	public virtual void initialize(ConstPool cp, CodeAttribute attr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 179, 104, 103 })]
	public Transformer(Transformer t)
	{
		next = t;
	}
}
