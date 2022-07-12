
using com.github.javaparser.resolution.declarations;

using java.lang;
using java.util;

namespace com.github.javaparser.resolution.types;

public class ResolvedTypeVariable : ResolvedType
{
    private ResolvedTypeParameterDeclaration typeParameter;


    
    public virtual string qualifiedName()
    {
        string result = typeParameter.getQualifiedName();

        return result;
    }


    
    
    public ResolvedTypeVariable(ResolvedTypeParameterDeclaration typeParameter)
    {
        this.typeParameter = typeParameter;
    }


    
    public virtual string describe()
    {
        string name = typeParameter.getName();

        return name;
    }

    public virtual ResolvedTypeParameterDeclaration asTypeParameter()
    {
        return typeParameter;
    }

    public virtual ResolvedTypeVariable asTypeVariable()
    {
        return this;
    }


    
    public override string ToString()
    {
        string result = new StringBuilder().append("TypeVariable {").append(Object.instancehelper_toString(typeParameter)).append("}")
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
        ResolvedTypeVariable resolvedTypeVariable = (ResolvedTypeVariable)o;
        if (!String.instancehelper_equals(typeParameter.getName(), resolvedTypeVariable.typeParameter.getName()))
        {
            return false;
        }
        if (typeParameter.declaredOnType() != resolvedTypeVariable.typeParameter.declaredOnType())
        {
            return false;
        }
        if (typeParameter.declaredOnMethod() != resolvedTypeVariable.typeParameter.declaredOnMethod())
        {
            return false;
        }
        return true;
    }

    
    public override int GetHashCode()
    {
        int result = Object.instancehelper_hashCode(typeParameter);

        return result;
    }


    public virtual bool isArray()
    {
        return false;
    }

    public virtual bool isPrimitive()
    {
        return false;
    }


    
    
    public virtual ResolvedType replaceTypeVariables(ResolvedTypeParameterDeclaration tpToBeReplaced, ResolvedType replaced, Map inferredTypes)
    {
        if (String.instancehelper_equals(tpToBeReplaced.getName(), typeParameter.getName()))
        {
            inferredTypes.put(asTypeParameter(), replaced);
            return replaced;
        }
        return this;
    }

    public virtual bool isReferenceType()
    {
        return false;
    }

    public virtual bool isTypeVariable()
    {
        return true;
    }


    
    
    public virtual bool isAssignableBy(ResolvedType other)
    {
        if (other.isTypeVariable())
        {
            bool result = String.instancehelper_equals(describe(), other.describe());

            return result;
        }
        return true;
    }


    
    
    public virtual bool mention(List typeParameters)
    {
        bool result = typeParameters.contains(typeParameter);

        return result;
    }


    
    public virtual ResolvedType erasure()
    {
        if (typeParameter.isBounded())
        {
            ResolvedType type = ((ResolvedTypeParameterDeclaration.Bound)typeParameter.getBounds().get(0)).getType();

            return type;
        }
        ResolvedReferenceType result = typeParameter.@object();

        return result;
    }

    [HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
    public virtual int arrayLevel()
    {
        return ResolvedType._003Cdefault_003EarrayLevel(this);
    }

    [HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
    public virtual bool isNull()
    {
        return ResolvedType._003Cdefault_003EisNull(this);
    }

    [HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
    public virtual bool isUnionType()
    {
        return ResolvedType._003Cdefault_003EisUnionType(this);
    }

    [HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
    public virtual bool isReference()
    {
        return ResolvedType._003Cdefault_003EisReference(this);
    }

    [HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
    public virtual bool isConstraint()
    {
        return ResolvedType._003Cdefault_003EisConstraint(this);
    }

    [HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
    public virtual bool isVoid()
    {
        return ResolvedType._003Cdefault_003EisVoid(this);
    }

    [HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
    public virtual bool isWildcard()
    {
        return ResolvedType._003Cdefault_003EisWildcard(this);
    }

    [HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
    public virtual bool isInferenceVariable()
    {
        return ResolvedType._003Cdefault_003EisInferenceVariable(this);
    }

    [HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
    public virtual ResolvedArrayType asArrayType()
    {
        return ResolvedType._003Cdefault_003EasArrayType(this);
    }

    [HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
    public virtual ResolvedReferenceType asReferenceType()
    {
        return ResolvedType._003Cdefault_003EasReferenceType(this);
    }

    [HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
    public virtual ResolvedPrimitiveType asPrimitive()
    {
        return ResolvedType._003Cdefault_003EasPrimitive(this);
    }

    [HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
    public virtual ResolvedWildcard asWildcard()
    {
        return ResolvedType._003Cdefault_003EasWildcard(this);
    }

    [HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
    public virtual ResolvedLambdaConstraintType asConstraintType()
    {
        return ResolvedType._003Cdefault_003EasConstraintType(this);
    }

    [HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
    public virtual ResolvedUnionType asUnionType()
    {
        return ResolvedType._003Cdefault_003EasUnionType(this);
    }

    [HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
    public virtual ResolvedType replaceTypeVariables(ResolvedTypeParameterDeclaration P_0, ResolvedType P_1)
    {
        return ResolvedType._003Cdefault_003EreplaceTypeVariables(this, P_0, P_1);
    }

    [HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
    public virtual bool isNumericType()
    {
        return ResolvedType._003Cdefault_003EisNumericType(this);
    }
}
