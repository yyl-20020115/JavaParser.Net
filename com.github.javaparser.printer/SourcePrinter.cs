using System;

using com.github.javaparser.printer.configuration;
using com.github.javaparser.utils;

using IKVM.Runtime;
using java.lang;
using java.util;

namespace com.github.javaparser.printer;

public class SourcePrinter
{
	
	
	
	
	internal class _1
	{
		
		internal static int[] _0024SwitchMap_0024com_0024github_0024javaparser_0024printer_0024configuration_0024Indentation_0024IndentType;

		
		
		public static void ___003Cclinit_003E()
		{
		}

		
		static _1()
		{
			_0024SwitchMap_0024com_0024github_0024javaparser_0024printer_0024configuration_0024Indentation_0024IndentType = new int[(nint)Indentation.IndentType.values().LongLength];
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024printer_0024configuration_0024Indentation_0024IndentType[Indentation.IndentType.___003C_003ESPACES.ordinal()] = 1;
			}
			catch (System.Exception x)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0033;
			}
			goto IL_0039;
			IL_0033:
			
			goto IL_0039;
			IL_0039:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024printer_0024configuration_0024Indentation_0024IndentType[Indentation.IndentType.___003C_003ETABS_WITH_SPACE_ALIGN.ordinal()] = 2;
			}
			catch (System.Exception x2)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x2, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_005c;
			}
			goto IL_0062;
			IL_005c:
			
			goto IL_0062;
			IL_0062:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024printer_0024configuration_0024Indentation_0024IndentType[Indentation.IndentType.___003C_003ETABS.ordinal()] = 3;
				return;
			}
			catch (System.Exception x3)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x3, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
			}
			
		}

		_1()
		{
			throw null;
		}
	}

	private string endOfLineCharacter;

	private Indentation indentation;

	
		private Deque indents;

	
		private Deque reindentedIndents;

	private string lastPrintedIndent;

	
	private StringBuilder buf;

	private Position cursor;

	private bool indented;

	
	
	
	public virtual SourcePrinter print(string arg)
	{
		if (!indented)
		{
			lastPrintedIndent = (string)indents.peek();
			append(lastPrintedIndent);
			indented = true;
		}
		append(arg);
		return this;
	}

	
	
	
	public virtual string normalizeEolInTextBlock(string content)
	{
		string result = Utils.normalizeEolInTextBlock(content, endOfLineCharacter);
		
		return result;
	}

	
	
	
	public virtual SourcePrinter println(string arg)
	{
		print(arg);
		println();
		return this;
	}

	
	
	public virtual SourcePrinter println()
	{
		buf.append(endOfLineCharacter);
		Position.___003Cclinit_003E();
		cursor = new Position(cursor.___003C_003Eline + 1, 0);
		indented = false;
		return this;
	}

	
	
	public virtual SourcePrinter indent()
	{
		string str = (string)indents.peek();
		switch (_1._0024SwitchMap_0024com_0024github_0024javaparser_0024printer_0024configuration_0024Indentation_0024IndentType[indentation.getType().ordinal()])
		{
		case 1:
		case 2:
			indents.push(new StringBuilder().append(str).append(indentation.getIndent()).ToString());
			break;
		case 3:
			indents.push(new StringBuilder().append(indentation.getIndent()).append(str).ToString());
			break;
		default:
			
			throw new AssertionError("Unhandled indent type");
		}
		return this;
	}

	
	
	public virtual SourcePrinter unindent()
	{
		if (indents.isEmpty())
		{
			
			throw new IllegalStateException("Indent/unindent calls are not well-balanced.");
		}
		indents.pop();
		return this;
	}

	
	
	internal SourcePrinter()
		: this(new DefaultPrinterConfiguration())
	{
	}

	
	
	public override string ToString()
	{
		string result = buf.ToString();
		
		return result;
	}

	
	
	
	internal SourcePrinter(PrinterConfiguration configuration)
		: this((Indentation)((ConfigurationOption)configuration.get(new DefaultConfigurationOption(DefaultPrinterConfiguration.ConfigOption.___003C_003EINDENTATION)).get()).asValue(), ((ConfigurationOption)configuration.get(new DefaultConfigurationOption(DefaultPrinterConfiguration.ConfigOption.___003C_003EEND_OF_LINE_CHARACTER)).get()).asString())
	{
	}

	public virtual Position getCursor()
	{
		return cursor;
	}

	
	
	
	public virtual SourcePrinter indentWithAlignTo(int column)
	{
		indents.push(calculateIndentWithAlignTo(column));
		return this;
	}

	
	
	public virtual void duplicateIndent()
	{
		indents.push(indents.peek());
	}

	
	
	public virtual void reindentToPreviousLevel()
	{
		if (reindentedIndents.isEmpty())
		{
			
			throw new IllegalStateException("Reindent calls are not well-balanced.");
		}
		indents.pop();
		indents.push(reindentedIndents.pop());
	}

	
	
	public virtual void reindentWithAlignToCursor()
	{
		string e = calculateIndentWithAlignTo(cursor.___003C_003Ecolumn);
		reindentedIndents.push(indents.pop());
		indents.push(e);
	}

	
	
	
	internal SourcePrinter(PrettyPrinterConfiguration configuration)
		: this(configuration.getIndentation(), configuration.getEndOfLineCharacter())
	{
	}

	
	
	
	internal SourcePrinter(Indentation indentation, string eol)
	{
		indents = new LinkedList();
		reindentedIndents = new LinkedList();
		lastPrintedIndent = "";
		buf = new StringBuilder();
		cursor = new Position(1, 0);
		indented = false;
		this.indentation = indentation;
		endOfLineCharacter = eol;
		indents.push("");
	}

	
	
	
	private string calculateIndentWithAlignTo(int column)
	{
		if (column < java.lang.String.instancehelper_length(lastPrintedIndent))
		{
			
			throw new IllegalStateException("Attempt to indent less than the previous indent.");
		}
		StringBuilder stringBuilder = new StringBuilder(lastPrintedIndent);
		switch (_1._0024SwitchMap_0024com_0024github_0024javaparser_0024printer_0024configuration_0024Indentation_0024IndentType[indentation.getType().ordinal()])
		{
		case 1:
		case 2:
			while (stringBuilder.length() < column)
			{
				stringBuilder.append(Indentation.IndentType.___003C_003ESPACES.getCar());
			}
			break;
		case 3:
		{
			Indentation.IndentType type = indentation.getType();
			int i;
			for (i = stringBuilder.length(); i + type.getWidth() <= column; i += type.getWidth())
			{
				stringBuilder.insert(0, type.getCar());
			}
			for (; i < column; i++)
			{
				stringBuilder.append(Indentation.IndentType.___003C_003ESPACES.getCar());
			}
			StringBuilder stringBuilder2 = new StringBuilder();
			for (int j = 0; j < type.getWidth(); j++)
			{
				stringBuilder2.append(Indentation.IndentType.___003C_003ESPACES.getCar());
			}
			string text = stringBuilder2.ToString();
			if (stringBuilder.length() >= type.getWidth() && java.lang.String.instancehelper_equals(stringBuilder.substring(stringBuilder.length() - type.getWidth()), text))
			{
				int num = stringBuilder.indexOf(text);
				stringBuilder.replace(num, num + type.getWidth(), type.getCar().ToString());
			}
			break;
		}
		default:
			
			throw new AssertionError("Unhandled indent type");
		}
		string result = stringBuilder.ToString();
		
		return result;
	}

	
	
	
	private void append(string arg)
	{
		buf.append(arg);
		cursor = cursor.withColumn(cursor.___003C_003Ecolumn + java.lang.String.instancehelper_length(arg));
	}

	
	
	
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual string getSource()
	{
		string result = ToString();
		
		return result;
	}
}
