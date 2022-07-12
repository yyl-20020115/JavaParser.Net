using System.ComponentModel;

using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.type;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;


namespace com.github.javaparser.ast.stmt;


public class CatchClause : Node, NodeWithBlockStmt
{
	private Parameter parameter;

	private BlockStmt body;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	
	public CatchClause(TokenRange tokenRange, Parameter parameter, BlockStmt body)
		: base(tokenRange)
	{
		setParameter(parameter);
		setBody(body);
		customInitialization();
	}

	
	
	
	public virtual CatchClause setParameter(Parameter parameter)
	{
		Utils.assertNotNull(parameter);
		if (parameter == this.parameter)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EPARAMETER, this.parameter, parameter);
		if (this.parameter != null)
		{
			this.parameter.setParentNode(null);
		}
		this.parameter = parameter;
		setAsParentNodeOf(parameter);
		return this;
	}

	
	
	
	public virtual CatchClause setBody(BlockStmt body)
	{
		Utils.assertNotNull(body);
		if (body == this.body)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EBODY, this.body, body);
		if (this.body != null)
		{
			this.body.setParentNode(null);
		}
		this.body = body;
		setAsParentNodeOf(body);
		return this;
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual CatchClauseMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EcatchClauseMetaModel;
	}

	
	
	public new virtual CatchClause clone()
	{
		return (CatchClause)accept(new CloneVisitor(), null);
	}

	
	
	public CatchClause()
		: this(null, new Parameter(), new BlockStmt())
	{
	}

	
		
	
	public CatchClause(NodeList exceptModifier, NodeList exceptAnnotations, ClassOrInterfaceType exceptType, SimpleName exceptName, BlockStmt body)
	{
		Parameter.___003Cclinit_003E();
		this._002Ector(null, new Parameter(null, exceptModifier, exceptAnnotations, exceptType, isVarArgs: false, new NodeList(), exceptName), body);
	}

	
	
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public CatchClause(Parameter parameter, BlockStmt body)
		: this(null, parameter, body)
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	public virtual Parameter getParameter()
	{
		return parameter;
	}

	public virtual BlockStmt getBody()
	{
		return body;
	}

	
	
	
	public override bool replace(Node node, Node replacementNode)
	{
		if (node == null)
		{
			return false;
		}
		if (node == body)
		{
			setBody((BlockStmt)replacementNode);
			return true;
		}
		if (node == parameter)
		{
			setParameter((Parameter)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	
	
	
	
	public virtual NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		CatchClauseMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Node _003Cbridge_003Eclone()
	{
		CatchClause result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		CatchClause result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetBody(BlockStmt body)
	{
		CatchClause result = setBody(body);
		
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual BlockStmt createBody()
	{
		return NodeWithBlockStmt._003Cdefault_003EcreateBody(this);
	}

	
	static CatchClause()
	{
		Node.___003Cclinit_003E();
	}

	Node NodeWithBlockStmt.NodeWithBlockStmt_003A_003AsetBody(BlockStmt P_0)
	{
		return _003Cbridge_003EsetBody(P_0);
	}
}
