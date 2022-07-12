

using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.printer.lexicalpreservation;

internal class TextElementIteratorsFactory
{
	
		[EnclosingMethod(null, "reverseIterator", "(Lcom.github.javaparser.printer.lexicalpreservation.NodeText;I)Ljava.util.Iterator;")]
	internal sealed class _1 : SingleElementIterator
	{
		
		internal NodeText val_0024nodeText;

		
		internal int val_0024index;

		
		
		
		internal _1(TokenTextElement element, NodeText val_0024index, int val_0024nodeText)
		{
			this.val_0024nodeText = val_0024index;
			this.val_0024index = val_0024nodeText;
			base._002Ector(element);
		}

		
		
		public override void remove()
		{
			val_0024nodeText.removeElement(val_0024index);
		}
	}

		internal class CascadingIterator: Iterator
	{
				internal interface Provider
		{
						virtual Iterator provide();
		}

		
				private Provider nextProvider;

				private Iterator current;

				private Iterator m_next;

		private bool lastReturnedFromCurrent;

		private bool lastReturnedFromNext;

		
				
		
		public CascadingIterator(Iterator current, Provider nextProvider)
		{
			lastReturnedFromCurrent = false;
			lastReturnedFromNext = false;
			this.nextProvider = nextProvider;
			this.current = current;
		}

		
		
		public virtual bool hasNext()
		{
			if (current.hasNext())
			{
				return true;
			}
			if (this.m_next == null)
			{
				this.m_next = nextProvider.provide();
			}
			bool result = this.m_next.hasNext();
			
			return result;
		}

		
				
		public virtual object next()
		{
			if (current.hasNext())
			{
				lastReturnedFromCurrent = true;
				lastReturnedFromNext = false;
				object result = current.next();
				
				return result;
			}
			if (this.m_next == null)
			{
				this.m_next = nextProvider.provide();
			}
			lastReturnedFromCurrent = false;
			lastReturnedFromNext = true;
			object result2 = this.m_next.next();
			
			return result2;
		}

		
		
		public virtual void remove()
		{
			if (lastReturnedFromCurrent)
			{
				current.remove();
				return;
			}
			if (lastReturnedFromNext)
			{
				this.m_next.remove();
				return;
			}
			
			throw new IllegalArgumentException();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEachRemaining(Consumer P_0)
		{
			Iterator._003Cdefault_003EforEachRemaining(this, P_0);
		}
	}

		internal class ComposedIterator: Iterator
	{
		
				private List elements;

		private int currIndex;

		
				
		
		internal ComposedIterator(List elements)
		{
			this.elements = elements;
			currIndex = 0;
		}

		
		
		public virtual bool hasNext()
		{
			if (currIndex >= elements.size())
			{
				return false;
			}
			if (((Iterator)elements.get(currIndex)).hasNext())
			{
				return true;
			}
			currIndex++;
			bool result = hasNext();
			
			return result;
		}

		
				
		public virtual object next()
		{
			if (!hasNext())
			{
				
				throw new IllegalArgumentException();
			}
			object result = ((Iterator)elements.get(currIndex)).next();
			
			return result;
		}

		
		
		public virtual void remove()
		{
			((Iterator)elements.get(currIndex)).remove();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEachRemaining(Consumer P_0)
		{
			Iterator._003Cdefault_003EforEachRemaining(this, P_0);
		}
	}

		internal class EmptyIterator: Iterator
	{
		
		
		internal EmptyIterator()
		{
		}

		public virtual bool hasNext()
		{
			return false;
		}

		
				
		public virtual object next()
		{
			
			throw new IllegalArgumentException();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void remove()
		{
			Iterator._003Cdefault_003Eremove(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEachRemaining(Consumer P_0)
		{
			Iterator._003Cdefault_003EforEachRemaining(this, P_0);
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
		internal class SingleElementIterator: Iterator
	{
		
				private object element;

		private bool returned;

		
				
		
		internal SingleElementIterator(object element)
		{
			this.element = element;
		}

		public virtual bool hasNext()
		{
			return (!returned) ? true : false;
		}

				public virtual object next()
		{
			returned = true;
			return element;
		}

		public virtual void remove()
		{
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEachRemaining(Consumer P_0)
		{
			Iterator._003Cdefault_003EforEachRemaining(this, P_0);
		}
	}

	
		
	
	public static Iterator partialReverseIterator(NodeText nodeText, int fromIndex)
	{
		LinkedList linkedList = new LinkedList();
		for (int i = fromIndex; i >= 0; i += -1)
		{
			((List)linkedList).add((object)reverseIterator(nodeText, i));
		}
		ComposedIterator result = new ComposedIterator(linkedList);
		
		return result;
	}

	
		
	
	public static Iterator reverseIterator(NodeText nodeText)
	{
		Iterator result = partialReverseIterator(nodeText, nodeText.numberOfElements() - 1);
		
		return result;
	}

	
		
	
	private static Iterator reverseIterator(NodeText nodeText, int index)
	{
		TextElement textElement = nodeText.getTextElement(index);
		if (textElement is TokenTextElement)
		{
			_1 result = new _1((TokenTextElement)textElement, nodeText, index);
			
			return result;
		}
		if (textElement is ChildTextElement)
		{
			ChildTextElement childTextElement = (ChildTextElement)textElement;
			NodeText nodeTextForWrappedNode = childTextElement.getNodeTextForWrappedNode();
			Iterator result2 = reverseIterator(nodeTextForWrappedNode);
			
			return result2;
		}
		
		throw new IllegalArgumentException();
	}

	
	
	internal TextElementIteratorsFactory()
	{
	}
}
