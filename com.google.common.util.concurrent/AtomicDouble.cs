using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using com.google.common.@base;
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
public class AtomicDouble : Number, Serializable.__Interface
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

	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	private const long serialVersionUID = 0L;

	[NonSerialized]
	private volatile long value;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Ljava/util/concurrent/atomic/AtomicLongFieldUpdater<Lcom/google/common/util/concurrent/AtomicDouble;>;")]
	private static AtomicLongFieldUpdater updater;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 72, 103 })]
	public double getAndAccumulate(double x, DoubleBinaryOperator accumulatorFunction)
	{
		Preconditions.checkNotNull(accumulatorFunction);
		double andUpdate = getAndUpdate(new ___003C_003EAnon1(accumulatorFunction, x));
		_ = null;
		return andUpdate;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 87, 103 })]
	public double accumulateAndGet(double x, DoubleBinaryOperator accumulatorFunction)
	{
		Preconditions.checkNotNull(accumulatorFunction);
		double result = updateAndGet(new ___003C_003EAnon2(accumulatorFunction, x));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 101, 108, 106, 105, 106, 112, 130 })]
	public double getAndUpdate(DoubleUnaryOperator updateFunction)
	{
		long expect;
		double num;
		DoubleConverter converter = default(DoubleConverter);
		long update;
		do
		{
			expect = ByteCodeHelper.VolatileRead(ref value);
			num = DoubleConverter.ToDouble(expect, ref converter);
			double num2 = updateFunction.applyAsDouble(num);
			update = DoubleConverter.ToLong(num2, ref converter);
		}
		while (!updater.compareAndSet(this, expect, update));
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 121, 108, 106, 105, 106, 112, 130 })]
	public double updateAndGet(DoubleUnaryOperator updateFunction)
	{
		long expect;
		DoubleConverter converter = default(DoubleConverter);
		double result;
		long update;
		do
		{
			expect = ByteCodeHelper.VolatileRead(ref value);
			double operand = DoubleConverter.ToDouble(expect, ref converter);
			result = updateFunction.applyAsDouble(operand);
			update = DoubleConverter.ToLong(result, ref converter);
		}
		while (!updater.compareAndSet(this, expect, update));
		return result;
	}

	[LineNumberTable(88)]
	public double get()
	{
		DoubleConverter converter = default(DoubleConverter);
		double result = DoubleConverter.ToDouble(ByteCodeHelper.VolatileRead(ref value), ref converter);
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 47, 106, 110 })]
	public void set(double newValue)
	{
		DoubleConverter converter = default(DoubleConverter);
		long num = DoubleConverter.ToLong(newValue, ref converter);
		long newValue2 = num;
		ByteCodeHelper.VolatileWrite(ref value, newValue2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(187)]
	private static double lambda_0024getAndAccumulate_00240(DoubleBinaryOperator P_0, double P_1, double P_2)
	{
		double result = P_0.applyAsDouble(P_2, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(202)]
	private static double lambda_0024accumulateAndGet_00241(DoubleBinaryOperator P_0, double P_1, double P_2)
	{
		double result = P_0.applyAsDouble(P_2, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 23, 104, 118 })]
	public AtomicDouble(double initialValue)
	{
		DoubleConverter converter = default(DoubleConverter);
		ByteCodeHelper.VolatileWrite(newValue: DoubleConverter.ToLong(initialValue, ref converter), v: ref value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 28, 136 })]
	public AtomicDouble()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 57, 106, 110 })]
	public void lazySet(double newValue)
	{
		DoubleConverter converter = default(DoubleConverter);
		long newValue2 = DoubleConverter.ToLong(newValue, ref converter);
		updater.lazySet(this, newValue2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 68, 106 })]
	public double getAndSet(double newValue)
	{
		DoubleConverter converter = default(DoubleConverter);
		long newValue2 = DoubleConverter.ToLong(newValue, ref converter);
		double result = DoubleConverter.ToDouble(updater.getAndSet(this, newValue2), ref converter);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(132)]
	public bool compareAndSet(double expect, double update)
	{
		DoubleConverter converter = default(DoubleConverter);
		bool result = updater.compareAndSet(this, DoubleConverter.ToLong(expect, ref converter), DoubleConverter.ToLong(update, ref converter));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 99, 104, 48 })]
	public bool weakCompareAndSet(double expect, double update)
	{
		DoubleConverter converter = default(DoubleConverter);
		bool result = updater.weakCompareAndSet(this, DoubleConverter.ToLong(expect, ref converter), DoubleConverter.ToLong(update, ref converter));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(161)]
	public double getAndAdd(double delta)
	{
		double andAccumulate = getAndAccumulate(delta, new ___003C_003EAnon0());
		_ = null;
		return andAccumulate;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(172)]
	public double addAndGet(double delta)
	{
		double result = accumulateAndGet(delta, new ___003C_003EAnon0());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(252)]
	public override string toString()
	{
		string result = java.lang.Double.toString(get());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(261)]
	public override int intValue()
	{
		return ByteCodeHelper.d2i(get());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(270)]
	public override long longValue()
	{
		return ByteCodeHelper.d2l(get());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(279)]
	public override float floatValue()
	{
		return (float)get();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(285)]
	public override double doubleValue()
	{
		double result = get();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 180, 134, 110 })]
	private void writeObject(ObjectOutputStream P_0)
	{
		P_0.defaultWriteObject();
		P_0.writeDouble(get());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "java.lang.ClassNotFoundException" })]
	[LineNumberTable(new byte[] { 160, 188, 134, 110 })]
	private void readObject(ObjectInputStream P_0)
	{
		P_0.defaultReadObject();
		set(P_0.readDouble());
	}

	[LineNumberTable(new byte[] { 15, 106, 47 })]
	static AtomicDouble()
	{
		updater = AtomicLongFieldUpdater.newUpdater(ClassLiteral<AtomicDouble>.Value, "value", AtomicDouble.___003CGetCallerID_003E());
	}

	static CallerID ___003CGetCallerID_003E()
	{
		if (___003CcallerID_003E == null)
		{
			___003CcallerID_003E = new ___003CCallerID_003E();
		}
		return ___003CcallerID_003E;
	}

	[HideFromJava]
	public static implicit operator Serializable(AtomicDouble P_0)
	{
		Serializable result = default(Serializable);
		result.___003Cref_003E = P_0;
		return result;
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected AtomicDouble(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
