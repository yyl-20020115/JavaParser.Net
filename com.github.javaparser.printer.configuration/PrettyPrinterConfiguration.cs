using System;
using System.Runtime.CompilerServices;
using com.github.javaparser.utils;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace com.github.javaparser.printer.configuration;


[Deprecated(new object[]
{
	(byte)64,
	"Ljava/lang/Deprecated;"
})]
public class PrettyPrinterConfiguration :  PrinterConfiguration
{
	internal PrinterConfiguration wrappedConfiguration;

	
	
	public virtual Indentation getIndentation()
	{
		return (Indentation)((ConfigurationOption)wrappedConfiguration.get(new DefaultConfigurationOption(DefaultPrinterConfiguration.ConfigOption.___003C_003EINDENTATION)).get()).asValue();
	}

	
	
	
	public virtual PrettyPrinterConfiguration setIndentation(Indentation indentation)
	{
		wrappedConfiguration.addOption(new DefaultConfigurationOption(DefaultPrinterConfiguration.ConfigOption.___003C_003EINDENTATION, indentation));
		return this;
	}

	
	
	
	
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual PrettyPrinterConfiguration setIndentSize(int indentSize)
	{
		Indentation indentation = getIndentation().setSize(((Integer)Utils.assertNonNegative(Integer.valueOf(indentSize))).intValue());
		setIndentation(indentation);
		return this;
	}

	
	
	
	public virtual PrinterConfiguration addOption(ConfigurationOption option)
	{
		PrinterConfiguration result = wrappedConfiguration.addOption(option);
		
		return result;
	}

	
	
	
	public virtual PrinterConfiguration removeOption(ConfigurationOption option)
	{
		PrinterConfiguration result = wrappedConfiguration.removeOption(option);
		
		return result;
	}

	
	
	public PrettyPrinterConfiguration()
	{
		wrappedConfiguration = new DefaultPrinterConfiguration();
	}

	
	
	
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual string getIndent()
	{
		string indent = getIndentation().getIndent();
		
		return indent;
	}

	
	
	
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual int getIndentSize()
	{
		int size = getIndentation().getSize();
		
		return size;
	}

	
	
	
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual Indentation.IndentType getIndentType()
	{
		Indentation.IndentType type = getIndentation().getType();
		
		return type;
	}

	
	
	
	
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual PrettyPrinterConfiguration setIndentType(Indentation.IndentType indentType)
	{
		Indentation indentation = getIndentation().setType((Indentation.IndentType)Utils.assertNotNull(indentType));
		setIndentation(indentation);
		return this;
	}

	
	
	
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual int getTabWidth()
	{
		int size = getIndentation().getSize();
		
		return size;
	}

	
	
	
	
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual PrettyPrinterConfiguration setTabWidth(int tabWidth)
	{
		setIndentSize(((Integer)Utils.assertPositive(Integer.valueOf(tabWidth))).intValue());
		return this;
	}

	
	
	public virtual bool isOrderImports()
	{
		bool result = wrappedConfiguration.get(new DefaultConfigurationOption(DefaultPrinterConfiguration.ConfigOption.___003C_003EORDER_IMPORTS)).isPresent();
		
		return result;
	}

	
	
	public virtual bool isPrintComments()
	{
		bool result = wrappedConfiguration.get(new DefaultConfigurationOption(DefaultPrinterConfiguration.ConfigOption.___003C_003EPRINT_COMMENTS)).isPresent();
		
		return result;
	}

	
	
	public virtual bool isIgnoreComments()
	{
		return (!wrappedConfiguration.get(new DefaultConfigurationOption(DefaultPrinterConfiguration.ConfigOption.___003C_003EPRINT_COMMENTS)).isPresent()) ? true : false;
	}

	
	
	public virtual bool isSpaceAroundOperators()
	{
		bool result = wrappedConfiguration.get(new DefaultConfigurationOption(DefaultPrinterConfiguration.ConfigOption.___003C_003ESPACE_AROUND_OPERATORS)).isPresent();
		
		return result;
	}

	
	
	public virtual bool isPrintJavadoc()
	{
		bool result = wrappedConfiguration.get(new DefaultConfigurationOption(DefaultPrinterConfiguration.ConfigOption.___003C_003EPRINT_JAVADOC)).isPresent();
		
		return result;
	}

	
	
	public virtual bool isColumnAlignParameters()
	{
		bool result = wrappedConfiguration.get(new DefaultConfigurationOption(DefaultPrinterConfiguration.ConfigOption.___003C_003ECOLUMN_ALIGN_PARAMETERS)).isPresent();
		
		return result;
	}

	
	
	public virtual bool isColumnAlignFirstMethodChain()
	{
		bool result = wrappedConfiguration.get(new DefaultConfigurationOption(DefaultPrinterConfiguration.ConfigOption.___003C_003ECOLUMN_ALIGN_FIRST_METHOD_CHAIN)).isPresent();
		
		return result;
	}

	
	
