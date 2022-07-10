using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.symbolsolver.javaparsermodel.declarations;
using com.github.javaparser.symbolsolver.model.resolution;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.symbolsolver.javaparsermodel.declarators;

public class VariableSymbolDeclarator : AbstractSymbolDeclarator
{
	
	private sealed class ___003C_003EAnon0 : Consumer
	{
		internal ___003C_003EAnon0()
		{
		}

		public void accept(object P_0)
		{
			lambda_0024new_00240((Node)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Function
	{
		private readonly VariableSymbolDeclarator arg_00241;

		internal ___003C_003EAnon1(VariableSymbolDeclarator P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			JavaParserVariableDeclaration result = arg_00241.lambda_0024getSymbolDeclarations_00241((VariableDeclarator)P_0);
			
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

	
	private sealed class ___003C_003EAnon2 : Supplier
	{
		internal ___003C_003EAnon2()
		{
		}

		public object get()
		{
			ArrayList result = new ArrayList();
			
			return result;
		}
	}

	
	
	
	private static void lambda_0024new_00240(Node P_0)
	{
		if (P_0 is FieldDeclaration)
		{
			
			throw new IllegalArgumentException();
		}
	}

	
	
	
	private JavaParserVariableDeclaration lambda_0024getSymbolDeclarations_00241(VariableDeclarator P_0)
	{
		JavaParserVariableDeclaration result = JavaParserSymbolDeclaration.localVar(P_0, typeSolver);
		
		return result;
	}

	
	
	public VariableSymbolDeclarator(VariableDeclarationExpr wrappedNode, TypeSolver typeSolver)
		: base(wrappedNode, typeSolver)
	{
		wrappedNode.getParentNode().ifPresent(new ___003C_003EAnon0());
	}

	
		
	public override List getSymbolDeclarations()
	{
		List c = (List)((VariableDeclarationExpr)wrappedNode).getVariables().stream().map(new ___003C_003EAnon1(this))
			.collect(Collectors.toCollection(new ___003C_003EAnon2()));
		return new ArrayList(c);
	}
}
