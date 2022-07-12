using System.ComponentModel;

using com.github.javaparser.ast.comments;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.nodeTypes.modifiers;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.type;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.javadoc;
using com.github.javaparser.metamodel;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.utils;

using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.ast.body;


public abstract class TypeDeclaration : BodyDeclaration, NodeWithSimpleName, NodeWithJavadoc, NodeWithMembers, NodeWithAccessModifiers, NodeWithPublicModifier, NodeWithModifiers, NodeWithPrivateModifier, NodeWithProtectedModifier, NodeWithStaticModifier, NodeWithStrictfpModifier
{
	
	private sealed class ___003C_003EAnon0 : Function
	{
		internal ___003C_003EAnon0()
		{
		}

		public object apply(object P_0)
		{
			Boolean result = lambda_0024isTopLevelType_00240((Node)P_0);
			
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
		internal ___003C_003EAnon1()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024getCallablesWithSignature_00241((BodyDeclaration)P_0);
			
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
			CallableDeclaration result = lambda_0024getCallablesWithSignature_00242((BodyDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon3 : Predicate
	{
		private readonly CallableDeclaration.Signature arg_00241;

		internal ___003C_003EAnon3(CallableDeclaration.Signature P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024getCallablesWithSignature_00243(arg_00241, (CallableDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon4 : Function
	{
		private readonly TypeDeclaration arg_00241;

		internal ___003C_003EAnon4(TypeDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			string result = arg_00241.lambda_0024getFullyQualifiedName_00246((CompilationUnit)P_0);
			
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
		internal ___003C_003EAnon5()
		{
		}

		public object apply(object P_0)
		{
			TypeDeclaration result = lambda_0024getFullyQualifiedName_00247((TypeDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon6 : Function
	{
		private readonly TypeDeclaration arg_00241;

		internal ___003C_003EAnon6(TypeDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			Optional result = arg_00241.lambda_0024getFullyQualifiedName_00249((TypeDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon7 : Function
	{
		internal ___003C_003EAnon7()
		{
		}

		public object apply(object P_0)
		{
			Boolean result = lambda_0024isNestedType_002410((Node)P_0);
			
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

	
	private sealed class ___003C_003EAnon8 : Function
	{
		private readonly TypeDeclaration arg_00241;

		internal ___003C_003EAnon8(TypeDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			string result = arg_00241.lambda_0024null_00248((string)P_0);
			
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
		internal ___003C_003EAnon9()
		{
		}

		public object apply(object P_0)
		{
			string result = lambda_0024null_00244((PackageDeclaration)P_0);
			
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
		private readonly TypeDeclaration arg_00241;

		internal ___003C_003EAnon10(TypeDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			string result = arg_00241.lambda_0024null_00245((string)P_0);
			
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

	private SimpleName name;

		private NodeList modifiers;

		private NodeList members;

	
	
	protected internal new static void ___003Cclinit_003E()
	{
	}

	
		
	
	public virtual List getCallablesWithSignature(CallableDeclaration.Signature signature)
	{
		return (List)getMembers().stream().filter(new ___003C_003EAnon1()).map(new ___003C_003EAnon2())
			.filter(new ___003C_003EAnon3(signature))
			.collect(Collectors.toList());
	}


	public virtual string getNameAsString()
	{
		return NodeWithSimpleName._003Cdefault_003EgetNameAsString(this);
	}

		public virtual NodeList getMembers()
	{
		return members;
	}

	
	
	
	public override bool remove(Node node)
	{
		if (node == null)
		{
			return false;
		}
		for (int i = 0; i < members.size(); i++)
		{
			if (members.get(i) == node)
			{
				members.remove(i);
				return true;
			}
		}
		for (int i = 0; i < modifiers.size(); i++)
		{
			if (modifiers.get(i) == node)
			{
				modifiers.remove(i);
				return true;
			}
		}
		bool result = base.remove(node);
		
		return result;
	}

	
		
	
	public virtual TypeDeclaration addMember(BodyDeclaration decl)
	{
		NodeList nodeList = getMembers();
		nodeList.add(decl);
		return this;
	}


	public virtual Node setPublic(bool P_0)
	{
		return NodeWithPublicModifier._003Cdefault_003EsetPublic(this, P_0);
	}


	public virtual List getMethods()
	{
		return NodeWithMembers._003Cdefault_003EgetMethods(this);
	}


	public virtual MethodDeclaration addMethod(string P_0, Modifier.Keyword[] P_1)
	{
		return NodeWithMembers._003Cdefault_003EaddMethod(this, P_0, P_1);
	}

	
		
	
	public TypeDeclaration(TokenRange tokenRange, NodeList modifiers, NodeList annotations, SimpleName name, NodeList members)
		: base(tokenRange, annotations)
	{
		setModifiers(modifiers);
		setName(name);
		setMembers(members);
		customInitialization();
	}

	
		
	
	public virtual TypeDeclaration setModifiers(NodeList modifiers)
	{
		Utils.assertNotNull(modifiers);
		if (modifiers == this.modifiers)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EMODIFIERS, this.modifiers, modifiers);
		if (this.modifiers != null)
		{
			this.modifiers.setParentNode(null);
		}
		this.modifiers = modifiers;
		setAsParentNodeOf(modifiers);
		return this;
	}

	
		
	
	public virtual TypeDeclaration setName(SimpleName name)
	{
		Utils.assertNotNull(name);
		if (name == this.name)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ENAME, this.name, name);
		if (this.name != null)
		{
			this.name.setParentNode(null);
		}
		this.name = name;
		setAsParentNodeOf(name);
		return this;
	}

	
		
	
	public virtual TypeDeclaration setMembers(NodeList members)
	{
		Utils.assertNotNull(members);
		if (members == this.members)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EMEMBERS, this.members, members);
		if (this.members != null)
		{
			this.members.setParentNode(null);
		}
		this.members = members;
		setAsParentNodeOf(members);
		return this;
	}

	
	
	public virtual bool isTopLevelType()
	{
		bool result = ((Boolean)getParentNode().map(new ___003C_003EAnon0()).orElse(Boolean.valueOf(b: false))).booleanValue();
		
		return result;
	}

	
	
	public new virtual TypeDeclarationMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EtypeDeclarationMetaModel;
	}

	
		
	public new virtual TypeDeclaration clone()
	{
		return (TypeDeclaration)accept(new CloneVisitor(), null);
	}

	
		
	public virtual Optional getFullyQualifiedName()
	{
		if (isTopLevelType())
		{
			Optional result = findCompilationUnit().map(new ___003C_003EAnon4(this));
			
			return result;
		}
		Optional result2 = findAncestor(new Class[1] { ClassLiteral<TypeDeclaration>.Value }).map(new ___003C_003EAnon5()).flatMap(new ___003C_003EAnon6(this));
		
		return result2;
	}

	
	
	
	
	private static Boolean lambda_0024isTopLevelType_00240(Node p)
	{
		Boolean result = Boolean.valueOf(p is CompilationUnit);
		
		return result;
	}

	
	
	
	private static bool lambda_0024getCallablesWithSignature_00241(BodyDeclaration m)
	{
		return m is CallableDeclaration;
	}

	
	
	
	private static CallableDeclaration lambda_0024getCallablesWithSignature_00242(BodyDeclaration m)
	{
		return (CallableDeclaration)m;
	}

	
	
	
	
	private static bool lambda_0024getCallablesWithSignature_00243(CallableDeclaration.Signature signature, CallableDeclaration m)
	{
		bool result = m.getSignature().equals(signature);
		
		return result;
	}

	
	
	
	
	private string lambda_0024getFullyQualifiedName_00246(CompilationUnit cu)
	{
		return (string)cu.getPackageDeclaration().map(new ___003C_003EAnon9()).map(new ___003C_003EAnon10(this))
			.orElse(getNameAsString());
	}

	
	
	private static TypeDeclaration lambda_0024getFullyQualifiedName_00247(TypeDeclaration td)
	{
		return td;
	}

	
	
	
	
	private Optional lambda_0024getFullyQualifiedName_00249(TypeDeclaration td)
	{
		Optional result = td.getFullyQualifiedName().map(new ___003C_003EAnon8(this));
		
		return result;
	}

	
	
	
	
	private static Boolean lambda_0024isNestedType_002410(Node p)
	{
		Boolean result = Boolean.valueOf(p is TypeDeclaration);
		
		return result;
	}

	
	
	
	
	private string lambda_0024null_00248(string fqn)
	{
		string result = new StringBuilder().append(fqn).append(".").append(getNameAsString())
			.ToString();
		
		return result;
	}

	
	
	
	
	private static string lambda_0024null_00244(PackageDeclaration pd)
	{
		string nameAsString = pd.getNameAsString();
		
		return nameAsString;
	}

	
	
	
	
	private string lambda_0024null_00245(string pkg)
	{
		string result = new StringBuilder().append(pkg).append(".").append(getNameAsString())
			.ToString();
		
		return result;
	}

	
	
	public TypeDeclaration()
		: this(null, new NodeList(), new NodeList(), new SimpleName(), new NodeList())
	{
	}

	
		
	
	public TypeDeclaration(NodeList modifiers, string name)
		: this(null, modifiers, new NodeList(), new SimpleName(name), new NodeList())
	{
	}

	
		
	
	
	public TypeDeclaration(NodeList modifiers, NodeList annotations, SimpleName name, NodeList members)
		: this(null, modifiers, annotations, name, members)
	{
	}

		public virtual NodeList getModifiers()
	{
		return modifiers;
	}

	public virtual SimpleName getName()
	{
		return name;
	}

	
	
	public virtual bool isNestedType()
	{
		bool result = ((Boolean)getParentNode().map(new ___003C_003EAnon7()).orElse(Boolean.valueOf(b: false))).booleanValue();
		
		return result;
	}

	
	
	
	public override bool replace(Node node, Node replacementNode)
	{
		if (node == null)
		{
			return false;
		}
		for (int i = 0; i < members.size(); i++)
		{
			if (members.get(i) == node)
			{
				members.set(i, (BodyDeclaration)replacementNode);
				return true;
			}
		}
		for (int i = 0; i < modifiers.size(); i++)
		{
			if (modifiers.get(i) == node)
			{
				modifiers.set(i, (Modifier)replacementNode);
				return true;
			}
		}
		if (node == name)
		{
			setName((SimpleName)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isTypeDeclaration()
	{
		return true;
	}

	public override TypeDeclaration asTypeDeclaration()
	{
		return this;
	}

	
		
	
	public override void ifTypeDeclaration(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toTypeDeclaration()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	public abstract ResolvedReferenceTypeDeclaration resolve();

	
	
	
	
	public new virtual BodyDeclarationMetaModel _003Cbridge_003EgetMetaModel()
	{
		TypeDeclarationMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual BodyDeclaration _003Cbridge_003Eclone()
	{
		TypeDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		TypeDeclarationMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		TypeDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		TypeDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetName(SimpleName name)
	{
		TypeDeclaration result = setName(name);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetMembers(NodeList members)
	{
		TypeDeclaration result = setMembers(members);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EaddMember(BodyDeclaration decl)
	{
		TypeDeclaration result = addMember(decl);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetModifiers(NodeList modifiers)
	{
		TypeDeclaration result = setModifiers(modifiers);
		
		return result;
	}


	public virtual Node setName(string P_0)
	{
		return NodeWithSimpleName._003Cdefault_003EsetName(this, P_0);
	}


	public virtual NameExpr getNameAsExpression()
	{
		return NodeWithSimpleName._003Cdefault_003EgetNameAsExpression(this);
	}


	public virtual Optional getJavadocComment()
	{
		return NodeWithJavadoc._003Cdefault_003EgetJavadocComment(this);
	}


	public virtual Optional getJavadoc()
	{
		return NodeWithJavadoc._003Cdefault_003EgetJavadoc(this);
	}


	public virtual Node setJavadocComment(string P_0)
	{
		return NodeWithJavadoc._003Cdefault_003EsetJavadocComment(this, P_0);
	}


	public virtual Node setJavadocComment(JavadocComment P_0)
	{
		return NodeWithJavadoc._003Cdefault_003EsetJavadocComment(this, P_0);
	}


	public virtual Node setJavadocComment(string P_0, Javadoc P_1)
	{
		return NodeWithJavadoc._003Cdefault_003EsetJavadocComment(this, P_0, P_1);
	}


	public virtual Node setJavadocComment(Javadoc P_0)
	{
		return NodeWithJavadoc._003Cdefault_003EsetJavadocComment(this, P_0);
	}


	public virtual bool removeJavaDocComment()
	{
		return NodeWithJavadoc._003Cdefault_003EremoveJavaDocComment(this);
	}


	public virtual bool hasJavaDocComment()
	{
		return NodeWithJavadoc._003Cdefault_003EhasJavaDocComment(this);
	}


	public virtual BodyDeclaration getMember(int P_0)
	{
		return NodeWithMembers._003Cdefault_003EgetMember(this, P_0);
	}


	public virtual Node setMember(int P_0, BodyDeclaration P_1)
	{
		return NodeWithMembers._003Cdefault_003EsetMember(this, P_0, P_1);
	}


	public virtual FieldDeclaration addField(Class P_0, string P_1, Modifier.Keyword[] P_2)
	{
		return NodeWithMembers._003Cdefault_003EaddField(this, P_0, P_1, P_2);
	}


	public virtual FieldDeclaration addField(string P_0, string P_1, Modifier.Keyword[] P_2)
	{
		return NodeWithMembers._003Cdefault_003EaddField(this, P_0, P_1, P_2);
	}


	public virtual FieldDeclaration addField(Type P_0, string P_1, Modifier.Keyword[] P_2)
	{
		return NodeWithMembers._003Cdefault_003EaddField(this, P_0, P_1, P_2);
	}


	public virtual FieldDeclaration addFieldWithInitializer(Class P_0, string P_1, Expression P_2, Modifier.Keyword[] P_3)
	{
		return NodeWithMembers._003Cdefault_003EaddFieldWithInitializer(this, P_0, P_1, P_2, P_3);
	}


	public virtual FieldDeclaration addFieldWithInitializer(string P_0, string P_1, Expression P_2, Modifier.Keyword[] P_3)
	{
		return NodeWithMembers._003Cdefault_003EaddFieldWithInitializer(this, P_0, P_1, P_2, P_3);
	}


	public virtual FieldDeclaration addFieldWithInitializer(Type P_0, string P_1, Expression P_2, Modifier.Keyword[] P_3)
	{
		return NodeWithMembers._003Cdefault_003EaddFieldWithInitializer(this, P_0, P_1, P_2, P_3);
	}


	public virtual FieldDeclaration addPrivateField(Class P_0, string P_1)
	{
		return NodeWithMembers._003Cdefault_003EaddPrivateField(this, P_0, P_1);
	}


	public virtual FieldDeclaration addPrivateField(string P_0, string P_1)
	{
		return NodeWithMembers._003Cdefault_003EaddPrivateField(this, P_0, P_1);
	}


	public virtual FieldDeclaration addPrivateField(Type P_0, string P_1)
	{
		return NodeWithMembers._003Cdefault_003EaddPrivateField(this, P_0, P_1);
	}


	public virtual FieldDeclaration addPublicField(Class P_0, string P_1)
	{
		return NodeWithMembers._003Cdefault_003EaddPublicField(this, P_0, P_1);
	}


	public virtual FieldDeclaration addPublicField(string P_0, string P_1)
	{
		return NodeWithMembers._003Cdefault_003EaddPublicField(this, P_0, P_1);
	}


	public virtual FieldDeclaration addPublicField(Type P_0, string P_1)
	{
		return NodeWithMembers._003Cdefault_003EaddPublicField(this, P_0, P_1);
	}


	public virtual FieldDeclaration addProtectedField(Class P_0, string P_1)
	{
		return NodeWithMembers._003Cdefault_003EaddProtectedField(this, P_0, P_1);
	}


	public virtual FieldDeclaration addProtectedField(string P_0, string P_1)
	{
		return NodeWithMembers._003Cdefault_003EaddProtectedField(this, P_0, P_1);
	}


	public virtual FieldDeclaration addProtectedField(Type P_0, string P_1)
	{
		return NodeWithMembers._003Cdefault_003EaddProtectedField(this, P_0, P_1);
	}


	public virtual ConstructorDeclaration addConstructor(Modifier.Keyword[] P_0)
	{
		return NodeWithMembers._003Cdefault_003EaddConstructor(this, P_0);
	}


	public virtual BlockStmt addInitializer()
	{
		return NodeWithMembers._003Cdefault_003EaddInitializer(this);
	}


	public virtual BlockStmt addStaticInitializer()
	{
		return NodeWithMembers._003Cdefault_003EaddStaticInitializer(this);
	}


	public virtual List getMethodsByName(string P_0)
	{
		return NodeWithMembers._003Cdefault_003EgetMethodsByName(this, P_0);
	}


	public virtual List getMethodsByParameterTypes(string[] P_0)
	{
		return NodeWithMembers._003Cdefault_003EgetMethodsByParameterTypes(this, P_0);
	}


	public virtual List getMethodsBySignature(string P_0, string[] P_1)
	{
		return NodeWithMembers._003Cdefault_003EgetMethodsBySignature(this, P_0, P_1);
	}


	public virtual List getMethodsByParameterTypes(Class[] P_0)
	{
		return NodeWithMembers._003Cdefault_003EgetMethodsByParameterTypes(this, P_0);
	}


	public virtual List getConstructors()
	{
		return NodeWithMembers._003Cdefault_003EgetConstructors(this);
	}


	public virtual Optional getDefaultConstructor()
	{
		return NodeWithMembers._003Cdefault_003EgetDefaultConstructor(this);
	}


	public virtual Optional getConstructorByParameterTypes(string[] P_0)
	{
		return NodeWithMembers._003Cdefault_003EgetConstructorByParameterTypes(this, P_0);
	}


	public virtual Optional getConstructorByParameterTypes(Class[] P_0)
	{
		return NodeWithMembers._003Cdefault_003EgetConstructorByParameterTypes(this, P_0);
	}


	public virtual Optional getFieldByName(string P_0)
	{
		return NodeWithMembers._003Cdefault_003EgetFieldByName(this, P_0);
	}


	public virtual List getFields()
	{
		return NodeWithMembers._003Cdefault_003EgetFields(this);
	}


	public virtual bool isEmpty()
	{
		return NodeWithMembers._003Cdefault_003EisEmpty(this);
	}


	public virtual Node addModifier(Modifier.Keyword[] P_0)
	{
		return NodeWithModifiers._003Cdefault_003EaddModifier(this, P_0);
	}


	public virtual Node removeModifier(Modifier.Keyword[] P_0)
	{
		return NodeWithModifiers._003Cdefault_003EremoveModifier(this, P_0);
	}


	public virtual Node setModifier(Modifier.Keyword P_0, bool P_1)
	{
		return NodeWithModifiers._003Cdefault_003EsetModifier(this, P_0, P_1);
	}


	public virtual bool hasModifier(Modifier.Keyword P_0)
	{
		return NodeWithModifiers._003Cdefault_003EhasModifier(this, P_0);
	}


	public virtual Node setModifiers(Modifier.Keyword[] P_0)
	{
		return NodeWithModifiers._003Cdefault_003EsetModifiers(this, P_0);
	}


	public virtual AccessSpecifier getAccessSpecifier()
	{
		return NodeWithModifiers._003Cdefault_003EgetAccessSpecifier(this);
	}


	public virtual bool isPublic()
	{
		return NodeWithPublicModifier._003Cdefault_003EisPublic(this);
	}


	public virtual bool isPrivate()
	{
		return NodeWithPrivateModifier._003Cdefault_003EisPrivate(this);
	}


	public virtual Node setPrivate(bool P_0)
	{
		return NodeWithPrivateModifier._003Cdefault_003EsetPrivate(this, P_0);
	}


	public virtual bool isProtected()
	{
		return NodeWithProtectedModifier._003Cdefault_003EisProtected(this);
	}


	public virtual Node setProtected(bool P_0)
	{
		return NodeWithProtectedModifier._003Cdefault_003EsetProtected(this, P_0);
	}


	public virtual bool isStatic()
	{
		return NodeWithStaticModifier._003Cdefault_003EisStatic(this);
	}


	public virtual Node setStatic(bool P_0)
	{
		return NodeWithStaticModifier._003Cdefault_003EsetStatic(this, P_0);
	}


	public virtual bool isStrictfp()
	{
		return NodeWithStrictfpModifier._003Cdefault_003EisStrictfp(this);
	}


	public virtual Node setStrictfp(bool P_0)
	{
		return NodeWithStrictfpModifier._003Cdefault_003EsetStrictfp(this, P_0);
	}

	
	static TypeDeclaration()
	{
		BodyDeclaration.___003Cclinit_003E();
	}

	Node NodeWithSimpleName.NodeWithSimpleName_003A_003AsetName(SimpleName P_0)
	{
		return _003Cbridge_003EsetName(P_0);
	}

	Node NodeWithMembers.NodeWithMembers_003A_003AaddMember(BodyDeclaration P_0)
	{
		return _003Cbridge_003EaddMember(P_0);
	}

	Node NodeWithMembers.NodeWithMembers_003A_003AsetMembers(NodeList P_0)
	{
		return _003Cbridge_003EsetMembers(P_0);
	}

	Node NodeWithModifiers.NodeWithModifiers_003A_003AsetModifiers(NodeList P_0)
	{
		return _003Cbridge_003EsetModifiers(P_0);
	}
}
