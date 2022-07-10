using System;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.printer.concretesyntaxmodel;
using com.github.javaparser.printer.lexicalpreservation.changes;
using com.github.javaparser.utils;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.printer.lexicalpreservation;

internal class LexicalDifferenceCalculator
{
	
	
	
	
	internal class _1
	{
		
		internal static int[] _0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024Modifier_0024Keyword;

		
		
		public static void ___003Cclinit_003E()
		{
		}

		
		static _1()
		{
			_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024Modifier_0024Keyword = new int[(nint)Modifier.Keyword.values().LongLength];
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024Modifier_0024Keyword[Modifier.Keyword.___003C_003EPUBLIC.ordinal()] = 1;
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
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024Modifier_0024Keyword[Modifier.Keyword.___003C_003EPRIVATE.ordinal()] = 2;
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
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024Modifier_0024Keyword[Modifier.Keyword.___003C_003EPROTECTED.ordinal()] = 3;
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
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024Modifier_0024Keyword[Modifier.Keyword.___003C_003ESTATIC.ordinal()] = 4;
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
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024Modifier_0024Keyword[Modifier.Keyword.___003C_003EFINAL.ordinal()] = 5;
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
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024Modifier_0024Keyword[Modifier.Keyword.___003C_003EABSTRACT.ordinal()] = 6;
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
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024Modifier_0024Keyword[Modifier.Keyword.___003C_003ETRANSIENT.ordinal()] = 7;
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
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024Modifier_0024Keyword[Modifier.Keyword.___003C_003ESYNCHRONIZED.ordinal()] = 8;
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
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024Modifier_0024Keyword[Modifier.Keyword.___003C_003EVOLATILE.ordinal()] = 9;
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
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024Modifier_0024Keyword[Modifier.Keyword.___003C_003ENATIVE.ordinal()] = 10;
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
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024Modifier_0024Keyword[Modifier.Keyword.___003C_003ESTRICTFP.ordinal()] = 11;
			}
			catch (System.Exception x11)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x11, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_01d0;
			}
			goto IL_01d6;
			IL_01d0:
			
