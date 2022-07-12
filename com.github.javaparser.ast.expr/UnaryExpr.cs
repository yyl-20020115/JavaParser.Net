using System;
using System.ComponentModel;

using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.printer;
using com.github.javaparser.utils;

using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.expr;


public class UnaryExpr : Expression, NodeWithExpression
{
	
	
		
	
	public class Operator : java.lang.Enum, Stringable
	{
		
		
		public enum __Enum
		{
			PLUS,
			MINUS,
			PREFIX_INCREMENT,
			PREFIX_DECREMENT,
			LOGICAL_COMPLEMENT,
			BITWISE_COMPLEMENT,
			POSTFIX_INCREMENT,
			POSTFIX_DECREMENT
		}

		
		internal static Operator ___003C_003EPLUS;

		
		internal static Operator ___003C_003EMINUS;

		
		internal static Operator ___003C_003EPREFIX_INCREMENT;

		
		internal static Operator ___003C_003EPREFIX_DECREMENT;

		
		internal static Operator ___003C_003ELOGICAL_COMPLEMENT;

		
		internal static Operator ___003C_003EBITWISE_COMPLEMENT;

		
		internal static Operator ___003C_003EPOSTFIX_INCREMENT;

		
		internal static Operator ___003C_003EPOSTFIX_DECREMENT;

		
		private string codeRepresentation;

		
		private bool m_isPostfix;

		
		private static Operator[] _0024VALUES;

		
		public static Operator PLUS
		{
			
			get
			{
				return ___003C_003EPLUS;
			}
		}

		
		public static Operator MINUS
		{
			
			get
			{
				return ___003C_003EMINUS;
			}
		}

		
		public static Operator PREFIX_INCREMENT
		{
			
			get
			{
				return ___003C_003EPREFIX_INCREMENT;
			}
		}

		
		public static Operator PREFIX_DECREMENT
		{
			
			get
			{
				return ___003C_003EPREFIX_DECREMENT;
			}
		}

		
		public static Operator LOGICAL_COMPLEMENT
		{
			
			get
			{
				return ___003C_003ELOGICAL_COMPLEMENT;
			}
		}

		
		public static Operator BITWISE_COMPLEMENT
		{
			
			get
			{
				return ___003C_003EBITWISE_COMPLEMENT;
			}
		}

		
		public static Operator POSTFIX_INCREMENT
		{
			
			get
			{
				return ___003C_003EPOSTFIX_INCREMENT;
			}
		}

		
		public static Operator POSTFIX_DECREMENT
		{
			
			get
			{
				return ___003C_003EPOSTFIX_DECREMENT;
			}
		}

		
		
		public static void ___003Cclinit_003E()
		{
		}

		public virtual bool isPostfix()
		{
			return this.m_isPostfix;
		}

		
				
		
		private Operator(string _0024enum_0024name, int _0024enum_0024ordinal, string codeRepresentation, bool isPostfix)
			: base(_0024enum_0024name, _0024enum_0024ordinal)
		{
			this.codeRepresentation = codeRepresentation;
			this.m_isPostfix = isPostfix;
			GC.KeepAlive(this);
		}

		
		
		public static Operator[] values()
		{
			return (Operator[])_0024VALUES.Clone();
		}

		
		
		
		public static Operator valueOf(string name)
		{
			return (Operator)java.lang.Enum.valueOf(ClassLiteral<Operator>.Value, name);
		}

		public virtual string asString()
		{
			return codeRepresentation;
		}

		
		
