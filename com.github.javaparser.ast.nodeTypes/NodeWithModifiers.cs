using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.nodeTypes;

public interface NodeWithModifiers
{

	
	internal class _1
	{
		
		internal static int[] _0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024Modifier_0024Keyword;

		
		
		public static void ___003Cclinit_003E()
		{
		}

		
		static _1()
		{
			_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024Modifier_0024Keyword = new int[(nint)Modifier.Keyword.values().LongLength];
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024Modifier_0024Keyword[Modifier.Keyword.___003C_003EPUBLIC.ordinal()] = 1;
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
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024Modifier_0024Keyword[Modifier.Keyword.___003C_003EPROTECTED.ordinal()] = 2;
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
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024Modifier_0024Keyword[Modifier.Keyword.___003C_003EPRIVATE.ordinal()] = 3;
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

	private static class ___003C_003EPIM
	{
		
		
		[MethodParameters(new Modifiers[]
		{
			Modifiers.Final | Modifiers.Synthetic,
			Modifiers.Synthetic
		})]
		
		internal static bool lambda_0024addModifier_00240(Modifier.Keyword newModifier, Modifier m)
		{
			return m.getKeyword() == newModifier;
		}

		
		
		[MethodParameters(new Modifiers[]
		{
			Modifiers.Final | Modifiers.Synthetic,
			Modifiers.Synthetic
		})]
		
		internal static bool lambda_0024removeModifier_00241(List modifiersToRemoveAsList, Modifier existingModifier)
		{
			return (!modifiersToRemoveAsList.contains(existingModifier.getKeyword())) ? true : false;
		}
	}

	
	public static class __DefaultMethods
	{
		public unsafe static Node addModifier(NodeWithModifiers P_0, Modifier.Keyword[] P_1)
		{
			
			return _003Cdefault_003EaddModifier(P_0, P_1);
		}

		public unsafe static Node removeModifier(NodeWithModifiers P_0, Modifier.Keyword[] P_1)
		{
			
			return _003Cdefault_003EremoveModifier(P_0, P_1);
		}

		public unsafe static Node setModifier(NodeWithModifiers P_0, Modifier.Keyword P_1, bool P_2)
		{
			
			return _003Cdefault_003EsetModifier(P_0, P_1, P_2);
		}

		public unsafe static bool hasModifier(NodeWithModifiers P_0, Modifier.Keyword P_1)
		{
			
			return _003Cdefault_003EhasModifier(P_0, P_1);
		}

		public unsafe static Node setModifiers(NodeWithModifiers P_0, Modifier.Keyword[] P_1)
		{
			
			return _003Cdefault_003EsetModifiers(P_0, P_1);
		}

		public unsafe static AccessSpecifier getAccessSpecifier(NodeWithModifiers P_0)
		{
			
			return _003Cdefault_003EgetAccessSpecifier(P_0);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Predicate
	{
		private readonly Modifier.Keyword arg_00241;

		internal ___003C_003EAnon1(Modifier.Keyword P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM.lambda_0024addModifier_00240(arg_00241, (Modifier)P_0);
			
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

	
	private sealed class ___003C_003EAnon2 : Predicate
	{
		private readonly List arg_00241;

		internal ___003C_003EAnon2(List P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM.lambda_0024removeModifier_00241(arg_00241, (Modifier)P_0);
			
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
		internal ___003C_003EAnon3()
		{
		}

		public object apply(object P_0)
		{
			Modifier result = new Modifier((Modifier.Keyword)P_0);
			
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

	
		
	virtual Node addModifier(params Modifier.Keyword[] newModifiers);

	
	
	
	static Node _003Cdefault_003EaddModifier(NodeWithModifiers P_0, Modifier.Keyword[] P_1)
	{
		NodeList nodeList = new NodeList(P_0.getModifiers());
		int num = P_1.Length;
		for (int i = 0; i < num; i++)
		{
			Modifier.Keyword keyword = P_1[i];
			if (!nodeList.stream().anyMatch(new ___003C_003EAnon1(keyword)))
			{
				nodeList.add(new Modifier(keyword));
			}
		}
		P_0.setModifiers(nodeList);
		return (Node)P_0;
	}

		virtual NodeList getModifiers();

		
	virtual Node setModifiers(NodeList modifiers);

	
		
	virtual Node removeModifier(params Modifier.Keyword[] modifiersToRemove);

	
	
	
	static Node _003Cdefault_003EremoveModifier(NodeWithModifiers P_0, Modifier.Keyword[] P_1)
	{
		List list = Arrays.asList(P_1);
		NodeList modifiers = (NodeList)P_0.getModifiers().stream().filter(new ___003C_003EAnon2(list))
			.collect(NodeList.toNodeList());
		P_0.setModifiers(modifiers);
		return (Node)P_0;
	}

	
	Node setModifier(Modifier.Keyword m, bool set);

	
	
	
	Node _003Cdefault_003EsetModifier(NodeWithModifiers P_0, Modifier.Keyword P_1, bool P_2)
	{
		if (P_2)
		{
			Node result = P_0.addModifier(P_1);
			
			return result;
		}
		Node result2 = P_0.removeModifier(P_1);
		
		return result2;
	}

	
	
	bool hasModifier(Modifier.Keyword modifier);

	
	
	
	bool _003Cdefault_003EhasModifier(NodeWithModifiers P_0, Modifier.Keyword P_1)
	{
		Iterator iterator = P_0.getModifiers().iterator();
		while (iterator.hasNext())
		{
			Modifier modifier = (Modifier)iterator.next();
			if (modifier.getKeyword() == P_1)
			{
				return true;
			}
		}
		return false;
	}

	
		
     Node setModifiers(params Modifier.Keyword[] modifiers);

	
	
	
	static Node _003Cdefault_003EsetModifiers(NodeWithModifiers P_0, Modifier.Keyword[] P_1)
	{
		Node result = P_0.setModifiers((NodeList)Arrays.stream(P_1).map(new ___003C_003EAnon3()).collect(NodeList.toNodeList()));
		
		return result;
	}

	
	AccessSpecifier getAccessSpecifier();

	
	
	
	static AccessSpecifier _003Cdefault_003EgetAccessSpecifier(NodeWithModifiers P_0)
	{
		Iterator iterator = P_0.getModifiers().iterator();
		while (iterator.hasNext())
		{
			Modifier modifier = (Modifier)iterator.next();
			switch (_1._0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024Modifier_0024Keyword[modifier.getKeyword().ordinal()])
			{
			case 1:
				return AccessSpecifier.___003C_003EPUBLIC;
			case 2:
				return AccessSpecifier.___003C_003EPROTECTED;
			case 3:
				return AccessSpecifier.___003C_003EPRIVATE;
			}
		}
		return AccessSpecifier.___003C_003ENONE;
	}
}
