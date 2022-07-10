using System;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;
using javax.json.stream;

namespace com.github.javaparser.serialization;

public class JavaParserJsonSerializer
{
	[Serializable]
	[InnerClass(null, Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		
	public class JsonNode : java.lang.Enum
	{
		[Serializable]
		
		public enum __Enum
		{
			RANGE,
			TOKEN_RANGE,
			COMMENT,
			CLASS
		}

		
		internal static JsonNode ___003C_003ERANGE;

		
		internal static JsonNode ___003C_003ETOKEN_RANGE;

		
		internal static JsonNode ___003C_003ECOMMENT;

		
		internal static JsonNode ___003C_003ECLASS;

		
		internal string propertyKey;

		
		private static JsonNode[] _0024VALUES;

		
		public static JsonNode RANGE
		{
			
			get
			{
				return ___003C_003ERANGE;
			}
		}

		
		public static JsonNode TOKEN_RANGE
		{
			
			get
			{
				return ___003C_003ETOKEN_RANGE;
			}
		}

		
		public static JsonNode COMMENT
		{
			
			get
			{
				return ___003C_003ECOMMENT;
			}
		}

		
		public static JsonNode CLASS
		{
			
			get
			{
				return ___003C_003ECLASS;
			}
		}

		
		
		public static void ___003Cclinit_003E()
		{
		}

		
				
		private JsonNode(string P_0, int P_1, string P_2)
			: base(P_0, P_1)
		{
			propertyKey = P_2;
			GC.KeepAlive(this);
		}

		
		
		public static JsonNode[] values()
		{
			return (JsonNode[])_0024VALUES.Clone();
		}

		
		
		public static JsonNode valueOf(string name)
		{
			return (JsonNode)java.lang.Enum.valueOf(ClassLiteral<JsonNode>.Value, name);
		}

		public override string ToString()
		{
			return propertyKey;
		}

		
		static JsonNode()
		{
			___003C_003ERANGE = new JsonNode("RANGE", 0, "range");
			___003C_003ETOKEN_RANGE = new JsonNode("TOKEN_RANGE", 1, "tokenRange");
			___003C_003ECOMMENT = new JsonNode("COMMENT", 2, Utils.decapitalize(JavaParserMetaModel.___003C_003EcommentMetaModel.getTypeName()));
			___003C_003ECLASS = new JsonNode("CLASS", 3, "!");
			_0024VALUES = new JsonNode[4] { ___003C_003ERANGE, ___003C_003ETOKEN_RANGE, ___003C_003ECOMMENT, ___003C_003ECLASS };
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		
	public class JsonRange : java.lang.Enum
	{
		[Serializable]
		
		public enum __Enum
		{
			BEGIN_LINE,
			BEGIN_COLUMN,
			END_LINE,
			END_COLUMN
		}

		
		internal static JsonRange ___003C_003EBEGIN_LINE;

		
		internal static JsonRange ___003C_003EBEGIN_COLUMN;

		
		internal static JsonRange ___003C_003EEND_LINE;

		
		internal static JsonRange ___003C_003EEND_COLUMN;

		
		internal string propertyKey;

		
		private static JsonRange[] _0024VALUES;

		
		public static JsonRange BEGIN_LINE
		{
			
			get
			{
				return ___003C_003EBEGIN_LINE;
			}
		}

		
		public static JsonRange BEGIN_COLUMN
		{
			
			get
			{
				return ___003C_003EBEGIN_COLUMN;
			}
		}

		
		public static JsonRange END_LINE
		{
			
			get
			{
				return ___003C_003EEND_LINE;
			}
		}

		
		public static JsonRange END_COLUMN
		{
			
			get
			{
				return ___003C_003EEND_COLUMN;
			}
		}

		
		
		public static void ___003Cclinit_003E()
		{
		}

		
				
		private JsonRange(string P_0, int P_1, string P_2)
			: base(P_0, P_1)
		{
			propertyKey = P_2;
			GC.KeepAlive(this);
		}

		
		
		public static JsonRange[] values()
		{
			return (JsonRange[])_0024VALUES.Clone();
		}

		
		
		public static JsonRange valueOf(string name)
		{
			return (JsonRange)java.lang.Enum.valueOf(ClassLiteral<JsonRange>.Value, name);
		}

		public override string ToString()
		{
			return propertyKey;
		}

		
		static JsonRange()
		{
			___003C_003EBEGIN_LINE = new JsonRange("BEGIN_LINE", 0, "beginLine");
			___003C_003EBEGIN_COLUMN = new JsonRange("BEGIN_COLUMN", 1, "beginColumn");
			___003C_003EEND_LINE = new JsonRange("END_LINE", 2, "endLine");
			___003C_003EEND_COLUMN = new JsonRange("END_COLUMN", 3, "endColumn");
			_0024VALUES = new JsonRange[4] { ___003C_003EBEGIN_LINE, ___003C_003EBEGIN_COLUMN, ___003C_003EEND_LINE, ___003C_003EEND_COLUMN };
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		
	public class JsonToken : java.lang.Enum
	{
		[Serializable]
		
		public enum __Enum
		{
			TEXT,
			KIND
		}

		
		internal static JsonToken ___003C_003ETEXT;

		
		internal static JsonToken ___003C_003EKIND;

		
		internal string propertyKey;

		
		private static JsonToken[] _0024VALUES;

		
		public static JsonToken TEXT
		{
			
			get
			{
				return ___003C_003ETEXT;
			}
		}

		
		public static JsonToken KIND
		{
			
			get
			{
				return ___003C_003EKIND;
			}
		}

		
		
		public static void ___003Cclinit_003E()
		{
		}

		
				
		private JsonToken(string P_0, int P_1, string P_2)
			: base(P_0, P_1)
		{
			propertyKey = P_2;
			GC.KeepAlive(this);
		}

		
		
		public static JsonToken[] values()
		{
			return (JsonToken[])_0024VALUES.Clone();
		}

		
		
		public static JsonToken valueOf(string name)
		{
			return (JsonToken)java.lang.Enum.valueOf(ClassLiteral<JsonToken>.Value, name);
		}

		public override string ToString()
		{
			return propertyKey;
		}

		
		static JsonToken()
		{
			___003C_003ETEXT = new JsonToken("TEXT", 0, "text");
			___003C_003EKIND = new JsonToken("KIND", 1, "kind");
			_0024VALUES = new JsonToken[2] { ___003C_003ETEXT, ___003C_003EKIND };
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		
	public class JsonTokenRange : java.lang.Enum
	{
		[Serializable]
		
		public enum __Enum
		{
			BEGIN_TOKEN,
			END_TOKEN
		}

		
		internal static JsonTokenRange ___003C_003EBEGIN_TOKEN;

		
		internal static JsonTokenRange ___003C_003EEND_TOKEN;

		
		internal string propertyKey;

		
		private static JsonTokenRange[] _0024VALUES;

		
		public static JsonTokenRange BEGIN_TOKEN
		{
			
			get
			{
				return ___003C_003EBEGIN_TOKEN;
			}
		}

		
		public static JsonTokenRange END_TOKEN
		{
			
			get
			{
				return ___003C_003EEND_TOKEN;
			}
		}

		
		
		public static void ___003Cclinit_003E()
		{
		}

		
				
		private JsonTokenRange(string P_0, int P_1, string P_2)
			: base(P_0, P_1)
		{
			propertyKey = P_2;
			GC.KeepAlive(this);
		}

		
		
		public static JsonTokenRange[] values()
		{
			return (JsonTokenRange[])_0024VALUES.Clone();
		}

		
		
		public static JsonTokenRange valueOf(string name)
		{
			return (JsonTokenRange)java.lang.Enum.valueOf(ClassLiteral<JsonTokenRange>.Value, name);
		}

		public override string ToString()
		{
			return propertyKey;
		}

		
		static JsonTokenRange()
		{
			___003C_003EBEGIN_TOKEN = new JsonTokenRange("BEGIN_TOKEN", 0, "beginToken");
			___003C_003EEND_TOKEN = new JsonTokenRange("END_TOKEN", 1, "endToken");
			_0024VALUES = new JsonTokenRange[2] { ___003C_003EBEGIN_TOKEN, ___003C_003EEND_TOKEN };
		}
	}

	
	private sealed class ___003C_003EAnon0 : Supplier
	{
		private readonly Node arg_00241;

		internal ___003C_003EAnon0(Node P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			IllegalStateException result = lambda_0024serialize_00240(arg_00241);
			
			return result;
		}
	}

	
	[LineNumberTable(new byte[]
	{
		19, 103, 159, 2, 99, 137, 136, 124, 104, 127,
		4, 103, 105, 103, 104, 105, 104, 127, 1, 106,
		98, 103, 106, 145, 175, 101, 103
	})]
	private void serialize(string P_0, Node P_1, JsonGenerator P_2)
	{
		Objects.requireNonNull(P_1);
		BaseNodeMetaModel baseNodeMetaModel = (BaseNodeMetaModel)JavaParserMetaModel.getNodeMetaModel(java.lang.Object.instancehelper_getClass(P_1)).orElseThrow(new ___003C_003EAnon0(P_1));
		if (P_0 == null)
		{
			P_2.writeStartObject();
		}
		else
		{
			P_2.writeStartObject(P_0);
		}
		P_2.write(JsonNode.___003C_003ECLASS.propertyKey, java.lang.Object.instancehelper_getClass(P_1).getName());
		writeNonMetaProperties(P_1, P_2);
		Iterator iterator = baseNodeMetaModel.getAllPropertyMetaModels().iterator();
		while (iterator.hasNext())
		{
			PropertyMetaModel propertyMetaModel = (PropertyMetaModel)iterator.next();
			string name = propertyMetaModel.getName();
			object value = propertyMetaModel.getValue(P_1);
			if (value == null)
			{
				continue;
			}
			if (propertyMetaModel.isNodeList())
			{
				NodeList nodeList = (NodeList)value;
				P_2.writeStartArray(name);
				Iterator iterator2 = nodeList.iterator();
				while (iterator2.hasNext())
				{
					Node node = (Node)iterator2.next();
					serialize(null, node, P_2);
				}
				P_2.writeEnd();
			}
			else if (propertyMetaModel.isNode())
			{
				serialize(name, (Node)value, P_2);
			}
			else
			{
				P_2.write(name, java.lang.Object.instancehelper_toString(value));
			}
		}
		P_2.writeEnd();
	}

	
	
	protected internal virtual void writeNonMetaProperties(Node node, JsonGenerator generator)
	{
		writeRange(node, generator);
		writeTokens(node, generator);
	}

	
	
	protected internal virtual void writeRange(Node node, JsonGenerator generator)
	{
		if (node.hasRange())
		{
			Range range = (Range)node.getRange().get();
			generator.writeStartObject(JsonNode.___003C_003ERANGE.propertyKey);
			generator.write(JsonRange.___003C_003EBEGIN_LINE.propertyKey, range.___003C_003Ebegin.___003C_003Eline);
			generator.write(JsonRange.___003C_003EBEGIN_COLUMN.propertyKey, range.___003C_003Ebegin.___003C_003Ecolumn);
			generator.write(JsonRange.___003C_003EEND_LINE.propertyKey, range.___003C_003Eend.___003C_003Eline);
			generator.write(JsonRange.___003C_003EEND_COLUMN.propertyKey, range.___003C_003Eend.___003C_003Ecolumn);
			generator.writeEnd();
		}
	}

	
	
	protected internal virtual void writeTokens(Node node, JsonGenerator generator)
	{
		if (node.getTokenRange().isPresent())
		{
			TokenRange tokenRange = (TokenRange)node.getTokenRange().get();
			generator.writeStartObject(JsonNode.___003C_003ETOKEN_RANGE.propertyKey);
			writeToken(JsonTokenRange.___003C_003EBEGIN_TOKEN.propertyKey, tokenRange.getBegin(), generator);
			writeToken(JsonTokenRange.___003C_003EEND_TOKEN.propertyKey, tokenRange.getEnd(), generator);
			generator.writeEnd();
		}
	}

	
	
	protected internal virtual void writeToken(string name, JavaToken token, JsonGenerator generator)
	{
		generator.writeStartObject(name);
		generator.write(JsonToken.___003C_003EKIND.propertyKey, token.getKind());
		generator.write(JsonToken.___003C_003ETEXT.propertyKey, token.getText());
		generator.writeEnd();
	}

	
	
	
	private static IllegalStateException lambda_0024serialize_00240(Node P_0)
	{
		IllegalStateException result = new IllegalStateException(new StringBuilder().append("Unknown Node: ").append(java.lang.Object.instancehelper_getClass(P_0)).ToString());
		
		return result;
	}

	
	
	public JavaParserJsonSerializer()
	{
	}

	
	
	public virtual void serialize(Node node, JsonGenerator generator)
	{
		Objects.requireNonNull(node);
		Log.info("Serializing Node to JSON.");
		try
		{
			serialize(null, node, generator);
		}
		finally
		{
			generator.close();
		}
	}
}
