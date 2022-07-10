using System;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.type;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.core.resolution;
using com.github.javaparser.symbolsolver.logic;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.model.typesystem;
using com.github.javaparser.symbolsolver.resolution;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.symbolsolver.javaparsermodel.declarations;


public class JavaParserClassDeclaration : AbstractClassDeclaration, MethodUsageResolutionCapability
{
	
	[EnclosingMethod(null, "lambda$null$1", "(Ljava.util.List;Lcom.github.javaparser.resolution.types.ResolvedReferenceType;Lcom.github.javaparser.resolution.declarations.ResolvedFieldDeclaration;)V")]
	
	internal class _1 :  ResolvedFieldDeclaration, ResolvedValueDeclaration, ResolvedDeclaration, HasAccessSpecifier, AssociableToAST
	{
		
		internal ResolvedFieldDeclaration val_0024f;

		
		internal ResolvedReferenceType val_0024ancestor;

		
		internal JavaParserClassDeclaration this_00240;

		
		
		internal _1(JavaParserClassDeclaration P_0, ResolvedFieldDeclaration P_1, ResolvedReferenceType P_2)
		{
			this_00240 = P_0;
			val_0024f = P_1;
			val_0024ancestor = P_2;
			
		}

		
		
		public virtual AccessSpecifier accessSpecifier()
		{
			AccessSpecifier result = val_0024f.accessSpecifier();
			
			return result;
		}

		
		
		public virtual string getName()
		{
			string name = val_0024f.getName();
			
			return name;
		}

		
		
		public virtual ResolvedType getType()
		{
			ResolvedType result = val_0024ancestor.useThisTypeParametersOnTheGivenType(val_0024f.getType());
			
			return result;
		}

		
		
		public virtual bool isStatic()
		{
			bool result = val_0024f.isStatic();
			
			return result;
		}

		
		
		public virtual bool isVolatile()
		{
			bool result = val_0024f.isVolatile();
			
			return result;
		}

		
		
		public virtual ResolvedTypeDeclaration declaringType()
		{
			ResolvedTypeDeclaration result = val_0024f.declaringType();
			
			return result;
		}

		
				
