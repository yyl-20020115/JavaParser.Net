
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.model.typesystem;

using java.lang;
using java.lang.reflect;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.symbolsolver.reflectionmodel;


public class ReflectionTypeParameter: ResolvedTypeParameterDeclaration, ResolvedTypeDeclaration, ResolvedDeclaration
{
	
	private sealed class ___003C_003EAnon0 : Function
	{
		private readonly ReflectionTypeParameter arg_00241;

		internal ___003C_003EAnon0(ReflectionTypeParameter P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			ResolvedTypeParameterDeclaration.Bound result = arg_00241.lambda_0024getBounds_00240((Type)P_0);
			
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

	private TypeVariable typeVariable;

	private TypeSolver typeSolver;

	private ResolvedTypeParametrizable container;

	
	
	public ReflectionTypeParameter(TypeVariable typeVariable, bool declaredOnClass, TypeSolver typeSolver)
	{
		GenericDeclaration genericDeclaration = typeVariable.getGenericDeclaration();
		if (genericDeclaration is Class)
		{
			container = ReflectionFactory.typeDeclarationFor((Class)genericDeclaration, typeSolver);
		}
		else if (genericDeclaration is Method)
		{
			container = new ReflectionMethodDeclaration((Method)genericDeclaration, typeSolver);
		}
		else if (genericDeclaration is Constructor)
		{
			container = new ReflectionConstructorDeclaration((Constructor)genericDeclaration, typeSolver);
		}
		this.typeVariable = typeVariable;
		this.typeSolver = typeSolver;
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

	
	
	
	private ResolvedTypeParameterDeclaration.Bound lambda_0024getBounds_00240(Type P_0)
	{
		ResolvedTypeParameterDeclaration.Bound result = ResolvedTypeParameterDeclaration.Bound.extendsBound(ReflectionFactory.typeUsageFor(P_0, typeSolver));
		
		return result;
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
		int num = Object.instancehelper_hashCode(typeVariable);
		return 31 * num + Object.instancehelper_hashCode(container);
	}

	
	
	public virtual string getName()
	{
		string name = typeVariable.getName();
		
		return name;
	}

	
	
	public virtual string getContainerQualifiedName()
	{
		if (container is ResolvedReferenceTypeDeclaration)
		{
			string qualifiedName = ((ResolvedReferenceTypeDeclaration)container).getQualifiedName();
			
			return qualifiedName;
		}
		string qualifiedSignature = ((ResolvedMethodLikeDeclaration)container).getQualifiedSignature();
		
		return qualifiedSignature;
	}

	
	
	public virtual string getContainerId()
	{
		if (container is ResolvedReferenceTypeDeclaration)
		{
			string id = ((ResolvedReferenceTypeDeclaration)container).getId();
			
			return id;
		}
		string qualifiedSignature = ((ResolvedMethodLikeDeclaration)container).getQualifiedSignature();
		
		return qualifiedSignature;
	}

	public virtual ResolvedTypeParametrizable getContainer()
	{
		return container;
	}

	
		
	public virtual List getBounds()
	{
		return (List)Arrays.stream(typeVariable.getBounds()).map(new ___003C_003EAnon0(this)).collect(Collectors.toList());
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("ReflectionTypeParameter{typeVariable=").append(typeVariable).append('}')
			.ToString();
		
		return result;
	}

	
		
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
