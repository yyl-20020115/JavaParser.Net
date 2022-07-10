using System;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.comments;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.type;
using com.github.javaparser.printer.concretesyntaxmodel;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.printer.lexicalpreservation;

public class Difference
{
	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		
	internal sealed class MatchClassification : java.lang.Enum
	{
		
		public static MatchClassification ALL;

		
		public static MatchClassification PREVIOUS_AND_SAME;

		
		public static MatchClassification NEXT_AND_SAME;

		
		public static MatchClassification SAME_ONLY;

		
		public static MatchClassification ALMOST;

		
		private int priority;

		
		private static MatchClassification[] _0024VALUES;

		
		
		public static void ___003Cclinit_003E()
		{
		}

		
				[MethodParameters(new Modifiers[]
		{
			Modifiers.Synthetic,
			Modifiers.Synthetic,
			(Modifiers)0
		})]
		
		private MatchClassification(string _0024enum_0024name, int _0024enum_0024ordinal, int priority)
			: base(_0024enum_0024name, _0024enum_0024ordinal)
		{
			this.priority = priority;
			GC.KeepAlive(this);
		}

		
		
		public static MatchClassification[] values()
		{
			return (MatchClassification[])_0024VALUES.Clone();
		}

		
		
		
		public static MatchClassification valueOf(string name)
		{
			return (MatchClassification)java.lang.Enum.valueOf(ClassLiteral<MatchClassification>.Value, name);
		}

		internal virtual int getPriority()
		{
			return priority;
		}

		
		static MatchClassification()
		{
			ALL = new MatchClassification("ALL", 0, 1);
			PREVIOUS_AND_SAME = new MatchClassification("PREVIOUS_AND_SAME", 1, 2);
			NEXT_AND_SAME = new MatchClassification("NEXT_AND_SAME", 2, 3);
			SAME_ONLY = new MatchClassification("SAME_ONLY", 3, 4);
			ALMOST = new MatchClassification("ALMOST", 4, 5);
			_0024VALUES = new MatchClassification[5] { ALL, PREVIOUS_AND_SAME, NEXT_AND_SAME, SAME_ONLY, ALMOST };
		}
	}

	
	private sealed class ___003C_003EAnon0 : Comparator
	{
		internal ___003C_003EAnon0()
		{
		}

