using System;
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

namespace com.github.javaparser.ast.type;


public class ArrayType : ReferenceType, NodeWithAnnotations
{
	public class ArrayBracketPair
	{
		private TokenRange tokenRange;

				private NodeList annotations;

		private Origin origin;

		
		public virtual ArrayBracketPair setTokenRange(TokenRange range)
		{
			tokenRange = range;
			return this;
		}

		
				
		
		public virtual ArrayBracketPair setAnnotations(NodeList annotations)
		{
			this.annotations = (NodeList)Utils.assertNotNull(annotations);
			return this;
		}

		
		
		
		public virtual ArrayBracketPair setOrigin(Origin origin)
		{
			this.origin = (Origin)Utils.assertNotNull(origin);
			return this;
		}

		
				
		
		public ArrayBracketPair(TokenRange tokenRange, Origin origin, NodeList annotations)
		{
			this.annotations = new NodeList();
			setTokenRange(tokenRange);
			setAnnotations(annotations);
			setOrigin(origin);
		}

				public virtual NodeList getAnnotations()
		{
			return annotations;
		}

		
				
		public virtual Optional getTokenRange()
		{
			Optional result = Optional.ofNullable(tokenRange);
			
			return result;
		}

		public virtual Origin getOrigin()
		{
			return origin;
		}
	}

	
	
		
	public class Origin : java.lang.Enum
	{
		
		
		public enum __Enum
		{
			NAME,
			TYPE
		}

		
		internal static Origin ___003C_003ENAME;

		
		internal static Origin ___003C_003ETYPE;

		
		private static Origin[] _0024VALUES;

		
		public static Origin NAME
		{
			
			get
			{
				return ___003C_003ENAME;
			}
		}

		
		public static Origin TYPE
		{
			
			get
			{
				return ___003C_003ETYPE;
			}
		}

		
		
		public static void ___003Cclinit_003E()
		{
		}

		
				
		
		private Origin(string _0024enum_0024name, int _0024enum_0024ordinal)
			: base(_0024enum_0024name, _0024enum_0024ordinal)
		{
			GC.KeepAlive(this);
		}

		
		
		public static Origin[] values()
		{
			return (Origin[])_0024VALUES.Clone();
		}

		
		
		
		public static Origin valueOf(string name)
		{
			return (Origin)java.lang.Enum.valueOf(ClassLiteral<Origin>.Value, name);
		}

		
		static Origin()
		{
			___003C_003ENAME = new Origin("NAME", 0);
			___003C_003ETYPE = new Origin("TYPE", 1);
			_0024VALUES = new Origin[2] { ___003C_003ENAME, ___003C_003ETYPE };
		}
	}

	private Type componentType;

	private Origin origin;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	
	public ArrayType(Type type, params AnnotationExpr[] annotations)
		: this(type, Origin.___003C_003ETYPE, NodeList.nodeList(annotations))
	{
	}

	
		
	
	
	public ArrayType(Type componentType, Origin origin, NodeList annotations)
		: this(null, componentType, origin, annotations)
	{
	}

