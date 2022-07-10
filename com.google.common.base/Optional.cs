using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using ikvm.@internal;
using ikvm.lang;
using java.io;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.@base;

[Serializable]
[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;Ljava/io/Serializable;")]
[DoNotMock(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/DoNotMock;",
	"value",
	"Use Optional.of(value) or Optional.absent()"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Serializable" })]
public abstract class Optional : java.lang.Object, Serializable.__Interface, ISerializable
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Ljava/lang/Iterable<TT;>;")]
	[EnclosingMethod(null, "presentInstances", "(Ljava.lang.Iterable;)Ljava.lang.Iterable;")]
	[Implements(new string[] { "java.lang.Iterable" })]
	internal class _1 : java.lang.Object, Iterable, IEnumerable
	{
		[SpecialName]
		[Signature("Lcom/google/common/base/AbstractIterator<TT;>;")]
		[EnclosingMethod(null, "iterator", "()Ljava.util.Iterator;")]
		internal class _1 : AbstractIterator
		{
			[Modifiers(Modifiers.Private | Modifiers.Final)]
			[Signature("Ljava/util/Iterator<+Lcom/google/common/base/Optional<+TT;>;>;")]
			private Iterator iterator;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Optional._1 this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 160, 227, 111, 108, 52 })]
			internal _1(Optional._1 P_0)
			{
				this_00240 = P_0;
				base._002Ector();
				iterator = (Iterator)Preconditions.checkNotNull(this_00240.val_0024optionals.iterator());
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()TT;")]
			[LineNumberTable(new byte[] { 160, 234, 109, 113, 104, 137, 98 })]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			protected internal override object computeNext()
			{
				while (iterator.hasNext())
				{
					Optional optional = (Optional)iterator.next();
					if (optional.isPresent())
					{
						object result = optional.get();
						_ = null;
						return result;
					}
				}
				object result2 = endOfData();
				_ = null;
				return result2;
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Iterable val_0024optionals;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(338)]
		internal _1(Iterable P_0)
		{
			val_0024optionals = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TT;>;")]
		[LineNumberTable(341)]
		public virtual Iterator iterator()
		{
			_1 result = new _1(this);
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEach(Consumer P_0)
		{
			Iterable._003Cdefault_003EforEach(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Spliterator spliterator()
		{
			return Iterable._003Cdefault_003Espliterator(this);
		}

		[SpecialName]
		[HideFromJava]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new IterableEnumerator(this);
		}
	}

	private const long serialVersionUID = 0L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>()Lcom/google/common/base/Optional<TT;>;")]
	[LineNumberTable(94)]
	public static Optional absent()
	{
		Optional result = Absent.withType();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;)Lcom/google/common/base/Optional<TT;>;")]
	[LineNumberTable(117)]
	public static Optional fromNullable([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object nullableReference)
	{
		Optional result = ((nullableReference != null) ? new Present(nullableReference) : absent());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Optional<TT;>;")]
	[LineNumberTable(159)]
	public virtual java.util.Optional toJavaUtil()
	{
		java.util.Optional result = java.util.Optional.ofNullable(orNull());
		_ = null;
		return result;
	}

	[Signature("()TT;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public abstract object orNull();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;)Lcom/google/common/base/Optional<TT;>;")]
	[LineNumberTable(106)]
	public static Optional of(object reference)
	{
		Present result = new Present(Preconditions.checkNotNull(reference));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Optional<TT;>;)Lcom/google/common/base/Optional<TT;>;")]
	[LineNumberTable(128)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public static Optional fromJavaUtil([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] java.util.Optional javaUtilOptional)
	{
		Optional result = ((javaUtilOptional != null) ? fromNullable(javaUtilOptional.orElse(null)) : null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Lcom/google/common/base/Optional<TT;>;)Ljava/util/Optional<TT;>;")]
	[LineNumberTable(146)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public static java.util.Optional toJavaUtil([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] Optional googleOptional)
	{
		java.util.Optional result = googleOptional?.toJavaUtil();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(162)]
	internal Optional()
	{
	}

	public abstract bool isPresent();

	[Signature("()TT;")]
	public abstract object get();

	[Signature("(TT;)TT;")]
	public abstract object or(object obj);

	[Signature("(Lcom/google/common/base/Optional<+TT;>;)Lcom/google/common/base/Optional<TT;>;")]
	public abstract Optional or(Optional o);

	[Signature("(Lcom/google/common/base/Supplier<+TT;>;)TT;")]
	public abstract object or(Supplier s);

	[Signature("()Ljava/util/Set<TT;>;")]
	public abstract Set asSet();

	[Signature("<V:Ljava/lang/Object;>(Lcom/google/common/base/Function<-TT;TV;>;)Lcom/google/common/base/Optional<TV;>;")]
	public abstract Optional transform(Function f);

	public abstract override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj);

	public abstract override int hashCode();

	public abstract override string toString();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<+Lcom/google/common/base/Optional<+TT;>;>;)Ljava/lang/Iterable<TT;>;")]
	[LineNumberTable(new byte[] { 160, 223, 103 })]
	public static Iterable presentInstances(Iterable optionals)
	{
		Preconditions.checkNotNull(optionals);
		_1 result = new _1(optionals);
		_ = null;
		return result;
	}

	[HideFromJava]
	public static implicit operator Serializable(Optional P_0)
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
	protected Optional(SerializationInfo P_0, StreamingContext P_1)
	{
		Serialization.readObject(this, P_0);
	}
}
