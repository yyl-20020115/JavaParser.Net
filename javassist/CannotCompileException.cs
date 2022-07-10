using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.lang;
using javassist.compiler;

namespace javassist;

[Serializable]
public class CannotCompileException : java.lang.Exception
{
	private const long serialVersionUID = 1L;

	private System.Exception myCause;

	private string message;

	[MethodImpl(MethodImplOptions.Synchronized)]
	public override System.Exception initCause(System.Exception cause)
	{
		myCause = cause;
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 15, 105, 103, 104 })]
	public CannotCompileException(string msg)
		: base(msg)
	{
		message = msg;
		initCause(null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 40, 105, 104 })]
	public CannotCompileException(string msg, System.Exception e)
		: this(msg)
	{
		initCause(e);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public override System.Exception getCause()
	{
		return (myCause != this) ? myCause : null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 4, 104, 103 })]
	public virtual string getReason()
	{
		if (message != null)
		{
			return message;
		}
		string result = Throwable.instancehelper_toString(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 27, 127, 8, 103, 104 })]
	public CannotCompileException(System.Exception e)
		: base(new StringBuilder().append("by ").append(Throwable.instancehelper_toString(e)).toString())
	{
		message = null;
		initCause(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 49, 127, 9 })]
	public CannotCompileException(NotFoundException e)
		: this(new StringBuilder().append("cannot find ").append(Throwable.instancehelper_getMessage(e)).toString(), e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 56, 127, 9 })]
	public CannotCompileException(CompileError e)
		: this(new StringBuilder().append("[source error] ").append(e.getMessage()).toString(), e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 64, 127, 4 })]
	public CannotCompileException(java.lang.ClassNotFoundException e, string name)
		: this(new StringBuilder().append("cannot find ").append(name).toString(), e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 71, 127, 4 })]
	public CannotCompileException(java.lang.ClassFormatError e, string name)
		: this(new StringBuilder().append("invalid class format: ").append(name).toString(), e)
	{
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected CannotCompileException(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
