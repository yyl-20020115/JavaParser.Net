
using com.github.javaparser.ast;
using com.github.javaparser.utils;

using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.lang.reflect;
using java.util;

namespace com.github.javaparser.metamodel;

public abstract class BaseNodeMetaModel
{
	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	
		private Optional superNodeMetaModel;

	
		private List declaredPropertyMetaModels;

	
		private List derivedPropertyMetaModels;

	
		private List constructorParameters;

	
		private Class type;

	
	private string name;

	
	private string packageName;

	
	private bool m_isAbstract;

	
	private bool m_hasWildcard;

	
	private static CallerID ___003CcallerID_003E;

	public virtual string getPackageName()
	{
		return packageName;
	}

	
	
	public virtual string getTypeName()
	{
		string simpleName = type.getSimpleName();
		
		return simpleName;
	}

		public virtual Class getType()
	{
		return type;
	}

	public virtual bool isAbstract()
	{
		return this.m_isAbstract;
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

	
	
	public virtual bool isRootNode()
	{
		return (!superNodeMetaModel.isPresent()) ? true : false;
	}

	
	
	public virtual string getMetaModelFieldName()
	{
		string result = Utils.decapitalize(Object.instancehelper_getClass(this).getSimpleName());
		
		return result;
	}

	
		
	
	public virtual bool @is(Class c)
	{
		bool result = Object.instancehelper_equals(type, c);
		
		return result;
	}

		public virtual List getConstructorParameters()
	{
		return constructorParameters;
	}

		public virtual List getDeclaredPropertyMetaModels()
	{
		return declaredPropertyMetaModels;
	}

		public virtual List getDerivedPropertyMetaModels()
	{
		return derivedPropertyMetaModels;
	}

	public virtual bool hasWildcard()
	{
		return this.m_hasWildcard;
	}

		public virtual Optional getSuperNodeMetaModel()
	{
		return superNodeMetaModel;
	}

	
	
	
	public virtual bool isInstanceOfMetaModel(BaseNodeMetaModel baseMetaModel)
	{
		if (this == baseMetaModel)
		{
			return true;
		}
		if (isRootNode())
		{
			return false;
		}
		bool result = ((BaseNodeMetaModel)getSuperNodeMetaModel().get()).isInstanceOfMetaModel(baseMetaModel);
		
		return result;
	}

	
		
	public virtual List getAllPropertyMetaModels()
	{
		
		ArrayList arrayList = new ArrayList(getDeclaredPropertyMetaModels());
		BaseNodeMetaModel baseNodeMetaModel = this;
		while (baseNodeMetaModel.getSuperNodeMetaModel().isPresent())
		{
			baseNodeMetaModel = (BaseNodeMetaModel)baseNodeMetaModel.getSuperNodeMetaModel().get();
			((List)arrayList).addAll((Collection)baseNodeMetaModel.getDeclaredPropertyMetaModels());
		}
		return arrayList;
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
		BaseNodeMetaModel baseNodeMetaModel = (BaseNodeMetaModel)o;
		if (!Object.instancehelper_equals(type, baseNodeMetaModel.type))
		{
			return false;
		}
		return true;
	}

	
		
	
	public BaseNodeMetaModel(Optional superNodeMetaModel, Class type, string name, string packageName, bool isAbstract, bool hasWildcard)
	{
		declaredPropertyMetaModels = new ArrayList();
		derivedPropertyMetaModels = new ArrayList();
		constructorParameters = new ArrayList();
		this.superNodeMetaModel = superNodeMetaModel;
		this.type = type;
		this.name = name;
		this.packageName = packageName;
		this.m_isAbstract = isAbstract;
		this.m_hasWildcard = hasWildcard;
	}

	
	
	public virtual string getQualifiedClassName()
	{
		string result = new StringBuilder().append(packageName).append(".").append(name)
			.ToString();
		
		return result;
	}

	
	
	public override int GetHashCode()
	{
		int result = Object.instancehelper_hashCode(type);
		
		return result;
	}

	public override string ToString()
	{
		return name;
	}

	
		
	
	public virtual Node construct(Map parameters)
	{
		//Discarded unreachable code: IL_00b6
		Constructor[] constructors = getType().getConstructors(BaseNodeMetaModel.___003CGetCallerID_003E());
		int num = constructors.Length;
		int num2 = 0;
		while (num2 < num)
		{
			Constructor constructor = constructors[num2];
			IllegalAccessException ex2;
			InvocationTargetException ex3;
			object ex4;
			if (constructor.getAnnotation(ClassLiteral<AllFieldsConstructor>.Value) != null)
			{
				InstantiationException ex;
				try
				{
					try
					{
						try
						{
							object[] array = new object[constructor.getParameterCount()];
							int num3 = 0;
							Iterator iterator = getConstructorParameters().iterator();
							while (iterator.hasNext())
							{
								PropertyMetaModel propertyMetaModel = (PropertyMetaModel)iterator.next();
								array[num3] = parameters.get(propertyMetaModel.getName());
								if (array[num3] == null && propertyMetaModel.isRequired() && propertyMetaModel.isNodeList())
								{
									array[num3] = new NodeList();
								}
								num3++;
							}
							return (Node)constructor.newInstance(array, BaseNodeMetaModel.___003CGetCallerID_003E());
						}
						catch (InstantiationException x)
						{
							ex = ByteCodeHelper.MapException<InstantiationException>(x, ByteCodeHelper.MapFlags.NoRemapping);
						}
					}
					catch (IllegalAccessException x2)
					{
						ex2 = ByteCodeHelper.MapException<IllegalAccessException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
						goto IL_00e2;
					}
				}
				catch (InvocationTargetException x3)
				{
					ex3 = ByteCodeHelper.MapException<InvocationTargetException>(x3, ByteCodeHelper.MapFlags.NoRemapping);
					goto IL_00e6;
				}
				ex4 = ex;
				goto IL_00eb;
			}
			num2++;
			continue;
			IL_00e6:
			ex4 = ex3;
			goto IL_00eb;
			IL_00e2:
			ex4 = ex2;
			goto IL_00eb;
			IL_00eb:
			ReflectiveOperationException cause = (ReflectiveOperationException)ex4;
			
			throw new RuntimeException(cause);
		}
		
		throw new IllegalStateException();
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
