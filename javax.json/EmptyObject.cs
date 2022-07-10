using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.util;
using java.util.function;

namespace javax.json;

[Serializable]
[Signature("Ljava/util/AbstractMap<Ljava/lang/String;Ljavax/json/JsonValue;>;Ljavax/json/JsonObject;Ljava/io/Serializable;")]
[Implements(new string[] { "javax.json.JsonObject", "java.io.Serializable" })]
internal sealed class EmptyObject : AbstractMap, JsonObject, JsonStructure, JsonValue, Map, Serializable.__Interface, ISerializable, IObjectReference
{
	private const long serialVersionUID = -1461653546889072583L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(53)]
	internal EmptyObject()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(79)]
	public virtual JsonString getJsonString(string P_0)
	{
		return (JsonString)base.get(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(74)]
	public virtual JsonNumber getJsonNumber(string P_0)
	{
		return (JsonNumber)base.get(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<Ljava/lang/String;Ljavax/json/JsonValue;>;>;")]
	[LineNumberTable(59)]
	public override Set entrySet()
	{
		Set result = Collections.emptySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(64)]
	public virtual JsonArray getJsonArray(string P_0)
	{
		return (JsonArray)base.get(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(69)]
	public virtual JsonObject getJsonObject(string P_0)
	{
		return (JsonObject)base.get(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(84)]
	public virtual string getString(string P_0)
	{
		string @string = getJsonString(P_0).getString();
		_ = null;
		return @string;
	}

	public virtual string getString(string P_0, string P_1)
	{
		return P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(94)]
	public virtual int getInt(string P_0)
	{
		int result = getJsonNumber(P_0).intValue();
		_ = null;
		return result;
	}

	public virtual int getInt(string P_0, int P_1)
	{
		return P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(104)]
	public virtual bool getBoolean(string P_0)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new NullPointerException();
	}

	public virtual bool getBoolean(string P_0, bool P_1)
	{
		return P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(114)]
	public virtual bool isNull(string P_0)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new NullPointerException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(119)]
	public virtual JsonValue.ValueType getValueType()
	{
		return JsonValue.ValueType.___003C_003EOBJECT;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(124)]
	private object readResolve()
	{
		return JsonValue.EMPTY_JSON_OBJECT;
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

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual JsonValue getValue(string P_0)
	{
		return JsonStructure._003Cdefault_003EgetValue(this, P_0);
	}

	string JsonValue.JsonValue_003A_003AtoString()
	{
		return toString();
	}

	object Map.Map_003A_003Aget(object P_0)
	{
		return get(P_0);
	}

	int Map.Map_003A_003Asize()
	{
		return size();
	}

	Set Map.Map_003A_003AkeySet()
	{
		return keySet();
	}

	object Map.Map_003A_003Aput(object P_0, object P_1)
	{
		return put(P_0, P_1);
	}

	object Map.Map_003A_003Aremove(object P_0)
	{
		return remove(P_0);
	}

	void Map.Map_003A_003AputAll(Map P_0)
	{
		putAll(P_0);
	}

	object Map.Map_003A_003AputIfAbsent(object P_0, object P_1)
	{
		return putIfAbsent(P_0, P_1);
	}

	Collection Map.Map_003A_003Avalues()
	{
		return values();
	}

	bool Map.Map_003A_003AcontainsKey(object P_0)
	{
		return containsKey(P_0);
	}

	bool Map.Map_003A_003AisEmpty()
	{
		return isEmpty();
	}

	bool Map.Map_003A_003AcontainsValue(object P_0)
	{
		return containsValue(P_0);
	}

	void Map.Map_003A_003Aclear()
	{
		clear();
	}

	bool Map.Map_003A_003Aequals(object P_0)
	{
		return equals(P_0);
	}

	int Map.Map_003A_003AhashCode()
	{
		return hashCode();
	}

	object Map.Map_003A_003AgetOrDefault(object P_0, object P_1)
	{
		return getOrDefault(P_0, P_1);
	}

	void Map.Map_003A_003AforEach(BiConsumer P_0)
	{
		forEach(P_0);
	}

	void Map.Map_003A_003AreplaceAll(BiFunction P_0)
	{
		replaceAll(P_0);
	}

	bool Map.Map_003A_003Aremove(object P_0, object P_1)
	{
		return remove(P_0, P_1);
	}

	bool Map.Map_003A_003Areplace(object P_0, object P_1, object P_2)
	{
		return replace(P_0, P_1, P_2);
	}

	object Map.Map_003A_003Areplace(object P_0, object P_1)
	{
		return replace(P_0, P_1);
	}

	object Map.Map_003A_003AcomputeIfAbsent(object P_0, Function P_1)
	{
		return computeIfAbsent(P_0, P_1);
	}

	object Map.Map_003A_003AcomputeIfPresent(object P_0, BiFunction P_1)
	{
		return computeIfPresent(P_0, P_1);
	}

	object Map.Map_003A_003Acompute(object P_0, BiFunction P_1)
	{
		return compute(P_0, P_1);
	}

	object Map.Map_003A_003Amerge(object P_0, object P_1, BiFunction P_2)
	{
		return merge(P_0, P_1, P_2);
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
	protected EmptyObject(SerializationInfo P_0, StreamingContext P_1)
	{
		Serialization.readObject(this, P_0);
	}

	[SecurityCritical]
	[HideFromJava]
	object IObjectReference.GetRealObject(StreamingContext P_0)
	{
		return readResolve();
	}
}
