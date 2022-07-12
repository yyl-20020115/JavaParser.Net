using System;


using ikvm.@internal;
using java.lang;

namespace com.github.javaparser.symbolsolver.resolution.naming;



public class NameRole : java.lang.Enum
{
	
	
	public enum __Enum
	{
		DECLARATION,
		REFERENCE
	}

	
	internal static NameRole ___003C_003EDECLARATION;

	
	internal static NameRole ___003C_003EREFERENCE;

	
	private static NameRole[] _0024VALUES;

	
	public static NameRole DECLARATION
	{
		
		get
		{
			return ___003C_003EDECLARATION;
		}
	}

	
	public static NameRole REFERENCE
	{
		
		get
		{
			return ___003C_003EREFERENCE;
		}
	}

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
		
	private NameRole(string P_0, int P_1)
		: base(P_0, P_1)
	{
		GC.KeepAlive(this);
	}

	
	
	public static NameRole[] values()
	{
		return (NameRole[])_0024VALUES.Clone();
	}

	
	
	public static NameRole valueOf(string name)
	{
		return (NameRole)java.lang.Enum.valueOf(ClassLiteral<NameRole>.Value, name);
	}

	
	static NameRole()
	{
		___003C_003EDECLARATION = new NameRole("DECLARATION", 0);
		___003C_003EREFERENCE = new NameRole("REFERENCE", 1);
		_0024VALUES = new NameRole[2] { ___003C_003EDECLARATION, ___003C_003EREFERENCE };
	}
}
