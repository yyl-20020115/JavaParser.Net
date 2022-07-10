using System.Runtime.CompilerServices;
using IKVM.Attributes;

namespace javassist.bytecode;

public interface Opcode
{
	[HideFromJava]
	public static class __Fields
	{
		public const int AALOAD = 50;

		public const int AASTORE = 83;

		public const int ACONST_NULL = 1;

		public const int ALOAD = 25;

		public const int ALOAD_0 = 42;

		public const int ALOAD_1 = 43;

		public const int ALOAD_2 = 44;

		public const int ALOAD_3 = 45;

		public const int ANEWARRAY = 189;

		public const int ARETURN = 176;

		public const int ARRAYLENGTH = 190;

		public const int ASTORE = 58;

		public const int ASTORE_0 = 75;

		public const int ASTORE_1 = 76;

		public const int ASTORE_2 = 77;

		public const int ASTORE_3 = 78;

		public const int ATHROW = 191;

		public const int BALOAD = 51;

		public const int BASTORE = 84;

		public const int BIPUSH = 16;

		public const int CALOAD = 52;

		public const int CASTORE = 85;

		public const int CHECKCAST = 192;

		public const int D2F = 144;

		public const int D2I = 142;

		public const int D2L = 143;

		public const int DADD = 99;

		public const int DALOAD = 49;

		public const int DASTORE = 82;

		public const int DCMPG = 152;

		public const int DCMPL = 151;

		public const int DCONST_0 = 14;

		public const int DCONST_1 = 15;

		public const int DDIV = 111;

		public const int DLOAD = 24;

		public const int DLOAD_0 = 38;

		public const int DLOAD_1 = 39;

		public const int DLOAD_2 = 40;

		public const int DLOAD_3 = 41;

		public const int DMUL = 107;

		public const int DNEG = 119;

		public const int DREM = 115;

		public const int DRETURN = 175;

		public const int DSTORE = 57;

		public const int DSTORE_0 = 71;

		public const int DSTORE_1 = 72;

		public const int DSTORE_2 = 73;

		public const int DSTORE_3 = 74;

		public const int DSUB = 103;

		public const int DUP = 89;

		public const int DUP2 = 92;

		public const int DUP2_X1 = 93;

		public const int DUP2_X2 = 94;

		public const int DUP_X1 = 90;

		public const int DUP_X2 = 91;

		public const int F2D = 141;

		public const int F2I = 139;

		public const int F2L = 140;

		public const int FADD = 98;

		public const int FALOAD = 48;

		public const int FASTORE = 81;

		public const int FCMPG = 150;

		public const int FCMPL = 149;

		public const int FCONST_0 = 11;

		public const int FCONST_1 = 12;

		public const int FCONST_2 = 13;

		public const int FDIV = 110;

		public const int FLOAD = 23;

		public const int FLOAD_0 = 34;

		public const int FLOAD_1 = 35;

		public const int FLOAD_2 = 36;

		public const int FLOAD_3 = 37;

		public const int FMUL = 106;

		public const int FNEG = 118;

		public const int FREM = 114;

		public const int FRETURN = 174;

		public const int FSTORE = 56;

		public const int FSTORE_0 = 67;

		public const int FSTORE_1 = 68;

		public const int FSTORE_2 = 69;

		public const int FSTORE_3 = 70;

		public const int FSUB = 102;

		public const int GETFIELD = 180;

		public const int GETSTATIC = 178;

		public const int GOTO = 167;

		public const int GOTO_W = 200;

		public const int I2B = 145;

		public const int I2C = 146;

		public const int I2D = 135;

		public const int I2F = 134;

		public const int I2L = 133;

		public const int I2S = 147;

		public const int IADD = 96;

		public const int IALOAD = 46;

		public const int IAND = 126;

		public const int IASTORE = 79;

		public const int ICONST_0 = 3;

		public const int ICONST_1 = 4;

		public const int ICONST_2 = 5;

		public const int ICONST_3 = 6;

		public const int ICONST_4 = 7;

		public const int ICONST_5 = 8;

		public const int ICONST_M1 = 2;

		public const int IDIV = 108;

		public const int IFEQ = 153;

		public const int IFGE = 156;

		public const int IFGT = 157;

		public const int IFLE = 158;

		public const int IFLT = 155;

		public const int IFNE = 154;

