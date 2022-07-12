
using com.github.javaparser.ast.stmt;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.javaparser;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.model.typesystem;
using com.github.javaparser.symbolsolver.resolution;

using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.javaparsermodel.contexts;

public class SwitchEntryContext : AbstractJavaParserContext
{
	
	
	public SwitchEntryContext(SwitchEntry wrappedNode, TypeSolver typeSolver)
		: base(wrappedNode, typeSolver)
	{
	}

	
		
	public override SymbolReference solveSymbol(string name)
	{
		SwitchStmt switchStmt = (SwitchStmt)Navigator.demandParentNode(wrappedNode);
		ResolvedType type = JavaParserFacade.get(typeSolver).getType(switchStmt.getSelector());
		if (type.isReferenceType() && type.asReferenceType().getTypeDeclaration().isPresent())
		{
			ResolvedReferenceTypeDeclaration resolvedReferenceTypeDeclaration = (ResolvedReferenceTypeDeclaration)type.asReferenceType().getTypeDeclaration().get();
			if (resolvedReferenceTypeDeclaration.isEnum())
			{
				if (!(type is ReferenceTypeImpl))
				{
					
					throw new UnsupportedOperationException();
				}
				ReferenceTypeImpl referenceTypeImpl = (ReferenceTypeImpl)type;
				if (referenceTypeImpl.getTypeDeclaration().isPresent())
				{
					ResolvedReferenceTypeDeclaration resolvedReferenceTypeDeclaration2 = (ResolvedReferenceTypeDeclaration)referenceTypeImpl.getTypeDeclaration().get();
					if (resolvedReferenceTypeDeclaration2.asEnum().hasEnumConstant(name))
					{
						SymbolReference result = SymbolReference.solved(resolvedReferenceTypeDeclaration2.asEnum().getEnumConstant(name));
						
						return result;
					}
					if (resolvedReferenceTypeDeclaration2.hasField(name))
					{
						SymbolReference result2 = SymbolReference.solved(resolvedReferenceTypeDeclaration2.getField(name));
						
						return result2;
					}
				}
			}
		}
		Iterator iterator = switchStmt.getEntries().iterator();
		while (iterator.hasNext())
		{
			SwitchEntry switchEntry = (SwitchEntry)iterator.next();
			Iterator iterator2 = switchEntry.getStatements().iterator();
			while (iterator2.hasNext())
			{
				Statement node = (Statement)iterator2.next();
				SymbolDeclarator symbolDeclarator = JavaParserFactory.getSymbolDeclarator(node, typeSolver);
				SymbolReference symbolReference = AbstractJavaParserContext.solveWith(symbolDeclarator, name);
				if (symbolReference.isSolved())
				{
					return symbolReference;
				}
			}
			if (switchEntry == wrappedNode)
			{
				break;
			}
		}
		SymbolReference result3 = solveSymbolInParentContext(name);
		
		return result3;
	}

	
		
	public override SymbolReference solveMethod(string name, List argumentsTypes, bool staticOnly)
	{
		SymbolReference result = solveMethodInParentContext(name, argumentsTypes, false);
		
		return result;
	}
}
