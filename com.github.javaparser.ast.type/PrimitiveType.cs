using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.resolution.types;
using com.github.javaparser.utils;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.type;


public class PrimitiveType : Type, NodeWithAnnotations
{
	[Serializable]
	[InnerClass(null, Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		
	public class Primitive : java.lang.Enum
	{
		[Serializable]
		
		public enum __Enum
		{
			BOOLEAN,
			CHAR,
			BYTE,
			SHORT,
			INT,
			LONG,
			FLOAT,
			DOUBLE
		}

		
		internal static Primitive ___003C_003EBOOLEAN;

		
		internal static Primitive ___003C_003ECHAR;

		
		internal static Primitive ___003C_003EBYTE;

		
		internal static Primitive ___003C_003ESHORT;

		
		internal static Primitive ___003C_003EINT;

		
		internal static Primitive ___003C_003ELONG;

		
		internal static Primitive ___003C_003EFLOAT;

		
		internal static Primitive ___003C_003EDOUBLE;

		
		internal string nameOfBoxedType;

		
		internal string descriptor;

		private string codeRepresentation;

		
		private static Primitive[] _0024VALUES;

		
		public static Primitive BOOLEAN
		{
			
			get
			{
				return ___003C_003EBOOLEAN;
			}
		}

		
		public static Primitive CHAR
		{
			
			get
			{
				return ___003C_003ECHAR;
			}
		}

		
		public static Primitive BYTE
		{
			
			get
			{
				return ___003C_003EBYTE;
			}
		}

		
		public static Primitive SHORT
		{
			
			get
			{
				return ___003C_003ESHORT;
			}
		}

		
		public static Primitive INT
		{
			
			get
			{
				return ___003C_003EINT;
			}
		}

		
		public static Primitive LONG
		{
			
			get
			{
				return ___003C_003ELONG;
			}
		}

		
		public static Primitive FLOAT
		{
			
			get
			{
				return ___003C_003EFLOAT;
			}
		}

		
		public static Primitive DOUBLE
		{
			
			get
			{
				return ___003C_003EDOUBLE;
			}
		}

		
		
		public static void ___003Cclinit_003E()
		{
		}

		
				[MethodParameters(new Modifiers[]
		{
			Modifiers.Synthetic,
			Modifiers.Synthetic,
			(Modifiers)0,
			(Modifiers)0
		})]
		
		private Primitive(string _0024enum_0024name, int _0024enum_0024ordinal, string nameOfBoxedType, string descriptor)
			: base(_0024enum_0024name, _0024enum_0024ordinal)
		{
			this.nameOfBoxedType = nameOfBoxedType;
			codeRepresentation = java.lang.String.instancehelper_toLowerCase(name());
			this.descriptor = descriptor;
			GC.KeepAlive(this);
		}

		
		
		public static Primitive[] values()
		{
			return (Primitive[])_0024VALUES.Clone();
		}

		
		
		
		public static Primitive valueOf(string name)
		{
			return (Primitive)java.lang.Enum.valueOf(ClassLiteral<Primitive>.Value, name);
		}

		
		
		public virtual ClassOrInterfaceType toBoxedType()
		{
			ClassOrInterfaceType result = StaticJavaParser.parseClassOrInterfaceType(nameOfBoxedType);
			
			return result;
		}

		public virtual string asString()
		{
			return codeRepresentation;
		}

		
		static Primitive()
		{
			___003C_003EBOOLEAN = new Primitive("BOOLEAN", 0, "Boolean", "Z");
			___003C_003ECHAR = new Primitive("CHAR", 1, "Character", "C");
			___003C_003EBYTE = new Primitive("BYTE", 2, "Byte", "B");
			___003C_003ESHORT = new Primitive("SHORT", 3, "Short", "S");
			___003C_003EINT = new Primitive("INT", 4, "Integer", "I");
			___003C_003ELONG = new Primitive("LONG", 5, "Long", "J");
			___003C_003EFLOAT = new Primitive("FLOAT", 6, "Float", "F");
			___003C_003EDOUBLE = new Primitive("DOUBLE", 7, "Double", "D");
			_0024VALUES = new Primitive[8] { ___003C_003EBOOLEAN, ___003C_003ECHAR, ___003C_003EBYTE, ___003C_003ESHORT, ___003C_003EINT, ___003C_003ELONG, ___003C_003EFLOAT, ___003C_003EDOUBLE };
		}
	}

	
		internal static HashMap unboxMap;

	private Primitive type;

	
	
	public new static void ___003Cclinit_003E()
	{
	}

	
	
	
	public PrimitiveType(Primitive type)
		: this(null, type, new NodeList())
	{
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public PrimitiveType(TokenRange tokenRange, Primitive type, NodeList annotations)
		: base(tokenRange, annotations)
	{
		setType(type);
		customInitialization();
	}

	
	
	
	public virtual PrimitiveType setType(Primitive type)
	{
		Utils.assertNotNull(type);
		if (type == this.type)
		{
			return this;
		}
		notifyPropertyChange(ObservableProperty.___003C_003ETYPE, this.type, type);
		this.type = type;
		return this;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public override object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
	
	public new virtual ResolvedPrimitiveType resolve()
	{
		return (ResolvedPrimitiveType)getSymbolResolver().toResolvedType(this, ClassLiteral<ResolvedPrimitiveType>.Value);
	}

	
	
	public new virtual PrimitiveTypeMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EprimitiveTypeMetaModel;
	}

	
	
	public new virtual PrimitiveType clone()
	{
		return (PrimitiveType)accept(new CloneVisitor(), null);
	}

	
		
	
	public new virtual PrimitiveType setAnnotations(NodeList annotations)
	{
		return (PrimitiveType)base.setAnnotations(annotations);
	}

	
	
	public static PrimitiveType booleanType()
	{
		PrimitiveType result = new PrimitiveType(Primitive.___003C_003EBOOLEAN);
		
		return result;
	}

	
	
	public static PrimitiveType charType()
	{
		PrimitiveType result = new PrimitiveType(Primitive.___003C_003ECHAR);
		
		return result;
	}

	
	
	public static PrimitiveType byteType()
	{
		PrimitiveType result = new PrimitiveType(Primitive.___003C_003EBYTE);
		
		return result;
	}

	
	
	public static PrimitiveType shortType()
	{
		PrimitiveType result = new PrimitiveType(Primitive.___003C_003ESHORT);
		
		return result;
	}

	
	
	public static PrimitiveType intType()
	{
		PrimitiveType result = new PrimitiveType(Primitive.___003C_003EINT);
		
		return result;
	}

	
	
	public static PrimitiveType longType()
	{
		PrimitiveType result = new PrimitiveType(Primitive.___003C_003ELONG);
		
		return result;
	}

	
	
	public static PrimitiveType floatType()
	{
		PrimitiveType result = new PrimitiveType(Primitive.___003C_003EFLOAT);
		
		return result;
	}

	
	
	public static PrimitiveType doubleType()
	{
		PrimitiveType result = new PrimitiveType(Primitive.___003C_003EDOUBLE);
		
		return result;
	}

	
	
	public PrimitiveType()
		: this(null, Primitive.___003C_003EINT, new NodeList())
	{
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		(Modifiers)0
	})]
	
	[AllFieldsConstructor(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/ast/AllFieldsConstructor;"
	})]
	public PrimitiveType(Primitive type, NodeList annotations)
		: this(null, type, annotations)
	{
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public override void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	public virtual Primitive getType()
	{
		return type;
	}

	
	
	public virtual ClassOrInterfaceType toBoxedType()
	{
		ClassOrInterfaceType result = type.toBoxedType();
		
		return result;
	}

	
	public override string toDescriptor()
	{
		return type.descriptor;
	}

	
	
	public override string asString()
	{
		string result = type.asString();
		
		return result;
	}

	public override bool isPrimitiveType()
	{
		return true;
	}

	public override PrimitiveType asPrimitiveType()
	{
		return this;
	}

	
		
	
	public override void ifPrimitiveType(Consumer action)
	{
		action.accept(this);
	}

	
		
	public override Optional toPrimitiveType()
	{
		Optional result = Optional.of(this);
		
		return result;
	}

	
	
	
	
	public new virtual ResolvedType _003Cbridge_003Eresolve()
	{
		ResolvedPrimitiveType result = resolve();
		
		return result;
	}

	
	
	
	
	public new virtual TypeMetaModel _003Cbridge_003EgetMetaModel()
	{
		PrimitiveTypeMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Type _003Cbridge_003Eclone()
	{
		PrimitiveType result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Type _003Cbridge_003EsetAnnotations(NodeList annotations)
	{
		PrimitiveType result = setAnnotations(annotations);
		
		return result;
	}

	
	
	
	
	public override object _003Cbridge_003Eresolve()
	{
		ResolvedPrimitiveType result = resolve();
		
		return result;
	}

	
	
	
	
	public override NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		PrimitiveTypeMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public override Node _003Cbridge_003Eclone()
	{
		PrimitiveType result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		PrimitiveType result = clone();
		
		return result;
	}

	
	
	
	
	
	public virtual Node _003Cbridge_003EsetAnnotations(NodeList annotations)
	{
		PrimitiveType result = setAnnotations(annotations);
		
		return result;
	}

	
	static PrimitiveType()
	{
		Type.___003Cclinit_003E();
		unboxMap = new HashMap();
		Primitive[] array = Primitive.values();
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			Primitive primitive = array[i];
			unboxMap.put(primitive.nameOfBoxedType, primitive);
		}
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node setAnnotation(int P_0, AnnotationExpr P_1)
	{
		return NodeWithAnnotations._003Cdefault_003EsetAnnotation(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addAnnotation(AnnotationExpr P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddAnnotation(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addAnnotation(string P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddAnnotation(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual NormalAnnotationExpr addAndGetAnnotation(string P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddAndGetAnnotation(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addAnnotation(Class P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddAnnotation(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual NormalAnnotationExpr addAndGetAnnotation(Class P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddAndGetAnnotation(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addMarkerAnnotation(string P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddMarkerAnnotation(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addMarkerAnnotation(Class P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EaddMarkerAnnotation(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addSingleMemberAnnotation(string P_0, Expression P_1)
	{
		return NodeWithAnnotations._003Cdefault_003EaddSingleMemberAnnotation(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addSingleMemberAnnotation(Class P_0, Expression P_1)
	{
		return NodeWithAnnotations._003Cdefault_003EaddSingleMemberAnnotation(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addSingleMemberAnnotation(string P_0, string P_1)
	{
		return NodeWithAnnotations._003Cdefault_003EaddSingleMemberAnnotation(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Node addSingleMemberAnnotation(Class P_0, string P_1)
	{
		return NodeWithAnnotations._003Cdefault_003EaddSingleMemberAnnotation(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isAnnotationPresent(string P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EisAnnotationPresent(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isAnnotationPresent(Class P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EisAnnotationPresent(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional getAnnotationByName(string P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EgetAnnotationByName(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional getAnnotationByClass(Class P_0)
	{
		return NodeWithAnnotations._003Cdefault_003EgetAnnotationByClass(this, P_0);
	}

	Node NodeWithAnnotations.NodeWithAnnotations_003A_003AsetAnnotations(NodeList P_0)
	{
		return this._003Cbridge_003EsetAnnotations(P_0);
	}
}
