using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.lang.invoke;
using java.net;
using java.security;
using java.util;
using javassist.bytecode;
using javassist.compiler;
using javassist.expr;

namespace javassist;

public abstract class CtClass : java.lang.Object
{
	[Serializable]
	[SpecialName]
	[IKVM.Attributes.EnclosingMethod(null, "getRefClasses", "()Ljava.util.Collection;")]
	internal class _1 : ClassMap
	{
		private const long serialVersionUID = 1L;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal CtClass this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(530)]
		internal _1(CtClass P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(535)]
		public override string put(string P_0, string P_1)
		{
			string result = put0(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 169, 108, 105 })]
		public override string get(object P_0)
		{
			string text = ClassMap.toJavaName((string)P_0);
			put0(text, text);
			return null;
		}

		public override void fix(string P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(530)]
		public override object put(object P_0, object P_1)
		{
			string result = put((string)P_0, (string)P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(530)]
		public new virtual object get(object P_0)
		{
			string result = this.get(P_0);
			_ = null;
			return result;
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected _1(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	internal class DelayedFileOutputStream : OutputStream
	{
		private FileOutputStream file;

		private string filename;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 165, 220, 104, 103, 103 })]
		internal DelayedFileOutputStream(string P_0)
		{
			file = null;
			filename = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 165, 226, 104, 118 })]
		private void init()
		{
			if (file == null)
			{
				FileOutputStream.___003Cclinit_003E();
				file = new FileOutputStream(filename);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 165, 232, 102, 110 })]
		public override void write(int P_0)
		{
			init();
			file.write(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 165, 238, 102, 110 })]
		public override void write(byte[] P_0)
		{
			init();
			file.write(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 165, 244, 102, 144 })]
		public override void write(byte[] P_0, int P_1, int P_2)
		{
			init();
			file.write(P_0, P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 165, 251, 102, 109 })]
		public override void flush()
		{
			init();
			file.flush();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 166, 1, 102, 109 })]
		public override void close()
		{
			init();
			file.close();
		}
	}

	protected internal string qualifiedName;

	public static string debugDump;

	public const string version = "3.29.0-GA";

	internal const string javaLangObject = "java.lang.Object";

	public static CtClass booleanType;

	public static CtClass charType;

	public static CtClass byteType;

	public static CtClass shortType;

	public static CtClass intType;

	public static CtClass longType;

	public static CtClass floatType;

	public static CtClass doubleType;

	public static CtClass voidType;

	internal static CtClass[] primitiveTypes;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	public virtual string getName()
	{
		return qualifiedName;
	}

	public virtual bool isAnnotation()
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 10, 103, 105, 100, 98 })]
	public string getPackageName()
	{
		string @this = qualifiedName;
		int num = java.lang.String.instancehelper_lastIndexOf(@this, 46);
		if (num < 0)
		{
			return null;
		}
		string result = java.lang.String.instancehelper_substring(@this, 0, num);
		_ = null;
		return result;
	}

	public virtual bool hasAnnotation(string annotationTypeName)
	{
		return false;
	}

	[LineNumberTable(1003)]
	public virtual CtMethod[] getDeclaredMethods()
	{
		return new CtMethod[0];
	}

	[Throws(new string[] { "java.lang.ClassNotFoundException" })]
	[IKVM.Attributes.Signature("(Ljava/lang/Class<*>;)Ljava/lang/Object;")]
	public virtual object getAnnotation(Class clz)
	{
		return null;
	}

	public virtual bool isInterface()
	{
		return false;
	}

	public virtual bool isPrimitive()
	{
		return false;
	}

	public virtual bool isEnum()
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 89, 113, 105, 114, 105, 103, 105 })]
	public override string toString()
	{
		StringBuilder stringBuilder = new StringBuilder(java.lang.Object.instancehelper_getClass(this).getName());
		stringBuilder.append('@');
		stringBuilder.append(Integer.toHexString(java.lang.Object.instancehelper_hashCode(this)));
		stringBuilder.append('[');
		extendToString(stringBuilder);
		stringBuilder.append(']');
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[LineNumberTable(875)]
	public virtual CtField[] getDeclaredFields()
	{
		return new CtField[0];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 118, 102 })]
	public virtual ClassFile getClassFile()
	{
		checkModify();
		ClassFile classFile = getClassFile2();
		_ = null;
		return classFile;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160,
		byte.MaxValue,
		103,
		105,
		100,
		98
	})]
	public string getSimpleName()
	{
		string text = qualifiedName;
		int num = java.lang.String.instancehelper_lastIndexOf(text, 46);
		if (num < 0)
		{
			return text;
		}
		string result = java.lang.String.instancehelper_substring(text, num + 1);
		_ = null;
		return result;
	}

	public virtual int getModifiers()
	{
		return 0;
	}

	[LineNumberTable(839)]
	public virtual CtField[] getFields()
	{
		return new CtField[0];
	}

	public virtual bool isArray()
	{
		return false;
	}

	[Throws(new string[] { "javassist.NotFoundException" })]
	public virtual CtClass getComponentType()
	{
		return null;
	}

	public virtual string getGenericSignature()
	{
		return null;
	}

	[LineNumberTable(915)]
	public virtual CtConstructor[] getConstructors()
	{
		return new CtConstructor[0];
	}

	[Throws(new string[] { "javassist.NotFoundException" })]
	public virtual CtClass getDeclaringClass()
	{
		return null;
	}

	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(681)]
	public virtual CtClass[] getNestedClasses()
	{
		return new CtClass[0];
	}

	internal virtual void compress()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 23, 102, 99, 103 })]
	public virtual void setName(string name)
	{
		checkModify();
		if (name != null)
		{
			qualifiedName = name;
		}
	}

	internal virtual void incGetCounter()
	{
	}

	public virtual bool isFrozen()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(1046)]
	public virtual CtMethod getDeclaredMethod(string name)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new NotFoundException(name);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.RuntimeException" })]
	[LineNumberTable(new byte[] { 160, 182, 104, 191, 11 })]
	internal virtual void checkModify()
	{
		if (isFrozen())
		{
			string message = new StringBuilder().append(getName()).append(" class is frozen").toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException(message);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 70, 104 })]
	public virtual void setModifiers(int mod)
	{
		checkModify();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 165, 122, 102, 135, 171, 102, 35, 98, 130 })]
	public virtual byte[] toBytecode()
	{
		ByteArrayOutputStream byteArrayOutputStream = new ByteArrayOutputStream();
		DataOutputStream dataOutputStream = new DataOutputStream(byteArrayOutputStream);
		try
		{
			toBytecode(dataOutputStream);
		}
		finally
		{
			dataOutputStream.close();
		}
		return byteArrayOutputStream.toByteArray();
	}

	public virtual ClassPool getClassPool()
	{
		return null;
	}

	public virtual ClassFile getClassFile2()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 103, 109 })]
	protected internal virtual void extendToString(StringBuilder buffer)
	{
		buffer.append(getName());
	}

	[Throws(new string[] { "javassist.NotFoundException" })]
	public virtual CtBehavior getEnclosingBehavior()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(861)]
	public virtual CtField getField(string name, string desc)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new NotFoundException(name);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(931)]
	public virtual CtConstructor getConstructor(string desc)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new NotFoundException("no such constructor");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 164, 37, 104 })]
	public virtual void addField(CtField f, CtField.Initializer init)
	{
		checkModify();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException", "java.io.IOException" })]
	[LineNumberTable(1668)]
	public virtual void toBytecode(DataOutputStream @out)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException("not a class");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException", "java.io.IOException" })]
	[LineNumberTable(new byte[] { 165, 160, 136, 171, 102, 35, 98, 98 })]
	public virtual void writeFile(string directoryName)
	{
		DataOutputStream dataOutputStream = makeFileOutput(directoryName);
		try
		{
			toBytecode(dataOutputStream);
		}
		finally
		{
			dataOutputStream.close();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 165, 170, 103, 125, 122, 108, 100, 105, 109, 172 })]
	protected internal virtual DataOutputStream makeFileOutput(string directoryName)
	{
		string name = getName();
		string text = new StringBuilder().append(directoryName).append(File.separatorChar).append(java.lang.String.instancehelper_replace(name, '.', File.separatorChar))
			.append(".class")
			.toString();
		int num = java.lang.String.instancehelper_lastIndexOf(text, File.separatorChar);
		if (num > 0)
		{
			string text2 = java.lang.String.instancehelper_substring(text, 0, num);
			if (!java.lang.String.instancehelper_equals(text2, "."))
			{
				new File(text2).mkdirs();
			}
		}
		DataOutputStream result = new DataOutputStream(new BufferedOutputStream(new DelayedFileOutputStream(text)));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 165, 206, 104, 103, 102, 223, 0, 2, 97, 140 })]
	public virtual void debugWriteFile(string directoryName)
	{
		java.lang.Exception ex2;
		try
		{
			int stop = (stopPruning(stop: true) ? 1 : 0);
			writeFile(directoryName);
			defrost();
			stopPruning((byte)stop != 0);
			return;
		}
		catch (System.Exception x)
		{
			java.lang.Exception ex = ByteCodeHelper.MapException<java.lang.Exception>(x, ByteCodeHelper.MapFlags.None);
			if (ex == null)
			{
				throw;
			}
			ex2 = ex;
		}
		java.lang.Exception cause = ex2;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(cause);
	}

	public virtual bool stopPruning(bool stop)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(318)]
	public virtual void defrost()
	{
		string message = new StringBuilder().append("cannot defrost ").append(getName()).toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(message);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 32, 111, 145 })]
	public static void main(string[] args)
	{
		java.lang.System.@out.println("Javassist version 3.29.0-GA");
		java.lang.System.@out.println("Copyright (C) 1999-2022 Shigeru Chiba. All Rights Reserved.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 80, 104, 103 })]
	protected internal CtClass(string name)
	{
		qualifiedName = name;
	}

	public virtual AccessorMaker getAccessorMaker()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(267)]
	public virtual URL getURL()
	{
		string name = getName();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new NotFoundException(name);
	}

	public virtual bool isModified()
	{
		return false;
	}

	public virtual void freeze()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(340)]
	public virtual bool isKotlin()
	{
		bool result = hasAnnotation("kotlin.Metadata");
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(357)]
	public virtual bool subtypeOf(CtClass clazz)
	{
		return (this == clazz || java.lang.String.instancehelper_equals(getName(), clazz.getName())) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(484)]
	public virtual void setGenericSignature(string sig)
	{
		checkModify();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 124, 104 })]
	public virtual void replaceClassName(string oldName, string newName)
	{
		checkModify();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 145, 104 })]
	public virtual void replaceClassName(ClassMap map)
	{
		checkModify();
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("()Ljava/util/Collection<Ljava/lang/String;>;")]
	[LineNumberTable(new byte[] { 161, 158, 103, 99, 231, 81, 103, 137 })]
	public virtual Collection getRefClasses()
	{
		ClassFile classFile = getClassFile2();
		if (classFile != null)
		{
			_1  = new _1(this);
			classFile.getRefClasses();
			Collection result = .values();
			_ = null;
			return result;
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/lang/Class<*>;)Z")]
	[LineNumberTable(602)]
	public virtual bool hasAnnotation(Class annotationType)
	{
		bool result = hasAnnotation(annotationType.getName());
		_ = null;
		return result;
	}

	[Throws(new string[] { "java.lang.ClassNotFoundException" })]
	[LineNumberTable(643)]
	public virtual object[] getAnnotations()
	{
		return new object[0];
	}

	[LineNumberTable(658)]
	public virtual object[] getAvailableAnnotations()
	{
		return new object[0];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(670)]
	public virtual CtClass[] getDeclaredClasses()
	{
		CtClass[] nestedClasses = getNestedClasses();
		_ = null;
		return nestedClasses;
	}

	public virtual bool subclassOf(CtClass superclass)
	{
		return false;
	}

	[Throws(new string[] { "javassist.NotFoundException" })]
	public virtual CtClass getSuperclass()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 162, 115, 104 })]
	public virtual void setSuperclass(CtClass clazz)
	{
		checkModify();
	}

	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(750)]
	public virtual CtClass[] getInterfaces()
	{
		return new CtClass[0];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 137, 104 })]
	public virtual void setInterfaces(CtClass[] list)
	{
		checkModify();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 146, 104 })]
	public virtual void addInterface(CtClass anInterface)
	{
		checkModify();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[Obsolete]
	[LineNumberTable(new byte[] { 162, 171, 103, 99, 98, 104, 135 })]
	[java.lang.Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public CtMethod getEnclosingMethod()
	{
		CtBehavior enclosingBehavior = getEnclosingBehavior();
		if (enclosingBehavior == null)
		{
			return null;
		}
		if (enclosingBehavior is CtMethod)
		{
			return (CtMethod)enclosingBehavior;
		}
		string msg = new StringBuilder().append(enclosingBehavior.getLongName()).append(" is enclosing ").append(getName())
			.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new NotFoundException(msg);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(830)]
	public virtual CtClass makeNestedClass(string name, bool isStatic)
	{
		string message = new StringBuilder().append(getName()).append(" is not a class").toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(message);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(846)]
	public virtual CtField getField(string name)
	{
		CtField field = getField(name, null);
		_ = null;
		return field;
	}

	internal virtual CtField getField2(string P_0, string P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(884)]
	public virtual CtField getDeclaredField(string name)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new NotFoundException(name);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(900)]
	public virtual CtField getDeclaredField(string name, string desc)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new NotFoundException(name);
	}

	[LineNumberTable(907)]
	public virtual CtBehavior[] getDeclaredBehaviors()
	{
		return new CtBehavior[0];
	}

	[LineNumberTable(940)]
	public virtual CtConstructor[] getDeclaredConstructors()
	{
		return new CtConstructor[0];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 163, 69, 103 })]
	public virtual CtConstructor getDeclaredConstructor(CtClass[] @params)
	{
		string desc = Descriptor.ofConstructor(@params);
		CtConstructor constructor = getConstructor(desc);
		_ = null;
		return constructor;
	}

	public virtual CtConstructor getClassInitializer()
	{
		return null;
	}

	[LineNumberTable(975)]
	public virtual CtMethod[] getMethods()
	{
		return new CtMethod[0];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(993)]
	public virtual CtMethod getMethod(string name, string desc)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new NotFoundException(name);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(1019)]
	public virtual CtMethod getDeclaredMethod(string name, CtClass[] @params)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new NotFoundException(name);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(1033)]
	public virtual CtMethod[] getDeclaredMethods(string name)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new NotFoundException(name);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(1059)]
	public virtual CtConstructor makeClassInitializer()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException("not a class");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 163, 189, 104 })]
	public virtual void addConstructor(CtConstructor c)
	{
		checkModify();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 163, 199, 104 })]
	public virtual void removeConstructor(CtConstructor c)
	{
		checkModify();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 163, 206, 104 })]
	public virtual void addMethod(CtMethod m)
	{
		checkModify();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 163, 216, 104 })]
	public virtual void removeMethod(CtMethod m)
	{
		checkModify();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 163, 229, 111 })]
	public virtual void addField(CtField f)
	{
		addField(f, (CtField.Initializer)null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 164, 9, 104 })]
	public virtual void addField(CtField f, string init)
	{
		checkModify();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 164, 47, 104 })]
	public virtual void removeField(CtField f)
	{
		checkModify();
	}

	public virtual byte[] getAttribute(string name)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 94, 104 })]
	public virtual void setAttribute(string name, byte[] data)
	{
		checkModify();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 164, 108, 104 })]
	public virtual void instrument(CodeConverter converter)
	{
		checkModify();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 164, 122, 104 })]
	public virtual void instrument(ExprEditor editor)
	{
		checkModify();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[IKVM.Attributes.Signature("()Ljava/lang/Class<*>;")]
	[LineNumberTable(1298)]
	public virtual Class toClass()
	{
		Class result = getClassPool().toClass(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[IKVM.Attributes.Signature("(Ljava/lang/Class<*>;)Ljava/lang/Class<*>;")]
	[LineNumberTable(1325)]
	public virtual Class toClass(Class neighbor)
	{
		Class result = getClassPool().toClass(this, neighbor);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[IKVM.Attributes.Signature("(Ljava/lang/invoke/MethodHandles$Lookup;)Ljava/lang/Class<*>;")]
	[LineNumberTable(1351)]
	public virtual Class toClass(MethodHandles.Lookup lookup)
	{
		Class result = getClassPool().toClass(this, lookup);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[IKVM.Attributes.Signature("(Ljava/lang/ClassLoader;Ljava/security/ProtectionDomain;)Ljava/lang/Class<*>;")]
	[LineNumberTable(new byte[] { 164, 250, 103, 99, 136 })]
	public virtual Class toClass(ClassLoader loader, ProtectionDomain domain)
	{
		ClassPool classPool = getClassPool();
		if (loader == null)
		{
			loader = classPool.getClassLoader();
		}
		Class result = classPool.toClass(this, null, loader, domain);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[Obsolete]
	[IKVM.Attributes.Signature("(Ljava/lang/ClassLoader;)Ljava/lang/Class<*>;")]
	[LineNumberTable(1408)]
	[java.lang.Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public Class toClass(ClassLoader loader)
	{
		Class result = getClassPool().toClass(this, null, loader, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 165, 30, 103, 109, 103, 112 })]
	public virtual void detach()
	{
		ClassPool classPool = getClassPool();
		CtClass ctClass = classPool.removeCached(getName());
		if (ctClass != null && ctClass != this)
		{
			classPool.cacheCtClass(getName(), ctClass, dynamic: false);
		}
	}

	public virtual void prune()
	{
	}

	public virtual void rebuildClassFile()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException", "java.io.IOException", "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 165, 145, 109 })]
	public virtual void writeFile()
	{
		writeFile(".");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 165, 192, 109 })]
	public virtual void debugWriteFile()
	{
		debugWriteFile(".");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1681)]
	public virtual string makeUniqueName(string prefix)
	{
		string message = new StringBuilder().append("not available in ").append(getName()).toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(message);
	}

	[LineNumberTable(new byte[]
	{
		17, 230, 160, 79, 140, 223, 8, 140, 191, 8,
		140, 191, 8, 140, 191, 9, 140, 191, 9, 140,
		191, 9, 140, 191, 8, 140, 191, 8, 140, 159,
		0, 108
	})]
	static CtClass()
	{
		debugDump = null;
		primitiveTypes = new CtClass[9];
		booleanType = new CtPrimitiveType("boolean", 'Z', "java.lang.Boolean", "booleanValue", "()Z", 172, 4, 1);
		primitiveTypes[0] = booleanType;
		charType = new CtPrimitiveType("char", 'C', "java.lang.Character", "charValue", "()C", 172, 5, 1);
		primitiveTypes[1] = charType;
		byteType = new CtPrimitiveType("byte", 'B', "java.lang.Byte", "byteValue", "()B", 172, 8, 1);
		primitiveTypes[2] = byteType;
		shortType = new CtPrimitiveType("short", 'S', "java.lang.Short", "shortValue", "()S", 172, 9, 1);
		primitiveTypes[3] = shortType;
		intType = new CtPrimitiveType("int", 'I', "java.lang.Integer", "intValue", "()I", 172, 10, 1);
		primitiveTypes[4] = intType;
		longType = new CtPrimitiveType("long", 'J', "java.lang.Long", "longValue", "()J", 173, 11, 2);
		primitiveTypes[5] = longType;
		floatType = new CtPrimitiveType("float", 'F', "java.lang.Float", "floatValue", "()F", 174, 6, 1);
		primitiveTypes[6] = floatType;
		doubleType = new CtPrimitiveType("double", 'D', "java.lang.Double", "doubleValue", "()D", 175, 7, 2);
		primitiveTypes[7] = doubleType;
		voidType = new CtPrimitiveType("void", 'V', "java.lang.Void", null, null, 177, 0, 0);
		primitiveTypes[8] = voidType;
	}
}
