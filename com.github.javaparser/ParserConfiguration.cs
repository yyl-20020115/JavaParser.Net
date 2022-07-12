using System;

using com.github.javaparser.ast;
using com.github.javaparser.ast.comments;
using com.github.javaparser.ast.validator;
using com.github.javaparser.ast.validator.language_level_validations;
using com.github.javaparser.ast.validator.postprocessors;
using com.github.javaparser.printer.lexicalpreservation;
using com.github.javaparser.resolution;
using com.github.javaparser.utils;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.nio.charset;
using java.util;
using java.util.function;

namespace com.github.javaparser;

public class ParserConfiguration
{
	
	
	internal class _1 : Processor
	{
		
		private sealed class ___003C_003EAnon0 : Consumer
		{
			private readonly ParseResult arg_00241;

			private readonly ParserConfiguration arg_00242;

			internal ___003C_003EAnon0(ParseResult P_0, ParserConfiguration P_1)
			{
				arg_00241 = P_0;
				arg_00242 = P_1;
			}

			public void accept(object P_0)
			{
				lambda_0024postProcess_00241(arg_00241, arg_00242, (Node)P_0);
				
			}

			
			public Consumer andThen(Consumer P_0)
			{
				return Consumer._003Cdefault_003EandThen(this, P_0);
			}
		}

		
		private sealed class ___003C_003EAnon1 : Consumer
		{
			private readonly ParserConfiguration arg_00241;

			private readonly Node arg_00242;

			internal ___003C_003EAnon1(ParserConfiguration P_0, Node P_1)
			{
				arg_00241 = P_0;
				arg_00242 = P_1;
			}

			public void accept(object P_0)
			{
				lambda_0024null_00240(arg_00241, arg_00242, (CommentsCollection)P_0);
				
			}

			
			public Consumer andThen(Consumer P_0)
			{
				return Consumer._003Cdefault_003EandThen(this, P_0);
			}
		}

		
		internal ParserConfiguration this_00240;

		
		
		[MethodParameters(new Modifiers[]
		{
			Modifiers.Final | Modifiers.Synthetic,
			Modifiers.Final | Modifiers.Synthetic,
			Modifiers.Synthetic
		})]
		
		private static void lambda_0024postProcess_00241(ParseResult result, ParserConfiguration configuration, Node resultNode)
		{
			result.getCommentsCollection().ifPresent(new ___003C_003EAnon1(configuration, resultNode));
		}

		
		
		[MethodParameters(new Modifiers[]
		{
			Modifiers.Final | Modifiers.Synthetic,
			Modifiers.Final | Modifiers.Synthetic,
			Modifiers.Synthetic
		})]
		
		private static void lambda_0024null_00240(ParserConfiguration configuration, Node resultNode, CommentsCollection comments)
		{
			new CommentsInserter(configuration).insertComments(resultNode, comments.copy().getComments());
		}

		
		
		
		internal _1(ParserConfiguration this_00240)
		{
			this.this_00240 = this_00240;
			base._002Ector();
		}

		
				[MethodParameters(new Modifiers[]
		{
			(Modifiers)0,
			(Modifiers)0
		})]
		
		public override void postProcess(ParseResult result, ParserConfiguration configuration)
		{
			if (configuration.isAttributeComments())
			{
				result.ifSuccessful(new ___003C_003EAnon0(result, configuration));
			}
		}
	}

	
	
	internal class _2 : Processor
	{
		
		private sealed class ___003C_003EAnon0 : Consumer
		{
			private readonly ParseResult arg_00241;

			internal ___003C_003EAnon0(ParseResult P_0)
			{
				arg_00241 = P_0;
			}

			public void accept(object P_0)
			{
				lambda_0024postProcess_00240(arg_00241, (Problem)P_0);
				
			}

			
			public Consumer andThen(Consumer P_0)
			{
				return Consumer._003Cdefault_003EandThen(this, P_0);
			}
		}

		
		internal ParserConfiguration this_00240;

		
		
		
		internal _2(ParserConfiguration this_00240)
		{
			this.this_00240 = this_00240;
			base._002Ector();
		}

		
		
		[MethodParameters(new Modifiers[]
		{
			Modifiers.Final | Modifiers.Synthetic,
			Modifiers.Synthetic
		})]
		
		private static void lambda_0024postProcess_00240(ParseResult result, Problem newProblem)
		{
			result.getProblems().add(newProblem);
		}

		
				[MethodParameters(new Modifiers[]
		{
			(Modifiers)0,
			(Modifiers)0
		})]
		
