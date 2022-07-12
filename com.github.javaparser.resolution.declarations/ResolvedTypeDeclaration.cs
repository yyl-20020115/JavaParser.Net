

using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.resolution.declarations;


public interface ResolvedTypeDeclaration : ResolvedDeclaration
{
	private static class ___003C_003EPIM
	{
		
		
		
		
		internal static bool lambda_0024getInternalType_00240(string name, ResolvedReferenceTypeDeclaration f)
		{
			bool result = String.instancehelper_equals(f.getName(), name);
			
			return result;
		}

		
		
		
		
		internal static UnsolvedSymbolException lambda_0024getInternalType_00241(string name)
		{
			UnsolvedSymbolException result = new UnsolvedSymbolException(new StringBuilder().append("Internal type not found: ").append(name).ToString());
			
			return result;
		}

		
		
		
		
		internal static bool lambda_0024hasInternalType_00242(string name, ResolvedReferenceTypeDeclaration f)
		{
			bool result = String.instancehelper_equals(f.getName(), name);
			
			return result;
		}
	}

	
	public new static class __DefaultMethods
	{
		public unsafe static Set internalTypes(ResolvedTypeDeclaration P_0)
		{
			
			return _003Cdefault_003EinternalTypes(P_0);
		}

		public unsafe static ResolvedReferenceTypeDeclaration getInternalType(ResolvedTypeDeclaration P_0, string P_1)
		{
			
			return _003Cdefault_003EgetInternalType(P_0, P_1);
		}

		public unsafe static bool hasInternalType(ResolvedTypeDeclaration P_0, string P_1)
		{
			
			return _003Cdefault_003EhasInternalType(P_0, P_1);
		}

		public unsafe static bool isClass(ResolvedTypeDeclaration P_0)
		{
			
			return _003Cdefault_003EisClass(P_0);
		}

		public unsafe static bool isInterface(ResolvedTypeDeclaration P_0)
		{
			
			return _003Cdefault_003EisInterface(P_0);
		}

		public unsafe static bool isEnum(ResolvedTypeDeclaration P_0)
		{
			
			return _003Cdefault_003EisEnum(P_0);
		}

		public unsafe static bool isAnnotation(ResolvedTypeDeclaration P_0)
		{
			
			return _003Cdefault_003EisAnnotation(P_0);
		}

		public unsafe static bool isTypeParameter(ResolvedTypeDeclaration P_0)
		{
			
			return _003Cdefault_003EisTypeParameter(P_0);
		}

		public unsafe static bool isType(ResolvedTypeDeclaration P_0)
		{
			
			return _003Cdefault_003EisType(P_0);
		}

		public unsafe static bool isAnonymousClass(ResolvedTypeDeclaration P_0)
		{
			
			return _003Cdefault_003EisAnonymousClass(P_0);
		}

		public unsafe static ResolvedTypeDeclaration asType(ResolvedTypeDeclaration P_0)
		{
			
			return _003Cdefault_003EasType(P_0);
		}

		public unsafe static ResolvedClassDeclaration asClass(ResolvedTypeDeclaration P_0)
		{
			
			return _003Cdefault_003EasClass(P_0);
		}

		public unsafe static ResolvedInterfaceDeclaration asInterface(ResolvedTypeDeclaration P_0)
		{
			
			return _003Cdefault_003EasInterface(P_0);
		}

		public unsafe static ResolvedEnumDeclaration asEnum(ResolvedTypeDeclaration P_0)
		{
			
			return _003Cdefault_003EasEnum(P_0);
		}

		public unsafe static ResolvedAnnotationDeclaration asAnnotation(ResolvedTypeDeclaration P_0)
		{
			
			return _003Cdefault_003EasAnnotation(P_0);
		}

		public unsafe static ResolvedTypeParameterDeclaration asTypeParameter(ResolvedTypeDeclaration P_0)
		{
			
			return _003Cdefault_003EasTypeParameter(P_0);
		}

		public unsafe static ResolvedReferenceTypeDeclaration asReferenceType(ResolvedTypeDeclaration P_0)
		{
			
			return _003Cdefault_003EasReferenceType(P_0);
		}

		public unsafe static string getId(ResolvedTypeDeclaration P_0)
		{
			
			return _003Cdefault_003EgetId(P_0);
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
			bool result = ___003C_003EPIM.lambda_0024getInternalType_00240(arg_00241, (ResolvedReferenceTypeDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon2 : Supplier
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon2(string P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			UnsolvedSymbolException result = ___003C_003EPIM.lambda_0024getInternalType_00241(arg_00241);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon3 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon3(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM.lambda_0024hasInternalType_00242(arg_00241, (ResolvedReferenceTypeDeclaration)P_0);
			
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

	
		virtual Set internalTypes();

	
	
	
	static Set _003Cdefault_003EinternalTypes(ResolvedTypeDeclaration P_0)
	{
		string message = new StringBuilder().append("InternalTypes not available for ").append(Object.instancehelper_getClass(P_0).getCanonicalName()).ToString();
		
		throw new UnsupportedOperationException(message);
	}

	virtual string getQualifiedName();

	
	
	virtual ResolvedReferenceTypeDeclaration getInternalType(string name);

	
	
	
	static ResolvedReferenceTypeDeclaration _003Cdefault_003EgetInternalType(ResolvedTypeDeclaration P_0, string P_1)
	{
		Optional optional = P_0.internalTypes().stream().filter(new ___003C_003EAnon1(P_1))
			.findFirst();
		return (ResolvedReferenceTypeDeclaration)optional.orElseThrow(new ___003C_003EAnon2(P_1));
	}

	
	
	virtual bool hasInternalType(string name);

	
	
	
	static bool _003Cdefault_003EhasInternalType(ResolvedTypeDeclaration P_0, string P_1)
	{
		bool result = P_0.internalTypes().stream().anyMatch(new ___003C_003EAnon3(P_1));
		
		return result;
	}

		virtual Optional containerType();

	
	virtual bool isClass();

	
	static bool _003Cdefault_003EisClass(ResolvedTypeDeclaration P_0)
	{
		return false;
	}

	
	virtual bool isInterface();

	
	static bool _003Cdefault_003EisInterface(ResolvedTypeDeclaration P_0)
	{
		return false;
	}

	
	virtual bool isEnum();

	
	static bool _003Cdefault_003EisEnum(ResolvedTypeDeclaration P_0)
	{
		return false;
	}

	
	virtual bool isAnnotation();

	
	static bool _003Cdefault_003EisAnnotation(ResolvedTypeDeclaration P_0)
	{
		return false;
	}

	
	virtual bool isTypeParameter();

	
	static bool _003Cdefault_003EisTypeParameter(ResolvedTypeDeclaration P_0)
	{
		return false;
	}

	
	bool isType();

	
	static bool _003Cdefault_003EisType(ResolvedTypeDeclaration P_0)
	{
		return true;
	}

	
	virtual bool isAnonymousClass();

	
	static bool _003Cdefault_003EisAnonymousClass(ResolvedTypeDeclaration P_0)
	{
		return false;
	}

	
	ResolvedTypeDeclaration asType();

	
	static ResolvedTypeDeclaration _003Cdefault_003EasType(ResolvedTypeDeclaration P_0)
	{
		return P_0;
	}

	
	virtual ResolvedClassDeclaration asClass();

	
	
	
	static ResolvedClassDeclaration _003Cdefault_003EasClass(ResolvedTypeDeclaration P_0)
	{
		string message = String.format("%s is not a class", P_0);
		
		throw new UnsupportedOperationException(message);
	}

	
	virtual ResolvedInterfaceDeclaration asInterface();

	
	
	
	static ResolvedInterfaceDeclaration _003Cdefault_003EasInterface(ResolvedTypeDeclaration P_0)
	{
		string message = String.format("%s is not an interface", P_0);
		
		throw new UnsupportedOperationException(message);
	}

	
	virtual ResolvedEnumDeclaration asEnum();

	
	
	
	static ResolvedEnumDeclaration _003Cdefault_003EasEnum(ResolvedTypeDeclaration P_0)
	{
		string message = String.format("%s is not an enum", P_0);
		
		throw new UnsupportedOperationException(message);
	}

	
	virtual ResolvedAnnotationDeclaration asAnnotation();

	
	
	
	static ResolvedAnnotationDeclaration _003Cdefault_003EasAnnotation(ResolvedTypeDeclaration P_0)
	{
		string message = String.format("%s is not an annotation", P_0);
		
		throw new UnsupportedOperationException(message);
	}

	
	virtual ResolvedTypeParameterDeclaration asTypeParameter();

	
	
	
	static ResolvedTypeParameterDeclaration _003Cdefault_003EasTypeParameter(ResolvedTypeDeclaration P_0)
	{
		string message = String.format("%s is not a type parameter", P_0);
		
		throw new UnsupportedOperationException(message);
	}

	
	virtual ResolvedReferenceTypeDeclaration asReferenceType();

	
	
	
	static ResolvedReferenceTypeDeclaration _003Cdefault_003EasReferenceType(ResolvedTypeDeclaration P_0)
	{
		string message = String.format("%s is not a reference type", P_0);
		
		throw new UnsupportedOperationException(message);
	}

	virtual string getPackageName();

	virtual string getClassName();

	
	virtual string getId();

	
	
	
	static string _003Cdefault_003EgetId(ResolvedTypeDeclaration P_0)
	{
		string qualifiedName = P_0.getQualifiedName();
		if (qualifiedName == null)
		{
			string result = String.format("<localClass>:%s", P_0.getName());
			
			return result;
		}
		return qualifiedName;
	}
}
