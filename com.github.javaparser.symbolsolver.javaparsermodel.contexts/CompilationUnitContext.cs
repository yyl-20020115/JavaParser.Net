
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.type;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.symbolsolver.javaparsermodel.declarations;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.resolution;

using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.symbolsolver.javaparsermodel.contexts;

public class CompilationUnitContext : AbstractJavaParserContext
{
	
	private sealed class ___003C_003EAnon0 : Function
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon0(string P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			Boolean result = lambda_0024solveType_00240(arg_00241, (string)P_0);
			
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

	
	private sealed class ___003C_003EAnon1 : Predicate
	{
		private readonly CompilationUnitContext arg_00241;

		private readonly string arg_00242;

		internal ___003C_003EAnon1(CompilationUnitContext P_0, string P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public bool test(object P_0)
		{
			bool result = arg_00241.lambda_0024solveMethod_00241(arg_00242, (TypeDeclaration)P_0);
			
			return result;
		}

		
		public Predicate and(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public Predicate negate()
		{
			return Predicate._003Cdefault_003Enegate(this);
		}

		
		public Predicate or(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon2 : Predicate
	{
		internal ___003C_003EAnon2()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024fieldsExposedToChild_00242((ResolvedFieldDeclaration)P_0);
			
			return result;
		}

		
		public Predicate and(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public Predicate negate()
		{
			return Predicate._003Cdefault_003Enegate(this);
		}

		
		public Predicate or(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon3 : Predicate
	{
		private readonly ImportDeclaration arg_00241;

		internal ___003C_003EAnon3(ImportDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024fieldsExposedToChild_00243(arg_00241, (ResolvedFieldDeclaration)P_0);
			
			return result;
		}

		
		public Predicate and(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public Predicate negate()
		{
			return Predicate._003Cdefault_003Enegate(this);
		}

		
		public Predicate or(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	
	private string getType(string P_0)
	{
		int num = String.instancehelper_lastIndexOf(P_0, 46);
		if (num == -1)
		{
			
			throw new UnsupportedOperationException();
		}
		return String.instancehelper_substring(P_0, 0, num);
	}

	
	
	private string getMember(string P_0)
	{
		int num = String.instancehelper_lastIndexOf(P_0, 46);
		if (num == -1)
		{
			
			throw new UnsupportedOperationException();
		}
		return String.instancehelper_substring(P_0, num + 1);
	}

	
		
	public override SymbolReference solveType(string name)
	{
		if (((CompilationUnit)wrappedNode).getTypes() != null)
		{
			Iterator iterator = ((CompilationUnit)wrappedNode).getTypes().iterator();
			while (iterator.hasNext())
			{
				TypeDeclaration typeDeclaration = (TypeDeclaration)iterator.next();
				if (String.instancehelper_equals(typeDeclaration.getName().getId(), name) || ((Boolean)typeDeclaration.getFullyQualifiedName().map(new ___003C_003EAnon0(name)).orElse(Boolean.valueOf(b: false))).booleanValue())
				{
					if (typeDeclaration is ClassOrInterfaceDeclaration)
					{
						SymbolReference result = SymbolReference.solved(JavaParserFacade.get(typeSolver).getTypeDeclaration((ClassOrInterfaceDeclaration)typeDeclaration));
						
						return result;
					}
					if (typeDeclaration is AnnotationDeclaration)
					{
						SymbolReference result2 = SymbolReference.solved(new JavaParserAnnotationDeclaration((AnnotationDeclaration)typeDeclaration, typeSolver));
						
						return result2;
					}
					if (typeDeclaration is EnumDeclaration)
					{
						JavaParserEnumDeclaration.___003Cclinit_003E();
						SymbolReference result3 = SymbolReference.solved(new JavaParserEnumDeclaration((EnumDeclaration)typeDeclaration, typeSolver));
						
						return result3;
					}
					string canonicalName = Object.instancehelper_getClass(typeDeclaration).getCanonicalName();
					
					throw new UnsupportedOperationException(canonicalName);
				}
			}
			if (String.instancehelper_indexOf(name, 46) > -1)
			{
				SymbolReference symbolReference = null;
				SymbolReference symbolReference2 = solveType(String.instancehelper_substring(name, 0, String.instancehelper_indexOf(name, ".")));
				if (symbolReference2 != null && symbolReference2.isSolved() && symbolReference2.getCorrespondingDeclaration() is JavaParserClassDeclaration)
				{
					symbolReference = ((JavaParserClassDeclaration)symbolReference2.getCorrespondingDeclaration()).solveType(String.instancehelper_substring(name, String.instancehelper_indexOf(name, ".") + 1));
				}
				else if (symbolReference2 != null && symbolReference2.isSolved() && symbolReference2.getCorrespondingDeclaration() is JavaParserInterfaceDeclaration)
				{
					symbolReference = ((JavaParserInterfaceDeclaration)symbolReference2.getCorrespondingDeclaration()).solveType(String.instancehelper_substring(name, String.instancehelper_indexOf(name, ".") + 1));
				}
				if (symbolReference != null && symbolReference.isSolved())
				{
					return symbolReference;
				}
			}
		}
		int num = String.instancehelper_indexOf(name, 46);
		string text = null;
		if (num > -1)
		{
			text = String.instancehelper_substring(name, 0, num);
		}
		Iterator iterator2 = ((CompilationUnit)wrappedNode).getImports().iterator();
		while (iterator2.hasNext())
		{
			ImportDeclaration importDeclaration = (ImportDeclaration)iterator2.next();
			if (importDeclaration.isAsterisk())
			{
				continue;
			}
			string text2 = importDeclaration.getNameAsString();
			int num2 = ((importDeclaration.getName().getQualifier().isPresent() && 0 == 0 && String.instancehelper_equals(importDeclaration.getName().getIdentifier(), name)) ? 1 : 0);
			if (num2 == 0 && text != null)
			{
				num2 = (String.instancehelper_endsWith(text2, new StringBuilder().append(".").append(text).ToString()) ? 1 : 0);
				if (num2 != 0)
				{
					text2 = new StringBuilder().append(text2).append(String.instancehelper_substring(name, num)).ToString();
				}
			}
			if (num2 != 0)
			{
				SymbolReference symbolReference3 = typeSolver.tryToSolveType(text2);
				if (symbolReference3 != null && symbolReference3.isSolved())
				{
					SymbolReference result4 = SymbolReference.adapt(symbolReference3, ClassLiteral<ResolvedTypeDeclaration>.Value);
					
					return result4;
				}
			}
		}
		if (((CompilationUnit)wrappedNode).getPackageDeclaration().isPresent())
		{
			string str = new StringBuilder().append(((PackageDeclaration)((CompilationUnit)wrappedNode).getPackageDeclaration().get()).getName().ToString()).append(".").append(name)
				.ToString();
			SymbolReference symbolReference4 = typeSolver.tryToSolveType(str);
			if (symbolReference4 != null && symbolReference4.isSolved())
			{
				SymbolReference result5 = SymbolReference.adapt(symbolReference4, ClassLiteral<ResolvedTypeDeclaration>.Value);
				
				return result5;
			}
		}
		else
		{
			string str = name;
			SymbolReference symbolReference4 = typeSolver.tryToSolveType(str);
			if (symbolReference4 != null && symbolReference4.isSolved())
			{
				SymbolReference result6 = SymbolReference.adapt(symbolReference4, ClassLiteral<ResolvedTypeDeclaration>.Value);
				
				return result6;
			}
		}
		iterator2 = ((CompilationUnit)wrappedNode).getImports().iterator();
		while (iterator2.hasNext())
		{
			ImportDeclaration importDeclaration = (ImportDeclaration)iterator2.next();
			if (importDeclaration.isAsterisk())
			{
				string text2 = new StringBuilder().append(importDeclaration.getNameAsString()).append(".").append(name)
					.ToString();
				SymbolReference symbolReference5 = typeSolver.tryToSolveType(text2);
				if (symbolReference5 != null && symbolReference5.isSolved())
				{
					SymbolReference result7 = SymbolReference.adapt(symbolReference5, ClassLiteral<ResolvedTypeDeclaration>.Value);
					
					return result7;
				}
			}
		}
		SymbolReference symbolReference6 = typeSolver.tryToSolveType(new StringBuilder().append("java.lang.").append(name).ToString());
		if (symbolReference6 != null && symbolReference6.isSolved())
		{
			SymbolReference result8 = SymbolReference.adapt(symbolReference6, ClassLiteral<ResolvedTypeDeclaration>.Value);
			
			return result8;
		}
		if (AbstractJavaParserContext.isQualifiedName(name))
		{
			SymbolReference result9 = SymbolReference.adapt(typeSolver.tryToSolveType(name), ClassLiteral<ResolvedTypeDeclaration>.Value);
			
			return result9;
		}
		SymbolReference result10 = SymbolReference.unsolved(ClassLiteral<ResolvedReferenceTypeDeclaration>.Value);
		
		return result10;
	}

	
	
	private bool isAncestorOf(ResolvedTypeDeclaration P_0)
	{
		if (P_0 is AssociableToAST)
		{
			Optional optional = ((AssociableToAST)P_0).toAst();
			if (optional.isPresent())
			{
				bool result = ((CompilationUnit)wrappedNode).isAncestorOf((Node)optional.get());
				
				return result;
			}
			return false;
		}
		if (P_0 is JavaParserEnumDeclaration)
		{
			bool result2 = ((CompilationUnit)wrappedNode).isAncestorOf(((JavaParserEnumDeclaration)P_0).getWrappedNode());
			
			return result2;
		}
		
		throw new UnsupportedOperationException();
	}

	
	
	private string qName(ClassOrInterfaceType P_0)
	{
		if (P_0.getScope().isPresent())
		{
			string result = new StringBuilder().append(qName((ClassOrInterfaceType)P_0.getScope().get())).append(".").append(P_0.getName().getId())
				.ToString();
			
			return result;
		}
		string id = P_0.getName().getId();
		
		return id;
	}

	
	
	private string qName(Name P_0)
	{
		if (P_0.getQualifier().isPresent())
		{
			string result = new StringBuilder().append(qName((Name)P_0.getQualifier().get())).append(".").append(P_0.getId())
				.ToString();
			
			return result;
		}
		string id = P_0.getId();
		
		return id;
	}

	
	
	private string packageName(string P_0)
	{
		int num = String.instancehelper_lastIndexOf(P_0, 46);
		if (num == -1)
		{
			
			throw new UnsupportedOperationException();
		}
		string result = String.instancehelper_substring(P_0, 0, num);
		
		return result;
	}

	
	
	private string toSimpleName(string P_0)
	{
		string[] array = String.instancehelper_split(P_0, "\\.");
		return array[(nint)array.LongLength - 1];
	}

	
	
	
	private static Boolean lambda_0024solveType_00240(string P_0, string P_1)
	{
		Boolean result = Boolean.valueOf(String.instancehelper_equals(P_1, P_0));
		
		return result;
	}

	
	
	
	private bool lambda_0024solveMethod_00241(string P_0, TypeDeclaration P_1)
	{
		bool result = String.instancehelper_equals(P_1.getName().getIdentifier(), toSimpleName(P_0));
		
		return result;
	}

	
	
	
	private static bool lambda_0024fieldsExposedToChild_00242(ResolvedFieldDeclaration P_0)
	{
		bool result = P_0.isStatic();
		
		return result;
	}

	
	
	
	private static bool lambda_0024fieldsExposedToChild_00243(ImportDeclaration P_0, ResolvedFieldDeclaration P_1)
	{
		return (P_0.isAsterisk() || String.instancehelper_equals(P_0.getName().getIdentifier(), P_1.getName())) ? true : false;
	}

	
	
	public CompilationUnitContext(CompilationUnit wrappedNode, TypeSolver typeSolver)
		: base(wrappedNode, typeSolver)
	{
	}

	
		
	public override SymbolReference solveSymbol(string name)
	{
		string text = name;
		CharSequence s = default(CharSequence);
		while (true)
		{
			string @this = text;
			object obj = (s.___003Cref_003E = ".");
			if (!String.instancehelper_contains(@this, s))
			{
				break;
			}
			string type = getType(text);
			string member = getMember(text);
			SymbolReference symbolReference = solveType(type);
			if (symbolReference.isSolved())
			{
				SymbolReference result = new SymbolSolver(typeSolver).solveSymbolInType((ResolvedTypeDeclaration)symbolReference.getCorrespondingDeclaration(), member);
				
				return result;
			}
			text = type;
		}
		Iterator iterator = ((CompilationUnit)wrappedNode).getImports().iterator();
		while (iterator.hasNext())
		{
			ImportDeclaration importDeclaration = (ImportDeclaration)iterator.next();
			if (!importDeclaration.isStatic())
			{
				continue;
			}
			string nameAsString;
			if (importDeclaration.isAsterisk())
			{
				nameAsString = importDeclaration.getNameAsString();
				ResolvedReferenceTypeDeclaration resolvedReferenceTypeDeclaration = typeSolver.solveType(nameAsString);
				if (!isAncestorOf(resolvedReferenceTypeDeclaration))
				{
					SymbolReference symbolReference2 = new SymbolSolver(typeSolver).solveSymbolInType(resolvedReferenceTypeDeclaration, name);
					if (symbolReference2.isSolved())
					{
						return symbolReference2;
					}
				}
				continue;
			}
			nameAsString = importDeclaration.getNameAsString();
			string member2 = getMember(nameAsString);
			string type2 = getType(nameAsString);
			if (!String.instancehelper_equals(member2, name))
			{
				continue;
			}
			ResolvedReferenceTypeDeclaration typeDeclaration = typeSolver.solveType(type2);
			SymbolReference result2 = new SymbolSolver(typeSolver).solveSymbolInType(typeDeclaration, member2);
			
			return result2;
		}
		SymbolReference result3 = SymbolReference.unsolved(ClassLiteral<ResolvedValueDeclaration>.Value);
		
		return result3;
	}

	
		
	public override SymbolReference solveMethod(string name, List argumentsTypes, bool staticOnly)
	{
		Iterator iterator = ((CompilationUnit)wrappedNode).getImports().iterator();
		while (iterator.hasNext())
		{
			ImportDeclaration importDeclaration = (ImportDeclaration)iterator.next();
			if (!importDeclaration.isStatic())
			{
				continue;
			}
			string nameAsString;
			if (importDeclaration.isAsterisk())
			{
				nameAsString = importDeclaration.getNameAsString();
				if (((CompilationUnit)wrappedNode).getPackageDeclaration().isPresent() && String.instancehelper_equals(((PackageDeclaration)((CompilationUnit)wrappedNode).getPackageDeclaration().get()).getName().getIdentifier(), packageName(nameAsString)) && ((CompilationUnit)wrappedNode).getTypes().stream().anyMatch(new ___003C_003EAnon1(this, nameAsString)))
				{
					SymbolReference result = SymbolReference.unsolved(ClassLiteral<ResolvedMethodDeclaration>.Value);
					
					return result;
				}
				ResolvedReferenceTypeDeclaration resolvedReferenceTypeDeclaration = typeSolver.solveType(nameAsString);
				if (!isAncestorOf(resolvedReferenceTypeDeclaration))
				{
					SymbolReference symbolReference = MethodResolutionLogic.solveMethodInType(resolvedReferenceTypeDeclaration, name, argumentsTypes, staticOnly: true);
					if (symbolReference.isSolved())
					{
						return symbolReference;
					}
				}
				continue;
			}
			nameAsString = importDeclaration.getNameAsString();
			if (!String.instancehelper_equals(nameAsString, name) && !String.instancehelper_endsWith(nameAsString, new StringBuilder().append(".").append(name).ToString()))
			{
				continue;
			}
			string type = getType(nameAsString);
			ResolvedReferenceTypeDeclaration typeDeclaration = typeSolver.solveType(type);
			SymbolReference symbolReference2 = MethodResolutionLogic.solveMethodInType(typeDeclaration, name, argumentsTypes, staticOnly: true);
			if (symbolReference2.isSolved())
			{
				return symbolReference2;
			}
			SymbolReference result2 = SymbolReference.unsolved(ClassLiteral<ResolvedMethodDeclaration>.Value);
			
			return result2;
		}
		SymbolReference result3 = SymbolReference.unsolved(ClassLiteral<ResolvedMethodDeclaration>.Value);
		
		return result3;
	}

	
		
	public override List fieldsExposedToChild(Node child)
	{
		LinkedList linkedList = new LinkedList();
		Iterator iterator = ((CompilationUnit)wrappedNode).getImports().iterator();
		while (iterator.hasNext())
		{
			ImportDeclaration importDeclaration = (ImportDeclaration)iterator.next();
			if (importDeclaration.isStatic())
			{
				Name name = ((!importDeclaration.isAsterisk()) ? ((Name)importDeclaration.getName().getQualifier().get()) : importDeclaration.getName());
				string name2 = name.asString();
				ResolvedReferenceTypeDeclaration resolvedReferenceTypeDeclaration = typeSolver.solveType(name2);
				((List)linkedList).addAll((Collection)resolvedReferenceTypeDeclaration.getAllFields().stream().filter(new ___003C_003EAnon2())
					.filter(new ___003C_003EAnon3(importDeclaration))
					.collect(Collectors.toList()));
			}
		}
		return linkedList;
	}
}