	public virtual bool isIndentCaseInSwitch()
	{
		bool result = wrappedConfiguration.get(new DefaultConfigurationOption(DefaultPrinterConfiguration.ConfigOption.___003C_003EINDENT_CASE_IN_SWITCH)).isPresent();
		
		return result;
	}

	
	
	
	public virtual PrettyPrinterConfiguration setPrintComments(bool printComments)
	{
		wrappedConfiguration = ((!printComments) ? removeOption(new DefaultConfigurationOption(DefaultPrinterConfiguration.ConfigOption.___003C_003EPRINT_COMMENTS)) : addOption(new DefaultConfigurationOption(DefaultPrinterConfiguration.ConfigOption.___003C_003EPRINT_COMMENTS)));
		return this;
	}

	
	
	
	public virtual PrettyPrinterConfiguration setPrintJavadoc(bool printJavadoc)
	{
		wrappedConfiguration = ((!printJavadoc) ? removeOption(new DefaultConfigurationOption(DefaultPrinterConfiguration.ConfigOption.___003C_003EPRINT_JAVADOC)) : addOption(new DefaultConfigurationOption(DefaultPrinterConfiguration.ConfigOption.___003C_003EPRINT_JAVADOC)));
		return this;
	}

	
	
	
	public virtual PrettyPrinterConfiguration setSpaceAroundOperators(bool spaceAroundOperators)
	{
		wrappedConfiguration = ((!spaceAroundOperators) ? removeOption(new DefaultConfigurationOption(DefaultPrinterConfiguration.ConfigOption.___003C_003ESPACE_AROUND_OPERATORS)) : addOption(new DefaultConfigurationOption(DefaultPrinterConfiguration.ConfigOption.___003C_003ESPACE_AROUND_OPERATORS)));
		return this;
	}

	
	
	
	public virtual PrettyPrinterConfiguration setColumnAlignParameters(bool columnAlignParameters)
	{
		wrappedConfiguration = ((!columnAlignParameters) ? removeOption(new DefaultConfigurationOption(DefaultPrinterConfiguration.ConfigOption.___003C_003ECOLUMN_ALIGN_PARAMETERS)) : addOption(new DefaultConfigurationOption(DefaultPrinterConfiguration.ConfigOption.___003C_003ECOLUMN_ALIGN_PARAMETERS)));
		return this;
	}

	
	
	
	public virtual PrettyPrinterConfiguration setColumnAlignFirstMethodChain(bool columnAlignFirstMethodChain)
	{
		wrappedConfiguration = ((!columnAlignFirstMethodChain) ? removeOption(new DefaultConfigurationOption(DefaultPrinterConfiguration.ConfigOption.___003C_003ECOLUMN_ALIGN_FIRST_METHOD_CHAIN)) : addOption(new DefaultConfigurationOption(DefaultPrinterConfiguration.ConfigOption.___003C_003ECOLUMN_ALIGN_FIRST_METHOD_CHAIN)));
		return this;
	}

	
	
	
	public virtual PrettyPrinterConfiguration setIndentCaseInSwitch(bool indentInSwitch)
	{
		wrappedConfiguration = ((!indentInSwitch) ? removeOption(new DefaultConfigurationOption(DefaultPrinterConfiguration.ConfigOption.___003C_003EINDENT_CASE_IN_SWITCH)) : addOption(new DefaultConfigurationOption(DefaultPrinterConfiguration.ConfigOption.___003C_003EINDENT_CASE_IN_SWITCH)));
		return this;
	}

	
	
	public virtual string getEndOfLineCharacter()
	{
		return (string)((ConfigurationOption)wrappedConfiguration.get(new DefaultConfigurationOption(DefaultPrinterConfiguration.ConfigOption.___003C_003EEND_OF_LINE_CHARACTER)).get()).asValue();
	}

	
	
	
	public virtual PrettyPrinterConfiguration setEndOfLineCharacter(string endOfLineCharacter)
	{
		addOption(new DefaultConfigurationOption(DefaultPrinterConfiguration.ConfigOption.___003C_003EEND_OF_LINE_CHARACTER, endOfLineCharacter));
		return this;
	}

	
	
	
	public virtual PrettyPrinterConfiguration setOrderImports(bool orderImports)
	{
		wrappedConfiguration = ((!orderImports) ? removeOption(new DefaultConfigurationOption(DefaultPrinterConfiguration.ConfigOption.___003C_003EORDER_IMPORTS)) : addOption(new DefaultConfigurationOption(DefaultPrinterConfiguration.ConfigOption.___003C_003EORDER_IMPORTS)));
		return this;
	}

	
	
	public virtual int getMaxEnumConstantsToAlignHorizontally()
	{
		int result = ((ConfigurationOption)wrappedConfiguration.get(new DefaultConfigurationOption(DefaultPrinterConfiguration.ConfigOption.___003C_003EMAX_ENUM_CONSTANTS_TO_ALIGN_HORIZONTALLY)).get()).asInteger().intValue();
		
		return result;
	}

	
	
	
	public virtual PrettyPrinterConfiguration setMaxEnumConstantsToAlignHorizontally(int maxEnumConstantsToAlignHorizontally)
	{
		addOption(new DefaultConfigurationOption(DefaultPrinterConfiguration.ConfigOption.___003C_003EMAX_ENUM_CONSTANTS_TO_ALIGN_HORIZONTALLY, Integer.valueOf(maxEnumConstantsToAlignHorizontally)));
		return this;
	}

	
	
	
	public virtual bool isActivated(ConfigurationOption option)
	{
		bool result = wrappedConfiguration.isActivated(option);
		
		return result;
	}

	
		
	
	public virtual Optional get(ConfigurationOption option)
	{
		Optional result = wrappedConfiguration.get(option);
		
		return result;
	}

	
		
	public virtual Set get()
	{
		Set result = wrappedConfiguration.get();
		
		return result;
	}
}
