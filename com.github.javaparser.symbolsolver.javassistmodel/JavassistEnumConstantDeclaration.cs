
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.model.typesystem;

using java.lang;
using javassist;

namespace com.github.javaparser.symbolsolver.javassistmodel;


public class JavassistEnumConstantDeclaration: ResolvedEnumConstantDeclaration, ResolvedValueDeclaration, ResolvedDeclaration
{
	private CtField ctField;

	private TypeSolver typeSolver;

	private ResolvedType type;

	
	
	public JavassistEnumConstantDeclaration(CtField ctField, TypeSolver typeSolver)
	{
		if (ctField == null)
		{
			
			throw new IllegalArgumentException();
		}
		if ((ctField.getFieldInfo2().getAccessFlags() & 0x4000) == 0)
		{
			string s = new StringBuilder().append("Trying to instantiate a JavassistEnumConstantDeclaration with something which is not an enum field: ").append(ctField.ToString()).ToString();
			
			throw new IllegalArgumentException(s);
		}
		this.ctField = ctField;
		this.typeSolver = typeSolver;
	}

	
	
	public virtual string getName()
	{
		string name = ctField.getName();
		
		return name;
	}

	
	
	public virtual ResolvedType getType()
	{
		if (type == null)
		{
			ReferenceTypeImpl.___003Cclinit_003E();
			type = new ReferenceTypeImpl(new JavassistEnumDeclaration(ctField.getDeclaringClass(), typeSolver), typeSolver);
		}
		return type;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append(Object.instancehelper_getClass(this).getSimpleName()).append("{ctField=").append(ctField.getName())
			.append(", typeSolver=")
			.append(typeSolver)
			.append('}')
			.ToString();
		
		return result;
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
		return ResolvedEnumConstantDeclaration._003Cdefault_003EisEnumConstant(this);
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
		return ResolvedDeclaration._003Cdefault_003EisType(this);
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
		return ResolvedDeclaration._003Cdefault_003EasType(this);
	}


	public virtual ResolvedMethodDeclaration asMethod()
	{
		return ResolvedDeclaration._003Cdefault_003EasMethod(this);
	}


	public virtual ResolvedEnumConstantDeclaration asEnumConstant()
	{
		return ResolvedEnumConstantDeclaration._003Cdefault_003EasEnumConstant(this);
	}


	public virtual ResolvedPatternDeclaration asPattern()
	{
		return ResolvedDeclaration._003Cdefault_003EasPattern(this);
	}
}
