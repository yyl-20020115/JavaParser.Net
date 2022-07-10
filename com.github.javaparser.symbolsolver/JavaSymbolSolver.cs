using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.type;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.javaparsermodel;
using com.github.javaparser.symbolsolver.javaparsermodel.declarations;
using com.github.javaparser.symbolsolver.model.resolution;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util.function;

namespace com.github.javaparser.symbolsolver;

public class JavaSymbolSolver: SymbolResolver
{
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	
	internal class ArrayLengthValueDeclaration: ResolvedValueDeclaration, ResolvedDeclaration
	{
		
		private static ArrayLengthValueDeclaration INSTANCE;

		
		
		public static void ___003Cclinit_003E()
		{
		}

		
		
		private ArrayLengthValueDeclaration()
		{
		}

		public virtual string getName()
		{
			return "length";
		}

		
		
		public virtual ResolvedType getType()
		{
			return ResolvedPrimitiveType.___003C_003EINT;
		}

		
		internal static ArrayLengthValueDeclaration access_0024000()
		{
			return INSTANCE;
		}

		
		static ArrayLengthValueDeclaration()
		{
			INSTANCE = new ArrayLengthValueDeclaration();
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
	}

	
	private sealed class ___003C_003EAnon0 : Predicate
	{
		private readonly Node arg_00241;

