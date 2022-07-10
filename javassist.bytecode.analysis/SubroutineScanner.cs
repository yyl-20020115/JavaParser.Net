using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace javassist.bytecode.analysis;

public class SubroutineScanner : Object, Opcode
{
	private Subroutine[] subroutines;

	[IKVM.Attributes.Signature("Ljava/util/Map<Ljava/lang/Integer;Ljavassist/bytecode/analysis/Subroutine;>;")]
	internal Map subTable;

	[IKVM.Attributes.Signature("Ljava/util/Set<Ljava/lang/Integer;>;")]
	internal Set done;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 177, 168, 107 })]
	public SubroutineScanner()
	{
		subTable = new HashMap();
		done = new HashSet();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		159, 185, 103, 135, 113, 107, 139, 137, 103, 107,
		169, 247, 60, 230, 71
	})]
	public virtual Subroutine[] scan(MethodInfo method)
	{
		CodeAttribute codeAttribute = method.getCodeAttribute();
		CodeIterator codeIterator = codeAttribute.iterator();
		subroutines = new Subroutine[codeAttribute.getCodeLength()];
		subTable.clear();
		done.clear();
		scan(0, codeIterator, null);
		ExceptionTable exceptionTable = codeAttribute.getExceptionTable();
		for (int i = 0; i < exceptionTable.size(); i++)
		{
			int num = exceptionTable.handlerPc(i);
			scan(num, codeIterator, subroutines[exceptionTable.startPc(i)]);
		}
		return subroutines;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 15, 115, 129, 146, 103, 199, 104, 120, 131, 105 })]
	private void scan(int P_0, CodeIterator P_1, Subroutine P_2)
	{
		if (!done.contains(Integer.valueOf(P_0)))
		{
			done.add(Integer.valueOf(P_0));
			int index = P_1.lookAhead();
			P_1.move(P_0);
			do
			{
				P_0 = P_1.next();
			}
			while ((scanOp(P_0, P_1, P_2) && P_1.hasNext()) ? true : false);
			P_1.move(index);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		33, 137, 136, 104, 137, 162, 104, 137, 194, 120,
		130, 107, 104, 112, 119, 99, 104, 115, 139, 135,
		98, 169, 104, 194
	})]
	private bool scanOp(int P_0, CodeIterator P_1, Subroutine P_2)
	{
		subroutines[P_0] = P_2;
		int num = P_1.byteAt(P_0);
		switch (num)
		{
		case 170:
			scanTableSwitch(P_0, P_1, P_2);
			return false;
		case 171:
			scanLookupSwitch(P_0, P_1, P_2);
			return false;
		default:
			if (Util.isReturn(num) || num == 169 || num == 191)
			{
				return false;
			}
			if (Util.isJumpInstruction(num))
			{
				int jumpTarget = Util.getJumpTarget(P_0, P_1);
				if (num == 168 || num == 201)
				{
					Subroutine subroutine = (Subroutine)subTable.get(Integer.valueOf(jumpTarget));
					if (subroutine == null)
					{
						subroutine = new Subroutine(jumpTarget, P_0);
						subTable.put(Integer.valueOf(jumpTarget), subroutine);
						scan(jumpTarget, P_1, subroutine);
					}
					else
					{
						subroutine.addCaller(P_0);
					}
				}
				else
				{
					scan(jumpTarget, P_1, P_2);
					if (Util.isGoto(num))
					{
						return false;
					}
				}
			}
			return true;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 92, 135, 113, 108, 108, 174, 100, 107, 10, 198 })]
	private void scanTableSwitch(int P_0, CodeIterator P_1, Subroutine P_2)
	{
		int num = (P_0 & -4) + 4;
		scan(P_0 + P_1.s32bitAt(num), P_1, P_2);
		num += 4;
		int num2 = P_1.s32bitAt(num);
		num += 4;
		int num3 = P_1.s32bitAt(num);
		int num4 = (num3 - num2 + 1) * 4;
		num += 4;
		for (int num5 = num4 + num; num < num5; num += 4)
		{
			int num6 = P_1.s32bitAt(num) + P_0;
			scan(num6, P_1, P_2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 77, 135, 113, 108, 170, 104, 106, 9, 198 })]
	private void scanLookupSwitch(int P_0, CodeIterator P_1, Subroutine P_2)
	{
		int num = (P_0 & -4) + 4;
		scan(P_0 + P_1.s32bitAt(num), P_1, P_2);
		num += 4;
		int num2 = P_1.s32bitAt(num);
		int num3 = num2 * 8;
		num += 4;
		int num4 = num3 + num;
		for (num += 4; num < num4; num += 8)
		{
			int num5 = P_1.s32bitAt(num) + P_0;
			scan(num5, P_1, P_2);
		}
	}
}
