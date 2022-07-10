using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;

namespace javassist.bytecode.stackmap;

public abstract class TypeData : Object
{
	public abstract class AbsTypeVar : TypeData
	{
		public abstract void merge(TypeData td);

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(198)]
		public AbsTypeVar()
		{
		}

		public override int getTypeTag()
		{
			return 7;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(205)]
		public override int getTypeData(ConstPool cp)
		{
			int result = cp.addClassInfo(getName());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 96, 104, 138 })]
		public override bool eq(TypeData d)
		{
			if (d.isUninit())
			{
				bool result = d.eq(this);
				_ = null;
				return result;
			}
			bool result2 = String.instancehelper_equals(getName(), d.getName());
			_ = null;
			return result2;
		}
	}

	public class ArrayElement : AbsTypeVar
	{
		private AbsTypeVar array;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
		[LineNumberTable(new byte[] { 162, 74, 104, 110, 104, 110, 104, 104, 147 })]
		public static TypeData make(TypeData array)
		{
			if (array is ArrayType)
			{
				AbsTypeVar result = ((ArrayType)array).elementType();
				_ = null;
				return result;
			}
			if (array is AbsTypeVar)
			{
				ArrayElement result2 = new ArrayElement((AbsTypeVar)array);
				_ = null;
				return result2;
			}
			if (array is ClassName && !array.isNullType())
			{
				ClassName result3 = new ClassName(typeName(array.getName()));
				_ = null;
				return result3;
			}
			string msg = new StringBuilder().append("bad AASTORE: ").append(array).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new BadBytecode(msg);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(692)]
		internal static string access_0024000(string P_0)
		{
			string result = typeName(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 115, 116, 104, 101, 123, 101, 170 })]
		private static string typeName(string P_0)
		{
			if (String.instancehelper_length(P_0) > 1 && String.instancehelper_charAt(P_0, 0) == '[')
			{
				switch (String.instancehelper_charAt(P_0, 1))
				{
				case 'L':
				{
					string result2 = String.instancehelper_replace(String.instancehelper_substring(P_0, 2, String.instancehelper_length(P_0) - 1), '/', '.');
					_ = null;
					return result2;
				}
				case '[':
				{
					string result = String.instancehelper_substring(P_0, 1);
					_ = null;
					return result;
				}
				}
			}
			return "java.lang.Object";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 69, 104, 103 })]
		private ArrayElement(AbsTypeVar P_0)
		{
			array = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			162,
			88,
			104,
			byte.MaxValue,
			4,
			69,
			226,
			61,
			129,
			159,
			6
		})]
		public override void merge(TypeData t)
		{
			BadBytecode badBytecode;
			try
			{
				if (!t.isNullType())
				{
					array.merge(ArrayType.make(t));
				}
				return;
			}
			catch (BadBytecode x)
			{
				badBytecode = ByteCodeHelper.MapException<BadBytecode>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			BadBytecode obj = badBytecode;
			string message = new StringBuilder().append("fatal: ").append(obj).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException(message);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(725)]
		public override string getName()
		{
			string result = typeName(array.getName());
			_ = null;
			return result;
		}

		public virtual AbsTypeVar arrayType()
		{
			return array;
		}

		public override BasicType isBasicType()
		{
			return null;
		}

		public override bool is2WordType()
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
		[LineNumberTable(new byte[] { 162, 128, 116 })]
		public override void setType(string s, ClassPool cp)
		{
			array.setType(ArrayType.typeName(s), cp);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(758)]
		protected internal override TypeVar toTypeVar(int dim)
		{
			TypeVar result = array.toTypeVar(dim - 1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.NotFoundException" })]
		[LineNumberTable(762)]
		public override TypeData getArrayType(int dim)
		{
			TypeData result = array.getArrayType(dim - 1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.NotFoundException" })]
		[IKVM.Attributes.Signature("(Ljava/util/List<Ljavassist/bytecode/stackmap/TypeData;>;ILjavassist/ClassPool;)I")]
		[LineNumberTable(767)]
		public override int dfs(List order, int index, ClassPool cp)
		{
			int result = array.dfs(order, index, cp);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IKVM.Attributes.Signature("(Ljava/util/Set<Ljavassist/bytecode/stackmap/TypeData;>;)Ljava/lang/String;")]
		[LineNumberTable(772)]
		internal override string toString2(Set P_0)
		{
			string result = new StringBuilder().append("*").append(array.toString2(P_0)).toString();
			_ = null;
			return result;
		}
	}

	public class ArrayType : AbsTypeVar
	{
		private AbsTypeVar element;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
		[LineNumberTable(new byte[] { 161, 251, 104, 110, 104, 110, 104, 104, 147 })]
		internal static TypeData make(TypeData P_0)
		{
			if (P_0 is ArrayElement)
			{
				AbsTypeVar result = ((ArrayElement)P_0).arrayType();
				_ = null;
				return result;
			}
			if (P_0 is AbsTypeVar)
			{
				ArrayType result2 = new ArrayType((AbsTypeVar)P_0);
				_ = null;
				return result2;
			}
			if (P_0 is ClassName && !P_0.isNullType())
			{
				ClassName result3 = new ClassName(typeName(P_0.getName()));
				_ = null;
				return result3;
			}
			string msg = new StringBuilder().append("bad AASTORE: ").append(P_0).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new BadBytecode(msg);
		}

		public virtual AbsTypeVar elementType()
		{
			return element;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 34, 107, 125 })]
		public static string typeName(string elementType)
		{
			if (String.instancehelper_charAt(elementType, 0) == '[')
			{
				string result = new StringBuilder().append("[").append(elementType).toString();
				_ = null;
				return result;
			}
			string result2 = new StringBuilder().append("[L").append(String.instancehelper_replace(elementType, '.', '/')).append(";")
				.toString();
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 246, 104, 103 })]
		private ArrayType(AbsTypeVar P_0)
		{
			element = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			162,
			9,
			104,
			byte.MaxValue,
			4,
			69,
			226,
			61,
			129,
			159,
			6
		})]
		public override void merge(TypeData t)
		{
			BadBytecode badBytecode;
			try
			{
				if (!t.isNullType())
				{
					element.merge(ArrayElement.make(t));
				}
				return;
			}
			catch (BadBytecode x)
			{
				badBytecode = ByteCodeHelper.MapException<BadBytecode>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			BadBytecode obj = badBytecode;
			string message = new StringBuilder().append("fatal: ").append(obj).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException(message);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(646)]
		public override string getName()
		{
			string result = typeName(element.getName());
			_ = null;
			return result;
		}

		public override BasicType isBasicType()
		{
			return null;
		}

		public override bool is2WordType()
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
		[LineNumberTable(new byte[] { 162, 41, 116 })]
		public override void setType(string s, ClassPool cp)
		{
			element.setType(ArrayElement.access_0024000(s), cp);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(671)]
		protected internal override TypeVar toTypeVar(int dim)
		{
			TypeVar result = element.toTypeVar(dim + 1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.NotFoundException" })]
		[LineNumberTable(675)]
		public override TypeData getArrayType(int dim)
		{
			TypeData arrayType = element.getArrayType(dim + 1);
			_ = null;
			return arrayType;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.NotFoundException" })]
		[IKVM.Attributes.Signature("(Ljava/util/List<Ljavassist/bytecode/stackmap/TypeData;>;ILjavassist/ClassPool;)I")]
		[LineNumberTable(680)]
		public override int dfs(List order, int index, ClassPool cp)
		{
			int result = element.dfs(order, index, cp);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IKVM.Attributes.Signature("(Ljava/util/Set<Ljavassist/bytecode/stackmap/TypeData;>;)Ljava/lang/String;")]
		[LineNumberTable(685)]
		internal override string toString2(Set P_0)
		{
			string result = new StringBuilder().append("[").append(element.toString2(P_0)).toString();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Protected | Modifiers.Static)]
	public class BasicType : TypeData
	{
		private string name;

		private int typeTag;

		private char decodedName;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 159, 110, 98, 104, 103, 103, 103 })]
		public BasicType(string type, int tag, char decoded)
		{
			name = type;
			typeTag = tag;
			decodedName = decoded;
		}

		public override int getTypeTag()
		{
			return typeTag;
		}

		public override int getTypeData(ConstPool cp)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 92, 104, 98 })]
		public override TypeData join()
		{
			if (this == TypeTag.TOP)
			{
				return this;
			}
			TypeData result = base.join();
			_ = null;
			return result;
		}

		public override BasicType isBasicType()
		{
			return this;
		}

		public override bool is2WordType()
		{
			return (typeTag == 4 || typeTag == 3) ? true : false;
		}

		public override bool eq(TypeData d)
		{
			return this == d;
		}

		public override string getName()
		{
			return name;
		}

		public virtual char getDecodedName()
		{
			return decodedName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
		[LineNumberTable(168)]
		public override void setType(string s, ClassPool cp)
		{
			string msg = new StringBuilder().append("conflict: ").append(name).append(" and ")
				.append(s)
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new BadBytecode(msg);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.NotFoundException" })]
		[LineNumberTable(new byte[]
		{
			126, 104, 98, 100, 127, 11, 99, 130, 105, 102,
			37, 166, 105
		})]
		public override TypeData getArrayType(int dim)
		{
			if (this == TypeTag.TOP)
			{
				return this;
			}
			if (dim < 0)
			{
				string msg = new StringBuilder().append("no element type: ").append(name).toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new NotFoundException(msg);
			}
			if (dim == 0)
			{
				return this;
			}
			char[] array = new char[dim + 1];
			for (int i = 0; i < dim; i++)
			{
				array[i] = '[';
			}
			array[dim] = decodedName;
			ClassName result = new ClassName(String.newhelper(array));
			_ = null;
			return result;
		}

		[IKVM.Attributes.Signature("(Ljava/util/Set<Ljavassist/bytecode/stackmap/TypeData;>;)Ljava/lang/String;")]
		internal override string toString2(Set P_0)
		{
			return name;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(124)]
		internal static char access_0024100(BasicType P_0)
		{
			return P_0.decodedName;
		}
	}

	public class ClassName : TypeData
	{
		private string name;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 211, 104, 103 })]
		public ClassName(string n)
		{
			name = n;
		}

		public override string getName()
		{
			return name;
		}

		public override BasicType isBasicType()
		{
			return null;
		}

		public override bool is2WordType()
		{
			return false;
		}

		public override int getTypeTag()
		{
			return 7;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(857)]
		public override int getTypeData(ConstPool cp)
		{
			int result = cp.addClassInfo(getName());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 236, 104, 138 })]
		public override bool eq(TypeData d)
		{
			if (d.isUninit())
			{
				bool result = d.eq(this);
				_ = null;
				return result;
			}
			bool result2 = String.instancehelper_equals(name, d.getName());
			_ = null;
			return result2;
		}

		[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
		public override void setType(string typeName, ClassPool cp)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.NotFoundException" })]
		[LineNumberTable(new byte[]
		{
			162, 247, 99, 98, 103, 103, 102, 37, 166, 103,
			107, 159, 15, 191, 4, 103, 112, 31, 27, 198,
			110, 101, 117, 101, 127, 14, 109, 102, 109, 102,
			109, 134
		})]
		public override TypeData getArrayType(int dim)
		{
			if (dim == 0)
			{
				return this;
			}
			if (dim > 0)
			{
				char[] array = new char[dim];
				for (int i = 0; i < dim; i++)
				{
					array[i] = '[';
				}
				string text = getName();
				if (String.instancehelper_charAt(text, 0) != '[')
				{
					text = new StringBuilder().append("L").append(String.instancehelper_replace(text, '.', '/')).append(";")
						.toString();
				}
				ClassName result = new ClassName(new StringBuilder().append(String.newhelper(array)).append(text).toString());
				_ = null;
				return result;
			}
			int j;
			for (j = 0; j < -dim; j++)
			{
				if (String.instancehelper_charAt(name, j) != '[')
				{
					string msg = new StringBuilder().append("no ").append(dim).append(" dimensional array type: ")
						.append(getName())
						.toString();
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new NotFoundException(msg);
				}
			}
			j = String.instancehelper_charAt(name, -dim);
			switch (j)
			{
			case 91:
			{
				ClassName result3 = new ClassName(String.instancehelper_substring(name, -dim));
				_ = null;
				return result3;
			}
			case 76:
			{
				ClassName result2 = new ClassName(String.instancehelper_replace(String.instancehelper_substring(name, -dim + 1, String.instancehelper_length(name) - 1), '/', '.'));
				_ = null;
				return result2;
			}
			default:
				if (j == BasicType.access_0024100(TypeTag.DOUBLE))
				{
					return TypeTag.DOUBLE;
				}
				if (j == BasicType.access_0024100(TypeTag.FLOAT))
				{
					return TypeTag.FLOAT;
				}
				if (j == BasicType.access_0024100(TypeTag.LONG))
				{
					return TypeTag.LONG;
				}
				return TypeTag.INTEGER;
			}
		}

		[IKVM.Attributes.Signature("(Ljava/util/Set<Ljavassist/bytecode/stackmap/TypeData;>;)Ljava/lang/String;")]
		internal override string toString2(Set P_0)
		{
			return name;
		}
	}

	public class NullType : ClassName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 38, 109 })]
		public NullType()
			: base("null-type")
		{
		}

		public override int getTypeTag()
		{
			return 5;
		}

		public override bool isNullType()
		{
			return true;
		}

		public override int getTypeData(ConstPool cp)
		{
			return 0;
		}

		public override TypeData getArrayType(int dim)
		{
			return this;
		}
	}

	public class TypeVar : AbsTypeVar
	{
		[IKVM.Attributes.Signature("Ljava/util/List<Ljavassist/bytecode/stackmap/TypeData;>;")]
		protected internal List lowers;

		[IKVM.Attributes.Signature("Ljava/util/List<Ljavassist/bytecode/stackmap/TypeData;>;")]
		protected internal List usedBy;

		[IKVM.Attributes.Signature("Ljava/util/List<Ljava/lang/String;>;")]
		protected internal List uppers;

		protected internal string fixedType;

		private new bool m_is2WordType;

		private int visited;

		private int smallest;

		private bool inList;

		private int dimension;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			160, 112, 232, 160, 78, 103, 103, 103, 231, 159,
			176, 103, 108, 108, 103, 103, 108
		})]
		public TypeVar(TypeData t)
		{
			visited = 0;
			smallest = 0;
			inList = false;
			dimension = 0;
			uppers = null;
			lowers = new ArrayList(2);
			usedBy = new ArrayList(2);
			merge(t);
			fixedType = null;
			this.m_is2WordType = t.is2WordType();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 160, 109, 104, 114 })]
		public override void merge(TypeData t)
		{
			lowers.add(t);
			if (t is TypeVar)
			{
				((TypeVar)t).usedBy.add(this);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 130, 104, 121 })]
		public override BasicType isBasicType()
		{
			if (fixedType == null)
			{
				BasicType result = ((TypeData)lowers.get(0)).isBasicType();
				_ = null;
				return result;
			}
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 146, 104, 121 })]
		public override bool isNullType()
		{
			if (fixedType == null)
			{
				bool result = ((TypeData)lowers.get(0)).isNullType();
				_ = null;
				return result;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 123, 104, 121 })]
		public override string getName()
		{
			if (fixedType == null)
			{
				string name = ((TypeData)lowers.get(0)).getName();
				_ = null;
				return name;
			}
			return fixedType;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.NotFoundException" })]
		[IKVM.Attributes.Signature("(Ljava/util/List<Ljavassist/bytecode/stackmap/TypeData;>;ILjavassist/ClassPool;)I")]
		[LineNumberTable(new byte[]
		{
			160, 220, 105, 130, 119, 104, 103, 108, 105, 125,
			99, 104, 107, 110, 142, 104, 110, 236, 54, 233,
			77, 110, 167, 116, 103, 105, 100, 169
		})]
		public override int dfs(List preOrder, int index, ClassPool cp)
		{
			if (visited > 0)
			{
				return index;
			}
			index++;
			int num = index;
			smallest = num;
			visited = num;
			preOrder.add(this);
			inList = true;
			int num2 = lowers.size();
			for (int i = 0; i < num2; i++)
			{
				TypeVar typeVar = ((TypeData)lowers.get(i)).toTypeVar(dimension);
				if (typeVar == null)
				{
					continue;
				}
				if (typeVar.visited == 0)
				{
					index = typeVar.dfs(preOrder, index, cp);
					if (typeVar.smallest < smallest)
					{
						smallest = typeVar.smallest;
					}
				}
				else if (typeVar.inList && typeVar.visited < smallest)
				{
					smallest = typeVar.visited;
				}
			}
			if (visited == smallest)
			{
				ArrayList arrayList = new ArrayList();
				TypeVar typeVar;
				do
				{
					typeVar = (TypeVar)preOrder.remove(preOrder.size() - 1);
					typeVar.inList = false;
					((List)arrayList).add((object)typeVar);
				}
				while (typeVar != this);
				fixTypes(arrayList, cp);
			}
			return index;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.NotFoundException" })]
		[IKVM.Attributes.Signature("(Ljava/util/List<Ljavassist/bytecode/stackmap/TypeData;>;Ljavassist/ClassPool;)V")]
		[LineNumberTable(new byte[]
		{
			160,
			byte.MaxValue,
			102,
			98,
			98,
			103,
			107,
			111,
			105,
			105,
			108,
			112,
			112,
			105,
			99,
			100,
			98,
			227,
			69,
			105,
			165,
			98,
			197,
			112,
			98,
			102,
			194,
			109,
			238,
			35,
			235,
			60,
			235,
			101,
			99,
			108,
			170,
			107,
			144
		})]
		private void fixTypes(List P_0, ClassPool P_1)
		{
			HashSet hashSet = new HashSet();
			int num = 0;
			TypeData typeData = null;
			int num2 = P_0.size();
			for (int i = 0; i < num2; i++)
			{
				TypeVar typeVar = (TypeVar)P_0.get(i);
				List list = typeVar.lowers;
				int num3 = list.size();
				for (int j = 0; j < num3; j++)
				{
					TypeData typeData2 = (TypeData)list.get(j);
					TypeData arrayType = typeData2.getArrayType(typeVar.dimension);
					BasicType basicType = arrayType.isBasicType();
					if (typeData == null)
					{
						if (basicType == null)
						{
							num = 0;
							typeData = arrayType;
							if (arrayType.isUninit())
							{
								break;
							}
						}
						else
						{
							num = 1;
							typeData = basicType;
						}
					}
					else if ((basicType == null && num != 0) || (basicType != null && typeData != basicType))
					{
						num = 1;
						typeData = TypeTag.TOP;
						break;
					}
					if (basicType == null && !arrayType.isNullType())
					{
						((Set)hashSet).add((object)arrayType.getName());
					}
				}
			}
			if (num != 0)
			{
				this.m_is2WordType = typeData.is2WordType();
				fixTypes1(P_0, typeData);
			}
			else
			{
				string n = fixTypes2(P_0, hashSet, P_1);
				fixTypes1(P_0, new ClassName(n));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.NotFoundException" })]
		[IKVM.Attributes.Signature("(Ljava/util/List<Ljavassist/bytecode/stackmap/TypeData;>;Ljavassist/bytecode/stackmap/TypeData;)V")]
		[LineNumberTable(new byte[]
		{
			161, 51, 103, 105, 109, 110, 104, 142, 107, 109,
			236, 56, 233, 75
		})]
		private void fixTypes1(List P_0, TypeData P_1)
		{
			int num = P_0.size();
			for (int i = 0; i < num; i++)
			{
				TypeVar typeVar = (TypeVar)P_0.get(i);
				TypeData arrayType = P_1.getArrayType(-typeVar.dimension);
				if (arrayType.isBasicType() == null)
				{
					typeVar.fixedType = arrayType.getName();
					continue;
				}
				typeVar.lowers.clear();
				typeVar.lowers.add(arrayType);
				typeVar.m_is2WordType = arrayType.is2WordType();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.NotFoundException" })]
		[IKVM.Attributes.Signature("(Ljava/util/List<Ljavassist/bytecode/stackmap/TypeData;>;Ljava/util/Set<Ljava/lang/String;>;Ljavassist/ClassPool;)Ljava/lang/String;")]
		[LineNumberTable(new byte[]
		{
			161, 66, 103, 104, 98, 105, 140, 114, 104, 154,
			112, 143, 104, 137
		})]
		private string fixTypes2(List P_0, Set P_1, ClassPool P_2)
		{
			Iterator iterator = P_1.iterator();
			if (P_1.isEmpty())
			{
				return null;
			}
			if (P_1.size() == 1)
			{
				return (string)iterator.next();
			}
			CtClass ctClass = P_2.get((string)iterator.next());
			while (iterator.hasNext())
			{
				ctClass = commonSuperClassEx(ctClass, P_2.get((string)iterator.next()));
			}
			if (ctClass.getSuperclass() == null || isObjectArray(ctClass))
			{
				ctClass = fixByUppers(P_0, P_2, new HashSet(), ctClass);
			}
			if (ctClass.isArray())
			{
				string result = Descriptor.toJvmName(ctClass);
				_ = null;
				return result;
			}
			string name = ctClass.getName();
			_ = null;
			return name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.NotFoundException" })]
		[LineNumberTable(457)]
		private static bool isObjectArray(CtClass P_0)
		{
			return (P_0.isArray() && P_0.getComponentType().getSuperclass() == null) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.NotFoundException" })]
		[IKVM.Attributes.Signature("(Ljava/util/List<Ljavassist/bytecode/stackmap/TypeData;>;Ljavassist/ClassPool;Ljava/util/Set<Ljavassist/bytecode/stackmap/TypeData;>;Ljavassist/CtClass;)Ljavassist/CtClass;")]
		[LineNumberTable(new byte[]
		{
			161, 93, 99, 131, 103, 105, 109, 105, 131, 104,
			108, 104, 122, 107, 228, 61, 232, 71, 242, 50,
			233, 81
		})]
		private CtClass fixByUppers(List P_0, ClassPool P_1, Set P_2, CtClass P_3)
		{
			if (P_0 == null)
			{
				return P_3;
			}
			int num = P_0.size();
			for (int i = 0; i < num; i++)
			{
				TypeVar typeVar = (TypeVar)P_0.get(i);
				if (!P_2.add(typeVar))
				{
					return P_3;
				}
				if (typeVar.uppers != null)
				{
					int num2 = typeVar.uppers.size();
					for (int j = 0; j < num2; j++)
					{
						CtClass ctClass = P_1.get((string)typeVar.uppers.get(j));
						if (ctClass.subtypeOf(P_3))
						{
							P_3 = ctClass;
						}
					}
				}
				P_3 = fixByUppers(typeVar.usedBy, P_1, P_2, P_3);
			}
			return P_3;
		}

		public override bool is2WordType()
		{
			if (fixedType == null)
			{
				return this.m_is2WordType;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 153, 104, 121 })]
		public override bool isUninit()
		{
			if (fixedType == null)
			{
				bool result = ((TypeData)lowers.get(0)).isUninit();
				_ = null;
				return result;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 170, 104, 121 })]
		public override int getTypeTag()
		{
			if (fixedType == null)
			{
				int typeTag = ((TypeData)lowers.get(0)).getTypeTag();
				_ = null;
				return typeTag;
			}
			int typeTag2 = base.getTypeTag();
			_ = null;
			return typeTag2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 177, 104, 122 })]
		public override int getTypeData(ConstPool cp)
		{
			if (fixedType == null)
			{
				int typeData = ((TypeData)lowers.get(0)).getTypeData(cp);
				_ = null;
				return typeData;
			}
			int typeData2 = base.getTypeData(cp);
			_ = null;
			return typeData2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
		[LineNumberTable(new byte[] { 160, 184, 104, 139, 109 })]
		public override void setType(string typeName, ClassPool cp)
		{
			if (uppers == null)
			{
				uppers = new ArrayList();
			}
			uppers.add(typeName);
		}

		protected internal override TypeVar toTypeVar(int dim)
		{
			dimension = dim;
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.NotFoundException" })]
		[LineNumberTable(new byte[] { 160, 206, 99, 98, 103, 99, 104, 136, 116 })]
		public override TypeData getArrayType(int dim)
		{
			if (dim == 0)
			{
				return this;
			}
			BasicType basicType = isBasicType();
			if (basicType == null)
			{
				if (isNullType())
				{
					NullType result = new NullType();
					_ = null;
					return result;
				}
				TypeData arrayType = new ClassName(getName()).getArrayType(dim);
				_ = null;
				return arrayType;
			}
			TypeData arrayType2 = basicType.getArrayType(dim);
			_ = null;
			return arrayType2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IKVM.Attributes.Signature("(Ljava/util/Set<Ljavassist/bytecode/stackmap/TypeData;>;)Ljava/lang/String;")]
		[LineNumberTable(new byte[] { 161, 119, 104, 110, 114, 108, 170 })]
		internal override string toString2(Set P_0)
		{
			P_0.add(this);
			if (lowers.size() > 0)
			{
				TypeData typeData = (TypeData)lowers.get(0);
				if (typeData != null && !P_0.contains(typeData))
				{
					string result = typeData.toString2(P_0);
					_ = null;
					return result;
				}
			}
			return "?";
		}
	}

	public class UninitData : ClassName
	{
		internal int offset;

		internal bool initialized;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 63, 105, 103, 103 })]
		internal UninitData(int P_0, string P_1)
			: base(P_1)
		{
			this.offset = P_0;
			initialized = false;
		}

		public virtual int offset()
		{
			return this.offset;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(950)]
		public virtual UninitData copy()
		{
			UninitData result = new UninitData(this.offset, getName());
			_ = null;
			return result;
		}

		public override int getTypeTag()
		{
			return 8;
		}

		public override int getTypeData(ConstPool cp)
		{
			return this.offset;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 82, 104, 115 })]
		public override TypeData join()
		{
			if (initialized)
			{
				TypeVar result = new TypeVar(new ClassName(getName()));
				_ = null;
				return result;
			}
			UninitTypeVar result2 = new UninitTypeVar(copy());
			_ = null;
			return result2;
		}

		public override bool isUninit()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 92, 104, 103, 159, 7 })]
		public override bool eq(TypeData d)
		{
			if (d is UninitData)
			{
				UninitData uninitData = (UninitData)d;
				return (this.offset == uninitData.offset && String.instancehelper_equals(getName(), uninitData.getName())) ? true : false;
			}
			return false;
		}

		public override void constructorCalled(int offset)
		{
			if (offset == this.offset)
			{
				initialized = true;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IKVM.Attributes.Signature("(Ljava/util/Set<Ljavassist/bytecode/stackmap/TypeData;>;)Ljava/lang/String;")]
		[LineNumberTable(990)]
		internal override string toString2(Set P_0)
		{
			string result = new StringBuilder().append(getName()).append(",").append(this.offset)
				.toString();
			_ = null;
			return result;
		}
	}

	public class UninitThis : UninitData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 113, 106 })]
		internal UninitThis(string P_0)
			: base(-1, P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(999)]
		public override UninitData copy()
		{
			UninitThis result = new UninitThis(getName());
			_ = null;
			return result;
		}

		public override int getTypeTag()
		{
			return 6;
		}

		public override int getTypeData(ConstPool cp)
		{
			return 0;
		}

		[IKVM.Attributes.Signature("(Ljava/util/Set<Ljavassist/bytecode/stackmap/TypeData;>;)Ljava/lang/String;")]
		internal override string toString2(Set P_0)
		{
			return "uninit:this";
		}
	}

	public class UninitTypeVar : AbsTypeVar
	{
		protected internal TypeData type;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 191, 109, 113 })]
		public virtual int offset()
		{
			if (type is UninitData)
			{
				return ((UninitData)type).offset;
			}
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException("not available");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(779)]
		public UninitTypeVar(UninitData t)
		{
			type = t;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(781)]
		public override int getTypeTag()
		{
			int typeTag = type.getTypeTag();
			_ = null;
			return typeTag;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(783)]
		public override int getTypeData(ConstPool cp)
		{
			int typeData = type.getTypeData(cp);
			_ = null;
			return typeData;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(785)]
		public override BasicType isBasicType()
		{
			BasicType result = type.isBasicType();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(787)]
		public override bool is2WordType()
		{
			bool result = type.is2WordType();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(789)]
		public override bool isUninit()
		{
			bool result = type.isUninit();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(791)]
		public override bool eq(TypeData d)
		{
			bool result = type.eq(d);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(793)]
		public override string getName()
		{
			string name = type.getName();
			_ = null;
			return name;
		}

		protected internal override TypeVar toTypeVar(int dim)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(798)]
		public override TypeData join()
		{
			TypeData result = type.join();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
		[LineNumberTable(new byte[] { 162, 176, 111 })]
		public override void setType(string s, ClassPool cp)
		{
			type.setType(s, cp);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 181, 110, 107 })]
		public override void merge(TypeData t)
		{
			if (!t.eq(type))
			{
				type = TypeTag.TOP;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 187, 110 })]
		public override void constructorCalled(int offset)
		{
			type.constructorCalled(offset);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.NotFoundException" })]
		[LineNumberTable(824)]
		public override TypeData getArrayType(int dim)
		{
			TypeData arrayType = type.getArrayType(dim);
			_ = null;
			return arrayType;
		}

		[IKVM.Attributes.Signature("(Ljava/util/Set<Ljavassist/bytecode/stackmap/TypeData;>;)Ljava/lang/String;")]
		internal override string toString2(Set P_0)
		{
			return "";
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 181, 103, 102, 40, 166 })]
	public static TypeData[] make(int size)
	{
		TypeData[] array = new TypeData[size];
		for (int i = 0; i < size; i++)
		{
			array[i] = TypeTag.TOP;
		}
		return array;
	}

	public abstract bool is2WordType();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		161, 223, 104, 104, 145, 104, 104, 105, 104, 104,
		108, 104, 162, 127, 6
	})]
	public static void aastore(TypeData array, TypeData value, ClassPool cp)
	{
		if (array is AbsTypeVar && !value.isNullType())
		{
			((AbsTypeVar)array).merge(ArrayType.make(value));
		}
		if (!(value is AbsTypeVar))
		{
			return;
		}
		if (array is AbsTypeVar)
		{
			ArrayElement.make(array);
			return;
		}
		if (array is ClassName)
		{
			if (!array.isNullType())
			{
				string str = ArrayElement.access_0024000(array.getName());
				value.setType(str, cp);
			}
			return;
		}
		string msg = new StringBuilder().append("bad AASTORE: ").append(array).toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new BadBytecode(msg);
	}

	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	public abstract void setType(string str, ClassPool cp);

	public virtual bool isUninit()
	{
		return false;
	}

	public virtual void constructorCalled(int offset)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(63)]
	public virtual TypeData join()
	{
		TypeVar result = new TypeVar(this);
		_ = null;
		return result;
	}

	[Throws(new string[] { "javassist.NotFoundException" })]
	[IKVM.Attributes.Signature("(Ljava/util/List<Ljavassist/bytecode/stackmap/TypeData;>;ILjavassist/ClassPool;)I")]
	public virtual int dfs(List order, int index, ClassPool cp)
	{
		return index;
	}

	public abstract int getTypeTag();

	public abstract int getTypeData(ConstPool cp);

	public abstract bool eq(TypeData td);

	[Modifiers(Modifiers.Abstract)]
	[IKVM.Attributes.Signature("(Ljava/util/Set<Ljavassist/bytecode/stackmap/TypeData;>;)Ljava/lang/String;")]
	internal virtual string toString2(Set P_0)
	{
		throw new AbstractMethodError("javassist.bytecode.stackmap.TypeData.toString2(Ljava.util.Set;)Ljava.lang.String;");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		161, 135, 100, 98, 118, 103, 103, 104, 100, 98,
		100, 130, 112, 63, 0, 168, 112, 98, 112, 147
	})]
	public static CtClass commonSuperClassEx(CtClass one, CtClass two)
	{
		if (one == two)
		{
			return one;
		}
		if (one.isArray() && two.isArray())
		{
			CtClass componentType = one.getComponentType();
			CtClass componentType2 = two.getComponentType();
			CtClass ctClass = commonSuperClassEx(componentType, componentType2);
			if (ctClass == componentType)
			{
				return one;
			}
			if (ctClass == componentType2)
			{
				return two;
			}
			CtClass result = one.getClassPool().get((ctClass != null) ? new StringBuilder().append(ctClass.getName()).append("[]").toString() : "java.lang.Object");
			_ = null;
			return result;
		}
		if (one.isPrimitive() || two.isPrimitive())
		{
			return null;
		}
		if (one.isArray() || two.isArray())
		{
			CtClass result2 = one.getClassPool().get("java.lang.Object");
			_ = null;
			return result2;
		}
		CtClass result3 = commonSuperClass(one, two);
		_ = null;
		return result3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		161, 162, 98, 98, 98, 226, 69, 113, 130, 104,
		136, 132, 98, 162, 132, 98, 98, 130, 98, 98,
		162, 99, 99, 197, 103, 99, 130, 169, 194, 105,
		103, 169
	})]
	public static CtClass commonSuperClass(CtClass one, CtClass two)
	{
		CtClass ctClass = one;
		CtClass ctClass2 = two;
		CtClass ctClass3 = ctClass2;
		CtClass ctClass4 = ctClass;
		while (true)
		{
			if (eq(ctClass, ctClass2) && ctClass.getSuperclass() != null)
			{
				return ctClass;
			}
			CtClass superclass = ctClass.getSuperclass();
			CtClass superclass2 = ctClass2.getSuperclass();
			if (superclass2 == null)
			{
				ctClass2 = ctClass3;
				break;
			}
			if (superclass == null)
			{
				ctClass = ctClass4;
				ctClass4 = ctClass3;
				ctClass3 = ctClass;
				ctClass = ctClass2;
				ctClass2 = ctClass3;
				break;
			}
			ctClass = superclass;
			ctClass2 = superclass2;
		}
		while (true)
		{
			ctClass = ctClass.getSuperclass();
			if (ctClass == null)
			{
				break;
			}
			ctClass4 = ctClass4.getSuperclass();
		}
		ctClass = ctClass4;
		while (!eq(ctClass, ctClass2))
		{
			ctClass = ctClass.getSuperclass();
			ctClass2 = ctClass2.getSuperclass();
		}
		return ctClass;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(589)]
	internal static bool eq(CtClass P_0, CtClass P_1)
	{
		return (P_0 == P_1 || (P_0 != null && P_1 != null && String.instancehelper_equals(P_0.getName(), P_1.getName()))) ? true : false;
	}

	public virtual bool isNullType()
	{
		return false;
	}

	public abstract string getName();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(46)]
	protected internal TypeData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 7, 106 })]
	private static void setType(TypeData P_0, string P_1, ClassPool P_2)
	{
		P_0.setType(P_1, P_2);
	}

	public abstract BasicType isBasicType();

	[Throws(new string[] { "javassist.NotFoundException" })]
	public abstract TypeData getArrayType(int i);

	protected internal virtual TypeVar toTypeVar(int dim)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(116)]
	public override string toString()
	{
		string result = new StringBuilder().append(base.toString()).append("(").append(toString2(new HashSet()))
			.append(")")
			.toString();
		_ = null;
		return result;
	}
}
