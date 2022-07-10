using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.errorprone.annotations.concurrent;
using IKVM.Attributes;
using java.lang;
using javax.annotation;

namespace com.google.common.math;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/math/ElementTypesAreNonnullByDefault;"
})]
public abstract class LinearTransformation : Object
{
	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal class _1 : Object
	{
		_1()
		{
			throw null;
		}
	}

	public sealed class LinearTransformationBuilder : Object
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private double x1;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private double y1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(60)]
		internal LinearTransformationBuilder(double P_0, double P_1, _1 P_2)
			: this(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 15, 104, 105, 105 })]
		private LinearTransformationBuilder(double P_0, double P_1)
		{
			x1 = P_0;
			y1 = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 42, 114, 105, 114, 139 })]
		public virtual LinearTransformation withSlope(double slope)
		{
			Preconditions.checkArgument((!Double.isNaN(slope)) ? true : false);
			if (DoubleUtils.isFinite(slope))
			{
				double num = y1 - x1 * slope;
				RegularLinearTransformation result = new RegularLinearTransformation(slope, num);
				_ = null;
				return result;
			}
			VerticalLinearTransformation result2 = new VerticalLinearTransformation(x1);
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 27, 123, 106, 114, 142 })]
		public virtual LinearTransformation and(double x2, double y2)
		{
			Preconditions.checkArgument((DoubleUtils.isFinite(x2) && DoubleUtils.isFinite(y2)) ? true : false);
			if (x2 == x1)
			{
				Preconditions.checkArgument(y2 != y1);
				VerticalLinearTransformation result = new VerticalLinearTransformation(x1);
				_ = null;
				return result;
			}
			LinearTransformation result2 = withSlope((y2 - y1) / (x2 - x1));
			_ = null;
			return result2;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class NaNLinearTransformation : LinearTransformation
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static NaNLinearTransformation INSTANCE;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(272)]
		private NaNLinearTransformation()
		{
		}

		public override bool isVertical()
		{
			return false;
		}

		public override bool isHorizontal()
		{
			return false;
		}

		public override double slope()
		{
			return double.NaN;
		}

		public override double transform(double P_0)
		{
			return double.NaN;
		}

		public override LinearTransformation inverse()
		{
			return this;
		}

		public override string toString()
		{
			return "NaN";
		}

		[LineNumberTable(274)]
		static NaNLinearTransformation()
		{
			INSTANCE = new NaNLinearTransformation();
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class RegularLinearTransformation : LinearTransformation
	{
		[Modifiers(Modifiers.Final)]
		internal new double slope;

		[Modifiers(Modifiers.Final)]
		internal double yIntercept;

		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		[LazyInit(new object[]
		{
			(byte)64,
			"Lcom/google/errorprone/annotations/concurrent/LazyInit;"
		})]
		internal new LinearTransformation inverse;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 118, 104, 105, 105, 103 })]
		internal RegularLinearTransformation(double P_0, double P_1)
		{
			this.slope = P_0;
			yIntercept = P_1;
			this.inverse = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 98, 109, 159, 13 })]
		private LinearTransformation createInverse()
		{
			if (this.slope != 0.0)
			{
				RegularLinearTransformation result = new RegularLinearTransformation(1.0 / this.slope, -1.0 * yIntercept / this.slope, this);
				_ = null;
				return result;
			}
			VerticalLinearTransformation result2 = new VerticalLinearTransformation(yIntercept, this);
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 124, 104, 105, 105, 103 })]
		internal RegularLinearTransformation(double P_0, double P_1, LinearTransformation P_2)
		{
			this.slope = P_0;
			yIntercept = P_1;
			this.inverse = P_2;
		}

		public override bool isVertical()
		{
			return false;
		}

		public override bool isHorizontal()
		{
			return this.slope == 0.0;
		}

		public override double slope()
		{
			return this.slope;
		}

		public override double transform(double P_0)
		{
			return P_0 * this.slope + yIntercept;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 88, 103 })]
		public override LinearTransformation inverse()
		{
			LinearTransformation linearTransformation = this.inverse;
			LinearTransformation result;
			if (linearTransformation == null)
			{
				LinearTransformation linearTransformation2 = createInverse();
				result = linearTransformation2;
				this.inverse = linearTransformation2;
			}
			else
			{
				result = linearTransformation;
			}
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(208)]
		public override string toString()
		{
			string result = String.format("y = %g * x + %g", Double.valueOf(this.slope), Double.valueOf(yIntercept));
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class VerticalLinearTransformation : LinearTransformation
	{
		[Modifiers(Modifiers.Final)]
		internal double x;

		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		[LazyInit(new object[]
		{
			(byte)64,
			"Lcom/google/errorprone/annotations/concurrent/LazyInit;"
		})]
		internal new LinearTransformation inverse;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 112, 104, 105, 103 })]
		internal VerticalLinearTransformation(double P_0)
		{
			x = P_0;
			this.inverse = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 117, 104, 105, 103 })]
		internal VerticalLinearTransformation(double P_0, LinearTransformation P_1)
		{
			x = P_0;
			this.inverse = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(268)]
		private LinearTransformation createInverse()
		{
			RegularLinearTransformation result = new RegularLinearTransformation(0.0, x, this);
			_ = null;
			return result;
		}

		public override bool isVertical()
		{
			return true;
		}

		public override bool isHorizontal()
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(248)]
		public override double slope()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(253)]
		public override double transform(double P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 144, 103 })]
		public override LinearTransformation inverse()
		{
			LinearTransformation linearTransformation = this.inverse;
			LinearTransformation result;
			if (linearTransformation == null)
			{
				LinearTransformation linearTransformation2 = createInverse();
				result = linearTransformation2;
				this.inverse = linearTransformation2;
			}
			else
			{
				result = linearTransformation;
			}
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(264)]
		public override string toString()
		{
			string result = String.format("x = %g", Double.valueOf(x));
			_ = null;
			return result;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(40)]
	public LinearTransformation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 190, 123 })]
	public static LinearTransformationBuilder mapping(double x1, double y1)
	{
		Preconditions.checkArgument((DoubleUtils.isFinite(x1) && DoubleUtils.isFinite(y1)) ? true : false);
		LinearTransformationBuilder result = new LinearTransformationBuilder(x1, y1, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 57, 108 })]
	public static LinearTransformation vertical(double x)
	{
		Preconditions.checkArgument(DoubleUtils.isFinite(x));
		VerticalLinearTransformation result = new VerticalLinearTransformation(x);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 66, 108, 102 })]
	public static LinearTransformation horizontal(double y)
	{
		Preconditions.checkArgument(DoubleUtils.isFinite(y));
		double num = 0.0;
		RegularLinearTransformation result = new RegularLinearTransformation(num, y);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(128)]
	public static LinearTransformation forNaN()
	{
		return NaNLinearTransformation.INSTANCE;
	}

	public abstract bool isVertical();

	public abstract bool isHorizontal();

	public abstract double slope();

	public abstract double transform(double d);

	public abstract LinearTransformation inverse();
}
