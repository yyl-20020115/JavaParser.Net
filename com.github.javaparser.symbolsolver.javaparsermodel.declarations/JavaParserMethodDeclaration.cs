
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.type;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.core.resolution;
using com.github.javaparser.symbolsolver.declarations.common;
using com.github.javaparser.symbolsolver.javaparser;
using com.github.javaparser.symbolsolver.model.resolution;

using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.symbolsolver.javaparsermodel.declarations;


public class JavaParserMethodDeclaration: ResolvedMethodDeclaration, ResolvedMethodLikeDeclaration, ResolvedDeclaration, ResolvedTypeParametrizable, HasAccessSpecifier, AssociableToAST, TypeVariableResolutionCapability
{
	
	private sealed class ___003C_003EAnon0 : Function
	{
		private readonly JavaParserMethodDeclaration arg_00241;

		internal ___003C_003EAnon0(JavaParserMethodDeclaration P_0)
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

	private MethodDeclaration wrappedNode;

	private TypeSolver typeSolver;

	
	
	public JavaParserMethodDeclaration(MethodDeclaration wrappedNode, TypeSolver typeSolver)
	{
		this.wrappedNode = wrappedNode;
		this.typeSolver = typeSolver;
	}

	
	
	private Context getContext()
	{
		Context context = JavaParserFactory.getContext(wrappedNode, typeSolver);
		
		return context;
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

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("JavaParserMethodDeclaration{wrappedNode=").append(wrappedNode).append(", typeSolver=")
			.append(typeSolver)
			.append('}')
			.ToString();
		
		return result;
	}

	
	
	public virtual ResolvedReferenceTypeDeclaration declaringType()
	{
		if (Navigator.demandParentNode(wrappedNode) is ObjectCreationExpr)
		{
			ObjectCreationExpr objectCreationExpr = (ObjectCreationExpr)Navigator.demandParentNode(wrappedNode);
			JavaParserAnonymousClassDeclaration result = new JavaParserAnonymousClassDeclaration(objectCreationExpr, typeSolver);
			
			return result;
		}
		ResolvedReferenceTypeDeclaration result2 = JavaParserFactory.toTypeDeclaration(Navigator.demandParentNode(wrappedNode), typeSolver);
		
		return result2;
	}

	
	
	public virtual ResolvedType getReturnType()
	{
		ResolvedType result = JavaParserFacade.get(typeSolver).convert(wrappedNode.getType(), getContext());
		
		return result;
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

	
	
	public virtual MethodUsage getUsage(Node node)
	{
		
		throw new UnsupportedOperationException();
	}

	
		
	public virtual MethodUsage resolveTypeVariables(Context context, List parameterTypes)
	{
		MethodUsage result = new MethodDeclarationCommonLogic(this, typeSolver).resolveTypeVariables(context, parameterTypes);
		
		return result;
	}

	
	
	public virtual bool isAbstract()
	{
		return (!wrappedNode.getBody().isPresent()) ? true : false;
	}

	
	
	public virtual string getName()
	{
		string id = wrappedNode.getName().getId();
		
		return id;
	}

	
		
	public virtual List getTypeParameters()
	{
		return (List)wrappedNode.getTypeParameters().stream().map(new ___003C_003EAnon0(this))
			.collect(Collectors.toList());
	}

	
	
	public virtual bool isDefaultMethod()
	{
		bool result = wrappedNode.isDefault();
		
		return result;
	}

	
	
	public virtual bool isStatic()
	{
		bool result = wrappedNode.isStatic();
		
		return result;
	}

	public virtual MethodDeclaration getWrappedNode()
	{
		return wrappedNode;
	}

	
	
	public virtual AccessSpecifier accessSpecifier()
	{
		AccessSpecifier result = wrappedNode.getAccessSpecifier();
		
		return result;
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

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool hasName()
	{
		return ResolvedDeclaration._003Cdefault_003EhasName(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isField()
	{
		return ResolvedDeclaration._003Cdefault_003EisField(this);
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
		return ResolvedDeclaration._003Cdefault_003EasField(this);
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

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional findTypeParameter(string P_0)
	{
		return ResolvedMethodLikeDeclaration._003Cdefault_003EfindTypeParameter(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isGeneric()
	{
		return ResolvedTypeParametrizable._003Cdefault_003EisGeneric(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual string getPackageName()
	{
		return ResolvedMethodLikeDeclaration._003Cdefault_003EgetPackageName(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual string getClassName()
	{
		return ResolvedMethodLikeDeclaration._003Cdefault_003EgetClassName(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual string getQualifiedName()
	{
		return ResolvedMethodLikeDeclaration._003Cdefault_003EgetQualifiedName(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual string getSignature()
	{
		return ResolvedMethodLikeDeclaration._003Cdefault_003EgetSignature(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual string getQualifiedSignature()
	{
		return ResolvedMethodLikeDeclaration._003Cdefault_003EgetQualifiedSignature(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedParameterDeclaration getLastParam()
	{
		return ResolvedMethodLikeDeclaration._003Cdefault_003EgetLastParam(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool hasVariadicParameter()
	{
		return ResolvedMethodLikeDeclaration._003Cdefault_003EhasVariadicParameter(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual List getSpecifiedExceptions()
	{
		return ResolvedMethodLikeDeclaration._003Cdefault_003EgetSpecifiedExceptions(this);
	}
}
