using System;

using com.github.javaparser.ast;
using com.github.javaparser.ast.observer;
using com.github.javaparser.printer.concretesyntaxmodel;
using com.github.javaparser.utils;

using IKVM.Runtime;
using java.lang;
using java.util.function;

namespace com.github.javaparser.printer.lexicalpreservation.changes;

public interface Change
{
	
	
	
	
	internal class _1
	{
		
		internal static int[] _0024SwitchMap_0024com_0024github_0024javaparser_0024printer_0024concretesyntaxmodel_0024CsmConditional_0024Condition;

		
		
		public static void ___003Cclinit_003E()
		{
		}

		
		static _1()
		{
			_0024SwitchMap_0024com_0024github_0024javaparser_0024printer_0024concretesyntaxmodel_0024CsmConditional_0024Condition = new int[(nint)CsmConditional.Condition.values().LongLength];
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024printer_0024concretesyntaxmodel_0024CsmConditional_0024Condition[CsmConditional.Condition.___003C_003EFLAG.ordinal()] = 1;
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
				_0024SwitchMap_0024com_0024github_0024javaparser_0024printer_0024concretesyntaxmodel_0024CsmConditional_0024Condition[CsmConditional.Condition.___003C_003EIS_NOT_EMPTY.ordinal()] = 2;
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
				_0024SwitchMap_0024com_0024github_0024javaparser_0024printer_0024concretesyntaxmodel_0024CsmConditional_0024Condition[CsmConditional.Condition.___003C_003EIS_EMPTY.ordinal()] = 3;
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
				_0024SwitchMap_0024com_0024github_0024javaparser_0024printer_0024concretesyntaxmodel_0024CsmConditional_0024Condition[CsmConditional.Condition.___003C_003EIS_PRESENT.ordinal()] = 4;
				return;
			}
			catch (System.Exception x4)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x4, ByteCodeHelper.MapFlags.Unused) == null)
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

	private static class ___003C_003EPIM
	{
		
		
		[NameSig("lambda$evaluate$0", "(Lcom.github.javaparser.ast.Node;Lcom.github.javaparser.ast.observer.ObservableProperty;)Z")]
		
		
		
		internal unsafe static bool _003Cpiim_003Elambda_0024evaluate_00240(Change node, Node p, ObservableProperty P_2)
		{
			
			bool result = ((java.lang.Boolean)node.getValue(P_2, p)).booleanValue();
			
			return result;
		}
	}

	
	public static class __DefaultMethods
	{
		public unsafe static bool evaluate(Change P_0, CsmConditional P_1, Node P_2)
		{
			
			return _003Cdefault_003Eevaluate(P_0, P_1, P_2);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Predicate
	{
		private readonly Change arg_00241;

		private readonly Node arg_00242;

		internal ___003C_003EAnon1(Change P_0, Node P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM._003Cpiim_003Elambda_0024evaluate_00240(arg_00241, arg_00242, (ObservableProperty)P_0);
			
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

	
	virtual object getValue(ObservableProperty property, Node node);

	
	
	virtual bool evaluate(CsmConditional csmConditional, Node node);

	
	
	
	static bool _003Cdefault_003Eevaluate(Change P_0, CsmConditional P_1, Node P_2)
	{
		switch (_1._0024SwitchMap_0024com_0024github_0024javaparser_0024printer_0024concretesyntaxmodel_0024CsmConditional_0024Condition[P_1.getCondition().ordinal()])
		{
		case 1:
		{
			bool result = P_1.getProperties().stream().anyMatch(new ___003C_003EAnon1(P_0, P_2));
			
			return result;
		}
		case 2:
			return (!Utils.valueIsNullOrEmpty(P_0.getValue(P_1.getProperty(), P_2))) ? true : false;
		case 3:
		{
			bool result2 = Utils.valueIsNullOrEmpty(P_0.getValue(P_1.getProperty(), P_2));
			
			return result2;
		}
		case 4:
			return (!Utils.valueIsNullOrEmptyStringOrOptional(P_0.getValue(P_1.getProperty(), P_2))) ? true : false;
		default:
		{
			string message = new StringBuilder().append("").append(P_1.getProperty()).append(" ")
				.append(P_1.getCondition())
				.ToString();
			
			throw new UnsupportedOperationException(message);
		}
		}
	}
}