		public override void postProcess(ParseResult result, ParserConfiguration configuration)
		{
			LanguageLevel languageLevel = this_00240.getLanguageLevel();
			if (languageLevel != null)
			{
				if (languageLevel.postProcessor != null)
				{
					languageLevel.postProcessor.postProcess(result, configuration);
				}
				if (languageLevel.validator != null)
				{
					languageLevel.validator.accept((Node)result.getResult().get(), new ProblemReporter(new ___003C_003EAnon0(result)));
				}
			}
		}
	}

	
	
	internal class _3 : Processor
	{
		
		private sealed class ___003C_003EAnon0 : Consumer
		{
			private readonly ParseResult arg_00241;

			internal ___003C_003EAnon0(ParseResult P_0)
			{
				arg_00241 = P_0;
			}

			public void accept(object P_0)
			{
				lambda_0024postProcess_00241(arg_00241, (SymbolResolver)P_0);
				
			}

			
			public Consumer andThen(Consumer P_0)
			{
				return Consumer._003Cdefault_003EandThen(this, P_0);
			}
		}

		
		private sealed class ___003C_003EAnon1 : Consumer
		{
			private readonly SymbolResolver arg_00241;

			internal ___003C_003EAnon1(SymbolResolver P_0)
			{
				arg_00241 = P_0;
			}

			public void accept(object P_0)
			{
				lambda_0024null_00240(arg_00241, (Node)P_0);
				
			}

			
			public Consumer andThen(Consumer P_0)
			{
				return Consumer._003Cdefault_003EandThen(this, P_0);
			}
		}

		
		internal ParserConfiguration this_00240;

		
		
		
		internal _3(ParserConfiguration this_00240)
		{
			this.this_00240 = this_00240;
			base._002Ector();
		}

		
		
		[MethodParameters(new Modifiers[]
		{
			Modifiers.Final | Modifiers.Synthetic,
			Modifiers.Synthetic
		})]
		
		private static void lambda_0024postProcess_00241(ParseResult result, SymbolResolver symbolResolver)
		{
			result.ifSuccessful(new ___003C_003EAnon1(symbolResolver));
		}

		
		
		[MethodParameters(new Modifiers[]
		{
			Modifiers.Final | Modifiers.Synthetic,
			Modifiers.Synthetic
		})]
		
		private static void lambda_0024null_00240(SymbolResolver symbolResolver, Node resultNode)
		{
			if (resultNode is CompilationUnit)
			{
				resultNode.setData(Node.___003C_003ESYMBOL_RESOLVER_KEY, symbolResolver);
			}
		}

		
				[MethodParameters(new Modifiers[]
		{
			(Modifiers)0,
			(Modifiers)0
		})]
		
		public override void postProcess(ParseResult result, ParserConfiguration configuration)
		{
			configuration.getSymbolResolver().ifPresent(new ___003C_003EAnon0(result));
		}
	}

	
	[EnclosingMethod(null, "lambda$new$5", "()Lcom.github.javaparser.Processor;")]
	internal class _4 : Processor
	{
		
		private sealed class ___003C_003EAnon0 : Consumer
		{
			internal ___003C_003EAnon0()
			{
			}

			public void accept(object P_0)
			{
				LexicalPreservingPrinter.setup((Node)P_0);
				
			}

			
			public Consumer andThen(Consumer P_0)
			{
				return Consumer._003Cdefault_003EandThen(this, P_0);
			}
		}

		
		internal ParserConfiguration this_00240;

		
		
		
		internal _4(ParserConfiguration this_00240)
		{
			this.this_00240 = this_00240;
			base._002Ector();
		}

		
				[MethodParameters(new Modifiers[]
		{
			(Modifiers)0,
			(Modifiers)0
		})]
		
		public override void postProcess(ParseResult result, ParserConfiguration configuration)
		{
			if (configuration.isLexicalPreservationEnabled())
			{
				result.ifSuccessful(new ___003C_003EAnon0());
			}
		}
	}

	
	
		
	public class LanguageLevel : java.lang.Enum
	{
		
		
		public enum __Enum
		{
			JAVA_1_0,
			JAVA_1_1,
			JAVA_1_2,
			JAVA_1_3,
			JAVA_1_4,
			JAVA_5,
			JAVA_6,
			JAVA_7,
			JAVA_8,
			JAVA_9,
			JAVA_10,
			JAVA_10_PREVIEW,
			JAVA_11,
			JAVA_11_PREVIEW,
			JAVA_12,
			JAVA_12_PREVIEW,
			JAVA_13,
			JAVA_13_PREVIEW,
			JAVA_14,
			JAVA_14_PREVIEW,
			JAVA_15,
			JAVA_15_PREVIEW,
			JAVA_16,
			JAVA_16_PREVIEW,
			JAVA_17,
			JAVA_17_PREVIEW
		}

		
		private sealed class ___003C_003EAnon0 : Predicate
		{
			private readonly LanguageLevel arg_00241;

