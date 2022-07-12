
using com.github.javaparser.ast;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.model.resolution;

using java.util;
using java.util.function;

namespace com.github.javaparser.symbolsolver.logic;


public abstract class AbstractClassDeclaration : AbstractTypeDeclaration, ResolvedClassDeclaration, ResolvedReferenceTypeDeclaration, ResolvedTypeDeclaration, ResolvedDeclaration, ResolvedTypeParametrizable, HasAccessSpecifier, AssociableToAST, MethodResolutionCapability
{
	
	private sealed class ___003C_003EAnon0 : Consumer
	{
		private readonly List arg_00241;

		internal ___003C_003EAnon0(List P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			lambda_0024getAllSuperClasses_00240(arg_00241, (ResolvedReferenceType)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Predicate
	{
		internal ___003C_003EAnon1()
		{
		}

		public bool test(object P_0)
		{
			bool result = ((ResolvedReferenceType)P_0).isJavaLangObject();
			
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

	
	private sealed class ___003C_003EAnon2 : Consumer
	{
		private readonly List arg_00241;

		internal ___003C_003EAnon2(List P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			lambda_0024getAllInterfaces_00241(arg_00241, (ResolvedReferenceType)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}


	public override ResolvedReferenceTypeDeclaration asReferenceType()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EasReferenceType(this);
	}


	public abstract override Set getDeclaredMethods();


	public override bool isJavaLangObject()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EisJavaLangObject(this);
	}


	public override List getAncestors()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetAncestors(this);
	}


	public override bool hasField(string P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EhasField(this, P_0);
	}


	public override ResolvedFieldDeclaration getField(string P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetField(this, P_0);
	}


	public abstract override string getQualifiedName();


	public abstract Optional getSuperClass();

	protected internal abstract ResolvedReferenceType @object();


	public abstract List getInterfaces();

	
	
	
	private static void lambda_0024getAllSuperClasses_00240(List P_0, ResolvedReferenceType P_1)
	{
		P_0.add(P_1);
		P_0.addAll(P_1.getAllClassesAncestors());
	}

	
	
	
	private static void lambda_0024getAllInterfaces_00241(List P_0, ResolvedReferenceType P_1)
	{
		P_0.addAll(P_1.getAllInterfacesAncestors());
	}

	
	
	public AbstractClassDeclaration()
	{
	}

	
	
	public override bool hasName()
	{
		return getQualifiedName() != null;
	}

	
		
	public List getAllSuperClasses()
	{
		ArrayList arrayList = new ArrayList();
		getSuperClass().ifPresent(new ___003C_003EAnon0(arrayList));
		if (((Collection)arrayList).removeIf((Predicate)new ___003C_003EAnon1()))
		{
			((List)arrayList).add((object)@object());
		}
		return arrayList;
	}

	
		
	public List getAllInterfaces()
	{
		ArrayList arrayList = new ArrayList();
		Iterator iterator = getInterfaces().iterator();
		while (iterator.hasNext())
		{
			ResolvedReferenceType resolvedReferenceType = (ResolvedReferenceType)iterator.next();
			((List)arrayList).add((object)resolvedReferenceType);
			((List)arrayList).addAll((Collection)resolvedReferenceType.getAllInterfacesAncestors());
		}
		getSuperClass().ifPresent(new ___003C_003EAnon2(arrayList));
		return arrayList;
	}

	public sealed override ResolvedClassDeclaration asClass()
	{
		return this;
	}


	public abstract override string getName();


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


	public override Set internalTypes()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EinternalTypes(this);
	}


	public override ResolvedReferenceTypeDeclaration getInternalType(string P_0)
	{
		return ResolvedTypeDeclaration._003Cdefault_003EgetInternalType(this, P_0);
	}


	public override bool hasInternalType(string P_0)
	{
		return ResolvedTypeDeclaration._003Cdefault_003EhasInternalType(this, P_0);
	}


	public abstract override Optional containerType();


	public override bool isClass()
	{
		return ResolvedClassDeclaration._003Cdefault_003EisClass(this);
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
		return ResolvedTypeDeclaration._003Cdefault_003EasAnnotation(this);
	}


	public override ResolvedTypeParameterDeclaration asTypeParameter()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EasTypeParameter(this);
	}


	public abstract override string getPackageName();


	public abstract override string getClassName();


	public override string getId()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EgetId(this);
	}


	public abstract override List getTypeParameters();


	public override Optional findTypeParameter(string P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EfindTypeParameter(this, P_0);
	}


	public override bool isGeneric()
	{
		return ResolvedTypeParametrizable._003Cdefault_003EisGeneric(this);
	}


	public abstract override List getAncestors(bool P_0);


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


	public abstract override List getAllFields();


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


	public abstract override bool isAssignableBy(ResolvedType P_0);


	public override bool canBeAssignedTo(ResolvedReferenceTypeDeclaration P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EcanBeAssignedTo(this, P_0);
	}


	public abstract override bool isAssignableBy(ResolvedReferenceTypeDeclaration P_0);


	public abstract override bool hasDirectlyAnnotation(string P_0);


	public override bool hasAnnotation(string P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EhasAnnotation(this, P_0);
	}


	public abstract override List getConstructors();


	public override bool isJavaLangEnum()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EisJavaLangEnum(this);
	}


	public abstract AccessSpecifier accessSpecifier();


	public virtual Optional toAst()
	{
		return AssociableToAST._003Cdefault_003EtoAst(this);
	}


	public abstract SymbolReference solveMethod(string P_0, List P_1, bool P_2);
}
