using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.javaparser;
using com.github.javaparser.symbolsolver.model.resolution;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.javaparsermodel.declarations;


public class JavaParserFieldDeclaration: ResolvedFieldDeclaration, ResolvedValueDeclaration, ResolvedDeclaration, HasAccessSpecifier, AssociableToAST
{
	private VariableDeclarator variableDeclarator;

	private FieldDeclaration wrappedNode;

	private TypeSolver typeSolver;

	
	
	public JavaParserFieldDeclaration(VariableDeclarator variableDeclarator, TypeSolver typeSolver)
	{
		if (typeSolver == null)
		{
			
			throw new IllegalArgumentException("typeSolver should not be null");
		}
		this.variableDeclarator = variableDeclarator;
		this.typeSolver = typeSolver;
		if (!(Navigator.demandParentNode(variableDeclarator) is FieldDeclaration))
		{
			string canonicalName = Object.instancehelper_getClass(Navigator.demandParentNode(variableDeclarator)).getCanonicalName();
			
			throw new IllegalStateException(canonicalName);
		}
		wrappedNode = (FieldDeclaration)Navigator.demandParentNode(variableDeclarator);
	}

	
	
	public virtual string getName()
	{
		string id = variableDeclarator.getName().getId();
		
		return id;
	}

	
	
	public virtual ResolvedType getType()
	{
		ResolvedType result = JavaParserFacade.get(typeSolver).convert(variableDeclarator.getType(), wrappedNode);
		
		return result;
	}

	
	
	public virtual bool isStatic()
	{
		bool result = wrappedNode.hasModifier(Modifier.Keyword.___003C_003ESTATIC);
		
		return result;
	}

	
	
	public virtual bool isVolatile()
	{
		bool result = wrappedNode.hasModifier(Modifier.Keyword.___003C_003EVOLATILE);
		
		return result;
	}

	public virtual bool isField()
	{
		return true;
	}

	public virtual FieldDeclaration getWrappedNode()
	{
		return wrappedNode;
	}

	public virtual VariableDeclarator getVariableDeclarator()
	{
		return variableDeclarator;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("JavaParserFieldDeclaration{").append(getName()).append("}")
			.ToString();
		
		return result;
	}

	
	
	public virtual AccessSpecifier accessSpecifier()
	{
		AccessSpecifier result = wrappedNode.getAccessSpecifier();
		
		return result;
	}

	
	
	public virtual ResolvedTypeDeclaration declaringType()
	{
		Optional optional = wrappedNode.findAncestor(new Class[1] { ClassLiteral<TypeDeclaration>.Value });
		if (optional.isPresent())
		{
			ResolvedReferenceTypeDeclaration typeDeclaration = JavaParserFacade.get(typeSolver).getTypeDeclaration((TypeDeclaration)optional.get());
			
			return typeDeclaration;
		}
		
		throw new IllegalStateException();
	}

	
		
	public virtual Optional toAst()
	{
		Optional result = Optional.ofNullable(wrappedNode);
		
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool hasName()
	{
		return ResolvedDeclaration._003Cdefault_003EhasName(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isVariable()
	{
		return ResolvedDeclaration._003Cdefault_003EisVariable(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isEnumConstant()
	{
		return ResolvedDeclaration._003Cdefault_003EisEnumConstant(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isPattern()
	{
		return ResolvedDeclaration._003Cdefault_003EisPattern(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isParameter()
	{
		return ResolvedDeclaration._003Cdefault_003EisParameter(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isType()
	{
		return ResolvedDeclaration._003Cdefault_003EisType(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isMethod()
	{
		return ResolvedDeclaration._003Cdefault_003EisMethod(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedFieldDeclaration asField()
	{
		return ResolvedFieldDeclaration._003Cdefault_003EasField(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedParameterDeclaration asParameter()
	{
		return ResolvedDeclaration._003Cdefault_003EasParameter(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedTypeDeclaration asType()
	{
		return ResolvedDeclaration._003Cdefault_003EasType(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedMethodDeclaration asMethod()
	{
		return ResolvedDeclaration._003Cdefault_003EasMethod(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedEnumConstantDeclaration asEnumConstant()
	{
		return ResolvedDeclaration._003Cdefault_003EasEnumConstant(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedPatternDeclaration asPattern()
	{
		return ResolvedDeclaration._003Cdefault_003EasPattern(this);
	}
}
