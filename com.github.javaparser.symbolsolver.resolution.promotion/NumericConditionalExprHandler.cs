using System.Runtime.CompilerServices;
using com.github.javaparser.resolution.types;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.symbolsolver.resolution.promotion;

public class NumericConditionalExprHandler: ConditionalExprHandler
{
	
	private sealed class ___003C_003EAnon0 : Predicate
	{
		private readonly ResolvedType arg_00241;

		internal ___003C_003EAnon0(ResolvedType P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024relaxMatch_00240(arg_00241, (ResolvedPrimitiveType)P_0);
			
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

	
	private sealed class ___003C_003EAnon1 : Predicate
	{
		private readonly ResolvedPrimitiveType arg_00241;

		internal ___003C_003EAnon1(ResolvedPrimitiveType P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024isResolvableTo_00241(arg_00241, (Map.Entry)P_0);
			
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

	
	private sealed class ___003C_003EAnon2 : Function
	{
		internal ___003C_003EAnon2()
		{
		}

		public object apply(object P_0)
		{
			Stream result = lambda_0024isResolvableTo_00242((Map.Entry)P_0);
			
			return result;
		}

		
		public Function compose(Function P_0)
		{
			return Function._003Cdefault_003Ecompose(this, P_0);
		}

		
		public Function andThen(Function P_0)
		{
			return Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon3 : Predicate
	{
		private readonly ResolvedType arg_00241;

		private readonly bool arg_00242;

		private readonly ResolvedPrimitiveType arg_00243;

		internal ___003C_003EAnon3(ResolvedType P_0, bool P_1, ResolvedPrimitiveType P_2)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024isResolvableTo_00243(arg_00241, arg_00242, arg_00243, (ResolvedType)P_0);
			
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

		private static Map NumericConverter;

	private static ResolvedPrimitiveType[] resolvedPrimitiveTypeSubList;

	internal ResolvedType thenExpr;

	internal ResolvedType elseExpr;

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
	
	public NumericConditionalExprHandler(ResolvedType thenExpr, ResolvedType elseExpr)
	{
		this.thenExpr = thenExpr;
		this.elseExpr = elseExpr;
	}

	
	
	protected internal virtual bool isResolvableTo(ResolvedPrimitiveType toType, ResolvedType resolvedType)
	{
		bool result = isResolvableTo(toType, resolvedType, verifyBoxedType: true);
		
		return result;
	}

	
	
	protected internal virtual bool relaxMatch(ResolvedType type, params ResolvedPrimitiveType[] types)
	{
		return (exactMatch(type, types) || (type.isReferenceType() && Arrays.stream(types).anyMatch(new ___003C_003EAnon0(type)))) ? true : false;
	}

	
	
	protected internal virtual bool exactMatch(ResolvedType type, params ResolvedPrimitiveType[] types)
	{
		return (type.isPrimitive() && type.asPrimitive().@in(types)) ? true : false;
	}

	
	
	protected internal virtual bool isResolvableTo(ResolvedPrimitiveType toType, ResolvedType resolvedType, bool verifyBoxedType)
	{
		bool result = NumericConverter.entrySet().stream().filter(new ___003C_003EAnon1(toType))
			.flatMap(new ___003C_003EAnon2())
			.anyMatch(new ___003C_003EAnon3(resolvedType, verifyBoxedType, toType));
		
		return result;
	}

	
	
	
	private static bool lambda_0024relaxMatch_00240(ResolvedType P_0, ResolvedPrimitiveType P_1)
	{
		bool result = String.instancehelper_equals(P_0.asReferenceType().getQualifiedName(), P_1.getBoxTypeQName());
		
		return result;
	}

	
	
	
	private static bool lambda_0024isResolvableTo_00241(ResolvedPrimitiveType P_0, Map.Entry P_1)
	{
		return P_1.getKey() == P_0;
	}

	
	
	
	private static Stream lambda_0024isResolvableTo_00242(Map.Entry P_0)
	{
		Stream result = ((List)P_0.getValue()).stream();
		
		return result;
	}

	
	
	
	private static bool lambda_0024isResolvableTo_00243(ResolvedType P_0, bool P_1, ResolvedPrimitiveType P_2, ResolvedType P_3)
	{
		return (P_3 == P_0 || (P_1 && P_0.isReferenceType() && P_0.asReferenceType().toUnboxedType().get() == P_2)) ? true : false;
	}

	
	[LineNumberTable(new byte[]
	{
		159, 186, 127, 6, 107, 127, 6, 107, 105, 231,
		70, 127, 1, 102, 113, 135, 127, 1, 102, 113,
		231, 71, 127, 28, 127, 4, 230, 78, 125, 127,
		8, 103, 103, 127, 8, 103, 231, 74, 127, 4,
		114, 127, 17, 103, 123, 127, 4, 114, 127, 17,
		103, 251, 70, 127, 1, 117, 127, 1, 117
	})]
	public virtual ResolvedType resolveType()
	{
		string text = ((!thenExpr.isPrimitive()) ? thenExpr.asReferenceType().describe() : thenExpr.asPrimitive().describe());
		string text2 = ((!elseExpr.isPrimitive()) ? elseExpr.asReferenceType().describe() : elseExpr.asPrimitive().describe());
		if (String.instancehelper_equals(text, text2))
		{
			return thenExpr;
		}
		if (thenExpr.isPrimitive() && elseExpr.isReferenceType() && elseExpr.asReferenceType().isUnboxableTo((ResolvedPrimitiveType)ResolvedPrimitiveType.byName(text)))
		{
			return thenExpr;
		}
		if (elseExpr.isPrimitive() && thenExpr.isReferenceType() && thenExpr.asReferenceType().isUnboxableTo((ResolvedPrimitiveType)ResolvedPrimitiveType.byName(text2)))
		{
			return elseExpr;
		}
		if ((isResolvableTo(ResolvedPrimitiveType.___003C_003ESHORT, thenExpr) && relaxMatch(elseExpr, ResolvedPrimitiveType.___003C_003EBYTE)) || (isResolvableTo(ResolvedPrimitiveType.___003C_003ESHORT, elseExpr) && relaxMatch(thenExpr, ResolvedPrimitiveType.___003C_003EBYTE)))
		{
			return ResolvedPrimitiveType.___003C_003ESHORT;
		}
		if (thenExpr.isPrimitive() && elseExpr.isPrimitive())
		{
			if (((ResolvedPrimitiveType)thenExpr).@in(resolvedPrimitiveTypeSubList) && ((ResolvedPrimitiveType)elseExpr).equals(ResolvedPrimitiveType.___003C_003EINT))
			{
				return thenExpr;
			}
			if (((ResolvedPrimitiveType)elseExpr).@in(resolvedPrimitiveTypeSubList) && ((ResolvedPrimitiveType)thenExpr).equals(ResolvedPrimitiveType.___003C_003EINT))
			{
				return elseExpr;
			}
		}
		if (thenExpr.isReference() && elseExpr.isPrimitive() && thenExpr.asReferenceType().isUnboxable() && ((ResolvedPrimitiveType)thenExpr.asReferenceType().toUnboxedType().get()).@in(resolvedPrimitiveTypeSubList) && ((ResolvedPrimitiveType)elseExpr).equals(ResolvedPrimitiveType.___003C_003EINT))
		{
			return (ResolvedType)thenExpr.asReferenceType().toUnboxedType().get();
		}
		if (elseExpr.isReference() && thenExpr.isPrimitive() && elseExpr.asReferenceType().isUnboxable() && ((ResolvedPrimitiveType)elseExpr.asReferenceType().toUnboxedType().get()).@in(resolvedPrimitiveTypeSubList) && ((ResolvedPrimitiveType)thenExpr).equals(ResolvedPrimitiveType.___003C_003EINT))
		{
			return (ResolvedType)elseExpr.asReferenceType().toUnboxedType().get();
		}
		ResolvedPrimitiveType resolvedPrimitiveType = ((!thenExpr.isPrimitive()) ? ((ResolvedPrimitiveType)thenExpr.asReferenceType().toUnboxedType().get()) : thenExpr.asPrimitive());
		ResolvedPrimitiveType other = ((!elseExpr.isPrimitive()) ? ((ResolvedPrimitiveType)elseExpr.asReferenceType().toUnboxedType().get()) : elseExpr.asPrimitive());
		ResolvedPrimitiveType result = resolvedPrimitiveType.bnp(other);
		
		return result;
	}

	
	static NumericConditionalExprHandler()
	{
		NumericConverter = new HashMap();
		NumericConverter.put(ResolvedPrimitiveType.___003C_003ESHORT, Arrays.asList(ResolvedPrimitiveType.___003C_003ESHORT, ResolvedPrimitiveType.___003C_003EBYTE));
		resolvedPrimitiveTypeSubList = new ResolvedPrimitiveType[3]
		{
			ResolvedPrimitiveType.___003C_003EBYTE,
			ResolvedPrimitiveType.___003C_003ESHORT,
			ResolvedPrimitiveType.___003C_003ECHAR
		};
	}
}
