using System.Runtime.CompilerServices;
using IKVM.Attributes;

namespace javassist;

public sealed class CtPrimitiveType : CtClass
{
	private char descriptor;

	private string wrapperName;

	private string getMethodName;

	private string mDescriptor;

	private int returnOp;

	private int arrayType;

	private int dataSize;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159, 134, 162, 105, 103, 103, 104, 104, 104, 104,
		104
	})]
	internal CtPrimitiveType(string P_0, char P_1, string P_2, string P_3, string P_4, int P_5, int P_6, int P_7)
		: base(P_0)
	{
		descriptor = P_1;
		wrapperName = P_2;
		getMethodName = P_3;
		mDescriptor = P_4;
		returnOp = P_5;
		arrayType = P_6;
		dataSize = P_7;
	}

	public virtual int getDataSize()
	{
		return dataSize;
	}

	public virtual char getDescriptor()
	{
		return descriptor;
	}

	public virtual int getReturnOp()
	{
		return returnOp;
	}

	public virtual int getArrayType()
	{
		return arrayType;
	}

	public virtual string getWrapperName()
	{
		return wrapperName;
	}

	public virtual string getGetMethodName()
	{
		return getMethodName;
	}

	public virtual string getGetMethodDescriptor()
	{
		return mDescriptor;
	}

	public override bool isPrimitive()
	{
		return true;
	}

	public override int getModifiers()
	{
		return 17;
	}

	[HideFromJava]
	static CtPrimitiveType()
	{
		CtClass.___003Cclinit_003E();
	}
}
