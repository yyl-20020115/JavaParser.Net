using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.resolution.types;
using com.github.javaparser.utils;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.ast.type;


public class IntersectionType : Type, NodeWithAnnotations
{
	
	private sealed class ___003C_003EAnon0 : Function
	{
		internal ___003C_003EAnon0()
		{
		}

		public object apply(object P_0)
		{
			string result = ((ReferenceType)P_0).asString();
			
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

		[NonEmptyProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/NonEmptyProperty;"
	})]
	private NodeList elements;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public IntersectionType(TokenRange tokenRange, NodeList elements)
		: base(tokenRange)
	{
		setElements(elements);
		customInitialization();
	}

	
		
	
	public virtual IntersectionType setElements(NodeList elements)
	{
		Utils.assertNotNull(elements);
		if (elements == this.elements)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EELEMENTS, this.elements, elements);
		if (this.elements != null)
		{
			this.elements.setParentNode(null);
		}
		this.elements = elements;
		setAsParentNodeOf(elements);
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

	
	
	public new virtual ResolvedIntersectionType resolve()
	{
		return (ResolvedIntersectionType)getSymbolResolver().toResolvedType(this, ClassLiteral<ResolvedIntersectionType>.Value);
	}

	
	
	public new virtual IntersectionTypeMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EintersectionTypeMetaModel;
	}

	
	
	public new virtual IntersectionType clone()
	{
		return (IntersectionType)accept(new CloneVisitor(), null);
	}

	
		
	
	public new virtual IntersectionType setAnnotations(NodeList annotations)
	{
		return (IntersectionType)base.setAnnotations(annotations);
	}

	
		
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public IntersectionType(NodeList elements)
		: this(null, elements)
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

		public virtual NodeList getElements()
	{
		return elements;
	}

	
	
	
	public override bool remove(Node node)
	{
		if (node == null)
		{
			return false;
		}
		for (int i = 0; i < elements.size(); i++)
		{
			if (elements.get(i) == node)
			{
				elements.remove(i);
				return true;
			}
		}
		bool result = base.remove(node);
		
		return result;
	}

	
	
	public override string asString()
	{
		Stream obj = elements.stream().map(new ___003C_003EAnon0());
		CharSequence delimiter = default(CharSequence);
		object obj2 = (delimiter.___003Cref_003E = "&");
		return (string)obj.collect(Collectors.joining(delimiter));
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public override bool replace(Node node, Node replacementNode)
	{
		if (node == null)
		{
			return false;
		}
		for (int i = 0; i < elements.size(); i++)
		{
			if (elements.get(i) == node)
			{
				elements.set(i, (ReferenceType)replacementNode);
				return true;
			}
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isIntersectionType()
	{
		return true;
	}

	public override IntersectionType asIntersectionType()
	{
		return this;
	}

	
		
	
	public override void ifIntersectionType(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toIntersectionType()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual ResolvedType _003Cbridge_003Eresolve()
	{
		ResolvedIntersectionType result = resolve();
		
		return result;
	}

	
	
	
	
	public new virtual TypeMetaModel _003Cbridge_003EgetMetaModel()
	{
		IntersectionTypeMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Type _003Cbridge_003Eclone()
	{
		IntersectionType result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Type _003Cbridge_003EsetAnnotations(NodeList annotations)
	{
		IntersectionType result = setAnnotations(annotations);
		
		return result;
	}

	
	
	
	
	public override object _003Cbridge_003Eresolve()
	{
		ResolvedIntersectionType result = resolve();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		IntersectionTypeMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		IntersectionType result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		IntersectionType result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetAnnotations(NodeList annotations)
	{
		IntersectionType result = setAnnotations(annotations);
		
		return result;
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

	
	static IntersectionType()
	{
		Type.___003Cclinit_003E();
	}

	Node NodeWithAnnotations.NodeWithAnnotations_003A_003AsetAnnotations(NodeList P_0)
	{
		return this._003Cbridge_003EsetAnnotations(P_0);
	}
}
