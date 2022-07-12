
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.type;
using com.github.javaparser.metamodel;

using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.ast.nodeTypes;

public interface NodeWithVariables
{
	
	[InnerClass(null, (Modifiers)0)]
	[EnclosingMethod(null, "calculateMaximumCommonType", "(Ljava.util.List;)Ljava.util.Optional;")]
	internal class _1Helper
	{
		
		
		internal _1Helper()
		{
		}

		
		
		
		internal static Optional access_0024000(_1Helper P_0, Type P_1, int P_2)
		{
			Optional result = P_0.toArrayLevel(P_1, P_2);
			
			return result;
		}

		
				
		
		private Optional toArrayLevel(Type type, int level)
		{
			if (level > type.getArrayLevel())
			{
				Optional result = Optional.empty();
				
				return result;
			}
			for (int i = type.getArrayLevel(); i > level; i += -1)
			{
				if (!(type is ArrayType))
				{
					Optional result2 = Optional.empty();
					
					return result2;
				}
				type = ((ArrayType)type).getComponentType();
			}
			Optional result3 = Optional.of(type);
			
			return result3;
		}
	}

	private static class ___003C_003EPIM
	{
		
		
		
		
		internal static Type lambda_0024getMaximumCommonType_00240(VariableDeclarator v)
		{
			Type type = v.getType();
			
			return type;
		}

		
		
		
		
		internal static string lambda_0024calculateMaximumCommonType_00241(_1Helper helper, int currentLevel, Type v)
		{
			Optional optional = _1Helper.access_0024000(helper, v, currentLevel);
			return (string)optional.map(new ___003C_003EAnon3()).orElse(null);
		}
	}

	
	public static class __DefaultMethods
	{
		public unsafe static VariableDeclarator getVariable(NodeWithVariables P_0, int P_1)
		{
			
			return _003Cdefault_003EgetVariable(P_0, P_1);
		}

		public unsafe static Node setVariable(NodeWithVariables P_0, int P_1, VariableDeclarator P_2)
		{
			
			return _003Cdefault_003EsetVariable(P_0, P_1, P_2);
		}

		public unsafe static Node addVariable(NodeWithVariables P_0, VariableDeclarator P_1)
		{
			
			return _003Cdefault_003EaddVariable(P_0, P_1);
		}

		public unsafe static Type getCommonType(NodeWithVariables P_0)
		{
			
			return _003Cdefault_003EgetCommonType(P_0);
		}

		public unsafe static Type getElementType(NodeWithVariables P_0)
		{
			
			return _003Cdefault_003EgetElementType(P_0);
		}

		public unsafe static Node setAllTypes(NodeWithVariables P_0, Type P_1)
		{
			
			return _003Cdefault_003EsetAllTypes(P_0, P_1);
		}

		public unsafe static Optional getMaximumCommonType(NodeWithVariables P_0)
		{
			
			return _003Cdefault_003EgetMaximumCommonType(P_0);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Function
	{
		internal ___003C_003EAnon1()
		{
		}

		public object apply(object P_0)
		{
			Type result = ___003C_003EPIM.lambda_0024getMaximumCommonType_00240((VariableDeclarator)P_0);
			
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

	
	private sealed class ___003C_003EAnon2 : Function
	{
		private readonly _1Helper arg_00241;

		private readonly int arg_00242;

		internal ___003C_003EAnon2(_1Helper P_0, int P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			string result = ___003C_003EPIM.lambda_0024calculateMaximumCommonType_00241(arg_00241, arg_00242, (Type)P_0);
			
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

	
	private sealed class ___003C_003EAnon3 : Function
	{
		internal ___003C_003EAnon3()
		{
		}

		public object apply(object P_0)
		{
			string result = ((Type)P_0).ToString();
			
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

	
	public static class __Methods
	{
		public static Optional calculateMaximumCommonType(List P_0)
		{
			return NodeWithVariables.calculateMaximumCommonType(P_0);
		}
	}

	
	
	virtual VariableDeclarator getVariable(int i);

	
	
	
	static VariableDeclarator _003Cdefault_003EgetVariable(NodeWithVariables P_0, int P_1)
	{
		return (VariableDeclarator)P_0.getVariables().get(P_1);
	}

		virtual NodeList getVariables();

	
		
	
	static Optional calculateMaximumCommonType(List types)
	{
		_1Helper _1Helper = new _1Helper();
		int num = 0;
		int num2 = 1;
		while (num2 != 0)
		{
			int num3 = num;
			object[] array = types.stream().map(new ___003C_003EAnon2(_1Helper, num3)).distinct()
				.toArray();
			if ((nint)array.LongLength == 1 && array[0] != null)
			{
				num++;
			}
			else
			{
				num2 = 0;
			}
		}
		Type obj = (Type)types.get(0);
		num += -1;
		Optional result = _1Helper.access_0024000(_1Helper, obj, num);
		
		return result;
	}

		
	virtual Node setVariables(NodeList variables);

	
		
	virtual Node setVariable(int i, VariableDeclarator variableDeclarator);

	
	
	
	static Node _003Cdefault_003EsetVariable(NodeWithVariables P_0, int P_1, VariableDeclarator P_2)
	{
		P_0.getVariables().set(P_1, P_2);
		return (Node)P_0;
	}

	
		
	virtual Node addVariable(VariableDeclarator variableDeclarator);

	
	
	
	static Node _003Cdefault_003EaddVariable(NodeWithVariables P_0, VariableDeclarator P_1)
	{
		P_0.getVariables().add(P_1);
		return (Node)P_0;
	}

	
	virtual Type getCommonType();

	
	
	
	static Type _003Cdefault_003EgetCommonType(NodeWithVariables P_0)
	{
		NodeList variables = P_0.getVariables();
		if (variables.isEmpty())
		{
			
			throw new AssertionError("There is no common type since there are no variables.");
		}
		Type type = ((VariableDeclarator)variables.get(0)).getType();
		for (int i = 1; i < variables.size(); i++)
		{
			if (!((VariableDeclarator)variables.get(i)).getType().equals(type))
			{
				
				throw new AssertionError("The variables do not have a common type.");
			}
		}
		return type;
	}

	
	virtual Type getElementType();

	
	
	
	static Type _003Cdefault_003EgetElementType(NodeWithVariables P_0)
	{
		NodeList variables = P_0.getVariables();
		if (variables.isEmpty())
		{
			
			throw new AssertionError("There is no element type since there are no variables.");
		}
		Type elementType = ((VariableDeclarator)variables.get(0)).getType().getElementType();
		for (int i = 1; i < variables.size(); i++)
		{
			if (!((VariableDeclarator)variables.get(i)).getType().getElementType().equals(elementType))
			{
				
				throw new AssertionError("The variables do not have a common type.");
			}
		}
		return elementType;
	}

	
		
	virtual Node setAllTypes(Type newType);

	
	
	
	static Node _003Cdefault_003EsetAllTypes(NodeWithVariables P_0, Type P_1)
	{
		Iterator iterator = P_0.getVariables().iterator();
		while (iterator.hasNext())
		{
			VariableDeclarator variableDeclarator = (VariableDeclarator)iterator.next();
			variableDeclarator.setType(P_1);
		}
		return (Node)P_0;
	}

	
		[DerivedProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/DerivedProperty;"
	})]
	virtual Optional getMaximumCommonType();

	
	
	
	static Optional _003Cdefault_003EgetMaximumCommonType(NodeWithVariables P_0)
	{
		Optional result = calculateMaximumCommonType((List)P_0.getVariables().stream().map(new ___003C_003EAnon1())
			.collect(Collectors.toList()));
		
		return result;
	}
}
