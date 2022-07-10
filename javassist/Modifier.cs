using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.lang.reflect;

namespace javassist;

public class Modifier : Object
{
	public const int PUBLIC = 1;

	public const int PRIVATE = 2;

	public const int PROTECTED = 4;

	public const int STATIC = 8;

	public const int FINAL = 16;

	public const int SYNCHRONIZED = 32;

	public const int VOLATILE = 64;

	public const int VARARGS = 128;

	public const int TRANSIENT = 128;

	public const int NATIVE = 256;

	public const int INTERFACE = 512;

	public const int ABSTRACT = 1024;

	public const int STRICT = 2048;

	public const int ANNOTATION = 8192;

	public const int ENUM = 16384;

	public static bool isStatic(int mod)
	{
		return (((uint)mod & 8u) != 0) ? true : false;
	}

	public static bool isPrivate(int mod)
	{
		return (((uint)mod & 2u) != 0) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(225)]
	public static string toString(int mod)
	{
		string result = java.lang.reflect.Modifier.toString(mod);
		_ = null;
		return result;
	}

	public static bool isPublic(int mod)
	{
		return (((uint)mod & (true ? 1u : 0u)) != 0) ? true : false;
	}

	public static bool isProtected(int mod)
	{
		return (((uint)mod & 4u) != 0) ? true : false;
	}

	public static bool isInterface(int mod)
	{
		return (((uint)mod & 0x200u) != 0) ? true : false;
	}

	public static bool isAnnotation(int mod)
	{
		return (((uint)mod & 0x2000u) != 0) ? true : false;
	}

	public static bool isEnum(int mod)
	{
		return (((uint)mod & 0x4000u) != 0) ? true : false;
	}

	public static bool isFinal(int mod)
	{
		return (((uint)mod & 0x10u) != 0) ? true : false;
	}

	public static bool isAbstract(int mod)
	{
		return (((uint)mod & 0x400u) != 0) ? true : false;
	}

	public static int setPublic(int mod)
	{
		return (mod & -7) | 1;
	}

	public static bool isPackage(int mod)
	{
		return ((mod & 7) == 0) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(31)]
	public Modifier()
	{
	}

	public static bool isSynchronized(int mod)
	{
		return (((uint)mod & 0x20u) != 0) ? true : false;
	}

	public static bool isVolatile(int mod)
	{
		return (((uint)mod & 0x40u) != 0) ? true : false;
	}

	public static bool isTransient(int mod)
	{
		return (((uint)mod & 0x80u) != 0) ? true : false;
	}

	public static bool isNative(int mod)
	{
		return (((uint)mod & 0x100u) != 0) ? true : false;
	}

	public static bool isStrict(int mod)
	{
		return (((uint)mod & 0x800u) != 0) ? true : false;
	}

	public static bool isVarArgs(int mod)
	{
		return (((uint)mod & 0x80u) != 0) ? true : false;
	}

	public static int setProtected(int mod)
	{
		return (mod & -4) | 4;
	}

	public static int setPrivate(int mod)
	{
		return (mod & -6) | 2;
	}

	public static int setPackage(int mod)
	{
		return mod & -8;
	}

	public static int clear(int mod, int clearBit)
	{
		return mod & (clearBit ^ -1);
	}
}
