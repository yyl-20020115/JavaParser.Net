
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.type;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.core.resolution;
using com.github.javaparser.symbolsolver.javaparsermodel.contexts;
using com.github.javaparser.symbolsolver.logic;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.model.typesystem;
using com.google.common.collect;

using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.symbolsolver.javaparsermodel.declarations;


public class JavaParserAnonymousClassDeclaration : AbstractClassDeclaration, MethodUsageResolutionCapability
{
	
	private sealed class ___003C_003EAnon0 : Predicate
	{
		private readonly Class arg_00241;

		internal ___003C_003EAnon0(Class P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024findMembersOfKind_00240(arg_00241, (BodyDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon1 : Function
	{
		private readonly Class arg_00241;

		internal ___003C_003EAnon1(Class P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			Node result = (Node)arg_00241.cast((BodyDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon2 : Predicate
	{
		internal ___003C_003EAnon2()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024getInterfaces_00241((ResolvedReferenceType)P_0);
			
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
		internal ___003C_003EAnon3()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024getInterfaces_00242((ResolvedReferenceType)P_0);
			
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

	
	private sealed class ___003C_003EAnon4 : Consumer
	{
		private readonly ImmutableList.Builder arg_00241;

		internal ___003C_003EAnon4(ImmutableList.Builder P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.add((ResolvedReferenceType)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon5 : Function
	{
		private readonly JavaParserAnonymousClassDeclaration arg_00241;

		internal ___003C_003EAnon5(JavaParserAnonymousClassDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			Stream result = arg_00241.lambda_0024getAllFields_00244((FieldDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon6 : Supplier
	{
		internal ___003C_003EAnon6()
		{
		}

		public object get()
		{
			RuntimeException result = lambda_0024getAllFields_00245();
			
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
			RuntimeException result = lambda_0024getAllFields_00246();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon8 : Function
	{
		internal ___003C_003EAnon8()
		{
		}

		public object apply(object P_0)
		{
			Stream result = lambda_0024getAllFields_00248((ResolvedReferenceType)P_0);
			
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

	
	private sealed class ___003C_003EAnon9 : Function
	{
		private readonly JavaParserAnonymousClassDeclaration arg_00241;

		internal ___003C_003EAnon9(JavaParserAnonymousClassDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			JavaParserMethodDeclaration result = arg_00241.lambda_0024getDeclaredMethods_00249((MethodDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon10 : Function
	{
		private readonly JavaParserAnonymousClassDeclaration arg_00241;

		internal ___003C_003EAnon10(JavaParserAnonymousClassDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			ResolvedReferenceTypeDeclaration result = arg_00241.lambda_0024internalTypes_002410((TypeDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon11 : Supplier
	{
		internal ___003C_003EAnon11()
		{
		}

		public object get()
		{
			RuntimeException result = lambda_0024null_00247();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon12 : Function
	{
		private readonly JavaParserAnonymousClassDeclaration arg_00241;

		internal ___003C_003EAnon12(JavaParserAnonymousClassDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			JavaParserFieldDeclaration result = arg_00241.lambda_0024null_00243((VariableDeclarator)P_0);
			
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

	
	private TypeSolver typeSolver;

	
	private ObjectCreationExpr wrappedNode;

	
	private ResolvedTypeDeclaration superTypeDeclaration;

	
	private string name;

	
	
	public JavaParserAnonymousClassDeclaration(ObjectCreationExpr wrappedNode, TypeSolver typeSolver)
	{
		name = new StringBuilder().append("Anonymous-").append(UUID.randomUUID()).ToString();
		this.typeSolver = typeSolver;
		this.wrappedNode = wrappedNode;
		ClassOrInterfaceType type = wrappedNode.getType();
		string str = type.getName().getId();
		if (type.getScope().isPresent())
		{
			str = new StringBuilder().append(((ClassOrInterfaceType)type.getScope().get()).asString()).append(".").append(str)
				.ToString();
		}
		ObjectCreationContext objectCreationContext = new ObjectCreationContext(wrappedNode, typeSolver);
		superTypeDeclaration = (ResolvedTypeDeclaration)((Context)objectCreationContext).solveType(str).getCorrespondingDeclaration();
	}

	
		
	public override Set getDeclaredMethods()
	{
		return (Set)findMembersOfKind(ClassLiteral<MethodDeclaration>.Value).stream().map(new ___003C_003EAnon9(this)).collect(Collectors.toSet());
	}

	public virtual ResolvedTypeDeclaration getSuperTypeDeclaration()
	{
		return superTypeDeclaration;
	}

	
		
	public unsafe virtual List findMembersOfKind(Class memberClass)
	{
		if (wrappedNode.getAnonymousClassBody().isPresent())
		{
			Stream stream = ((NodeList)wrappedNode.getAnonymousClassBody().get()).stream().filter(new ___003C_003EAnon0(memberClass));
			
			return (List)stream.map(new ___003C_003EAnon1(memberClass)).collect(Collectors.toList());
		}
		List result = Collections.emptyList();
		
		return result;
	}

	
	
	public virtual Context getContext()
	{
		Context context = JavaParserFactory.getContext(wrappedNode, typeSolver);
		
		return context;
	}

	
		
	public override Optional getSuperClass()
	{
		ResolvedReferenceTypeDeclaration resolvedReferenceTypeDeclaration = superTypeDeclaration.asReferenceType();
		if (resolvedReferenceTypeDeclaration == null)
		{
			Optional result = Optional.empty();
			
			return result;
		}
		ReferenceTypeImpl.___003Cclinit_003E();
		Optional result2 = Optional.of(new ReferenceTypeImpl(resolvedReferenceTypeDeclaration, typeSolver));
		
		return result2;
	}

	
		
	public override List getInterfaces()
	{
		return (List)superTypeDeclaration.asReferenceType().getAncestors().stream()
			.filter(new ___003C_003EAnon2())
			.filter(new ___003C_003EAnon3())
			.collect(Collectors.toList());
	}

	public override string getName()
	{
		return name;
	}

	
	
	
	private static bool lambda_0024findMembersOfKind_00240(Class P_0, BodyDeclaration P_1)
	{
		bool result = P_0.isAssignableFrom(Object.instancehelper_getClass(P_1));
		
		return result;
	}

	
	
	
	private static bool lambda_0024getInterfaces_00241(ResolvedReferenceType P_0)
	{
		bool result = P_0.getTypeDeclaration().isPresent();
		
		return result;
	}

	
	
	
	private static bool lambda_0024getInterfaces_00242(ResolvedReferenceType P_0)
	{
		bool result = ((ResolvedReferenceTypeDeclaration)P_0.getTypeDeclaration().get()).isInterface();
		
		return result;
	}

	
	
	
	private Stream lambda_0024getAllFields_00244(FieldDeclaration P_0)
	{
		Stream result = P_0.getVariables().stream().map(new ___003C_003EAnon12(this));
		
		return result;
	}

	
	
	
	private static RuntimeException lambda_0024getAllFields_00245()
	{
		RuntimeException result = new RuntimeException("super class unexpectedly empty");
		
		return result;
	}

	
	
	
	private static RuntimeException lambda_0024getAllFields_00246()
	{
		RuntimeException result = new RuntimeException("TypeDeclaration unexpectedly empty.");
		
		return result;
	}

	
	
	
	private static Stream lambda_0024getAllFields_00248(ResolvedReferenceType P_0)
	{
		Stream result = ((ResolvedReferenceTypeDeclaration)P_0.getTypeDeclaration().orElseThrow(new ___003C_003EAnon11())).getAllFields().stream();
		
		return result;
	}

	
	
	
	private JavaParserMethodDeclaration lambda_0024getDeclaredMethods_00249(MethodDeclaration P_0)
	{
		JavaParserMethodDeclaration result = new JavaParserMethodDeclaration(P_0, typeSolver);
		
		return result;
	}

	
	
	
	private ResolvedReferenceTypeDeclaration lambda_0024internalTypes_002410(TypeDeclaration P_0)
	{
		ResolvedReferenceTypeDeclaration typeDeclaration = JavaParserFacade.get(typeSolver).getTypeDeclaration(P_0);
		
		return typeDeclaration;
	}

	
	
	
	private static RuntimeException lambda_0024null_00247()
	{
		RuntimeException result = new RuntimeException("TypeDeclaration unexpectedly empty.");
		
		return result;
	}

	
	
	
	private JavaParserFieldDeclaration lambda_0024null_00243(VariableDeclarator P_0)
	{
		JavaParserFieldDeclaration result = new JavaParserFieldDeclaration(P_0, typeSolver);
		
		return result;
	}

	
		
	public override SymbolReference solveMethod(string name, List argumentsTypes, bool staticOnly)
	{
		SymbolReference result = getContext().solveMethod(name, argumentsTypes, staticOnly);
		
		return result;
	}

	
		
	public virtual Optional solveMethodAsUsage(string name, List argumentTypes, Context invocationContext, List typeParameters)
	{
		Optional result = getContext().solveMethodAsUsage(name, argumentTypes);
		
		return result;
	}

	
	
	protected internal override ResolvedReferenceType @object()
	{
		ReferenceTypeImpl.___003Cclinit_003E();
		ReferenceTypeImpl result = new ReferenceTypeImpl(typeSolver.getSolvedJavaLangObject(), typeSolver);
		
		return result;
	}

	
		
	public override List getConstructors()
	{
		if (superTypeDeclaration.isInterface())
		{
			List result = Collections.singletonList(new DefaultConstructorDeclaration(this));
			
			return result;
		}
		List constructors = superTypeDeclaration.asReferenceType().getConstructors();
		
		return constructors;
	}

	
	
	public override AccessSpecifier accessSpecifier()
	{
		return AccessSpecifier.___003C_003EPRIVATE;
	}

	
		
	public unsafe override List getAncestors(bool acceptIncompleteList)
	{
		ImmutableList.Builder builder = ImmutableList.builder();
		Optional superClass = getSuperClass();
		
		superClass.ifPresent(new ___003C_003EAnon4(builder));
		builder.addAll(superTypeDeclaration.asReferenceType().getAncestors(acceptIncompleteList));
		ImmutableList result = builder.build();
		
		return result;
	}

	
		
	public override List getAllFields()
	{
		List elements = (List)findMembersOfKind(ClassLiteral<FieldDeclaration>.Value).stream().flatMap(new ___003C_003EAnon5(this)).collect(Collectors.toList());
		List allFields = ((ResolvedReferenceTypeDeclaration)((ResolvedReferenceType)getSuperClass().orElseThrow(new ___003C_003EAnon6())).getTypeDeclaration().orElseThrow(new ___003C_003EAnon7())).getAllFields();
		List elements2 = (List)getInterfaces().stream().flatMap(new ___003C_003EAnon8()).collect(Collectors.toList());
		ImmutableList result = ImmutableList.builder().addAll(elements).addAll(allFields)
			.addAll(elements2)
			.build();
		
		return result;
	}

	public override bool isAssignableBy(ResolvedType type)
	{
		return false;
	}

	public override bool isAssignableBy(ResolvedReferenceTypeDeclaration other)
	{
		return false;
	}

	public override bool hasDirectlyAnnotation(string qualifiedName)
	{
		return false;
	}

	
	
	public override string getPackageName()
	{
		string packageName = AstResolutionUtils.getPackageName(wrappedNode);
		
		return packageName;
	}

	
	
	public override string getClassName()
	{
		string className = AstResolutionUtils.getClassName("", wrappedNode);
		
		return className;
	}

	
	
	public override string getQualifiedName()
	{
		string text = AstResolutionUtils.containerName((Node)wrappedNode.getParentNode().orElse(null));
		if (String.instancehelper_isEmpty(text))
		{
			string result = getName();
			
			return result;
		}
		string result2 = new StringBuilder().append(text).append(".").append(getName())
			.ToString();
		
		return result2;
	}

	
		
	public override Set internalTypes()
	{
		return (Set)findMembersOfKind(ClassLiteral<TypeDeclaration>.Value).stream().map(new ___003C_003EAnon10(this)).collect(Collectors.toSet());
	}

	
		
	public override List getTypeParameters()
	{
		ArrayList result = Lists.newArrayList();
		
		return result;
	}

	
		
	public override Optional containerType()
	{
		string message = new StringBuilder().append("containerType is not supported for ").append(Object.instancehelper_getClass(this).getCanonicalName()).ToString();
		
		throw new UnsupportedOperationException(message);
	}

	
		
	public override Optional toAst()
	{
		Optional result = Optional.of(wrappedNode);
		
		return result;
	}
}
