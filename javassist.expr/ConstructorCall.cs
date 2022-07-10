using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using javassist.bytecode;

namespace javassist.expr;

public class ConstructorCall : MethodCall
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(71)]
	public override bool isSuper()
	{
		bool result = base.isSuper();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 179, 109 })]
	protected internal ConstructorCall(int pos, CodeIterator i, CtClass decl, MethodInfo m)
		: base(pos, i, decl, m)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(45)]
	public override string getMethodName()
	{
		return (!isSuper()) ? "this" : "super";
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(55)]
	public override CtMethod getMethod()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new NotFoundException("this is a constructor call.  Call getConstructor().");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(62)]
	public virtual CtConstructor getConstructor()
	{
		CtConstructor constructor = getCtClass().getConstructor(getSignature());
		_ = null;
		return constructor;
	}
}