			internal ___003C_003EAnon0(LanguageLevel P_0)
			{
				arg_00241 = P_0;
			}

			public bool test(object P_0)
			{
				bool result = arg_00241.lambda_0024isYieldSupported_00240((LanguageLevel)P_0);
				
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

		
		internal static LanguageLevel ___003C_003EJAVA_1_0;

		
		internal static LanguageLevel ___003C_003EJAVA_1_1;

		
		internal static LanguageLevel ___003C_003EJAVA_1_2;

		
		internal static LanguageLevel ___003C_003EJAVA_1_3;

		
		internal static LanguageLevel ___003C_003EJAVA_1_4;

		
		internal static LanguageLevel ___003C_003EJAVA_5;

		
		internal static LanguageLevel ___003C_003EJAVA_6;

		
		internal static LanguageLevel ___003C_003EJAVA_7;

		
		internal static LanguageLevel ___003C_003EJAVA_8;

		
		internal static LanguageLevel ___003C_003EJAVA_9;

		
		internal static LanguageLevel ___003C_003EJAVA_10;

		
		internal static LanguageLevel ___003C_003EJAVA_10_PREVIEW;

		
		internal static LanguageLevel ___003C_003EJAVA_11;

		
		internal static LanguageLevel ___003C_003EJAVA_11_PREVIEW;

		
		internal static LanguageLevel ___003C_003EJAVA_12;

		
		internal static LanguageLevel ___003C_003EJAVA_12_PREVIEW;

		
		internal static LanguageLevel ___003C_003EJAVA_13;

		
		internal static LanguageLevel ___003C_003EJAVA_13_PREVIEW;

		
		internal static LanguageLevel ___003C_003EJAVA_14;

		
		internal static LanguageLevel ___003C_003EJAVA_14_PREVIEW;

		
		internal static LanguageLevel ___003C_003EJAVA_15;

		
		internal static LanguageLevel ___003C_003EJAVA_15_PREVIEW;

		
		internal static LanguageLevel ___003C_003EJAVA_16;

		
		internal static LanguageLevel ___003C_003EJAVA_16_PREVIEW;

		
		internal static LanguageLevel ___003C_003EJAVA_17;

		
		internal static LanguageLevel ___003C_003EJAVA_17_PREVIEW;

		public static LanguageLevel RAW;

		public static LanguageLevel POPULAR;

		public static LanguageLevel CURRENT;

		public static LanguageLevel BLEEDING_EDGE;

		
		internal Validator validator;

		
		internal PostProcessors postProcessor;

		
		private static LanguageLevel[] yieldSupport;

		
		private static LanguageLevel[] _0024VALUES;

		
		public static LanguageLevel JAVA_1_0
		{
			
			get
			{
				return ___003C_003EJAVA_1_0;
			}
		}

		
		public static LanguageLevel JAVA_1_1
		{
			
			get
			{
				return ___003C_003EJAVA_1_1;
			}
		}

		
		public static LanguageLevel JAVA_1_2
		{
			
			get
			{
				return ___003C_003EJAVA_1_2;
			}
		}

		
		public static LanguageLevel JAVA_1_3
		{
			
			get
			{
				return ___003C_003EJAVA_1_3;
			}
		}

		
		public static LanguageLevel JAVA_1_4
		{
			
			get
			{
				return ___003C_003EJAVA_1_4;
			}
		}

		
		public static LanguageLevel JAVA_5
		{
			
			get
			{
				return ___003C_003EJAVA_5;
			}
		}

		
		public static LanguageLevel JAVA_6
		{
			
			get
			{
				return ___003C_003EJAVA_6;
			}
		}

		
		public static LanguageLevel JAVA_7
		{
			
			get
			{
				return ___003C_003EJAVA_7;
			}
		}

		
		public static LanguageLevel JAVA_8
		{
			
			get
			{
				return ___003C_003EJAVA_8;
			}
		}

		
		public static LanguageLevel JAVA_9
		{
			
			get
			{
				return ___003C_003EJAVA_9;
			}
		}

		
		public static LanguageLevel JAVA_10
		{
			
			get
			{
				return ___003C_003EJAVA_10;
			}
		}

		
		public static LanguageLevel JAVA_10_PREVIEW
		{
			
			get
			{
				return ___003C_003EJAVA_10_PREVIEW;
			}
		}

		
		public static LanguageLevel JAVA_11
		{
			
			get
			{
				return ___003C_003EJAVA_11;
			}
		}

		
		public static LanguageLevel JAVA_11_PREVIEW
		{
			
			get
			{
				return ___003C_003EJAVA_11_PREVIEW;
			}
		}

		
		public static LanguageLevel JAVA_12
		{
			
			get
			{
				return ___003C_003EJAVA_12;
			}
		}

		
		public static LanguageLevel JAVA_12_PREVIEW
		{
			
			get
			{
				return ___003C_003EJAVA_12_PREVIEW;
			}
		}

		
		public static LanguageLevel JAVA_13
		{
			
			get
			{
				return ___003C_003EJAVA_13;
			}
		}

		
		public static LanguageLevel JAVA_13_PREVIEW
		{
			
			get
			{
				return ___003C_003EJAVA_13_PREVIEW;
			}
		}

		
		public static LanguageLevel JAVA_14
		{
			
			get
			{
				return ___003C_003EJAVA_14;
			}
		}

		
		public static LanguageLevel JAVA_14_PREVIEW
		{
			
			get
			{
				return ___003C_003EJAVA_14_PREVIEW;
			}
		}

		
		public static LanguageLevel JAVA_15
		{
			
			get
			{
				return ___003C_003EJAVA_15;
			}
		}

		
		public static LanguageLevel JAVA_15_PREVIEW
		{
			
			get
			{
				return ___003C_003EJAVA_15_PREVIEW;
			}
		}

		
		public static LanguageLevel JAVA_16
		{
			
			get
			{
				return ___003C_003EJAVA_16;
			}
		}

		
		public static LanguageLevel JAVA_16_PREVIEW
		{
			
			get
			{
				return ___003C_003EJAVA_16_PREVIEW;
			}
		}

		
		public static LanguageLevel JAVA_17
		{
			
			get
			{
				return ___003C_003EJAVA_17;
			}
		}

		
		public static LanguageLevel JAVA_17_PREVIEW
		{
			
			get
			{
				return ___003C_003EJAVA_17_PREVIEW;
			}
		}

		
		
		public static void ___003Cclinit_003E()
		{
		}

		
		
		public virtual bool isYieldSupported()
		{
			bool result = Arrays.stream(yieldSupport).anyMatch(new ___003C_003EAnon0(this));
			
			return result;
		}

		
				[MethodParameters(new Modifiers[]
		{
			Modifiers.Synthetic,
			Modifiers.Synthetic,
			(Modifiers)0,
			(Modifiers)0
		})]
		
		private LanguageLevel(string _0024enum_0024name, int _0024enum_0024ordinal, Validator validator, PostProcessors postProcessor)
			: base(_0024enum_0024name, _0024enum_0024ordinal)
		{
			this.validator = validator;
			this.postProcessor = postProcessor;
			GC.KeepAlive(this);
		}

		
		
		private bool lambda_0024isYieldSupported_00240(LanguageLevel level)
		{
			return level == this;
		}

		
		
		public static LanguageLevel[] values()
		{
			return (LanguageLevel[])_0024VALUES.Clone();
		}

		
		
		
		public static LanguageLevel valueOf(string name)
		{
			return (LanguageLevel)java.lang.Enum.valueOf(ClassLiteral<LanguageLevel>.Value, name);
		}

		[LineNumberTable(new byte[]
		{
			4,
			214,
			214,
			214,
			214,
			214,
			214,
			214,
			214,
			214,
			215,
			251,
			69,
			219,
			251,
			69,
			219,
			251,
			72,
			219,
			251,
			72,
			219,
			251,
			69,
			219,
			251,
			69,
			219,
			251,
			69,
			219,
			251,
			69,
			251,
			159,
			138,
			byte.MaxValue,
			160,
			142,
			160,
			123,
			198,
			202,
			202,
			234,
			69
		})]
		static LanguageLevel()
		{
			___003C_003EJAVA_1_0 = new LanguageLevel("JAVA_1_0", 0, new Java1_0Validator(), null);
			___003C_003EJAVA_1_1 = new LanguageLevel("JAVA_1_1", 1, new Java1_1Validator(), null);
			___003C_003EJAVA_1_2 = new LanguageLevel("JAVA_1_2", 2, new Java1_2Validator(), null);
			___003C_003EJAVA_1_3 = new LanguageLevel("JAVA_1_3", 3, new Java1_3Validator(), null);
			___003C_003EJAVA_1_4 = new LanguageLevel("JAVA_1_4", 4, new Java1_4Validator(), null);
			___003C_003EJAVA_5 = new LanguageLevel("JAVA_5", 5, new Java5Validator(), null);
			___003C_003EJAVA_6 = new LanguageLevel("JAVA_6", 6, new Java6Validator(), null);
			___003C_003EJAVA_7 = new LanguageLevel("JAVA_7", 7, new Java7Validator(), null);
			___003C_003EJAVA_8 = new LanguageLevel("JAVA_8", 8, new Java8Validator(), null);
			___003C_003EJAVA_9 = new LanguageLevel("JAVA_9", 9, new Java9Validator(), null);
			___003C_003EJAVA_10 = new LanguageLevel("JAVA_10", 10, new Java10Validator(), new Java10PostProcessor());
			___003C_003EJAVA_10_PREVIEW = new LanguageLevel("JAVA_10_PREVIEW", 11, new Java10PreviewValidator(), new Java10PostProcessor());
			___003C_003EJAVA_11 = new LanguageLevel("JAVA_11", 12, new Java11Validator(), new Java11PostProcessor());
			___003C_003EJAVA_11_PREVIEW = new LanguageLevel("JAVA_11_PREVIEW", 13, new Java11PreviewValidator(), new Java11PostProcessor());
			___003C_003EJAVA_12 = new LanguageLevel("JAVA_12", 14, new Java12Validator(), new Java12PostProcessor());
			___003C_003EJAVA_12_PREVIEW = new LanguageLevel("JAVA_12_PREVIEW", 15, new Java12PreviewValidator(), new Java12PostProcessor());
			___003C_003EJAVA_13 = new LanguageLevel("JAVA_13", 16, new Java13Validator(), new Java13PostProcessor());
			___003C_003EJAVA_13_PREVIEW = new LanguageLevel("JAVA_13_PREVIEW", 17, new Java13PreviewValidator(), new Java13PostProcessor());
			___003C_003EJAVA_14 = new LanguageLevel("JAVA_14", 18, new Java14Validator(), new Java14PostProcessor());
			___003C_003EJAVA_14_PREVIEW = new LanguageLevel("JAVA_14_PREVIEW", 19, new Java14PreviewValidator(), new Java14PostProcessor());
			___003C_003EJAVA_15 = new LanguageLevel("JAVA_15", 20, new Java15Validator(), new Java15PostProcessor());
			___003C_003EJAVA_15_PREVIEW = new LanguageLevel("JAVA_15_PREVIEW", 21, new Java15PreviewValidator(), new Java15PostProcessor());
			___003C_003EJAVA_16 = new LanguageLevel("JAVA_16", 22, new Java16Validator(), new Java16PostProcessor());
			___003C_003EJAVA_16_PREVIEW = new LanguageLevel("JAVA_16_PREVIEW", 23, new Java16PreviewValidator(), new Java16PostProcessor());
			___003C_003EJAVA_17 = new LanguageLevel("JAVA_17", 24, new Java17Validator(), new Java17PostProcessor());
			___003C_003EJAVA_17_PREVIEW = new LanguageLevel("JAVA_17_PREVIEW", 25, new Java17PreviewValidator(), new Java17PostProcessor());
			_0024VALUES = new LanguageLevel[26]
			{
				___003C_003EJAVA_1_0, ___003C_003EJAVA_1_1, ___003C_003EJAVA_1_2, ___003C_003EJAVA_1_3, ___003C_003EJAVA_1_4, ___003C_003EJAVA_5, ___003C_003EJAVA_6, ___003C_003EJAVA_7, ___003C_003EJAVA_8, ___003C_003EJAVA_9,
				___003C_003EJAVA_10, ___003C_003EJAVA_10_PREVIEW, ___003C_003EJAVA_11, ___003C_003EJAVA_11_PREVIEW, ___003C_003EJAVA_12, ___003C_003EJAVA_12_PREVIEW, ___003C_003EJAVA_13, ___003C_003EJAVA_13_PREVIEW, ___003C_003EJAVA_14, ___003C_003EJAVA_14_PREVIEW,
				___003C_003EJAVA_15, ___003C_003EJAVA_15_PREVIEW, ___003C_003EJAVA_16, ___003C_003EJAVA_16_PREVIEW, ___003C_003EJAVA_17, ___003C_003EJAVA_17_PREVIEW
			};
			RAW = null;
			POPULAR = ___003C_003EJAVA_11;
			CURRENT = ___003C_003EJAVA_16;
			BLEEDING_EDGE = ___003C_003EJAVA_17_PREVIEW;
			yieldSupport = new LanguageLevel[10] { ___003C_003EJAVA_13, ___003C_003EJAVA_13_PREVIEW, ___003C_003EJAVA_14, ___003C_003EJAVA_14_PREVIEW, ___003C_003EJAVA_15, ___003C_003EJAVA_15_PREVIEW, ___003C_003EJAVA_16, ___003C_003EJAVA_16_PREVIEW, ___003C_003EJAVA_17, ___003C_003EJAVA_17_PREVIEW };
		}
	}

