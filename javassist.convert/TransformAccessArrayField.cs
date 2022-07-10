using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using javassist.bytecode;
using javassist.bytecode.analysis;

namespace javassist.convert;

public sealed class TransformAccessArrayField : Transformer
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private string methodClassname;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private CodeConverter.ArrayAccessReplacementMethodNames names;

	private Frame[] frames;

	private int offset;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 159, 187, 105, 103, 135 })]
	public TransformAccessArrayField(Transformer next, string methodClassname, CodeConverter.ArrayAccessReplacementMethodNames names)
		: base(next)
	{
		this.methodClassname = methodClassname;
		this.names = names;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 56, 104, 114, 135 })]
	private void initFrames(CtClass P_0, MethodInfo P_1)
	{
		if (frames == null)
		{
			frames = new Analyzer().analyze(P_0, P_1);
			offset = 0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		160, 114, 159, 12, 134, 134, 134, 134, 134, 134,
		134, 166
	})]
	private string getLoadReplacementSignature(int P_0)
	{
		switch (P_0)
		{
		case 50:
			return "(Ljava/lang/Object;I)Ljava/lang/Object;";
		case 51:
			return "(Ljava/lang/Object;I)B";
		case 52:
			return "(Ljava/lang/Object;I)C";
		case 49:
			return "(Ljava/lang/Object;I)D";
		case 48:
			return "(Ljava/lang/Object;I)F";
		case 46:
			return "(Ljava/lang/Object;I)I";
		case 53:
			return "(Ljava/lang/Object;I)S";
		case 47:
			return "(Ljava/lang/Object;I)J";
		default:
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new BadBytecode(P_0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		80, 98, 105, 134, 102, 205, 99, 98, 109, 226,
		69, 104, 98, 110, 104, 109, 108, 108, 139, 99,
		105, 110, 171, 175
	})]
	private int replace(ConstPool P_0, CodeIterator P_1, int P_2, int P_3, string P_4)
	{
		string text = null;
		string methodName = getMethodName(P_3);
		if (methodName != null)
		{
			if (P_3 == 50)
			{
				text = getTopType(P_1.lookAhead());
				if (text == null)
				{
					return P_2;
				}
				if (java.lang.String.instancehelper_equals("java/lang/Object", text))
				{
					text = null;
				}
			}
			P_1.writeByte(0, P_2);
			CodeIterator.Gap gap = P_1.insertGapAt(P_2, (text == null) ? 2 : 5, exclusive: false);
			P_2 = gap.position;
			int classInfo = P_0.addClassInfo(methodClassname);
			int value = P_0.addMethodrefInfo(classInfo, methodName, P_4);
			P_1.writeByte(184, P_2);
			P_1.write16bit(value, P_2 + 1);
			if (text != null)
			{
				int value2 = P_0.addClassInfo(text);
				P_1.writeByte(192, P_2 + 3);
				P_1.write16bit(value2, P_2 + 4);
			}
			P_2 = updatePos(P_2, gap.length);
		}
		return P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		160, 137, 159, 12, 134, 134, 134, 134, 134, 134,
		134, 166
	})]
	private string getStoreReplacementSignature(int P_0)
	{
		switch (P_0)
		{
		case 83:
			return "(Ljava/lang/Object;ILjava/lang/Object;)V";
		case 84:
			return "(Ljava/lang/Object;IB)V";
		case 85:
			return "(Ljava/lang/Object;IC)V";
		case 82:
			return "(Ljava/lang/Object;ID)V";
		case 81:
			return "(Ljava/lang/Object;IF)V";
		case 79:
			return "(Ljava/lang/Object;II)V";
		case 86:
			return "(Ljava/lang/Object;IS)V";
		case 80:
			return "(Ljava/lang/Object;IJ)V";
		default:
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new BadBytecode(P_0);
		}
	}

	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(102)]
	private Frame getFrame(int P_0)
	{
		return frames[P_0 - offset];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		119, 98, 159, 160, 83, 108, 133, 108, 133, 108,
		133, 108, 133, 108, 133, 108, 133, 108, 133, 108,
		133, 108, 133, 108, 130, 108, 130, 108, 130, 108,
		130, 108, 130, 108, 130, 204, 109, 130
	})]
	private string getMethodName(int P_0)
	{
		string text = null;
		switch (P_0)
		{
		case 50:
			text = names.objectRead();
			break;
		case 51:
			text = names.byteOrBooleanRead();
			break;
		case 52:
			text = names.charRead();
			break;
		case 49:
			text = names.doubleRead();
			break;
		case 48:
			text = names.floatRead();
			break;
		case 46:
			text = names.intRead();
			break;
		case 53:
			text = names.shortRead();
			break;
		case 47:
			text = names.longRead();
			break;
		case 83:
			text = names.objectWrite();
			break;
		case 84:
			text = names.byteOrBooleanWrite();
			break;
		case 85:
			text = names.charWrite();
			break;
		case 82:
			text = names.doubleWrite();
			break;
		case 81:
			text = names.floatWrite();
			break;
		case 79:
			text = names.intWrite();
			break;
		case 86:
			text = names.shortWrite();
			break;
		case 80:
			text = names.longWrite();
			break;
		}
		if (java.lang.String.instancehelper_equals("", text))
		{
			text = null;
		}
		return text;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 70, 104, 99, 130, 108 })]
	private string getTopType(int P_0)
	{
		Frame frame = getFrame(P_0);
		if (frame == null)
		{
			return null;
		}
		CtClass ctClass = frame.peek().getCtClass();
		return (ctClass == null) ? null : Descriptor.toJvmName(ctClass);
	}

	[LineNumberTable(new byte[] { 63, 105, 142 })]
	private int updatePos(int P_0, int P_1)
	{
		if (offset > -1)
		{
			offset += P_1;
		}
		return P_0 + P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		13,
		108,
		139,
		103,
		136,
		101,
		136,
		191,
		9,
		116,
		191,
		9,
		byte.MaxValue,
		10,
		69,
		5,
		98,
		173
	})]
	public override void initialize(ConstPool cp, CtClass clazz, MethodInfo minfo)
	{
		CodeIterator codeIterator = minfo.getCodeAttribute().iterator();
		while (codeIterator.hasNext())
		{
			java.lang.Exception ex2;
			try
			{
				int num = codeIterator.next();
				int num2 = codeIterator.byteAt(num);
				if (num2 == 50)
				{
					initFrames(clazz, minfo);
				}
				switch (num2)
				{
				case 46:
				case 47:
				case 48:
				case 49:
				case 50:
				case 51:
				case 52:
				case 53:
					replace(cp, codeIterator, num, num2, getLoadReplacementSignature(num2));
					break;
				case 79:
				case 80:
				case 81:
				case 82:
				case 83:
				case 84:
				case 85:
				case 86:
					replace(cp, codeIterator, num, num2, getStoreReplacementSignature(num2));
					break;
				}
			}
			catch (System.Exception x)
			{
				java.lang.Exception ex = ByteCodeHelper.MapException<java.lang.Exception>(x, ByteCodeHelper.MapFlags.None);
				if (ex == null)
				{
					throw;
				}
				ex2 = ex;
				goto IL_00bd;
			}
			continue;
			IL_00bd:
			java.lang.Exception e = ex2;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CannotCompileException(e);
		}
	}

	public override void clean()
	{
		frames = null;
		offset = -1;
	}

	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	public override int transform(CtClass tclazz, int pos, CodeIterator iterator, ConstPool cp)
	{
		return pos;
	}
}
