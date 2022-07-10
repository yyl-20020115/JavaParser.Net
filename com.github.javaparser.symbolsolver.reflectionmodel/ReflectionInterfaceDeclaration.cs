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
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.lang.reflect;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.symbolsolver.reflectionmodel;


public class ReflectionInterfaceDeclaration : AbstractTypeDeclaration, ResolvedInterfaceDeclaration, ResolvedReferenceTypeDeclaration, ResolvedTypeDeclaration, ResolvedDeclaration, ResolvedTypeParametrizable, HasAccessSpecifier, AssociableToAST, MethodResolutionCapability, MethodUsageResolutionCapability
{
	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	
	private sealed class ___003C_003EAnon1 : Function
	{
		private readonly ReflectionInterfaceDeclaration arg_00241;

		internal ___003C_003EAnon1(ReflectionInterfaceDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			ResolvedReferenceTypeDeclaration result = arg_00241.lambda_0024internalTypes_00240((Class)P_0);
			
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

	
		
	public ReflectionInterfaceDeclaration(Class clazz, TypeSolver typeSolver)
	{
		if (!clazz.isInterface())
		{
			
			throw new IllegalArgumentException();
		}
		this.clazz = clazz;
		this.typeSolver = typeSolver;
		reflectionClassAdapter = new ReflectionClassAdapter(clazz, typeSolver, this);
	}

	
	[LineNumberTable(new byte[]
	{
		160, 65, 104, 137, 115, 130, 115, 120, 130, 121,
		116, 2, 230, 70, 136, 162
	})]
	public override bool canBeAssignedTo(ResolvedReferenceTypeDeclaration other)
	{
		if (other is LambdaArgumentTypePlaceholder)
		{
			bool result = isFunctionalInterface();
			
			return result;
		}
		if (java.lang.String.instancehelper_equals(other.getQualifiedName(), getQualifiedName()))
		{
			return true;
		}
		if (clazz.getSuperclass() != null && new ReflectionInterfaceDeclaration(clazz.getSuperclass(), typeSolver).canBeAssignedTo(other))
		{
			return true;
		}
		Class[] interfaces = clazz.getInterfaces();
		int num = interfaces.Length;
		for (int i = 0; i < num; i++)
		{
			Class @class = interfaces[i];
			if (new ReflectionInterfaceDeclaration(@class, typeSolver).canBeAssignedTo(other))
			{
				return true;
			}
		}
		if (other.isJavaLangObject())
		{
			return true;
		}
		return false;
	}

	
	[LineNumberTable(new byte[]
	{
		160, 91, 104, 130, 104, 137, 104, 130, 104, 130,
		115, 130, 104, 103, 109, 217
	})]
	public override bool isAssignableBy(ResolvedType type)
	{
		if (type is NullType)
		{
			return true;
		}
		if (type is LambdaArgumentTypePlaceholder)
		{
			bool result = isFunctionalInterface();
			
			return result;
		}
		if (type.isArray())
		{
			return false;
		}
		if (type.isPrimitive())
		{
			return false;
		}
		if (java.lang.String.instancehelper_equals(type.describe(), getQualifiedName()))
		{
			return true;
		}
		if (type is ReferenceTypeImpl)
		{
			ReferenceTypeImpl referenceTypeImpl = (ReferenceTypeImpl)type;
			if (referenceTypeImpl.getTypeDeclaration().isPresent())
			{
				bool result2 = ((ResolvedReferenceTypeDeclaration)referenceTypeImpl.getTypeDeclaration().get()).canBeAssignedTo(this);
				
				return result2;
			}
		}
		return false;
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

	
		
	public override List getTypeParameters()
	{
		List typeParameters = reflectionClassAdapter.getTypeParameters();
		
		return typeParameters;
	}

	
	
	public override string getQualifiedName()
	{
		string canonicalName = clazz.getCanonicalName();
		
		return canonicalName;
	}

	
	
	
	private ResolvedReferenceTypeDeclaration lambda_0024internalTypes_00240(Class P_0)
	{
		ResolvedReferenceTypeDeclaration result = ReflectionFactory.typeDeclarationFor(P_0, typeSolver);
		
		return result;
	}

	
	
	public override bool isAssignableBy(ResolvedReferenceTypeDeclaration other)
	{
		ReferenceTypeImpl.___003Cclinit_003E();
		bool result = isAssignableBy(new ReferenceTypeImpl(other, typeSolver));
		
		return result;
	}

	
	
	public override string getClassName()
	{
		string canonicalName = clazz.getCanonicalName();
		if (canonicalName != null && getPackageName() != null)
		{
			string result = java.lang.String.instancehelper_substring(canonicalName, java.lang.String.instancehelper_length(getPackageName()) + 1);
			
			return result;
		}
		return null;
	}

	
	
		
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual SymbolReference solveMethod(string name, List parameterTypes, bool staticOnly)
	{
		SymbolReference result = ReflectionMethodResolutionLogic.solveMethod(name, parameterTypes, staticOnly, typeSolver, this, clazz);
		
		return result;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("ReflectionInterfaceDeclaration{clazz=").append(clazz.getCanonicalName()).append('}')
			.ToString();
		
		return result;
	}

	
	
	public virtual ResolvedType getUsage(Node node)
	{
		ReferenceTypeImpl.___003Cclinit_003E();
		ReferenceTypeImpl result = new ReferenceTypeImpl(this, typeSolver);
		
		return result;
	}

	
	
	public override bool Equals(object o)
	{
		if (this == o)
		{
			return true;
		}
		if (!(o is ReflectionInterfaceDeclaration))
		{
			return false;
		}
		ReflectionInterfaceDeclaration reflectionInterfaceDeclaration = (ReflectionInterfaceDeclaration)o;
		if (!java.lang.String.instancehelper_equals(clazz.getCanonicalName(), reflectionInterfaceDeclaration.clazz.getCanonicalName()))
		{
			return false;
		}
		if (!getTypeParameters().equals(reflectionInterfaceDeclaration.getTypeParameters()))
		{
			return false;
		}
		return true;
	}

	
	
	public override int GetHashCode()
	{
		int result = java.lang.Object.instancehelper_hashCode(clazz);
		
		return result;
	}

	
		[LineNumberTable(new byte[]
	{
		97, 152, 139, 107, 108, 98, 103, 127, 0, 169,
		114, 100, 130, 110, 110, 61, 168, 111, 120, 97,
		166
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

	public override bool isTypeParameter()
	{
		return false;
	}

	
	
	public override ResolvedFieldDeclaration getField(string name)
	{
		ResolvedFieldDeclaration field = reflectionClassAdapter.getField(name);
		
		return field;
	}

	
		
	public override List getAllFields()
	{
		List allFields = reflectionClassAdapter.getAllFields();
		
		return allFields;
	}

	
	
		
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual SymbolReference solveSymbol(string name, TypeSolver typeSolver)
	{
		Field[] fields = clazz.getFields(ReflectionInterfaceDeclaration.___003CGetCallerID_003E());
		int num = fields.Length;
		for (int i = 0; i < num; i++)
		{
			Field field = fields[i];
			if (java.lang.String.instancehelper_equals(field.getName(), name))
			{
				SymbolReference result = SymbolReference.solved(new ReflectionFieldDeclaration(field, typeSolver));
				
				return result;
			}
		}
		SymbolReference result2 = SymbolReference.unsolved(ClassLiteral<ResolvedValueDeclaration>.Value);
		
		return result2;
	}

	
		
	public override List getAncestors(bool acceptIncompleteList)
	{
		List ancestors = reflectionClassAdapter.getAncestors();
		
		return ancestors;
	}

	
		
	public override Set getDeclaredMethods()
	{
		Set declaredMethods = reflectionClassAdapter.getDeclaredMethods();
		
		return declaredMethods;
	}

	
	
	public override bool hasField(string name)
	{
		bool result = reflectionClassAdapter.hasField(name);
		
		return result;
	}

	
	
	public override string getName()
	{
		string simpleName = clazz.getSimpleName();
		
		return simpleName;
	}

	public override bool isInterface()
	{
		return true;
	}

	
		
	public virtual List getInterfacesExtended()
	{
		ArrayList arrayList = new ArrayList();
		Class[] interfaces = clazz.getInterfaces();
		int num = interfaces.Length;
		for (int i = 0; i < num; i++)
		{
			Class @class = interfaces[i];
			ReferenceTypeImpl.___003Cclinit_003E();
			((List)arrayList).add((object)new ReferenceTypeImpl(new ReflectionInterfaceDeclaration(@class, typeSolver), typeSolver));
		}
		return arrayList;
	}

	
		
	public override Optional containerType()
	{
		Optional result = reflectionClassAdapter.containerType();
		
		return result;
	}

	
		
	public override Set internalTypes()
	{
		return (Set)Arrays.stream(clazz.getDeclaredClasses(ReflectionInterfaceDeclaration.___003CGetCallerID_003E())).map(new ___003C_003EAnon1(this)).collect(Collectors.toSet());
	}

	public override ResolvedInterfaceDeclaration asInterface()
	{
		return this;
	}

	
	
	public override bool hasDirectlyAnnotation(string canonicalName)
	{
		bool result = reflectionClassAdapter.hasDirectlyAnnotation(canonicalName);
		
		return result;
	}

	
	
	public virtual AccessSpecifier accessSpecifier()
	{
		AccessSpecifier result = ReflectionFactory.modifiersToAccessLevel(clazz.getModifiers());
		
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

	static CallerID ___003CGetCallerID_003E()
	{
		if (___003CcallerID_003E == null)
		{
			___003CcallerID_003E = new ___003CCallerID_003E();
		}
		return ___003CcallerID_003E;
	}
}
