using System;

using com.github.javaparser.resolution.declarations;

using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.resolution.types;




public class ResolvedPrimitiveType : java.lang.Enum, ResolvedType
{
	
	
	public enum __Enum
	{
		BYTE,
		SHORT,
		CHAR,
		INT,
		LONG,
		BOOLEAN,
		FLOAT,
		DOUBLE
	}

	
	private sealed class ___003C_003EAnon0 : Predicate
	{
		private readonly ResolvedPrimitiveType arg_00241;

		internal ___003C_003EAnon0(ResolvedPrimitiveType P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = arg_00241.lambda_0024in_00240((ResolvedPrimitiveType)P_0);
			
			return result;
		}

		
		public Predicate and(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public Predicate negate()
		{
			return Predicate._003Cdefault_003Enegate(this);
		}

		
		public Predicate or(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	internal static ResolvedPrimitiveType ___003C_003EBYTE;

	
	internal static ResolvedPrimitiveType ___003C_003ESHORT;

	
	internal static ResolvedPrimitiveType ___003C_003ECHAR;

	
	internal static ResolvedPrimitiveType ___003C_003EINT;

	
	internal static ResolvedPrimitiveType ___003C_003ELONG;

	
	internal static ResolvedPrimitiveType ___003C_003EBOOLEAN;

	
	internal static ResolvedPrimitiveType ___003C_003EFLOAT;

	
	internal static ResolvedPrimitiveType ___003C_003EDOUBLE;

	private new string name;

	private string boxTypeQName;

		private List promotionTypes;

	
	private static ResolvedPrimitiveType[] _0024VALUES;

	
	public static ResolvedPrimitiveType BYTE
	{
		
		get
		{
			return ___003C_003EBYTE;
		}
	}

	
	public static ResolvedPrimitiveType SHORT
	{
		
		get
		{
			return ___003C_003ESHORT;
		}
	}

	
	public static ResolvedPrimitiveType CHAR
	{
		
		get
		{
			return ___003C_003ECHAR;
		}
	}

	
	public static ResolvedPrimitiveType INT
	{
		
		get
		{
			return ___003C_003EINT;
		}
	}

	
	public static ResolvedPrimitiveType LONG
	{
		
		get
		{
			return ___003C_003ELONG;
		}
	}

	
	public static ResolvedPrimitiveType BOOLEAN
	{
		
		get
		{
			return ___003C_003EBOOLEAN;
		}
	}

	
	public static ResolvedPrimitiveType FLOAT
	{
		
		get
		{
			return ___003C_003EFLOAT;
		}
	}

	
	public static ResolvedPrimitiveType DOUBLE
	{
		
		get
		{
			return ___003C_003EDOUBLE;
		}
	}

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
	public static ResolvedPrimitiveType[] getNumericPrimitiveTypes()
	{
		return new ResolvedPrimitiveType[7] { ___003C_003EBYTE, ___003C_003ESHORT, ___003C_003ECHAR, ___003C_003EINT, ___003C_003ELONG, ___003C_003EFLOAT, ___003C_003EDOUBLE };
	}

	
	
	
	public virtual bool isAssignableBy(ResolvedType other)
	{
		if (other.isPrimitive())
		{
			return (this == other || promotionTypes.contains(other)) ? true : false;
		}
		if (other.isReferenceType())
		{
			if (java.lang.String.instancehelper_equals(other.asReferenceType().getQualifiedName(), boxTypeQName))
			{
				return true;
			}
			Iterator iterator = promotionTypes.iterator();
			while (iterator.hasNext())
			{
				ResolvedPrimitiveType resolvedPrimitiveType = (ResolvedPrimitiveType)iterator.next();
				if (java.lang.String.instancehelper_equals(other.asReferenceType().getQualifiedName(), resolvedPrimitiveType.boxTypeQName))
				{
					return true;
				}
			}
			return false;
		}
		return (other.isConstraint() && isAssignableBy(other.asConstraintType().getBound())) ? true : false;
	}

	
	
	public static ResolvedPrimitiveType[] values()
	{
		return (ResolvedPrimitiveType[])_0024VALUES.Clone();
	}

	public virtual string describe()
	{
		return name;
	}

	
	
	
	public virtual bool @in(params ResolvedPrimitiveType[] types)
	{
		bool result = Arrays.stream(types).anyMatch(new ___003C_003EAnon0(this));
		
		return result;
	}

	
		
	
	private ResolvedPrimitiveType(string _0024enum_0024name, int _0024enum_0024ordinal, string name, string boxTypeQName, List promotionTypes)
		: base(_0024enum_0024name, _0024enum_0024ordinal)
	{
		this.name = name;
		this.boxTypeQName = boxTypeQName;
		this.promotionTypes = promotionTypes;
		GC.KeepAlive(this);
	}

	
	
	private bool lambda_0024in_00240(ResolvedPrimitiveType type)
	{
		return this == type;
	}

	
	
	
	public static ResolvedPrimitiveType valueOf(string name)
	{
		return (ResolvedPrimitiveType)java.lang.Enum.valueOf(ClassLiteral<ResolvedPrimitiveType>.Value, name);
	}

	
	
	
	public static ResolvedType byName(string name)
	{
		name = java.lang.String.instancehelper_toLowerCase(name);
		ResolvedPrimitiveType[] array = values();
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			ResolvedPrimitiveType resolvedPrimitiveType = array[i];
			if (java.lang.String.instancehelper_equals(resolvedPrimitiveType.describe(), name))
			{
				return resolvedPrimitiveType;
			}
		}
		string s = new StringBuilder().append("Name ").append(name).ToString();
		
		throw new IllegalArgumentException(s);
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("PrimitiveTypeUsage{name='").append(name).append('\'')
			.append('}')
			.ToString();
		
		return result;
	}

	public virtual ResolvedPrimitiveType asPrimitive()
	{
		return this;
	}

	public virtual bool isArray()
	{
		return false;
	}

	public virtual bool isPrimitive()
	{
		return true;
	}

	public virtual bool isReferenceType()
	{
		return false;
	}

	public virtual bool isTypeVariable()
	{
		return false;
	}

	public virtual string getBoxTypeQName()
	{
		return boxTypeQName;
	}

	public virtual bool isNumeric()
	{
		return this != ___003C_003EBOOLEAN;
	}

	public virtual bool isBoolean()
	{
		return this == ___003C_003EBOOLEAN;
	}

	
	public virtual ResolvedPrimitiveType bnp(ResolvedPrimitiveType other)
	{
		if (this == ___003C_003EDOUBLE || other == ___003C_003EDOUBLE)
		{
			return ___003C_003EDOUBLE;
		}
		if (this == ___003C_003EFLOAT || other == ___003C_003EFLOAT)
		{
			return ___003C_003EFLOAT;
		}
		if (this == ___003C_003ELONG || other == ___003C_003ELONG)
		{
			return ___003C_003ELONG;
		}
		return ___003C_003EINT;
	}

	
	
	
	public static ResolvedType unp(ResolvedType type)
	{
		int num = ((type.isReferenceType() && type.asReferenceType().isUnboxable()) ? 1 : 0);
		if (num != 0 && ((ResolvedPrimitiveType)type.asReferenceType().toUnboxedType().get()).@in(___003C_003EBYTE, ___003C_003ESHORT, ___003C_003ECHAR, ___003C_003EINT))
		{
			return ___003C_003EINT;
		}
		if (num != 0 && ((ResolvedPrimitiveType)type.asReferenceType().toUnboxedType().get()).@in(___003C_003ELONG, ___003C_003EFLOAT, ___003C_003EDOUBLE))
		{
			return (ResolvedType)type.asReferenceType().toUnboxedType().get();
		}
		if (type.isPrimitive() && type.asPrimitive().@in(___003C_003EBYTE, ___003C_003ECHAR, ___003C_003ESHORT))
		{
			return ___003C_003EINT;
		}
		return type;
	}

	
	static ResolvedPrimitiveType()
	{
		___003C_003EBYTE = new ResolvedPrimitiveType("BYTE", 0, "byte", ClassLiteral<java.lang.Byte>.Value.getCanonicalName(), Collections.emptyList());
		___003C_003ESHORT = new ResolvedPrimitiveType("SHORT", 1, "short", ClassLiteral<Short>.Value.getCanonicalName(), Collections.singletonList(___003C_003EBYTE));
		___003C_003ECHAR = new ResolvedPrimitiveType("CHAR", 2, "char", ClassLiteral<Character>.Value.getCanonicalName(), Collections.emptyList());
		___003C_003EINT = new ResolvedPrimitiveType("INT", 3, "int", ClassLiteral<Integer>.Value.getCanonicalName(), Arrays.asList(___003C_003EBYTE, ___003C_003ESHORT, ___003C_003ECHAR));
		___003C_003ELONG = new ResolvedPrimitiveType("LONG", 4, "long", ClassLiteral<Long>.Value.getCanonicalName(), Arrays.asList(___003C_003EBYTE, ___003C_003ESHORT, ___003C_003EINT, ___003C_003ECHAR));
		___003C_003EBOOLEAN = new ResolvedPrimitiveType("BOOLEAN", 5, "boolean", ClassLiteral<java.lang.Boolean>.Value.getCanonicalName(), Collections.emptyList());
		___003C_003EFLOAT = new ResolvedPrimitiveType("FLOAT", 6, "float", ClassLiteral<Float>.Value.getCanonicalName(), Arrays.asList(___003C_003ELONG, ___003C_003EINT, ___003C_003ESHORT, ___003C_003EBYTE, ___003C_003ECHAR));
		___003C_003EDOUBLE = new ResolvedPrimitiveType("DOUBLE", 7, "double", ClassLiteral<java.lang.Double>.Value.getCanonicalName(), Arrays.asList(___003C_003EFLOAT, ___003C_003ELONG, ___003C_003EINT, ___003C_003ESHORT, ___003C_003EBYTE, ___003C_003ECHAR));
		_0024VALUES = new ResolvedPrimitiveType[8] { ___003C_003EBYTE, ___003C_003ESHORT, ___003C_003ECHAR, ___003C_003EINT, ___003C_003ELONG, ___003C_003EBOOLEAN, ___003C_003EFLOAT, ___003C_003EDOUBLE };
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual int arrayLevel()
	{
		return ResolvedType._003Cdefault_003EarrayLevel(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isNull()
	{
		return ResolvedType._003Cdefault_003EisNull(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isUnionType()
	{
		return ResolvedType._003Cdefault_003EisUnionType(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isReference()
	{
		return ResolvedType._003Cdefault_003EisReference(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isConstraint()
	{
		return ResolvedType._003Cdefault_003EisConstraint(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isVoid()
	{
		return ResolvedType._003Cdefault_003EisVoid(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isWildcard()
	{
		return ResolvedType._003Cdefault_003EisWildcard(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isInferenceVariable()
	{
		return ResolvedType._003Cdefault_003EisInferenceVariable(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedArrayType asArrayType()
	{
		return ResolvedType._003Cdefault_003EasArrayType(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedReferenceType asReferenceType()
	{
		return ResolvedType._003Cdefault_003EasReferenceType(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedTypeParameterDeclaration asTypeParameter()
	{
		return ResolvedType._003Cdefault_003EasTypeParameter(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedTypeVariable asTypeVariable()
	{
		return ResolvedType._003Cdefault_003EasTypeVariable(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedWildcard asWildcard()
	{
		return ResolvedType._003Cdefault_003EasWildcard(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedLambdaConstraintType asConstraintType()
	{
		return ResolvedType._003Cdefault_003EasConstraintType(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedUnionType asUnionType()
	{
		return ResolvedType._003Cdefault_003EasUnionType(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedType replaceTypeVariables(ResolvedTypeParameterDeclaration P_0, ResolvedType P_1, Map P_2)
	{
		return ResolvedType._003Cdefault_003EreplaceTypeVariables(this, P_0, P_1, P_2);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedType replaceTypeVariables(ResolvedTypeParameterDeclaration P_0, ResolvedType P_1)
	{
		return ResolvedType._003Cdefault_003EreplaceTypeVariables(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool mention(List P_0)
	{
		return ResolvedType._003Cdefault_003Emention(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isNumericType()
	{
		return ResolvedType._003Cdefault_003EisNumericType(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedType erasure()
	{
		return ResolvedType._003Cdefault_003Eerasure(this);
	}
}
