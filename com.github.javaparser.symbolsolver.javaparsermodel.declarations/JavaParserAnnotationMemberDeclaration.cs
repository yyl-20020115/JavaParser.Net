
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.core.resolution;
using com.github.javaparser.symbolsolver.model.resolution;

using java.lang;

namespace com.github.javaparser.symbolsolver.javaparsermodel.declarations;


public class JavaParserAnnotationMemberDeclaration: ResolvedAnnotationMemberDeclaration, ResolvedValueDeclaration, ResolvedDeclaration
{
	private AnnotationMemberDeclaration wrappedNode;

	private TypeSolver typeSolver;

	
	
	public JavaParserAnnotationMemberDeclaration(AnnotationMemberDeclaration wrappedNode, TypeSolver typeSolver)
	{
		this.wrappedNode = wrappedNode;
		this.typeSolver = typeSolver;
	}

	
	
	private Context getContext()
	{
		Context context = JavaParserFactory.getContext(wrappedNode, typeSolver);
		
		return context;
	}

	public virtual AnnotationMemberDeclaration getWrappedNode()
	{
		return wrappedNode;
	}

	
	
	public virtual Expression getDefaultValue()
	{
		return (Expression)wrappedNode.getDefaultValue().orElse(null);
	}

	
	
	public virtual ResolvedType getType()
	{
		ResolvedType result = JavaParserFacade.get(typeSolver).convert(wrappedNode.getType(), getContext());
		
		return result;
	}

	
	
	public virtual string getName()
	{
		string nameAsString = wrappedNode.getNameAsString();
		
		return nameAsString;
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