		public virtual Optional toAst()
		{
			Optional result = val_0024f.toAst();
			
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual bool hasName()
		{
			return ResolvedDeclaration._003Cdefault_003EhasName(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual bool isField()
		{
			return ResolvedFieldDeclaration._003Cdefault_003EisField(this);
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
			return ResolvedFieldDeclaration._003Cdefault_003EasField(this);
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
		internal ___003C_003EAnon0()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024getAllFields_00240((ResolvedReferenceType)P_0);
			
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

	
	private sealed class ___003C_003EAnon1 : Consumer
	{
		private readonly JavaParserClassDeclaration arg_00241;

		private readonly List arg_00242;

		internal ___003C_003EAnon1(JavaParserClassDeclaration P_0, List P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024getAllFields_00242(arg_00242, (ResolvedReferenceType)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon2 : Supplier
	{
		internal ___003C_003EAnon2()
		{
		}

		public object get()
		{
			RuntimeException result = lambda_0024solveType_00243();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon3 : Function
	{
		private readonly JavaParserClassDeclaration arg_00241;

		internal ___003C_003EAnon3(JavaParserClassDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			JavaParserTypeParameter result = arg_00241.lambda_0024getTypeParameters_00244((TypeParameter)P_0);
			
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

	
	private sealed class ___003C_003EAnon4 : Function
	{
		private readonly JavaParserClassDeclaration arg_00241;

		internal ___003C_003EAnon4(JavaParserClassDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			LazyType result = arg_00241.lambda_0024toReferenceType_00246((com.github.javaparser.ast.type.Type)P_0);
			
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

	
	private sealed class ___003C_003EAnon5 : Function
	{
		private readonly JavaParserClassDeclaration arg_00241;

		private readonly com.github.javaparser.ast.type.Type arg_00242;

		internal ___003C_003EAnon5(JavaParserClassDeclaration P_0, com.github.javaparser.ast.type.Type P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			ResolvedType result = arg_00241.lambda_0024null_00245(arg_00242, (java.lang.Void)P_0);
			
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

	
	private sealed class ___003C_003EAnon6 : Consumer
	{
		private readonly JavaParserClassDeclaration arg_00241;

		private readonly List arg_00242;

		private readonly ResolvedReferenceType arg_00243;

		internal ___003C_003EAnon6(JavaParserClassDeclaration P_0, List P_1, ResolvedReferenceType P_2)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024null_00241(arg_00242, arg_00243, (ResolvedFieldDeclaration)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	private TypeSolver typeSolver;

	private ClassOrInterfaceDeclaration wrappedNode;

		private JavaParserTypeAdapter javaParserTypeAdapter;

	
	
		[LineNumberTable(new byte[]
	{
		160, 195, 120, 137, 109, 104, 162, 127, 6, 119,
		191, 6, 117, 107, 7
	})]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual SymbolReference solveType(string name)
	{
		if (java.lang.String.instancehelper_equals(wrappedNode.getName().getId(), name))
		{
			SymbolReference result = SymbolReference.solved(this);
			
			return result;
		}
		SymbolReference symbolReference = javaParserTypeAdapter.solveType(name);
		if (symbolReference.isSolved())
		{
			return symbolReference;
		}
		string text = new StringBuilder().append(wrappedNode.getName()).append(".").ToString();
		if (java.lang.String.instancehelper_startsWith(name, text) && java.lang.String.instancehelper_length(name) > java.lang.String.instancehelper_length(text))
		{
			SymbolReference result2 = new JavaParserClassDeclaration(wrappedNode, typeSolver).solveType(java.lang.String.instancehelper_substring(name, java.lang.String.instancehelper_length(text)));
			
			return result2;
		}
		SymbolReference result3 = ((Context)getContext().getParent().orElseThrow(new ___003C_003EAnon2())).solveType(name);
		
		return result3;
	}

	
		[LineNumberTable(new byte[]
	{
		159,
		59,
		162,
		166,
		104,
		162,
		108,
		104,
		226,
		69,
		103,
		104,
		126,
		byte.MaxValue,
		2,
		75,
		226,
		56,
		194,
		131,
		200,
		191,
		13,
		106,
		117,
		253,
		75,
		226,
		55,
		226,
		69,
		131,
		168,
		133
	})]
	public override List getAncestors(bool acceptIncompleteList)
	{
		ArrayList arrayList = new ArrayList();
		if (isJavaLangObject())
		{
			return arrayList;
		}
		Optional fullyQualifiedName = wrappedNode.getFullyQualifiedName();
		if (!fullyQualifiedName.isPresent())
		{
			return arrayList;
		}
		UnsolvedSymbolException ex;
		try
		{
			Optional superClass = getSuperClass();
			if (superClass.isPresent() && isAncestor((ResolvedReferenceType)superClass.get(), (string)fullyQualifiedName.get()))
			{
				((List)arrayList).add(superClass.get());
			}
		}
		catch (UnsolvedSymbolException x)
		{
			ex = ByteCodeHelper.MapException<UnsolvedSymbolException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0072;
		}
		goto IL_0085;
		IL_0072:
		UnsolvedSymbolException ex2 = ex;
		if (!acceptIncompleteList)
		{
			throw ex2;
		}
		goto IL_0085;
		IL_0085:
		Iterator iterator = wrappedNode.getImplementedTypes().iterator();
		while (iterator.hasNext())
		{
			ClassOrInterfaceType classOrInterfaceType = (ClassOrInterfaceType)iterator.next();
			UnsolvedSymbolException ex3;
			try
			{
				ResolvedReferenceType resolvedReferenceType = toReferenceType(classOrInterfaceType);
				if (isAncestor(resolvedReferenceType, (string)fullyQualifiedName.get()))
				{
					((List)arrayList).add((object)resolvedReferenceType);
				}
			}
			catch (UnsolvedSymbolException x2)
			{
				ex3 = ByteCodeHelper.MapException<UnsolvedSymbolException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_00e9;
			}
			continue;
			IL_00e9:
			UnsolvedSymbolException ex4 = ex3;
			if (!acceptIncompleteList)
			{
				throw Throwable.___003Cunmap_003E(ex4);
			}
		}
		return arrayList;
	}

	
	
	
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual Context getContext()
	{
		Context context = JavaParserFactory.getContext(wrappedNode, typeSolver);
		
		return context;
	}

	
	
	protected internal override ResolvedReferenceType @object()
	{
		ResolvedReferenceTypeDeclaration solvedJavaLangObject = typeSolver.getSolvedJavaLangObject();
		ReferenceTypeImpl.___003Cclinit_003E();
		ReferenceTypeImpl result = new ReferenceTypeImpl(solvedJavaLangObject, typeSolver);
		
		return result;
	}

	
	[LineNumberTable(new byte[]
	{
		161, 89, 108, 141, 159, 22, 168, 104, 103, 104,
		127, 32, 232, 69, 104, 182, 109, 191, 4, 112,
		112, 101, 145
	})]
	private ResolvedReferenceType toReferenceType(ClassOrInterfaceType P_0)
	{
		string text = P_0.getName().getId();
		if (P_0.getScope().isPresent())
		{
			text = new StringBuilder().append(((ClassOrInterfaceType)P_0.getScope().get()).ToString()).append(".").append(text)
				.ToString();
		}
		SymbolReference symbolReference = solveType(text);
		if (!symbolReference.isSolved())
		{
			Optional scope = P_0.getScope();
			if (scope.isPresent())
			{
				string name = new StringBuilder().append(((ClassOrInterfaceType)scope.get()).getName().getId()).append(".").append(P_0.getName().getId())
					.ToString();
				symbolReference = solveType(name);
			}
		}
		if (!symbolReference.isSolved())
		{
			string id = P_0.getName().getId();
			
			throw new UnsolvedSymbolException(id);
		}
		if (!P_0.getTypeArguments().isPresent())
		{
			ReferenceTypeImpl.___003Cclinit_003E();
			ReferenceTypeImpl result = new ReferenceTypeImpl(((ResolvedTypeDeclaration)symbolReference.getCorrespondingDeclaration()).asReferenceType(), typeSolver);
			
			return result;
		}
		List typeArguments = (List)((NodeList)P_0.getTypeArguments().get()).stream().map(new ___003C_003EAnon4(this)).collect(Collectors.toList());
		ReferenceTypeImpl.___003Cclinit_003E();
		ReferenceTypeImpl result2 = new ReferenceTypeImpl(((ResolvedTypeDeclaration)symbolReference.getCorrespondingDeclaration()).asReferenceType(), typeArguments, typeSolver);
		
		return result2;
	}

	
	
	public override string getQualifiedName()
	{
		string qualifiedName = javaParserTypeAdapter.getQualifiedName();
		
		return qualifiedName;
	}

	
		
	public override Optional getSuperClass()
	{
		if (isJavaLangObject())
		{
			Optional result = Optional.empty();
			
			return result;
		}
		if (wrappedNode.getExtendedTypes().isEmpty())
		{
			Optional result2 = Optional.of(@object());
			
			return result2;
		}
		Optional result3 = Optional.of(toReferenceType((ClassOrInterfaceType)wrappedNode.getExtendedTypes().getFirst().get()));
		
		return result3;
	}

	
	
	public JavaParserClassDeclaration(ClassOrInterfaceDeclaration wrappedNode, TypeSolver typeSolver)
	{
		if (wrappedNode.isInterface())
		{
			
			throw new IllegalArgumentException("Interface given");
		}
		this.wrappedNode = wrappedNode;
		this.typeSolver = typeSolver;
		javaParserTypeAdapter = new JavaParserTypeAdapter(wrappedNode, typeSolver);
	}

	
	
	private bool isAncestor(ResolvedReferenceType P_0, string P_1)
	{
		Optional typeDeclaration = P_0.getTypeDeclaration();
		if (typeDeclaration.isPresent())
		{
			ResolvedTypeDeclaration resolvedTypeDeclaration = ((ResolvedReferenceTypeDeclaration)typeDeclaration.get()).asType();
			return (!resolvedTypeDeclaration.hasInternalType(P_1)) ? true : false;
		}
		return false;
	}

	
	
	
	private static bool lambda_0024getAllFields_00240(ResolvedReferenceType P_0)
	{
		bool result = P_0.getTypeDeclaration().isPresent();
		
		return result;
	}

	
	
	
	private void lambda_0024getAllFields_00242(List P_0, ResolvedReferenceType P_1)
	{
		((ResolvedReferenceTypeDeclaration)P_1.getTypeDeclaration().get()).getAllFields().forEach(new ___003C_003EAnon6(this, P_0, P_1));
	}

	
	
	
	private static RuntimeException lambda_0024solveType_00243()
	{
		RuntimeException result = new RuntimeException("Parent context unexpectedly empty.");
		
		return result;
	}

	
	
	
	private JavaParserTypeParameter lambda_0024getTypeParameters_00244(TypeParameter P_0)
	{
		JavaParserTypeParameter result = new JavaParserTypeParameter(P_0, typeSolver);
		
		return result;
	}

	
	
	
	private LazyType lambda_0024toReferenceType_00246(com.github.javaparser.ast.type.Type P_0)
	{
		LazyType result = new LazyType(new ___003C_003EAnon5(this, P_0));
		
		return result;
	}

	
	
	
	private ResolvedType lambda_0024null_00245(com.github.javaparser.ast.type.Type P_0, java.lang.Void P_1)
	{
		ResolvedType result = JavaParserFacade.get(typeSolver).convert(P_0, P_0);
		
		return result;
	}

	
	
	
	private void lambda_0024null_00241(List P_0, ResolvedReferenceType P_1, ResolvedFieldDeclaration P_2)
	{
		P_0.add(new _1(this, P_2, P_1));
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
		JavaParserClassDeclaration javaParserClassDeclaration = (JavaParserClassDeclaration)o;
		bool result = wrappedNode.equals(javaParserClassDeclaration.wrappedNode);
		
		return result;
	}

	
	
	public override int GetHashCode()
	{
		int result = wrappedNode.GetHashCode();
		
		return result;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("JavaParserClassDeclaration{wrappedNode=").append(wrappedNode).append('}')
			.ToString();
		
		return result;
	}

	
		
	public override List getAllFields()
	{
		List fieldsForDeclaredVariables = javaParserTypeAdapter.getFieldsForDeclaredVariables();
		getAncestors(acceptIncompleteList: true).stream().filter(new ___003C_003EAnon0()).forEach(new ___003C_003EAnon1(this, fieldsForDeclaredVariables));
		return fieldsForDeclaredVariables;
	}

	
		
	public virtual SymbolReference solveMethod(string name, List parameterTypes)
	{
		Context context = getContext();
		SymbolReference result = context.solveMethod(name, parameterTypes, staticOnly: false);
		
		return result;
	}

	
		
	public virtual Optional solveMethodAsUsage(string name, List argumentTypes, Context invocationContext, List typeParameters)
	{
		Optional result = getContext().solveMethodAsUsage(name, argumentTypes);
		
		return result;
	}

	
	
	public virtual ResolvedType getUsage(Node node)
	{
		
		throw new UnsupportedOperationException();
	}

	
	
	public override string getName()
	{
		string id = wrappedNode.getName().getId();
		
		return id;
	}

	
		
	public override List getInterfaces()
	{
		ArrayList arrayList = new ArrayList();
		if (wrappedNode.getImplementedTypes() != null)
		{
			Iterator iterator = wrappedNode.getImplementedTypes().iterator();
			while (iterator.hasNext())
			{
				ClassOrInterfaceType classOrInterfaceType = (ClassOrInterfaceType)iterator.next();
				((List)arrayList).add((object)toReferenceType(classOrInterfaceType));
			}
		}
		return arrayList;
	}

	
		
	public override List getConstructors()
	{
		List constructors = AstResolutionUtils.getConstructors(wrappedNode, typeSolver, this);
		
		return constructors;
	}

	
	
	public override bool hasDirectlyAnnotation(string canonicalName)
	{
		bool result = AstResolutionUtils.hasDirectlyAnnotation(wrappedNode, typeSolver, canonicalName);
		
		return result;
	}

	
	
	public override bool isInterface()
	{
		bool result = wrappedNode.isInterface();
		
		return result;
	}

	
	
	public override string getPackageName()
	{
		string packageName = javaParserTypeAdapter.getPackageName();
		
		return packageName;
	}

	
	
	public override string getClassName()
	{
		string className = javaParserTypeAdapter.getClassName();
		
		return className;
	}

	
	
	public override bool isAssignableBy(ResolvedReferenceTypeDeclaration other)
	{
		bool result = javaParserTypeAdapter.isAssignableBy(other);
		
		return result;
	}

	
	
	public override bool isAssignableBy(ResolvedType type)
	{
		bool result = javaParserTypeAdapter.isAssignableBy(type);
		
		return result;
	}

	
	[LineNumberTable(new byte[]
	{
		160, 153, 115, 162, 103, 104, 113, 104, 108, 108,
		110, 226, 71, 109, 127, 7, 121, 106, 130, 162
	})]
	public override bool canBeAssignedTo(ResolvedReferenceTypeDeclaration other)
	{
		if (java.lang.String.instancehelper_equals(getQualifiedName(), other.getQualifiedName()))
		{
			return true;
		}
		Optional superClass = getSuperClass();
		if (superClass.isPresent())
		{
			Optional typeDeclaration = ((ResolvedReferenceType)superClass.get()).getTypeDeclaration();
			if (typeDeclaration.isPresent())
			{
				ResolvedReferenceTypeDeclaration resolvedReferenceTypeDeclaration = (ResolvedReferenceTypeDeclaration)typeDeclaration.get();
				if (resolvedReferenceTypeDeclaration != this && resolvedReferenceTypeDeclaration.isClass() && resolvedReferenceTypeDeclaration.asClass().canBeAssignedTo(other))
				{
					return true;
				}
			}
		}
		if (wrappedNode.getImplementedTypes() != null)
		{
			Iterator iterator = wrappedNode.getImplementedTypes().iterator();
			while (iterator.hasNext())
			{
				ClassOrInterfaceType type = (ClassOrInterfaceType)iterator.next();
				ResolvedReferenceTypeDeclaration resolvedReferenceTypeDeclaration2 = (ResolvedReferenceTypeDeclaration)new SymbolSolver(typeSolver).solveType(type);
				if (resolvedReferenceTypeDeclaration2.canBeAssignedTo(other))
				{
					return true;
				}
			}
		}
		return false;
	}

	public override bool isTypeParameter()
	{
		return false;
	}

	
		
	public override SymbolReference solveMethod(string name, List argumentsTypes, bool staticOnly)
	{
		SymbolReference result = getContext().solveMethod(name, argumentsTypes, staticOnly);
		
		return result;
	}

	
		
	public override Set getDeclaredMethods()
	{
		HashSet hashSet = new HashSet();
		Iterator iterator = wrappedNode.getMembers().iterator();
		while (iterator.hasNext())
		{
			BodyDeclaration bodyDeclaration = (BodyDeclaration)iterator.next();
			if (bodyDeclaration is MethodDeclaration)
			{
				((Set)hashSet).add((object)new JavaParserMethodDeclaration((MethodDeclaration)bodyDeclaration, typeSolver));
			}
		}
		return hashSet;
	}

	
		
	public override List getTypeParameters()
	{
		return (List)wrappedNode.getTypeParameters().stream().map(new ___003C_003EAnon3(this))
			.collect(Collectors.toList());
	}

	public virtual ClassOrInterfaceDeclaration getWrappedNode()
	{
		return wrappedNode;
	}

	
	
	public override AccessSpecifier accessSpecifier()
	{
		AccessSpecifier result = wrappedNode.getAccessSpecifier();
		
		return result;
	}

	
		
	public override Optional toAst()
	{
		Optional result = Optional.of(wrappedNode);
		
		return result;
	}

	
		
	public override Set internalTypes()
	{
		Set result = javaParserTypeAdapter.internalTypes();
		
		return result;
	}

	
		
	public override Optional containerType()
	{
		Optional result = javaParserTypeAdapter.containerType();
		
		return result;
	}
}
