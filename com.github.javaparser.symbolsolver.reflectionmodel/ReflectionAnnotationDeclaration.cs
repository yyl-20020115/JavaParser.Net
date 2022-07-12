
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.core.resolution;
using com.github.javaparser.symbolsolver.logic;
using com.github.javaparser.symbolsolver.model.resolution;

using ikvm.@internal;
using java.lang;
using java.lang.annotation;
using java.lang.reflect;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.symbolsolver.reflectionmodel;


public class ReflectionAnnotationDeclaration : AbstractTypeDeclaration, ResolvedAnnotationDeclaration, ResolvedReferenceTypeDeclaration, ResolvedTypeDeclaration, ResolvedDeclaration, ResolvedTypeParametrizable, AssociableToAST, MethodUsageResolutionCapability, MethodResolutionCapability
{
	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	
	private sealed class ___003C_003EAnon1 : Function
	{
		private readonly ReflectionAnnotationDeclaration arg_00241;

		internal ___003C_003EAnon1(ReflectionAnnotationDeclaration P_0)
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

	
	private sealed class ___003C_003EAnon2 : Function
	{
		private readonly ReflectionAnnotationDeclaration arg_00241;

		internal ___003C_003EAnon2(ReflectionAnnotationDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			ReflectionAnnotationMemberDeclaration result = arg_00241.lambda_0024getAnnotationMembers_00241((Method)P_0);
			
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

	
		
	public ReflectionAnnotationDeclaration(Class clazz, TypeSolver typeSolver)
	{
		if (!clazz.isAnnotation())
		{
			
			throw new IllegalArgumentException("The given type is not an annotation.");
		}
		this.clazz = clazz;
		this.typeSolver = typeSolver;
		reflectionClassAdapter = new ReflectionClassAdapter(clazz, typeSolver, this);
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

	
	
	
	private ReflectionAnnotationMemberDeclaration lambda_0024getAnnotationMembers_00241(Method P_0)
	{
		ReflectionAnnotationMemberDeclaration.___003Cclinit_003E();
		ReflectionAnnotationMemberDeclaration result = new ReflectionAnnotationMemberDeclaration(P_0, typeSolver);
		
		return result;
	}

	
	
	public override string getPackageName()
	{
		if (clazz.getPackage() != null)
		{
			string name = clazz.getPackage().getName();
			
			return name;
		}
		return "";
	}

	
	
	public override string getClassName()
	{
		string qualifiedName = getQualifiedName();
		CharSequence s = default(CharSequence);
		object obj = (s.___003Cref_003E = ".");
		if (String.instancehelper_contains(qualifiedName, s))
		{
			string result = String.instancehelper_substring(qualifiedName, String.instancehelper_lastIndexOf(qualifiedName, "."), String.instancehelper_length(qualifiedName));
			
			return result;
		}
		return qualifiedName;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append(Object.instancehelper_getClass(this).getSimpleName()).append("{clazz=").append(clazz.getCanonicalName())
			.append('}')
			.ToString();
		
		return result;
	}

	
	
	public override bool Equals(object o)
	{
		if (this == o)
		{
			return true;
		}
		if (!(o is ReflectionAnnotationDeclaration))
		{
			return false;
		}
		ReflectionAnnotationDeclaration reflectionAnnotationDeclaration = (ReflectionAnnotationDeclaration)o;
		bool result = String.instancehelper_equals(clazz.getCanonicalName(), reflectionAnnotationDeclaration.clazz.getCanonicalName());
		
		return result;
	}

	
	
	public override int GetHashCode()
	{
		int result = String.instancehelper_hashCode(clazz.getCanonicalName());
		
		return result;
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
		bool result = reflectionClassAdapter.hasDirectlyAnnotation(canonicalName);
		
		return result;
	}

	
		
	public override List getAllFields()
	{
		List allFields = reflectionClassAdapter.getAllFields();
		
		return allFields;
	}

	
		
	public override List getAncestors(bool acceptIncompleteList)
	{
		List ancestors = reflectionClassAdapter.getAncestors();
		
		return ancestors;
	}

	
		
	public override Set getDeclaredMethods()
	{
		
		throw new UnsupportedOperationException();
	}

	
	
	public override string getName()
	{
		string simpleName = clazz.getSimpleName();
		
		return simpleName;
	}

	
		
	public override Optional containerType()
	{
		string message = new StringBuilder().append("containerType() is not supported for ").append(Object.instancehelper_getClass(this).getCanonicalName()).ToString();
		
		throw new UnsupportedOperationException(message);
	}

	
		
	public override List getTypeParameters()
	{
		List result = Collections.emptyList();
		
		return result;
	}

	
		
	public override Set internalTypes()
	{
		return (Set)Arrays.stream(clazz.getDeclaredClasses(ReflectionAnnotationDeclaration.___003CGetCallerID_003E())).map(new ___003C_003EAnon1(this)).collect(Collectors.toSet());
	}

	
		
	public override List getConstructors()
	{
		List result = Collections.emptyList();
		
		return result;
	}

	
		
	public virtual List getAnnotationMembers()
	{
		return (List)Stream.of(clazz.getDeclaredMethods(ReflectionAnnotationDeclaration.___003CGetCallerID_003E())).map(new ___003C_003EAnon2(this)).collect(Collectors.toList());
	}

	
		
	public virtual Optional toAst()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
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

	
		
	public virtual SymbolReference solveMethod(string name, List argumentsTypes, bool staticOnly)
	{
		SymbolReference result = ReflectionMethodResolutionLogic.solveMethod(name, argumentsTypes, staticOnly, typeSolver, this, clazz);
		
		return result;
	}

	
	
	public virtual bool isInheritable()
	{
		return clazz.getAnnotation(ClassLiteral<Inherited>.Value) != null;
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


	public override ResolvedReferenceTypeDeclaration getInternalType(string P_0)
	{
		return ResolvedTypeDeclaration._003Cdefault_003EgetInternalType(this, P_0);
	}


	public override bool hasInternalType(string P_0)
	{
		return ResolvedTypeDeclaration._003Cdefault_003EhasInternalType(this, P_0);
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
		return ResolvedTypeDeclaration._003Cdefault_003EisEnum(this);
	}


	public override bool isAnnotation()
	{
		return ResolvedAnnotationDeclaration._003Cdefault_003EisAnnotation(this);
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
		return ResolvedTypeDeclaration._003Cdefault_003EasEnum(this);
	}


	public override ResolvedAnnotationDeclaration asAnnotation()
	{
		return ResolvedAnnotationDeclaration._003Cdefault_003EasAnnotation(this);
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


	public override ResolvedFieldDeclaration getField(string P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetField(this, P_0);
	}


	public override ResolvedFieldDeclaration getVisibleField(string P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetVisibleField(this, P_0);
	}


	public override bool hasField(string P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EhasField(this, P_0);
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

	static CallerID ___003CGetCallerID_003E()
	{
		if (___003CcallerID_003E == null)
		{
			___003CcallerID_003E = new ___003CCallerID_003E();
		}
		return ___003CcallerID_003E;
	}
}
