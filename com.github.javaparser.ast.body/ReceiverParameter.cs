using System.ComponentModel;

using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.type;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;

using java.lang;
using java.util;

namespace com.github.javaparser.ast.body;


public class ReceiverParameter : Node, NodeWithType, NodeWithAnnotations, NodeWithName
{
	private Type type;

		private NodeList annotations;

	private Name name;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
		
	
	public ReceiverParameter(TokenRange tokenRange, NodeList annotations, Type type, Name name)
		: base(tokenRange)
	{
		setAnnotations(annotations);
		setType(type);
		setName(name);
		customInitialization();
	}

	
		
	
	public virtual ReceiverParameter setAnnotations(NodeList annotations)
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

	
	
	
	public virtual ReceiverParameter setType(Type type)
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

	
	
	
	public virtual ReceiverParameter setName(Name name)
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

	
	
	public new virtual ReceiverParameterMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EreceiverParameterMetaModel;
	}

	
	
	public new virtual ReceiverParameter clone()
	{
		return (ReceiverParameter)accept(new CloneVisitor(), null);
	}

	
	
	public ReceiverParameter()
		: this(null, new NodeList(), new ClassOrInterfaceType(), new Name())
	{
	}

	
	
	
	public ReceiverParameter(Type type, Name name)
		: this(null, new NodeList(), type, name)
	{
	}

	
	
	
	public ReceiverParameter(Type type, string name)
		: this(null, new NodeList(), type, new Name(name))
	{
	}

	
		
	
	
	public ReceiverParameter(NodeList annotations, Type type, Name name)
		: this(null, annotations, type, name)
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	public virtual Type getType()
	{
		return type;
	}

		public virtual NodeList getAnnotations()
	{
		return annotations;
	}

	public virtual Name getName()
	{
		return name;
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
		bool result = base.remove(node);
		
		return result;
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
		if (node == name)
		{
			setName((Name)replacementNode);
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

	
	
	
	
	public virtual NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		ReceiverParameterMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Node _003Cbridge_003Eclone()
	{
		ReceiverParameter result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		ReceiverParameter result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetType(Type type)
	{
		ReceiverParameter result = setType(type);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetAnnotations(NodeList annotations)
	{
		ReceiverParameter result = setAnnotations(annotations);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetName(Name name)
	{
		ReceiverParameter result = setName(name);
		
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
		return NodeWithName._003Cdefault_003EsetName(this, P_0);
	}


	public virtual string getNameAsString()
	{
		return NodeWithName._003Cdefault_003EgetNameAsString(this);
	}

	
	static ReceiverParameter()
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

	Node NodeWithName.NodeWithName_003A_003AsetName(Name P_0)
	{
		return _003Cbridge_003EsetName(P_0);
	}
}
