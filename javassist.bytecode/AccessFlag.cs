using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace javassist.bytecode;

public class AccessFlag : Object
{
	public const int PUBLIC = 1;

	public const int PRIVATE = 2;

	public const int PROTECTED = 4;

	public const int STATIC = 8;

	public const int FINAL = 16;

	public const int SYNCHRONIZED = 32;

	public const int VOLATILE = 64;

	public const int BRIDGE = 64;

	public const int TRANSIENT = 128;

	public const int VARARGS = 128;

	public const int NATIVE = 256;

	public const int INTERFACE = 512;

	public const int ABSTRACT = 1024;

	public const int STRICT = 2048;

	public const int SYNTHETIC = 4096;

	public const int ANNOTATION = 8192;

	public const int ENUM = 16384;

	public const int MANDATED = 32768;

	public const int SUPER = 32;

	public const int MODULE = 32768;

	public static int toModifier(int accflags)
	{
		return accflags;
	}

	public static int of(int modifier)
	{
		return modifier;
	}

	public static int clear(int accflags, int clearBit)
	{
		return accflags & (clearBit ^ -1);
	}

	public static int setPrivate(int accflags)
	{
		return (accflags & -6) | 2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(23)]
	public AccessFlag()
	{
	}

	public static int setPublic(int accflags)
	{
		return (accflags & -7) | 1;
	}

	public static int setProtected(int accflags)
	{
		return (accflags & -4) | 4;
	}

	public static int setPackage(int accflags)
	{
		return accflags & -8;
	}

	public static bool isPublic(int accflags)
	{
		return (((uint)accflags & (true ? 1u : 0u)) != 0) ? true : false;
	}

	public static bool isProtected(int accflags)
	{
		return (((uint)accflags & 4u) != 0) ? true : false;
	}

	public static bool isPrivate(int accflags)
	{
		return (((uint)accflags & 2u) != 0) ? true : false;
	}

	public static bool isPackage(int accflags)
	{
		return ((accflags & 7) == 0) ? true : false;
	}
}
