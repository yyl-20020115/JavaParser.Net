using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.comments;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.modules;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.type;
using com.github.javaparser.metamodel;
using com.github.javaparser.printer.concretesyntaxmodel;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.printer;

public class ConcreteSyntaxModel
{
	
	private sealed class ___003C_003EAnon0 : Consumer
	{
		internal ___003C_003EAnon0()
		{
		}

		public void accept(object P_0)
		{
			lambda_0024forClass_00242((string)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Predicate
	{
		internal ___003C_003EAnon1()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024static_00240((BaseNodeMetaModel)P_0);
			
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
		internal ___003C_003EAnon2()
		{
		}

		public object apply(object P_0)
		{
			string result = lambda_0024static_00241((BaseNodeMetaModel)P_0);
			
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

	
		private static Map concreteSyntaxModelByClass;

		private static Optional initializationError;

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public static void genericPrettyPrint(Node node, SourcePrinter printer)
	{
		forClass(Object.instancehelper_getClass(node)).prettyPrint(node, printer);
	}

	
		
	
	public static CsmElement forClass(Class nodeClazz)
	{
		initializationError.ifPresent(new ___003C_003EAnon0());
		if (!concreteSyntaxModelByClass.containsKey(nodeClazz))
		{
			string simpleName = nodeClazz.getSimpleName();
			
			throw new UnsupportedOperationException(simpleName);
		}
		return (CsmElement)concreteSyntaxModelByClass.get(nodeClazz);
	}

	
	
	private static CsmElement memberAnnotations()
	{
		CsmElement result = CsmElement.list(ObservableProperty.___003C_003EANNOTATIONS, CsmElement.newline(), CsmElement.none(), CsmElement.newline());
		
		return result;
	}

	
	
	private static CsmElement modifiers()
	{
		CsmElement result = CsmElement.list(ObservableProperty.___003C_003EMODIFIERS, CsmElement.space(), CsmElement.none(), CsmElement.space());
		
		return result;
	}

	
	
	private static CsmElement typeParameters()
	{
		CsmElement result = CsmElement.list(ObservableProperty.___003C_003ETYPE_PARAMETERS, CsmElement.sequence(CsmElement.comma(), CsmElement.space()), CsmElement.token(110), CsmElement.sequence(CsmElement.token(146), CsmElement.space()));
		
		return result;
	}

	
	
	private static CsmElement annotations()
	{
		CsmElement result = CsmElement.list(ObservableProperty.___003C_003EANNOTATIONS, CsmElement.space(), CsmElement.none(), CsmElement.newline());
		
		return result;
	}

	
	
	
	private static CsmElement mix(params CsmElement[] elements)
	{
		CsmMix result = new CsmMix(Arrays.asList(elements));
		
		return result;
	}

	
	
	private static CsmElement typeArguments()
	{
		CsmElement result = CsmElement.list(ObservableProperty.___003C_003ETYPE_ARGUMENTS, CsmElement.sequence(CsmElement.comma(), CsmElement.space()), CsmElement.token(110), CsmElement.sequence(CsmElement.token(146)));
		
		return result;
	}

	
	
	
	
	private static void lambda_0024forClass_00242(string s)
	{
		
		throw new IllegalStateException(s);
	}

	
	
	
	
	private static bool lambda_0024static_00240(BaseNodeMetaModel c)
	{
		return (!c.isAbstract() && !ClassLiteral<Comment>.Value.isAssignableFrom(c.getType()) && !concreteSyntaxModelByClass.containsKey(c.getType())) ? true : false;
	}

	
	
	
	
	private static string lambda_0024static_00241(BaseNodeMetaModel nm)
	{
		string simpleName = nm.getType().getSimpleName();
		
		return simpleName;
	}

	
	
	private ConcreteSyntaxModel()
	{
	}

	
	
	
	public static string genericPrettyPrint(Node node)
	{
		SourcePrinter sourcePrinter = new SourcePrinter();
		forClass(Object.instancehelper_getClass(node)).prettyPrint(node, sourcePrinter);
		string result = sourcePrinter.ToString();
		
		return result;
	}

	[LineNumberTable(new byte[]
	{
		19,
		234,
		102,
		115,
		104,
		104,
		106,
		106,
		104,
		109,
		104,
		106,
		105,
		105,
		110,
		125,
		107,
		230,
		50,
		235,
		81,
		115,
		104,
		104,
		109,
		104,
		109,
		106,
		106,
		122,
		127,
		20,
		230,
		54,
		235,
		77,
		115,
		104,
		104,
		116,
		116,
		109,
		117,
		159,
		28,
		123,
		125,
		229,
		61,
		215,
		123,
		106,
		104,
		230,
		61,
		165,
		229,
		61,
		201,
		113,
		byte.MaxValue,
		36,
		47,
		235,
		84,
		115,
		104,
		104,
		104,
		109,
		106,
		117,
		127,
		8,
		117,
		127,
		39,
		110,
		230,
		53,
		235,
		78,
		115,
		104,
		104,
		106,
		104,
		109,
		106,
		117,
		127,
		8,
		118,
		127,
		29,
		123,
		106,
		104,
		230,
		61,
		165,
		229,
		61,
		201,
		113,
		byte.MaxValue,
		36,
		48,
		235,
		83,
		114,
		104,
		104,
		104,
		109,
		117,
		127,
		38,
		109,
		230,
		56,
		235,
		75,
		114,
		104,
		109,
		117,
		127,
		29,
		127,
		16,
		124,
		106,
		238,
		61,
		235,
		59,
		235,
		75,
		115,
		104,
		104,
		106,
		104,
		109,
		149,
		123,
		125,
		229,
		61,
		200,
		106,
		105,
		105,
		105,
		150,
		115,
		101,
		229,
		61,
		253,
		69,
		114,
		31,
		29,
		169,
		107,
		230,
		40,
		235,
		91,
		114,
		104,
		112,
		127,
		6,
		109,
		117,
		123,
		230,
		57,
		235,
		73,
		114,
		124,
		127,
		1,
		230,
		61,
		235,
		69,
		115,
		104,
		112,
		118,
		109,
		104,
		109,
		106,
		127,
		0,
		127,
		18,
		127,
		9,
		118,
		127,
		57,
		byte.MaxValue,
		4,
		51,
		235,
		80,
		114,
		109,
		119,
		109,
		159,
		0,
		121,
		6,
		173,
		109,
		230,
		55,
		235,
		75,
		114,
		109,
		124,
		104,
		109,
		230,
		59,
		235,
		71,
		114,
		109,
		186,
		127,
		0,
		38,
		235,
		59,
		235,
		77,
		114,
		109,
		106,
		109,
		106,
		230,
		59,
		235,
		72,
		114,
		106,
		104,
		109,
		109,
		122,
		254,
		58,
		235,
		73,
		114,
		106,
		117,
		127,
		6,
		106,
		230,
		59,
		235,
		71,
		114,
		109,
		104,
		109,
		104,
		109,
		230,
		58,
		235,
		73,
		114,
		109,
		104,
		109,
		104,
		109,
		230,
		58,
		235,
		73,
		114,
		51,
		203,
		114,
		106,
		109,
		106,
		104,
		109,
		230,
		58,
		235,
		73,
		114,
		109,
		6,
		235,
		69,
		114,
		63,
		8,
		171,
		115,
		109,
		104,
		106,
		104,
		109,
		104,
		106,
		104,
		110,
		230,
		54,
		235,
		77,
		114,
		109,
		6,
		235,
		69,
		114,
		106,
		109,
		106,
		230,
		60,
		235,
		71,
		114,
		109,
		106,
		109,
		230,
		60,
		235,
		71,
		114,
		109,
		104,
		106,
		104,
		109,
		230,
		58,
		235,
		73,
		119,
		104,
		109,
		230,
		61,
		235,
		70,
		114,
		109,
		6,
		235,
		69,
		114,
		116,
		122,
		127,
		8,
		109,
		106,
		104,
		119,
		245,
		56,
		235,
		75,
		114,
		109,
		6,
		235,
		69,
		159,
		27,
		127,
		0,
		104,
		106,
		104,
		109,
		230,
		59,
		235,
		71,
		114,
		127,
		0,
		125,
		109,
		106,
		117,
		127,
		8,
		230,
		57,
		235,
		74,
		114,
		109,
		106,
		104,
		109,
		230,
		59,
		235,
		72,
		154,
		114,
		127,
		0,
		127,
		3,
		104,
		230,
		60,
		235,
		71,
		114,
		109,
		104,
		230,
		61,
		235,
		70,
		114,
		106,
		109,
		106,
		117,
		125,
		230,
		58,
		235,
		73,
		114,
		106,
		6,
		235,
		69,
		115,
		127,
		0,
		127,
		0,
		104,
		117,
		127,
		23,
		114,
		106,
		117,
		127,
		9,
		187,
		159,
		8,
		101,
		101,
		101,
		229,
		60,
		232,
		69,
		106,
		230,
		56,
		37,
		230,
		53,
		235,
		88,
		154,
		114,
		106,
		109,
		106,
		109,
		106,
		230,
		58,
		235,
		72,
		114,
		109,
		6,
		235,
		69,
		114,
		109,
		6,
		235,
		69,
		114,
		127,
		0,
		127,
		0,
		230,
		61,
		235,
		70,
		114,
		127,
		0,
		127,
		0,
		230,
		61,
		235,
		70,
		114,
		109,
		6,
		235,
		69,
		127,
		2,
		114,
		119,
		235,
		61,
		235,
		70,
		114,
		109,
		119,
		109,
		104,
		117,
		249,
		58,
		235,
		77,
		114,
		106,
		104,
		109,
		154,
		106,
		104,
		109,
		230,
		60,
		237,
		70,
		230,
		53,
		235,
		78,
		114,
		104,
		106,
		104,
		109,
		127,
		14,
		106,
		230,
		57,
		235,
		74,
		114,
		106,
		122,
		127,
		1,
		230,
		60,
		235,
		71,
		115,
		104,
		106,
		104,
		106,
		109,
		106,
		104,
		109,
		230,
		55,
		235,
		76,
		114,
		106,
		122,
		127,
		1,
		230,
		60,
		235,
		71,
		115,
		106,
		104,
		109,
		104,
		106,
		104,
		106,
		109,
		107,
		105,
		230,
		53,
		235,
		78,
		114,
		106,
		6,
		235,
		69,
		114,
		106,
		6,
		235,
		69,
		114,
		154,
		159,
		21,
		125,
		106,
		230,
		61,
		5,
		234,
		71,
		117,
		125,
		104,
		230,
		52,
		235,
		79,
		114,
		104,
		109,
		104,
		230,
		60,
		235,
		71,
		115,
		106,
		104,
		106,
		109,
		104,
		106,
		104,
		109,
		107,
		105,
		110,
		230,
		52,
		235,
		79,
		115,
		106,
		104,
		106,
		117,
		123,
		104,
		109,
		104,
		105,
		118,
		126,
		105,
		110,
		230,
		50,
		235,
		81,
		114,
		106,
		104,
		106,
		109,
		106,
		154,
		127,
		0,
		43,
		141,
		127,
		8,
		109,
		6,
		229,
		61,
		252,
		71,
		126,
		114,
		127,
		1,
		31,
		9,
		38,
		37,
		230,
		51,
		235,
		84,
		114,
		109,
		106,
		104,
		109,
		230,
		59,
		235,
		72,
		114,
		109,
		6,
		235,
		69,
		114,
		109,
		6,
		235,
		69,
		114,
		106,
		122,
		127,
		1,
		230,
		60,
		235,
		70,
		114,
		106,
		122,
		127,
		1,
		230,
		60,
		235,
		70,
		114,
		156,
		127,
		21,
		21,
		168,
		104,
		109,
		119,
		230,
		56,
		235,
		75,
		115,
		106,
		106,
		109,
		106,
		104,
		106,
		104,
		109,
		122,
		230,
		54,
		235,
		77,
		115,
		106,
		106,
		109,
		106,
		104,
		106,
		104,
		109,
		122,
		230,
		54,
		235,
		77,
		114,
		106,
		104,
		106,
		109,
		106,
		104,
		109,
		230,
		56,
		235,
		75,
		114,
		106,
		104,
		109,
		104,
		230,
		59,
		235,
		72,
		114,
		106,
		104,
		156,
		117,
		127,
		8,
		104,
		230,
		60,
		242,
		69,
		109,
		122,
		byte.MaxValue,
		17,
		53,
		235,
		78,
		114,
		106,
		104,
		106,
		109,
		106,
		104,
		109,
		230,
		56,
		235,
		79,
		119,
		109,
		106,
		106,
		230,
		60,
		235,
		70,
		127,
		18,
		127,
		3,
		124,
		156,
		127,
		6,
		31,
		10,
		230,
		60,
		235,
		72,
		114,
		104,
		117,
		byte.MaxValue,
		7,
		61,
		235,
		69,
		114,
		109,
		109,
		230,
		61,
		235,
		69,
		114,
		104,
		109,
		181,
		109,
		104,
		230,
		61,
		237,
		69,
		106,
		104,
		230,
		61,
		197,
		229,
		55,
		230,
		60,
		235,
		80,
		114,
		104,
		117,
		byte.MaxValue,
		7,
		61,
		235,
		70,
		149,
		159,
		22,
		159,
		27,
		127,
		31,
		127,
		37,
		31,
		17,
		235,
		72,
		114,
		106,
		109,
		106,
		230,
		60,
		235,
		71,
		114,
		109,
		109,
		127,
		19,
		127,
		2,
		104,
		230,
		58,
		235,
		72,
		114,
		106,
		104,
		124,
		127,
		1,
		124,
		125,
		104,
		230,
		56,
		235,
		75,
		115,
		104,
		106,
		104,
		109,
		104,
		104,
		104,
		104,
		230,
		55,
		235,
		79,
		115,
		124,
		125,
		104,
		109,
		104,
		106,
		104,
		104,
		110,
		105,
		107,
		105,
		230,
		51,
		235,
		80,
		116,
		104,
		109,
		149,
		123,
		125,
		229,
		61,
		200,
		104,
		230,
		55,
		235,
		76,
		116,
		104,
		109,
		149,
		123,
		125,
		229,
		61,
		200,
		104,
		230,
		55,
		235,
		76,
		116,
		104,
		109,
		149,
		123,
		125,
		229,
		61,
		200,
		104,
		230,
		55,
		235,
		76,
		116,
		104,
		104,
		109,
		104,
		104,
		230,
		58,
		235,
		73,
		116,
		104,
		109,
		104,
		104,
		230,
		59,
		235,
		72,
		116,
		111,
		101,
		112,
		104,
		140,
		159,
		58
	})]
	static ConcreteSyntaxModel()
	{
		concreteSyntaxModelByClass = new HashMap();
		concreteSyntaxModelByClass.put(ClassLiteral<AnnotationDeclaration>.Value, CsmElement.sequence(CsmElement.comment(), memberAnnotations(), modifiers(), CsmElement.token(107), CsmElement.token(39), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003ENAME), CsmElement.space(), CsmElement.token(99), CsmElement.newline(), CsmElement.indent(), CsmElement.list(ObservableProperty.___003C_003EMEMBERS, CsmElement.newline(), CsmElement.none(), CsmElement.none(), CsmElement.newline()), CsmElement.unindent(), CsmElement.token(100)));
		concreteSyntaxModelByClass.put(ClassLiteral<AnnotationMemberDeclaration>.Value, CsmElement.sequence(CsmElement.comment(), memberAnnotations(), modifiers(), CsmElement.child(ObservableProperty.___003C_003ETYPE), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003ENAME), CsmElement.token(97), CsmElement.token(98), CsmElement.conditional(ObservableProperty.___003C_003EDEFAULT_VALUE, CsmConditional.Condition.___003C_003EIS_PRESENT, CsmElement.sequence(CsmElement.space(), CsmElement.token(22), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003EDEFAULT_VALUE))), CsmElement.semicolon()));
		concreteSyntaxModelByClass.put(ClassLiteral<ClassOrInterfaceDeclaration>.Value, CsmElement.sequence(CsmElement.comment(), memberAnnotations(), modifiers(), CsmElement.conditional(ObservableProperty.___003C_003EINTERFACE, CsmConditional.Condition.___003C_003EFLAG, CsmElement.token(39), CsmElement.token(19)), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003ENAME), CsmElement.list(ObservableProperty.___003C_003ETYPE_PARAMETERS, CsmElement.sequence(CsmElement.comma(), CsmElement.space()), CsmElement.@string(110), CsmElement.@string(146)), CsmElement.list(ObservableProperty.___003C_003EEXTENDED_TYPES, CsmElement.sequence(CsmElement.@string(104), CsmElement.space()), CsmElement.sequence(CsmElement.space(), CsmElement.token(27), CsmElement.space()), CsmElement.none()), CsmElement.list(ObservableProperty.___003C_003EIMPLEMENTED_TYPES, CsmElement.sequence(CsmElement.@string(104), CsmElement.space()), CsmElement.sequence(CsmElement.space(), CsmElement.token(35), CsmElement.space()), CsmElement.none()), CsmElement.space(), CsmElement.block(CsmElement.sequence(CsmElement.newline(), CsmElement.list(ObservableProperty.___003C_003EMEMBERS, CsmElement.sequence(CsmElement.newline(), CsmElement.newline()), CsmElement.newline(), CsmElement.newline())))));
		concreteSyntaxModelByClass.put(ClassLiteral<ConstructorDeclaration>.Value, CsmElement.sequence(CsmElement.comment(), memberAnnotations(), modifiers(), typeParameters(), CsmElement.child(ObservableProperty.___003C_003ENAME), CsmElement.token(97), CsmElement.list(ObservableProperty.___003C_003EPARAMETERS, CsmElement.sequence(CsmElement.comma(), CsmElement.space()), CsmElement.none(), CsmElement.none()), CsmElement.token(98), CsmElement.list(ObservableProperty.___003C_003ETHROWN_EXCEPTIONS, CsmElement.sequence(CsmElement.comma(), CsmElement.space()), CsmElement.sequence(CsmElement.space(), CsmElement.token(58), CsmElement.space()), CsmElement.none()), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003EBODY)));
		concreteSyntaxModelByClass.put(ClassLiteral<RecordDeclaration>.Value, CsmElement.sequence(CsmElement.comment(), memberAnnotations(), modifiers(), CsmElement.token(48), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003ENAME), CsmElement.token(97), CsmElement.list(ObservableProperty.___003C_003EPARAMETERS, CsmElement.sequence(CsmElement.comma(), CsmElement.space()), CsmElement.none(), CsmElement.none()), CsmElement.token(98), CsmElement.list(ObservableProperty.___003C_003ETYPE_PARAMETERS, CsmElement.sequence(CsmElement.comma(), CsmElement.space()), CsmElement.@string(110), CsmElement.@string(146)), CsmElement.list(ObservableProperty.___003C_003EIMPLEMENTED_TYPES, CsmElement.sequence(CsmElement.@string(104), CsmElement.space()), CsmElement.sequence(CsmElement.space(), CsmElement.token(35), CsmElement.space()), CsmElement.none()), CsmElement.space(), CsmElement.block(CsmElement.sequence(CsmElement.newline(), CsmElement.list(ObservableProperty.___003C_003EMEMBERS, CsmElement.sequence(CsmElement.newline(), CsmElement.newline()), CsmElement.newline(), CsmElement.newline())))));
		concreteSyntaxModelByClass.put(ClassLiteral<CompactConstructorDeclaration>.Value, CsmElement.sequence(CsmElement.comment(), memberAnnotations(), modifiers(), typeParameters(), CsmElement.child(ObservableProperty.___003C_003ENAME), CsmElement.list(ObservableProperty.___003C_003ETHROWN_EXCEPTIONS, CsmElement.sequence(CsmElement.comma(), CsmElement.space()), CsmElement.sequence(CsmElement.space(), CsmElement.token(58), CsmElement.space()), CsmElement.none()), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003EBODY)));
		concreteSyntaxModelByClass.put(ClassLiteral<EnumConstantDeclaration>.Value, CsmElement.sequence(CsmElement.comment(), memberAnnotations(), CsmElement.child(ObservableProperty.___003C_003ENAME), CsmElement.list(ObservableProperty.___003C_003EARGUMENTS, CsmElement.sequence(CsmElement.comma(), CsmElement.space()), CsmElement.token(97), CsmElement.token(98)), CsmElement.conditional(ObservableProperty.___003C_003ECLASS_BODY, CsmConditional.Condition.___003C_003EIS_NOT_EMPTY, CsmElement.sequence(CsmElement.space(), CsmElement.token(99), CsmElement.newline(), CsmElement.indent(), CsmElement.newline(), CsmElement.list(ObservableProperty.___003C_003ECLASS_BODY, CsmElement.newline(), CsmElement.newline(), CsmElement.none(), CsmElement.newline()), CsmElement.unindent(), CsmElement.token(100), CsmElement.newline()))));
		concreteSyntaxModelByClass.put(ClassLiteral<EnumDeclaration>.Value, CsmElement.sequence(CsmElement.comment(), annotations(), modifiers(), CsmElement.token(26), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003ENAME), CsmElement.list(ObservableProperty.___003C_003EIMPLEMENTED_TYPES, CsmElement.sequence(CsmElement.comma(), CsmElement.space()), CsmElement.sequence(CsmElement.space(), CsmElement.token(35), CsmElement.space()), CsmElement.none()), CsmElement.space(), CsmElement.token(99), CsmElement.newline(), CsmElement.indent(), CsmElement.newline(), CsmElement.list(ObservableProperty.___003C_003EENTRIES, CsmElement.sequence(CsmElement.comma(), CsmElement.newline()), CsmElement.none(), CsmElement.none()), CsmElement.conditional(ObservableProperty.___003C_003EMEMBERS, CsmConditional.Condition.___003C_003EIS_EMPTY, CsmElement.conditional(ObservableProperty.___003C_003EENTRIES, CsmConditional.Condition.___003C_003EIS_NOT_EMPTY, CsmElement.newline()), CsmElement.sequence(CsmElement.semicolon(), CsmElement.newline(), CsmElement.newline(), CsmElement.list(ObservableProperty.___003C_003EMEMBERS, CsmElement.newline(), CsmElement.newline(), CsmElement.none(), CsmElement.newline()))), CsmElement.unindent(), CsmElement.token(100)));
		concreteSyntaxModelByClass.put(ClassLiteral<FieldDeclaration>.Value, CsmElement.sequence(CsmElement.orphanCommentsBeforeThis(), CsmElement.comment(), mix(annotations(), modifiers()), CsmElement.conditional(ObservableProperty.___003C_003EVARIABLES, CsmConditional.Condition.___003C_003EIS_NOT_EMPTY, CsmElement.child(ObservableProperty.___003C_003EMAXIMUM_COMMON_TYPE)), CsmElement.space(), CsmElement.list(ObservableProperty.___003C_003EVARIABLES, CsmElement.sequence(CsmElement.comma(), CsmElement.space())), CsmElement.semicolon()));
		concreteSyntaxModelByClass.put(ClassLiteral<InitializerDeclaration>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.conditional(ObservableProperty.___003C_003ESTATIC, CsmConditional.Condition.___003C_003EFLAG, CsmElement.sequence(CsmElement.token(51), CsmElement.space())), CsmElement.child(ObservableProperty.___003C_003EBODY)));
		concreteSyntaxModelByClass.put(ClassLiteral<MethodDeclaration>.Value, CsmElement.sequence(CsmElement.orphanCommentsBeforeThis(), CsmElement.comment(), mix(memberAnnotations(), modifiers()), typeParameters(), CsmElement.child(ObservableProperty.___003C_003ETYPE), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003ENAME), CsmElement.token(97), CsmElement.conditional(ObservableProperty.___003C_003ERECEIVER_PARAMETER, CsmConditional.Condition.___003C_003EIS_PRESENT, CsmElement.sequence(CsmElement.child(ObservableProperty.___003C_003ERECEIVER_PARAMETER), CsmElement.comma(), CsmElement.space())), CsmElement.list(ObservableProperty.___003C_003EPARAMETERS, CsmElement.sequence(CsmElement.comma(), CsmElement.space()), CsmElement.none(), CsmElement.none()), CsmElement.token(98), CsmElement.list(ObservableProperty.___003C_003ETHROWN_EXCEPTIONS, CsmElement.sequence(CsmElement.comma(), CsmElement.space()), CsmElement.sequence(CsmElement.space(), CsmElement.token(58), CsmElement.space()), CsmElement.none()), CsmElement.conditional(ObservableProperty.___003C_003EBODY, CsmConditional.Condition.___003C_003EIS_PRESENT, CsmElement.sequence(CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003EBODY)), CsmElement.semicolon())));
		concreteSyntaxModelByClass.put(ClassLiteral<Parameter>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.list(ObservableProperty.___003C_003EANNOTATIONS, CsmElement.space(), CsmElement.none(), CsmElement.space()), modifiers(), CsmElement.child(ObservableProperty.___003C_003ETYPE), CsmElement.conditional(ObservableProperty.___003C_003EVAR_ARGS, CsmConditional.Condition.___003C_003EFLAG, CsmElement.sequence(CsmElement.list(ObservableProperty.___003C_003EVAR_ARGS_ANNOTATIONS, CsmElement.space(), CsmElement.none(), CsmElement.none()), CsmElement.token(106))), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003ENAME)));
		concreteSyntaxModelByClass.put(ClassLiteral<ReceiverParameter>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.list(ObservableProperty.___003C_003EANNOTATIONS, CsmElement.space(), CsmElement.none(), CsmElement.space()), CsmElement.child(ObservableProperty.___003C_003ETYPE), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003ENAME)));
		concreteSyntaxModelByClass.put(ClassLiteral<VariableDeclarator>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.child(ObservableProperty.___003C_003ENAME), CsmElement.conditional(ObservableProperty.___003C_003EINITIALIZER, CsmConditional.Condition.___003C_003EIS_PRESENT, CsmElement.sequence(CsmElement.space(), CsmElement.token(109), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003EINITIALIZER)))));
		concreteSyntaxModelByClass.put(ClassLiteral<ArrayAccessExpr>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.child(ObservableProperty.___003C_003ENAME), CsmElement.token(101), CsmElement.child(ObservableProperty.___003C_003EINDEX), CsmElement.token(102)));
		concreteSyntaxModelByClass.put(ClassLiteral<ArrayCreationExpr>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.token(42), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003EELEMENT_TYPE), CsmElement.list(ObservableProperty.___003C_003ELEVELS), CsmElement.conditional(ObservableProperty.___003C_003EINITIALIZER, CsmConditional.Condition.___003C_003EIS_PRESENT, CsmElement.sequence(CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003EINITIALIZER)))));
		concreteSyntaxModelByClass.put(ClassLiteral<ArrayInitializerExpr>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.token(99), CsmElement.list(ObservableProperty.___003C_003EVALUES, CsmElement.sequence(CsmElement.comma(), CsmElement.space()), CsmElement.space(), CsmElement.space()), CsmElement.orphanCommentsEnding(), CsmElement.token(100)));
		concreteSyntaxModelByClass.put(ClassLiteral<AssignExpr>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.child(ObservableProperty.___003C_003ETARGET), CsmElement.space(), CsmElement.attribute(ObservableProperty.___003C_003EOPERATOR), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003EVALUE)));
		concreteSyntaxModelByClass.put(ClassLiteral<BinaryExpr>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.child(ObservableProperty.___003C_003ELEFT), CsmElement.space(), CsmElement.attribute(ObservableProperty.___003C_003EOPERATOR), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003ERIGHT)));
		concreteSyntaxModelByClass.put(ClassLiteral<BooleanLiteralExpr>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.attribute(ObservableProperty.___003C_003EVALUE)));
		concreteSyntaxModelByClass.put(ClassLiteral<CastExpr>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.token(97), CsmElement.child(ObservableProperty.___003C_003ETYPE), CsmElement.token(98), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003EEXPRESSION)));
		concreteSyntaxModelByClass.put(ClassLiteral<CharLiteralExpr>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.charToken(ObservableProperty.___003C_003EVALUE)));
		concreteSyntaxModelByClass.put(ClassLiteral<ClassExpr>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.child(ObservableProperty.___003C_003ETYPE), CsmElement.token(105), CsmElement.token(19)));
		concreteSyntaxModelByClass.put(ClassLiteral<ConditionalExpr>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.child(ObservableProperty.___003C_003ECONDITION), CsmElement.space(), CsmElement.token(113), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003ETHEN_EXPR), CsmElement.space(), CsmElement.token(114), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003EELSE_EXPR)));
		concreteSyntaxModelByClass.put(ClassLiteral<DoubleLiteralExpr>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.attribute(ObservableProperty.___003C_003EVALUE)));
		concreteSyntaxModelByClass.put(ClassLiteral<EnclosedExpr>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.token(97), CsmElement.child(ObservableProperty.___003C_003EINNER), CsmElement.token(98)));
		concreteSyntaxModelByClass.put(ClassLiteral<FieldAccessExpr>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.child(ObservableProperty.___003C_003ESCOPE), CsmElement.token(105), CsmElement.child(ObservableProperty.___003C_003ENAME)));
		concreteSyntaxModelByClass.put(ClassLiteral<InstanceOfExpr>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.child(ObservableProperty.___003C_003EEXPRESSION), CsmElement.space(), CsmElement.token(37), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003ETYPE)));
		concreteSyntaxModelByClass.put(ClassLiteral<PatternExpr>.Value, CsmElement.sequence(CsmElement.child(ObservableProperty.___003C_003ETYPE), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003ENAME)));
		concreteSyntaxModelByClass.put(ClassLiteral<IntegerLiteralExpr>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.attribute(ObservableProperty.___003C_003EVALUE)));
		concreteSyntaxModelByClass.put(ClassLiteral<LambdaExpr>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.conditional(ObservableProperty.___003C_003EENCLOSING_PARAMETERS, CsmConditional.Condition.___003C_003EFLAG, CsmElement.token(97)), CsmElement.list(ObservableProperty.___003C_003EPARAMETERS, CsmElement.sequence(CsmElement.comma(), CsmElement.space())), CsmElement.conditional(ObservableProperty.___003C_003EENCLOSING_PARAMETERS, CsmConditional.Condition.___003C_003EFLAG, CsmElement.token(98)), CsmElement.space(), CsmElement.token(115), CsmElement.space(), CsmElement.conditional(ObservableProperty.___003C_003EEXPRESSION_BODY, CsmConditional.Condition.___003C_003EIS_PRESENT, CsmElement.child(ObservableProperty.___003C_003EEXPRESSION_BODY), CsmElement.child(ObservableProperty.___003C_003EBODY))));
		concreteSyntaxModelByClass.put(ClassLiteral<LongLiteralExpr>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.attribute(ObservableProperty.___003C_003EVALUE)));
		concreteSyntaxModelByClass.put(ClassLiteral<MarkerAnnotationExpr>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.token(107), CsmElement.attribute(ObservableProperty.___003C_003ENAME)));
		concreteSyntaxModelByClass.put(ClassLiteral<MemberValuePair>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.child(ObservableProperty.___003C_003ENAME), CsmElement.space(), CsmElement.token(109), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003EVALUE)));
		concreteSyntaxModelByClass.put(ClassLiteral<MethodCallExpr>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.conditional(ObservableProperty.___003C_003ESCOPE, CsmConditional.Condition.___003C_003EIS_PRESENT, CsmElement.sequence(CsmElement.child(ObservableProperty.___003C_003ESCOPE), CsmElement.token(105))), typeArguments(), CsmElement.child(ObservableProperty.___003C_003ENAME), CsmElement.token(97), CsmElement.list(ObservableProperty.___003C_003EARGUMENTS, CsmElement.sequence(CsmElement.comma(), CsmElement.space()), CsmElement.none(), CsmElement.none()), CsmElement.token(98)));
		concreteSyntaxModelByClass.put(ClassLiteral<MethodReferenceExpr>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.child(ObservableProperty.___003C_003ESCOPE), CsmElement.token(108), typeArguments(), CsmElement.attribute(ObservableProperty.___003C_003EIDENTIFIER)));
		concreteSyntaxModelByClass.put(ClassLiteral<Modifier>.Value, CsmElement.attribute(ObservableProperty.___003C_003EKEYWORD));
		concreteSyntaxModelByClass.put(ClassLiteral<Name>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.conditional(ObservableProperty.___003C_003EQUALIFIER, CsmConditional.Condition.___003C_003EIS_PRESENT, CsmElement.sequence(CsmElement.child(ObservableProperty.___003C_003EQUALIFIER), CsmElement.token(105))), CsmElement.attribute(ObservableProperty.___003C_003EIDENTIFIER), CsmElement.orphanCommentsEnding()));
		concreteSyntaxModelByClass.put(ClassLiteral<NameExpr>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.child(ObservableProperty.___003C_003ENAME), CsmElement.orphanCommentsEnding()));
		concreteSyntaxModelByClass.put(ClassLiteral<NormalAnnotationExpr>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.token(107), CsmElement.child(ObservableProperty.___003C_003ENAME), CsmElement.token(97), CsmElement.list(ObservableProperty.___003C_003EPAIRS, CsmElement.sequence(CsmElement.comma(), CsmElement.space())), CsmElement.token(98)));
		concreteSyntaxModelByClass.put(ClassLiteral<NullLiteralExpr>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.token(43)));
		concreteSyntaxModelByClass.put(ClassLiteral<ObjectCreationExpr>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.conditional(ObservableProperty.___003C_003ESCOPE, CsmConditional.Condition.___003C_003EIS_PRESENT, CsmElement.sequence(CsmElement.child(ObservableProperty.___003C_003ESCOPE), CsmElement.token(105))), CsmElement.token(42), CsmElement.space(), CsmElement.list(ObservableProperty.___003C_003ETYPE_ARGUMENTS, CsmElement.sequence(CsmElement.comma(), CsmElement.space()), CsmElement.token(110), CsmElement.token(146)), CsmElement.conditional(ObservableProperty.___003C_003ETYPE_ARGUMENTS, CsmConditional.Condition.___003C_003EIS_NOT_EMPTY, CsmElement.space()), CsmElement.child(ObservableProperty.___003C_003ETYPE), CsmElement.token(97), CsmElement.list(ObservableProperty.___003C_003EARGUMENTS, CsmElement.sequence(CsmElement.comma(), CsmElement.space()), CsmElement.none(), CsmElement.none()), CsmElement.token(98), CsmElement.conditional(ObservableProperty.___003C_003EANONYMOUS_CLASS_BODY, CsmConditional.Condition.___003C_003EIS_PRESENT, CsmElement.sequence(CsmElement.space(), CsmElement.token(99), CsmElement.newline(), CsmElement.indent(), CsmElement.list(ObservableProperty.___003C_003EANONYMOUS_CLASS_BODY, CsmElement.newline(), CsmElement.newline(), CsmElement.newline(), CsmElement.newline()), CsmElement.unindent(), CsmElement.token(100)))));
		concreteSyntaxModelByClass.put(ClassLiteral<SimpleName>.Value, CsmElement.attribute(ObservableProperty.___003C_003EIDENTIFIER));
		concreteSyntaxModelByClass.put(ClassLiteral<SingleMemberAnnotationExpr>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.token(107), CsmElement.child(ObservableProperty.___003C_003ENAME), CsmElement.token(97), CsmElement.child(ObservableProperty.___003C_003EMEMBER_VALUE), CsmElement.token(98)));
		concreteSyntaxModelByClass.put(ClassLiteral<StringLiteralExpr>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.stringToken(ObservableProperty.___003C_003EVALUE)));
		concreteSyntaxModelByClass.put(ClassLiteral<TextBlockLiteralExpr>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.textBlockToken(ObservableProperty.___003C_003EVALUE)));
		concreteSyntaxModelByClass.put(ClassLiteral<SuperExpr>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.conditional(ObservableProperty.___003C_003ETYPE_NAME, CsmConditional.Condition.___003C_003EIS_PRESENT, CsmElement.sequence(CsmElement.child(ObservableProperty.___003C_003ETYPE_NAME), CsmElement.token(105))), CsmElement.token(53)));
		concreteSyntaxModelByClass.put(ClassLiteral<ThisExpr>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.conditional(ObservableProperty.___003C_003ETYPE_NAME, CsmConditional.Condition.___003C_003EIS_PRESENT, CsmElement.sequence(CsmElement.child(ObservableProperty.___003C_003ETYPE_NAME), CsmElement.token(105))), CsmElement.token(56)));
		concreteSyntaxModelByClass.put(ClassLiteral<TypeExpr>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.child(ObservableProperty.___003C_003ETYPE)));
		concreteSyntaxModelByClass.put(ClassLiteral<UnaryExpr>.Value, CsmElement.sequence(CsmElement.conditional(ObservableProperty.___003C_003EPREFIX, CsmConditional.Condition.___003C_003EFLAG, CsmElement.attribute(ObservableProperty.___003C_003EOPERATOR)), CsmElement.child(ObservableProperty.___003C_003EEXPRESSION), CsmElement.conditional(ObservableProperty.___003C_003EPOSTFIX, CsmConditional.Condition.___003C_003EFLAG, CsmElement.attribute(ObservableProperty.___003C_003EOPERATOR))));
		concreteSyntaxModelByClass.put(ClassLiteral<VariableDeclarationExpr>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.list(ObservableProperty.___003C_003EANNOTATIONS, CsmElement.space(), CsmElement.none(), CsmElement.space()), modifiers(), CsmElement.child(ObservableProperty.___003C_003EMAXIMUM_COMMON_TYPE), CsmElement.space(), CsmElement.list(ObservableProperty.___003C_003EVARIABLES, CsmElement.sequence(CsmElement.comma(), CsmElement.space()))));
		concreteSyntaxModelByClass.put(ClassLiteral<AssertStmt>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.token(12), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003ECHECK), CsmElement.conditional(ObservableProperty.___003C_003EMESSAGE, CsmConditional.Condition.___003C_003EIS_PRESENT, CsmElement.sequence(CsmElement.space(), CsmElement.token(114), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003EMESSAGE))), CsmElement.semicolon()));
		concreteSyntaxModelByClass.put(ClassLiteral<BlockStmt>.Value, CsmElement.sequence(CsmElement.orphanCommentsBeforeThis(), CsmElement.comment(), CsmElement.token(99), CsmElement.newline(), CsmElement.list(ObservableProperty.___003C_003ESTATEMENTS, CsmElement.newline(), CsmElement.indent(), CsmElement.sequence(CsmElement.newline(), CsmElement.unindent())), CsmElement.orphanCommentsEnding(), CsmElement.token(100)));
		concreteSyntaxModelByClass.put(ClassLiteral<BreakStmt>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.token(14), CsmElement.conditional(ObservableProperty.___003C_003ELABEL, CsmConditional.Condition.___003C_003EIS_PRESENT, CsmElement.sequence(CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003ELABEL))), CsmElement.semicolon()));
		concreteSyntaxModelByClass.put(ClassLiteral<CatchClause>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.space(), CsmElement.token(17), CsmElement.space(), CsmElement.token(97), CsmElement.child(ObservableProperty.___003C_003EPARAMETER), CsmElement.token(98), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003EBODY)));
		concreteSyntaxModelByClass.put(ClassLiteral<ContinueStmt>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.token(21), CsmElement.conditional(ObservableProperty.___003C_003ELABEL, CsmConditional.Condition.___003C_003EIS_PRESENT, CsmElement.sequence(CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003ELABEL))), CsmElement.semicolon()));
		concreteSyntaxModelByClass.put(ClassLiteral<DoStmt>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.token(23), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003EBODY), CsmElement.space(), CsmElement.token(64), CsmElement.space(), CsmElement.token(97), CsmElement.child(ObservableProperty.___003C_003ECONDITION), CsmElement.token(98), CsmElement.semicolon()));
		concreteSyntaxModelByClass.put(ClassLiteral<EmptyStmt>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.token(103)));
		concreteSyntaxModelByClass.put(ClassLiteral<UnparsableStmt>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.token(103)));
		concreteSyntaxModelByClass.put(ClassLiteral<ExplicitConstructorInvocationStmt>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.conditional(ObservableProperty.___003C_003ETHIS, CsmConditional.Condition.___003C_003EFLAG, CsmElement.sequence(typeArguments(), CsmElement.token(56)), CsmElement.sequence(CsmElement.conditional(ObservableProperty.___003C_003EEXPRESSION, CsmConditional.Condition.___003C_003EIS_PRESENT, CsmElement.sequence(CsmElement.child(ObservableProperty.___003C_003EEXPRESSION), CsmElement.token(105))), typeArguments(), CsmElement.token(53))), CsmElement.token(97), CsmElement.list(ObservableProperty.___003C_003EARGUMENTS, CsmElement.sequence(CsmElement.comma(), CsmElement.space())), CsmElement.token(98), CsmElement.semicolon()));
		concreteSyntaxModelByClass.put(ClassLiteral<ExpressionStmt>.Value, CsmElement.sequence(CsmElement.orphanCommentsBeforeThis(), CsmElement.comment(), CsmElement.child(ObservableProperty.___003C_003EEXPRESSION), CsmElement.semicolon()));
		concreteSyntaxModelByClass.put(ClassLiteral<ForEachStmt>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.token(32), CsmElement.space(), CsmElement.token(97), CsmElement.child(ObservableProperty.___003C_003EVARIABLE), CsmElement.space(), CsmElement.token(114), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003EITERABLE), CsmElement.token(98), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003EBODY)));
		concreteSyntaxModelByClass.put(ClassLiteral<ForStmt>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.token(32), CsmElement.space(), CsmElement.token(97), CsmElement.list(ObservableProperty.___003C_003EINITIALIZATION, CsmElement.sequence(CsmElement.comma(), CsmElement.space())), CsmElement.semicolon(), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003ECOMPARE), CsmElement.semicolon(), CsmElement.space(), CsmElement.list(ObservableProperty.___003C_003EUPDATE, CsmElement.sequence(CsmElement.comma(), CsmElement.space())), CsmElement.token(98), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003EBODY)));
		concreteSyntaxModelByClass.put(ClassLiteral<IfStmt>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.token(34), CsmElement.space(), CsmElement.token(97), CsmElement.child(ObservableProperty.___003C_003ECONDITION), CsmElement.token(98), CsmElement.conditional(ObservableProperty.___003C_003ETHEN_BLOCK, CsmConditional.Condition.___003C_003EFLAG, CsmElement.sequence(CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003ETHEN_STMT), CsmElement.conditional(ObservableProperty.___003C_003EELSE_STMT, CsmConditional.Condition.___003C_003EIS_PRESENT, CsmElement.space())), CsmElement.sequence(CsmElement.newline(), CsmElement.indent(), CsmElement.child(ObservableProperty.___003C_003ETHEN_STMT), CsmElement.conditional(ObservableProperty.___003C_003EELSE_STMT, CsmConditional.Condition.___003C_003EIS_PRESENT, CsmElement.newline()), CsmElement.unindent())), CsmElement.conditional(ObservableProperty.___003C_003EELSE_STMT, CsmConditional.Condition.___003C_003EIS_PRESENT, CsmElement.sequence(CsmElement.token(25), CsmElement.conditional(Arrays.asList(ObservableProperty.___003C_003EELSE_BLOCK, ObservableProperty.___003C_003ECASCADING_IF_STMT), CsmConditional.Condition.___003C_003EFLAG, CsmElement.sequence(CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003EELSE_STMT)), CsmElement.sequence(CsmElement.newline(), CsmElement.indent(), CsmElement.child(ObservableProperty.___003C_003EELSE_STMT), CsmElement.unindent()))))));
		concreteSyntaxModelByClass.put(ClassLiteral<LabeledStmt>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.child(ObservableProperty.___003C_003ELABEL), CsmElement.token(114), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003ESTATEMENT)));
		concreteSyntaxModelByClass.put(ClassLiteral<LocalClassDeclarationStmt>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.child(ObservableProperty.___003C_003ECLASS_DECLARATION)));
		concreteSyntaxModelByClass.put(ClassLiteral<LocalRecordDeclarationStmt>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.child(ObservableProperty.___003C_003ERECORD_DECLARATION)));
		concreteSyntaxModelByClass.put(ClassLiteral<ReturnStmt>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.token(49), CsmElement.conditional(ObservableProperty.___003C_003EEXPRESSION, CsmConditional.Condition.___003C_003EIS_PRESENT, CsmElement.sequence(CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003EEXPRESSION))), CsmElement.semicolon()));
		concreteSyntaxModelByClass.put(ClassLiteral<YieldStmt>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.token(65), CsmElement.conditional(ObservableProperty.___003C_003EEXPRESSION, CsmConditional.Condition.___003C_003EIS_PRESENT, CsmElement.sequence(CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003EEXPRESSION))), CsmElement.semicolon()));
		concreteSyntaxModelByClass.put(ClassLiteral<SwitchEntry>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.conditional(ObservableProperty.___003C_003ELABELS, CsmConditional.Condition.___003C_003EIS_NOT_EMPTY, CsmElement.sequence(CsmElement.token(16), CsmElement.space(), CsmElement.list(ObservableProperty.___003C_003ELABELS), CsmElement.token(114)), CsmElement.sequence(CsmElement.token(22), CsmElement.token(114))), CsmElement.newline(), CsmElement.indent(), CsmElement.list(ObservableProperty.___003C_003ESTATEMENTS, CsmElement.newline(), CsmElement.none(), CsmElement.newline()), CsmElement.unindent()));
		concreteSyntaxModelByClass.put(ClassLiteral<SwitchStmt>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.token(54), CsmElement.token(97), CsmElement.child(ObservableProperty.___003C_003ESELECTOR), CsmElement.token(98), CsmElement.space(), CsmElement.token(99), CsmElement.newline(), CsmElement.list(ObservableProperty.___003C_003EENTRIES, CsmElement.none(), CsmElement.indent(), CsmElement.unindent()), CsmElement.token(100)));
		concreteSyntaxModelByClass.put(ClassLiteral<SwitchExpr>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.token(54), CsmElement.token(97), CsmElement.child(ObservableProperty.___003C_003ESELECTOR), CsmElement.token(98), CsmElement.space(), CsmElement.token(99), CsmElement.newline(), CsmElement.list(ObservableProperty.___003C_003EENTRIES, CsmElement.none(), CsmElement.indent(), CsmElement.unindent()), CsmElement.token(100)));
		concreteSyntaxModelByClass.put(ClassLiteral<SynchronizedStmt>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.token(55), CsmElement.space(), CsmElement.token(97), CsmElement.child(ObservableProperty.___003C_003EEXPRESSION), CsmElement.token(98), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003EBODY)));
		concreteSyntaxModelByClass.put(ClassLiteral<ThrowStmt>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.token(57), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003EEXPRESSION), CsmElement.semicolon()));
		concreteSyntaxModelByClass.put(ClassLiteral<TryStmt>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.token(61), CsmElement.space(), CsmElement.conditional(ObservableProperty.___003C_003ERESOURCES, CsmConditional.Condition.___003C_003EIS_NOT_EMPTY, CsmElement.sequence(CsmElement.token(97), CsmElement.list(ObservableProperty.___003C_003ERESOURCES, CsmElement.sequence(CsmElement.semicolon(), CsmElement.newline()), CsmElement.indent(), CsmElement.unindent()), CsmElement.token(98), CsmElement.space())), CsmElement.child(ObservableProperty.___003C_003ETRY_BLOCK), CsmElement.list(ObservableProperty.___003C_003ECATCH_CLAUSES), CsmElement.conditional(ObservableProperty.___003C_003EFINALLY_BLOCK, CsmConditional.Condition.___003C_003EIS_PRESENT, CsmElement.sequence(CsmElement.space(), CsmElement.token(30), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003EFINALLY_BLOCK)))));
		concreteSyntaxModelByClass.put(ClassLiteral<WhileStmt>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.token(64), CsmElement.space(), CsmElement.token(97), CsmElement.child(ObservableProperty.___003C_003ECONDITION), CsmElement.token(98), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003EBODY)));
		concreteSyntaxModelByClass.put(ClassLiteral<ArrayType>.Value, CsmElement.sequence(CsmElement.child(ObservableProperty.___003C_003ECOMPONENT_TYPE), CsmElement.list(ObservableProperty.___003C_003EANNOTATIONS), CsmElement.@string(101), CsmElement.@string(102)));
		concreteSyntaxModelByClass.put(ClassLiteral<ClassOrInterfaceType>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.conditional(ObservableProperty.___003C_003ESCOPE, CsmConditional.Condition.___003C_003EIS_PRESENT, CsmElement.sequence(CsmElement.child(ObservableProperty.___003C_003ESCOPE), CsmElement.@string(105))), CsmElement.list(ObservableProperty.___003C_003EANNOTATIONS, CsmElement.space(), CsmElement.none(), CsmElement.space()), CsmElement.child(ObservableProperty.___003C_003ENAME), CsmElement.conditional(ObservableProperty.___003C_003EUSING_DIAMOND_OPERATOR, CsmConditional.Condition.___003C_003EFLAG, CsmElement.sequence(CsmElement.@string(110), CsmElement.@string(146)), CsmElement.list(ObservableProperty.___003C_003ETYPE_ARGUMENTS, CsmElement.sequence(CsmElement.comma(), CsmElement.space()), CsmElement.@string(110), CsmElement.@string(146)))));
		concreteSyntaxModelByClass.put(ClassLiteral<IntersectionType>.Value, CsmElement.sequence(CsmElement.comment(), annotations(), CsmElement.list(ObservableProperty.___003C_003EELEMENTS, CsmElement.sequence(CsmElement.space(), CsmElement.token(128), CsmElement.space()))));
		concreteSyntaxModelByClass.put(ClassLiteral<PrimitiveType>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.list(ObservableProperty.___003C_003EANNOTATIONS), CsmElement.attribute(ObservableProperty.___003C_003ETYPE)));
		concreteSyntaxModelByClass.put(ClassLiteral<TypeParameter>.Value, CsmElement.sequence(CsmElement.comment(), annotations(), CsmElement.child(ObservableProperty.___003C_003ENAME), CsmElement.list(ObservableProperty.___003C_003ETYPE_BOUND, CsmElement.sequence(CsmElement.space(), CsmElement.token(128), CsmElement.space()), CsmElement.sequence(CsmElement.space(), CsmElement.token(27), CsmElement.space()), CsmElement.none())));
		concreteSyntaxModelByClass.put(ClassLiteral<UnionType>.Value, CsmElement.sequence(CsmElement.comment(), annotations(), CsmElement.list(ObservableProperty.___003C_003EELEMENTS, CsmElement.sequence(CsmElement.space(), CsmElement.token(129), CsmElement.space()))));
		concreteSyntaxModelByClass.put(ClassLiteral<UnknownType>.Value, CsmElement.none());
		concreteSyntaxModelByClass.put(ClassLiteral<VoidType>.Value, CsmElement.sequence(CsmElement.comment(), annotations(), CsmElement.token(62)));
		concreteSyntaxModelByClass.put(ClassLiteral<VarType>.Value, CsmElement.sequence(CsmElement.comment(), annotations(), CsmElement.@string(94, "var")));
		concreteSyntaxModelByClass.put(ClassLiteral<WildcardType>.Value, CsmElement.sequence(CsmElement.comment(), annotations(), CsmElement.token(113), CsmElement.conditional(ObservableProperty.___003C_003EEXTENDED_TYPE, CsmConditional.Condition.___003C_003EIS_PRESENT, CsmElement.sequence(CsmElement.space(), CsmElement.token(27), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003EEXTENDED_TYPE))), CsmElement.conditional(ObservableProperty.___003C_003ESUPER_TYPE, CsmConditional.Condition.___003C_003EIS_PRESENT, CsmElement.sequence(CsmElement.space(), CsmElement.token(53), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003ESUPER_TYPE)))));
		concreteSyntaxModelByClass.put(ClassLiteral<ArrayCreationLevel>.Value, CsmElement.sequence(annotations(), CsmElement.token(101), CsmElement.child(ObservableProperty.___003C_003EDIMENSION), CsmElement.token(102)));
		concreteSyntaxModelByClass.put(ClassLiteral<CompilationUnit>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.child(ObservableProperty.___003C_003EPACKAGE_DECLARATION), CsmElement.list(ObservableProperty.___003C_003EIMPORTS, CsmElement.newline(), CsmElement.none(), CsmElement.sequence(CsmElement.newline(), CsmElement.newline())), CsmElement.list(ObservableProperty.___003C_003ETYPES, CsmElement.newline(), CsmElement.newline(), CsmElement.none(), CsmElement.newline()), CsmElement.child(ObservableProperty.___003C_003EMODULE), CsmElement.orphanCommentsEnding()));
		concreteSyntaxModelByClass.put(ClassLiteral<ImportDeclaration>.Value, CsmElement.sequence(CsmElement.comment(), CsmElement.token(36), CsmElement.space(), CsmElement.conditional(ObservableProperty.___003C_003ESTATIC, CsmConditional.Condition.___003C_003EFLAG, CsmElement.sequence(CsmElement.token(51), CsmElement.space())), CsmElement.child(ObservableProperty.___003C_003ENAME), CsmElement.conditional(ObservableProperty.___003C_003EASTERISK, CsmConditional.Condition.___003C_003EFLAG, CsmElement.sequence(CsmElement.token(105), CsmElement.token(126))), CsmElement.semicolon(), CsmElement.orphanCommentsEnding()));
		concreteSyntaxModelByClass.put(ClassLiteral<PackageDeclaration>.Value, CsmElement.sequence(CsmElement.comment(), memberAnnotations(), CsmElement.token(44), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003ENAME), CsmElement.semicolon(), CsmElement.newline(), CsmElement.newline(), CsmElement.orphanCommentsEnding()));
		concreteSyntaxModelByClass.put(ClassLiteral<ModuleDeclaration>.Value, CsmElement.sequence(memberAnnotations(), CsmElement.conditional(ObservableProperty.___003C_003EOPEN, CsmConditional.Condition.___003C_003EFLAG, CsmElement.sequence(CsmElement.token(69), CsmElement.space())), CsmElement.token(72), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003ENAME), CsmElement.space(), CsmElement.token(99), CsmElement.newline(), CsmElement.indent(), CsmElement.list(ObservableProperty.___003C_003EDIRECTIVES), CsmElement.unindent(), CsmElement.token(100), CsmElement.newline()));
		concreteSyntaxModelByClass.put(ClassLiteral<ModuleExportsDirective>.Value, CsmElement.sequence(CsmElement.token(73), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003ENAME), CsmElement.list(ObservableProperty.___003C_003EMODULE_NAMES, CsmElement.sequence(CsmElement.comma(), CsmElement.space()), CsmElement.sequence(CsmElement.space(), CsmElement.token(67), CsmElement.space()), CsmElement.none()), CsmElement.semicolon(), CsmElement.newline()));
		concreteSyntaxModelByClass.put(ClassLiteral<ModuleOpensDirective>.Value, CsmElement.sequence(CsmElement.token(70), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003ENAME), CsmElement.list(ObservableProperty.___003C_003EMODULE_NAMES, CsmElement.sequence(CsmElement.comma(), CsmElement.space()), CsmElement.sequence(CsmElement.space(), CsmElement.token(67), CsmElement.space()), CsmElement.none()), CsmElement.semicolon(), CsmElement.newline()));
		concreteSyntaxModelByClass.put(ClassLiteral<ModuleProvidesDirective>.Value, CsmElement.sequence(CsmElement.token(74), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003ENAME), CsmElement.list(ObservableProperty.___003C_003EWITH, CsmElement.sequence(CsmElement.comma(), CsmElement.space()), CsmElement.sequence(CsmElement.space(), CsmElement.token(68), CsmElement.space()), CsmElement.none()), CsmElement.semicolon(), CsmElement.newline()));
		concreteSyntaxModelByClass.put(ClassLiteral<ModuleRequiresDirective>.Value, CsmElement.sequence(CsmElement.token(66), CsmElement.space(), modifiers(), CsmElement.child(ObservableProperty.___003C_003ENAME), CsmElement.semicolon(), CsmElement.newline()));
		concreteSyntaxModelByClass.put(ClassLiteral<ModuleUsesDirective>.Value, CsmElement.sequence(CsmElement.token(71), CsmElement.space(), CsmElement.child(ObservableProperty.___003C_003ENAME), CsmElement.semicolon(), CsmElement.newline()));
		List list = (List)JavaParserMetaModel.getNodeMetaModels().stream().filter(new ___003C_003EAnon1())
			.map(new ___003C_003EAnon2())
			.collect(Collectors.toList());
		if (list.isEmpty())
		{
			initializationError = Optional.empty();
			return;
		}
		StringBuilder stringBuilder = new StringBuilder().append("The ").append(ClassLiteral<ConcreteSyntaxModel>.Value.getSimpleName()).append(" should include support for these classes: ");
		Iterable elements = list;
		CharSequence delimiter = default(CharSequence);
		object obj = (delimiter.___003Cref_003E = ", ");
		initializationError = Optional.of(stringBuilder.append(String.join(delimiter, elements)).ToString());
	}
}
