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

public class DotPrinter
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

	private int nodeCount;

	
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
		7, 103, 103, 103, 127, 0, 117, 127, 0, 117,
		117, 145, 104, 104, 191, 58, 159, 35, 99, 159,
		30, 127, 3, 104, 127, 33, 63, 4, 134, 159,
		31, 133, 127, 0, 111, 100, 115, 130, 127, 4,
		111, 115, 104, 127, 41, 127, 31, 125, 127, 1,
		144, 101
	})]
	public virtual void output(Node node, string parentNodeName, string name, StringBuilder builder)
	{
		Utils.assertNotNull(node);
		NodeMetaModel metaModel = node.getMetaModel();
		List allPropertyMetaModels = metaModel.getAllPropertyMetaModels();
		List list = (List)allPropertyMetaModels.stream().filter(new ___003C_003EAnon0()).filter(new ___003C_003EAnon1())
			.collect(Collectors.toList());
		List list2 = (List)allPropertyMetaModels.stream().filter(new ___003C_003EAnon2()).filter(new ___003C_003EAnon1())
			.collect(Collectors.toList());
		List list3 = (List)allPropertyMetaModels.stream().filter(new ___003C_003EAnon3()).collect(Collectors.toList());
		string text = nextNodeName();
		if (outputNodeType)
		{
			builder.append(new StringBuilder().append(Utils.___003C_003ESYSTEM_EOL).append(text).append(" [label=\"")
				.append(escape(name))
				.append(" (")
				.append(metaModel.getTypeName())
				.append(")\"];")
				.ToString());
		}
		else
		{
			builder.append(new StringBuilder().append(Utils.___003C_003ESYSTEM_EOL).append(text).append(" [label=\"")
				.append(escape(name))
				.append("\"];")
				.ToString());
		}
		if (parentNodeName != null)
		{
			builder.append(new StringBuilder().append(Utils.___003C_003ESYSTEM_EOL).append(parentNodeName).append(" -> ")
				.append(text)
				.append(";")
				.ToString());
		}
		Iterator iterator = list.iterator();
		while (iterator.hasNext())
		{
			PropertyMetaModel propertyMetaModel = (PropertyMetaModel)iterator.next();
			string str = nextNodeName();
			builder.append(new StringBuilder().append(Utils.___003C_003ESYSTEM_EOL).append(str).append(" [label=\"")
				.append(escape(propertyMetaModel.getName()))
				.append("='")
				.append(escape(Object.instancehelper_toString(propertyMetaModel.getValue(node))))
				.append("'\"];")
				.ToString());
			builder.append(new StringBuilder().append(Utils.___003C_003ESYSTEM_EOL).append(text).append(" -> ")
				.append(str)
				.append(";")
				.ToString());
		}
		iterator = list2.iterator();
		while (iterator.hasNext())
		{
			PropertyMetaModel propertyMetaModel = (PropertyMetaModel)iterator.next();
			Node node2 = (Node)propertyMetaModel.getValue(node);
			if (node2 != null)
			{
				output(node2, text, propertyMetaModel.getName(), builder);
			}
		}
		iterator = list3.iterator();
		while (iterator.hasNext())
		{
			PropertyMetaModel propertyMetaModel = (PropertyMetaModel)iterator.next();
			NodeList nodeList = (NodeList)propertyMetaModel.getValue(node);
			if (nodeList != null && nodeList.isNonEmpty())
			{
				string text2 = nextNodeName();
				builder.append(new StringBuilder().append(Utils.___003C_003ESYSTEM_EOL).append(text2).append(" [label=\"")
					.append(escape(propertyMetaModel.getName()))
					.append("\"];")
					.ToString());
				builder.append(new StringBuilder().append(Utils.___003C_003ESYSTEM_EOL).append(text).append(" -> ")
					.append(text2)
					.append(";")
					.ToString());
				string name2 = String.instancehelper_substring(propertyMetaModel.getName(), 0, String.instancehelper_length(propertyMetaModel.getName()) - 1);
				Iterator iterator2 = nodeList.iterator();
				while (iterator2.hasNext())
				{
					Node node3 = (Node)iterator2.next();
					output(node3, text2, name2, builder);
				}
			}
		}
	}

	
	
	private string nextNodeName()
	{
		StringBuilder stringBuilder = new StringBuilder().append("n");
		int num = nodeCount;
		nodeCount = num + 1;
		string result = stringBuilder.append(num).ToString();
		
		return result;
	}

	
	
	
	private static string escape(string value)
	{
		object __003Cref_003E = "\\\"";
		CharSequence charSequence = default(CharSequence);
		object obj = (charSequence.___003Cref_003E = "\"");
		CharSequence target = charSequence;
		obj = (charSequence.___003Cref_003E = __003Cref_003E);
		string result = String.instancehelper_replace(value, target, charSequence);
		
		return result;
	}

	
	
	
	public DotPrinter(bool outputNodeType)
	{
		this.outputNodeType = outputNodeType;
	}

	
	
	
	public virtual string output(Node node)
	{
		nodeCount = 0;
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.append("digraph {");
		output(node, null, "root", stringBuilder);
		stringBuilder.append(new StringBuilder().append(Utils.___003C_003ESYSTEM_EOL).append("}").ToString());
		string result = stringBuilder.ToString();
		
		return result;
	}
}
