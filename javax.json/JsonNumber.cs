using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.math;

namespace javax.json;

[Implements(new string[] { "javax.json.JsonValue" })]
public interface JsonNumber : JsonValue
{
	[HideFromJava]
	public new static class __DefaultMethods
	{
		public unsafe static Number numberValue(JsonNumber P_0)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003EnumberValue(P_0);
		}
	}

	virtual int intValue();

	virtual bool isIntegral();

	virtual int intValueExact();

	virtual long longValue();

	virtual long longValueExact();

	virtual BigInteger bigIntegerValue();

	virtual BigInteger bigIntegerValueExact();

	virtual double doubleValue();

	virtual BigDecimal bigDecimalValue();

	[Modifiers(Modifiers.Public)]
	virtual Number numberValue();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(174)]
	static Number _003Cdefault_003EnumberValue(JsonNumber P_0)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	string toString();

	virtual bool equals(object obj);

	virtual int hashCode();
}
