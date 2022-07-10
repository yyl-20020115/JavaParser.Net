using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast.comments;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.javadoc;
using com.github.javaparser.metamodel;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.utils;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.body;


public class EnumConstantDeclaration : BodyDeclaration, NodeWithJavadoc, NodeWithSimpleName, NodeWithArguments, Resolvable
{
	private SimpleName name;

		private NodeList arguments;

		private NodeList classBody;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addArgument(string P_0)
	{
		return NodeWithArguments._003Cdefault_003EaddArgument(this, P_0);
	}

	
	
	
	public EnumConstantDeclaration(string name)
		: this(null, new NodeList(), new SimpleName(name), new NodeList(), new NodeList())
	{
	}

		public virtual NodeList getArguments()
	{
		return arguments;
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public EnumConstantDeclaration(TokenRange tokenRange, NodeList annotations, SimpleName name, NodeList arguments, NodeList classBody)
		: base(tokenRange, annotations)
	{
		setName(name);
		setArguments(arguments);
		setClassBody(classBody);
		customInitialization();
	}

	
	
	
	public virtual EnumConstantDeclaration setName(SimpleName name)
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

	
		
	
	public virtual EnumConstantDeclaration setArguments(NodeList arguments)
	{
		Utils.assertNotNull(arguments);
		if (arguments == this.arguments)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EARGUMENTS, this.arguments, arguments);
		if (this.arguments != null)
		{
			this.arguments.setParentNode(null);
		}
		this.arguments = arguments;
		setAsParentNodeOf(arguments);
		return this;
	}

	
		
	
	public virtual EnumConstantDeclaration setClassBody(NodeList classBody)
	{
		Utils.assertNotNull(classBody);
		if (classBody == this.classBody)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ECLASS_BODY, this.classBody, classBody);
		if (this.classBody != null)
		{
			this.classBody.setParentNode(null);
		}
		this.classBody = classBody;
		setAsParentNodeOf(classBody);
		return this;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual EnumConstantDeclarationMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EenumConstantDeclarationMetaModel;
	}

	
	
	public new virtual EnumConstantDeclaration clone()
	{
		return (EnumConstantDeclaration)accept(new CloneVisitor(), null);
	}

	
	
	public virtual ResolvedEnumConstantDeclaration resolve()
	{
		return (ResolvedEnumConstantDeclaration)getSymbolResolver().resolveDeclaration(this, ClassLiteral<ResolvedEnumConstantDeclaration>.Value);
	}

	
	
	public EnumConstantDeclaration()
		: this(null, new NodeList(), new SimpleName(), new NodeList(), new NodeList())
	{
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public EnumConstantDeclaration(NodeList annotations, SimpleName name, NodeList arguments, NodeList classBody)
		: this(null, annotations, name, arguments, classBody)
	{
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

		public virtual NodeList getClassBody()
	{
		return classBody;
	}

	public virtual SimpleName getName()
	{
		return name;
	}

	
	
	[LineNumberTable(new byte[]
	{
		106, 99, 130, 112, 111, 109, 226, 61, 230, 70,
		112, 111, 109, 226, 61, 230, 70
	})]
	public override bool remove(Node node)
	{
		if (node == null)
		{
			return false;
		}
		for (int i = 0; i < arguments.size(); i++)
		{
			if (arguments.get(i) == node)
			{
				arguments.remove(i);
				return true;
			}
		}
		for (int i = 0; i < classBody.size(); i++)
		{
			if (classBody.get(i) == node)
			{
				classBody.remove(i);
				return true;
			}
		}
		bool result = base.remove(node);
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		160, 75, 99, 130, 112, 111, 115, 226, 61, 230,
		70, 112, 111, 115, 226, 61, 230, 70, 105, 109,
		130
	})]
	public override bool replace(Node node, Node replacementNode)
	{
		if (node == null)
		{
			return false;
		}
		for (int i = 0; i < arguments.size(); i++)
		{
			if (arguments.get(i) == node)
			{
				arguments.set(i, (Expression)replacementNode);
				return true;
			}
		}
		for (int i = 0; i < classBody.size(); i++)
		{
			if (classBody.get(i) == node)
			{
				classBody.set(i, (BodyDeclaration)replacementNode);
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

	public override bool isEnumConstantDeclaration()
	{
		return true;
	}

	public override EnumConstantDeclaration asEnumConstantDeclaration()
	{
		return this;
	}

	
		
	
	public override void ifEnumConstantDeclaration(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toEnumConstantDeclaration()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual BodyDeclarationMetaModel _003Cbridge_003EgetMetaModel()
	{
		EnumConstantDeclarationMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual BodyDeclaration _003Cbridge_003Eclone()
	{
		EnumConstantDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		EnumConstantDeclarationMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		EnumConstantDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		EnumConstantDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetName(SimpleName name)
	{
		EnumConstantDeclaration result = setName(name);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetArguments(NodeList arguments)
	{
		EnumConstantDeclaration result = setArguments(arguments);
		
		return result;
	}

	
	
	
	
	public virtual object _003Cbridge_003Eresolve()
	{
		ResolvedEnumConstantDeclaration result = resolve();
		
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional getJavadocComment()
	{
		return NodeWithJavadoc._003Cdefault_003EgetJavadocComment(this);
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
	public virtual Node setName(string P_0)
	{
		return NodeWithSimpleName._003Cdefault_003EsetName(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual string getNameAsString()
	{
		return NodeWithSimpleName._003Cdefault_003EgetNameAsString(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual NameExpr getNameAsExpression()
	{
		return NodeWithSimpleName._003Cdefault_003EgetNameAsExpression(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Expression getArgument(int P_0)
	{
		return NodeWithArguments._003Cdefault_003EgetArgument(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addArgument(Expression P_0)
	{
		return NodeWithArguments._003Cdefault_003EaddArgument(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setArgument(int P_0, Expression P_1)
	{
		return NodeWithArguments._003Cdefault_003EsetArgument(this, P_0, P_1);
	}

	
	static EnumConstantDeclaration()
	{
		BodyDeclaration.___003Cclinit_003E();
	}

	Node NodeWithSimpleName.NodeWithSimpleName_003A_003AsetName(SimpleName P_0)
	{
		return _003Cbridge_003EsetName(P_0);
	}

	Node NodeWithArguments.NodeWithArguments_003A_003AsetArguments(NodeList P_0)
	{
		return _003Cbridge_003EsetArguments(P_0);
	}

	object Resolvable.Resolvable_003A_003Aresolve()
	{
		return _003Cbridge_003Eresolve();
	}
}
