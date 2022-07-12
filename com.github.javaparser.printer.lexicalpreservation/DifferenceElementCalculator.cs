
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.type;
using com.github.javaparser.printer.concretesyntaxmodel;

using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.printer.lexicalpreservation;

[NonNestedInnerClass("com.github.javaparser.printer.lexicalpreservation.DifferenceElementCalculator$ChildPositionInfo")]
internal class DifferenceElementCalculator
{
	
	private sealed class ___003C_003EAnon0 : Predicate
	{
		private readonly DifferenceElementCalculator_0024ChildPositionInfo arg_00241;

		internal ___003C_003EAnon0(DifferenceElementCalculator_0024ChildPositionInfo P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024calculate_00240(arg_00241, (DifferenceElementCalculator_0024ChildPositionInfo)P_0);
			
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

	
	private sealed class ___003C_003EAnon1 : Function
	{
		internal ___003C_003EAnon1()
		{
		}

		public object apply(object P_0)
		{
			Integer result = lambda_0024calculate_00241((DifferenceElementCalculator_0024ChildPositionInfo)P_0);
			
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

	
	private sealed class ___003C_003EAnon2 : Predicate
	{
		private readonly DifferenceElementCalculator_0024ChildPositionInfo arg_00241;

		internal ___003C_003EAnon2(DifferenceElementCalculator_0024ChildPositionInfo P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024calculate_00242(arg_00241, (DifferenceElementCalculator_0024ChildPositionInfo)P_0);
			
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

	
	private sealed class ___003C_003EAnon3 : Function
	{
		internal ___003C_003EAnon3()
		{
		}

		public object apply(object P_0)
		{
			Integer result = lambda_0024calculate_00243((DifferenceElementCalculator_0024ChildPositionInfo)P_0);
			
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

	
	private sealed class ___003C_003EAnon4 : Consumer
	{
		private readonly List arg_00241;

		internal ___003C_003EAnon4(List P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			lambda_0024calculateImpl_00244(arg_00241, (CsmElement)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon5 : Predicate
	{
		internal ___003C_003EAnon5()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024cost_00245((DifferenceElement)P_0);
			
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
			bool result = lambda_0024removeIndentationElements_00246((DifferenceElement)P_0);
			
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

	
	
	
	internal static bool matching(CsmElement a, CsmElement b)
	{
		if (a is LexicalDifferenceCalculator.CsmChild)
		{
			if (b is LexicalDifferenceCalculator.CsmChild)
			{
				LexicalDifferenceCalculator.CsmChild csmChild = (LexicalDifferenceCalculator.CsmChild)a;
				LexicalDifferenceCalculator.CsmChild csmChild2 = (LexicalDifferenceCalculator.CsmChild)b;
				bool result = csmChild.getChild().equals(csmChild2.getChild());
				
				return result;
			}
			if (b is CsmToken)
			{
				return false;
			}
			if (b is CsmIndent)
			{
				return false;
			}
			if (b is CsmUnindent)
			{
				return false;
			}
			string message = new StringBuilder().append(Object.instancehelper_getClass(a).getSimpleName()).append(" ").append(Object.instancehelper_getClass(b).getSimpleName())
				.ToString();
			
			throw new UnsupportedOperationException(message);
		}
		if (a is CsmToken)
		{
			if (b is CsmToken)
			{
				CsmToken csmToken = (CsmToken)a;
				CsmToken o = (CsmToken)b;
				bool result2 = csmToken.equals(o);
				
				return result2;
			}
			if (b is LexicalDifferenceCalculator.CsmChild)
			{
				return false;
			}
			if (b is CsmIndent)
			{
				return false;
			}
			if (b is CsmUnindent)
			{
				return false;
			}
			string message2 = new StringBuilder().append(Object.instancehelper_getClass(a).getSimpleName()).append(" ").append(Object.instancehelper_getClass(b).getSimpleName())
				.ToString();
			
			throw new UnsupportedOperationException(message2);
		}
		if (a is CsmIndent)
		{
			return b is CsmIndent;
		}
		if (a is CsmUnindent)
		{
			return b is CsmUnindent;
		}
		string message3 = new StringBuilder().append(Object.instancehelper_getClass(a).getSimpleName()).append(" ").append(Object.instancehelper_getClass(b).getSimpleName())
			.ToString();
		
		throw new UnsupportedOperationException(message3);
	}

	
		
	
	private static List findChildrenPositions(LexicalDifferenceCalculator.CalculatedSyntaxModel calculatedSyntaxModel)
	{
		ArrayList arrayList = new ArrayList();
		for (int i = 0; i < calculatedSyntaxModel.elements.size(); i++)
		{
			CsmElement csmElement = (CsmElement)calculatedSyntaxModel.elements.get(i);
			if (csmElement is LexicalDifferenceCalculator.CsmChild)
			{
				((List)arrayList).add((object)new DifferenceElementCalculator_0024ChildPositionInfo(((LexicalDifferenceCalculator.CsmChild)csmElement).getChild(), Integer.valueOf(i)));
			}
		}
		return arrayList;
	}

	
		
	
	private static List calculateImpl(LexicalDifferenceCalculator.CalculatedSyntaxModel original, LexicalDifferenceCalculator.CalculatedSyntaxModel after)
	{
		LinkedList linkedList = new LinkedList();
		int num = 0;
		int num2 = 0;
		do
		{
			CsmElement removedElement;
			if (num < original.elements.size() && num2 >= after.elements.size())
			{
				removedElement = (CsmElement)original.elements.get(num);
				num = considerRemoval(removedElement, num, linkedList);
				continue;
			}
			if (num >= original.elements.size() && num2 < after.elements.size())
			{
				((List)linkedList).add((object)new Added((CsmElement)after.elements.get(num2)));
				num2++;
				continue;
			}
			removedElement = (CsmElement)original.elements.get(num);
			CsmElement csmElement = (CsmElement)after.elements.get(num2);
			if (removedElement is CsmMix && csmElement is CsmMix)
			{
				if (((CsmMix)csmElement).getElements().equals(((CsmMix)removedElement).getElements()))
				{
					((CsmMix)csmElement).getElements().forEach(new ___003C_003EAnon4(linkedList));
				}
				else
				{
					((List)linkedList).add((object)new Reshuffled((CsmMix)removedElement, (CsmMix)csmElement));
				}
				num++;
				num2++;
				continue;
			}
			if (matching(removedElement, csmElement))
			{
				((List)linkedList).add((object)new Kept(removedElement));
				num++;
				num2++;
				continue;
			}
			if (replacement(removedElement, csmElement))
			{
				num = considerRemoval(removedElement, num, linkedList);
				((List)linkedList).add((object)new Added(csmElement));
				num2++;
				continue;
			}
			List elements = calculate(original.from(num), after.from(num2 + 1));
			List list = null;
			if (cost(elements) > 0)
			{
				list = calculate(original.from(num + 1), after.from(num2));
			}
			if (list == null || cost(list) > cost(elements))
			{
				((List)linkedList).add((object)new Added(csmElement));
				num2++;
			}
			else
			{
				((List)linkedList).add((object)new Removed(removedElement));
				num++;
			}
		}
		while (num < original.elements.size() || num2 < after.elements.size());
		return linkedList;
	}

	
		
	
	private static void considerRemoval(NodeText nodeTextForChild, List elements)
	{
		Iterator iterator = nodeTextForChild.getElements().iterator();
		while (iterator.hasNext())
		{
			TextElement textElement = (TextElement)iterator.next();
			if (textElement is ChildTextElement)
			{
				ChildTextElement childTextElement = (ChildTextElement)textElement;
				considerRemoval(LexicalPreservingPrinter.getOrCreateNodeText(childTextElement.getChild()), elements);
				continue;
			}
			if (textElement is TokenTextElement)
			{
				TokenTextElement tokenTextElement = (TokenTextElement)textElement;
				elements.add(new Removed(new CsmToken(tokenTextElement.getTokenKind(), tokenTextElement.getText())));
				continue;
			}
			string message = Object.instancehelper_toString(textElement);
			
			throw new UnsupportedOperationException(message);
		}
	}

	
		
	
	private static int considerRemoval(CsmElement removedElement, int originalIndex, List elements)
	{
		int num = 0;
		if (removedElement is LexicalDifferenceCalculator.CsmChild)
		{
			LexicalDifferenceCalculator.CsmChild csmChild = (LexicalDifferenceCalculator.CsmChild)removedElement;
			if (csmChild.getChild() is Type && csmChild.getChild().getParentNode().isPresent() && csmChild.getChild().getParentNode().get() is VariableDeclarator)
			{
				NodeText orCreateNodeText = LexicalPreservingPrinter.getOrCreateNodeText(csmChild.getChild());
				considerRemoval(orCreateNodeText, elements);
				originalIndex++;
				num = 1;
			}
		}
		if (num == 0)
		{
			elements.add(new Removed(removedElement));
			originalIndex++;
		}
		return originalIndex;
	}

	
	
	
	private static bool replacement(CsmElement a, CsmElement b)
	{
		if (a is CsmIndent || b is CsmIndent || a is CsmUnindent || b is CsmUnindent)
		{
			return false;
		}
		if (a is LexicalDifferenceCalculator.CsmChild)
		{
			if (b is LexicalDifferenceCalculator.CsmChild)
			{
				LexicalDifferenceCalculator.CsmChild csmChild = (LexicalDifferenceCalculator.CsmChild)a;
				LexicalDifferenceCalculator.CsmChild csmChild2 = (LexicalDifferenceCalculator.CsmChild)b;
				bool result = Object.instancehelper_equals(Object.instancehelper_getClass(csmChild.getChild()), Object.instancehelper_getClass(csmChild2.getChild()));
				
				return result;
			}
			if (b is CsmToken)
			{
				return false;
			}
			string message = new StringBuilder().append(Object.instancehelper_getClass(a).getSimpleName()).append(" ").append(Object.instancehelper_getClass(b).getSimpleName())
				.ToString();
			
			throw new UnsupportedOperationException(message);
		}
		if (a is CsmToken)
		{
			if (b is CsmToken)
			{
				CsmToken csmToken = (CsmToken)a;
				CsmToken csmToken2 = (CsmToken)b;
				return csmToken.getTokenType() == csmToken2.getTokenType();
			}
			if (b is LexicalDifferenceCalculator.CsmChild)
			{
				return false;
			}
		}
		string message2 = new StringBuilder().append(Object.instancehelper_getClass(a).getSimpleName()).append(" ").append(Object.instancehelper_getClass(b).getSimpleName())
			.ToString();
		
		throw new UnsupportedOperationException(message2);
	}

	
		
	
	internal static List calculate(LexicalDifferenceCalculator.CalculatedSyntaxModel original, LexicalDifferenceCalculator.CalculatedSyntaxModel after)
	{
		List list = findChildrenPositions(original);
		List list2 = findChildrenPositions(after);
		ArrayList arrayList = new ArrayList(list);
		((List)arrayList).retainAll((Collection)list2);
		LinkedList linkedList = new LinkedList();
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		while (num3 < ((List)arrayList).size())
		{
			int index = num3;
			num3++;
			DifferenceElementCalculator_0024ChildPositionInfo differenceElementCalculator_0024ChildPositionInfo = (DifferenceElementCalculator_0024ChildPositionInfo)((List)arrayList).get(index);
			int num4 = ((Integer)list.stream().filter(new ___003C_003EAnon0(differenceElementCalculator_0024ChildPositionInfo)).map(new ___003C_003EAnon1())
				.findFirst()
				.get()).intValue();
			int num5 = ((Integer)list2.stream().filter(new ___003C_003EAnon2(differenceElementCalculator_0024ChildPositionInfo)).map(new ___003C_003EAnon3())
				.findFirst()
				.get()).intValue();
			if (num < num4 || num2 < num5)
			{
				((List)linkedList).addAll((Collection)calculateImpl(original.sub(num, num4), after.sub(num2, num5)));
			}
			((List)linkedList).add((object)new Kept(new LexicalDifferenceCalculator.CsmChild(differenceElementCalculator_0024ChildPositionInfo.node)));
			num = num4 + 1;
			num2 = num5 + 1;
		}
		if (num < original.elements.size() || num2 < after.elements.size())
		{
			((List)linkedList).addAll((Collection)calculateImpl(original.sub(num, original.elements.size()), after.sub(num2, after.elements.size())));
		}
		return linkedList;
	}

	
		
	
	private static long cost(List elements)
	{
		long result = elements.stream().filter(new ___003C_003EAnon5()).count();
		
		return result;
	}

	
	
	
	
	private static bool lambda_0024calculate_00240(DifferenceElementCalculator_0024ChildPositionInfo child, DifferenceElementCalculator_0024ChildPositionInfo i)
	{
		bool result = i.equals(child);
		
		return result;
	}

	
	
	
	private static Integer lambda_0024calculate_00241(DifferenceElementCalculator_0024ChildPositionInfo i)
	{
		return i.position;
	}

	
	
	
	
	private static bool lambda_0024calculate_00242(DifferenceElementCalculator_0024ChildPositionInfo child, DifferenceElementCalculator_0024ChildPositionInfo i)
	{
		bool result = i.equals(child);
		
		return result;
	}

	
	
	
	private static Integer lambda_0024calculate_00243(DifferenceElementCalculator_0024ChildPositionInfo i)
	{
		return i.position;
	}

	
	
	
	
	private static void lambda_0024calculateImpl_00244(List elements, CsmElement el)
	{
		elements.add(new Kept(el));
	}

	
	
	
	private static bool lambda_0024cost_00245(DifferenceElement e)
	{
		return !(e is Kept);
	}

	
	
	
	
	private static bool lambda_0024removeIndentationElements_00246(DifferenceElement el)
	{
		return (el.getElement() is CsmIndent || el.getElement() is CsmUnindent) ? true : false;
	}

	
	
	internal DifferenceElementCalculator()
	{
	}

	
		
	
	internal static void removeIndentationElements(List elements)
	{
		elements.removeIf(new ___003C_003EAnon6());
	}
}
