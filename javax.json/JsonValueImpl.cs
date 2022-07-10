using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;

namespace javax.json;

[Serializable]
[Implements(new string[] { "javax.json.JsonValue", "java.io.Serializable" })]
internal sealed class JsonValueImpl : java.lang.Object, JsonValue, Serializable.__Interface, ISerializable
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private JsonValue.ValueType valueType;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 5, 104, 103 })]
	internal JsonValueImpl(JsonValue.ValueType P_0)
	{
		valueType = P_0;
	}

	public virtual JsonValue.ValueType getValueType()
	{
		return valueType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 31, 100, 130, 104, 153 })]
	public override bool equals(object P_0)
	{
		if (this == P_0)
		{
			return true;
		}
		if (P_0 is JsonValue)
		{
			bool result = getValueType().equals(((JsonValue)P_0).getValueType());
			_ = null;
			return result;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(99)]
	public override int hashCode()
	{
		int result = valueType.hashCode();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(104)]
	public override string toString()
	{
		string result = java.lang.String.instancehelper_toLowerCase(valueType.name());
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual JsonObject asJsonObject()
	{
		return JsonValue._003Cdefault_003EasJsonObject(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual JsonArray asJsonArray()
	{
		return JsonValue._003Cdefault_003EasJsonArray(this);
	}

	[SecurityCritical]
	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	void ISerializable.GetObjectData(SerializationInfo P_0, StreamingContext P_1)
	{
		Serialization.writeObject(this, P_0);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected JsonValueImpl(SerializationInfo P_0, StreamingContext P_1)
	{
		Serialization.readObject(this, P_0);
	}
}
