using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.comments;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.util;
using java.util.function;
using javax.json;

namespace com.github.javaparser.serialization;

public class JavaParserJsonDeserializer
{
	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	
	private sealed class ___003C_003EAnon1 : Supplier
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon1(string P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			IllegalStateException result = lambda_0024deserializeObject_00240(arg_00241);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon2 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon2(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024deserializeObject_00241(arg_00241, (PropertyMetaModel)P_0);
			
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

	
	private sealed class ___003C_003EAnon3 : Function
	{
		private readonly JavaParserJsonDeserializer arg_00241;

		internal ___003C_003EAnon3(JavaParserJsonDeserializer P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			Node result = arg_00241.lambda_0024deserializeNodeList_00242((JsonValue)P_0);
			
			return result;
		}

		
		public Function compose(Function P_0)
		{
			return Function._003Cdefault_003Ecompose(this, P_0);
		}

		
		public Function andThen(Function P_0)
		{
			return Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private static CallerID ___003CcallerID_003E;

	
	[LineNumberTable(new byte[]
	{
		19, 113, 123, 107, 102, 134, 127, 8, 115, 162,
		119, 101, 103, 105, 113, 165, 110, 105, 106, 113,
		110, 156, 105, 105, 118, 105, 125, 110, 154, 191,
		7, 133, 169, 114, 189, 127, 5, 121, 159, 28,
		101, 136, 125, 98
	})]
	private Node deserializeObject(JsonObject P_0)
	{
		//Discarded unreachable code: IL_027f
		java.lang.ClassNotFoundException ex;
		try
		{
			string @string = P_0.getString(JavaParserJsonSerializer.JsonNode.___003C_003ECLASS.propertyKey);
			BaseNodeMetaModel baseNodeMetaModel = (BaseNodeMetaModel)JavaParserMetaModel.getNodeMetaModel(Class.forName(@string, JavaParserJsonDeserializer.___003CGetCallerID_003E())).orElseThrow(new ___003C_003EAnon1(@string));
			HashMap hashMap = new HashMap();
			HashMap hashMap2 = new HashMap();
			Iterator iterator = P_0.keySet().iterator();
			while (iterator.hasNext())
			{
				string text = (string)iterator.next();
				if (String.instancehelper_equals(text, JavaParserJsonSerializer.JsonNode.___003C_003ECLASS.propertyKey))
				{
					continue;
				}
				Optional optional = baseNodeMetaModel.getAllPropertyMetaModels().stream().filter(new ___003C_003EAnon2(text))
					.findFirst();
				if (!optional.isPresent())
				{
					((Map)hashMap2).put((object)text, P_0.get(text));
					continue;
				}
				PropertyMetaModel propertyMetaModel = (PropertyMetaModel)optional.get();
				if (propertyMetaModel.isNodeList())
				{
					JsonArray jsonArray = P_0.getJsonArray(text);
					((Map)hashMap).put((object)text, (object)deserializeNodeList(jsonArray));
					continue;
				}
				if (propertyMetaModel.isNode())
				{
					((Map)hashMap).put((object)text, (object)deserializeObject(P_0.getJsonObject(text)));
					continue;
				}
				Class type = propertyMetaModel.getType();
				if (type == ClassLiteral<String>.Value)
				{
					((Map)hashMap).put((object)text, (object)P_0.getString(text));
					continue;
				}
				if (type == Boolean.TYPE)
				{
					((Map)hashMap).put((object)text, (object)Boolean.valueOf(Boolean.parseBoolean(P_0.getString(text))));
					continue;
				}
				if (ClassLiteral<Enum>.Value.isAssignableFrom(type))
				{
					((Map)hashMap).put((object)text, (object)Enum.valueOf(type, P_0.getString(text)));
					continue;
				}
				string s = new StringBuilder().append("Don't know how to convert: ").append(type).ToString();
				
				throw new IllegalStateException(s);
			}
			Node node = baseNodeMetaModel.construct(hashMap);
			if (((Map)hashMap).containsKey((object)JavaParserJsonSerializer.JsonNode.___003C_003ECOMMENT.propertyKey))
			{
				node.setComment((Comment)((Map)hashMap).get((object)JavaParserJsonSerializer.JsonNode.___003C_003ECOMMENT.propertyKey));
			}
			Iterator iterator2 = ((Map)hashMap2).keySet().iterator();
			while (iterator2.hasNext())
			{
				string text2 = (string)iterator2.next();
				if (!readNonMetaProperties(text2, (JsonValue)((Map)hashMap2).get((object)text2), node))
				{
					string s2 = new StringBuilder().append("Unknown propertyKey: ").append(baseNodeMetaModel.getQualifiedClassName()).append(".")
						.append(text2)
						.ToString();
					
					throw new IllegalStateException(s2);
				}
			}
			setSymbolResolverIfCompilationUnit(node);
			return node;
		}
		catch (java.lang.ClassNotFoundException x)
		{
			ex = ByteCodeHelper.MapException<java.lang.ClassNotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		java.lang.ClassNotFoundException cause = ex;
		
		throw new RuntimeException(cause);
	}

	
		
	private NodeList deserializeNodeList(JsonArray P_0)
	{
		return (NodeList)P_0.stream().map(new ___003C_003EAnon3(this)).collect(NodeList.toNodeList());
	}

	
	
	protected internal virtual bool readNonMetaProperties(string name, JsonValue jsonValue, Node node)
	{
		return (readRange(name, jsonValue, node) || readTokenRange(name, jsonValue, node)) ? true : false;
	}

	
	
	private void setSymbolResolverIfCompilationUnit(Node P_0)
	{
		if (P_0 is CompilationUnit && StaticJavaParser.getConfiguration().getSymbolResolver().isPresent())
		{
			CompilationUnit compilationUnit = (CompilationUnit)P_0;
			compilationUnit.setData(Node.___003C_003ESYMBOL_RESOLVER_KEY, StaticJavaParser.getConfiguration().getSymbolResolver().get());
		}
	}

	
	[LineNumberTable(new byte[]
	{
		96, 117, 103, 112, 112, 139, 112, 112, 139, 110,
		130
	})]
	protected internal virtual bool readRange(string name, JsonValue jsonValue, Node node)
	{
		if (String.instancehelper_equals(name, JavaParserJsonSerializer.JsonNode.___003C_003ERANGE.propertyKey))
		{
			JsonObject jsonObject = (JsonObject)jsonValue;
			Position.___003Cclinit_003E();
			Position begin = new Position(jsonObject.getInt(JavaParserJsonSerializer.JsonRange.___003C_003EBEGIN_LINE.propertyKey), jsonObject.getInt(JavaParserJsonSerializer.JsonRange.___003C_003EBEGIN_COLUMN.propertyKey));
			Position.___003Cclinit_003E();
			Position end = new Position(jsonObject.getInt(JavaParserJsonSerializer.JsonRange.___003C_003EEND_LINE.propertyKey), jsonObject.getInt(JavaParserJsonSerializer.JsonRange.___003C_003EEND_COLUMN.propertyKey));
			node.setRange(new Range(begin, end));
			return true;
		}
		return false;
	}

	
	
	protected internal virtual bool readTokenRange(string name, JsonValue jsonValue, Node node)
	{
		if (String.instancehelper_equals(name, JavaParserJsonSerializer.JsonNode.___003C_003ETOKEN_RANGE.propertyKey))
		{
			JsonObject jsonObject = (JsonObject)jsonValue;
			JavaToken begin = readToken(JavaParserJsonSerializer.JsonTokenRange.___003C_003EBEGIN_TOKEN.propertyKey, jsonObject);
			JavaToken end = readToken(JavaParserJsonSerializer.JsonTokenRange.___003C_003EEND_TOKEN.propertyKey, jsonObject);
			node.setTokenRange(new TokenRange(begin, end));
			return true;
		}
		return false;
	}

	
	
	protected internal virtual JavaToken readToken(string name, JsonObject jsonObject)
	{
		JsonObject jsonObject2 = jsonObject.getJsonObject(name);
		JavaToken.___003Cclinit_003E();
		JavaToken result = new JavaToken(jsonObject2.getInt(JavaParserJsonSerializer.JsonToken.___003C_003EKIND.propertyKey), jsonObject2.getString(JavaParserJsonSerializer.JsonToken.___003C_003ETEXT.propertyKey));
		
		return result;
	}

	
	
	
	private static IllegalStateException lambda_0024deserializeObject_00240(string P_0)
	{
		IllegalStateException result = new IllegalStateException(new StringBuilder().append("Trying to deserialize an unknown node type: ").append(P_0).ToString());
		
		return result;
	}

	
	
	
	private static bool lambda_0024deserializeObject_00241(string P_0, PropertyMetaModel P_1)
	{
		bool result = String.instancehelper_equals(P_1.getName(), P_0);
		
		return result;
	}

	
	
	
	private Node lambda_0024deserializeNodeList_00242(JsonValue P_0)
	{
		Node result = deserializeObject((JsonObject)P_0);
		
		return result;
	}

	
	
	public JavaParserJsonDeserializer()
	{
	}

	
	
	public virtual Node deserializeObject(JsonReader reader)
	{
		Log.info("Deserializing JSON to Node.");
		JsonObject jsonObject = reader.readObject();
		Node result = deserializeObject(jsonObject);
		
		return result;
	}

	static CallerID ___003CGetCallerID_003E()
	{
		if (___003CcallerID_003E == null)
		{
			___003CcallerID_003E = new ___003CCallerID_003E();
		}
		return ___003CcallerID_003E;
	}
}
