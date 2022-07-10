using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.common.primitives;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util.concurrent.atomic;
using java.util.function;

namespace com.google.common.util.concurrent;

[Serializable]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Serializable" })]
public class AtomicDoubleArray : java.lang.Object, Serializable.__Interface, ISerializable
{
	[SpecialName]
	private sealed class ___003C_003EAnon0 : DoubleBinaryOperator
	{
		internal ___003C_003EAnon0()
		{
		}

		public double applyAsDouble(double P_0, double P_1)
		{
			double result = java.lang.Double.sum(P_0, P_1);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon1 : DoubleUnaryOperator
	{
		private readonly DoubleBinaryOperator arg_00241;

		private readonly double arg_00242;

		internal ___003C_003EAnon1(DoubleBinaryOperator P_0, double P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public double applyAsDouble(double P_0)
		{
			double result = lambda_0024getAndAccumulate_00240(arg_00241, arg_00242, P_0);
			_ = null;
			return result;
		}

		[SpecialName]
		public DoubleUnaryOperator compose(DoubleUnaryOperator P_0)
		{
			return DoubleUnaryOperator._003Cdefault_003Ecompose(this, P_0);
		}

		[SpecialName]
		public DoubleUnaryOperator andThen(DoubleUnaryOperator P_0)
		{
			return DoubleUnaryOperator._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon2 : DoubleUnaryOperator
	{
		private readonly DoubleBinaryOperator arg_00241;

		private readonly double arg_00242;

		internal ___003C_003EAnon2(DoubleBinaryOperator P_0, double P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public double applyAsDouble(double P_0)
		{
			double result = lambda_0024accumulateAndGet_00241(arg_00241, arg_00242, P_0);
			_ = null;
			return result;
		}

		[SpecialName]
		public DoubleUnaryOperator compose(DoubleUnaryOperator P_0)
		{
			return DoubleUnaryOperator._003Cdefault_003Ecompose(this, P_0);
		}

		[SpecialName]
		public DoubleUnaryOperator andThen(DoubleUnaryOperator P_0)
		{
			return DoubleUnaryOperator._003Cdefault_003EandThen(this, P_0);
		}
	}

	private const long serialVersionUID = 0L;

	[NonSerialized]
	private AtomicLongArray longs;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 90, 103 })]
	public double getAndAccumulate(int i, double x, DoubleBinaryOperator accumulatorFunction)
	{
		Preconditions.checkNotNull(accumulatorFunction);
		double andUpdate = getAndUpdate(i, new ___003C_003EAnon1(accumulatorFunction, x));
		_ = null;
		return andUpdate;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 106, 103 })]
	public double accumulateAndGet(int i, double x, DoubleBinaryOperator accumulatorFunction)
	{
		Preconditions.checkNotNull(accumulatorFunction);
		double result = updateAndGet(i, new ___003C_003EAnon2(accumulatorFunction, x));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 122, 109, 106, 105, 106, 113, 130 })]
	public double getAndUpdate(int i, DoubleUnaryOperator updaterFunction)
	{
		long num;
		double num2;
		DoubleConverter converter = default(DoubleConverter);
		long update;
		do
		{
			num = longs.get(i);
			num2 = DoubleConverter.ToDouble(num, ref converter);
			double value = updaterFunction.applyAsDouble(num2);
			update = DoubleConverter.ToLong(value, ref converter);
		}
		while (!longs.compareAndSet(i, num, update));
		return num2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 144, 109, 106, 105, 106, 113, 130 })]
	public double updateAndGet(int i, DoubleUnaryOperator updaterFunction)
	{
		long num;
		DoubleConverter converter = default(DoubleConverter);
		double num2;
		long update;
		do
		{
			num = longs.get(i);
			double operand = DoubleConverter.ToDouble(num, ref converter);
			num2 = updaterFunction.applyAsDouble(operand);
			update = DoubleConverter.ToLong(num2, ref converter);
		}
		while (!longs.compareAndSet(i, num, update));
		return num2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(89)]
	public int length()
	{
		int result = longs.length();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(99)]
	public double get(int i)
	{
		DoubleConverter converter = default(DoubleConverter);
		double result = DoubleConverter.ToDouble(longs.get(i), ref converter);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(205)]
	private static double lambda_0024getAndAccumulate_00240(DoubleBinaryOperator P_0, double P_1, double P_2)
	{
		double result = P_0.applyAsDouble(P_2, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(221)]
	private static double lambda_0024accumulateAndGet_00241(DoubleBinaryOperator P_0, double P_1, double P_2)
	{
		double result = P_0.applyAsDouble(P_2, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 13, 104, 108 })]
	public AtomicDoubleArray(int length)
	{
		longs = new AtomicLongArray(length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 24, 104, 99, 103, 102, 45, 166, 108 })]
	public AtomicDoubleArray(double[] array)
	{
		int num = array.Length;
		long[] array2 = new long[num];
		DoubleConverter converter = default(DoubleConverter);
		for (int i = 0; i < num; i++)
		{
			array2[i] = DoubleConverter.ToLong(array[i], ref converter);
		}
		longs = new AtomicLongArray(array2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 59, 106, 111 })]
	public void set(int i, double newValue)
	{
		DoubleConverter converter = default(DoubleConverter);
		long newValue2 = DoubleConverter.ToLong(newValue, ref converter);
		longs.set(i, newValue2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 70, 106, 111 })]
	public void lazySet(int i, double newValue)
	{
		DoubleConverter converter = default(DoubleConverter);
		long newValue2 = DoubleConverter.ToLong(newValue, ref converter);
		longs.lazySet(i, newValue2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 82, 106 })]
	public double getAndSet(int i, double newValue)
	{
		DoubleConverter converter = default(DoubleConverter);
		long newValue2 = DoubleConverter.ToLong(newValue, ref converter);
		double result = DoubleConverter.ToDouble(longs.getAndSet(i, newValue2), ref converter);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(147)]
	public bool compareAndSet(int i, double expect, double update)
	{
		DoubleConverter converter = default(DoubleConverter);
		bool result = longs.compareAndSet(i, DoubleConverter.ToLong(expect, ref converter), DoubleConverter.ToLong(update, ref converter));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(165)]
	public bool weakCompareAndSet(int i, double expect, double update)
	{
		DoubleConverter converter = default(DoubleConverter);
		bool result = longs.weakCompareAndSet(i, DoubleConverter.ToLong(expect, ref converter), DoubleConverter.ToLong(update, ref converter));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(177)]
	public double getAndAdd(int i, double delta)
	{
		double andAccumulate = getAndAccumulate(i, delta, new ___003C_003EAnon0());
		_ = null;
		return andAccumulate;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(189)]
	public virtual double addAndGet(int i, double delta)
	{
		double result = accumulateAndGet(i, delta, new ___003C_003EAnon0());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 161, 105, 100, 198, 108, 105, 98, 122, 100,
		144, 240, 59
	})]
	public override string toString()
	{
		int num = length() - 1;
		if (num == -1)
		{
			return "[]";
		}
		StringBuilder stringBuilder = new StringBuilder(19 * (num + 1));
		stringBuilder.append('[');
		int num2 = 0;
		DoubleConverter converter = default(DoubleConverter);
		while (true)
		{
			stringBuilder.append(DoubleConverter.ToDouble(longs.get(num2), ref converter));
			if (num2 == num)
			{
				break;
			}
			stringBuilder.append(',').append(' ');
			num2++;
		}
		string result = stringBuilder.append(']').toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 185, 166, 103, 167, 102, 45, 166 })]
	private void writeObject(ObjectOutputStream P_0)
	{
		P_0.defaultWriteObject();
		int num = length();
		P_0.writeInt(num);
		for (int i = 0; i < num; i++)
		{
			P_0.writeDouble(get(i));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "java.lang.ClassNotFoundException" })]
	[LineNumberTable(new byte[] { 160, 200, 134, 103, 102, 102, 52, 166, 118 })]
	private void readObject(ObjectInputStream P_0)
	{
		P_0.defaultReadObject();
		int num = P_0.readInt();
		ImmutableLongArray.Builder builder = ImmutableLongArray.builder();
		DoubleConverter converter = default(DoubleConverter);
		for (int i = 0; i < num; i++)
		{
			builder.add(DoubleConverter.ToLong(P_0.readDouble(), ref converter));
		}
		longs = new AtomicLongArray(builder.build().toArray());
	}

	[HideFromJava]
	public static implicit operator Serializable(AtomicDoubleArray P_0)
	{
		Serializable result = default(Serializable);
		result.___003Cref_003E = P_0;
		return result;
	}

	[SecurityCritical]
	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected virtual void GetObjectData(SerializationInfo P_0, StreamingContext P_1)
	{
		Serialization.writeObject(this, P_0);
	}

	void ISerializable.GetObjectData(SerializationInfo P_0, StreamingContext P_1)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetObjectData
		this.GetObjectData(P_0, P_1);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected AtomicDoubleArray(SerializationInfo P_0, StreamingContext P_1)
	{
		Serialization.readObject(this, P_0);
	}
}
