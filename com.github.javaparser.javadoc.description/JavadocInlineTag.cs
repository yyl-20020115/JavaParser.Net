using System;

using com.github.javaparser.utils;

using ikvm.@internal;
using java.lang;

namespace com.github.javaparser.javadoc.description;

public class JavadocInlineTag :  JavadocDescriptionElement
{
	
	
		
	public class Type : java.lang.Enum
	{
		
		
		public enum __Enum
		{
			CODE,
			DOC_ROOT,
			INHERIT_DOC,
			LINK,
			LINKPLAIN,
			LITERAL,
			VALUE,
			SYSTEM_PROPERTY,
			UNKNOWN
		}

		
		internal static Type ___003C_003ECODE;

		
		internal static Type ___003C_003EDOC_ROOT;

		
		internal static Type ___003C_003EINHERIT_DOC;

		
		internal static Type ___003C_003ELINK;

		
		internal static Type ___003C_003ELINKPLAIN;

		
		internal static Type ___003C_003ELITERAL;

		
		internal static Type ___003C_003EVALUE;

		
		internal static Type ___003C_003ESYSTEM_PROPERTY;

		
		internal static Type ___003C_003EUNKNOWN;

		private string keyword;

		
		private static Type[] _0024VALUES;

		
		public static Type CODE
		{
			
			get
			{
				return ___003C_003ECODE;
			}
		}

		
		public static Type DOC_ROOT
		{
			
			get
			{
				return ___003C_003EDOC_ROOT;
			}
		}

		
		public static Type INHERIT_DOC
		{
			
			get
			{
				return ___003C_003EINHERIT_DOC;
			}
		}

		
		public static Type LINK
		{
			
			get
			{
				return ___003C_003ELINK;
			}
		}

		
		public static Type LINKPLAIN
		{
			
			get
			{
				return ___003C_003ELINKPLAIN;
			}
		}

		
		public static Type LITERAL
		{
			
			get
			{
				return ___003C_003ELITERAL;
			}
		}

		
		public static Type VALUE
		{
			
			get
			{
				return ___003C_003EVALUE;
			}
		}

		
		public static Type SYSTEM_PROPERTY
		{
			
			get
			{
				return ___003C_003ESYSTEM_PROPERTY;
			}
		}

		
		public static Type UNKNOWN
		{
			
			get
			{
				return ___003C_003EUNKNOWN;
			}
		}

		
		
		public static void ___003Cclinit_003E()
		{
		}

		
		
		public static Type[] values()
		{
			return (Type[])_0024VALUES.Clone();
		}

		
				
		
		private Type(string _0024enum_0024name, int _0024enum_0024ordinal)
			: base(_0024enum_0024name, _0024enum_0024ordinal)
		{
			keyword = Utils.screamingToCamelCase(name());
			GC.KeepAlive(this);
		}

		
		
		
		public static Type valueOf(string name)
		{
			return (Type)java.lang.Enum.valueOf(ClassLiteral<Type>.Value, name);
		}

		
		
		
		internal static Type fromName(string tagName)
		{
			Type[] array = values();
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				Type type = array[i];
				if (java.lang.String.instancehelper_equals(type.keyword, tagName))
				{
					return type;
				}
			}
			return ___003C_003EUNKNOWN;
		}

		
		static Type()
		{
			___003C_003ECODE = new Type("CODE", 0);
			___003C_003EDOC_ROOT = new Type("DOC_ROOT", 1);
			___003C_003EINHERIT_DOC = new Type("INHERIT_DOC", 2);
			___003C_003ELINK = new Type("LINK", 3);
			___003C_003ELINKPLAIN = new Type("LINKPLAIN", 4);
			___003C_003ELITERAL = new Type("LITERAL", 5);
			___003C_003EVALUE = new Type("VALUE", 6);
			___003C_003ESYSTEM_PROPERTY = new Type("SYSTEM_PROPERTY", 7);
			___003C_003EUNKNOWN = new Type("UNKNOWN", 8);
			_0024VALUES = new Type[9] { ___003C_003ECODE, ___003C_003EDOC_ROOT, ___003C_003EINHERIT_DOC, ___003C_003ELINK, ___003C_003ELINKPLAIN, ___003C_003ELITERAL, ___003C_003EVALUE, ___003C_003ESYSTEM_PROPERTY, ___003C_003EUNKNOWN };
		}
	}

	private string tagName;

	private Type type;

	private string content;

	
	
	
	public static JavadocDescriptionElement fromText(string text)
	{
		if (!java.lang.String.instancehelper_startsWith(text, "{@"))
		{
			string s = java.lang.String.format("Expected to start with '{@'. Text '%s'", text);
			
			throw new IllegalArgumentException(s);
		}
		if (!java.lang.String.instancehelper_endsWith(text, "}"))
		{
			string s2 = java.lang.String.format("Expected to end with '}'. Text '%s'", text);
			
			throw new IllegalArgumentException(s2);
		}
		text = java.lang.String.instancehelper_substring(text, 2, java.lang.String.instancehelper_length(text) - 1);
		string @this = Utils.nextWord(text);
		Type type = Type.fromName(@this);
		string text2 = java.lang.String.instancehelper_substring(text, java.lang.String.instancehelper_length(@this));
		JavadocInlineTag result = new JavadocInlineTag(@this, type, text2);
		
		return result;
	}

	
	
	
	public JavadocInlineTag(string tagName, Type type, string content)
	{
		this.tagName = tagName;
		this.type = type;
		this.content = content;
	}

	public virtual Type getType()
	{
		return type;
	}

	public virtual string getContent()
	{
		return content;
	}

	public virtual string getName()
	{
		return tagName;
	}

	
	
	public virtual string toText()
	{
		string result = new StringBuilder().append("{@").append(tagName).append(content)
			.append("}")
			.ToString();
		
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
		JavadocInlineTag javadocInlineTag = (JavadocInlineTag)o;
		if (tagName != null)
		{
			if (!java.lang.String.instancehelper_equals(tagName, javadocInlineTag.tagName))
			{
				goto IL_0045;
			}
		}
		else if (javadocInlineTag.tagName != null)
		{
			goto IL_0045;
		}
		if (type != javadocInlineTag.type)
		{
			return false;
		}
		return (content != null) ? java.lang.String.instancehelper_equals(content, javadocInlineTag.content) : (javadocInlineTag.content == null);
		IL_0045:
		return false;
	}

	
	
	public override int GetHashCode()
	{
		int num = ((tagName != null) ? java.lang.String.instancehelper_hashCode(tagName) : 0);
		num = 31 * num + ((type != null) ? type.GetHashCode() : 0);
		return 31 * num + ((content != null) ? java.lang.String.instancehelper_hashCode(content) : 0);
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("JavadocInlineTag{tagName='").append(tagName).append('\'')
			.append(", type=")
			.append(type)
			.append(", content='")
			.append(content)
			.append('\'')
			.append('}')
			.ToString();
		
		return result;
	}
}
