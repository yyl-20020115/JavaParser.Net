using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.type;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.core.resolution;
using com.github.javaparser.symbolsolver.javaparser;
using com.github.javaparser.symbolsolver.logic;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.model.typesystem;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.symbolsolver.javaparsermodel.declarations;


public class JavaParserTypeParameter : AbstractTypeDeclaration, ResolvedTypeParameterDeclaration, ResolvedTypeDeclaration, ResolvedDeclaration
{
	
	private sealed class ___003C_003EAnon0 : Function
	{
		private readonly JavaParserTypeParameter arg_00241;

		internal ___003C_003EAnon0(JavaParserTypeParameter P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			ResolvedTypeParameterDeclaration.Bound result = arg_00241.lambda_0024getBounds_00240((ClassOrInterfaceType)P_0);
			
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

	private TypeParameter wrappedNode;

	private TypeSolver typeSolver;

	
	
	public JavaParserTypeParameter(TypeParameter wrappedNode, TypeSolver typeSolver)
	{
		this.wrappedNode = wrappedNode;
		this.typeSolver = typeSolver;
	}

	
	
	public virtual Context getContext()
	{
		
		throw new UnsupportedOperationException();
	}

	
	
	public override bool isAssignableBy(ResolvedType type)
	{
		
		throw new UnsupportedOperationException();
	}

	
	[LineNumberTable(new byte[]
	{
		78, 108, 104, 103, 116, 107, 103, 117, 104, 125,
		105, 182, 98, 104, 144
	})]
	public virtual ResolvedTypeParametrizable getContainer()
	{
		Node node = Navigator.demandParentNode(wrappedNode);
		if (node is ClassOrInterfaceDeclaration)
		{
			ClassOrInterfaceDeclaration classOrInterfaceDeclaration = (ClassOrInterfaceDeclaration)node;
			ResolvedReferenceTypeDeclaration typeDeclaration = JavaParserFacade.get(typeSolver).getTypeDeclaration(classOrInterfaceDeclaration);
			
			return typeDeclaration;
		}
		if (node is ConstructorDeclaration)
		{
			ConstructorDeclaration constructorDeclaration = (ConstructorDeclaration)node;
			Optional optional = constructorDeclaration.findAncestor(new Class[1] { ClassLiteral<ClassOrInterfaceDeclaration>.Value });
			if (optional.isPresent())
			{
				ResolvedReferenceTypeDeclaration typeDeclaration2 = JavaParserFacade.get(typeSolver).getTypeDeclaration((ClassOrInterfaceDeclaration)optional.get());
				if (typeDeclaration2.isClass())
				{
					JavaParserConstructorDeclaration result = new JavaParserConstructorDeclaration(typeDeclaration2.asClass(), constructorDeclaration, typeSolver);
					
					return result;
				}
			}
			
			throw new UnsupportedOperationException();
		}
		MethodDeclaration methodDeclaration = (MethodDeclaration)node;
		JavaParserMethodDeclaration result2 = new JavaParserMethodDeclaration(methodDeclaration, typeSolver);
		
		return result2;
	}

	
	
	public virtual string getContainerQualifiedName()
	{
		ResolvedTypeParametrizable container = getContainer();
		if (container is ResolvedReferenceTypeDeclaration)
		{
			string qualifiedName = ((ResolvedReferenceTypeDeclaration)container).getQualifiedName();
			
			return qualifiedName;
		}
		if (container is JavaParserConstructorDeclaration)
		{
			string qualifiedSignature = ((JavaParserConstructorDeclaration)container).getQualifiedSignature();
			
			return qualifiedSignature;
		}
		string qualifiedSignature2 = ((JavaParserMethodDeclaration)container).getQualifiedSignature();
		
		return qualifiedSignature2;
	}

	
	
	public override string getName()
	{
		string id = wrappedNode.getName().getId();
		
		return id;
	}

	
	
	private ResolvedTypeParameterDeclaration.Bound toBound(ClassOrInterfaceType P_0, TypeSolver P_1)
	{
		ResolvedType type = JavaParserFacade.get(P_1).convertToUsage(P_0, P_0);
		ResolvedTypeParameterDeclaration.Bound result = ResolvedTypeParameterDeclaration.Bound.extendsBound(type);
		
		return result;
	}

	
	
	
	private ResolvedTypeParameterDeclaration.Bound lambda_0024getBounds_00240(ClassOrInterfaceType P_0)
	{
		ResolvedTypeParameterDeclaration.Bound result = toBound(P_0, typeSolver);
		
		return result;
	}

	
		
	public override Set getDeclaredMethods()
	{
		Set result = Collections.emptySet();
		
		return result;
	}

	
		
	public virtual SymbolReference solveMethod(string name, List parameterTypes)
	{
		SymbolReference result = getContext().solveMethod(name, parameterTypes, staticOnly: false);
		
		return result;
	}

	
	
	public override bool Equals(object o)
	{
		if (this == o)
		{
			return true;
		}
		if (!(o is JavaParserTypeParameter))
		{
			return false;
		}
		JavaParserTypeParameter javaParserTypeParameter = (JavaParserTypeParameter)o;
		if (wrappedNode != null)
		{
			if (!wrappedNode.equals(javaParserTypeParameter.wrappedNode))
			{
				goto IL_003c;
			}
		}
		else if (javaParserTypeParameter.wrappedNode != null)
		{
			goto IL_003c;
		}
		return true;
		IL_003c:
		return false;
	}

	
	
	public override int GetHashCode()
	{
		int num = ((wrappedNode != null) ? wrappedNode.GetHashCode() : 0);
		return 31 * num + ((typeSolver != null) ? Object.instancehelper_hashCode(typeSolver) : 0);
	}

	
	
	public override bool isAssignableBy(ResolvedReferenceTypeDeclaration other)
	{
		ReferenceTypeImpl.___003Cclinit_003E();
		bool result = isAssignableBy(new ReferenceTypeImpl(other, typeSolver));
		
		return result;
	}

	
	
	public virtual string getContainerId()
	{
		ResolvedTypeParametrizable container = getContainer();
		if (container is ResolvedReferenceTypeDeclaration)
		{
			string id = ((ResolvedReferenceTypeDeclaration)container).getId();
			
			return id;
		}
		if (container is JavaParserConstructorDeclaration)
		{
			string qualifiedSignature = ((JavaParserConstructorDeclaration)container).getQualifiedSignature();
			
			return qualifiedSignature;
		}
		string qualifiedSignature2 = ((JavaParserMethodDeclaration)container).getQualifiedSignature();
		
		return qualifiedSignature2;
	}

	
	
	public override string getQualifiedName()
	{
		string result = String.format("%s.%s", getContainerQualifiedName(), getName());
		
		return result;
	}

	
		
	public virtual List getBounds()
	{
		return (List)wrappedNode.getTypeBound().stream().map(new ___003C_003EAnon0(this))
			.collect(Collectors.toList());
	}

	
	
	public virtual ResolvedType getUsage(Node node)
	{
		
		throw new UnsupportedOperationException();
	}

	
	
	public override ResolvedFieldDeclaration getField(string name)
	{
		
		throw new UnsupportedOperationException();
	}

	public override bool hasField(string name)
	{
		return false;
	}

	
		
	public override List getAllFields()
	{
		ArrayList result = new ArrayList();
		
		return result;
	}

	
		
	public override List getAncestors(bool acceptIncompleteList)
	{
		
		throw new UnsupportedOperationException();
	}

	public override bool isTypeParameter()
	{
		return true;
	}

	public override ResolvedTypeParameterDeclaration asTypeParameter()
	{
		return this;
	}

	
	
	public override bool hasDirectlyAnnotation(string canonicalName)
	{
		
		throw new UnsupportedOperationException();
	}

	
		
	public override List getTypeParameters()
	{
		List result = Collections.emptyList();
		
		return result;
	}

	public virtual TypeParameter getWrappedNode()
	{
		return wrappedNode;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("JPTypeParameter(").append(wrappedNode.getName()).append(", bounds=")
			.append(wrappedNode.getTypeBound())
			.append(")")
			.ToString();
		
		return result;
	}

	
		
	public override Optional containerType()
	{
		ResolvedTypeParametrizable container = getContainer();
		if (container is ResolvedReferenceTypeDeclaration)
		{
			Optional result = Optional.of((ResolvedReferenceTypeDeclaration)container);
			
			return result;
		}
		Optional result2 = Optional.empty();
		
		return result2;
	}

	
		
	public override List getConstructors()
	{
		List result = Collections.emptyList();
		
		return result;
	}

	
	
	public virtual ResolvedReferenceType @object()
	{
		ReferenceTypeImpl.___003Cclinit_003E();
		ReferenceTypeImpl result = new ReferenceTypeImpl(typeSolver.getSolvedJavaLangObject(), typeSolver);
		
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
	public override Set internalTypes()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EinternalTypes(this);
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
	public override ResolvedInterfaceDeclaration asInterface()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EasInterface(this);
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
	public override ResolvedReferenceTypeDeclaration asReferenceType()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EasReferenceType(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override string getPackageName()
	{
		return ResolvedTypeParameterDeclaration._003Cdefault_003EgetPackageName(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override string getClassName()
	{
		return ResolvedTypeParameterDeclaration._003Cdefault_003EgetClassName(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override string getId()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EgetId(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool declaredOnType()
	{
		return ResolvedTypeParameterDeclaration._003Cdefault_003EdeclaredOnType(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool declaredOnMethod()
	{
		return ResolvedTypeParameterDeclaration._003Cdefault_003EdeclaredOnMethod(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool declaredOnConstructor()
	{
		return ResolvedTypeParameterDeclaration._003Cdefault_003EdeclaredOnConstructor(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool hasLowerBound()
	{
		return ResolvedTypeParameterDeclaration._003Cdefault_003EhasLowerBound(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool hasUpperBound()
	{
		return ResolvedTypeParameterDeclaration._003Cdefault_003EhasUpperBound(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedType getLowerBound()
	{
		return ResolvedTypeParameterDeclaration._003Cdefault_003EgetLowerBound(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedType getUpperBound()
	{
		return ResolvedTypeParameterDeclaration._003Cdefault_003EgetUpperBound(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isBounded()
	{
		return ResolvedTypeParameterDeclaration._003Cdefault_003EisBounded(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isUnbounded()
	{
		return ResolvedTypeParameterDeclaration._003Cdefault_003EisUnbounded(this);
	}
}
