using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace javassist;

public abstract class CtMember : Object
{
	internal class Cache : CtMember
	{
		private CtMember methodTail;

		private CtMember consTail;

		private CtMember fieldTail;

		internal virtual CtMember fieldHead()
		{
			return consTail;
		}

		internal virtual CtMember lastField()
		{
			return fieldTail;
		}

		internal virtual CtMember consHead()
		{
			return methodTail;
		}

		internal virtual CtMember lastCons()
		{
			return consTail;
		}

		internal virtual CtMember methodHead()
		{
			return this;
		}

		internal virtual CtMember lastMethod()
		{
			return methodTail;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 16, 105, 103, 103, 103, 108 })]
		internal Cache(CtClassType P_0)
			: base(P_0)
		{
			methodTail = this;
			consTail = this;
			fieldTail = this;
			fieldTail.next = this;
		}

		[LineNumberTable(new byte[] { 54, 103, 108, 103 })]
		internal virtual void addField(CtMember P_0)
		{
			P_0.next = this;
			fieldTail.next = P_0;
			fieldTail = P_0;
		}

		[LineNumberTable(new byte[] { 31, 113, 108, 110, 103, 110, 167, 103 })]
		internal virtual void addMethod(CtMember P_0)
		{
			P_0.next = methodTail.next;
			methodTail.next = P_0;
			if (methodTail == consTail)
			{
				consTail = P_0;
				if (methodTail == fieldTail)
				{
					fieldTail = P_0;
				}
			}
			methodTail = P_0;
		}

		[LineNumberTable(new byte[] { 45, 113, 108, 110, 135, 103 })]
		internal virtual void addConstructor(CtMember P_0)
		{
			P_0.next = consTail.next;
			consTail.next = P_0;
			if (consTail == fieldTail)
			{
				fieldTail = P_0;
			}
			consTail = P_0;
		}

		[LineNumberTable(new byte[] { 60, 98, 100, 100, 170 })]
		internal static int count(CtMember P_0, CtMember P_1)
		{
			int num = 0;
			while (P_0 != P_1)
			{
				num++;
				P_0 = P_0.next;
			}
			return num;
		}

		[LineNumberTable(new byte[]
		{
			70, 130, 110, 100, 108, 105, 135, 105, 135, 105,
			201, 140
		})]
		internal virtual void remove(CtMember P_0)
		{
			CtMember ctMember = this;
			CtMember ctMember2;
			while ((ctMember2 = ctMember.next) != this)
			{
				if (ctMember2 == P_0)
				{
					ctMember.next = ctMember2.next;
					if (ctMember2 == methodTail)
					{
						methodTail = ctMember;
					}
					if (ctMember2 == consTail)
					{
						consTail = ctMember;
					}
					if (ctMember2 == fieldTail)
					{
						fieldTail = ctMember;
					}
					break;
				}
				ctMember = ctMember.next;
			}
		}

		protected internal override void extendToString(StringBuilder P_0)
		{
		}

		public override bool hasAnnotation(string P_0)
		{
			return false;
		}

		[Throws(new string[] { "java.lang.ClassNotFoundException" })]
		[Signature("(Ljava/lang/Class<*>;)Ljava/lang/Object;")]
		public override object getAnnotation(Class P_0)
		{
			return null;
		}

		[Throws(new string[] { "java.lang.ClassNotFoundException" })]
		public override object[] getAnnotations()
		{
			return null;
		}

		public override byte[] getAttribute(string P_0)
		{
			return null;
		}

		public override object[] getAvailableAnnotations()
		{
			return null;
		}

		public override int getModifiers()
		{
			return 0;
		}

		public override string getName()
		{
			return null;
		}

		public override string getSignature()
		{
			return null;
		}

		public override void setAttribute(string P_0, byte[] P_1)
		{
		}

		public override void setModifiers(int P_0)
		{
		}

		public override string getGenericSignature()
		{
			return null;
		}

		public override void setGenericSignature(string P_0)
		{
		}
	}

	internal CtMember next;

	protected internal CtClass declaringClass;

	public abstract string getName();

	public virtual CtClass getDeclaringClass()
	{
		return declaringClass;
	}

	public abstract int getModifiers();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 108, 113, 105, 114, 105, 114, 103, 105 })]
	public override string toString()
	{
		StringBuilder stringBuilder = new StringBuilder(Object.instancehelper_getClass(this).getName());
		stringBuilder.append('@');
		stringBuilder.append(Integer.toHexString(Object.instancehelper_hashCode(this)));
		stringBuilder.append('[');
		stringBuilder.append(Modifier.toString(getModifiers()));
		extendToString(stringBuilder);
		stringBuilder.append(']');
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	public abstract string getGenericSignature();

	public abstract string getSignature();

	protected internal abstract void extendToString(StringBuilder sb);

	public abstract bool hasAnnotation(string str);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 91, 104, 103, 103 })]
	protected internal CtMember(CtClass clazz)
	{
		declaringClass = clazz;
		this.next = null;
	}

	internal CtMember next()
	{
		return this.next;
	}

	internal virtual void nameReplaced()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 72, 103, 104, 98, 104, 138, 108, 135, 99,
		138, 136, 107, 143
	})]
	public virtual bool visibleFrom(CtClass clazz)
	{
		int modifiers = getModifiers();
		if (Modifier.isPublic(modifiers))
		{
			return true;
		}
		if (Modifier.isPrivate(modifiers))
		{
			return clazz == declaringClass;
		}
		string packageName = declaringClass.getPackageName();
		string packageName2 = clazz.getPackageName();
		int num = (((packageName != null) ? String.instancehelper_equals(packageName, packageName2) : (packageName2 == null)) ? 1 : 0);
		if (num == 0 && Modifier.isProtected(modifiers))
		{
			bool result = clazz.subclassOf(declaringClass);
			_ = null;
			return result;
		}
		return (byte)num != 0;
	}

	public abstract void setModifiers(int i);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<*>;)Z")]
	[LineNumberTable(231)]
	public virtual bool hasAnnotation(Class clz)
	{
		bool result = hasAnnotation(clz.getName());
		_ = null;
		return result;
	}

	[Throws(new string[] { "java.lang.ClassNotFoundException" })]
	[Signature("(Ljava/lang/Class<*>;)Ljava/lang/Object;")]
	public abstract object getAnnotation(Class c);

	[Throws(new string[] { "java.lang.ClassNotFoundException" })]
	public abstract object[] getAnnotations();

	public abstract object[] getAvailableAnnotations();

	public abstract void setGenericSignature(string str);

	public abstract byte[] getAttribute(string str);

	public abstract void setAttribute(string str, byte[] barr);
}
