using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.lang;
using javassist.compiler.ast;

namespace javassist.compiler;

[Serializable]
public class NoFieldException : CompileError
{
	private const long serialVersionUID = 1L;

	private string fieldName;

	private ASTree expr;

	public virtual ASTree getExpr()
	{
		return expr;
	}

	public virtual string getField()
	{
		return fieldName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 172, 127, 3, 103, 103 })]
	public NoFieldException(string name, ASTree e)
		: base(new StringBuilder().append("no such field: ").append(name).toString())
	{
		fieldName = name;
		expr = e;
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected NoFieldException(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
