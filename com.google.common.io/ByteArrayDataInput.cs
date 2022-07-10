using IKVM.Attributes;
using java.io;
using javax.annotation;

namespace com.google.common.io;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/io/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.DataInput" })]
public interface ByteArrayDataInput : DataInput
{
	void readFully(byte[] barr);

	void readFully(byte[] barr, int i1, int i2);

	int skipBytes(int i);

	bool readBoolean();

	byte readByte();

	int readUnsignedByte();

	short readShort();

	int readUnsignedShort();

	char readChar();

	int readInt();

	long readLong();

	float readFloat();

	double readDouble();

	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	string readLine();

	string readUTF();
}
