using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;
using javassist.bytecode.annotation;

namespace javassist.bytecode;

public class AnnotationsAttribute : AttributeInfo
{
	internal class Copier : Walker
	{
		internal ByteArrayOutputStream output;

		internal AnnotationsWriter writer;

		internal ConstPool srcPool;

		internal ConstPool destPool;

		[IKVM.Attributes.Signature("Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;")]
		internal Map classnames;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IKVM.Attributes.Signature("([BLjavassist/bytecode/ConstPool;Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
		[LineNumberTable(new byte[] { 161, 177, 110 })]
		internal Copier(byte[] P_0, ConstPool P_1, ConstPool P_2, Map P_3)
			: this(P_0, P_1, P_2, P_3, true)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 161, 192, 107 })]
		internal virtual byte[] close()
		{
			writer.close();
			byte[] result = output.toByteArray();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IKVM.Attributes.Signature("([BLjavassist/bytecode/ConstPool;Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;Z)V")]
		[LineNumberTable(new byte[] { 159, 5, 163, 105, 107, 99, 146, 103, 103, 104 })]
		internal Copier(byte[] P_0, ConstPool P_1, ConstPool P_2, Map P_3, bool P_4)
			: base(P_0)
		{
			output = new ByteArrayOutputStream();
			if (P_4)
			{
				writer = new AnnotationsWriter(output, P_2);
			}
			srcPool = P_1;
			destPool = P_2;
			classnames = P_3;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 20, 109, 109 })]
		internal virtual int copyType(int P_0)
		{
			string utf8Info = srcPool.getUtf8Info(P_0);
			string utf = Descriptor.rename(utf8Info, classnames);
			int result = destPool.addUtf8Info(utf);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(632)]
		internal virtual int copy(int P_0)
		{
			int result = srcPool.copy(P_0, destPool, classnames);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 161, 198, 108, 106 })]
		internal override void parameters(int P_0, int P_1)
		{
			writer.numParameters(P_0);
			base.parameters(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 161, 204, 108 })]
		internal override int annotationArray(int P_0, int P_1)
		{
			writer.numAnnotations(P_1);
			int result = base.annotationArray(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 161, 210, 115 })]
		internal override int annotation(int P_0, int P_1, int P_2)
		{
			writer.annotation(copyType(P_1), P_2);
			int result = base.annotation(P_0, P_1, P_2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 161, 216, 114 })]
		internal override int memberValuePair(int P_0, int P_1)
		{
			writer.memberValuePair(copy(P_1));
			int result = base.memberValuePair(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 161, 222, 115, 106 })]
		internal override void constValueMember(int P_0, int P_1)
		{
			writer.constValueIndex(P_0, copy(P_1));
			base.constValueMember(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 161, 230, 121, 107 })]
		internal override void enumMemberValue(int P_0, int P_1, int P_2)
		{
			writer.enumConstValue(copyType(P_1), copy(P_2));
			base.enumMemberValue(P_0, P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 161, 236, 114, 106 })]
		internal override void classMemberValue(int P_0, int P_1)
		{
			writer.classInfoIndex(copyType(P_1));
			base.classMemberValue(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 161, 242, 107 })]
		internal override int annotationMemberValue(int P_0)
		{
			writer.annotationValue();
			int result = base.annotationMemberValue(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 161, 248, 108 })]
		internal override int arrayMemberValue(int P_0, int P_1)
		{
			writer.arrayValue(P_1);
			int result = base.arrayMemberValue(P_0, P_1);
			_ = null;
			return result;
		}
	}

	internal class Parser : Walker
	{
		internal ConstPool pool;

		internal Annotation[][] allParams;

		internal Annotation[] allAnno;

		internal Annotation currentAnno;

		internal MemberValue currentMember;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 41, 105, 103 })]
		internal Parser(byte[] P_0, ConstPool P_1)
			: base(P_0)
		{
			pool = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 162, 56, 104 })]
		internal virtual MemberValue parseMemberValue()
		{
			memberValue(0);
			return currentMember;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 162, 51, 102 })]
		internal virtual Annotation[] parseAnnotations()
		{
			annotationArray();
			return allAnno;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 162, 46, 102 })]
		internal virtual Annotation[][] parseParameters()
		{
			parameters();
			return allParams;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 162, 62, 103, 102, 105, 9, 230, 69, 103 })]
		internal override void parameters(int P_0, int P_1)
		{
			Annotation[][] array = new Annotation[P_0][];
			for (int i = 0; i < P_0; i++)
			{
				P_1 = annotationArray(P_1);
				array[i] = allAnno;
			}
			allParams = array;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 162, 73, 103, 102, 105, 9, 230, 69, 103 })]
		internal override int annotationArray(int P_0, int P_1)
		{
			Annotation[] array = new Annotation[P_1];
			for (int i = 0; i < P_1; i++)
			{
				P_0 = annotation(P_0);
				array[i] = currentAnno;
			}
			allAnno = array;
			return P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 162, 85, 114 })]
		internal override int annotation(int P_0, int P_1, int P_2)
		{
			currentAnno = new Annotation(P_1, pool);
			int result = base.annotation(P_0, P_1, P_2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 162, 91, 106, 114 })]
		internal override int memberValuePair(int P_0, int P_1)
		{
			P_0 = base.memberValuePair(P_0, P_1);
			currentAnno.addMemberValue(P_1, currentMember);
			return P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[]
		{
			162, 99, 103, 159, 69, 104, 133, 104, 133, 104,
			133, 104, 133, 104, 130, 104, 130, 104, 130, 104,
			130, 104, 130, 191, 6, 103, 106
		})]
		internal override void constValueMember(int P_0, int P_1)
		{
			ConstPool cp = pool;
			MemberValue memberValue;
			switch (P_0)
			{
			case 66:
				memberValue = new ByteMemberValue(P_1, cp);
				break;
			case 67:
				memberValue = new CharMemberValue(P_1, cp);
				break;
			case 68:
				memberValue = new DoubleMemberValue(P_1, cp);
				break;
			case 70:
				memberValue = new FloatMemberValue(P_1, cp);
				break;
			case 73:
				memberValue = new IntegerMemberValue(P_1, cp);
				break;
			case 74:
				memberValue = new LongMemberValue(P_1, cp);
				break;
			case 83:
				memberValue = new ShortMemberValue(P_1, cp);
				break;
			case 90:
				memberValue = new BooleanMemberValue(P_1, cp);
				break;
			case 115:
				memberValue = new StringMemberValue(P_1, cp);
				break;
			default:
			{
				string message = new StringBuilder().append("unknown tag:").append(P_0).toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new RuntimeException(message);
			}
			}
			currentMember = memberValue;
			base.constValueMember(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 162, 140, 147, 107 })]
		internal override void enumMemberValue(int P_0, int P_1, int P_2)
		{
			currentMember = new EnumMemberValue(P_1, P_2, pool);
			base.enumMemberValue(P_0, P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 162, 147, 114, 106 })]
		internal override void classMemberValue(int P_0, int P_1)
		{
			currentMember = new ClassMemberValue(P_1, pool);
			base.classMemberValue(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 162, 153, 103, 105, 119, 103 })]
		internal override int annotationMemberValue(int P_0)
		{
			Annotation annotation = currentAnno;
			P_0 = base.annotationMemberValue(P_0);
			currentMember = new AnnotationMemberValue(currentAnno, pool);
			currentAnno = annotation;
			return P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[]
		{
			162, 162, 108, 103, 102, 105, 9, 230, 69, 103,
			103
		})]
		internal override int arrayMemberValue(int P_0, int P_1)
		{
			ArrayMemberValue arrayMemberValue = new ArrayMemberValue(pool);
			MemberValue[] array = new MemberValue[P_1];
			for (int i = 0; i < P_1; i++)
			{
				P_0 = memberValue(P_0);
				array[i] = currentMember;
			}
			arrayMemberValue.setValue(array);
			currentMember = arrayMemberValue;
			return P_0;
		}
	}

	internal class Renamer : Walker
	{
		internal ConstPool cpool;

		[IKVM.Attributes.Signature("Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;")]
		internal Map classnames;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IKVM.Attributes.Signature("([BLjavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
		[LineNumberTable(new byte[] { 161, 124, 105, 103, 103 })]
		internal Renamer(byte[] P_0, ConstPool P_1, Map P_2)
			: base(P_0)
		{
			cpool = P_1;
			classnames = P_2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 150, 109, 109, 105, 109, 143 })]
		private void renameType(int P_0, int P_1)
		{
			string utf8Info = cpool.getUtf8Info(P_1);
			string text = Descriptor.rename(utf8Info, classnames);
			if (!java.lang.String.instancehelper_equals(utf8Info, text))
			{
				int value = cpool.addUtf8Info(text);
				ByteArray.write16bit(value, info, P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 161, 131, 106 })]
		internal override int annotation(int P_0, int P_1, int P_2)
		{
			renameType(P_0 - 4, P_1);
			int result = base.annotation(P_0, P_1, P_2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 161, 139, 106, 107 })]
		internal override void enumMemberValue(int P_0, int P_1, int P_2)
		{
			renameType(P_0 + 1, P_1);
			base.enumMemberValue(P_0, P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 161, 145, 106, 106 })]
		internal override void classMemberValue(int P_0, int P_1)
		{
			renameType(P_0 + 1, P_1);
			base.classMemberValue(P_0, P_1);
		}
	}

	internal class Walker : java.lang.Object
	{
		internal byte[] info;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[]
		{
			161, 49, 105, 101, 111, 111, 105, 132, 101, 111,
			104, 132, 101, 108, 101, 111, 173, 111, 104
		})]
		internal int memberValue(int P_0)
		{
			int num = info[P_0];
			switch (num)
			{
			case 101:
			{
				int num2 = ByteArray.readU16bit(info, P_0 + 1);
				int num3 = ByteArray.readU16bit(info, P_0 + 3);
				enumMemberValue(P_0, num2, num3);
				return P_0 + 5;
			}
			case 99:
			{
				int num2 = ByteArray.readU16bit(info, P_0 + 1);
				classMemberValue(P_0, num2);
				return P_0 + 3;
			}
			case 64:
			{
				int result2 = annotationMemberValue(P_0 + 1);
				_ = null;
				return result2;
			}
			case 91:
			{
				int num2 = ByteArray.readU16bit(info, P_0 + 1);
				int result = arrayMemberValue(P_0 + 3, num2);
				_ = null;
				return result;
			}
			default:
			{
				int num2 = ByteArray.readU16bit(info, P_0 + 1);
				constValueMember(num, num2);
				return P_0 + 3;
			}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 160, 253, 102, 41, 134 })]
		internal virtual void parameters(int P_0, int P_1)
		{
			for (int i = 0; i < P_0; i++)
			{
				P_1 = annotationArray(P_1);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 161, 6, 109 })]
		internal int annotationArray(int P_0)
		{
			int num = ByteArray.readU16bit(info, P_0);
			int result = annotationArray(P_0 + 2, num);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 161, 11, 102, 41, 166 })]
		internal virtual int annotationArray(int P_0, int P_1)
		{
			for (int i = 0; i < P_1; i++)
			{
				P_0 = annotation(P_0);
			}
			return P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 161, 18, 109, 111 })]
		internal int annotation(int P_0)
		{
			int num = ByteArray.readU16bit(info, P_0);
			int num2 = ByteArray.readU16bit(info, P_0 + 2);
			int result = annotation(P_0 + 4, num, num2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 161, 24, 102, 41, 166 })]
		internal virtual int annotation(int P_0, int P_1, int P_2)
		{
			for (int i = 0; i < P_2; i++)
			{
				P_0 = memberValuePair(P_0);
			}
			return P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 161, 34, 109 })]
		internal int memberValuePair(int P_0)
		{
			int num = ByteArray.readU16bit(info, P_0);
			int result = memberValuePair(P_0 + 2, num);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(412)]
		internal virtual int memberValuePair(int P_0, int P_1)
		{
			int result = memberValue(P_0);
			_ = null;
			return result;
		}

		[Throws(new string[] { "java.lang.Exception" })]
		internal virtual void enumMemberValue(int P_0, int P_1, int P_2)
		{
		}

		[Throws(new string[] { "java.lang.Exception" })]
		internal virtual void classMemberValue(int P_0, int P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(465)]
		internal virtual int annotationMemberValue(int P_0)
		{
			int result = annotation(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 161, 102, 102, 41, 198 })]
		internal virtual int arrayMemberValue(int P_0, int P_1)
		{
			for (int i = 0; i < P_1; i++)
			{
				P_0 = memberValue(P_0);
			}
			return P_0;
		}

		[Throws(new string[] { "java.lang.Exception" })]
		internal virtual void constValueMember(int P_0, int P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 243, 104, 103 })]
		internal Walker(byte[] P_0)
		{
			info = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 160, 248, 105, 106 })]
		internal void parameters()
		{
			int num = info[0];
			parameters(num, 1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 161, 2, 104 })]
		internal void annotationArray()
		{
			annotationArray(0);
		}
	}

	public const string visibleTag = "RuntimeVisibleAnnotations";

	public const string invisibleTag = "RuntimeInvisibleAnnotations";

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 156, 159, 18, 97 })]
	public virtual Annotation[] getAnnotations()
	{
		//Discarded unreachable code: IL_0018
		java.lang.Exception ex2;
		try
		{
			return new Parser(info, constPool).parseAnnotations();
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
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 116, 107 })]
	internal AnnotationsAttribute(ConstPool P_0, int P_1, DataInputStream P_2)
		: base(P_0, P_1, P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 92, 107 })]
	public AnnotationsAttribute(ConstPool cp, string attrname, byte[] info)
		: base(cp, attrname, info)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 171, 102, 141, 99, 103, 102, 41, 166, 218,
		2, 98, 173, 108
	})]
	public virtual void setAnnotations(Annotation[] annotations)
	{
		ByteArrayOutputStream byteArrayOutputStream = new ByteArrayOutputStream();
		AnnotationsWriter annotationsWriter = new AnnotationsWriter(byteArrayOutputStream, constPool);
		IOException ex;
		try
		{
			int num = annotations.Length;
			annotationsWriter.numAnnotations(num);
			for (int i = 0; i < num; i++)
			{
				annotations[i].write(annotationsWriter);
			}
			annotationsWriter.close();
		}
		catch (IOException x)
		{
			ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0048;
		}
		set(byteArrayOutputStream.toByteArray());
		return;
		IL_0048:
		IOException cause = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(cause);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
	[LineNumberTable(new byte[] { 160, 212, 147, 189, 2, 97, 140 })]
	internal override void renameClass(Map P_0)
	{
		Renamer renamer = new Renamer(info, getConstPool(), P_0);
		java.lang.Exception ex2;
		try
		{
			renamer.annotationArray();
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
	[LineNumberTable(new byte[] { 107, 120 })]
	public AnnotationsAttribute(ConstPool cp, string attrname)
		: this(cp, attrname, new byte[2] { 0, 0 })
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(173)]
	public virtual int numAnnotations()
	{
		int result = ByteArray.readU16bit(info, 0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)Ljavassist/bytecode/AttributeInfo;")]
	[LineNumberTable(new byte[] { 160, 67, 148, 102, 159, 14, 97 })]
	public override AttributeInfo copy(ConstPool newCp, Map classnames)
	{
		//Discarded unreachable code: IL_002e
		Copier copier = new Copier(info, constPool, newCp, classnames);
		java.lang.Exception ex2;
		try
		{
			copier.annotationArray();
			return new AnnotationsAttribute(newCp, getName(), copier.close());
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
	[LineNumberTable(new byte[] { 160, 87, 103, 103, 112, 4, 230, 69 })]
	public virtual Annotation getAnnotation(string type)
	{
		Annotation[] annotations = getAnnotations();
		for (int i = 0; i < (nint)annotations.LongLength; i++)
		{
			if (java.lang.String.instancehelper_equals(annotations[i].getTypeName(), type))
			{
				return annotations[i];
			}
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 103, 103, 103, 103, 112, 100, 105, 225, 60,
		230, 72, 106, 107, 101, 105
	})]
	public virtual void addAnnotation(Annotation annotation)
	{
		string typeName = annotation.getTypeName();
		Annotation[] annotations = getAnnotations();
		for (int i = 0; i < (nint)annotations.LongLength; i++)
		{
			if (java.lang.String.instancehelper_equals(annotations[i].getTypeName(), typeName))
			{
				annotations[i] = annotation;
				setAnnotations(annotations);
				return;
			}
		}
		Annotation[] array = new Annotation[(nint)annotations.LongLength + 1];
		ByteCodeHelper.arraycopy(annotations, 0, array, 0, annotations.Length);
		array[(nint)annotations.LongLength] = annotation;
		setAnnotations(array);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 129, 103, 106, 112, 106, 106, 103, 177, 103,
		226, 55, 233, 76
	})]
	public virtual bool removeAnnotation(string type)
	{
		Annotation[] annotations = getAnnotations();
		for (int i = 0; i < (nint)annotations.LongLength; i++)
		{
			if (java.lang.String.instancehelper_equals(annotations[i].getTypeName(), type))
			{
				Annotation[] array = new Annotation[(nint)annotations.LongLength - 1];
				ByteCodeHelper.arraycopy(annotations, 0, array, 0, i);
				if (i < (nint)annotations.LongLength - 1)
				{
					ByteCodeHelper.arraycopy(annotations, i + 1, array, i, (int)((nint)annotations.LongLength - i - 1));
				}
				setAnnotations(array);
				return true;
			}
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 196, 114 })]
	public virtual void setAnnotation(Annotation annotation)
	{
		setAnnotations(new Annotation[1] { annotation });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 205, 102, 105, 105 })]
	internal override void renameClass(string P_0, string P_1)
	{
		HashMap hashMap = new HashMap();
		((Map)hashMap).put((object)P_0, (object)P_1);
		renameClass(hashMap);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
	[LineNumberTable(335)]
	internal override void getRefClasses(Map P_0)
	{
		renameClass(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 228, 103, 102, 98, 101, 115, 101, 174 })]
	public override string toString()
	{
		Annotation[] annotations = getAnnotations();
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		while (num < (nint)annotations.LongLength)
		{
			int num2 = num;
			num++;
			stringBuilder.append(annotations[num2].toString());
			if ((nint)num != (nint)annotations.LongLength)
			{
				stringBuilder.append(", ");
			}
		}
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}
}