		public const int IFNONNULL = 199;

		public const int IFNULL = 198;

		public const int IF_ACMPEQ = 165;

		public const int IF_ACMPNE = 166;

		public const int IF_ICMPEQ = 159;

		public const int IF_ICMPGE = 162;

		public const int IF_ICMPGT = 163;

		public const int IF_ICMPLE = 164;

		public const int IF_ICMPLT = 161;

		public const int IF_ICMPNE = 160;

		public const int IINC = 132;

		public const int ILOAD = 21;

		public const int ILOAD_0 = 26;

		public const int ILOAD_1 = 27;

		public const int ILOAD_2 = 28;

		public const int ILOAD_3 = 29;

		public const int IMUL = 104;

		public const int INEG = 116;

		public const int INSTANCEOF = 193;

		public const int INVOKEDYNAMIC = 186;

		public const int INVOKEINTERFACE = 185;

		public const int INVOKESPECIAL = 183;

		public const int INVOKESTATIC = 184;

		public const int INVOKEVIRTUAL = 182;

		public const int IOR = 128;

		public const int IREM = 112;

		public const int IRETURN = 172;

		public const int ISHL = 120;

		public const int ISHR = 122;

		public const int ISTORE = 54;

		public const int ISTORE_0 = 59;

		public const int ISTORE_1 = 60;

		public const int ISTORE_2 = 61;

		public const int ISTORE_3 = 62;

		public const int ISUB = 100;

		public const int IUSHR = 124;

		public const int IXOR = 130;

		public const int JSR = 168;

		public const int JSR_W = 201;

		public const int L2D = 138;

		public const int L2F = 137;

		public const int L2I = 136;

		public const int LADD = 97;

		public const int LALOAD = 47;

		public const int LAND = 127;

		public const int LASTORE = 80;

		public const int LCMP = 148;

		public const int LCONST_0 = 9;

		public const int LCONST_1 = 10;

		public const int LDC = 18;

		public const int LDC2_W = 20;

		public const int LDC_W = 19;

		public const int LDIV = 109;

		public const int LLOAD = 22;

		public const int LLOAD_0 = 30;

		public const int LLOAD_1 = 31;

		public const int LLOAD_2 = 32;

		public const int LLOAD_3 = 33;

		public const int LMUL = 105;

		public const int LNEG = 117;

		public const int LOOKUPSWITCH = 171;

		public const int LOR = 129;

		public const int LREM = 113;

		public const int LRETURN = 173;

		public const int LSHL = 121;

		public const int LSHR = 123;

		public const int LSTORE = 55;

		public const int LSTORE_0 = 63;

		public const int LSTORE_1 = 64;

		public const int LSTORE_2 = 65;

		public const int LSTORE_3 = 66;

		public const int LSUB = 101;

		public const int LUSHR = 125;

		public const int LXOR = 131;

		public const int MONITORENTER = 194;

		public const int MONITOREXIT = 195;

		public const int MULTIANEWARRAY = 197;

		public const int NEW = 187;

		public const int NEWARRAY = 188;

		public const int NOP = 0;

		public const int POP = 87;

		public const int POP2 = 88;

		public const int PUTFIELD = 181;

		public const int PUTSTATIC = 179;

		public const int RET = 169;

		public const int RETURN = 177;

		public const int SALOAD = 53;

		public const int SASTORE = 86;

		public const int SIPUSH = 17;

		public const int SWAP = 95;

		public const int TABLESWITCH = 170;

		public const int WIDE = 196;

		public const int T_BOOLEAN = 4;

		public const int T_CHAR = 5;

		public const int T_FLOAT = 6;

		public const int T_DOUBLE = 7;

		public const int T_BYTE = 8;

		public const int T_SHORT = 9;

		public const int T_INT = 10;

		public const int T_LONG = 11;

		public static readonly int[] STACK_GROW;

		static __Fields()
		{
			STACK_GROW = Opcode.STACK_GROW;
		}
	}

	const int AALOAD = 50;

	const int AASTORE = 83;

	const int ACONST_NULL = 1;

	const int ALOAD = 25;

	const int ALOAD_0 = 42;

	const int ALOAD_1 = 43;

	const int ALOAD_2 = 44;

	const int ALOAD_3 = 45;

	const int ANEWARRAY = 189;

	const int ARETURN = 176;

	const int ARRAYLENGTH = 190;

