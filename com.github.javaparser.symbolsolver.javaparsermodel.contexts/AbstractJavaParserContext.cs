using System;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.core.resolution;
using com.github.javaparser.symbolsolver.javaparser;
using com.github.javaparser.symbolsolver.javaparsermodel.declarations;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.reflectionmodel;
using com.github.javaparser.symbolsolver.resolution;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.symbolsolver.javaparsermodel.contexts;

public abstract class AbstractJavaParserContext : java.lang.Context
{
	
	private sealed class ___003C_003EAnon0 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon0(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024solveSymbolInParentContext_00240(arg_00241, (PatternExpr)P_0);
			
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
		private readonly string arg_00241;

		internal ___003C_003EAnon1(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024solveWithAsValue_00241(arg_00241, (ResolvedValueDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon2 : Function
	{
		internal ___003C_003EAnon2()
		{
		}

		public object apply(object P_0)
		{
			Value result = Value.from((ResolvedValueDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon3 : Supplier
	{
		internal ___003C_003EAnon3()
		{
		}

		public object get()
		{
			RuntimeException result = lambda_0024findTypeDeclarations_00242();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon4 : Supplier
	{
		internal ___003C_003EAnon4()
		{
		}

		public object get()
		{
			RuntimeException result = lambda_0024findTypeDeclarations_00243();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon5 : Supplier
	{
		internal ___003C_003EAnon5()
		{
		}

		public object get()
		{
			RuntimeException result = lambda_0024findTypeDeclarations_00244();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon6 : Function
	{
		internal ___003C_003EAnon6()
		{
		}

		public object apply(object P_0)
		{
			Optional typeDeclaration = ((ResolvedReferenceType)P_0).getTypeDeclaration();
			
			return typeDeclaration;
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

	
	private sealed class ___003C_003EAnon7 : Function
	{
		internal ___003C_003EAnon7()
		{
		}

		public object apply(object P_0)
		{
			List result = Collections.singletonList((ResolvedReferenceTypeDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon8 : Supplier
	{
		private readonly ResolvedType arg_00241;

		internal ___003C_003EAnon8(ResolvedType P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			UnsolvedSymbolException result = lambda_0024findTypeDeclarations_00245(arg_00241);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon9 : Supplier
	{
		internal ___003C_003EAnon9()
		{
		}

		public object get()
		{
			RuntimeException result = lambda_0024findTypeDeclarations_00246();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon10 : Supplier
	{
		internal ___003C_003EAnon10()
		{
		}

		public object get()
		{
			RuntimeException result = lambda_0024findTypeDeclarations_00247();
			
			return result;
		}
	}

		protected internal Node wrappedNode;

	protected internal TypeSolver typeSolver;

		public virtual Node getWrappedNode()
	{
		return wrappedNode;
	}

	
	
	protected internal virtual Node getScope(Node node)
	{
		return (Node)((NodeWithOptionalScope)node).getScope().get();
	}

	
		[LineNumberTable(new byte[]
	{
		66, 183, 107, 135, 98, 127, 2, 106, 98, 130,
		98, 99, 99, 105, 139, 181, 131, 120, 124, 150,
		100, 136, 111
	})]
	public Optional getParent()
	{
		Node node = (Node)wrappedNode.getParentNode().orElse(null);
		if (node is MethodCallExpr)
		{
			MethodCallExpr methodCallExpr = (MethodCallExpr)node;
			int num = 0;
			Iterator iterator = methodCallExpr.getArguments().iterator();
			while (iterator.hasNext())
			{
				Expression expression = (Expression)iterator.next();
				if (expression == wrappedNode)
				{
					num = 1;
					break;
				}
			}
			if (num != 0)
			{
				Node node2 = node;
				while (node2 is MethodCallExpr)
				{
					node2 = Navigator.demandParentNode(node2);
				}
				Optional result = Optional.of(JavaParserFactory.getContext(node2, typeSolver));
				
				return result;
			}
		}
		Node node3 = node;
		while (node3 is MethodCallExpr || node3 is FieldAccessExpr || (node3 != null && node3.hasScope() && getScope(node3).equals(wrappedNode)))
		{
			node3 = (Node)node3.getParentNode().orElse(null);
		}
		if (node3 == null)
		{
			Optional result2 = Optional.empty();
			
			return result2;
		}
		Context context = JavaParserFactory.getContext(node3, typeSolver);
		Optional result3 = Optional.of(context);
		
		return result3;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual SymbolReference solveType(string P_0)
	{
		return Context._003Cdefault_003EsolveType(this, P_0);
	}

	
	
	
	private static bool lambda_0024solveSymbolInParentContext_00240(string P_0, PatternExpr P_1)
	{
		bool result = java.lang.String.instancehelper_equals(P_1.getNameAsString(), P_0);
		
		return result;
	}

	
	
	
	private static bool lambda_0024solveWithAsValue_00241(string P_0, ResolvedValueDeclaration P_1)
	{
		bool result = java.lang.String.instancehelper_equals(P_1.getName(), P_0);
		
		return result;
	}

	
	
	
	private static RuntimeException lambda_0024findTypeDeclarations_00242()
	{
		RuntimeException result = new RuntimeException("TypeDeclaration unexpectedly empty.");
		
		return result;
	}

	
	
	
	private static RuntimeException lambda_0024findTypeDeclarations_00243()
	{
		RuntimeException result = new RuntimeException("TypeDeclaration unexpectedly empty.");
		
		return result;
	}

	
	
	
	private static RuntimeException lambda_0024findTypeDeclarations_00244()
	{
		RuntimeException result = new RuntimeException("TypeDeclaration unexpectedly empty.");
		
		return result;
	}

	
	
	
	private static UnsolvedSymbolException lambda_0024findTypeDeclarations_00245(ResolvedType P_0)
	{
		UnsolvedSymbolException result = new UnsolvedSymbolException(new StringBuilder().append("No common ancestor available for UnionType").append(P_0.describe()).ToString());
		
		return result;
	}

	
	
	
	private static RuntimeException lambda_0024findTypeDeclarations_00246()
	{
		RuntimeException result = new RuntimeException("TypeDeclaration unexpectedly empty.");
		
		return result;
	}

	
	
	
	private static RuntimeException lambda_0024findTypeDeclarations_00247()
	{
		RuntimeException result = new RuntimeException("TypeDeclaration unexpectedly empty.");
		
		return result;
	}

	
	
	protected internal static bool isQualifiedName(string name)
	{
		CharSequence s = default(CharSequence);
		object obj = (s.___003Cref_003E = ".");
		bool result = java.lang.String.instancehelper_contains(name, s);
		
		return result;
	}

	
		
	public static SymbolReference solveWith(SymbolDeclarator symbolDeclarator, string name)
	{
		Iterator iterator = symbolDeclarator.getSymbolDeclarations().iterator();
		while (iterator.hasNext())
		{
			ResolvedValueDeclaration resolvedValueDeclaration = (ResolvedValueDeclaration)iterator.next();
			if (java.lang.String.instancehelper_equals(resolvedValueDeclaration.getName(), name))
			{
				SymbolReference result = SymbolReference.solved(resolvedValueDeclaration);
				
				return result;
			}
		}
		SymbolReference result2 = SymbolReference.unsolved(ClassLiteral<ResolvedValueDeclaration>.Value);
		
		return result2;
	}

	
		
	public AbstractJavaParserContext(Node wrappedNode, TypeSolver typeSolver)
	{
		if (wrappedNode == null)
		{
			
			throw new NullPointerException();
		}
		this.wrappedNode = wrappedNode;
		this.typeSolver = typeSolver;
	}

	
	
	public override bool Equals(object o)
	{
		if (this == o)
		{
			return true;
		}
		if (o == null || ((object)this).GetType() != o.GetType())
		{
			return false;
		}
		AbstractJavaParserContext abstractJavaParserContext = (AbstractJavaParserContext)o;
		return (wrappedNode != null) ? wrappedNode.equals(abstractJavaParserContext.wrappedNode) : (abstractJavaParserContext.wrappedNode == null);
	}

	
	
	public override int GetHashCode()
	{
		int result = ((wrappedNode != null) ? wrappedNode.GetHashCode() : 0);
		
		return result;
	}

	
		[LineNumberTable(new byte[]
	{
		108, 103, 104, 205, 108, 115, 141, 97, 112, 101,
		134, 104, 105, 120, 106, 105, 240, 70
	})]
	public virtual SymbolReference solveSymbolInParentContext(string name)
	{
		Optional parent = getParent();
		if (!parent.isPresent())
		{
			SymbolReference result = SymbolReference.unsolved(ClassLiteral<ResolvedValueDeclaration>.Value);
			
			return result;
		}
		Context context = (Context)parent.get();
		if (context is BinaryExprContext || context is IfStatementContext)
		{
			List list = context.patternExprsExposedToChild(getWrappedNode());
			Optional optional = list.stream().filter(new ___003C_003EAnon0(name)).findFirst();
			if (optional.isPresent())
			{
				if (list.size() == 1)
				{
					JavaParserPatternDeclaration symbolDeclaration = JavaParserSymbolDeclaration.patternVar((PatternExpr)optional.get(), typeSolver);
					SymbolReference result2 = SymbolReference.solved(symbolDeclaration);
					
					return result2;
				}
				if (list.size() > 1)
				{
					
					throw new IllegalStateException("Unexpectedly more than one reference in scope");
				}
			}
		}
		SymbolReference result3 = context.solveSymbol(name);
		
		return result3;
	}

	
		
	protected internal virtual Optional solveWithAsValue(SymbolDeclarator symbolDeclarator, string name)
	{
		Optional result = symbolDeclarator.getSymbolDeclarations().stream().filter(new ___003C_003EAnon1(name))
			.map(new ___003C_003EAnon2())
			.findFirst();
		
		return result;
	}

	
		[LineNumberTable(new byte[]
	{
		160,
		85,
		107,
		172,
		104,
		103,
		114,
		122,
		246,
		70,
		byte.MaxValue,
		12,
		74,
		226,
		55,
		130,
		104,
		104,
		116,
		166,
		158,
		104,
		154,
		97,
		101,
		101,
		101,
		111,
		229,
		59,
		230,
		72,
		155,
		136,
		123,
		104,
		103,
		159,
		10,
		100,
		101,
		101,
		111,
		229,
		60,
		230,
		70,
		98,
		99,
		136,
		97,
		101,
		101,
		101,
		111,
		229,
		59,
		230,
		71,
		104,
		117,
		111,
		112,
		234,
		61,
		225,
		71,
		97,
		101,
		111,
		229,
		61,
		230,
		71,
		184,
		98,
		101,
		111,
		229,
		61
	})]
	protected internal virtual Collection findTypeDeclarations(Optional optScope)
	{
		Expression expression;
		java.lang.Exception ex2;
		if (optScope.isPresent())
		{
			expression = (Expression)optScope.get();
			if (expression is NameExpr)
			{
				NameExpr nameExpr = expression.asNameExpr();
				SymbolReference symbolReference = solveType(nameExpr.getName().getId());
				if (symbolReference.isSolved() && ((ResolvedTypeDeclaration)symbolReference.getCorrespondingDeclaration()).isType())
				{
					return Collections.singletonList(((ResolvedTypeDeclaration)symbolReference.getCorrespondingDeclaration()).asReferenceType());
				}
			}
			ResolvedType type;
			try
			{
				type = JavaParserFacade.get(typeSolver).getType(expression);
			}
			catch (System.Exception x)
			{
				java.lang.Exception ex = ByteCodeHelper.MapException<java.lang.Exception>(x, ByteCodeHelper.MapFlags.None);
				if (ex == null)
				{
					throw;
				}
				ex2 = ex;
				goto IL_008f;
			}
			if (type.isWildcard())
			{
				if (type.asWildcard().isExtends() || type.asWildcard().isSuper())
				{
					return Collections.singletonList(type.asWildcard().getBoundedType().asReferenceType()
						.getTypeDeclaration()
						.orElseThrow(new ___003C_003EAnon3()));
				}
				return Collections.singletonList(new ReflectionClassDeclaration(ClassLiteral<java.lang.Object>.Value, typeSolver).asReferenceType());
			}
			if (type.isArray())
			{
				return Collections.singletonList(new ReflectionClassDeclaration(ClassLiteral<java.lang.Object>.Value, typeSolver).asReferenceType());
			}
			if (type.isTypeVariable())
			{
				ArrayList arrayList = new ArrayList();
				Iterator iterator = type.asTypeParameter().getBounds().iterator();
				while (iterator.hasNext())
				{
					ResolvedTypeParameterDeclaration.Bound bound = (ResolvedTypeParameterDeclaration.Bound)iterator.next();
					((Collection)arrayList).add(bound.getType().asReferenceType().getTypeDeclaration()
						.orElseThrow(new ___003C_003EAnon4()));
				}
				return arrayList;
			}
			if (type.isConstraint())
			{
				return Collections.singletonList(type.asConstraintType().getBound().asReferenceType()
					.getTypeDeclaration()
					.orElseThrow(new ___003C_003EAnon5()));
			}
			if (type.isUnionType())
			{
				return (Collection)type.asUnionType().getCommonAncestor().flatMap(new ___003C_003EAnon6())
					.map(new ___003C_003EAnon7())
					.orElseThrow(new ___003C_003EAnon8(type));
			}
			return Collections.singletonList(type.asReferenceType().getTypeDeclaration().orElseThrow(new ___003C_003EAnon9()));
		}
		ResolvedType typeOfThisIn = JavaParserFacade.get(typeSolver).getTypeOfThisIn(wrappedNode);
		return Collections.singletonList(typeOfThisIn.asReferenceType().getTypeDeclaration().orElseThrow(new ___003C_003EAnon10()));
		IL_008f:
		java.lang.Exception cause = ex2;
		if (expression is FieldAccessExpr)
		{
			FieldAccessExpr fieldAccessExpr = (FieldAccessExpr)expression;
			if (solveType(fieldAccessExpr.ToString()).isSolved())
			{
				return Collections.emptyList();
			}
		}
		string name = expression.ToString();
		string context = wrappedNode.ToString();
		
		throw new UnsolvedSymbolException(name, context, cause);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional solveGenericType(string P_0)
	{
		return Context._003Cdefault_003EsolveGenericType(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional solveGenericTypeInParentContext(string P_0)
	{
		return Context._003Cdefault_003EsolveGenericTypeInParentContext(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual SymbolReference solveTypeInParentContext(string P_0)
	{
		return Context._003Cdefault_003EsolveTypeInParentContext(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual SymbolReference solveSymbol(string P_0)
	{
		return Context._003Cdefault_003EsolveSymbol(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional solveSymbolAsValue(string P_0)
	{
		return Context._003Cdefault_003EsolveSymbolAsValue(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional solveSymbolAsValueInParentContext(string P_0)
	{
		return Context._003Cdefault_003EsolveSymbolAsValueInParentContext(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual List fieldsExposedToChild(Node P_0)
	{
		return Context._003Cdefault_003EfieldsExposedToChild(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual List localVariablesExposedToChild(Node P_0)
	{
		return Context._003Cdefault_003ElocalVariablesExposedToChild(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual List parametersExposedToChild(Node P_0)
	{
		return Context._003Cdefault_003EparametersExposedToChild(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual List patternExprsExposedToChild(Node P_0)
	{
		return Context._003Cdefault_003EpatternExprsExposedToChild(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual List patternExprsExposedFromChildren()
	{
		return Context._003Cdefault_003EpatternExprsExposedFromChildren(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual List negatedPatternExprsExposedFromChildren()
	{
		return Context._003Cdefault_003EnegatedPatternExprsExposedFromChildren(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional localVariableDeclarationInScope(string P_0)
	{
		return Context._003Cdefault_003ElocalVariableDeclarationInScope(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional parameterDeclarationInScope(string P_0)
	{
		return Context._003Cdefault_003EparameterDeclarationInScope(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional patternExprInScope(string P_0)
	{
		return Context._003Cdefault_003EpatternExprInScope(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional fieldDeclarationInScope(string P_0)
	{
		return Context._003Cdefault_003EfieldDeclarationInScope(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual SymbolReference solveConstructor(List P_0)
	{
		return Context._003Cdefault_003EsolveConstructor(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual SymbolReference solveMethod(string P_0, List P_1, bool P_2)
	{
		return Context._003Cdefault_003EsolveMethod(this, P_0, P_1, P_2);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual SymbolReference solveMethodInParentContext(string P_0, List P_1, bool P_2)
	{
		return Context._003Cdefault_003EsolveMethodInParentContext(this, P_0, P_1, P_2);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional solveMethodAsUsage(string P_0, List P_1)
	{
		return Context._003Cdefault_003EsolveMethodAsUsage(this, P_0, P_1);
	}
}
