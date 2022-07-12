using System;
using System.ComponentModel;

using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.type;
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.resolution.types;
using com.github.javaparser.symbolsolver.core.resolution;
using com.github.javaparser.symbolsolver.javaparser;
using com.github.javaparser.symbolsolver.javaparsermodel.declarations;
using com.github.javaparser.symbolsolver.logic;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.model.typesystem;
using com.github.javaparser.symbolsolver.reflectionmodel;
using com.github.javaparser.symbolsolver.resolution;
using com.github.javaparser.symbolsolver.resolution.promotion;
using com.github.javaparser.symbolsolver.resolution.typesolvers;
using com.github.javaparser.utils;
using com.google.common.collect;

using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.symbolsolver.javaparsermodel;

public class TypeExtractor : DefaultVisitorAdapter
{
	
	
	
	
	internal class _1
	{
		
		internal static int[] _0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024BinaryExpr_0024Operator;

		
		internal static int[] _0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024UnaryExpr_0024Operator;

		
		
		public static void ___003Cclinit_003E()
		{
		}

		
		static _1()
		{
			_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024UnaryExpr_0024Operator = new int[(nint)UnaryExpr.Operator.values().LongLength];
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024UnaryExpr_0024Operator[UnaryExpr.Operator.___003C_003EMINUS.ordinal()] = 1;
			}
			catch (System.Exception x)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0033;
			}
			goto IL_0039;
			IL_0033:
			
