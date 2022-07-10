using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace com.github.javaparser.ast;

[Serializable]

public class AccessSpecifier : java.lang.Enum
{
	[Serializable]
	
	public enum __Enum
	{
		PUBLIC,
		PRIVATE,
		PROTECTED,
		NONE
	}

	
	internal static AccessSpecifier ___003C_003EPUBLIC;

	
	internal static AccessSpecifier ___003C_003EPRIVATE;

	
	internal static AccessSpecifier ___003C_003EPROTECTED;

	
	internal static AccessSpecifier ___003C_003ENONE;

	private string codeRepresenation;

	
	private static AccessSpecifier[] _0024VALUES;

	
	public static AccessSpecifier PUBLIC
	{
		
		get
		{
			return ___003C_003EPUBLIC;
		}
	}

	
	public static AccessSpecifier PRIVATE
	{
		
		get
		{
			return ___003C_003EPRIVATE;
		}
	}

	
	public static AccessSpecifier PROTECTED
	{
		
		get
		{
			return ___003C_003EPROTECTED;
		}
	}

	
	public static AccessSpecifier NONE
	{
		
		get
		{
			return ___003C_003ENONE;
		}
	}

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic,
		(Modifiers)0
	})]
	
	private AccessSpecifier(string _0024enum_0024name, int _0024enum_0024ordinal, string codeRepresentation)
		: base(_0024enum_0024name, _0024enum_0024ordinal)
	{
		codeRepresenation = codeRepresentation;
		GC.KeepAlive(this);
	}

	
	
	public static AccessSpecifier[] values()
	{
		return (AccessSpecifier[])_0024VALUES.Clone();
	}

	
	
	
	public static AccessSpecifier valueOf(string name)
	{
		return (AccessSpecifier)java.lang.Enum.valueOf(ClassLiteral<AccessSpecifier>.Value, name);
	}

	public virtual string asString()
	{
		return codeRepresenation;
	}

	
	static AccessSpecifier()
	{
		___003C_003EPUBLIC = new AccessSpecifier("PUBLIC", 0, "public");
		___003C_003EPRIVATE = new AccessSpecifier("PRIVATE", 1, "private");
		___003C_003EPROTECTED = new AccessSpecifier("PROTECTED", 2, "protected");
		___003C_003ENONE = new AccessSpecifier("NONE", 3, "");
		_0024VALUES = new AccessSpecifier[4] { ___003C_003EPUBLIC, ___003C_003EPRIVATE, ___003C_003EPROTECTED, ___003C_003ENONE };
	}
}