	public virtual Type getComponentType()
	{
		return componentType;
	}

	
		
	
	public ArrayType(TokenRange tokenRange, Type componentType, Origin origin, NodeList annotations)
		: base(tokenRange, annotations)
	{
		setComponentType(componentType);
		setOrigin(origin);
		customInitialization();
	}

	
	
	
	public virtual ArrayType setComponentType(Type componentType)
	{
		Utils.assertNotNull(componentType);
		if (componentType == this.componentType)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ECOMPONENT_TYPE, this.componentType, componentType);
		if (this.componentType != null)
		{
			this.componentType.setParentNode(null);
		}
		this.componentType = componentType;
		setAsParentNodeOf(componentType);
		return this;
	}

	
	
	
	public virtual ArrayType setOrigin(Origin origin)
	{
		Utils.assertNotNull(origin);
		if (origin == this.origin)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EORIGIN, this.origin, origin);
		this.origin = origin;
		return this;
	}

	public virtual Origin getOrigin()
	{
		return origin;
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual ArrayTypeMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EarrayTypeMetaModel;
	}

	
	
	public new virtual ArrayType clone()
	{
		return (ArrayType)accept(new CloneVisitor(), null);
	}

	
	
	public new virtual ResolvedArrayType resolve()
	{
		return (ResolvedArrayType)getSymbolResolver().toResolvedType(this, ClassLiteral<ResolvedArrayType>.Value);
	}

	
		
	
	public new virtual ArrayType setAnnotations(NodeList annotations)
	{
		return (ArrayType)base.setAnnotations(annotations);
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	
		
	
	
	public static Type wrapInArrayTypes(Type type, params List[] arrayBracketPairLists)
	{
		for (int i = (int)((nint)arrayBracketPairLists.LongLength - 1); i >= 0; i += -1)
		{
			List list = arrayBracketPairLists[i];
			if (list == null)
			{
				continue;
			}
			for (int j = list.size() - 1; j >= 0; j += -1)
			{
				ArrayBracketPair arrayBracketPair = (ArrayBracketPair)list.get(j);
				TokenRange tokenRange = null;
				if (type.getTokenRange().isPresent() && arrayBracketPair.getTokenRange().isPresent())
				{
					TokenRange.___003Cclinit_003E();
					tokenRange = new TokenRange(((TokenRange)type.getTokenRange().get()).getBegin(), ((TokenRange)arrayBracketPair.getTokenRange().get()).getEnd());
				}
				type = new ArrayType(tokenRange, type, arrayBracketPair.getOrigin(), arrayBracketPair.getAnnotations());
				if (tokenRange != null)
				{
					((ArrayType)type).setRange((Range)tokenRange.toRange().get());
				}
			}
		}
		return type;
	}

	
		
	
	public static Pair unwrapArrayTypes(Type type)
	{
		ArrayList arrayList = new ArrayList(0);
		while (type is ArrayType)
		{
			ArrayType arrayType = (ArrayType)type;
			((List)arrayList).add((object)new ArrayBracketPair((TokenRange)type.getTokenRange().orElse(null), arrayType.getOrigin(), arrayType.getAnnotations()));
			type = arrayType.getComponentType();
		}
		Pair result = new Pair(type, arrayList);
		
		return result;
	}

	
	
	public override string asString()
	{
		string result = new StringBuilder().append(componentType.asString()).append("[]").ToString();
		
		return result;
	}

	
	
	public override string toDescriptor()
	{
		StringBuffer stringBuffer = new StringBuffer();
		stringBuffer.append("[");
		stringBuffer.append(componentType.toDescriptor());
		string result = stringBuffer.ToString();
		
		return result;
	}

	
	
	
	public override bool replace(Node node, Node replacementNode)
	{
		if (node == null)
		{
			return false;
		}
		if (node == componentType)
		{
			setComponentType((Type)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isArrayType()
	{
		return true;
	}

	public override ArrayType asArrayType()
	{
		return this;
	}

	
		
	
	public override void ifArrayType(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toArrayType()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	public override Type getElementType()
	{
		Type elementType = getComponentType().getElementType();
		
		return elementType;
	}

	
	
	public override int getArrayLevel()
	{
		return 1 + getComponentType().getArrayLevel();
	}

	
	
	
	
	public new virtual ReferenceTypeMetaModel _003Cbridge_003EgetMetaModel()
	{
		ArrayTypeMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual ReferenceType _003Cbridge_003Eclone()
	{
		ArrayType result = clone();
		
		return result;
	}

	
	
	
	
	public new virtual ResolvedType _003Cbridge_003Eresolve()
	{
		ResolvedArrayType result = resolve();
		
		return result;
	}

	
	
	
	
	public override TypeMetaModel _003Cbridge_003EgetMetaModel()
	{
		ArrayTypeMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Type _003Cbridge_003Eclone()
	{
		ArrayType result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Type _003Cbridge_003EsetAnnotations(NodeList annotations)
	{
		ArrayType result = setAnnotations(annotations);
		
		return result;
	}

	
	
	
	
	public override object _003Cbridge_003Eresolve()
	{
		ResolvedArrayType result = resolve();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		ArrayTypeMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		ArrayType result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		ArrayType result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetAnnotations(NodeList annotations)
	{
		ArrayType result = setAnnotations(annotations);
		
		return result;
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

	
	static ArrayType()
	{
		ReferenceType.___003Cclinit_003E();
	}

	Node NodeWithAnnotations.NodeWithAnnotations_003A_003AsetAnnotations(NodeList P_0)
	{
		return this._003Cbridge_003EsetAnnotations(P_0);
	}
}
