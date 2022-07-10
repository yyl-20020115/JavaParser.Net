using System;
using IKVM.Attributes;
using java.io;
using java.lang;

namespace com.google.common.io;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/io/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.DataOutput" })]
public interface ByteArrayDataOutput : DataOutput
{
	void write(int i);

	void write(byte[] barr);

	void write(byte[] barr, int i1, int i2);

	void writeBoolean(bool b);

	void writeByte(int i);

	void writeShort(int i);

	void writeChar(int i);

	void writeInt(int i);

	void writeLong(long l);

	void writeFloat(float f);

	void writeDouble(double d);

	void writeChars(string str);

	void writeUTF(string str);

	[Obsolete]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	void writeBytes(string str);

	virtual byte[] toByteArray();
}
