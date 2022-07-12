
using com.github.javaparser.ast.type;

using ikvm.@internal;
using java.lang;
using java.util.function;

namespace com.github.javaparser.ast.validator.postprocessors;

public class Java10PostProcessor : PostProcessors
{
	
	
	internal class _1 : Processor
	{
		
		private sealed class ___003C_003EAnon0 : Consumer
		{
			internal ___003C_003EAnon0()
			{
			}

			public void accept(object P_0)
			{
				lambda_0024postProcess_00241((Node)P_0);
				
			}

			
			public Consumer andThen(Consumer P_0)
			{
				return Consumer._003Cdefault_003EandThen(this, P_0);
			}
		}

		
		private sealed class ___003C_003EAnon1 : Consumer
		{
			internal ___003C_003EAnon1()
			{
			}

			public void accept(object P_0)
			{
				lambda_0024null_00240((ClassOrInterfaceType)P_0);
				
			}

			
			public Consumer andThen(Consumer P_0)
			{
				return Consumer._003Cdefault_003EandThen(this, P_0);
			}
		}

		
		internal Java10PostProcessor this_00240;

		
		
		
		
		private static void lambda_0024postProcess_00241(Node node)
		{
			node.findAll(ClassLiteral<ClassOrInterfaceType>.Value).forEach(new ___003C_003EAnon1());
		}

		
		
		
		
		private static void lambda_0024null_00240(ClassOrInterfaceType n)
		{
			if (String.instancehelper_equals(n.getNameAsString(), "var"))
			{
				VarType.___003Cclinit_003E();
				n.replace(new VarType((TokenRange)n.getTokenRange().orElse(null)));
			}
		}

		
		
		
		internal _1(Java10PostProcessor this_00240)
		{
			this.this_00240 = this_00240;
			
		}

		
				
		
		public override void postProcess(ParseResult result, ParserConfiguration configuration)
		{
			result.getResult().ifPresent(new ___003C_003EAnon0());
		}
	}

	internal Processor ___003C_003EvarNodeCreator;

	
	protected internal Processor varNodeCreator
	{
		
		get
		{
			return ___003C_003EvarNodeCreator;
		}
		
		private set
		{
			___003C_003EvarNodeCreator = value;
		}
	}

	
	
	public Java10PostProcessor()
	{
		___003C_003EvarNodeCreator = new _1(this);
		add(___003C_003EvarNodeCreator);
	}
}
