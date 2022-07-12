using System;
using System.ComponentModel;

using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.printer;
using com.github.javaparser.utils;

using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.expr;

public class AssignExpr : Expression
{
	
	
	
	
	internal new class _1
	{
		
		internal static int[] _0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024AssignExpr_0024Operator;

		
		
		public static void ___003Cclinit_003E()
		{
		}

		
		static _1()
		{
			_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024AssignExpr_0024Operator = new int[(nint)Operator.values().LongLength];
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024AssignExpr_0024Operator[Operator.___003C_003EPLUS.ordinal()] = 1;
			}
			catch (System.Exception x)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0033;
			}
			goto IL_0039;
			IL_0033:
			
			goto IL_0039;
			IL_0039:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024AssignExpr_0024Operator[Operator.___003C_003EMINUS.ordinal()] = 2;
			}
			catch (System.Exception x2)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x2, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_005c;
			}
			goto IL_0062;
			IL_005c:
			
			goto IL_0062;
			IL_0062:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024AssignExpr_0024Operator[Operator.___003C_003EMULTIPLY.ordinal()] = 3;
			}
			catch (System.Exception x3)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x3, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0085;
			}
			goto IL_008b;
			IL_0085:
			
			goto IL_008b;
			IL_008b:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024AssignExpr_0024Operator[Operator.___003C_003EDIVIDE.ordinal()] = 4;
			}
			catch (System.Exception x4)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x4, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_00ae;
			}
			goto IL_00b4;
			IL_00ae:
			
			goto IL_00b4;
			IL_00b4:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024AssignExpr_0024Operator[Operator.___003C_003EBINARY_AND.ordinal()] = 5;
			}
			catch (System.Exception x5)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x5, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_00d7;
			}
			goto IL_00dd;
			IL_00d7:
			
			goto IL_00dd;
			IL_00dd:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024AssignExpr_0024Operator[Operator.___003C_003EBINARY_OR.ordinal()] = 6;
			}
			catch (System.Exception x6)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x6, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0100;
			}
			goto IL_0106;
			IL_0100:
			
			goto IL_0106;
			IL_0106:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024AssignExpr_0024Operator[Operator.___003C_003EXOR.ordinal()] = 7;
			}
			catch (System.Exception x7)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x7, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0129;
			}
			goto IL_012f;
			IL_0129:
			
			goto IL_012f;
			IL_012f:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024AssignExpr_0024Operator[Operator.___003C_003EREMAINDER.ordinal()] = 8;
			}
			catch (System.Exception x8)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x8, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0152;
			}
			goto IL_0158;
			IL_0152:
			
			goto IL_0158;
			IL_0158:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024AssignExpr_0024Operator[Operator.___003C_003ELEFT_SHIFT.ordinal()] = 9;
			}
			catch (System.Exception x9)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x9, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_017c;
			}
			goto IL_0182;
			IL_017c:
			
			goto IL_0182;
			IL_0182:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024AssignExpr_0024Operator[Operator.___003C_003ESIGNED_RIGHT_SHIFT.ordinal()] = 10;
			}
			catch (System.Exception x10)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x10, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_01a6;
			}
			goto IL_01ac;
			IL_01a6:
			
			goto IL_01ac;
			IL_01ac:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024AssignExpr_0024Operator[Operator.___003C_003EUNSIGNED_RIGHT_SHIFT.ordinal()] = 11;
				return;
			}
			catch (System.Exception x11)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x11, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
			}
			
		}

		_1()
		{
			throw null;
		}
	}

	
	
		
	
	public class Operator : java.lang.Enum, Stringable
	{
		
		
		public enum __Enum
		{
			ASSIGN,
			PLUS,
			MINUS,
			MULTIPLY,
			DIVIDE,
			BINARY_AND,
			BINARY_OR,
			XOR,
			REMAINDER,
			LEFT_SHIFT,
			SIGNED_RIGHT_SHIFT,
			UNSIGNED_RIGHT_SHIFT
		}

		
		internal static Operator ___003C_003EASSIGN;

		
		internal static Operator ___003C_003EPLUS;

		
		internal static Operator ___003C_003EMINUS;

		
		internal static Operator ___003C_003EMULTIPLY;

		
		internal static Operator ___003C_003EDIVIDE;

		
		internal static Operator ___003C_003EBINARY_AND;

		
		internal static Operator ___003C_003EBINARY_OR;

		
		internal static Operator ___003C_003EXOR;

		
		internal static Operator ___003C_003EREMAINDER;

		
		internal static Operator ___003C_003ELEFT_SHIFT;

		
		internal static Operator ___003C_003ESIGNED_RIGHT_SHIFT;

		
		internal static Operator ___003C_003EUNSIGNED_RIGHT_SHIFT;

		
		private string codeRepresentation;

		
		private static Operator[] _0024VALUES;

		
		public static Operator ASSIGN
		{
			
			get
			{
				return ___003C_003EASSIGN;
			}
		}

		
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

		
		public static Operator MULTIPLY
		{
			
			get
			{
				return ___003C_003EMULTIPLY;
			}
		}

		
		public static Operator DIVIDE
		{
			
			get
			{
				return ___003C_003EDIVIDE;
			}
		}

		
		public static Operator BINARY_AND
		{
			
			get
			{
				return ___003C_003EBINARY_AND;
			}
		}

		
		public static Operator BINARY_OR
		{
			
			get
			{
				return ___003C_003EBINARY_OR;
			}
		}

		
		public static Operator XOR
		{
			
			get
			{
				return ___003C_003EXOR;
			}
		}

		
		public static Operator REMAINDER
		{
			
			get
			{
				return ___003C_003EREMAINDER;
			}
		}

		
		public static Operator LEFT_SHIFT
		{
			
			get
			{
				return ___003C_003ELEFT_SHIFT;
			}
		}

		
		public static Operator SIGNED_RIGHT_SHIFT
		{
			
			get
			{
				return ___003C_003ESIGNED_RIGHT_SHIFT;
			}
		}

		
		public static Operator UNSIGNED_RIGHT_SHIFT
		{
			
			get
			{
				return ___003C_003EUNSIGNED_RIGHT_SHIFT;
			}
		}

		
		
		public static void ___003Cclinit_003E()
		{
		}

		
		
		public static Operator[] values()
		{
			return (Operator[])_0024VALUES.Clone();
		}

		
				
		
		private Operator(string _0024enum_0024name, int _0024enum_0024ordinal, string codeRepresentation)
			: base(_0024enum_0024name, _0024enum_0024ordinal)
		{
			this.codeRepresentation = codeRepresentation;
			GC.KeepAlive(this);
		}

		
		
		
		public static Operator valueOf(string name)
		{
			return (Operator)java.lang.Enum.valueOf(ClassLiteral<Operator>.Value, name);
		}

		public virtual string asString()
		{
			return codeRepresentation;
		}

		
				
		public virtual Optional toBinaryOperator()
		{
			switch (_1._0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024AssignExpr_0024Operator[ordinal()])
			{
			case 1:
			{
				Optional result12 = Optional.of(BinaryExpr.Operator.___003C_003EPLUS);
				
				return result12;
			}
			case 2:
			{
				Optional result11 = Optional.of(BinaryExpr.Operator.___003C_003EMINUS);
				
				return result11;
			}
			case 3:
			{
				Optional result10 = Optional.of(BinaryExpr.Operator.___003C_003EMULTIPLY);
				
				return result10;
			}
			case 4:
			{
				Optional result9 = Optional.of(BinaryExpr.Operator.___003C_003EDIVIDE);
				
				return result9;
			}
			case 5:
			{
				Optional result8 = Optional.of(BinaryExpr.Operator.___003C_003EBINARY_AND);
				
				return result8;
			}
			case 6:
			{
				Optional result7 = Optional.of(BinaryExpr.Operator.___003C_003EBINARY_OR);
				
				return result7;
			}
			case 7:
			{
				Optional result6 = Optional.of(BinaryExpr.Operator.___003C_003EXOR);
				
				return result6;
			}
			case 8:
			{
				Optional result5 = Optional.of(BinaryExpr.Operator.___003C_003EREMAINDER);
				
				return result5;
			}
			case 9:
			{
				Optional result4 = Optional.of(BinaryExpr.Operator.___003C_003ELEFT_SHIFT);
				
				return result4;
			}
			case 10:
			{
				Optional result3 = Optional.of(BinaryExpr.Operator.___003C_003ESIGNED_RIGHT_SHIFT);
				
				return result3;
			}
			case 11:
			{
				Optional result2 = Optional.of(BinaryExpr.Operator.___003C_003EUNSIGNED_RIGHT_SHIFT);
				
				return result2;
			}
			default:
			{
				Optional result = Optional.empty();
				
				return result;
			}
			}
		}

		
		static Operator()
		{
			___003C_003EASSIGN = new Operator("ASSIGN", 0, "=");
			___003C_003EPLUS = new Operator("PLUS", 1, "+=");
			___003C_003EMINUS = new Operator("MINUS", 2, "-=");
			___003C_003EMULTIPLY = new Operator("MULTIPLY", 3, "*=");
			___003C_003EDIVIDE = new Operator("DIVIDE", 4, "/=");
			___003C_003EBINARY_AND = new Operator("BINARY_AND", 5, "&=");
			___003C_003EBINARY_OR = new Operator("BINARY_OR", 6, "|=");
			___003C_003EXOR = new Operator("XOR", 7, "^=");
			___003C_003EREMAINDER = new Operator("REMAINDER", 8, "%=");
			___003C_003ELEFT_SHIFT = new Operator("LEFT_SHIFT", 9, "<<=");
			___003C_003ESIGNED_RIGHT_SHIFT = new Operator("SIGNED_RIGHT_SHIFT", 10, ">>=");
			___003C_003EUNSIGNED_RIGHT_SHIFT = new Operator("UNSIGNED_RIGHT_SHIFT", 11, ">>>=");
			_0024VALUES = new Operator[12]
			{
				___003C_003EASSIGN, ___003C_003EPLUS, ___003C_003EMINUS, ___003C_003EMULTIPLY, ___003C_003EDIVIDE, ___003C_003EBINARY_AND, ___003C_003EBINARY_OR, ___003C_003EXOR, ___003C_003EREMAINDER, ___003C_003ELEFT_SHIFT,
				___003C_003ESIGNED_RIGHT_SHIFT, ___003C_003EUNSIGNED_RIGHT_SHIFT
			};
		}
	}

	private Expression target;

	private Expression value;

	private Operator @operator;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public AssignExpr(Expression target, Expression value, Operator @operator)
		: this(null, target, value, @operator)
	{
	}

	
	
	
	public AssignExpr(TokenRange tokenRange, Expression target, Expression value, Operator @operator)
		: base(tokenRange)
	{
		setTarget(target);
		setValue(value);
		setOperator(@operator);
		customInitialization();
	}

	
	
	
	public virtual AssignExpr setTarget(Expression target)
	{
		Utils.assertNotNull(target);
		if (target == this.target)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ETARGET, this.target, target);
		if (this.target != null)
		{
			this.target.setParentNode(null);
		}
		this.target = target;
		setAsParentNodeOf(target);
		return this;
	}

	
	
	
	public virtual AssignExpr setValue(Expression value)
	{
		Utils.assertNotNull(value);
		if (value == this.value)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EVALUE, this.value, value);
		if (this.value != null)
		{
			this.value.setParentNode(null);
		}
		this.value = value;
		setAsParentNodeOf(value);
		return this;
	}

	
	
	
	public virtual AssignExpr setOperator(Operator @operator)
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

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual AssignExprMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EassignExprMetaModel;
	}

	
	
	public new virtual AssignExpr clone()
	{
		return (AssignExpr)accept(new CloneVisitor(), null);
	}

	
	
	public AssignExpr()
		: this(null, new NameExpr(), new StringLiteralExpr(), Operator.___003C_003EASSIGN)
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	public virtual Operator getOperator()
	{
		return @operator;
	}

	public virtual Expression getTarget()
	{
		return target;
	}

	public virtual Expression getValue()
	{
		return value;
	}

	
	
	
	public override bool replace(Node node, Node replacementNode)
	{
		if (node == null)
		{
			return false;
		}
		if (node == target)
		{
			setTarget((Expression)replacementNode);
			return true;
		}
		if (node == value)
		{
			setValue((Expression)replacementNode);
			return true;
		}
		bool result = base.replace(node, replacementNode);
		
		return result;
	}

	public override bool isAssignExpr()
	{
		return true;
	}

	public override AssignExpr asAssignExpr()
	{
		return this;
	}

	
		
	
	public override void ifAssignExpr(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toAssignExpr()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	protected internal override bool isAssignmentContext()
	{
		return true;
	}

	
	
	
	
	public new virtual ExpressionMetaModel _003Cbridge_003EgetMetaModel()
	{
		AssignExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Expression _003Cbridge_003Eclone()
	{
		AssignExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		AssignExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		AssignExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		AssignExpr result = clone();
		
		return result;
	}

	
	static AssignExpr()
	{
		Expression.___003Cclinit_003E();
	}
}
