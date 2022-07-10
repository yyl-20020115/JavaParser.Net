using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using javassist.bytecode;

namespace javassist;

public sealed class CtMethod : CtBehavior
{
	public class ConstParameter : Object
	{
		internal static string defaultDescriptor()
		{
			return "([Ljava/lang/Object;)Ljava/lang/Object;";
		}

		internal static string defaultConstDescriptor()
		{
			return "([Ljava/lang/Object;)V";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(332)]
		public static ConstParameter integer(int i)
		{
			IntConstParameter result = new IntConstParameter(i);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(341)]
		public static ConstParameter integer(long i)
		{
			LongConstParameter result = new LongConstParameter(i);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(350)]
		public static ConstParameter @string(string s)
		{
			StringConstParameter result = new StringConstParameter(s);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(353)]
		internal ConstParameter()
		{
		}

		[Throws(new string[] { "javassist.CannotCompileException" })]
		internal virtual int compile(Bytecode P_0)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(363)]
		internal virtual string descriptor()
		{
			string result = defaultDescriptor();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(379)]
		internal virtual string constDescriptor()
		{
			string result = defaultConstDescriptor();
			_ = null;
			return result;
		}
	}

	internal class IntConstParameter : ConstParameter
	{
		internal int param;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 23, 104, 103 })]
		internal IntConstParameter(int P_0)
		{
			param = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.CannotCompileException" })]
		[LineNumberTable(new byte[] { 161, 29, 108 })]
		internal override int compile(Bytecode P_0)
		{
			P_0.addIconst(param);
			return 1;
		}

		internal override string descriptor()
		{
			return "([Ljava/lang/Object;I)Ljava/lang/Object;";
		}

		internal override string constDescriptor()
		{
			return "([Ljava/lang/Object;I)V";
		}
	}

	internal class LongConstParameter : ConstParameter
	{
		internal long param;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 47, 104, 103 })]
		internal LongConstParameter(long P_0)
		{
			param = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.CannotCompileException" })]
		[LineNumberTable(new byte[] { 161, 53, 108 })]
		internal override int compile(Bytecode P_0)
		{
			P_0.addLconst(param);
			return 2;
		}

		internal override string descriptor()
		{
			return "([Ljava/lang/Object;J)Ljava/lang/Object;";
		}

		internal override string constDescriptor()
		{
			return "([Ljava/lang/Object;J)V";
		}
	}

	internal class StringConstParameter : ConstParameter
	{
		internal string param;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 71, 104, 103 })]
		internal StringConstParameter(string P_0)
		{
			param = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.CannotCompileException" })]
		[LineNumberTable(new byte[] { 161, 77, 108 })]
		internal override int compile(Bytecode P_0)
		{
			P_0.addLdc(param);
			return 1;
		}

		internal override string descriptor()
		{
			return "([Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;";
		}

		internal override string constDescriptor()
		{
			return "([Ljava/lang/Object;Ljava/lang/String;)V";
		}
	}

	protected internal string cachedStringRep;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(217)]
	public override string getName()
	{
		string name = methodInfo.getName();
		_ = null;
		return name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 94, 127, 1, 63, 2 })]
	public override string getLongName()
	{
		string result = new StringBuilder().append(base.getDeclaringClass().getName()).append(".").append(getName())
			.append(Descriptor.toString(getSignature()))
			.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 188, 106, 103 })]
	internal CtMethod(MethodInfo P_0, CtClass P_1)
		: base(P_1, P_0)
	{
		cachedStringRep = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 69, 104, 124, 153 })]
	internal string getStringRep()
	{
		if (cachedStringRep == null)
		{
			cachedStringRep = new StringBuilder().append(methodInfo.getName()).append(Descriptor.getParamDescriptor(methodInfo.getDescriptor())).toString();
		}
		return cachedStringRep;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 110, 107, 110 })]
	public virtual void setName(string newname)
	{
		declaringClass.checkModify();
		methodInfo.setName(newname);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(232)]
	public virtual CtClass getReturnType()
	{
		CtClass returnType = base.getReturnType0();
		_ = null;
		return returnType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 13, 107, 109, 104, 110, 109 })]
	public CtMethod(CtClass returnType, string mname, CtClass[] parameters, CtClass declaring)
		: this(null, declaring)
	{
		ConstPool constPool = declaring.getClassFile2().getConstPool();
		string desc = Descriptor.ofMethod(returnType, parameters);
		methodInfo = new MethodInfo(constPool, mname, desc);
		setModifiers(1025);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 73, 106, 107 })]
	public CtMethod(CtMethod src, CtClass declaring, ClassMap map)
		: this(null, declaring)
	{
		base.copy(src, false, map);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(140)]
	public static CtMethod make(string src, CtClass declaring)
	{
		CtMethod result = CtNewMethod.make(src, declaring);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 105, 115, 144 })]
	public static CtMethod make(MethodInfo minfo, CtClass declaring)
	{
		if (declaring.getClassFile2().getConstPool() != minfo.getConstPool())
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CannotCompileException("bad declaring class");
		}
		CtMethod result = new CtMethod(minfo, declaring);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(168)]
	public override int hashCode()
	{
		int result = String.instancehelper_hashCode(getStringRep());
		_ = null;
		return result;
	}

	internal override void nameReplaced()
	{
		cachedStringRep = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 82, 113, 54 })]
	public override bool equals(object obj)
	{
		return (obj != null && obj is CtMethod && String.instancehelper_equals(((CtMethod)obj).getStringRep(), getStringRep())) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 127, 108, 99, 147, 135, 124, 57, 161, 97 })]
	public override bool isEmpty()
	{
		//Discarded unreachable code: IL_0052
		CodeAttribute codeAttribute = base.getMethodInfo2().getCodeAttribute();
		if (codeAttribute == null)
		{
			return (((uint)getModifiers() & 0x400u) != 0) ? true : false;
		}
		CodeIterator codeIterator = codeAttribute.iterator();
		try
		{
			return (codeIterator.hasNext() && codeIterator.byteAt(codeIterator.next()) == 177 && !codeIterator.hasNext()) ? true : false;
		}
		catch (BadBytecode)
		{
		}
		_ = null;
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 160, 157, 159, 1 })]
	public virtual void setBody(CtMethod src, ClassMap map)
	{
		CtBehavior.setBody0(src.declaringClass, src.methodInfo, declaringClass, methodInfo, map);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		160, 175, 139, 199, 103, 217, 2, 98, 173, 98,
		41, 231, 69, 105, 109, 188
	})]
	public virtual void setWrappedBody(CtMethod mbody, ConstParameter constParam)
	{
		declaringClass.checkModify();
		CtClass ctClass = base.getDeclaringClass();
		CtClass[] parameterTypes;
		CtClass returnType;
		NotFoundException ex;
		try
		{
			parameterTypes = base.getParameterTypes();
			returnType = getReturnType();
		}
		catch (NotFoundException x)
		{
			ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_002f;
		}
		Bytecode bytecode = CtNewWrappedMethod.makeBody(ctClass, ctClass.getClassFile2(), mbody, parameterTypes, returnType, constParam);
		CodeAttribute codeAttribute = bytecode.toCodeAttribute();
		methodInfo.setCodeAttribute(codeAttribute);
		methodInfo.setAccessFlags(methodInfo.getAccessFlags() & -1025);
		return;
		IL_002f:
		NotFoundException e = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
	}
}
