using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;Ljava/io/Serializable;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 91, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)91,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Serializable" })]
internal sealed class GeneralRange : java.lang.Object, Serializable.__Interface, ISerializable
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Ljava/util/Comparator<-TT;>;")]
	private Comparator m_comparator;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private bool m_hasLowerBound;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("TT;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private object lowerEndpoint;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private BoundType lowerBoundType;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private bool m_hasUpperBound;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("TT;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private object upperEndpoint;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private BoundType upperBoundType;

	[NonSerialized]
	[Signature("Lcom/google/common/collect/GeneralRange<TT;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private GeneralRange m_reverse;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Comparator<-TT;>;ZTT;Lcom/google/common/collect/BoundType;ZTT;Lcom/google/common/collect/BoundType;)V")]
	[LineNumberTable(new byte[]
	{
		159, 115, 133, 104, 113, 103, 103, 103, 114, 104,
		242, 71, 99, 98, 43, 166, 99, 99, 44, 198,
		102, 130, 44, 166, 148, 99, 189
	})]
	private GeneralRange(Comparator P_0, bool P_1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_2, BoundType P_3, bool P_4, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_5, BoundType P_6)
	{
		this.m_comparator = (Comparator)Preconditions.checkNotNull(P_0);
		this.m_hasLowerBound = P_1;
		this.m_hasUpperBound = P_4;
		lowerEndpoint = P_2;
		lowerBoundType = (BoundType)Preconditions.checkNotNull(P_3);
		upperEndpoint = P_5;
		upperBoundType = (BoundType)Preconditions.checkNotNull(P_6);
		if (P_1)
		{
			P_0.compare(NullnessCasts.uncheckedCastNullableTToT(P_2), NullnessCasts.uncheckedCastNullableTToT(P_2));
		}
		if (P_4)
		{
			P_0.compare(NullnessCasts.uncheckedCastNullableTToT(P_5), NullnessCasts.uncheckedCastNullableTToT(P_5));
		}
		if (P_1 && P_4)
		{
			int num = P_0.compare(NullnessCasts.uncheckedCastNullableTToT(P_2), NullnessCasts.uncheckedCastNullableTToT(P_5));
			Preconditions.checkArgument(num <= 0, "lowerEndpoint (%s) > upperEndpoint (%s)", P_2, P_5);
			if (num == 0)
			{
				Preconditions.checkArgument((P_3 != BoundType.___003C_003EOPEN || P_6 != BoundType.___003C_003EOPEN) ? true : false);
			}
		}
	}

	internal virtual bool hasUpperBound()
	{
		return this.m_hasUpperBound;
	}

	[Signature("()TT;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal virtual object getUpperEndpoint()
	{
		return upperEndpoint;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TT;)Z")]
	[LineNumberTable(new byte[] { 115, 104, 162, 108, 110 })]
	internal virtual bool tooLow([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		if (!hasLowerBound())
		{
			return false;
		}
		object o = NullnessCasts.uncheckedCastNullableTToT(getLowerEndpoint());
		int num = this.m_comparator.compare(P_0, o);
		return (num < 0) | (((num == 0) ? true : false) & (getLowerBoundType() == BoundType.___003C_003EOPEN));
	}

	internal virtual bool hasLowerBound()
	{
		return this.m_hasLowerBound;
	}

	[Signature("()TT;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal virtual object getLowerEndpoint()
	{
		return lowerEndpoint;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TT;)Z")]
	[LineNumberTable(new byte[] { 125, 104, 162, 108, 110 })]
	internal virtual bool tooHigh([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		if (!hasUpperBound())
		{
			return false;
		}
		object o = NullnessCasts.uncheckedCastNullableTToT(getUpperEndpoint());
		int num = this.m_comparator.compare(P_0, o);
		return (num > 0) | (((num == 0) ? true : false) & (getUpperBoundType() == BoundType.___003C_003EOPEN));
	}

	internal virtual BoundType getLowerBoundType()
	{
		return lowerBoundType;
	}

	internal virtual BoundType getUpperBoundType()
	{
		return upperBoundType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T::Ljava/lang/Comparable;>(Lcom/google/common/collect/Range<TT;>;)Lcom/google/common/collect/GeneralRange<TT;>;")]
	[LineNumberTable(new byte[] { 159, 186, 114, 150, 114, 150, 102, 168, 238, 59 })]
	internal static GeneralRange from(Range P_0)
	{
		IComparable comparable = ((!P_0.hasLowerBound()) ? null : P_0.lowerEndpoint());
		BoundType boundType = ((!P_0.hasLowerBound()) ? BoundType.___003C_003EOPEN : P_0.lowerBoundType());
		IComparable comparable2 = ((!P_0.hasUpperBound()) ? null : P_0.upperEndpoint());
		BoundType boundType2 = ((!P_0.hasUpperBound()) ? BoundType.___003C_003EOPEN : P_0.upperBoundType());
		GeneralRange result = new GeneralRange(Ordering.natural(), P_0.hasLowerBound(), comparable, boundType, P_0.hasUpperBound(), comparable2, boundType2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Comparator<-TT;>;)Lcom/google/common/collect/GeneralRange<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 91, 0, 0 })]
	[LineNumberTable(61)]
	internal static GeneralRange all(Comparator P_0)
	{
		GeneralRange result = new GeneralRange(P_0, false, null, BoundType.___003C_003EOPEN, false, null, BoundType.___003C_003EOPEN);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Comparator<-TT;>;TT;Lcom/google/common/collect/BoundType;)Lcom/google/common/collect/GeneralRange<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 91, 0, 0 })]
	[LineNumberTable(70)]
	internal static GeneralRange downTo(Comparator P_0, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_1, BoundType P_2)
	{
		GeneralRange result = new GeneralRange(P_0, true, P_1, P_2, false, null, BoundType.___003C_003EOPEN);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Comparator<-TT;>;TT;Lcom/google/common/collect/BoundType;)Lcom/google/common/collect/GeneralRange<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 91, 0, 0 })]
	[LineNumberTable(79)]
	internal static GeneralRange upTo(Comparator P_0, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_1, BoundType P_2)
	{
		GeneralRange result = new GeneralRange(P_0, false, null, BoundType.___003C_003EOPEN, true, P_1, P_2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Comparator<-TT;>;TT;Lcom/google/common/collect/BoundType;TT;Lcom/google/common/collect/BoundType;)Lcom/google/common/collect/GeneralRange<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 91, 0, 0 })]
	[LineNumberTable(92)]
	internal static GeneralRange range(Comparator P_0, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_1, BoundType P_2, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_3, BoundType P_4)
	{
		GeneralRange result = new GeneralRange(P_0, true, P_1, P_2, true, P_3, P_4);
		_ = null;
		return result;
	}

	[Signature("()Ljava/util/Comparator<-TT;>;")]
	internal virtual Comparator comparator()
	{
		return this.m_comparator;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 110, 124, 62 })]
	internal virtual bool isEmpty()
	{
		return ((hasUpperBound() && tooLow(NullnessCasts.uncheckedCastNullableTToT(getUpperEndpoint()))) || (hasLowerBound() && tooHigh(NullnessCasts.uncheckedCastNullableTToT(getLowerEndpoint())))) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TT;)Z")]
	[LineNumberTable(185)]
	internal virtual bool contains([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		return (!tooLow(P_0) && !tooHigh(P_0)) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/GeneralRange<TT;>;)Lcom/google/common/collect/GeneralRange<TT;>;")]
	[LineNumberTable(new byte[]
	{
		160, 79, 103, 150, 103, 103, 103, 104, 103, 103,
		105, 104, 120, 116, 103, 199, 103, 104, 104, 104,
		103, 104, 106, 104, 121, 118, 104, 200, 102, 112,
		154, 99, 102, 199
	})]
	internal virtual GeneralRange intersect(GeneralRange P_0)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkArgument(this.m_comparator.equals(P_0.m_comparator));
		int num = (this.m_hasLowerBound ? 1 : 0);
		object obj = getLowerEndpoint();
		BoundType __003C_003EOPEN = getLowerBoundType();
		int num2;
		if (!hasLowerBound())
		{
			num = (P_0.m_hasLowerBound ? 1 : 0);
			obj = P_0.getLowerEndpoint();
			__003C_003EOPEN = P_0.getLowerBoundType();
		}
		else if (P_0.hasLowerBound())
		{
			num2 = this.m_comparator.compare(getLowerEndpoint(), P_0.getLowerEndpoint());
			if (num2 < 0 || (num2 == 0 && P_0.getLowerBoundType() == BoundType.___003C_003EOPEN))
			{
				obj = P_0.getLowerEndpoint();
				__003C_003EOPEN = P_0.getLowerBoundType();
			}
		}
		num2 = (this.m_hasUpperBound ? 1 : 0);
		object obj2 = getUpperEndpoint();
		BoundType __003C_003ECLOSED = getUpperBoundType();
		if (!hasUpperBound())
		{
			num2 = (P_0.m_hasUpperBound ? 1 : 0);
			obj2 = P_0.getUpperEndpoint();
			__003C_003ECLOSED = P_0.getUpperBoundType();
		}
		else if (P_0.hasUpperBound())
		{
			int num3 = this.m_comparator.compare(getUpperEndpoint(), P_0.getUpperEndpoint());
			if (num3 > 0 || (num3 == 0 && P_0.getUpperBoundType() == BoundType.___003C_003EOPEN))
			{
				obj2 = P_0.getUpperEndpoint();
				__003C_003ECLOSED = P_0.getUpperBoundType();
			}
		}
		if (num != 0 && num2 != 0)
		{
			int num3 = this.m_comparator.compare(obj, obj2);
			if (num3 > 0 || (num3 == 0 && __003C_003EOPEN == BoundType.___003C_003EOPEN && __003C_003ECLOSED == BoundType.___003C_003EOPEN))
			{
				obj = obj2;
				__003C_003EOPEN = BoundType.___003C_003EOPEN;
				__003C_003ECLOSED = BoundType.___003C_003ECLOSED;
			}
		}
		GeneralRange result = new GeneralRange(this.m_comparator, (byte)num != 0, obj, __003C_003EOPEN, (byte)num2 != 0, obj2, __003C_003ECLOSED);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 127, 107, 103, 191, 23, 115, 115, 115, 246,
		58, 225, 72
	})]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		if (P_0 is GeneralRange)
		{
			GeneralRange generalRange = (GeneralRange)P_0;
			return (this.m_comparator.equals(generalRange.m_comparator) && this.m_hasLowerBound == generalRange.m_hasLowerBound && this.m_hasUpperBound == generalRange.m_hasUpperBound && getLowerBoundType().equals(generalRange.getLowerBoundType()) && getUpperBoundType().equals(generalRange.getUpperBoundType()) && com.google.common.@base.Objects.equal(getLowerEndpoint(), generalRange.getLowerEndpoint()) && com.google.common.@base.Objects.equal(getUpperEndpoint(), generalRange.getUpperEndpoint())) ? true : false;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 142, 146, 105, 105, 105, 230, 59 })]
	public override int hashCode()
	{
		int result = com.google.common.@base.Objects.hashCode(this.m_comparator, getLowerEndpoint(), getLowerBoundType(), getUpperEndpoint(), getUpperBoundType());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/GeneralRange<TT;>;")]
	[LineNumberTable(new byte[]
	{
		160, 154, 103, 99, 134, 145, 102, 140, 102, 107,
		103, 141
	})]
	internal virtual GeneralRange reverse()
	{
		GeneralRange generalRange = this.m_reverse;
		if (generalRange == null)
		{
			generalRange = new GeneralRange(Ordering.from(this.m_comparator).reverse(), this.m_hasUpperBound, getUpperEndpoint(), getUpperBoundType(), this.m_hasLowerBound, getLowerEndpoint(), getLowerBoundType());
			generalRange.m_reverse = this;
			GeneralRange result = generalRange;
			this.m_reverse = result;
			return result;
		}
		return generalRange;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160,
		173,
		140,
		116,
		155,
		123,
		byte.MaxValue,
		95,
		58
	})]
	public override string toString()
	{
		string text = java.lang.String.valueOf(this.m_comparator);
		int c = ((lowerBoundType != BoundType.___003C_003ECLOSED) ? 40 : 91);
		string text2 = java.lang.String.valueOf((!this.m_hasLowerBound) ? "-∞" : lowerEndpoint);
		string text3 = java.lang.String.valueOf((!this.m_hasUpperBound) ? "∞" : upperEndpoint);
		int c2 = ((upperBoundType != BoundType.___003C_003ECLOSED) ? 41 : 93);
		int num = 4 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text3));
		num = num;
		string result = new StringBuilder(num).append(text).append(":").append((char)c)
			.append(text2)
			.append(',')
			.append(text3)
			.append((char)c2)
			.toString();
		_ = null;
		return result;
	}

	[SecurityCritical]
	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	void ISerializable.GetObjectData(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.writeObject(this, P_0);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected GeneralRange(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.readObject(this, P_0);
	}
}
