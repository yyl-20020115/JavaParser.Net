using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;

namespace javassist.bytecode;

public class StackMapTable : AttributeInfo
{
	internal class Copier : SimpleCopy
	{
		private ConstPool srcPool;

		private ConstPool destPool;

		[IKVM.Attributes.Signature("Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;")]
		private Map classnames;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;[BLjavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
		[LineNumberTable(new byte[] { 161, 63, 105, 103, 103, 104 })]
		public Copier(ConstPool P_0, byte[] P_1, ConstPool P_2, Map P_3)
			: base(P_1)
		{
			srcPool = P_0;
			destPool = P_2;
			classnames = P_3;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 71, 100, 123 })]
		protected internal override int copyData(int P_0, int P_1)
		{
			if (P_0 == 7)
			{
				int result = srcPool.copy(P_1, destPool, classnames);
				_ = null;
				return result;
			}
			return P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161, 78, 104, 103, 102, 159, 0, 230, 60, 230,
			70
		})]
		protected internal override int[] copyData(int[] P_0, int[] P_1)
		{
			int[] array = new int[(nint)P_1.LongLength];
			for (int i = 0; i < (nint)P_1.LongLength; i++)
			{
				if (P_0[i] == 7)
				{
					array[i] = srcPool.copy(P_1[i], destPool, classnames);
				}
				else
				{
					array[i] = P_1[i];
				}
			}
			return array;
		}
	}

	internal class InsertLocal : SimpleCopy
	{
		private int varIndex;

		private int varTag;

		private int varData;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 146, 105, 103, 103, 104 })]
		public InsertLocal(byte[] P_0, int P_1, int P_2, int P_3)
			: base(P_0)
		{
			varIndex = P_1;
			varTag = P_2;
			varData = P_3;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161, 155, 99, 105, 113, 161, 119, 105, 105, 104,
			99, 104, 102, 134, 104, 239, 59, 232, 72, 106,
			106, 100, 103, 167, 112
		})]
		public override void fullFrame(int P_0, int P_1, int[] P_2, int[] P_3, int[] P_4, int[] P_5)
		{
			int num = P_2.Length;
			if (num < varIndex)
			{
				base.fullFrame(P_0, P_1, P_2, P_3, P_4, P_5);
				return;
			}
			int num2 = ((varTag != 4 && varTag != 3) ? 1 : 2);
			int[] array = new int[num + num2];
			int[] array2 = new int[num + num2];
			int num3 = varIndex;
			int num4 = 0;
			for (int i = 0; i < num; i++)
			{
				if (num4 == num3)
				{
					num4 += num2;
				}
				array[num4] = P_2[i];
				int num5 = num4;
				num4++;
				array2[num5] = P_3[i];
			}
			array[num3] = varTag;
			array2[num3] = varData;
			if (num2 > 1)
			{
				array[num3 + 1] = 0;
				array2[num3 + 1] = 0;
			}
			base.fullFrame(P_0, P_1, array, array2, P_4, P_5);
		}
	}

	internal class NewRemover : SimpleCopy
	{
		internal int posOfNew;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 171, 105, 103 })]
		public NewRemover(byte[] P_0, int P_1)
			: base(P_0)
		{
			posOfNew = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 177, 110, 138, 109 })]
		public override void sameLocals(int P_0, int P_1, int P_2, int P_3)
		{
			if (P_2 == 8 && P_3 == posOfNew)
			{
				sameFrame(P_0, P_1);
			}
			else
			{
				base.sameLocals(P_0, P_1, P_2, P_3);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			163, 186, 102, 105, 159, 23, 100, 105, 105, 99,
			104, 101, 136, 105, 239, 59, 232, 72, 99, 99,
			226, 47, 233, 84, 113
		})]
		public override void fullFrame(int P_0, int P_1, int[] P_2, int[] P_3, int[] P_4, int[] P_5)
		{
			int num = (int)((nint)P_4.LongLength - 1);
			for (int i = 0; i < num; i++)
			{
				if (P_4[i] != 8 || P_5[i] != posOfNew || P_4[i + 1] != 8 || P_5[i + 1] != posOfNew)
				{
					continue;
				}
				num++;
				int[] array = new int[num - 2];
				int[] array2 = new int[num - 2];
				int num2 = 0;
				for (int j = 0; j < num; j++)
				{
					if (j == i)
					{
						j++;
						continue;
					}
					array[num2] = P_4[j];
					int num3 = num2;
					num2++;
					array2[num3] = P_5[j];
				}
				P_4 = array;
				P_5 = array2;
				break;
			}
			base.fullFrame(P_0, P_1, P_2, P_3, P_4, P_5);
		}
	}

	internal class OffsetShifter : Walker
	{
		internal int where;

		internal int gap;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 210, 105, 103, 103 })]
		public OffsetShifter(StackMapTable P_0, int P_1, int P_2)
			: base(P_0)
		{
			where = P_1;
			gap = P_2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 217, 100, 105, 118 })]
		public override void objectOrUninitialized(int P_0, int P_1, int P_2)
		{
			if (P_0 == 8 && where <= P_1)
			{
				ByteArray.write16bit(P_1 + gap, info, P_2);
			}
		}
	}

	internal class Printer : Walker
	{
		private PrintWriter writer;

		private int offset;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 108, 223, 4, 2, 97, 140 })]
		public static void print(StackMapTable P_0, PrintWriter P_1)
		{
			BadBytecode badBytecode;
			try
			{
				new Printer(P_0.get(), P_1).parse();
				return;
			}
			catch (BadBytecode x)
			{
				badBytecode = ByteCodeHelper.MapException<BadBytecode>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			BadBytecode @this = badBytecode;
			P_1.println(Throwable.instancehelper_getMessage(@this));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 116, 105, 103, 103 })]
		internal Printer(byte[] P_0, PrintWriter P_1)
			: base(P_0)
		{
			writer = P_1;
			offset = -1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			162, 163, 98, 159, 16, 102, 133, 102, 133, 102,
			133, 102, 133, 102, 130, 102, 130, 102, 130, 127,
			6, 130, 223, 6, 112, 110
		})]
		private void printTypeInfo(int P_0, int P_1)
		{
			string x = null;
			switch (P_0)
			{
			case 0:
				x = "top";
				break;
			case 1:
				x = "integer";
				break;
			case 2:
				x = "float";
				break;
			case 3:
				x = "double";
				break;
			case 4:
				x = "long";
				break;
			case 5:
				x = "null";
				break;
			case 6:
				x = "this";
				break;
			case 7:
				x = new StringBuilder().append("object (cpool_index ").append(P_1).append(")")
					.toString();
				break;
			case 8:
				x = new StringBuilder().append("uninitialized (offset ").append(P_1).append(")")
					.toString();
				break;
			}
			writer.print("    ");
			writer.println(x);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 123, 112, 127, 19 })]
		public override void sameFrame(int P_0, int P_1)
		{
			offset += P_1 + 1;
			writer.println(new StringBuilder().append(offset).append(" same frame: ").append(P_1)
				.toString());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 129, 112, 127, 17, 107 })]
		public override void sameLocals(int P_0, int P_1, int P_2, int P_3)
		{
			offset += P_1 + 1;
			writer.println(new StringBuilder().append(offset).append(" same locals: ").append(P_1)
				.toString());
			printTypeInfo(P_2, P_3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 136, 112, 127, 45 })]
		public override void chopFrame(int P_0, int P_1, int P_2)
		{
			offset += P_1 + 1;
			writer.println(new StringBuilder().append(offset).append(" chop frame: ").append(P_1)
				.append(",    ")
				.append(P_2)
				.append(" last locals")
				.toString());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 142, 112, 127, 17, 103, 45, 134 })]
		public override void appendFrame(int P_0, int P_1, int[] P_2, int[] P_3)
		{
			offset += P_1 + 1;
			writer.println(new StringBuilder().append(offset).append(" append frame: ").append(P_1)
				.toString());
			for (int i = 0; i < (nint)P_2.LongLength; i++)
			{
				printTypeInfo(P_2[i], P_3[i]);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			162, 151, 112, 127, 17, 112, 103, 45, 166, 112,
			104, 46, 134
		})]
		public override void fullFrame(int P_0, int P_1, int[] P_2, int[] P_3, int[] P_4, int[] P_5)
		{
			offset += P_1 + 1;
			writer.println(new StringBuilder().append(offset).append(" full frame: ").append(P_1)
				.toString());
			writer.println("[locals]");
			for (int i = 0; i < (nint)P_2.LongLength; i++)
			{
				printTypeInfo(P_2[i], P_3[i]);
			}
			writer.println("[stack]");
			for (int i = 0; i < (nint)P_4.LongLength; i++)
			{
				printTypeInfo(P_4[i], P_5[i]);
			}
		}
	}

	[Serializable]
	public class RuntimeCopyException : RuntimeException
	{
		private const long serialVersionUID = 1L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 41, 105 })]
		public RuntimeCopyException(string s)
			: base(s)
		{
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected RuntimeCopyException(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	internal class Shifter : Walker
	{
		private StackMapTable stackMap;

		internal int where;

		internal int gap;

		internal int position;

		internal byte[] updatedInfo;

		internal bool exclusive;

		[Modifiers(Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		internal static bool _0024assertionsDisabled;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 158, 184, 99, 105, 103, 103, 103, 103, 103, 103 })]
		public Shifter(StackMapTable P_0, int P_1, int P_2, bool P_3)
			: base(P_0)
		{
			stackMap = P_0;
			where = P_1;
			gap = P_2;
			position = 0;
			updatedInfo = null;
			exclusive = P_3;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
		[LineNumberTable(new byte[] { 162, 241, 102, 104, 115 })]
		public virtual void doit()
		{
			parse();
			if (updatedInfo != null)
			{
				stackMap.set(updatedInfo);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			163, 1, 103, 145, 200, 191, 10, 156, 102, 105,
			105, 115, 101, 110, 106, 111, 103, 107, 104, 130,
			145
		})]
		internal virtual void update(int P_0, int P_1, int P_2, int P_3)
		{
			int num = position;
			position = num + P_1 + ((num != 0) ? 1 : 0);
			if ((!exclusive) ? ((num <= where && where < position) ? true : false) : (((num == 0 && where == 0) || (num < where && where <= position)) ? true : false))
			{
				int num2 = info[P_0];
				int num3 = P_1 + gap;
				position += gap;
				if (num3 < 64)
				{
					info[P_0] = (byte)(sbyte)(num3 + P_2);
				}
				else if (P_1 < 64 && num2 != P_3)
				{
					byte[] array = insertGap(info, P_0, 2);
					array[P_0] = (byte)(sbyte)P_3;
					ByteArray.write16bit(num3, array, P_0 + 1);
					updatedInfo = array;
				}
				else
				{
					ByteArray.write16bit(num3, info, P_0 + 1);
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			163, 31, 99, 105, 100, 108, 100, 140, 122, 106,
			142
		})]
		internal static byte[] insertGap(byte[] P_0, int P_1, int P_2)
		{
			int num = P_0.Length;
			byte[] array = new byte[num + P_2];
			if (P_1 <= 0)
			{
				ByteCodeHelper.arraycopy_primitive_1(P_0, 0, array, P_2, num);
			}
			else if (P_1 >= num)
			{
				ByteCodeHelper.arraycopy_primitive_1(P_0, 0, array, 0, num);
			}
			else
			{
				if (!_0024assertionsDisabled && (P_1 <= 0 || P_1 >= num))
				{
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new AssertionError();
				}
				ByteCodeHelper.arraycopy_primitive_1(P_0, 0, array, 0, P_1);
				ByteCodeHelper.arraycopy_primitive_1(P_0, P_1, array, P_1 + P_2, num - P_1);
			}
			return array;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			163, 62, 103, 145, 104, 191, 10, 156, 99, 105,
			111, 147
		})]
		internal virtual void update(int P_0, int P_1)
		{
			int num = position;
			position = num + P_1 + ((num != 0) ? 1 : 0);
			if ((!exclusive) ? ((num <= where && where < position) ? true : false) : (((num == 0 && where == 0) || (num < where && where <= position)) ? true : false))
			{
				int value = P_1 + gap;
				ByteArray.write16bit(value, info, P_0 + 1);
				position += gap;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 248, 112 })]
		public override void sameFrame(int P_0, int P_1)
		{
			update(P_0, P_1, 0, 251);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 253, 113 })]
		public override void sameLocals(int P_0, int P_1, int P_2, int P_3)
		{
			update(P_0, P_1, 64, 247);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 47, 106 })]
		public override void chopFrame(int P_0, int P_1, int P_2)
		{
			update(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 52, 106 })]
		public override void appendFrame(int P_0, int P_1, int[] P_2, int[] P_3)
		{
			update(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 58, 106 })]
		public override void fullFrame(int P_0, int P_1, int[] P_2, int[] P_3, int[] P_4, int[] P_5)
		{
			update(P_0, P_1);
		}

		[LineNumberTable(849)]
		static Shifter()
		{
			_0024assertionsDisabled = ((!ClassLiteral<StackMapTable>.Value.desiredAssertionStatus()) ? true : false);
		}
	}

	internal class SimpleCopy : Walker
	{
		private Writer writer;

		protected internal virtual int copyData(int P_0, int P_1)
		{
			return P_1;
		}

		protected internal virtual int[] copyData(int[] P_0, int[] P_1)
		{
			return P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 13, 105, 109 })]
		public SimpleCopy(byte[] P_0)
			: base(P_0)
		{
			writer = new Writer(P_0.Length);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
		[LineNumberTable(new byte[] { 161, 18, 102 })]
		public virtual byte[] doit()
		{
			parse();
			byte[] result = writer.toByteArray();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 24, 110 })]
		public override void sameFrame(int P_0, int P_1)
		{
			writer.sameFrame(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 29, 120 })]
		public override void sameLocals(int P_0, int P_1, int P_2, int P_3)
		{
			writer.sameLocals(P_1, P_2, copyData(P_2, P_3));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 34, 111 })]
		public override void chopFrame(int P_0, int P_1, int P_2)
		{
			writer.chopFrame(P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 39, 120 })]
		public override void appendFrame(int P_0, int P_1, int[] P_2, int[] P_3)
		{
			writer.appendFrame(P_1, P_2, copyData(P_2, P_3));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 45, 120, 37, 135 })]
		public override void fullFrame(int P_0, int P_1, int[] P_2, int[] P_3, int[] P_4, int[] P_5)
		{
			writer.fullFrame(P_1, P_2, copyData(P_2, P_3), P_4, copyData(P_4, P_5));
		}
	}

	internal class SwitchShifter : Shifter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 88, 108 })]
		internal SwitchShifter(StackMapTable P_0, int P_1, int P_2)
			: base(P_0, P_1, P_2, false)
		{
		}

		[LineNumberTable(new byte[] { 163, 123, 101, 99, 105, 102, 47, 166 })]
		internal static byte[] deleteGap(byte[] P_0, int P_1, int P_2)
		{
			P_1 += P_2;
			int num = P_0.Length;
			byte[] array = new byte[num - P_2];
			for (int i = 0; i < num; i++)
			{
				array[i - ((i >= P_1) ? P_2 : 0)] = P_0[i];
			}
			return array;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			163, 93, 103, 113, 98, 110, 107, 105, 139, 129,
			101, 101, 145, 110, 102, 106, 103, 130, 101, 110,
			103, 103, 130, 113
		})]
		internal override void update(int P_0, int P_1, int P_2, int P_3)
		{
			int num = position;
			position = num + P_1 + ((num != 0) ? 1 : 0);
			int num2;
			if (where == position)
			{
				num2 = P_1 - gap;
			}
			else
			{
				if (where != num)
				{
					return;
				}
				num2 = P_1 + gap;
			}
			if (P_1 < 64)
			{
				if (num2 < 64)
				{
					info[P_0] = (byte)(sbyte)(num2 + P_2);
					return;
				}
				byte[] array = Shifter.insertGap(info, P_0, 2);
				array[P_0] = (byte)(sbyte)P_3;
				ByteArray.write16bit(num2, array, P_0 + 1);
				updatedInfo = array;
			}
			else if (num2 < 64)
			{
				byte[] array = deleteGap(info, P_0, 2);
				array[P_0] = (byte)(sbyte)(num2 + P_2);
				updatedInfo = array;
			}
			else
			{
				ByteArray.write16bit(num2, info, P_0 + 1);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			163, 134, 103, 113, 98, 110, 107, 105, 139, 129,
			113
		})]
		internal override void update(int P_0, int P_1)
		{
			int num = position;
			position = num + P_1 + ((num != 0) ? 1 : 0);
			int value;
			if (where == position)
			{
				value = P_1 - gap;
			}
			else
			{
				if (where != num)
				{
					return;
				}
				value = P_1 + gap;
			}
			ByteArray.write16bit(value, info, P_0 + 1);
		}

		[HideFromJava]
		static SwitchShifter()
		{
			Shifter.___003Cclinit_003E();
		}
	}

	public class Walker : java.lang.Object
	{
		internal byte[] info;

		internal int numOfEntries;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 120, 104, 103, 109 })]
		public Walker(byte[] data)
		{
			info = data;
			numOfEntries = ByteArray.readU16bit(data, 0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
		[LineNumberTable(new byte[]
		{
			160, 86, 105, 101, 104, 138, 104, 111, 104, 223,
			48, 104, 111, 104, 111, 111, 101, 98, 104, 111,
			104, 101, 98, 104, 140, 137
		})]
		internal virtual int stackMapFrames(int P_0, int P_1)
		{
			int num = info[P_0];
			if (num < 64)
			{
				sameFrame(P_0, num);
				P_0++;
			}
			else if (num < 128)
			{
				P_0 = sameLocals(P_0, num);
			}
			else
			{
				if (num < 247)
				{
					string msg = new StringBuilder().append("bad frame_type ").append(num).append(" in StackMapTable (pos: ")
						.append(P_0)
						.append(", frame no.:")
						.append(P_1)
						.append(")")
						.toString();
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new BadBytecode(msg);
				}
				if (num == 247)
				{
					P_0 = sameLocals(P_0, num);
				}
				else if (num < 251)
				{
					int offsetDelta = ByteArray.readU16bit(info, P_0 + 1);
					chopFrame(P_0, offsetDelta, 251 - num);
					P_0 += 3;
				}
				else if (num != 251)
				{
					P_0 = ((num >= 255) ? fullFrame(P_0) : appendFrame(P_0, num));
				}
				else
				{
					int offsetDelta = ByteArray.readU16bit(info, P_0 + 1);
					sameFrame(P_0, offsetDelta);
					P_0 += 3;
				}
			}
			return P_0;
		}

		[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
		public virtual void sameFrame(int pos, int offsetDelta)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
		[LineNumberTable(new byte[]
		{
			160, 129, 130, 104, 135, 111, 165, 107, 98, 104,
			111, 107, 165, 106
		})]
		private int sameLocals(int P_0, int P_1)
		{
			int pos = P_0;
			int offsetDelta;
			if (P_1 < 128)
			{
				offsetDelta = P_1 - 64;
			}
			else
			{
				offsetDelta = ByteArray.readU16bit(info, P_0 + 1);
				P_0 += 2;
			}
			int num = info[P_0 + 1];
			int num2 = 0;
			if (num == 7 || num == 8)
			{
				num2 = ByteArray.readU16bit(info, P_0 + 2);
				objectOrUninitialized(num, num2, P_0 + 2);
				P_0 += 2;
			}
			sameLocals(pos, offsetDelta, num, num2);
			return P_0 + 2;
		}

		[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
		public virtual void chopFrame(int pos, int offsetDelta, int k)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
		[LineNumberTable(new byte[]
		{
			160, 175, 104, 111, 103, 103, 101, 107, 107, 102,
			106, 115, 112, 168, 101, 230, 54, 235, 78, 106
		})]
		private int appendFrame(int P_0, int P_1)
		{
			int num = P_1 - 251;
			int offsetDelta = ByteArray.readU16bit(info, P_0 + 1);
			int[] array = new int[num];
			int[] array2 = new int[num];
			int num2 = P_0 + 3;
			for (int i = 0; i < num; i++)
			{
				int num3 = (array[i] = info[num2]);
				if (num3 == 7 || num3 == 8)
				{
					array2[i] = ByteArray.readU16bit(info, num2 + 1);
					objectOrUninitialized(num3, array2[i], num2 + 1);
					num2 += 3;
				}
				else
				{
					array2[i] = 0;
					num2++;
				}
			}
			appendFrame(P_0, offsetDelta, array, array2);
			return num2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
		[LineNumberTable(new byte[]
		{
			160, 211, 111, 111, 103, 103, 110, 111, 105, 105,
			114, 110
		})]
		private int fullFrame(int P_0)
		{
			int offsetDelta = ByteArray.readU16bit(info, P_0 + 1);
			int num = ByteArray.readU16bit(info, P_0 + 3);
			int[] array = new int[num];
			int[] array2 = new int[num];
			int num2 = verifyTypeInfo(P_0 + 5, num, array, array2);
			int num3 = ByteArray.readU16bit(info, num2);
			int[] array3 = new int[num3];
			int[] array4 = new int[num3];
			num2 = verifyTypeInfo(num2 + 2, num3, array3, array4);
			fullFrame(P_0, offsetDelta, array, array2, array3, array4);
			return num2;
		}

		public virtual void objectOrUninitialized(int tag, int data, int pos)
		{
		}

		[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
		public virtual void sameLocals(int pos, int offsetDelta, int stackTag, int stackData)
		{
		}

		[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
		public virtual void appendFrame(int pos, int offsetDelta, int[] tags, int[] data)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			160, 241, 102, 110, 100, 104, 112, 108, 229, 58,
			230, 74
		})]
		private int verifyTypeInfo(int P_0, int P_1, int[] P_2, int[] P_3)
		{
			for (int i = 0; i < P_1; i++)
			{
				byte[] array = info;
				int num = P_0;
				P_0++;
				int num2 = (P_2[i] = array[num]);
				if (num2 == 7 || num2 == 8)
				{
					P_3[i] = ByteArray.readU16bit(info, P_0);
					objectOrUninitialized(num2, P_3[i], P_0);
					P_0 += 2;
				}
			}
			return P_0;
		}

		[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
		public virtual void fullFrame(int pos, int offsetDelta, int[] localTags, int[] localData, int[] stackTags, int[] stackData)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 109, 110 })]
		public Walker(StackMapTable smt)
			: this(smt.get())
		{
		}

		public int size()
		{
			return numOfEntries;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
		[LineNumberTable(new byte[] { 160, 70, 103, 98, 102, 41, 134 })]
		public virtual void parse()
		{
			int num = numOfEntries;
			int num2 = 2;
			for (int i = 0; i < num; i++)
			{
				num2 = stackMapFrames(num2, i);
			}
		}
	}

	public class Writer : java.lang.Object
	{
		internal ByteArrayOutputStream output;

		internal int numOfEntries;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 207, 108, 109 })]
		public virtual byte[] toByteArray()
		{
			byte[] array = output.toByteArray();
			ByteArray.write16bit(numOfEntries, array, 0);
			return array;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 196, 104, 108, 103, 108, 110 })]
		public Writer(int size)
		{
			output = new ByteArrayOutputStream(size);
			numOfEntries = 0;
			output.write(0);
			output.write(0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 227, 110, 101, 142, 112, 137 })]
		public virtual void sameFrame(int offsetDelta)
		{
			numOfEntries++;
			if (offsetDelta < 64)
			{
				output.write(offsetDelta);
				return;
			}
			output.write(251);
			write16(offsetDelta);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 248, 110, 101, 145, 112, 167, 106 })]
		public virtual void sameLocals(int offsetDelta, int tag, int data)
		{
			numOfEntries++;
			if (offsetDelta < 64)
			{
				output.write(offsetDelta + 64);
			}
			else
			{
				output.write(247);
				write16(offsetDelta);
			}
			writeTypeInfo(tag, data);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 9, 110, 114, 105 })]
		public virtual void chopFrame(int offsetDelta, int k)
		{
			numOfEntries++;
			output.write(251 - k);
			write16(offsetDelta);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 28, 110, 99, 114, 103, 102, 44, 134 })]
		public virtual void appendFrame(int offsetDelta, int[] tags, int[] data)
		{
			numOfEntries++;
			int num = tags.Length;
			output.write(num + 251);
			write16(offsetDelta);
			for (int i = 0; i < num; i++)
			{
				writeTypeInfo(tags[i], data[i]);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			162, 57, 110, 112, 103, 99, 103, 102, 44, 166,
			100, 103, 102, 46, 134
		})]
		public virtual void fullFrame(int offsetDelta, int[] localTags, int[] localData, int[] stackTags, int[] stackData)
		{
			numOfEntries++;
			output.write(255);
			write16(offsetDelta);
			int num = localTags.Length;
			write16(num);
			for (int i = 0; i < num; i++)
			{
				writeTypeInfo(localTags[i], localData[i]);
			}
			num = stackTags.Length;
			write16(num);
			for (int i = 0; i < num; i++)
			{
				writeTypeInfo(stackTags[i], stackData[i]);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 78, 116, 116 })]
		private void write16(int P_0)
		{
			output.write((int)(((uint)P_0 >> 8) & 0xFF));
			output.write(P_0 & 0xFF);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 72, 108, 104, 105 })]
		private void writeTypeInfo(int P_0, int P_1)
		{
			output.write(P_0);
			if (P_0 == 7 || P_0 == 8)
			{
				write16(P_1);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(590)]
		public virtual StackMapTable toStackMapTable(ConstPool cp)
		{
			StackMapTable result = new StackMapTable(cp, toByteArray());
			_ = null;
			return result;
		}
	}

	public const string tag = "StackMapTable";

	public const int TOP = 0;

	public const int INTEGER = 1;

	public const int FLOAT = 2;

	public const int DOUBLE = 3;

	public const int LONG = 4;

	public const int NULL = 5;

	public const int THIS = 6;

	public const int OBJECT = 7;

	public const int UNINIT = 8;

	public static int typeTagOf(char descriptor)
	{
		switch (descriptor)
		{
		case 'D':
			return 3;
		case 'F':
			return 2;
		case 'J':
			return 4;
		case 'L':
		case '[':
			return 7;
		default:
			return 1;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 161, 106, 116, 105 })]
	public virtual void insertLocal(int index, int tag, int classInfo)
	{
		byte[] newinfo = new InsertLocal(get(), index, tag, classInfo).doit();
		set(newinfo);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 4, 107 })]
	internal StackMapTable(ConstPool P_0, int P_1, DataInputStream P_2)
		: base(P_0, P_1, P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 158, 191, 66, 109, 112 })]
	internal virtual void shiftPc(int P_0, int P_1, bool P_2)
	{
		new OffsetShifter(this, P_0, P_1).parse();
		new Shifter(this, P_0, P_1, P_2).doit();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 163, 83, 111 })]
	internal virtual void shiftForSwitch(int P_0, int P_1)
	{
		new SwitchShifter(this, P_0, P_1).doit();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 190, 111 })]
	internal StackMapTable(ConstPool P_0, byte[] P_1)
		: base(P_0, "StackMapTable", P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.StackMapTable$RuntimeCopyException" })]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)Ljavassist/bytecode/AttributeInfo;")]
	[LineNumberTable(new byte[] { 21, 116, 56, 161, 97 })]
	public override AttributeInfo copy(ConstPool newCp, Map classnames)
	{
		//Discarded unreachable code: IL_0020
		try
		{
			return new StackMapTable(newCp, new Copier(constPool, info, newCp, classnames).doit());
		}
		catch (BadBytecode)
		{
		}
		_ = null;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeCopyException("bad bytecode. fatal?");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 47, 105 })]
	internal override void write(DataOutputStream P_0)
	{
		base.write(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 87, 105 })]
	public virtual void println(PrintWriter w)
	{
		Printer.print(this, w);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 96, 111 })]
	public virtual void println(PrintStream ps)
	{
		Printer.print(this, new PrintWriter(ps, autoFlush: true));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 163, 159, 114, 217, 2, 97, 145 })]
	public virtual void removeNew(int where)
	{
		BadBytecode badBytecode;
		try
		{
			byte[] newinfo = new NewRemover(get(), where).doit();
			set(newinfo);
			return;
		}
		catch (BadBytecode x)
		{
			badBytecode = ByteCodeHelper.MapException<BadBytecode>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		BadBytecode e = badBytecode;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException("bad stack map table", e);
	}
}
