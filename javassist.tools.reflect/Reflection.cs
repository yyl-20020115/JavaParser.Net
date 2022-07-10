using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;
using javassist.bytecode;

namespace javassist.tools.reflect;

public class Reflection : Object, Translator
{
	internal const string classobjectField = "_classobject";

	internal const string classobjectAccessor = "_getClass";

	internal const string metaobjectField = "_metaobject";

	internal const string metaobjectGetter = "_getMetaobject";

	internal const string metaobjectSetter = "_setMetaobject";

	internal const string readPrefix = "_r_";

	internal const string writePrefix = "_w_";

	internal const string metaobjectClassName = "javassist.tools.reflect.Metaobject";

	internal const string classMetaobjectClassName = "javassist.tools.reflect.ClassMetaobject";

	protected internal CtMethod trapMethod;

	protected internal CtMethod trapStaticMethod;

	protected internal CtMethod trapRead;

	protected internal CtMethod trapWrite;

	protected internal CtClass[] readParam;

	protected internal ClassPool classPool;

	protected internal CodeConverter converter;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 58, 104, 103, 107 })]
	public Reflection()
	{
		classPool = null;
		converter = new CodeConverter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		68, 103, 166, 113, 108, 113, 113, 113, 113, 116,
		251, 70, 226, 60, 97, 112, 97, 144
	})]
	public virtual void start(ClassPool pool)
	{
		classPool = pool;
		try
		{
			try
			{
				CtClass ctClass = classPool.get("javassist.tools.reflect.Sample");
				rebuildClassFile(ctClass.getClassFile());
				trapMethod = ctClass.getDeclaredMethod("trap");
				trapStaticMethod = ctClass.getDeclaredMethod("trapStatic");
				trapRead = ctClass.getDeclaredMethod("trapRead");
				trapWrite = ctClass.getDeclaredMethod("trapWrite");
				readParam = new CtClass[1] { classPool.get("java.lang.Object") };
				return;
			}
			catch (NotFoundException)
			{
			}
		}
		catch (BadBytecode)
		{
			goto IL_009a;
		}
		_ = null;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException("javassist.tools.reflect.Sample is not found or broken.");
		IL_009a:
		_ = null;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException("javassist.tools.reflect.Sample is not found or broken.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException", "javassist.tools.reflect.CannotReflectException", "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		160, 106, 104, 112, 154, 120, 144, 154, 120, 144,
		154, 103
	})]
	public virtual bool makeReflective(CtClass clazz, CtClass metaobject, CtClass metaclass)
	{
		if (clazz.isInterface())
		{
			string msg = new StringBuilder().append("Cannot reflect an interface: ").append(clazz.getName()).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CannotReflectException(msg);
		}
		if (clazz.subclassOf(classPool.get("javassist.tools.reflect.ClassMetaobject")))
		{
			string msg2 = new StringBuilder().append("Cannot reflect a subclass of ClassMetaobject: ").append(clazz.getName()).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CannotReflectException(msg2);
		}
		if (clazz.subclassOf(classPool.get("javassist.tools.reflect.Metaobject")))
		{
			string msg3 = new StringBuilder().append("Cannot reflect a subclass of Metaobject: ").append(clazz.getName()).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CannotReflectException(msg3);
		}
		registerReflectiveClass(clazz);
		bool result = modifyClassfile(clazz, metaobject, metaclass);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException", "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 96, 104, 110 })]
	public virtual void onLoad(ClassPool pool, string classname)
	{
		CtClass ctClass = pool.get(classname);
		ctClass.instrument(converter);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException", "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 117, 116, 108, 5 })]
	public virtual bool makeReflective(string classname, string metaobject, string metaclass)
	{
		bool result = makeReflective(classPool.get(classname), classPool.get(metaobject), classPool.get(metaclass));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 161, 33, 105, 129, 127, 1, 110 })]
	public virtual void rebuildClassFile(ClassFile cf)
	{
		if (ClassFile.___003C_003EMAJOR_VERSION >= 50)
		{
			Iterator iterator = cf.getMethods().iterator();
			while (iterator.hasNext())
			{
				MethodInfo methodInfo = (MethodInfo)iterator.next();
				methodInfo.rebuildStackMap(classPool);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160,
		129,
		103,
		106,
		100,
		103,
		107,
		104,
		127,
		9,
		byte.MaxValue,
		9,
		58,
		233,
		73
	})]
	private void registerReflectiveClass(CtClass P_0)
	{
		CtField[] declaredFields = P_0.getDeclaredFields();
		for (int i = 0; i < (nint)declaredFields.LongLength; i++)
		{
			CtField ctField = declaredFields[i];
			int modifiers = ctField.getModifiers();
			if (((uint)modifiers & (true ? 1u : 0u)) != 0 && (modifiers & 0x10) == 0)
			{
				string name = ctField.getName();
				converter.replaceFieldRead(ctField, P_0, new StringBuilder().append("_r_").append(name).toString());
				converter.replaceFieldWrite(ctField, P_0, new StringBuilder().append("_w_").append(name).toString());
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException", "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		160, 145, 109, 98, 145, 113, 110, 99, 135, 104,
		167, 99, 156, 103, 141, 113, 177, 156, 104, 108,
		38, 170, 113
	})]
	private bool modifyClassfile(CtClass P_0, CtClass P_1, CtClass P_2)
	{
		if (P_0.getAttribute("Reflective") != null)
		{
			return false;
		}
		P_0.setAttribute("Reflective", new byte[0]);
		CtClass ctClass = classPool.get("javassist.tools.reflect.Metalevel");
		int num = ((!P_0.subtypeOf(ctClass)) ? 1 : 0);
		if (num != 0)
		{
			P_0.addInterface(ctClass);
		}
		processMethods(P_0, (byte)num != 0);
		processFields(P_0);
		CtField ctField;
		if (num != 0)
		{
			ctField = new CtField(classPool.get("javassist.tools.reflect.Metaobject"), "_metaobject", P_0);
			ctField.setModifiers(4);
			P_0.addField(ctField, CtField.Initializer.byNewWithParams(P_1));
			P_0.addMethod(CtNewMethod.getter("_getMetaobject", ctField));
			P_0.addMethod(CtNewMethod.setter("_setMetaobject", ctField));
		}
		ctField = new CtField(classPool.get("javassist.tools.reflect.ClassMetaobject"), "_classobject", P_0);
		ctField.setModifiers(10);
		P_0.addField(ctField, CtField.Initializer.byNew(P_2, new string[1] { P_0.getName() }));
		P_0.addMethod(CtNewMethod.getter("_getClass", ctField));
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException", "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		159, 69, 162, 103, 103, 100, 104, 114, 236, 60,
		230, 70
	})]
	private void processMethods(CtClass P_0, bool P_1)
	{
		CtMethod[] methods = P_0.getMethods();
		for (int i = 0; i < (nint)methods.LongLength; i++)
		{
			CtMethod ctMethod = methods[i];
			int modifiers = ctMethod.getModifiers();
			if (Modifier.isPublic(modifiers) && !Modifier.isAbstract(modifiers))
			{
				processMethods0(modifiers, P_0, ctMethod, i, P_1);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException", "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		161, 4, 103, 106, 100, 103, 113, 100, 104, 104,
		191, 13, 6, 199, 104, 104, 104, 116, 102, 191,
		12, 230, 61, 199, 104, 232, 42, 233, 89
	})]
	private void processFields(CtClass P_0)
	{
		CtField[] declaredFields = P_0.getDeclaredFields();
		for (int i = 0; i < (nint)declaredFields.LongLength; i++)
		{
			CtField ctField = declaredFields[i];
			int modifiers = ctField.getModifiers();
			if (((uint)modifiers & (true ? 1u : 0u)) != 0 && (modifiers & 0x10) == 0)
			{
				modifiers |= 8;
				string name = ctField.getName();
				CtClass type = ctField.getType();
				CtMethod ctMethod = CtNewMethod.wrapped(type, new StringBuilder().append("_r_").append(name).toString(), readParam, null, trapRead, CtMethod.ConstParameter.@string(name), P_0);
				ctMethod.setModifiers(modifiers);
				P_0.addMethod(ctMethod);
				ctMethod = CtNewMethod.wrapped(parameterTypes: new CtClass[2]
				{
					classPool.get("java.lang.Object"),
					type
				}, returnType: CtClass.voidType, mname: new StringBuilder().append("_w_").append(name).toString(), exceptionTypes: null, body: trapWrite, constParam: CtMethod.ConstParameter.@string(name), declaring: P_0);
				ctMethod.setModifiers(modifiers);
				P_0.addMethod(ctMethod);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException", "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		159, 65, 99, 135, 105, 161, 105, 104, 129, 98,
		104, 102, 201, 104, 129, 105, 111, 103, 167, 191,
		18, 104, 137, 135, 97, 103, 110, 6, 199, 104,
		106
	})]
	private void processMethods0(int P_0, CtClass P_1, CtMethod P_2, int P_3, bool P_4)
	{
		string name = P_2.getName();
		if (isExcluded(name))
		{
			return;
		}
		CtMethod ctMethod;
		if (P_2.getDeclaringClass() == P_1)
		{
			if (Modifier.isNative(P_0))
			{
				return;
			}
			ctMethod = P_2;
			if (Modifier.isFinal(P_0))
			{
				P_0 &= -17;
				ctMethod.setModifiers(P_0);
			}
		}
		else
		{
			if (Modifier.isFinal(P_0))
			{
				return;
			}
			P_0 &= -257;
			ctMethod = CtNewMethod.delegator(findOriginal(P_2, P_4), P_1);
			ctMethod.setModifiers(P_0);
			P_1.addMethod(ctMethod);
		}
		ctMethod.setName(new StringBuilder().append("_m_").append(P_3).append("_")
			.append(name)
			.toString());
		CtMethod ctMethod2 = CtNewMethod.wrapped(body: (!Modifier.isStatic(P_0)) ? trapMethod : trapStaticMethod, returnType: P_2.getReturnType(), mname: name, parameterTypes: P_2.getParameterTypes(), exceptionTypes: P_2.getExceptionTypes(), constParam: CtMethod.ConstParameter.integer(P_3), declaring: P_1);
		ctMethod2.setModifiers(P_0);
		P_1.addMethod(ctMethod2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 47, 115, 109, 109, 109, 109, 235, 59 })]
	private bool isExcluded(string P_0)
	{
		return (String.instancehelper_startsWith(P_0, "_m_") || String.instancehelper_equals(P_0, "_getClass") || String.instancehelper_equals(P_0, "_setMetaobject") || String.instancehelper_equals(P_0, "_getMetaobject") || String.instancehelper_startsWith(P_0, "_r_") || String.instancehelper_startsWith(P_0, "_w_")) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		159, 54, 162, 99, 130, 103, 108, 103, 106, 113,
		106, 114, 228, 59, 230, 72
	})]
	private CtMethod findOriginal(CtMethod P_0, bool P_1)
	{
		if (P_1)
		{
			return P_0;
		}
		string name = P_0.getName();
		CtMethod[] declaredMethods = P_0.getDeclaringClass().getDeclaredMethods();
		for (int i = 0; i < (nint)declaredMethods.LongLength; i++)
		{
			string name2 = declaredMethods[i].getName();
			if (String.instancehelper_endsWith(name2, name) && String.instancehelper_startsWith(name2, "_m_") && String.instancehelper_equals(declaredMethods[i].getSignature(), P_0.getSignature()))
			{
				return declaredMethods[i];
			}
		}
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException", "javassist.NotFoundException" })]
	[IKVM.Attributes.Signature("(Ljava/lang/Class<*>;Ljava/lang/Class<*>;Ljava/lang/Class<*>;)Z")]
	[LineNumberTable(new byte[] { 160, 79, 110, 37 })]
	public virtual bool makeReflective(Class clazz, Class metaobject, Class metaclass)
	{
		bool result = makeReflective(clazz.getName(), metaobject.getName(), metaclass.getName());
		_ = null;
		return result;
	}
}