	[InnerClass(null, Modifiers.Private)]
	internal class LineEndingProcessor : Processor
	{
		
		private sealed class ___003C_003EAnon0 : Consumer
		{
			private readonly LineEndingProcessor arg_00241;

			internal ___003C_003EAnon0(LineEndingProcessor P_0)
			{
				arg_00241 = P_0;
			}

			public void accept(object P_0)
			{
				arg_00241.lambda_0024postProcess_00240((Node)P_0);
				
			}

			
			public Consumer andThen(Consumer P_0)
			{
				return Consumer._003Cdefault_003EandThen(this, P_0);
			}
		}

		private LineEndingProcessingProvider _lineEndingProcessingProvider;

		
		internal ParserConfiguration this_00240;

		
		
		
		internal LineEndingProcessor(ParserConfiguration P_0, _1 P_1)
			: this(P_0)
		{
		}

		
		
		
		private LineEndingProcessor(ParserConfiguration this_00240)
		{
			this.this_00240 = this_00240;
			base._002Ector();
		}

		
		
		
		
		private void lambda_0024postProcess_00240(Node rootNode)
		{
			LineSeparator detectedLineEnding = _lineEndingProcessingProvider.getDetectedLineEnding();
			rootNode.setData(Node.___003C_003ELINE_SEPARATOR_KEY, detectedLineEnding);
		}

		
		
		
		public override Provider preProcess(Provider innerProvider)
		{
			if (this_00240.isDetectOriginalLineSeparator())
			{
				_lineEndingProcessingProvider = new LineEndingProcessingProvider(innerProvider);
				return _lineEndingProcessingProvider;
			}
			return innerProvider;
		}

		
				[MethodParameters(new Modifiers[]
		{
			(Modifiers)0,
			(Modifiers)0
		})]
		
