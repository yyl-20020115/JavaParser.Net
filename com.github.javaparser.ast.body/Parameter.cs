using System.ComponentModel;

using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.nodeTypes.modifiers;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.type;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.utils;

using ikvm.@internal;
using java.lang;
using java.util;

namespace com.github.javaparser.ast.body;


public class Parameter : Node, NodeWithType, NodeWithAnnotations, NodeWithSimpleName, NodeWithFinalModifier, NodeWithModifiers, Resolvable
{
	private Type type;

	private bool m_isVarArgs;

		private NodeList varArgsAnnotations;

		private NodeList modifiers;

		private NodeList annotations;

	private SimpleName name;

	
	
	public new static void ___003Cclinit_003E()
	{
	}


	public virtual Node addModifier(Modifier.Keyword[] P_0)
	{
		return NodeWithModifiers._003Cdefault_003EaddModifier(this, P_0);
	}

	public virtual Type getType()
	{
		return type;
	}


	public virtual Node setFinal(bool P_0)
	{
		return NodeWithFinalModifier._003Cdefault_003EsetFinal(this, P_0);
	}

	
	
	
	public Parameter(Type type, string name)
		: this(null, new NodeList(), new NodeList(), type, isVarArgs: false, new NodeList(), new SimpleName(name))
	{
	}


	public virtual string getNameAsString()
	{
		return NodeWithSimpleName._003Cdefault_003EgetNameAsString(this);
	}

