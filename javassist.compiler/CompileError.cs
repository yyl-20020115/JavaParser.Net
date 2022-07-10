using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.lang;

namespace javassist.compiler;

[Serializable]
public class CompileError : java.lang.Exception
{
	private const long serialVersionUID = 1L;

	private Lex lex;

	private string reason;

	public override string getMessage()
	{
		return reason;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 181, 110 })]
	public CompileError(CannotCompileException e)
		: this(e.getReason())
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 185, 127, 8 })]
	public CompileError(NotFoundException e)
		: this(new StringBuilder().append("cannot find ").append(Throwable.instancehelper_getMessage(e)).toString())
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 175, 104, 103, 103 })]
	public CompileError(string s)
	{
		reason = s;
		lex = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 170, 104, 103, 103 })]
	public CompileError(string s, Lex l)
	{
		reason = s;
		lex = l;
	}

	public virtual Lex getLex()
	{
		return lex;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(55)]
	public override string toString()
	{
		string result = new StringBuilder().append("compile error: ").append(reason).toString();
		_ = null;
		return result;
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected CompileError(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
