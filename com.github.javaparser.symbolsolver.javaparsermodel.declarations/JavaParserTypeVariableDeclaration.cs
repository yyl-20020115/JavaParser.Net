using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.type;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.core.resolution;
using com.github.javaparser.symbolsolver.logic;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.model.typesystem;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.javaparsermodel.declarations;


public class JavaParserTypeVariableDeclaration : AbstractTypeDeclaration, AssociableToAST
{
	private TypeParameter wrappedNode;

	private TypeSolver typeSolver;

	
	
	public JavaParserTypeVariableDeclaration(TypeParameter wrappedNode, TypeSolver typeSolver)
	{
		this.wrappedNode = wrappedNode;
		this.typeSolver = typeSolver;
	}

	
	
	public override bool isAssignableBy(ResolvedType type)
	{
		if (type.isTypeVariable())
		{
			string message = new StringBuilder().append("Is this type variable declaration assignable by ").append(type.describe()).ToString();
			
			throw new UnsupportedOperationException(message);
		}
		string message2 = new StringBuilder().append("Is this type variable declaration assignable by ").append(type).ToString();
		
		throw new UnsupportedOperationException(message2);
	}

	
	
	public override string getName()
	{
		string id = wrappedNode.getName().getId();
		
		return id;
	}

	
	
	public override ResolvedTypeParameterDeclaration asTypeParameter()
	{
		JavaParserTypeParameter result = new JavaParserTypeParameter(wrappedNode, typeSolver);
		
		return result;
	}

	
	
	public override bool isAssignableBy(ResolvedReferenceTypeDeclaration other)
	{
		ReferenceTypeImpl.___003Cclinit_003E();
		bool result = isAssignableBy(new ReferenceTypeImpl(other, typeSolver));
		
		return result;
	}

	
	
	public override string getPackageName()
	{
		string packageName = AstResolutionUtils.getPackageName(wrappedNode);
		
		return packageName;
	}

	
	
	public override string getClassName()
	{
		string className = AstResolutionUtils.getClassName("", wrappedNode);
		
		return className;
	}

	
	
	public override string getQualifiedName()
	{
		string name = getName();
		
		return name;
	}

	
	
	public virtual Context getContext()
	{
		
		throw new UnsupportedOperationException();
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("JavaParserTypeVariableDeclaration{").append(wrappedNode.getName()).append('}')
			.ToString();
		
		return result;
	}

	
		
	public virtual SymbolReference solveMethod(string name, List parameterTypes)
	{
		
		throw new UnsupportedOperationException();
	}

	
	
	public virtual ResolvedType getUsage(Node node)
	{
		
		throw new UnsupportedOperationException();
	}

	public override bool isTypeParameter()
	{
		return true;
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

	
		
	public override Set getDeclaredMethods()
	{
		Set result = Collections.emptySet();
		
		return result;
	}

	public override bool isType()
	{
		return true;
	}

	
	
	public override bool hasDirectlyAnnotation(string canonicalName)
	{
		
		throw new UnsupportedOperationException();
	}

	public override bool isClass()
	{
		return false;
	}

	public override bool isInterface()
	{
		return false;
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

	
		
	public override Optional containerType()
	{
		Optional result = asTypeParameter().containerType();
		
		return result;
	}

	
		
	public override List getConstructors()
	{
		List result = Collections.emptyList();
		
		return result;
	}

	
		
	public virtual Optional toAst()
	{
		Optional result = Optional.of(wrappedNode);
		
		return result;
	}
}
