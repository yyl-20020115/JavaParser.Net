using System;

using com.github.javaparser.utils;

using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.printer.configuration;

public class DefaultPrinterConfiguration :  PrinterConfiguration
{
	
	
		
	public class ConfigOption : java.lang.Enum
	{
		
		
		public enum __Enum
		{
			ORDER_IMPORTS,
			PRINT_COMMENTS,
			PRINT_JAVADOC,
			SPACE_AROUND_OPERATORS,
			COLUMN_ALIGN_PARAMETERS,
			COLUMN_ALIGN_FIRST_METHOD_CHAIN,
			INDENT_CASE_IN_SWITCH,
			MAX_ENUM_CONSTANTS_TO_ALIGN_HORIZONTALLY,
			END_OF_LINE_CHARACTER,
			INDENTATION
		}

		
		internal static ConfigOption ___003C_003EORDER_IMPORTS;

		
		internal static ConfigOption ___003C_003EPRINT_COMMENTS;

		
		internal static ConfigOption ___003C_003EPRINT_JAVADOC;

		
		internal static ConfigOption ___003C_003ESPACE_AROUND_OPERATORS;

		
		internal static ConfigOption ___003C_003ECOLUMN_ALIGN_PARAMETERS;

		
		internal static ConfigOption ___003C_003ECOLUMN_ALIGN_FIRST_METHOD_CHAIN;

		
		internal static ConfigOption ___003C_003EINDENT_CASE_IN_SWITCH;

		
		internal static ConfigOption ___003C_003EMAX_ENUM_CONSTANTS_TO_ALIGN_HORIZONTALLY;

		
		internal static ConfigOption ___003C_003EEND_OF_LINE_CHARACTER;

		
		internal static ConfigOption ___003C_003EINDENTATION;

		internal object defaultValue;

		internal Class type;

		
		private static ConfigOption[] _0024VALUES;

		
		public static ConfigOption ORDER_IMPORTS
		{
			
			get
			{
				return ___003C_003EORDER_IMPORTS;
			}
		}

		
		public static ConfigOption PRINT_COMMENTS
		{
			
			get
			{
				return ___003C_003EPRINT_COMMENTS;
			}
		}

		
		public static ConfigOption PRINT_JAVADOC
		{
			
			get
			{
				return ___003C_003EPRINT_JAVADOC;
			}
		}

		
		public static ConfigOption SPACE_AROUND_OPERATORS
		{
			
			get
			{
				return ___003C_003ESPACE_AROUND_OPERATORS;
			}
		}

		
		public static ConfigOption COLUMN_ALIGN_PARAMETERS
		{
			
			get
			{
				return ___003C_003ECOLUMN_ALIGN_PARAMETERS;
			}
		}

		
		public static ConfigOption COLUMN_ALIGN_FIRST_METHOD_CHAIN
		{
			
			get
			{
				return ___003C_003ECOLUMN_ALIGN_FIRST_METHOD_CHAIN;
			}
		}

		
		public static ConfigOption INDENT_CASE_IN_SWITCH
		{
			
			get
			{
				return ___003C_003EINDENT_CASE_IN_SWITCH;
			}
		}

		
		public static ConfigOption MAX_ENUM_CONSTANTS_TO_ALIGN_HORIZONTALLY
		{
			
			get
			{
				return ___003C_003EMAX_ENUM_CONSTANTS_TO_ALIGN_HORIZONTALLY;
			}
		}

		
		public static ConfigOption END_OF_LINE_CHARACTER
		{
			
			get
			{
				return ___003C_003EEND_OF_LINE_CHARACTER;
			}
		}

		
		public static ConfigOption INDENTATION
		{
			
			get
			{
				return ___003C_003EINDENTATION;
			}
		}

		
		
		public static void ___003Cclinit_003E()
		{
		}

		
				
		
		private ConfigOption(string _0024enum_0024name, int _0024enum_0024ordinal, Class clazz)
			: base(_0024enum_0024name, _0024enum_0024ordinal)
		{
			type = clazz;
			GC.KeepAlive(this);
		}

		
				
		
		private ConfigOption(string _0024enum_0024name, int _0024enum_0024ordinal, Class clazz, object value)
			: base(_0024enum_0024name, _0024enum_0024ordinal)
		{
			type = clazz;
			if (!type.isAssignableFrom(java.lang.Object.instancehelper_getClass(value)))
			{
				string s = java.lang.String.format("%s is not an instance of %s", value, type.getName());
				
				IllegalArgumentException ex = new IllegalArgumentException(s);
				GC.KeepAlive(this);
				throw ex;
			}
			defaultValue = value;
			GC.KeepAlive(this);
		}

		
		
