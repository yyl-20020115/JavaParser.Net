using System;
using System.Runtime.CompilerServices;
using com.github.javaparser.utils;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.lang.reflect;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.observer;

[Serializable]

public class ObservableProperty : java.lang.Enum
{
	[Serializable]
	
	public enum __Enum
	{
		ANNOTATIONS,
		ANONYMOUS_CLASS_BODY,
		ARGUMENTS,
		ASTERISK,
		BODY,
		CATCH_CLAUSES,
		CHECK,
		CLASS_BODY,
		CLASS_DECLARATION,
		COMMENT,
		COMPARE,
		COMPONENT_TYPE,
		CONDITION,
		CONTENT,
		DEFAULT_VALUE,
		DIMENSION,
		DIRECTIVES,
		ELEMENTS,
		ELEMENT_TYPE,
		ELSE_EXPR,
		ELSE_STMT,
		ENCLOSING_PARAMETERS,
		ENTRIES,
		EXPRESSION,
		EXTENDED_TYPE,
		EXTENDED_TYPES,
		FINALLY_BLOCK,
		IDENTIFIER,
		IMPLEMENTED_TYPES,
		IMPORTS,
		INDEX,
		INITIALIZATION,
		INITIALIZER,
		INNER,
		INTERFACE,
		ITERABLE,
		KEYWORD,
		LABEL,
		LABELS,
		LEFT,
		LEVELS,
		MEMBERS,
		MEMBER_VALUE,
		MESSAGE,
		MODIFIERS,
		MODULE,
		MODULE_NAMES,
		NAME,
		OPEN,
		OPERATOR,
		ORIGIN,
		PACKAGE_DECLARATION,
		PAIRS,
		PARAMETER,
		PARAMETERS,
		PATTERN,
		QUALIFIER,
		RECEIVER_PARAMETER,
		RECORD_DECLARATION,
		RESOURCES,
		RIGHT,
		SCOPE,
		SELECTOR,
		STATEMENT,
		STATEMENTS,
		STATIC,
		SUPER_TYPE,
		TARGET,
		THEN_EXPR,
		THEN_STMT,
		THIS,
		THROWN_EXCEPTIONS,
		TRY_BLOCK,
		TYPE,
		TYPES,
		TYPE_ARGUMENTS,
		TYPE_BOUND,
		TYPE_NAME,
		TYPE_PARAMETERS,
		UPDATE,
		VALUE,
		VALUES,
		VARIABLE,
		VARIABLES,
		VAR_ARGS,
		VAR_ARGS_ANNOTATIONS,
		WITH,
		CASCADING_IF_STMT,
		ELSE_BLOCK,
		ELSE_BRANCH,
		EXPRESSION_BODY,
		MAXIMUM_COMMON_TYPE,
		POSTFIX,
		PREFIX,
		THEN_BLOCK,
		USING_DIAMOND_OPERATOR,
		RANGE,
		COMMENTED_NODE
	}

