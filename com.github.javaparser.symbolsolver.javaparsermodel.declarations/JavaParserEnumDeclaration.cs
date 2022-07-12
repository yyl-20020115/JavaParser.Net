using System;

using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.type;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.resolution.types.parametrization;
using com.github.javaparser.symbolsolver.core.resolution;
using com.github.javaparser.symbolsolver.logic;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.model.typesystem;
using com.github.javaparser.symbolsolver.reflectionmodel;

using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.symbolsolver.javaparsermodel.declarations;


public class JavaParserEnumDeclaration : AbstractTypeDeclaration, ResolvedEnumDeclaration, ResolvedReferenceTypeDeclaration, ResolvedTypeDeclaration, ResolvedDeclaration, ResolvedTypeParametrizable, HasAccessSpecifier, MethodResolutionCapability, MethodUsageResolutionCapability, AssociableToAST
{
	
	public class ValueOfMethod :  ResolvedMethodDeclaration, ResolvedMethodLikeDeclaration, ResolvedDeclaration, ResolvedTypeParametrizable, HasAccessSpecifier, AssociableToAST, TypeVariableResolutionCapability
	{
		
		[EnclosingMethod(null, "getParam", "(I)Lcom.github.javaparser.resolution.declarations.ResolvedParameterDeclaration;")]
		
		internal class _1 :  ResolvedParameterDeclaration, ResolvedValueDeclaration, ResolvedDeclaration
		{
			
			internal ValueOfMethod this_00240;

			
			
			internal _1(ValueOfMethod P_0)
			{
				this_00240 = P_0;
				
			}

			public virtual string getName()
			{
				return "name";
			}

			
			
			public virtual ResolvedType getType()
			{
				ReferenceTypeImpl.___003Cclinit_003E();
				ReferenceTypeImpl result = new ReferenceTypeImpl(access_0024000(this_00240).solveType("java.lang.String"), access_0024000(this_00240));
				
				return result;
			}

