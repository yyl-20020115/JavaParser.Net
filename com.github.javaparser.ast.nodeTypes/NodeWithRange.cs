using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.nodeTypes;

public class NodeWithRange
{
	private static class ___003C_003EPIM
	{
				
		internal static Position lambda_0024getBegin_00240(Range r)
		{
			return r.___003C_003Ebegin;
		}

		
		internal static Position lambda_0024getEnd_00241(Range r)
		{
			return r.___003C_003Eend;
		}
	}

	
	public static class __DefaultMethods
	{
		public unsafe static Optional getBegin(NodeWithRange P_0)
		{
			
			return _003Cdefault_003EgetBegin(P_0);
		}

		public unsafe static Optional getEnd(NodeWithRange P_0)
		{
			
			return _003Cdefault_003EgetEnd(P_0);
		}

		public unsafe static bool containsWithin(NodeWithRange P_0, Node P_1)
		{
			
			return _003Cdefault_003EcontainsWithin(P_0, P_1);
		}

		public unsafe static bool containsWithinRange(NodeWithRange P_0, Node P_1)
		{
			
			return _003Cdefault_003EcontainsWithinRange(P_0, P_1);
		}

		public unsafe static bool hasRange(NodeWithRange P_0)
		{
			
			return _003Cdefault_003EhasRange(P_0);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Function
	{
		internal ___003C_003EAnon1()
		{
		}

		public object apply(object P_0)
		{
			Position result = ___003C_003EPIM.lambda_0024getBegin_00240((Range)P_0);
			
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
			Position result = ___003C_003EPIM.lambda_0024getEnd_00241((Range)P_0);
			
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

		virtual Optional getRange();

	
	
	virtual bool containsWithinRange(Node other);

	
	
	
	static bool _003Cdefault_003EcontainsWithinRange(NodeWithRange P_0, Node P_1)
	{
		if (P_0.hasRange() && P_1.hasRange())
		{
			bool result = ((Range)P_0.getRange().get()).contains((Range)P_1.getRange().get());
			
			return result;
		}
		return false;
	}

	
	virtual bool hasRange();

	
	
	
	static bool _003Cdefault_003EhasRange(NodeWithRange P_0)
	{
		bool result = P_0.getRange().isPresent();
		
		return result;
	}

		
	virtual object setRange(Range range);

	
		virtual Optional getBegin();

	
	
	
	static Optional _003Cdefault_003EgetBegin(NodeWithRange P_0)
	{
		Optional result = P_0.getRange().map(new ___003C_003EAnon1());
		
		return result;
	}

	
		virtual Optional getEnd();

	
	
	
	static Optional _003Cdefault_003EgetEnd(NodeWithRange P_0)
	{
		Optional result = P_0.getRange().map(new ___003C_003EAnon2());
		
		return result;
	}

	
	
	
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	virtual bool containsWithin(Node other);

	
	
	
	static bool _003Cdefault_003EcontainsWithin(NodeWithRange P_0, Node P_1)
	{
		bool result = P_0.containsWithinRange(P_1);
		
		return result;
	}
}
