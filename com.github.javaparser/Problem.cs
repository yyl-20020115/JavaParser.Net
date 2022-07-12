using System;

using com.github.javaparser.utils;

using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser;

public class Problem
{
	
	private sealed class ___003C_003EAnon0 : Function
	{
		private readonly Problem arg_00241;

		internal ___003C_003EAnon0(Problem P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			string result = arg_00241.lambda_0024getVerboseMessage_00241((TokenRange)P_0);
			
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
		internal ___003C_003EAnon1()
		{
		}

		public object apply(object P_0)
		{
			Optional result = lambda_0024null_00243((TokenRange)P_0);
			
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
			Optional result = lambda_0024null_00245((TokenRange)P_0);
			
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
			Position result = lambda_0024null_00244((Range)P_0);
			
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
			Position result = lambda_0024null_00242((Range)P_0);
			
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
			string result = lambda_0024null_00240((Range)P_0);
			
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

	
	private sealed class ___003C_003EAnon6 : Comparator
	{
		internal ___003C_003EAnon6()
		{
		}

		public int compare(object P_0, object P_1)
		{
			int result = lambda_0024static_00246((Problem)P_0, (Problem)P_1);
			
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

	
	private string message;

	
	private TokenRange location;

	
	private System.Exception cause;

		public static Comparator PROBLEM_BY_BEGIN_POSITION;

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
	
	
	public Problem(string message, TokenRange location, System.Exception cause)
	{
		Utils.assertNotNull(message);
		this.message = message;
		this.location = location;
		this.cause = cause;
	}

	
	
	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder(getVerboseMessage());
		if (cause != null)
		{
			stringBuilder.append(Utils.___003C_003ESYSTEM_EOL).append("Problem stacktrace : ").append(Utils.___003C_003ESYSTEM_EOL);
			for (int i = 0; i < (nint)Throwable.instancehelper_getStackTrace(cause).LongLength; i++)
			{
				StackTraceElement stackTraceElement = Throwable.instancehelper_getStackTrace(cause)[i];
				stringBuilder.append("  ").append(stackTraceElement.ToString());
				if ((nint)(i + 1) != (nint)Throwable.instancehelper_getStackTrace(cause).LongLength)
				{
					stringBuilder.append(Utils.___003C_003ESYSTEM_EOL);
				}
			}
		}
		string result = stringBuilder.ToString();
		
		return result;
	}

	
	
	public virtual string getVerboseMessage()
	{
		return (string)getLocation().map(new ___003C_003EAnon0(this)).orElse(message);
	}

	
		
	public virtual Optional getLocation()
	{
		Optional result = Optional.ofNullable(location);
		
		return result;
	}

	
	
	
	
	private string lambda_0024getVerboseMessage_00241(TokenRange l)
	{
		string result = new StringBuilder().append((string)l.getBegin().getRange().map(new ___003C_003EAnon5())
			.orElse("(line ?,col ?)")).append(" ").append(message)
			.ToString();
		
		return result;
	}

	
	
	
	
	private static Optional lambda_0024null_00243(TokenRange l)
	{
		Optional result = l.getBegin().getRange().map(new ___003C_003EAnon4());
		
		return result;
	}

	
	
	
	
	private static Optional lambda_0024null_00245(TokenRange l)
	{
		Optional result = l.getBegin().getRange().map(new ___003C_003EAnon3());
		
		return result;
	}

	
	
	
	private static Position lambda_0024null_00244(Range r)
	{
		return r.___003C_003Ebegin;
	}

	
	
	
	private static Position lambda_0024null_00242(Range r)
	{
		return r.___003C_003Ebegin;
	}

	
	
	
	
	private static string lambda_0024null_00240(Range r)
	{
		string result = r.___003C_003Ebegin.ToString();
		
		return result;
	}

	
	
	
	
	private static int lambda_0024static_00246(Problem a, Problem b)
	{
		Optional optional = a.getLocation().flatMap(new ___003C_003EAnon1());
		Optional optional2 = b.getLocation().flatMap(new ___003C_003EAnon2());
		if (optional.isPresent() && optional2.isPresent())
		{
			int result = ((Position)optional.get()).compareTo((Position)optional2.get());
			
			return result;
		}
		if (a.getLocation().isPresent() || b.getLocation().isPresent())
		{
			if (a.getLocation().isPresent())
			{
				return 1;
			}
			return -1;
		}
		return 0;
	}

	public virtual string getMessage()
	{
		return message;
	}

	
		
	public virtual Optional getCause()
	{
		Optional result = Optional.ofNullable(cause);
		
		return result;
	}

	
	static Problem()
	{
		PROBLEM_BY_BEGIN_POSITION = new ___003C_003EAnon6();
	}
}
