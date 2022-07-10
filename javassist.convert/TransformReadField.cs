using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using javassist.bytecode;

namespace javassist.convert;

public class TransformReadField : Transformer
{
	protected internal string fieldname;

	protected internal CtClass fieldClass;

	protected internal bool isPrivate;

	protected internal string methodClassname;

	protected internal string methodName;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 179, 105, 108, 108, 103, 104, 113 })]
	public TransformReadField(Transformer next, CtField field, string methodClassname, string methodName)
		: base(next)
	{
		fieldClass = field.getDeclaringClass();
		fieldname = field.getName();
		this.methodClassname = methodClassname;
		this.methodName = methodName;
		isPrivate = Modifier.isPrivate(field.getModifiers());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 131, 163, 112, 162, 111, 113, 155, 99 })]
	internal static string isField(ClassPool P_0, ConstPool P_1, CtClass P_2, string P_3, bool P_4, int P_5)
	{
		//Discarded unreachable code: IL_0041
		if (!String.instancehelper_equals(P_1.getFieldrefName(P_5), P_3))
		{
			return null;
		}
		try
		{
			CtClass ctClass = P_0.get(P_1.getFieldrefClassName(P_5));
			if (ctClass == P_2 || (!P_4 && isFieldInSuper(ctClass, P_2, P_3)))
			{
				return P_1.getFieldrefType(P_5);
			}
		}
		catch (NotFoundException)
		{
			goto IL_004c;
		}
		goto IL_0053;
		IL_004c:
		_ = null;
		goto IL_0053;
		IL_0053:
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 10, 105, 162, 104, 156, 97 })]
	internal static bool isFieldInSuper(CtClass P_0, CtClass P_1, string P_2)
	{
		//Discarded unreachable code: IL_0022
		if (!P_0.subclassOf(P_1))
		{
			return false;
		}
		try
		{
			CtField field = P_0.getField(P_2);
			return (field.getDeclaringClass() == P_1) ? true : false;
		}
		catch (NotFoundException)
		{
		}
		_ = null;
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		25, 104, 115, 106, 159, 2, 102, 104, 103, 105,
		104, 168, 123, 111, 114, 108, 107, 194
	})]
	public override int transform(CtClass tclazz, int pos, CodeIterator iterator, ConstPool cp)
	{
		int num = iterator.byteAt(pos);
		if (num == 180 || num == 178)
		{
			int num2 = iterator.u16bitAt(pos + 1);
			string text = isField(tclazz.getClassPool(), cp, fieldClass, fieldname, isPrivate, num2);
			if (text != null)
			{
				if (num == 178)
				{
					iterator.move(pos);
					pos = iterator.insertGap(1);
					iterator.writeByte(1, pos);
					pos = iterator.next();
				}
				string type = new StringBuilder().append("(Ljava/lang/Object;)").append(text).toString();
				int classInfo = cp.addClassInfo(methodClassname);
				int value = cp.addMethodrefInfo(classInfo, methodName, type);
				iterator.writeByte(184, pos);
				iterator.write16bit(value, pos + 1);
				return pos;
			}
		}
		return pos;
	}
}
