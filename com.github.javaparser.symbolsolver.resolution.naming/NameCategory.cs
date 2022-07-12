using System;


using ikvm.@internal;
using java.lang;

namespace com.github.javaparser.symbolsolver.resolution.naming;



public class NameCategory : java.lang.Enum
{
	
	
	public enum __Enum
	{
		MODULE_NAME,
		PACKAGE_NAME,
		TYPE_NAME,
		EXPRESSION_NAME,
		METHOD_NAME,
		PACKAGE_OR_TYPE_NAME,
		AMBIGUOUS_NAME,
		COMPILATION_ERROR
	}

	
	internal static NameCategory ___003C_003EMODULE_NAME;

	
	internal static NameCategory ___003C_003EPACKAGE_NAME;

	
	internal static NameCategory ___003C_003ETYPE_NAME;

	
	internal static NameCategory ___003C_003EEXPRESSION_NAME;

	
	internal static NameCategory ___003C_003EMETHOD_NAME;

	
	internal static NameCategory ___003C_003EPACKAGE_OR_TYPE_NAME;

	
	internal static NameCategory ___003C_003EAMBIGUOUS_NAME;

	
	internal static NameCategory ___003C_003ECOMPILATION_ERROR;

	private bool needDisambiguation;

	
	private static NameCategory[] _0024VALUES;

	
	public static NameCategory MODULE_NAME
	{
		
		get
		{
			return ___003C_003EMODULE_NAME;
		}
	}

	
	public static NameCategory PACKAGE_NAME
	{
		
		get
		{
			return ___003C_003EPACKAGE_NAME;
		}
	}

	
	public static NameCategory TYPE_NAME
	{
		
		get
		{
			return ___003C_003ETYPE_NAME;
		}
	}

	
	public static NameCategory EXPRESSION_NAME
	{
		
		get
		{
			return ___003C_003EEXPRESSION_NAME;
		}
	}

	
	public static NameCategory METHOD_NAME
	{
		
		get
		{
			return ___003C_003EMETHOD_NAME;
		}
	}

	
	public static NameCategory PACKAGE_OR_TYPE_NAME
	{
		
		get
		{
			return ___003C_003EPACKAGE_OR_TYPE_NAME;
		}
	}

	
	public static NameCategory AMBIGUOUS_NAME
	{
		
		get
		{
			return ___003C_003EAMBIGUOUS_NAME;
		}
	}

	
	public static NameCategory COMPILATION_ERROR
	{
		
		get
		{
			return ___003C_003ECOMPILATION_ERROR;
		}
	}

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
		
	private NameCategory(string P_0, int P_1, bool P_2)
		: base(P_0, P_1)
	{
		needDisambiguation = P_2;
		GC.KeepAlive(this);
	}

	
	
	public static NameCategory[] values()
	{
		return (NameCategory[])_0024VALUES.Clone();
	}

	
	
	public static NameCategory valueOf(string name)
	{
		return (NameCategory)java.lang.Enum.valueOf(ClassLiteral<NameCategory>.Value, name);
	}

	public virtual bool isNeedingDisambiguation()
	{
		return needDisambiguation;
	}

	
	
	public virtual bool isNameAcceptable(string name)
	{
		return (this != ___003C_003ETYPE_NAME || !java.lang.String.instancehelper_equals(name, "var")) ? true : false;
	}

	public virtual bool isValid()
	{
		return this != ___003C_003ECOMPILATION_ERROR;
	}

	
	static NameCategory()
	{
		___003C_003EMODULE_NAME = new NameCategory("MODULE_NAME", 0, false);
		___003C_003EPACKAGE_NAME = new NameCategory("PACKAGE_NAME", 1, false);
		___003C_003ETYPE_NAME = new NameCategory("TYPE_NAME", 2, false);
		___003C_003EEXPRESSION_NAME = new NameCategory("EXPRESSION_NAME", 3, false);
		___003C_003EMETHOD_NAME = new NameCategory("METHOD_NAME", 4, false);
		___003C_003EPACKAGE_OR_TYPE_NAME = new NameCategory("PACKAGE_OR_TYPE_NAME", 5, true);
		___003C_003EAMBIGUOUS_NAME = new NameCategory("AMBIGUOUS_NAME", 6, true);
		___003C_003ECOMPILATION_ERROR = new NameCategory("COMPILATION_ERROR", 7, false);
		_0024VALUES = new NameCategory[8] { ___003C_003EMODULE_NAME, ___003C_003EPACKAGE_NAME, ___003C_003ETYPE_NAME, ___003C_003EEXPRESSION_NAME, ___003C_003EMETHOD_NAME, ___003C_003EPACKAGE_OR_TYPE_NAME, ___003C_003EAMBIGUOUS_NAME, ___003C_003ECOMPILATION_ERROR };
	}
}
