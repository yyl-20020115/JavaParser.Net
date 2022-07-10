using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using javassist.bytecode;
using javassist.convert;

namespace javassist;

public class CodeConverter : Object
{
	public interface ArrayAccessReplacementMethodNames
	{
		virtual string byteOrBooleanRead();

		virtual string byteOrBooleanWrite();

		virtual string charRead();

		virtual string charWrite();

		virtual string doubleRead();

		virtual string doubleWrite();

		virtual string floatRead();

		virtual string floatWrite();

		virtual string intRead();

		virtual string intWrite();

		virtual string longRead();

		virtual string longWrite();

		virtual string objectRead();

		virtual string objectWrite();

		virtual string shortRead();

		virtual string shortWrite();
	}

	public class DefaultArrayAccessReplacementMethodNames : Object, ArrayAccessReplacementMethodNames
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(712)]
		public DefaultArrayAccessReplacementMethodNames()
		{
		}

		public virtual string byteOrBooleanRead()
		{
			return "arrayReadByteOrBoolean";
		}

		public virtual string byteOrBooleanWrite()
		{
			return "arrayWriteByteOrBoolean";
		}

		public virtual string charRead()
		{
			return "arrayReadChar";
		}

		public virtual string charWrite()
		{
			return "arrayWriteChar";
		}

		public virtual string doubleRead()
		{
			return "arrayReadDouble";
		}

		public virtual string doubleWrite()
		{
			return "arrayWriteDouble";
		}

		public virtual string floatRead()
		{
			return "arrayReadFloat";
		}

		public virtual string floatWrite()
		{
			return "arrayWriteFloat";
		}

		public virtual string intRead()
		{
			return "arrayReadInt";
		}

		public virtual string intWrite()
		{
			return "arrayWriteInt";
		}

		public virtual string longRead()
		{
			return "arrayReadLong";
		}

		public virtual string longWrite()
		{
			return "arrayWriteLong";
		}

		public virtual string objectRead()
		{
			return "arrayReadObject";
		}

		public virtual string objectWrite()
		{
			return "arrayWriteObject";
		}

		public virtual string shortRead()
		{
			return "arrayReadShort";
		}

		public virtual string shortWrite()
		{
			return "arrayWriteShort";
		}
	}

	protected internal Transformer transformers;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 14, 104 })]
	public CodeConverter()
	{
		transformers = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 61, 110, 112 })]
	public virtual void replaceNew(CtClass newClass, CtClass calledClass, string calledMethod)
	{
		transformers = new TransformNew(transformers, newClass.getName(), calledClass.getName(), calledMethod);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 87, 110, 111 })]
	public virtual void replaceNew(CtClass oldClass, CtClass newClass)
	{
		transformers = new TransformNewClass(transformers, oldClass.getName(), newClass.getName());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 110, 105, 144 })]
	public virtual void redirectFieldAccess(CtField field, CtClass newClass, string newFieldname)
	{
		transformers = new TransformFieldAccess(transformers, field, newClass.getName(), newFieldname);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 86, 105, 144 })]
	public virtual void replaceFieldRead(CtField field, CtClass calledClass, string calledMethod)
	{
		transformers = new TransformReadField(transformers, field, calledClass.getName(), calledMethod);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 127, 105, 144 })]
	public virtual void replaceFieldWrite(CtField field, CtClass calledClass, string calledMethod)
	{
		transformers = new TransformWriteField(transformers, field, calledClass.getName(), calledMethod);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 160, 230, 120 })]
	public virtual void replaceArrayAccess(CtClass calledClass, ArrayAccessReplacementMethodNames names)
	{
		transformers = new TransformAccessArrayField(transformers, calledClass.getName(), names);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		160, 252, 108, 108, 105, 112, 154, 103, 103, 111,
		112, 107, 108, 112, 154, 147
	})]
	public virtual void redirectMethodCall(CtMethod origMethod, CtMethod substMethod)
	{
		string descriptor = origMethod.getMethodInfo2().getDescriptor();
		string descriptor2 = substMethod.getMethodInfo2().getDescriptor();
		if (!String.instancehelper_equals(descriptor, descriptor2))
		{
			string msg = new StringBuilder().append("signature mismatch: ").append(substMethod.getLongName()).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CannotCompileException(msg);
		}
		int modifiers = origMethod.getModifiers();
		int modifiers2 = substMethod.getModifiers();
		if (Modifier.isStatic(modifiers) != Modifier.isStatic(modifiers2) || (Modifier.isPrivate(modifiers) && !Modifier.isPrivate(modifiers2)) || origMethod.getDeclaringClass().isInterface() != substMethod.getDeclaringClass().isInterface())
		{
			string msg2 = new StringBuilder().append("invoke-type mismatch ").append(substMethod.getLongName()).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CannotCompileException(msg2);
		}
		transformers = new TransformCall(transformers, origMethod, substMethod);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 161, 36, 147 })]
	public virtual void redirectMethodCall(string oldMethodName, CtMethod newMethod)
	{
		transformers = new TransformCall(transformers, oldMethodName, newMethod);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 72, 147 })]
	public virtual void redirectMethodCallToStatic(CtMethod origMethod, CtMethod staticMethod)
	{
		transformers = new TransformCallToStatic(transformers, origMethod, staticMethod);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		161,
		115,
		byte.MaxValue,
		6,
		69,
		2,
		97,
		140
	})]
	public virtual void insertBeforeMethod(CtMethod origMethod, CtMethod beforeMethod)
	{
		NotFoundException ex;
		try
		{
			transformers = new TransformBefore(transformers, origMethod, beforeMethod);
			return;
		}
		catch (NotFoundException x)
		{
			ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		NotFoundException e = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		161,
		163,
		byte.MaxValue,
		6,
		69,
		2,
		97,
		140
	})]
	public virtual void insertAfterMethod(CtMethod origMethod, CtMethod afterMethod)
	{
		NotFoundException ex;
		try
		{
			transformers = new TransformAfter(transformers, origMethod, afterMethod);
			return;
		}
		catch (NotFoundException x)
		{
			ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		NotFoundException e = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		161, 178, 103, 107, 97, 106, 41, 169, 103, 139,
		103, 106, 43, 251, 69, 2, 98, 205, 98, 99,
		106, 104, 101, 131, 104, 102, 228, 57, 233, 74,
		106, 38, 169, 100, 142, 101, 175, 104, 37, 249,
		69, 2, 98, 148
	})]
	protected internal virtual void doit(CtClass clazz, MethodInfo minfo, ConstPool cp)
	{
		CodeAttribute codeAttribute = minfo.getCodeAttribute();
		if (codeAttribute == null || transformers == null)
		{
			return;
		}
		for (Transformer next = transformers; next != null; next = next.getNext())
		{
			next.initialize(cp, clazz, minfo);
		}
		CodeIterator codeIterator = codeAttribute.iterator();
		int i;
		while (codeIterator.hasNext())
		{
			BadBytecode badBytecode;
			try
			{
				i = codeIterator.next();
				for (Transformer next = transformers; next != null; next = next.getNext())
				{
					i = next.transform(clazz, i, codeIterator, cp);
				}
			}
			catch (BadBytecode x)
			{
				badBytecode = ByteCodeHelper.MapException<BadBytecode>(x, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_0074;
			}
			continue;
			IL_0074:
			BadBytecode e = badBytecode;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CannotCompileException(e);
		}
		i = 0;
		int num = 0;
		for (Transformer next = transformers; next != null; next = next.getNext())
		{
			int num2 = next.extraLocals();
			if (num2 > i)
			{
				i = num2;
			}
			num2 = next.extraStack();
			if (num2 > num)
			{
				num = num2;
			}
		}
		for (Transformer next = transformers; next != null; next = next.getNext())
		{
			next.clean();
		}
		if (i > 0)
		{
			codeAttribute.setMaxLocals(codeAttribute.getMaxLocals() + i);
		}
		if (num > 0)
		{
			codeAttribute.setMaxStack(codeAttribute.getMaxStack() + num);
		}
		BadBytecode badBytecode2;
		try
		{
			minfo.rebuildStackMapIf6(clazz.getClassPool(), clazz.getClassFile2());
			return;
		}
		catch (BadBytecode x2)
		{
			badBytecode2 = ByteCodeHelper.MapException<BadBytecode>(x2, ByteCodeHelper.MapFlags.NoRemapping);
		}
		BadBytecode badBytecode3 = badBytecode2;
		string msg = Throwable.instancehelper_getMessage(badBytecode3);
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(msg, badBytecode3);
	}
}
