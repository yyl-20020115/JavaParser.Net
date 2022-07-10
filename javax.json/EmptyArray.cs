using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using IKVM.Attributes;
using ikvm.@internal;
using ikvm.lang;
using java.io;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace javax.json;

[Serializable]
[Signature("Ljava/util/AbstractList<Ljavax/json/JsonValue;>;Ljavax/json/JsonArray;Ljava/io/Serializable;Ljava/util/RandomAccess;")]
[Implements(new string[] { "javax.json.JsonArray", "java.io.Serializable", "java.util.RandomAccess" })]
internal sealed class EmptyArray : AbstractList, JsonArray, JsonStructure, JsonValue, List, Collection, Iterable, IEnumerable, Serializable.__Interface, RandomAccess, ISerializable, IObjectReference
{
	private const long serialVersionUID = 7295439472061642859L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(53)]
	internal EmptyArray()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(59)]
	public new virtual JsonValue get(int P_0)
	{
		string s = new StringBuilder().append("Index: ").append(P_0).toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new IndexOutOfBoundsException(s);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(84)]
	public virtual JsonString getJsonString(int P_0)
	{
		return (JsonString)get(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(79)]
	public virtual JsonNumber getJsonNumber(int P_0)
	{
		return (JsonNumber)get(P_0);
	}

	public override int size()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(69)]
	public virtual JsonObject getJsonObject(int P_0)
	{
		return (JsonObject)get(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(74)]
	public virtual JsonArray getJsonArray(int P_0)
	{
		return (JsonArray)get(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T::Ljavax/json/JsonValue;>(Ljava/lang/Class<TT;>;)Ljava/util/List<TT;>;")]
	[LineNumberTable(89)]
	public virtual List getValuesAs(Class P_0)
	{
		List result = Collections.emptyList();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(94)]
	public virtual string getString(int P_0)
	{
		string @string = getJsonString(P_0).getString();
		_ = null;
		return @string;
	}

	public virtual string getString(int P_0, string P_1)
	{
		return P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(104)]
	public virtual int getInt(int P_0)
	{
		int result = getJsonNumber(P_0).intValue();
		_ = null;
		return result;
	}

	public virtual int getInt(int P_0, int P_1)
	{
		return P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(114)]
	public virtual bool getBoolean(int P_0)
	{
		return get(P_0) == JsonValue.TRUE;
	}

	public virtual bool getBoolean(int P_0, bool P_1)
	{
		return P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(124)]
	public virtual bool isNull(int P_0)
	{
		return get(P_0) == JsonValue.NULL;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(129)]
	public virtual JsonValue.ValueType getValueType()
	{
		return JsonValue.ValueType.___003C_003EARRAY;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(134)]
	private object readResolve()
	{
		return JsonValue.EMPTY_JSON_ARRAY;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(53)]
	public override object get(int P_0)
	{
		JsonValue result = get(P_0);
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

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual JsonValue getValue(string P_0)
	{
		return JsonStructure._003Cdefault_003EgetValue(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual List getValuesAs(Function P_0)
	{
		return JsonArray._003Cdefault_003EgetValuesAs(this, P_0);
	}

	[SpecialName]
	[HideFromJava]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return new IterableEnumerator(this);
	}

	string JsonValue.JsonValue_003A_003AtoString()
	{
		return toString();
	}

	bool List.List_003A_003Aadd(object P_0)
	{
		return add(P_0);
	}

	Iterator List.List_003A_003Aiterator()
	{
		return iterator();
	}

	object[] List.List_003A_003AtoArray(object[] P_0)
	{
		return toArray(P_0);
	}

	object[] List.List_003A_003AtoArray()
	{
		return toArray();
	}

	object List.List_003A_003Aremove(int P_0)
	{
		return remove(P_0);
	}

	bool List.List_003A_003Aremove(object P_0)
	{
		return remove(P_0);
	}

	void List.List_003A_003Aclear()
	{
		clear();
	}

	void List.List_003A_003Aadd(int P_0, object P_1)
	{
		add(P_0, P_1);
	}

	bool List.List_003A_003AisEmpty()
	{
		return isEmpty();
	}

	bool List.List_003A_003Aequals(object P_0)
	{
		return equals(P_0);
	}

	bool List.List_003A_003AremoveAll(Collection P_0)
	{
		return removeAll(P_0);
	}

	bool List.List_003A_003AaddAll(Collection P_0)
	{
		return addAll(P_0);
	}

	bool List.List_003A_003Acontains(object P_0)
	{
		return contains(P_0);
	}

	List List.List_003A_003AsubList(int P_0, int P_1)
	{
		return subList(P_0, P_1);
	}

	int List.List_003A_003AindexOf(object P_0)
	{
		return indexOf(P_0);
	}

	int List.List_003A_003AhashCode()
	{
		return hashCode();
	}

	object List.List_003A_003Aset(int P_0, object P_1)
	{
		return set(P_0, P_1);
	}

	ListIterator List.List_003A_003AlistIterator()
	{
		return listIterator();
	}

	bool List.List_003A_003AcontainsAll(Collection P_0)
	{
		return containsAll(P_0);
	}

	bool List.List_003A_003AaddAll(int P_0, Collection P_1)
	{
		return addAll(P_0, P_1);
	}

	bool List.List_003A_003AretainAll(Collection P_0)
	{
		return retainAll(P_0);
	}

	void List.List_003A_003AreplaceAll(UnaryOperator P_0)
	{
		replaceAll(P_0);
	}

	void List.List_003A_003Asort(Comparator P_0)
	{
		sort(P_0);
	}

	int List.List_003A_003AlastIndexOf(object P_0)
	{
		return lastIndexOf(P_0);
	}

	ListIterator List.List_003A_003AlistIterator(int P_0)
	{
		return listIterator(P_0);
	}

	Spliterator List.List_003A_003Aspliterator()
	{
		return spliterator();
	}

	bool Collection.Collection_003A_003Aadd(object P_0)
	{
		return add(P_0);
	}

	object[] Collection.Collection_003A_003AtoArray(object[] P_0)
	{
		return toArray(P_0);
	}

	Iterator Collection.Collection_003A_003Aiterator()
	{
		return iterator();
	}

	Spliterator Collection.Collection_003A_003Aspliterator()
	{
		return spliterator();
	}

	bool Collection.Collection_003A_003AisEmpty()
	{
		return isEmpty();
	}

	bool Collection.Collection_003A_003Acontains(object P_0)
	{
		return contains(P_0);
	}

	object[] Collection.Collection_003A_003AtoArray()
	{
		return toArray();
	}

	bool Collection.Collection_003A_003Aremove(object P_0)
	{
		return remove(P_0);
	}

	bool Collection.Collection_003A_003AcontainsAll(Collection P_0)
	{
		return containsAll(P_0);
	}

	bool Collection.Collection_003A_003AaddAll(Collection P_0)
	{
		return addAll(P_0);
	}

	bool Collection.Collection_003A_003AremoveAll(Collection P_0)
	{
		return removeAll(P_0);
	}

	bool Collection.Collection_003A_003AremoveIf(Predicate P_0)
	{
		return removeIf(P_0);
	}

	bool Collection.Collection_003A_003AretainAll(Collection P_0)
	{
		return retainAll(P_0);
	}

	void Collection.Collection_003A_003Aclear()
	{
		clear();
	}

	bool Collection.Collection_003A_003Aequals(object P_0)
	{
		return equals(P_0);
	}

	int Collection.Collection_003A_003AhashCode()
	{
		return hashCode();
	}

	Stream Collection.Collection_003A_003Astream()
	{
		return stream();
	}

	Stream Collection.Collection_003A_003AparallelStream()
	{
		return parallelStream();
	}

	Iterator Iterable.Iterable_003A_003Aiterator()
	{
		return iterator();
	}

	void Iterable.Iterable_003A_003AforEach(Consumer P_0)
	{
		forEach(P_0);
	}

	Spliterator Iterable.Iterable_003A_003Aspliterator()
	{
		return spliterator();
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
	protected EmptyArray(SerializationInfo P_0, StreamingContext P_1)
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