		public override void postProcess(ParseResult result, ParserConfiguration configuration)
		{
			if (this_00240.isDetectOriginalLineSeparator())
			{
				result.getResult().ifPresent(new ___003C_003EAnon0(this));
			}
		}
	}

	[InnerClass(null, Modifiers.Private)]
	internal class UnicodeEscapeProcessor : Processor
	{
		
		private sealed class ___003C_003EAnon0 : Consumer
		{
			private readonly UnicodeEscapeProcessor arg_00241;

			internal ___003C_003EAnon0(UnicodeEscapeProcessor P_0)
			{
				arg_00241 = P_0;
			}

			public void accept(object P_0)
			{
				arg_00241.lambda_0024postProcess_00242((Node)P_0);
				
			}

			
			public Consumer andThen(Consumer P_0)
			{
				return Consumer._003Cdefault_003EandThen(this, P_0);
			}
		}

		
		private sealed class ___003C_003EAnon1 : Consumer
		{
			private readonly UnicodeEscapeProcessingProvider.PositionMapping arg_00241;

			internal ___003C_003EAnon1(UnicodeEscapeProcessingProvider.PositionMapping P_0)
			{
				arg_00241 = P_0;
			}

			public void accept(object P_0)
			{
				lambda_0024null_00241(arg_00241, (Node)P_0);
				
			}

			
			public Consumer andThen(Consumer P_0)
			{
				return Consumer._003Cdefault_003EandThen(this, P_0);
			}
		}

		
		private sealed class ___003C_003EAnon2 : Consumer
		{
			private readonly Node arg_00241;

