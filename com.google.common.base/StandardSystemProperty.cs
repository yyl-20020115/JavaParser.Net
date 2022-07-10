using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using javax.annotation;

namespace com.google.common.@base;

[Serializable]
[Signature("Ljava/lang/Enum<Lcom/google/common/base/StandardSystemProperty;>;")]
[Modifiers(Modifiers.Public | Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
public sealed class StandardSystemProperty : java.lang.Enum
{
	[Serializable]
	[HideFromJava]
	public enum __Enum
	{
		JAVA_VERSION,
		JAVA_VENDOR,
		JAVA_VENDOR_URL,
		JAVA_HOME,
		JAVA_VM_SPECIFICATION_VERSION,
		JAVA_VM_SPECIFICATION_VENDOR,
		JAVA_VM_SPECIFICATION_NAME,
		JAVA_VM_VERSION,
		JAVA_VM_VENDOR,
		JAVA_VM_NAME,
		JAVA_SPECIFICATION_VERSION,
		JAVA_SPECIFICATION_VENDOR,
		JAVA_SPECIFICATION_NAME,
		JAVA_CLASS_VERSION,
		JAVA_CLASS_PATH,
		JAVA_LIBRARY_PATH,
		JAVA_IO_TMPDIR,
		JAVA_COMPILER,
		JAVA_EXT_DIRS,
		OS_NAME,
		OS_ARCH,
		OS_VERSION,
		FILE_SEPARATOR,
		PATH_SEPARATOR,
		LINE_SEPARATOR,
		USER_NAME,
		USER_HOME,
		USER_DIR
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static StandardSystemProperty ___003C_003EJAVA_VERSION;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static StandardSystemProperty ___003C_003EJAVA_VENDOR;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static StandardSystemProperty ___003C_003EJAVA_VENDOR_URL;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static StandardSystemProperty ___003C_003EJAVA_HOME;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static StandardSystemProperty ___003C_003EJAVA_VM_SPECIFICATION_VERSION;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static StandardSystemProperty ___003C_003EJAVA_VM_SPECIFICATION_VENDOR;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static StandardSystemProperty ___003C_003EJAVA_VM_SPECIFICATION_NAME;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static StandardSystemProperty ___003C_003EJAVA_VM_VERSION;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static StandardSystemProperty ___003C_003EJAVA_VM_VENDOR;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static StandardSystemProperty ___003C_003EJAVA_VM_NAME;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static StandardSystemProperty ___003C_003EJAVA_SPECIFICATION_VERSION;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static StandardSystemProperty ___003C_003EJAVA_SPECIFICATION_VENDOR;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static StandardSystemProperty ___003C_003EJAVA_SPECIFICATION_NAME;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static StandardSystemProperty ___003C_003EJAVA_CLASS_VERSION;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static StandardSystemProperty ___003C_003EJAVA_CLASS_PATH;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static StandardSystemProperty ___003C_003EJAVA_LIBRARY_PATH;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static StandardSystemProperty ___003C_003EJAVA_IO_TMPDIR;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static StandardSystemProperty ___003C_003EJAVA_COMPILER;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	[Obsolete]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	internal static StandardSystemProperty ___003C_003EJAVA_EXT_DIRS;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static StandardSystemProperty ___003C_003EOS_NAME;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static StandardSystemProperty ___003C_003EOS_ARCH;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static StandardSystemProperty ___003C_003EOS_VERSION;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static StandardSystemProperty ___003C_003EFILE_SEPARATOR;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static StandardSystemProperty ___003C_003EPATH_SEPARATOR;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static StandardSystemProperty ___003C_003ELINE_SEPARATOR;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static StandardSystemProperty ___003C_003EUSER_NAME;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static StandardSystemProperty ___003C_003EUSER_HOME;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static StandardSystemProperty ___003C_003EUSER_DIR;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private string m_key;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
	private static StandardSystemProperty[] _0024VALUES;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static StandardSystemProperty JAVA_VERSION
	{
		[HideFromJava]
		get
		{
			return ___003C_003EJAVA_VERSION;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static StandardSystemProperty JAVA_VENDOR
	{
		[HideFromJava]
		get
		{
			return ___003C_003EJAVA_VENDOR;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static StandardSystemProperty JAVA_VENDOR_URL
	{
		[HideFromJava]
		get
		{
			return ___003C_003EJAVA_VENDOR_URL;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static StandardSystemProperty JAVA_HOME
	{
		[HideFromJava]
		get
		{
			return ___003C_003EJAVA_HOME;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static StandardSystemProperty JAVA_VM_SPECIFICATION_VERSION
	{
		[HideFromJava]
		get
		{
			return ___003C_003EJAVA_VM_SPECIFICATION_VERSION;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static StandardSystemProperty JAVA_VM_SPECIFICATION_VENDOR
	{
		[HideFromJava]
		get
		{
			return ___003C_003EJAVA_VM_SPECIFICATION_VENDOR;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static StandardSystemProperty JAVA_VM_SPECIFICATION_NAME
	{
		[HideFromJava]
		get
		{
			return ___003C_003EJAVA_VM_SPECIFICATION_NAME;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static StandardSystemProperty JAVA_VM_VERSION
	{
		[HideFromJava]
		get
		{
			return ___003C_003EJAVA_VM_VERSION;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static StandardSystemProperty JAVA_VM_VENDOR
	{
		[HideFromJava]
		get
		{
			return ___003C_003EJAVA_VM_VENDOR;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static StandardSystemProperty JAVA_VM_NAME
	{
		[HideFromJava]
		get
		{
			return ___003C_003EJAVA_VM_NAME;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static StandardSystemProperty JAVA_SPECIFICATION_VERSION
	{
		[HideFromJava]
		get
		{
			return ___003C_003EJAVA_SPECIFICATION_VERSION;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static StandardSystemProperty JAVA_SPECIFICATION_VENDOR
	{
		[HideFromJava]
		get
		{
			return ___003C_003EJAVA_SPECIFICATION_VENDOR;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static StandardSystemProperty JAVA_SPECIFICATION_NAME
	{
		[HideFromJava]
		get
		{
			return ___003C_003EJAVA_SPECIFICATION_NAME;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static StandardSystemProperty JAVA_CLASS_VERSION
	{
		[HideFromJava]
		get
		{
			return ___003C_003EJAVA_CLASS_VERSION;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static StandardSystemProperty JAVA_CLASS_PATH
	{
		[HideFromJava]
		get
		{
			return ___003C_003EJAVA_CLASS_PATH;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static StandardSystemProperty JAVA_LIBRARY_PATH
	{
		[HideFromJava]
		get
		{
			return ___003C_003EJAVA_LIBRARY_PATH;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static StandardSystemProperty JAVA_IO_TMPDIR
	{
		[HideFromJava]
		get
		{
			return ___003C_003EJAVA_IO_TMPDIR;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static StandardSystemProperty JAVA_COMPILER
	{
		[HideFromJava]
		get
		{
			return ___003C_003EJAVA_COMPILER;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static StandardSystemProperty JAVA_EXT_DIRS
	{
		[HideFromJava]
		get
		{
			return ___003C_003EJAVA_EXT_DIRS;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static StandardSystemProperty OS_NAME
	{
		[HideFromJava]
		get
		{
			return ___003C_003EOS_NAME;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static StandardSystemProperty OS_ARCH
	{
		[HideFromJava]
		get
		{
			return ___003C_003EOS_ARCH;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static StandardSystemProperty OS_VERSION
	{
		[HideFromJava]
		get
		{
			return ___003C_003EOS_VERSION;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static StandardSystemProperty FILE_SEPARATOR
	{
		[HideFromJava]
		get
		{
			return ___003C_003EFILE_SEPARATOR;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static StandardSystemProperty PATH_SEPARATOR
	{
		[HideFromJava]
		get
		{
			return ___003C_003EPATH_SEPARATOR;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static StandardSystemProperty LINE_SEPARATOR
	{
		[HideFromJava]
		get
		{
			return ___003C_003ELINE_SEPARATOR;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static StandardSystemProperty USER_NAME
	{
		[HideFromJava]
		get
		{
			return ___003C_003EUSER_NAME;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static StandardSystemProperty USER_HOME
	{
		[HideFromJava]
		get
		{
			return ___003C_003EUSER_HOME;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static StandardSystemProperty USER_DIR
	{
		[HideFromJava]
		get
		{
			return ___003C_003EUSER_DIR;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	public virtual string key()
	{
		return this.m_key;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(158)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual string value()
	{
		string property = java.lang.System.getProperty(this.m_key);
		_ = null;
		return property;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/String;)V")]
	[LineNumberTable(new byte[] { 74, 106, 103 })]
	private StandardSystemProperty(string P_0, int P_1, string P_2)
		: base(P_0, P_1)
	{
		this.m_key = P_2;
		GC.KeepAlive(this);
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(26)]
	private static StandardSystemProperty[] _0024values()
	{
		return new StandardSystemProperty[28]
		{
			___003C_003EJAVA_VERSION, ___003C_003EJAVA_VENDOR, ___003C_003EJAVA_VENDOR_URL, ___003C_003EJAVA_HOME, ___003C_003EJAVA_VM_SPECIFICATION_VERSION, ___003C_003EJAVA_VM_SPECIFICATION_VENDOR, ___003C_003EJAVA_VM_SPECIFICATION_NAME, ___003C_003EJAVA_VM_VERSION, ___003C_003EJAVA_VM_VENDOR, ___003C_003EJAVA_VM_NAME,
			___003C_003EJAVA_SPECIFICATION_VERSION, ___003C_003EJAVA_SPECIFICATION_VENDOR, ___003C_003EJAVA_SPECIFICATION_NAME, ___003C_003EJAVA_CLASS_VERSION, ___003C_003EJAVA_CLASS_PATH, ___003C_003EJAVA_LIBRARY_PATH, ___003C_003EJAVA_IO_TMPDIR, ___003C_003EJAVA_COMPILER, ___003C_003EJAVA_EXT_DIRS, ___003C_003EOS_NAME,
			___003C_003EOS_ARCH, ___003C_003EOS_VERSION, ___003C_003EFILE_SEPARATOR, ___003C_003EPATH_SEPARATOR, ___003C_003ELINE_SEPARATOR, ___003C_003EUSER_NAME, ___003C_003EUSER_HOME, ___003C_003EUSER_DIR
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(26)]
	public static StandardSystemProperty[] values()
	{
		return (StandardSystemProperty[])_0024VALUES.Clone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(26)]
	public static StandardSystemProperty valueOf(string name)
	{
		return (StandardSystemProperty)java.lang.Enum.valueOf(ClassLiteral<StandardSystemProperty>.Value, name);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(164)]
	public override string toString()
	{
		string text = key();
		string text2 = value();
		int num = 1 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
		num = num;
		string result = new StringBuilder(num).append(text).append("=").append(text2)
			.toString();
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[]
	{
		159, 173, 181, 181, 181, 181, 181, 181, 181, 181,
		181, 182, 182, 182, 182, 182, 182, 182, 182, 246,
		74, 214, 182, 182, 182, 182, 182, 182, 182, 182,
		246, 159, 162
	})]
	static StandardSystemProperty()
	{
		___003C_003EJAVA_VERSION = new StandardSystemProperty("JAVA_VERSION", 0, "java.version");
		___003C_003EJAVA_VENDOR = new StandardSystemProperty("JAVA_VENDOR", 1, "java.vendor");
		___003C_003EJAVA_VENDOR_URL = new StandardSystemProperty("JAVA_VENDOR_URL", 2, "java.vendor.url");
		___003C_003EJAVA_HOME = new StandardSystemProperty("JAVA_HOME", 3, "java.home");
		___003C_003EJAVA_VM_SPECIFICATION_VERSION = new StandardSystemProperty("JAVA_VM_SPECIFICATION_VERSION", 4, "java.vm.specification.version");
		___003C_003EJAVA_VM_SPECIFICATION_VENDOR = new StandardSystemProperty("JAVA_VM_SPECIFICATION_VENDOR", 5, "java.vm.specification.vendor");
		___003C_003EJAVA_VM_SPECIFICATION_NAME = new StandardSystemProperty("JAVA_VM_SPECIFICATION_NAME", 6, "java.vm.specification.name");
		___003C_003EJAVA_VM_VERSION = new StandardSystemProperty("JAVA_VM_VERSION", 7, "java.vm.version");
		___003C_003EJAVA_VM_VENDOR = new StandardSystemProperty("JAVA_VM_VENDOR", 8, "java.vm.vendor");
		___003C_003EJAVA_VM_NAME = new StandardSystemProperty("JAVA_VM_NAME", 9, "java.vm.name");
		___003C_003EJAVA_SPECIFICATION_VERSION = new StandardSystemProperty("JAVA_SPECIFICATION_VERSION", 10, "java.specification.version");
		___003C_003EJAVA_SPECIFICATION_VENDOR = new StandardSystemProperty("JAVA_SPECIFICATION_VENDOR", 11, "java.specification.vendor");
		___003C_003EJAVA_SPECIFICATION_NAME = new StandardSystemProperty("JAVA_SPECIFICATION_NAME", 12, "java.specification.name");
		___003C_003EJAVA_CLASS_VERSION = new StandardSystemProperty("JAVA_CLASS_VERSION", 13, "java.class.version");
		___003C_003EJAVA_CLASS_PATH = new StandardSystemProperty("JAVA_CLASS_PATH", 14, "java.class.path");
		___003C_003EJAVA_LIBRARY_PATH = new StandardSystemProperty("JAVA_LIBRARY_PATH", 15, "java.library.path");
		___003C_003EJAVA_IO_TMPDIR = new StandardSystemProperty("JAVA_IO_TMPDIR", 16, "java.io.tmpdir");
		___003C_003EJAVA_COMPILER = new StandardSystemProperty("JAVA_COMPILER", 17, "java.compiler");
		___003C_003EJAVA_EXT_DIRS = new StandardSystemProperty("JAVA_EXT_DIRS", 18, "java.ext.dirs");
		___003C_003EOS_NAME = new StandardSystemProperty("OS_NAME", 19, "os.name");
		___003C_003EOS_ARCH = new StandardSystemProperty("OS_ARCH", 20, "os.arch");
		___003C_003EOS_VERSION = new StandardSystemProperty("OS_VERSION", 21, "os.version");
		___003C_003EFILE_SEPARATOR = new StandardSystemProperty("FILE_SEPARATOR", 22, "file.separator");
		___003C_003EPATH_SEPARATOR = new StandardSystemProperty("PATH_SEPARATOR", 23, "path.separator");
		___003C_003ELINE_SEPARATOR = new StandardSystemProperty("LINE_SEPARATOR", 24, "line.separator");
		___003C_003EUSER_NAME = new StandardSystemProperty("USER_NAME", 25, "user.name");
		___003C_003EUSER_HOME = new StandardSystemProperty("USER_HOME", 26, "user.home");
		___003C_003EUSER_DIR = new StandardSystemProperty("USER_DIR", 27, "user.dir");
		_0024VALUES = _0024values();
	}
}
