using System;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.type;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.core.resolution;
using com.github.javaparser.symbolsolver.javaparser;
using com.github.javaparser.symbolsolver.javaparsermodel.contexts;
using com.github.javaparser.symbolsolver.javaparsermodel.declarations;
using com.github.javaparser.symbolsolver.logic;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.model.typesystem;
using com.github.javaparser.symbolsolver.reflectionmodel;
using com.github.javaparser.symbolsolver.resolution;
using com.github.javaparser.utils;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.symbolsolver.javaparsermodel;

public class JavaParserFacade
{
	
		
	internal sealed class _1 : DataKey
	{
		
		
		internal _1()
		{
		}
	}

	
		
	internal sealed class _2 : DataKey
	{
		
		
		internal _2()
		{
		}
	}

	
	private sealed class ___003C_003EAnon0 : Function
	{
		internal ___003C_003EAnon0()
		{
		}

		public object apply(object P_0)
		{
			JavaParserFacade result = new JavaParserFacade((TypeSolver)P_0);
			
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
		private readonly JavaParserFacade arg_00241;

		internal ___003C_003EAnon1(JavaParserFacade P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			SymbolReference result = arg_00241.solve((NameExpr)P_0);
			
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
		private readonly Expression arg_00241;

		internal ___003C_003EAnon2(Expression P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			IllegalArgumentException result = lambda_0024solve_00240(arg_00241);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon3 : Supplier
	{
		private readonly Node arg_00241;

		internal ___003C_003EAnon3(Node P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			object result = lambda_0024getType_00241(arg_00241);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon4 : Supplier
	{
		private readonly ResolvedType arg_00241;

		internal ___003C_003EAnon4(ResolvedType P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			object result = lambda_0024getType_00242(arg_00241);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon5 : Supplier
	{
		private readonly Node arg_00241;

		internal ___003C_003EAnon5(Node P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			object result = lambda_0024getType_00243(arg_00241);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon6 : Supplier
	{
		private readonly Optional arg_00241;

		internal ___003C_003EAnon6(Optional P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			object result = lambda_0024getType_00244(arg_00241);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon7 : Supplier
	{
		internal ___003C_003EAnon7()
		{
		}

		public object get()
		{
			RuntimeException result = lambda_0024toMethodUsage_00245();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon8 : Predicate
	{
		internal ___003C_003EAnon8()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024toMethodUsage_00246((MethodUsage)P_0);
			
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

	
	private sealed class ___003C_003EAnon9 : Predicate
	{
		internal ___003C_003EAnon9()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024toMethodUsage_00247((MethodUsage)P_0);
			
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

	
	private sealed class ___003C_003EAnon10 : Function
	{
		private readonly JavaParserFacade arg_00241;

		private readonly Context arg_00242;

		internal ___003C_003EAnon10(JavaParserFacade P_0, Context P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			ResolvedType result = arg_00241.lambda_0024convertClassOrInterfaceTypeToUsage_00248(arg_00242, (com.github.javaparser.ast.type.Type)P_0);
			
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

	
	private sealed class ___003C_003EAnon11 : Function
	{
		private readonly JavaParserFacade arg_00241;

		private readonly Context arg_00242;

		internal ___003C_003EAnon11(JavaParserFacade P_0, Context P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			ResolvedType result = arg_00241.lambda_0024convertUnionTypeToUsage_00249(arg_00242, (ReferenceType)P_0);
			
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

	
	private sealed class ___003C_003EAnon12 : Function
	{
		internal ___003C_003EAnon12()
		{
		}

		public object apply(object P_0)
		{
			ResolvedType result = ((Expression)P_0).calculateResolvedType();
			
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

	
	private sealed class ___003C_003EAnon13 : Supplier
	{
		internal ___003C_003EAnon13()
		{
		}

		public object get()
		{
			IllegalStateException result = lambda_0024convertVarTypeToUsage_002410();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon14 : Function
	{
		internal ___003C_003EAnon14()
		{
		}

		public object apply(object P_0)
		{
			string result = lambda_0024solveMethodAsUsage_002411((Range)P_0);
			
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

	
		private static DataKey TYPE_WITH_LAMBDAS_RESOLVED;

	
		private static DataKey TYPE_WITHOUT_LAMBDAS_RESOLVED;

	
		private static Map instances;

	
	private static string JAVA_LANG_STRING;

	
	private TypeSolver typeSolver;

	
	private TypeExtractor typeExtractor;

	
	private SymbolSolver symbolSolver;

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
	
	
	public static JavaParserFacade get(TypeSolver typeSolver)
	{
		lock (ClassLiteral<JavaParserFacade>.Value)
		{
			return (JavaParserFacade)instances.computeIfAbsent(typeSolver, new ___003C_003EAnon0());
		}
	}

	
	[LineNumberTable(new byte[]
	{
		161, 6, 126, 97, 104, 103, 109, 108, 119, 110,
		174
	})]
	public virtual ResolvedType getType(Node node)
	{
		//Discarded unreachable code: IL_000a
		UnsolvedSymbolException ex;
		try
		{
			return getType(node, solveLambdas: true);
		}
		catch (UnsolvedSymbolException x)
		{
			ex = ByteCodeHelper.MapException<UnsolvedSymbolException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		UnsolvedSymbolException ex2 = ex;
		if (node is NameExpr)
		{
			NameExpr nameExpr = (NameExpr)node;
			SymbolReference symbolReference = JavaParserFactory.getContext(node, typeSolver).solveType(nameExpr.getNameAsString());
			if (symbolReference.isSolved() && symbolReference.getCorrespondingDeclaration() is ResolvedReferenceTypeDeclaration)
			{
				ResolvedReferenceTypeDeclaration typeDeclaration = (ResolvedReferenceTypeDeclaration)symbolReference.getCorrespondingDeclaration();
				return ReferenceTypeImpl.undeterminedParameters(typeDeclaration, typeSolver);
			}
		}
		throw ex2;
	}

	
	[LineNumberTable(new byte[]
	{
		162, 216, 104, 159, 0, 104, 119, 148, 122, 114,
		148
	})]
	public virtual ResolvedType getTypeOfThisIn(Node node)
	{
		if (node is ClassOrInterfaceDeclaration)
		{
			ReferenceTypeImpl.___003Cclinit_003E();
			ReferenceTypeImpl result = new ReferenceTypeImpl(getTypeDeclaration((ClassOrInterfaceDeclaration)node), typeSolver);
			
			return result;
		}
		if (node is EnumDeclaration)
		{
			JavaParserEnumDeclaration.___003Cclinit_003E();
			JavaParserEnumDeclaration typeDeclaration = new JavaParserEnumDeclaration((EnumDeclaration)node, typeSolver);
			ReferenceTypeImpl.___003Cclinit_003E();
			ReferenceTypeImpl result2 = new ReferenceTypeImpl(typeDeclaration, typeSolver);
			
			return result2;
		}
		if (node is ObjectCreationExpr && ((ObjectCreationExpr)node).getAnonymousClassBody().isPresent())
		{
			JavaParserAnonymousClassDeclaration typeDeclaration2 = new JavaParserAnonymousClassDeclaration((ObjectCreationExpr)node, typeSolver);
			ReferenceTypeImpl.___003Cclinit_003E();
			ReferenceTypeImpl result3 = new ReferenceTypeImpl(typeDeclaration2, typeSolver);
			
			return result3;
		}
		ResolvedType typeOfThisIn = getTypeOfThisIn(Navigator.demandParentNode(node));
		
		return typeOfThisIn;
	}

	
		
	public virtual ResolvedReferenceTypeDeclaration getTypeDeclaration(TypeDeclaration typeDeclaration)
	{
		ResolvedReferenceTypeDeclaration result = JavaParserFactory.toTypeDeclaration(typeDeclaration, typeSolver);
		
		return result;
	}

	
	
	public virtual ResolvedReferenceTypeDeclaration getTypeDeclaration(ClassOrInterfaceDeclaration classOrInterfaceDeclaration)
	{
		ResolvedReferenceTypeDeclaration result = JavaParserFactory.toTypeDeclaration(classOrInterfaceDeclaration, typeSolver);
		
		return result;
	}

	
	[LineNumberTable(new byte[]
	{
		162, 176, 102, 107, 191, 4, 191, 7, 2, 98,
		191, 6, 133, 110, 117, 108, 127, 22, 159, 58
	})]
	public virtual MethodUsage solveMethodAsUsage(MethodCallExpr call)
	{
		ArrayList arrayList = new ArrayList();
		if (call.getArguments() != null)
		{
			Iterator iterator = call.getArguments().iterator();
			while (iterator.hasNext())
			{
				Expression expression = (Expression)iterator.next();
				java.lang.Exception ex2;
				try
				{
					((List)arrayList).add((object)getType(expression, solveLambdas: false));
				}
				catch (System.Exception x)
				{
					java.lang.Exception ex = ByteCodeHelper.MapException<java.lang.Exception>(x, ByteCodeHelper.MapFlags.None);
					if (ex == null)
					{
						throw;
					}
					ex2 = ex;
					goto IL_0057;
				}
				continue;
				IL_0057:
				java.lang.Exception cause = ex2;
				string message = java.lang.String.format("Error calculating the type of parameter %s of method call %s", expression, call);
				
				throw new RuntimeException(message, cause);
			}
		}
		Context context = JavaParserFactory.getContext(call, typeSolver);
		Optional optional = context.solveMethodAsUsage(call.getName().getId(), arrayList);
		if (!optional.isPresent())
		{
			string message2 = new StringBuilder().append("Method '").append(call.getName()).append("' cannot be resolved in context ")
				.append(call)
				.append(" (line: ")
				.append((string)call.getRange().map(new ___003C_003EAnon14()).orElse("??"))
				.append(") ")
				.append(context)
				.append(". Parameter types: ")
				.append(arrayList)
				.ToString();
			
			throw new RuntimeException(message2);
		}
		return (MethodUsage)optional.get();
	}

	
	
	public virtual ResolvedType convertToUsageVariableType(VariableDeclarator var)
	{
		ResolvedType result = get(typeSolver).convertToUsage(var.getType(), var);
		
		return result;
	}

	
	
	public virtual ResolvedType convertToUsage(com.github.javaparser.ast.type.Type type)
	{
		ResolvedType result = convertToUsage(type, type);
		
		return result;
	}

	
		[LineNumberTable(new byte[]
	{
		162, 242, 104, 206, 104, 111, 104, 111, 104, 143,
		141
	})]
	public virtual ResolvedType classToResolvedType(Class clazz)
	{
		if (clazz.isPrimitive())
		{
			ResolvedType result = ResolvedPrimitiveType.byName(clazz.getName());
			
			return result;
		}
		AbstractTypeDeclaration typeDeclaration = (clazz.isAnnotation() ? new ReflectionAnnotationDeclaration(clazz, typeSolver) : (clazz.isEnum() ? new ReflectionEnumDeclaration(clazz, typeSolver) : ((!clazz.isInterface()) ? ((AbstractTypeDeclaration)new ReflectionClassDeclaration(clazz, typeSolver)) : ((AbstractTypeDeclaration)new ReflectionInterfaceDeclaration(clazz, typeSolver)))));
		ReferenceTypeImpl.___003Cclinit_003E();
		ReferenceTypeImpl result2 = new ReferenceTypeImpl(typeDeclaration, typeSolver);
		
		return result2;
	}

	
	
	public virtual ResolvedType convert(com.github.javaparser.ast.type.Type type, Context context)
	{
		ResolvedType result = convertToUsage(type, context);
		
		return result;
	}

	
	
	public virtual ResolvedType convert(com.github.javaparser.ast.type.Type type, Node node)
	{
		ResolvedType result = convert(type, JavaParserFactory.getContext(node, typeSolver));
		
		return result;
	}

	
	
	public virtual ResolvedType convertToUsage(com.github.javaparser.ast.type.Type type, Node context)
	{
		ResolvedType result = convertToUsage(type, JavaParserFactory.getContext(context, typeSolver));
		
		return result;
	}

	
	
	protected internal static ResolvedType solveGenericTypes(ResolvedType type, Context context)
	{
		if (type.isTypeVariable())
		{
			return (ResolvedType)context.solveGenericType(type.describe()).orElse(type);
		}
		if (type.isWildcard() && (type.asWildcard().isExtends() || type.asWildcard().isSuper()))
		{
			ResolvedWildcard resolvedWildcard = type.asWildcard();
			ResolvedType type2 = solveGenericTypes(resolvedWildcard.getBoundedType(), context);
			if (resolvedWildcard.isExtends())
			{
				ResolvedWildcard result = ResolvedWildcard.extendsBound(type2);
				
				return result;
			}
			ResolvedWildcard result2 = ResolvedWildcard.superBound(type2);
			
			return result2;
		}
		return type;
	}

	
		[LineNumberTable(new byte[]
	{
		159, 64, 66, 102, 134, 144, 127, 0, 127, 0,
		104, 98
	})]
	public virtual SymbolReference solve(MethodCallExpr methodCallExpr, bool solveLambdas)
	{
		LinkedList linkedList = new LinkedList();
		LinkedList linkedList2 = new LinkedList();
		solveArguments(methodCallExpr, methodCallExpr.getArguments(), solveLambdas, linkedList, linkedList2);
		SymbolReference symbolReference = JavaParserFactory.getContext(methodCallExpr, typeSolver).solveMethod(methodCallExpr.getName().getId(), linkedList, staticOnly: false);
		Iterator iterator = ((List)linkedList2).iterator();
		while (iterator.hasNext())
		{
			LambdaArgumentTypePlaceholder lambdaArgumentTypePlaceholder = (LambdaArgumentTypePlaceholder)iterator.next();
			lambdaArgumentTypePlaceholder.setMethod(symbolReference);
		}
		return symbolReference;
	}

	
		
	public virtual SymbolReference solve(MethodReferenceExpr methodReferenceExpr, bool solveLambdas)
	{
		LinkedList argumentsTypes = new LinkedList();
		SymbolReference result = JavaParserFactory.getContext(methodReferenceExpr, typeSolver).solveMethod(methodReferenceExpr.getIdentifier(), argumentsTypes, staticOnly: false);
		
		return result;
	}

	
		[LineNumberTable(new byte[]
	{
		159, 77, 130, 102, 134, 144, 98, 109, 143, 121,
		124, 183, 99, 141, 127, 8, 127, 0, 105, 98
	})]
	public virtual SymbolReference solve(ObjectCreationExpr objectCreationExpr, bool solveLambdas)
	{
		LinkedList linkedList = new LinkedList();
		LinkedList linkedList2 = new LinkedList();
		solveArguments(objectCreationExpr, objectCreationExpr.getArguments(), solveLambdas, linkedList, linkedList2);
		object obj = null;
		if (objectCreationExpr.getAnonymousClassBody().isPresent())
		{
			obj = new JavaParserAnonymousClassDeclaration(objectCreationExpr, typeSolver);
		}
		else
		{
			ResolvedType resolvedType = get(typeSolver).convert(objectCreationExpr.getType(), objectCreationExpr);
			if (resolvedType.isReferenceType() && resolvedType.asReferenceType().getTypeDeclaration().isPresent())
			{
				obj = (ResolvedReferenceTypeDeclaration)resolvedType.asReferenceType().getTypeDeclaration().get();
			}
		}
		if (obj == null)
		{
			SymbolReference result = SymbolReference.unsolved(ClassLiteral<ResolvedConstructorDeclaration>.Value);
			
			return result;
		}
		object obj2 = obj;
		SymbolReference symbolReference = ConstructorResolutionLogic.findMostApplicable(((obj2 == null) ? null : ((obj2 as ResolvedReferenceTypeDeclaration) ?? throw new java.lang.IncompatibleClassChangeError())).getConstructors(), linkedList, typeSolver);
		Iterator iterator = ((List)linkedList2).iterator();
		while (iterator.hasNext())
		{
			LambdaArgumentTypePlaceholder lambdaArgumentTypePlaceholder = (LambdaArgumentTypePlaceholder)iterator.next();
			lambdaArgumentTypePlaceholder.setMethod(symbolReference);
		}
		return symbolReference;
	}

	
		[LineNumberTable(new byte[]
	{
		159, 93, 66, 117, 104, 173, 108, 103, 104, 176,
		99, 136, 170, 109, 127, 2, 189, 100, 205, 103,
		103, 178, 123, 127, 1, 105, 130
	})]
	public virtual SymbolReference solve(ExplicitConstructorInvocationStmt explicitConstructorInvocationStmt, bool solveLambdas)
	{
		Optional optional = explicitConstructorInvocationStmt.findAncestor(new Class[1] { ClassLiteral<ClassOrInterfaceDeclaration>.Value });
		if (!optional.isPresent())
		{
			SymbolReference result = SymbolReference.unsolved(ClassLiteral<ResolvedConstructorDeclaration>.Value);
			
			return result;
		}
		ClassOrInterfaceDeclaration classOrInterfaceDeclaration = (ClassOrInterfaceDeclaration)optional.get();
		ResolvedReferenceTypeDeclaration resolvedReferenceTypeDeclaration = classOrInterfaceDeclaration.resolve();
		if (!resolvedReferenceTypeDeclaration.isClass())
		{
			
			throw new IllegalStateException("Expected to be a class -- cannot call this() or super() within an interface.");
		}
		object obj = null;
		if (explicitConstructorInvocationStmt.isThis())
		{
			obj = resolvedReferenceTypeDeclaration.asReferenceType();
		}
		else
		{
			Optional superClass = resolvedReferenceTypeDeclaration.asClass().getSuperClass();
			if (superClass.isPresent() && ((ResolvedReferenceType)superClass.get()).getTypeDeclaration().isPresent())
			{
				obj = (ResolvedTypeDeclaration)((ResolvedReferenceType)superClass.get()).getTypeDeclaration().get();
			}
		}
		if (obj == null)
		{
			SymbolReference result2 = SymbolReference.unsolved(ClassLiteral<ResolvedConstructorDeclaration>.Value);
			
			return result2;
		}
		LinkedList linkedList = new LinkedList();
		LinkedList linkedList2 = new LinkedList();
		solveArguments(explicitConstructorInvocationStmt, explicitConstructorInvocationStmt.getArguments(), solveLambdas, linkedList, linkedList2);
		SymbolReference symbolReference = ConstructorResolutionLogic.findMostApplicable(((ResolvedClassDeclaration)obj).getConstructors(), linkedList, typeSolver);
		Iterator iterator = ((List)linkedList2).iterator();
		while (iterator.hasNext())
		{
			LambdaArgumentTypePlaceholder lambdaArgumentTypePlaceholder = (LambdaArgumentTypePlaceholder)iterator.next();
			lambdaArgumentTypePlaceholder.setMethod(symbolReference);
		}
		return symbolReference;
	}

	
		[LineNumberTable(new byte[]
	{
		159,
		70,
		66,
		98,
		126,
		112,
		104,
		106,
		106,
		133,
		byte.MaxValue,
		34,
		70,
		226,
		59,
		98,
		104,
		98,
		223,
		6,
		100,
		101
	})]
	private void solveArguments(Node P_0, NodeList P_1, bool P_2, List P_3, List P_4)
	{
		int num = 0;
		Iterator iterator = P_1.iterator();
		while (iterator.hasNext())
		{
			Expression expression = (Expression)iterator.next();
			UnsolvedSymbolException ex;
			java.lang.Exception ex3;
			if (expression.isLambdaExpr() || expression.isMethodReferenceExpr())
			{
				LambdaArgumentTypePlaceholder e = new LambdaArgumentTypePlaceholder(num);
				P_3.add(e);
				P_4.add(e);
			}
			else
			{
				try
				{
					try
					{
						P_3.add(get(typeSolver).getType(expression, P_2));
					}
					catch (UnsolvedSymbolException x)
					{
						ex = ByteCodeHelper.MapException<UnsolvedSymbolException>(x, ByteCodeHelper.MapFlags.NoRemapping);
						goto IL_008c;
					}
				}
				catch (System.Exception x2)
				{
					java.lang.Exception ex2 = ByteCodeHelper.MapException<java.lang.Exception>(x2, ByteCodeHelper.MapFlags.None);
					if (ex2 == null)
					{
						throw;
					}
					ex3 = ex2;
					goto IL_0090;
				}
			}
			num++;
			continue;
			IL_0090:
			java.lang.Exception cause = ex3;
			string message = java.lang.String.format("Unable to calculate the type of a parameter of a method call. Method call: %s, Parameter: %s", P_0, expression);
			
			throw new RuntimeException(message, cause);
			IL_008c:
			UnsolvedSymbolException ex4 = ex;
			throw Throwable.___003Cunmap_003E(ex4);
		}
	}

	
	[LineNumberTable(new byte[]
	{
		161, 230, 98, 130, 103, 104, 104, 130, 132, 104,
		99
	})]
	protected internal virtual Node findContainingTypeDeclOrObjectCreationExpr(Node node)
	{
		Node node2 = node;
		int num = 0;
		while (true)
		{
			node2 = Navigator.demandParentNode(node2);
			if (node2 is BodyDeclaration)
			{
				if (node2 is TypeDeclaration)
				{
					return node2;
				}
				num = 1;
			}
			else if (node2 is ObjectCreationExpr && num != 0)
			{
				break;
			}
		}
		return node2;
	}

	
	
	public virtual ResolvedReferenceTypeDeclaration getTypeDeclaration(Node node)
	{
		if (node is TypeDeclaration)
		{
			ResolvedReferenceTypeDeclaration typeDeclaration = getTypeDeclaration((TypeDeclaration)node);
			
			return typeDeclaration;
		}
		if (node is ObjectCreationExpr)
		{
			JavaParserAnonymousClassDeclaration result = new JavaParserAnonymousClassDeclaration((ObjectCreationExpr)node, typeSolver);
			
			return result;
		}
		
		throw new IllegalArgumentException();
	}

	
	[LineNumberTable(new byte[]
	{
		159, 44, 66, 102, 112, 137, 140, 98, 104, 103,
		127, 5, 110, 106, 130, 130, 99, 107, 106, 173,
		159, 13, 145, 110, 105, 141, 110, 105, 106, 109,
		100, 127, 14, 131
	})]
	public virtual ResolvedType getType(Node node, bool solveLambdas)
	{
		if (solveLambdas)
		{
			if (!node.containsData(TYPE_WITH_LAMBDAS_RESOLVED))
			{
				ResolvedType typeConcrete = getTypeConcrete(node, solveLambdas);
				node.setData(TYPE_WITH_LAMBDAS_RESOLVED, typeConcrete);
				int num = 0;
				if (node is MethodCallExpr)
				{
					MethodCallExpr methodCallExpr = (MethodCallExpr)node;
					Iterator iterator = methodCallExpr.getArguments().iterator();
					while (iterator.hasNext())
					{
						Node node2 = (Node)iterator.next();
						if (!node2.containsData(TYPE_WITH_LAMBDAS_RESOLVED))
						{
							getType(node2, solveLambdas: true);
							num = 1;
						}
					}
				}
				if (num != 0)
				{
					node.removeData(TYPE_WITH_LAMBDAS_RESOLVED);
					ResolvedType type = getType(node, solveLambdas: true);
					node.setData(TYPE_WITH_LAMBDAS_RESOLVED, type);
				}
				Log.trace("getType on %s  -> %s", new ___003C_003EAnon3(node), new ___003C_003EAnon4(typeConcrete));
			}
			return (ResolvedType)node.getData(TYPE_WITH_LAMBDAS_RESOLVED);
		}
		Optional optional = find(TYPE_WITH_LAMBDAS_RESOLVED, node);
		if (optional.isPresent())
		{
			return (ResolvedType)optional.get();
		}
		optional = find(TYPE_WITHOUT_LAMBDAS_RESOLVED, node);
		if (!optional.isPresent())
		{
			ResolvedType typeConcrete2 = getTypeConcrete(node, solveLambdas);
			node.setData(TYPE_WITHOUT_LAMBDAS_RESOLVED, typeConcrete2);
			Optional optional2 = optional;
			Log.trace("getType on %s (no solveLambdas) -> %s", new ___003C_003EAnon5(node), new ___003C_003EAnon6(optional2));
			return typeConcrete2;
		}
		return (ResolvedType)optional.get();
	}

	
	
	private ResolvedType getTypeConcrete(Node P_0, bool P_1)
	{
		if (P_0 == null)
		{
			
			throw new IllegalArgumentException();
		}
		return (ResolvedType)P_0.accept(typeExtractor, java.lang.Boolean.valueOf(P_1));
	}

	
		
	private Optional find(DataKey P_0, Node P_1)
	{
		if (P_1.containsData(P_0))
		{
			Optional result = Optional.of(P_1.getData(P_0));
			
			return result;
		}
		Optional result2 = Optional.empty();
		
		return result2;
	}

	
	[LineNumberTable(new byte[]
	{
		162, 84, 103, 104, 104, 140, 108, 102, 109, 159,
		23, 104, 142
	})]
	protected internal virtual ResolvedType convertClassOrInterfaceTypeToUsage(ClassOrInterfaceType classOrInterfaceType, Context context)
	{
		string nameWithScope = classOrInterfaceType.getNameWithScope();
		SymbolReference symbolReference = context.solveType(nameWithScope);
		if (!symbolReference.isSolved())
		{
			
			throw new UnsolvedSymbolException(nameWithScope);
		}
		ResolvedTypeDeclaration resolvedTypeDeclaration = (ResolvedTypeDeclaration)symbolReference.getCorrespondingDeclaration();
		List typeArguments = Collections.emptyList();
		if (classOrInterfaceType.getTypeArguments().isPresent())
		{
			typeArguments = (List)((NodeList)classOrInterfaceType.getTypeArguments().get()).stream().map(new ___003C_003EAnon10(this, context)).collect(Collectors.toList());
		}
		if (resolvedTypeDeclaration.isTypeParameter())
		{
			ResolvedTypeVariable result = new ResolvedTypeVariable(resolvedTypeDeclaration.asTypeParameter());
			
			return result;
		}
		ReferenceTypeImpl.___003Cclinit_003E();
		ReferenceTypeImpl result2 = new ReferenceTypeImpl((ResolvedReferenceTypeDeclaration)resolvedTypeDeclaration, typeArguments, typeSolver);
		
		return result2;
	}

	
	
	protected internal virtual ResolvedType convertWildcardTypeToUsage(WildcardType wildcardType, Context context)
	{
		if (wildcardType.getExtendedType().isPresent() && !wildcardType.getSuperType().isPresent())
		{
			ResolvedWildcard result = ResolvedWildcard.extendsBound(convertToUsage((com.github.javaparser.ast.type.Type)wildcardType.getExtendedType().get(), context));
			
			return result;
		}
		if (!wildcardType.getExtendedType().isPresent() && wildcardType.getSuperType().isPresent())
		{
			ResolvedWildcard result2 = ResolvedWildcard.superBound(convertToUsage((com.github.javaparser.ast.type.Type)wildcardType.getSuperType().get(), context));
			
			return result2;
		}
		if (!wildcardType.getExtendedType().isPresent() && !wildcardType.getSuperType().isPresent())
		{
			return ResolvedWildcard.UNBOUNDED;
		}
		string message = wildcardType.ToString();
		
		throw new UnsupportedOperationException(message);
	}

	
	
	protected internal virtual ResolvedType convertArrayTypeToUsage(ArrayType arrayType, Context context)
	{
		ResolvedArrayType result = new ResolvedArrayType(convertToUsage(arrayType.getComponentType(), context));
		
		return result;
	}

	
	
	protected internal virtual ResolvedType convertUnionTypeToUsage(UnionType unionType, Context context)
	{
		List elements = (List)unionType.getElements().stream().map(new ___003C_003EAnon11(this, context))
			.collect(Collectors.toList());
		ResolvedUnionType result = new ResolvedUnionType(elements);
		
		return result;
	}

	
	
	protected internal virtual ResolvedType convertVarTypeToUsage(VarType varType, Context context)
	{
		Node node = (Node)varType.getParentNode().get();
		if (!(node is VariableDeclarator))
		{
			
			throw new IllegalStateException("Trying to resolve a `var` which is not in a variable declaration.");
		}
		VariableDeclarator variableDeclarator = (VariableDeclarator)node;
		return (ResolvedType)variableDeclarator.getInitializer().map(new ___003C_003EAnon12()).orElseThrow(new ___003C_003EAnon13());
	}

	
	[LineNumberTable(new byte[]
	{
		162, 28, 99, 144, 104, 112, 104, 112, 104, 120,
		104, 112, 104, 102, 104, 112, 104, 112, 104, 144
	})]
	protected internal virtual ResolvedType convertToUsage(com.github.javaparser.ast.type.Type type, Context context)
	{
		if (context == null)
		{
			
			throw new NullPointerException("Context should not be null");
		}
		if (type.isUnknownType())
		{
			
			throw new IllegalArgumentException("Inferred lambda parameter type");
		}
		if (type.isClassOrInterfaceType())
		{
			ResolvedType result = convertClassOrInterfaceTypeToUsage(type.asClassOrInterfaceType(), context);
			
			return result;
		}
		if (type.isPrimitiveType())
		{
			ResolvedType result2 = ResolvedPrimitiveType.byName(type.asPrimitiveType().getType().name());
			
			return result2;
		}
		if (type.isWildcardType())
		{
			ResolvedType result3 = convertWildcardTypeToUsage(type.asWildcardType(), context);
			
			return result3;
		}
		if (type.isVoidType())
		{
			return ResolvedVoidType.___003C_003EINSTANCE;
		}
		if (type.isArrayType())
		{
			ResolvedType result4 = convertArrayTypeToUsage(type.asArrayType(), context);
			
			return result4;
		}
		if (type.isUnionType())
		{
			ResolvedType result5 = convertUnionTypeToUsage(type.asUnionType(), context);
			
			return result5;
		}
		if (type.isVarType())
		{
			ResolvedType result6 = convertVarTypeToUsage(type.asVarType(), context);
			
			return result6;
		}
		string canonicalName = java.lang.Object.instancehelper_getClass(type).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	private JavaParserFacade(TypeSolver P_0)
	{
		typeSolver = P_0.getRoot();
		symbolSolver = new SymbolSolver(P_0);
		typeExtractor = new TypeExtractor(P_0, this);
	}

	
		
	public virtual SymbolReference solve(NameExpr nameExpr)
	{
		SymbolReference result = symbolSolver.solveSymbol(nameExpr.getName().getId(), nameExpr);
		
		return result;
	}

	
	
	
	private static IllegalArgumentException lambda_0024solve_00240(Expression P_0)
	{
		IllegalArgumentException result = new IllegalArgumentException(java.lang.Object.instancehelper_getClass(P_0).getCanonicalName());
		
		return result;
	}

	
	private static object lambda_0024getType_00241(Node P_0)
	{
		return P_0;
	}

	
	private static object lambda_0024getType_00242(ResolvedType P_0)
	{
		return P_0;
	}

	
	private static object lambda_0024getType_00243(Node P_0)
	{
		return P_0;
	}

	
	private static object lambda_0024getType_00244(Optional P_0)
	{
		return P_0;
	}

	
	
	
	private static RuntimeException lambda_0024toMethodUsage_00245()
	{
		RuntimeException result = new RuntimeException("TypeDeclaration unexpectedly empty.");
		
		return result;
	}

	
	
	
	private static bool lambda_0024toMethodUsage_00246(MethodUsage P_0)
	{
		bool result = P_0.getDeclaration().isStatic();
		
		return result;
	}

	
	
	
	private static bool lambda_0024toMethodUsage_00247(MethodUsage P_0)
	{
		return (!P_0.getDeclaration().isStatic()) ? true : false;
	}

	
	
	
	private ResolvedType lambda_0024convertClassOrInterfaceTypeToUsage_00248(Context P_0, com.github.javaparser.ast.type.Type P_1)
	{
		ResolvedType result = convertToUsage(P_1, P_0);
		
		return result;
	}

	
	
	
	private ResolvedType lambda_0024convertUnionTypeToUsage_00249(Context P_0, ReferenceType P_1)
	{
		ResolvedType result = convertToUsage(P_1, P_0);
		
		return result;
	}

	
	
	
	private static IllegalStateException lambda_0024convertVarTypeToUsage_002410()
	{
		IllegalStateException result = new IllegalStateException("Cannot resolve `var` which has no initializer.");
		
		return result;
	}

	
	
	
	private static string lambda_0024solveMethodAsUsage_002411(Range P_0)
	{
		string result = new StringBuilder().append("").append(P_0.___003C_003Ebegin.___003C_003Eline).ToString();
		
		return result;
	}

	
	
	public static void clearInstances()
	{
		instances.clear();
	}

	public virtual TypeSolver getTypeSolver()
	{
		return typeSolver;
	}

	public virtual SymbolSolver getSymbolSolver()
	{
		return symbolSolver;
	}

	
		
	public virtual SymbolReference solve(SimpleName nameExpr)
	{
		SymbolReference result = symbolSolver.solveSymbol(nameExpr.getId(), nameExpr);
		
		return result;
	}

	
		
	public virtual SymbolReference solve(Expression expr)
	{
		return (SymbolReference)expr.toNameExpr().map(new ___003C_003EAnon1(this)).orElseThrow(new ___003C_003EAnon2(expr));
	}

	
		
	public virtual SymbolReference solve(MethodCallExpr methodCallExpr)
	{
		SymbolReference result = solve(methodCallExpr, solveLambdas: true);
		
		return result;
	}

	
		
	public virtual SymbolReference solve(MethodReferenceExpr methodReferenceExpr)
	{
		SymbolReference result = solve(methodReferenceExpr, solveLambdas: true);
		
		return result;
	}

	
		
	public virtual SymbolReference solve(ObjectCreationExpr objectCreationExpr)
	{
		SymbolReference result = solve(objectCreationExpr, solveLambdas: true);
		
		return result;
	}

	
		
	public virtual SymbolReference solve(ExplicitConstructorInvocationStmt explicitConstructorInvocationStmt)
	{
		SymbolReference result = solve(explicitConstructorInvocationStmt, solveLambdas: true);
		
		return result;
	}

	
		[LineNumberTable(new byte[]
	{
		160, 124, 144, 150, 109, 104, 174, 117, 104, 114,
		104, 217
	})]
	public virtual SymbolReference solve(ThisExpr node)
	{
		if (node.getTypeName().isPresent())
		{
			string text = ((Name)node.getTypeName().get()).asString();
			SymbolReference symbolReference = typeSolver.tryToSolveType(text);
			if (symbolReference.isSolved())
			{
				SymbolReference result = SymbolReference.solved(symbolReference.getCorrespondingDeclaration());
				
				return result;
			}
			Optional optional = node.findAncestor(new Class[1] { ClassLiteral<CompilationUnit>.Value });
			if (optional.isPresent())
			{
				Optional classByName = ((CompilationUnit)optional.get()).getClassByName(text);
				if (classByName.isPresent())
				{
					SymbolReference result2 = SymbolReference.solved(getTypeDeclaration((ClassOrInterfaceDeclaration)classByName.get()));
					
					return result2;
				}
			}
		}
		SymbolReference result3 = SymbolReference.solved(getTypeDeclaration(findContainingTypeDeclOrObjectCreationExpr(node)));
		
		return result3;
	}

	
		
	public virtual SymbolReference solve(AnnotationExpr annotationExpr)
	{
		Context context = JavaParserFactory.getContext(annotationExpr, typeSolver);
		SymbolReference symbolReference = context.solveType(annotationExpr.getNameAsString());
		if (symbolReference.isSolved())
		{
			ResolvedAnnotationDeclaration symbolDeclaration = (ResolvedAnnotationDeclaration)symbolReference.getCorrespondingDeclaration();
			SymbolReference result = SymbolReference.solved(symbolDeclaration);
			
			return result;
		}
		SymbolReference result2 = SymbolReference.unsolved(ClassLiteral<ResolvedAnnotationDeclaration>.Value);
		
		return result2;
	}

	
		
	public virtual SymbolReference solve(FieldAccessExpr fieldAccessExpr)
	{
		SymbolReference result = ((FieldAccessContext)JavaParserFactory.getContext(fieldAccessExpr, typeSolver)).solveField(fieldAccessExpr.getName().getId());
		
		return result;
	}

	
		[LineNumberTable(new byte[]
	{
		161, 72, 103, 109, 104, 214, 117, 106, 134, 139,
		112, 101, 144, 149, 139, 112, 101, 145, 104, 137,
		99, 45, 135, 114, 191, 11, 105, 164, 98, 154,
		127, 2, 223, 11, 105, 171
	})]
	protected internal virtual MethodUsage toMethodUsage(MethodReferenceExpr methodReferenceExpr, List paramTypes)
	{
		Expression scope = methodReferenceExpr.getScope();
		ResolvedType type = getType(methodReferenceExpr.getScope());
		if (!type.isReferenceType())
		{
			string canonicalName = java.lang.Object.instancehelper_getClass(type).getCanonicalName();
			
			throw new UnsupportedOperationException(canonicalName);
		}
		Set allMethods = ((ResolvedReferenceTypeDeclaration)type.asReferenceType().getTypeDeclaration().orElseThrow(new ___003C_003EAnon7())).getAllMethods();
		Optional optional;
		if (scope.isTypeExpr())
		{
			List methods = (List)allMethods.stream().filter(new ___003C_003EAnon8()).collect(Collectors.toList());
			optional = MethodResolutionLogic.findMostApplicableUsage(methods, methodReferenceExpr.getIdentifier(), paramTypes, typeSolver);
			if (!paramTypes.isEmpty())
			{
				List methods2 = (List)allMethods.stream().filter(new ___003C_003EAnon9()).collect(Collectors.toList());
				ArrayList arrayList = new ArrayList(paramTypes);
				((List)arrayList).remove(0);
				Optional optional2 = MethodResolutionLogic.findMostApplicableUsage(methods2, methodReferenceExpr.getIdentifier(), arrayList, typeSolver);
				if (optional.isPresent() && optional2.isPresent())
				{
					string description = new StringBuilder().append("Ambiguous method call: cannot find a most applicable method for ").append(methodReferenceExpr.getIdentifier()).ToString();
					
					throw new MethodAmbiguityException(description);
				}
				if (optional2.isPresent())
				{
					optional = optional2;
				}
			}
		}
		else
		{
			optional = MethodResolutionLogic.findMostApplicableUsage(new ArrayList(allMethods), methodReferenceExpr.getIdentifier(), paramTypes, typeSolver);
			if (optional.isPresent() && ((MethodUsage)optional.get()).getDeclaration().isStatic())
			{
				string message = new StringBuilder().append("Invalid static method reference ").append(methodReferenceExpr.getIdentifier()).ToString();
				
				throw new RuntimeException(message);
			}
		}
		if (!optional.isPresent())
		{
			
			throw new UnsupportedOperationException();
		}
		return (MethodUsage)optional.get();
	}

	
	[LineNumberTable(new byte[]
	{
		159, 18, 66, 105, 233, 74, 108, 110, 118, 110,
		119, 103, 232, 78, 122, 155, 103, 180, 105, 130
	})]
	protected internal virtual ResolvedType getBinaryTypeConcrete(Node left, Node right, bool solveLambdas, BinaryExpr.Operator @operator)
	{
		ResolvedType typeConcrete = getTypeConcrete(left, solveLambdas);
		ResolvedType typeConcrete2 = getTypeConcrete(right, solveLambdas);
		int num;
		int num2;
		if (@operator == BinaryExpr.Operator.___003C_003EPLUS)
		{
			num = ((typeConcrete.isReferenceType() && java.lang.String.instancehelper_equals(typeConcrete.asReferenceType().getQualifiedName(), JAVA_LANG_STRING)) ? 1 : 0);
			num2 = ((typeConcrete2.isReferenceType() && java.lang.String.instancehelper_equals(typeConcrete2.asReferenceType().getQualifiedName(), JAVA_LANG_STRING)) ? 1 : 0);
			if (num != 0 || num2 != 0)
			{
				return (num == 0) ? typeConcrete2 : typeConcrete;
			}
		}
		num = ((typeConcrete.isPrimitive() && typeConcrete.asPrimitive().isNumeric()) ? 1 : 0);
		num2 = ((typeConcrete2.isPrimitive() && typeConcrete2.asPrimitive().isNumeric()) ? 1 : 0);
		if (num != 0 && num2 != 0)
		{
			ResolvedPrimitiveType result = typeConcrete.asPrimitive().bnp(typeConcrete2.asPrimitive());
			
			return result;
		}
		if (typeConcrete2.isAssignableBy(typeConcrete))
		{
			return typeConcrete2;
		}
		return typeConcrete;
	}

	
		
	protected internal virtual TypeDeclaration findContainingTypeDecl(Node node)
	{
		Node node2 = node;
		do
		{
			node2 = Navigator.demandParentNode(node2);
		}
		while (!(node2 is TypeDeclaration));
		return (TypeDeclaration)node2;
	}

	
	[LineNumberTable(new byte[]
	{
		161, 253, 98, 130, 103, 104, 127, 6, 130, 132,
		127, 9, 102
	})]
	protected internal virtual Node findContainingTypeDeclOrObjectCreationExpr(Node node, string className)
	{
		Node node2 = node;
		int num = 0;
		while (true)
		{
			node2 = Navigator.demandParentNode(node2);
			if (node2 is BodyDeclaration)
			{
				if (node2 is TypeDeclaration && java.lang.String.instancehelper_endsWith((string)((TypeDeclaration)node2).getFullyQualifiedName().get(), className))
				{
					return node2;
				}
				num = 1;
			}
			else if (node2 is ObjectCreationExpr && java.lang.String.instancehelper_equals(((ObjectCreationExpr)node2).getType().getName().asString(), className) && num != 0)
			{
				break;
			}
		}
		return node2;
	}

	
	static JavaParserFacade()
	{
		TYPE_WITH_LAMBDAS_RESOLVED = new _1();
		TYPE_WITHOUT_LAMBDAS_RESOLVED = new _2();
		instances = new WeakHashMap();
		JAVA_LANG_STRING = ClassLiteral<java.lang.String>.Value.getCanonicalName();
	}
}
