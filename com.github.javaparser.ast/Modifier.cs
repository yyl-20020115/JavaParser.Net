using System;
using System.ComponentModel;

using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;

using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast;

public class Modifier : Node
{
	
	
		
	public class Keyword : java.lang.Enum
	{
		
		
		public enum __Enum
		{
			DEFAULT,
			PUBLIC,
			PROTECTED,
			PRIVATE,
			ABSTRACT,
			STATIC,
			FINAL,
			TRANSIENT,
			VOLATILE,
			SYNCHRONIZED,
			NATIVE,
			STRICTFP,
			TRANSITIVE
		}

		
		internal static Keyword ___003C_003EDEFAULT;

		
		internal static Keyword ___003C_003EPUBLIC;

		
		internal static Keyword ___003C_003EPROTECTED;

		
		internal static Keyword ___003C_003EPRIVATE;

		
		internal static Keyword ___003C_003EABSTRACT;

		
		internal static Keyword ___003C_003ESTATIC;

		
		internal static Keyword ___003C_003EFINAL;

		
		internal static Keyword ___003C_003ETRANSIENT;

		
		internal static Keyword ___003C_003EVOLATILE;

		
		internal static Keyword ___003C_003ESYNCHRONIZED;

		
		internal static Keyword ___003C_003ENATIVE;

		
		internal static Keyword ___003C_003ESTRICTFP;

		
		internal static Keyword ___003C_003ETRANSITIVE;

		
		private string codeRepresentation;

		
		private static Keyword[] _0024VALUES;

		
		public static Keyword DEFAULT
		{
			
			get
			{
				return ___003C_003EDEFAULT;
			}
		}

		
		public static Keyword PUBLIC
		{
			
			get
			{
				return ___003C_003EPUBLIC;
			}
		}

		
		public static Keyword PROTECTED
		{
			
			get
			{
				return ___003C_003EPROTECTED;
			}
		}

		
		public static Keyword PRIVATE
		{
			
			get
			{
				return ___003C_003EPRIVATE;
			}
		}

		
		public static Keyword ABSTRACT
		{
			
			get
			{
				return ___003C_003EABSTRACT;
			}
		}

		
		public static Keyword STATIC
		{
			
			get
			{
				return ___003C_003ESTATIC;
			}
		}

		
		public static Keyword FINAL
		{
			
			get
			{
				return ___003C_003EFINAL;
			}
		}

		
		public static Keyword TRANSIENT
		{
			
			get
			{
				return ___003C_003ETRANSIENT;
			}
		}

		
		public static Keyword VOLATILE
		{
			
			get
			{
				return ___003C_003EVOLATILE;
			}
		}

		
		public static Keyword SYNCHRONIZED
		{
			
			get
			{
				return ___003C_003ESYNCHRONIZED;
			}
		}

		
		public static Keyword NATIVE
		{
			
			get
			{
				return ___003C_003ENATIVE;
			}
		}

		
		public static Keyword STRICTFP
		{
			
			get
			{
				return ___003C_003ESTRICTFP;
			}
		}

		
		public static Keyword TRANSITIVE
		{
			
			get
			{
				return ___003C_003ETRANSITIVE;
			}
		}

		
		
		public static void ___003Cclinit_003E()
		{
		}

		
				
		
		private Keyword(string _0024enum_0024name, int _0024enum_0024ordinal, string codeRepresentation)
			: base(_0024enum_0024name, _0024enum_0024ordinal)
		{
			this.codeRepresentation = codeRepresentation;
			GC.KeepAlive(this);
		}

		
		
		public static Keyword[] values()
		{
			return (Keyword[])_0024VALUES.Clone();
		}

		
		
		
		public static Keyword valueOf(string name)
		{
			return (Keyword)java.lang.Enum.valueOf(ClassLiteral<Keyword>.Value, name);
		}

