using System;

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

using IKVM.Runtime;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.symbolsolver.javaparsermodel.declarations;


public class JavaParserInterfaceDeclaration : AbstractTypeDeclaration, ResolvedInterfaceDeclaration, ResolvedReferenceTypeDeclaration, ResolvedTypeDeclaration, ResolvedDeclaration, ResolvedTypeParametrizable, HasAccessSpecifier, AssociableToAST, MethodResolutionCapability, MethodUsageResolutionCapability
{
	
	[EnclosingMethod(null, "lambda$null$1", "(Ljava.util.List;Lcom.github.javaparser.resolution.types.ResolvedReferenceType;Lcom.github.javaparser.resolution.declarations.ResolvedFieldDeclaration;)V")]
	
	internal class _1 :  ResolvedFieldDeclaration, ResolvedValueDeclaration, ResolvedDeclaration, HasAccessSpecifier, AssociableToAST
	{
		
		internal ResolvedFieldDeclaration val_0024f;

		
		internal ResolvedReferenceType val_0024ancestor;

		
		internal JavaParserInterfaceDeclaration this_00240;

		
		
		internal _1(JavaParserInterfaceDeclaration P_0, ResolvedFieldDeclaration P_1, ResolvedReferenceType P_2)
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
		private readonly JavaParserInterfaceDeclaration arg_00241;

		private readonly List arg_00242;

		internal ___003C_003EAnon1(JavaParserInterfaceDeclaration P_0, List P_1)
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
		private readonly JavaParserInterfaceDeclaration arg_00241;

		internal ___003C_003EAnon3(JavaParserInterfaceDeclaration P_0)
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
		private readonly JavaParserInterfaceDeclaration arg_00241;

		internal ___003C_003EAnon4(JavaParserInterfaceDeclaration P_0)
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
		private readonly JavaParserInterfaceDeclaration arg_00241;

		private readonly com.github.javaparser.ast.type.Type arg_00242;

		internal ___003C_003EAnon5(JavaParserInterfaceDeclaration P_0, com.github.javaparser.ast.type.Type P_1)
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
		private readonly JavaParserInterfaceDeclaration arg_00241;

		private readonly List arg_00242;

		private readonly ResolvedReferenceType arg_00243;

		internal ___003C_003EAnon6(JavaParserInterfaceDeclaration P_0, List P_1, ResolvedReferenceType P_2)
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
			SymbolReference result2 = new JavaParserInterfaceDeclaration(wrappedNode, typeSolver).solveType(java.lang.String.instancehelper_substring(name, java.lang.String.instancehelper_length(text)));
			
			return result2;
		}
		SymbolReference result3 = ((Context)getContext().getParent().orElseThrow(new ___003C_003EAnon2())).solveType(name);
		
