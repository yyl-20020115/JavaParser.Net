using System.ComponentModel;

using com.github.javaparser.ast.body;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.type;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;

using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.expr;


public class LambdaExpr : Expression, NodeWithParameters
{
		private NodeList parameters;

	private bool m_isEnclosingParameters;

	private Statement body;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
		
	
	public LambdaExpr(TokenRange tokenRange, NodeList parameters, Statement body, bool isEnclosingParameters)
		: base(tokenRange)
	{
		setParameters(parameters);
		setBody(body);
		setEnclosingParameters(isEnclosingParameters);
		customInitialization();
	}

	
		
	
	public virtual LambdaExpr setParameters(NodeList parameters)
	{
		Utils.assertNotNull(parameters);
		if (parameters == this.parameters)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EPARAMETERS, this.parameters, parameters);
		if (this.parameters != null)
		{
			this.parameters.setParentNode(null);
		}
		this.parameters = parameters;
		setAsParentNodeOf(parameters);
		return this;
	}

	
	
	
	public virtual LambdaExpr setBody(Statement body)
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

	
	
	
	public virtual LambdaExpr setEnclosingParameters(bool isEnclosingParameters)
	{
		if (isEnclosingParameters == this.m_isEnclosingParameters)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EENCLOSING_PARAMETERS, Boolean.valueOf(this.m_isEnclosingParameters), Boolean.valueOf(isEnclosingParameters));
		this.m_isEnclosingParameters = isEnclosingParameters;
		return this;
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual LambdaExprMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003ElambdaExprMetaModel;
	}

	
	
	public new virtual LambdaExpr clone()
	{
		return (LambdaExpr)accept(new CloneVisitor(), null);
	}

	
	
	public LambdaExpr()
		: this(null, new NodeList(), new ReturnStmt(), isEnclosingParameters: false)
	{
	}

	
	
	
	public LambdaExpr(Parameter parameter, BlockStmt body)
		: this(null, new NodeList(parameter), body, isEnclosingParameters: false)
	{
	}

	
		
	
	public LambdaExpr(NodeList parameters, BlockStmt body)
		: this(null, parameters, body, isEnclosingParameters: true)
	{
	}

	
	
	
	public LambdaExpr(Parameter parameter, Expression body)
		: this(null, new NodeList(parameter), new ExpressionStmt(body), isEnclosingParameters: false)
	{
	}

	
		
	
	public LambdaExpr(NodeList parameters, Expression body)
		: this(null, parameters, new ExpressionStmt(body), isEnclosingParameters: true)
	{
	}

	
		
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public LambdaExpr(NodeList parameters, Statement body, bool isEnclosingParameters)
		: this(null, parameters, body, isEnclosingParameters)
	{
	}

		public virtual NodeList getParameters()
	{
		return parameters;
	}

	public virtual Statement getBody()
	{
		return body;
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	public virtual bool isEnclosingParameters()
	{
		return this.m_isEnclosingParameters;
	}

	
	
	
	public override bool remove(Node node)
	{
		if (node == null)
		{
			return false;
		}
		for (int i = 0; i < parameters.size(); i++)
		{
			if (parameters.get(i) == node)
			{
				parameters.remove(i);
				return true;
			}
		}
		bool result = base.remove(node);
		
		return result;
	}

	
		
	[DerivedProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/DerivedProperty;"
	})]
	public virtual Optional getExpressionBody()
	{
		if (body.isExpressionStmt())
		{
			Optional result = Optional.of(body.asExpressionStmt().getExpression());
			
			return result;
		}
		Optional result2 = Optional.empty();
		
		return result2;
	}

	
	
	
	public override bool replace(Node node, Node replacementNode)
	{
		if (node == null)
		{
			return false;
		}
		if (node == body)
		{
			setBody((Statement)replacementNode);
			return true;
		}
		for (int i = 0; i < parameters.size(); i++)
		{
			if (parameters.get(i) == node)
			{
				parameters.set(i, (Parameter)replacementNode);
				return true;
			}
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isLambdaExpr()
	{
		return true;
	}

	public override LambdaExpr asLambdaExpr()
	{
		return this;
	}

	
		
	
	public override void ifLambdaExpr(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toLambdaExpr()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	public override bool isPolyExpression()
	{
		return true;
	}

	
	
	
	
	public new virtual ExpressionMetaModel _003Cbridge_003EgetMetaModel()
	{
		LambdaExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Expression _003Cbridge_003Eclone()
	{
		LambdaExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		LambdaExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		LambdaExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		LambdaExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetParameters(NodeList parameters)
	{
		LambdaExpr result = setParameters(parameters);
		
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Parameter getParameter(int P_0)
	{
		return NodeWithParameters._003Cdefault_003EgetParameter(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setParameter(int P_0, Parameter P_1)
	{
		return NodeWithParameters._003Cdefault_003EsetParameter(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addParameter(Type P_0, string P_1)
	{
		return NodeWithParameters._003Cdefault_003EaddParameter(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addParameter(Class P_0, string P_1)
	{
		return NodeWithParameters._003Cdefault_003EaddParameter(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addParameter(string P_0, string P_1)
	{
		return NodeWithParameters._003Cdefault_003EaddParameter(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addParameter(Parameter P_0)
	{
		return NodeWithParameters._003Cdefault_003EaddParameter(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Parameter addAndGetParameter(Type P_0, string P_1)
	{
		return NodeWithParameters._003Cdefault_003EaddAndGetParameter(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Parameter addAndGetParameter(Class P_0, string P_1)
	{
		return NodeWithParameters._003Cdefault_003EaddAndGetParameter(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Parameter addAndGetParameter(string P_0, string P_1)
	{
		return NodeWithParameters._003Cdefault_003EaddAndGetParameter(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Parameter addAndGetParameter(Parameter P_0)
	{
		return NodeWithParameters._003Cdefault_003EaddAndGetParameter(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional getParameterByName(string P_0)
	{
		return NodeWithParameters._003Cdefault_003EgetParameterByName(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional getParameterByType(string P_0)
	{
		return NodeWithParameters._003Cdefault_003EgetParameterByType(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional getParameterByType(Class P_0)
	{
		return NodeWithParameters._003Cdefault_003EgetParameterByType(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool hasParametersOfType(string[] P_0)
	{
		return NodeWithParameters._003Cdefault_003EhasParametersOfType(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool hasParametersOfType(Class[] P_0)
	{
		return NodeWithParameters._003Cdefault_003EhasParametersOfType(this, P_0);
	}

	
	static LambdaExpr()
	{
		Expression.___003Cclinit_003E();
	}

	Node NodeWithParameters.NodeWithParameters_003A_003AsetParameters(NodeList P_0)
	{
		return _003Cbridge_003EsetParameters(P_0);
	}
}
