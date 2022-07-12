
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.utils;

using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.symbolsolver.logic;


public abstract class AbstractTypeDeclaration : ResolvedReferenceTypeDeclaration, ResolvedTypeDeclaration, ResolvedDeclaration, ResolvedTypeParametrizable
{

	public virtual ResolvedReferenceTypeDeclaration asReferenceType()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EasReferenceType(this);
	}


	public abstract Set getDeclaredMethods();


	public virtual bool isJavaLangObject()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EisJavaLangObject(this);
	}


	public virtual List getAncestors()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetAncestors(this);
	}


	public virtual bool hasField(string P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EhasField(this, P_0);
	}


	public virtual ResolvedFieldDeclaration getField(string P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetField(this, P_0);
	}


	public virtual List getAllAncestors()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetAllAncestors(this);
	}

	
	
	public AbstractTypeDeclaration()
	{
	}

	
		
	public Set getAllMethods()
	{
		HashSet hashSet = new HashSet();
		HashSet hashSet2 = new HashSet();
		Iterator iterator = getDeclaredMethods().iterator();
		while (iterator.hasNext())
		{
			ResolvedMethodDeclaration declaration = (ResolvedMethodDeclaration)iterator.next();
			MethodUsage methodUsage = new MethodUsage(declaration);
			((Set)hashSet).add((object)methodUsage);
			((Set)hashSet2).add((object)methodUsage.getSignature());
		}
		iterator = getAllAncestors().iterator();
		while (iterator.hasNext())
		{
			ResolvedReferenceType resolvedReferenceType = (ResolvedReferenceType)iterator.next();
			List typeParametersMap = resolvedReferenceType.getTypeParametersMap();
			Iterator iterator2 = resolvedReferenceType.getDeclaredMethods().iterator();
			while (iterator2.hasNext())
			{
				MethodUsage methodUsage2 = (MethodUsage)iterator2.next();
				MethodUsage methodUsage3 = methodUsage2;
				Iterator iterator3 = typeParametersMap.iterator();
				while (iterator3.hasNext())
				{
					Pair pair = (Pair)iterator3.next();
					methodUsage3 = methodUsage3.replaceTypeParameter((ResolvedTypeParameterDeclaration)pair.___003C_003Ea, (ResolvedType)pair.___003C_003Eb);
				}
				string signature = methodUsage3.getSignature();
				if (!((Set)hashSet2).contains((object)signature))
				{
					((Set)hashSet2).add((object)signature);
					((Set)hashSet).add((object)methodUsage2);
				}
			}
		}
		return hashSet;
	}

	
	
	public bool isFunctionalInterface()
	{
		bool result = FunctionalInterfaceLogic.getFunctionalMethod(this).isPresent();
		
		return result;
	}


	public virtual bool hasName()
	{
		return ResolvedDeclaration._003Cdefault_003EhasName(this);
	}


	public abstract string getName();


	public virtual bool isField()
	{
		return ResolvedDeclaration._003Cdefault_003EisField(this);
	}


	public virtual bool isVariable()
	{
		return ResolvedDeclaration._003Cdefault_003EisVariable(this);
	}


	public virtual bool isEnumConstant()
	{
		return ResolvedDeclaration._003Cdefault_003EisEnumConstant(this);
	}


	public virtual bool isPattern()
	{
		return ResolvedDeclaration._003Cdefault_003EisPattern(this);
	}


	public virtual bool isParameter()
	{
		return ResolvedDeclaration._003Cdefault_003EisParameter(this);
	}


	public virtual bool isType()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EisType(this);
	}


	public virtual bool isMethod()
	{
		return ResolvedDeclaration._003Cdefault_003EisMethod(this);
	}


	public virtual ResolvedFieldDeclaration asField()
	{
		return ResolvedDeclaration._003Cdefault_003EasField(this);
	}


	public virtual ResolvedParameterDeclaration asParameter()
	{
		return ResolvedDeclaration._003Cdefault_003EasParameter(this);
	}


	public virtual ResolvedTypeDeclaration asType()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EasType(this);
	}


	public virtual ResolvedMethodDeclaration asMethod()
	{
		return ResolvedDeclaration._003Cdefault_003EasMethod(this);
	}


	public virtual ResolvedEnumConstantDeclaration asEnumConstant()
	{
		return ResolvedDeclaration._003Cdefault_003EasEnumConstant(this);
	}


	public virtual ResolvedPatternDeclaration asPattern()
	{
		return ResolvedDeclaration._003Cdefault_003EasPattern(this);
	}


	public virtual Set internalTypes()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EinternalTypes(this);
	}


	public virtual ResolvedReferenceTypeDeclaration getInternalType(string P_0)
	{
		return ResolvedTypeDeclaration._003Cdefault_003EgetInternalType(this, P_0);
	}


	public virtual bool hasInternalType(string P_0)
	{
		return ResolvedTypeDeclaration._003Cdefault_003EhasInternalType(this, P_0);
	}


	public abstract Optional containerType();


	public virtual bool isClass()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EisClass(this);
	}


	public virtual bool isInterface()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EisInterface(this);
	}


	public virtual bool isEnum()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EisEnum(this);
	}


	public virtual bool isAnnotation()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EisAnnotation(this);
	}


	public virtual bool isTypeParameter()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EisTypeParameter(this);
	}


	public virtual bool isAnonymousClass()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EisAnonymousClass(this);
	}


	public virtual ResolvedClassDeclaration asClass()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EasClass(this);
	}


	public virtual ResolvedInterfaceDeclaration asInterface()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EasInterface(this);
	}


	public virtual ResolvedEnumDeclaration asEnum()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EasEnum(this);
	}


	public virtual ResolvedAnnotationDeclaration asAnnotation()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EasAnnotation(this);
	}


	public virtual ResolvedTypeParameterDeclaration asTypeParameter()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EasTypeParameter(this);
	}


	public abstract string getPackageName();


	public abstract string getClassName();


	public abstract string getQualifiedName();


	public virtual string getId()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EgetId(this);
	}


	public abstract List getTypeParameters();


	public virtual Optional findTypeParameter(string P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EfindTypeParameter(this, P_0);
	}


	public virtual bool isGeneric()
	{
		return ResolvedTypeParametrizable._003Cdefault_003EisGeneric(this);
	}


	public abstract List getAncestors(bool P_0);


	public virtual List getAllAncestors(Function P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetAllAncestors(this, P_0);
	}


	public virtual ResolvedFieldDeclaration getVisibleField(string P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetVisibleField(this, P_0);
	}


	public virtual bool hasVisibleField(string P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EhasVisibleField(this, P_0);
	}


	public abstract List getAllFields();


	public virtual List getVisibleFields()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetVisibleFields(this);
	}


	public virtual List getAllNonStaticFields()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetAllNonStaticFields(this);
	}


	public virtual List getAllStaticFields()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetAllStaticFields(this);
	}


	public virtual List getDeclaredFields()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetDeclaredFields(this);
	}


	public abstract bool isAssignableBy(ResolvedType P_0);


	public virtual bool canBeAssignedTo(ResolvedReferenceTypeDeclaration P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EcanBeAssignedTo(this, P_0);
	}


	public abstract bool isAssignableBy(ResolvedReferenceTypeDeclaration P_0);


	public abstract bool hasDirectlyAnnotation(string P_0);


	public virtual bool hasAnnotation(string P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EhasAnnotation(this, P_0);
	}


	public abstract List getConstructors();


	public virtual bool isJavaLangEnum()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EisJavaLangEnum(this);
	}
}
