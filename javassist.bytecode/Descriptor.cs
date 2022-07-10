using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace javassist.bytecode;

public class Descriptor : Object
{
	public class Iterator : Object
	{
		private string desc;

		private int index;

		private int curPos;

		private bool param;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 159, 104, 103, 114, 103 })]
		public Iterator(string s)
		{
			desc = s;
			int num = 0;
			curPos = num;
			index = num;
			param = false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			162, 195, 103, 109, 101, 110, 113, 167, 101, 110,
			113, 167, 101, 147, 101, 113, 100, 176, 132, 108,
			103
		})]
		public virtual int next()
		{
			int num = index;
			int num2 = String.instancehelper_charAt(desc, num);
			if (num2 == 40)
			{
				index++;
				string @this = desc;
				num++;
				num2 = String.instancehelper_charAt(@this, num);
				param = true;
			}
			if (num2 == 41)
			{
				index++;
				string this2 = desc;
				num++;
				num2 = String.instancehelper_charAt(this2, num);
				param = false;
			}
			while (true)
			{
				switch (num2)
				{
				case 91:
					goto IL_006f;
				case 76:
					num = String.instancehelper_indexOf(desc, 59, num) + 1;
					if (num <= 0)
					{
						Throwable.___003CsuppressFillInStackTrace_003E();
						throw new IndexOutOfBoundsException("bad descriptor");
					}
					break;
				default:
					num++;
					break;
				}
				break;
				IL_006f:
				string this3 = desc;
				num++;
				num2 = String.instancehelper_charAt(this3, num);
			}
			curPos = index;
			index = num;
			return curPos;
		}

		public virtual bool isParameter()
		{
			return param;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 186, 103 })]
		public virtual bool is2byte()
		{
			int num = currentChar();
			return (num == 68 || num == 74) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(806)]
		public virtual char currentChar()
		{
			char result = String.instancehelper_charAt(desc, curPos);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(795)]
		public virtual bool hasNext()
		{
			return index < String.instancehelper_length(desc);
		}
	}

	internal class PrettyPrinter : Object
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			162, 96, 102, 107, 98, 105, 107, 100, 137, 171,
			105, 130, 137
		})]
		internal static string toString(string P_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (String.instancehelper_charAt(P_0, 0) == '(')
			{
				int num = 1;
				stringBuilder.append('(');
				while (String.instancehelper_charAt(P_0, num) != ')')
				{
					if (num > 1)
					{
						stringBuilder.append(',');
					}
					num = readType(stringBuilder, num, P_0);
				}
				stringBuilder.append(')');
			}
			else
			{
				readType(stringBuilder, 0, P_0);
			}
			string result = stringBuilder.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			162, 116, 104, 98, 101, 100, 175, 133, 109, 101,
			130, 101, 131, 170, 103, 173, 104, 142
		})]
		internal static int readType(StringBuilder P_0, int P_1, string P_2)
		{
			int num = String.instancehelper_charAt(P_2, P_1);
			int num2 = 0;
			while (num == 91)
			{
				num2++;
				P_1++;
				num = String.instancehelper_charAt(P_2, P_1);
			}
			if (num == 76)
			{
				while (true)
				{
					P_1++;
					num = String.instancehelper_charAt(P_2, P_1);
					switch (num)
					{
					case 47:
						num = 46;
						goto IL_0043;
					default:
						goto IL_0043;
					case 59:
						break;
					}
					break;
					IL_0043:
					P_0.append((char)num);
				}
			}
			else
			{
				CtClass ctClass = toPrimitiveClass((char)num);
				P_0.append(ctClass.getName());
			}
			while (true)
			{
				int num3 = num2;
				num2 += -1;
				if (num3 <= 0)
				{
					break;
				}
				P_0.append("[]");
			}
			return P_1 + 1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(720)]
		internal PrettyPrinter()
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(40)]
	public static string toJvmName(string classname)
	{
		string result = String.instancehelper_replace(classname, '.', '/');
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(53)]
	public static string toJavaName(string classname)
	{
		string result = String.instancehelper_replace(classname, '/', '.');
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 161, 153, 103, 107, 100, 164 })]
	public static CtClass toCtClass(string desc, ClassPool cp)
	{
		CtClass[] array = new CtClass[1];
		int num = toCtClass(cp, desc, 0, array, 0);
		if (num >= 0)
		{
			return array[0];
		}
		CtClass result = cp.get(String.instancehelper_replace(desc, '/', '.'));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		22, 98, 98, 104, 101, 100, 206, 101, 110, 115,
		98, 101, 101, 108, 101, 108, 101, 108, 101, 108,
		101, 108, 101, 105, 101, 105, 101, 105, 101, 137,
		159, 6, 107, 159, 6, 99, 99, 137, 109, 136
	})]
	public static string toClassName(string descriptor)
	{
		int num = 0;
		int num2 = 0;
		int num3 = String.instancehelper_charAt(descriptor, 0);
		string text;
		while (true)
		{
			switch (num3)
			{
			case 91:
				goto IL_0011;
			case 76:
			{
				int fromIndex = num2;
				num2++;
				int num4 = String.instancehelper_indexOf(descriptor, 59, fromIndex);
				text = String.instancehelper_replace(String.instancehelper_substring(descriptor, num2, num4), '/', '.');
				num2 = num4;
				break;
			}
			case 86:
				text = "void";
				break;
			case 73:
				text = "int";
				break;
			case 66:
				text = "byte";
				break;
			case 74:
				text = "long";
				break;
			case 68:
				text = "double";
				break;
			case 70:
				text = "float";
				break;
			case 67:
				text = "char";
				break;
			case 83:
				text = "short";
				break;
			case 90:
				text = "boolean";
				break;
			default:
			{
				string message = new StringBuilder().append("bad descriptor: ").append(descriptor).toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new RuntimeException(message);
			}
			}
			break;
			IL_0011:
			num++;
			num2++;
			num3 = String.instancehelper_charAt(descriptor, num2);
		}
		if (num2 + 1 != String.instancehelper_length(descriptor))
		{
			string message2 = new StringBuilder().append("multiple descriptors?: ").append(descriptor).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException(message2);
		}
		if (num == 0)
		{
			return text;
		}
		StringBuilder stringBuilder = new StringBuilder(text);
		do
		{
			stringBuilder.append("[]");
			num += -1;
		}
		while (num > 0);
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(276)]
	public static string ofConstructor(CtClass[] paramTypes)
	{
		string result = ofMethod(CtClass.voidType, paramTypes);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 161, 47, 107, 98, 103, 103, 98, 130, 111, 100 })]
	public static CtClass[] getParameterTypes(string desc, ClassPool cp)
	{
		if (String.instancehelper_charAt(desc, 0) != '(')
		{
			return null;
		}
		int num = numOfParameters(desc);
		CtClass[] array = new CtClass[num];
		int num2 = 0;
		int num3 = 1;
		do
		{
			int num4 = num3;
			int num5 = num2;
			num2++;
			num3 = toCtClass(cp, desc, num4, array, num5);
		}
		while (num3 > 0);
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 161, 98, 105, 100, 98, 103, 109 })]
	public static CtClass getReturnType(string desc, ClassPool cp)
	{
		int num = String.instancehelper_indexOf(desc, 41);
		if (num < 0)
		{
			return null;
		}
		CtClass[] array = new CtClass[1];
		toCtClass(cp, desc, num + 1, array, 0);
		return array[0];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 126, 102, 103 })]
	public static string of(CtClass type)
	{
		StringBuilder stringBuilder = new StringBuilder();
		toDescriptor(stringBuilder, type);
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(651)]
	public static int dataSize(string desc)
	{
		int result = dataSize(desc, true);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 11, 107, 98 })]
	public static string insertParameter(CtClass type, string descriptor)
	{
		if (String.instancehelper_charAt(descriptor, 0) != '(')
		{
			return descriptor;
		}
		string result = new StringBuilder().append("(").append(of(type)).append(String.instancehelper_substring(descriptor, 1))
			.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 247, 105, 100, 98, 102, 111, 103, 110 })]
	public static string appendParameter(CtClass type, string descriptor)
	{
		int num = String.instancehelper_indexOf(descriptor, 41);
		if (num < 0)
		{
			return descriptor;
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.append(String.instancehelper_substring(descriptor, 0, num));
		toDescriptor(stringBuilder, type);
		stringBuilder.append(String.instancehelper_substring(descriptor, num));
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(664)]
	public static int paramSize(string desc)
	{
		return -dataSize(desc, false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 113, 98, 130, 104, 101, 130, 101, 142, 101,
		108, 100, 176, 132, 100, 133
	})]
	public static int numOfParameters(string desc)
	{
		int num = 0;
		int num2 = 1;
		while (true)
		{
			int num3 = String.instancehelper_charAt(desc, num2);
			if (num3 == 41)
			{
				break;
			}
			while (true)
			{
				switch (num3)
				{
				case 91:
					break;
				case 76:
					num2 = String.instancehelper_indexOf(desc, 59, num2) + 1;
					if (num2 <= 0)
					{
						Throwable.___003CsuppressFillInStackTrace_003E();
						throw new IndexOutOfBoundsException("bad descriptor");
					}
					goto end_IL_0013;
				default:
					num2++;
					goto end_IL_0013;
				}
				num2++;
				num3 = String.instancehelper_charAt(desc, num2);
				continue;
				end_IL_0013:
				break;
			}
			num++;
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(310)]
	public static string ofParameters(CtClass[] paramTypes)
	{
		string result = ofMethod(null, paramTypes);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(717)]
	public static string toString(string desc)
	{
		string result = PrettyPrinter.toString(desc);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 173, 102, 105, 99, 99, 102, 41, 198, 105,
		99, 135
	})]
	public static string ofMethod(CtClass returnType, CtClass[] paramTypes)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.append('(');
		if (paramTypes != null)
		{
			int num = paramTypes.Length;
			for (int i = 0; i < num; i++)
			{
				toDescriptor(stringBuilder, paramTypes[i]);
			}
		}
		stringBuilder.append(')');
		if (returnType != null)
		{
			toDescriptor(stringBuilder, returnType);
		}
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(454)]
	public static string getParamDescriptor(string decl)
	{
		string result = String.instancehelper_substring(decl, 0, String.instancehelper_indexOf(decl, 41) + 1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 11, 104, 105 })]
	public static string toJvmName(CtClass clazz)
	{
		if (clazz.isArray())
		{
			string result = of(clazz);
			_ = null;
			return result;
		}
		string result2 = toJvmName(clazz.getName());
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/lang/String;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)Ljava/lang/String;")]
	[LineNumberTable(new byte[]
	{
		160, 86, 99, 130, 102, 98, 130, 106, 100, 133,
		107, 101, 133, 101, 109, 111, 100, 111, 105, 105,
		105, 130, 133, 99, 98, 103, 100, 143
	})]
	public static string rename(string desc, Map map)
	{
		if (map == null)
		{
			return desc;
		}
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		int num2 = 0;
		int num3;
		while (true)
		{
			num3 = String.instancehelper_indexOf(desc, 76, num2);
			if (num3 < 0)
			{
				break;
			}
			int num4 = String.instancehelper_indexOf(desc, 59, num3);
			if (num4 < 0)
			{
				break;
			}
			num2 = num4 + 1;
			string key = String.instancehelper_substring(desc, num3 + 1, num4);
			string text = (string)map.get(key);
			if (text != null)
			{
				stringBuilder.append(String.instancehelper_substring(desc, num, num3));
				stringBuilder.append('L');
				stringBuilder.append(text);
				stringBuilder.append(';');
				num = num2;
			}
		}
		if (num == 0)
		{
			return desc;
		}
		num3 = String.instancehelper_length(desc);
		if (num < num3)
		{
			stringBuilder.append(String.instancehelper_substring(desc, num, num3));
		}
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		107, 106, 130, 102, 98, 130, 106, 100, 101, 111,
		113, 111, 105, 104, 105, 175, 108, 100, 130, 133,
		99, 98, 103, 100, 143
	})]
	public static string rename(string desc, string oldname, string newname)
	{
		if (String.instancehelper_indexOf(desc, oldname) < 0)
		{
			return desc;
		}
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		int num2 = 0;
		int num3;
		while (true)
		{
			num3 = String.instancehelper_indexOf(desc, 76, num2);
			if (num3 < 0)
			{
				break;
			}
			if (String.instancehelper_startsWith(desc, oldname, num3 + 1) && String.instancehelper_charAt(desc, num3 + String.instancehelper_length(oldname) + 1) == ';')
			{
				stringBuilder.append(String.instancehelper_substring(desc, num, num3));
				stringBuilder.append('L');
				stringBuilder.append(newname);
				stringBuilder.append(';');
				num = (num2 = num3 + String.instancehelper_length(oldname) + 2);
			}
			else
			{
				num2 = String.instancehelper_indexOf(desc, 59, num3) + 1;
				if (num2 < 1)
				{
					break;
				}
			}
		}
		if (num == 0)
		{
			return desc;
		}
		num3 = String.instancehelper_length(desc);
		if (num < num3)
		{
			stringBuilder.append(String.instancehelper_substring(desc, num, num3));
		}
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 65, 107, 130, 98, 104, 106, 130, 101, 226,
		58
	})]
	public static bool eqParamTypes(string desc1, string desc2)
	{
		if (String.instancehelper_charAt(desc1, 0) != '(')
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			int num2 = String.instancehelper_charAt(desc1, num);
			if (num2 != String.instancehelper_charAt(desc2, num))
			{
				return false;
			}
			if (num2 == 41)
			{
				break;
			}
			num++;
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		74, 109, 102, 109, 102, 109, 102, 109, 102, 109,
		102, 109, 102, 109, 102, 109, 102, 109, 134
	})]
	public static string of(string classname)
	{
		if (String.instancehelper_equals(classname, "void"))
		{
			return "V";
		}
		if (String.instancehelper_equals(classname, "int"))
		{
			return "I";
		}
		if (String.instancehelper_equals(classname, "byte"))
		{
			return "B";
		}
		if (String.instancehelper_equals(classname, "long"))
		{
			return "J";
		}
		if (String.instancehelper_equals(classname, "double"))
		{
			return "D";
		}
		if (String.instancehelper_equals(classname, "float"))
		{
			return "F";
		}
		if (String.instancehelper_equals(classname, "char"))
		{
			return "C";
		}
		if (String.instancehelper_equals(classname, "short"))
		{
			return "S";
		}
		if (String.instancehelper_equals(classname, "boolean"))
		{
			return "Z";
		}
		string result = new StringBuilder().append("L").append(toJvmName(classname)).append(";")
			.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 132, 104, 137, 247, 71, 229, 59, 97, 105,
		103, 123, 105, 130, 104, 103, 109, 130, 105, 118,
		137
	})]
	private static void toDescriptor(StringBuilder P_0, CtClass P_1)
	{
		if (P_1.isArray())
		{
			P_0.append('[');
			try
			{
				toDescriptor(P_0, P_1.getComponentType());
				return;
			}
			catch (NotFoundException)
			{
			}
			_ = null;
			P_0.append('L');
			string name = P_1.getName();
			P_0.append(toJvmName(String.instancehelper_substring(name, 0, String.instancehelper_length(name) - 2)));
			P_0.append(';');
		}
		else if (P_1.isPrimitive())
		{
			CtPrimitiveType ctPrimitiveType = (CtPrimitiveType)P_1;
			P_0.append(ctPrimitiveType.getDescriptor());
		}
		else
		{
			P_0.append('L');
			P_0.append(String.instancehelper_replace(P_1.getName(), '.', '/'));
			P_0.append(';');
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		161, 169, 98, 104, 101, 100, 175, 101, 111, 184,
		104, 100, 130, 100, 99, 102, 130, 168, 100, 104,
		104, 143, 168, 107
	})]
	private static int toCtClass(ClassPool P_0, string P_1, int P_2, CtClass[] P_3, int P_4)
	{
		int num = 0;
		int num2 = String.instancehelper_charAt(P_1, P_2);
		int result;
		string text;
		while (true)
		{
			switch (num2)
			{
			case 91:
				goto IL_000f;
			case 76:
			{
				P_2++;
				result = String.instancehelper_indexOf(P_1, 59, P_2);
				int beginIndex = P_2;
				int endIndex = result;
				result++;
				text = String.instancehelper_replace(String.instancehelper_substring(P_1, beginIndex, endIndex), '/', '.');
				break;
			}
			default:
			{
				CtClass ctClass = toPrimitiveClass((char)num2);
				if (ctClass == null)
				{
					return -1;
				}
				result = P_2 + 1;
				if (num == 0)
				{
					P_3[P_4] = ctClass;
					return result;
				}
				text = ctClass.getName();
				break;
			}
			}
			break;
			IL_000f:
			num++;
			P_2++;
			num2 = String.instancehelper_charAt(P_1, P_2);
		}
		if (num > 0)
		{
			StringBuilder stringBuilder = new StringBuilder(text);
			while (true)
			{
				int num3 = num;
				num += -1;
				if (num3 <= 0)
				{
					break;
				}
				stringBuilder.append("[]");
			}
			text = stringBuilder.toString();
		}
		P_3[P_4] = P_0.get(text);
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		158, 254, 66, 98, 159, 80, 102, 130, 102, 130,
		102, 130, 102, 130, 102, 130, 102, 130, 102, 130,
		102, 130, 198
	})]
	internal static CtClass toPrimitiveClass(char P_0)
	{
		CtClass result = null;
		switch (P_0)
		{
		case 'Z':
			result = CtClass.booleanType;
			break;
		case 'C':
			result = CtClass.charType;
			break;
		case 'B':
			result = CtClass.byteType;
			break;
		case 'S':
			result = CtClass.shortType;
			break;
		case 'I':
			result = CtClass.intType;
			break;
		case 'J':
			result = CtClass.longType;
			break;
		case 'F':
			result = CtClass.floatType;
			break;
		case 'D':
			result = CtClass.doubleType;
			break;
		case 'V':
			result = CtClass.voidType;
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		158, 231, 66, 98, 104, 104, 130, 104, 101, 106,
		165, 99, 101, 99, 174, 101, 108, 100, 176, 132,
		110, 135, 100, 165, 99, 106, 102, 101, 132
	})]
	private static int dataSize(string P_0, bool P_1)
	{
		int num = 0;
		int num2 = String.instancehelper_charAt(P_0, 0);
		if (num2 == 40)
		{
			int num3 = 1;
			while (true)
			{
				num2 = String.instancehelper_charAt(P_0, num3);
				if (num2 == 41)
				{
					break;
				}
				int num4 = 0;
				while (true)
				{
					switch (num2)
					{
					case 91:
						goto IL_003a;
					case 76:
						num3 = String.instancehelper_indexOf(P_0, 59, num3) + 1;
						if (num3 <= 0)
						{
							Throwable.___003CsuppressFillInStackTrace_003E();
							throw new IndexOutOfBoundsException("bad descriptor");
						}
						break;
					default:
						num3++;
						break;
					}
					break;
					IL_003a:
					num4 = 1;
					num3++;
					num2 = String.instancehelper_charAt(P_0, num3);
				}
				num = ((num4 != 0 || (num2 != 74 && num2 != 68)) ? (num + -1) : (num + -2));
			}
			num2 = String.instancehelper_charAt(P_0, num3 + 1);
		}
		if (P_1)
		{
			switch (num2)
			{
			case 68:
			case 74:
				num += 2;
				break;
			default:
				num++;
				break;
			case 86:
				break;
			}
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(31)]
	public Descriptor()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 209, 105, 100, 98, 102, 111, 105, 113, 105,
		110
	})]
	public static string appendParameter(string classname, string desc)
	{
		int num = String.instancehelper_indexOf(desc, 41);
		if (num < 0)
		{
			return desc;
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.append(String.instancehelper_substring(desc, 0, num));
		stringBuilder.append('L');
		stringBuilder.append(String.instancehelper_replace(classname, '.', '/'));
		stringBuilder.append(';');
		stringBuilder.append(String.instancehelper_substring(desc, num));
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 232, 107, 98, 127, 8, 49 })]
	public static string insertParameter(string classname, string desc)
	{
		if (String.instancehelper_charAt(desc, 0) != '(')
		{
			return desc;
		}
		string result = new StringBuilder().append("(L").append(String.instancehelper_replace(classname, '.', '/')).append(';')
			.append(String.instancehelper_substring(desc, 1))
			.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 25, 105, 100, 98, 102, 113, 105, 113, 105 })]
	public static string changeReturnType(string classname, string desc)
	{
		int num = String.instancehelper_indexOf(desc, 41);
		if (num < 0)
		{
			return desc;
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.append(String.instancehelper_substring(desc, 0, num + 1));
		stringBuilder.append('L');
		stringBuilder.append(String.instancehelper_replace(classname, '.', '/'));
		stringBuilder.append(';');
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 249, 98, 107, 134 })]
	public static int arrayDimension(string desc)
	{
		int i;
		for (i = 0; String.instancehelper_charAt(desc, i) == '['; i++)
		{
		}
		return i;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(636)]
	public static string toArrayComponent(string desc, int dim)
	{
		string result = String.instancehelper_substring(desc, dim);
		_ = null;
		return result;
	}
}
