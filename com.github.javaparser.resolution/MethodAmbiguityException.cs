using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.lang;

namespace com.github.javaparser.resolution;

[Serializable]
public class MethodAmbiguityException : RuntimeException
{
	
	
	
	public MethodAmbiguityException(string description)
		: base(description)
	{
	}

	
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected MethodAmbiguityException(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
