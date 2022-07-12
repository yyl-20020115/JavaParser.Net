
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.type;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.javaparsermodel.contexts;
using com.github.javaparser.symbolsolver.model.resolution;

using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.javaparsermodel.declarations;


public class JavaParserParameterDeclaration: ResolvedParameterDeclaration, ResolvedValueDeclaration, ResolvedDeclaration, AssociableToAST
{
	
	private Parameter wrappedNode;

	
	private TypeSolver typeSolver;

	
	
	public JavaParserParameterDeclaration(Parameter wrappedNode, TypeSolver typeSolver)
	{
		this.wrappedNode = wrappedNode;
		this.typeSolver = typeSolver;
	}

	
	
	public virtual bool isVariadic()
	{
		bool result = wrappedNode.isVarArgs();
		
		return result;
	}

	
	
	public virtual string getName()
	{
		string id = wrappedNode.getName().getId();
		
		return id;
	}

	
	
	public virtual ResolvedType getType()
	{
		if (wrappedNode.getType() is UnknownType && JavaParserFactory.getContext(wrappedNode, typeSolver) is LambdaExprContext)
		{
			Optional optional = JavaParserFactory.getContext(wrappedNode, typeSolver).solveSymbolAsValue(wrappedNode.getNameAsString());
			if (optional.isPresent())
			{
				ResolvedType type = ((Value)optional.get()).getType();
				
				return type;
			}
		}
		object obj = JavaParserFacade.get(typeSolver).convert(wrappedNode.getType(), wrappedNode);
		if (isVariadic())
		{
			obj = new ResolvedArrayType((ResolvedType)obj);
		}
		object obj2 = obj;
		return (obj2 == null) ? null : ((obj2 as ResolvedType) ?? throw new java.lang.IncompatibleClassChangeError());
	}

	public virtual Parameter getWrappedNode()
	{
		return wrappedNode;
	}

	
		
	public virtual Optional toAst()
	{
		Optional result = Optional.of(wrappedNode);
		
		return result;
	}


	public virtual bool hasName()
	{
		return ResolvedParameterDeclaration._003Cdefault_003EhasName(this);
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
		return ResolvedParameterDeclaration._003Cdefault_003EisParameter(this);
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
		return ResolvedParameterDeclaration._003Cdefault_003EasParameter(this);
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


	public virtual string describeType()
	{
		return ResolvedParameterDeclaration._003Cdefault_003EdescribeType(this);
	}
}
