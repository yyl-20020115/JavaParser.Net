using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;

namespace com.github.javaparser;

[Serializable]

public class Token : TokenBase, /*Serializable.*/__Interface, ISerializable
{
	private const long serialVersionUID = 1L;

	public int kind;

	public int beginLine;

	public int beginColumn;

	public int endLine;

	public int endColumn;

	public string image;

	public Token next;

	public Token specialToken;

	
	
	public Token()
	{
	}

	
	
	
	public static Token newToken(int ofKind)
	{
		Token result = newToken(ofKind, null);
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public Token(int nKind, string sImage)
	{
		kind = nKind;
		image = sImage;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public static Token newToken(int ofKind, string image)
	{
		Token result = new Token(ofKind, image);
		
		return result;
	}

	
	
	
	public Token(int nKind)
		: this(nKind, null)
	{
	}

	public virtual object getValue()
	{
		return null;
	}

	public override string ToString()
	{
		return image;
	}

	
	public static implicit operator Serializable(Token P_0)
	{
		Serializable result = default(Serializable);
		result.___003Cref_003E = P_0;
		return result;
	}

	[SecurityCritical]
	
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected virtual void GetObjectData(SerializationInfo P_0, StreamingContext P_1)
	{
		Serialization.writeObject(this, P_0);
	}

	void ISerializable.GetObjectData(SerializationInfo P_0, StreamingContext P_1)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetObjectData
		this.GetObjectData(P_0, P_1);
	}

	
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected Token(SerializationInfo P_0, StreamingContext P_1)
	{
		Serialization.readObject(this, P_0);
	}
}
