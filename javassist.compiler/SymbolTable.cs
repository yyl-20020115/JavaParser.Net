using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.util;
using javassist.compiler.ast;

namespace javassist.compiler;

[Serializable]
[Signature("Ljava/util/HashMap<Ljava/lang/String;Ljavassist/compiler/ast/Declarator;>;")]
public sealed class SymbolTable : HashMap
{
	private const long serialVersionUID = 1L;

	private SymbolTable parent;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(28)]
	public SymbolTable()
		: this(null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 173, 104, 103 })]
	public SymbolTable(SymbolTable p)
	{
		parent = p;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 187, 105 })]
	public virtual void append(string name, Declarator value)
	{
		put(name, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 180, 109, 107, 111 })]
	public virtual Declarator lookup(string name)
	{
		Declarator declarator = (Declarator)get(name);
		if (declarator == null && parent != null)
		{
			Declarator result = parent.lookup(name);
			_ = null;
			return result;
		}
		return declarator;
	}

	public virtual SymbolTable getParent()
	{
		return parent;
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected SymbolTable(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