		public virtual string asString()
		{
			return codeRepresentation;
		}

		
		static Keyword()
		{
			___003C_003EDEFAULT = new Keyword("DEFAULT", 0, "default");
			___003C_003EPUBLIC = new Keyword("PUBLIC", 1, "public");
			___003C_003EPROTECTED = new Keyword("PROTECTED", 2, "protected");
			___003C_003EPRIVATE = new Keyword("PRIVATE", 3, "private");
			___003C_003EABSTRACT = new Keyword("ABSTRACT", 4, "abstract");
			___003C_003ESTATIC = new Keyword("STATIC", 5, "static");
			___003C_003EFINAL = new Keyword("FINAL", 6, "final");
			___003C_003ETRANSIENT = new Keyword("TRANSIENT", 7, "transient");
			___003C_003EVOLATILE = new Keyword("VOLATILE", 8, "volatile");
			___003C_003ESYNCHRONIZED = new Keyword("SYNCHRONIZED", 9, "synchronized");
			___003C_003ENATIVE = new Keyword("NATIVE", 10, "native");
			___003C_003ESTRICTFP = new Keyword("STRICTFP", 11, "strictfp");
			___003C_003ETRANSITIVE = new Keyword("TRANSITIVE", 12, "transitive");
			_0024VALUES = new Keyword[13]
			{
				___003C_003EDEFAULT, ___003C_003EPUBLIC, ___003C_003EPROTECTED, ___003C_003EPRIVATE, ___003C_003EABSTRACT, ___003C_003ESTATIC, ___003C_003EFINAL, ___003C_003ETRANSIENT, ___003C_003EVOLATILE, ___003C_003ESYNCHRONIZED,
				___003C_003ENATIVE, ___003C_003ESTRICTFP, ___003C_003ETRANSITIVE
			};
		}
	}

	
	private sealed class ___003C_003EAnon0 : Function
	{
		internal ___003C_003EAnon0()
		{
		}

		public object apply(object P_0)
		{
			Modifier result = new Modifier((Keyword)P_0);
			
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

	private Keyword keyword;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
		
	
	public static NodeList createModifierList(params Keyword[] modifiers)
	{
		return (NodeList)Arrays.stream(modifiers).map(new ___003C_003EAnon0()).collect(NodeList.toNodeList());
	}

	
	
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public Modifier(Keyword keyword)
		: this(null, keyword)
	{
	}

	public virtual Keyword getKeyword()
	{
		return keyword;
	}

	
	
	public Modifier()
		: this(Keyword.___003C_003EPUBLIC)
	{
	}

	
	
	
	public Modifier(TokenRange tokenRange, Keyword keyword)
		: base(tokenRange)
	{
		setKeyword(keyword);
		customInitialization();
	}

	
	
	
	public virtual Modifier setKeyword(Keyword keyword)
	{
		Utils.assertNotNull(keyword);
		if (keyword == this.keyword)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003EKEYWORD, this.keyword, keyword);
		this.keyword = keyword;
		return this;
	}

	
		
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual ModifierMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EmodifierMetaModel;
	}

	
	
	public new virtual Modifier clone()
	{
		return (Modifier)accept(new CloneVisitor(), null);
	}

	
	
	public static Modifier publicModifier()
	{
		Modifier result = new Modifier(Keyword.___003C_003EPUBLIC);
		
		return result;
	}

	
	
	public static Modifier protectedModifier()
	{
		Modifier result = new Modifier(Keyword.___003C_003EPROTECTED);
		
		return result;
	}

	
	
	public static Modifier privateModifier()
	{
		Modifier result = new Modifier(Keyword.___003C_003EPRIVATE);
		
		return result;
	}

	
	
	public static Modifier abstractModifier()
	{
		Modifier result = new Modifier(Keyword.___003C_003EABSTRACT);
		
		return result;
	}

	
	
	public static Modifier staticModifier()
	{
		Modifier result = new Modifier(Keyword.___003C_003ESTATIC);
		
		return result;
	}

	
	
	public static Modifier finalModifier()
	{
		Modifier result = new Modifier(Keyword.___003C_003EFINAL);
		
		return result;
	}

	
	
	public static Modifier transientModifier()
	{
		Modifier result = new Modifier(Keyword.___003C_003ETRANSIENT);
		
		return result;
	}

	
	
	public static Modifier volatileModifier()
	{
		Modifier result = new Modifier(Keyword.___003C_003EVOLATILE);
		
		return result;
	}

	
	
	public static Modifier synchronizedModifier()
	{
		Modifier result = new Modifier(Keyword.___003C_003ESYNCHRONIZED);
		
		return result;
	}

	
	
	public static Modifier nativeModifier()
	{
		Modifier result = new Modifier(Keyword.___003C_003ENATIVE);
		
		return result;
	}

	
	
	public static Modifier strictfpModifier()
	{
		Modifier result = new Modifier(Keyword.___003C_003ESTRICTFP);
		
		return result;
	}

	
	
	public static Modifier transitiveModifier()
	{
		Modifier result = new Modifier(Keyword.___003C_003ETRANSITIVE);
		
		return result;
	}

	
		
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	
	
	
	
	public virtual NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		ModifierMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Node _003Cbridge_003Eclone()
	{
		Modifier result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		Modifier result = clone();
		
		return result;
	}

	
	static Modifier()
	{
		Node.___003Cclinit_003E();
	}
}
