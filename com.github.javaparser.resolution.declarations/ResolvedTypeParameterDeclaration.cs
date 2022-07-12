
using com.github.javaparser.resolution.types;

using java.lang;
using java.util;

namespace com.github.javaparser.resolution.declarations;


public interface ResolvedTypeParameterDeclaration : ResolvedTypeDeclaration, ResolvedDeclaration
{
	
	[EnclosingMethod(null, "onType", "(Ljava.lang.String;Ljava.lang.String;Ljava.util.List;)Lcom.github.javaparser.resolution.declarations.ResolvedTypeParameterDeclaration;")]
	
	internal class _1: ResolvedTypeParameterDeclaration, ResolvedTypeDeclaration, ResolvedDeclaration
	{
		
		internal string val_0024name;

		
		internal string val_0024classQName;

		
		internal List val_0024bounds;

		
		
		
		internal _1(string val_0024bounds, string val_0024classQName, List val_0024name)
		{
			this.val_0024name = val_0024bounds;
			this.val_0024classQName = val_0024classQName;
			this.val_0024bounds = val_0024name;
			
		}

		public virtual string getName()
		{
			return val_0024name;
		}

		public virtual bool declaredOnType()
		{
			return true;
		}

		public virtual bool declaredOnMethod()
		{
			return false;
		}

		public virtual bool declaredOnConstructor()
		{
			return false;
		}

		public virtual string getContainerQualifiedName()
		{
			return val_0024classQName;
		}

		public virtual string getContainerId()
		{
			return val_0024classQName;
		}

		public virtual ResolvedTypeParametrizable getContainer()
		{
			return null;
		}

				public virtual List getBounds()
		{
			return val_0024bounds;
		}

		
		
		public override string ToString()
		{
			string result = new StringBuilder().append("TypeParameter onType ").append(val_0024name).ToString();
			
			return result;
		}

		
				
		public virtual Optional containerType()
		{
			
			throw new UnsupportedOperationException();
		}

		
		
