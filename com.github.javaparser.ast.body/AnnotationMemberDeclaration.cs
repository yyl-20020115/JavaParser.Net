using System.ComponentModel;

using com.github.javaparser.ast.comments;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.nodeTypes.modifiers;
using com.github.javaparser.ast.observer;
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


public class AnnotationMemberDeclaration : BodyDeclaration, NodeWithJavadoc, NodeWithSimpleName, NodeWithType, NodeWithPublicModifier, NodeWithModifiers, NodeWithAbstractModifier, Resolvable
{
		private NodeList modifiers;

	private Type type;

	private SimpleName name;

	
	private Expression defaultValue;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
		
	
	public AnnotationMemberDeclaration(TokenRange tokenRange, NodeList modifiers, NodeList annotations, Type type, SimpleName name, Expression defaultValue)
		: base(tokenRange, annotations)
	{
		setModifiers(modifiers);
		setType(type);
		setName(name);
		setDefaultValue(defaultValue);
		customInitialization();
	}

	
		
	
	public virtual AnnotationMemberDeclaration setModifiers(NodeList modifiers)
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

	
	
	
	public virtual AnnotationMemberDeclaration setType(Type type)
	{
		Utils.assertNotNull(type);
		if (type == this.type)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ETYPE, this.type, type);
		if (this.type != null)
		{
			this.type.setParentNode(null);
		}
		this.type = type;
		setAsParentNodeOf(type);
		return this;
	}

	
	
	
	public virtual AnnotationMemberDeclaration setName(SimpleName name)
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

	
	
	
	public virtual AnnotationMemberDeclaration setDefaultValue(Expression defaultValue)
	{
		if (defaultValue == this.defaultValue)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EDEFAULT_VALUE, this.defaultValue, defaultValue);
		if (this.defaultValue != null)
		{
			this.defaultValue.setParentNode(null);
		}
		this.defaultValue = defaultValue;
		setAsParentNodeOf(defaultValue);
		return this;
	}

	
	
	public virtual AnnotationMemberDeclaration removeDefaultValue()
	{
		AnnotationMemberDeclaration result = setDefaultValue(null);
		
		return result;
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual AnnotationMemberDeclarationMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EannotationMemberDeclarationMetaModel;
	}

	
	
	public new virtual AnnotationMemberDeclaration clone()
	{
		return (AnnotationMemberDeclaration)accept(new CloneVisitor(), null);
	}

	
	
	public virtual ResolvedAnnotationMemberDeclaration resolve()
	{
		return (ResolvedAnnotationMemberDeclaration)getSymbolResolver().resolveDeclaration(this, ClassLiteral<ResolvedAnnotationMemberDeclaration>.Value);
	}

	
	
	public AnnotationMemberDeclaration()
		: this(null, new NodeList(), new NodeList(), new ClassOrInterfaceType(), new SimpleName(), null)
	{
	}

	
		
	
	public AnnotationMemberDeclaration(NodeList modifiers, Type type, string name, Expression defaultValue)
		: this(null, modifiers, new NodeList(), type, new SimpleName(name), defaultValue)
	{
	}

	
		
	
	
	public AnnotationMemberDeclaration(NodeList modifiers, NodeList annotations, Type type, SimpleName name, Expression defaultValue)
		: this(null, modifiers, annotations, type, name, defaultValue)
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	
		
	public virtual Optional getDefaultValue()
	{
		Optional result = Optional.ofNullable(defaultValue);
		
		return result;
	}

		public virtual NodeList getModifiers()
	{
		return modifiers;
	}

	public virtual SimpleName getName()
	{
		return name;
	}

	public virtual Type getType()
	{
		return type;
	}

	
	
	
	public override bool remove(Node node)
	{
		if (node == null)
		{
			return false;
		}
		if (defaultValue != null && node == defaultValue)
		{
			removeDefaultValue();
			return true;
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

	
	
	
	public override bool replace(Node node, Node replacementNode)
	{
		if (node == null)
		{
			return false;
		}
		if (defaultValue != null && node == defaultValue)
		{
			setDefaultValue((Expression)replacementNode);
			return true;
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
		if (node == type)
		{
			setType((Type)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isAnnotationMemberDeclaration()
	{
		return true;
	}

	public override AnnotationMemberDeclaration asAnnotationMemberDeclaration()
	{
		return this;
	}

	
		
	
	public override void ifAnnotationMemberDeclaration(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toAnnotationMemberDeclaration()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual BodyDeclarationMetaModel _003Cbridge_003EgetMetaModel()
	{
		AnnotationMemberDeclarationMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual BodyDeclaration _003Cbridge_003Eclone()
	{
		AnnotationMemberDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		AnnotationMemberDeclarationMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		AnnotationMemberDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		AnnotationMemberDeclaration result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetName(SimpleName name)
	{
		AnnotationMemberDeclaration result = setName(name);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetType(Type type)
	{
		AnnotationMemberDeclaration result = setType(type);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetModifiers(NodeList modifiers)
	{
		AnnotationMemberDeclaration result = setModifiers(modifiers);
		
		return result;
	}

	
	
	
	
	public virtual object _003Cbridge_003Eresolve()
	{
		ResolvedAnnotationMemberDeclaration result = resolve();
		
		return result;
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


	public virtual Node setName(string P_0)
	{
		return NodeWithSimpleName._003Cdefault_003EsetName(this, P_0);
	}


	public virtual string getNameAsString()
	{
		return NodeWithSimpleName._003Cdefault_003EgetNameAsString(this);
	}


	public virtual NameExpr getNameAsExpression()
	{
		return NodeWithSimpleName._003Cdefault_003EgetNameAsExpression(this);
	}


	public virtual Node setType(Class P_0)
	{
		return NodeWithType._003Cdefault_003EsetType(this, P_0);
	}


	public virtual Node setType(string P_0)
	{
		return NodeWithType._003Cdefault_003EsetType(this, P_0);
	}


	public virtual string getTypeAsString()
	{
		return NodeWithType._003Cdefault_003EgetTypeAsString(this);
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


	public virtual Node setPublic(bool P_0)
	{
		return NodeWithPublicModifier._003Cdefault_003EsetPublic(this, P_0);
	}


	public virtual bool isAbstract()
	{
		return NodeWithAbstractModifier._003Cdefault_003EisAbstract(this);
	}


	public virtual Node setAbstract(bool P_0)
	{
		return NodeWithAbstractModifier._003Cdefault_003EsetAbstract(this, P_0);
	}

	
	static AnnotationMemberDeclaration()
	{
		BodyDeclaration.___003Cclinit_003E();
	}

	Node NodeWithSimpleName.NodeWithSimpleName_003A_003AsetName(SimpleName P_0)
	{
		return _003Cbridge_003EsetName(P_0);
	}

	Node NodeWithType.NodeWithType_003A_003AsetType(Type P_0)
	{
		return _003Cbridge_003EsetType(P_0);
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
