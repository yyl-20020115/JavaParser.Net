using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.utils;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.lang.reflect;
using java.util;

namespace com.github.javaparser.metamodel;

public class PropertyMetaModel
{
	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	
	private BaseNodeMetaModel containingNodeMetaModel;

	
	private string name;

	
		private Class type;

	
		private Optional nodeReference;

	
	private bool m_isOptional;

	
	private bool m_isNonEmpty;

	
	private bool m_isNodeList;

	
	private bool m_hasWildcard;

	
	private static CallerID ___003CcallerID_003E;

	
	
	public virtual string getTypeNameForSetter()
	{
		if (this.m_isNodeList)
		{
			string result = new StringBuilder().append("NodeList<").append(getTypeNameGenerified()).append(">")
				.ToString();
			
			return result;
		}
		string typeNameGenerified = getTypeNameGenerified();
		
		return typeNameGenerified;
	}

	public virtual string getName()
	{
		return name;
	}

	
	
	public virtual string getSetterMethodName()
	{
		string result = CodeGenerationUtils.setterName(name);
		
		return result;
	}

	public virtual BaseNodeMetaModel getContainingNodeMetaModel()
	{
		return containingNodeMetaModel;
	}

	public virtual bool isRequired()
	{
		return (!this.m_isOptional) ? true : false;
	}

		public virtual Class getType()
	{
		return type;
	}

	public virtual bool isNonEmpty()
	{
		return this.m_isNonEmpty;
	}

	public virtual bool isSingular()
	{
		return (!this.m_isNodeList) ? true : false;
	}

	
	
	public virtual bool isNode()
	{
		bool result = getNodeReference().isPresent();
		
		return result;
	}

	
	
	public virtual string getTypeNameForGetter()
	{
		if (this.m_isOptional)
		{
			string result = new StringBuilder().append("Optional<").append(getTypeNameForSetter()).append(">")
				.ToString();
			
			return result;
		}
		string typeNameForSetter = getTypeNameForSetter();
		
		return typeNameForSetter;
	}

	
	
	public virtual string getGetterMethodName()
	{
		string result = CodeGenerationUtils.getterName(type, name);
		
		return result;
	}

	public virtual bool isOptional()
	{
		return this.m_isOptional;
	}

	public virtual bool isNodeList()
	{
		return this.m_isNodeList;
	}

	
	
	public virtual string getTypeName()
	{
		string simpleName = type.getSimpleName();
		
		return simpleName;
	}

		public virtual Optional getNodeReference()
	{
		return nodeReference;
	}

	
	
	public virtual string getTypeNameGenerified()
	{
		if (this.m_hasWildcard)
		{
			string result = new StringBuilder().append(getTypeName()).append("<?>").ToString();
			
			return result;
		}
		string typeName = getTypeName();
		
		return typeName;
	}

	
	
	
	public override bool Equals(object o)
	{
		if (this == o)
		{
			return true;
		}
		if (o == null || ((object)this).GetType() != o.GetType())
		{
			return false;
		}
		PropertyMetaModel propertyMetaModel = (PropertyMetaModel)o;
		if (!String.instancehelper_equals(name, propertyMetaModel.name))
		{
			return false;
		}
		if (!Object.instancehelper_equals(type, propertyMetaModel.type))
		{
			return false;
		}
		return true;
	}

	
	
	[LineNumberTable(new byte[]
	{
		160, 129, 109, 108, 115, 116, 104, 241, 61, 8,
		236, 73, 127, 3, 98
	})]
	public virtual object getValue(Node node)
	{
		IllegalAccessException ex;
		try
		{
			for (Class @class = Object.instancehelper_getClass(node); @class != null; @class = @class.getSuperclass())
			{
				Field[] declaredFields = @class.getDeclaredFields(PropertyMetaModel.___003CGetCallerID_003E());
				Field[] array = declaredFields;
				int num = array.Length;
				for (int i = 0; i < num; i++)
				{
					Field field = array[i];
					if (String.instancehelper_equals(field.getName(), getName()))
					{
						field.setAccessible(flag: true);
						return field.get(node, PropertyMetaModel.___003CGetCallerID_003E());
					}
				}
			}
			string s = getName();
			
			throw new NoSuchFieldError(s);
		}
		catch (IllegalAccessException x)
		{
			ex = ByteCodeHelper.MapException<IllegalAccessException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		IllegalAccessException cause = ex;
		
		throw new RuntimeException(cause);
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		159, 131, 108, 105, 103, 103, 103, 104, 103, 103,
		103, 103
	})]
	public PropertyMetaModel(BaseNodeMetaModel containingNodeMetaModel, string name, Class type, Optional nodeReference, bool isOptional, bool isNonEmpty, bool isNodeList, bool hasWildcard)
	{
		this.containingNodeMetaModel = containingNodeMetaModel;
		this.name = name;
		this.type = type;
		this.nodeReference = nodeReference;
		this.m_isOptional = isOptional;
		this.m_isNonEmpty = isNonEmpty;
		this.m_isNodeList = isNodeList;
		this.m_hasWildcard = hasWildcard;
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual bool @is(Class c, string fieldName)
	{
		return (containingNodeMetaModel.@is(c) && String.instancehelper_equals(name, fieldName)) ? true : false;
	}

	
	
	
	public virtual bool @is(string fieldName)
	{
		bool result = String.instancehelper_equals(name, fieldName);
		
		return result;
	}

	public virtual bool hasWildcard()
	{
		return this.m_hasWildcard;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("(").append(getTypeName()).append(")\t")
			.append(containingNodeMetaModel)
			.append("#")
			.append(name)
			.ToString();
		
		return result;
	}

	
	
	public override int GetHashCode()
	{
		int num = String.instancehelper_hashCode(name);
		return 31 * num + Object.instancehelper_hashCode(type);
	}

	
	
	public virtual string getMetaModelFieldName()
	{
		string result = new StringBuilder().append(getName()).append("PropertyMetaModel").ToString();
		
		return result;
	}

	
	
	public virtual bool isAttribute()
	{
		return (!isNode()) ? true : false;
	}

	static CallerID ___003CGetCallerID_003E()
	{
		if (___003CcallerID_003E == null)
		{
			___003CcallerID_003E = new ___003CCallerID_003E();
		}
		return ___003CcallerID_003E;
	}
}
