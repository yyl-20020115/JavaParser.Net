using System;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.observer;
using com.github.javaparser.utils;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;

namespace com.github.javaparser.printer.concretesyntaxmodel;

public class CsmAttribute :  CsmElement
{
	
	
	
	
	internal class _1
	{
		
		internal static int[] _0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024observer_0024ObservableProperty;

		
		
		public static void ___003Cclinit_003E()
		{
		}

		
		static _1()
		{
			_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024observer_0024ObservableProperty = new int[(nint)ObservableProperty.values().LongLength];
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024observer_0024ObservableProperty[ObservableProperty.___003C_003EIDENTIFIER.ordinal()] = 1;
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
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024observer_0024ObservableProperty[ObservableProperty.___003C_003ETYPE.ordinal()] = 2;
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
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024observer_0024ObservableProperty[ObservableProperty.___003C_003EKEYWORD.ordinal()] = 3;
			}
			catch (System.Exception x3)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x3, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0085;
			}
			goto IL_008b;
			IL_0085:
			
			goto IL_008b;
			IL_008b:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024observer_0024ObservableProperty[ObservableProperty.___003C_003EOPERATOR.ordinal()] = 4;
			}
			catch (System.Exception x4)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x4, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_00ae;
			}
			goto IL_00b4;
			IL_00ae:
			
			goto IL_00b4;
			IL_00b4:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024observer_0024ObservableProperty[ObservableProperty.___003C_003EVALUE.ordinal()] = 5;
			}
			catch (System.Exception x5)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x5, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_00d7;
			}
			goto IL_00dd;
			IL_00d7:
			
			goto IL_00dd;
			IL_00dd:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024observer_0024ObservableProperty[ObservableProperty.___003C_003ENAME.ordinal()] = 6;
				return;
			}
			catch (System.Exception x6)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x6, ByteCodeHelper.MapFlags.Unused) == null)
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

	
	private ObservableProperty property;

	
	
	
	public CsmAttribute(ObservableProperty property)
	{
		this.property = property;
	}

	public virtual ObservableProperty getProperty()
	{
		return property;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual void prettyPrint(Node node, SourcePrinter printer)
	{
		object rawValue = property.getRawValue(node);
		printer.print(PrintingHelper.printToString(rawValue));
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		6, 159, 22, 131, 127, 11, 107, 111, 2, 230,
		69, 223, 14, 127, 11, 107, 111, 2, 230, 69,
		191, 14, 104, 163, 131
	})]
	public virtual int getTokenType(Node node, string text, string tokenText)
	{
		switch (_1._0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024observer_0024ObservableProperty[property.ordinal()])
		{
		case 1:
			return 94;
		case 2:
		{
			string anObject = new StringBuilder().append("\"").append(java.lang.String.instancehelper_toLowerCase(text)).append("\"")
				.ToString();
			for (int i = 0; i < (nint)GeneratedJavaParserConstants.tokenImage.LongLength; i++)
			{
				if (java.lang.String.instancehelper_equals(GeneratedJavaParserConstants.tokenImage[i], anObject))
				{
					return i;
				}
			}
			string message3 = CodeGenerationUtils.f("Attribute '%s' does not corresponding to any expected value. Text: %s", property.camelCaseName(), text);
			
			throw new RuntimeException(message3);
		}
		case 3:
		case 4:
		{
			string anObject = new StringBuilder().append("\"").append(java.lang.String.instancehelper_toLowerCase(tokenText)).append("\"")
				.ToString();
			for (int i = 0; i < (nint)GeneratedJavaParserConstants.tokenImage.LongLength; i++)
			{
				if (java.lang.String.instancehelper_equals(GeneratedJavaParserConstants.tokenImage[i], anObject))
				{
					return i;
				}
			}
			string message2 = CodeGenerationUtils.f("Attribute '%s' does not corresponding to any expected value. Text: %s", property.camelCaseName(), tokenText);
			
			throw new RuntimeException(message2);
		}
		case 5:
			if (node is IntegerLiteralExpr)
			{
				return 77;
			}
			goto case 6;
		case 6:
			return 94;
		default:
		{
			string message = new StringBuilder().append("getTokenType does not know how to handle property ").append(property).append(" with text: ")
				.append(text)
				.ToString();
			
			throw new UnsupportedOperationException(message);
		}
		}
	}

	
	
	public override string ToString()
	{
		string result = java.lang.String.format("%s(property:%s)", java.lang.Object.instancehelper_getClass(this).getSimpleName(), getProperty());
		
		return result;
	}
}
