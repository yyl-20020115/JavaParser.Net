using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace javax.json;

public interface JsonPatch
{
	[Serializable]
	[InnerClass(null, Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Ljavax/json/JsonPatch$Operation;>;")]
	[Modifiers(Modifiers.Public | Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	public sealed class Operation : java.lang.Enum
	{
		[Serializable]
		[HideFromJava]
		public enum __Enum
		{
			ADD,
			REMOVE,
			REPLACE,
			MOVE,
			COPY,
			TEST
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static Operation ___003C_003EADD;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static Operation ___003C_003EREMOVE;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static Operation ___003C_003EREPLACE;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static Operation ___003C_003EMOVE;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static Operation ___003C_003ECOPY;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static Operation ___003C_003ETEST;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private string m_operationName;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static Operation[] _0024VALUES;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static Operation ADD
		{
			[HideFromJava]
			get
			{
				return ___003C_003EADD;
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static Operation REMOVE
		{
			[HideFromJava]
			get
			{
				return ___003C_003EREMOVE;
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static Operation REPLACE
		{
			[HideFromJava]
			get
			{
				return ___003C_003EREPLACE;
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static Operation MOVE
		{
			[HideFromJava]
			get
			{
				return ___003C_003EMOVE;
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static Operation COPY
		{
			[HideFromJava]
			get
			{
				return ___003C_003ECOPY;
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static Operation TEST
		{
			[HideFromJava]
			get
			{
				return ___003C_003ETEST;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(80)]
		public static Operation[] values()
		{
			return (Operation[])_0024VALUES.Clone();
		}

		public virtual string operationName()
		{
			return this.m_operationName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/String;)V")]
		[LineNumberTable(new byte[] { 64, 106, 103 })]
		private Operation(string P_0, int P_1, string P_2)
			: base(P_0, P_1)
		{
			this.m_operationName = P_2;
			GC.KeepAlive(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(80)]
		public static Operation valueOf(string name)
		{
			return (Operation)java.lang.Enum.valueOf(ClassLiteral<Operation>.Value, name);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 85, 115, 110, 2, 230, 69 })]
		public static Operation fromOperationName(string operationName)
		{
			Operation[] array = values();
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				Operation operation = array[i];
				if (java.lang.String.instancehelper_equalsIgnoreCase(operation.operationName(), operationName))
				{
					return operation;
				}
			}
			string message = new StringBuilder().append("Illegal value for the operationName of the JSON patch operation: ").append(operationName).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new JsonException(message);
		}

		[LineNumberTable(new byte[]
		{
			35, 245, 69, 245, 69, 245, 69, 245, 69, 245,
			69, 245, 34
		})]
		static Operation()
		{
			___003C_003EADD = new Operation("ADD", 0, "add");
			___003C_003EREMOVE = new Operation("REMOVE", 1, "remove");
			___003C_003EREPLACE = new Operation("REPLACE", 2, "replace");
			___003C_003EMOVE = new Operation("MOVE", 3, "move");
			___003C_003ECOPY = new Operation("COPY", 4, "copy");
			___003C_003ETEST = new Operation("TEST", 5, "test");
			_0024VALUES = new Operation[6] { ___003C_003EADD, ___003C_003EREMOVE, ___003C_003EREPLACE, ___003C_003EMOVE, ___003C_003ECOPY, ___003C_003ETEST };
		}
	}

	[Signature("<T::Ljavax/json/JsonStructure;>(TT;)TT;")]
	virtual JsonStructure apply(JsonStructure js);

	virtual JsonArray toJsonArray();
}
