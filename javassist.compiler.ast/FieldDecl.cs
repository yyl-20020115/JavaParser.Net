using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;

namespace javassist.compiler.ast;

[Serializable]
public class FieldDecl : ASTList
{
	private const long serialVersionUID = 1L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(33)]
	public virtual ASTree getInit()
	{
		ASTree result = sublist(2).head();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(31)]
	public virtual Declarator getDeclarator()
	{
		return (Declarator)tail().head();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(29)]
	public virtual ASTList getModifiers()
	{
		return (ASTList)getLeft();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 168, 106 })]
	public FieldDecl(ASTree _head, ASTList _tail)
		: base(_head, _tail)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 159, 179, 105 })]
	public override void accept(Visitor v)
	{
		v.atFieldDecl(this);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected FieldDecl(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