		internal ___003C_003EAnon0(Node P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024resolveDeclaration_00240(arg_00241, (ResolvedEnumConstantDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon1 : Predicate
	{
		internal ___003C_003EAnon1()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024resolveDeclaration_00241((ResolvedConstructorDeclaration)P_0);
			
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
		private readonly ConstructorDeclaration arg_00241;

		internal ___003C_003EAnon2(ConstructorDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024resolveDeclaration_00242(arg_00241, (ResolvedConstructorDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon3 : Supplier
	{
		internal ___003C_003EAnon3()
		{
		}

		public object get()
		{
			RuntimeException result = lambda_0024resolveDeclaration_00243();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon4 : Predicate
	{
		private readonly Node arg_00241;

		internal ___003C_003EAnon4(Node P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024resolveDeclaration_00244(arg_00241, (ResolvedAnnotationMemberDeclaration)P_0);
			
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

	private TypeSolver typeSolver;

	
		[LineNumberTable(new byte[]
	{
		39, 104, 154, 104, 109, 105, 170, 104, 109, 105,
		170, 104, 127, 10, 127, 12, 105, 170, 107, 103,
		114, 116, 118, 112, 101, 111, 108, 106, 171, 104,
		109, 105, 170, 104, 127, 6, 127, 14, 106, 171,
		104, 104, 111, 144, 117, 106, 171, 139, 127, 0,
		117, 127, 0, 149, 159, 11, 106, 171, 104, 120,
		105, 111, 176, 191, 6, 104, 120, 105, 111, 176,
		191, 6, 104, 120, 105, 111, 176, 191, 6, 104,
		120, 105, 111, 176, 191, 6, 107, 120, 105, 114,
		176, 124, 114, 105, 109, 206, 191, 6, 104, 120,
		105, 111, 176, 191, 6, 104, 120, 105, 111, 176,
		191, 6, 107, 112, 104, 159, 1, 105, 144, 142,
		127, 5, 127, 20, 31, 10, 235, 71, 104, 120,
		105, 111, 176, 191, 6, 104, 120, 105, 111, 176,
		191, 6, 127, 6
	})]
	public virtual object resolveDeclaration(Node node, Class resultClass)
	{
		if (node is MethodDeclaration)
		{
			object result = resultClass.cast(new JavaParserMethodDeclaration((MethodDeclaration)node, typeSolver));
			
			return result;
		}
		if (node is ClassOrInterfaceDeclaration)
		{
			ResolvedReferenceTypeDeclaration obj = JavaParserFactory.toTypeDeclaration(node, typeSolver);
			if (resultClass.isInstance(obj))
			{
				object result2 = resultClass.cast(obj);
				
				return result2;
			}
		}
		if (node is EnumDeclaration)
		{
			ResolvedReferenceTypeDeclaration obj = JavaParserFactory.toTypeDeclaration(node, typeSolver);
			if (resultClass.isInstance(obj))
			{
				object result3 = resultClass.cast(obj);
				
				return result3;
			}
		}
		if (node is EnumConstantDeclaration)
		{
			ResolvedEnumDeclaration resolvedEnumDeclaration = ((EnumDeclaration)node.findAncestor(new Class[1] { ClassLiteral<EnumDeclaration>.Value }).get()).resolve().asEnum();
			ResolvedEnumConstantDeclaration obj2 = (ResolvedEnumConstantDeclaration)resolvedEnumDeclaration.getEnumConstants().stream().filter(new ___003C_003EAnon0(node))
				.findFirst()
				.get();
			if (resultClass.isInstance(obj2))
			{
				object result4 = resultClass.cast(obj2);
				
				return result4;
			}
		}
		if (node is ConstructorDeclaration)
		{
			ConstructorDeclaration constructorDeclaration = (ConstructorDeclaration)node;
			TypeDeclaration node2 = (TypeDeclaration)node.getParentNode().get();
			ResolvedReferenceTypeDeclaration resolvedReferenceTypeDeclaration = (ResolvedReferenceTypeDeclaration)resolveDeclaration(node2, ClassLiteral<ResolvedReferenceTypeDeclaration>.Value);
			ResolvedConstructorDeclaration obj3 = (ResolvedConstructorDeclaration)resolvedReferenceTypeDeclaration.getConstructors().stream().filter(new ___003C_003EAnon1())
				.filter(new ___003C_003EAnon2(constructorDeclaration))
				.findFirst()
				.orElseThrow(new ___003C_003EAnon3());
			if (resultClass.isInstance(obj3))
			{
				object result5 = resultClass.cast(obj3);
				
				return result5;
			}
		}
		if (node is AnnotationDeclaration)
		{
			ResolvedReferenceTypeDeclaration obj = JavaParserFactory.toTypeDeclaration(node, typeSolver);
			if (resultClass.isInstance(obj))
			{
				object result6 = resultClass.cast(obj);
				
				return result6;
			}
		}
		if (node is AnnotationMemberDeclaration)
		{
			ResolvedAnnotationDeclaration resolvedAnnotationDeclaration = ((AnnotationDeclaration)node.findAncestor(new Class[1] { ClassLiteral<AnnotationDeclaration>.Value }).get()).resolve();
			ResolvedAnnotationMemberDeclaration obj4 = (ResolvedAnnotationMemberDeclaration)resolvedAnnotationDeclaration.getAnnotationMembers().stream().filter(new ___003C_003EAnon4(node))
				.findFirst()
				.get();
			if (resultClass.isInstance(obj4))
			{
				object result7 = resultClass.cast(obj4);
				
				return result7;
			}
		}
		if (node is FieldDeclaration)
		{
			FieldDeclaration fieldDeclaration = (FieldDeclaration)node;
			if (fieldDeclaration.getVariables().size() != 1)
			{
				
				throw new RuntimeException("Cannot resolve a Field Declaration including multiple variable declarators. Resolve the single variable declarators");
			}
			JavaParserFieldDeclaration obj5 = new JavaParserFieldDeclaration(fieldDeclaration.getVariable(0), typeSolver);
			if (resultClass.isInstance(obj5))
			{
				object result8 = resultClass.cast(obj5);
				
				return result8;
			}
		}
		if (node is VariableDeclarator)
		{
			object obj6;
			if (node.getParentNode().isPresent() && node.getParentNode().get() is FieldDeclaration)
			{
				obj6 = new JavaParserFieldDeclaration((VariableDeclarator)node, typeSolver);
			}
			else
			{
				if (!node.getParentNode().isPresent() || !(node.getParentNode().get() is VariableDeclarationExpr))
				{
					string message = new StringBuilder().append("Parent of VariableDeclarator is: ").append(node.getParentNode()).ToString();
					
					throw new UnsupportedOperationException(message);
				}
				obj6 = new JavaParserVariableDeclaration((VariableDeclarator)node, typeSolver);
			}
			if (resultClass.isInstance(obj6))
			{
				object result9 = resultClass.cast(obj6);
				
				return result9;
			}
		}
		if (node is MethodCallExpr)
		{
			SymbolReference symbolReference = JavaParserFacade.get(typeSolver).solve((MethodCallExpr)node);
			if (!symbolReference.isSolved())
			{
				string name = new StringBuilder().append("We are unable to find the method declaration corresponding to ").append(node).ToString();
				
				throw new UnsolvedSymbolException(name);
			}
			if (resultClass.isInstance(symbolReference.getCorrespondingDeclaration()))
			{
				object result10 = resultClass.cast(symbolReference.getCorrespondingDeclaration());
				
				return result10;
			}
		}
		if (node is ObjectCreationExpr)
		{
			SymbolReference symbolReference = JavaParserFacade.get(typeSolver).solve((ObjectCreationExpr)node);
			if (!symbolReference.isSolved())
			{
				string name2 = new StringBuilder().append("We are unable to find the constructor declaration corresponding to ").append(node).ToString();
				
				throw new UnsolvedSymbolException(name2);
			}
			if (resultClass.isInstance(symbolReference.getCorrespondingDeclaration()))
			{
				object result11 = resultClass.cast(symbolReference.getCorrespondingDeclaration());
				
				return result11;
			}
		}
		if (node is NameExpr)
		{
			SymbolReference symbolReference = JavaParserFacade.get(typeSolver).solve((NameExpr)node);
			if (!symbolReference.isSolved())
			{
				string name3 = new StringBuilder().append("We are unable to find the value declaration corresponding to ").append(node).ToString();
				
				throw new UnsolvedSymbolException(name3);
			}
			if (resultClass.isInstance(symbolReference.getCorrespondingDeclaration()))
			{
				object result12 = resultClass.cast(symbolReference.getCorrespondingDeclaration());
				
				return result12;
			}
		}
		if (node is MethodReferenceExpr)
		{
			SymbolReference symbolReference = JavaParserFacade.get(typeSolver).solve((MethodReferenceExpr)node);
			if (!symbolReference.isSolved())
			{
				string name4 = new StringBuilder().append("We are unable to find the method declaration corresponding to ").append(node).ToString();
				
				throw new UnsolvedSymbolException(name4);
			}
			if (resultClass.isInstance(symbolReference.getCorrespondingDeclaration()))
			{
				object result13 = resultClass.cast(symbolReference.getCorrespondingDeclaration());
				
				return result13;
			}
		}
		if (node is FieldAccessExpr)
		{
			SymbolReference symbolReference = JavaParserFacade.get(typeSolver).solve((FieldAccessExpr)node);
			if (!symbolReference.isSolved())
			{
				if (String.instancehelper_equals(((FieldAccessExpr)node).getName().getId(), "length"))
				{
					ResolvedType resolvedType = ((FieldAccessExpr)node).getScope().calculateResolvedType();
					if (resolvedType.isArray() && resultClass.isInstance(ArrayLengthValueDeclaration.access_0024000()))
					{
						object result14 = resultClass.cast(ArrayLengthValueDeclaration.access_0024000());
						
						return result14;
					}
				}
				string name5 = new StringBuilder().append("We are unable to find the value declaration corresponding to ").append(node).ToString();
				
				throw new UnsolvedSymbolException(name5);
			}
			if (resultClass.isInstance(symbolReference.getCorrespondingDeclaration()))
			{
				object result15 = resultClass.cast(symbolReference.getCorrespondingDeclaration());
				
				return result15;
			}
		}
		if (node is ThisExpr)
		{
			SymbolReference symbolReference = JavaParserFacade.get(typeSolver).solve((ThisExpr)node);
			if (!symbolReference.isSolved())
			{
				string name6 = new StringBuilder().append("We are unable to find the type declaration corresponding to ").append(node).ToString();
				
				throw new UnsolvedSymbolException(name6);
			}
			if (resultClass.isInstance(symbolReference.getCorrespondingDeclaration()))
			{
				object result16 = resultClass.cast(symbolReference.getCorrespondingDeclaration());
				
				return result16;
			}
		}
		if (node is ExplicitConstructorInvocationStmt)
		{
			SymbolReference symbolReference = JavaParserFacade.get(typeSolver).solve((ExplicitConstructorInvocationStmt)node);
			if (!symbolReference.isSolved())
			{
				string name7 = new StringBuilder().append("We are unable to find the constructor declaration corresponding to ").append(node).ToString();
				
				throw new UnsolvedSymbolException(name7);
			}
			if (resultClass.isInstance(symbolReference.getCorrespondingDeclaration()))
			{
				object result17 = resultClass.cast(symbolReference.getCorrespondingDeclaration());
				
				return result17;
			}
		}
		if (node is Parameter && Object.instancehelper_equals(ClassLiteral<ResolvedParameterDeclaration>.Value, resultClass))
		{
			Parameter parameter = (Parameter)node;
			CallableDeclaration callableDeclaration = (CallableDeclaration)node.findAncestor(new Class[1] { ClassLiteral<CallableDeclaration>.Value }).get();
			object obj7 = ((!callableDeclaration.isConstructorDeclaration()) ? ((object)callableDeclaration.asMethodDeclaration().resolve()) : ((object)callableDeclaration.asConstructorDeclaration().resolve()));
			for (int i = 0; i < ((obj7 == null) ? null : ((obj7 as ResolvedMethodLikeDeclaration) ?? throw new java.lang.IncompatibleClassChangeError())).getNumberOfParams(); i++)
			{
				int i2 = i;
				if (String.instancehelper_equals(((obj7 == null) ? null : ((obj7 as ResolvedMethodLikeDeclaration) ?? throw new java.lang.IncompatibleClassChangeError())).getParam(i2).getName(), parameter.getNameAsString()))
				{
					i2 = i;
					object result18 = resultClass.cast(((obj7 == null) ? null : ((obj7 as ResolvedMethodLikeDeclaration) ?? throw new java.lang.IncompatibleClassChangeError())).getParam(i2));
					
					return result18;
				}
			}
		}
		if (node is AnnotationExpr)
		{
			SymbolReference symbolReference = JavaParserFacade.get(typeSolver).solve((AnnotationExpr)node);
			if (!symbolReference.isSolved())
			{
				string name8 = new StringBuilder().append("We are unable to find the annotation declaration corresponding to ").append(node).ToString();
				
				throw new UnsolvedSymbolException(name8);
			}
			if (resultClass.isInstance(symbolReference.getCorrespondingDeclaration()))
			{
				object result19 = resultClass.cast(symbolReference.getCorrespondingDeclaration());
				
				return result19;
			}
		}
		if (node is PatternExpr)
		{
			SymbolReference symbolReference = JavaParserFacade.get(typeSolver).solve((PatternExpr)node);
			if (!symbolReference.isSolved())
			{
				string name9 = new StringBuilder().append("We are unable to find the method declaration corresponding to ").append(node).ToString();
				
				throw new UnsolvedSymbolException(name9);
			}
			if (resultClass.isInstance(symbolReference.getCorrespondingDeclaration()))
			{
				object result20 = resultClass.cast(symbolReference.getCorrespondingDeclaration());
				
				return result20;
			}
		}
		string message2 = new StringBuilder().append("Unable to find the declaration of type ").append(resultClass.getSimpleName()).append(" from ")
			.append(Object.instancehelper_getClass(node).getSimpleName())
			.ToString();
		
		throw new UnsupportedOperationException(message2);
	}

	
	
	
	private static bool lambda_0024resolveDeclaration_00240(Node P_0, ResolvedEnumConstantDeclaration P_1)
	{
		return ((JavaParserEnumConstantDeclaration)P_1).getWrappedNode() == P_0;
	}

	
	
	private static bool lambda_0024resolveDeclaration_00241(ResolvedConstructorDeclaration P_0)
	{
		return P_0 is JavaParserConstructorDeclaration;
	}

	
	
	
	private static bool lambda_0024resolveDeclaration_00242(ConstructorDeclaration P_0, ResolvedConstructorDeclaration P_1)
	{
		return ((JavaParserConstructorDeclaration)P_1).getWrappedNode() == P_0;
	}

	
	
	
	private static RuntimeException lambda_0024resolveDeclaration_00243()
	{
		RuntimeException result = new RuntimeException("This constructor cannot be found in its parent. This seems wrong");
		
		return result;
	}

	
	
	
	private static bool lambda_0024resolveDeclaration_00244(Node P_0, ResolvedAnnotationMemberDeclaration P_1)
	{
		return ((JavaParserAnnotationMemberDeclaration)P_1).getWrappedNode() == P_0;
	}

	
	
	public JavaSymbolSolver(TypeSolver typeSolver)
	{
		this.typeSolver = typeSolver;
	}

	
	
	public virtual void inject(CompilationUnit destination)
	{
		destination.setData(Node.___003C_003ESYMBOL_RESOLVER_KEY, this);
	}

	
		
	public virtual object toResolvedType(Type javaparserType, Class resultClass)
	{
		ResolvedType obj = JavaParserFacade.get(typeSolver).convertToUsage(javaparserType, javaparserType);
		if (resultClass.isInstance(obj))
		{
			object result = resultClass.cast(obj);
			
			return result;
		}
		string message = new StringBuilder().append("Unable to get the resolved type of class ").append(resultClass.getSimpleName()).append(" from ")
			.append(javaparserType)
			.ToString();
		
		throw new UnsupportedOperationException(message);
	}

	
	
	public virtual ResolvedType calculateType(Expression expression)
	{
		ResolvedType type = JavaParserFacade.get(typeSolver).getType(expression);
		
		return type;
	}
}
