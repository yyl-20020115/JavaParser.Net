using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;

namespace javassist.compiler.ast;

[Serializable]
[Implements(new string[] { "java.io.Serializable" })]
public abstract class ASTree : java.lang.Object, Serializable.__Interface, ISerializable
{
	private const long serialVersionUID = 1L;

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	public abstract void accept(Visitor v);

	public virtual ASTree getLeft()
	{
		return null;
	}

	public virtual ASTree getRight()
	{
		return null;
	}

	public virtual void setLeft(ASTree _left)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 11, 108 })]
	protected internal virtual string getTag()
	{
		string name = java.lang.Object.instancehelper_getClass(this).getName();
		string result = java.lang.String.instancehelper_substring(name, java.lang.String.instancehelper_lastIndexOf(name, 46) + 1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(28)]
	public ASTree()
	{
	}

	public virtual void setRight(ASTree _right)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 191, 102, 105, 109, 105 })]
	public override string toString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.append('<');
		stringBuilder.append(getTag());
		stringBuilder.append('>');
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[HideFromJava]
	public static implicit operator Serializable(ASTree P_0)
	{
		Serializable result = default(Serializable);
		result.___003Cref_003E = P_0;
		return result;
	}

	[SecurityCritical]
	[HideFromJava]
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

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected ASTree(SerializationInfo P_0, StreamingContext P_1)
	{
		Serialization.readObject(this, P_0);
	}
}
