using System;

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


public class JavassistInterfaceDeclaration : AbstractTypeDeclaration, ResolvedInterfaceDeclaration, ResolvedReferenceTypeDeclaration, ResolvedTypeDeclaration, ResolvedDeclaration, ResolvedTypeParametrizable, HasAccessSpecifier, AssociableToAST, MethodResolutionCapability, MethodUsageResolutionCapability
{
	
	private sealed class ___003C_003EAnon0 : Function
	{
		private readonly JavassistInterfaceDeclaration arg_00241;

		internal ___003C_003EAnon0(JavassistInterfaceDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			JavassistMethodDeclaration result = arg_00241.lambda_0024getDeclaredMethods_00240((CtMethod)P_0);
			
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

	
	private sealed class ___003C_003EAnon1 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon1(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024getInternalType_00241(arg_00241, (ResolvedReferenceTypeDeclaration)P_0);
			
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
			UnsolvedSymbolException result = lambda_0024getInternalType_00242(arg_00241);
			
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
			bool result = lambda_0024hasInternalType_00243(arg_00241, (ResolvedReferenceTypeDeclaration)P_0);
			
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

	private CtClass ctClass;

	private TypeSolver typeSolver;

	private JavassistTypeDeclarationAdapter javassistTypeDeclarationAdapter;

	
	
	public JavassistInterfaceDeclaration(CtClass ctClass, TypeSolver typeSolver)
	{
		if (!ctClass.isInterface())
		{
			string s = new StringBuilder().append("Not an interface: ").append(ctClass.getName()).ToString();
			
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

	
		
	public override Set internalTypes()
	{
		Set result = javassistTypeDeclarationAdapter.internalTypes();
		
		return result;
	}

	
	
	
	private JavassistMethodDeclaration lambda_0024getDeclaredMethods_00240(CtMethod P_0)
	{
		JavassistMethodDeclaration result = new JavassistMethodDeclaration(P_0, typeSolver);
		
		return result;
	}

	
	
	
	private static bool lambda_0024getInternalType_00241(string P_0, ResolvedReferenceTypeDeclaration P_1)
	{
		bool result = java.lang.String.instancehelper_endsWith(P_1.getName(), P_0);
		
		return result;
	}

	
	
	
	private static UnsolvedSymbolException lambda_0024getInternalType_00242(string P_0)
	{
		UnsolvedSymbolException result = new UnsolvedSymbolException(new StringBuilder().append("Internal type not found: ").append(P_0).ToString());
		
		return result;
	}

	
	
	
	private static bool lambda_0024hasInternalType_00243(string P_0, ResolvedReferenceTypeDeclaration P_1)
	{
		bool result = java.lang.String.instancehelper_endsWith(P_1.getName(), P_0);
		
		return result;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("JavassistInterfaceDeclaration{ctClass=").append(ctClass.getName()).append(", typeSolver=")
			.append(typeSolver)
			.append('}')
			.ToString();
		
		return result;
	}

	
		
	public virtual List getInterfacesExtended()
	{
		List interfaces = javassistTypeDeclarationAdapter.getInterfaces();
		
		return interfaces;
	}

	
	
	public override string getClassName()
	{
		string text = java.lang.String.instancehelper_replace(ctClass.getName(), '$', '.');
		if (getPackageName() != null)
		{
			string result = java.lang.String.instancehelper_substring(text, java.lang.String.instancehelper_length(getPackageName()) + 1);
			
			return result;
		}
		return text;
	}

	
	
	public override string getQualifiedName()
	{
		string result = java.lang.String.instancehelper_replace(ctClass.getName(), '$', '.');
		
		return result;
	}

	
	
		
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual Optional solveMethodAsUsage(string name, List argumentsTypes, Context invokationContext, List typeParameterValues)
	{
		Optional result = JavassistUtils.solveMethodAsUsage(name, argumentsTypes, typeSolver, invokationContext, typeParameterValues, this, ctClass);
		
		return result;
	}

	
	
		
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual SymbolReference solveMethod(string name, List argumentsTypes, bool staticOnly)
	{
		SymbolReference result = JavassistUtils.solveMethod(name, argumentsTypes, staticOnly, typeSolver, this, ctClass);
		
		return result;
	}

	
	
	public override bool isAssignableBy(ResolvedType type)
	{
		bool result = javassistTypeDeclarationAdapter.isAssignableBy(type);
		
		return result;
	}

	
		
	public override List getAllFields()
	{
		List declaredFields = javassistTypeDeclarationAdapter.getDeclaredFields();
		
		return declaredFields;
	}

	
	
	public override bool isAssignableBy(ResolvedReferenceTypeDeclaration other)
	{
		bool result = javassistTypeDeclarationAdapter.isAssignableBy(other);
		
		return result;
	}

	
		
	public override List getAncestors(bool acceptIncompleteList)
	{
		List ancestors = javassistTypeDeclarationAdapter.getAncestors(acceptIncompleteList);
		
		return ancestors;
	}

	
		
	public override Set getDeclaredMethods()
	{
		return (Set)Arrays.stream(ctClass.getDeclaredMethods()).map(new ___003C_003EAnon0(this)).collect(Collectors.toSet());
	}

	
	
	public override bool hasDirectlyAnnotation(string canonicalName)
	{
		bool result = ctClass.hasAnnotation(canonicalName);
		
		return result;
	}

	
	
	public override string getName()
	{
		string[] array = java.lang.String.instancehelper_split(java.lang.String.instancehelper_replace(ctClass.getSimpleName(), '$', '.'), "\\.");
		return array[(nint)array.LongLength - 1];
	}

	
		
	public override List getTypeParameters()
	{
		List typeParameters = javassistTypeDeclarationAdapter.getTypeParameters();
		
		return typeParameters;
	}

	
	
	public virtual AccessSpecifier accessSpecifier()
	{
		AccessSpecifier result = JavassistFactory.modifiersToAccessLevel(ctClass.getModifiers());
		
		return result;
	}

	public override ResolvedInterfaceDeclaration asInterface()
	{
		return this;
	}

	
	
		
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual SymbolReference solveSymbol(string name, TypeSolver typeSolver)
	{
		CtField[] declaredFields = ctClass.getDeclaredFields();
		int num = declaredFields.Length;
		int i;
		for (i = 0; i < num; i++)
		{
			CtField ctField = declaredFields[i];
			if (java.lang.String.instancehelper_equals(ctField.getName(), name))
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

	
		
	public override Optional containerType()
	{
		Optional result = javassistTypeDeclarationAdapter.containerType();
		
		return result;
	}

	
	
	public override ResolvedReferenceTypeDeclaration getInternalType(string name)
	{
		Optional optional = internalTypes().stream().filter(new ___003C_003EAnon1(name)).findFirst();
		return (ResolvedReferenceTypeDeclaration)optional.orElseThrow(new ___003C_003EAnon2(name));
	}

	
	
	public override bool hasInternalType(string name)
	{
		bool result = internalTypes().stream().anyMatch(new ___003C_003EAnon3(name));
		
		return result;
	}

	
		
	public override List getConstructors()
	{
		List result = Collections.emptyList();
		
		return result;
	}

	
		
	public virtual Optional toAst()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool hasName()
	{
		return ResolvedDeclaration._003Cdefault_003EhasName(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isField()
	{
		return ResolvedDeclaration._003Cdefault_003EisField(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isVariable()
	{
		return ResolvedDeclaration._003Cdefault_003EisVariable(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isEnumConstant()
	{
		return ResolvedDeclaration._003Cdefault_003EisEnumConstant(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isPattern()
	{
		return ResolvedDeclaration._003Cdefault_003EisPattern(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isParameter()
	{
		return ResolvedDeclaration._003Cdefault_003EisParameter(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isType()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EisType(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isMethod()
	{
		return ResolvedDeclaration._003Cdefault_003EisMethod(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedFieldDeclaration asField()
	{
		return ResolvedDeclaration._003Cdefault_003EasField(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedParameterDeclaration asParameter()
	{
		return ResolvedDeclaration._003Cdefault_003EasParameter(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedTypeDeclaration asType()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EasType(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedMethodDeclaration asMethod()
	{
		return ResolvedDeclaration._003Cdefault_003EasMethod(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedEnumConstantDeclaration asEnumConstant()
	{
		return ResolvedDeclaration._003Cdefault_003EasEnumConstant(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedPatternDeclaration asPattern()
	{
		return ResolvedDeclaration._003Cdefault_003EasPattern(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isClass()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EisClass(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isInterface()
	{
		return ResolvedInterfaceDeclaration._003Cdefault_003EisInterface(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isEnum()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EisEnum(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isAnnotation()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EisAnnotation(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isTypeParameter()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EisTypeParameter(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isAnonymousClass()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EisAnonymousClass(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedClassDeclaration asClass()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EasClass(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedEnumDeclaration asEnum()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EasEnum(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedAnnotationDeclaration asAnnotation()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EasAnnotation(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedTypeParameterDeclaration asTypeParameter()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EasTypeParameter(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedReferenceTypeDeclaration asReferenceType()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EasReferenceType(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override string getId()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EgetId(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Optional findTypeParameter(string P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EfindTypeParameter(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isGeneric()
	{
		return ResolvedTypeParametrizable._003Cdefault_003EisGeneric(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override List getAncestors()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetAncestors(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override List getAllAncestors()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetAllAncestors(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override List getAllAncestors(Function P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetAllAncestors(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedFieldDeclaration getField(string P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetField(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedFieldDeclaration getVisibleField(string P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetVisibleField(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool hasField(string P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EhasField(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool hasVisibleField(string P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EhasVisibleField(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override List getVisibleFields()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetVisibleFields(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override List getAllNonStaticFields()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetAllNonStaticFields(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override List getAllStaticFields()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetAllStaticFields(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override List getDeclaredFields()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetDeclaredFields(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool canBeAssignedTo(ResolvedReferenceTypeDeclaration P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EcanBeAssignedTo(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool hasAnnotation(string P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EhasAnnotation(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isJavaLangObject()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EisJavaLangObject(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isJavaLangEnum()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EisJavaLangEnum(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual List getAllInterfacesExtended()
	{
		return ResolvedInterfaceDeclaration._003Cdefault_003EgetAllInterfacesExtended(this);
	}
}