		public virtual bool isPrefix()
		{
			return (!isPostfix()) ? true : false;
		}

		
		static Operator()
		{
			___003C_003EPLUS = new Operator("PLUS", 0, "+", isPostfix: false);
			___003C_003EMINUS = new Operator("MINUS", 1, "-", isPostfix: false);
			___003C_003EPREFIX_INCREMENT = new Operator("PREFIX_INCREMENT", 2, "++", isPostfix: false);
			___003C_003EPREFIX_DECREMENT = new Operator("PREFIX_DECREMENT", 3, "--", isPostfix: false);
			___003C_003ELOGICAL_COMPLEMENT = new Operator("LOGICAL_COMPLEMENT", 4, "!", isPostfix: false);
			___003C_003EBITWISE_COMPLEMENT = new Operator("BITWISE_COMPLEMENT", 5, "~", isPostfix: false);
			___003C_003EPOSTFIX_INCREMENT = new Operator("POSTFIX_INCREMENT", 6, "++", isPostfix: true);
			___003C_003EPOSTFIX_DECREMENT = new Operator("POSTFIX_DECREMENT", 7, "--", isPostfix: true);
			_0024VALUES = new Operator[8] { ___003C_003EPLUS, ___003C_003EMINUS, ___003C_003EPREFIX_INCREMENT, ___003C_003EPREFIX_DECREMENT, ___003C_003ELOGICAL_COMPLEMENT, ___003C_003EBITWISE_COMPLEMENT, ___003C_003EPOSTFIX_INCREMENT, ___003C_003EPOSTFIX_DECREMENT };
		}
	}

	private Expression expression;

	private Operator @operator;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	
	public UnaryExpr(TokenRange tokenRange, Expression expression, Operator @operator)
		: base(tokenRange)
	{
		setExpression(expression);
		setOperator(@operator);
		customInitialization();
	}

	
	
	
	public virtual UnaryExpr setExpression(Expression expression)
	{
		Utils.assertNotNull(expression);
		if (expression == this.expression)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EEXPRESSION, this.expression, expression);
		if (this.expression != null)
		{
			this.expression.setParentNode(null);
		}
		this.expression = expression;
		setAsParentNodeOf(expression);
		return this;
	}

	
	
	
	public virtual UnaryExpr setOperator(Operator @operator)
	{
		Utils.assertNotNull(@operator);
		if (@operator == this.@operator)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EOPERATOR, this.@operator, @operator);
		this.@operator = @operator;
		return this;
	}

	
	
	[DerivedProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/DerivedProperty;"
	})]
	public virtual bool isPostfix()
	{
		bool result = @operator.isPostfix();
		
		return result;
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual UnaryExprMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EunaryExprMetaModel;
	}

	
	
	public new virtual UnaryExpr clone()
	{
		return (UnaryExpr)accept(new CloneVisitor(), null);
	}

	
	
	public UnaryExpr()
		: this(null, new IntegerLiteralExpr(), Operator.___003C_003EPOSTFIX_INCREMENT)
	{
	}

	
	
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public UnaryExpr(Expression expression, Operator @operator)
		: this(null, expression, @operator)
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	public virtual Expression getExpression()
	{
		return expression;
	}

	public virtual Operator getOperator()
	{
		return @operator;
	}

	
	
	[DerivedProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/DerivedProperty;"
	})]
	public virtual bool isPrefix()
	{
		return (!isPostfix()) ? true : false;
	}

	
	
	
	public override bool replace(Node node, Node replacementNode)
	{
		if (node == null)
		{
			return false;
		}
		if (node == expression)
		{
			setExpression((Expression)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isUnaryExpr()
	{
		return true;
	}

	public override UnaryExpr asUnaryExpr()
	{
		return this;
	}

	
		
	
	public override void ifUnaryExpr(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toUnaryExpr()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual ExpressionMetaModel _003Cbridge_003EgetMetaModel()
	{
		UnaryExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Expression _003Cbridge_003Eclone()
	{
		UnaryExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		UnaryExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		UnaryExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		UnaryExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetExpression(Expression expression)
	{
		UnaryExpr result = setExpression(expression);
		
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setExpression(string P_0)
	{
		return NodeWithExpression._003Cdefault_003EsetExpression(this, P_0);
	}

	
	static UnaryExpr()
	{
		Expression.___003Cclinit_003E();
	}

	Node NodeWithExpression.NodeWithExpression_003A_003AsetExpression(Expression P_0)
	{
		return _003Cbridge_003EsetExpression(P_0);
	}
}
