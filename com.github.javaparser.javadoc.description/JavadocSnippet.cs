

using java.lang;

namespace com.github.javaparser.javadoc.description;

public class JavadocSnippet: JavadocDescriptionElement
{
	private string text;

	
	
	
	public JavadocSnippet(string text)
	{
		if (text == null)
		{
			
			throw new NullPointerException();
		}
		this.text = text;
	}

	public virtual string toText()
	{
		return text;
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
		JavadocSnippet javadocSnippet = (JavadocSnippet)o;
		bool result = String.instancehelper_equals(text, javadocSnippet.text);
		
		return result;
	}

	
	
	public override int GetHashCode()
	{
		int result = String.instancehelper_hashCode(text);
		
		return result;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("JavadocSnippet{text='").append(text).append('\'')
			.append('}')
			.ToString();
		
		return result;
	}
}
