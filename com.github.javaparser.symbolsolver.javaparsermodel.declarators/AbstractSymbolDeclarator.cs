
using com.github.javaparser.ast;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.resolution;

using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.javaparsermodel.declarators;

public abstract class AbstractSymbolDeclarator : SymbolDeclarator
{
		protected internal Node wrappedNode;

	protected internal TypeSolver typeSolver;

	
		
	public AbstractSymbolDeclarator(Node wrappedNode, TypeSolver typeSolver)
	{
		this.wrappedNode = wrappedNode;
		this.typeSolver = typeSolver;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract List getSymbolDeclarations();
}
