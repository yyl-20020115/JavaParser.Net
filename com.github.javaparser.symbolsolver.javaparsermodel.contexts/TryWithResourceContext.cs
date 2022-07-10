using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.symbolsolver.javaparser;
using com.github.javaparser.symbolsolver.javaparsermodel.declarations;
using com.github.javaparser.symbolsolver.model.resolution;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.symbolsolver.javaparsermodel.contexts;

public class TryWithResourceContext : AbstractJavaParserContext
{
	
	private sealed class ___003C_003EAnon0 : Function
	{
		internal ___003C_003EAnon0()
		{
		}

		public object apply(object P_0)
		{
			List result = lambda_0024localVariablesExposedToChild_00240((Expression)P_0);
			
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

	
	private sealed class ___003C_003EAnon1 : Function
	{
		internal ___003C_003EAnon1()
		{
		}

		public object apply(object P_0)
		{
			Stream result = ((List)P_0).stream();
			
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

	
	
	
	private static List lambda_0024localVariablesExposedToChild_00240(Expression P_0)
	{
		List obj = ((!(P_0 is VariableDeclarationExpr)) ? Collections.emptyList() : ((VariableDeclarationExpr)P_0).getVariables());
		List result = ((obj == null) ? null : ((obj as List) ?? throw new java.lang.IncompatibleClassChangeError()));
		
		return result;
	}

	
	
	public TryWithResourceContext(TryStmt wrappedNode, TypeSolver typeSolver)
		: base(wrappedNode, typeSolver)
	{
	}

	
		[LineNumberTable(new byte[]
	{
		5, 127, 14, 104, 127, 6, 115, 110, 143, 130,
		133, 114, 154
	})]
	public override Optional solveSymbolAsValue(string name)
	{
		Iterator iterator = ((TryStmt)wrappedNode).getResources().iterator();
		while (iterator.hasNext())
		{
			Expression expression = (Expression)iterator.next();
			if (!(expression is VariableDeclarationExpr))
			{
				continue;
			}
			Iterator iterator2 = ((VariableDeclarationExpr)expression).getVariables().iterator();
			while (iterator2.hasNext())
			{
				VariableDeclarator variableDeclarator = (VariableDeclarator)iterator2.next();
				if (String.instancehelper_equals(variableDeclarator.getName().getIdentifier(), name))
				{
					JavaParserVariableDeclaration decl = JavaParserSymbolDeclaration.localVar(variableDeclarator, typeSolver);
					Optional result = Optional.of(Value.from(decl));
					
					return result;
				}
			}
		}
		if (Navigator.demandParentNode(wrappedNode) is BlockStmt)
		{
			Optional result2 = StatementContext.solveInBlockAsValue(name, typeSolver, (Statement)wrappedNode);
			
			return result2;
		}
		Optional result3 = solveSymbolAsValueInParentContext(name);
		
		return result3;
	}

	
		[LineNumberTable(new byte[]
	{
		25, 127, 14, 104, 127, 6, 115, 148, 130, 133,
		114, 154
	})]
	public override SymbolReference solveSymbol(string name)
	{
		Iterator iterator = ((TryStmt)wrappedNode).getResources().iterator();
		while (iterator.hasNext())
		{
			Expression expression = (Expression)iterator.next();
			if (!(expression is VariableDeclarationExpr))
			{
				continue;
			}
			Iterator iterator2 = ((VariableDeclarationExpr)expression).getVariables().iterator();
			while (iterator2.hasNext())
			{
				VariableDeclarator variableDeclarator = (VariableDeclarator)iterator2.next();
				if (String.instancehelper_equals(variableDeclarator.getName().getIdentifier(), name))
				{
					SymbolReference result = SymbolReference.solved(JavaParserSymbolDeclaration.localVar(variableDeclarator, typeSolver));
					
					return result;
				}
			}
		}
		if (Navigator.demandParentNode(wrappedNode) is BlockStmt)
		{
			SymbolReference result2 = StatementContext.solveInBlock(name, typeSolver, (Statement)wrappedNode);
			
			return result2;
		}
		SymbolReference result3 = solveSymbolInParentContext(name);
		
		return result3;
	}

	
		
	public override SymbolReference solveMethod(string name, List argumentsTypes, bool staticOnly)
	{
		SymbolReference result = solveMethodInParentContext(name, argumentsTypes, false);
		
		return result;
	}

	
		[LineNumberTable(new byte[]
	{
		50, 113, 107, 106, 119, 143, 101, 239, 60, 1,
		230, 73, 115, 102, 124, 105, 147, 98, 130
	})]
	public override List localVariablesExposedToChild(Node child)
	{
		NodeList resources = ((TryStmt)wrappedNode).getResources();
		for (int i = 0; i < resources.size(); i++)
		{
			if (child == resources.get(i))
			{
				return (List)resources.subList(0, i).stream().map(new ___003C_003EAnon0())
					.flatMap(new ___003C_003EAnon1())
					.collect(Collectors.toList());
			}
		}
		if (child == ((TryStmt)wrappedNode).getTryBlock())
		{
			LinkedList linkedList = new LinkedList();
			Iterator iterator = resources.iterator();
			while (iterator.hasNext())
			{
				Expression expression = (Expression)iterator.next();
				if (expression is VariableDeclarationExpr)
				{
					((List)linkedList).addAll((Collection)((VariableDeclarationExpr)expression).getVariables());
				}
			}
			return linkedList;
		}
		List result = Collections.emptyList();
		
		return result;
	}
}
