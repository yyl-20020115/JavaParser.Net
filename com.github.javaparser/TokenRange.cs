using System.Collections;

using com.github.javaparser.utils;

using ikvm.lang;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser;


public class TokenRange: Iterable, IEnumerable
{
	
		[EnclosingMethod(null, "iterator", "()Ljava.util.Iterator;")]
	internal class _1: Iterator
	{
		private bool m_hasNext;

		private JavaToken current;

		
		internal TokenRange this_00240;

		
		
		public virtual JavaToken next()
		{
			JavaToken result = current;
			if (current == null)
			{
				
				throw new IllegalStateException("Attempting to move past end of range.");
			}
			if (current == access_0024100(this_00240))
			{
				this.m_hasNext = false;
			}
			current = (JavaToken)current.getNextToken().orElse(null);
			if (current == null && this.m_hasNext)
			{
				
				throw new IllegalStateException("End token is not linked to begin token.");
			}
			return result;
		}

		
		
		
		internal _1(TokenRange this_00240)
		{
			this.this_00240 = this_00240;
			
			this.m_hasNext = true;
			current = access_0024000(this.this_00240);
		}

		public virtual bool hasNext()
		{
			return this.m_hasNext;
		}

		
		
		
		public virtual object next()
		{
			JavaToken result = this.next();
			
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

	internal static TokenRange ___003C_003EINVALID;

	
	private JavaToken begin;

	
	private JavaToken end;

	
	public static TokenRange INVALID
	{
		
		get
		{
			return ___003C_003EINVALID;
		}
	}

	
	
	public static void ___003Cclinit_003E()
	{
	}

	public virtual JavaToken getBegin()
	{
		return begin;
	}

	public virtual JavaToken getEnd()
	{
		return end;
	}

	
		
	public virtual Iterator iterator()
	{
		_1 result = new _1(this);
		
		return result;
	}

	
	
	
	public TokenRange(JavaToken begin, JavaToken end)
	{
		this.begin = (JavaToken)Utils.assertNotNull(begin);
		this.end = (JavaToken)Utils.assertNotNull(end);
	}

	
		
	public virtual Optional toRange()
	{
		if (begin.hasRange() && end.hasRange())
		{
			Optional result = Optional.of(new Range(((Range)begin.getRange().get()).___003C_003Ebegin, ((Range)end.getRange().get()).___003C_003Eend));
			
			return result;
		}
		Optional result2 = Optional.empty();
		
		return result2;
	}

	
	
	
	public virtual TokenRange withEnd(JavaToken end)
	{
		TokenRange result = new TokenRange(begin, (JavaToken)Utils.assertNotNull(end));
		
		return result;
	}

	
	
	
	public virtual TokenRange withBegin(JavaToken begin)
	{
		TokenRange result = new TokenRange((JavaToken)Utils.assertNotNull(begin), end);
		
		return result;
	}

	
	
	internal static JavaToken access_0024000(TokenRange P_0)
	{
		return P_0.begin;
	}

	
	
	internal static JavaToken access_0024100(TokenRange P_0)
	{
		return P_0.end;
	}

	
	
	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		Iterator iterator = this.iterator();
		while (iterator.hasNext())
		{
			JavaToken javaToken = (JavaToken)iterator.next();
			stringBuilder.append(javaToken.getText());
		}
		string result = stringBuilder.ToString();
		
		return result;
	}

	
	static TokenRange()
	{
		___003C_003EINVALID = new TokenRange(JavaToken.___003C_003EINVALID, JavaToken.___003C_003EINVALID);
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
