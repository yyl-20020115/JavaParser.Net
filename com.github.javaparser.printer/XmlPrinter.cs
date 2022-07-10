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

public class XmlPrinter
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
		1, 103, 103, 103, 127, 21, 127, 21, 159, 7,
		115, 104, 184, 127, 0, 127, 2, 98, 141, 127,
		0, 111, 100, 148, 130, 127, 4, 111, 115, 105,
		126, 115, 127, 1, 111, 98, 143, 101, 110
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
		builder.append("<").append(name);
		if (outputNodeType)
		{
			builder.append(attribute("type", metaModel.getTypeName()));
		}
		Iterator iterator = list.iterator();
		while (iterator.hasNext())
		{
			PropertyMetaModel propertyMetaModel = (PropertyMetaModel)iterator.next();
			builder.append(attribute(propertyMetaModel.getName(), Object.instancehelper_toString(propertyMetaModel.getValue(node))));
		}
		builder.append(">");
		iterator = list2.iterator();
		while (iterator.hasNext())
		{
			PropertyMetaModel propertyMetaModel = (PropertyMetaModel)iterator.next();
			Node node2 = (Node)propertyMetaModel.getValue(node);
			if (node2 != null)
			{
				output(node2, propertyMetaModel.getName(), level + 1, builder);
			}
		}
		iterator = list3.iterator();
		while (iterator.hasNext())
		{
			PropertyMetaModel propertyMetaModel = (PropertyMetaModel)iterator.next();
			NodeList nodeList = (NodeList)propertyMetaModel.getValue(node);
			if (nodeList != null && !nodeList.isEmpty())
			{
				string name2 = propertyMetaModel.getName();
				builder.append("<").append(name2).append(">");
				string name3 = String.instancehelper_substring(name2, 0, String.instancehelper_length(name2) - 1);
				Iterator iterator2 = nodeList.iterator();
				while (iterator2.hasNext())
				{
					Node node3 = (Node)iterator2.next();
					output(node3, name3, level + 1, builder);
				}
				builder.append(close(name2));
			}
		}
		builder.append(close(name));
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	private static string attribute(string name, string value)
	{
		string result = new StringBuilder().append(" ").append(name).append("='")
			.append(value)
			.append("'")
			.ToString();
		
		return result;
	}

	
	
	
	private static string close(string name)
	{
		string result = new StringBuilder().append("</").append(name).append(">")
			.ToString();
		
		return result;
	}

	
	
	
	public XmlPrinter(bool outputNodeType)
	{
		this.outputNodeType = outputNodeType;
	}

	
	
	
	public virtual string output(Node node)
	{
		StringBuilder stringBuilder = new StringBuilder();
		output(node, "root", 0, stringBuilder);
		string result = stringBuilder.ToString();
		
		return result;
	}

	
	
	
	public static void print(Node node)
	{
		java.lang.System.@out.println(new XmlPrinter(outputNodeType: true).output(node));
	}
}
