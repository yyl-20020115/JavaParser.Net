using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;
using javassist.bytecode.stackmap;

namespace javassist.bytecode.analysis;

public class ControlFlow : Object
{
	[SpecialName]
	[IKVM.Attributes.EnclosingMethod(null, "<init>", "(Ljavassist.CtClass;Ljavassist.bytecode.MethodInfo;)V")]
	internal class _1 : BasicBlock.Maker
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ControlFlow this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(68)]
		internal _1(ControlFlow P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(71)]
		protected internal override BasicBlock makeBlock(int P_0)
		{
			Block result = new Block(P_0, access_0024000(this_00240));
			_ = null;
			return result;
		}

		[LineNumberTable(75)]
		protected internal override BasicBlock[] makeArray(int P_0)
		{
			return new Block[P_0];
		}
	}

	[SpecialName]
	[IKVM.Attributes.EnclosingMethod(null, "dominatorTree", "()[Ljavassist.bytecode.analysis.ControlFlow$Node;")]
	internal class _2 : Access
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ControlFlow this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(162)]
		internal _2(ControlFlow P_0, Node[] P_1)
		{
			this_00240 = P_0;
			base._002Ector(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(164)]
		internal override BasicBlock[] exits(Node P_0)
		{
			BasicBlock[] exit = Node.access_0024200(P_0).getExit();
			_ = null;
			return exit;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(166)]
		internal override BasicBlock[] entrances(Node P_0)
		{
			return Node.access_0024200(P_0).entrances;
		}
	}

	[SpecialName]
	[IKVM.Attributes.EnclosingMethod(null, "postDominatorTree", "()[Ljavassist.bytecode.analysis.ControlFlow$Node;")]
	internal class _3 : Access
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ControlFlow this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(210)]
		internal _3(ControlFlow P_0, Node[] P_1)
		{
			this_00240 = P_0;
			base._002Ector(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(212)]
		internal override BasicBlock[] exits(Node P_0)
		{
			return Node.access_0024200(P_0).entrances;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(214)]
		internal override BasicBlock[] entrances(Node P_0)
		{
			BasicBlock[] exit = Node.access_0024200(P_0).getExit();
			_ = null;
			return exit;
		}
	}

	internal abstract class Access : Object
	{
		internal Node[] all;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(339)]
		internal Access(Node[] P_0)
		{
			all = P_0;
		}

		[LineNumberTable(340)]
		internal virtual Node node(BasicBlock P_0)
		{
			return all[((Block)P_0).index];
		}

		internal abstract BasicBlock[] exits(Node P_0);

		internal abstract BasicBlock[] entrances(Node P_0);
	}

	public class Block : BasicBlock
	{
		public object clientData;

		internal int index;

		internal MethodInfo method;

		internal Block[] entrances;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 145, 233, 57, 231, 72, 103 })]
		internal Block(int P_0, MethodInfo P_1)
			: base(P_0)
		{
			clientData = null;
			method = P_1;
		}

		public virtual int incomings()
		{
			return base.incoming;
		}

		[LineNumberTable(311)]
		public virtual int exits()
		{
			return (int)((base.exit != null) ? base.exit.LongLength : 0);
		}

		[LineNumberTable(319)]
		public new virtual Block exit(int n)
		{
			return (Block)base.exit[n];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 212, 102, 103, 99, 109, 169 })]
		public virtual Catcher[] catchers()
		{
			ArrayList arrayList = new ArrayList();
			for (Catch next = toCatch; next != null; next = next.next)
			{
				((List)arrayList).add((object)new Catcher(next));
			}
			return (Catcher[])((List)arrayList).toArray((object[])new Catcher[((List)arrayList).size()]);
		}

		internal virtual BasicBlock[] getExit()
		{
			return base.exit;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 151, 103, 108, 108, 62, 166, 105 })]
		protected internal override void toString2(StringBuilder sbuf)
		{
			base.toString2(sbuf);
			sbuf.append(", incoming{");
			for (int i = 0; i < (nint)entrances.LongLength; i++)
			{
				sbuf.append(((BasicBlock)entrances[i]).position).append(", ");
			}
			sbuf.append('}');
		}

		public virtual int index()
		{
			return this.index;
		}

		public new virtual int position()
		{
			return base.position;
		}

		public new virtual int length()
		{
			return base.length;
		}

		[LineNumberTable(304)]
		public new virtual Block incoming(int n)
		{
			return entrances[n];
		}
	}

	public class Catcher : Object
	{
		private Block node;

		private int typeIndex;

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(494)]
		internal static Block access_0024100(Catcher P_0)
		{
			return P_0.node;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 128, 104, 113, 108 })]
		internal Catcher(BasicBlock.Catch P_0)
		{
			node = (Block)P_0.body;
			typeIndex = P_0.typeIndex;
		}

		public virtual Block block()
		{
			return node;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 143, 104, 134 })]
		public virtual string type()
		{
			if (typeIndex == 0)
			{
				return "java.lang.Throwable";
			}
			string classInfo = node.method.getConstPool().getClassInfo(typeIndex);
			_ = null;
			return classInfo;
		}
	}

	public class Node : Object
	{
		private Block m_block;

		private Node m_parent;

		private Node[] m_children;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 239, 104, 103, 103 })]
		internal Node(Block P_0)
		{
			this.m_block = P_0;
			this.m_parent = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161, 33, 108, 101, 130, 100, 103, 105, 99, 103,
			107, 15, 230, 69, 106
		})]
		internal virtual int makeDepth1stTree(Node P_0, bool[] P_1, int P_2, int[] P_3, Access P_4)
		{
			int index = this.m_block.index;
			if (P_1[index])
			{
				return P_2;
			}
			P_1[index] = true;
			this.m_parent = P_0;
			BasicBlock[] array = P_4.exits(this);
			if (array != null)
			{
				for (int i = 0; i < (nint)array.LongLength; i++)
				{
					Node node = P_4.node(array[i]);
					P_2 = node.makeDepth1stTree(this, P_1, P_2, P_3, P_4);
				}
			}
			int num = P_2;
			P_2++;
			P_3[index] = num;
			return P_2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161, 51, 108, 101, 130, 100, 98, 104, 99, 103,
			107, 108, 226, 61, 230, 70, 105, 100, 106, 104,
			121, 106, 104, 226, 59, 232, 74
		})]
		internal virtual bool makeDominatorTree(bool[] P_0, int[] P_1, Access P_2)
		{
			int index = this.m_block.index;
			if (P_0[index])
			{
				return false;
			}
			P_0[index] = true;
			int result = 0;
			BasicBlock[] array = P_2.exits(this);
			if (array != null)
			{
				for (int i = 0; i < (nint)array.LongLength; i++)
				{
					Node node = P_2.node(array[i]);
					if (node.makeDominatorTree(P_0, P_1, P_2))
					{
						result = 1;
					}
				}
			}
			BasicBlock[] array2 = P_2.entrances(this);
			if (array2 != null)
			{
				for (int j = 0; j < (nint)array2.LongLength; j++)
				{
					if (this.m_parent != null)
					{
						Node ancestor = getAncestor(this.m_parent, P_2.node(array2[j]), P_1);
						if (ancestor != this.m_parent)
						{
							this.m_parent = ancestor;
							result = 1;
						}
					}
				}
			}
			return (byte)result != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(348)]
		internal static void access_0024300(Node[] P_0)
		{
			setChildren(P_0);
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(348)]
		internal static Block access_0024200(Node P_0)
		{
			return P_0.m_block;
		}

		[LineNumberTable(new byte[]
		{
			161,
			95,
			99,
			103,
			102,
			36,
			166,
			102,
			105,
			99,
			252,
			61,
			230,
			70,
			102,
			48,
			166,
			102,
			36,
			166,
			105,
			100,
			104,
			100,
			byte.MaxValue,
			21,
			60,
			233,
			70
		})]
		private static void setChildren(Node[] P_0)
		{
			int num = P_0.Length;
			int[] array = new int[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = 0;
			}
			for (int i = 0; i < num; i++)
			{
				Node node = P_0[i].m_parent;
				if (node != null)
				{
					int index = node.m_block.index;
					int[] array2 = array;
					array2[index]++;
				}
			}
			for (int i = 0; i < num; i++)
			{
				P_0[i].m_children = new Node[array[i]];
			}
			for (int i = 0; i < num; i++)
			{
				array[i] = 0;
			}
			for (int i = 0; i < num; i++)
			{
				Node node = P_0[i];
				Node node2 = node.m_parent;
				if (node2 != null)
				{
					Node[] array3 = node2.m_children;
					int index = node2.m_block.index;
					int[] array2 = array;
					int[] array4 = array2;
					int num2 = index;
					index = array2[index];
					int num3 = num2;
					array2 = array4;
					int num4 = index;
					array2[num3] = index + 1;
					array3[num4] = node;
				}
			}
		}

		public virtual Block block()
		{
			return this.m_block;
		}

		[LineNumberTable(new byte[] { 161, 81, 100, 124, 138, 136, 102, 162 })]
		private static Node getAncestor(Node P_0, Node P_1, int[] P_2)
		{
			while (P_0 != P_1)
			{
				if (P_2[P_0.m_block.index] < P_2[P_1.m_block.index])
				{
					P_0 = P_0.m_parent;
				}
				else
				{
					P_1 = P_1.m_parent;
				}
				if (P_0 == null || P_1 == null)
				{
					return null;
				}
			}
			return P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			160, 249, 102, 124, 108, 127, 12, 108, 108, 63,
			4, 166, 108
		})]
		public override string toString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.append("Node[pos=").append(block().position());
			stringBuilder.append(", parent=");
			stringBuilder.append((this.m_parent != null) ? Integer.toString(this.m_parent.block().position()) : "*");
			stringBuilder.append(", children{");
			for (int i = 0; i < (nint)this.m_children.LongLength; i++)
			{
				stringBuilder.append(this.m_children[i].block().position()).append(", ");
			}
			stringBuilder.append("}]");
			string result = stringBuilder.toString();
			_ = null;
			return result;
		}

		public virtual Node parent()
		{
			return this.m_parent;
		}

		[LineNumberTable(388)]
		public virtual int children()
		{
			return this.m_children.Length;
		}

		[LineNumberTable(395)]
		public virtual Node child(int n)
		{
			return this.m_children[n];
		}
	}

	private CtClass clazz;

	private MethodInfo methodInfo;

	private Block[] m_basicBlocks;

	private Frame[] frames;

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(48)]
	internal static MethodInfo access_0024000(ControlFlow P_0)
	{
		return P_0.methodInfo;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		14, 104, 103, 103, 103, 232, 73, 111, 104, 108,
		104, 103, 102, 106, 104, 115, 228, 60, 230, 71,
		105, 106, 110, 107, 31, 17, 235, 69, 105, 106,
		108, 31, 17, 232, 56, 233, 77
	})]
	public ControlFlow(CtClass ctclazz, MethodInfo minfo)
	{
		clazz = ctclazz;
		methodInfo = minfo;
		frames = null;
		this.m_basicBlocks = (Block[])new _1(this).make(minfo);
		if (this.m_basicBlocks == null)
		{
			this.m_basicBlocks = new Block[0];
		}
		int num = this.m_basicBlocks.Length;
		int[] array = new int[num];
		for (int i = 0; i < num; i++)
		{
			Block block = this.m_basicBlocks[i];
			block.index = i;
			block.entrances = new Block[block.incomings()];
			array[i] = 0;
		}
		for (int i = 0; i < num; i++)
		{
			Block block = this.m_basicBlocks[i];
			for (int j = 0; j < block.exits(); j++)
			{
				Block block2 = block.exit(j);
				Block[] entrances = block2.entrances;
				int index = block2.index;
				int[] array2 = array;
				int[] array3 = array2;
				int num2 = index;
				index = array2[index];
				int num3 = num2;
				array2 = array3;
				int num4 = index;
				array2[num3] = index + 1;
				entrances[num4] = block;
			}
			Catcher[] array4 = block.catchers();
			for (int k = 0; k < (nint)array4.LongLength; k++)
			{
				Block block3 = Catcher.access_0024100(array4[k]);
				Block[] entrances2 = block3.entrances;
				int index = block3.index;
				int[] array2 = array;
				int[] array5 = array2;
				int num5 = index;
				index = array2[index];
				int num3 = num5;
				array2 = array5;
				int num6 = index;
				array2[num3] = index + 1;
				entrances2[num6] = block;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 8, 116 })]
	public ControlFlow(CtMethod method)
		: this(method.getDeclaringClass(), method.getMethodInfo2())
	{
	}

	public virtual Block[] basicBlocks()
	{
		return this.m_basicBlocks;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 73, 104, 156 })]
	public virtual Frame frameAt(int pos)
	{
		if (frames == null)
		{
			frames = new Analyzer().analyze(clazz, methodInfo);
		}
		return frames[pos];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		100, 104, 99, 130, 103, 103, 103, 104, 114, 5,
		232, 69, 233, 70, 143, 104, 37, 136, 110, 102
	})]
	public virtual Node[] dominatorTree()
	{
		int num = this.m_basicBlocks.Length;
		if (num == 0)
		{
			return null;
		}
		Node[] array = new Node[num];
		bool[] array2 = new bool[num];
		int[] array3 = new int[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = new Node(this.m_basicBlocks[i]);
			array2[i] = false;
		}
		_2  = new _2(this, array);
		array[0].makeDepth1stTree(null, array2, 0, array3, );
		do
		{
			for (int j = 0; j < num; j++)
			{
				array2[j] = false;
			}
		}
		while (array[0].makeDominatorTree(array2, array3, ));
		Node.access_0024300(array);
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 84, 104, 99, 130, 103, 103, 103, 104, 114,
		5, 232, 69, 233, 71, 99, 104, 112, 18, 232,
		70, 104, 37, 168, 99, 104, 112, 111, 227, 61,
		200, 135, 102
	})]
	public virtual Node[] postDominatorTree()
	{
		int num = this.m_basicBlocks.Length;
		if (num == 0)
		{
			return null;
		}
		Node[] array = new Node[num];
		bool[] array2 = new bool[num];
		int[] array3 = new int[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = new Node(this.m_basicBlocks[i]);
			array2[i] = false;
		}
		_3  = new _3(this, array);
		int num2 = 0;
		int j;
		for (j = 0; j < num; j++)
		{
			if (Node.access_0024200(array[j]).exits() == 0)
			{
				num2 = array[j].makeDepth1stTree(null, array2, num2, array3, );
			}
		}
		do
		{
			for (int k = 0; k < num; k++)
			{
				array2[k] = false;
			}
			j = 0;
			for (int k = 0; k < num; k++)
			{
				if (Node.access_0024200(array[k]).exits() == 0 && array[k].makeDominatorTree(array2, array3, ))
				{
					j = 1;
				}
			}
		}
		while (j != 0);
		Node.access_0024300(array);
		return array;
	}
}
