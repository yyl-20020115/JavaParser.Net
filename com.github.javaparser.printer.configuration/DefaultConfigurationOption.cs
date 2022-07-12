
using com.github.javaparser.utils;

using java.lang;

namespace com.github.javaparser.printer.configuration;

public class DefaultConfigurationOption: ConfigurationOption
{
	internal DefaultPrinterConfiguration.ConfigOption configOption;

	internal object currentValue;

	
	
	
	public DefaultConfigurationOption(DefaultPrinterConfiguration.ConfigOption configOption, object value)
	{
		this.configOption = configOption;
		if (value != null)
		{
			this.value(value);
		}
	}

	
	
	
	public DefaultConfigurationOption(DefaultPrinterConfiguration.ConfigOption configOption)
		: this(configOption, null)
	{
	}

	
	
	
	public virtual ConfigurationOption value(object value)
	{
		Utils.assertNotNull(value);
		currentValue = value;
		if (!configOption.type.isAssignableFrom(Object.instancehelper_getClass(value)))
		{
			string s = String.format("%s is not an instance of %s", value, configOption.type.getName());
			
			throw new IllegalArgumentException(s);
		}
		return this;
	}

	
		
	private object cast()
	{
		if (!hasValue())
		{
			string s = String.format("The option %s has no currentValue", configOption.name());
			
			throw new IllegalArgumentException(s);
		}
		if (configOption.type.isAssignableFrom(Object.instancehelper_getClass(currentValue)))
		{
			object result = configOption.type.cast(currentValue);
			
			return result;
		}
		string s2 = String.format("%s cannot be cast to %s", currentValue, configOption.type.getName());
		
		throw new IllegalArgumentException(s2);
	}

	public virtual bool hasValue()
	{
		return currentValue != null;
	}

	
	
	
	public override bool Equals(object o)
	{
		if (o == null || !(o is DefaultConfigurationOption))
		{
			return false;
		}
		DefaultConfigurationOption defaultConfigurationOption = (DefaultConfigurationOption)o;
		bool result = configOption.equals(defaultConfigurationOption.configOption);
		
		return result;
	}

	
	
	public override int GetHashCode()
	{
		int result = configOption.GetHashCode();
		
		return result;
	}

	
	
	public virtual Integer asInteger()
	{
		return (Integer)cast();
	}

	
	
	public virtual string asString()
	{
		return (string)cast();
	}

	
	
	public virtual Boolean asBoolean()
	{
		return (Boolean)cast();
	}

	
		
	public virtual object asValue()
	{
		object result = cast();
		
		return result;
	}
}
