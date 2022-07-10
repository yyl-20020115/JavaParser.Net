using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.lang;

namespace com.github.javaparser.resolution;

[Serializable]
public class UnsolvedSymbolException : RuntimeException
{
	private string name;

	private string context;

	private System.Exception cause;

	
	
	
	public UnsolvedSymbolException(string name)
		: this(name, null, null)
	{
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public UnsolvedSymbolException(string name, string context, System.Exception cause)
		: base(new StringBuilder().append("Unsolved symbol").append((context == null) ? "" : new StringBuilder().append(" in ").append(context).ToString()).append(" : ")
			.append(name)
			.ToString(), cause)
	{
		this.name = name;
		this.context = context;
		this.cause = cause;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public UnsolvedSymbolException(string name, string context)
		: this(name, context, null)
	{
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public UnsolvedSymbolException(string name, System.Exception cause)
		: this(name, null, cause)
	{
	}

	public virtual string getName()
	{
		return name;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("UnsolvedSymbolException{context='").append(context).append("', name='")
			.append(name)
			.append("', cause='")
			.append(cause)
			.append("'}")
			.ToString();
		
		return result;
	}

	
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected UnsolvedSymbolException(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
