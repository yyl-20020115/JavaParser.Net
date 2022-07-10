using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using javassist.bytecode;

namespace javassist;

internal class CtNewClass : CtClassType
{
	protected internal bool hasConstructor;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159, 135, 162, 106, 135, 103, 132, 136, 110, 103,
		155, 113, 103
	})]
	internal CtNewClass(string P_0, ClassPool P_1, bool P_2, CtClass P_3)
		: base(P_0, P_1)
	{
		wasChanged = true;
		classfile = new ClassFile(P_2, P_0, (!P_2 && P_3 != null) ? P_3.getName() : null);
		if (P_2 && P_3 != null)
		{
			classfile.setInterfaces(new string[1] { P_3.getName() });
		}
		setModifiers(Modifier.setPublic(getModifiers()));
		hasConstructor = P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException", "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		42, 103, 135, 98, 103, 101, 105, 107, 98, 103,
		38, 135, 107, 104, 228, 55, 233, 77, 100, 112,
		154
	})]
	public virtual void inheritAllConstructors()
	{
		CtClass superclass = getSuperclass();
		CtConstructor[] declaredConstructors = superclass.getDeclaredConstructors();
		int num = 0;
		for (int i = 0; i < (nint)declaredConstructors.LongLength; i++)
		{
			CtConstructor ctConstructor = declaredConstructors[i];
			int modifiers = ctConstructor.getModifiers();
			if (isInheritable(modifiers, superclass))
			{
				CtConstructor ctConstructor2 = CtNewConstructor.make(ctConstructor.getParameterTypes(), ctConstructor.getExceptionTypes(), this);
				ctConstructor2.setModifiers(modifiers & 7);
				addConstructor(ctConstructor2);
				num++;
			}
		}
		if (num < 1)
		{
			string msg = new StringBuilder().append("no inheritable constructor in ").append(superclass.getName()).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CannotCompileException(msg);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 66, 104, 130, 104, 103, 103, 99, 104, 170 })]
	private bool isInheritable(int P_0, CtClass P_1)
	{
		if (Modifier.isPrivate(P_0))
		{
			return false;
		}
		if (Modifier.isPackage(P_0))
		{
			string packageName = getPackageName();
			string packageName2 = P_1.getPackageName();
			if (packageName == null)
			{
				return packageName2 == null;
			}
			bool result = String.instancehelper_equals(packageName, packageName2);
			_ = null;
			return result;
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 9, 103, 105 })]
	public override void addConstructor(CtConstructor P_0)
	{
		hasConstructor = true;
		base.addConstructor(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 191, 104, 140, 105 })]
	protected internal override void extendToString(StringBuilder P_0)
	{
		if (hasConstructor)
		{
			P_0.append("hasConstructor ");
		}
		base.extendToString(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException", "java.io.IOException" })]
	[LineNumberTable(new byte[] { 17, 136, 102, 217, 2, 97, 172, 103 })]
	public override void toBytecode(DataOutputStream P_0)
	{
		NotFoundException ex;
		if (!hasConstructor)
		{
			try
			{
				inheritAllConstructors();
				hasConstructor = true;
			}
			catch (NotFoundException x)
			{
				ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_0024;
			}
		}
		base.toBytecode(P_0);
		return;
		IL_0024:
		NotFoundException e = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
	}

	[HideFromJava]
	static CtNewClass()
	{
		CtClassType.___003Cclinit_003E();
	}
}