		public virtual ResolvedReferenceType @object()
		{
			
			throw new UnsupportedOperationException();
		}

	
		public virtual bool hasName()
		{
			return ResolvedDeclaration._003Cdefault_003EhasName(this);
		}

	
		public virtual bool isField()
		{
			return ResolvedDeclaration._003Cdefault_003EisField(this);
		}

	
		public virtual bool isVariable()
		{
			return ResolvedDeclaration._003Cdefault_003EisVariable(this);
		}

	
		public virtual bool isEnumConstant()
		{
			return ResolvedDeclaration._003Cdefault_003EisEnumConstant(this);
		}

	
		public virtual bool isPattern()
		{
			return ResolvedDeclaration._003Cdefault_003EisPattern(this);
		}

	
		public virtual bool isParameter()
		{
			return ResolvedDeclaration._003Cdefault_003EisParameter(this);
		}

	
		public virtual bool isType()
		{
			return ResolvedTypeDeclaration._003Cdefault_003EisType(this);
		}

	
		public virtual bool isMethod()
		{
			return ResolvedDeclaration._003Cdefault_003EisMethod(this);
		}

	
		public virtual ResolvedFieldDeclaration asField()
		{
			return ResolvedDeclaration._003Cdefault_003EasField(this);
		}

	
		public virtual ResolvedParameterDeclaration asParameter()
		{
			return ResolvedDeclaration._003Cdefault_003EasParameter(this);
		}

	
		public virtual ResolvedTypeDeclaration asType()
		{
			return ResolvedTypeDeclaration._003Cdefault_003EasType(this);
		}

	
		public virtual ResolvedMethodDeclaration asMethod()
		{
			return ResolvedDeclaration._003Cdefault_003EasMethod(this);
		}

	
		public virtual ResolvedEnumConstantDeclaration asEnumConstant()
		{
			return ResolvedDeclaration._003Cdefault_003EasEnumConstant(this);
		}

	
		public virtual ResolvedPatternDeclaration asPattern()
		{
			return ResolvedDeclaration._003Cdefault_003EasPattern(this);
		}

	
		public virtual Set internalTypes()
		{
			return ResolvedTypeDeclaration._003Cdefault_003EinternalTypes(this);
		}

	
		public virtual ResolvedReferenceTypeDeclaration getInternalType(string P_0)
		{
			return ResolvedTypeDeclaration._003Cdefault_003EgetInternalType(this, P_0);
		}

	
		public virtual bool hasInternalType(string P_0)
		{
			return ResolvedTypeDeclaration._003Cdefault_003EhasInternalType(this, P_0);
		}

	
		public virtual bool isClass()
		{
			return ResolvedTypeDeclaration._003Cdefault_003EisClass(this);
		}

	
		public virtual bool isInterface()
		{
			return ResolvedTypeDeclaration._003Cdefault_003EisInterface(this);
		}

	
		public virtual bool isEnum()
		{
			return ResolvedTypeDeclaration._003Cdefault_003EisEnum(this);
		}

	
		public virtual bool isAnnotation()
		{
			return ResolvedTypeDeclaration._003Cdefault_003EisAnnotation(this);
		}

	
		public virtual bool isTypeParameter()
		{
			return ResolvedTypeDeclaration._003Cdefault_003EisTypeParameter(this);
		}

	
		public virtual bool isAnonymousClass()
		{
			return ResolvedTypeDeclaration._003Cdefault_003EisAnonymousClass(this);
		}

	
		public virtual ResolvedClassDeclaration asClass()
		{
			return ResolvedTypeDeclaration._003Cdefault_003EasClass(this);
		}

	
		public virtual ResolvedInterfaceDeclaration asInterface()
		{
			return ResolvedTypeDeclaration._003Cdefault_003EasInterface(this);
		}

	
		public virtual ResolvedEnumDeclaration asEnum()
		{
			return ResolvedTypeDeclaration._003Cdefault_003EasEnum(this);
		}

	
		public virtual ResolvedAnnotationDeclaration asAnnotation()
		{
			return ResolvedTypeDeclaration._003Cdefault_003EasAnnotation(this);
		}

	
		public virtual ResolvedTypeParameterDeclaration asTypeParameter()
		{
			return ResolvedTypeDeclaration._003Cdefault_003EasTypeParameter(this);
		}

	
		public virtual ResolvedReferenceTypeDeclaration asReferenceType()
		{
			return ResolvedTypeDeclaration._003Cdefault_003EasReferenceType(this);
		}

	
		public virtual string getPackageName()
		{
			return _003Cdefault_003EgetPackageName(this);
		}

	
		public virtual string getClassName()
		{
			return _003Cdefault_003EgetClassName(this);
		}

	
		public virtual string getQualifiedName()
		{
			return _003Cdefault_003EgetQualifiedName(this);
		}

	
		public virtual string getId()
		{
			return ResolvedTypeDeclaration._003Cdefault_003EgetId(this);
		}

	
		public virtual bool hasLowerBound()
		{
			return _003Cdefault_003EhasLowerBound(this);
		}

	
		public virtual bool hasUpperBound()
		{
			return _003Cdefault_003EhasUpperBound(this);
		}

	
		public virtual ResolvedType getLowerBound()
		{
			return _003Cdefault_003EgetLowerBound(this);
		}

	
		public virtual ResolvedType getUpperBound()
		{
			return _003Cdefault_003EgetUpperBound(this);
		}

	
		public virtual bool isBounded()
		{
			return _003Cdefault_003EisBounded(this);
		}

	
		public virtual bool isUnbounded()
		{
			return _003Cdefault_003EisUnbounded(this);
		}
	}

	public class Bound
	{
		private bool m_extendsBound;

		private ResolvedType type;

		public virtual bool isExtends()
		{
			return this.m_extendsBound;
		}

		
		
