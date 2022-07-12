
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.model.typesystem;

using java.lang;
using java.util;
using javassist.bytecode;

namespace com.github.javaparser.symbolsolver.javassistmodel;


public class JavassistTypeParameter: ResolvedTypeParameterDeclaration, ResolvedTypeDeclaration, ResolvedDeclaration
{
	private javassist.bytecode.SignatureAttribute.TypeParameter wrapped;

	private TypeSolver typeSolver;

	private ResolvedTypeParametrizable container;

	
	
	public JavassistTypeParameter(javassist.bytecode.SignatureAttribute.TypeParameter wrapped, ResolvedTypeParametrizable container, TypeSolver typeSolver)
	{
		this.wrapped = wrapped;
		this.typeSolver = typeSolver;
		this.container = container;
	}


	public virtual string getQualifiedName()
	{
		return ResolvedTypeParameterDeclaration._003Cdefault_003EgetQualifiedName(this);
	}


	public virtual bool declaredOnType()
	{
		return ResolvedTypeParameterDeclaration._003Cdefault_003EdeclaredOnType(this);
	}


	public virtual bool declaredOnMethod()
	{
		return ResolvedTypeParameterDeclaration._003Cdefault_003EdeclaredOnMethod(this);
	}

	
	
	public virtual string getContainerQualifiedName()
	{
		if (container is ResolvedReferenceTypeDeclaration)
		{
			string qualifiedName = ((ResolvedReferenceTypeDeclaration)container).getQualifiedName();
			
			return qualifiedName;
		}
		if (container is ResolvedMethodLikeDeclaration)
		{
			string qualifiedName2 = ((ResolvedMethodLikeDeclaration)container).getQualifiedName();
			
			return qualifiedName2;
		}
		
		throw new UnsupportedOperationException();
	}

	public virtual ResolvedTypeParametrizable getContainer()
	{
		return container;
	}

	
	
	public override bool Equals(object o)
	{
		if (this == o)
		{
			return true;
		}
		if (!(o is ResolvedTypeParameterDeclaration))
		{
			return false;
		}
		ResolvedTypeParameterDeclaration resolvedTypeParameterDeclaration = (ResolvedTypeParameterDeclaration)o;
		if (!String.instancehelper_equals(getQualifiedName(), resolvedTypeParameterDeclaration.getQualifiedName()))
		{
			return false;
		}
		if (declaredOnType() != resolvedTypeParameterDeclaration.declaredOnType())
		{
			return false;
		}
		if (declaredOnMethod() != resolvedTypeParameterDeclaration.declaredOnMethod())
		{
			return false;
		}
		return true;
	}

	
	
	public override int GetHashCode()
	{
		int result = Objects.hash(getQualifiedName(), Boolean.valueOf(declaredOnType()), Boolean.valueOf(declaredOnMethod()));
		
		return result;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("JavassistTypeParameter{").append(wrapped.getName()).append('}')
			.ToString();
		
		return result;
	}

	
	
	public virtual string getName()
	{
		string name = wrapped.getName();
		
		return name;
	}

	
	
	public virtual string getContainerId()
	{
		string containerQualifiedName = getContainerQualifiedName();
		
		return containerQualifiedName;
	}

	
	[IKVM.Attributes.Signature("()Ljava/util/List<Lcom/github/javaparser/resolution/declarations/ResolvedTypeParameterDeclaration$Bound;>;")]
	
	public virtual List getBounds()
	{
		ArrayList arrayList = new ArrayList();
		javassist.bytecode.SignatureAttribute.ObjectType classBound = wrapped.getClassBound();
		if (classBound != null)
		{
			((List)arrayList).add((object)ResolvedTypeParameterDeclaration.Bound.extendsBound(JavassistUtils.signatureTypeToType(classBound, typeSolver, getContainer())));
		}
		javassist.bytecode.SignatureAttribute.ObjectType[] interfaceBound = wrapped.getInterfaceBound();
		int num = interfaceBound.Length;
		for (int i = 0; i < num; i++)
		{
			javassist.bytecode.SignatureAttribute.ObjectType objectType = interfaceBound[i];
			((List)arrayList).add((object)ResolvedTypeParameterDeclaration.Bound.extendsBound(JavassistUtils.signatureTypeToType(objectType, typeSolver, getContainer())));
		}
		return arrayList;
	}

	
	[IKVM.Attributes.Signature("()Ljava/util/Optional<Lcom/github/javaparser/resolution/declarations/ResolvedReferenceTypeDeclaration;>;")]
	
	public virtual Optional containerType()
	{
		if (container is ResolvedReferenceTypeDeclaration)
		{
			Optional result = Optional.of((ResolvedReferenceTypeDeclaration)container);
			
			return result;
		}
		Optional result2 = Optional.empty();
		
		return result2;
	}

	
	
	public virtual ResolvedReferenceType @object()
	{
		ReferenceTypeImpl.___003Cclinit_003E();
		ReferenceTypeImpl result = new ReferenceTypeImpl(typeSolver.getSolvedJavaLangObject(), typeSolver);
		
		return result;
	}


	public virtual bool hasName()
	{
		return ResolvedDeclaration._003Cdefault_003EhasName(this);
	}


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


	public virtual ResolvedReferenceTypeDeclaration asReferenceType()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EasReferenceType(this);
	}


	public virtual string getPackageName()
	{
		return ResolvedTypeParameterDeclaration._003Cdefault_003EgetPackageName(this);
	}


	public virtual string getClassName()
	{
		return ResolvedTypeParameterDeclaration._003Cdefault_003EgetClassName(this);
	}


	public virtual string getId()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EgetId(this);
	}


	public virtual bool declaredOnConstructor()
	{
		return ResolvedTypeParameterDeclaration._003Cdefault_003EdeclaredOnConstructor(this);
	}


	public virtual bool hasLowerBound()
	{
		return ResolvedTypeParameterDeclaration._003Cdefault_003EhasLowerBound(this);
	}


	public virtual bool hasUpperBound()
	{
		return ResolvedTypeParameterDeclaration._003Cdefault_003EhasUpperBound(this);
	}


	public virtual ResolvedType getLowerBound()
	{
		return ResolvedTypeParameterDeclaration._003Cdefault_003EgetLowerBound(this);
	}


	public virtual ResolvedType getUpperBound()
	{
		return ResolvedTypeParameterDeclaration._003Cdefault_003EgetUpperBound(this);
	}


	public virtual bool isBounded()
	{
		return ResolvedTypeParameterDeclaration._003Cdefault_003EisBounded(this);
	}


	public virtual bool isUnbounded()
	{
		return ResolvedTypeParameterDeclaration._003Cdefault_003EisUnbounded(this);
	}
}
