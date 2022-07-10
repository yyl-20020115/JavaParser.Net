using System.Runtime.CompilerServices;
using com.github.javaparser.utils;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.javadoc.description;

public class JavadocDescription
{
	
	private sealed class ___003C_003EAnon0 : Consumer
	{
		private readonly StringBuilder arg_00241;

		internal ___003C_003EAnon0(StringBuilder P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			lambda_0024toText_00240(arg_00241, (JavadocDescriptionElement)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

		private List elements;

	
	
	public JavadocDescription()
	{
		elements = new LinkedList();
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	private static Pair indexOfNextInlineTag(string text, int start)
	{
		int num = String.instancehelper_indexOf(text, "{@", start);
		if (num == -1)
		{
			return null;
		}
		int num2 = String.instancehelper_indexOf(text, "}", num);
		if (num2 == -1)
		{
			return null;
		}
		Pair result = new Pair(Integer.valueOf(num), Integer.valueOf(num2));
		
		return result;
	}

	
	
	
	public virtual bool addElement(JavadocDescriptionElement element)
	{
		bool result = elements.add(element);
		
		return result;
	}

	
	
	public virtual string toText()
	{
		StringBuilder stringBuilder = new StringBuilder();
		elements.forEach(new ___003C_003EAnon0(stringBuilder));
		string result = stringBuilder.ToString();
		
		return result;
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private static void lambda_0024toText_00240(StringBuilder sb, JavadocDescriptionElement e)
	{
		sb.append(e.toText());
	}

	
	
	[LineNumberTable(new byte[]
	{
		159, 181, 102, 130, 110, 115, 159, 4, 127, 21,
		152, 105, 147
	})]
	public static JavadocDescription parseText(string text)
	{
		JavadocDescription javadocDescription = new JavadocDescription();
		int num = 0;
		Pair pair;
		while ((pair = indexOfNextInlineTag(text, num)) != null)
		{
			if (((Integer)pair.___003C_003Ea).intValue() != num)
			{
				javadocDescription.addElement(new JavadocSnippet(String.instancehelper_substring(text, num, ((Integer)pair.___003C_003Ea).intValue())));
			}
			javadocDescription.addElement(JavadocInlineTag.fromText(String.instancehelper_substring(text, ((Integer)pair.___003C_003Ea).intValue(), ((Integer)pair.___003C_003Eb).intValue() + 1)));
			num = ((Integer)pair.___003C_003Eb).intValue() + 1;
		}
		if (num < String.instancehelper_length(text))
		{
			javadocDescription.addElement(new JavadocSnippet(String.instancehelper_substring(text, num)));
		}
		return javadocDescription;
	}

	
		
	
	public JavadocDescription(List elements)
		: this()
	{
		this.elements.addAll(elements);
	}

		public virtual List getElements()
	{
		return elements;
	}

	
	
	public virtual bool isEmpty()
	{
		bool result = String.instancehelper_isEmpty(toText());
		
		return result;
	}

	
	
	
	public override bool Equals(object o)
	{
		if (this == o)
		{
			return true;
		}
		if (o == null || ((object)this).GetType() != o.GetType())
		{
			return false;
		}
		JavadocDescription javadocDescription = (JavadocDescription)o;
		bool result = elements.equals(javadocDescription.elements);
		
		return result;
	}

	
	
	public override int GetHashCode()
	{
		int result = elements.GetHashCode();
		
		return result;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("JavadocDescription{elements=").append(elements).append('}')
			.ToString();
		
		return result;
	}
}
