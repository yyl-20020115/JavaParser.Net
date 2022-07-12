using System.ComponentModel;

using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;

using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.ast.expr;

public class TextBlockLiteralExpr : LiteralStringValueExpr
{
	
	private sealed class ___003C_003EAnon0 : IntFunction
	{
		private readonly string[] arg_00241;

		internal ___003C_003EAnon0(string[] P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(int P_0)
		{
			Pair result = lambda_0024stripIndentOfLines_00240(arg_00241, P_0);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon1 : Predicate
	{
		private readonly TextBlockLiteralExpr arg_00241;

		private readonly string[] arg_00242;

		internal ___003C_003EAnon1(TextBlockLiteralExpr P_0, string[] P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public bool test(object P_0)
		{
			bool result = arg_00241.lambda_0024stripIndentOfLines_00241(arg_00242, (Pair)P_0);
			
			return result;
		}

		
		public Predicate and(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public Predicate negate()
		{
			return Predicate._003Cdefault_003Enegate(this);
		}

		
		public Predicate or(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon2 : Function
	{
		private readonly TextBlockLiteralExpr arg_00241;

		internal ___003C_003EAnon2(TextBlockLiteralExpr P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			Integer result = arg_00241.lambda_0024stripIndentOfLines_00242((Pair)P_0);
			
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

	
	private sealed class ___003C_003EAnon3 : Comparator
	{
		internal ___003C_003EAnon3()
		{
		}

		public int compare(object P_0, object P_1)
		{
			int result = Integer.compare(((Integer)P_0).intValue(), ((Integer)P_1).intValue());
			
			return result;
		}

		
		public Comparator thenComparing(Comparator P_0)
		{
			return Comparator._003Cdefault_003EthenComparing(this, P_0);
		}

		
		public bool equals(object P_0)
		{
			return Object.instancehelper_equals(this, P_0);
		}

		
		public Comparator reversed()
		{
			return Comparator._003Cdefault_003Ereversed(this);
		}

		
		public Comparator thenComparing(Function P_0, Comparator P_1)
		{
			return Comparator._003Cdefault_003EthenComparing(this, P_0, P_1);
		}

		
		public Comparator thenComparing(Function P_0)
		{
			return Comparator._003Cdefault_003EthenComparing(this, P_0);
		}

		
		public Comparator thenComparingInt(ToIntFunction P_0)
		{
			return Comparator._003Cdefault_003EthenComparingInt(this, P_0);
		}

		
		public Comparator thenComparingLong(ToLongFunction P_0)
		{
			return Comparator._003Cdefault_003EthenComparingLong(this, P_0);
		}

		
		public Comparator thenComparingDouble(ToDoubleFunction P_0)
		{
			return Comparator._003Cdefault_003EthenComparingDouble(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon4 : Function
	{
		private readonly int arg_00241;

		internal ___003C_003EAnon4(int P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			string result = lambda_0024stripIndentOfLines_00243(arg_00241, (string)P_0);
			
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

	
	private sealed class ___003C_003EAnon5 : Function
	{
		private readonly TextBlockLiteralExpr arg_00241;

		internal ___003C_003EAnon5(TextBlockLiteralExpr P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			string result = arg_00241.trimTrailing((string)P_0);
			
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

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	
	public TextBlockLiteralExpr(TokenRange tokenRange, string value)
		: base(tokenRange, value)
	{
		customInitialization();
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
		
	public virtual Stream stripIndentOfLines()
	{
		string[] array = String.instancehelper_split(getValue(), "\\R", -1);
		int num = ((Integer)IntStream.range(0, array.Length).mapToObj(new ___003C_003EAnon0(array)).filter(new ___003C_003EAnon1(this, array))
			.map(new ___003C_003EAnon2(this))
			.min(new ___003C_003EAnon3())
			.orElse(Integer.valueOf(0))).intValue();
		Stream result = Arrays.stream(array).map(new ___003C_003EAnon4(num)).map(new ___003C_003EAnon5(this));
		
		return result;
	}

	
	
	public virtual string stripIndent()
	{
		Stream obj = stripIndentOfLines();
		CharSequence delimiter = default(CharSequence);
		object obj2 = (delimiter.___003Cref_003E = "\n");
		return (string)obj.collect(Collectors.joining(delimiter));
	}

	
	
	public virtual string translateEscapes()
	{
		string result = StringEscapeUtils.unescapeJavaTextBlock(stripIndent());
		
		return result;
	}

	
	
	public new virtual TextBlockLiteralExprMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EtextBlockLiteralExprMetaModel;
	}

	
	
	public new virtual TextBlockLiteralExpr clone()
	{
		return (TextBlockLiteralExpr)accept(new CloneVisitor(), null);
	}

	
	
	
	private int indentSize(string s)
	{
		string text = String.instancehelper_trim(s);
		if (String.instancehelper_isEmpty(text))
		{
			int result = String.instancehelper_length(s);
			
			return result;
		}
		int result2 = String.instancehelper_indexOf(s, text);
		
		return result2;
	}

	
	
	
	private bool emptyOrWhitespace(string rawLine)
	{
		bool result = String.instancehelper_isEmpty(String.instancehelper_trim(rawLine));
		
		return result;
	}

	
	
	
	private bool isLastLine(string[] rawLines, Integer lineNr)
	{
		return lineNr.intValue() == (nint)rawLines.LongLength - 1;
	}

	
	
	
	
	private static Pair lambda_0024stripIndentOfLines_00240(string[] rawLines, int nr)
	{
		Pair result = new Pair(Integer.valueOf(nr), rawLines[nr]);
		
		return result;
	}

	
	
	
	
	private bool lambda_0024stripIndentOfLines_00241(string[] rawLines, Pair l)
	{
		return (!emptyOrWhitespace((string)l.___003C_003Eb) || isLastLine(rawLines, (Integer)l.___003C_003Ea)) ? true : false;
	}

	
	
	
	
	private Integer lambda_0024stripIndentOfLines_00242(Pair l)
	{
		Integer result = Integer.valueOf(indentSize((string)l.___003C_003Eb));
		
		return result;
	}

	
	
	
	
	private static string lambda_0024stripIndentOfLines_00243(int commonWhiteSpacePrefixSize, string l)
	{
		string result = ((String.instancehelper_length(l) >= commonWhiteSpacePrefixSize) ? String.instancehelper_substring(l, commonWhiteSpacePrefixSize) : l);
		
		return result;
	}

	
	
	
	private string trimTrailing(string source)
	{
		int i;
		for (i = String.instancehelper_length(source) - 1; i >= 0 && Character.isWhitespace(String.instancehelper_charAt(source, i)); i += -1)
		{
		}
		i++;
		return (i >= String.instancehelper_length(source)) ? source : String.instancehelper_substring(source, 0, i);
	}

	
	
	public TextBlockLiteralExpr()
		: this(null, "empty")
	{
	}

	
	
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public TextBlockLiteralExpr(string value)
		: this(null, value)
	{
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	public override bool isTextBlockLiteralExpr()
	{
		return true;
	}

	public override TextBlockLiteralExpr asTextBlockLiteralExpr()
	{
		return this;
	}

	
		
	public override Optional toTextBlockLiteralExpr()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
		
	
	public override void ifTextBlockLiteralExpr(Consumer action)
	{
		action.accept(this);
	}

	
	
	public virtual string asString()
	{
		string result = translateEscapes();
		
		return result;
	}

	
	
	
	
	public new virtual LiteralStringValueExprMetaModel _003Cbridge_003EgetMetaModel()
	{
		TextBlockLiteralExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual LiteralStringValueExpr _003Cbridge_003Eclone()
	{
		TextBlockLiteralExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override LiteralExprMetaModel _003Cbridge_003EgetMetaModel()
	{
		TextBlockLiteralExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override LiteralExpr _003Cbridge_003Eclone()
	{
		TextBlockLiteralExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override ExpressionMetaModel _003Cbridge_003EgetMetaModel()
	{
		TextBlockLiteralExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Expression _003Cbridge_003Eclone()
	{
		TextBlockLiteralExpr result = clone();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		TextBlockLiteralExprMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		TextBlockLiteralExpr result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		TextBlockLiteralExpr result = clone();
		
		return result;
	}

	
	static TextBlockLiteralExpr()
	{
		LiteralStringValueExpr.___003Cclinit_003E();
	}
}
