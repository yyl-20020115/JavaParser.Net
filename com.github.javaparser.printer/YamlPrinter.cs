using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.printer;

public class YamlPrinter
{
	
	private sealed class ___003C_003EAnon0 : Predicate
	{
		internal ___003C_003EAnon0()
		{
		}

		public bool test(object P_0)
		{
			bool result = ((PropertyMetaModel)P_0).isAttribute();
			
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

	
	private sealed class ___003C_003EAnon1 : Predicate
	{
		internal ___003C_003EAnon1()
		{
		}

		public bool test(object P_0)
		{
			bool result = ((PropertyMetaModel)P_0).isSingular();
			
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

	
	private sealed class ___003C_003EAnon2 : Predicate
	{
		internal ___003C_003EAnon2()
		{
		}

		public bool test(object P_0)
		{
			bool result = ((PropertyMetaModel)P_0).isNode();
			
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

	
	private sealed class ___003C_003EAnon3 : Predicate
	{
		internal ___003C_003EAnon3()
		{
		}

		public bool test(object P_0)
		{
			bool result = ((PropertyMetaModel)P_0).isNodeList();
			
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

	private const int NUM_SPACES_FOR_INDENT = 4;

	
	private bool outputNodeType;

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		5, 103, 103, 103, 127, 0, 117, 127, 0, 117,
		117, 145, 104, 159, 48, 159, 25, 101, 127, 0,
		127, 55, 130, 127, 0, 111, 100, 114, 130, 127,
		4, 111, 115, 127, 31, 105, 127, 11, 127, 1,
		159, 11, 101
	})]
	public virtual void output(Node node, string name, int level, StringBuilder builder)
	{
		Utils.assertNotNull(node);
		NodeMetaModel metaModel = node.getMetaModel();
		List allPropertyMetaModels = metaModel.getAllPropertyMetaModels();
		List list = (List)allPropertyMetaModels.stream().filter(new ___003C_003EAnon0()).filter(new ___003C_003EAnon1())
			.collect(Collectors.toList());
		List list2 = (List)allPropertyMetaModels.stream().filter(new ___003C_003EAnon2()).filter(new ___003C_003EAnon1())
			.collect(Collectors.toList());
		List list3 = (List)allPropertyMetaModels.stream().filter(new ___003C_003EAnon3()).collect(Collectors.toList());
		if (outputNodeType)
		{
			builder.append(new StringBuilder().append(java.lang.System.lineSeparator()).append(indent(level)).append(name)
				.append("(Type=")
				.append(metaModel.getTypeName())
				.append("): ")
				.ToString());
		}
		else
		{
			builder.append(new StringBuilder().append(java.lang.System.lineSeparator()).append(indent(level)).append(name)
				.append(": ")
				.ToString());
		}
		level++;
		Iterator iterator = list.iterator();
		while (iterator.hasNext())
		{
			PropertyMetaModel propertyMetaModel = (PropertyMetaModel)iterator.next();
			builder.append(new StringBuilder().append(java.lang.System.lineSeparator()).append(indent(level)).append(propertyMetaModel.getName())
				.append(": ")
				.append(escapeValue(Object.instancehelper_toString(propertyMetaModel.getValue(node))))
				.ToString());
		}
		iterator = list2.iterator();
		while (iterator.hasNext())
		{
			PropertyMetaModel propertyMetaModel = (PropertyMetaModel)iterator.next();
			Node node2 = (Node)propertyMetaModel.getValue(node);
			if (node2 != null)
			{
				output(node2, propertyMetaModel.getName(), level, builder);
			}
		}
		iterator = list3.iterator();
		while (iterator.hasNext())
		{
			PropertyMetaModel propertyMetaModel = (PropertyMetaModel)iterator.next();
			NodeList nodeList = (NodeList)propertyMetaModel.getValue(node);
			if (nodeList != null && nodeList.isNonEmpty())
			{
				builder.append(new StringBuilder().append(java.lang.System.lineSeparator()).append(indent(level)).append(propertyMetaModel.getName())
					.append(": ")
					.ToString());
				string name2 = propertyMetaModel.getName();
				name2 = ((!String.instancehelper_endsWith(name2, "s")) ? name2 : String.instancehelper_substring(name2, 0, String.instancehelper_length(propertyMetaModel.getName()) - 1));
				Iterator iterator2 = nodeList.iterator();
				while (iterator2.hasNext())
				{
					Node node3 = (Node)iterator2.next();
					output(node3, new StringBuilder().append("- ").append(name2).ToString(), level + 1, builder);
				}
			}
		}
	}

	
	
	
	private string indent(int level)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < level; i++)
		{
			for (int j = 0; j < 4; j++)
			{
				stringBuilder.append(" ");
			}
		}
		string result = stringBuilder.ToString();
		
		return result;
	}

	
	
	[LineNumberTable(new byte[]
	{
		52,
		122,
		127,
		18,
		111,
		127,
		18,
		127,
		18,
		127,
		18,
		127,
		18,
		byte.MaxValue,
		30,
		57
	})]
	private string escapeValue(string value)
	{
		StringBuilder stringBuilder = new StringBuilder().append("\"");
		object __003Cref_003E = "\\\\";
		CharSequence charSequence = default(CharSequence);
		object obj = (charSequence.___003Cref_003E = "\\");
		CharSequence target = charSequence;
		obj = (charSequence.___003Cref_003E = __003Cref_003E);
		string @this = String.instancehelper_replaceAll(String.instancehelper_replace(value, target, charSequence), "\"", "\\\\\"");
		obj = "\\n";
		__003Cref_003E = (charSequence.___003Cref_003E = "\n");
		CharSequence target2 = charSequence;
		__003Cref_003E = (charSequence.___003Cref_003E = obj);
		string this2 = String.instancehelper_replace(@this, target2, charSequence);
		__003Cref_003E = "\\r";
		obj = (charSequence.___003Cref_003E = "\r");
		CharSequence target3 = charSequence;
		obj = (charSequence.___003Cref_003E = __003Cref_003E);
		string this3 = String.instancehelper_replace(this2, target3, charSequence);
		obj = "\\f";
		__003Cref_003E = (charSequence.___003Cref_003E = "\f");
		CharSequence target4 = charSequence;
		__003Cref_003E = (charSequence.___003Cref_003E = obj);
		string this4 = String.instancehelper_replace(this3, target4, charSequence);
		__003Cref_003E = "\\b";
		obj = (charSequence.___003Cref_003E = "\b");
		CharSequence target5 = charSequence;
		obj = (charSequence.___003Cref_003E = __003Cref_003E);
		string this5 = String.instancehelper_replace(this4, target5, charSequence);
		obj = "\\t";
		__003Cref_003E = (charSequence.___003Cref_003E = "\t");
		CharSequence target6 = charSequence;
		__003Cref_003E = (charSequence.___003Cref_003E = obj);
		string result = stringBuilder.append(String.instancehelper_replace(this5, target6, charSequence)).append("\"").ToString();
		
		return result;
	}

	
	
	
	public YamlPrinter(bool outputNodeType)
	{
		this.outputNodeType = outputNodeType;
	}

	
	
	
	public virtual string output(Node node)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.append("---");
		output(node, "root", 0, stringBuilder);
		stringBuilder.append(new StringBuilder().append(java.lang.System.lineSeparator()).append("...").ToString());
		string result = stringBuilder.ToString();
		
		return result;
	}

	
	
	
	public static void print(Node node)
	{
		java.lang.System.@out.println(new YamlPrinter(outputNodeType: true).output(node));
	}
}
