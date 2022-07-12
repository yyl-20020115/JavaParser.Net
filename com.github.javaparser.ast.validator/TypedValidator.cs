using System.ComponentModel;


using java.util.function;

namespace com.github.javaparser.ast.validator;


public interface TypedValidator : BiConsumer
{
	
	[EnclosingMethod(null, "processor", "()Lcom.github.javaparser.Processor;")]
	internal class _1 : Processor
	{
		
		private sealed class ___003C_003EAnon0 : Consumer
		{
			private readonly _1 arg_00241;

			private readonly ParseResult arg_00242;

			internal ___003C_003EAnon0(_1 P_0, ParseResult P_1)
			{
				arg_00241 = P_0;
				arg_00242 = P_1;
			}

			public void accept(object P_0)
			{
				arg_00241.lambda_0024postProcess_00241(arg_00242, (Node)P_0);
				
			}

			
			public Consumer andThen(Consumer P_0)
			{
				return Consumer._003Cdefault_003EandThen(this, P_0);
			}
		}

		
		private sealed class ___003C_003EAnon1 : Consumer
		{
			private readonly ParseResult arg_00241;

			internal ___003C_003EAnon1(ParseResult P_0)
			{
				arg_00241 = P_0;
			}

			public void accept(object P_0)
			{
				lambda_0024null_00240(arg_00241, (Problem)P_0);
				
			}

			
			public Consumer andThen(Consumer P_0)
			{
				return Consumer._003Cdefault_003EandThen(this, P_0);
			}
		}

		
		internal TypedValidator this_00240;

		
		
		
		internal _1(TypedValidator this_00240)
		{
			this.this_00240 = this_00240;
			base._002Ector();
		}

		
		
		
		
		private void lambda_0024postProcess_00241(ParseResult result, Node node)
		{
			this_00240.accept(node, new ProblemReporter(new ___003C_003EAnon1(result)));
		}

		
		
		
		
		private static void lambda_0024null_00240(ParseResult result, Problem problem)
		{
			result.getProblems().add(problem);
		}

		
				
		
		public override void postProcess(ParseResult result, ParserConfiguration configuration)
		{
			result.getResult().ifPresent(new ___003C_003EAnon0(this, result));
		}
	}

	
	public new static class __DefaultMethods
	{
		public unsafe static Processor processor(TypedValidator P_0)
		{
			
			return _003Cdefault_003Eprocessor(P_0);
		}

		public unsafe static void accept(TypedValidator P_0, object P_1, object P_2)
		{
			
			_003Cdefault_003Eaccept(P_0, P_1, P_2);
		}
	}

		
	virtual void accept(Node node, ProblemReporter problemReporter);

	
	virtual Processor processor();

	
	
	
	static Processor _003Cdefault_003Eprocessor(TypedValidator P_0)
	{
		_1 result = new _1(P_0);
		
		return result;
	}

	
	
	
	void accept(object node, object problemReporter);

	
	
	
	static void _003Cdefault_003Eaccept(TypedValidator P_0, object P_1, object P_2)
	{
		P_0.accept((Node)P_1, (ProblemReporter)P_2);
	}
}
