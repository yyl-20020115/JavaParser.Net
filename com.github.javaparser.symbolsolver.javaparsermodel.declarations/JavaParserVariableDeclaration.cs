
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.javaparser;
using com.github.javaparser.symbolsolver.model.resolution;

using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.javaparsermodel.declarations;


public class JavaParserVariableDeclaration: ResolvedValueDeclaration, ResolvedDeclaration, AssociableToAST
{
	private VariableDeclarator variableDeclarator;

	private VariableDeclarationExpr wrappedNode;

	private TypeSolver typeSolver;

	
	
	public JavaParserVariableDeclaration(VariableDeclarator variableDeclarator, TypeSolver typeSolver)
	{
		if (typeSolver == null)
		{
			
			throw new IllegalArgumentException("typeSolver should not be null");
		}
		this.variableDeclarator = variableDeclarator;
		this.typeSolver = typeSolver;
		if (!(Navigator.demandParentNode(variableDeclarator) is VariableDeclarationExpr))
		{
			string canonicalName = Object.instancehelper_getClass(Navigator.demandParentNode(variableDeclarator)).getCanonicalName();
			
			throw new IllegalStateException(canonicalName);
		}
		wrappedNode = (VariableDeclarationExpr)Navigator.demandParentNode(variableDeclarator);
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

	public virtual bool isVariable()
	{
		return true;
	}

	public virtual VariableDeclarationExpr getWrappedNode()
	{
		return wrappedNode;
	}

	public virtual VariableDeclarator getVariableDeclarator()
	{
		return variableDeclarator;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("JavaParserVariableDeclaration{").append(getName()).append("}")
			.ToString();
		
		return result;
	}

	
		
	public virtual Optional toAst()
	{
		Optional result = Optional.of(wrappedNode);
		
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
		return ResolvedDeclaration._003Cdefault_003EisType(this);
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
		return ResolvedDeclaration._003Cdefault_003EasType(this);
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
}
