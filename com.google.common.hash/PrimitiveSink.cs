using java.lang;
using java.nio;
using java.nio.charset;

namespace com.google.common.hash;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/hash/ElementTypesAreNonnullByDefault;"
})]
public interface PrimitiveSink
{
	virtual PrimitiveSink putByte(byte b);

	virtual PrimitiveSink putBytes(byte[] barr);

	virtual PrimitiveSink putBytes(byte[] barr, int i1, int i2);

	virtual PrimitiveSink putBytes(ByteBuffer bb);

	virtual PrimitiveSink putShort(short s);

	virtual PrimitiveSink putInt(int i);

	virtual PrimitiveSink putLong(long l);

	virtual PrimitiveSink putFloat(float f);

	virtual PrimitiveSink putDouble(double d);

	virtual PrimitiveSink putBoolean(bool b);

	virtual PrimitiveSink putChar(char ch);

	virtual PrimitiveSink putUnencodedChars(CharSequence cs);

	virtual PrimitiveSink putString(CharSequence cs, Charset c);
}
