using System.Runtime.CompilerServices;
using com.github.javaparser.ast.comments;
using com.github.javaparser.javadoc.description;
using com.github.javaparser.utils;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.javadoc;

public class Javadoc
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
			lambda_0024toText_00240(arg_00241, (JavadocBlockTag)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	private JavadocDescription description;

		private List blockTags;

	
	
	[LineNumberTable(new byte[]
	{
		59, 116, 104, 16, 230, 69, 103, 109, 104, 108,
		127, 2, 105, 109, 106, 237, 60, 232, 71, 105,
		109
	})]
	public virtual JavadocComment toComment(string indentation)
	{
		char[] array = String.instancehelper_toCharArray(indentation);
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			int ch = array[i];
			if (!Character.isWhitespace((char)ch))
			{
				
				throw new IllegalArgumentException("The indentation string should be composed only by whitespace characters");
			}
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.append(Utils.___003C_003ESYSTEM_EOL);
		string @this = toText();
		if (!String.instancehelper_isEmpty(@this))
		{
			string[] array2 = String.instancehelper_split(@this, Utils.___003C_003ESYSTEM_EOL);
			int ch = array2.Length;
			for (int j = 0; j < ch; j++)
			{
				string str = array2[j];
				stringBuilder.append(indentation);
				stringBuilder.append(" * ");
				stringBuilder.append(str);
				stringBuilder.append(Utils.___003C_003ESYSTEM_EOL);
			}
		}
		stringBuilder.append(indentation);
		stringBuilder.append(" ");
		JavadocComment.___003Cclinit_003E();
		JavadocComment result = new JavadocComment(stringBuilder.ToString());
		
		return result;
	}

	
	
	public virtual JavadocComment toComment()
	{
		JavadocComment result = toComment("");
		
		return result;
	}

	
	
	
	public virtual Javadoc addBlockTag(JavadocBlockTag blockTag)
	{
		blockTags.add(blockTag);
		return this;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual Javadoc addBlockTag(string tagName, string content)
	{
		Javadoc result = addBlockTag(new JavadocBlockTag(tagName, content));
		
		return result;
	}

	
	
	public virtual string toText()
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (!description.isEmpty())
		{
			stringBuilder.append(description.toText());
			stringBuilder.append(Utils.___003C_003ESYSTEM_EOL);
		}
		if (!blockTags.isEmpty())
		{
			stringBuilder.append(Utils.___003C_003ESYSTEM_EOL);
		}
		blockTags.forEach(new ___003C_003EAnon0(stringBuilder));
		string result = stringBuilder.ToString();
		
		return result;
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private static void lambda_0024toText_00240(StringBuilder sb, JavadocBlockTag bt)
	{
		sb.append(bt.toText());
		sb.append(Utils.___003C_003ESYSTEM_EOL);
	}

	
	
	
	public Javadoc(JavadocDescription description)
	{
		this.description = description;
		blockTags = new LinkedList();
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual Javadoc addBlockTag(string tagName, string parameter, string content)
	{
		Javadoc result = addBlockTag(tagName, new StringBuilder().append(parameter).append(" ").append(content)
			.ToString());
		
		return result;
	}

	
	
	
	public virtual Javadoc addBlockTag(string tagName)
	{
		Javadoc result = addBlockTag(tagName, "");
		
		return result;
	}

	public virtual JavadocDescription getDescription()
	{
		return description;
	}

		public virtual List getBlockTags()
	{
		return blockTags;
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
		Javadoc javadoc = (Javadoc)o;
		return (description.equals(javadoc.description) && blockTags.equals(javadoc.blockTags)) ? true : false;
	}

	
	
	public override int GetHashCode()
	{
		int num = description.GetHashCode();
		return 31 * num + blockTags.GetHashCode();
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("Javadoc{description=").append(description).append(", blockTags=")
			.append(blockTags)
			.append('}')
			.ToString();
		
		return result;
	}
}
