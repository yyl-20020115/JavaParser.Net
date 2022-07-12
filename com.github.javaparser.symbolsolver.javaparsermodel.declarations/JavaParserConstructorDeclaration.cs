
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.type;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.model.resolution;

using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.symbolsolver.javaparsermodel.declarations;


public class JavaParserConstructorDeclaration: ResolvedConstructorDeclaration, ResolvedMethodLikeDeclaration, ResolvedDeclaration, ResolvedTypeParametrizable, HasAccessSpecifier, AssociableToAST
{
	
	private sealed class ___003C_003EAnon0 : Function
	{
		private readonly JavaParserConstructorDeclaration arg_00241;

		internal ___003C_003EAnon0(JavaParserConstructorDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			JavaParserTypeParameter result = arg_00241.lambda_0024getTypeParameters_00240((TypeParameter)P_0);
			
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

		private ResolvedReferenceTypeDeclaration m_declaringType;

	private ConstructorDeclaration wrappedNode;

	private TypeSolver typeSolver;

	
		
	internal JavaParserConstructorDeclaration(ResolvedReferenceTypeDeclaration P_0, ConstructorDeclaration P_1, TypeSolver P_2)
	{
		this.m_declaringType = P_0;
		wrappedNode = P_1;
		typeSolver = P_2;
	}

	
	
	public virtual int getNumberOfParams()
	{
		int result = wrappedNode.getParameters().size();
		
		return result;
	}

	
	
	public virtual int getNumberOfSpecifiedExceptions()
	{
		int result = wrappedNode.getThrownExceptions().size();
		
		return result;
	}

	
	
	
	private JavaParserTypeParameter lambda_0024getTypeParameters_00240(TypeParameter P_0)
	{
		JavaParserTypeParameter result = new JavaParserTypeParameter(P_0, typeSolver);
		
		return result;
	}

		public virtual ResolvedReferenceTypeDeclaration declaringType()
	{
		return this.m_declaringType;
	}

	
	
	public virtual ResolvedParameterDeclaration getParam(int i)
	{
		if (i < 0 || i >= getNumberOfParams())
		{
			string s = String.format("No param with index %d. Number of params: %d", Integer.valueOf(i), Integer.valueOf(getNumberOfParams()));
			
			throw new IllegalArgumentException(s);
		}
		JavaParserParameterDeclaration result = new JavaParserParameterDeclaration((Parameter)wrappedNode.getParameters().get(i), typeSolver);
		
		return result;
	}

	
	
	public virtual string getName()
	{
		string name = this.m_declaringType.getName();
		
		return name;
	}

	public virtual ConstructorDeclaration getWrappedNode()
	{
		return wrappedNode;
	}

	
	
	public virtual AccessSpecifier accessSpecifier()
	{
		AccessSpecifier result = wrappedNode.getAccessSpecifier();
		
		return result;
	}

	
		
	public virtual List getTypeParameters()
	{
		return (List)wrappedNode.getTypeParameters().stream().map(new ___003C_003EAnon0(this))
			.collect(Collectors.toList());
	}

	
	
	public virtual ResolvedType getSpecifiedException(int index)
	{
		if (index < 0 || index >= getNumberOfSpecifiedExceptions())
		{
			string s = String.format("No exception with index %d. Number of exceptions: %d", Integer.valueOf(index), Integer.valueOf(getNumberOfSpecifiedExceptions()));
			
			throw new IllegalArgumentException(s);
		}
		ResolvedType result = JavaParserFacade.get(typeSolver).convert((Type)wrappedNode.getThrownExceptions().get(index), wrappedNode);
		
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


	public virtual Optional findTypeParameter(string P_0)
	{
		return ResolvedMethodLikeDeclaration._003Cdefault_003EfindTypeParameter(this, P_0);
	}


	public virtual bool isGeneric()
	{
		return ResolvedTypeParametrizable._003Cdefault_003EisGeneric(this);
	}


	public virtual string getPackageName()
	{
		return ResolvedMethodLikeDeclaration._003Cdefault_003EgetPackageName(this);
	}


	public virtual string getClassName()
	{
		return ResolvedMethodLikeDeclaration._003Cdefault_003EgetClassName(this);
	}


	public virtual string getQualifiedName()
	{
		return ResolvedMethodLikeDeclaration._003Cdefault_003EgetQualifiedName(this);
	}


	public virtual string getSignature()
	{
		return ResolvedMethodLikeDeclaration._003Cdefault_003EgetSignature(this);
	}


	public virtual string getQualifiedSignature()
	{
		return ResolvedMethodLikeDeclaration._003Cdefault_003EgetQualifiedSignature(this);
	}


	public virtual ResolvedParameterDeclaration getLastParam()
	{
		return ResolvedMethodLikeDeclaration._003Cdefault_003EgetLastParam(this);
	}


	public virtual bool hasVariadicParameter()
	{
		return ResolvedMethodLikeDeclaration._003Cdefault_003EhasVariadicParameter(this);
	}


	public virtual List getSpecifiedExceptions()
	{
		return ResolvedMethodLikeDeclaration._003Cdefault_003EgetSpecifiedExceptions(this);
	}
}