			goto IL_01d6;
			IL_01d6:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024Modifier_0024Keyword[Modifier.Keyword.___003C_003ETRANSITIVE.ordinal()] = 12;
				return;
			}
			catch (System.Exception x12)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x12, ByteCodeHelper.MapFlags.Unused) == null)
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

	internal class CalculatedSyntaxModel
	{
		
		private sealed class ___003C_003EAnon0 : Predicate
		{
			internal ___003C_003EAnon0()
			{
			}

			public bool test(object P_0)
			{
				bool result = lambda_0024removeIndentationElements_00240((CsmElement)P_0);
				
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

		
				internal List elements;

		
		[MethodParameters(new Modifiers[]
		{
			(Modifiers)0,
			(Modifiers)0
		})]
		
		internal virtual CalculatedSyntaxModel sub(int start, int end)
		{
			CalculatedSyntaxModel result = new CalculatedSyntaxModel(elements.subList(start, end));
			
			return result;
		}

		
		
		
		public virtual CalculatedSyntaxModel from(int index)
		{
			
			CalculatedSyntaxModel result = new CalculatedSyntaxModel(new ArrayList(elements.subList(index, elements.size())));
			
			return result;
		}

		
				
		
		internal CalculatedSyntaxModel(List elements)
		{
			this.elements = elements;
		}

		
		
		
		private static bool lambda_0024removeIndentationElements_00240(CsmElement el)
		{
			return (el is CsmIndent || el is CsmUnindent) ? true : false;
		}

		
		
		public override string ToString()
		{
			string result = new StringBuilder().append("CalculatedSyntaxModel{elements=").append(elements).append('}')
				.ToString();
			
			return result;
		}

		
		
		internal virtual void removeIndentationElements()
		{
			elements.removeIf(new ___003C_003EAnon0());
		}
	}

	internal class CsmChild :  CsmElement
	{
		
		private Node child;

		public virtual Node getChild()
		{
			return child;
		}

		
		
		
		internal CsmChild(Node child)
		{
			this.child = child;
		}

		
		[MethodParameters(new Modifiers[]
		{
			(Modifiers)0,
			(Modifiers)0
		})]
		
		public virtual void prettyPrint(Node node, SourcePrinter printer)
		{
			
			throw new UnsupportedOperationException();
		}

		
		
		public override string ToString()
		{
			string result = new StringBuilder().append("child(").append(java.lang.Object.instancehelper_getClass(child).getSimpleName()).append(")")
				.ToString();
			
			return result;
		}

		
		
		
		public override bool Equals(object o)
		{
			if (this == o)
			{
				return true;
			}
			if (o == null || ((object)this).GetType() != o.GetType())
			{
				return false;
			}
			CsmChild csmChild = (CsmChild)o;
			bool result = child.equals(csmChild.child);
			
			return result;
		}

		
		
		public override int GetHashCode()
		{
			int result = child.GetHashCode();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon0 : Consumer
	{
		private readonly LexicalDifferenceCalculator arg_00241;

		private readonly Node arg_00242;

		private readonly List arg_00243;

		private readonly Change arg_00244;

		internal ___003C_003EAnon0(LexicalDifferenceCalculator P_0, Node P_1, List P_2, Change P_3)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
			arg_00244 = P_3;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024calculatedSyntaxModelForNode_00240(arg_00242, arg_00243, arg_00244, (CsmElement)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Consumer
	{
		private readonly LexicalDifferenceCalculator arg_00241;

		private readonly Node arg_00242;

		private readonly List arg_00243;

		private readonly Change arg_00244;

		internal ___003C_003EAnon1(LexicalDifferenceCalculator P_0, Node P_1, List P_2, Change P_3)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
			arg_00244 = P_3;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024calculatedSyntaxModelForNode_00241(arg_00242, arg_00243, arg_00244, (CsmElement)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	internal virtual CalculatedSyntaxModel calculatedSyntaxModelForNode(CsmElement csm, Node node)
	{
		LinkedList elements = new LinkedList();
		calculatedSyntaxModelForNode(csm, node, elements, new NoChange());
		CalculatedSyntaxModel result = new CalculatedSyntaxModel(elements);
		
		return result;
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	internal virtual CalculatedSyntaxModel calculatedSyntaxModelAfterListRemoval(CsmElement csm, ObservableProperty observableProperty, NodeList nodeList, int index)
	{
		LinkedList elements = new LinkedList();
		Node parentNodeForChildren = nodeList.getParentNodeForChildren();
		calculatedSyntaxModelForNode(csm, parentNodeForChildren, elements, new ListRemovalChange(observableProperty, index));
		CalculatedSyntaxModel result = new CalculatedSyntaxModel(elements);
		
		return result;
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	internal virtual CalculatedSyntaxModel calculatedSyntaxModelAfterListAddition(CsmElement csm, ObservableProperty observableProperty, NodeList nodeList, int index, Node nodeAdded)
	{
		LinkedList elements = new LinkedList();
		Node parentNodeForChildren = nodeList.getParentNodeForChildren();
		calculatedSyntaxModelForNode(csm, parentNodeForChildren, elements, new ListAdditionChange(observableProperty, index, nodeAdded));
		CalculatedSyntaxModel result = new CalculatedSyntaxModel(elements);
		
		return result;
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	private void replaceEolTokens(List differenceElements, LineSeparator lineSeparator)
	{
		CsmElement newLineToken = getNewLineToken(lineSeparator);
		for (int i = 0; i < differenceElements.size(); i++)
		{
			DifferenceElement differenceElement = (DifferenceElement)differenceElements.get(i);
			differenceElements.set(i, differenceElement.replaceEolTokens(newLineToken));
		}
	}

	
	
	
	private CsmElement getNewLineToken(LineSeparator lineSeparator)
	{
		CsmElement result = CsmElement.newline(lineSeparator);
		
		return result;
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	private CalculatedSyntaxModel calculatedSyntaxModelAfterListReplacement(CsmElement csm, ObservableProperty observableProperty, NodeList nodeList, int index, Node newValue)
	{
		LinkedList elements = new LinkedList();
		Node parentNodeForChildren = nodeList.getParentNodeForChildren();
		calculatedSyntaxModelForNode(csm, parentNodeForChildren, elements, new ListReplacementChange(observableProperty, index, newValue));
		CalculatedSyntaxModel result = new CalculatedSyntaxModel(elements);
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	internal virtual CalculatedSyntaxModel calculatedSyntaxModelAfterPropertyChange(CsmElement csm, Node node, ObservableProperty property, object oldValue, object newValue)
	{
		LinkedList elements = new LinkedList();
		calculatedSyntaxModelForNode(csm, node, elements, new PropertyChange(property, oldValue, newValue));
		CalculatedSyntaxModel result = new CalculatedSyntaxModel(elements);
		
		return result;
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		160, 83, 104, 103, 122, 146, 107, 135, 125, 148,
		141, 227, 74, 117, 108, 124, 152, 141, 146, 104,
		109, 141, 107, 104, 113, 145, 108, 105, 105, 110,
		159, 22, 144, 135, 98, 105, 159, 17, 137, 108,
		113, 110, 100, 145, 117, 109, 241, 58, 232, 74,
		145, 101, 118, 108, 145, 99, 117, 100, 145, 105,
		105, 105, 115, 98, 156, 105, 145, 99, 101, 177,
		109, 104, 108, 100, 147, 145, 109, 109, 104, 109,
		104, 104, 113, 105, 105, 142, 127, 0, 251, 69,
		105, 121, 62, 171, 120, 62, 171, 150, 105, 121,
		62, 171, 120, 62, 171, 118, 105, 121, 62, 171,
		120, 62, 171, 104, 104, 103, 124, 110, 106, 138,
		159, 22
	})]
	private void calculatedSyntaxModelForNode(CsmElement csm, Node node, List elements, Change change)
	{
		if (csm is CsmSequence)
		{
			CsmSequence csmSequence = (CsmSequence)csm;
			csmSequence.getElements().forEach(new ___003C_003EAnon0(this, node, elements, change));
		}
		else
		{
			if (csm is CsmComment)
			{
				return;
			}
			if (csm is CsmSingleReference)
			{
				CsmSingleReference csmSingleReference = (CsmSingleReference)csm;
				Node node2 = ((!(change is PropertyChange) || ((PropertyChange)change).getProperty() != csmSingleReference.getProperty()) ? csmSingleReference.getProperty().getValueAsSingleReference(node) : ((Node)((PropertyChange)change).getNewValue()));
				if (node2 != null)
				{
					if (node.getComment().isPresent() && node is ExpressionStmt)
					{
						LineSeparator lineEndingStyleOrDefault = node.getLineEndingStyleOrDefault(LineSeparator.___003C_003ESYSTEM);
						elements.add(new CsmChild((Node)node.getComment().get()));
						elements.add(new CsmToken(TokenTypes.eolTokenKind(lineEndingStyleOrDefault), lineEndingStyleOrDefault.asRawString()));
					}
					elements.add(new CsmChild(node2));
				}
			}
			else
			{
				if (csm is CsmNone)
				{
					return;
				}
				if (csm is CsmToken)
				{
					elements.add(csm);
				}
				else
				{
					if (csm is CsmOrphanCommentsEnding)
					{
						return;
					}
					if (csm is CsmList)
					{
						CsmList csmList = (CsmList)csm;
						if (csmList.getProperty().isAboutNodes())
						{
							object value = change.getValue(csmList.getProperty(), node);
							NodeList nodeList;
							if (value is Optional)
							{
								Optional optional = (Optional)value;
								if (optional.isPresent())
								{
									if (!(optional.get() is NodeList))
									{
										string s = new StringBuilder().append("Expected NodeList, found ").append(java.lang.Object.instancehelper_getClass(optional.get()).getCanonicalName()).ToString();
										
										throw new IllegalStateException(s);
									}
									nodeList = (NodeList)optional.get();
								}
								else
								{
									nodeList = new NodeList();
								}
							}
							else
							{
								if (!(value is NodeList))
								{
									string s2 = new StringBuilder().append("Expected NodeList, found ").append(java.lang.Object.instancehelper_getClass(value).getCanonicalName()).ToString();
									
									throw new IllegalStateException(s2);
								}
								nodeList = (NodeList)value;
							}
							if (nodeList.isEmpty())
							{
								return;
							}
							calculatedSyntaxModelForNode(csmList.getPreceeding(), node, elements, change);
							for (int i = 0; i < nodeList.size(); i++)
							{
								if (i != 0)
								{
									calculatedSyntaxModelForNode(csmList.getSeparatorPre(), node, elements, change);
								}
								elements.add(new CsmChild(nodeList.get(i)));
								if (i != nodeList.size() - 1)
								{
									calculatedSyntaxModelForNode(csmList.getSeparatorPost(), node, elements, change);
								}
							}
							calculatedSyntaxModelForNode(csmList.getFollowing(), node, elements, change);
							return;
						}
						Collection collection = (Collection)change.getValue(csmList.getProperty(), node);
						if (collection.isEmpty())
						{
							return;
						}
						calculatedSyntaxModelForNode(csmList.getPreceeding(), node, elements, change);
						int num = 1;
						Iterator iterator = collection.iterator();
						while (iterator.hasNext())
						{
							if (num == 0)
							{
								calculatedSyntaxModelForNode(csmList.getSeparatorPre(), node, elements, change);
							}
							object obj = iterator.next();
							if (obj is Modifier)
							{
								Modifier modifier = (Modifier)obj;
								elements.add(new CsmToken(toToken(modifier)));
								if (iterator.hasNext())
								{
									calculatedSyntaxModelForNode(csmList.getSeparatorPost(), node, elements, change);
								}
								num = 0;
								continue;
							}
							string simpleName = java.lang.Object.instancehelper_getClass(iterator.next()).getSimpleName();
							
							throw new UnsupportedOperationException(simpleName);
						}
						calculatedSyntaxModelForNode(csmList.getFollowing(), node, elements, change);
					}
					else if (csm is CsmConditional)
					{
						CsmConditional csmConditional = (CsmConditional)csm;
						if (change.evaluate(csmConditional, node))
						{
							calculatedSyntaxModelForNode(csmConditional.getThenElement(), node, elements, change);
						}
						else
						{
							calculatedSyntaxModelForNode(csmConditional.getElseElement(), node, elements, change);
						}
					}
					else if (csm is CsmIndent)
					{
						elements.add(csm);
					}
					else if (csm is CsmUnindent)
					{
						elements.add(csm);
					}
					else if (csm is CsmAttribute)
					{
						CsmAttribute csmAttribute = (CsmAttribute)csm;
						object value = change.getValue(csmAttribute.getProperty(), node);
						string text = java.lang.Object.instancehelper_toString(value);
						if (value is Stringable)
						{
							text = ((Stringable)value).asString();
						}
						elements.add(new CsmToken(csmAttribute.getTokenType(node, java.lang.Object.instancehelper_toString(value), text), text));
					}
					else if (csm is CsmString && node is StringLiteralExpr)
					{
						if (change is PropertyChange)
						{
							elements.add(new CsmToken(90, new StringBuilder().append("\"").append(((PropertyChange)change).getNewValue()).append("\"")
								.ToString()));
						}
						else
						{
							elements.add(new CsmToken(90, new StringBuilder().append("\"").append(((StringLiteralExpr)node).getValue()).append("\"")
								.ToString()));
						}
					}
					else if (csm is CsmString && node is TextBlockLiteralExpr)
					{
						if (change is PropertyChange)
						{
							elements.add(new CsmToken(92, new StringBuilder().append("\"\"\"").append(((PropertyChange)change).getNewValue()).append("\"\"\"")
								.ToString()));
						}
						else
						{
							elements.add(new CsmToken(92, new StringBuilder().append("\"\"\"").append(((TextBlockLiteralExpr)node).getValue()).append("\"\"\"")
								.ToString()));
						}
					}
					else if (csm is CsmChar && node is CharLiteralExpr)
					{
						if (change is PropertyChange)
						{
							elements.add(new CsmToken(18, new StringBuilder().append("'").append(((PropertyChange)change).getNewValue()).append("'")
								.ToString()));
						}
						else
						{
							elements.add(new CsmToken(18, new StringBuilder().append("'").append(((CharLiteralExpr)node).getValue()).append("'")
								.ToString()));
						}
					}
					else if (csm is CsmMix)
					{
						CsmMix csmMix = (CsmMix)csm;
						LinkedList linkedList = new LinkedList();
						csmMix.getElements().forEach(new ___003C_003EAnon1(this, node, linkedList, change));
						elements.add(new CsmMix(linkedList));
					}
					else
					{
						if (!(csm is CsmChild))
						{
							string message = new StringBuilder().append(java.lang.Object.instancehelper_getClass(csm).getSimpleName()).append(" ").append(csm)
								.ToString();
							
							throw new UnsupportedOperationException(message);
						}
						elements.add(csm);
					}
				}
			}
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		160, 241, 159, 43, 131, 131, 131, 131, 131, 131,
		131, 131, 131, 131, 131, 131
	})]
	public static int toToken(Modifier modifier)
	{
		switch (_1._0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024Modifier_0024Keyword[modifier.getKeyword().ordinal()])
		{
		case 1:
			return 47;
		case 2:
			return 45;
		case 3:
			return 46;
		case 4:
			return 51;
		case 5:
			return 29;
		case 6:
			return 11;
		case 7:
			return 59;
		case 8:
			return 55;
		case 9:
			return 63;
		case 10:
			return 41;
		case 11:
			return 52;
		case 12:
			return 75;
		default:
		{
			string message = modifier.getKeyword().name();
			
			throw new UnsupportedOperationException(message);
		}
		}
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private void lambda_0024calculatedSyntaxModelForNode_00240(Node node, List elements, Change change, CsmElement e)
	{
		calculatedSyntaxModelForNode(e, node, elements, change);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private void lambda_0024calculatedSyntaxModelForNode_00241(Node node, List mixElements, Change change, CsmElement e)
	{
		calculatedSyntaxModelForNode(e, node, mixElements, change);
	}

	
	
	internal LexicalDifferenceCalculator()
	{
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	internal virtual List calculateListRemovalDifference(ObservableProperty observableProperty, NodeList nodeList, int index)
	{
		Node parentNodeForChildren = nodeList.getParentNodeForChildren();
		CsmElement csm = ConcreteSyntaxModel.forClass(java.lang.Object.instancehelper_getClass(parentNodeForChildren));
		CalculatedSyntaxModel original = calculatedSyntaxModelForNode(csm, parentNodeForChildren);
		CalculatedSyntaxModel after = calculatedSyntaxModelAfterListRemoval(csm, observableProperty, nodeList, index);
		List result = DifferenceElementCalculator.calculate(original, after);
		
		return result;
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	internal virtual List calculateListAdditionDifference(ObservableProperty observableProperty, NodeList nodeList, int index, Node nodeAdded)
	{
		Node parentNodeForChildren = nodeList.getParentNodeForChildren();
		CsmElement csm = ConcreteSyntaxModel.forClass(java.lang.Object.instancehelper_getClass(parentNodeForChildren));
		CalculatedSyntaxModel original = calculatedSyntaxModelForNode(csm, parentNodeForChildren);
		CalculatedSyntaxModel after = calculatedSyntaxModelAfterListAddition(csm, observableProperty, nodeList, index, nodeAdded);
		List list = DifferenceElementCalculator.calculate(original, after);
		LineSeparator lineEndingStyleOrDefault = parentNodeForChildren.getLineEndingStyleOrDefault(LineSeparator.___003C_003ESYSTEM);
		replaceEolTokens(list, lineEndingStyleOrDefault);
		return list;
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	internal virtual List calculateListReplacementDifference(ObservableProperty observableProperty, NodeList nodeList, int index, Node newValue)
	{
		Node parentNodeForChildren = nodeList.getParentNodeForChildren();
		CsmElement csm = ConcreteSyntaxModel.forClass(java.lang.Object.instancehelper_getClass(parentNodeForChildren));
		CalculatedSyntaxModel original = calculatedSyntaxModelForNode(csm, parentNodeForChildren);
		CalculatedSyntaxModel after = calculatedSyntaxModelAfterListReplacement(csm, observableProperty, nodeList, index, newValue);
		List result = DifferenceElementCalculator.calculate(original, after);
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	internal virtual void calculatePropertyChange(NodeText nodeText, Node observedNode, ObservableProperty property, object oldValue, object newValue)
	{
		if (nodeText == null)
		{
			
			throw new NullPointerException();
		}
		CsmElement csm = ConcreteSyntaxModel.forClass(java.lang.Object.instancehelper_getClass(observedNode));
		CalculatedSyntaxModel original = calculatedSyntaxModelForNode(csm, observedNode);
		CalculatedSyntaxModel after = calculatedSyntaxModelAfterPropertyChange(csm, observedNode, property, oldValue, newValue);
		List diffElements = DifferenceElementCalculator.calculate(original, after);
		Difference difference = new Difference(diffElements, nodeText, observedNode);
		difference.apply();
	}

	
	
	
	internal virtual CalculatedSyntaxModel calculatedSyntaxModelForNode(Node node)
	{
		CalculatedSyntaxModel result = calculatedSyntaxModelForNode(ConcreteSyntaxModel.forClass(java.lang.Object.instancehelper_getClass(node)), node);
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	internal virtual CalculatedSyntaxModel calculatedSyntaxModelAfterPropertyChange(Node node, ObservableProperty property, object oldValue, object newValue)
	{
		CalculatedSyntaxModel result = calculatedSyntaxModelAfterPropertyChange(ConcreteSyntaxModel.forClass(java.lang.Object.instancehelper_getClass(node)), node, property, oldValue, newValue);
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	internal virtual CalculatedSyntaxModel calculatedSyntaxModelAfterListAddition(Node container, ObservableProperty observableProperty, int index, Node nodeAdded)
	{
		CsmElement csm = ConcreteSyntaxModel.forClass(java.lang.Object.instancehelper_getClass(container));
		object rawValue = observableProperty.getRawValue(container);
		if (!(rawValue is NodeList))
		{
			string s = new StringBuilder().append("Expected NodeList, found ").append(java.lang.Object.instancehelper_getClass(rawValue).getCanonicalName()).ToString();
			
			throw new IllegalStateException(s);
		}
		NodeList nodeList = (NodeList)rawValue;
		CalculatedSyntaxModel result = calculatedSyntaxModelAfterListAddition(csm, observableProperty, nodeList, index, nodeAdded);
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	internal virtual CalculatedSyntaxModel calculatedSyntaxModelAfterListRemoval(Node container, ObservableProperty observableProperty, int index)
	{
		CsmElement csm = ConcreteSyntaxModel.forClass(java.lang.Object.instancehelper_getClass(container));
		object rawValue = observableProperty.getRawValue(container);
		if (!(rawValue is NodeList))
		{
			string s = new StringBuilder().append("Expected NodeList, found ").append(java.lang.Object.instancehelper_getClass(rawValue).getCanonicalName()).ToString();
			
			throw new IllegalStateException(s);
		}
		NodeList nodeList = (NodeList)rawValue;
		CalculatedSyntaxModel result = calculatedSyntaxModelAfterListRemoval(csm, observableProperty, nodeList, index);
		
		return result;
	}
}