	const int ASTORE = 58;

	const int ASTORE_0 = 75;

	const int ASTORE_1 = 76;

	const int ASTORE_2 = 77;

	const int ASTORE_3 = 78;

	const int ATHROW = 191;

	const int BALOAD = 51;

	const int BASTORE = 84;

	const int BIPUSH = 16;

	const int CALOAD = 52;

	const int CASTORE = 85;

	const int CHECKCAST = 192;

	const int D2F = 144;

	const int D2I = 142;

	const int D2L = 143;

	const int DADD = 99;

	const int DALOAD = 49;

	const int DASTORE = 82;

	const int DCMPG = 152;

	const int DCMPL = 151;

	const int DCONST_0 = 14;

	const int DCONST_1 = 15;

	const int DDIV = 111;

	const int DLOAD = 24;

	const int DLOAD_0 = 38;

	const int DLOAD_1 = 39;

	const int DLOAD_2 = 40;

	const int DLOAD_3 = 41;

	const int DMUL = 107;

	const int DNEG = 119;

	const int DREM = 115;

	const int DRETURN = 175;

	const int DSTORE = 57;

	const int DSTORE_0 = 71;

	const int DSTORE_1 = 72;

	const int DSTORE_2 = 73;

	const int DSTORE_3 = 74;

	const int DSUB = 103;

	const int DUP = 89;

	const int DUP2 = 92;

	const int DUP2_X1 = 93;

	const int DUP2_X2 = 94;

	const int DUP_X1 = 90;

	const int DUP_X2 = 91;

	const int F2D = 141;

	const int F2I = 139;

	const int F2L = 140;

	const int FADD = 98;

	const int FALOAD = 48;

	const int FASTORE = 81;

	const int FCMPG = 150;

	const int FCMPL = 149;

	const int FCONST_0 = 11;

	const int FCONST_1 = 12;

	const int FCONST_2 = 13;

	const int FDIV = 110;

	const int FLOAD = 23;

	const int FLOAD_0 = 34;

	const int FLOAD_1 = 35;

	const int FLOAD_2 = 36;

	const int FLOAD_3 = 37;

	const int FMUL = 106;

	const int FNEG = 118;

	const int FREM = 114;

	const int FRETURN = 174;

	const int FSTORE = 56;

	const int FSTORE_0 = 67;

	const int FSTORE_1 = 68;

	const int FSTORE_2 = 69;

	const int FSTORE_3 = 70;

	const int FSUB = 102;

	const int GETFIELD = 180;

	const int GETSTATIC = 178;

	const int GOTO = 167;

	const int GOTO_W = 200;

	const int I2B = 145;

	const int I2C = 146;

	const int I2D = 135;

	const int I2F = 134;

	const int I2L = 133;

	const int I2S = 147;

	const int IADD = 96;

	const int IALOAD = 46;

	const int IAND = 126;

	const int IASTORE = 79;

	const int ICONST_0 = 3;

	const int ICONST_1 = 4;

	const int ICONST_2 = 5;

	const int ICONST_3 = 6;

	const int ICONST_4 = 7;

	const int ICONST_5 = 8;

	const int ICONST_M1 = 2;

	const int IDIV = 108;

	const int IFEQ = 153;

	const int IFGE = 156;

	const int IFGT = 157;

	const int IFLE = 158;

	const int IFLT = 155;

	const int IFNE = 154;

	const int IFNONNULL = 199;

	const int IFNULL = 198;

	const int IF_ACMPEQ = 165;

	const int IF_ACMPNE = 166;

	const int IF_ICMPEQ = 159;

	const int IF_ICMPGE = 162;

	const int IF_ICMPGT = 163;

	const int IF_ICMPLE = 164;

	const int IF_ICMPLT = 161;

	const int IF_ICMPNE = 160;

	const int IINC = 132;

	const int ILOAD = 21;

	const int ILOAD_0 = 26;

	const int ILOAD_1 = 27;

	const int ILOAD_2 = 28;

	const int ILOAD_3 = 29;

	const int IMUL = 104;

	const int INEG = 116;

	const int INSTANCEOF = 193;

	const int INVOKEDYNAMIC = 186;

	const int INVOKEINTERFACE = 185;

	const int INVOKESPECIAL = 183;

	const int INVOKESTATIC = 184;

	const int INVOKEVIRTUAL = 182;