		return result3;
	}

	
	
	public override string getQualifiedName()
	{
		string qualifiedName = javaParserTypeAdapter.getQualifiedName();
		
		return qualifiedName;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override List getAncestors()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetAncestors(this);
	}

	
	
	public JavaParserInterfaceDeclaration(ClassOrInterfaceDeclaration wrappedNode, TypeSolver typeSolver)
	{
		if (!wrappedNode.isInterface())
		{
			
			throw new IllegalArgumentException();
		}
		this.wrappedNode = wrappedNode;
		this.typeSolver = typeSolver;
		javaParserTypeAdapter = new JavaParserTypeAdapter(wrappedNode, typeSolver);
	}

	
	
	public virtual Context getContext()
	{
		Context context = JavaParserFactory.getContext(wrappedNode, typeSolver);
		
		return context;
	}

	
	
	private ResolvedReferenceType toReferenceType(ClassOrInterfaceType P_0)
	{
		SymbolReference symbolReference = null;
		string text = P_0.getName().getId();
		if (P_0.getScope().isPresent())
		{
			text = new StringBuilder().append(((ClassOrInterfaceType)P_0.getScope().get()).asString()).append(".").append(text)
				.ToString();
		}
		if (java.lang.String.instancehelper_indexOf(text, 46) > -1)
		{
			symbolReference = typeSolver.tryToSolveType(text);
		}
		if (symbolReference == null || !symbolReference.isSolved())
		{
			symbolReference = solveType(text);
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

	
	
	public virtual ResolvedType getUsage(Node node)
	{
		
		throw new UnsupportedOperationException();
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
		JavaParserInterfaceDeclaration javaParserInterfaceDeclaration = (JavaParserInterfaceDeclaration)o;
		if (!wrappedNode.equals(javaParserInterfaceDeclaration.wrappedNode))
		{
			return false;
		}
		return true;
	}

	
	
	public override int GetHashCode()
	{
		int result = wrappedNode.GetHashCode();
		
		return result;
	}

	
	
	public override string getName()
	{
		string id = wrappedNode.getName().getId();
		
		return id;
	}

	public override ResolvedInterfaceDeclaration asInterface()
	{
		return this;
	}

	
	
	public override bool hasDirectlyAnnotation(string canonicalName)
	{
		bool result = AstResolutionUtils.hasDirectlyAnnotation(wrappedNode, typeSolver, canonicalName);
		
		return result;
	}

	public override bool isInterface()
	{
		return true;
	}

	
		
	public virtual List getInterfacesExtended()
	{
		ArrayList arrayList = new ArrayList();
		Iterator iterator = wrappedNode.getExtendedTypes().iterator();
		while (iterator.hasNext())
		{
			ClassOrInterfaceType classOrInterfaceType = (ClassOrInterfaceType)iterator.next();
			ReferenceTypeImpl.___003Cclinit_003E();
			((List)arrayList).add((object)new ReferenceTypeImpl(((ResolvedTypeDeclaration)solveType(classOrInterfaceType.getName().getId()).getCorrespondingDeclaration()).asInterface(), typeSolver));
		}
		return arrayList;
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

	
	
	public override bool canBeAssignedTo(ResolvedReferenceTypeDeclaration other)
	{
		if (java.lang.String.instancehelper_equals(getQualifiedName(), other.getQualifiedName()))
		{
			return true;
		}
		if (wrappedNode.getExtendedTypes() != null)
		{
			Iterator iterator = wrappedNode.getExtendedTypes().iterator();
			while (iterator.hasNext())
			{
				ClassOrInterfaceType type = (ClassOrInterfaceType)iterator.next();
				ResolvedReferenceTypeDeclaration resolvedReferenceTypeDeclaration = (ResolvedReferenceTypeDeclaration)new SymbolSolver(typeSolver).solveType(type);
				if (resolvedReferenceTypeDeclaration.canBeAssignedTo(other))
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
				ResolvedReferenceTypeDeclaration resolvedReferenceTypeDeclaration = (ResolvedReferenceTypeDeclaration)new SymbolSolver(typeSolver).solveType(type);
				if (resolvedReferenceTypeDeclaration.canBeAssignedTo(other))
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

	
		
	public override List getAllFields()
	{
		List fieldsForDeclaredVariables = javaParserTypeAdapter.getFieldsForDeclaredVariables();
		getAncestors().stream().filter(new ___003C_003EAnon0()).forEach(new ___003C_003EAnon1(this, fieldsForDeclaredVariables));
		return fieldsForDeclaredVariables;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("JavaParserInterfaceDeclaration{wrappedNode=").append(wrappedNode).append('}')
			.ToString();
		
		return result;
	}

	
		
	public virtual SymbolReference solveMethod(string name, List argumentsTypes, bool staticOnly)
	{
		SymbolReference result = getContext().solveMethod(name, argumentsTypes, staticOnly);
		
		return result;
	}

	
		
	public virtual Optional solveMethodAsUsage(string name, List argumentTypes, Context invocationContext, List typeParameters)
	{
		Optional result = getContext().solveMethodAsUsage(name, argumentTypes);
		
		return result;
	}

	
		
	public override List getAncestors(bool acceptIncompleteList)
	{
		ArrayList arrayList = new ArrayList();
		if (wrappedNode.getExtendedTypes() != null)
		{
			Iterator iterator = wrappedNode.getExtendedTypes().iterator();
			while (iterator.hasNext())
			{
				ClassOrInterfaceType classOrInterfaceType = (ClassOrInterfaceType)iterator.next();
				UnsolvedSymbolException ex;
				try
				{
					((List)arrayList).add((object)toReferenceType(classOrInterfaceType));
				}
				catch (UnsolvedSymbolException x)
				{
					ex = ByteCodeHelper.MapException<UnsolvedSymbolException>(x, ByteCodeHelper.MapFlags.NoRemapping);
					goto IL_005b;
				}
				continue;
				IL_005b:
				UnsolvedSymbolException ex2 = ex;
				if (!acceptIncompleteList)
				{
					throw ex2;
				}
			}
		}
		if (wrappedNode.getImplementedTypes() != null)
		{
			Iterator iterator = wrappedNode.getImplementedTypes().iterator();
			while (iterator.hasNext())
			{
				ClassOrInterfaceType classOrInterfaceType = (ClassOrInterfaceType)iterator.next();
				UnsolvedSymbolException ex3;
				try
				{
					((List)arrayList).add((object)toReferenceType(classOrInterfaceType));
				}
				catch (UnsolvedSymbolException x2)
				{
					ex3 = ByteCodeHelper.MapException<UnsolvedSymbolException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
					goto IL_00c3;
				}
				continue;
				IL_00c3:
				UnsolvedSymbolException ex2 = ex3;
				if (!acceptIncompleteList)
				{
					throw ex2;
				}
			}
		}
		return arrayList;
	}

	
		
	public override List getTypeParameters()
	{
		if (wrappedNode.getTypeParameters() == null)
		{
			List result = Collections.emptyList();
			
			return result;
		}
		return (List)wrappedNode.getTypeParameters().stream().map(new ___003C_003EAnon3(this))
			.collect(Collectors.toList());
	}

	public virtual ClassOrInterfaceDeclaration getWrappedNode()
	{
		return wrappedNode;
	}

	
	
	public virtual AccessSpecifier accessSpecifier()
	{
		AccessSpecifier result = wrappedNode.getAccessSpecifier();
		
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

	
		
	public override List getConstructors()
	{
		List result = Collections.emptyList();
		
		return result;
	}

	
		
	public virtual Optional toAst()
	{
		Optional result = Optional.of(wrappedNode);
		
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool hasName()
	{
		return ResolvedDeclaration._003Cdefault_003EhasName(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isField()
	{
		return ResolvedDeclaration._003Cdefault_003EisField(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isVariable()
	{
		return ResolvedDeclaration._003Cdefault_003EisVariable(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isEnumConstant()
	{
		return ResolvedDeclaration._003Cdefault_003EisEnumConstant(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isPattern()
	{
		return ResolvedDeclaration._003Cdefault_003EisPattern(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isParameter()
	{
		return ResolvedDeclaration._003Cdefault_003EisParameter(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isType()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EisType(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isMethod()
	{
		return ResolvedDeclaration._003Cdefault_003EisMethod(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedFieldDeclaration asField()
	{
		return ResolvedDeclaration._003Cdefault_003EasField(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedParameterDeclaration asParameter()
	{
		return ResolvedDeclaration._003Cdefault_003EasParameter(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedTypeDeclaration asType()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EasType(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedMethodDeclaration asMethod()
	{
		return ResolvedDeclaration._003Cdefault_003EasMethod(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedEnumConstantDeclaration asEnumConstant()
	{
		return ResolvedDeclaration._003Cdefault_003EasEnumConstant(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedPatternDeclaration asPattern()
	{
		return ResolvedDeclaration._003Cdefault_003EasPattern(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedReferenceTypeDeclaration getInternalType(string P_0)
	{
		return ResolvedTypeDeclaration._003Cdefault_003EgetInternalType(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool hasInternalType(string P_0)
	{
		return ResolvedTypeDeclaration._003Cdefault_003EhasInternalType(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isClass()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EisClass(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isEnum()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EisEnum(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isAnnotation()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EisAnnotation(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isAnonymousClass()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EisAnonymousClass(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedClassDeclaration asClass()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EasClass(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedEnumDeclaration asEnum()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EasEnum(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedAnnotationDeclaration asAnnotation()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EasAnnotation(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedTypeParameterDeclaration asTypeParameter()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EasTypeParameter(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedReferenceTypeDeclaration asReferenceType()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EasReferenceType(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override string getId()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EgetId(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Optional findTypeParameter(string P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EfindTypeParameter(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isGeneric()
	{
		return ResolvedTypeParametrizable._003Cdefault_003EisGeneric(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override List getAllAncestors()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetAllAncestors(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override List getAllAncestors(Function P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetAllAncestors(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedFieldDeclaration getField(string P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetField(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedFieldDeclaration getVisibleField(string P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetVisibleField(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool hasField(string P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EhasField(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool hasVisibleField(string P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EhasVisibleField(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override List getVisibleFields()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetVisibleFields(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override List getAllNonStaticFields()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetAllNonStaticFields(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override List getAllStaticFields()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetAllStaticFields(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override List getDeclaredFields()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetDeclaredFields(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool hasAnnotation(string P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EhasAnnotation(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isJavaLangObject()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EisJavaLangObject(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isJavaLangEnum()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EisJavaLangEnum(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual List getAllInterfacesExtended()
	{
		return ResolvedInterfaceDeclaration._003Cdefault_003EgetAllInterfacesExtended(this);
	}
}
