
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.symbolsolver.model.resolution;
using com.google.common.collect;

using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.symbolsolver.javaparsermodel.declarations;

internal class AstResolutionUtils
{
	
	private sealed class ___003C_003EAnon0 : Function
	{
		internal ___003C_003EAnon0()
		{
		}

		public object apply(object P_0)
		{
			string result = lambda_0024getPackageName_00240((PackageDeclaration)P_0);
			
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
		private readonly ResolvedReferenceTypeDeclaration arg_00241;

		private readonly TypeSolver arg_00242;

		internal ___003C_003EAnon1(ResolvedReferenceTypeDeclaration P_0, TypeSolver P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			JavaParserConstructorDeclaration result = lambda_0024getConstructors_00241(arg_00241, arg_00242, (ConstructorDeclaration)P_0);
			
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

	
	
	internal static string getPackageName(Node P_0)
	{
		string result = "";
		if (P_0 == null)
		{
			return result;
		}
		Optional optional = P_0.findCompilationUnit();
		if (optional.isPresent())
		{
			result = (string)((CompilationUnit)optional.get()).getPackageDeclaration().map(new ___003C_003EAnon0()).orElse("");
		}
		return result;
	}

	
	
	internal static string getClassName(string P_0, Node P_1)
	{
		if (P_1 is ClassOrInterfaceDeclaration)
		{
			string className = getClassName(P_0, (Node)P_1.getParentNode().orElse(null));
			string id = ((ClassOrInterfaceDeclaration)P_1).getName().getId();
			if (String.instancehelper_isEmpty(className))
			{
				return id;
			}
			string result = new StringBuilder().append(className).append(".").append(id)
				.ToString();
			
			return result;
		}
		if (P_1 is EnumDeclaration)
		{
			string className = getClassName(P_0, (Node)P_1.getParentNode().orElse(null));
			string id = ((EnumDeclaration)P_1).getName().getId();
			if (String.instancehelper_isEmpty(className))
			{
				return id;
			}
			string result2 = new StringBuilder().append(className).append(".").append(id)
				.ToString();
			
			return result2;
		}
		if (P_1 is AnnotationDeclaration)
		{
			string className = getClassName(P_0, (Node)P_1.getParentNode().orElse(null));
			string id = ((AnnotationDeclaration)P_1).getName().getId();
			if (String.instancehelper_isEmpty(className))
			{
				return id;
			}
			string result3 = new StringBuilder().append(className).append(".").append(id)
				.ToString();
			
			return result3;
		}
		if (P_1 != null)
		{
			string className2 = getClassName(P_0, (Node)P_1.getParentNode().orElse(null));
			
			return className2;
		}
		return P_0;
	}

	
	
	
	private static string lambda_0024getPackageName_00240(PackageDeclaration P_0)
	{
		string nameAsString = P_0.getNameAsString();
		
		return nameAsString;
	}

	
	
	
	private static JavaParserConstructorDeclaration lambda_0024getConstructors_00241(ResolvedReferenceTypeDeclaration P_0, TypeSolver P_1, ConstructorDeclaration P_2)
	{
		JavaParserConstructorDeclaration result = new JavaParserConstructorDeclaration(P_0, P_2, P_1);
		
		return result;
	}

	
	
	internal AstResolutionUtils()
	{
	}

	
	
	internal static string containerName(Node P_0)
	{
		string packageName = getPackageName(P_0);
		string className = getClassName("", P_0);
		string result = new StringBuilder().append(packageName).append((String.instancehelper_isEmpty(packageName) || String.instancehelper_isEmpty(className)) ? "" : ".").append(className)
			.ToString();
		
		return result;
	}

	
		
	internal static bool hasDirectlyAnnotation(NodeWithAnnotations P_0, TypeSolver P_1, string P_2)
	{
		Iterator iterator = P_0.getAnnotations().iterator();
		while (iterator.hasNext())
		{
			AnnotationExpr annotationExpr = (AnnotationExpr)iterator.next();
			SymbolReference symbolReference = JavaParserFactory.getContext(annotationExpr, P_1).solveType(annotationExpr.getNameAsString());
			if (symbolReference.isSolved())
			{
				if (String.instancehelper_equals(((ResolvedTypeDeclaration)symbolReference.getCorrespondingDeclaration()).getQualifiedName(), P_2))
				{
					return true;
				}
				continue;
			}
			string id = annotationExpr.getName().getId();
			
			throw new UnsolvedSymbolException(id);
		}
		return false;
	}

	
		
	internal static List getConstructors(NodeWithMembers P_0, TypeSolver P_1, ResolvedReferenceTypeDeclaration P_2)
	{
		List list = (List)P_0.getConstructors().stream().map(new ___003C_003EAnon1(P_2, P_1))
			.collect(Collectors.toList());
		if (list.isEmpty())
		{
			ImmutableList result = ImmutableList.of(new DefaultConstructorDeclaration(P_2));
			
			return result;
		}
		return list;
	}
}
