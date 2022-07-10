using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;
using javassist.bytecode.annotation;

namespace javassist.bytecode;

public class ParameterAnnotationsAttribute : AttributeInfo
{
	public const string visibleTag = "RuntimeVisibleParameterAnnotations";

	public const string invisibleTag = "RuntimeInvisibleParameterAnnotations";

	[LineNumberTable(102)]
	public virtual int numParameters()
	{
		return info[0];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 85, 159, 18, 97 })]
	public virtual Annotation[][] getAnnotations()
	{
		//Discarded unreachable code: IL_0018
		java.lang.Exception ex2;
		try
		{
			return new AnnotationsAttribute.Parser(info, constPool).parseParameters();
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
	[LineNumberTable(new byte[] { 45, 107 })]
	internal ParameterAnnotationsAttribute(ConstPool P_0, int P_1, DataInputStream P_2)
		: base(P_0, P_1, P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 21, 107 })]
	public ParameterAnnotationsAttribute(ConstPool cp, string attrname, byte[] info)
		: base(cp, attrname, info)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
	[LineNumberTable(new byte[] { 160, 70, 147, 189, 2, 97, 140 })]
	internal override void renameClass(Map P_0)
	{
		AnnotationsAttribute.Renamer renamer = new AnnotationsAttribute.Renamer(info, getConstPool(), P_0);
		java.lang.Exception ex2;
		try
		{
			renamer.parameters();
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 36, 116 })]
	public ParameterAnnotationsAttribute(ConstPool cp, string attrname)
		: this(cp, attrname, new byte[1] { 0 })
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)Ljavassist/bytecode/AttributeInfo;")]
	[LineNumberTable(new byte[] { 60, 148, 102, 104, 63, 5, 161, 97 })]
	public override AttributeInfo copy(ConstPool newCp, Map classnames)
	{
		//Discarded unreachable code: IL_002e
		AnnotationsAttribute.Copier copier = new AnnotationsAttribute.Copier(info, constPool, newCp, classnames);
		java.lang.Exception ex2;
		try
		{
			copier.parameters();
			return new ParameterAnnotationsAttribute(newCp, getName(), copier.close());
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
	[LineNumberTable(new byte[]
	{
		102, 102, 141, 104, 115, 105, 106, 43, 8, 232,
		70, 218, 2, 98, 173, 108
	})]
	public virtual void setAnnotations(Annotation[][] @params)
	{
		ByteArrayOutputStream byteArrayOutputStream = new ByteArrayOutputStream();
		AnnotationsWriter annotationsWriter = new AnnotationsWriter(byteArrayOutputStream, constPool);
		IOException ex;
		try
		{
			annotationsWriter.numParameters(@params.Length);
			int num = @params.Length;
			for (int i = 0; i < num; i++)
			{
				Annotation[] array = @params[i];
				annotationsWriter.numAnnotations(array.Length);
				for (int j = 0; j < (nint)array.LongLength; j++)
				{
					array[j].write(annotationsWriter);
				}
			}
			annotationsWriter.close();
		}
		catch (IOException x)
		{
			ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0072;
		}
		set(byteArrayOutputStream.toByteArray());
		return;
		IL_0072:
		IOException cause = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(cause);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 127, 102, 105, 105 })]
	internal override void renameClass(string P_0, string P_1)
	{
		HashMap hashMap = new HashMap();
		((Map)hashMap).put((object)P_0, (object)P_1);
		renameClass(hashMap);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
	[LineNumberTable(193)]
	internal override void getRefClasses(Map P_0)
	{
		renameClass(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 86, 103, 102, 118, 121, 53, 168, 236, 60,
		235, 71
	})]
	public override string toString()
	{
		Annotation[][] annotations = getAnnotations();
		StringBuilder stringBuilder = new StringBuilder();
		Annotation[][] array = annotations;
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			Annotation[] array2 = array[i];
			Annotation[] array3 = array2;
			int num2 = array3.Length;
			for (int j = 0; j < num2; j++)
			{
				Annotation annotation = array3[j];
				stringBuilder.append(annotation.toString()).append(' ');
			}
			stringBuilder.append(", ");
		}
		string result = java.lang.String.instancehelper_replaceAll(stringBuilder.toString(), " (?=,)|, $", "");
		_ = null;
		return result;
	}
}
