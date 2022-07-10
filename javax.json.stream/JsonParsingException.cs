using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;

namespace javax.json.stream;

[Serializable]
public class JsonParsingException : JsonException
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private JsonLocation location;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 13, 105, 103 })]
	public JsonParsingException(string message, JsonLocation location)
		: base(message)
	{
		this.location = location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 32, 106, 103 })]
	public JsonParsingException(string message, Exception cause, JsonLocation location)
		: base(message, cause)
	{
		this.location = location;
	}

	public virtual JsonLocation getLocation()
	{
		return location;
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected JsonParsingException(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
