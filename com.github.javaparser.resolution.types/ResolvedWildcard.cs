using System;
using System.Runtime.CompilerServices;
using com.github.javaparser.resolution.declarations;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util;

namespace com.github.javaparser.resolution.types;

public class ResolvedWildcard :  ResolvedType
{
	[Serializable]
	[InnerClass(null, Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		
	public class BoundType : java.lang.Enum
	{
		[Serializable]
		
		public enum __Enum
		{
			SUPER,
			EXTENDS
		}

		
		internal static BoundType ___003C_003ESUPER;

		
		internal static BoundType ___003C_003EEXTENDS;

		
		private static BoundType[] _0024VALUES;

		
		public static BoundType SUPER
		{
			
			get
			{
				return ___003C_003ESUPER;
			}
		}

		
		public static BoundType EXTENDS
		{
			
			get
			{
				return ___003C_003EEXTENDS;
			}
		}

		
		
		public static void ___003Cclinit_003E()
		{
		}

		
				[MethodParameters(new Modifiers[]
		{
			Modifiers.Synthetic,
			Modifiers.Synthetic
		})]
		
		private BoundType(string _0024enum_0024name, int _0024enum_0024ordinal)
			: base(_0024enum_0024name, _0024enum_0024ordinal)
		{
			GC.KeepAlive(this);
		}

		
		
		public static BoundType[] values()
		{
			return (BoundType[])_0024VALUES.Clone();
		}

		
		
		
		public static BoundType valueOf(string name)
		{
			return (BoundType)java.lang.Enum.valueOf(ClassLiteral<BoundType>.Value, name);
		}

		
		static BoundType()
		{
			___003C_003ESUPER = new BoundType("SUPER", 0);
			___003C_003EEXTENDS = new BoundType("EXTENDS", 1);
			_0024VALUES = new BoundType[2] { ___003C_003ESUPER, ___003C_003EEXTENDS };
		}
	}

	public static ResolvedWildcard UNBOUNDED;

	private BoundType type;

	private ResolvedType boundedType;

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
	
	public virtual bool isBounded()
	{
		return (isSuper() || isExtends()) ? true : false;
	}

	
	
	public virtual bool isExtends()
	{
		return type == BoundType.___003C_003EEXTENDS;
	}

	
	
	public virtual ResolvedType getBoundedType()
	{
		if (boundedType == null)
		{
			
			throw new IllegalStateException();
		}
		return boundedType;
	}

	
	
	
	public static ResolvedWildcard extendsBound(ResolvedType type)
	{
		ResolvedWildcard result = new ResolvedWildcard(BoundType.___003C_003EEXTENDS, type);
		
		return result;
	}

	
	
	
	public static ResolvedWildcard superBound(ResolvedType type)
	{
		ResolvedWildcard result = new ResolvedWildcard(BoundType.___003C_003ESUPER, type);
		
		return result;
	}

	
	
	public virtual bool isSuper()
	{
		return type == BoundType.___003C_003ESUPER;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	private ResolvedWildcard(BoundType type, ResolvedType boundedType)
	{
		if (type == null && boundedType != null)
		{
			
			throw new IllegalArgumentException();
		}
		if (type != null && boundedType == null)
		{
			
			throw new IllegalArgumentException();
		}
		this.type = type;
		this.boundedType = boundedType;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("WildcardUsage{type=").append(type).append(", boundedType=")
			.append(boundedType)
			.append('}')
			.ToString();
		
		return result;
	}

	public virtual bool isWildcard()
	{
		return true;
	}

	public virtual ResolvedWildcard asWildcard()
	{
		return this;
	}

	
	
	
	public override bool Equals(object o)
	{
		if (this == o)
		{
			return true;
		}
		if (!(o is ResolvedWildcard))
		{
			return false;
		}
		ResolvedWildcard resolvedWildcard = (ResolvedWildcard)o;
		if (boundedType != null)
		{
			if (!java.lang.Object.instancehelper_equals(boundedType, resolvedWildcard.boundedType))
			{
				goto IL_003c;
			}
		}
		else if (resolvedWildcard.boundedType != null)
		{
			goto IL_003c;
		}
		if (type != resolvedWildcard.type)
		{
			return false;
		}
		return true;
		IL_003c:
		return false;
	}

	
	
	public override int GetHashCode()
	{
		int num = ((type != null) ? type.GetHashCode() : 0);
		return 31 * num + ((boundedType != null) ? java.lang.Object.instancehelper_hashCode(boundedType) : 0);
	}

	
	
	public virtual string describe()
	{
		if (type == null)
		{
			return "?";
		}
		if (type == BoundType.___003C_003ESUPER)
		{
			string result = new StringBuilder().append("? super ").append(boundedType.describe()).ToString();
			
			return result;
		}
		if (type == BoundType.___003C_003EEXTENDS)
		{
			string result2 = new StringBuilder().append("? extends ").append(boundedType.describe()).ToString();
			
			return result2;
		}
		
		throw new UnsupportedOperationException();
	}

	
	
	
	public virtual bool isAssignableBy(ResolvedType other)
	{
		if (boundedType == null)
		{
			return false;
		}
		if (type == BoundType.___003C_003ESUPER)
		{
			bool result = boundedType.isAssignableBy(other);
			
			return result;
		}
		if (type == BoundType.___003C_003EEXTENDS)
		{
			return false;
		}
		
		throw new RuntimeException();
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual ResolvedType replaceTypeVariables(ResolvedTypeParameterDeclaration tpToReplace, ResolvedType replaced, Map inferredTypes)
	{
		if (replaced == null)
		{
			
			throw new IllegalArgumentException();
		}
		if (boundedType == null)
		{
			return this;
		}
		ResolvedType resolvedType = boundedType.replaceTypeVariables(tpToReplace, replaced, inferredTypes);
		if (resolvedType == null)
		{
			
			throw new RuntimeException();
		}
		if (resolvedType != boundedType)
		{
			ResolvedWildcard result = new ResolvedWildcard(type, resolvedType);
			
			return result;
		}
		return this;
	}

	
		
	
	public virtual bool mention(List typeParameters)
	{
		return (boundedType != null && boundedType.mention(typeParameters)) ? true : false;
	}

	
	
	public virtual bool isUpperBounded()
	{
		bool result = isSuper();
		
		return result;
	}

	
	
	public virtual bool isLowerBounded()
	{
		bool result = isExtends();
		
		return result;
	}

	
	static ResolvedWildcard()
	{
		UNBOUNDED = new ResolvedWildcard(null, null);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isArray()
	{
		return ResolvedType._003Cdefault_003EisArray(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual int arrayLevel()
	{
		return ResolvedType._003Cdefault_003EarrayLevel(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isPrimitive()
	{
		return ResolvedType._003Cdefault_003EisPrimitive(this);
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
	public virtual bool isReferenceType()
	{
		return ResolvedType._003Cdefault_003EisReferenceType(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isVoid()
	{
		return ResolvedType._003Cdefault_003EisVoid(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isTypeVariable()
	{
		return ResolvedType._003Cdefault_003EisTypeVariable(this);
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
	public virtual ResolvedPrimitiveType asPrimitive()
	{
		return ResolvedType._003Cdefault_003EasPrimitive(this);
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
	public virtual ResolvedType replaceTypeVariables(ResolvedTypeParameterDeclaration P_0, ResolvedType P_1)
	{
		return ResolvedType._003Cdefault_003EreplaceTypeVariables(this, P_0, P_1);
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
