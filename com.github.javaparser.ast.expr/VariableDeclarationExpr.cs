using System.ComponentModel;

using com.github.javaparser.ast.body;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.nodeTypes.modifiers;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.type;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;

using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.ast.expr;


public class VariableDeclarationExpr : Expression, NodeWithFinalModifier, NodeWithModifiers, NodeWithAnnotations, NodeWithVariables
{
	
	private sealed class ___003C_003EAnon0 : Supplier
	{
		internal ___003C_003EAnon0()
		{
		}

		public object get()
		{
			NodeList result = lambda_0024new_00240();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon1 : Supplier
	{
		internal ___003C_003EAnon1()
		{
		}

		public object get()
		{
			NodeList result = lambda_0024new_00241();
			
			return result;
		}
	}

		private NodeList modifiers;

		private NodeList annotations;

		[NonEmptyProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/NonEmptyProperty;"
	})]
	private NodeList variables;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
		
	
	public VariableDeclarationExpr(TokenRange tokenRange, NodeList modifiers, NodeList annotations, NodeList variables)
		: base(tokenRange)
	{
		setModifiers(modifiers);
		setAnnotations(annotations);
		setVariables(variables);
		customInitialization();
	}

	
		
	
	public virtual VariableDeclarationExpr setModifiers(NodeList modifiers)
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

	
		
	
	public virtual VariableDeclarationExpr setAnnotations(NodeList annotations)
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

	
		
	
	public virtual VariableDeclarationExpr setVariables(NodeList variables)
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

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual VariableDeclarationExprMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EvariableDeclarationExprMetaModel;
	}

	
	
	public new virtual VariableDeclarationExpr clone()
	{
		return (VariableDeclarationExpr)accept(new CloneVisitor(), null);
	}

	
	
	
	private static NodeList lambda_0024new_00240()
	{
		NodeList result = new NodeList();
		
		return result;
	}

	
	
	
	private static NodeList lambda_0024new_00241()
	{
		NodeList result = new NodeList();
		
		return result;
	}

	
	
	public VariableDeclarationExpr()
		: this(null, new NodeList(), new NodeList(), new NodeList())
	{
	}

	
	
	
	public VariableDeclarationExpr(Type type, string variableName)
		: this(null, new NodeList(), new NodeList(), NodeList.nodeList(new VariableDeclarator(type, variableName)))
	{
	}

	
	
	
	public VariableDeclarationExpr(VariableDeclarator var)
		: this(null, new NodeList(), new NodeList(), NodeList.nodeList(var))
	{
	}

	
	
	
	public VariableDeclarationExpr(Type type, string variableName, params Modifier[] modifiers)
		: this(null, (NodeList)Arrays.stream(modifiers).collect(Collectors.toCollection(new ___003C_003EAnon0())), new NodeList(), NodeList.nodeList(new VariableDeclarator(type, variableName)))
	{
	}

	
	
	
	public VariableDeclarationExpr(VariableDeclarator var, params Modifier[] modifiers)
		: this(null, (NodeList)Arrays.stream(modifiers).collect(Collectors.toCollection(new ___003C_003EAnon1())), new NodeList(), NodeList.nodeList(var))
	{
	}

	
		
	
	public VariableDeclarationExpr(NodeList variables)
		: this(null, new NodeList(), new NodeList(), variables)
	{
	}

	
		
	
	public VariableDeclarationExpr(NodeList modifiers, NodeList variables)
		: this(null, modifiers, new NodeList(), variables)
	{
	}

	
		
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public VariableDeclarationExpr(NodeList modifiers, NodeList annotations, NodeList variables)
		: this(null, modifiers, annotations, variables)
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

		public virtual NodeList getModifiers()
	{
		return modifiers;
	}

		public virtual NodeList getVariables()
	{
		return variables;
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

	public override bool isVariableDeclarationExpr()
	{
		return true;
	}

	public override VariableDeclarationExpr asVariableDeclarationExpr()
	{
		return this;
	}

	
		
	
	public override void ifVariableDeclarationExpr(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toVariableDeclarationExpr()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual ExpressionMetaModel _003Cbridge_003EgetMetaModel()
	{
		VariableDeclarationExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Expression _003Cbridge_003Eclone()
	{
		VariableDeclarationExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		VariableDeclarationExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		VariableDeclarationExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		VariableDeclarationExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetModifiers(NodeList modifiers)
	{
		VariableDeclarationExpr result = setModifiers(modifiers);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetAnnotations(NodeList annotations)
	{
		VariableDeclarationExpr result = setAnnotations(annotations);
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetVariables(NodeList variables)
	{
		VariableDeclarationExpr result = setVariables(variables);
		
		return result;
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
	public virtual Node setModifier(Modifier.Keyword P_0, bool P_1)
	{
		return NodeWithModifiers._003Cdefault_003EsetModifier(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool hasModifier(Modifier.Keyword P_0)
	{
		return NodeWithModifiers._003Cdefault_003EhasModifier(this, P_0);
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
	public virtual bool isFinal()
	{
		return NodeWithFinalModifier._003Cdefault_003EisFinal(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setFinal(bool P_0)
	{
		return NodeWithFinalModifier._003Cdefault_003EsetFinal(this, P_0);
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

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual VariableDeclarator getVariable(int P_0)
	{
		return NodeWithVariables._003Cdefault_003EgetVariable(this, P_0);
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

	
	static VariableDeclarationExpr()
	{
		Expression.___003Cclinit_003E();
	}

	Node NodeWithModifiers.NodeWithModifiers_003A_003AsetModifiers(NodeList P_0)
	{
		return _003Cbridge_003EsetModifiers(P_0);
	}

	Node NodeWithAnnotations.NodeWithAnnotations_003A_003AsetAnnotations(NodeList P_0)
	{
		return _003Cbridge_003EsetAnnotations(P_0);
	}

	Node NodeWithVariables.NodeWithVariables_003A_003AsetVariables(NodeList P_0)
	{
		return _003Cbridge_003EsetVariables(P_0);
	}
}