		public virtual bool isSuper()
		{
			return (!isExtends()) ? true : false;
		}

		public virtual ResolvedType getType()
		{
			return type;
		}

		
		
		
		private Bound(bool extendsBound, ResolvedType type)
		{
			this.m_extendsBound = extendsBound;
			this.type = type;
		}

		
		
		
		public static Bound extendsBound(ResolvedType type)
		{
			Bound result = new Bound(extendsBound: true, type);
			
			return result;
		}

		
		
		
		public static Bound superBound(ResolvedType type)
		{
			Bound result = new Bound(extendsBound: false, type);
			
			return result;
		}

		
		
		public override string ToString()
		{
			string result = new StringBuilder().append("Bound{extendsBound=").append(this.m_extendsBound).append(", type=")
				.append(type)
				.append('}')
				.ToString();
			
			return result;
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
			Bound bound = (Bound)o;
			if (this.m_extendsBound != bound.m_extendsBound)
			{
				return false;
			}
			return (type != null) ? Object.instancehelper_equals(type, bound.type) : (bound.type == null);
		}

		
		
		public override int GetHashCode()
		{
			int num = (this.m_extendsBound ? 1 : 0);
			return 31 * num + ((type != null) ? Object.instancehelper_hashCode(type) : 0);
		}
	}

	
	public new static class __DefaultMethods
	{
		public unsafe static bool declaredOnType(ResolvedTypeParameterDeclaration P_0)
		{
			
			return _003Cdefault_003EdeclaredOnType(P_0);
		}

		public unsafe static bool declaredOnMethod(ResolvedTypeParameterDeclaration P_0)
		{
			
			return _003Cdefault_003EdeclaredOnMethod(P_0);
		}

		public unsafe static bool declaredOnConstructor(ResolvedTypeParameterDeclaration P_0)
		{
			
			return _003Cdefault_003EdeclaredOnConstructor(P_0);
		}

		public unsafe static string getPackageName(ResolvedTypeParameterDeclaration P_0)
		{
			
			return _003Cdefault_003EgetPackageName(P_0);
		}

		public unsafe static string getClassName(ResolvedTypeParameterDeclaration P_0)
		{
			
			return _003Cdefault_003EgetClassName(P_0);
		}

		public unsafe static string getQualifiedName(ResolvedTypeParameterDeclaration P_0)
		{
			
			return _003Cdefault_003EgetQualifiedName(P_0);
		}

		public unsafe static bool hasLowerBound(ResolvedTypeParameterDeclaration P_0)
		{
			
			return _003Cdefault_003EhasLowerBound(P_0);
		}

		public unsafe static bool hasUpperBound(ResolvedTypeParameterDeclaration P_0)
		{
			
			return _003Cdefault_003EhasUpperBound(P_0);
		}

		public unsafe static ResolvedType getLowerBound(ResolvedTypeParameterDeclaration P_0)
		{
			
			return _003Cdefault_003EgetLowerBound(P_0);
		}

		public unsafe static ResolvedType getUpperBound(ResolvedTypeParameterDeclaration P_0)
		{
			
			return _003Cdefault_003EgetUpperBound(P_0);
		}

		public unsafe static bool isBounded(ResolvedTypeParameterDeclaration P_0)
		{
			
			return _003Cdefault_003EisBounded(P_0);
		}

		public unsafe static bool isUnbounded(ResolvedTypeParameterDeclaration P_0)
		{
			
			return _003Cdefault_003EisUnbounded(P_0);
		}
	}

	
	public static class __Methods
	{
		public static ResolvedTypeParameterDeclaration onType(string P_0, string P_1, List P_2)
		{
			return ResolvedTypeParameterDeclaration.onType(P_0, P_1, P_2);
		}
	}

	string getName();

	virtual ResolvedTypeParametrizable getContainer();

	virtual string getContainerId();