	public virtual bool isVarArgs()
	{
		return this.m_isVarArgs;
	}

	
		
	
	public Parameter(TokenRange tokenRange, NodeList modifiers, NodeList annotations, Type type, bool isVarArgs, NodeList varArgsAnnotations, SimpleName name)
		: base(tokenRange)
	{
		setModifiers(modifiers);
		setAnnotations(annotations);
		setType(type);
		setVarArgs(isVarArgs);
		setVarArgsAnnotations(varArgsAnnotations);
		setName(name);
		customInitialization();
	}

	
		
	
	public virtual Parameter setModifiers(NodeList modifiers)
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

	
		
	
	public virtual Parameter setAnnotations(NodeList annotations)
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

	
	
	
	public virtual Parameter setType(Type type)
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

	
	
	
	public virtual Parameter setVarArgs(bool isVarArgs)
	{
		if (isVarArgs == this.m_isVarArgs)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EVAR_ARGS, Boolean.valueOf(this.m_isVarArgs), Boolean.valueOf(isVarArgs));
		this.m_isVarArgs = isVarArgs;
		return this;
	}

	
		
	
	public virtual Parameter setVarArgsAnnotations(NodeList varArgsAnnotations)
	{
		Utils.assertNotNull(varArgsAnnotations);
		if (varArgsAnnotations == this.varArgsAnnotations)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EVAR_ARGS_ANNOTATIONS, this.varArgsAnnotations, varArgsAnnotations);
		if (this.varArgsAnnotations != null)
		{
			this.varArgsAnnotations.setParentNode(null);
		}
		this.varArgsAnnotations = varArgsAnnotations;
		setAsParentNodeOf(varArgsAnnotations);
		return this;
	}

	
	
	
	public virtual Parameter setName(SimpleName name)
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

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual ParameterMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EparameterMetaModel;
	}

	
	
	public new virtual Parameter clone()
	{
		return (Parameter)accept(new CloneVisitor(), null);
	}

	
	
	public virtual ResolvedParameterDeclaration resolve()
	{
		return (ResolvedParameterDeclaration)getSymbolResolver().resolveDeclaration(this, ClassLiteral<ResolvedParameterDeclaration>.Value);
	}

	
	
	public Parameter()
		: this(null, new NodeList(), new NodeList(), new ClassOrInterfaceType(), isVarArgs: false, new NodeList(), new SimpleName())
	{
	}

	
	
	
	public Parameter(Type type, SimpleName name)
		: this(null, new NodeList(), new NodeList(), type, isVarArgs: false, new NodeList(), name)
	{
	}

	
		
	
	public Parameter(NodeList modifiers, Type type, SimpleName name)
		: this(null, modifiers, new NodeList(), type, isVarArgs: false, new NodeList(), name)
	{
	}

	
		
	
	
	public Parameter(NodeList modifiers, NodeList annotations, Type type, bool isVarArgs, NodeList varArgsAnnotations, SimpleName name)
		: this(null, modifiers, annotations, type, isVarArgs, varArgsAnnotations, name)
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

		public virtual NodeList getAnnotations()
	{
		return annotations;
	}

	public virtual SimpleName getName()
	{
		return name;
	}

		public virtual NodeList getModifiers()
	{
		return modifiers;
	}

	
	
	
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
		for (int i = 0; i < modifiers.size(); i++)
		{
			if (modifiers.get(i) == node)
			{
				modifiers.remove(i);
				return true;
			}
		}
		for (int i = 0; i < varArgsAnnotations.size(); i++)
		{
			if (varArgsAnnotations.get(i) == node)
			{
				varArgsAnnotations.remove(i);
				return true;
			}
		}
		bool result = base.remove(node);
		
		return result;
	}

		public virtual NodeList getVarArgsAnnotations()
	{
		return varArgsAnnotations;
	}

	
	
	
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
		for (int i = 0; i < varArgsAnnotations.size(); i++)
		{
			if (varArgsAnnotations.get(i) == node)
			{
				varArgsAnnotations.set(i, (AnnotationExpr)replacementNode);
				return true;
			}
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	
	
	public virtual bool isFinal()
	{
		if (getParentNode().isPresent())
		{
			Node node = (Node)getParentNode().get();
			if (node is RecordDeclaration)
			{
				return true;
			}
		}
		bool result = NodeWithFinalModifier._003Cdefault_003EisFinal(this);
		
		return result;
	}

	
	
	
	
	public virtual NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		ParameterMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Node _003Cbridge_003Eclone()
	{
		Parameter result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		Parameter result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetType(Type type)
	{
		Parameter result = setType(type);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetAnnotations(NodeList annotations)
	{
		Parameter result = setAnnotations(annotations);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetName(SimpleName name)
	{
		Parameter result = setName(name);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetModifiers(NodeList modifiers)
	{
		Parameter result = setModifiers(modifiers);
		
		return result;
	}

	
	
	
	
	public virtual object _003Cbridge_003Eresolve()
	{
		ResolvedParameterDeclaration result = resolve();
		
		return result;
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


	public virtual AnnotationExpr getAnnotation(int P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EgetAnnotation(this, P_0);
	}


	public virtual Node setAnnotation(int P_0, AnnotationExpr P_1)
	{
		return NodeWithAnnotations._003Cdefault_003EsetAnnotation(this, P_0, P_1);
	}


	public virtual Node addAnnotation(AnnotationExpr P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddAnnotation(this, P_0);
	}


	public virtual Node addAnnotation(string P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddAnnotation(this, P_0);
	}


	public virtual NormalAnnotationExpr addAndGetAnnotation(string P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddAndGetAnnotation(this, P_0);
	}


	public virtual Node addAnnotation(Class P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddAnnotation(this, P_0);
	}


	public virtual NormalAnnotationExpr addAndGetAnnotation(Class P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddAndGetAnnotation(this, P_0);
	}


	public virtual Node addMarkerAnnotation(string P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddMarkerAnnotation(this, P_0);
	}


	public virtual Node addMarkerAnnotation(Class P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddMarkerAnnotation(this, P_0);
	}


	public virtual Node addSingleMemberAnnotation(string P_0, Expression P_1)
	{
		return NodeWithAnnotations._003Cdefault_003EaddSingleMemberAnnotation(this, P_0, P_1);
	}


	public virtual Node addSingleMemberAnnotation(Class P_0, Expression P_1)
	{
		return NodeWithAnnotations._003Cdefault_003EaddSingleMemberAnnotation(this, P_0, P_1);
	}


	public virtual Node addSingleMemberAnnotation(string P_0, string P_1)
	{
		return NodeWithAnnotations._003Cdefault_003EaddSingleMemberAnnotation(this, P_0, P_1);
	}


	public virtual Node addSingleMemberAnnotation(Class P_0, string P_1)
	{
		return NodeWithAnnotations._003Cdefault_003EaddSingleMemberAnnotation(this, P_0, P_1);
	}


	public virtual bool isAnnotationPresent(string P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EisAnnotationPresent(this, P_0);
	}


	public virtual bool isAnnotationPresent(Class P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EisAnnotationPresent(this, P_0);
	}


	public virtual Optional getAnnotationByName(string P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EgetAnnotationByName(this, P_0);
	}


	public virtual Optional getAnnotationByClass(Class P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EgetAnnotationByClass(this, P_0);
	}


	public virtual Node setName(string P_0)
	{
		return NodeWithSimpleName._003Cdefault_003EsetName(this, P_0);
	}


	public virtual NameExpr getNameAsExpression()
	{
		return NodeWithSimpleName._003Cdefault_003EgetNameAsExpression(this);
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

	
	static Parameter()
	{
		Node.___003Cclinit_003E();
	}

	Node NodeWithType.NodeWithType_003A_003AsetType(Type P_0)
	{
		return _003Cbridge_003EsetType(P_0);
	}

	Node NodeWithAnnotations.NodeWithAnnotations_003A_003AsetAnnotations(NodeList P_0)
	{
		return _003Cbridge_003EsetAnnotations(P_0);
	}

	Node NodeWithSimpleName.NodeWithSimpleName_003A_003AsetName(SimpleName P_0)
	{
		return _003Cbridge_003EsetName(P_0);
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