	[Serializable]
	[InnerClass(null, Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		
	internal sealed class Type : java.lang.Enum
	{
		
		public static Type SINGLE_ATTRIBUTE;

		
		public static Type SINGLE_REFERENCE;

		
		public static Type MULTIPLE_ATTRIBUTE;

		
		public static Type MULTIPLE_REFERENCE;

		private bool multiple;

		private bool node;

		
		private static Type[] _0024VALUES;

		
		
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
		
		private Type(string _0024enum_0024name, int _0024enum_0024ordinal, bool multiple, bool node)
			: base(_0024enum_0024name, _0024enum_0024ordinal)
		{
			this.multiple = multiple;
			this.node = node;
			GC.KeepAlive(this);
		}

		
		
		public static Type[] values()
		{
			return (Type[])_0024VALUES.Clone();
		}

		
		
		
		public static Type valueOf(string name)
		{
			return (Type)java.lang.Enum.valueOf(ClassLiteral<Type>.Value, name);
		}

		
		
		internal static bool access_0024000(Type P_0)
		{
			return P_0.node;
		}

		
		
		internal static bool access_0024100(Type P_0)
		{
			return P_0.multiple;
		}

		
		static Type()
		{
			SINGLE_ATTRIBUTE = new Type("SINGLE_ATTRIBUTE", 0, multiple: false, node: false);
			SINGLE_REFERENCE = new Type("SINGLE_REFERENCE", 1, multiple: false, node: true);
			MULTIPLE_ATTRIBUTE = new Type("MULTIPLE_ATTRIBUTE", 2, multiple: true, node: false);
			MULTIPLE_REFERENCE = new Type("MULTIPLE_REFERENCE", 3, multiple: true, node: true);
			_0024VALUES = new Type[4] { SINGLE_ATTRIBUTE, SINGLE_REFERENCE, MULTIPLE_ATTRIBUTE, MULTIPLE_REFERENCE };
		}
	}

	
	private sealed class ___003C_003EAnon0 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon0(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024fromCamelCaseName_00240(arg_00241, (ObservableProperty)P_0);
			
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

	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	
	internal static ObservableProperty ___003C_003EANNOTATIONS;

	
	internal static ObservableProperty ___003C_003EANONYMOUS_CLASS_BODY;

	
	internal static ObservableProperty ___003C_003EARGUMENTS;

	
	internal static ObservableProperty ___003C_003EASTERISK;

	
	internal static ObservableProperty ___003C_003EBODY;

	
	internal static ObservableProperty ___003C_003ECATCH_CLAUSES;

	
	internal static ObservableProperty ___003C_003ECHECK;

	
	internal static ObservableProperty ___003C_003ECLASS_BODY;

	
	internal static ObservableProperty ___003C_003ECLASS_DECLARATION;

	
	internal static ObservableProperty ___003C_003ECOMMENT;

	
	internal static ObservableProperty ___003C_003ECOMPARE;

	
	internal static ObservableProperty ___003C_003ECOMPONENT_TYPE;

	
	internal static ObservableProperty ___003C_003ECONDITION;

	
	internal static ObservableProperty ___003C_003ECONTENT;

	
	internal static ObservableProperty ___003C_003EDEFAULT_VALUE;

	
	internal static ObservableProperty ___003C_003EDIMENSION;

	
	internal static ObservableProperty ___003C_003EDIRECTIVES;

	
	internal static ObservableProperty ___003C_003EELEMENTS;

	
	internal static ObservableProperty ___003C_003EELEMENT_TYPE;

	
	internal static ObservableProperty ___003C_003EELSE_EXPR;

	
	internal static ObservableProperty ___003C_003EELSE_STMT;

	
	internal static ObservableProperty ___003C_003EENCLOSING_PARAMETERS;

	
	internal static ObservableProperty ___003C_003EENTRIES;

	
	internal static ObservableProperty ___003C_003EEXPRESSION;

	
	internal static ObservableProperty ___003C_003EEXTENDED_TYPE;

	
	internal static ObservableProperty ___003C_003EEXTENDED_TYPES;

	
	internal static ObservableProperty ___003C_003EFINALLY_BLOCK;

	
	internal static ObservableProperty ___003C_003EIDENTIFIER;

	
	internal static ObservableProperty ___003C_003EIMPLEMENTED_TYPES;

	
	internal static ObservableProperty ___003C_003EIMPORTS;

	
	internal static ObservableProperty ___003C_003EINDEX;

	
	internal static ObservableProperty ___003C_003EINITIALIZATION;

	
	internal static ObservableProperty ___003C_003EINITIALIZER;

	
	internal static ObservableProperty ___003C_003EINNER;

	
	internal static ObservableProperty ___003C_003EINTERFACE;

	
	internal static ObservableProperty ___003C_003EITERABLE;

	
	internal static ObservableProperty ___003C_003EKEYWORD;

	
	internal static ObservableProperty ___003C_003ELABEL;

	
	internal static ObservableProperty ___003C_003ELABELS;

	
	internal static ObservableProperty ___003C_003ELEFT;

	
	internal static ObservableProperty ___003C_003ELEVELS;

	
	internal static ObservableProperty ___003C_003EMEMBERS;

	
	internal static ObservableProperty ___003C_003EMEMBER_VALUE;

	
	internal static ObservableProperty ___003C_003EMESSAGE;

	
	internal static ObservableProperty ___003C_003EMODIFIERS;

	
	internal static ObservableProperty ___003C_003EMODULE;

	
	internal static ObservableProperty ___003C_003EMODULE_NAMES;

	
	internal static ObservableProperty ___003C_003ENAME;

	
	internal static ObservableProperty ___003C_003EOPEN;

	
	internal static ObservableProperty ___003C_003EOPERATOR;

	
	internal static ObservableProperty ___003C_003EORIGIN;

	
	internal static ObservableProperty ___003C_003EPACKAGE_DECLARATION;

	
	internal static ObservableProperty ___003C_003EPAIRS;

	
	internal static ObservableProperty ___003C_003EPARAMETER;

	
	internal static ObservableProperty ___003C_003EPARAMETERS;

	
	internal static ObservableProperty ___003C_003EPATTERN;

	
	internal static ObservableProperty ___003C_003EQUALIFIER;

	
	internal static ObservableProperty ___003C_003ERECEIVER_PARAMETER;

	
	internal static ObservableProperty ___003C_003ERECORD_DECLARATION;

	
	internal static ObservableProperty ___003C_003ERESOURCES;

	
	internal static ObservableProperty ___003C_003ERIGHT;

	
	internal static ObservableProperty ___003C_003ESCOPE;

	
	internal static ObservableProperty ___003C_003ESELECTOR;

	
	internal static ObservableProperty ___003C_003ESTATEMENT;

	
	internal static ObservableProperty ___003C_003ESTATEMENTS;

	
	internal static ObservableProperty ___003C_003ESTATIC;

	
	internal static ObservableProperty ___003C_003ESUPER_TYPE;

	
	internal static ObservableProperty ___003C_003ETARGET;

	
	internal static ObservableProperty ___003C_003ETHEN_EXPR;

	
	internal static ObservableProperty ___003C_003ETHEN_STMT;

	
	internal static ObservableProperty ___003C_003ETHIS;

	
	internal static ObservableProperty ___003C_003ETHROWN_EXCEPTIONS;

	
	internal static ObservableProperty ___003C_003ETRY_BLOCK;

	
	internal static ObservableProperty ___003C_003ETYPE;

	
	internal static ObservableProperty ___003C_003ETYPES;

	
	internal static ObservableProperty ___003C_003ETYPE_ARGUMENTS;

	
	internal static ObservableProperty ___003C_003ETYPE_BOUND;

	
	internal static ObservableProperty ___003C_003ETYPE_NAME;

	
	internal static ObservableProperty ___003C_003ETYPE_PARAMETERS;

	
	internal static ObservableProperty ___003C_003EUPDATE;

	
	internal static ObservableProperty ___003C_003EVALUE;

	
	internal static ObservableProperty ___003C_003EVALUES;

	
	internal static ObservableProperty ___003C_003EVARIABLE;

	
	internal static ObservableProperty ___003C_003EVARIABLES;

	
	internal static ObservableProperty ___003C_003EVAR_ARGS;

	
	internal static ObservableProperty ___003C_003EVAR_ARGS_ANNOTATIONS;

	
	internal static ObservableProperty ___003C_003EWITH;

	
	internal static ObservableProperty ___003C_003ECASCADING_IF_STMT;

	
	internal static ObservableProperty ___003C_003EELSE_BLOCK;

	
	internal static ObservableProperty ___003C_003EELSE_BRANCH;

	
	internal static ObservableProperty ___003C_003EEXPRESSION_BODY;

	
	internal static ObservableProperty ___003C_003EMAXIMUM_COMMON_TYPE;

	
	internal static ObservableProperty ___003C_003EPOSTFIX;

	
	internal static ObservableProperty ___003C_003EPREFIX;

	
	internal static ObservableProperty ___003C_003ETHEN_BLOCK;

	
	internal static ObservableProperty ___003C_003EUSING_DIAMOND_OPERATOR;

	
	internal static ObservableProperty ___003C_003ERANGE;

	
	internal static ObservableProperty ___003C_003ECOMMENTED_NODE;

	private Type type;

	private bool derived;

	
	private static ObservableProperty[] _0024VALUES;

	
	private static CallerID ___003CcallerID_003E;

	
	public static ObservableProperty ANNOTATIONS
	{
		
		get
		{
			return ___003C_003EANNOTATIONS;
		}
	}

	
	public static ObservableProperty ANONYMOUS_CLASS_BODY
	{
		
		get
		{
			return ___003C_003EANONYMOUS_CLASS_BODY;
		}
	}

	
	public static ObservableProperty ARGUMENTS
	{
		
		get
		{
			return ___003C_003EARGUMENTS;
		}
	}

	
	public static ObservableProperty ASTERISK
	{
		
		get
		{
			return ___003C_003EASTERISK;
		}
	}

	
	public static ObservableProperty BODY
	{
		
		get
		{
			return ___003C_003EBODY;
		}
	}

	
	public static ObservableProperty CATCH_CLAUSES
	{
		
		get
		{
			return ___003C_003ECATCH_CLAUSES;
		}
	}

	
	public static ObservableProperty CHECK
	{
		
		get
		{
			return ___003C_003ECHECK;
		}
	}

	
	public static ObservableProperty CLASS_BODY
	{
		
		get
		{
			return ___003C_003ECLASS_BODY;
		}
	}

	
	public static ObservableProperty CLASS_DECLARATION
	{
		
		get
		{
			return ___003C_003ECLASS_DECLARATION;
		}
	}

	
	public static ObservableProperty COMMENT
	{
		
		get
		{
			return ___003C_003ECOMMENT;
		}
	}

	
	public static ObservableProperty COMPARE
	{
		
		get
		{
			return ___003C_003ECOMPARE;
		}
	}

	
	public static ObservableProperty COMPONENT_TYPE
	{
		
		get
		{
			return ___003C_003ECOMPONENT_TYPE;
		}
	}

	
	public static ObservableProperty CONDITION
	{
		
		get
		{
			return ___003C_003ECONDITION;
		}
	}

	
	public static ObservableProperty CONTENT
	{
		
		get
		{
			return ___003C_003ECONTENT;
		}
	}

	
	public static ObservableProperty DEFAULT_VALUE
	{
		
		get
		{
			return ___003C_003EDEFAULT_VALUE;
		}
	}

	
	public static ObservableProperty DIMENSION
	{
		
		get
		{
			return ___003C_003EDIMENSION;
		}
	}

	
	public static ObservableProperty DIRECTIVES
	{
		
		get
		{
			return ___003C_003EDIRECTIVES;
		}
	}

	
	public static ObservableProperty ELEMENTS
	{
		
		get
		{
			return ___003C_003EELEMENTS;
		}
	}

	
	public static ObservableProperty ELEMENT_TYPE
	{
		
		get
		{
			return ___003C_003EELEMENT_TYPE;
		}
	}

	
	public static ObservableProperty ELSE_EXPR
	{
		
		get
		{
			return ___003C_003EELSE_EXPR;
		}
	}

	
	public static ObservableProperty ELSE_STMT
	{
		
		get
		{
			return ___003C_003EELSE_STMT;
		}
	}

	
	public static ObservableProperty ENCLOSING_PARAMETERS
	{
		
		get
		{
			return ___003C_003EENCLOSING_PARAMETERS;
		}
	}

	
	public static ObservableProperty ENTRIES
	{
		
		get
		{
			return ___003C_003EENTRIES;
		}
	}

	
	public static ObservableProperty EXPRESSION
	{
		
		get
		{
			return ___003C_003EEXPRESSION;
		}
	}

	
	public static ObservableProperty EXTENDED_TYPE
	{
		
		get
		{
			return ___003C_003EEXTENDED_TYPE;
		}
	}

	
	public static ObservableProperty EXTENDED_TYPES
	{
		
		get
		{
			return ___003C_003EEXTENDED_TYPES;
		}
	}

	
	public static ObservableProperty FINALLY_BLOCK
	{
		
		get
		{
			return ___003C_003EFINALLY_BLOCK;
		}
	}

	
	public static ObservableProperty IDENTIFIER
	{
		
		get
		{
			return ___003C_003EIDENTIFIER;
		}
	}

	
	public static ObservableProperty IMPLEMENTED_TYPES
	{
		
		get
		{
			return ___003C_003EIMPLEMENTED_TYPES;
		}
	}

	
	public static ObservableProperty IMPORTS
	{
		
		get
		{
			return ___003C_003EIMPORTS;
		}
	}

	
	public static ObservableProperty INDEX
	{
		
		get
		{
			return ___003C_003EINDEX;
		}
	}

	
	public static ObservableProperty INITIALIZATION
	{
		
		get
		{
			return ___003C_003EINITIALIZATION;
		}
	}

	
	public static ObservableProperty INITIALIZER
	{
		
		get
		{
			return ___003C_003EINITIALIZER;
		}
	}

	
	public static ObservableProperty INNER
	{
		
		get
		{
			return ___003C_003EINNER;
		}
	}

	
	public static ObservableProperty INTERFACE
	{
		
		get
		{
			return ___003C_003EINTERFACE;
		}
	}

	
	public static ObservableProperty ITERABLE
	{
		
		get
		{
			return ___003C_003EITERABLE;
		}
	}

	
	public static ObservableProperty KEYWORD
	{
		
		get
		{
			return ___003C_003EKEYWORD;
		}
	}

	
	public static ObservableProperty LABEL
	{
		
		get
		{
			return ___003C_003ELABEL;
		}
	}

	
	public static ObservableProperty LABELS
	{
		
		get
		{
			return ___003C_003ELABELS;
		}
	}

	
	public static ObservableProperty LEFT
	{
		
		get
		{
			return ___003C_003ELEFT;
		}
	}

	
	public static ObservableProperty LEVELS
	{
		
		get
		{
			return ___003C_003ELEVELS;
		}
	}

	
	public static ObservableProperty MEMBERS
	{
		
		get
		{
			return ___003C_003EMEMBERS;
		}
	}

	
	public static ObservableProperty MEMBER_VALUE
	{
		
		get
		{
			return ___003C_003EMEMBER_VALUE;
		}
	}

	
	public static ObservableProperty MESSAGE
	{
		
		get
		{
			return ___003C_003EMESSAGE;
		}
	}

	
	public static ObservableProperty MODIFIERS
	{
		
		get
		{
			return ___003C_003EMODIFIERS;
		}
	}

	
	public static ObservableProperty MODULE
	{
		
		get
		{
			return ___003C_003EMODULE;
		}
	}

	
	public static ObservableProperty MODULE_NAMES
	{
		
		get
		{
			return ___003C_003EMODULE_NAMES;
		}
	}

	
	public static ObservableProperty NAME
	{
		
		get
		{
			return ___003C_003ENAME;
		}
	}

	
	public static ObservableProperty OPEN
	{
		
		get
		{
			return ___003C_003EOPEN;
		}
	}

	
	public static ObservableProperty OPERATOR
	{
		
		get
		{
			return ___003C_003EOPERATOR;
		}
	}

	
	public static ObservableProperty ORIGIN
	{
		
		get
		{
			return ___003C_003EORIGIN;
		}
	}

	
	public static ObservableProperty PACKAGE_DECLARATION
	{
		
		get
		{
			return ___003C_003EPACKAGE_DECLARATION;
		}
	}

	
	public static ObservableProperty PAIRS
	{
		
		get
		{
			return ___003C_003EPAIRS;
		}
	}

	
	public static ObservableProperty PARAMETER
	{
		
		get
		{
			return ___003C_003EPARAMETER;
		}
	}

	
	public static ObservableProperty PARAMETERS
	{
		
		get
		{
			return ___003C_003EPARAMETERS;
		}
	}

	
	public static ObservableProperty PATTERN
	{
		
		get
		{
			return ___003C_003EPATTERN;
		}
	}

	
	public static ObservableProperty QUALIFIER
	{
		
		get
		{
			return ___003C_003EQUALIFIER;
		}
	}

	
	public static ObservableProperty RECEIVER_PARAMETER
	{
		
		get
		{
			return ___003C_003ERECEIVER_PARAMETER;
		}
	}

	
	public static ObservableProperty RECORD_DECLARATION
	{
		
		get
		{
			return ___003C_003ERECORD_DECLARATION;
		}
	}

	
	public static ObservableProperty RESOURCES
	{
		
		get
		{
			return ___003C_003ERESOURCES;
		}
	}

	
	public static ObservableProperty RIGHT
	{
		
		get
		{
			return ___003C_003ERIGHT;
		}
	}

	
	public static ObservableProperty SCOPE
	{
		
		get
		{
			return ___003C_003ESCOPE;
		}
	}

	
	public static ObservableProperty SELECTOR
	{
		
		get
		{
			return ___003C_003ESELECTOR;
		}
	}

	
	public static ObservableProperty STATEMENT
	{
		
		get
		{
			return ___003C_003ESTATEMENT;
		}
	}

	
	public static ObservableProperty STATEMENTS
	{
		
		get
		{
			return ___003C_003ESTATEMENTS;
		}
	}

	
	public static ObservableProperty STATIC
	{
		
		get
		{
			return ___003C_003ESTATIC;
		}
	}

	
	public static ObservableProperty SUPER_TYPE
	{
		
		get
		{
			return ___003C_003ESUPER_TYPE;
		}
	}

	
	public static ObservableProperty TARGET
	{
		
		get
		{
			return ___003C_003ETARGET;
		}
	}

	
	public static ObservableProperty THEN_EXPR
	{
		
		get
		{
			return ___003C_003ETHEN_EXPR;
		}
	}

	
	public static ObservableProperty THEN_STMT
	{
		
		get
		{
			return ___003C_003ETHEN_STMT;
		}
	}

	
	public static ObservableProperty THIS
	{
		
		get
		{
			return ___003C_003ETHIS;
		}
	}

	
	public static ObservableProperty THROWN_EXCEPTIONS
	{
		
		get
		{
			return ___003C_003ETHROWN_EXCEPTIONS;
		}
	}

	
	public static ObservableProperty TRY_BLOCK
	{
		
		get
		{
			return ___003C_003ETRY_BLOCK;
		}
	}

	
	public static ObservableProperty TYPE
	{
		
		get
		{
			return ___003C_003ETYPE;
		}
	}

	
	public static ObservableProperty TYPES
	{
		
		get
		{
			return ___003C_003ETYPES;
		}
	}

	
	public static ObservableProperty TYPE_ARGUMENTS
	{
		
		get
		{
			return ___003C_003ETYPE_ARGUMENTS;
		}
	}

	
	public static ObservableProperty TYPE_BOUND
	{
		
		get
		{
			return ___003C_003ETYPE_BOUND;
		}
	}

	
	public static ObservableProperty TYPE_NAME
	{
		
		get
		{
			return ___003C_003ETYPE_NAME;
		}
	}

	
	public static ObservableProperty TYPE_PARAMETERS
	{
		
		get
		{
			return ___003C_003ETYPE_PARAMETERS;
		}
	}

	
	public static ObservableProperty UPDATE
	{
		
		get
		{
			return ___003C_003EUPDATE;
		}
	}

	
	public static ObservableProperty VALUE
	{
		
		get
		{
			return ___003C_003EVALUE;
		}
	}

	
	public static ObservableProperty VALUES
	{
		
		get
		{
			return ___003C_003EVALUES;
		}
	}

	
	public static ObservableProperty VARIABLE
	{
		
		get
		{
			return ___003C_003EVARIABLE;
		}
	}

	
	public static ObservableProperty VARIABLES
	{
		
		get
		{
			return ___003C_003EVARIABLES;
		}
	}

	
	public static ObservableProperty VAR_ARGS
	{
		
		get
		{
			return ___003C_003EVAR_ARGS;
		}
	}

	
	public static ObservableProperty VAR_ARGS_ANNOTATIONS
	{
		
		get
		{
			return ___003C_003EVAR_ARGS_ANNOTATIONS;
		}
	}

	
	public static ObservableProperty WITH
	{
		
		get
		{
			return ___003C_003EWITH;
		}
	}

	
	public static ObservableProperty CASCADING_IF_STMT
	{
		
		get
		{
			return ___003C_003ECASCADING_IF_STMT;
		}
	}

	
	public static ObservableProperty ELSE_BLOCK
	{
		
		get
		{
			return ___003C_003EELSE_BLOCK;
		}
	}

	
	public static ObservableProperty ELSE_BRANCH
	{
		
		get
		{
			return ___003C_003EELSE_BRANCH;
		}
	}

	
	public static ObservableProperty EXPRESSION_BODY
	{
		
		get
		{
			return ___003C_003EEXPRESSION_BODY;
		}
	}

	
	public static ObservableProperty MAXIMUM_COMMON_TYPE
	{
		
		get
		{
			return ___003C_003EMAXIMUM_COMMON_TYPE;
		}
	}

	
	public static ObservableProperty POSTFIX
	{
		
		get
		{
			return ___003C_003EPOSTFIX;
		}
	}

	
	public static ObservableProperty PREFIX
	{
		
		get
		{
			return ___003C_003EPREFIX;
		}
	}

	
	public static ObservableProperty THEN_BLOCK
	{
		
		get
		{
			return ___003C_003ETHEN_BLOCK;
		}
	}

	
	public static ObservableProperty USING_DIAMOND_OPERATOR
	{
		
		get
		{
			return ___003C_003EUSING_DIAMOND_OPERATOR;
		}
	}

	
	public static ObservableProperty RANGE
	{
		
		get
		{
			return ___003C_003ERANGE;
		}
	}

	
	public static ObservableProperty COMMENTED_NODE
	{
		
		get
		{
			return ___003C_003ECOMMENTED_NODE;
		}
	}

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
	
	public static ObservableProperty[] values()
	{
		return (ObservableProperty[])_0024VALUES.Clone();
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	private ObservableProperty(string _0024enum_0024name, int _0024enum_0024ordinal, Type type, bool derived)
		: base(_0024enum_0024name, _0024enum_0024ordinal)
	{
		this.type = type;
		this.derived = derived;
		GC.KeepAlive(this);
	}

	
	
	public virtual bool isAboutNodes()
	{
		bool result = Type.access_0024000(type);
		
		return result;
	}

	
	
	public virtual bool isMultiple()
	{
		bool result = Type.access_0024100(type);
		
		return result;
	}

	
	
	[LineNumberTable(new byte[]
	{
		160, 156, 127, 6, 106, 127, 6, 106, 223, 6,
		127, 57, 98
	})]
	public virtual object getRawValue(Node node)
	{
		//Discarded unreachable code: IL_00ad
		string text = new StringBuilder().append("get").append(Utils.capitalize(camelCaseName())).ToString();
		if (!hasMethod(node, text))
		{
			text = new StringBuilder().append("is").append(Utils.capitalize(camelCaseName())).ToString();
			if (!hasMethod(node, text))
			{
				text = new StringBuilder().append("has").append(Utils.capitalize(camelCaseName())).ToString();
			}
		}
		NoSuchMethodException ex;
		IllegalAccessException ex2;
		InvocationTargetException ex3;
		try
		{
			try
			{
				try
				{
					return java.lang.Object.instancehelper_getClass(node).getMethod(text, new Class[0], ObservableProperty.___003CGetCallerID_003E()).invoke(node, new object[0], ObservableProperty.___003CGetCallerID_003E());
				}
				catch (NoSuchMethodException x)
				{
					ex = ByteCodeHelper.MapException<NoSuchMethodException>(x, ByteCodeHelper.MapFlags.NoRemapping);
				}
			}
			catch (IllegalAccessException x2)
			{
				ex2 = ByteCodeHelper.MapException<IllegalAccessException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_00d3;
			}
		}
		catch (InvocationTargetException x3)
		{
			ex3 = ByteCodeHelper.MapException<InvocationTargetException>(x3, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_00d6;
		}
		object ex4 = ex;
		goto IL_00db;
		IL_00d3:
		ex4 = ex2;
		goto IL_00db;
		IL_00db:
		ReflectiveOperationException cause = (ReflectiveOperationException)ex4;
		string message = new StringBuilder().append("Unable to get value for ").append(name()).append(" from ")
			.append(node)
			.append(" (")
			.append(java.lang.Object.instancehelper_getClass(node).getSimpleName())
			.append(")")
			.ToString();
		
		throw new RuntimeException(message, cause);
		IL_00d6:
		ex4 = ex3;
		goto IL_00db;
	}

	
	
	public virtual string camelCaseName()
	{
		string result = Utils.screamingToCamelCase(name());
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	private bool hasMethod(Node node, string name)
	{
		//Discarded unreachable code: IL_001b
		try
		{
			java.lang.Object.instancehelper_getClass(node).getMethod(name, new Class[0], ObservableProperty.___003CGetCallerID_003E());
			return true;
		}
		catch (NoSuchMethodException)
		{
		}
		
		return false;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic,
		(Modifiers)0
	})]
	
	private ObservableProperty(string _0024enum_0024name, int _0024enum_0024ordinal, Type type)
		: base(_0024enum_0024name, _0024enum_0024ordinal)
	{
		this.type = type;
		derived = false;
		GC.KeepAlive(this);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private ObservableProperty(string _0024enum_0024name, int _0024enum_0024ordinal)
		: this(_0024enum_0024name, _0024enum_0024ordinal, Type.SINGLE_REFERENCE, derived: false)
	{
		GC.KeepAlive(this);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private static bool lambda_0024fromCamelCaseName_00240(string camelCaseName, ObservableProperty v)
	{
		bool result = java.lang.String.instancehelper_equals(v.camelCaseName(), camelCaseName);
		
		return result;
	}

	
	
	
	public static ObservableProperty valueOf(string name)
	{
		return (ObservableProperty)java.lang.Enum.valueOf(ClassLiteral<ObservableProperty>.Value, name);
	}

	
	
	
	public static ObservableProperty fromCamelCaseName(string camelCaseName)
	{
		Optional optional = Arrays.stream(values()).filter(new ___003C_003EAnon0(camelCaseName)).findFirst();
		if (optional.isPresent())
		{
			return (ObservableProperty)optional.get();
		}
		string s = new StringBuilder().append("No property found with the given camel case name: ").append(camelCaseName).ToString();
		
		throw new IllegalArgumentException(s);
	}

	public virtual bool isDerived()
	{
		return derived;
	}

	
	
	public virtual bool isAboutValues()
	{
		return (!isAboutNodes()) ? true : false;
	}

	
	
	public virtual bool isSingle()
	{
		return (!isMultiple()) ? true : false;
	}

	
	
	[LineNumberTable(new byte[]
	{
		160, 89, 136, 104, 108, 104, 103, 104, 142, 164,
		159, 51, 98
	})]
	public virtual Node getValueAsSingleReference(Node node)
	{
		object rawValue = getRawValue(node);
		ClassCastException ex2;
		try
		{
			if (rawValue is Node)
			{
				return (Node)rawValue;
			}
			if (rawValue is Optional)
			{
				Optional optional = (Optional)rawValue;
				if (optional.isPresent())
				{
					return (Node)optional.get();
				}
				return null;
			}
			string message = java.lang.String.format("Property %s returned %s (%s)", name(), java.lang.Object.instancehelper_toString(rawValue), java.lang.Object.instancehelper_getClass(rawValue).getCanonicalName());
			
			throw new RuntimeException(message);
		}
		catch (System.Exception x)
		{
			ClassCastException ex = ByteCodeHelper.MapException<ClassCastException>(x, ByteCodeHelper.MapFlags.None);
			if (ex == null)
			{
				throw;
			}
			ex2 = ex;
		}
		ClassCastException cause = ex2;
		
		throw new RuntimeException(cause);
	}

	
		
	[LineNumberTable(new byte[]
	{
		160, 118, 136, 99, 132, 104, 137, 103, 104, 142,
		191, 3, 98
	})]
	public virtual NodeList getValueAsMultipleReference(Node node)
	{
		//Discarded unreachable code: IL_0040
		object rawValue = getRawValue(node);
		ClassCastException ex2;
		try
		{
			if (rawValue == null)
			{
				return null;
			}
			if (rawValue is NodeList)
			{
				return (NodeList)rawValue;
			}
			Optional optional = (Optional)rawValue;
			if (optional.isPresent())
			{
				return (NodeList)optional.get();
			}
			
		}
		catch (System.Exception x)
		{
			ClassCastException ex = ByteCodeHelper.MapException<ClassCastException>(x, ByteCodeHelper.MapFlags.None);
			if (ex == null)
			{
				throw;
			}
			ex2 = ex;
			goto IL_005b;
		}
		return null;
		IL_005b:
		ClassCastException cause = ex2;
		string message = new StringBuilder().append("Unable to get list value for ").append(name()).append(" from ")
			.append(node)
			.append(" (class: ")
			.append(java.lang.Object.instancehelper_getClass(node).getSimpleName())
			.append(")")
			.ToString();
		
		throw new RuntimeException(message, cause);
	}

	
		
	
	public virtual Collection getValueAsCollection(Node node)
	{
		//Discarded unreachable code: IL_0010
		object rawValue = getRawValue(node);
		ClassCastException ex2;
		try
		{
			return (Collection)rawValue;
		}
		catch (System.Exception x)
		{
			ClassCastException ex = ByteCodeHelper.MapException<ClassCastException>(x, ByteCodeHelper.MapFlags.None);
			if (ex == null)
			{
				throw;
			}
			ex2 = ex;
		}
		ClassCastException cause = ex2;
		string message = new StringBuilder().append("Unable to get list value for ").append(name()).append(" from ")
			.append(node)
			.append(" (class: ")
			.append(java.lang.Object.instancehelper_getClass(node).getSimpleName())
			.append(")")
			.ToString();
		
		throw new RuntimeException(message, cause);
	}

	
	
	
	public virtual string getValueAsStringAttribute(Node node)
	{
		return (string)getRawValue(node);
	}

	
	
	
	public virtual java.lang.Boolean getValueAsBooleanAttribute(Node node)
	{
		return (java.lang.Boolean)getRawValue(node);
	}

	
	
	
	public virtual bool isNull(Node node)
	{
		return null == getRawValue(node);
	}

	
	
	
	public virtual bool isNullOrNotPresent(Node node)
	{
		object rawValue = getRawValue(node);
		if (rawValue == null)
		{
			return true;
		}
		if (rawValue is Optional)
		{
			return (!((Optional)rawValue).isPresent()) ? true : false;
		}
		return false;
	}

	
	
	
	public virtual bool isNullOrEmpty(Node node)
	{
		bool result = Utils.valueIsNullOrEmpty(getRawValue(node));
		
		return result;
	}

	[LineNumberTable(new byte[]
	{
		159, 180, 117, 117, 117, 117, 117, 117, 117, 117,
		117, 118, 118, 118, 118, 118, 118, 118, 118, 118,
		118, 118, 118, 118, 118, 118, 118, 118, 118, 118,
		118, 118, 118, 118, 118, 118, 118, 118, 118, 118,
		118, 118, 118, 118, 118, 118, 118, 118, 118, 118,
		118, 118, 118, 118, 118, 118, 118, 118, 118, 118,
		118, 118, 118, 118, 118, 118, 118, 118, 118, 118,
		118, 118, 118, 118, 118, 118, 118, 118, 118, 118,
		118, 118, 118, 118, 118, 118, 118, 118, 118, 119,
		119, 119, 119, 119, 119, 119, 119, 119, 113, 241,
		159, 156
	})]
	static ObservableProperty()
	{
		___003C_003EANNOTATIONS = new ObservableProperty("ANNOTATIONS", 0, Type.MULTIPLE_REFERENCE);
		___003C_003EANONYMOUS_CLASS_BODY = new ObservableProperty("ANONYMOUS_CLASS_BODY", 1, Type.MULTIPLE_REFERENCE);
		___003C_003EARGUMENTS = new ObservableProperty("ARGUMENTS", 2, Type.MULTIPLE_REFERENCE);
		___003C_003EASTERISK = new ObservableProperty("ASTERISK", 3, Type.SINGLE_ATTRIBUTE);
		___003C_003EBODY = new ObservableProperty("BODY", 4, Type.SINGLE_REFERENCE);
		___003C_003ECATCH_CLAUSES = new ObservableProperty("CATCH_CLAUSES", 5, Type.MULTIPLE_REFERENCE);
		___003C_003ECHECK = new ObservableProperty("CHECK", 6, Type.SINGLE_REFERENCE);
		___003C_003ECLASS_BODY = new ObservableProperty("CLASS_BODY", 7, Type.MULTIPLE_REFERENCE);
		___003C_003ECLASS_DECLARATION = new ObservableProperty("CLASS_DECLARATION", 8, Type.SINGLE_REFERENCE);
		___003C_003ECOMMENT = new ObservableProperty("COMMENT", 9, Type.SINGLE_REFERENCE);
		___003C_003ECOMPARE = new ObservableProperty("COMPARE", 10, Type.SINGLE_REFERENCE);
		___003C_003ECOMPONENT_TYPE = new ObservableProperty("COMPONENT_TYPE", 11, Type.SINGLE_REFERENCE);
		___003C_003ECONDITION = new ObservableProperty("CONDITION", 12, Type.SINGLE_REFERENCE);
		___003C_003ECONTENT = new ObservableProperty("CONTENT", 13, Type.SINGLE_ATTRIBUTE);
		___003C_003EDEFAULT_VALUE = new ObservableProperty("DEFAULT_VALUE", 14, Type.SINGLE_REFERENCE);
		___003C_003EDIMENSION = new ObservableProperty("DIMENSION", 15, Type.SINGLE_REFERENCE);
		___003C_003EDIRECTIVES = new ObservableProperty("DIRECTIVES", 16, Type.MULTIPLE_REFERENCE);
		___003C_003EELEMENTS = new ObservableProperty("ELEMENTS", 17, Type.MULTIPLE_REFERENCE);
		___003C_003EELEMENT_TYPE = new ObservableProperty("ELEMENT_TYPE", 18, Type.SINGLE_REFERENCE);
		___003C_003EELSE_EXPR = new ObservableProperty("ELSE_EXPR", 19, Type.SINGLE_REFERENCE);
		___003C_003EELSE_STMT = new ObservableProperty("ELSE_STMT", 20, Type.SINGLE_REFERENCE);
		___003C_003EENCLOSING_PARAMETERS = new ObservableProperty("ENCLOSING_PARAMETERS", 21, Type.SINGLE_ATTRIBUTE);
		___003C_003EENTRIES = new ObservableProperty("ENTRIES", 22, Type.MULTIPLE_REFERENCE);
		___003C_003EEXPRESSION = new ObservableProperty("EXPRESSION", 23, Type.SINGLE_REFERENCE);
		___003C_003EEXTENDED_TYPE = new ObservableProperty("EXTENDED_TYPE", 24, Type.SINGLE_REFERENCE);
		___003C_003EEXTENDED_TYPES = new ObservableProperty("EXTENDED_TYPES", 25, Type.MULTIPLE_REFERENCE);
		___003C_003EFINALLY_BLOCK = new ObservableProperty("FINALLY_BLOCK", 26, Type.SINGLE_REFERENCE);
		___003C_003EIDENTIFIER = new ObservableProperty("IDENTIFIER", 27, Type.SINGLE_ATTRIBUTE);
		___003C_003EIMPLEMENTED_TYPES = new ObservableProperty("IMPLEMENTED_TYPES", 28, Type.MULTIPLE_REFERENCE);
		___003C_003EIMPORTS = new ObservableProperty("IMPORTS", 29, Type.MULTIPLE_REFERENCE);
		___003C_003EINDEX = new ObservableProperty("INDEX", 30, Type.SINGLE_REFERENCE);
		___003C_003EINITIALIZATION = new ObservableProperty("INITIALIZATION", 31, Type.MULTIPLE_REFERENCE);
		___003C_003EINITIALIZER = new ObservableProperty("INITIALIZER", 32, Type.SINGLE_REFERENCE);
		___003C_003EINNER = new ObservableProperty("INNER", 33, Type.SINGLE_REFERENCE);
		___003C_003EINTERFACE = new ObservableProperty("INTERFACE", 34, Type.SINGLE_ATTRIBUTE);
		___003C_003EITERABLE = new ObservableProperty("ITERABLE", 35, Type.SINGLE_REFERENCE);
		___003C_003EKEYWORD = new ObservableProperty("KEYWORD", 36, Type.SINGLE_ATTRIBUTE);
		___003C_003ELABEL = new ObservableProperty("LABEL", 37, Type.SINGLE_REFERENCE);
		___003C_003ELABELS = new ObservableProperty("LABELS", 38, Type.MULTIPLE_REFERENCE);
		___003C_003ELEFT = new ObservableProperty("LEFT", 39, Type.SINGLE_REFERENCE);
		___003C_003ELEVELS = new ObservableProperty("LEVELS", 40, Type.MULTIPLE_REFERENCE);
		___003C_003EMEMBERS = new ObservableProperty("MEMBERS", 41, Type.MULTIPLE_REFERENCE);
		___003C_003EMEMBER_VALUE = new ObservableProperty("MEMBER_VALUE", 42, Type.SINGLE_REFERENCE);
		___003C_003EMESSAGE = new ObservableProperty("MESSAGE", 43, Type.SINGLE_REFERENCE);
		___003C_003EMODIFIERS = new ObservableProperty("MODIFIERS", 44, Type.MULTIPLE_REFERENCE);
		___003C_003EMODULE = new ObservableProperty("MODULE", 45, Type.SINGLE_REFERENCE);
		___003C_003EMODULE_NAMES = new ObservableProperty("MODULE_NAMES", 46, Type.MULTIPLE_REFERENCE);
		___003C_003ENAME = new ObservableProperty("NAME", 47, Type.SINGLE_REFERENCE);
		___003C_003EOPEN = new ObservableProperty("OPEN", 48, Type.SINGLE_ATTRIBUTE);
		___003C_003EOPERATOR = new ObservableProperty("OPERATOR", 49, Type.SINGLE_ATTRIBUTE);
		___003C_003EORIGIN = new ObservableProperty("ORIGIN", 50, Type.SINGLE_ATTRIBUTE);
		___003C_003EPACKAGE_DECLARATION = new ObservableProperty("PACKAGE_DECLARATION", 51, Type.SINGLE_REFERENCE);
		___003C_003EPAIRS = new ObservableProperty("PAIRS", 52, Type.MULTIPLE_REFERENCE);
		___003C_003EPARAMETER = new ObservableProperty("PARAMETER", 53, Type.SINGLE_REFERENCE);
		___003C_003EPARAMETERS = new ObservableProperty("PARAMETERS", 54, Type.MULTIPLE_REFERENCE);
		___003C_003EPATTERN = new ObservableProperty("PATTERN", 55, Type.SINGLE_REFERENCE);
		___003C_003EQUALIFIER = new ObservableProperty("QUALIFIER", 56, Type.SINGLE_REFERENCE);
		___003C_003ERECEIVER_PARAMETER = new ObservableProperty("RECEIVER_PARAMETER", 57, Type.SINGLE_REFERENCE);
		___003C_003ERECORD_DECLARATION = new ObservableProperty("RECORD_DECLARATION", 58, Type.SINGLE_REFERENCE);
		___003C_003ERESOURCES = new ObservableProperty("RESOURCES", 59, Type.MULTIPLE_REFERENCE);
		___003C_003ERIGHT = new ObservableProperty("RIGHT", 60, Type.SINGLE_REFERENCE);
		___003C_003ESCOPE = new ObservableProperty("SCOPE", 61, Type.SINGLE_REFERENCE);
		___003C_003ESELECTOR = new ObservableProperty("SELECTOR", 62, Type.SINGLE_REFERENCE);
		___003C_003ESTATEMENT = new ObservableProperty("STATEMENT", 63, Type.SINGLE_REFERENCE);
		___003C_003ESTATEMENTS = new ObservableProperty("STATEMENTS", 64, Type.MULTIPLE_REFERENCE);
		___003C_003ESTATIC = new ObservableProperty("STATIC", 65, Type.SINGLE_ATTRIBUTE);
		___003C_003ESUPER_TYPE = new ObservableProperty("SUPER_TYPE", 66, Type.SINGLE_REFERENCE);
		___003C_003ETARGET = new ObservableProperty("TARGET", 67, Type.SINGLE_REFERENCE);
		___003C_003ETHEN_EXPR = new ObservableProperty("THEN_EXPR", 68, Type.SINGLE_REFERENCE);
		___003C_003ETHEN_STMT = new ObservableProperty("THEN_STMT", 69, Type.SINGLE_REFERENCE);
		___003C_003ETHIS = new ObservableProperty("THIS", 70, Type.SINGLE_ATTRIBUTE);
		___003C_003ETHROWN_EXCEPTIONS = new ObservableProperty("THROWN_EXCEPTIONS", 71, Type.MULTIPLE_REFERENCE);
		___003C_003ETRY_BLOCK = new ObservableProperty("TRY_BLOCK", 72, Type.SINGLE_REFERENCE);
		___003C_003ETYPE = new ObservableProperty("TYPE", 73, Type.SINGLE_REFERENCE);
		___003C_003ETYPES = new ObservableProperty("TYPES", 74, Type.MULTIPLE_REFERENCE);
		___003C_003ETYPE_ARGUMENTS = new ObservableProperty("TYPE_ARGUMENTS", 75, Type.MULTIPLE_REFERENCE);
		___003C_003ETYPE_BOUND = new ObservableProperty("TYPE_BOUND", 76, Type.MULTIPLE_REFERENCE);
		___003C_003ETYPE_NAME = new ObservableProperty("TYPE_NAME", 77, Type.SINGLE_REFERENCE);
		___003C_003ETYPE_PARAMETERS = new ObservableProperty("TYPE_PARAMETERS", 78, Type.MULTIPLE_REFERENCE);
		___003C_003EUPDATE = new ObservableProperty("UPDATE", 79, Type.MULTIPLE_REFERENCE);
		___003C_003EVALUE = new ObservableProperty("VALUE", 80, Type.SINGLE_REFERENCE);
		___003C_003EVALUES = new ObservableProperty("VALUES", 81, Type.MULTIPLE_REFERENCE);
		___003C_003EVARIABLE = new ObservableProperty("VARIABLE", 82, Type.SINGLE_REFERENCE);
		___003C_003EVARIABLES = new ObservableProperty("VARIABLES", 83, Type.MULTIPLE_REFERENCE);
		___003C_003EVAR_ARGS = new ObservableProperty("VAR_ARGS", 84, Type.SINGLE_ATTRIBUTE);
		___003C_003EVAR_ARGS_ANNOTATIONS = new ObservableProperty("VAR_ARGS_ANNOTATIONS", 85, Type.MULTIPLE_REFERENCE);
		___003C_003EWITH = new ObservableProperty("WITH", 86, Type.MULTIPLE_REFERENCE);
		___003C_003ECASCADING_IF_STMT = new ObservableProperty("CASCADING_IF_STMT", 87, Type.SINGLE_ATTRIBUTE, derived: true);
		___003C_003EELSE_BLOCK = new ObservableProperty("ELSE_BLOCK", 88, Type.SINGLE_ATTRIBUTE, derived: true);
		___003C_003EELSE_BRANCH = new ObservableProperty("ELSE_BRANCH", 89, Type.SINGLE_ATTRIBUTE, derived: true);
		___003C_003EEXPRESSION_BODY = new ObservableProperty("EXPRESSION_BODY", 90, Type.SINGLE_REFERENCE, derived: true);
		___003C_003EMAXIMUM_COMMON_TYPE = new ObservableProperty("MAXIMUM_COMMON_TYPE", 91, Type.SINGLE_REFERENCE, derived: true);
		___003C_003EPOSTFIX = new ObservableProperty("POSTFIX", 92, Type.SINGLE_ATTRIBUTE, derived: true);
		___003C_003EPREFIX = new ObservableProperty("PREFIX", 93, Type.SINGLE_ATTRIBUTE, derived: true);
		___003C_003ETHEN_BLOCK = new ObservableProperty("THEN_BLOCK", 94, Type.SINGLE_ATTRIBUTE, derived: true);
		___003C_003EUSING_DIAMOND_OPERATOR = new ObservableProperty("USING_DIAMOND_OPERATOR", 95, Type.SINGLE_ATTRIBUTE, derived: true);
		___003C_003ERANGE = new ObservableProperty("RANGE", 96);
		___003C_003ECOMMENTED_NODE = new ObservableProperty("COMMENTED_NODE", 97);
		_0024VALUES = new ObservableProperty[98]
		{
			___003C_003EANNOTATIONS, ___003C_003EANONYMOUS_CLASS_BODY, ___003C_003EARGUMENTS, ___003C_003EASTERISK, ___003C_003EBODY, ___003C_003ECATCH_CLAUSES, ___003C_003ECHECK, ___003C_003ECLASS_BODY, ___003C_003ECLASS_DECLARATION, ___003C_003ECOMMENT,
			___003C_003ECOMPARE, ___003C_003ECOMPONENT_TYPE, ___003C_003ECONDITION, ___003C_003ECONTENT, ___003C_003EDEFAULT_VALUE, ___003C_003EDIMENSION, ___003C_003EDIRECTIVES, ___003C_003EELEMENTS, ___003C_003EELEMENT_TYPE, ___003C_003EELSE_EXPR,
			___003C_003EELSE_STMT, ___003C_003EENCLOSING_PARAMETERS, ___003C_003EENTRIES, ___003C_003EEXPRESSION, ___003C_003EEXTENDED_TYPE, ___003C_003EEXTENDED_TYPES, ___003C_003EFINALLY_BLOCK, ___003C_003EIDENTIFIER, ___003C_003EIMPLEMENTED_TYPES, ___003C_003EIMPORTS,
			___003C_003EINDEX, ___003C_003EINITIALIZATION, ___003C_003EINITIALIZER, ___003C_003EINNER, ___003C_003EINTERFACE, ___003C_003EITERABLE, ___003C_003EKEYWORD, ___003C_003ELABEL, ___003C_003ELABELS, ___003C_003ELEFT,
			___003C_003ELEVELS, ___003C_003EMEMBERS, ___003C_003EMEMBER_VALUE, ___003C_003EMESSAGE, ___003C_003EMODIFIERS, ___003C_003EMODULE, ___003C_003EMODULE_NAMES, ___003C_003ENAME, ___003C_003EOPEN, ___003C_003EOPERATOR,
			___003C_003EORIGIN, ___003C_003EPACKAGE_DECLARATION, ___003C_003EPAIRS, ___003C_003EPARAMETER, ___003C_003EPARAMETERS, ___003C_003EPATTERN, ___003C_003EQUALIFIER, ___003C_003ERECEIVER_PARAMETER, ___003C_003ERECORD_DECLARATION, ___003C_003ERESOURCES,
			___003C_003ERIGHT, ___003C_003ESCOPE, ___003C_003ESELECTOR, ___003C_003ESTATEMENT, ___003C_003ESTATEMENTS, ___003C_003ESTATIC, ___003C_003ESUPER_TYPE, ___003C_003ETARGET, ___003C_003ETHEN_EXPR, ___003C_003ETHEN_STMT,
			___003C_003ETHIS, ___003C_003ETHROWN_EXCEPTIONS, ___003C_003ETRY_BLOCK, ___003C_003ETYPE, ___003C_003ETYPES, ___003C_003ETYPE_ARGUMENTS, ___003C_003ETYPE_BOUND, ___003C_003ETYPE_NAME, ___003C_003ETYPE_PARAMETERS, ___003C_003EUPDATE,
			___003C_003EVALUE, ___003C_003EVALUES, ___003C_003EVARIABLE, ___003C_003EVARIABLES, ___003C_003EVAR_ARGS, ___003C_003EVAR_ARGS_ANNOTATIONS, ___003C_003EWITH, ___003C_003ECASCADING_IF_STMT, ___003C_003EELSE_BLOCK, ___003C_003EELSE_BRANCH,
			___003C_003EEXPRESSION_BODY, ___003C_003EMAXIMUM_COMMON_TYPE, ___003C_003EPOSTFIX, ___003C_003EPREFIX, ___003C_003ETHEN_BLOCK, ___003C_003EUSING_DIAMOND_OPERATOR, ___003C_003ERANGE, ___003C_003ECOMMENTED_NODE
		};
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