			private readonly UnicodeEscapeProcessingProvider.PositionMapping arg_00242;

			internal ___003C_003EAnon2(Node P_0, UnicodeEscapeProcessingProvider.PositionMapping P_1)
			{
				arg_00241 = P_0;
				arg_00242 = P_1;
			}

			public void accept(object P_0)
			{
				lambda_0024null_00240(arg_00241, arg_00242, (Range)P_0);
				
			}

			
			public Consumer andThen(Consumer P_0)
			{
				return Consumer._003Cdefault_003EandThen(this, P_0);
			}
		}

		private UnicodeEscapeProcessingProvider _unicodeDecoder;

		
		internal ParserConfiguration this_00240;

		
		
		
		internal UnicodeEscapeProcessor(ParserConfiguration P_0, _1 P_1)
			: this(P_0)
		{
		}

		
		
		
		private UnicodeEscapeProcessor(ParserConfiguration this_00240)
		{
			this.this_00240 = this_00240;
			base._002Ector();
		}

		
		
		
		
		private void lambda_0024postProcess_00242(Node root)
		{
			UnicodeEscapeProcessingProvider.PositionMapping positionMapping = _unicodeDecoder.getPositionMapping();
			if (!positionMapping.isEmpty())
			{
				root.walk(new ___003C_003EAnon1(positionMapping));
			}
		}

		
		
