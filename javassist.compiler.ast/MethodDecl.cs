using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.lang;

namespace javassist.compiler.ast;

[Serializable]
public class MethodDecl : ASTList
{
	private const long serialVersionUID = 1L;

	public const string initName = "<init>";

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(35)]
	public virtual ASTList getModifiers()
	{
		return (ASTList)getLeft();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(39)]
	public virtual ASTList getParams()
	{
		return (ASTList)sublist(2).head();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(43)]
	public virtual Stmnt getBody()
	{
		return (Stmnt)sublist(4).head();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 173, 108 })]
	public virtual bool isConstructor()
	{
		Symbol variable = getReturn().getVariable();
		return (variable != null && java.lang.String.instancehelper_equals("<init>", variable.get())) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(37)]
	public virtual Declarator getReturn()
	{
		return (Declarator)tail().head();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 159, 189, 105 })]
	public override void accept(Visitor v)
	{
		v.atMethodDecl(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(41)]
	public virtual ASTList getThrows()
	{
		return (ASTList)sublist(3).head();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 169, 106 })]
	public MethodDecl(ASTree _head, ASTList _tail)
		: base(_head, _tail)
	{
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected MethodDecl(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
