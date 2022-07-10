using System.Runtime.CompilerServices;
using IKVM.Attributes;

namespace javax.json;

[Implements(new string[] { "javax.json.JsonValue" })]
public interface JsonStructure : JsonValue
{
	[HideFromJava]
	public new static class __DefaultMethods
	{
		public unsafe static JsonValue getValue(JsonStructure P_0, string P_1)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003EgetValue(P_0, P_1);
		}
	}

	[Modifiers(Modifiers.Public)]
	virtual JsonValue getValue(string jsonPointer);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(60)]
	static JsonValue _003Cdefault_003EgetValue(JsonStructure P_0, string P_1)
	{
		JsonValue value = Json.createPointer(P_1).getValue(P_0);
		_ = null;
		return value;
	}
}
