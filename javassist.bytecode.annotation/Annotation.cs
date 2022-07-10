using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;

namespace javassist.bytecode.annotation;

public class Annotation : java.lang.Object
{
	internal class Pair : java.lang.Object
	{
		internal int name;

		internal MemberValue value;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(49)]
		internal Pair()
		{
		}
	}

	internal ConstPool pool;

	internal int typeIndex;

	[IKVM.Attributes.Signature("Ljava/util/Map<Ljava/lang/String;Ljavassist/bytecode/annotation/Annotation$Pair;>;")]
	internal Map members;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(236)]
	public virtual string getTypeName()
	{
		string result = Descriptor.toClassName(pool.getUtf8Info(typeIndex));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.ClassNotFoundException", "javassist.bytecode.annotation.NoSuchClassError" })]
	[LineNumberTable(new byte[] { 160, 171, 141, 159, 17, 226, 69, 147, 130 })]
	public virtual object toAnnotationType(ClassLoader cl, ClassPool cp)
	{
		//Discarded unreachable code: IL_0018
		Class @class = MemberValue.loadClass(cl, getTypeName());
		IllegalArgumentException ex;
		java.lang.IllegalAccessError illegalAccessError2;
		try
		{
			try
			{
				return AnnotationImpl.make(cl, @class, cp, this);
			}
			catch (IllegalArgumentException x)
			{
				ex = ByteCodeHelper.MapException<IllegalArgumentException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
		}
		catch (System.Exception x2)
		{
			java.lang.IllegalAccessError illegalAccessError = ByteCodeHelper.MapException<java.lang.IllegalAccessError>(x2, ByteCodeHelper.MapFlags.None);
			if (illegalAccessError == null)
			{
				throw;
			}
			illegalAccessError2 = illegalAccessError;
			goto IL_0039;
		}
		IllegalArgumentException ex2 = ex;
		string name = @class.getName();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new java.lang.ClassNotFoundException(name, ex2);
		IL_0039:
		java.lang.IllegalAccessError ex3 = illegalAccessError2;
		string name2 = @class.getName();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new java.lang.ClassNotFoundException(name2, ex3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		160, 195, 114, 104, 106, 161, 114, 127, 6, 108,
		108, 98
	})]
	public virtual void write(AnnotationsWriter writer)
	{
		string utf8Info = pool.getUtf8Info(typeIndex);
		if (members == null)
		{
			writer.annotation(utf8Info, 0);
			return;
		}
		writer.annotation(utf8Info, members.size());
		Iterator iterator = members.values().iterator();
		while (iterator.hasNext())
		{
			Pair pair = (Pair)iterator.next();
			writer.memberValuePair(pair.name);
			pair.value.write(writer);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 99, 102, 105, 109, 107, 105, 127, 6, 112,
		111, 102, 98, 110, 169
	})]
	public override string toString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.append('@');
		stringBuilder.append(getTypeName());
		if (members != null)
		{
			stringBuilder.append('(');
			Iterator iterator = members.keySet().iterator();
			while (iterator.hasNext())
			{
				string text = (string)iterator.next();
				stringBuilder.append(text).append('=').append(getMemberValue(text))
					.append(", ");
			}
			stringBuilder.setLength(stringBuilder.length() - 2);
			stringBuilder.append(')');
		}
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 21, 104, 103, 103, 103 })]
	public Annotation(int type, ConstPool cp)
	{
		pool = cp;
		typeIndex = type;
		members = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 64, 102, 103, 103, 105 })]
	public virtual void addMemberValue(int nameIndex, MemberValue value)
	{
		Pair pair = new Pair();
		pair.name = nameIndex;
		pair.value = value;
		addMemberValue(pair);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		79, 104, 105, 104, 105, 104, 105, 104, 105, 104,
		105, 104, 105, 104, 105, 104, 105, 114, 105, 114,
		105, 104, 103, 104, 138, 104, 104, 234, 70, 103,
		108
	})]
	public static MemberValue createMemberValue(ConstPool cp, CtClass type)
	{
		if (type == CtClass.booleanType)
		{
			BooleanMemberValue result = new BooleanMemberValue(cp);
			_ = null;
			return result;
		}
		if (type == CtClass.byteType)
		{
			ByteMemberValue result2 = new ByteMemberValue(cp);
			_ = null;
			return result2;
		}
		if (type == CtClass.charType)
		{
			CharMemberValue result3 = new CharMemberValue(cp);
			_ = null;
			return result3;
		}
		if (type == CtClass.shortType)
		{
			ShortMemberValue result4 = new ShortMemberValue(cp);
			_ = null;
			return result4;
		}
		if (type == CtClass.intType)
		{
			IntegerMemberValue result5 = new IntegerMemberValue(cp);
			_ = null;
			return result5;
		}
		if (type == CtClass.longType)
		{
			LongMemberValue result6 = new LongMemberValue(cp);
			_ = null;
			return result6;
		}
		if (type == CtClass.floatType)
		{
			FloatMemberValue result7 = new FloatMemberValue(cp);
			_ = null;
			return result7;
		}
		if (type == CtClass.doubleType)
		{
			DoubleMemberValue result8 = new DoubleMemberValue(cp);
			_ = null;
			return result8;
		}
		if (java.lang.String.instancehelper_equals(type.getName(), "java.lang.Class"))
		{
			ClassMemberValue result9 = new ClassMemberValue(cp);
			_ = null;
			return result9;
		}
		if (java.lang.String.instancehelper_equals(type.getName(), "java.lang.String"))
		{
			StringMemberValue result10 = new StringMemberValue(cp);
			_ = null;
			return result10;
		}
		if (type.isArray())
		{
			CtClass componentType = type.getComponentType();
			MemberValue t = createMemberValue(cp, componentType);
			ArrayMemberValue result11 = new ArrayMemberValue(t, cp);
			_ = null;
			return result11;
		}
		if (type.isInterface())
		{
			Annotation a = new Annotation(cp, type);
			AnnotationMemberValue result12 = new AnnotationMemberValue(a, cp);
			_ = null;
			return result12;
		}
		EnumMemberValue enumMemberValue = new EnumMemberValue(cp);
		enumMemberValue.setType(type.getName());
		return enumMemberValue;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 77, 102, 114, 103, 104, 139, 110 })]
	public virtual void addMemberValue(string name, MemberValue value)
	{
		Pair pair = new Pair();
		pair.name = pool.addUtf8Info(name);
		pair.value = value;
		if (members == null)
		{
			members = new LinkedHashMap();
		}
		members.put(name, pair);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		53, 154, 104, 176, 103, 101, 139, 115, 107, 42,
		37, 168
	})]
	public Annotation(ConstPool cp, CtClass clazz)
		: this(cp.addUtf8Info(Descriptor.of(clazz.getName())), cp)
	{
		if (!clazz.isInterface())
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException("Only interfaces are allowed for Annotation creation.");
		}
		CtMethod[] declaredMethods = clazz.getDeclaredMethods();
		if ((nint)declaredMethods.LongLength > 0)
		{
			members = new LinkedHashMap();
		}
		CtMethod[] array = declaredMethods;
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			CtMethod ctMethod = array[i];
			addMemberValue(ctMethod.getName(), createMemberValue(cp, ctMethod.getReturnType()));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 87, 114, 104, 139, 110 })]
	private void addMemberValue(Pair P_0)
	{
		string utf8Info = pool.getUtf8Info(P_0.name);
		if (members == null)
		{
			members = new LinkedHashMap();
		}
		members.put(utf8Info, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 152, 118, 98 })]
	public virtual MemberValue getMemberValue(string name)
	{
		if (members == null || members.get(name) == null)
		{
			return null;
		}
		return ((Pair)members.get(name)).value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 37, 117 })]
	public Annotation(string typeName, ConstPool cp)
		: this(cp.addUtf8Info(Descriptor.of(typeName)), cp)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("()Ljava/util/Set<Ljava/lang/String;>;")]
	[LineNumberTable(new byte[] { 160, 131, 104, 98 })]
	public virtual Set getMemberNames()
	{
		if (members == null)
		{
			return null;
		}
		Set result = members.keySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 210, 107, 55 })]
	public override int hashCode()
	{
		return java.lang.String.instancehelper_hashCode(getTypeName()) + ((members != null) ? members.hashCode() : 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 220, 100, 98, 107, 130, 135, 115, 130, 103,
		105, 98, 104, 136, 99, 130
	})]
	public override bool equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (obj == null || !(obj is Annotation))
		{
			return false;
		}
		Annotation annotation = (Annotation)obj;
		if (!java.lang.String.instancehelper_equals(getTypeName(), annotation.getTypeName()))
		{
			return false;
		}
		Map map = annotation.members;
		if (members == map)
		{
			return true;
		}
		if (members == null)
		{
			return map == null;
		}
		if (map == null)
		{
			return false;
		}
		bool result = members.equals(map);
		_ = null;
		return result;
	}
}
