using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;

namespace javassist.bytecode.analysis;

public class MultiArrayType : Type
{
	private MultiType component;

	private int dims;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		42, 119, 130, 119, 130, 119, 130, 104, 130, 104,
		135, 105, 130, 105, 119, 130, 119, 130, 119, 130,
		162
	})]
	public virtual bool isAssignableTo(Type type)
	{
		if (Type.eq(type.getCtClass(), Type.___003C_003EOBJECT.getCtClass()))
		{
			return true;
		}
		if (Type.eq(type.getCtClass(), Type.___003C_003ECLONEABLE.getCtClass()))
		{
			return true;
		}
		if (Type.eq(type.getCtClass(), Type.___003C_003ESERIALIZABLE.getCtClass()))
		{
			return true;
		}
		if (!type.isArray())
		{
			return false;
		}
		Type rootComponent = getRootComponent(type);
		int dimensions = type.getDimensions();
		if (dimensions > dims)
		{
			return false;
		}
		if (dimensions < dims)
		{
			if (Type.eq(rootComponent.getCtClass(), Type.___003C_003EOBJECT.getCtClass()))
			{
				return true;
			}
			if (Type.eq(rootComponent.getCtClass(), Type.___003C_003ECLONEABLE.getCtClass()))
			{
				return true;
			}
			if (Type.eq(rootComponent.getCtClass(), Type.___003C_003ESERIALIZABLE.getCtClass()))
			{
				return true;
			}
			return false;
		}
		bool result = component.isAssignableTo(rootComponent);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 174, 105, 103, 103 })]
	public MultiArrayType(MultiType component, int dims)
		: base(null)
	{
		this.component = component;
		this.dims = dims;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159, 181, 108, 99, 130, 103, 99, 134, 179, 127,
		0, 98
	})]
	public override CtClass getCtClass()
	{
		//Discarded unreachable code: IL_003d
		CtClass ctClass = component.getCtClass();
		if (ctClass == null)
		{
			return null;
		}
		ClassPool classPool = ctClass.getClassPool();
		if (classPool == null)
		{
			classPool = ClassPool.getDefault();
		}
		string classname = arrayName(ctClass.getName(), dims);
		NotFoundException ex;
		try
		{
			return classPool.get(classname);
		}
		catch (NotFoundException x)
		{
			ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		NotFoundException cause = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(cause);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(58)]
	internal override bool popChanged()
	{
		bool result = component.popChanged();
		_ = null;
		return result;
	}

	public override int getDimensions()
	{
		return dims;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(68)]
	public override Type getComponent()
	{
		Type result = ((dims != 1) ? ((Type)new MultiArrayType(component, dims - 1)) : ((Type)component));
		_ = null;
		return result;
	}

	public override int getSize()
	{
		return 1;
	}

	public override bool isArray()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(83)]
	public override bool isAssignableFrom(Type type)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException("Not implemented");
	}

	public override bool isReference()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(129)]
	public override int hashCode()
	{
		return component.hashCode() + dims;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 84, 104, 98, 135 })]
	public override bool equals(object o)
	{
		if (!(o is MultiArrayType))
		{
			return false;
		}
		MultiArrayType multiArrayType = (MultiArrayType)o;
		return (component.equals(multiArrayType.component) && dims == multiArrayType.dims) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(144)]
	public override string toString()
	{
		string result = arrayName(component.toString(), dims);
		_ = null;
		return result;
	}

	[HideFromJava]
	static MultiArrayType()
	{
		Type.___003Cclinit_003E();
	}
}
