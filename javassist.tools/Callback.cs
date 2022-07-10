using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace javassist.tools;

public abstract class Callback : Object
{
	[Signature("Ljava/util/Map<Ljava/lang/String;Ljavassist/tools/Callback;>;")]
	public static Map callbacks;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private string m_sourceCode;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	public virtual string sourceCode()
	{
		return this.m_sourceCode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(79)]
	public override string toString()
	{
		string text = sourceCode();
		_ = null;
		return text;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 14, 104, 107, 109, 127, 27 })]
	public Callback(string src)
	{
		string text = UUID.randomUUID().toString();
		callbacks.put(text, this);
		this.m_sourceCode = new StringBuilder().append("((javassist.tools.Callback) javassist.tools.Callback.callbacks.get(\"").append(text).append("\")).result(new Object[]{")
			.append(src)
			.append("});")
			.toString();
	}

	public abstract void result(object[] objarr);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 46, 110 })]
	public static void insertBefore(CtBehavior behavior, Callback callback)
	{
		behavior.insertBefore(callback.toString());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 62, 111 })]
	public static void insertAfter(CtBehavior behavior, Callback callback)
	{
		behavior.insertAfter(callback.toString(), asFinally: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 159, 109, 98, 111 })]
	public static void insertAfter(CtBehavior behavior, Callback callback, bool asFinally)
	{
		behavior.insertAfter(callback.toString(), asFinally);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(152)]
	public static int insertAt(CtBehavior behavior, Callback callback, int lineNum)
	{
		int num = behavior.insertAt(lineNum, callback.toString());
		_ = null;
		return num;
	}

	[LineNumberTable(53)]
	static Callback()
	{
		callbacks = new HashMap();
	}
}
