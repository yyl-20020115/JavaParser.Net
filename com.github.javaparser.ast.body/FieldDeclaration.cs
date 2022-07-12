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
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.utils;

using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.body;


public class FieldDeclaration : BodyDeclaration, NodeWithJavadoc, NodeWithVariables, NodeWithAccessModifiers, NodeWithPublicModifier, NodeWithModifiers, NodeWithPrivateModifier, NodeWithProtectedModifier, NodeWithStaticModifier, NodeWithFinalModifier, Resolvable
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
			MethodDeclaration result = lambda_0024createGetter_00240(arg_00241, (ClassOrInterfaceDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon1 : Supplier
	{
		private readonly Optional arg_00241;

		private readonly string arg_00242;

		internal ___003C_003EAnon1(Optional P_0, string P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object get()
		{
			MethodDeclaration result = lambda_0024createGetter_00241(arg_00241, arg_00242);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon2 : Function
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon2(string P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			MethodDeclaration result = lambda_0024createSetter_00242(arg_00241, (ClassOrInterfaceDeclaration)P_0);
			
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
		private readonly Optional arg_00241;

		private readonly string arg_00242;

		internal ___003C_003EAnon3(Optional P_0, string P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object get()
		{
			MethodDeclaration result = lambda_0024createSetter_00243(arg_00241, arg_00242);
			
			return result;
		}
	}

		private NodeList modifiers;

		[NonEmptyProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/NonEmptyProperty;"
	})]
	private NodeList variables;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual VariableDeclarator getVariable(int P_0)
	{
		return NodeWithVariables._003Cdefault_003EgetVariable(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional getJavadocComment()
	{
		return NodeWithJavadoc._003Cdefault_003EgetJavadocComment(this);
	}

	
	
	public FieldDeclaration()
		: this(null, new NodeList(), new NodeList(), new NodeList())
	{
	}

		public virtual NodeList getVariables()
	{
		return variables;
	}

	
		
	
	public virtual FieldDeclaration setModifiers(NodeList modifiers)
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

	
		
	
	public FieldDeclaration(TokenRange tokenRange, NodeList modifiers, NodeList annotations, NodeList variables)
		: base(tokenRange, annotations)
	{
		setModifiers(modifiers);
		setVariables(variables);
		customInitialization();
	}

	
		
	
	public virtual FieldDeclaration setVariables(NodeList variables)
	{
		Utils.assertNotNull(variables);
		if (variables == this.variables)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EVARIABLES, this.variables, variables);
		if (this.variables != null)
		{
			this.variables.setParentNode(null);
		}
		this.variables = variables;
		setAsParentNodeOf(variables);
		return this;
	}

	
		
	
	public FieldDeclaration(NodeList modifiers, VariableDeclarator variable)
		: this(null, modifiers, new NodeList(), NodeList.nodeList(variable))
	{
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool hasModifier(Modifier.Keyword P_0)
	{
		return NodeWithModifiers._003Cdefault_003EhasModifier(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setModifier(Modifier.Keyword P_0, bool P_1)
	{
		return NodeWithModifiers._003Cdefault_003EsetModifier(this, P_0, P_1);
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual FieldDeclarationMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EfieldDeclarationMetaModel;
	}

	
	
	public new virtual FieldDeclaration clone()
	{
		return (FieldDeclaration)accept(new CloneVisitor(), null);
	}

	
	
	public virtual ResolvedFieldDeclaration resolve()
	{
		return (ResolvedFieldDeclaration)getSymbolResolver().resolveDeclaration(this, ClassLiteral<ResolvedFieldDeclaration>.Value);
	}

	
	
	
	
	private static MethodDeclaration lambda_0024createGetter_00240(string fieldNameUpper, ClassOrInterfaceDeclaration clazz)
	{
		MethodDeclaration result = clazz.addMethod(new StringBuilder().append("get").append(fieldNameUpper).ToString(), new Modifier.Keyword[1] { Modifier.Keyword.___003C_003EPUBLIC });
		
		return result;
	}

	
	
	
	
	private static MethodDeclaration lambda_0024createGetter_00241(Optional parentEnum, string fieldNameUpper)
	{
		MethodDeclaration result = ((EnumDeclaration)parentEnum.get()).addMethod(new StringBuilder().append("get").append(fieldNameUpper).ToString(), new Modifier.Keyword[1] { Modifier.Keyword.___003C_003EPUBLIC });
		
		return result;
	}

	
	
	
	
	private static MethodDeclaration lambda_0024createSetter_00242(string fieldNameUpper, ClassOrInterfaceDeclaration clazz)
	{
		MethodDeclaration result = clazz.addMethod(new StringBuilder().append("set").append(fieldNameUpper).ToString(), new Modifier.Keyword[1] { Modifier.Keyword.___003C_003EPUBLIC });
		
		return result;
	}

	
	
	
	
	private static MethodDeclaration lambda_0024createSetter_00243(Optional parentEnum, string fieldNameUpper)
	{
		MethodDeclaration result = ((EnumDeclaration)parentEnum.get()).addMethod(new StringBuilder().append("set").append(fieldNameUpper).ToString(), new Modifier.Keyword[1] { Modifier.Keyword.___003C_003EPUBLIC });
		
		return result;
	}

	
		
	
	public FieldDeclaration(NodeList modifiers, NodeList variables)
		: this(null, modifiers, new NodeList(), variables)
	{
	}

	
		
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public FieldDeclaration(NodeList modifiers, NodeList annotations, NodeList variables)
		: this(null, modifiers, annotations, variables)
	{
	}

	
		
	
	public FieldDeclaration(NodeList modifiers, Type type, string name)
	{
		NodeList obj = (NodeList)Utils.assertNotNull(modifiers);
		VariableDeclarator.___003Cclinit_003E();
		this._002Ector(obj, new VariableDeclarator(type, (string)Utils.assertNotNull(name)));
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

		public virtual NodeList getModifiers()
	{
		return modifiers;
	}

	
	
	public virtual MethodDeclaration createGetter()
	{
		if (getVariables().size() != 1)
		{
			
			throw new IllegalStateException("You can use this only when the field declares only 1 variable name");
		}
		Optional optional = findAncestor(new Class[1] { ClassLiteral<ClassOrInterfaceDeclaration>.Value });
		Optional optional2 = findAncestor(new Class[1] { ClassLiteral<EnumDeclaration>.Value });
		if ((!optional.isPresent() && !optional2.isPresent()) || (optional.isPresent() && ((ClassOrInterfaceDeclaration)optional.get()).isInterface()))
		{
			
			throw new IllegalStateException("You can use this only when the field is attached to a class or an enum");
		}
		VariableDeclarator variable = getVariable(0);
		string nameAsString = variable.getNameAsString();
		string text = new StringBuilder().append(String.instancehelper_substring(String.instancehelper_toUpperCase(nameAsString), 0, 1)).append(String.instancehelper_substring(nameAsString, 1, String.instancehelper_length(nameAsString))).ToString();
		MethodDeclaration methodDeclaration = (MethodDeclaration)optional.map(new ___003C_003EAnon0(text)).orElseGet(new ___003C_003EAnon1(optional2, text));
		methodDeclaration.setType(variable.getType());
		BlockStmt blockStmt = new BlockStmt();
		methodDeclaration.setBody(blockStmt);
		blockStmt.addStatement(new ReturnStmt(nameAsString));
		return methodDeclaration;
	}

	
	
	public virtual MethodDeclaration createSetter()
	{
		if (getVariables().size() != 1)
		{
			
			throw new IllegalStateException("You can use this only when the field declares only 1 variable name");
		}
		Optional optional = findAncestor(new Class[1] { ClassLiteral<ClassOrInterfaceDeclaration>.Value });
		Optional optional2 = findAncestor(new Class[1] { ClassLiteral<EnumDeclaration>.Value });
		if ((!optional.isPresent() && !optional2.isPresent()) || (optional.isPresent() && ((ClassOrInterfaceDeclaration)optional.get()).isInterface()))
		{
			
			throw new IllegalStateException("You can use this only when the field is attached to a class or an enum");
		}
		VariableDeclarator variable = getVariable(0);
		string nameAsString = variable.getNameAsString();
		string text = new StringBuilder().append(String.instancehelper_substring(String.instancehelper_toUpperCase(nameAsString), 0, 1)).append(String.instancehelper_substring(nameAsString, 1, String.instancehelper_length(nameAsString))).ToString();
		MethodDeclaration methodDeclaration = (MethodDeclaration)optional.map(new ___003C_003EAnon2(text)).orElseGet(new ___003C_003EAnon3(optional2, text));
		methodDeclaration.setType(new VoidType());
		NodeList parameters = methodDeclaration.getParameters();
		Parameter.___003Cclinit_003E();
		parameters.add(new Parameter(variable.getType(), nameAsString));
		BlockStmt blockStmt = new BlockStmt();
		methodDeclaration.setBody(blockStmt);
		AssignExpr.___003Cclinit_003E();
		NameExpr.___003Cclinit_003E();
		blockStmt.addStatement(new AssignExpr(new NameExpr(new StringBuilder().append("this.").append(nameAsString).ToString()), new NameExpr(nameAsString), AssignExpr.Operator.___003C_003EASSIGN));
		return methodDeclaration;
	}

	
	
	public virtual bool isTransient()
	{
		bool result = hasModifier(Modifier.Keyword.___003C_003ETRANSIENT);
		
		return result;
	}

	
	
	public virtual bool isVolatile()
	{
		bool result = hasModifier(Modifier.Keyword.___003C_003EVOLATILE);
		
		return result;
	}

	
	
	
	public virtual FieldDeclaration setTransient(bool set)
	{
		return (FieldDeclaration)setModifier(Modifier.Keyword.___003C_003ETRANSIENT, set);
	}

	
	
	
	public virtual FieldDeclaration setVolatile(bool set)
	{
		return (FieldDeclaration)setModifier(Modifier.Keyword.___003C_003EVOLATILE, set);
	}

	
	
	
	public override bool remove(Node node)
	{
		if (node == null)
		{
			return false;
		}
		for (int i = 0; i < modifiers.size(); i++)
		{
			if (modifiers.get(i) == node)
			{
				modifiers.remove(i);
				return true;
			}
		}
		for (int i = 0; i < variables.size(); i++)
		{
			if (variables.get(i) == node)
			{
				variables.remove(i);
				return true;
			}
		}
		bool result = base.remove(node);
		
		return result;
	}

	
	
	
	public override bool replace(Node node, Node replacementNode)
	{
		if (node == null)
		{
			return false;
		}
		for (int i = 0; i < modifiers.size(); i++)
		{
			if (modifiers.get(i) == node)
			{
				modifiers.set(i, (Modifier)replacementNode);
				return true;
			}
		}
		for (int i = 0; i < variables.size(); i++)
		{
			if (variables.get(i) == node)
			{
				variables.set(i, (VariableDeclarator)replacementNode);
				return true;
			}
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isFieldDeclaration()
	{
		return true;
	}

	public override FieldDeclaration asFieldDeclaration()
	{
		return this;
	}

	
		
	
	public override void ifFieldDeclaration(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toFieldDeclaration()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual BodyDeclarationMetaModel _003Cbridge_003EgetMetaModel()
	{
		FieldDeclarationMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual BodyDeclaration _003Cbridge_003Eclone()
	{
		FieldDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		FieldDeclarationMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		FieldDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		FieldDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetVariables(NodeList variables)
	{
		FieldDeclaration result = setVariables(variables);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetModifiers(NodeList modifiers)
	{
		FieldDeclaration result = setModifiers(modifiers);
		
		return result;
	}

	
	
	
	
	public virtual object _003Cbridge_003Eresolve()
	{
		ResolvedFieldDeclaration result = resolve();
		
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional getJavadoc()
	{
		return NodeWithJavadoc._003Cdefault_003EgetJavadoc(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setJavadocComment(string P_0)
	{
		return NodeWithJavadoc._003Cdefault_003EsetJavadocComment(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setJavadocComment(JavadocComment P_0)
	{
		return NodeWithJavadoc._003Cdefault_003EsetJavadocComment(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setJavadocComment(string P_0, Javadoc P_1)
	{
		return NodeWithJavadoc._003Cdefault_003EsetJavadocComment(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setJavadocComment(Javadoc P_0)
	{
		return NodeWithJavadoc._003Cdefault_003EsetJavadocComment(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool removeJavaDocComment()
	{
		return NodeWithJavadoc._003Cdefault_003EremoveJavaDocComment(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool hasJavaDocComment()
	{
		return NodeWithJavadoc._003Cdefault_003EhasJavaDocComment(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setVariable(int P_0, VariableDeclarator P_1)
	{
		return NodeWithVariables._003Cdefault_003EsetVariable(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addVariable(VariableDeclarator P_0)
	{
		return NodeWithVariables._003Cdefault_003EaddVariable(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Type getCommonType()
	{
		return NodeWithVariables._003Cdefault_003EgetCommonType(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Type getElementType()
	{
		return NodeWithVariables._003Cdefault_003EgetElementType(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setAllTypes(Type P_0)
	{
		return NodeWithVariables._003Cdefault_003EsetAllTypes(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional getMaximumCommonType()
	{
		return NodeWithVariables._003Cdefault_003EgetMaximumCommonType(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addModifier(Modifier.Keyword[] P_0)
	{
		return NodeWithModifiers._003Cdefault_003EaddModifier(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node removeModifier(Modifier.Keyword[] P_0)
	{
		return NodeWithModifiers._003Cdefault_003EremoveModifier(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setModifiers(Modifier.Keyword[] P_0)
	{
		return NodeWithModifiers._003Cdefault_003EsetModifiers(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual AccessSpecifier getAccessSpecifier()
	{
		return NodeWithModifiers._003Cdefault_003EgetAccessSpecifier(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isPublic()
	{
		return NodeWithPublicModifier._003Cdefault_003EisPublic(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setPublic(bool P_0)
	{
		return NodeWithPublicModifier._003Cdefault_003EsetPublic(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isPrivate()
	{
		return NodeWithPrivateModifier._003Cdefault_003EisPrivate(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setPrivate(bool P_0)
	{
		return NodeWithPrivateModifier._003Cdefault_003EsetPrivate(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isProtected()
	{
		return NodeWithProtectedModifier._003Cdefault_003EisProtected(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setProtected(bool P_0)
	{
		return NodeWithProtectedModifier._003Cdefault_003EsetProtected(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isStatic()
	{
		return NodeWithStaticModifier._003Cdefault_003EisStatic(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setStatic(bool P_0)
	{
		return NodeWithStaticModifier._003Cdefault_003EsetStatic(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isFinal()
	{
		return NodeWithFinalModifier._003Cdefault_003EisFinal(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setFinal(bool P_0)
	{
		return NodeWithFinalModifier._003Cdefault_003EsetFinal(this, P_0);
	}

	
	static FieldDeclaration()
	{
		BodyDeclaration.___003Cclinit_003E();
	}

	Node NodeWithVariables.NodeWithVariables_003A_003AsetVariables(NodeList P_0)
	{
		return _003Cbridge_003EsetVariables(P_0);
	}

	Node NodeWithModifiers.NodeWithModifiers_003A_003AsetModifiers(NodeList P_0)
	{
		return _003Cbridge_003EsetModifiers(P_0);
	}

	object Resolvable.Resolvable_003A_003Aresolve()
	{
		return _003Cbridge_003Eresolve();
	}
}
