using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace com.github.javaparser.ast.modules;


public class ModuleDeclaration : Node, NodeWithName, NodeWithAnnotations
{
	private Name name;

		private NodeList annotations;

	private bool m_isOpen;

		private NodeList directives;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public ModuleDeclaration(Name name, bool isOpen)
		: this(null, new NodeList(), name, isOpen, new NodeList())
	{
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public ModuleDeclaration(TokenRange tokenRange, NodeList annotations, Name name, bool isOpen, NodeList directives)
		: base(tokenRange)
	{
		setAnnotations(annotations);
		setName(name);
		setOpen(isOpen);
		setDirectives(directives);
		customInitialization();
	}

	
		
	
	public virtual ModuleDeclaration setAnnotations(NodeList annotations)
	{
		Utils.assertNotNull(annotations);
		if (annotations == this.annotations)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EANNOTATIONS, this.annotations, annotations);
		if (this.annotations != null)
		{
			this.annotations.setParentNode(null);
		}
		this.annotations = annotations;
		setAsParentNodeOf(annotations);
		return this;
	}

	
	
	
	public virtual ModuleDeclaration setName(Name name)
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

	
	
	
	public virtual ModuleDeclaration setOpen(bool isOpen)
	{
		if (isOpen == this.m_isOpen)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EOPEN, Boolean.valueOf(this.m_isOpen), Boolean.valueOf(isOpen));
		this.m_isOpen = isOpen;
		return this;
	}

	
		
	
	public virtual ModuleDeclaration setDirectives(NodeList directives)
	{
		Utils.assertNotNull(directives);
		if (directives == this.directives)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EDIRECTIVES, this.directives, directives);
		if (this.directives != null)
		{
			this.directives.setParentNode(null);
		}
		this.directives = directives;
		setAsParentNodeOf(directives);
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

	
	
	
	public virtual ModuleDeclaration addDirective(ModuleDirective directive)
	{
		getDirectives().add(directive);
		return this;
	}

		public virtual NodeList getDirectives()
	{
		return directives;
	}

	
	
	public new virtual ModuleDeclarationMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EmoduleDeclarationMetaModel;
	}

	
	
	public new virtual ModuleDeclaration clone()
	{
		return (ModuleDeclaration)accept(new CloneVisitor(), null);
	}

	
	
	public ModuleDeclaration()
		: this(null, new NodeList(), new Name(), isOpen: false, new NodeList())
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
	public ModuleDeclaration(NodeList annotations, Name name, bool isOpen, NodeList directives)
		: this(null, annotations, name, isOpen, directives)
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

	public virtual Name getName()
	{
		return name;
	}

		public virtual NodeList getAnnotations()
	{
		return annotations;
	}

	
	
	[LineNumberTable(new byte[]
	{
		83, 99, 130, 112, 111, 109, 226, 61, 230, 70,
		112, 111, 109, 226, 61, 230, 70
	})]
	public override bool remove(Node node)
	{
		if (node == null)
		{
			return false;
		}
		for (int i = 0; i < annotations.size(); i++)
		{
			if (annotations.get(i) == node)
			{
				annotations.remove(i);
				return true;
			}
		}
		for (int i = 0; i < directives.size(); i++)
		{
			if (directives.get(i) == node)
			{
				directives.remove(i);
				return true;
			}
		}
		bool result = base.remove(node);
		
		return result;
	}

	public virtual bool isOpen()
	{
		return this.m_isOpen;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		160, 86, 99, 130, 112, 111, 115, 226, 61, 230,
		70, 112, 111, 115, 226, 61, 230, 70, 105, 109,
		130
	})]
	public override bool replace(Node node, Node replacementNode)
	{
		if (node == null)
		{
			return false;
		}
		for (int i = 0; i < annotations.size(); i++)
		{
			if (annotations.get(i) == node)
			{
				annotations.set(i, (AnnotationExpr)replacementNode);
				return true;
			}
		}
		for (int i = 0; i < directives.size(); i++)
		{
			if (directives.get(i) == node)
			{
				directives.set(i, (ModuleDirective)replacementNode);
				return true;
			}
		}
		if (node == name)
		{
			setName((Name)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	
	
	
	public virtual ModuleDeclaration addDirective(string directive)
	{
		ModuleDeclaration result = addDirective(StaticJavaParser.parseModuleDirective(directive));
		
		return result;
	}

	
	
	
	
	public virtual NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		ModuleDeclarationMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Node _003Cbridge_003Eclone()
	{
		ModuleDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		ModuleDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetName(Name name)
	{
		ModuleDeclaration result = setName(name);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetAnnotations(NodeList annotations)
	{
		ModuleDeclaration result = setAnnotations(annotations);
		
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setName(string P_0)
	{
		return NodeWithName._003Cdefault_003EsetName(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual string getNameAsString()
	{
		return NodeWithName._003Cdefault_003EgetNameAsString(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual AnnotationExpr getAnnotation(int P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EgetAnnotation(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setAnnotation(int P_0, AnnotationExpr P_1)
	{
		return NodeWithAnnotations._003Cdefault_003EsetAnnotation(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addAnnotation(AnnotationExpr P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddAnnotation(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addAnnotation(string P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddAnnotation(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual NormalAnnotationExpr addAndGetAnnotation(string P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddAndGetAnnotation(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addAnnotation(Class P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddAnnotation(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual NormalAnnotationExpr addAndGetAnnotation(Class P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddAndGetAnnotation(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addMarkerAnnotation(string P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddMarkerAnnotation(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addMarkerAnnotation(Class P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddMarkerAnnotation(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addSingleMemberAnnotation(string P_0, Expression P_1)
	{
		return NodeWithAnnotations._003Cdefault_003EaddSingleMemberAnnotation(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addSingleMemberAnnotation(Class P_0, Expression P_1)
	{
		return NodeWithAnnotations._003Cdefault_003EaddSingleMemberAnnotation(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addSingleMemberAnnotation(string P_0, string P_1)
	{
		return NodeWithAnnotations._003Cdefault_003EaddSingleMemberAnnotation(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addSingleMemberAnnotation(Class P_0, string P_1)
	{
		return NodeWithAnnotations._003Cdefault_003EaddSingleMemberAnnotation(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isAnnotationPresent(string P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EisAnnotationPresent(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isAnnotationPresent(Class P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EisAnnotationPresent(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional getAnnotationByName(string P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EgetAnnotationByName(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional getAnnotationByClass(Class P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EgetAnnotationByClass(this, P_0);
	}

	
	static ModuleDeclaration()
	{
		Node.___003Cclinit_003E();
	}

	Node NodeWithName.NodeWithName_003A_003AsetName(Name P_0)
	{
		return _003Cbridge_003EsetName(P_0);
	}

	Node NodeWithAnnotations.NodeWithAnnotations_003A_003AsetAnnotations(NodeList P_0)
	{
		return _003Cbridge_003EsetAnnotations(P_0);
	}
}
