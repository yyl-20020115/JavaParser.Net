using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.printer.concretesyntaxmodel;

public class CsmSequence : CsmElement
{
	
	private sealed class ___003C_003EAnon0 : Predicate
	{
		internal ___003C_003EAnon0()
		{
		}

		public bool test(object P_0)
		{
			bool result = Objects.isNull((CsmElement)P_0);
			
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

	
	private sealed class ___003C_003EAnon1 : Consumer
	{
		private readonly Node arg_00241;

		private readonly SourcePrinter arg_00242;

		internal ___003C_003EAnon1(Node P_0, SourcePrinter P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			lambda_0024prettyPrint_00240(arg_00241, arg_00242, (CsmElement)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon2 : Function
	{
		internal ___003C_003EAnon2()
		{
		}

		public object apply(object P_0)
		{
			string result = lambda_0024toString_00241((CsmElement)P_0);
			
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

		private List elements;

	
		
	
	public CsmSequence(List elements)
	{
		if (elements == null)
		{
			
			throw new NullPointerException();
		}
		if (elements.stream().anyMatch(new ___003C_003EAnon0()))
		{
			
			throw new IllegalArgumentException("Null element in the sequence");
		}
		this.elements = elements;
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private static void lambda_0024prettyPrint_00240(Node node, SourcePrinter printer, CsmElement e)
	{
		e.prettyPrint(node, printer);
	}

	
	
	
	
	private static string lambda_0024toString_00241(CsmElement e)
	{
		string result = Object.instancehelper_toString(e);
		
		return result;
	}

		public virtual List getElements()
	{
		return elements;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual void prettyPrint(Node node, SourcePrinter printer)
	{
		elements.forEach(new ___003C_003EAnon1(node, printer));
	}

	
	
	public override string ToString()
	{
		Stream stream = elements.stream().map(new ___003C_003EAnon2());
		object __003Cref_003E = "]";
		object __003Cref_003E2 = "CsmSequence[";
		CharSequence charSequence = default(CharSequence);
		object obj = (charSequence.___003Cref_003E = ",");
		CharSequence delimiter = charSequence;
		obj = (charSequence.___003Cref_003E = __003Cref_003E2);
		CharSequence prefix = charSequence;
		obj = (charSequence.___003Cref_003E = __003Cref_003E);
		return (string)stream.collect(Collectors.joining(delimiter, prefix, charSequence));
	}
}
