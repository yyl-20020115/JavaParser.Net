using System;

using com.github.javaparser.javadoc.description;
using com.github.javaparser.utils;

using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.javadoc;

public class JavadocBlockTag
{
	
	
		
	public class Type : java.lang.Enum
	{
		
		
		public enum __Enum
		{
			AUTHOR,
			DEPRECATED,
			EXCEPTION,
			PARAM,
			RETURN,
			SEE,
			SERIAL,
			SERIAL_DATA,
			SERIAL_FIELD,
			SINCE,
			THROWS,
			VERSION,
			UNKNOWN
		}

		
		internal static Type ___003C_003EAUTHOR;

		
		internal static Type ___003C_003EDEPRECATED;

		
		internal static Type ___003C_003EEXCEPTION;

		
		internal static Type ___003C_003EPARAM;

		
		internal static Type ___003C_003ERETURN;

		
		internal static Type ___003C_003ESEE;

		
		internal static Type ___003C_003ESERIAL;

		
		internal static Type ___003C_003ESERIAL_DATA;

		
		internal static Type ___003C_003ESERIAL_FIELD;

		
		internal static Type ___003C_003ESINCE;

		
		internal static Type ___003C_003ETHROWS;

		
		internal static Type ___003C_003EVERSION;

		
		internal static Type ___003C_003EUNKNOWN;

		private string keyword;

		
		private static Type[] _0024VALUES;

		
		public static Type AUTHOR
		{
			
			get
			{
				return ___003C_003EAUTHOR;
			}
		}

		
		public static Type DEPRECATED
		{
			
			get
			{
				return ___003C_003EDEPRECATED;
			}
		}

		
		public static Type EXCEPTION
		{
			
			get
			{
				return ___003C_003EEXCEPTION;
			}
		}

		
		public static Type PARAM
		{
			
			get
			{
				return ___003C_003EPARAM;
			}
		}

		
		public static Type RETURN
		{
			
			get
			{
				return ___003C_003ERETURN;
			}
		}

		
		public static Type SEE
		{
			
			get
			{
				return ___003C_003ESEE;
			}
		}

		
		public static Type SERIAL
		{
			
			get
			{
				return ___003C_003ESERIAL;
			}
		}

		
		public static Type SERIAL_DATA
		{
			
			get
			{
				return ___003C_003ESERIAL_DATA;
			}
		}

		
		public static Type SERIAL_FIELD
		{
			
			get
			{
				return ___003C_003ESERIAL_FIELD;
			}
		}

		
		public static Type SINCE
		{
			
			get
			{
				return ___003C_003ESINCE;
			}
		}

		
		public static Type THROWS
		{
			
			get
			{
				return ___003C_003ETHROWS;
			}
		}

		
		public static Type VERSION
		{
			
			get
			{
				return ___003C_003EVERSION;
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

		internal virtual bool hasName()
		{
			return (this == ___003C_003EPARAM || this == ___003C_003EEXCEPTION || this == ___003C_003ETHROWS) ? true : false;
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

		
		
		internal static string access_0024000(Type P_0)
		{
			return P_0.keyword;
		}

		
		static Type()
		{
			___003C_003EAUTHOR = new Type("AUTHOR", 0);
			___003C_003EDEPRECATED = new Type("DEPRECATED", 1);
			___003C_003EEXCEPTION = new Type("EXCEPTION", 2);
			___003C_003EPARAM = new Type("PARAM", 3);
			___003C_003ERETURN = new Type("RETURN", 4);
			___003C_003ESEE = new Type("SEE", 5);
			___003C_003ESERIAL = new Type("SERIAL", 6);
			___003C_003ESERIAL_DATA = new Type("SERIAL_DATA", 7);
			___003C_003ESERIAL_FIELD = new Type("SERIAL_FIELD", 8);
			___003C_003ESINCE = new Type("SINCE", 9);
			___003C_003ETHROWS = new Type("THROWS", 10);
			___003C_003EVERSION = new Type("VERSION", 11);
			___003C_003EUNKNOWN = new Type("UNKNOWN", 12);
			_0024VALUES = new Type[13]
			{
				___003C_003EAUTHOR, ___003C_003EDEPRECATED, ___003C_003EEXCEPTION, ___003C_003EPARAM, ___003C_003ERETURN, ___003C_003ESEE, ___003C_003ESERIAL, ___003C_003ESERIAL_DATA, ___003C_003ESERIAL_FIELD, ___003C_003ESINCE,
				___003C_003ETHROWS, ___003C_003EVERSION, ___003C_003EUNKNOWN
			};
		}
	}

	
	private sealed class ___003C_003EAnon0 : Consumer
	{
		private readonly StringBuilder arg_00241;

		internal ___003C_003EAnon0(StringBuilder P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			lambda_0024toText_00240(arg_00241, (string)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	private Type type;

	private JavadocDescription content;

		private Optional name;

	private string tagName;

	
	
	
	public JavadocBlockTag(string tagName, string content)
		: this(Type.fromName(tagName), content)
	{
		this.tagName = tagName;
	}

	
	
	public virtual string toText()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.append("@");
		stringBuilder.append(tagName);
		name.ifPresent(new ___003C_003EAnon0(stringBuilder));
		if (!content.isEmpty())
		{
			stringBuilder.append(" ");
			stringBuilder.append(content.toText());
		}
		string result = stringBuilder.ToString();
		
		return result;
	}

	
	
	
	public JavadocBlockTag(Type type, string content)
	{
		name = Optional.empty();
		this.type = type;
		tagName = Type.access_0024000(type);
		if (type.hasName())
		{
			name = Optional.of(Utils.nextWord(content));
			content = java.lang.String.instancehelper_trim(java.lang.String.instancehelper_substring(content, java.lang.String.instancehelper_length((string)name.get())));
		}
		this.content = JavadocDescription.parseText(content);
	}

	
	
	
	
	private static void lambda_0024toText_00240(StringBuilder sb, string s)
	{
		sb.append(" ").append(s);
	}

	
	
	
	public static JavadocBlockTag createParamBlockTag(string paramName, string content)
	{
		JavadocBlockTag result = new JavadocBlockTag(Type.___003C_003EPARAM, new StringBuilder().append(paramName).append(" ").append(content)
			.ToString());
		
		return result;
	}

	public virtual Type getType()
	{
		return type;
	}

	public virtual JavadocDescription getContent()
	{
		return content;
	}

		public virtual Optional getName()
	{
		return name;
	}

	public virtual string getTagName()
	{
		return tagName;
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
		JavadocBlockTag javadocBlockTag = (JavadocBlockTag)o;
		if (type != javadocBlockTag.type)
		{
			return false;
		}
		if (!content.equals(javadocBlockTag.content))
		{
			return false;
		}
		bool result = name.equals(javadocBlockTag.name);
		
		return result;
	}

	
	
	public override int GetHashCode()
	{
		int num = type.GetHashCode();
		num = 31 * num + content.GetHashCode();
		return 31 * num + name.GetHashCode();
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("JavadocBlockTag{type=").append(type).append(", content='")
			.append(content)
			.append('\'')
			.append(", name=")
			.append(name)
			.append('}')
			.ToString();
		
		return result;
	}
}