		[MethodParameters(new Modifiers[]
		{
			Modifiers.Final | Modifiers.Synthetic,
			Modifiers.Synthetic
		})]
		
		private static void lambda_0024null_00241(UnicodeEscapeProcessingProvider.PositionMapping mapping, Node node)
		{
			node.getRange().ifPresent(new ___003C_003EAnon2(node, mapping));
		}

		
		
		[MethodParameters(new Modifiers[]
		{
			Modifiers.Final | Modifiers.Synthetic,
			Modifiers.Final | Modifiers.Synthetic,
			Modifiers.Synthetic
		})]
		
		private static void lambda_0024null_00240(Node node, UnicodeEscapeProcessingProvider.PositionMapping mapping, Range range)
		{
			node.setRange(mapping.transform(range));
		}

		
		
		
		public override Provider preProcess(Provider innerProvider)
		{
			if (this_00240.isPreprocessUnicodeEscapes())
			{
				_unicodeDecoder = new UnicodeEscapeProcessingProvider(innerProvider);
				return _unicodeDecoder;
			}
			return innerProvider;
		}

		
				[MethodParameters(new Modifiers[]
		{
			(Modifiers)0,
			(Modifiers)0
		})]
		
		public override void postProcess(ParseResult result, ParserConfiguration configuration)
		{
			if (this_00240.isPreprocessUnicodeEscapes())
			{
				result.getResult().ifPresent(new ___003C_003EAnon0(this));
			}
		}
	}

	
	private sealed class ___003C_003EAnon0 : Supplier
	{
		private readonly ParserConfiguration arg_00241;

