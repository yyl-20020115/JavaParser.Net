using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.lang.reflect;
using java.util;

namespace javassist.bytecode.annotation;

public abstract class MemberValue : java.lang.Object
{
	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	internal ConstPool cp;

	internal char tag;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	public virtual void renameClass(string oldname, string newname)
	{
	}

	[IKVM.Attributes.Signature("(Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
	public virtual void renameClass(Map classnames)
	{
	}

	[Throws(new string[] { "java.io.IOException" })]
	public abstract void write(AnnotationsWriter aw);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.ClassNotFoundException", "javassist.bytecode.annotation.NoSuchClassError" })]
	[IKVM.Attributes.Signature("(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Class<*>;")]
	[LineNumberTable(new byte[] { 6, 159, 14, 97 })]
	internal static Class loadClass(ClassLoader P_0, string P_1)
	{
		//Discarded unreachable code: IL_0014
		java.lang.LinkageError linkageError2;
		try
		{
			return Class.forName(convertFromArray(P_1), true, P_0, MemberValue.___003CGetCallerID_003E());
		}
		catch (System.Exception x)
		{
			java.lang.LinkageError linkageError = ByteCodeHelper.MapException<java.lang.LinkageError>(x, ByteCodeHelper.MapFlags.None);
			if (linkageError == null)
			{
				throw;
			}
			linkageError2 = linkageError;
		}
		java.lang.LinkageError cause = linkageError2;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new NoSuchClassError(P_1, cause);
	}

	[Throws(new string[] { "java.lang.ClassNotFoundException" })]
	[Modifiers(Modifiers.Abstract)]
	internal virtual object getValue(ClassLoader P_0, ClassPool P_1, Method P_2)
	{
		throw new AbstractMethodError("javassist.bytecode.annotation.MemberValue.getValue(Ljava.lang.ClassLoader;Ljavassist.ClassPool;Ljava.lang.reflect.Method;)Ljava.lang.Object;");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 15, 108, 100, 105, 108, 100, 106, 145, 146 })]
	private static string convertFromArray(string P_0)
	{
		int num = java.lang.String.instancehelper_indexOf(P_0, "[]");
		if (num != -1)
		{
			string classname = java.lang.String.instancehelper_substring(P_0, 0, num);
			StringBuilder stringBuilder = new StringBuilder(Descriptor.of(classname));
			while (num != -1)
			{
				stringBuilder.insert(0, '[');
				num = java.lang.String.instancehelper_indexOf(P_0, "[]", num + 1);
			}
			string result = java.lang.String.instancehelper_replace(stringBuilder.toString(), '/', '.');
			_ = null;
			return result;
		}
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 133, 130, 104, 103, 103 })]
	internal MemberValue(char P_0, ConstPool P_1)
	{
		cp = P_1;
		tag = P_0;
	}

	[Throws(new string[] { "java.lang.ClassNotFoundException" })]
	[Modifiers(Modifiers.Abstract)]
	[IKVM.Attributes.Signature("(Ljava/lang/ClassLoader;)Ljava/lang/Class<*>;")]
	internal virtual Class getType(ClassLoader P_0)
	{
		throw new AbstractMethodError("javassist.bytecode.annotation.MemberValue.getType(Ljava.lang.ClassLoader;)Ljava.lang.Class;");
	}

	public abstract void accept(MemberValueVisitor mvv);

	static CallerID ___003CGetCallerID_003E()
	{
		if (___003CcallerID_003E == null)
		{
			___003CcallerID_003E = new ___003CCallerID_003E();
		}
		return ___003CcallerID_003E;
	}
}
