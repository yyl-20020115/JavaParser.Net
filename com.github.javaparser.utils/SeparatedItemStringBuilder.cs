

using java.lang;

namespace com.github.javaparser.utils;

public class SeparatedItemStringBuilder
{
	
	private string separator;

	
	private string postfix;

	private bool m_hasItems;

	private StringBuilder builder;

	
	
	
	public SeparatedItemStringBuilder(string prefix, string separator, string postfix)
	{
		this.m_hasItems = false;
		builder = new StringBuilder(prefix);
		this.separator = separator;
		this.postfix = postfix;
	}

	
	
	
	public virtual SeparatedItemStringBuilder append(CharSequence format, params object[] args)
	{
		CharSequence charSequence = format;
		object __003Cref_003E = charSequence.___003Cref_003E;
		if (this.m_hasItems)
		{
			builder.append(separator);
		}
		StringBuilder stringBuilder = builder;
		CharSequence charSequence2 = default(CharSequence);
		object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
		stringBuilder.append(String.format(charSequence2.ToString(), args));
		this.m_hasItems = true;
		return this;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append(builder.ToString()).append(postfix).ToString();
		
		return result;
	}

	public virtual bool hasItems()
	{
		return this.m_hasItems;
	}
}
