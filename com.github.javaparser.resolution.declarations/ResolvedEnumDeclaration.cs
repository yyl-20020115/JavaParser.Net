

using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.resolution.declarations;


public interface ResolvedEnumDeclaration : ResolvedReferenceTypeDeclaration, ResolvedTypeDeclaration, ResolvedDeclaration, ResolvedTypeParametrizable, HasAccessSpecifier
{
	private static class ___003C_003EPIM
	{
		
		
		
		
		internal static bool lambda_0024hasEnumConstant_00240(string name, ResolvedEnumConstantDeclaration c)
		{
			bool result = String.instancehelper_equals(c.getName(), name);
			
			return result;
		}

		
		
		
		
		internal static bool lambda_0024getEnumConstant_00241(string name, ResolvedEnumConstantDeclaration c)
		{
			bool result = String.instancehelper_equals(c.getName(), name);
			
			return result;
		}

		
		
		
		
		internal static IllegalArgumentException lambda_0024getEnumConstant_00242(string name)
		{
			IllegalArgumentException result = new IllegalArgumentException(new StringBuilder().append("No constant named ").append(name).ToString());
			
			return result;
		}
	}

	
	public new static class __DefaultMethods
	{
		public unsafe static bool isEnum(ResolvedEnumDeclaration P_0)
		{
			
			return _003Cdefault_003EisEnum(P_0);
		}

		public unsafe static ResolvedEnumDeclaration asEnum(ResolvedEnumDeclaration P_0)
		{
			
			return _003Cdefault_003EasEnum(P_0);
		}

		public unsafe static bool hasEnumConstant(ResolvedEnumDeclaration P_0, string P_1)
		{
			
			return _003Cdefault_003EhasEnumConstant(P_0, P_1);
		}

		public unsafe static ResolvedEnumConstantDeclaration getEnumConstant(ResolvedEnumDeclaration P_0, string P_1)
		{
			
			return _003Cdefault_003EgetEnumConstant(P_0, P_1);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon1(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM.lambda_0024hasEnumConstant_00240(arg_00241, (ResolvedEnumConstantDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon2 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon2(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM.lambda_0024getEnumConstant_00241(arg_00241, (ResolvedEnumConstantDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon3 : Supplier
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon3(string P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			IllegalArgumentException result = ___003C_003EPIM.lambda_0024getEnumConstant_00242(arg_00241);
			
			return result;
		}
	}

		virtual List getEnumConstants();

	
	bool isEnum();

	
	static bool _003Cdefault_003EisEnum(ResolvedEnumDeclaration P_0)
	{
		return true;
	}

	
	ResolvedEnumDeclaration asEnum();

	
	static ResolvedEnumDeclaration _003Cdefault_003EasEnum(ResolvedEnumDeclaration P_0)
	{
		return P_0;
	}

	
	
	virtual bool hasEnumConstant(string name);

	
	
	
	static bool _003Cdefault_003EhasEnumConstant(ResolvedEnumDeclaration P_0, string P_1)
	{
		bool result = P_0.getEnumConstants().stream().anyMatch(new ___003C_003EAnon1(P_1));
		
		return result;
	}

	
	
	virtual ResolvedEnumConstantDeclaration getEnumConstant(string name);

	
	
	
	static ResolvedEnumConstantDeclaration _003Cdefault_003EgetEnumConstant(ResolvedEnumDeclaration P_0, string P_1)
	{
		return (ResolvedEnumConstantDeclaration)P_0.getEnumConstants().stream().filter(new ___003C_003EAnon2(P_1))
			.findFirst()
			.orElseThrow(new ___003C_003EAnon3(P_1));
	}
}
