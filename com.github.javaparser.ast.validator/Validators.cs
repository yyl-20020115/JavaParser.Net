using System.ComponentModel;


using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.validator;


public class Validators: Validator, TypedValidator, BiConsumer
{
	
	private sealed class ___003C_003EAnon0 : Consumer
	{
		private readonly Node arg_00241;

		private readonly ProblemReporter arg_00242;

		internal ___003C_003EAnon0(Node P_0, ProblemReporter P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			lambda_0024accept_00240(arg_00241, arg_00242, (Validator)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
		private List validators;

	
	
	
	public virtual Validators remove(Validator validator)
	{
		if (!validators.remove(validator))
		{
			
			throw new AssertionError("Trying to remove a validator that isn't there.");
		}
		return this;
	}

	
	
	
	public virtual Validators add(Validator newValidator)
	{
		validators.add(newValidator);
		return this;
	}

	
	
	
	public virtual void accept(Node node, ProblemReporter problemReporter)
	{
		validators.forEach(new ___003C_003EAnon0(node, problemReporter));
	}

	
	
	
	
	private static void lambda_0024accept_00240(Node node, ProblemReporter problemReporter, Validator v)
	{
		v.accept(node, problemReporter);
	}

	
	
	
	public Validators(params Validator[] validators)
	{
		this.validators = new ArrayList();
		this.validators.addAll(Arrays.asList(validators));
	}

		public virtual List getValidators()
	{
		return validators;
	}

	
	
	
	public virtual Validators replace(Validator oldValidator, Validator newValidator)
	{
		remove(oldValidator);
		add(newValidator);
		return this;
	}

	
	
	
	
	
	public virtual void accept(object node, object problemReporter)
	{
		accept((Node)node, (ProblemReporter)problemReporter);
	}


	public virtual BiConsumer andThen(BiConsumer P_0)
	{
		return BiConsumer._003Cdefault_003EandThen(this, P_0);
	}


	public virtual Processor processor()
	{
		return TypedValidator._003Cdefault_003Eprocessor(this);
	}
}
