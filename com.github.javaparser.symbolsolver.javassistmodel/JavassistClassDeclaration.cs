using System;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.core.resolution;
using com.github.javaparser.symbolsolver.javaparsermodel;
using com.github.javaparser.symbolsolver.logic;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.model.typesystem;
using com.github.javaparser.symbolsolver.resolution;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;
using javassist;

namespace com.github.javaparser.symbolsolver.javassistmodel;


public class JavassistClassDeclaration : AbstractClassDeclaration, MethodUsageResolutionCapability
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
			bool result = lambda_0024getInternalType_00240(arg_00241, (ResolvedReferenceTypeDeclaration)P_0);
			
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
		private readonly string arg_00241;

		internal ___003C_003EAnon1(string P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			UnsolvedSymbolException result = lambda_0024getInternalType_00241(arg_00241);
			
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
			bool result = lambda_0024hasInternalType_00242(arg_00241, (ResolvedReferenceTypeDeclaration)P_0);
			
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

	
	[LineNumberTable(new byte[]
	{
		160, 77, 104, 162, 104, 201, 115, 162, 103, 104,
		108, 105, 194, 127, 1, 105, 130, 130
	})]
	public override bool isAssignableBy(ResolvedType type)
	{
		if (type.isNull())
		{
			return true;
		}
		if (type is LambdaArgumentTypePlaceholder)
		{
			bool result = isFunctionalInterface();
			
			return result;
		}
		if (java.lang.String.instancehelper_equals(type.describe(), getQualifiedName()))
		{
			return true;
		}
		Optional superClass = getSuperClass();
		if (superClass.isPresent())
		{
			ResolvedReferenceType resolvedReferenceType = (ResolvedReferenceType)superClass.get();
			if (resolvedReferenceType.isAssignableBy(type))
			{
				return true;
			}
		}
		Iterator iterator = getInterfaces().iterator();
		while (iterator.hasNext())
		{
			ResolvedReferenceType resolvedReferenceType2 = (ResolvedReferenceType)iterator.next();
			if (resolvedReferenceType2.isAssignableBy(type))
			{
				return true;
			}
		}
		return false;
	}

	
	
	public override string getPackageName()
	{
		string packageName = ctClass.getPackageName();
		
		return packageName;
	}

	
	
	private string getSuperclassFQN()
	{
		string superclass = ctClass.getClassFile().getSuperclass();
		
		return superclass;
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

	
	
	private string[] getInterfaceFQNs()
	{
		string[] interfaces = ctClass.getClassFile().getInterfaces();
		
		return interfaces;
	}

	
	
	public override string getQualifiedName()
	{
		string result = java.lang.String.instancehelper_replace(ctClass.getName(), '$', '.');
		
		return result;
	}

	
		
	public override Optional getSuperClass()
	{
		Optional superClass = javassistTypeDeclarationAdapter.getSuperClass();
		
		return superClass;
	}

	
		
	public override List getInterfaces()
	{
		List interfaces = javassistTypeDeclarationAdapter.getInterfaces();
		
		return interfaces;
	}

	
		
	public override Set internalTypes()
	{
		Set result = javassistTypeDeclarationAdapter.internalTypes();
		
		return result;
	}

	
	
	
	private static bool lambda_0024getInternalType_00240(string P_0, ResolvedReferenceTypeDeclaration P_1)
	{
		bool result = java.lang.String.instancehelper_endsWith(P_1.getName(), P_0);
		
		return result;
	}

	
	
	
	private static UnsolvedSymbolException lambda_0024getInternalType_00241(string P_0)
	{
		UnsolvedSymbolException result = new UnsolvedSymbolException(new StringBuilder().append("Internal type not found: ").append(P_0).ToString());
		
		return result;
	}

	
	
	
	private static bool lambda_0024hasInternalType_00242(string P_0, ResolvedReferenceTypeDeclaration P_1)
	{
		bool result = java.lang.String.instancehelper_endsWith(P_1.getName(), P_0);
		
		return result;
	}

	
	[LineNumberTable(new byte[]
	{
		10, 104, 99, 139, 127, 1, 159, 11, 103, 103,
		110
	})]
	public JavassistClassDeclaration(CtClass ctClass, TypeSolver typeSolver)
	{
		if (ctClass == null)
		{
			
			throw new IllegalArgumentException();
		}
		if (ctClass.isInterface() || ctClass.isAnnotation() || ctClass.isPrimitive() || ctClass.isEnum())
		{
			string s = new StringBuilder().append("Trying to instantiate a JavassistClassDeclaration with something which is not a class: ").append(ctClass.ToString()).ToString();
			
			throw new IllegalArgumentException(s);
		}
		this.ctClass = ctClass;
		this.typeSolver = typeSolver;
		javassistTypeDeclarationAdapter = new JavassistTypeDeclarationAdapter(ctClass, typeSolver, this);
	}

	
	
	protected internal override ResolvedReferenceType @object()
	{
		ReferenceTypeImpl.___003Cclinit_003E();
		ReferenceTypeImpl result = new ReferenceTypeImpl(typeSolver.getSolvedJavaLangObject(), typeSolver);
		
		return result;
	}

	
	
	public override bool hasDirectlyAnnotation(string canonicalName)
	{
		bool result = ctClass.hasAnnotation(canonicalName);
		
		return result;
	}

	
		
	public override Set getDeclaredMethods()
	{
		Set declaredMethods = javassistTypeDeclarationAdapter.getDeclaredMethods();
		
		return declaredMethods;
	}

	
	
	public override bool isAssignableBy(ResolvedReferenceTypeDeclaration other)
	{
		ReferenceTypeImpl.___003Cclinit_003E();
		bool result = isAssignableBy(new ReferenceTypeImpl(other, typeSolver));
		
		return result;
	}

	
	
	public override bool Equals(object o)
	{
		if (this == o)
		{
			return true;
		}
		if (o == null || ((object)this).GetType() != o.GetType())
		{
			return false;
		}
		JavassistClassDeclaration javassistClassDeclaration = (JavassistClassDeclaration)o;
		bool result = java.lang.Object.instancehelper_equals(ctClass, javassistClassDeclaration.ctClass);
		
		return result;
	}

	
	
	public override int GetHashCode()
	{
		int result = java.lang.Object.instancehelper_hashCode(ctClass);
		
		return result;
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

	
	
		[LineNumberTable(new byte[]
	{
		84, 121, 110, 15, 230, 70, 104, 107, 105, 163,
		104, 121, 107, 105, 227, 61, 232, 71
	})]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual SymbolReference solveSymbol(string name, TypeSolver typeSolver)
	{
		CtField[] declaredFields = ctClass.getDeclaredFields();
		int num = declaredFields.Length;
		for (int i = 0; i < num; i++)
		{
			CtField ctField = declaredFields[i];
			if (java.lang.String.instancehelper_equals(ctField.getName(), name))
			{
				SymbolReference result = SymbolReference.solved(new JavassistFieldDeclaration(ctField, typeSolver));
				
				return result;
			}
		}
		string superclassFQN = getSuperclassFQN();
		SymbolReference symbolReference = solveSymbolForFQN(name, superclassFQN);
		if (symbolReference.isSolved())
		{
			return symbolReference;
		}
		string[] interfaceFQNs = getInterfaceFQNs();
		string[] array = interfaceFQNs;
		int num2 = array.Length;
		for (int j = 0; j < num2; j++)
		{
			string text = array[j];
			SymbolReference symbolReference2 = solveSymbolForFQN(name, text);
			if (symbolReference2.isSolved())
			{
				return symbolReference2;
			}
		}
		SymbolReference result2 = SymbolReference.unsolved(ClassLiteral<ResolvedValueDeclaration>.Value);
		
		return result2;
	}

	
		
	public override List getAncestors(bool acceptIncompleteList)
	{
		List ancestors = javassistTypeDeclarationAdapter.getAncestors(acceptIncompleteList);
		
		return ancestors;
	}

	
	
		
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public override SymbolReference solveMethod(string name, List argumentsTypes, bool staticOnly)
	{
		SymbolReference result = JavassistUtils.solveMethod(name, argumentsTypes, staticOnly, typeSolver, this, ctClass);
		
		return result;
	}

	
	
	public virtual ResolvedType getUsage(Node node)
	{
		ReferenceTypeImpl.___003Cclinit_003E();
		ReferenceTypeImpl result = new ReferenceTypeImpl(this, typeSolver);
		
		return result;
	}

	public override bool isTypeParameter()
	{
		return false;
	}

	
		
	public override List getAllFields()
	{
		List declaredFields = javassistTypeDeclarationAdapter.getDeclaredFields();
		
		return declaredFields;
	}

	
	
	public override string getName()
	{
		string[] array = java.lang.String.instancehelper_split(java.lang.String.instancehelper_replace(ctClass.getSimpleName(), '$', '.'), "\\.");
		return array[(nint)array.LongLength - 1];
	}

	public override bool isField()
	{
		return false;
	}

	public override bool isParameter()
	{
		return false;
	}

	public override bool isType()
	{
		return true;
	}

	
	
	public override bool isClass()
	{
		return (!ctClass.isInterface()) ? true : false;
	}

	
	
	public override bool isInterface()
	{
		bool result = ctClass.isInterface();
		
		return result;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("JavassistClassDeclaration {").append(ctClass.getName()).append('}')
			.ToString();
		
		return result;
	}

	
		
	public override List getTypeParameters()
	{
		List typeParameters = javassistTypeDeclarationAdapter.getTypeParameters();
		
		return typeParameters;
	}

	
	
	public override AccessSpecifier accessSpecifier()
	{
		AccessSpecifier result = JavassistFactory.modifiersToAccessLevel(ctClass.getModifiers());
		
		return result;
	}

	
		
	public override List getConstructors()
	{
		List constructors = javassistTypeDeclarationAdapter.getConstructors();
		
		return constructors;
	}

	
		
	public override Optional containerType()
	{
		Optional result = javassistTypeDeclarationAdapter.containerType();
		
		return result;
	}

	
	
	public override ResolvedReferenceTypeDeclaration getInternalType(string name)
	{
		Optional optional = internalTypes().stream().filter(new ___003C_003EAnon0(name)).findFirst();
		return (ResolvedReferenceTypeDeclaration)optional.orElseThrow(new ___003C_003EAnon1(name));
	}

	
	
	public override bool hasInternalType(string name)
	{
		bool result = internalTypes().stream().anyMatch(new ___003C_003EAnon2(name));
		
		return result;
	}

	
		
	public override Optional toAst()
	{
		Optional result = Optional.empty();
		
		return result;
	}
}
