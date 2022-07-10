using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;

namespace javassist.bytecode.stackmap;

public class MapMaker : Tracer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		49, 103, 99, 194, 212, 2, 97, 162, 99, 130,
		137, 223, 0, 2, 98, 174
	})]
	public static StackMapTable make(ClassPool classes, MethodInfo minfo)
	{
		CodeAttribute codeAttribute = minfo.getCodeAttribute();
		if (codeAttribute == null)
		{
			return null;
		}
		TypedBlock[] array;
		try
		{
			array = TypedBlock.makeBlocks(minfo, codeAttribute, optimize: true);
		}
		catch (BasicBlock.JsrBytecode)
		{
			goto IL_001d;
		}
		if (array == null)
		{
			return null;
		}
		MapMaker mapMaker = new MapMaker(classes, minfo, codeAttribute);
		BadBytecode badBytecode;
		try
		{
			mapMaker.make(array, codeAttribute.getCode());
		}
		catch (BadBytecode x)
		{
			badBytecode = ByteCodeHelper.MapException<BadBytecode>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_004f;
		}
		return mapMaker.toStackMap(array);
		IL_001d:
		_ = null;
		return null;
		IL_004f:
		BadBytecode cause = badBytecode;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new BadBytecode(minfo, cause);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		83, 103, 99, 194, 212, 2, 97, 162, 99, 130,
		137, 223, 0, 2, 98, 142
	})]
	public static StackMap make2(ClassPool classes, MethodInfo minfo)
	{
		CodeAttribute codeAttribute = minfo.getCodeAttribute();
		if (codeAttribute == null)
		{
			return null;
		}
		TypedBlock[] array;
		try
		{
			array = TypedBlock.makeBlocks(minfo, codeAttribute, optimize: true);
		}
		catch (BasicBlock.JsrBytecode)
		{
			goto IL_001d;
		}
		if (array == null)
		{
			return null;
		}
		MapMaker mapMaker = new MapMaker(classes, minfo, codeAttribute);
		BadBytecode badBytecode;
		try
		{
			mapMaker.make(array, codeAttribute.getCode());
		}
		catch (BadBytecode x)
		{
			badBytecode = ByteCodeHelper.MapException<BadBytecode>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_004f;
		}
		return mapMaker.toStackMap2(minfo.getConstPool(), array);
		IL_001d:
		_ = null;
		return null;
		IL_004f:
		BadBytecode cause = badBytecode;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new BadBytecode(minfo, cause);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 109, 105, 108, 10, 167 })]
	public MapMaker(ClassPool classes, MethodInfo minfo, CodeAttribute ca)
		: base(classes, minfo.getConstPool(), ca.getMaxStack(), ca.getMaxLocals(), TypedBlock.getRetType(minfo.getDescriptor()))
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 122, 106, 136, 186, 2, 97, 145 })]
	internal virtual void make(TypedBlock[] P_0, byte[] P_1)
	{
		make(P_1, P_0[0]);
		findDeadCatchers(P_1, P_0);
		NotFoundException ex;
		try
		{
			fixTypes(P_1, P_0);
			return;
		}
		catch (NotFoundException x)
		{
			ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		NotFoundException cause = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new BadBytecode("failed to resolve types", cause);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 39, 104, 99, 100, 103, 105, 103, 164, 107,
		102, 112, 103, 159, 2, 109, 106, 99, 98, 137,
		103, 172, 234, 48, 235, 83
	})]
	public virtual StackMapTable toStackMap(TypedBlock[] blocks)
	{
		StackMapTable.Writer writer = new StackMapTable.Writer(32);
		int num = blocks.Length;
		TypedBlock typedBlock = blocks[0];
		int num2 = typedBlock.length;
		if (typedBlock.incoming > 0)
		{
			writer.sameFrame(0);
			num2 += -1;
		}
		for (int i = 1; i < num; i++)
		{
			TypedBlock typedBlock2 = blocks[i];
			if (isTarget(typedBlock2, blocks[i - 1]))
			{
				typedBlock2.resetNumLocals();
				int num3 = stackMapDiff(typedBlock.numLocals, typedBlock.localsTypes, typedBlock2.numLocals, typedBlock2.localsTypes);
				toStackMapBody(writer, typedBlock2, num3, num2, typedBlock);
				num2 = typedBlock2.length - 1;
				typedBlock = typedBlock2;
			}
			else if (typedBlock2.incoming == 0)
			{
				writer.sameFrame(num2);
				num2 = typedBlock2.length - 1;
			}
			else
			{
				num2 += typedBlock2.length;
			}
		}
		StackMapTable result = writer.toStackMapTable(cpool);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 188, 102, 99, 103, 164, 140, 107, 104, 102,
		127, 3, 103, 99, 230, 59, 232, 73, 100, 130,
		104, 104, 102, 21, 200
	})]
	public virtual StackMap toStackMap2(ConstPool cp, TypedBlock[] blocks)
	{
		StackMap.Writer writer = new StackMap.Writer();
		int num = blocks.Length;
		bool[] array = new bool[num];
		TypedBlock typedBlock = blocks[0];
		array[0] = typedBlock.incoming > 0;
		int num2 = (array[0] ? 1 : 0);
		for (int i = 1; i < num; i++)
		{
			TypedBlock typedBlock2 = blocks[i];
			int num3 = i;
			int num4 = (isTarget(typedBlock2, blocks[i - 1]) ? 1 : 0);
			int num5 = num3;
			bool[] array2 = array;
			array2[num5] = (byte)num4 != 0;
			if (num4 != 0)
			{
				typedBlock2.resetNumLocals();
				num2++;
			}
		}
		if (num2 == 0)
		{
			return null;
		}
		writer.write16bit(num2);
		for (int i = 0; i < num; i++)
		{
			if (array[i])
			{
				writeStackFrame(writer, cp, blocks[i].position, blocks[i]);
			}
		}
		StackMap result = writer.toStackMap(cp);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		160, 72, 119, 108, 152, 141, 103, 105, 100, 107,
		175, 104, 108, 110, 104, 138, 103, 104, 233, 57,
		230, 75
	})]
	private void make(byte[] P_0, TypedBlock P_1)
	{
		copyTypeData(P_1.stackTop, P_1.stackTypes, stackTypes);
		stackTop = P_1.stackTop;
		copyTypeData(P_1.localsTypes.Length, P_1.localsTypes, localsTypes);
		traceException(P_0, P_1.toCatch);
		int num = P_1.position;
		int num2 = num + P_1.length;
		while (num < num2)
		{
			num += doOpcode(num, P_0);
			traceException(P_0, P_1.toCatch);
		}
		if (P_1.exit == null)
		{
			return;
		}
		for (int i = 0; i < (nint)P_1.exit.LongLength; i++)
		{
			TypedBlock typedBlock = (TypedBlock)P_1.exit[i];
			if (typedBlock.alreadySet())
			{
				mergeMap(typedBlock, true);
				continue;
			}
			recordStackMap(typedBlock);
			MapMaker mapMaker = new MapMaker(this);
			mapMaker.make(P_0, typedBlock);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		160, 219, 99, 105, 100, 104, 104, 103, 99, 109,
		169, 110, 105, 232, 52, 233, 82
	})]
	private void findDeadCatchers(byte[] P_0, TypedBlock[] P_1)
	{
		int num = P_1.Length;
		for (int i = 0; i < num; i++)
		{
			TypedBlock typedBlock = P_1[i];
			if (typedBlock.alreadySet())
			{
				continue;
			}
			fixDeadcode(P_0, typedBlock);
			BasicBlock.Catch toCatch = typedBlock.toCatch;
			if (toCatch != null)
			{
				TypedBlock typedBlock2 = (TypedBlock)toCatch.body;
				if (!typedBlock2.alreadySet())
				{
					recordStackMap(typedBlock2, toCatch.typeIndex);
					fixDeadcode(P_0, typedBlock2);
					typedBlock2.incoming = 1;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException", "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		161, 19, 102, 99, 98, 105, 101, 108, 106, 105,
		56, 168, 105, 105, 56, 232, 56, 233, 76
	})]
	private void fixTypes(byte[] P_0, TypedBlock[] P_1)
	{
		ArrayList order = new ArrayList();
		int num = P_1.Length;
		int index = 0;
		for (int i = 0; i < num; i++)
		{
			TypedBlock typedBlock = P_1[i];
			if (typedBlock.alreadySet())
			{
				int num2 = typedBlock.localsTypes.Length;
				for (int j = 0; j < num2; j++)
				{
					index = typedBlock.localsTypes[j].dfs(order, index, classPool);
				}
				num2 = typedBlock.stackTop;
				for (int j = 0; j < num2; j++)
				{
					index = typedBlock.stackTypes[j].dfs(order, index, classPool);
				}
			}
		}
	}

	[LineNumberTable(new byte[] { 160, 198, 108 })]
	protected internal static void copyTypeData(int n, TypeData[] srcTypes, TypeData[] destTypes)
	{
		ByteCodeHelper.arraycopy(srcTypes, 0, destTypes, 0, n);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		160, 102, 102, 108, 104, 104, 105, 159, 11, 223,
		5, 109, 103, 168, 104, 101
	})]
	private void traceException(byte[] P_0, BasicBlock.Catch P_1)
	{
		while (P_1 != null)
		{
			TypedBlock typedBlock = (TypedBlock)P_1.body;
			if (typedBlock.alreadySet())
			{
				mergeMap(typedBlock, false);
				if (typedBlock.stackTop < 1)
				{
					string msg = new StringBuilder().append("bad catch clause: ").append(P_1.typeIndex).toString();
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new BadBytecode(msg);
				}
				typedBlock.stackTypes[0] = merge(toExceptionType(P_1.typeIndex), typedBlock.stackTypes[0]);
			}
			else
			{
				recordStackMap(typedBlock, P_1.typeIndex);
				MapMaker mapMaker = new MapMaker(this);
				mapMaker.make(P_0, typedBlock);
			}
			P_1 = P_1.next;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		159, 83, 98, 104, 102, 63, 4, 198, 99, 103,
		102, 62, 166
	})]
	private void mergeMap(TypedBlock P_0, bool P_1)
	{
		int num = localsTypes.Length;
		for (int i = 0; i < num; i++)
		{
			P_0.localsTypes[i] = merge(validateTypeData(localsTypes, num, i), P_0.localsTypes[i]);
		}
		if (P_1)
		{
			num = stackTop;
			for (int i = 0; i < num; i++)
			{
				P_0.stackTypes[i] = merge(stackTypes[i], P_0.stackTypes[i]);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 160, 152, 109, 103, 110, 107 })]
	private void recordStackMap(TypedBlock P_0)
	{
		TypeData[] array = TypeData.make(stackTypes.Length);
		int num = stackTop;
		recordTypeData(num, stackTypes, array);
		recordStackMap0(P_0, num, array);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(164)]
	protected internal MapMaker(MapMaker old)
		: base(old)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 168, 99, 136, 141 })]
	private TypeData.ClassName toExceptionType(int P_0)
	{
		string n = ((P_0 != 0) ? cpool.getClassInfo(P_0) : "java.lang.Throwable");
		TypeData.ClassName result = new TypeData.ClassName(n);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 160, 136, 100, 98, 144, 98, 104, 108, 162 })]
	private TypeData merge(TypeData P_0, TypeData P_1)
	{
		if (P_0 == P_1)
		{
			return P_1;
		}
		if (P_1 is TypeData.ClassName || P_1 is TypeData.BasicType)
		{
			return P_1;
		}
		if (P_1 is TypeData.AbsTypeVar)
		{
			((TypeData.AbsTypeVar)P_1).merge(P_0);
			return P_1;
		}
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException("fatal: this should never happen");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 160, 161, 109, 111, 107 })]
	private void recordStackMap(TypedBlock P_0, int P_1)
	{
		TypeData[] array = TypeData.make(stackTypes.Length);
		array[0] = toExceptionType(P_1).join();
		recordStackMap0(P_0, 1, array);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 202, 100, 110, 108, 134 })]
	private static TypeData validateTypeData(TypeData[] P_0, int P_1, int P_2)
	{
		TypeData typeData = P_0[P_2];
		if (typeData.is2WordType() && P_2 + 1 < P_1 && P_0[P_2 + 1] != TypeTag.TOP)
		{
			return TypeTag.TOP;
		}
		return typeData;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 186, 98, 102, 105, 105, 104, 228, 60, 230,
		71
	})]
	protected internal static int recordTypeData(int n, TypeData[] srcTypes, TypeData[] destTypes)
	{
		int num = -1;
		for (int i = 0; i < n; i++)
		{
			TypeData typeData = validateTypeData(srcTypes, n, i);
			destTypes[i] = typeData.join();
			if (typeData != TypeTag.TOP)
			{
				num = i + 1;
			}
		}
		return num + 1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 160, 179, 104, 103, 110, 108 })]
	private void recordStackMap0(TypedBlock P_0, int P_1, TypeData[] P_2)
	{
		int num = localsTypes.Length;
		TypeData[] array = TypeData.make(num);
		int nl = recordTypeData(num, localsTypes, array);
		P_0.setStackMap(P_1, P_2, nl, array);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		160, 241, 103, 105, 132, 100, 132, 110, 103, 106,
		225, 69, 135, 102, 38, 166, 103, 111
	})]
	private void fixDeadcode(byte[] P_0, TypedBlock P_1)
	{
		int position = P_1.position;
		int num = P_1.length - 3;
		if (num < 0)
		{
			if (num == -1)
			{
				P_0[position] = 0;
			}
			P_0[position + P_1.length - 1] = 191;
			P_1.incoming = 1;
			recordStackMap(P_1, 0);
		}
		else
		{
			P_1.incoming = 0;
			for (int i = 0; i < num; i++)
			{
				P_0[position + i] = 0;
			}
			P_0[position + num] = 167;
			ByteArray.write16bit(-num, P_0, position + num + 1);
		}
	}

	[LineNumberTable(new byte[] { 161, 74, 103, 100, 98, 100, 130 })]
	private bool isTarget(TypedBlock P_0, TypedBlock P_1)
	{
		int incoming = P_0.incoming;
		if (incoming > 1)
		{
			return true;
		}
		if (incoming < 1)
		{
			return false;
		}
		return P_1.stop;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 149, 132, 100, 132, 130, 106, 100, 139, 106 })]
	private static int stackMapDiff(int P_0, TypeData[] P_1, int P_2, TypeData[] P_3)
	{
		int num = P_2 - P_0;
		int num2 = ((num <= 0) ? P_2 : P_0);
		if (stackMapEq(P_1, P_3, num2))
		{
			if (num > 0)
			{
				int result = diffSize(P_3, num2, P_2);
				_ = null;
				return result;
			}
			return -diffSize(P_1, num2, P_0);
		}
		return -100;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 88, 103, 102, 99, 106, 129, 105, 108, 129,
		110, 103, 191, 4, 108, 161, 103, 105, 124, 129,
		103, 105, 136, 124, 193, 103, 112, 109, 119, 112
	})]
	private void toStackMapBody(StackMapTable.Writer P_0, TypedBlock P_1, int P_2, int P_3, TypedBlock P_4)
	{
		int num = P_1.stackTop;
		int[] array;
		int[] tags;
		if (num == 0)
		{
			if (P_2 == 0)
			{
				P_0.sameFrame(P_3);
				return;
			}
			if (0 > P_2 && P_2 >= -3)
			{
				P_0.chopFrame(P_3, -P_2);
				return;
			}
			if (0 < P_2 && P_2 <= 3)
			{
				array = new int[P_2];
				tags = fillStackMap(P_1.numLocals - P_4.numLocals, P_4.numLocals, array, P_1.localsTypes);
				P_0.appendFrame(P_3, tags, array);
				return;
			}
		}
		else
		{
			if (num == 1 && P_2 == 0)
			{
				TypeData typeData = P_1.stackTypes[0];
				P_0.sameLocals(P_3, typeData.getTypeTag(), typeData.getTypeData(cpool));
				return;
			}
			if (num == 2 && P_2 == 0)
			{
				TypeData typeData = P_1.stackTypes[0];
				if (typeData.is2WordType())
				{
					P_0.sameLocals(P_3, typeData.getTypeTag(), typeData.getTypeData(cpool));
					return;
				}
			}
		}
		array = new int[num];
		tags = fillStackMap(num, 0, array, P_1.stackTypes);
		int[] array2 = new int[P_1.numLocals];
		int[] localTags = fillStackMap(P_1.numLocals, 0, array2, P_1.localsTypes);
		P_0.fullFrame(P_3, localTags, array2, tags, array);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 129, 108, 103, 103, 98, 104, 105, 106, 107,
		105, 134, 228, 57, 232, 74
	})]
	private int[] fillStackMap(int P_0, int P_1, int[] P_2, TypeData[] P_3)
	{
		int num = diffSize(P_3, P_1, P_1 + P_0);
		ConstPool cp = cpool;
		int[] array = new int[num];
		int num2 = 0;
		for (int i = 0; i < P_0; i++)
		{
			TypeData typeData = P_3[P_1 + i];
			array[num2] = typeData.getTypeTag();
			P_2[num2] = typeData.getTypeData(cp);
			if (typeData.is2WordType())
			{
				i++;
			}
			num2++;
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 174, 98, 100, 105, 100, 104, 101, 130 })]
	private static int diffSize(TypeData[] P_0, int P_1, int P_2)
	{
		int num = 0;
		while (P_1 < P_2)
		{
			int num2 = P_1;
			P_1++;
			TypeData typeData = P_0[num2];
			num++;
			if (typeData.is2WordType())
			{
				P_1++;
			}
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 165, 102, 109, 2, 230, 69 })]
	private static bool stackMapEq(TypeData[] P_0, TypeData[] P_1, int P_2)
	{
		for (int i = 0; i < P_2; i++)
		{
			if (!P_0[i].eq(P_1[i]))
			{
				return false;
			}
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 218, 103, 118, 120 })]
	private void writeStackFrame(StackMap.Writer P_0, ConstPool P_1, int P_2, TypedBlock P_3)
	{
		P_0.write16bit(P_2);
		writeVerifyTypeInfo(P_0, P_1, P_3.localsTypes, P_3.numLocals);
		writeVerifyTypeInfo(P_0, P_1, P_3.stackTypes, P_3.stackTop);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 224, 98, 103, 100, 107, 100, 228, 60, 230,
		72, 106, 103, 100, 115, 104, 228, 60, 230, 70
	})]
	private void writeVerifyTypeInfo(StackMap.Writer P_0, ConstPool P_1, TypeData[] P_2, int P_3)
	{
		int num = 0;
		for (int i = 0; i < P_3; i++)
		{
			TypeData typeData = P_2[i];
			if (typeData != null && typeData.is2WordType())
			{
				num++;
				i++;
			}
		}
		P_0.write16bit(P_3 - num);
		for (int i = 0; i < P_3; i++)
		{
			TypeData typeData = P_2[i];
			P_0.writeVerifyTypeInfo(typeData.getTypeTag(), typeData.getTypeData(P_1));
			if (typeData.is2WordType())
			{
				i++;
			}
		}
	}
}
