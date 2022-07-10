using System.Collections;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.printer.concretesyntaxmodel;
using IKVM.Attributes;
using ikvm.lang;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.printer.lexicalpreservation;


internal sealed class RemovedGroup: Iterable, IEnumerable
{
	
		[EnclosingMethod(null, "iterator", "()Ljava.util.Iterator;")]
	internal class _1: Iterator
	{
		private int currentIndex;

		
		internal RemovedGroup this_00240;

		
		
		public virtual Removed next()
		{
			List list = access_0024000(this_00240);
			int num = currentIndex;
			currentIndex = num + 1;
			return (Removed)list.get(num);
		}

		
		
		
		internal _1(RemovedGroup this_00240)
		{
			this.this_00240 = this_00240;
			
			currentIndex = 0;
		}

		
		
		public virtual bool hasNext()
		{
			return (currentIndex < access_0024000(this_00240).size() && access_0024000(this_00240).get(currentIndex) != null) ? true : false;
		}

		
		
		
		public virtual object next()
		{
			Removed result = this.next();
			
			return result;
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

	
	private sealed class ___003C_003EAnon0 : Function
	{
		private readonly RemovedGroup arg_00241;

		internal ___003C_003EAnon0(RemovedGroup P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			Boolean result = arg_00241.lambda_0024new_00241((JavaToken)P_0);
			
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

	
	private sealed class ___003C_003EAnon1 : Function
	{
		private readonly RemovedGroup arg_00241;

		internal ___003C_003EAnon1(RemovedGroup P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			Boolean result = arg_00241.lambda_0024new_00243((JavaToken)P_0);
			
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
		private readonly RemovedGroup arg_00241;

		internal ___003C_003EAnon2(RemovedGroup P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			Boolean result = arg_00241.lambda_0024new_00244((TokenRange)P_0);
			
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
		private readonly RemovedGroup arg_00241;

		internal ___003C_003EAnon3(RemovedGroup P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			Boolean result = arg_00241.lambda_0024new_00245((TokenRange)P_0);
			
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

	
	private sealed class ___003C_003EAnon4 : Function
	{
		internal ___003C_003EAnon4()
		{
		}

		public object apply(object P_0)
		{
			Optional result = lambda_0024null_00242((JavaToken)P_0);
			
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
		internal ___003C_003EAnon5()
		{
		}

		public object apply(object P_0)
		{
			Optional result = lambda_0024null_00240((JavaToken)P_0);
			
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

	
	private Integer firstElementIndex;

	
		private List removedList;

	private bool m_isProcessed;

	
		private Function hasOnlyWhitespaceJavaTokenInFrontFunction;

	
		private Function hasOnlyWhitespaceJavaTokenBehindFunction;

	
		private Function hasOnlyWhitespaceInFrontFunction;

	
		private Function hasOnlyWhitespaceBehindFunction;

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public static RemovedGroup of(Integer firstElementIndex, List removedList)
	{
		RemovedGroup result = new RemovedGroup(firstElementIndex, removedList);
		
		return result;
	}

	
		
	public Iterator iterator()
	{
		_1 result = new _1(this);
		
		return result;
	}

	
	
	internal bool isACompleteLine()
	{
		return (hasOnlyWhitespace(getFirstElement(), hasOnlyWhitespaceInFrontFunction) && hasOnlyWhitespace(getLastElement(), hasOnlyWhitespaceBehindFunction)) ? true : false;
	}

	internal bool isProcessed()
	{
		return this.m_isProcessed;
	}

	
	
	internal Removed getLastElement()
	{
		return (Removed)removedList.get(removedList.size() - 1);
	}

	
	
	internal Integer getLastElementIndex()
	{
		List indicesBeingRemoved = getIndicesBeingRemoved();
		return (Integer)indicesBeingRemoved.get(indicesBeingRemoved.size() - 1);
	}

	
		[LineNumberTable(new byte[]
	{
		160, 81, 135, 98, 107, 108, 135, 104, 108, 147,
		124, 137, 127, 2, 132, 181, 105, 120, 142, 168,
		238, 70
	})]
	internal Optional getIndentation()
	{
		Removed firstElement = getFirstElement();
		int num = 0;
		if (firstElement.isChild())
		{
			LexicalDifferenceCalculator.CsmChild csmChild = (LexicalDifferenceCalculator.CsmChild)firstElement.getElement();
			Node child = csmChild.getChild();
			Optional tokenRange = child.getTokenRange();
			if (tokenRange.isPresent())
			{
				JavaToken begin = ((TokenRange)tokenRange.get()).getBegin();
				if (((Boolean)hasOnlyWhitespaceJavaTokenInFrontFunction.apply(begin)).booleanValue())
				{
					Optional previousToken = begin.getPreviousToken();
					while (previousToken.isPresent() && TokenTypes.isWhitespaceButNotEndOfLine(((JavaToken)previousToken.get()).getKind()))
					{
						num++;
						previousToken = ((JavaToken)previousToken.get()).getPreviousToken();
					}
					if (previousToken.isPresent())
					{
						if (TokenTypes.isEndOfLineToken(((JavaToken)previousToken.get()).getKind()))
						{
							Optional result = Optional.of(Integer.valueOf(num));
							
							return result;
						}
						Optional result2 = Optional.empty();
						
						return result2;
					}
					Optional result3 = Optional.of(Integer.valueOf(num));
					
					return result3;
				}
			}
		}
		Optional result4 = Optional.empty();
		
		return result4;
	}

	internal void processed()
	{
		this.m_isProcessed = true;
	}

	
	
	internal static List access_0024000(RemovedGroup P_0)
	{
		return P_0.removedList;
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		5, 8, 231, 160, 95, 113, 113, 113, 241, 159,
		161, 99, 176, 107, 176, 103, 103
	})]
	private RemovedGroup(Integer firstElementIndex, List removedList)
	{
		this.m_isProcessed = false;
		hasOnlyWhitespaceJavaTokenInFrontFunction = new ___003C_003EAnon0(this);
		hasOnlyWhitespaceJavaTokenBehindFunction = new ___003C_003EAnon1(this);
		hasOnlyWhitespaceInFrontFunction = new ___003C_003EAnon2(this);
		hasOnlyWhitespaceBehindFunction = new ___003C_003EAnon3(this);
		if (firstElementIndex == null)
		{
			
			throw new IllegalArgumentException("firstElementIndex should not be null");
		}
		if (removedList == null || removedList.isEmpty())
		{
			
			throw new IllegalArgumentException("removedList should not be null or empty");
		}
		this.firstElementIndex = firstElementIndex;
		this.removedList = removedList;
	}

	
		
	private List getIndicesBeingRemoved()
	{
		return (List)IntStream.range(firstElementIndex.intValue(), firstElementIndex.intValue() + removedList.size()).boxed().collect(Collectors.toList());
	}

	
	
	internal Removed getFirstElement()
	{
		return (Removed)removedList.get(0);
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		104, 98, 104, 108, 135, 103, 104, 151, 106, 109,
		110, 162
	})]
	private bool hasOnlyWhitespace(Removed startElement, Function hasOnlyWhitespaceFunction)
	{
		int result = 0;
		if (startElement.isChild())
		{
			LexicalDifferenceCalculator.CsmChild csmChild = (LexicalDifferenceCalculator.CsmChild)startElement.getElement();
			Node child = csmChild.getChild();
			Optional tokenRange = child.getTokenRange();
			if (tokenRange.isPresent())
			{
				result = (((Boolean)hasOnlyWhitespaceFunction.apply(tokenRange.get())).booleanValue() ? 1 : 0);
			}
		}
		else if (startElement.isToken())
		{
			CsmToken csmToken = (CsmToken)startElement.getElement();
			if (TokenTypes.isEndOfLineToken(csmToken.getTokenType()))
			{
				result = 1;
			}
		}
		return (byte)result != 0;
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	private bool hasOnlyWhiteSpaceForTokenFunction(JavaToken token, Function tokenFunction)
	{
		Optional optional = (Optional)tokenFunction.apply(token);
		if (optional.isPresent())
		{
			if (TokenTypes.isWhitespaceButNotEndOfLine(((JavaToken)optional.get()).getKind()))
			{
				bool result = hasOnlyWhiteSpaceForTokenFunction((JavaToken)optional.get(), tokenFunction);
				
				return result;
			}
			if (TokenTypes.isEndOfLineToken(((JavaToken)optional.get()).getKind()))
			{
				return true;
			}
			return false;
		}
		return true;
	}

	
	
	
	
	private Boolean lambda_0024new_00241(JavaToken begin)
	{
		Boolean result = Boolean.valueOf(hasOnlyWhiteSpaceForTokenFunction(begin, new ___003C_003EAnon5()));
		
		return result;
	}

	
	
	
	
	private Boolean lambda_0024new_00243(JavaToken end)
	{
		Boolean result = Boolean.valueOf(hasOnlyWhiteSpaceForTokenFunction(end, new ___003C_003EAnon4()));
		
		return result;
	}

	
	
	
	
	private Boolean lambda_0024new_00244(TokenRange tokenRange)
	{
		return (Boolean)hasOnlyWhitespaceJavaTokenInFrontFunction.apply(tokenRange.getBegin());
	}

	
	
	
	
	private Boolean lambda_0024new_00245(TokenRange tokenRange)
	{
		return (Boolean)hasOnlyWhitespaceJavaTokenBehindFunction.apply(tokenRange.getEnd());
	}

	
	
	
	
	private static Optional lambda_0024null_00242(JavaToken token)
	{
		Optional nextToken = token.getNextToken();
		
		return nextToken;
	}

	
	
	
	
	private static Optional lambda_0024null_00240(JavaToken token)
	{
		Optional previousToken = token.getPreviousToken();
		
		return previousToken;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual void forEach(Consumer P_0)
	{
		Iterable._003Cdefault_003EforEach(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Spliterator spliterator()
	{
		return Iterable._003Cdefault_003Espliterator(this);
	}

	
	
	IEnumerator IEnumerable.GetEnumerator()
	{
		return new IterableEnumerator(this);
	}
}