		public int compare(object P_0, object P_1)
		{
			int result = ((Integer)P_0).compareTo((Integer)P_1);
			
			return result;
		}

		
		public Comparator thenComparing(Comparator P_0)
		{
			return Comparator._003Cdefault_003EthenComparing(this, P_0);
		}

		
		public bool equals(object P_0)
		{
			return java.lang.Object.instancehelper_equals(this, P_0);
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

	
	private sealed class ___003C_003EAnon1 : Function
	{
		internal ___003C_003EAnon1()
		{
		}

		public object apply(object P_0)
		{
			List result = lambda_0024groupConsecutiveRemovedElements_00240((Integer)P_0);
			
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

	
	private sealed class ___003C_003EAnon2 : Function
	{
		internal ___003C_003EAnon2()
		{
		}

		public object apply(object P_0)
		{
			Integer result = Integer.valueOf(((MatchClassification)P_0).getPriority());
			
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

	public const int STANDARD_INDENTATION_SIZE = 4;

	
	private NodeText nodeText;

	
	private Node node;

	
		private List diffElements;

	
		private List originalElements;

	private int originalIndex;

	private int diffIndex;

	
		private List indentation;

	private bool addedIndentation;

	
		
	
	internal virtual int lastIndexOfEol(List source)
	{
		ListIterator listIterator = source.listIterator(source.size());
		int num = source.size() - 1;
		while (listIterator.hasPrevious())
		{
			TextElement textElement = (TextElement)listIterator.previous();
			if (textElement.isNewline())
			{
				return num;
			}
			num += -1;
		}
		return -1;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	private bool isAfterLBrace(NodeText nodeText, int nodeTextIndex)
	{
		if (nodeTextIndex > 0 && ((TextElement)nodeText.getElements().get(nodeTextIndex - 1)).isToken(99))
		{
			return true;
		}
		if (nodeTextIndex > 0 && ((TextElement)nodeText.getElements().get(nodeTextIndex - 1)).isSpaceOrTab())
		{
			bool result = isAfterLBrace(nodeText, nodeTextIndex - 1);
			
			return result;
		}
		return false;
	}

	
		
	[LineNumberTable(new byte[]
	{
		160,
		129,
		110,
		109,
		107,
		167,
		103,
		168,
		171,
		159,
		1,
		103,
		110,
		117,
		101,
		246,
		61,
		232,
		70,
		191,
		14,
		103,
		137,
		103,
		145,
		179,
		99,
		124,
		112,
		122,
		112,
		148,
		byte.MaxValue,
		3,
		58,
		235,
		74,
		101,
		241,
		47,
		235,
		95,
		136,
		99,
		104,
		145,
		115,
		122,
		112,
		127,
		18,
		117,
		162,
		116,
		112,
		100,
		151,
		245,
		49,
		235,
		88,
		127,
		1,
		117,
		226,
		159,
		166,
		233,
		160,
		93
	})]
	private void extractReshuffledDiffElements(List diffElements)
	{
		for (int i = 0; i < diffElements.size(); i++)
		{
			DifferenceElement differenceElement = (DifferenceElement)diffElements.get(i);
			if (!(differenceElement is Reshuffled))
			{
				continue;
			}
			Reshuffled reshuffled = (Reshuffled)differenceElement;
			CsmMix previousOrder = reshuffled.getPreviousOrder();
			CsmMix nextOrder = reshuffled.getNextOrder();
			Map correspondanceBetweenNextOrderAndPreviousOrder = getCorrespondanceBetweenNextOrderAndPreviousOrder(previousOrder, nextOrder);
			List list = findIndexOfCorrespondingNodeTextElement(previousOrder.getElements(), nodeText, originalIndex, node);
			HashMap hashMap = new HashMap();
			int j;
			for (j = 0; j < list.size(); j++)
			{
				int num = ((Integer)list.get(j)).intValue();
				if (num != -1)
				{
					((Map)hashMap).put((object)Integer.valueOf(num), (object)Integer.valueOf(j));
				}
			}
			j = ((Integer)list.stream().max(new ___003C_003EAnon0()).orElse(Integer.valueOf(-1))).intValue();
			LinkedList linkedList = new LinkedList();
			List elements = nextOrder.getElements();
			HashMap hashMap2 = new HashMap();
			int k;
			for (k = 0; k < elements.size(); k++)
			{
				if (correspondanceBetweenNextOrderAndPreviousOrder.containsKey(Integer.valueOf(k)))
				{
					continue;
				}
				int num2 = -1;
				for (int l = k + 1; l < elements.size(); l++)
				{
					if (num2 != -1)
					{
						break;
					}
					if (correspondanceBetweenNextOrderAndPreviousOrder.containsKey(Integer.valueOf(l)))
					{
						num2 = ((Integer)correspondanceBetweenNextOrderAndPreviousOrder.get(Integer.valueOf(l))).intValue();
						if (!((Map)hashMap2).containsKey((object)Integer.valueOf(num2)))
						{
							((Map)hashMap2).put((object)Integer.valueOf(num2), (object)new LinkedList());
						}
						((List)((Map)hashMap2).get((object)Integer.valueOf(num2))).add(elements.get(k));
					}
				}
				if (num2 == -1)
				{
					((List)linkedList).add(elements.get(k));
				}
			}
			diffElements.remove(i);
			k = i;
			if (j != -1)
			{
				for (int num2 = originalIndex; num2 <= j; num2++)
				{
					if (!((Map)hashMap).containsKey((object)Integer.valueOf(num2)))
					{
						continue;
					}
					int l = ((Integer)((Map)hashMap).get((object)Integer.valueOf(num2))).intValue();
					if (((Map)hashMap2).containsKey((object)Integer.valueOf(l)))
					{
						Iterator iterator = ((List)((Map)hashMap2).get((object)Integer.valueOf(l))).iterator();
						while (iterator.hasNext())
						{
							CsmElement element = (CsmElement)iterator.next();
							int index = k;
							k++;
							diffElements.add(index, new Added(element));
						}
					}
					CsmElement element2 = (CsmElement)previousOrder.getElements().get(l);
					if (correspondanceBetweenNextOrderAndPreviousOrder.containsValue(Integer.valueOf(l)))
					{
						int index2 = k;
						k++;
						diffElements.add(index2, new Kept(element2));
					}
					else
					{
						int index3 = k;
						k++;
						diffElements.add(index3, new Removed(element2));
					}
				}
			}
			Iterator iterator2 = ((List)linkedList).iterator();
			while (iterator2.hasNext())
			{
				CsmElement element3 = (CsmElement)iterator2.next();
				int index4 = k;
				k++;
				diffElements.add(index4, new Added(element3));
			}
		}
	}

	
		[LineNumberTable(new byte[]
	{
		160, 238, 135, 102, 127, 1, 127, 3, 130, 103,
		127, 0, 127, 1, 108, 98, 130
	})]
	private Map combineRemovedElementsToRemovedGroups()
	{
		Map map = groupConsecutiveRemovedElements();
		ArrayList arrayList = new ArrayList();
		Iterator iterator = map.entrySet().iterator();
		while (iterator.hasNext())
		{
			Map.Entry entry = (Map.Entry)iterator.next();
			((List)arrayList).add((object)RemovedGroup.of((Integer)entry.getKey(), (List)entry.getValue()));
		}
		HashMap hashMap = new HashMap();
		Iterator iterator2 = ((List)arrayList).iterator();
		while (iterator2.hasNext())
		{
			RemovedGroup removedGroup = (RemovedGroup)iterator2.next();
			Iterator iterator3 = removedGroup.iterator();
			while (iterator3.hasNext())
			{
				Removed key = (Removed)iterator3.next();
				((Map)hashMap).put((object)key, (object)removedGroup);
			}
		}
		return hashMap;
	}

	
	[LineNumberTable(new byte[]
	{
		160, 106, 98, 127, 13, 119, 104, 112, 104, 135,
		119, 110, 110, 130, 174, 162
	})]
	private bool applyLeftOverDiffElements()
	{
		int result = 0;
		if (diffIndex < diffElements.size() && originalIndex >= originalElements.size())
		{
			DifferenceElement differenceElement = (DifferenceElement)diffElements.get(diffIndex);
			if (differenceElement is Kept)
			{
				diffIndex++;
			}
			else if (differenceElement is Added)
			{
				Added added = (Added)differenceElement;
				nodeText.addElement(originalIndex, added.toTextElement());
				originalIndex++;
				diffIndex++;
			}
			else
			{
				diffIndex++;
			}
			result = 1;
		}
		return (byte)result != 0;
	}

	
	[LineNumberTable(new byte[]
	{
		160, 89, 98, 127, 13, 151, 104, 144, 223, 43,
		130
	})]
	private bool applyLeftOverOriginalElements()
	{
		int result = 0;
		if (diffIndex >= diffElements.size() && originalIndex < originalElements.size())
		{
			TextElement textElement = (TextElement)originalElements.get(originalIndex);
			if (!textElement.isWhiteSpaceOrComment())
			{
				string message = new StringBuilder().append("NodeText: ").append(nodeText).append(". Difference: ")
					.append(this)
					.append(" ")
					.append(textElement)
					.ToString();
				
				throw new UnsupportedOperationException(message);
			}
			originalIndex++;
			result = 1;
		}
		return (byte)result != 0;
	}

	
	
	[LineNumberTable(new byte[]
	{
		162, 152, 104, 102, 50, 166, 103, 110, 129, 104,
		115, 57, 166, 103, 110, 161, 103, 98, 127, 14,
		102, 127, 3, 110, 127, 4, 153, 125, 144, 159,
		6, 101, 127, 14, 104, 130, 159, 14, 127, 9,
		116, 144, 127, 31, 127, 6, 226, 70, 104, 127,
		5, 127, 6, 194, 134, 119, 120, 127, 10, 120,
		110, 159, 10, 136, 110, 178, 127, 0, 115, 232,
		70, 174, 127, 0, 114, 115, 236, 72, 107, 142,
		114, 144, 114, 206, 107, 116, 110, 120, 108, 223,
		1, 110
	})]
	private void applyAddedDiffElement(Added added)
	{
		if (added.isIndent())
		{
			for (int i = 0; i < 4; i++)
			{
				indentation.add(new TokenTextElement(1));
			}
			addedIndentation = true;
			diffIndex++;
			return;
		}
		if (added.isUnindent())
		{
			for (int i = 0; i < 4; i++)
			{
				if (indentation.isEmpty())
				{
					break;
				}
				indentation.remove(indentation.size() - 1);
			}
			addedIndentation = false;
			diffIndex++;
			return;
		}
		TextElement textElement = added.toTextElement();
		int num = 0;
		int num2 = ((originalIndex > 0 && ((TextElement)originalElements.get(originalIndex - 1)).isNewline()) ? 1 : 0);
		if (num2 != 0)
		{
			List list = processIndentation(indentation, originalElements.subList(0, originalIndex - 1));
			int num3 = (nextIsRightBrace(originalIndex) ? 1 : 0);
			Iterator iterator = list.iterator();
			while (iterator.hasNext())
			{
				TextElement textElement2 = (TextElement)iterator.next();
				if (num3 == 0 && textElement2 is TokenTextElement && ((TextElement)originalElements.get(originalIndex)).isToken(((TokenTextElement)textElement2).getTokenKind()))
				{
					originalIndex++;
					continue;
				}
				NodeText obj = nodeText;
				int num4 = originalIndex;
				Difference difference = this;
				int index = num4;
				difference.originalIndex = num4 + 1;
				obj.addElement(index, textElement2);
			}
		}
		else if (isAfterLBrace(nodeText, originalIndex) && !isAReplacement(diffIndex))
		{
			if (textElement.isNewline())
			{
				num = 1;
			}
			NodeText obj2 = nodeText;
			int num4 = originalIndex;
			Difference difference = this;
			int index2 = num4;
			difference.originalIndex = num4 + 1;
			obj2.addElement(index2, new TokenTextElement(TokenTypes.eolTokenKind()));
			while (originalIndex >= 2 && ((TextElement)originalElements.get(originalIndex - 2)).isSpaceOrTab())
			{
				originalElements.remove(originalIndex - 2);
				originalIndex--;
			}
			Iterator iterator2 = processIndentation(indentation, originalElements.subList(0, originalIndex - 1)).iterator();
			while (iterator2.hasNext())
			{
				TextElement nodeTextElement = (TextElement)iterator2.next();
				NodeText obj3 = nodeText;
				num4 = originalIndex;
				difference = this;
				int index3 = num4;
				difference.originalIndex = num4 + 1;
				obj3.addElement(index3, nodeTextElement);
			}
			if (!addedIndentation)
			{
				iterator2 = indentationBlock().iterator();
				while (iterator2.hasNext())
				{
					TextElement nodeTextElement = (TextElement)iterator2.next();
					NodeText obj4 = nodeText;
					num4 = originalIndex;
					difference = this;
					int index4 = num4;
					difference.originalIndex = num4 + 1;
					obj4.addElement(index4, nodeTextElement);
				}
			}
		}
		if (num == 0)
		{
			int num5 = ((nodeText.numberOfElements() > originalIndex + 2) ? 1 : 0);
			int num3 = (nodeText.getTextElement(originalIndex).isComment() ? 1 : 0);
			int num6 = ((originalIndex > 0 && nodeText.getTextElement(originalIndex - 1).isComment()) ? 1 : 0);
			int num7 = (nodeText.getTextElement(originalIndex).isNewline() ? 1 : 0);
			int num8 = ((originalIndex == 0) ? 1 : 0);
			int num9 = ((originalIndex > 0 && nodeText.getTextElement(originalIndex - 1).isWhiteSpace()) ? 1 : 0);
			if (num5 != 0 && num3 != 0)
			{
				originalIndex += 2;
				nodeText.addElement(originalIndex, textElement);
				originalIndex = adjustIndentation(indentation, nodeText, originalIndex, followedByUnindent: false);
				originalIndex++;
			}
			else if (num7 != 0 && num6 != 0)
			{
				originalIndex++;
				originalIndex = adjustIndentation(indentation, nodeText, originalIndex, followedByUnindent: false);
				nodeText.addElement(originalIndex, textElement);
				originalIndex++;
			}
			else if (num7 != 0 && textElement.isChild())
			{
				if (num2 == 0 && num8 == 0 && num9 == 0)
				{
					originalIndex++;
				}
				nodeText.addElement(originalIndex, textElement);
				originalIndex++;
			}
			else
			{
				nodeText.addElement(originalIndex, textElement);
				originalIndex++;
			}
		}
		if (textElement.isNewline())
		{
			int num5 = (isFollowedByUnindent(diffElements, diffIndex) ? 1 : 0);
			int num3 = (nextIsRightBrace(originalIndex) ? 1 : 0);
			if ((!nodeText.getTextElement(originalIndex).isNewline() && num3 == 0) || num5 != 0)
			{
				originalIndex = adjustIndentation(indentation, nodeText, originalIndex, (byte)num5 != 0);
			}
		}
		diffIndex++;
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
		159, 20, 101, 104, 115, 127, 0, 115, 107, 110,
		115, 113, 104, 115, 113, 238, 72, 110, 110, 110,
		118, 238, 69, 110, 110, 110, 126, 116, 110, 110,
		110, 109, 110, 147, 104, 110, 147, 191, 27, 113,
		135, 110, 110, 115, 112, 110, 115, 112, 110, 115,
		104, 115, 104, 112, 208, 144, 159, 27, 112, 115,
		104, 115, 104, 115, 235, 69, 110, 107, 127, 10,
		63, 4, 232, 69, 159, 27
	})]
	private void applyKeptDiffElement(Kept kept, TextElement originalElement, bool originalElementIsChild, bool originalElementIsToken)
	{
		if (originalElement.isComment())
		{
			originalIndex++;
			return;
		}
		if (kept.isChild() && ((LexicalDifferenceCalculator.CsmChild)kept.getElement()).getChild() is Comment)
		{
			diffIndex++;
			return;
		}
		if (kept.isChild() && originalElementIsChild)
		{
			diffIndex++;
			originalIndex++;
			return;
		}
		if (kept.isChild() && originalElementIsToken)
		{
			if (originalElement.isWhiteSpaceOrComment())
			{
				originalIndex++;
				return;
			}
			if (originalElement.isIdentifier() && isNodeWithTypeArguments(kept))
			{
				diffIndex++;
				int indexToNextTokenElement = getIndexToNextTokenElement((TokenTextElement)originalElement, 0);
				originalIndex += indexToNextTokenElement;
				originalIndex++;
				return;
			}
			if (originalElement.isIdentifier() && isTypeWithFullyQualifiedName(kept))
			{
				diffIndex++;
				int indexToNextTokenElement = getIndexToNextTokenElement((TokenTextElement)originalElement, kept);
				originalIndex += indexToNextTokenElement;
				originalIndex++;
				return;
			}
			if ((originalElement.isIdentifier() || originalElement.isKeyword()) && isArrayType(kept))
			{
				int indexToNextTokenElement = getIndexToNextTokenElementInArrayType((TokenTextElement)originalElement, getArrayLevel(kept));
				diffIndex++;
				originalIndex += indexToNextTokenElement;
				originalIndex++;
				return;
			}
			if (originalElement.isIdentifier())
			{
				originalIndex++;
				diffIndex++;
				return;
			}
			if (kept.isPrimitiveType())
			{
				originalIndex++;
				diffIndex++;
				return;
			}
			string message = new StringBuilder().append("kept ").append(kept.getElement()).append(" vs ")
				.append(originalElement)
				.ToString();
			
			throw new UnsupportedOperationException(message);
		}
		if (kept.isToken() && originalElementIsToken)
		{
			TokenTextElement tokenTextElement = (TokenTextElement)originalElement;
			if (kept.getTokenType() == tokenTextElement.getTokenKind())
			{
				originalIndex++;
				diffIndex++;
				return;
			}
			if (kept.isNewLine() && tokenTextElement.isNewline())
			{
				originalIndex++;
				diffIndex++;
				return;
			}
			if (kept.isNewLine() && tokenTextElement.isSpaceOrTab())
			{
				originalIndex++;
				diffIndex++;
				return;
			}
			if (kept.isWhiteSpaceOrComment())
			{
				diffIndex++;
				return;
			}
			if (tokenTextElement.isWhiteSpaceOrComment())
			{
				originalIndex++;
				return;
			}
			if (!kept.isNewLine() && tokenTextElement.isSeparator())
			{
				originalIndex++;
				return;
			}
			string message2 = new StringBuilder().append("Csm token ").append(kept.getElement()).append(" NodeText TOKEN ")
				.append(tokenTextElement)
				.ToString();
			
			throw new UnsupportedOperationException(message2);
		}
		if (kept.isToken() && originalElementIsChild)
		{
			diffIndex++;
			return;
		}
		if (kept.isWhiteSpace())
		{
			diffIndex++;
			return;
		}
		if (kept.isIndent())
		{
			diffIndex++;
			return;
		}
		if (kept.isUnindent())
		{
			diffIndex++;
			if (openBraceWasOnSameLine())
			{
				return;
			}
			for (int indexToNextTokenElement = 0; indexToNextTokenElement < 4; indexToNextTokenElement++)
			{
				if (originalIndex < 1)
				{
					break;
				}
				if (!nodeText.getTextElement(originalIndex - 1).isSpaceOrTab())
				{
					break;
				}
				NodeText obj = nodeText;
				int index = originalIndex - 1;
				originalIndex = index;
				obj.removeElement(index);
			}
			return;
		}
		string message3 = new StringBuilder().append("kept ").append(kept.getElement()).append(" vs ")
			.append(originalElement)
			.ToString();
		
		throw new UnsupportedOperationException(message3);
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		159,
		45,
		134,
		113,
		103,
		171,
		108,
		127,
		19,
		147,
		142,
		101,
		145,
		127,
		17,
		103,
		184,
		127,
		3,
		127,
		15,
		145,
		127,
		16,
		byte.MaxValue,
		5,
		69,
		142,
		113,
		184,
		114,
		103,
		113,
		115,
		107,
		115,
		104,
		113,
		115,
		104,
		104,
		113,
		147,
		159,
		27,
		127,
		3,
		112,
		104,
		144,
		191,
		27,
		106
	})]
	private void applyRemovedDiffElement(RemovedGroup removedGroup, Removed removed, TextElement originalElement, bool originalElementIsChild, bool originalElementIsToken)
	{
		if (removed.isChild() && originalElementIsChild)
		{
			ChildTextElement childTextElement = (ChildTextElement)originalElement;
			if (childTextElement.isComment())
			{
				Comment comment = (Comment)childTextElement.getChild();
				if (!comment.isOrphan() && comment.getCommentedNode().isPresent() && ((Node)comment.getCommentedNode().get()).equals(removed.getChild()))
				{
					nodeText.removeElement(originalIndex);
				}
				else
				{
					originalIndex++;
				}
			}
			else
			{
				nodeText.removeElement(originalIndex);
				if ((diffIndex + 1 >= diffElements.size() || !(diffElements.get(diffIndex + 1) is Added)) && !removedGroup.isACompleteLine())
				{
					originalIndex = considerEnforcingIndentation(nodeText, originalIndex);
				}
				if (originalElements.size() > originalIndex && originalIndex > 0 && ((TextElement)originalElements.get(originalIndex)).isWhiteSpace() && ((TextElement)originalElements.get(originalIndex - 1)).isWhiteSpace() && (diffIndex + 1 == diffElements.size() || diffElements.get(diffIndex + 1) is Kept))
				{
					List list = originalElements;
					int num = originalIndex;
					originalIndex = num - 1;
					list.remove(num);
				}
				diffIndex++;
			}
		}
		else if (removed.isToken() && originalElementIsToken && (removed.getTokenType() == ((TokenTextElement)originalElement).getTokenKind() || (((TokenTextElement)originalElement).getToken().getCategory().isEndOfLine() && removed.isNewLine())))
		{
			nodeText.removeElement(originalIndex);
			diffIndex++;
		}
		else if (originalElementIsToken && originalElement.isWhiteSpaceOrComment())
		{
			originalIndex++;
		}
		else if (originalElement.isLiteral())
		{
			nodeText.removeElement(originalIndex);
			diffIndex++;
		}
		else if (removed.isPrimitiveType())
		{
			if (!originalElement.isPrimitive())
			{
				string message = new StringBuilder().append("removed ").append(removed.getElement()).append(" vs ")
					.append(originalElement)
					.ToString();
				
				throw new UnsupportedOperationException(message);
			}
			nodeText.removeElement(originalIndex);
			diffIndex++;
		}
		else if (removed.isWhiteSpace() || removed.getElement() is CsmIndent || removed.getElement() is CsmUnindent)
		{
			diffIndex++;
		}
		else
		{
			if (!originalElement.isWhiteSpace())
			{
				string message2 = new StringBuilder().append("removed ").append(removed.getElement()).append(" vs ")
					.append(originalElement)
					.ToString();
				
				throw new UnsupportedOperationException(message2);
			}
			originalIndex++;
		}
		cleanTheLineOfLeftOverSpace(removedGroup, removed);
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		163, 18, 134, 103, 103, 140, 112, 99, 143, 116,
		104, 116, 115, 103, 99, 240, 58, 235, 60, 235,
		79
	})]
	private Map getCorrespondanceBetweenNextOrderAndPreviousOrder(CsmMix elementsFromPreviousOrder, CsmMix elementsFromNextOrder)
	{
		HashMap hashMap = new HashMap();
		List elements = elementsFromNextOrder.getElements();
		List elements2 = elementsFromPreviousOrder.getElements();
		WrappingRangeIterator wrappingRangeIterator = new WrappingRangeIterator(elements2.size());
		for (int i = 0; i < elements.size(); i++)
		{
			int num = 0;
			CsmElement a = (CsmElement)elements.get(i);
			for (int j = 0; j < elements2.size(); j++)
			{
				if (num != 0)
				{
					break;
				}
				Integer integer = wrappingRangeIterator.next();
				CsmElement b = (CsmElement)elements2.get(integer.intValue());
				if (!((Map)hashMap).values().contains(integer) && DifferenceElementCalculator.matching(a, b))
				{
					num = 1;
					((Map)hashMap).put((object)Integer.valueOf(i), (object)integer);
				}
			}
		}
		return hashMap;
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
		163, 53, 102, 146, 103, 108, 136, 113, 117, 114,
		138, 141, 103, 99, 105, 140, 184, 99, 123, 140,
		185, 104, 118, 100, 118, 100, 150, 148, 111, 244,
		33, 235, 101, 118, 140, 105, 151, 141, 133
	})]
	private List findIndexOfCorrespondingNodeTextElement(List elements, NodeText nodeText, int startIndex, Node node)
	{
		ArrayList arrayList = new ArrayList();
		ListIterator listIterator = elements.listIterator();
		while (listIterator.hasNext())
		{
			int num = listIterator.previousIndex();
			CsmElement csmElement = (CsmElement)listIterator.next();
			int num2 = listIterator.nextIndex();
			EnumMap.___003Cclinit_003E();
			EnumMap enumMap = new EnumMap(ClassLiteral<MatchClassification>.Value);
			for (int i = startIndex; i < nodeText.getElements().size(); i++)
			{
				if (((List)arrayList).contains((object)Integer.valueOf(i)))
				{
					continue;
				}
				TextElement textElement = nodeText.getTextElement(i);
				if (isCorrespondingElement(textElement, csmElement, node))
				{
					int num3 = 0;
					if (i > 0 && num > -1)
					{
						TextElement textElement2 = nodeText.getTextElement(i - 1);
						num3 = (isCorrespondingElement(textElement2, (CsmElement)elements.get(num), node) ? 1 : 0);
					}
					int num4 = 0;
					if (i < nodeText.getElements().size() - 1 && num2 < elements.size())
					{
						TextElement textElement3 = nodeText.getTextElement(i + 1);
						num4 = (isCorrespondingElement(textElement3, (CsmElement)elements.get(num2), node) ? 1 : 0);
					}
					if (num3 != 0 && num4 != 0)
					{
						((Map)enumMap).putIfAbsent((object)MatchClassification.ALL, (object)Integer.valueOf(i));
					}
					else if (num3 != 0)
					{
						((Map)enumMap).putIfAbsent((object)MatchClassification.PREVIOUS_AND_SAME, (object)Integer.valueOf(i));
					}
					else if (num4 != 0)
					{
						((Map)enumMap).putIfAbsent((object)MatchClassification.NEXT_AND_SAME, (object)Integer.valueOf(i));
					}
					else
					{
						((Map)enumMap).putIfAbsent((object)MatchClassification.SAME_ONLY, (object)Integer.valueOf(i));
					}
				}
				else if (isAlmostCorrespondingElement(textElement, csmElement, node))
				{
					((Map)enumMap).putIfAbsent((object)MatchClassification.ALMOST, (object)Integer.valueOf(i));
				}
			}
			Optional optional = ((Map)enumMap).keySet().stream().min(Comparator.comparing(new ___003C_003EAnon2()));
			if (optional.isPresent())
			{
				((List)arrayList).add(((Map)enumMap).get(optional.get()));
			}
			else
			{
				((List)arrayList).add((object)Integer.valueOf(-1));
			}
		}
		return arrayList;
	}

	
		[LineNumberTable(new byte[]
	{
		161, 0, 134, 98, 115, 114, 104, 99, 167, 124,
		136, 226, 54, 233, 77
	})]
	private Map groupConsecutiveRemovedElements()
	{
		HashMap hashMap = new HashMap();
		Integer integer = null;
		for (int i = 0; i < diffElements.size(); i++)
		{
			DifferenceElement differenceElement = (DifferenceElement)diffElements.get(i);
			if (differenceElement is Removed)
			{
				if (integer == null)
				{
					integer = Integer.valueOf(i);
				}
				((List)((Map)hashMap).computeIfAbsent((object)integer, (Function)new ___003C_003EAnon1())).add((Removed)differenceElement);
			}
			else
			{
				integer = null;
			}
		}
		return hashMap;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		92, 98, 119, 120, 130, 120, 226, 59, 230, 72,
		98, 99, 116, 120, 130, 103, 226, 59, 230, 72,
		100, 139
	})]
	private int considerEnforcingIndentation(NodeText nodeText, int nodeTextIndex)
	{
		int num = 1;
		int i;
		for (i = nodeTextIndex; i >= 0; i += -1)
		{
			if (num == 0)
			{
				break;
			}
			if (i >= nodeText.getElements().size())
			{
				break;
			}
			if (((TextElement)nodeText.getElements().get(i)).isNewline())
			{
				break;
			}
			if (!((TextElement)nodeText.getElements().get(i)).isSpaceOrTab())
			{
				num = 0;
			}
		}
		i = nodeTextIndex;
		if (num != 0)
		{
			for (int j = nodeTextIndex; j >= 0 && j < nodeText.getElements().size() && !((TextElement)nodeText.getElements().get(j)).isNewline(); j += -1)
			{
				nodeText.removeElement(j);
				i = j;
			}
		}
		if (i < 0)
		{
			
			throw new IllegalStateException();
		}
		return i;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		161, 86, 147, 161, 108, 108, 106, 103, 135, 124,
		120, 157, 115, 159, 9, 115, 238, 57, 233, 77,
		136
	})]
	private void cleanTheLineOfLeftOverSpace(RemovedGroup removedGroup, Removed removed)
	{
		if (originalIndex >= originalElements.size() || removedGroup.isProcessed() || removedGroup.getLastElement() != removed || !removedGroup.isACompleteLine())
		{
			return;
		}
		Integer lastElementIndex = removedGroup.getLastElementIndex();
		Optional optional = removedGroup.getIndentation();
		if (optional.isPresent() && !isReplaced(lastElementIndex.intValue()))
		{
			for (int i = 0; i < ((Integer)optional.get()).intValue(); i++)
			{
				if (((TextElement)originalElements.get(originalIndex)).isSpaceOrTab())
				{
					nodeText.removeElement(originalIndex);
				}
				else if (originalIndex >= 1 && ((TextElement)originalElements.get(originalIndex - 1)).isSpaceOrTab())
				{
					nodeText.removeElement(originalIndex - 1);
					originalIndex--;
				}
			}
		}
		removedGroup.processed();
	}

	
	
	
	private bool isReplaced(int diffIndex)
	{
		return (diffIndex < diffElements.size() - 1 && diffElements.get(diffIndex + 1) is Added && diffElements.get(diffIndex) is Removed) ? true : false;
	}

	
	
	
	private bool isNodeWithTypeArguments(DifferenceElement element)
	{
		if (!element.isChild())
		{
			return false;
		}
		LexicalDifferenceCalculator.CsmChild csmChild = (LexicalDifferenceCalculator.CsmChild)element.getElement();
		if (!ClassLiteral<NodeWithTypeArguments>.Value.isAssignableFrom(java.lang.Object.instancehelper_getClass(csmChild.getChild())))
		{
			return false;
		}
		Optional typeArguments = ((NodeWithTypeArguments)csmChild.getChild()).getTypeArguments();
		return (typeArguments.isPresent() && ((NodeList)typeArguments.get()).size() > 0) ? true : false;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		162, 46, 98, 108, 138, 132, 108, 108, 105, 111,
		135, 229, 69, 112, 130
	})]
	private int getIndexToNextTokenElement(TokenTextElement element, int nestedDiamondOperator)
	{
		int num = 0;
		Optional nextToken = element.getToken().getNextToken();
		if (!nextToken.isPresent())
		{
			return num;
		}
		num++;
		JavaToken javaToken = (JavaToken)nextToken.get();
		JavaToken.Kind kind = JavaToken.Kind.valueOf(javaToken.getKind());
		if (isDiamondOperator(kind))
		{
			nestedDiamondOperator = ((!JavaToken.Kind.___003C_003EGT.equals(kind)) ? (nestedDiamondOperator + 1) : (nestedDiamondOperator + -1));
		}
		if (nestedDiamondOperator == 0 && !javaToken.getCategory().isWhitespace())
		{
			return num;
		}
		return num + getIndexToNextTokenElement(new TokenTextElement(javaToken), nestedDiamondOperator);
	}

	
	
	
	private bool isTypeWithFullyQualifiedName(DifferenceElement element)
	{
		if (!element.isChild())
		{
			return false;
		}
		LexicalDifferenceCalculator.CsmChild csmChild = (LexicalDifferenceCalculator.CsmChild)element.getElement();
		if (!ClassLiteral<ClassOrInterfaceType>.Value.isAssignableFrom(java.lang.Object.instancehelper_getClass(csmChild.getChild())))
		{
			return false;
		}
		bool result = ((ClassOrInterfaceType)csmChild.getChild()).getScope().isPresent();
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		162, 9, 98, 107, 140, 123, 103, 123, 111, 113,
		116, 113, 100, 162, 98, 226, 54, 235, 76
	})]
	private int getIndexToNextTokenElement(TokenTextElement element, DifferenceElement kept)
	{
		int num = 0;
		if (!isTypeWithFullyQualifiedName(kept))
		{
			return 0;
		}
		LexicalDifferenceCalculator.CsmChild csmChild = (LexicalDifferenceCalculator.CsmChild)kept.getElement();
		string[] array = java.lang.String.instancehelper_split(((ClassOrInterfaceType)csmChild.getChild()).getNameWithScope(), "\\.");
		JavaToken javaToken = element.getToken();
		string[] array2 = array;
		int num2 = array2.Length;
		for (int i = 0; i < num2; i++)
		{
			string @this = array2[i];
			if (java.lang.String.instancehelper_equals(@this, javaToken.asString()))
			{
				javaToken = (JavaToken)javaToken.getNextToken().get();
				if (!java.lang.String.instancehelper_equals(javaToken.asString(), "."))
				{
					break;
				}
				javaToken = (JavaToken)javaToken.getNextToken().get();
				num += 2;
				continue;
			}
			num = 0;
			break;
		}
		return num;
	}

	
	
	
	private bool isArrayType(DifferenceElement element)
	{
		CsmElement element2 = element.getElement();
		return (element2 is LexicalDifferenceCalculator.CsmChild && ((LexicalDifferenceCalculator.CsmChild)element2).getChild() is ArrayType) ? true : false;
	}

	
	
	
	private int getArrayLevel(DifferenceElement element)
	{
		CsmElement element2 = element.getElement();
		if (element2 is LexicalDifferenceCalculator.CsmChild && ((LexicalDifferenceCalculator.CsmChild)element2).getChild() is ArrayType)
		{
			Node child = ((LexicalDifferenceCalculator.CsmChild)element2).getChild();
			int arrayLevel = ((ArrayType)child).getArrayLevel();
			
			return arrayLevel;
		}
		return 0;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		162, 73, 98, 108, 138, 132, 108, 108, 105, 111,
		229, 69, 112, 130
	})]
	private int getIndexToNextTokenElementInArrayType(TokenTextElement element, int arrayLevel)
	{
		int num = 0;
		Optional nextToken = element.getToken().getNextToken();
		if (!nextToken.isPresent())
		{
			return num;
		}
		num++;
		JavaToken javaToken = (JavaToken)nextToken.get();
		JavaToken.Kind kind = JavaToken.Kind.valueOf(javaToken.getKind());
		if (isBracket(kind) && JavaToken.Kind.___003C_003ERBRACKET.equals(kind))
		{
			arrayLevel += -1;
		}
		if (arrayLevel == 0 && !javaToken.getCategory().isWhitespace())
		{
			return num;
		}
		return num + getIndexToNextTokenElementInArrayType(new TokenTextElement(javaToken), arrayLevel);
	}

	
	
	private bool openBraceWasOnSameLine()
	{
		for (int i = originalIndex; i >= 0 && !nodeText.getTextElement(i).isNewline(); i += -1)
		{
			if (nodeText.getTextElement(i).isToken(99))
			{
				return true;
			}
		}
		return false;
	}

	
	
	
	private bool isDiamondOperator(JavaToken.Kind kind)
	{
		return (JavaToken.Kind.___003C_003EGT.equals(kind) || JavaToken.Kind.___003C_003ELT.equals(kind)) ? true : false;
	}

	
	
	
	private bool isBracket(JavaToken.Kind kind)
	{
		return (JavaToken.Kind.___003C_003ELBRACKET.equals(kind) || JavaToken.Kind.___003C_003ERBRACKET.equals(kind)) ? true : false;
	}

	
	
	
	private bool doWeHaveLeftBraceFollowedBySpace(int index)
	{
		index = rewindSpace(index);
		bool result = ((TextElement)nodeText.getElements().get(index)).isToken(99);
		
		return result;
	}

	
	
	
	private int rewindSpace(int index)
	{
		if (index <= 0)
		{
			return index;
		}
		if (((TextElement)nodeText.getElements().get(index)).isWhiteSpace())
		{
			int result = rewindSpace(index - 1);
			
			return result;
		}
		return index;
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		36, 103, 104, 102, 134, 109, 109, 104, 104, 226,
		60, 230, 72
	})]
	private List processIndentation(List indentation, List prevElements)
	{
		LinkedList linkedList = new LinkedList(indentation);
		int num = lastIndexOfEol(prevElements);
		if (num < 0)
		{
			return linkedList;
		}
		((List)linkedList).clear();
		for (int i = num + 1; i < prevElements.size(); i++)
		{
			TextElement textElement = (TextElement)prevElements.get(i);
			if (!textElement.isWhiteSpace())
			{
				break;
			}
			((List)linkedList).add((object)textElement);
		}
		return linkedList;
	}

	
	
	
	private bool nextIsRightBrace(int index)
	{
		List list = originalElements.subList(index, originalElements.size());
		Iterator iterator = list.iterator();
		while (iterator.hasNext())
		{
			TextElement textElement = (TextElement)iterator.next();
			if (!textElement.isSpaceOrTab())
			{
				bool result = textElement.isToken(100);
				
				return result;
			}
		}
		return false;
	}

	
	
	
	private bool isAReplacement(int diffIndex)
	{
		return (diffIndex > 0 && diffElements.get(diffIndex) is Added && diffElements.get(diffIndex - 1) is Removed) ? true : false;
	}

	
		
	private List indentationBlock()
	{
		LinkedList linkedList = new LinkedList();
		((List)linkedList).add((object)new TokenTextElement(1));
		((List)linkedList).add((object)new TokenTextElement(1));
		((List)linkedList).add((object)new TokenTextElement(1));
		((List)linkedList).add((object)new TokenTextElement(1));
		return linkedList;
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
		158, 140, 163, 119, 127, 9, 125, 99, 150, 123,
		127, 7, 135, 146, 98, 100, 139
	})]
	private int adjustIndentation(List indentation, NodeText nodeText, int nodeTextIndex, bool followedByUnindent)
	{
		List list = processIndentation(indentation, nodeText.getElements().subList(0, nodeTextIndex - 1));
		if (nodeTextIndex < nodeText.getElements().size() && ((TextElement)nodeText.getElements().get(nodeTextIndex)).isToken(100))
		{
			list = list.subList(0, list.size() - java.lang.Math.min(4, list.size()));
		}
		else if (followedByUnindent)
		{
			list = list.subList(0, java.lang.Math.max(0, list.size() - 4));
		}
		Iterator iterator = list.iterator();
		while (iterator.hasNext())
		{
			TextElement element = (TextElement)iterator.next();
			if (nodeTextIndex < nodeText.getElements().size() && ((TextElement)nodeText.getElements().get(nodeTextIndex)).isSpaceOrTab())
			{
				nodeTextIndex++;
				continue;
			}
			List elements = nodeText.getElements();
			int index = nodeTextIndex;
			nodeTextIndex++;
			elements.add(index, element);
		}
		if (nodeTextIndex < 0)
		{
			
			throw new IllegalStateException();
		}
		return nodeTextIndex;
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	private bool isFollowedByUnindent(List diffElements, int diffIndex)
	{
		int num = diffIndex + 1;
		return (num < diffElements.size() && ((DifferenceElement)diffElements.get(num)).isAdded() && ((DifferenceElement)diffElements.get(num)).getElement() is CsmUnindent) ? true : false;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		163, 126, 104, 103, 104, 103, 159, 8, 106, 103,
		104, 103, 143, 98, 171
	})]
	private bool isCorrespondingElement(TextElement textElement, CsmElement csmElement, Node node)
	{
		if (csmElement is CsmToken)
		{
			CsmToken csmToken = (CsmToken)csmElement;
			if (textElement is TokenTextElement)
			{
				TokenTextElement tokenTextElement = (TokenTextElement)textElement;
				return (tokenTextElement.getTokenKind() == csmToken.getTokenType() && java.lang.String.instancehelper_equals(tokenTextElement.getText(), csmToken.getContent(node))) ? true : false;
			}
		}
		else
		{
			if (!(csmElement is LexicalDifferenceCalculator.CsmChild))
			{
				
				throw new UnsupportedOperationException();
			}
			LexicalDifferenceCalculator.CsmChild csmChild = (LexicalDifferenceCalculator.CsmChild)csmElement;
			if (textElement is ChildTextElement)
			{
				ChildTextElement childTextElement = (ChildTextElement)textElement;
				return childTextElement.getChild() == csmChild.getChild();
			}
		}
		return false;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	private bool isAlmostCorrespondingElement(TextElement textElement, CsmElement csmElement, Node node)
	{
		if (isCorrespondingElement(textElement, csmElement, node))
		{
			return false;
		}
		return (textElement.isWhiteSpace() && csmElement is CsmToken && ((CsmToken)csmElement).isWhiteSpace()) ? true : false;
	}

	
	
	
	
	private static List lambda_0024groupConsecutiveRemovedElements_00240(Integer key)
	{
		ArrayList result = new ArrayList();
		
		return result;
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		19, 232, 58, 103, 167, 167, 99, 176, 103, 103,
		103, 140, 108
	})]
	internal Difference(List diffElements, NodeText nodeText, Node node)
	{
		originalIndex = 0;
		diffIndex = 0;
		addedIndentation = false;
		if (nodeText == null)
		{
			
			throw new NullPointerException("nodeText can not be null");
		}
		this.nodeText = nodeText;
		this.node = node;
		this.diffElements = diffElements;
		originalElements = nodeText.getElements();
		indentation = LexicalPreservingPrinter.findIndentation(node);
	}

	
	[LineNumberTable(new byte[]
	{
		122, 108, 167, 103, 135, 108, 151, 104, 145, 120,
		108, 140, 104, 119, 104, 104, 123, 98, 223, 23,
		127, 13
	})]
	internal virtual void apply()
	{
		extractReshuffledDiffElements(diffElements);
		Map map = combineRemovedElementsToRemovedGroups();
		do
		{
			int num = (applyLeftOverDiffElements() ? 1 : 0);
			int num2 = (applyLeftOverOriginalElements() ? 1 : 0);
			if (num != 0 || num2 != 0)
			{
				continue;
			}
			DifferenceElement differenceElement = (DifferenceElement)diffElements.get(diffIndex);
			if (differenceElement is Added)
			{
				applyAddedDiffElement((Added)differenceElement);
				continue;
			}
			TextElement textElement = (TextElement)originalElements.get(originalIndex);
			int originalElementIsChild = ((textElement is ChildTextElement) ? 1 : 0);
			int originalElementIsToken = ((textElement is TokenTextElement) ? 1 : 0);
			if (differenceElement is Kept)
			{
				applyKeptDiffElement((Kept)differenceElement, textElement, (byte)originalElementIsChild != 0, (byte)originalElementIsToken != 0);
				continue;
			}
			if (differenceElement is Removed)
			{
				Removed removed = (Removed)differenceElement;
				applyRemovedDiffElement((RemovedGroup)map.get(removed), removed, textElement, (byte)originalElementIsChild != 0, (byte)originalElementIsToken != 0);
				continue;
			}
			string message = new StringBuilder().append("").append(differenceElement).append(" vs ")
				.append(textElement)
				.ToString();
			
			throw new UnsupportedOperationException(message);
		}
		while (diffIndex < diffElements.size() || originalIndex < originalElements.size());
	}

	
	
	private bool wasSpaceBetweenBraces()
	{
		return (nodeText.getTextElement(originalIndex).isToken(100) && doWeHaveLeftBraceFollowedBySpace(originalIndex - 1) && (diffIndex < 2 || !((DifferenceElement)diffElements.get(diffIndex - 2)).isRemoved())) ? true : false;
	}

	
	
	
	private string tokenDescription(int kind)
	{
		return GeneratedJavaParserConstants.tokenImage[kind];
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("Difference{").append(diffElements).append('}')
			.ToString();
		
		return result;
	}
}