	const int IOR = 128;

	const int IREM = 112;

	const int IRETURN = 172;

	const int ISHL = 120;

	const int ISHR = 122;

	const int ISTORE = 54;

	const int ISTORE_0 = 59;

	const int ISTORE_1 = 60;

	const int ISTORE_2 = 61;

	const int ISTORE_3 = 62;

	const int ISUB = 100;

	const int IUSHR = 124;

	const int IXOR = 130;

	const int JSR = 168;

	const int JSR_W = 201;

	const int L2D = 138;

	const int L2F = 137;

	const int L2I = 136;

	const int LADD = 97;

	const int LALOAD = 47;

	const int LAND = 127;

	const int LASTORE = 80;

	const int LCMP = 148;

	const int LCONST_0 = 9;

	const int LCONST_1 = 10;

	const int LDC = 18;

	const int LDC2_W = 20;

	const int LDC_W = 19;

	const int LDIV = 109;

	const int LLOAD = 22;

	const int LLOAD_0 = 30;

	const int LLOAD_1 = 31;

	const int LLOAD_2 = 32;

	const int LLOAD_3 = 33;

	const int LMUL = 105;

	const int LNEG = 117;

	const int LOOKUPSWITCH = 171;

	const int LOR = 129;

	const int LREM = 113;

	const int LRETURN = 173;

	const int LSHL = 121;

	const int LSHR = 123;

	const int LSTORE = 55;

	const int LSTORE_0 = 63;

	const int LSTORE_1 = 64;

	const int LSTORE_2 = 65;

	const int LSTORE_3 = 66;

	const int LSUB = 101;

	const int LUSHR = 125;

	const int LXOR = 131;

	const int MONITORENTER = 194;

	const int MONITOREXIT = 195;

	const int MULTIANEWARRAY = 197;

	const int NEW = 187;

	const int NEWARRAY = 188;

	const int NOP = 0;

	const int POP = 87;

	const int POP2 = 88;

	const int PUTFIELD = 181;

	const int PUTSTATIC = 179;

	const int RET = 169;

	const int RETURN = 177;

	const int SALOAD = 53;

	const int SASTORE = 86;

	const int SIPUSH = 17;

	const int SWAP = 95;

	const int TABLESWITCH = 170;

	const int WIDE = 196;

	const int T_BOOLEAN = 4;

	const int T_CHAR = 5;

	const int T_FLOAT = 6;

	const int T_DOUBLE = 7;

	const int T_BYTE = 8;

	const int T_SHORT = 9;

	const int T_INT = 10;

	const int T_LONG = 11;

	static readonly int[] STACK_GROW;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	static void ___003Cclinit_003E()
	{
	}

	[LineNumberTable(245)]
	static Opcode()
	{
		STACK_GROW = new int[202]
		{
			0, 1, 1, 1, 1, 1, 1, 1, 1, 2,
			2, 1, 1, 1, 2, 2, 1, 1, 1, 1,
			2, 1, 2, 1, 2, 1, 1, 1, 1, 1,
			2, 2, 2, 2, 1, 1, 1, 1, 2, 2,
			2, 2, 1, 1, 1, 1, -1, 0, -1, 0,
			-1, -1, -1, -1, -1, -2, -1, -2, -1, -1,
			-1, -1, -1, -2, -2, -2, -2, -1, -1, -1,
			-1, -2, -2, -2, -2, -1, -1, -1, -1, -3,
			-4, -3, -4, -3, -3, -3, -3, -1, -2, 1,
			1, 1, 2, 2, 2, 0, -1, -2, -1, -2,
			-1, -2, -1, -2, -1, -2, -1, -2, -1, -2,
			-1, -2, -1, -2, -1, -2, 0, 0, 0, 0,
			-1, -1, -1, -1, -1, -1, -1, -2, -1, -2,
			-1, -2, 0, 1, 0, 1, -1, -1, 0, 0,
			1, 1, -1, 0, -1, 0, 0, 0, -3, -1,
			-1, -3, -3, -1, -1, -1, -1, -1, -1, -2,
			-2, -2, -2, -2, -2, -2, -2, 0, 1, 0,
			-1, -1, -1, -2, -1, -2, -1, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 1, 0, 0,
			0, -1, 0, 0, -1, -1, 0, 0, -1, -1,
			0, 1
		};
	}
}
