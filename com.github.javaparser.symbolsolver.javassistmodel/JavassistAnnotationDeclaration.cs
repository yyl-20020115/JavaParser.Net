
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.logic;
using com.github.javaparser.symbolsolver.model.resolution;

using ikvm.@internal;
using java.lang;
using java.lang.annotation;
using java.util;
using java.util.function;
using java.util.stream;
using javassist;

namespace com.github.javaparser.symbolsolver.javassistmodel;


public class JavassistAnnotationDeclaration : AbstractTypeDeclaration, ResolvedAnnotationDeclaration, ResolvedReferenceTypeDeclaration, ResolvedTypeDeclaration, ResolvedDeclaration, ResolvedTypeParametrizable, AssociableToAST
{
	
	private sealed class ___003C_003EAnon0 : Function
	{
		private readonly JavassistAnnotationDeclaration arg_00241;

		internal ___003C_003EAnon0(JavassistAnnotationDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			JavassistAnnotationMemberDeclaration result = arg_00241.lambda_0024getAnnotationMembers_00240((CtMethod)P_0);
			
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

	
	
	public override string getQualifiedName()
	{
		string result = String.instancehelper_replace(ctClass.getName(), '$', '.');
		
		return result;
	}

	
	
	public override string getClassName()
	{
		string qualifiedName = getQualifiedName();
		CharSequence s = default(CharSequence);
		object obj = (s.___003Cref_003E = ".");
		if (String.instancehelper_contains(qualifiedName, s))
		{
			string result = String.instancehelper_substring(qualifiedName, String.instancehelper_lastIndexOf(qualifiedName, ".") + 1, String.instancehelper_length(qualifiedName));
			
			return result;
		}
		return qualifiedName;
	}

	
	
	
	private JavassistAnnotationMemberDeclaration lambda_0024getAnnotationMembers_00240(CtMethod P_0)
	{
		JavassistAnnotationMemberDeclaration.___003Cclinit_003E();
		JavassistAnnotationMemberDeclaration result = new JavassistAnnotationMemberDeclaration(P_0, typeSolver);
		
		return result;
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

	
	
	public JavassistAnnotationDeclaration(CtClass ctClass, TypeSolver typeSolver)
	{
		if (!ctClass.isAnnotation())
		{
			string s = new StringBuilder().append("Not an annotation: ").append(ctClass.getName()).ToString();
			
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

	
	
	public override bool isAssignableBy(ResolvedType type)
	{
		
		throw new UnsupportedOperationException();
	}

	
		
	public override List getAllFields()
	{
		List declaredFields = javassistTypeDeclarationAdapter.getDeclaredFields();
		
		return declaredFields;
	}

	
	
	public override bool isAssignableBy(ResolvedReferenceTypeDeclaration other)
	{
		
		throw new UnsupportedOperationException();
	}

	
		
	public override List getAncestors(bool acceptIncompleteList)
	{
		List ancestors = javassistTypeDeclarationAdapter.getAncestors(acceptIncompleteList);
		
		return ancestors;
	}

	
		
	public override Set internalTypes()
	{
		Set result = javassistTypeDeclarationAdapter.internalTypes();
		
		return result;
	}

	
		
	public override Set getDeclaredMethods()
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
		string className = getClassName();
		
		return className;
	}

	
		
	public override List getTypeParameters()
	{
		List result = Collections.emptyList();
		
		return result;
	}

	
		
	public override Optional containerType()
	{
		string message = new StringBuilder().append("containerType() is not supported for ").append(Object.instancehelper_getClass(this).getCanonicalName()).ToString();
		
		throw new UnsupportedOperationException(message);
	}

	
		
	public override List getConstructors()
	{
		List result = Collections.emptyList();
		
		return result;
	}

	
		
	public virtual List getAnnotationMembers()
	{
		return (List)Stream.of(ctClass.getDeclaredMethods()).map(new ___003C_003EAnon0(this)).collect(Collectors.toList());
	}

	
		
	public virtual Optional toAst()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
	
	public virtual bool isInheritable()
	{
		//Discarded unreachable code: IL_0018
		try
		{
			return ctClass.getAnnotation(ClassLiteral<Inherited>.Value) != null;
		}
		catch (java.lang.ClassNotFoundException)
		{
		}
		
		return false;
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
}
