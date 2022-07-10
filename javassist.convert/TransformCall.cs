using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using javassist.bytecode;

namespace javassist.convert;

public class TransformCall : Transformer
{
	protected internal string classname;

	protected internal string methodname;

	protected internal string methodDescriptor;

	protected internal string newClassname;

	protected internal string newMethodname;

	protected internal bool newMethodIsPrivate;

	protected internal int newIndex;

	protected internal ConstPool constPool;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 183, 112, 113 })]
	public TransformCall(Transformer next, CtMethod origMethod, CtMethod substMethod)
		: this(next, origMethod.getName(), substMethod)
	{
		classname = origMethod.getDeclaringClass().getName();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 190, 105, 103, 113, 124, 108, 103, 113 })]
	public TransformCall(Transformer next, string oldMethodName, CtMethod substMethod)
		: base(next)
	{
		methodname = oldMethodName;
		methodDescriptor = substMethod.getMethodInfo2().getDescriptor();
		string name = substMethod.getDeclaringClass().getName();
		newClassname = name;
		classname = name;
		newMethodname = substMethod.getName();
		constPool = null;
		newMethodIsPrivate = Modifier.isPrivate(substMethod.getModifiers());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		40, 110, 162, 104, 109, 137, 115, 159, 21, 129,
		226, 69, 2, 97, 162
	})]
	private bool matchClass(string P_0, ClassPool P_1)
	{
		//Discarded unreachable code: IL_0059
		if (String.instancehelper_equals(classname, P_0))
		{
			return true;
		}
		try
		{
			CtClass ctClass = P_1.get(P_0);
			CtClass clazz = P_1.get(classname);
			if (ctClass.subtypeOf(clazz))
			{
				try
				{
					CtMethod method = ctClass.getMethod(methodname, methodDescriptor);
					return String.instancehelper_equals(method.getDeclaringClass().getName(), classname);
				}
				catch (NotFoundException)
				{
				}
				goto IL_006c;
			}
		}
		catch (NotFoundException)
		{
			goto IL_0072;
		}
		return false;
		IL_0072:
		_ = null;
		return false;
		IL_006c:
		_ = null;
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		66, 107, 151, 110, 104, 145, 112, 140, 175, 168,
		111
	})]
	protected internal virtual int match(int c, int pos, CodeIterator iterator, int typedesc, ConstPool cp)
	{
		if (newIndex == 0)
		{
			int nameAndTypeInfo = cp.addNameAndTypeInfo(cp.addUtf8Info(newMethodname), typedesc);
			int classInfo = cp.addClassInfo(newClassname);
			if (c == 185)
			{
				newIndex = cp.addInterfaceMethodrefInfo(classInfo, nameAndTypeInfo);
			}
			else
			{
				if (newMethodIsPrivate && c == 182)
				{
					iterator.writeByte(183, pos);
				}
				newIndex = cp.addMethodrefInfo(classInfo, nameAndTypeInfo);
			}
			constPool = cp;
		}
		iterator.write16bit(newIndex, pos + 1);
		return pos;
	}

	public override void initialize(ConstPool cp, CodeAttribute attr)
	{
		if (constPool != cp)
		{
			newIndex = 0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		24, 104, 159, 1, 106, 117, 114, 105, 103, 39,
		231, 69
	})]
	public override int transform(CtClass clazz, int pos, CodeIterator iterator, ConstPool cp)
	{
		int num = iterator.byteAt(pos);
		if (num == 185 || num == 183 || num == 184 || num == 182)
		{
			int index = iterator.u16bitAt(pos + 1);
			string text = cp.eqMember(methodname, methodDescriptor, index);
			if (text != null && matchClass(text, clazz.getClassPool()))
			{
				int memberNameAndType = cp.getMemberNameAndType(index);
				pos = match(num, pos, iterator, cp.getNameAndTypeDescriptor(memberNameAndType), cp);
			}
		}
		return pos;
	}
}
