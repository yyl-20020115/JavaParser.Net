
using com.github.javaparser.ast;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.core.resolution;
using com.github.javaparser.symbolsolver.logic;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.resolution;

using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;
using javassist;

namespace com.github.javaparser.symbolsolver.javassistmodel;


public class JavassistEnumDeclaration : AbstractTypeDeclaration, ResolvedEnumDeclaration, ResolvedReferenceTypeDeclaration, ResolvedTypeDeclaration, ResolvedDeclaration, ResolvedTypeParametrizable, HasAccessSpecifier, MethodResolutionCapability, MethodUsageResolutionCapability
{
	
	private sealed class ___003C_003EAnon0 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon0(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024getField_00240(arg_00241, (ResolvedFieldDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon1 : Supplier
	{
		private readonly JavassistEnumDeclaration arg_00241;

		private readonly string arg_00242;

		internal ___003C_003EAnon1(JavassistEnumDeclaration P_0, string P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object get()
		{
			RuntimeException result = arg_00241.lambda_0024getField_00241(arg_00242);
			
			return result;
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
			bool result = lambda_0024hasField_00242(arg_00241, (ResolvedFieldDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon3 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon3(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024getInternalType_00243(arg_00241, (ResolvedReferenceTypeDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon4 : Supplier
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon4(string P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			UnsolvedSymbolException result = lambda_0024getInternalType_00244(arg_00241);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon5 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon5(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024hasInternalType_00245(arg_00241, (ResolvedReferenceTypeDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon6 : Predicate
	{
		internal ___003C_003EAnon6()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024getEnumConstants_00246((CtField)P_0);
			
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

	
	private sealed class ___003C_003EAnon7 : Function
	{
		private readonly JavassistEnumDeclaration arg_00241;

		internal ___003C_003EAnon7(JavassistEnumDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			JavassistEnumConstantDeclaration result = arg_00241.lambda_0024getEnumConstants_00247((CtField)P_0);
			
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

	private CtClass ctClass;

	private TypeSolver typeSolver;

	private JavassistTypeDeclarationAdapter javassistTypeDeclarationAdapter;

	
	
	public JavassistEnumDeclaration(CtClass ctClass, TypeSolver typeSolver)
	{
		if (ctClass == null)
		{
			
			throw new IllegalArgumentException();
		}
		if (!ctClass.isEnum())
		{
			string s = new StringBuilder().append("Trying to instantiate a JavassistEnumDeclaration with something which is not an enum: ").append(ctClass.ToString()).ToString();
			
			throw new IllegalArgumentException(s);
		}
		this.ctClass = ctClass;
		this.typeSolver = typeSolver;
		javassistTypeDeclarationAdapter = new JavassistTypeDeclarationAdapter(ctClass, typeSolver, this);
	}

	
	
	public override string getPackageName()
	{
		string packageName = ctClass.getPackageName();
		
		return packageName;
	}

	
		
	public override Set internalTypes()
	{
		Set result = javassistTypeDeclarationAdapter.internalTypes();
		
		return result;
	}

	
	
	private string[] getInterfaceFQNs()
	{
		string[] interfaces = ctClass.getClassFile().getInterfaces();
		
		return interfaces;
	}

	
		
	private SymbolReference solveSymbolForFQN(string P_0, string P_1)
	{
		if (P_1 == null)
		{
			SymbolReference result = SymbolReference.unsolved(ClassLiteral<ResolvedValueDeclaration>.Value);
			
			return result;
		}
		ResolvedReferenceTypeDeclaration typeDeclaration = typeSolver.solveType(P_1);
		SymbolReference result2 = new SymbolSolver(typeSolver).solveSymbolInType(typeDeclaration, P_0);
		
		return result2;
	}

	
	
	
	private static bool lambda_0024getField_00240(string P_0, ResolvedFieldDeclaration P_1)
	{
		bool result = String.instancehelper_equals(P_1.getName(), P_0);
		
		return result;
	}

	
	
	
	private RuntimeException lambda_0024getField_00241(string P_0)
	{
		RuntimeException result = new RuntimeException(new StringBuilder().append("Field ").append(P_0).append(" does not exist in ")
			.append(ctClass.getName())
			.append(".")
			.ToString());
		
		return result;
	}

	
	
	
	private static bool lambda_0024hasField_00242(string P_0, ResolvedFieldDeclaration P_1)
	{
		bool result = String.instancehelper_equals(P_1.getName(), P_0);
		
		return result;
	}

	
	
	
	private static bool lambda_0024getInternalType_00243(string P_0, ResolvedReferenceTypeDeclaration P_1)
	{
		bool result = String.instancehelper_endsWith(P_1.getName(), P_0);
		
		return result;
	}

	
	
	
	private static UnsolvedSymbolException lambda_0024getInternalType_00244(string P_0)
	{
		UnsolvedSymbolException result = new UnsolvedSymbolException(new StringBuilder().append("Internal type not found: ").append(P_0).ToString());
		
		return result;
	}

	
	
	
	private static bool lambda_0024hasInternalType_00245(string P_0, ResolvedReferenceTypeDeclaration P_1)
	{
		bool result = String.instancehelper_endsWith(P_1.getName(), P_0);
		
		return result;
	}

	
	
	
	private static bool lambda_0024getEnumConstants_00246(CtField P_0)
	{
		return (((uint)P_0.getFieldInfo2().getAccessFlags() & 0x4000u) != 0) ? true : false;
	}

	
	
	
	private JavassistEnumConstantDeclaration lambda_0024getEnumConstants_00247(CtField P_0)
	{
		JavassistEnumConstantDeclaration result = new JavassistEnumConstantDeclaration(P_0, typeSolver);
		
		return result;
	}

	
	
	public virtual AccessSpecifier accessSpecifier()
	{
		AccessSpecifier result = JavassistFactory.modifiersToAccessLevel(ctClass.getModifiers());
		
		return result;
	}

	
	
	public override string getClassName()
	{
		string text = String.instancehelper_replace(ctClass.getName(), '$', '.');
		if (getPackageName() != null)
		{
			string result = String.instancehelper_substring(text, String.instancehelper_length(getPackageName()) + 1);
			
			return result;
		}
		return text;
	}

	
	
	public override string getQualifiedName()
	{
		string result = String.instancehelper_replace(ctClass.getName(), '$', '.');
		
		return result;
	}

	
		
	public override List getAncestors(bool acceptIncompleteList)
	{
		List ancestors = javassistTypeDeclarationAdapter.getAncestors(acceptIncompleteList);
		
		return ancestors;
	}

	
	
	public override ResolvedFieldDeclaration getField(string name)
	{
		Optional optional = javassistTypeDeclarationAdapter.getDeclaredFields().stream().filter(new ___003C_003EAnon0(name))
			.findFirst();
		return (ResolvedFieldDeclaration)optional.orElseThrow(new ___003C_003EAnon1(this, name));
	}

	
	
	public override bool hasField(string name)
	{
		bool result = javassistTypeDeclarationAdapter.getDeclaredFields().stream().anyMatch(new ___003C_003EAnon2(name));
		
		return result;
	}

	
		
	public override List getAllFields()
	{
		List declaredFields = javassistTypeDeclarationAdapter.getDeclaredFields();
		
		return declaredFields;
	}

	
		
	public override Set getDeclaredMethods()
	{
		Set declaredMethods = javassistTypeDeclarationAdapter.getDeclaredMethods();
		
		return declaredMethods;
	}

	
	
	public override bool isAssignableBy(ResolvedType type)
	{
		
		throw new UnsupportedOperationException();
	}

	
	
	public override bool isAssignableBy(ResolvedReferenceTypeDeclaration other)
	{
		
		throw new UnsupportedOperationException();
	}

	
	
	public override bool hasDirectlyAnnotation(string canonicalName)
	{
		bool result = ctClass.hasAnnotation(canonicalName);
		
		return result;
	}

	
	
	public override string getName()
	{
		string[] array = String.instancehelper_split(String.instancehelper_replace(ctClass.getSimpleName(), '$', '.'), "\\.");
		return array[(nint)array.LongLength - 1];
	}

	
		
	public override List getTypeParameters()
	{
		List typeParameters = javassistTypeDeclarationAdapter.getTypeParameters();
		
		return typeParameters;
	}

	
		
	public override Optional containerType()
	{
		Optional result = javassistTypeDeclarationAdapter.containerType();
		
		return result;
	}

	
		
	public virtual SymbolReference solveMethod(string name, List argumentsTypes, bool staticOnly)
	{
		SymbolReference result = JavassistUtils.solveMethod(name, argumentsTypes, staticOnly, typeSolver, this, ctClass);
		
		return result;
	}

	
		
	public virtual Optional solveMethodAsUsage(string name, List argumentsTypes, Context invokationContext, List typeParameterValues)
	{
		Optional result = JavassistUtils.solveMethodAsUsage(name, argumentsTypes, typeSolver, invokationContext, typeParameterValues, this, ctClass);
		
		return result;
	}

	
	
	public override ResolvedReferenceTypeDeclaration getInternalType(string name)
	{
		Optional optional = internalTypes().stream().filter(new ___003C_003EAnon3(name)).findFirst();
		return (ResolvedReferenceTypeDeclaration)optional.orElseThrow(new ___003C_003EAnon4(name));
	}

	
	
	public override bool hasInternalType(string name)
	{
		bool result = internalTypes().stream().anyMatch(new ___003C_003EAnon5(name));
		
		return result;
	}

	
		
	public virtual SymbolReference solveSymbol(string name, TypeSolver typeSolver)
	{
		CtField[] declaredFields = ctClass.getDeclaredFields();
		int num = declaredFields.Length;
		int i;
		for (i = 0; i < num; i++)
		{
			CtField ctField = declaredFields[i];
			if (String.instancehelper_equals(ctField.getName(), name))
			{
				SymbolReference result = SymbolReference.solved(new JavassistFieldDeclaration(ctField, typeSolver));
				
				return result;
			}
		}
		string[] interfaceFQNs = getInterfaceFQNs();
		string[] array = interfaceFQNs;
		i = array.Length;
		for (int j = 0; j < i; j++)
		{
			string text = array[j];
			SymbolReference symbolReference = solveSymbolForFQN(name, text);
			if (symbolReference.isSolved())
			{
				return symbolReference;
			}
		}
		SymbolReference result2 = SymbolReference.unsolved(ClassLiteral<ResolvedValueDeclaration>.Value);
		
		return result2;
	}

	
		
	public virtual List getEnumConstants()
	{
		return (List)Arrays.stream(ctClass.getFields()).filter(new ___003C_003EAnon6()).map(new ___003C_003EAnon7(this))
			.collect(Collectors.toList());
	}

	
		
	public override List getConstructors()
	{
		List constructors = javassistTypeDeclarationAdapter.getConstructors();
		
		return constructors;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append(Object.instancehelper_getClass(this).getSimpleName()).append("{ctClass=").append(ctClass.getName())
			.append(", typeSolver=")
			.append(typeSolver)
			.append('}')
			.ToString();
		
		return result;
	}


	public override bool hasName()
	{
		return ResolvedDeclaration._003Cdefault_003EhasName(this);
	}


	public override bool isField()
	{
		return ResolvedDeclaration._003Cdefault_003EisField(this);
	}


	public override bool isVariable()
	{
		return ResolvedDeclaration._003Cdefault_003EisVariable(this);
	}


	public override bool isEnumConstant()
	{
		return ResolvedDeclaration._003Cdefault_003EisEnumConstant(this);
	}


	public override bool isPattern()
	{
		return ResolvedDeclaration._003Cdefault_003EisPattern(this);
	}


	public override bool isParameter()
	{
		return ResolvedDeclaration._003Cdefault_003EisParameter(this);
	}


	public override bool isType()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EisType(this);
	}


	public override bool isMethod()
	{
		return ResolvedDeclaration._003Cdefault_003EisMethod(this);
	}


	public override ResolvedFieldDeclaration asField()
	{
		return ResolvedDeclaration._003Cdefault_003EasField(this);
	}


	public override ResolvedParameterDeclaration asParameter()
	{
		return ResolvedDeclaration._003Cdefault_003EasParameter(this);
	}


	public override ResolvedTypeDeclaration asType()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EasType(this);
	}


	public override ResolvedMethodDeclaration asMethod()
	{
		return ResolvedDeclaration._003Cdefault_003EasMethod(this);
	}


	public override ResolvedEnumConstantDeclaration asEnumConstant()
	{
		return ResolvedDeclaration._003Cdefault_003EasEnumConstant(this);
	}


	public override ResolvedPatternDeclaration asPattern()
	{
		return ResolvedDeclaration._003Cdefault_003EasPattern(this);
	}


	public override bool isClass()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EisClass(this);
	}


	public override bool isInterface()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EisInterface(this);
	}


	public override bool isEnum()
	{
		return ResolvedEnumDeclaration._003Cdefault_003EisEnum(this);
	}


	public override bool isAnnotation()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EisAnnotation(this);
	}


	public override bool isTypeParameter()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EisTypeParameter(this);
	}


	public override bool isAnonymousClass()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EisAnonymousClass(this);
	}


	public override ResolvedClassDeclaration asClass()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EasClass(this);
	}


	public override ResolvedInterfaceDeclaration asInterface()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EasInterface(this);
	}


	public override ResolvedEnumDeclaration asEnum()
	{
		return ResolvedEnumDeclaration._003Cdefault_003EasEnum(this);
	}


	public override ResolvedAnnotationDeclaration asAnnotation()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EasAnnotation(this);
	}


	public override ResolvedTypeParameterDeclaration asTypeParameter()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EasTypeParameter(this);
	}


	public override ResolvedReferenceTypeDeclaration asReferenceType()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EasReferenceType(this);
	}


	public override string getId()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EgetId(this);
	}


	public override Optional findTypeParameter(string P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EfindTypeParameter(this, P_0);
	}


	public override bool isGeneric()
	{
		return ResolvedTypeParametrizable._003Cdefault_003EisGeneric(this);
	}


	public override List getAncestors()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetAncestors(this);
	}


	public override List getAllAncestors()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetAllAncestors(this);
	}


	public override List getAllAncestors(Function P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetAllAncestors(this, P_0);
	}


	public override ResolvedFieldDeclaration getVisibleField(string P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetVisibleField(this, P_0);
	}


	public override bool hasVisibleField(string P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EhasVisibleField(this, P_0);
	}


	public override List getVisibleFields()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetVisibleFields(this);
	}


	public override List getAllNonStaticFields()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetAllNonStaticFields(this);
	}


	public override List getAllStaticFields()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetAllStaticFields(this);
	}


	public override List getDeclaredFields()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetDeclaredFields(this);
	}


	public override bool canBeAssignedTo(ResolvedReferenceTypeDeclaration P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EcanBeAssignedTo(this, P_0);
	}


	public override bool hasAnnotation(string P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EhasAnnotation(this, P_0);
	}


	public override bool isJavaLangObject()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EisJavaLangObject(this);
	}


	public override bool isJavaLangEnum()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EisJavaLangEnum(this);
	}


	public virtual bool hasEnumConstant(string P_0)
	{
		return ResolvedEnumDeclaration._003Cdefault_003EhasEnumConstant(this, P_0);
	}


	public virtual ResolvedEnumConstantDeclaration getEnumConstant(string P_0)
	{
		return ResolvedEnumDeclaration._003Cdefault_003EgetEnumConstant(this, P_0);
	}
}
