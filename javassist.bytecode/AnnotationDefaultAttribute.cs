using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;
using javassist.bytecode.annotation;

namespace javassist.bytecode;

public class AnnotationDefaultAttribute : AttributeInfo
{
	public const string tag = "AnnotationDefault";

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 98, 113, 63, 0, 161, 97 })]
	public virtual MemberValue getDefaultValue()
	{
		//Discarded unreachable code: IL_0018
		java.lang.Exception ex2;
		try
		{
			return new AnnotationsAttribute.Parser(info, constPool).parseMemberValue();
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
		java.lang.Exception @this = ex2;
		string message = Throwable.instancehelper_toString(@this);
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(message);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 51, 107 })]
	internal AnnotationDefaultAttribute(ConstPool P_0, int P_1, DataInputStream P_2)
		: base(P_0, P_1, P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 31, 111 })]
	public AnnotationDefaultAttribute(ConstPool cp, byte[] info)
		: base(cp, "AnnotationDefault", info)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 113, 102, 141, 103, 216, 2, 97, 172, 140 })]
	public virtual void setDefaultValue(MemberValue value)
	{
		ByteArrayOutputStream byteArrayOutputStream = new ByteArrayOutputStream();
		AnnotationsWriter annotationsWriter = new AnnotationsWriter(byteArrayOutputStream, constPool);
		IOException ex;
		try
		{
			value.write(annotationsWriter);
			annotationsWriter.close();
		}
		catch (IOException x)
		{
			ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_002f;
		}
		set(byteArrayOutputStream.toByteArray());
		return;
		IL_002f:
		IOException cause = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(cause);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 42, 119 })]
	public AnnotationDefaultAttribute(ConstPool cp)
		: this(cp, new byte[2] { 0, 0 })
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)Ljavassist/bytecode/AttributeInfo;")]
	[LineNumberTable(new byte[] { 59, 180, 104, 159, 8, 97 })]
	public override AttributeInfo copy(ConstPool newCp, Map classnames)
	{
		//Discarded unreachable code: IL_002a
		AnnotationsAttribute.Copier copier = new AnnotationsAttribute.Copier(info, constPool, newCp, classnames);
		java.lang.Exception ex2;
		try
		{
			copier.memberValue(0);
			return new AnnotationDefaultAttribute(newCp, copier.close());
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
		java.lang.Exception @this = ex2;
		string message = Throwable.instancehelper_toString(@this);
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(message);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 73, 103, 104, 188, 2, 161 })]
	internal override void renameClass(string P_0, string P_1)
	{
		try
		{
			MemberValue defaultValue = getDefaultValue();
			defaultValue.renameClass(P_0, P_1);
			setDefaultValue(defaultValue);
			return;
		}
		catch (System.Exception x)
		{
			if (ByteCodeHelper.MapException<java.lang.Exception>(x, ByteCodeHelper.MapFlags.Unused) == null)
			{
				throw;
			}
		}
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
	[LineNumberTable(new byte[] { 84, 103, 103, 188, 2, 161 })]
	internal override void renameClass(Map P_0)
	{
		try
		{
			MemberValue defaultValue = getDefaultValue();
			defaultValue.renameClass(P_0);
			setDefaultValue(defaultValue);
			return;
		}
		catch (System.Exception x)
		{
			if (ByteCodeHelper.MapException<java.lang.Exception>(x, ByteCodeHelper.MapFlags.Unused) == null)
			{
				throw;
			}
		}
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(182)]
	public override string toString()
	{
		string result = java.lang.Object.instancehelper_toString(getDefaultValue());
		_ = null;
		return result;
	}
}
