using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.core.resolution;
using com.github.javaparser.symbolsolver.logic;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.model.typesystem;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.lang.reflect;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.symbolsolver.reflectionmodel;


public class ReflectionEnumDeclaration : AbstractTypeDeclaration, ResolvedEnumDeclaration, ResolvedReferenceTypeDeclaration, ResolvedTypeDeclaration, ResolvedDeclaration, ResolvedTypeParametrizable, HasAccessSpecifier, MethodResolutionCapability, MethodUsageResolutionCapability
{
	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	
	private sealed class ___003C_003EAnon1 : Predicate
	{
		internal ___003C_003EAnon1()
		{
		}

		public bool test(object P_0)
		{
			bool result = ((Field)P_0).isEnumConstant();
			
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
		private readonly ReflectionEnumDeclaration arg_00241;

		internal ___003C_003EAnon2(ReflectionEnumDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			ReflectionEnumConstantDeclaration result = arg_00241.lambda_0024getEnumConstants_00240((Field)P_0);
			
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

	
	private sealed class ___003C_003EAnon3 : Function
	{
		private readonly ReflectionEnumDeclaration arg_00241;

		internal ___003C_003EAnon3(ReflectionEnumDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			ResolvedReferenceTypeDeclaration result = arg_00241.lambda_0024internalTypes_00241((Class)P_0);
			
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

		private Class clazz;

	private TypeSolver typeSolver;

	private ReflectionClassAdapter reflectionClassAdapter;

	
	private static CallerID ___003CcallerID_003E;

	
		[LineNumberTable(new byte[]
	{
		11, 104, 99, 144, 104, 144, 104, 144, 104, 144,
		104, 144, 103, 103, 110
	})]
	public ReflectionEnumDeclaration(Class clazz, TypeSolver typeSolver)
	{
		if (clazz == null)
		{
			
			throw new IllegalArgumentException("Class should not be null");
		}
		if (clazz.isInterface())
		{
			
			throw new IllegalArgumentException("Class should not be an interface");
		}
		if (clazz.isPrimitive())
		{
			
			throw new IllegalArgumentException("Class should not represent a primitive class");
		}
		if (clazz.isArray())
		{
			
			throw new IllegalArgumentException("Class should not be an array");
		}
		if (!clazz.isEnum())
		{
			
			throw new IllegalArgumentException("Class should be an enum");
		}
		this.clazz = clazz;
		this.typeSolver = typeSolver;
		reflectionClassAdapter = new ReflectionClassAdapter(clazz, typeSolver, this);
	}

	
	
	public override string getPackageName()
	{
		if (clazz.getPackage() != null)
		{
			string name = clazz.getPackage().getName();
			
			return name;
		}
		return null;
	}

	
	
	public override bool isAssignableBy(ResolvedType type)
	{
		bool result = reflectionClassAdapter.isAssignableBy(type);
		
		return result;
	}

	
	
	
	private ReflectionEnumConstantDeclaration lambda_0024getEnumConstants_00240(Field P_0)
	{
		ReflectionEnumConstantDeclaration result = new ReflectionEnumConstantDeclaration(P_0, typeSolver);
		
		return result;
	}

	
	
	
	private ResolvedReferenceTypeDeclaration lambda_0024internalTypes_00241(Class P_0)
	{
		ResolvedReferenceTypeDeclaration result = ReflectionFactory.typeDeclarationFor(P_0, typeSolver);
		
		return result;
	}

	
	
	public virtual AccessSpecifier accessSpecifier()
	{
		AccessSpecifier result = ReflectionFactory.modifiersToAccessLevel(clazz.getModifiers());
		
		return result;
	}

	
		
	public override Optional containerType()
	{
		Optional result = reflectionClassAdapter.containerType();
		
		return result;
	}

	
	
	public override string getClassName()
	{
		string canonicalName = clazz.getCanonicalName();
		if (canonicalName != null && getPackageName() != null)
		{
			string result = String.instancehelper_substring(canonicalName, String.instancehelper_length(getPackageName()) + 1, String.instancehelper_length(canonicalName));
			
			return result;
		}
		return null;
	}

	
	
	public override string getQualifiedName()
	{
		string canonicalName = clazz.getCanonicalName();
		
		return canonicalName;
	}

	
		
	public override List getAncestors(bool acceptIncompleteList)
	{
		List ancestors = reflectionClassAdapter.getAncestors();
		
		return ancestors;
	}

	
	
	public override ResolvedFieldDeclaration getField(string name)
	{
		ResolvedFieldDeclaration field = reflectionClassAdapter.getField(name);
		
		return field;
	}

	
	
	public override bool hasField(string name)
	{
		bool result = reflectionClassAdapter.hasField(name);
		
		return result;
	}

	
		
	public override List getAllFields()
	{
		List allFields = reflectionClassAdapter.getAllFields();
		
		return allFields;
	}

	
		
	public override Set getDeclaredMethods()
	{
		Set declaredMethods = reflectionClassAdapter.getDeclaredMethods();
		
		return declaredMethods;
	}

	
	
	public override bool isAssignableBy(ResolvedReferenceTypeDeclaration other)
	{
		ReferenceTypeImpl.___003Cclinit_003E();
		bool result = isAssignableBy(new ReferenceTypeImpl(other, typeSolver));
		
		return result;
	}

	
	
	public override bool hasDirectlyAnnotation(string qualifiedName)
	{
		bool result = reflectionClassAdapter.hasDirectlyAnnotation(qualifiedName);
		
		return result;
	}

	
	
	public override string getName()
	{
		string simpleName = clazz.getSimpleName();
		
		return simpleName;
	}

	
		
	public override List getTypeParameters()
	{
		List typeParameters = reflectionClassAdapter.getTypeParameters();
		
		return typeParameters;
	}

	
		
	public virtual SymbolReference solveMethod(string name, List parameterTypes, bool staticOnly)
	{
		SymbolReference result = ReflectionMethodResolutionLogic.solveMethod(name, parameterTypes, staticOnly, typeSolver, this, clazz);
		
		return result;
	}

	
		[LineNumberTable(new byte[]
	{
		160, 64, 152, 139, 107, 108, 98, 103, 127, 0,
		169, 114, 100, 130, 110, 110, 61, 168, 111, 120,
		97, 166
	})]
	public virtual Optional solveMethodAsUsage(string name, List parameterTypes, Context invokationContext, List typeParameterValues)
	{
		//Discarded unreachable code: IL_00db
		Optional optional = ReflectionMethodResolutionLogic.solveMethodAsUsage(name, parameterTypes, typeSolver, invokationContext, typeParameterValues, this, clazz);
		if (optional.isPresent())
		{
			InferenceContext inferenceContext = new InferenceContext(MyObjectProvider.___003C_003EINSTANCE);
			MethodUsage methodUsage = (MethodUsage)optional.get();
			int num = 0;
			LinkedList linkedList = new LinkedList();
			Iterator iterator = parameterTypes.iterator();
			while (iterator.hasNext())
			{
				ResolvedType actual = (ResolvedType)iterator.next();
				ResolvedType paramType = methodUsage.getParamType(num);
				((List)linkedList).add((object)inferenceContext.addPair(paramType, actual));
				num++;
			}
			try
			{
				ResolvedType type = inferenceContext.addSingle(methodUsage.returnType());
				for (int i = 0; i < ((List)linkedList).size(); i++)
				{
					methodUsage = methodUsage.replaceParamType(i, inferenceContext.resolve((ResolvedType)((List)linkedList).get(i)));
				}
				methodUsage = methodUsage.replaceReturnType(inferenceContext.resolve(type));
				return Optional.of(methodUsage);
			}
			catch (ConfilictingGenericTypesException)
			{
			}
			
			return Optional.empty();
		}
		return optional;
	}

	
		
	public virtual List getEnumConstants()
	{
		return (List)Arrays.stream(clazz.getFields(ReflectionEnumDeclaration.___003CGetCallerID_003E())).filter(new ___003C_003EAnon1()).map(new ___003C_003EAnon2(this))
			.collect(Collectors.toList());
	}

	
		
	public override Set internalTypes()
	{
		return (Set)Arrays.stream(clazz.getDeclaredClasses(ReflectionEnumDeclaration.___003CGetCallerID_003E())).map(new ___003C_003EAnon3(this)).collect(Collectors.toSet());
	}

	
		
	public override List getConstructors()
	{
		List constructors = reflectionClassAdapter.getConstructors();
		
		return constructors;
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
	public override ResolvedReferenceTypeDeclaration getInternalType(string P_0)
	{
		return ResolvedTypeDeclaration._003Cdefault_003EgetInternalType(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool hasInternalType(string P_0)
	{
		return ResolvedTypeDeclaration._003Cdefault_003EhasInternalType(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isClass()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EisClass(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isInterface()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EisInterface(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isEnum()
	{
		return ResolvedEnumDeclaration._003Cdefault_003EisEnum(this);
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
	public override ResolvedInterfaceDeclaration asInterface()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EasInterface(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedEnumDeclaration asEnum()
	{
		return ResolvedEnumDeclaration._003Cdefault_003EasEnum(this);
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
	public override ResolvedFieldDeclaration getVisibleField(string P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetVisibleField(this, P_0);
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
	public virtual bool hasEnumConstant(string P_0)
	{
		return ResolvedEnumDeclaration._003Cdefault_003EhasEnumConstant(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedEnumConstantDeclaration getEnumConstant(string P_0)
	{
		return ResolvedEnumDeclaration._003Cdefault_003EgetEnumConstant(this, P_0);
	}

	static CallerID ___003CGetCallerID_003E()
	{
		if (___003CcallerID_003E == null)
		{
			___003CcallerID_003E = new ___003CCallerID_003E();
		}
		return ___003CcallerID_003E;
	}
}
