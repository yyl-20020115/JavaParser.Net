using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.type;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.javaparsermodel.declarations;
using com.github.javaparser.symbolsolver.model.resolution;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.symbolsolver.javaparsermodel.contexts;

public class ClassOrInterfaceDeclarationContext : AbstractJavaParserContext
{
	
	private sealed class ___003C_003EAnon0 : Consumer
	{
		private readonly List arg_00241;

		internal ___003C_003EAnon0(List P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			lambda_0024fieldsExposedToChild_00240(arg_00241, (ClassOrInterfaceType)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Consumer
	{
		private readonly List arg_00241;

		internal ___003C_003EAnon1(List P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			lambda_0024fieldsExposedToChild_00241(arg_00241, (ClassOrInterfaceType)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	private JavaParserTypeDeclarationAdapter javaParserTypeDeclarationAdapter;

	
	
	private ResolvedReferenceTypeDeclaration getDeclaration()
	{
		ResolvedReferenceTypeDeclaration typeDeclaration = JavaParserFacade.get(typeSolver).getTypeDeclaration((ClassOrInterfaceDeclaration)wrappedNode);
		
		return typeDeclaration;
	}

	
	
	
	private static void lambda_0024fieldsExposedToChild_00240(List P_0, ClassOrInterfaceType P_1)
	{
		P_0.addAll(P_1.resolve().asReferenceType().getAllFieldsVisibleToInheritors());
	}

	
	
	
	private static void lambda_0024fieldsExposedToChild_00241(List P_0, ClassOrInterfaceType P_1)
	{
		P_0.addAll(P_1.resolve().asReferenceType().getAllFieldsVisibleToInheritors());
	}

	
	
	public ClassOrInterfaceDeclarationContext(ClassOrInterfaceDeclaration wrappedNode, TypeSolver typeSolver)
		: base(wrappedNode, typeSolver)
	{
		javaParserTypeDeclarationAdapter = new JavaParserTypeDeclarationAdapter(wrappedNode, typeSolver, getDeclaration(), this);
	}

	
		
	public override SymbolReference solveSymbol(string name)
	{
		if (typeSolver == null)
		{
			
			throw new IllegalArgumentException();
		}
		if (getDeclaration().hasVisibleField(name))
		{
			SymbolReference result = SymbolReference.solved(getDeclaration().getVisibleField(name));
			
			return result;
		}
		SymbolReference result2 = solveSymbolInParentContext(name);
		
		return result2;
	}

	
		
	public override Optional solveSymbolAsValue(string name)
	{
		if (typeSolver == null)
		{
			
			throw new IllegalArgumentException();
		}
		if (getDeclaration().hasField(name))
		{
			Optional result = Optional.of(Value.from(getDeclaration().getField(name)));
			
			return result;
		}
		Optional result2 = solveSymbolAsValueInParentContext(name);
		
		return result2;
	}

	
		
	public override Optional solveGenericType(string name)
	{
		Iterator iterator = ((ClassOrInterfaceDeclaration)wrappedNode).getTypeParameters().iterator();
		while (iterator.hasNext())
		{
			TypeParameter typeParameter = (TypeParameter)iterator.next();
			if (String.instancehelper_equals(typeParameter.getName().getId(), name))
			{
				Optional result = Optional.of(new ResolvedTypeVariable(new JavaParserTypeParameter(typeParameter, typeSolver)));
				
				return result;
			}
		}
		Optional result2 = solveGenericTypeInParentContext(name);
		
		return result2;
	}

	
		
	public override SymbolReference solveType(string name)
	{
		SymbolReference result = javaParserTypeDeclarationAdapter.solveType(name);
		
		return result;
	}

	
		
	public override SymbolReference solveMethod(string name, List argumentsTypes, bool staticOnly)
	{
		SymbolReference result = javaParserTypeDeclarationAdapter.solveMethod(name, argumentsTypes, staticOnly);
		
		return result;
	}

	
		
	public override SymbolReference solveConstructor(List argumentsTypes)
	{
		SymbolReference result = javaParserTypeDeclarationAdapter.solveConstructor(argumentsTypes);
		
		return result;
	}

	
		
	public override List fieldsExposedToChild(Node child)
	{
		LinkedList linkedList = new LinkedList();
		((List)linkedList).addAll((Collection)((ClassOrInterfaceDeclaration)wrappedNode).resolve().getDeclaredFields());
		((ClassOrInterfaceDeclaration)wrappedNode).getExtendedTypes().forEach(new ___003C_003EAnon0(linkedList));
		((ClassOrInterfaceDeclaration)wrappedNode).getImplementedTypes().forEach(new ___003C_003EAnon1(linkedList));
		return linkedList;
	}
}