			public virtual bool isVariadic()
			{
				return false;
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual bool hasName()
			{
				return ResolvedParameterDeclaration._003Cdefault_003EhasName(this);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual bool isField()
			{
				return ResolvedDeclaration._003Cdefault_003EisField(this);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual bool isVariable()
			{
				return ResolvedDeclaration._003Cdefault_003EisVariable(this);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual bool isEnumConstant()
			{
				return ResolvedDeclaration._003Cdefault_003EisEnumConstant(this);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual bool isPattern()
			{
				return ResolvedDeclaration._003Cdefault_003EisPattern(this);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual bool isParameter()
			{
				return ResolvedParameterDeclaration._003Cdefault_003EisParameter(this);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual bool isType()
			{
				return ResolvedDeclaration._003Cdefault_003EisType(this);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual bool isMethod()
			{
				return ResolvedDeclaration._003Cdefault_003EisMethod(this);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual ResolvedFieldDeclaration asField()
			{
				return ResolvedDeclaration._003Cdefault_003EasField(this);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual ResolvedParameterDeclaration asParameter()
			{
				return ResolvedParameterDeclaration._003Cdefault_003EasParameter(this);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual ResolvedTypeDeclaration asType()
			{
				return ResolvedDeclaration._003Cdefault_003EasType(this);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual ResolvedMethodDeclaration asMethod()
			{
				return ResolvedDeclaration._003Cdefault_003EasMethod(this);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual ResolvedEnumConstantDeclaration asEnumConstant()
			{
				return ResolvedDeclaration._003Cdefault_003EasEnumConstant(this);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual ResolvedPatternDeclaration asPattern()
			{
				return ResolvedDeclaration._003Cdefault_003EasPattern(this);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual string describeType()
			{
				return ResolvedParameterDeclaration._003Cdefault_003EdescribeType(this);
			}
		}

		private JavaParserEnumDeclaration enumDeclaration;

		private TypeSolver typeSolver;

		
		
		internal static TypeSolver access_0024000(ValueOfMethod P_0)
		{
			return P_0.typeSolver;
		}

		
		
		public ValueOfMethod(JavaParserEnumDeclaration enumDeclaration, TypeSolver typeSolver)
		{
			this.enumDeclaration = enumDeclaration;
			this.typeSolver = typeSolver;
		}

		public virtual ResolvedReferenceTypeDeclaration declaringType()
		{
			return enumDeclaration;
		}

		
		
		public virtual ResolvedType getReturnType()
		{
			ReferenceTypeImpl.___003Cclinit_003E();
			ReferenceTypeImpl result = new ReferenceTypeImpl(enumDeclaration, typeSolver);
			
			return result;
		}

		public virtual int getNumberOfParams()
		{
			return 1;
		}

		
		
		public virtual ResolvedParameterDeclaration getParam(int i)
		{
			if (i == 0)
			{
				_1 result = new _1(this);
				
				return result;
			}
			
			throw new IllegalArgumentException("Invalid parameter index!");
		}

		
		
		public virtual MethodUsage getUsage(Node node)
		{
			
			throw new UnsupportedOperationException();
		}

		
				
		public virtual MethodUsage resolveTypeVariables(Context context, List parameterTypes)
		{
			MethodUsage result = new MethodUsage(this);
			
			return result;
		}

		public virtual bool isAbstract()
		{
			return false;
		}

		public virtual bool isDefaultMethod()
		{
			return false;
		}

		public virtual bool isStatic()
		{
			return true;
		}

		public virtual string getName()
		{
			return "valueOf";
		}

		
				
		public virtual List getTypeParameters()
		{
			List result = Collections.emptyList();
			
			return result;
		}

		
		
		public virtual AccessSpecifier accessSpecifier()
		{
			return AccessSpecifier.___003C_003EPUBLIC;
		}

		public virtual int getNumberOfSpecifiedExceptions()
		{
			return 0;
		}

		
		
		public virtual ResolvedType getSpecifiedException(int index)
		{
			
			throw new UnsupportedOperationException("The valueOf method of an enum does not throw any exception");
		}

		
				
		public virtual Optional toAst()
		{
			Optional result = Optional.empty();
			
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual bool hasName()
		{
			return ResolvedDeclaration._003Cdefault_003EhasName(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual bool isField()
		{
			return ResolvedDeclaration._003Cdefault_003EisField(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual bool isVariable()
		{
			return ResolvedDeclaration._003Cdefault_003EisVariable(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual bool isEnumConstant()
		{
			return ResolvedDeclaration._003Cdefault_003EisEnumConstant(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual bool isPattern()
		{
			return ResolvedDeclaration._003Cdefault_003EisPattern(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual bool isParameter()
		{
			return ResolvedDeclaration._003Cdefault_003EisParameter(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual bool isType()
		{
			return ResolvedDeclaration._003Cdefault_003EisType(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual bool isMethod()
		{
			return ResolvedDeclaration._003Cdefault_003EisMethod(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual ResolvedFieldDeclaration asField()
		{
			return ResolvedDeclaration._003Cdefault_003EasField(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual ResolvedParameterDeclaration asParameter()
		{
			return ResolvedDeclaration._003Cdefault_003EasParameter(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual ResolvedTypeDeclaration asType()
		{
			return ResolvedDeclaration._003Cdefault_003EasType(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual ResolvedMethodDeclaration asMethod()
		{
			return ResolvedDeclaration._003Cdefault_003EasMethod(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual ResolvedEnumConstantDeclaration asEnumConstant()
		{
			return ResolvedDeclaration._003Cdefault_003EasEnumConstant(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual ResolvedPatternDeclaration asPattern()
		{
			return ResolvedDeclaration._003Cdefault_003EasPattern(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Optional findTypeParameter(string P_0)
		{
			return ResolvedMethodLikeDeclaration._003Cdefault_003EfindTypeParameter(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual bool isGeneric()
		{
			return ResolvedTypeParametrizable._003Cdefault_003EisGeneric(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual string getPackageName()
		{
			return ResolvedMethodLikeDeclaration._003Cdefault_003EgetPackageName(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual string getClassName()
		{
			return ResolvedMethodLikeDeclaration._003Cdefault_003EgetClassName(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual string getQualifiedName()
		{
			return ResolvedMethodLikeDeclaration._003Cdefault_003EgetQualifiedName(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual string getSignature()
		{
			return ResolvedMethodLikeDeclaration._003Cdefault_003EgetSignature(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual string getQualifiedSignature()
		{
			return ResolvedMethodLikeDeclaration._003Cdefault_003EgetQualifiedSignature(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual ResolvedParameterDeclaration getLastParam()
		{
			return ResolvedMethodLikeDeclaration._003Cdefault_003EgetLastParam(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual bool hasVariadicParameter()
		{
			return ResolvedMethodLikeDeclaration._003Cdefault_003EhasVariadicParameter(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual List getSpecifiedExceptions()
		{
			return ResolvedMethodLikeDeclaration._003Cdefault_003EgetSpecifiedExceptions(this);
		}
	}

	
	public class ValuesMethod :  ResolvedMethodDeclaration, ResolvedMethodLikeDeclaration, ResolvedDeclaration, ResolvedTypeParametrizable, HasAccessSpecifier, AssociableToAST, TypeVariableResolutionCapability
	{
		private JavaParserEnumDeclaration enumDeclaration;

		private TypeSolver typeSolver;

		
		
		public ValuesMethod(JavaParserEnumDeclaration enumDeclaration, TypeSolver typeSolver)
		{
			this.enumDeclaration = enumDeclaration;
			this.typeSolver = typeSolver;
		}

		public virtual ResolvedReferenceTypeDeclaration declaringType()
		{
			return enumDeclaration;
		}

		
		
		public virtual ResolvedType getReturnType()
		{
			ReferenceTypeImpl.___003Cclinit_003E();
			ResolvedArrayType result = new ResolvedArrayType(new ReferenceTypeImpl(enumDeclaration, typeSolver));
			
			return result;
		}

		public virtual int getNumberOfParams()
		{
			return 0;
		}

		
		
		public virtual ResolvedParameterDeclaration getParam(int i)
		{
			
			throw new UnsupportedOperationException();
		}

		
		
		public virtual MethodUsage getUsage(Node node)
		{
			
			throw new UnsupportedOperationException();
		}

		
				
		public virtual MethodUsage resolveTypeVariables(Context context, List parameterTypes)
		{
			MethodUsage result = new MethodUsage(this);
			
			return result;
		}

		
		
		public virtual bool isAbstract()
		{
			
			throw new UnsupportedOperationException();
		}

		public virtual bool isDefaultMethod()
		{
			return false;
		}

		public virtual bool isStatic()
		{
			return false;
		}

		public virtual string getName()
		{
			return "values";
		}

		
				
		public virtual List getTypeParameters()
		{
			List result = Collections.emptyList();
			
			return result;
		}

		
		
		public virtual AccessSpecifier accessSpecifier()
		{
			AccessSpecifier result = enumDeclaration.getWrappedNode().getAccessSpecifier();
			
			return result;
		}

		public virtual int getNumberOfSpecifiedExceptions()
		{
			return 0;
		}

		
		
		public virtual ResolvedType getSpecifiedException(int index)
		{
			
			throw new UnsupportedOperationException("The values method of an enum does not throw any exception");
		}

		
				
		public virtual Optional toAst()
		{
			Optional result = Optional.empty();
			
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual bool hasName()
		{
			return ResolvedDeclaration._003Cdefault_003EhasName(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual bool isField()
		{
			return ResolvedDeclaration._003Cdefault_003EisField(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual bool isVariable()
		{
			return ResolvedDeclaration._003Cdefault_003EisVariable(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual bool isEnumConstant()
		{
			return ResolvedDeclaration._003Cdefault_003EisEnumConstant(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual bool isPattern()
		{
			return ResolvedDeclaration._003Cdefault_003EisPattern(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual bool isParameter()
		{
			return ResolvedDeclaration._003Cdefault_003EisParameter(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual bool isType()
		{
			return ResolvedDeclaration._003Cdefault_003EisType(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual bool isMethod()
		{
			return ResolvedDeclaration._003Cdefault_003EisMethod(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual ResolvedFieldDeclaration asField()
		{
			return ResolvedDeclaration._003Cdefault_003EasField(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual ResolvedParameterDeclaration asParameter()
		{
			return ResolvedDeclaration._003Cdefault_003EasParameter(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual ResolvedTypeDeclaration asType()
		{
			return ResolvedDeclaration._003Cdefault_003EasType(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual ResolvedMethodDeclaration asMethod()
		{
			return ResolvedDeclaration._003Cdefault_003EasMethod(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual ResolvedEnumConstantDeclaration asEnumConstant()
		{
			return ResolvedDeclaration._003Cdefault_003EasEnumConstant(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual ResolvedPatternDeclaration asPattern()
		{
			return ResolvedDeclaration._003Cdefault_003EasPattern(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Optional findTypeParameter(string P_0)
		{
			return ResolvedMethodLikeDeclaration._003Cdefault_003EfindTypeParameter(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual bool isGeneric()
		{
			return ResolvedTypeParametrizable._003Cdefault_003EisGeneric(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual string getPackageName()
		{
			return ResolvedMethodLikeDeclaration._003Cdefault_003EgetPackageName(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual string getClassName()
		{
			return ResolvedMethodLikeDeclaration._003Cdefault_003EgetClassName(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual string getQualifiedName()
		{
			return ResolvedMethodLikeDeclaration._003Cdefault_003EgetQualifiedName(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual string getSignature()
		{
			return ResolvedMethodLikeDeclaration._003Cdefault_003EgetSignature(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual string getQualifiedSignature()
		{
			return ResolvedMethodLikeDeclaration._003Cdefault_003EgetQualifiedSignature(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual ResolvedParameterDeclaration getLastParam()
		{
			return ResolvedMethodLikeDeclaration._003Cdefault_003EgetLastParam(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual bool hasVariadicParameter()
		{
			return ResolvedMethodLikeDeclaration._003Cdefault_003EhasVariadicParameter(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual List getSpecifiedExceptions()
		{
			return ResolvedMethodLikeDeclaration._003Cdefault_003EgetSpecifiedExceptions(this);
		}
	}

	
	private sealed class ___003C_003EAnon0 : Consumer
	{
		private readonly List arg_00241;

		internal ___003C_003EAnon0(List P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			lambda_0024getAllFields_00240(arg_00241, (ResolvedReferenceType)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Predicate
	{
		internal ___003C_003EAnon1()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024getAllFields_00241((BodyDeclaration)P_0);
			
			return result;
		}

		
		public Predicate and(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public Predicate negate()
		{
			return Predicate._003Cdefault_003Enegate(this);
		}

		
		public Predicate or(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon2 : Consumer
	{
		private readonly JavaParserEnumDeclaration arg_00241;

		private readonly List arg_00242;

		internal ___003C_003EAnon2(JavaParserEnumDeclaration P_0, List P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024getAllFields_00243(arg_00242, (BodyDeclaration)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon3 : Function
	{
		private readonly JavaParserEnumDeclaration arg_00241;

		internal ___003C_003EAnon3(JavaParserEnumDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			LazyType result = arg_00241.lambda_0024toReferenceType_00245((com.github.javaparser.ast.type.Type)P_0);
			
			return result;
		}

		
		public Function compose(Function P_0)
		{
			return Function._003Cdefault_003Ecompose(this, P_0);
		}

		
		public Function andThen(Function P_0)
		{
			return Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon4 : Supplier
	{
		internal ___003C_003EAnon4()
		{
		}

		public object get()
		{
			RuntimeException result = lambda_0024solveType_00246();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon5 : Function
	{
		private readonly JavaParserEnumDeclaration arg_00241;

		internal ___003C_003EAnon5(JavaParserEnumDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			JavaParserEnumConstantDeclaration result = arg_00241.lambda_0024getEnumConstants_00247((EnumConstantDeclaration)P_0);
			
			return result;
		}

		
		public Function compose(Function P_0)
		{
			return Function._003Cdefault_003Ecompose(this, P_0);
		}

		
		public Function andThen(Function P_0)
		{
			return Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon6 : Function
	{
		private readonly JavaParserEnumDeclaration arg_00241;

		private readonly com.github.javaparser.ast.type.Type arg_00242;

		internal ___003C_003EAnon6(JavaParserEnumDeclaration P_0, com.github.javaparser.ast.type.Type P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			ResolvedType result = arg_00241.lambda_0024null_00244(arg_00242, (java.lang.Void)P_0);
			
			return result;
		}

		
		public Function compose(Function P_0)
		{
			return Function._003Cdefault_003Ecompose(this, P_0);
		}

		
		public Function andThen(Function P_0)
		{
			return Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon7 : Consumer
	{
		private readonly JavaParserEnumDeclaration arg_00241;

		private readonly List arg_00242;

		internal ___003C_003EAnon7(JavaParserEnumDeclaration P_0, List P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024null_00242(arg_00242, (VariableDeclarator)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	private static string JAVA_LANG_ENUM;

	private static string JAVA_LANG_COMPARABLE;

	private static string JAVA_IO_SERIALIZABLE;

	private TypeSolver typeSolver;

	private EnumDeclaration wrappedNode;

		private JavaParserTypeAdapter javaParserTypeAdapter;

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
	
	public JavaParserEnumDeclaration(EnumDeclaration wrappedNode, TypeSolver typeSolver)
	{
		this.wrappedNode = wrappedNode;
		this.typeSolver = typeSolver;
		javaParserTypeAdapter = new JavaParserTypeAdapter(wrappedNode, typeSolver);
	}

	public virtual EnumDeclaration getWrappedNode()
	{
		return wrappedNode;
	}

	
	
	public override string getQualifiedName()
	{
		string qualifiedName = javaParserTypeAdapter.getQualifiedName();
		
		return qualifiedName;
	}

	
	
	public virtual Context getContext()
	{
		Context context = JavaParserFactory.getContext(wrappedNode, typeSolver);
		
		return context;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override List getAncestors()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetAncestors(this);
	}

	
	
	private ResolvedReferenceType toReferenceType(ClassOrInterfaceType P_0)
	{
		string text = P_0.getName().getId();
		if (P_0.getScope().isPresent())
		{
			text = new StringBuilder().append(((ClassOrInterfaceType)P_0.getScope().get()).ToString()).append(".").append(text)
				.ToString();
		}
		SymbolReference symbolReference = solveType(text);
		if (!symbolReference.isSolved())
		{
			string id = P_0.getName().getId();
			
			throw new UnsolvedSymbolException(id);
		}
		if (!P_0.getTypeArguments().isPresent())
		{
			ReferenceTypeImpl.___003Cclinit_003E();
			ReferenceTypeImpl result = new ReferenceTypeImpl(((ResolvedTypeDeclaration)symbolReference.getCorrespondingDeclaration()).asReferenceType(), typeSolver);
			
			return result;
		}
		List typeArguments = (List)((NodeList)P_0.getTypeArguments().get()).stream().map(new ___003C_003EAnon3(this)).collect(Collectors.toList());
		ReferenceTypeImpl.___003Cclinit_003E();
		ReferenceTypeImpl result2 = new ReferenceTypeImpl(((ResolvedTypeDeclaration)symbolReference.getCorrespondingDeclaration()).asReferenceType(), typeArguments, typeSolver);
		
		return result2;
	}

	
	
		
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual SymbolReference solveType(string name)
	{
		if (java.lang.String.instancehelper_equals(wrappedNode.getName().getId(), name))
		{
			SymbolReference result = SymbolReference.solved(this);
			
			return result;
		}
		SymbolReference symbolReference = javaParserTypeAdapter.solveType(name);
		if (symbolReference.isSolved())
		{
			return symbolReference;
		}
		SymbolReference result2 = ((Context)getContext().getParent().orElseThrow(new ___003C_003EAnon4())).solveType(name);
		
		return result2;
	}

	
	
	
	private static void lambda_0024getAllFields_00240(List P_0, ResolvedReferenceType P_1)
	{
		P_0.addAll(P_1.getAllFieldsVisibleToInheritors());
	}

	
	
	private static bool lambda_0024getAllFields_00241(BodyDeclaration P_0)
	{
		return P_0 is FieldDeclaration;
	}

	
	
	
	private void lambda_0024getAllFields_00243(List P_0, BodyDeclaration P_1)
	{
		FieldDeclaration fieldDeclaration = (FieldDeclaration)P_1;
		fieldDeclaration.getVariables().forEach(new ___003C_003EAnon7(this, P_0));
	}

	
	
	
	private LazyType lambda_0024toReferenceType_00245(com.github.javaparser.ast.type.Type P_0)
	{
		LazyType result = new LazyType(new ___003C_003EAnon6(this, P_0));
		
		return result;
	}

	
	
	
	private static RuntimeException lambda_0024solveType_00246()
	{
		RuntimeException result = new RuntimeException("Parent context unexpectedly empty.");
		
		return result;
	}

	
	
	
	private JavaParserEnumConstantDeclaration lambda_0024getEnumConstants_00247(EnumConstantDeclaration P_0)
	{
		JavaParserEnumConstantDeclaration result = new JavaParserEnumConstantDeclaration(P_0, typeSolver);
		
		return result;
	}

	
	
	
	private ResolvedType lambda_0024null_00244(com.github.javaparser.ast.type.Type P_0, java.lang.Void P_1)
	{
		ResolvedType result = JavaParserFacade.get(typeSolver).convert(P_0, P_0);
		
		return result;
	}

	
	
	
	private void lambda_0024null_00242(List P_0, VariableDeclarator P_1)
	{
		P_0.add(new JavaParserFieldDeclaration(P_1, typeSolver));
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("JavaParserEnumDeclaration{wrappedNode=").append(wrappedNode).append('}')
			.ToString();
		
		return result;
	}

	
		
	public override Set getDeclaredMethods()
	{
		HashSet hashSet = new HashSet();
		Iterator iterator = wrappedNode.getMembers().iterator();
		while (iterator.hasNext())
		{
			BodyDeclaration bodyDeclaration = (BodyDeclaration)iterator.next();
			if (bodyDeclaration is MethodDeclaration)
			{
				((Set)hashSet).add((object)new JavaParserMethodDeclaration((MethodDeclaration)bodyDeclaration, typeSolver));
			}
		}
		return hashSet;
	}

	
	
	public override string getName()
	{
		string id = wrappedNode.getName().getId();
		
		return id;
	}

	public override bool isField()
	{
		return false;
	}

	public override bool isParameter()
	{
		return false;
	}

	public override bool isType()
	{
		return true;
	}

	
	
	public override bool hasDirectlyAnnotation(string canonicalName)
	{
		bool result = AstResolutionUtils.hasDirectlyAnnotation(wrappedNode, typeSolver, canonicalName);
		
		return result;
	}

	
	
	public override bool canBeAssignedTo(ResolvedReferenceTypeDeclaration other)
	{
		string qualifiedName = other.getQualifiedName();
		if (java.lang.String.instancehelper_equals(qualifiedName, getQualifiedName()))
		{
			return true;
		}
		if (java.lang.String.instancehelper_equals(qualifiedName, JAVA_LANG_ENUM))
		{
			return true;
		}
		if (java.lang.String.instancehelper_equals(qualifiedName, JAVA_LANG_COMPARABLE))
		{
			return true;
		}
		if (java.lang.String.instancehelper_equals(qualifiedName, JAVA_IO_SERIALIZABLE))
		{
			return true;
		}
		if (other.isJavaLangObject())
		{
			return true;
		}
		return false;
	}

	public override bool isClass()
	{
		return false;
	}

	public override bool isInterface()
	{
		return false;
	}

	
	
	public override string getPackageName()
	{
		string packageName = javaParserTypeAdapter.getPackageName();
		
		return packageName;
	}

	
	
	public override string getClassName()
	{
		string className = javaParserTypeAdapter.getClassName();
		
		return className;
	}

	
	
	public override bool isAssignableBy(ResolvedReferenceTypeDeclaration other)
	{
		bool result = javaParserTypeAdapter.isAssignableBy(other);
		
		return result;
	}

	
	
	public override bool isAssignableBy(ResolvedType type)
	{
		bool result = javaParserTypeAdapter.isAssignableBy(type);
		
		return result;
	}

	public override bool isTypeParameter()
	{
		return false;
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
		JavaParserEnumDeclaration javaParserEnumDeclaration = (JavaParserEnumDeclaration)o;
		if (!wrappedNode.equals(javaParserEnumDeclaration.wrappedNode))
		{
			return false;
		}
		return true;
	}

	
	
	public override int GetHashCode()
	{
		int result = wrappedNode.GetHashCode();
		
		return result;
	}

	
		
	public virtual Optional solveMethodAsUsage(string name, List argumentTypes, Context invokationContext, List typeParameters)
	{
		Optional result = getContext().solveMethodAsUsage(name, argumentTypes);
		
		return result;
	}

	
		
	public virtual SymbolReference solveMethod(string name, List argumentsTypes, bool staticOnly)
	{
		if (java.lang.String.instancehelper_equals(name, "values") && argumentsTypes.isEmpty())
		{
			SymbolReference result = SymbolReference.solved(new ValuesMethod(this, typeSolver));
			
			return result;
		}
		if (java.lang.String.instancehelper_equals(name, "valueOf") && argumentsTypes.size() == 1)
		{
			ResolvedType resolvedType = (ResolvedType)argumentsTypes.get(0);
			if (resolvedType.isReferenceType() && java.lang.String.instancehelper_equals("java.lang.String", resolvedType.asReferenceType().getQualifiedName()))
			{
				SymbolReference result2 = SymbolReference.solved(new ValueOfMethod(this, typeSolver));
				
				return result2;
			}
		}
		SymbolReference result3 = getContext().solveMethod(name, argumentsTypes, staticOnly);
		
		return result3;
	}

	
		
	public override List getAllFields()
	{
		List fieldsForDeclaredVariables = javaParserTypeAdapter.getFieldsForDeclaredVariables();
		getAncestors().forEach(new ___003C_003EAnon0(fieldsForDeclaredVariables));
		wrappedNode.getMembers().stream().filter(new ___003C_003EAnon1())
			.forEach(new ___003C_003EAnon2(this, fieldsForDeclaredVariables));
		return fieldsForDeclaredVariables;
	}

	
		
	public override List getAncestors(bool acceptIncompleteList)
	{
		ArrayList arrayList = new ArrayList();
		ResolvedReferenceType resolvedReferenceType = ReflectionFactory.typeUsageFor(ClassLiteral<java.lang.Enum>.Value, typeSolver).asReferenceType();
		if (resolvedReferenceType.getTypeDeclaration().isPresent())
		{
			ResolvedTypeParameterDeclaration typeParameter = (ResolvedTypeParameterDeclaration)((ResolvedReferenceTypeDeclaration)resolvedReferenceType.getTypeDeclaration().get()).getTypeParameters().get(0);
			ResolvedReferenceType resolvedReferenceType2 = resolvedReferenceType;
			ResolvedTypeParametersMap.Builder builder = new ResolvedTypeParametersMap.Builder();
			ReferenceTypeImpl.___003Cclinit_003E();
			resolvedReferenceType = resolvedReferenceType2.deriveTypeParameters(builder.setValue(typeParameter, new ReferenceTypeImpl(this, typeSolver)).build());
			((List)arrayList).add((object)resolvedReferenceType);
		}
		if (wrappedNode.getImplementedTypes() != null)
		{
			Iterator iterator = wrappedNode.getImplementedTypes().iterator();
			while (iterator.hasNext())
			{
				ClassOrInterfaceType classOrInterfaceType = (ClassOrInterfaceType)iterator.next();
				UnsolvedSymbolException ex;
				try
				{
					((List)arrayList).add((object)toReferenceType(classOrInterfaceType));
				}
				catch (UnsolvedSymbolException x)
				{
					ex = ByteCodeHelper.MapException<UnsolvedSymbolException>(x, ByteCodeHelper.MapFlags.NoRemapping);
					goto IL_00d4;
				}
				continue;
				IL_00d4:
				UnsolvedSymbolException ex2 = ex;
				if (!acceptIncompleteList)
				{
					throw ex2;
				}
			}
		}
		return arrayList;
	}

	
		
	public override List getTypeParameters()
	{
		List result = Collections.emptyList();
		
		return result;
	}

	
		
	public virtual List getEnumConstants()
	{
		return (List)wrappedNode.getEntries().stream().map(new ___003C_003EAnon5(this))
			.collect(Collectors.toList());
	}

	
	
	public virtual AccessSpecifier accessSpecifier()
	{
		AccessSpecifier result = wrappedNode.getAccessSpecifier();
		
		return result;
	}

	
		
	public override Set internalTypes()
	{
		Set result = javaParserTypeAdapter.internalTypes();
		
		return result;
	}

	
		
	public override Optional containerType()
	{
		Optional result = javaParserTypeAdapter.containerType();
		
		return result;
	}

	
		
	public override List getConstructors()
	{
		List constructors = AstResolutionUtils.getConstructors(wrappedNode, typeSolver, this);
		
		return constructors;
	}

	
		
	public virtual Optional toAst()
	{
		Optional result = Optional.of(wrappedNode);
		
		return result;
	}

	
	static JavaParserEnumDeclaration()
	{
		JAVA_LANG_ENUM = ClassLiteral<java.lang.Enum>.Value.getCanonicalName();
		JAVA_LANG_COMPARABLE = ClassLiteral<Comparable>.Value.getCanonicalName();
		JAVA_IO_SERIALIZABLE = ClassLiteral<Serializable>.Value.getCanonicalName();
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool hasName()
	{
		return ResolvedDeclaration._003Cdefault_003EhasName(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isVariable()
	{
		return ResolvedDeclaration._003Cdefault_003EisVariable(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isEnumConstant()
	{
		return ResolvedDeclaration._003Cdefault_003EisEnumConstant(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isPattern()
	{
		return ResolvedDeclaration._003Cdefault_003EisPattern(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isMethod()
	{
		return ResolvedDeclaration._003Cdefault_003EisMethod(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedFieldDeclaration asField()
	{
		return ResolvedDeclaration._003Cdefault_003EasField(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedParameterDeclaration asParameter()
	{
		return ResolvedDeclaration._003Cdefault_003EasParameter(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedTypeDeclaration asType()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EasType(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedMethodDeclaration asMethod()
	{
		return ResolvedDeclaration._003Cdefault_003EasMethod(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedEnumConstantDeclaration asEnumConstant()
	{
		return ResolvedDeclaration._003Cdefault_003EasEnumConstant(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedPatternDeclaration asPattern()
	{
		return ResolvedDeclaration._003Cdefault_003EasPattern(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedReferenceTypeDeclaration getInternalType(string P_0)
	{
		return ResolvedTypeDeclaration._003Cdefault_003EgetInternalType(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool hasInternalType(string P_0)
	{
		return ResolvedTypeDeclaration._003Cdefault_003EhasInternalType(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isEnum()
	{
		return ResolvedEnumDeclaration._003Cdefault_003EisEnum(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isAnnotation()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EisAnnotation(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isAnonymousClass()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EisAnonymousClass(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedClassDeclaration asClass()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EasClass(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedInterfaceDeclaration asInterface()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EasInterface(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedEnumDeclaration asEnum()
	{
		return ResolvedEnumDeclaration._003Cdefault_003EasEnum(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedAnnotationDeclaration asAnnotation()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EasAnnotation(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedTypeParameterDeclaration asTypeParameter()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EasTypeParameter(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedReferenceTypeDeclaration asReferenceType()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EasReferenceType(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override string getId()
	{
		return ResolvedTypeDeclaration._003Cdefault_003EgetId(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Optional findTypeParameter(string P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EfindTypeParameter(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isGeneric()
	{
		return ResolvedTypeParametrizable._003Cdefault_003EisGeneric(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override List getAllAncestors()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetAllAncestors(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override List getAllAncestors(Function P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetAllAncestors(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedFieldDeclaration getField(string P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetField(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override ResolvedFieldDeclaration getVisibleField(string P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetVisibleField(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool hasField(string P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EhasField(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool hasVisibleField(string P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EhasVisibleField(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override List getVisibleFields()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetVisibleFields(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override List getAllNonStaticFields()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetAllNonStaticFields(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override List getAllStaticFields()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetAllStaticFields(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override List getDeclaredFields()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EgetDeclaredFields(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool hasAnnotation(string P_0)
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EhasAnnotation(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isJavaLangObject()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EisJavaLangObject(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool isJavaLangEnum()
	{
		return ResolvedReferenceTypeDeclaration._003Cdefault_003EisJavaLangEnum(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool hasEnumConstant(string P_0)
	{
		return ResolvedEnumDeclaration._003Cdefault_003EhasEnumConstant(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual ResolvedEnumConstantDeclaration getEnumConstant(string P_0)
	{
		return ResolvedEnumDeclaration._003Cdefault_003EgetEnumConstant(this, P_0);
	}
}