			goto IL_0039;
			IL_0039:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024UnaryExpr_0024Operator[UnaryExpr.Operator.___003C_003EPLUS.ordinal()] = 2;
			}
			catch (System.Exception x2)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x2, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_005c;
			}
			goto IL_0062;
			IL_005c:
			
			goto IL_0062;
			IL_0062:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024UnaryExpr_0024Operator[UnaryExpr.Operator.___003C_003ELOGICAL_COMPLEMENT.ordinal()] = 3;
			}
			catch (System.Exception x3)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x3, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0085;
			}
			goto IL_008b;
			IL_0085:
			
			goto IL_008b;
			IL_008b:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024UnaryExpr_0024Operator[UnaryExpr.Operator.___003C_003EPOSTFIX_DECREMENT.ordinal()] = 4;
			}
			catch (System.Exception x4)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x4, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_00ae;
			}
			goto IL_00b4;
			IL_00ae:
			
			goto IL_00b4;
			IL_00b4:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024UnaryExpr_0024Operator[UnaryExpr.Operator.___003C_003EPREFIX_DECREMENT.ordinal()] = 5;
			}
			catch (System.Exception x5)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x5, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_00d7;
			}
			goto IL_00dd;
			IL_00d7:
			
			goto IL_00dd;
			IL_00dd:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024UnaryExpr_0024Operator[UnaryExpr.Operator.___003C_003EPOSTFIX_INCREMENT.ordinal()] = 6;
			}
			catch (System.Exception x6)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x6, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0100;
			}
			goto IL_0106;
			IL_0100:
			
			goto IL_0106;
			IL_0106:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024UnaryExpr_0024Operator[UnaryExpr.Operator.___003C_003EPREFIX_INCREMENT.ordinal()] = 7;
			}
			catch (System.Exception x7)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x7, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0129;
			}
			goto IL_012f;
			IL_0129:
			
			goto IL_012f;
			IL_012f:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024UnaryExpr_0024Operator[UnaryExpr.Operator.___003C_003EBITWISE_COMPLEMENT.ordinal()] = 8;
			}
			catch (System.Exception x8)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x8, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0152;
			}
			goto IL_0158;
			IL_0152:
			
			goto IL_0158;
			IL_0158:
			_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024BinaryExpr_0024Operator = new int[(nint)BinaryExpr.Operator.values().LongLength];
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024BinaryExpr_0024Operator[BinaryExpr.Operator.___003C_003EPLUS.ordinal()] = 1;
			}
			catch (System.Exception x9)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x9, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_018b;
			}
			goto IL_0191;
			IL_018b:
			
			goto IL_0191;
			IL_0191:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024BinaryExpr_0024Operator[BinaryExpr.Operator.___003C_003EMINUS.ordinal()] = 2;
			}
			catch (System.Exception x10)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x10, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_01b4;
			}
			goto IL_01ba;
			IL_01b4:
			
			goto IL_01ba;
			IL_01ba:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024BinaryExpr_0024Operator[BinaryExpr.Operator.___003C_003EDIVIDE.ordinal()] = 3;
			}
			catch (System.Exception x11)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x11, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_01dd;
			}
			goto IL_01e3;
			IL_01dd:
			
			goto IL_01e3;
			IL_01e3:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024BinaryExpr_0024Operator[BinaryExpr.Operator.___003C_003EMULTIPLY.ordinal()] = 4;
			}
			catch (System.Exception x12)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x12, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0206;
			}
			goto IL_020c;
			IL_0206:
			
			goto IL_020c;
			IL_020c:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024BinaryExpr_0024Operator[BinaryExpr.Operator.___003C_003EREMAINDER.ordinal()] = 5;
			}
			catch (System.Exception x13)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x13, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_022f;
			}
			goto IL_0235;
			IL_022f:
			
			goto IL_0235;
			IL_0235:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024BinaryExpr_0024Operator[BinaryExpr.Operator.___003C_003EBINARY_AND.ordinal()] = 6;
			}
			catch (System.Exception x14)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x14, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0258;
			}
			goto IL_025e;
			IL_0258:
			
			goto IL_025e;
			IL_025e:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024BinaryExpr_0024Operator[BinaryExpr.Operator.___003C_003EBINARY_OR.ordinal()] = 7;
			}
			catch (System.Exception x15)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x15, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0281;
			}
			goto IL_0287;
			IL_0281:
			
			goto IL_0287;
			IL_0287:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024BinaryExpr_0024Operator[BinaryExpr.Operator.___003C_003EXOR.ordinal()] = 8;
			}
			catch (System.Exception x16)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x16, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_02aa;
			}
			goto IL_02b0;
			IL_02aa:
			
			goto IL_02b0;
			IL_02b0:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024BinaryExpr_0024Operator[BinaryExpr.Operator.___003C_003ELESS_EQUALS.ordinal()] = 9;
			}
			catch (System.Exception x17)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x17, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_02d4;
			}
			goto IL_02da;
			IL_02d4:
			
			goto IL_02da;
			IL_02da:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024BinaryExpr_0024Operator[BinaryExpr.Operator.___003C_003ELESS.ordinal()] = 10;
			}
			catch (System.Exception x18)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x18, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_02fe;
			}
			goto IL_0304;
			IL_02fe:
			
			goto IL_0304;
			IL_0304:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024BinaryExpr_0024Operator[BinaryExpr.Operator.___003C_003EGREATER.ordinal()] = 11;
			}
			catch (System.Exception x19)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x19, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0328;
			}
			goto IL_032e;
			IL_0328:
			
			goto IL_032e;
			IL_032e:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024BinaryExpr_0024Operator[BinaryExpr.Operator.___003C_003EGREATER_EQUALS.ordinal()] = 12;
			}
			catch (System.Exception x20)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x20, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0352;
			}
			goto IL_0358;
			IL_0352:
			
			goto IL_0358;
			IL_0358:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024BinaryExpr_0024Operator[BinaryExpr.Operator.___003C_003EEQUALS.ordinal()] = 13;
			}
			catch (System.Exception x21)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x21, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_037c;
			}
			goto IL_0382;
			IL_037c:
			
			goto IL_0382;
			IL_0382:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024BinaryExpr_0024Operator[BinaryExpr.Operator.___003C_003ENOT_EQUALS.ordinal()] = 14;
			}
			catch (System.Exception x22)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x22, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_03a6;
			}
			goto IL_03ac;
			IL_03a6:
			
			goto IL_03ac;
			IL_03ac:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024BinaryExpr_0024Operator[BinaryExpr.Operator.___003C_003EOR.ordinal()] = 15;
			}
			catch (System.Exception x23)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x23, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_03d0;
			}
			goto IL_03d6;
			IL_03d0:
			
			goto IL_03d6;
			IL_03d6:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024BinaryExpr_0024Operator[BinaryExpr.Operator.___003C_003EAND.ordinal()] = 16;
			}
			catch (System.Exception x24)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x24, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_03fa;
			}
			goto IL_0400;
			IL_03fa:
			
			goto IL_0400;
			IL_0400:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024BinaryExpr_0024Operator[BinaryExpr.Operator.___003C_003ESIGNED_RIGHT_SHIFT.ordinal()] = 17;
			}
			catch (System.Exception x25)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x25, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0424;
			}
			goto IL_042a;
			IL_0424:
			
			goto IL_042a;
			IL_042a:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024BinaryExpr_0024Operator[BinaryExpr.Operator.___003C_003EUNSIGNED_RIGHT_SHIFT.ordinal()] = 18;
			}
			catch (System.Exception x26)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x26, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_044e;
			}
			goto IL_0454;
			IL_044e:
			
			goto IL_0454;
			IL_0454:
			try
			{
				_0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024BinaryExpr_0024Operator[BinaryExpr.Operator.___003C_003ELEFT_SHIFT.ordinal()] = 19;
				return;
			}
			catch (System.Exception x27)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x27, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
			}
			
		}

		_1()
		{
			throw null;
		}
	}

	
	private sealed class ___003C_003EAnon0 : Supplier
	{
		private readonly MethodCallExpr arg_00241;

		internal ___003C_003EAnon0(MethodCallExpr P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			object result = lambda_0024visit_00240(arg_00241);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon1 : Supplier
	{
		private readonly MethodCallExpr arg_00241;

		internal ___003C_003EAnon1(MethodCallExpr P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			object result = lambda_0024visit_00241(arg_00241);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon2 : Supplier
	{
		private readonly MethodUsage arg_00241;

		internal ___003C_003EAnon2(MethodUsage P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			object result = lambda_0024visit_00242(arg_00241);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon3 : Supplier
	{
		private readonly MethodCallExpr arg_00241;

		internal ___003C_003EAnon3(MethodCallExpr P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			object result = lambda_0024visit_00243(arg_00241);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon4 : Supplier
	{
		private readonly MethodUsage arg_00241;

		internal ___003C_003EAnon4(MethodUsage P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			object result = arg_00241.returnType();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon5 : Supplier
	{
		private readonly NameExpr arg_00241;

		internal ___003C_003EAnon5(NameExpr P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			object result = lambda_0024visit_00244(arg_00241);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon6 : Supplier
	{
		private readonly TypeExpr arg_00241;

		internal ___003C_003EAnon6(TypeExpr P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			object result = lambda_0024visit_00245(arg_00241);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon7 : Supplier
	{
		internal ___003C_003EAnon7()
		{
		}

		public object get()
		{
			RuntimeException result = lambda_0024visit_00246();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon8 : Supplier
	{
		internal ___003C_003EAnon8()
		{
		}

		public object get()
		{
			RuntimeException result = lambda_0024visit_00247();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon9 : Supplier
	{
		private readonly SymbolReference arg_00241;

		internal ___003C_003EAnon9(SymbolReference P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			object result = lambda_0024visit_00248(arg_00241);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon10 : Function
	{
		private readonly TypeExtractor arg_00241;

		internal ___003C_003EAnon10(TypeExtractor P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			ResolvedType result = arg_00241.lambda_0024resolveLambda_002410((ReturnStmt)P_0);
			
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

	
	private sealed class ___003C_003EAnon11 : Predicate
	{
		internal ___003C_003EAnon11()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024resolveLambda_002411((ResolvedType)P_0);
			
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

	
	private sealed class ___003C_003EAnon12 : Supplier
	{
		private readonly SymbolReference arg_00241;

		internal ___003C_003EAnon12(SymbolReference P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			object result = lambda_0024visit_002412(arg_00241);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon13 : Function
	{
		private readonly TypeExtractor arg_00241;

		internal ___003C_003EAnon13(TypeExtractor P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			ResolvedType result = arg_00241.lambda_0024null_00249((Expression)P_0);
			
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

	
	private static string JAVA_LANG_STRING;

	private TypeSolver typeSolver;

	private JavaParserFacade facade;

	private ReferenceTypeImpl StringReferenceType;

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
	
	public TypeExtractor(TypeSolver typeSolver, JavaParserFacade facade)
	{
		this.typeSolver = typeSolver;
		this.facade = facade;
		ReferenceTypeImpl.___003Cclinit_003E();
		StringReferenceType = new ReferenceTypeImpl(new ReflectionTypeSolver().solveType(JAVA_LANG_STRING), typeSolver);
	}

	
	
	private ResolvedType solveDotExpressionType(ResolvedReferenceTypeDeclaration P_0, FieldAccessExpr P_1)
	{
		if (P_0.isEnum() && P_0.asEnum().hasEnumConstant(P_1.getName().getId()))
		{
			ResolvedType type = P_0.asEnum().getEnumConstant(P_1.getName().getId()).getType();
			
			return type;
		}
		if (P_0.hasField(P_1.getName().getId()))
		{
			ResolvedType type2 = P_0.getField(P_1.getName().getId()).getType();
			
			return type2;
		}
		if (P_0.hasInternalType(P_1.getName().getId()))
		{
			ReferenceTypeImpl.___003Cclinit_003E();
			ReferenceTypeImpl result = new ReferenceTypeImpl(P_0.getInternalType(P_1.getName().getId()), typeSolver);
			
			return result;
		}
		string id = P_1.getName().getId();
		
		throw new UnsolvedSymbolException(id);
	}

	
	
	private ResolvedType resolveLambda(LambdaExpr P_0, ResolvedType P_1)
	{
		Context context = JavaParserFactory.getContext(P_0, typeSolver);
		P_1 = JavaParserFacade.solveGenericTypes(P_1, context);
		Optional functionalMethod = FunctionalInterfaceLogic.getFunctionalMethod(P_1);
		if (functionalMethod.isPresent())
		{
			InferenceContext inferenceContext = new InferenceContext(MyObjectProvider.___003C_003EINSTANCE);
			InferenceContext inferenceContext2 = new InferenceContext(MyObjectProvider.___003C_003EINSTANCE);
			ResolvedReferenceType actual = ReferenceTypeImpl.undeterminedParameters(((MethodUsage)functionalMethod.get()).getDeclaration().declaringType(), typeSolver);
			inferenceContext.addPair(P_1, actual);
			ResolvedType actual2;
			if (P_0.getBody() is ExpressionStmt)
			{
				actual2 = facade.getType(((ExpressionStmt)P_0.getBody()).getExpression());
			}
			else
			{
				if (!(P_0.getBody() is BlockStmt))
				{
					
					throw new UnsupportedOperationException();
				}
				BlockStmt blockStmt = (BlockStmt)P_0.getBody();
				List list = blockStmt.findAll(ClassLiteral<ReturnStmt>.Value);
				actual2 = ((list.size() <= 0) ? ResolvedVoidType.___003C_003EINSTANCE : ((ResolvedType)list.stream().map(new ___003C_003EAnon10(this)).filter(new ___003C_003EAnon11())
					.findFirst()
					.orElse(ResolvedVoidType.___003C_003EINSTANCE)));
			}
			ResolvedType resolvedType = ((MethodUsage)functionalMethod.get()).returnType();
			inferenceContext2.addPair(resolvedType, actual2);
			ResolvedType actual3 = inferenceContext2.resolve(inferenceContext2.addSingle(actual));
			if (!(resolvedType is ResolvedVoidType))
			{
				inferenceContext.addPair(P_1, actual3);
				P_1 = inferenceContext.resolve(inferenceContext.addSingle(P_1));
			}
		}
		return P_1;
	}

	
	
	public override ResolvedType visit(TypeExpr node, java.lang.Boolean solveLambdas)
	{
		Log.trace("getType on type expr %s", new ___003C_003EAnon6(node));
		if (!(node.getType() is ClassOrInterfaceType))
		{
			string canonicalName = java.lang.Object.instancehelper_getClass(node.getType()).getCanonicalName();
			
			throw new UnsupportedOperationException(canonicalName);
		}
		ClassOrInterfaceType classOrInterfaceType = (ClassOrInterfaceType)node.getType();
		string nameWithScope = classOrInterfaceType.getNameWithScope();
		SymbolReference symbolReference = JavaParserFactory.getContext(classOrInterfaceType, typeSolver).solveType(nameWithScope);
		if (symbolReference.isSolved())
		{
			ReferenceTypeImpl.___003Cclinit_003E();
			ReferenceTypeImpl result = new ReferenceTypeImpl(((ResolvedTypeDeclaration)symbolReference.getCorrespondingDeclaration()).asReferenceType(), typeSolver);
			
			return result;
		}
		Optional optional = new SymbolSolver(typeSolver).solveSymbolAsValue(nameWithScope, node);
		if (optional.isPresent())
		{
			ResolvedType type = ((Value)optional.get()).getType();
			
			return type;
		}
		string name = new StringBuilder().append("Solving ").append(node).ToString();
		string id = classOrInterfaceType.getName().getId();
		
		throw new UnsolvedSymbolException(name, id);
	}

	
	
	public override ResolvedType visit(MethodReferenceExpr node, java.lang.Boolean solveLambdas)
	{
		if (Navigator.demandParentNode(node) is MethodCallExpr)
		{
			MethodCallExpr methodCallExpr = (MethodCallExpr)Navigator.demandParentNode(node);
			int paramPos = JavaParserSymbolDeclaration.getParamPos(node);
			SymbolReference symbolReference = facade.solve(methodCallExpr, solveLambdas: false);
			if (!symbolReference.isSolved())
			{
				string name = Navigator.demandParentNode(node).ToString();
				string id = methodCallExpr.getName().getId();
				
				throw new UnsolvedSymbolException(name, id);
			}
			Log.trace("getType on method reference expr %s", new ___003C_003EAnon12(symbolReference));
			if (solveLambdas.booleanValue())
			{
				MethodUsage methodUsage = facade.solveMethodAsUsage(methodCallExpr);
				ResolvedType paramType = methodUsage.getParamType(paramPos);
				Context context = JavaParserFactory.getContext(node, typeSolver);
				paramType = JavaParserFacade.solveGenericTypes(paramType, context);
				Optional functionalMethod = FunctionalInterfaceLogic.getFunctionalMethod(paramType);
				if (functionalMethod.isPresent())
				{
					MethodUsage methodUsage2 = (MethodUsage)functionalMethod.get();
					Iterator iterator = paramType.asReferenceType().getTypeParametersMap().iterator();
					while (iterator.hasNext())
					{
						Pair pair = (Pair)iterator.next();
						methodUsage2 = methodUsage2.replaceTypeParameter((ResolvedTypeParameterDeclaration)pair.___003C_003Ea, (ResolvedType)pair.___003C_003Eb);
					}
					ResolvedType paramType2;
					for (int i = 0; i < methodUsage2.getNoParams(); i++)
					{
						paramType2 = methodUsage2.getParamType(i);
						if (paramType2.isWildcard())
						{
							ResolvedType boundedType = paramType2.asWildcard().getBoundedType();
							methodUsage2 = methodUsage2.replaceParamType(i, boundedType);
						}
					}
					ResolvedType actual = facade.toMethodUsage(node, methodUsage2.getParamTypes()).returnType();
					paramType2 = methodUsage2.returnType();
					InferenceContext inferenceContext = new InferenceContext(MyObjectProvider.___003C_003EINSTANCE);
					inferenceContext.addPair(paramType2, actual);
					paramType = inferenceContext.resolve(inferenceContext.addSingle(paramType));
				}
				return paramType;
			}
			ResolvedType type = ((ResolvedMethodDeclaration)symbolReference.getCorrespondingDeclaration()).getParam(paramPos).getType();
			
			return type;
		}
		
		throw new UnsupportedOperationException("The type of a method reference expr depends on the position and its return value");
	}

	
	
	public override ResolvedType visit(LambdaExpr node, java.lang.Boolean solveLambdas)
	{
		ResolvedType resolvedType;
		Expression expression;
		int num;
		if (Navigator.demandParentNode(node) is MethodCallExpr)
		{
			MethodCallExpr methodCallExpr = (MethodCallExpr)Navigator.demandParentNode(node);
			int paramPos = JavaParserSymbolDeclaration.getParamPos(node);
			SymbolReference symbolReference = facade.solve(methodCallExpr);
			if (!symbolReference.isSolved())
			{
				string name = Navigator.demandParentNode(node).ToString();
				string id = methodCallExpr.getName().getId();
				
				throw new UnsolvedSymbolException(name, id);
			}
			Log.trace("getType on lambda expr %s", new ___003C_003EAnon9(symbolReference));
			resolvedType = ((ResolvedMethodDeclaration)symbolReference.getCorrespondingDeclaration()).getParam(paramPos).getType();
			if (solveLambdas.booleanValue())
			{
				if (methodCallExpr.hasScope())
				{
					expression = (Expression)methodCallExpr.getScope().get();
					num = 0;
					if (expression is NameExpr)
					{
						NameExpr nameExpr = (NameExpr)expression;
						try
						{
							SymbolReference symbolReference2 = JavaParserFactory.getContext(nameExpr, typeSolver).solveType(nameExpr.getName().getId());
							if (symbolReference2.isSolved())
							{
								num = 1;
							}
						}
						catch (System.Exception x)
						{
							if (ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.Unused) == null)
							{
								throw;
							}
							goto IL_0109;
						}
					}
					goto IL_010f;
				}
				goto IL_0139;
			}
			goto IL_0142;
		}
		if (Navigator.demandParentNode(node) is VariableDeclarator)
		{
			VariableDeclarator variableDeclarator = (VariableDeclarator)Navigator.demandParentNode(node);
			ResolvedType resolvedType2 = variableDeclarator.getType().resolve();
			if (solveLambdas.booleanValue())
			{
				resolvedType2 = resolveLambda(node, resolvedType2);
			}
			return resolvedType2;
		}
		if (Navigator.demandParentNode(node) is AssignExpr)
		{
			AssignExpr assignExpr = (AssignExpr)Navigator.demandParentNode(node);
			ResolvedType resolvedType2 = assignExpr.calculateResolvedType();
			if (solveLambdas.booleanValue())
			{
				resolvedType2 = resolveLambda(node, resolvedType2);
			}
			return resolvedType2;
		}
		
		throw new UnsupportedOperationException("The type of a lambda expr depends on the position and its return value");
		IL_0139:
		resolvedType = resolveLambda(node, resolvedType);
		goto IL_0142;
		IL_0109:
		
		goto IL_010f;
		IL_010f:
		if (num == 0)
		{
			ResolvedType type = facade.getType(expression);
			if (type.isReferenceType())
			{
				resolvedType = type.asReferenceType().useThisTypeParametersOnTheGivenType(resolvedType);
			}
		}
		goto IL_0139;
		IL_0142:
		return resolvedType;
	}

	
	
	public override ResolvedType visit(VariableDeclarationExpr node, java.lang.Boolean solveLambdas)
	{
		if (node.getVariables().size() != 1)
		{
			
			throw new UnsupportedOperationException();
		}
		ResolvedType result = facade.convertToUsageVariableType((VariableDeclarator)node.getVariables().get(0));
		
		return result;
	}

	
	
	public override ResolvedType visit(UnaryExpr node, java.lang.Boolean solveLambdas)
	{
		switch (_1._0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024UnaryExpr_0024Operator[node.getOperator().ordinal()])
		{
		case 1:
		case 2:
		{
			ResolvedType result = ResolvedPrimitiveType.unp((ResolvedType)node.getExpression().accept(this, solveLambdas));
			
			return result;
		}
		case 3:
			return ResolvedPrimitiveType.___003C_003EBOOLEAN;
		case 4:
		case 5:
		case 6:
		case 7:
		case 8:
			return (ResolvedType)node.getExpression().accept(this, solveLambdas);
		default:
		{
			string message = node.getOperator().name();
			
			throw new UnsupportedOperationException(message);
		}
		}
	}

	
	
	public override ResolvedType visit(SuperExpr node, java.lang.Boolean solveLambdas)
	{
		if (node.getTypeName().isPresent())
		{
			string name = ((Name)node.getTypeName().get()).asString();
			SymbolReference symbolReference = JavaParserFactory.getContext(node, typeSolver).solveType(name);
			if (symbolReference.isSolved())
			{
				ResolvedTypeDeclaration resolvedTypeDeclaration = (ResolvedTypeDeclaration)symbolReference.getCorrespondingDeclaration();
				if (resolvedTypeDeclaration.isInterface())
				{
					ReferenceTypeImpl.___003Cclinit_003E();
					ReferenceTypeImpl result = new ReferenceTypeImpl(resolvedTypeDeclaration.asInterface(), typeSolver);
					
					return result;
				}
				if (resolvedTypeDeclaration.isClass())
				{
					return (ResolvedType)resolvedTypeDeclaration.asClass().getSuperClass().orElseThrow(new ___003C_003EAnon7());
				}
				string canonicalName = java.lang.Object.instancehelper_getClass(node).getCanonicalName();
				
				throw new UnsupportedOperationException(canonicalName);
			}
			
			throw new UnsolvedSymbolException(name);
		}
		ResolvedReferenceTypeDeclaration typeDeclaration = facade.getTypeDeclaration(facade.findContainingTypeDeclOrObjectCreationExpr(node));
		if (typeDeclaration is ResolvedClassDeclaration)
		{
			return (ResolvedType)((ResolvedClassDeclaration)typeDeclaration).getSuperClass().orElseThrow(new ___003C_003EAnon8());
		}
		string canonicalName2 = java.lang.Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName2);
	}

	
	
	public override ResolvedType visit(ThisExpr node, java.lang.Boolean solveLambdas)
	{
		//Discarded unreachable code: IL_0050
		if (node.getTypeName().isPresent())
		{
			string text = ((Name)node.getTypeName().get()).asString();
			try
			{
				ReferenceTypeImpl.___003Cclinit_003E();
				return new ReferenceTypeImpl(facade.getTypeDeclaration(facade.findContainingTypeDeclOrObjectCreationExpr(node, text)), typeSolver);
			}
			catch (IllegalStateException)
			{
			}
			
			node.findAncestor(new Class[1] { ClassLiteral<CompilationUnit>.Value });
			SymbolReference symbolReference = typeSolver.tryToSolveType(text);
			if (symbolReference.isSolved())
			{
				ReferenceTypeImpl.___003Cclinit_003E();
				return new ReferenceTypeImpl((ResolvedReferenceTypeDeclaration)symbolReference.getCorrespondingDeclaration(), typeSolver);
			}
		}
		ReferenceTypeImpl.___003Cclinit_003E();
		return new ReferenceTypeImpl(facade.getTypeDeclaration(facade.findContainingTypeDeclOrObjectCreationExpr(node)), typeSolver);
	}

	
	
	public override ResolvedType visit(ObjectCreationExpr node, java.lang.Boolean solveLambdas)
	{
		ResolvedType result = facade.convertToUsage(node.getType(), node);
		
		return result;
	}

	
	
	public override ResolvedType visit(NameExpr node, java.lang.Boolean solveLambdas)
	{
		Log.trace("getType on name expr %s", new ___003C_003EAnon5(node));
		Optional optional = new SymbolSolver(typeSolver).solveSymbolAsValue(node.getName().getId(), node);
		if (!optional.isPresent())
		{
			string name = new StringBuilder().append("Solving ").append(node).ToString();
			string id = node.getName().getId();
			
			throw new UnsolvedSymbolException(name, id);
		}
		ResolvedType type = ((Value)optional.get()).getType();
		
		return type;
	}

	
	
	public unsafe override ResolvedType visit(MethodCallExpr node, java.lang.Boolean solveLambdas)
	{
		Log.trace("getType on method call %s", new ___003C_003EAnon0(node));
		MethodUsage methodUsage = facade.solveMethodAsUsage(node);
		Log.trace("getType on method call %s resolved to %s", new ___003C_003EAnon1(node), new ___003C_003EAnon2(methodUsage));
		Supplier[] obj = new Supplier[2]
		{
			new ___003C_003EAnon3(node),
			null
		};
		
		obj[1] = new ___003C_003EAnon4(methodUsage);
		Log.trace("getType on method call %s return type is %s", obj);
		ResolvedType result = methodUsage.returnType();
		
		return result;
	}

	
	
	public override ResolvedType visit(NullLiteralExpr node, java.lang.Boolean solveLambdas)
	{
		return NullType.___003C_003EINSTANCE;
	}

	
	
	public override ResolvedType visit(BooleanLiteralExpr node, java.lang.Boolean solveLambdas)
	{
		return ResolvedPrimitiveType.___003C_003EBOOLEAN;
	}

	
	
	public override ResolvedType visit(DoubleLiteralExpr node, java.lang.Boolean solveLambdas)
	{
		if (java.lang.String.instancehelper_endsWith(java.lang.String.instancehelper_toLowerCase(node.getValue()), "f"))
		{
			return ResolvedPrimitiveType.___003C_003EFLOAT;
		}
		return ResolvedPrimitiveType.___003C_003EDOUBLE;
	}

	
	
	public override ResolvedType visit(CharLiteralExpr node, java.lang.Boolean solveLambdas)
	{
		return ResolvedPrimitiveType.___003C_003ECHAR;
	}

	
	
	public override ResolvedType visit(LongLiteralExpr node, java.lang.Boolean solveLambdas)
	{
		return ResolvedPrimitiveType.___003C_003ELONG;
	}

	
	
	public override ResolvedType visit(IntegerLiteralExpr node, java.lang.Boolean solveLambdas)
	{
		return ResolvedPrimitiveType.___003C_003EINT;
	}

	public override ResolvedType visit(StringLiteralExpr node, java.lang.Boolean solveLambdas)
	{
		return StringReferenceType;
	}

	
	
	public override ResolvedType visit(InstanceOfExpr node, java.lang.Boolean solveLambdas)
	{
		return ResolvedPrimitiveType.___003C_003EBOOLEAN;
	}

	
	
	public override ResolvedType visit(FieldAccessExpr node, java.lang.Boolean solveLambdas)
	{
		if (node.getScope() is NameExpr || node.getScope() is FieldAccessExpr)
		{
			Expression scope = node.getScope();
			SymbolReference symbolReference = JavaParserFactory.getContext(node, typeSolver).solveType(scope.ToString());
			if (symbolReference.isSolved())
			{
				return solveDotExpressionType(((ResolvedTypeDeclaration)symbolReference.getCorrespondingDeclaration()).asReferenceType(), node);
			}
		}
		else if (node.getScope() is ThisExpr)
		{
			SymbolReference symbolReference2 = facade.solve((ThisExpr)node.getScope());
			if (symbolReference2.isSolved())
			{
				ResolvedTypeDeclaration resolvedTypeDeclaration = (ResolvedTypeDeclaration)symbolReference2.getCorrespondingDeclaration();
				if (resolvedTypeDeclaration is ResolvedReferenceTypeDeclaration)
				{
					return solveDotExpressionType(resolvedTypeDeclaration.asReferenceType(), node);
				}
			}
		}
		else if (java.lang.String.instancehelper_indexOf(node.getScope().ToString(), 46) > 0)
		{
			SymbolReference symbolReference2 = typeSolver.tryToSolveType(node.getScope().ToString());
			if (symbolReference2.isSolved())
			{
				return solveDotExpressionType((ResolvedReferenceTypeDeclaration)symbolReference2.getCorrespondingDeclaration(), node);
			}
		}
		Optional optional = Optional.empty();
		try
		{
			optional = new SymbolSolver(typeSolver).solveSymbolAsValue(node.getName().getId(), node);
		}
		catch (UnsolvedSymbolException)
		{
			goto IL_0122;
		}
		goto IL_0161;
		IL_0161:
		if (optional.isPresent())
		{
			return ((Value)optional.get()).getType();
		}
		string id = node.getName().getId();
		
		throw new UnsolvedSymbolException(id);
		IL_0122:
		
		SymbolReference symbolReference3 = typeSolver.tryToSolveType(node.ToString());
		if (symbolReference3.isSolved())
		{
			ReferenceTypeImpl.___003Cclinit_003E();
			return new ReferenceTypeImpl((ResolvedReferenceTypeDeclaration)symbolReference3.getCorrespondingDeclaration(), typeSolver);
		}
		goto IL_0161;
	}

	
	
	public override ResolvedType visit(EnclosedExpr node, java.lang.Boolean solveLambdas)
	{
		return (ResolvedType)node.getInner().accept(this, solveLambdas);
	}

	
	
	public override ResolvedType visit(ConditionalExpr node, java.lang.Boolean solveLambdas)
	{
		//Discarded unreachable code: IL_0036
		ResolvedType thenExpr = (ResolvedType)node.getThenExpr().accept(this, solveLambdas);
		ResolvedType elseExpr = (ResolvedType)node.getElseExpr().accept(this, solveLambdas);
		ConditionalExprHandler conditionExprHandler = ConditionalExprResolver.getConditionExprHandler(thenExpr, elseExpr);
		try
		{
			return conditionExprHandler.resolveType();
		}
		catch (UnsupportedOperationException)
		{
		}
		
		return (ResolvedType)node.getThenExpr().accept(this, solveLambdas);
	}

	
	
	public override ResolvedType visit(ClassExpr node, java.lang.Boolean solveLambdas)
	{
		com.github.javaparser.ast.type.Type type = node.getType();
		ResolvedType element = facade.convertToUsage(type, node.getType());
		ReferenceTypeImpl.___003Cclinit_003E();
		ReferenceTypeImpl result = new ReferenceTypeImpl(new ReflectionClassDeclaration(ClassLiteral<Class>.Value, typeSolver), ImmutableList.of(element), typeSolver);
		
		return result;
	}

	
	
	public override ResolvedType visit(CastExpr node, java.lang.Boolean solveLambdas)
	{
		ResolvedType result = facade.convertToUsage(node.getType(), JavaParserFactory.getContext(node, typeSolver));
		
		return result;
	}

	
	
	public override ResolvedType visit(BinaryExpr node, java.lang.Boolean solveLambdas)
	{
		switch (_1._0024SwitchMap_0024com_0024github_0024javaparser_0024ast_0024expr_0024BinaryExpr_0024Operator[node.getOperator().ordinal()])
		{
		case 1:
		case 2:
		case 3:
		case 4:
		case 5:
		case 6:
		case 7:
		case 8:
		{
			ResolvedType binaryTypeConcrete = facade.getBinaryTypeConcrete(node.getLeft(), node.getRight(), solveLambdas.booleanValue(), node.getOperator());
			
			return binaryTypeConcrete;
		}
		case 9:
		case 10:
		case 11:
		case 12:
		case 13:
		case 14:
		case 15:
		case 16:
			return ResolvedPrimitiveType.___003C_003EBOOLEAN;
		case 17:
		case 18:
		case 19:
		{
			ResolvedType type = (ResolvedType)node.getLeft().accept(this, solveLambdas);
			ResolvedType result = ResolvedPrimitiveType.unp(type);
			
			return result;
		}
		default:
		{
			string message = new StringBuilder().append("Operator ").append(node.getOperator().name()).ToString();
			
			throw new UnsupportedOperationException(message);
		}
		}
	}

	
	
	public override ResolvedType visit(AssignExpr node, java.lang.Boolean solveLambdas)
	{
		return (ResolvedType)node.getTarget().accept(this, solveLambdas);
	}

	
	
	public override ResolvedType visit(ArrayInitializerExpr node, java.lang.Boolean solveLambdas)
	{
		string canonicalName = java.lang.Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public override ResolvedType visit(ArrayCreationExpr node, java.lang.Boolean solveLambdas)
	{
		object obj = facade.convertToUsage(node.getElementType(), JavaParserFactory.getContext(node, typeSolver));
		for (int i = 0; i < node.getLevels().size(); i++)
		{
			object obj2 = obj;
			obj = new ResolvedArrayType((obj2 == null) ? null : ((obj2 as ResolvedType) ?? throw new java.lang.IncompatibleClassChangeError()));
		}
		object obj3 = obj;
		return (obj3 == null) ? null : ((obj3 as ResolvedType) ?? throw new java.lang.IncompatibleClassChangeError());
	}

	
	
	public override ResolvedType visit(ArrayAccessExpr node, java.lang.Boolean solveLambdas)
	{
		ResolvedType resolvedType = (ResolvedType)node.getName().accept(this, solveLambdas);
		if (resolvedType.isArray())
		{
			ResolvedType componentType = ((ResolvedArrayType)resolvedType).getComponentType();
			
			return componentType;
		}
		return resolvedType;
	}

	
	
	public override ResolvedType visit(Parameter node, java.lang.Boolean solveLambdas)
	{
		if (node.getType() is UnknownType)
		{
			string s = new StringBuilder().append("Parameter has unknown type: ").append(node).ToString();
			
			throw new IllegalStateException(s);
		}
		ResolvedType result = facade.convertToUsage(node.getType(), node);
		
		return result;
	}

	
	
	public override ResolvedType visit(VariableDeclarator node, java.lang.Boolean solveLambdas)
	{
		if (Navigator.demandParentNode(node) is FieldDeclaration)
		{
			ResolvedType result = facade.convertToUsageVariableType(node);
			
			return result;
		}
		if (Navigator.demandParentNode(node) is VariableDeclarationExpr)
		{
			ResolvedType result2 = facade.convertToUsageVariableType(node);
			
			return result2;
		}
		string canonicalName = java.lang.Object.instancehelper_getClass(Navigator.demandParentNode(node)).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public override ResolvedType visit(FieldDeclaration node, java.lang.Boolean solveLambdas)
	{
		if (node.getVariables().size() == 1)
		{
			return (ResolvedType)((VariableDeclarator)node.getVariables().get(0)).accept(this, solveLambdas);
		}
		
		throw new IllegalArgumentException("Cannot resolve the type of a field with multiple variable declarations. Pick one");
	}

	
	private static object lambda_0024visit_00240(MethodCallExpr P_0)
	{
		return P_0;
	}

	
	private static object lambda_0024visit_00241(MethodCallExpr P_0)
	{
		return P_0;
	}

	
	private static object lambda_0024visit_00242(MethodUsage P_0)
	{
		return P_0;
	}

	
	private static object lambda_0024visit_00243(MethodCallExpr P_0)
	{
		return P_0;
	}

	
	private static object lambda_0024visit_00244(NameExpr P_0)
	{
		return P_0;
	}

	
	private static object lambda_0024visit_00245(TypeExpr P_0)
	{
		return P_0;
	}

	
	
	
	private static RuntimeException lambda_0024visit_00246()
	{
		RuntimeException result = new RuntimeException("super class unexpectedly empty");
		
		return result;
	}

	
	
	
	private static RuntimeException lambda_0024visit_00247()
	{
		RuntimeException result = new RuntimeException("super class unexpectedly empty");
		
		return result;
	}

	
	
	
	private static object lambda_0024visit_00248(SymbolReference P_0)
	{
		string name = ((ResolvedMethodDeclaration)P_0.getCorrespondingDeclaration()).getName();
		
		return name;
	}

	
	
	
	private ResolvedType lambda_0024resolveLambda_002410(ReturnStmt P_0)
	{
		return (ResolvedType)P_0.getExpression().map(new ___003C_003EAnon13(this)).orElse(ResolvedVoidType.___003C_003EINSTANCE);
	}

	
	
	
	private static bool lambda_0024resolveLambda_002411(ResolvedType P_0)
	{
		return (P_0 != null && !P_0.isVoid() && !P_0.isNull()) ? true : false;
	}

	
	
	
	private static object lambda_0024visit_002412(SymbolReference P_0)
	{
		string name = ((ResolvedMethodDeclaration)P_0.getCorrespondingDeclaration()).getName();
		
		return name;
	}

	
	
	
	private ResolvedType lambda_0024null_00249(Expression P_0)
	{
		ResolvedType type = facade.getType(P_0);
		
		return type;
	}

	
	
	private bool isCompatible(ResolvedType P_0, ResolvedPrimitiveType P_1)
	{
		return ((P_0.isPrimitive() && P_0.asPrimitive().equals(P_1)) || (P_0.isReferenceType() && P_0.asReferenceType().isUnboxableTo(P_1))) ? true : false;
	}

	
	
	
	
	public override object visit(TypeExpr te, object obj)
	{
		ResolvedType result = visit(te, (java.lang.Boolean)obj);
		
		return result;
	}

	
	
	
	
	public override object visit(MethodReferenceExpr mre, object obj)
	{
		ResolvedType result = visit(mre, (java.lang.Boolean)obj);
		
		return result;
	}

	
	
	
	
	public override object visit(LambdaExpr le, object obj)
	{
		ResolvedType result = visit(le, (java.lang.Boolean)obj);
		
		return result;
	}

	
	
	
	
	public override object visit(VariableDeclarationExpr vde, object obj)
	{
		ResolvedType result = visit(vde, (java.lang.Boolean)obj);
		
		return result;
	}

	
	
	
	
	public override object visit(UnaryExpr ue, object obj)
	{
		ResolvedType result = visit(ue, (java.lang.Boolean)obj);
		
		return result;
	}

	
	
	
	
	public override object visit(SuperExpr se, object obj)
	{
		ResolvedType result = visit(se, (java.lang.Boolean)obj);
		
		return result;
	}

	
	
	
	
	public override object visit(ThisExpr te, object obj)
	{
		ResolvedType result = visit(te, (java.lang.Boolean)obj);
		
		return result;
	}

	
	
	
	
	public override object visit(ObjectCreationExpr oce, object obj)
	{
		ResolvedType result = visit(oce, (java.lang.Boolean)obj);
		
		return result;
	}

	
	
	
	
	public override object visit(NameExpr ne, object obj)
	{
		ResolvedType result = visit(ne, (java.lang.Boolean)obj);
		
		return result;
	}

	
	
	
	
	public override object visit(MethodCallExpr mce, object obj)
	{
		ResolvedType result = visit(mce, (java.lang.Boolean)obj);
		
		return result;
	}

	
	
	
	
	public override object visit(NullLiteralExpr nle, object obj)
	{
		ResolvedType result = visit(nle, (java.lang.Boolean)obj);
		
		return result;
	}

	
	
	
	
	public override object visit(BooleanLiteralExpr ble, object obj)
	{
		ResolvedType result = visit(ble, (java.lang.Boolean)obj);
		
		return result;
	}

	
	
	
	
	public override object visit(DoubleLiteralExpr dle, object obj)
	{
		ResolvedType result = visit(dle, (java.lang.Boolean)obj);
		
		return result;
	}

	
	
	
	
	public override object visit(CharLiteralExpr cle, object obj)
	{
		ResolvedType result = visit(cle, (java.lang.Boolean)obj);
		
		return result;
	}

	
	
	
	
	public override object visit(LongLiteralExpr lle, object obj)
	{
		ResolvedType result = visit(lle, (java.lang.Boolean)obj);
		
		return result;
	}

	
	
	
	
	public override object visit(IntegerLiteralExpr ile, object obj)
	{
		ResolvedType result = visit(ile, (java.lang.Boolean)obj);
		
		return result;
	}

	
	
	
	
	public override object visit(StringLiteralExpr sle, object obj)
	{
		ResolvedType result = visit(sle, (java.lang.Boolean)obj);
		
		return result;
	}

	
	
	
	
	public override object visit(InstanceOfExpr ioe, object obj)
	{
		ResolvedType result = visit(ioe, (java.lang.Boolean)obj);
		
		return result;
	}

	
	
	
	
	public override object visit(FieldAccessExpr fae, object obj)
	{
		ResolvedType result = visit(fae, (java.lang.Boolean)obj);
		
		return result;
	}

	
	
	
	
	public override object visit(EnclosedExpr ee, object obj)
	{
		ResolvedType result = visit(ee, (java.lang.Boolean)obj);
		
		return result;
	}

	
	
	
	
	public override object visit(ConditionalExpr ce, object obj)
	{
		ResolvedType result = visit(ce, (java.lang.Boolean)obj);
		
		return result;
	}

	
	
	
	
	public override object visit(ClassExpr ce, object obj)
	{
		ResolvedType result = visit(ce, (java.lang.Boolean)obj);
		
		return result;
	}

	
	
	
	
	public override object visit(CastExpr ce, object obj)
	{
		ResolvedType result = visit(ce, (java.lang.Boolean)obj);
		
		return result;
	}

	
	
	
	
	public override object visit(BinaryExpr be, object obj)
	{
		ResolvedType result = visit(be, (java.lang.Boolean)obj);
		
		return result;
	}

	
	
	
	
	public override object visit(AssignExpr ae, object obj)
	{
		ResolvedType result = visit(ae, (java.lang.Boolean)obj);
		
		return result;
	}

	
	
	
	
	public override object visit(ArrayInitializerExpr aie, object obj)
	{
		ResolvedType result = visit(aie, (java.lang.Boolean)obj);
		
		return result;
	}

	
	
	
	
	public override object visit(ArrayCreationExpr ace, object obj)
	{
		ResolvedType result = visit(ace, (java.lang.Boolean)obj);
		
		return result;
	}

	
	
	
	
	public override object visit(ArrayAccessExpr aae, object obj)
	{
		ResolvedType result = visit(aae, (java.lang.Boolean)obj);
		
		return result;
	}

	
	
	
	
	public override object visit(Parameter p, object obj)
	{
		ResolvedType result = visit(p, (java.lang.Boolean)obj);
		
		return result;
	}

	
	
	
	
	public override object visit(VariableDeclarator vd, object obj)
	{
		ResolvedType result = visit(vd, (java.lang.Boolean)obj);
		
		return result;
	}

	
	
	
	
	public override object visit(FieldDeclaration fd, object obj)
	{
		ResolvedType result = visit(fd, (java.lang.Boolean)obj);
		
		return result;
	}

	
	static TypeExtractor()
	{
		JAVA_LANG_STRING = ClassLiteral<java.lang.String>.Value.getCanonicalName();
	}
}
