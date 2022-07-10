using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.symbolsolver.javaparser;
using com.github.javaparser.symbolsolver.model.resolution;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.javaparsermodel.declarations;

public class JavaParserSymbolDeclaration
{
	
	
	public static JavaParserPatternDeclaration patternVar(PatternExpr patternExpr, TypeSolver typeSolver)
	{
		JavaParserPatternDeclaration result = new JavaParserPatternDeclaration(patternExpr, typeSolver);
		
		return result;
	}

	
	
	public static JavaParserVariableDeclaration localVar(VariableDeclarator variableDeclarator, TypeSolver typeSolver)
	{
		JavaParserVariableDeclaration result = new JavaParserVariableDeclaration(variableDeclarator, typeSolver);
		
		return result;
	}

	
	
	public static JavaParserFieldDeclaration field(VariableDeclarator wrappedNode, TypeSolver typeSolver)
	{
		JavaParserFieldDeclaration result = new JavaParserFieldDeclaration(wrappedNode, typeSolver);
		
		return result;
	}

	
	
	public static JavaParserParameterDeclaration parameter(Parameter parameter, TypeSolver typeSolver)
	{
		JavaParserParameterDeclaration result = new JavaParserParameterDeclaration(parameter, typeSolver);
		
		return result;
	}

	
	
	public static int getParamPos(Parameter parameter)
	{
		int num = 0;
		Iterator iterator = Navigator.demandParentNode(parameter).getChildNodes().iterator();
		while (iterator.hasNext())
		{
			Node node = (Node)iterator.next();
			if (node == parameter)
			{
				return num;
			}
			if (node is Parameter)
			{
				num++;
			}
		}
		return num;
	}

	
	
	public static int getParamPos(Node node)
	{
		if (Navigator.demandParentNode(node) is MethodCallExpr)
		{
			MethodCallExpr methodCallExpr = (MethodCallExpr)Navigator.demandParentNode(node);
			for (int i = 0; i < methodCallExpr.getArguments().size(); i++)
			{
				if (methodCallExpr.getArguments().get(i) == node)
				{
					return i;
				}
			}
			
			throw new IllegalStateException();
		}
		
		throw new IllegalArgumentException();
	}

	
	
	private JavaParserSymbolDeclaration()
	{
	}
}
