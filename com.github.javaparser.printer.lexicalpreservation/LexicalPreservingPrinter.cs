using System;

using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.comments;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.type;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.printer.concretesyntaxmodel;
using com.github.javaparser.utils;

using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.lang.reflect;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.printer.lexicalpreservation;

public class LexicalPreservingPrinter
{
	
		
	internal sealed class _1 : DataKey
	{
		
		
		internal _1()
		{
		}
	}

	
	[EnclosingMethod(null, "lambda$storeInitialText$3", "(Lcom.github.javaparser.ast.Node;Ljava.util.Map;Lcom.github.javaparser.TokenRange;)V")]
	internal sealed class _2 : TreeVisitor
	{
		
		internal Map val_0024tokensByNode;

		
		
		
		internal _2(Map val_0024tokensByNode)
		{
			this.val_0024tokensByNode = val_0024tokensByNode;
			
		}

		
		
		
		public override void process(Node node)
		{
			if (!node.isPhantom())
			{
				access_0024300(node, (List)val_0024tokensByNode.get(node));
			}
		}
	}

	
	
	
	
	internal class _3
	{
		
		internal static int[] _0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024type_0024PrimitiveType_0024Primitive;

		
		
		public static void ___003Cclinit_003E()
		{
		}

		
		static _3()
		{
			_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024type_0024PrimitiveType_0024Primitive = new int[(nint)PrimitiveType.Primitive.values().LongLength];
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024type_0024PrimitiveType_0024Primitive[PrimitiveType.Primitive.___003C_003EBOOLEAN.ordinal()] = 1;
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
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024type_0024PrimitiveType_0024Primitive[PrimitiveType.Primitive.___003C_003ECHAR.ordinal()] = 2;
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
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024type_0024PrimitiveType_0024Primitive[PrimitiveType.Primitive.___003C_003EBYTE.ordinal()] = 3;
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
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024type_0024PrimitiveType_0024Primitive[PrimitiveType.Primitive.___003C_003ESHORT.ordinal()] = 4;
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
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024type_0024PrimitiveType_0024Primitive[PrimitiveType.Primitive.___003C_003EINT.ordinal()] = 5;
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
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024type_0024PrimitiveType_0024Primitive[PrimitiveType.Primitive.___003C_003ELONG.ordinal()] = 6;
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
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024type_0024PrimitiveType_0024Primitive[PrimitiveType.Primitive.___003C_003EFLOAT.ordinal()] = 7;
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
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024type_0024PrimitiveType_0024Primitive[PrimitiveType.Primitive.___003C_003EDOUBLE.ordinal()] = 8;
				return;
			}
			catch (System.Exception x8)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x8, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
			}
			
		}

		_3()
		{
			throw null;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	internal class Observer : PropagatingAstObserver
	{
		
		private sealed class ___003C_003EAnon0 : Function
		{
			private readonly Optional arg_00241;

			internal ___003C_003EAnon0(Optional P_0)
			{
				arg_00241 = P_0;
			}

			public object apply(object P_0)
			{
				NodeText result = lambda_0024concretePropertyChange_00240(arg_00241, (Node)P_0);
				
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

		
		private sealed class ___003C_003EAnon1 : Predicate
		{
			internal ___003C_003EAnon1()
			{
			}

			public bool test(object P_0)
			{
				bool result = lambda_0024findChildTextElementForComment_00241((TextElement)P_0);
				
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
				ChildTextElement result = lambda_0024findChildTextElementForComment_00242((TextElement)P_0);
				
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

		
		private sealed class ___003C_003EAnon3 : Predicate
		{
			internal ___003C_003EAnon3()
			{
			}

			public bool test(object P_0)
			{
				bool result = lambda_0024findChildTextElementForComment_00243((ChildTextElement)P_0);
				
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

		
		private sealed class ___003C_003EAnon4 : Predicate
		{
			private readonly Comment arg_00241;

			internal ___003C_003EAnon4(Comment P_0)
			{
				arg_00241 = P_0;
			}

			public bool test(object P_0)
			{
				bool result = lambda_0024findChildTextElementForComment_00244(arg_00241, (ChildTextElement)P_0);
				
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

		
		private sealed class ___003C_003EAnon5 : Predicate
		{
			private readonly Observer arg_00241;

			private readonly Comment arg_00242;

			internal ___003C_003EAnon5(Observer P_0, Comment P_1)
			{
				arg_00241 = P_0;
				arg_00242 = P_1;
			}

			public bool test(object P_0)
			{
				bool result = arg_00241.lambda_0024findChildTextElementForComment_00245(arg_00242, (ChildTextElement)P_0);
				
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

		
		private sealed class ___003C_003EAnon6 : Predicate
		{
			internal ___003C_003EAnon6()
			{
			}

			public bool test(object P_0)
			{
				bool result = lambda_0024findTokenTextElementForComment_00246((TextElement)P_0);
				
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

		
		private sealed class ___003C_003EAnon7 : Function
		{
			internal ___003C_003EAnon7()
			{
			}

			public object apply(object P_0)
			{
				TokenTextElement result = lambda_0024findTokenTextElementForComment_00247((TextElement)P_0);
				
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

		
		private sealed class ___003C_003EAnon8 : Predicate
		{
			private readonly Comment arg_00241;

			internal ___003C_003EAnon8(Comment P_0)
			{
				arg_00241 = P_0;
			}

			public bool test(object P_0)
			{
				bool result = lambda_0024findTokenTextElementForComment_00248(arg_00241, (TokenTextElement)P_0);
				
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

		
		private sealed class ___003C_003EAnon9 : Predicate
		{
			internal ___003C_003EAnon9()
			{
			}

			public bool test(object P_0)
			{
				bool result = lambda_0024findTokenTextElementForComment_00249((TextElement)P_0);
				
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

		
		private sealed class ___003C_003EAnon10 : Function
		{
			internal ___003C_003EAnon10()
			{
			}

			public object apply(object P_0)
			{
				TokenTextElement result = lambda_0024findTokenTextElementForComment_002410((TextElement)P_0);
				
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

		
		private sealed class ___003C_003EAnon11 : Predicate
		{
			private readonly Comment arg_00241;

			internal ___003C_003EAnon11(Comment P_0)
			{
				arg_00241 = P_0;
			}

			public bool test(object P_0)
			{
				bool result = lambda_0024findTokenTextElementForComment_002411(arg_00241, (TokenTextElement)P_0);
				
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

		
		private sealed class ___003C_003EAnon12 : Predicate
		{
			internal ___003C_003EAnon12()
			{
			}

			public bool test(object P_0)
			{
				bool result = lambda_0024findTokenTextElementForComment_002412((TextElement)P_0);
				
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

		
		private sealed class ___003C_003EAnon13 : Function
		{
			internal ___003C_003EAnon13()
			{
			}

			public object apply(object P_0)
			{
				TokenTextElement result = lambda_0024findTokenTextElementForComment_002413((TextElement)P_0);
				
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

		
		private sealed class ___003C_003EAnon14 : Predicate
		{
			private readonly Comment arg_00241;

			internal ___003C_003EAnon14(Comment P_0)
			{
				arg_00241 = P_0;
			}

			public bool test(object P_0)
			{
				bool result = lambda_0024findTokenTextElementForComment_002414(arg_00241, (TokenTextElement)P_0);
				
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

		
		private sealed class ___003C_003EAnon15 : Predicate
		{
			private readonly Observer arg_00241;

			private readonly Comment arg_00242;

			internal ___003C_003EAnon15(Observer P_0, Comment P_1)
			{
				arg_00241 = P_0;
				arg_00242 = P_1;
			}

			public bool test(object P_0)
			{
				bool result = arg_00241.lambda_0024findTokenTextElementForComment_002415(arg_00242, (TokenTextElement)P_0);
				
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

		
		
		
		internal Observer(LexicalPreservingPrinter._1 P_0)
			: this()
		{
		}

		
		
		private Observer()
		{
		}

		
		
		
		private void fixIndentOfMovedNode(NodeText nodeText, int index)
		{
			if (index <= 0)
			{
				return;
			}
			TextElement textElement = null;
			for (int i = index - 1; i >= 0; i += -1)
			{
				TextElement textElement2 = nodeText.getTextElement(i);
				if (textElement2.isSpaceOrTab())
				{
					textElement = nodeText.getTextElement(i);
				}
				if (textElement2.isSpaceOrTab())
				{
					continue;
				}
				if (!textElement2.isNewline() || i == index - 1)
				{
					break;
				}
				for (int j = 0; j < index - 1 - i; j++)
				{
					if (textElement != null)
					{
						nodeText.addElement(index, new TokenTextElement(JavaToken.Kind.___003C_003ESPACE.getKind(), textElement.expand()));
					}
					else
					{
						nodeText.addElement(index, new TokenTextElement(JavaToken.Kind.___003C_003ESPACE.getKind()));
					}
				}
				break;
			}
		}

		
		
		
		private TokenTextElement makeCommentToken(Comment newComment)
		{
			if (newComment.isJavadocComment())
			{
				TokenTextElement result = new TokenTextElement(8, new StringBuilder().append("/**").append(newComment.getContent()).append("*/")
					.ToString());
				
				return result;
			}
			if (newComment.isLineComment())
			{
				TokenTextElement result2 = new TokenTextElement(5, new StringBuilder().append("//").append(newComment.getContent()).ToString());
				
				return result2;
			}
			if (newComment.isBlockComment())
			{
				TokenTextElement result3 = new TokenTextElement(9, new StringBuilder().append("/*").append(newComment.getContent()).append("*/")
					.ToString());
				
				return result3;
			}
			string message = new StringBuilder().append("Unknown type of comment: ").append(java.lang.Object.instancehelper_getClass(newComment).getSimpleName()).ToString();
			
			throw new UnsupportedOperationException(message);
		}

		
		
		
		private int getIndexOfComment(Comment oldValue, NodeText nodeText)
		{
			List list = findTokenTextElementForComment(oldValue, nodeText);
			if (!list.isEmpty())
			{
				TextElement textElement = (TextElement)list.get(0);
				int result = nodeText.findElement(textElement.and(textElement.matchByRange()));
				
				return result;
			}
			List list2 = findChildTextElementForComment(oldValue, nodeText);
			ChildTextElement childTextElement = (ChildTextElement)list2.get(0);
			int result2 = nodeText.findElement(childTextElement.and(childTextElement.matchByRange()));
			
			return result2;
		}

		
				
		
		private List findTokenTextElementForComment(Comment oldValue, NodeText nodeText)
		{
			List list = ((oldValue is JavadocComment) ? ((List)nodeText.getElements().stream().filter(new ___003C_003EAnon6())
				.map(new ___003C_003EAnon7())
				.filter(new ___003C_003EAnon8(oldValue))
				.collect(Collectors.toList())) : ((!(oldValue is BlockComment)) ? ((List)nodeText.getElements().stream().filter(new ___003C_003EAnon12())
				.map(new ___003C_003EAnon13())
				.filter(new ___003C_003EAnon14(oldValue))
				.collect(Collectors.toList())) : ((List)nodeText.getElements().stream().filter(new ___003C_003EAnon9())
				.map(new ___003C_003EAnon10())
				.filter(new ___003C_003EAnon11(oldValue))
				.collect(Collectors.toList()))));
			if (list.size() > 1)
			{
				list = (List)list.stream().filter(new ___003C_003EAnon15(this, oldValue)).collect(Collectors.toList());
			}
			return list;
		}

		
				
		
		private List findChildTextElementForComment(Comment oldValue, NodeText nodeText)
		{
			List list = (List)nodeText.getElements().stream().filter(new ___003C_003EAnon1())
				.map(new ___003C_003EAnon2())
				.filter(new ___003C_003EAnon3())
				.filter(new ___003C_003EAnon4(oldValue))
				.collect(Collectors.toList());
			if (list.size() > 1)
			{
				list = (List)list.stream().filter(new ___003C_003EAnon5(this, oldValue)).collect(Collectors.toList());
			}
			if (list.size() != 1)
			{
				
				throw new IllegalStateException("The matching child text element for the comment to be removed could not be found.");
			}
			return list;
		}

		
				
		
		private bool isEqualRange(Optional range1, Optional range2)
		{
			if (range1.isPresent() && range2.isPresent())
			{
				bool result = ((Range)range1.get()).equals(range2.get());
				
				return result;
			}
			return false;
		}

		
		
		
		
		private static NodeText lambda_0024concretePropertyChange_00240(Optional parentNode, Node parent)
		{
			NodeText orCreateNodeText = getOrCreateNodeText((Node)parentNode.get());
			
			return orCreateNodeText;
		}

		
		
		
		
		private static bool lambda_0024findChildTextElementForComment_00241(TextElement e)
		{
			bool result = e.isChild();
			
			return result;
		}

		
		
		
		private static ChildTextElement lambda_0024findChildTextElementForComment_00242(TextElement c)
		{
			return (ChildTextElement)c;
		}

		
		
		
		
		private static bool lambda_0024findChildTextElementForComment_00243(ChildTextElement c)
		{
			bool result = c.isComment();
			
			return result;
		}

		
		
		
		
		private static bool lambda_0024findChildTextElementForComment_00244(Comment oldValue, ChildTextElement c)
		{
			bool result = java.lang.String.instancehelper_equals(((Comment)c.getChild()).getContent(), oldValue.getContent());
			
			return result;
		}

		
		
		
		
		private bool lambda_0024findChildTextElementForComment_00245(Comment oldValue, ChildTextElement t)
		{
			bool result = isEqualRange(t.getChild().getRange(), oldValue.getRange());
			
			return result;
		}

		
		
		
		
		private static bool lambda_0024findTokenTextElementForComment_00246(TextElement e)
		{
			bool result = e.isToken(8);
			
			return result;
		}

		
		
		
		private static TokenTextElement lambda_0024findTokenTextElementForComment_00247(TextElement e)
		{
			return (TokenTextElement)e;
		}

		
		
		
		
		private static bool lambda_0024findTokenTextElementForComment_00248(Comment oldValue, TokenTextElement t)
		{
			bool result = java.lang.String.instancehelper_equals(t.getText(), new StringBuilder().append("/**").append(oldValue.getContent()).append("*/")
				.ToString());
			
			return result;
		}

		
		
		
		
		private static bool lambda_0024findTokenTextElementForComment_00249(TextElement e)
		{
			bool result = e.isToken(9);
			
			return result;
		}

		
		
		
		private static TokenTextElement lambda_0024findTokenTextElementForComment_002410(TextElement e)
		{
			return (TokenTextElement)e;
		}

		
		
		
		
		private static bool lambda_0024findTokenTextElementForComment_002411(Comment oldValue, TokenTextElement t)
		{
			bool result = java.lang.String.instancehelper_equals(t.getText(), new StringBuilder().append("/*").append(oldValue.getContent()).append("*/")
				.ToString());
			
			return result;
		}

		
		
		
		
		private static bool lambda_0024findTokenTextElementForComment_002412(TextElement e)
		{
			bool result = e.isToken(5);
			
			return result;
		}

		
		
		
		private static TokenTextElement lambda_0024findTokenTextElementForComment_002413(TextElement e)
		{
			return (TokenTextElement)e;
		}

		
		
		
		
		private static bool lambda_0024findTokenTextElementForComment_002414(Comment oldValue, TokenTextElement t)
		{
			bool result = java.lang.String.instancehelper_equals(java.lang.String.instancehelper_trim(t.getText()), java.lang.String.instancehelper_trim(new StringBuilder().append("//").append(oldValue.getContent()).ToString()));
			
			return result;
		}

		
		
		
		
		private bool lambda_0024findTokenTextElementForComment_002415(Comment oldValue, TokenTextElement t)
		{
			bool result = isEqualRange(t.getToken().getRange(), oldValue.getRange());
			
			return result;
		}

		
		
		
		public override void concretePropertyChange(Node observedNode, ObservableProperty property, object oldValue, object newValue)
		{
			if (oldValue == newValue || property == ObservableProperty.___003C_003ERANGE || property == ObservableProperty.___003C_003ECOMMENTED_NODE)
			{
				return;
			}
			if (property == ObservableProperty.___003C_003ECOMMENT)
			{
				Optional parentNode = observedNode.getParentNode();
				NodeText nodeText = (NodeText)parentNode.map(new ___003C_003EAnon0(parentNode)).orElse(getOrCreateNodeText(observedNode));
				if (oldValue == null)
				{
					int num = (parentNode.isPresent() ? nodeText.findChild(observedNode) : 0);
					fixIndentOfMovedNode(nodeText, num);
					LineSeparator lineEndingStyleOrDefault = observedNode.getLineEndingStyleOrDefault(LineSeparator.___003C_003ESYSTEM);
					nodeText.addElement(num, makeCommentToken((Comment)newValue));
					nodeText.addToken(num + 1, TokenTypes.eolTokenKind(lineEndingStyleOrDefault), lineEndingStyleOrDefault.asRawString());
				}
				else if (newValue == null)
				{
					if (!(oldValue is Comment))
					{
						
						throw new UnsupportedOperationException();
					}
					if (((Comment)oldValue).isOrphan())
					{
						nodeText = getOrCreateNodeText(observedNode);
					}
					int num = getIndexOfComment((Comment)oldValue, nodeText);
					nodeText.removeElement(num);
					if (((TextElement)nodeText.getElements().get(num)).isNewline())
					{
						nodeText.removeElement(num);
					}
				}
				else
				{
					List list = findTokenTextElementForComment((Comment)oldValue, nodeText);
					if (list.size() != 1)
					{
						
						throw new IllegalStateException("The matching comment to be replaced could not be found");
					}
					Comment newComment = (Comment)newValue;
					TokenTextElement tokenTextElement = (TokenTextElement)list.get(0);
					nodeText.replace(tokenTextElement.and(tokenTextElement.matchByRange()), makeCommentToken(newComment));
				}
			}
			NodeText orCreateNodeText = getOrCreateNodeText(observedNode);
			if (orCreateNodeText == null)
			{
				string simpleName = java.lang.Object.instancehelper_getClass(observedNode).getSimpleName();
				
				throw new NullPointerException(simpleName);
			}
			access_0024100().calculatePropertyChange(orCreateNodeText, observedNode, property, oldValue, newValue);
		}

		
				
		
		public override void concreteListChange(NodeList changedList, AstObserver.ListChangeType type, int index, Node nodeAddedOrRemoved)
		{
			NodeText orCreateNodeText = getOrCreateNodeText(changedList.getParentNodeForChildren());
			List diffElements;
			if (type == AstObserver.ListChangeType.___003C_003EREMOVAL)
			{
				diffElements = access_0024100().calculateListRemovalDifference(access_0024200(changedList), changedList, index);
			}
			else
			{
				if (type != AstObserver.ListChangeType.___003C_003EADDITION)
				{
					
					throw new UnsupportedOperationException();
				}
				diffElements = access_0024100().calculateListAdditionDifference(access_0024200(changedList), changedList, index, nodeAddedOrRemoved);
			}
			Difference difference = new Difference(diffElements, orCreateNodeText, changedList.getParentNodeForChildren());
			difference.apply();
		}

		
				
		
		public override void concreteListReplacement(NodeList changedList, int index, Node oldValue, Node newValue)
		{
			NodeText orCreateNodeText = getOrCreateNodeText(changedList.getParentNodeForChildren());
			List diffElements = access_0024100().calculateListReplacementDifference(access_0024200(changedList), changedList, index, newValue);
			Difference difference = new Difference(diffElements, orCreateNodeText, changedList.getParentNodeForChildren());
			difference.apply();
		}
	}

	
	private sealed class ___003C_003EAnon0 : Consumer
	{
		private readonly Node arg_00241;

		internal ___003C_003EAnon0(Node P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			lambda_0024setup_00240(arg_00241, (TokenRange)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Consumer
	{
		private readonly Node arg_00241;

		private readonly Map arg_00242;

		internal ___003C_003EAnon1(Node P_0, Map P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			lambda_0024storeInitialText_00243(arg_00241, arg_00242, (TokenRange)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon2 : Function
	{
		internal ___003C_003EAnon2()
		{
		}

		public object apply(object P_0)
		{
			Position result = lambda_0024storeInitialTextForOneNode_00244((Pair)P_0);
			
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

	
	private sealed class ___003C_003EAnon3 : Function
	{
		internal ___003C_003EAnon3()
		{
		}

		public object apply(object P_0)
		{
			TextElement result = lambda_0024storeInitialTextForOneNode_00245((Pair)P_0);
			
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

	
	private sealed class ___003C_003EAnon4 : TextElementIteratorsFactory.CascadingIterator.Provider
	{
		private readonly Node arg_00241;

		internal ___003C_003EAnon4(Node P_0)
		{
			arg_00241 = P_0;
		}

		public Iterator provide()
		{
			Iterator result = lambda_0024tokensPreceeding_00246(arg_00241);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon5 : Consumer
	{
		private readonly NodeText arg_00241;

		internal ___003C_003EAnon5(NodeText P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addElement((TokenTextElement)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon6 : Consumer
	{
		private readonly Node arg_00241;

		private readonly NodeText arg_00242;

		internal ___003C_003EAnon6(Node P_0, NodeText P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			lambda_0024interpret_00247(arg_00241, arg_00242, (CsmElement)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon7 : Consumer
	{
		private readonly VariableDeclarator arg_00241;

		private readonly NodeText arg_00242;

		internal ___003C_003EAnon7(VariableDeclarator P_0, NodeText P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			lambda_0024interpret_00249(arg_00241, arg_00242, (Node)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	
	private sealed class ___003C_003EAnon9 : Consumer
	{
		private readonly VariableDeclarator arg_00241;

		private readonly NodeText arg_00242;

		internal ___003C_003EAnon9(VariableDeclarator P_0, NodeText P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			lambda_0024null_00248(arg_00241, arg_00242, (com.github.javaparser.ast.type.Type)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon10 : Supplier
	{
		private readonly JavaToken arg_00241;

		internal ___003C_003EAnon10(JavaToken P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			RuntimeException result = lambda_0024null_00241(arg_00241);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon11 : Supplier
	{
		private readonly JavaToken arg_00241;

		internal ___003C_003EAnon11(JavaToken P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			RuntimeException result = lambda_0024null_00242(arg_00241);
			
			return result;
		}
	}

	private static string JAVA_UTIL_OPTIONAL;

	private static string JAVAPARSER_AST_NODELIST;

	private static AstObserver observer;

		internal static DataKey ___003C_003ENODE_TEXT_DATA;

	
	private static LexicalDifferenceCalculator LEXICAL_DIFFERENCE_CALCULATOR;

	
	private static CallerID ___003CcallerID_003E;

	
	public static DataKey NODE_TEXT_DATA
	{
		
		get
		{
			return ___003C_003ENODE_TEXT_DATA;
		}
	}

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
		
	
	public static Node setup(Node node)
	{
		Utils.assertNotNull(node);
		if (observer == null)
		{
			observer = createObserver();
		}
		node.getTokenRange().ifPresent(new ___003C_003EAnon0(node));
		return node;
	}

	
	
	
	public static string print(Node node)
	{
		StringWriter stringWriter = new StringWriter();
		IOException ex;
		try
		{
			print(node, stringWriter);
		}
		catch (IOException x)
		{
			ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_001c;
		}
		return stringWriter.ToString();
		IL_001c:
		IOException cause = ex;
		
		throw new RuntimeException("Unexpected IOException on a StringWriter", cause);
	}

	
	
	
	internal static NodeText getOrCreateNodeText(Node node)
	{
		if (!node.containsData(___003C_003ENODE_TEXT_DATA))
		{
			NodeText nodeText = new NodeText();
			node.setData(___003C_003ENODE_TEXT_DATA, nodeText);
			prettyPrintingTextNode(node, nodeText);
		}
		return (NodeText)node.getData(___003C_003ENODE_TEXT_DATA);
	}

	
		
	
	internal static List findIndentation(Node node)
	{
		LinkedList linkedList = new LinkedList();
		Iterator iterator = tokensPreceeding(node);
		while (iterator.hasNext())
		{
			TokenTextElement tokenTextElement = (TokenTextElement)iterator.next();
			if (tokenTextElement.getTokenKind() == 5 || tokenTextElement.isNewline())
			{
				break;
			}
			((List)linkedList).add((object)tokenTextElement);
		}
		Collections.reverse(linkedList);
		for (int i = 0; i < ((List)linkedList).size(); i++)
		{
			if (!((TokenTextElement)((List)linkedList).get(i)).isSpaceOrTab())
			{
				List result = ((List)linkedList).subList(0, i);
				
				return result;
			}
		}
		return linkedList;
	}

	
		
	
	private static void storeInitialTextForOneNode(Node node, List nodeTokens)
	{
		if (nodeTokens == null)
		{
			nodeTokens = Collections.emptyList();
		}
		LinkedList linkedList = new LinkedList();
		Iterator iterator = node.getChildNodes().iterator();
		while (iterator.hasNext())
		{
			Node node2 = (Node)iterator.next();
			if (!node2.isPhantom())
			{
				if (!node2.hasRange())
				{
					string message = new StringBuilder().append("Range not present on node ").append(node2).ToString();
					
					throw new RuntimeException(message);
				}
				((List)linkedList).add((object)new Pair(node2.getRange().get(), new ChildTextElement(node2)));
			}
		}
		iterator = nodeTokens.iterator();
		while (iterator.hasNext())
		{
			JavaToken javaToken = (JavaToken)iterator.next();
			((List)linkedList).add((object)new Pair(javaToken.getRange().get(), new TokenTextElement(javaToken)));
		}
		((List)linkedList).sort(Comparator.comparing(new ___003C_003EAnon2()));
		node.setData(___003C_003ENODE_TEXT_DATA, new NodeText((List)((Collection)linkedList).stream().map(new ___003C_003EAnon3()).collect(Collectors.toList())));
	}

	
		
	
	private static ObservableProperty findNodeListName(NodeList nodeList)
	{
		//Discarded unreachable code: IL_00e6, IL_01a2
		Node parentNodeForChildren = nodeList.getParentNodeForChildren();
		Method[] methods = java.lang.Object.instancehelper_getClass(parentNodeForChildren).getMethods(LexicalPreservingPrinter.___003CGetCallerID_003E());
		int num = methods.Length;
		for (int i = 0; i < num; i++)
		{
			Method method = methods[i];
			IllegalAccessException ex;
			InvocationTargetException ex2;
			IllegalAccessException ex3;
			InvocationTargetException ex4;
			if (method.getParameterCount() == 0 && java.lang.String.instancehelper_equals(method.getReturnType().getCanonicalName(), JAVAPARSER_AST_NODELIST))
			{
				try
				{
					try
					{
						object obj = method.invoke(parentNodeForChildren, new object[0], LexicalPreservingPrinter.___003CGetCallerID_003E());
						if (!(obj is NodeList))
						{
							string s = new StringBuilder().append("Expected NodeList, found ").append(java.lang.Object.instancehelper_getClass(obj).getCanonicalName()).ToString();
							
							throw new IllegalStateException(s);
						}
						NodeList nodeList2 = (NodeList)obj;
						if (nodeList2 == nodeList)
						{
							string text = method.getName();
							if (java.lang.String.instancehelper_startsWith(text, "get"))
							{
								text = java.lang.String.instancehelper_substring(text, java.lang.String.instancehelper_length("get"));
							}
							return ObservableProperty.fromCamelCaseName(Utils.decapitalize(text));
						}
					}
					catch (IllegalAccessException x)
					{
						ex = ByteCodeHelper.MapException<IllegalAccessException>(x, ByteCodeHelper.MapFlags.NoRemapping);
						goto IL_0106;
					}
				}
				catch (InvocationTargetException x2)
				{
					ex2 = ByteCodeHelper.MapException<InvocationTargetException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
					goto IL_010a;
				}
			}
			else
			{
				if (method.getParameterCount() != 0 || !isReturningOptionalNodeList(method))
				{
					continue;
				}
				try
				{
					try
					{
						Optional optional = (Optional)method.invoke(parentNodeForChildren, new object[0], LexicalPreservingPrinter.___003CGetCallerID_003E());
						if (optional.isPresent() && optional.get() == nodeList)
						{
							string text2 = method.getName();
							if (java.lang.String.instancehelper_startsWith(text2, "get"))
							{
								text2 = java.lang.String.instancehelper_substring(text2, java.lang.String.instancehelper_length("get"));
							}
							return ObservableProperty.fromCamelCaseName(Utils.decapitalize(text2));
						}
					}
					catch (IllegalAccessException x3)
					{
						ex3 = ByteCodeHelper.MapException<IllegalAccessException>(x3, ByteCodeHelper.MapFlags.NoRemapping);
						goto IL_01c2;
					}
				}
				catch (InvocationTargetException x4)
				{
					ex4 = ByteCodeHelper.MapException<InvocationTargetException>(x4, ByteCodeHelper.MapFlags.NoRemapping);
					goto IL_01c6;
				}
			}
			continue;
			IL_01cd:
			object ex5;
			ReflectiveOperationException ex6 = (ReflectiveOperationException)ex5;
			ReflectiveOperationException cause = ex6;
			
			throw new RuntimeException(cause);
			IL_01c6:
			ex5 = ex4;
			goto IL_01cd;
			IL_01c2:
			ex5 = ex3;
			goto IL_01cd;
			IL_010a:
			object ex7 = ex2;
			goto IL_0114;
			IL_0106:
			ex7 = ex;
			goto IL_0114;
			IL_0114:
			ex6 = (ReflectiveOperationException)ex7;
			ReflectiveOperationException cause2 = ex6;
			
			throw new RuntimeException(cause2);
		}
		string s2 = new StringBuilder().append("Cannot find list name of NodeList of size ").append(nodeList.size()).ToString();
		
		throw new IllegalArgumentException(s2);
	}

	
	
	private static AstObserver createObserver()
	{
		Observer result = new Observer(null);
		
		return result;
	}

	
		
	
	private static Optional findNodeForToken(Node node, Range tokenRange)
	{
		if (node.isPhantom())
		{
			Optional result = Optional.empty();
			
			return result;
		}
		if (!node.hasRange())
		{
			Optional result2 = Optional.empty();
			
			return result2;
		}
		if (!((Range)node.getRange().get()).contains(tokenRange))
		{
			Optional result3 = Optional.empty();
			
			return result3;
		}
		Iterator iterator = node.getChildNodes().iterator();
		while (iterator.hasNext())
		{
			Node node2 = (Node)iterator.next();
			Optional optional = findNodeForToken(node2, tokenRange);
			if (optional.isPresent())
			{
				return optional;
			}
		}
		Optional result4 = Optional.of(node);
		
		return result4;
	}

	
		
	
	private static Iterator tokensPreceeding(Node node)
	{
		if (!node.getParentNode().isPresent())
		{
			TextElementIteratorsFactory.EmptyIterator result = new TextElementIteratorsFactory.EmptyIterator();
			
			return result;
		}
		NodeText orCreateNodeText = getOrCreateNodeText((Node)node.getParentNode().get());
		int num = orCreateNodeText.tryToFindChild(node);
		if (num == -1)
		{
			if (node.getParentNode().get() is VariableDeclarator)
			{
				Iterator result2 = tokensPreceeding((Node)node.getParentNode().get());
				
				return result2;
			}
			string s = java.lang.String.format("I could not find child '%s' in parent '%s'. parentNodeText: %s", node, node.getParentNode().get(), orCreateNodeText);
			
			throw new IllegalArgumentException(s);
		}
		TextElementIteratorsFactory.CascadingIterator result3 = new TextElementIteratorsFactory.CascadingIterator(TextElementIteratorsFactory.partialReverseIterator(orCreateNodeText, num - 1), new ___003C_003EAnon4(node));
		
		return result3;
	}

	
	
	
	
	public static void print(Node node, Writer writer)
	{
		if (!node.containsData(___003C_003ENODE_TEXT_DATA))
		{
			getOrCreateNodeText(node);
		}
		NodeText nodeText = (NodeText)node.getData(___003C_003ENODE_TEXT_DATA);
		CharSequence csq = default(CharSequence);
		object obj = (csq.___003Cref_003E = nodeText.expand());
		writer.append(csq);
	}

	
	
	
	private unsafe static NodeText interpret(Node node, CsmElement csm, NodeText nodeText)
	{
		LexicalDifferenceCalculator.CalculatedSyntaxModel calculatedSyntaxModel = new LexicalDifferenceCalculator().calculatedSyntaxModelForNode(csm, node);
		List list = findIndentation(node);
		int num = 0;
		Iterator iterator = calculatedSyntaxModel.elements.iterator();
		while (iterator.hasNext())
		{
			CsmElement csmElement = (CsmElement)iterator.next();
			if (csmElement is CsmIndent)
			{
				int num2 = calculatedSyntaxModel.elements.indexOf(csmElement);
				if (calculatedSyntaxModel.elements.size() > num2 && !(calculatedSyntaxModel.elements.get(num2 + 1) is CsmUnindent))
				{
					for (int i = 0; i < 4; i++)
					{
						list.add(new TokenTextElement(1, " "));
					}
				}
			}
			else if (csmElement is CsmUnindent)
			{
				for (int num2 = 0; num2 < 4; num2++)
				{
					if (list.size() <= 0)
					{
						break;
					}
					list.remove(list.size() - 1);
				}
			}
			if (num != 0 && (!(csmElement is CsmToken) || !((CsmToken)csmElement).isNewLine()))
			{
				
				list.forEach(new ___003C_003EAnon5(nodeText));
			}
			num = 0;
			if (csmElement is LexicalDifferenceCalculator.CsmChild)
			{
				nodeText.addChild(((LexicalDifferenceCalculator.CsmChild)csmElement).getChild());
			}
			else if (csmElement is CsmToken)
			{
				CsmToken csmToken = (CsmToken)csmElement;
				nodeText.addToken(csmToken.getTokenType(), csmToken.getContent(node));
				if (csmToken.isNewLine())
				{
					num = 1;
				}
			}
			else if (csmElement is CsmMix)
			{
				CsmMix csmMix = (CsmMix)csmElement;
				csmMix.getElements().forEach(new ___003C_003EAnon6(node, nodeText));
			}
			else if (!(csmElement is CsmIndent) && !(csmElement is CsmUnindent))
			{
				string simpleName = java.lang.Object.instancehelper_getClass(csmElement).getSimpleName();
				
				throw new UnsupportedOperationException(simpleName);
			}
		}
		if (node is VariableDeclarator)
		{
			VariableDeclarator variableDeclarator = (VariableDeclarator)node;
			variableDeclarator.getParentNode().ifPresent(new ___003C_003EAnon7(variableDeclarator, nodeText));
		}
		return nodeText;
	}

	
	
	
	private static void prettyPrintingTextNode(Node node, NodeText nodeText)
	{
		if (node is PrimitiveType)
		{
			PrimitiveType primitiveType = (PrimitiveType)node;
			switch (_3._0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024type_0024PrimitiveType_0024Primitive[primitiveType.getType().ordinal()])
			{
			case 1:
				nodeText.addToken(13, node.ToString());
				break;
			case 2:
				nodeText.addToken(18, node.ToString());
				break;
			case 3:
				nodeText.addToken(15, node.ToString());
				break;
			case 4:
				nodeText.addToken(50, node.ToString());
				break;
			case 5:
				nodeText.addToken(38, node.ToString());
				break;
			case 6:
				nodeText.addToken(40, node.ToString());
				break;
			case 7:
				nodeText.addToken(31, node.ToString());
				break;
			case 8:
				nodeText.addToken(24, node.ToString());
				break;
			default:
				
				throw new IllegalArgumentException();
			}
		}
		else if (node is JavadocComment)
		{
			nodeText.addToken(8, new StringBuilder().append("/**").append(((JavadocComment)node).getContent()).append("*/")
				.ToString());
		}
		else if (node is BlockComment)
		{
			nodeText.addToken(9, new StringBuilder().append("/*").append(((BlockComment)node).getContent()).append("*/")
				.ToString());
		}
		else if (node is LineComment)
		{
			nodeText.addToken(5, new StringBuilder().append("//").append(((LineComment)node).getContent()).ToString());
		}
		else if (node is com.github.javaparser.ast.Modifier)
		{
			com.github.javaparser.ast.Modifier modifier = (com.github.javaparser.ast.Modifier)node;
			nodeText.addToken(LexicalDifferenceCalculator.toToken(modifier), modifier.getKeyword().asString());
		}
		else
		{
			interpret(node, ConcreteSyntaxModel.forClass(java.lang.Object.instancehelper_getClass(node)), nodeText);
		}
	}

	
	
	
	private static bool isReturningOptionalNodeList(Method m)
	{
		if (!java.lang.String.instancehelper_equals(m.getReturnType().getCanonicalName(), JAVA_UTIL_OPTIONAL))
		{
			return false;
		}
		if (!(m.getGenericReturnType() is ParameterizedType))
		{
			return false;
		}
		ParameterizedType parameterizedType = (ParameterizedType)m.getGenericReturnType();
		java.lang.reflect.Type type = parameterizedType.getActualTypeArguments()[0];
		bool result = java.lang.String.instancehelper_startsWith(type.getTypeName(), JAVAPARSER_AST_NODELIST);
		
		return result;
	}

	
	
	
	private static void storeInitialText(Node root)
	{
		IdentityHashMap identityHashMap = new IdentityHashMap();
		root.getTokenRange().ifPresent(new ___003C_003EAnon1(root, identityHashMap));
	}

	
	
	
	
	private static void lambda_0024setup_00240(Node node, TokenRange r)
	{
		storeInitialText(node);
		if (!node.isRegistered(observer))
		{
			node.registerForSubtree(observer);
		}
	}

	
	
	
	
	private static void lambda_0024storeInitialText_00243(Node root, Map tokensByNode, TokenRange rootTokenRange)
	{
		Iterator iterator = rootTokenRange.iterator();
		while (iterator.hasNext())
		{
			JavaToken javaToken = (JavaToken)iterator.next();
			Range tokenRange = (Range)javaToken.getRange().orElseThrow(new ___003C_003EAnon10(javaToken));
			Node key = (Node)findNodeForToken(root, tokenRange).orElseThrow(new ___003C_003EAnon11(javaToken));
			if (!tokensByNode.containsKey(key))
			{
				tokensByNode.put(key, new LinkedList());
			}
			((List)tokensByNode.get(key)).add(javaToken);
		}
		new _2(tokensByNode).visitBreadthFirst(root);
	}

	
	
	
	private static Position lambda_0024storeInitialTextForOneNode_00244(Pair e)
	{
		return ((Range)e.___003C_003Ea).___003C_003Ebegin;
	}

	
	
	
	private static TextElement lambda_0024storeInitialTextForOneNode_00245(Pair p)
	{
		return (TextElement)p.___003C_003Eb;
	}

	
	
	
	
	private static Iterator lambda_0024tokensPreceeding_00246(Node node)
	{
		Iterator result = tokensPreceeding((Node)node.getParentNode().get());
		
		return result;
	}

	
	
	
	
	private static void lambda_0024interpret_00247(Node node, NodeText nodeText, CsmElement e)
	{
		interpret(node, e, nodeText);
	}

	
	
	
	
	private static void lambda_0024interpret_00249(VariableDeclarator variableDeclarator, NodeText nodeText, Node parent)
	{
		((NodeWithVariables)parent).getMaximumCommonType().ifPresent(new ___003C_003EAnon9(variableDeclarator, nodeText));
	}

	
	
	
	
	private static void lambda_0024null_00248(VariableDeclarator variableDeclarator, NodeText nodeText, com.github.javaparser.ast.type.Type mct)
	{
		int num = variableDeclarator.getType().getArrayLevel() - mct.getArrayLevel();
		for (int i = 0; i < num; i++)
		{
			nodeText.addElement(new TokenTextElement(101));
			nodeText.addElement(new TokenTextElement(102));
		}
	}

	
	
	
	
	private static RuntimeException lambda_0024null_00241(JavaToken token)
	{
		RuntimeException result = new RuntimeException(new StringBuilder().append("Token without range: ").append(token).ToString());
		
		return result;
	}

	
	
	
	
	private static RuntimeException lambda_0024null_00242(JavaToken token)
	{
		RuntimeException result = new RuntimeException(new StringBuilder().append("Token without node owning it: ").append(token).ToString());
		
		return result;
	}

	
	
	public LexicalPreservingPrinter()
	{
	}

	
	internal static LexicalDifferenceCalculator access_0024100()
	{
		return LEXICAL_DIFFERENCE_CALCULATOR;
	}

	
	
	
	internal static ObservableProperty access_0024200(NodeList P_0)
	{
		ObservableProperty result = findNodeListName(P_0);
		
		return result;
	}

	
	
	
	internal static void access_0024300(Node P_0, List P_1)
	{
		storeInitialTextForOneNode(P_0, P_1);
	}

	
	static LexicalPreservingPrinter()
	{
		JAVA_UTIL_OPTIONAL = ClassLiteral<Optional>.Value.getCanonicalName();
		JAVAPARSER_AST_NODELIST = ClassLiteral<NodeList>.Value.getCanonicalName();
		___003C_003ENODE_TEXT_DATA = new _1();
		LEXICAL_DIFFERENCE_CALCULATOR = new LexicalDifferenceCalculator();
	}

	static CallerID ___003CGetCallerID_003E()
	{
		if (___003CcallerID_003E == null)
		{
			___003CcallerID_003E = new ___003CCallerID_003E();
		}
		return ___003CcallerID_003E;
	}
}