		public static ConfigOption[] values()
		{
			return (ConfigOption[])_0024VALUES.Clone();
		}

		
		
		
		public static ConfigOption valueOf(string name)
		{
			return (ConfigOption)java.lang.Enum.valueOf(ClassLiteral<ConfigOption>.Value, name);
		}

		
		static ConfigOption()
		{
			___003C_003EORDER_IMPORTS = new ConfigOption("ORDER_IMPORTS", 0, ClassLiteral<java.lang.Boolean>.Value);
			___003C_003EPRINT_COMMENTS = new ConfigOption("PRINT_COMMENTS", 1, ClassLiteral<java.lang.Boolean>.Value);
			___003C_003EPRINT_JAVADOC = new ConfigOption("PRINT_JAVADOC", 2, ClassLiteral<java.lang.Boolean>.Value);
			___003C_003ESPACE_AROUND_OPERATORS = new ConfigOption("SPACE_AROUND_OPERATORS", 3, ClassLiteral<java.lang.Boolean>.Value);
			___003C_003ECOLUMN_ALIGN_PARAMETERS = new ConfigOption("COLUMN_ALIGN_PARAMETERS", 4, ClassLiteral<java.lang.Boolean>.Value);
			___003C_003ECOLUMN_ALIGN_FIRST_METHOD_CHAIN = new ConfigOption("COLUMN_ALIGN_FIRST_METHOD_CHAIN", 5, ClassLiteral<java.lang.Boolean>.Value);
			___003C_003EINDENT_CASE_IN_SWITCH = new ConfigOption("INDENT_CASE_IN_SWITCH", 6, ClassLiteral<java.lang.Boolean>.Value);
			___003C_003EMAX_ENUM_CONSTANTS_TO_ALIGN_HORIZONTALLY = new ConfigOption("MAX_ENUM_CONSTANTS_TO_ALIGN_HORIZONTALLY", 7, ClassLiteral<Integer>.Value, Integer.valueOf(5));
			___003C_003EEND_OF_LINE_CHARACTER = new ConfigOption("END_OF_LINE_CHARACTER", 8, ClassLiteral<java.lang.String>.Value, Utils.___003C_003ESYSTEM_EOL);
			___003C_003EINDENTATION = new ConfigOption("INDENTATION", 9, ClassLiteral<Indentation>.Value, new Indentation(Indentation.IndentType.___003C_003ESPACES, 4));
			_0024VALUES = new ConfigOption[10] { ___003C_003EORDER_IMPORTS, ___003C_003EPRINT_COMMENTS, ___003C_003EPRINT_JAVADOC, ___003C_003ESPACE_AROUND_OPERATORS, ___003C_003ECOLUMN_ALIGN_PARAMETERS, ___003C_003ECOLUMN_ALIGN_FIRST_METHOD_CHAIN, ___003C_003EINDENT_CASE_IN_SWITCH, ___003C_003EMAX_ENUM_CONSTANTS_TO_ALIGN_HORIZONTALLY, ___003C_003EEND_OF_LINE_CHARACTER, ___003C_003EINDENTATION };
		}
	}

	
	private sealed class ___003C_003EAnon0 : Predicate
	{
		private readonly ConfigurationOption arg_00241;

		internal ___003C_003EAnon0(ConfigurationOption P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024get_00240(arg_00241, (ConfigurationOption)P_0);
			
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

		private Set defaultOptions;

	
	
	public DefaultPrinterConfiguration()
	{
		HashSet.___003Cclinit_003E();
		defaultOptions = new HashSet(Arrays.asList(new DefaultConfigurationOption(ConfigOption.___003C_003EPRINT_COMMENTS, ConfigOption.___003C_003EPRINT_COMMENTS.defaultValue), new DefaultConfigurationOption(ConfigOption.___003C_003EPRINT_JAVADOC, ConfigOption.___003C_003EPRINT_JAVADOC.defaultValue), new DefaultConfigurationOption(ConfigOption.___003C_003ESPACE_AROUND_OPERATORS, ConfigOption.___003C_003ESPACE_AROUND_OPERATORS.defaultValue), new DefaultConfigurationOption(ConfigOption.___003C_003EINDENT_CASE_IN_SWITCH, ConfigOption.___003C_003EINDENT_CASE_IN_SWITCH.defaultValue), new DefaultConfigurationOption(ConfigOption.___003C_003EMAX_ENUM_CONSTANTS_TO_ALIGN_HORIZONTALLY, ConfigOption.___003C_003EMAX_ENUM_CONSTANTS_TO_ALIGN_HORIZONTALLY.defaultValue), new DefaultConfigurationOption(ConfigOption.___003C_003EEND_OF_LINE_CHARACTER, ConfigOption.___003C_003EEND_OF_LINE_CHARACTER.defaultValue), new DefaultConfigurationOption(ConfigOption.___003C_003EINDENTATION, ConfigOption.___003C_003EINDENTATION.defaultValue)));
	}

	
	
	
	public virtual PrinterConfiguration removeOption(ConfigurationOption option)
	{
		defaultOptions.remove(option);
		return this;
	}

	
	
	
	
	private static bool lambda_0024get_00240(ConfigurationOption option, ConfigurationOption o)
	{
		bool result = java.lang.Object.instancehelper_equals(o, option);
		
		return result;
	}

	
	
	
	public virtual PrinterConfiguration addOption(ConfigurationOption option)
	{
		removeOption(option);
		defaultOptions.add(option);
		return this;
	}

	
	
	
	public virtual bool isActivated(ConfigurationOption option)
	{
		bool result = defaultOptions.contains(option);
		
		return result;
	}

	
		
	
	public virtual Optional get(ConfigurationOption option)
	{
		Optional result = defaultOptions.stream().filter(new ___003C_003EAnon0(option)).findFirst();
		
		return result;
	}

		public virtual Set get()
	{
		return defaultOptions;
	}
}