		internal ___003C_003EAnon0(ParserConfiguration P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			Processor result = arg_00241.lambda_0024new_00240();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon1 : Supplier
	{
		private readonly ParserConfiguration arg_00241;

		internal ___003C_003EAnon1(ParserConfiguration P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			Processor result = arg_00241.lambda_0024new_00241();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon2 : Supplier
	{
		private readonly ParserConfiguration arg_00241;

		internal ___003C_003EAnon2(ParserConfiguration P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			Processor result = arg_00241.lambda_0024new_00242();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon3 : Supplier
	{
		private readonly ParserConfiguration arg_00241;

		internal ___003C_003EAnon3(ParserConfiguration P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			Processor result = arg_00241.lambda_0024new_00243();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon4 : Supplier
	{
		private readonly ParserConfiguration arg_00241;

		internal ___003C_003EAnon4(ParserConfiguration P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			Processor result = arg_00241.lambda_0024new_00244();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon5 : Supplier
	{
		private readonly ParserConfiguration arg_00241;

		internal ___003C_003EAnon5(ParserConfiguration P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			Processor result = arg_00241.lambda_0024new_00245();
			
			return result;
		}
	}

	private bool detectOriginalLineSeparator;

	private bool storeTokens;

	private bool attributeComments;

	private bool doNotAssignCommentsPrecedingEmptyLines;

	private bool ignoreAnnotationsWhenAttributingComments;

	private bool lexicalPreservationEnabled;

	private bool preprocessUnicodeEscapes;

	private SymbolResolver symbolResolver;

	private int tabSize;

	private LanguageLevel languageLevel;

	private Charset characterEncoding;

	
		private List processors;

	
	[LineNumberTable(new byte[]
	{
		160, 171, 232, 159, 181, 103, 103, 103, 103, 103,
		103, 103, 103, 103, 107, 139, 235, 160, 64, 151,
		151, 247, 74, 247, 78, 247, 75, 247, 72
	})]
	public ParserConfiguration()
	{
		detectOriginalLineSeparator = true;
		storeTokens = true;
		attributeComments = true;
		doNotAssignCommentsPrecedingEmptyLines = true;
		ignoreAnnotationsWhenAttributingComments = false;
		lexicalPreservationEnabled = false;
		preprocessUnicodeEscapes = false;
		symbolResolver = null;
		tabSize = 1;
		languageLevel = LanguageLevel.POPULAR;
		characterEncoding = Providers.___003C_003EUTF8;
		processors = new ArrayList();
		processors.add((Supplier)new ___003C_003EAnon0(this));
		processors.add((Supplier)new ___003C_003EAnon1(this));
		processors.add((Supplier)new ___003C_003EAnon2(this));
		processors.add((Supplier)new ___003C_003EAnon3(this));
		processors.add((Supplier)new ___003C_003EAnon4(this));
		processors.add((Supplier)new ___003C_003EAnon5(this));
	}

	
	public virtual ParserConfiguration setLanguageLevel(LanguageLevel languageLevel)
	{
		this.languageLevel = languageLevel;
		return this;
	}

	public virtual bool isIgnoreAnnotationsWhenAttributingComments()
	{
		return ignoreAnnotationsWhenAttributingComments;
	}

	public virtual bool isDoNotAssignCommentsPrecedingEmptyLines()
	{
		return doNotAssignCommentsPrecedingEmptyLines;
	}

	public virtual int getTabSize()
	{
		return tabSize;
	}

	public virtual bool isStoreTokens()
	{
		return storeTokens;
	}

	public virtual LanguageLevel getLanguageLevel()
	{
		return languageLevel;
	}

		public virtual List getProcessors()
	{
		return processors;
	}

	public virtual Charset getCharacterEncoding()
	{
		return characterEncoding;
	}

	public virtual bool isAttributeComments()
	{
		return attributeComments;
	}

	
	public virtual ParserConfiguration setAttributeComments(bool attributeComments)
	{
		int num = ((this.attributeComments = attributeComments) ? 1 : 0);
		return this;
	}

	
	
	
	private Processor lambda_0024new_00240()
	{
		UnicodeEscapeProcessor result = new UnicodeEscapeProcessor(this, null);
		
		return result;
	}

	
	
	
	private Processor lambda_0024new_00241()
	{
		LineEndingProcessor result = new LineEndingProcessor(this, null);
		
		return result;
	}

	
	
	
	private Processor lambda_0024new_00242()
	{
		_1 result = new _1(this);
		
		return result;
	}

	
	
	
	private Processor lambda_0024new_00243()
	{
		_2 result = new _2(this);
		
		return result;
	}

	
	
	
	private Processor lambda_0024new_00244()
	{
		_3 result = new _3(this);
		
		return result;
	}

	
	
	
	private Processor lambda_0024new_00245()
	{
		_4 result = new _4(this);
		
		return result;
	}

	
	public virtual ParserConfiguration setDoNotAssignCommentsPrecedingEmptyLines(bool doNotAssignCommentsPrecedingEmptyLines)
	{
		int num = ((this.doNotAssignCommentsPrecedingEmptyLines = doNotAssignCommentsPrecedingEmptyLines) ? 1 : 0);
		return this;
	}

	
	public virtual ParserConfiguration setIgnoreAnnotationsWhenAttributingComments(bool ignoreAnnotationsWhenAttributingComments)
	{
		int num = ((this.ignoreAnnotationsWhenAttributingComments = ignoreAnnotationsWhenAttributingComments) ? 1 : 0);
		return this;
	}

	
	
	
	public virtual ParserConfiguration setStoreTokens(bool storeTokens)
	{
		if (!(this.storeTokens = storeTokens))
		{
			setAttributeComments(attributeComments: false);
		}
		return this;
	}

	
	public virtual ParserConfiguration setTabSize(int tabSize)
	{
		this.tabSize = tabSize;
		return this;
	}

	
	public virtual ParserConfiguration setLexicalPreservationEnabled(bool lexicalPreservationEnabled)
	{
		int num = ((this.lexicalPreservationEnabled = lexicalPreservationEnabled) ? 1 : 0);
		return this;
	}

	public virtual bool isLexicalPreservationEnabled()
	{
		return lexicalPreservationEnabled;
	}

	
		
	public virtual Optional getSymbolResolver()
	{
		Optional result = Optional.ofNullable(symbolResolver);
		
		return result;
	}

	
	public virtual ParserConfiguration setSymbolResolver(SymbolResolver symbolResolver)
	{
		this.symbolResolver = symbolResolver;
		return this;
	}

	
	public virtual ParserConfiguration setPreprocessUnicodeEscapes(bool preprocessUnicodeEscapes)
	{
		int num = ((this.preprocessUnicodeEscapes = preprocessUnicodeEscapes) ? 1 : 0);
		return this;
	}

	public virtual bool isPreprocessUnicodeEscapes()
	{
		return preprocessUnicodeEscapes;
	}

	
	public virtual ParserConfiguration setDetectOriginalLineSeparator(bool detectOriginalLineSeparator)
	{
		int num = ((this.detectOriginalLineSeparator = detectOriginalLineSeparator) ? 1 : 0);
		return this;
	}

	public virtual bool isDetectOriginalLineSeparator()
	{
		return detectOriginalLineSeparator;
	}

	
	public virtual ParserConfiguration setCharacterEncoding(Charset characterEncoding)
	{
		this.characterEncoding = characterEncoding;
		return this;
	}
}
