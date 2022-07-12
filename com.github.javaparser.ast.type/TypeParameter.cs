using System.ComponentModel;

using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.resolution.types;
using com.github.javaparser.utils;

using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.ast.type;


public class TypeParameter : ReferenceType, NodeWithSimpleName, NodeWithAnnotations
{
	
	private sealed class ___003C_003EAnon0 : Consumer
	{
		private readonly StringBuilder arg_00241;

		internal ___003C_003EAnon0(StringBuilder P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			lambda_0024asString_00240(arg_00241, (NodeList)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Function
	{
		internal ___003C_003EAnon1()
		{
		}

		public object apply(object P_0)
		{
			string result = ((ClassOrInterfaceType)P_0).asString();
			
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

		private NodeList typeBound;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
		
	
	public TypeParameter(TokenRange tokenRange, SimpleName name, NodeList typeBound, NodeList annotations)
		: base(tokenRange, annotations)
	{
		setName(name);
		setTypeBound(typeBound);
		customInitialization();
	}

	
	
	
	public virtual TypeParameter setName(SimpleName name)
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

	
		
	
	public virtual TypeParameter setTypeBound(NodeList typeBound)
	{
		Utils.assertNotNull(typeBound);
		if (typeBound == this.typeBound)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ETYPE_BOUND, this.typeBound, typeBound);
		if (this.typeBound != null)
		{
			this.typeBound.setParentNode(null);
		}
		this.typeBound = typeBound;
		setAsParentNodeOf(typeBound);
		return this;
	}


	public virtual string getNameAsString()
	{
		return NodeWithSimpleName._003Cdefault_003EgetNameAsString(this);
	}

		public virtual NodeList getTypeBound()
	{
		return typeBound;
	}

	
	
	public new virtual ResolvedTypeVariable resolve()
	{
		return (ResolvedTypeVariable)getSymbolResolver().toResolvedType(this, ClassLiteral<ResolvedTypeVariable>.Value);
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual TypeParameterMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EtypeParameterMetaModel;
	}

	
	
	public new virtual TypeParameter clone()
	{
		return (TypeParameter)accept(new CloneVisitor(), null);
	}

	
		
	
	public new virtual TypeParameter setAnnotations(NodeList annotations)
	{
		base.setAnnotations(annotations);
		return this;
	}

	
	
	
	
	private static void lambda_0024asString_00240(StringBuilder str, NodeList l)
	{
		Stream obj = l.stream().map(new ___003C_003EAnon1());
		object __003Cref_003E = "";
		object __003Cref_003E2 = " extends ";
		CharSequence charSequence = default(CharSequence);
		object obj2 = (charSequence.___003Cref_003E = "&");
		CharSequence delimiter = charSequence;
		obj2 = (charSequence.___003Cref_003E = __003Cref_003E2);
		CharSequence prefix = charSequence;
		obj2 = (charSequence.___003Cref_003E = __003Cref_003E);
		str.append((string)obj.collect(Collectors.joining(delimiter, prefix, charSequence)));
	}

	
	
	public TypeParameter()
		: this(null, new SimpleName(), new NodeList(), new NodeList())
	{
	}

	
	
	
	public TypeParameter(string name)
		: this(null, new SimpleName(name), new NodeList(), new NodeList())
	{
	}

	
		
	
	public TypeParameter(string name, NodeList typeBound)
		: this(null, new SimpleName(name), typeBound, new NodeList())
	{
	}

	
		
	
	
	public TypeParameter(SimpleName name, NodeList typeBound, NodeList annotations)
		: this(null, name, typeBound, annotations)
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	public virtual SimpleName getName()
	{
		return name;
	}

	
	
	
	public override bool remove(Node node)
	{
		if (node == null)
		{
			return false;
		}
		for (int i = 0; i < typeBound.size(); i++)
		{
			if (typeBound.get(i) == node)
			{
				typeBound.remove(i);
				return true;
			}
		}
		bool result = base.remove(node);
		
		return result;
	}

	
	
	public override string asString()
	{
		StringBuilder stringBuilder = new StringBuilder(getNameAsString());
		getTypeBound().ifNonEmpty(new ___003C_003EAnon0(stringBuilder));
		string result = stringBuilder.ToString();
		
		return result;
	}

	
	
	public override string toDescriptor()
	{
		string result = String.format("L%s;", resolve().qualifiedName());
		
		return result;
	}

	
	
	
	public override bool replace(Node node, Node replacementNode)
	{
		if (node == null)
		{
			return false;
		}
		if (node == name)
		{
			setName((SimpleName)replacementNode);
			return true;
		}
		for (int i = 0; i < typeBound.size(); i++)
		{
			if (typeBound.get(i) == node)
			{
				typeBound.set(i, (ClassOrInterfaceType)replacementNode);
				return true;
			}
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isTypeParameter()
	{
		return true;
	}

	public override TypeParameter asTypeParameter()
	{
		return this;
	}

	
		
	
	public override void ifTypeParameter(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toTypeParameter()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual ReferenceTypeMetaModel _003Cbridge_003EgetMetaModel()
	{
		TypeParameterMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual ReferenceType _003Cbridge_003Eclone()
	{
		TypeParameter result = clone();
		
		return result;
	}

	
	
	
	
	public new virtual ResolvedType _003Cbridge_003Eresolve()
	{
		ResolvedTypeVariable result = resolve();
		
		return result;
	}

	
	
	
	
	public override TypeMetaModel _003Cbridge_003EgetMetaModel()
	{
		TypeParameterMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Type _003Cbridge_003Eclone()
	{
		TypeParameter result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Type _003Cbridge_003EsetAnnotations(NodeList annotations)
	{
		TypeParameter result = setAnnotations(annotations);
		
		return result;
	}

	
	
	
	
	public override object _003Cbridge_003Eresolve()
	{
		ResolvedTypeVariable result = resolve();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		TypeParameterMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		TypeParameter result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		TypeParameter result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetName(SimpleName name)
	{
		TypeParameter result = setName(name);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetAnnotations(NodeList annotations)
	{
		TypeParameter result = setAnnotations(annotations);
		
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

	
	static TypeParameter()
	{
		ReferenceType.___003Cclinit_003E();
	}

	Node NodeWithSimpleName.NodeWithSimpleName_003A_003AsetName(SimpleName P_0)
	{
		return _003Cbridge_003EsetName(P_0);
	}

	Node NodeWithAnnotations.NodeWithAnnotations_003A_003AsetAnnotations(NodeList P_0)
	{
		return this._003Cbridge_003EsetAnnotations(P_0);
	}
}
