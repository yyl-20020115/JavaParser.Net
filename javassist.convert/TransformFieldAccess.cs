using System.Runtime.CompilerServices;
using IKVM.Attributes;
using javassist.bytecode;

namespace javassist.convert;

public sealed class TransformFieldAccess : Transformer
{
	private string newClassname;

	private string newFieldname;

	private string fieldname;

	private CtClass fieldClass;

	private bool isPrivate;

	private int newIndex;

	private ConstPool constPool;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 181, 105, 108, 108, 113, 103, 104, 103 })]
	public TransformFieldAccess(Transformer next, CtField field, string newClassname, string newFieldname)
		: base(next)
	{
		fieldClass = field.getDeclaringClass();
		fieldname = field.getName();
		isPrivate = Modifier.isPrivate(field.getModifiers());
		this.newClassname = newClassname;
		this.newFieldname = newFieldname;
		constPool = null;
	}

	public override void initialize(ConstPool cp, CodeAttribute attr)
	{
		if (constPool != cp)
		{
			newIndex = 0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		14, 104, 159, 4, 106, 97, 159, 1, 99, 104,
		143, 107, 38, 138, 168, 207
	})]
	public override int transform(CtClass clazz, int pos, CodeIterator iterator, ConstPool cp)
	{
		int num = iterator.byteAt(pos);
		if (num == 180 || num == 178 || num == 181 || num == 179)
		{
			int num2 = iterator.u16bitAt(pos + 1);
			string text = TransformReadField.isField(clazz.getClassPool(), cp, fieldClass, fieldname, isPrivate, num2);
			if (text != null)
			{
				if (newIndex == 0)
				{
					int nameAndTypeInfo = cp.addNameAndTypeInfo(newFieldname, text);
					newIndex = cp.addFieldrefInfo(cp.addClassInfo(newClassname), nameAndTypeInfo);
					constPool = cp;
				}
				iterator.write16bit(newIndex, pos + 1);
			}
		}
		return pos;
	}
}
