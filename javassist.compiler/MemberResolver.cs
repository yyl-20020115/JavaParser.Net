using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.lang.@ref;
using java.util;
using javassist.bytecode;
using javassist.compiler.ast;

namespace javassist.compiler;

public class MemberResolver : Object, TokenId
{
	public class Method : Object
	{
		public CtClass declaring;

		public MethodInfo info;

		public int notmatch;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 22, 108 })]
		public virtual bool isStatic()
		{
			int accessFlags = info.getAccessFlags();
			return (((uint)accessFlags & 8u) != 0) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 12, 104, 103, 103, 103 })]
		public Method(CtClass c, MethodInfo i, int n)
		{
			declaring = c;
			info = i;
			notmatch = n;
		}
	}

	private ClassPool classPool;

	private const int YES = 0;

	private const int NO = -1;

	private const string INVALID = "<invalid>";

	[IKVM.Attributes.Signature("Ljava/util/Map<Ljavassist/ClassPool;Ljava/lang/ref/Reference<Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;>;>;")]
	private static Map invalidNamesMap;

	[IKVM.Attributes.Signature("Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;")]
	private Map invalidNames;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(551)]
	public static string jvmToJavaName(string classname)
	{
		string result = String.instancehelper_replace(classname, '/', '.');
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(547)]
	public static string javaToJvmName(string classname)
	{
		string result = String.instancehelper_replace(classname, '.', '/');
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 160, 219, 110, 37 })]
	public virtual CtClass lookupClass(Declarator decl)
	{
		CtClass result = lookupClass(decl.getType(), decl.getArrayDim(), decl.getClassName());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 214, 98, 102, 108, 104, 159, 115, 100, 133,
		101, 133, 101, 130, 104, 130, 100, 130, 100, 130,
		100, 130, 101, 130, 104, 130, 168, 133
	})]
	public static int getModifiers(ASTList mods)
	{
		int num = 0;
		while (mods != null)
		{
			Keyword keyword = (Keyword)mods.head();
			mods = mods.tail();
			switch (keyword.get())
			{
			case 335:
				num |= 8;
				break;
			case 315:
				num |= 0x10;
				break;
			case 338:
				num |= 0x20;
				break;
			case 300:
				num |= 0x400;
				break;
			case 332:
				num |= 1;
				break;
			case 331:
				num |= 4;
				break;
			case 330:
				num |= 2;
				break;
			case 345:
				num |= 0x40;
				break;
			case 342:
				num |= 0x80;
				break;
			case 347:
				num |= 0x800;
				break;
			}
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 189, 232, 161, 129, 231, 158, 128, 103 })]
	public MemberResolver(ClassPool cp)
	{
		invalidNames = null;
		classPool = cp;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 161, 154, 103, 99, 148, 99, 112 })]
	public static CtClass getSuperclass(CtClass c)
	{
		//Discarded unreachable code: IL_000f
		try
		{
			CtClass superclass = c.getSuperclass();
			if (superclass != null)
			{
				return superclass;
			}
		}
		catch (NotFoundException)
		{
			goto IL_001a;
		}
		goto IL_0021;
		IL_001a:
		_ = null;
		goto IL_0021;
		IL_0021:
		string s = new StringBuilder().append("cannot find the super class of ").append(c.getName()).toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CompileError(s);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(329)]
	public virtual CtClass lookupClassByJvmName(string jvmName)
	{
		CtClass result = lookupClass(jvmToJavaName(jvmName), notCheckInner: false);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(325)]
	public virtual CtClass lookupClassByName(ASTList name)
	{
		CtClass result = lookupClass(Declarator.astToClassName(name, '.'), notCheckInner: false);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		159, 41, 162, 103, 109, 104, 127, 6, 131, 155,
		129, 130, 213, 2, 97, 169, 111
	})]
	public virtual CtClass lookupClass(string name, bool notCheckInner)
	{
		//Discarded unreachable code: IL_0054
		Map map = getInvalidNames();
		string text = (string)map.get(name);
		if ((object)text == "<invalid>")
		{
			string s = new StringBuilder().append("no such class: ").append(name).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CompileError(s);
		}
		if (text != null)
		{
			try
			{
				return classPool.get(text);
			}
			catch (NotFoundException)
			{
			}
			_ = null;
		}
		_ = null;
		CtClass ctClass;
		try
		{
			ctClass = lookupClass0(name, notCheckInner);
		}
		catch (NotFoundException)
		{
			goto IL_0076;
		}
		goto IL_0085;
		IL_0085:
		map.put(name, ctClass.getName());
		return ctClass;
		IL_0076:
		_ = null;
		ctClass = searchImports(name);
		goto IL_0085;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 161, 167, 103, 103, 112, 6, 177, 99, 127, 1 })]
	public static CtClass getSuperInterface(CtClass c, string interfaceName)
	{
		try
		{
			CtClass[] interfaces = c.getInterfaces();
			for (int i = 0; i < (nint)interfaces.LongLength; i++)
			{
				if (String.instancehelper_equals(interfaces[i].getName(), interfaceName))
				{
					return interfaces[i];
				}
			}
		}
		catch (NotFoundException)
		{
			goto IL_0032;
		}
		goto IL_0038;
		IL_0032:
		_ = null;
		goto IL_0038;
		IL_0038:
		string s = new StringBuilder().append("cannot find the super interface ").append(interfaceName).append(" of ")
			.append(c.getName())
			.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CompileError(s);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		33, 130, 103, 111, 147, 100, 105, 99, 98, 194,
		151, 99, 98
	})]
	public virtual Method lookupMethod(CtClass clazz, CtClass currentClass, MethodInfo current, string methodName, int[] argTypes, int[] argDims, string[] argClassNames)
	{
		Method method = null;
		if (current != null && clazz == currentClass && String.instancehelper_equals(current.getName(), methodName))
		{
			int num = compareSignature(current.getDescriptor(), argTypes, argDims, argClassNames);
			if (num != -1)
			{
				Method method2 = new Method(clazz, current, num);
				if (num == 0)
				{
					return method2;
				}
				method = method2;
			}
		}
		Method method3 = lookupMethod(clazz, methodName, argTypes, argDims, argClassNames, method != null);
		if (method3 != null)
		{
			return method3;
		}
		return method;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		159, 4, 162, 159, 84, 134, 134, 134, 134, 134,
		134, 134, 134, 166, 134, 101
	})]
	public static int descToType(char c)
	{
		switch (c)
		{
		case 'Z':
			return 301;
		case 'C':
			return 306;
		case 'B':
			return 303;
		case 'S':
			return 334;
		case 'I':
			return 324;
		case 'J':
			return 326;
		case 'F':
			return 317;
		case 'D':
			return 312;
		case 'V':
			return 344;
		case 'L':
		case '[':
			return 307;
		default:
			fatal();
			return 344;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 160, 202, 137, 155, 97 })]
	public virtual CtField lookupField(string className, Symbol fieldName)
	{
		//Discarded unreachable code: IL_0017
		CtClass ctClass = lookupClass(className, notCheckInner: false);
		try
		{
			return ctClass.getField(fieldName.get());
		}
		catch (NotFoundException)
		{
		}
		_ = null;
		string s = new StringBuilder().append("no such field: ").append(fieldName.get()).toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CompileError(s);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(307)]
	public virtual CtField lookupFieldByJvmName(string jvmClassName, Symbol fieldName)
	{
		CtField result = lookupField(jvmToJavaName(jvmClassName), fieldName);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.NoFieldException" })]
	[LineNumberTable(new byte[]
	{
		160, 167, 103, 130, 249, 69, 226, 61, 129, 223,
		13, 150, 129, 109
	})]
	public virtual CtField lookupFieldByJvmName2(string jvmClassName, Symbol fieldSym, ASTree expr)
	{
		//Discarded unreachable code: IL_005a
		string text = fieldSym.get();
		_ = null;
		CtClass ctClass;
		try
		{
			ctClass = lookupClass(jvmToJavaName(jvmClassName), notCheckInner: true);
		}
		catch (CompileError)
		{
			goto IL_001f;
		}
		try
		{
			return ctClass.getField(text);
		}
		catch (NotFoundException)
		{
		}
		_ = null;
		jvmClassName = javaToJvmName(ctClass.getName());
		string name = new StringBuilder().append(jvmClassName).append("$").append(text)
			.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new NoFieldException(name, expr);
		IL_001f:
		_ = null;
		string name2 = new StringBuilder().append(jvmClassName).append("/").append(text)
			.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new NoFieldException(name2, expr);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 161, 138, 99, 98 })]
	public virtual string resolveClassName(ASTList name)
	{
		if (name == null)
		{
			return null;
		}
		string result = javaToJvmName(lookupClassByName(name).getName());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 161, 147, 99, 98 })]
	public virtual string resolveJvmClassName(string jvmName)
	{
		if (jvmName == null)
		{
			return null;
		}
		string result = javaToJvmName(lookupClassByJvmName(jvmName).getName());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		160, 229, 134, 104, 104, 100, 137, 162, 135, 105,
		157
	})]
	public virtual CtClass lookupClass(int type, int dim, string classname)
	{
		string text;
		if (type == 307)
		{
			CtClass ctClass = lookupClassByJvmName(classname);
			if (dim <= 0)
			{
				return ctClass;
			}
			text = ctClass.getName();
		}
		else
		{
			text = getTypeName(type);
		}
		while (true)
		{
			int num = dim;
			dim += -1;
			if (num <= 0)
			{
				break;
			}
			text = new StringBuilder().append(text).append("[]").toString();
		}
		CtClass result = lookupClass(text, notCheckInner: false);
		_ = null;
		return result;
	}

	public virtual ClassPool getClassPool()
	{
		return classPool;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		160, 251, 102, 159, 87, 102, 130, 102, 130, 102,
		130, 102, 130, 102, 130, 102, 130, 102, 130, 102,
		130, 102, 130, 165
	})]
	internal static string getTypeName(int P_0)
	{
		string result = "";
		switch (P_0)
		{
		case 301:
			result = "boolean";
			break;
		case 306:
			result = "char";
			break;
		case 303:
			result = "byte";
			break;
		case 334:
			result = "short";
			break;
		case 324:
			result = "int";
			break;
		case 326:
			result = "long";
			break;
		case 317:
			result = "float";
			break;
		case 312:
			result = "double";
			break;
		case 344:
			result = "void";
			break;
		default:
			fatal();
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		160, 84, 98, 98, 99, 105, 130, 103, 106, 109,
		102, 106, 101, 130, 99, 102, 102, 175, 107, 106,
		130, 105, 145, 104, 113, 103, 162, 108, 100, 103,
		130, 105, 107, 112, 130, 107, 110, 141, 113, 134,
		215, 2, 97, 196, 101, 130, 105, 102, 102, 159,
		5, 134, 226, 4, 235, 160, 64
	})]
	private int compareSignature(string P_0, int[] P_1, int[] P_2, string[] P_3)
	{
		//Discarded unreachable code: IL_0139
		int num = 0;
		int num2 = 1;
		int num3 = P_1.Length;
		if (num3 != Descriptor.numOfParameters(P_0))
		{
			return -1;
		}
		int num4 = String.instancehelper_length(P_0);
		for (int i = 0; num2 < num4; i++)
		{
			int index = num2;
			num2++;
			int num5 = String.instancehelper_charAt(P_0, index);
			if (num5 == 41)
			{
				return (i != num3) ? (-1) : num;
			}
			if (i >= num3)
			{
				return -1;
			}
			int num6 = 0;
			while (num5 == 91)
			{
				num6++;
				int index2 = num2;
				num2++;
				num5 = String.instancehelper_charAt(P_0, index2);
			}
			if (P_1[i] == 412)
			{
				if (num6 == 0 && num5 != 76)
				{
					return -1;
				}
				if (num5 == 76)
				{
					num2 = String.instancehelper_indexOf(P_0, 59, num2) + 1;
				}
				continue;
			}
			if (P_2[i] != num6)
			{
				if (num6 != 0 || num5 != 76 || !String.instancehelper_startsWith(P_0, "java/lang/Object;", num2))
				{
					return -1;
				}
				num2 = String.instancehelper_indexOf(P_0, 59, num2) + 1;
				num++;
				if (num2 <= 0)
				{
					return -1;
				}
				continue;
			}
			int num7;
			if (num5 == 76)
			{
				num7 = String.instancehelper_indexOf(P_0, 59, num2);
				if (num7 < 0 || P_1[i] != 307)
				{
					return -1;
				}
				string text = String.instancehelper_substring(P_0, num2, num7);
				if (!String.instancehelper_equals(text, P_3[i]))
				{
					CtClass ctClass = lookupClassByJvmName(P_3[i]);
					try
					{
						if (!ctClass.subtypeOf(lookupClassByJvmName(text)))
						{
							return -1;
						}
						num++;
					}
					catch (NotFoundException)
					{
						goto IL_0147;
					}
				}
				goto IL_0152;
			}
			num7 = descToType((char)num5);
			int num8 = P_1[i];
			if (num7 != num8)
			{
				if (num7 != 324 || (num8 != 334 && num8 != 303 && num8 != 306))
				{
					return -1;
				}
				num++;
			}
			continue;
			IL_0152:
			num2 = num7 + 1;
			continue;
			IL_0147:
			_ = null;
			num++;
			goto IL_0152;
		}
		return -1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		159, 115, 99, 98, 167, 102, 103, 127, 3, 113,
		106, 148, 101, 108, 100, 99, 109, 163, 165, 99,
		132, 99, 130, 104, 169, 100, 104, 100, 145, 100,
		216, 163, 104, 121, 177, 100, 230, 59, 232, 72,
		132, 104, 100, 145, 100, 219, 131
	})]
	private Method lookupMethod(CtClass P_0, string P_1, int[] P_2, int[] P_3, string[] P_4, bool P_5)
	{
		//Discarded unreachable code: IL_00df, IL_0163
		Method method = null;
		ClassFile classFile = P_0.getClassFile2();
		if (classFile != null)
		{
			List methods = classFile.getMethods();
			Iterator iterator = methods.iterator();
			while (iterator.hasNext())
			{
				MethodInfo methodInfo = (MethodInfo)iterator.next();
				if (!String.instancehelper_equals(methodInfo.getName(), P_1) || ((uint)methodInfo.getAccessFlags() & 0x40u) != 0)
				{
					continue;
				}
				int num = compareSignature(methodInfo.getDescriptor(), P_2, P_3, P_4);
				if (num != -1)
				{
					Method method2 = new Method(P_0, methodInfo, num);
					if (num == 0)
					{
						return method2;
					}
					if (method == null || method.notmatch > num)
					{
						method = method2;
					}
				}
			}
		}
		if (P_5)
		{
			method = null;
		}
		else if (method != null)
		{
			return method;
		}
		int modifiers = P_0.getModifiers();
		int num2 = (Modifier.isInterface(modifiers) ? 1 : 0);
		try
		{
			if (num2 == 0)
			{
				CtClass superclass = P_0.getSuperclass();
				if (superclass != null)
				{
					Method method3 = lookupMethod(superclass, P_1, P_2, P_3, P_4, P_5);
					if (method3 != null)
					{
						return method3;
					}
				}
			}
		}
		catch (NotFoundException)
		{
			goto IL_00ed;
		}
		goto IL_00f4;
		IL_00f4:
		try
		{
			CtClass[] interfaces = P_0.getInterfaces();
			CtClass[] array = interfaces;
			int num3 = array.Length;
			for (int i = 0; i < num3; i++)
			{
				CtClass ctClass = array[i];
				Method method4 = lookupMethod(ctClass, P_1, P_2, P_3, P_4, P_5);
				if (method4 != null)
				{
					return method4;
				}
			}
			if (num2 != 0)
			{
				CtClass superclass2 = P_0.getSuperclass();
				if (superclass2 != null)
				{
					Method method2 = lookupMethod(superclass2, P_1, P_2, P_3, P_4, P_5);
					if (method2 != null)
					{
						return method2;
					}
					return method;
				}
				return method;
			}
			return method;
		}
		catch (NotFoundException)
		{
		}
		_ = null;
		return method;
		IL_00ed:
		_ = null;
		goto IL_00f4;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(54)]
	private static void fatal()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CompileError("fatal");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("()Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;")]
	[LineNumberTable(new byte[]
	{
		161, 68, 103, 107, 108, 118, 99, 140, 104, 102,
		156, 143, 186
	})]
	private Map getInvalidNames()
	{
		object obj = invalidNames;
		if ((Map)obj == null)
		{
			lock (ClassLiteral<MemberResolver>.Value)
			{
				Reference reference = (Reference)invalidNamesMap.get(classPool);
				if (reference != null)
				{
					obj = (Map)reference.get();
				}
				if ((Map)obj == null)
				{
					obj = new Hashtable();
					invalidNamesMap.put(classPool, new WeakReference((Hashtable)obj));
				}
			}
			object obj2 = obj;
			invalidNames = ((obj2 == null) ? null : ((obj2 as Map) ?? throw new java.lang.IncompatibleClassChangeError()));
		}
		object obj3 = obj;
		return (obj3 == null) ? null : ((obj3 as Map) ?? throw new java.lang.IncompatibleClassChangeError());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		159,
		21,
		98,
		162,
		byte.MaxValue,
		0,
		73,
		226,
		57,
		97,
		106,
		104,
		103,
		104,
		107,
		137,
		102
	})]
	private CtClass lookupClass0(string P_0, bool P_1)
	{
		CtClass ctClass = null;
		do
		{
			NotFoundException ex;
			try
			{
				ctClass = classPool.get(P_0);
			}
			catch (NotFoundException x)
			{
				ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_0020;
			}
			continue;
			IL_0020:
			NotFoundException ex2 = ex;
			int num = String.instancehelper_lastIndexOf(P_0, 46);
			if (P_1 || num < 0)
			{
				throw Throwable.___003Cunmap_003E(ex2);
			}
			StringBuilder stringBuilder = new StringBuilder(P_0);
			stringBuilder.setCharAt(num, '$');
			P_0 = stringBuilder.toString();
		}
		while (ctClass == null);
		return ctClass;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		161, 90, 110, 108, 107, 108, 159, 17, 155, 129,
		127, 3, 159, 3, 131, 165, 114
	})]
	private CtClass searchImports(string P_0)
	{
		//Discarded unreachable code: IL_006f, IL_00af
		if (String.instancehelper_indexOf(P_0, 46) < 0)
		{
			Iterator importedPackages = classPool.getImportedPackages();
			while (importedPackages.hasNext())
			{
				string text = (string)importedPackages.next();
				string classname = new StringBuilder().append(String.instancehelper_replaceAll(text, "\\.$", "")).append(".").append(P_0)
					.toString();
				try
				{
					return classPool.get(classname);
				}
				catch (NotFoundException)
				{
				}
				_ = null;
				try
				{
					if (String.instancehelper_endsWith(text, new StringBuilder().append(".").append(P_0).toString()))
					{
						return classPool.get(text);
					}
				}
				catch (NotFoundException)
				{
					goto IL_00bd;
				}
				continue;
				IL_00bd:
				_ = null;
			}
		}
		getInvalidNames().put(P_0, "<invalid>");
		string s = new StringBuilder().append("no such class: ").append(P_0).toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CompileError(s);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(435)]
	public static int getInvalidMapSize()
	{
		int result = invalidNamesMap.size();
		_ = null;
		return result;
	}

	[LineNumberTable(430)]
	static MemberResolver()
	{
		invalidNamesMap = new WeakHashMap();
	}
}