		virtual List getBounds();

	
	virtual bool isUnbounded();

	
	
	
	static bool _003Cdefault_003EisUnbounded(ResolvedTypeParameterDeclaration P_0)
	{
		bool result = P_0.getBounds().isEmpty();
		
		return result;
	}

	
		
	
	static ResolvedTypeParameterDeclaration onType(string name, string classQName, List bounds)
	{
		_1 result = new _1(name, classQName, bounds);
		
		return result;
	}

	
	virtual bool declaredOnType();

	
	
	
	static bool _003Cdefault_003EdeclaredOnType(ResolvedTypeParameterDeclaration P_0)
	{
		return P_0.getContainer() is ResolvedReferenceTypeDeclaration;
	}

	
	virtual bool declaredOnMethod();

	
	
	
	static bool _003Cdefault_003EdeclaredOnMethod(ResolvedTypeParameterDeclaration P_0)
	{
		return P_0.getContainer() is ResolvedMethodDeclaration;
	}

	
	virtual bool declaredOnConstructor();

	
	
	
	static bool _003Cdefault_003EdeclaredOnConstructor(ResolvedTypeParameterDeclaration P_0)
	{
		return P_0.getContainer() is ResolvedConstructorDeclaration;
	}

	
	string getPackageName();

	
	
	
	static string _003Cdefault_003EgetPackageName(ResolvedTypeParameterDeclaration P_0)
	{
		
		throw new UnsupportedOperationException();
	}

	
	string getClassName();

	
	
	
	static string _003Cdefault_003EgetClassName(ResolvedTypeParameterDeclaration P_0)
	{
		
		throw new UnsupportedOperationException();
	}

	
	string getQualifiedName();

	
	
	
	static string _003Cdefault_003EgetQualifiedName(ResolvedTypeParameterDeclaration P_0)
	{
		string result = String.format("%s.%s", P_0.getContainerId(), P_0.getName());
		
		return result;
	}

	virtual string getContainerQualifiedName();

	
	virtual bool hasLowerBound();

	
	
	
	static bool _003Cdefault_003EhasLowerBound(ResolvedTypeParameterDeclaration P_0)
	{
		Iterator iterator = P_0.getBounds().iterator();
		while (iterator.hasNext())
		{
			Bound bound = (Bound)iterator.next();
			if (bound.isExtends())
			{
				return true;
			}
		}
		return false;
	}

	
	virtual bool hasUpperBound();

	
	
	
	static bool _003Cdefault_003EhasUpperBound(ResolvedTypeParameterDeclaration P_0)
	{
		Iterator iterator = P_0.getBounds().iterator();
		while (iterator.hasNext())
		{
			Bound bound = (Bound)iterator.next();
			if (bound.isSuper())
			{
				return true;
			}
		}
		return false;
	}

	
	virtual ResolvedType getLowerBound();

	
	
	
	static ResolvedType _003Cdefault_003EgetLowerBound(ResolvedTypeParameterDeclaration P_0)
	{
		Iterator iterator = P_0.getBounds().iterator();
		while (iterator.hasNext())
		{
			Bound bound = (Bound)iterator.next();
			if (bound.isExtends())
			{
				ResolvedType type = bound.getType();
				
				return type;
			}
		}
		
		throw new IllegalStateException();
	}

	
	virtual ResolvedType getUpperBound();

	
	
	
	static ResolvedType _003Cdefault_003EgetUpperBound(ResolvedTypeParameterDeclaration P_0)
	{
		Iterator iterator = P_0.getBounds().iterator();
		while (iterator.hasNext())
		{
			Bound bound = (Bound)iterator.next();
			if (bound.isSuper())
			{
				ResolvedType type = bound.getType();
				
				return type;
			}
		}
		
		throw new IllegalStateException();
	}

	
	virtual bool isBounded();

	
	
	
	static bool _003Cdefault_003EisBounded(ResolvedTypeParameterDeclaration P_0)
	{
		return (!P_0.isUnbounded()) ? true : false;
	}

	virtual ResolvedReferenceType @object();
}
