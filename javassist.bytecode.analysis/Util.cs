using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace javassist.bytecode.analysis;

public class Util : Object, Opcode
{
	public static bool isJumpInstruction(int opcode)
	{
		return ((opcode >= 153 && opcode <= 168) || opcode == 198 || opcode == 199 || opcode == 201 || opcode == 200) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 170, 104, 127, 9 })]
	public static int getJumpTarget(int pos, CodeIterator iter)
	{
		int num = iter.byteAt(pos);
		pos += ((num != 201 && num != 200) ? iter.s16bitAt(pos + 1) : iter.s32bitAt(pos + 1));
		return pos;
	}

	public static bool isJsr(int opcode)
	{
		return (opcode == 168 || opcode == 201) ? true : false;
	}

	public static bool isGoto(int opcode)
	{
		return (opcode == 167 || opcode == 200) ? true : false;
	}

	public static bool isReturn(int opcode)
	{
		return (opcode >= 172 && opcode <= 177) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(26)]
	public Util()
	{
	}
}
