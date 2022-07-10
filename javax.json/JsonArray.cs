using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace javax.json;

[Signature("Ljava/lang/Object;Ljavax/json/JsonStructure;Ljava/util/List<Ljavax/json/JsonValue;>;")]
[Implements(new string[] { "javax.json.JsonStructure", "java.util.List" })]
public interface JsonArray : JsonStructure, JsonValue, List, Collection, Iterable
{
	[HideFromJava]
	public new static class __DefaultMethods
	{
		public unsafe static List getValuesAs(JsonArray P_0, Function P_1)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003EgetValuesAs(P_0, P_1);
		}
	}

	virtual JsonObject getJsonObject(int i);

	virtual JsonArray getJsonArray(int i);

	virtual JsonNumber getJsonNumber(int i);

	virtual JsonString getJsonString(int i);

	[Signature("<T::Ljavax/json/JsonValue;>(Ljava/lang/Class<TT;>;)Ljava/util/List<TT;>;")]
	virtual List getValuesAs(Class c);

	[Modifiers(Modifiers.Public)]
	[Signature("<T:Ljava/lang/Object;K::Ljavax/json/JsonValue;>(Ljava/util/function/Function<TK;TT;>;)Ljava/util/List<TT;>;")]
	virtual List getValuesAs(Function func);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(new byte[] { 160, 89, 103 })]
	static List _003Cdefault_003EgetValuesAs(JsonArray P_0, Function P_1)
	{
		Stream stream = P_0.stream();
		return (List)stream.map(P_1).collect(Collectors.toList());
	}

	virtual string getString(int i);

	virtual string getString(int i, string str);

	virtual int getInt(int i);

	virtual int getInt(int i1, int i2);

	virtual bool getBoolean(int i);

	virtual bool getBoolean(int i, bool b);

	virtual bool isNull(int i);
}
