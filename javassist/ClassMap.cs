using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.lang;
using java.util;
using javassist.bytecode;

namespace javassist;

[Serializable]
[IKVM.Attributes.Signature("Ljava/util/HashMap<Ljava/lang/String;Ljava/lang/String;>;")]
public class ClassMap : HashMap
{
	private const long serialVersionUID = 1L;

	private ClassMap parent;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 48, 100, 130, 103, 104, 108, 115 })]
	public virtual string put(string oldname, string newname)
	{
		if ((object)oldname == newname)
		{
			return oldname;
		}
		string text = toJvmName(oldname);
		string text2 = get(text);
		if (text2 == null || !java.lang.String.instancehelper_equals(text2, text))
		{
			return (string)base.put((object)text, (object)toJvmName(newname));
		}
		return text2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(168)]
	public static string toJvmName(string classname)
	{
		string result = Descriptor.toJvmName(classname);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 93, 109, 107, 111 })]
	public new virtual string get(object jvmClassName)
	{
		string text = (string)base.get(jvmClassName);
		if (text == null && parent != null)
		{
			string result = parent.get(jvmClassName);
			_ = null;
			return result;
		}
		return text;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 109, 103, 105 })]
	public virtual void fix(string name)
	{
		string text = toJvmName(name);
		base.put((object)text, (object)text);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(60)]
	public ClassMap()
	{
		parent = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(62)]
	internal ClassMap(ClassMap P_0)
	{
		parent = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 25, 115 })]
	public virtual void put(CtClass oldname, CtClass newname)
	{
		put(oldname.getName(), newname.getName());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 68, 100, 129, 103, 104, 99, 110 })]
	public virtual void putIfNone(string oldname, string newname)
	{
		if ((object)oldname != newname)
		{
			string text = toJvmName(oldname);
			string text2 = get(text);
			if (text2 == null)
			{
				base.put((object)text, (object)toJvmName(newname));
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(128)]
	protected internal string put0(string oldname, string newname)
	{
		return (string)base.put((object)oldname, (object)newname);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 102, 110 })]
	public virtual void fix(CtClass clazz)
	{
		fix(clazz.getName());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(176)]
	public static string toJavaName(string classname)
	{
		string result = Descriptor.toJavaName(classname);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(52)]
	public override object put(object obj1, object obj2)
	{
		string result = put((string)obj1, (string)obj2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(52)]
	public virtual object _003Cbridge_003Eget(object obj)
	{
		string result = get(obj);
		_ = null;
		return result;
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected ClassMap(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
