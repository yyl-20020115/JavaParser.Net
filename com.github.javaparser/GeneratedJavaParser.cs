using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.modules;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.type;
using com.github.javaparser.utils;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;

namespace com.github.javaparser;


internal class GeneratedJavaParser : GeneratedJavaParserBase, GeneratedJavaParserConstants
{
	internal class _1
	{
		_1()
		{
			throw null;
		}
	}

	internal sealed class JJCalls
	{
		internal int gen;

		internal Token first;

		internal int arg;

		internal JJCalls next;

		
		
		internal JJCalls()
		{
		}
	}

	[Serializable]
	[InnerClass(null, IKVM.Attributes.Modifiers.Private | IKVM.Attributes.Modifiers.Static | IKVM.Attributes.Modifiers.Final)]
	internal sealed class LookaheadSuccess : IllegalStateException
	{
		
		
		
		internal LookaheadSuccess(_1 P_0)
			: this()
		{
		}

		
		
		private LookaheadSuccess()
		{
		}

		
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected LookaheadSuccess(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	public GeneratedJavaParserTokenManager token_source;

	internal SimpleCharStream jj_input_stream;

	public new Token token;

	public Token jj_nt;

	private int jj_ntk;

	private Token jj_scanpos;

	private Token jj_lastpos;

	private int jj_la;

	private bool jj_lookingAhead;

	private bool jj_semLA;

	private int jj_gen;

	
	private int[] jj_la1;

	private static int[] jj_la1_0;

	private static int[] jj_la1_1;

	private static int[] jj_la1_2;

	private static int[] jj_la1_3;

	private static int[] jj_la1_4;

	
	private JJCalls[] jj_2_rtns;

	private bool jj_rescan;

	private int jj_gc;

	
	private LookaheadSuccess jj_ls;

		private List jj_expentries;

	private int[] jj_expentry;

	private int jj_kind;

	private int[] jj_lasttokens;

	private int jj_endpos;

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 32, 33, 103, 108, 108, 147, 78, 8, 100,
		103, 75, 34
	})]
	private bool jj_2_1(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_1()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003d;
			}
		}
		catch
		{
			//try-fault
			jj_save(0, xla);
			throw;
		}
		jj_save(0, xla);
		return (byte)result != 0;
		IL_003d:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(0, xla);
		}
	}

	
	
	
	[LineNumberTable(new byte[]
	{
		208, 52, 103, 103, 109, 147, 118, 145, 103, 113,
		110, 119, 103, 108, 106, 100, 111, 104, 235, 59,
		230, 73, 135, 103, 103
	})]
	private Token jj_consume_token(int kind)
	{
		Token token = this.token;
		if (this.token.next != null)
		{
			this.token = this.token.next;
		}
		else
		{
			this.token.next = token_source.getNextToken();
			this.token = this.token.next;
		}
		jj_ntk = -1;
		if (this.token.kind == kind)
		{
			jj_gen++;
			int num = jj_gc + 1;
			jj_gc = num;
			if (num > 100)
			{
				jj_gc = 0;
				for (int i = 0; i < (nint)jj_2_rtns.LongLength; i++)
				{
					for (JJCalls jJCalls = jj_2_rtns[i]; jJCalls != null; jJCalls = jJCalls.next)
					{
						if (jJCalls.gen < jj_gen)
						{
							jJCalls.first = null;
						}
					}
				}
			}
			return this.token;
		}
		this.token = token;
		jj_kind = kind;
		throw Throwable.___003Cunmap_003E(generateParseException());
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 32, 43, 103, 108, 108, 147, 78, 8, 100,
		103, 75, 34
	})]
	private bool jj_2_2(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_2()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003d;
			}
		}
		catch
		{
			//try-fault
			jj_save(1, xla);
			throw;
		}
		jj_save(1, xla);
		return (byte)result != 0;
		IL_003d:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(1, xla);
		}
	}

	
	
	
	public PackageDeclaration PackageDeclaration()
	{
		new NodeList();
		NodeList annotations = Annotations();
		jj_consume_token(44);
		JavaToken begin = token();
		Name name = Name();
		jj_consume_token(103);
		if ("" != null)
		{
			com.github.javaparser.ast.PackageDeclaration.___003Cclinit_003E();
			PackageDeclaration result = new PackageDeclaration(base.range(begin, token()), annotations, name);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	private int jj_ntk_f()
	{
		Token next = this.token.next;
		jj_nt = next;
		Token token = next;
		int kind;
		if (token == null)
		{
			this.token.next = token_source.getNextToken();
			kind = this.token.next.kind;
			int result = kind;
			jj_ntk = kind;
			return result;
		}
		kind = token.kind;
		int result2 = kind;
		jj_ntk = kind;
		return result2;
	}

	
	
	[LineNumberTable(new byte[]
	{
		160, 147, 98, 130, 105, 103, 159, 3, 105, 98,
		162, 174, 103, 159, 3, 105, 105, 98, 162, 174,
		105, 127, 5
	})]
	public ImportDeclaration ImportDeclaration()
	{
		int isStatic = 0;
		int isAsterisk = 0;
		jj_consume_token(36);
		JavaToken begin = token();
		if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 51)
		{
			jj_consume_token(51);
			isStatic = 1;
		}
		else
		{
			jj_la1[4] = jj_gen;
		}
		Name name = Name();
		if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 105)
		{
			jj_consume_token(105);
			jj_consume_token(126);
			isAsterisk = 1;
		}
		else
		{
			jj_la1[5] = jj_gen;
		}
		jj_consume_token(103);
		if ("" != null)
		{
			com.github.javaparser.ast.ImportDeclaration.___003Cclinit_003E();
			ImportDeclaration result = new ImportDeclaration(base.range(begin, token()), name, (byte)isStatic != 0, (byte)isAsterisk != 0);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		160, 211, 102, 102, 198, 204, 159, 160, 85, 105,
		127, 12, 165, 105, 127, 12, 165, 105, 127, 12,
		165, 105, 127, 12, 165, 105, 127, 12, 165, 105,
		127, 12, 165, 105, 127, 12, 165, 105, 127, 12,
		165, 105, 127, 12, 165, 105, 127, 12, 165, 105,
		127, 12, 165, 105, 127, 12, 165, 105, 127, 12,
		165, 103, 114, 165, 110, 104, 171, 114
	})]
	public ModifierHolder Modifiers()
	{
		JavaToken javaToken = JavaToken.___003C_003EINVALID;
		NodeList nodeList = new NodeList();
		NodeList nodeList2 = new NodeList();
		while (jj_2_3(2))
		{
			switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
			{
			case 47:
				jj_consume_token(47);
				Modifier.___003Cclinit_003E();
				base.add(nodeList, new Modifier(base.tokenRange(), Modifier.Keyword.___003C_003EPUBLIC));
				javaToken = base.orIfInvalid(javaToken, token());
				break;
			case 51:
				jj_consume_token(51);
				Modifier.___003Cclinit_003E();
				base.add(nodeList, new Modifier(base.tokenRange(), Modifier.Keyword.___003C_003ESTATIC));
				javaToken = base.orIfInvalid(javaToken, token());
				break;
			case 46:
				jj_consume_token(46);
				Modifier.___003Cclinit_003E();
				base.add(nodeList, new Modifier(base.tokenRange(), Modifier.Keyword.___003C_003EPROTECTED));
				javaToken = base.orIfInvalid(javaToken, token());
				break;
			case 45:
				jj_consume_token(45);
				Modifier.___003Cclinit_003E();
				base.add(nodeList, new Modifier(base.tokenRange(), Modifier.Keyword.___003C_003EPRIVATE));
				javaToken = base.orIfInvalid(javaToken, token());
				break;
			case 29:
				jj_consume_token(29);
				Modifier.___003Cclinit_003E();
				base.add(nodeList, new Modifier(base.tokenRange(), Modifier.Keyword.___003C_003EFINAL));
				javaToken = base.orIfInvalid(javaToken, token());
				break;
			case 11:
				jj_consume_token(11);
				Modifier.___003Cclinit_003E();
				base.add(nodeList, new Modifier(base.tokenRange(), Modifier.Keyword.___003C_003EABSTRACT));
				javaToken = base.orIfInvalid(javaToken, token());
				break;
			case 55:
				jj_consume_token(55);
				Modifier.___003Cclinit_003E();
				base.add(nodeList, new Modifier(base.tokenRange(), Modifier.Keyword.___003C_003ESYNCHRONIZED));
				javaToken = base.orIfInvalid(javaToken, token());
				break;
			case 41:
				jj_consume_token(41);
				Modifier.___003Cclinit_003E();
				base.add(nodeList, new Modifier(base.tokenRange(), Modifier.Keyword.___003C_003ENATIVE));
				javaToken = base.orIfInvalid(javaToken, token());
				break;
			case 59:
				jj_consume_token(59);
				Modifier.___003Cclinit_003E();
				base.add(nodeList, new Modifier(base.tokenRange(), Modifier.Keyword.___003C_003ETRANSIENT));
				javaToken = base.orIfInvalid(javaToken, token());
				break;
			case 63:
				jj_consume_token(63);
				Modifier.___003Cclinit_003E();
				base.add(nodeList, new Modifier(base.tokenRange(), Modifier.Keyword.___003C_003EVOLATILE));
				javaToken = base.orIfInvalid(javaToken, token());
				break;
			case 52:
				jj_consume_token(52);
				Modifier.___003Cclinit_003E();
				base.add(nodeList, new Modifier(base.tokenRange(), Modifier.Keyword.___003C_003ESTRICTFP));
				javaToken = base.orIfInvalid(javaToken, token());
				break;
			case 75:
				jj_consume_token(75);
				Modifier.___003Cclinit_003E();
				base.add(nodeList, new Modifier(base.tokenRange(), Modifier.Keyword.___003C_003ETRANSITIVE));
				javaToken = base.orIfInvalid(javaToken, token());
				break;
			case 22:
				jj_consume_token(22);
				Modifier.___003Cclinit_003E();
				base.add(nodeList, new Modifier(base.tokenRange(), Modifier.Keyword.___003C_003EDEFAULT));
				javaToken = base.orIfInvalid(javaToken, token());
				break;
			case 107:
			{
				AnnotationExpr annotationExpr = Annotation();
				nodeList2 = base.add(nodeList2, annotationExpr);
				javaToken = base.orIfInvalid(javaToken, annotationExpr);
				break;
			}
			default:
				jj_la1[6] = jj_gen;
				jj_consume_token(-1);
				
				throw new ParseException();
			}
		}
		if ("" != null)
		{
			ModifierHolder result = new ModifierHolder(javaToken, nodeList, nodeList2);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	
	[LineNumberTable(new byte[]
	{
		161, 80, 108, 103, 103, 103, 103, 159, 11, 105,
		99, 162, 105, 99, 162, 110, 104, 139, 110, 104,
		159, 3, 103, 162, 174, 159, 3, 103, 162, 175,
		159, 3, 103, 162, 175, 104, 127, 28
	})]
	public ClassOrInterfaceDeclaration ClassOrInterfaceDeclaration(ModifierHolder modifier)
	{
		RangedList rangedList = new RangedList(base.emptyNodeList());
		NodeList extendedTypes = base.emptyNodeList();
		NodeList implementedTypes = base.emptyNodeList();
		base.emptyNodeList();
		JavaToken begin = modifier.begin;
		int isInterface;
		switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
		{
		case 19:
			jj_consume_token(19);
			isInterface = 0;
			break;
		case 39:
			jj_consume_token(39);
			isInterface = 1;
			break;
		default:
			jj_la1[7] = jj_gen;
			jj_consume_token(-1);
			
			throw new ParseException();
		}
		begin = base.orIfInvalid(begin, token());
		SimpleName name = SimpleName();
		if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 110)
		{
			rangedList = TypeParameters();
		}
		else
		{
			jj_la1[8] = jj_gen;
		}
		if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 27)
		{
			extendedTypes = ExtendsList();
		}
		else
		{
			jj_la1[9] = jj_gen;
		}
		if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 35)
		{
			implementedTypes = ImplementsList();
		}
		else
		{
			jj_la1[10] = jj_gen;
		}
		NodeList members = ClassOrInterfaceBody();
		if ("" != null)
		{
			com.github.javaparser.ast.body.ClassOrInterfaceDeclaration.___003Cclinit_003E();
			ClassOrInterfaceDeclaration result = new ClassOrInterfaceDeclaration(base.range(begin, token()), modifier.modifiers, modifier.annotations, (byte)isInterface != 0, name, rangedList.list, extendedTypes, implementedTypes, members);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	
	[LineNumberTable(new byte[]
	{
		161, 169, 108, 103, 103, 103, 105, 110, 103, 159,
		3, 103, 162, 175, 104, 159, 3, 103, 162, 175,
		104, 127, 48
	})]
	public RecordDeclaration RecordDeclaration(ModifierHolder modifier)
	{
		RangedList rangedList = new RangedList(base.emptyNodeList());
		NodeList implementedTypes = base.emptyNodeList();
		base.emptyNodeList();
		JavaToken begin = modifier.begin;
		jj_consume_token(48);
		begin = base.orIfInvalid(begin, token());
		SimpleName name = SimpleName();
		if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 110)
		{
			rangedList = TypeParameters();
		}
		else
		{
			jj_la1[11] = jj_gen;
		}
		Pair pair = Parameters();
		if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 35)
		{
			implementedTypes = ImplementsList();
		}
		else
		{
			jj_la1[12] = jj_gen;
		}
		NodeList members = RecordBody();
		if ("" != null)
		{
			com.github.javaparser.ast.body.RecordDeclaration.___003Cclinit_003E();
			RecordDeclaration result = new RecordDeclaration(base.range(begin, token()), modifier.modifiers, modifier.annotations, name, (NodeList)pair.___003C_003Ea, rangedList.list, implementedTypes, members, (ReceiverParameter)pair.___003C_003Eb);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	
	[LineNumberTable(new byte[]
	{
		162,
		57,
		135,
		135,
		103,
		103,
		105,
		110,
		104,
		159,
		3,
		103,
		162,
		175,
		105,
		byte.MaxValue,
		160,
		80,
		81,
		104,
		169,
		201,
		105,
		104,
		235,
		69,
		175,
		159,
		3,
		105,
		162,
		175,
		159,
		6,
		169,
		byte.MaxValue,
		161,
		82,
		106,
		162,
		111,
		133,
		byte.MaxValue,
		161,
		82,
		105,
		104,
		106,
		165,
		105,
		165,
		111,
		104,
		235,
		70,
		175,
		105,
		127,
		19
	})]
	public EnumDeclaration EnumDeclaration(ModifierHolder modifier)
	{
		NodeList implementedTypes = base.emptyNodeList();
		NodeList nodeList = base.emptyNodeList();
		NodeList nodeList2 = base.emptyNodeList();
		JavaToken begin = modifier.begin;
		jj_consume_token(26);
		begin = base.orIfInvalid(begin, token());
		SimpleName name = SimpleName();
		if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 35)
		{
			implementedTypes = ImplementsList();
		}
		else
		{
			jj_la1[15] = jj_gen;
		}
		jj_consume_token(99);
		int num = ((jj_ntk != -1) ? jj_ntk : jj_ntk_f());
		if (num == 26 || num == 48 || num == 52 || num == 65 || num == 66 || num == 67 || num == 68 || num == 69 || num == 70 || num == 71 || num == 72 || num == 73 || num == 74 || num == 75 || num == 94 || num == 107)
		{
			EnumConstantDeclaration node = EnumConstantDeclaration();
			nodeList.add(node);
			while (jj_2_4(2))
			{
				jj_consume_token(104);
				node = EnumConstantDeclaration();
				nodeList.add(node);
			}
		}
		else
		{
			jj_la1[16] = jj_gen;
		}
		if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 104)
		{
			jj_consume_token(104);
		}
		else
		{
			jj_la1[17] = jj_gen;
		}
		if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 103)
		{
			jj_consume_token(103);
			while (true)
			{
				switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
				{
				case 11:
				case 13:
				case 15:
				case 18:
				case 19:
				case 22:
				case 24:
				case 26:
				case 29:
				case 31:
				case 38:
				case 39:
				case 40:
				case 41:
				case 45:
				case 46:
				case 47:
				case 48:
				case 50:
				case 51:
				case 52:
				case 55:
				case 59:
				case 62:
				case 63:
				case 65:
				case 66:
				case 67:
				case 68:
				case 69:
				case 70:
				case 71:
				case 72:
				case 73:
				case 74:
				case 75:
				case 94:
				case 99:
				case 103:
				case 107:
				case 110:
					switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
					{
					case 11:
					case 13:
					case 15:
					case 18:
					case 19:
					case 22:
					case 24:
					case 26:
					case 29:
					case 31:
					case 38:
					case 39:
					case 40:
					case 41:
					case 45:
					case 46:
					case 47:
					case 48:
					case 50:
					case 51:
					case 52:
					case 55:
					case 59:
					case 62:
					case 63:
					case 65:
					case 66:
					case 67:
					case 68:
					case 69:
					case 70:
					case 71:
					case 72:
					case 73:
					case 74:
					case 75:
					case 94:
					case 99:
					case 107:
					case 110:
					{
						BodyDeclaration obj = ClassOrInterfaceBodyDeclaration();
						nodeList2 = base.add(nodeList2, obj);
						break;
					}
					case 103:
						jj_consume_token(103);
						break;
					default:
						jj_la1[19] = jj_gen;
						jj_consume_token(-1);
						
						throw new ParseException();
					}
					continue;
				}
				break;
			}
			jj_la1[18] = jj_gen;
		}
		else
		{
			jj_la1[20] = jj_gen;
		}
		jj_consume_token(100);
		if ("" != null)
		{
			com.github.javaparser.ast.body.EnumDeclaration.___003Cclinit_003E();
			EnumDeclaration result = new EnumDeclaration(base.range(begin, token()), modifier.modifiers, modifier.annotations, name, implementedTypes, nodeList, nodeList2);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	
	[LineNumberTable(new byte[]
	{
		189, 90, 103, 103, 105, 110, 105, 103, 103, 127,
		16
	})]
	public AnnotationDeclaration AnnotationTypeDeclaration(ModifierHolder modifier)
	{
		base.emptyNodeList();
		JavaToken begin = modifier.begin;
		jj_consume_token(107);
		begin = base.orIfInvalid(begin, token());
		jj_consume_token(39);
		SimpleName name = SimpleName();
		NodeList members = AnnotationTypeBody();
		if ("" != null)
		{
			AnnotationDeclaration.___003Cclinit_003E();
			AnnotationDeclaration result = new AnnotationDeclaration(base.range(begin, token()), modifier.modifiers, modifier.annotations, name, members);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	
	[LineNumberTable(new byte[]
	{
		191,
		21,
		102,
		162,
		103,
		159,
		3,
		105,
		112,
		162,
		178,
		105,
		110,
		103,
		169,
		byte.MaxValue,
		38,
		70,
		162,
		114,
		130,
		104,
		143,
		105,
		127,
		11
	})]
	public ModuleDeclaration ModuleDeclaration(ModifierHolder modifier)
	{
		NodeList nodeList = new NodeList();
		int isOpen = 0;
		JavaToken firstChoice = modifier.begin;
		if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 69)
		{
			jj_consume_token(69);
			isOpen = 1;
			firstChoice = base.orIfInvalid(firstChoice, token());
		}
		else
		{
			jj_la1[177] = jj_gen;
		}
		jj_consume_token(72);
		firstChoice = base.orIfInvalid(firstChoice, token());
		Name name = Name();
		jj_consume_token(99);
		while (true)
		{
			switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
			{
			default:
				jj_la1[178] = jj_gen;
				jj_consume_token(100);
				if ("" != null)
				{
					com.github.javaparser.ast.modules.ModuleDeclaration.___003Cclinit_003E();
					ModuleDeclaration result = new ModuleDeclaration(base.range(firstChoice, token()), modifier.annotations, name, (byte)isOpen != 0, nodeList);
					
					return result;
				}
				
				throw new IllegalStateException("Missing return statement in function");
			case 66:
			case 70:
			case 71:
			case 73:
			case 74:
				break;
			}
			ModuleDirective obj = ModuleDirective();
			nodeList = base.add(nodeList, obj);
		}
	}

	
	internal override JavaToken getToken()
	{
		return this.token.javaToken;
	}

	
	
		
	public NodeList Annotations()
	{
		NodeList nodeList = new NodeList();
		while (jj_2_61(int.MaxValue))
		{
			AnnotationExpr obj = Annotation();
			nodeList = base.add(nodeList, obj);
		}
		if ("" != null)
		{
			return nodeList;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	
	public Name Name()
	{
		Identifier();
		com.github.javaparser.ast.expr.Name.___003Cclinit_003E();
		Name name = new Name(base.tokenRange(), null, this.token.image);
		while (jj_2_31(2))
		{
			jj_consume_token(105);
			Identifier();
			com.github.javaparser.ast.expr.Name.___003Cclinit_003E();
			name = new Name(base.range(name, token()), name, this.token.image);
		}
		if ("" != null)
		{
			return name;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 32, 53, 103, 108, 108, 147, 78, 8, 100,
		103, 75, 34
	})]
	private bool jj_2_3(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_3()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003d;
			}
		}
		catch
		{
			//try-fault
			jj_save(2, xla);
			throw;
		}
		jj_save(2, xla);
		return (byte)result != 0;
		IL_003d:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(2, xla);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		188,
		50,
		167,
		105,
		103,
		103,
		112,
		105,
		byte.MaxValue,
		160,
		69,
		80,
		103,
		162,
		178,
		105,
		124,
		109,
		105,
		104,
		105,
		157,
		153,
		105
	})]
	public AnnotationExpr Annotation()
	{
		NodeList pairs = base.emptyNodeList();
		jj_consume_token(107);
		JavaToken begin = token();
		Name name = Name();
		AnnotationExpr result;
		if (jj_2_62(int.MaxValue))
		{
			jj_consume_token(97);
			int num = ((jj_ntk != -1) ? jj_ntk : jj_ntk_f());
			if (num == 26 || num == 48 || num == 52 || num == 65 || num == 66 || num == 67 || num == 68 || num == 69 || num == 70 || num == 71 || num == 72 || num == 73 || num == 74 || num == 75 || num == 94)
			{
				pairs = MemberValuePairs();
			}
			else
			{
				jj_la1[161] = jj_gen;
			}
			jj_consume_token(98);
			NormalAnnotationExpr.___003Cclinit_003E();
			result = new NormalAnnotationExpr(base.range(begin, token()), name, pairs);
		}
		else if (jj_2_63(int.MaxValue))
		{
			jj_consume_token(97);
			Expression memberValue = MemberValue();
			jj_consume_token(98);
			SingleMemberAnnotationExpr.___003Cclinit_003E();
			result = new SingleMemberAnnotationExpr(base.range(begin, token()), name, memberValue);
		}
		else
		{
			MarkerAnnotationExpr.___003Cclinit_003E();
			result = new MarkerAnnotationExpr(base.range(begin, token()), name);
		}
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	
	public SimpleName SimpleName()
	{
		Identifier();
		com.github.javaparser.ast.expr.SimpleName.___003Cclinit_003E();
		SimpleName result = new SimpleName(base.tokenRange(), this.token.image);
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
		[LineNumberTable(new byte[]
	{
		163, 66, 171, 105, 108, 103, 104, 169, 159, 3,
		162, 111, 130, 105, 103, 104, 139, 108, 108, 105
	})]
	public RangedList TypeParameters()
	{
		RangedList rangedList = new RangedList(new NodeList());
		jj_consume_token(110);
		rangedList.beginAt(token());
		NodeList annotations = Annotations();
		TypeParameter t = TypeParameter(annotations);
		rangedList.add(t);
		
		while (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 104)
		{
			jj_consume_token(104);
			annotations = Annotations();
			t = TypeParameter(annotations);
			rangedList.add(t);
			
		}
		jj_la1[24] = jj_gen;
		jj_consume_token(146);
		rangedList.endAt(token());
		if ("" != null)
		{
			return rangedList;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
		[LineNumberTable(new byte[]
	{
		161, 220, 98, 134, 105, 103, 168, 159, 3, 162,
		111, 130, 105, 103, 140, 105
	})]
	public NodeList ExtendsList()
	{
		_ = 0;
		NodeList nodeList = new NodeList();
		jj_consume_token(27);
		ClassOrInterfaceType node = AnnotatedClassOrInterfaceType();
		nodeList.add(node);
		while (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 104)
		{
			jj_consume_token(104);
			node = AnnotatedClassOrInterfaceType();
			nodeList.add(node);
			_ = 1;
		}
		jj_la1[13] = jj_gen;
		if ("" != null)
		{
			return nodeList;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
		[LineNumberTable(new byte[]
	{
		162, 10, 134, 105, 103, 168, 159, 3, 162, 111,
		130, 105, 103, 138, 105
	})]
	public NodeList ImplementsList()
	{
		NodeList nodeList = new NodeList();
		jj_consume_token(35);
		ClassOrInterfaceType node = AnnotatedClassOrInterfaceType();
		nodeList.add(node);
		while (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 104)
		{
			jj_consume_token(104);
			node = AnnotatedClassOrInterfaceType();
			nodeList.add(node);
		}
		jj_la1[14] = jj_gen;
		if ("" != null)
		{
			return nodeList;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
		[LineNumberTable(new byte[]
	{
		163,
		207,
		135,
		169,
		byte.MaxValue,
		161,
		82,
		106,
		162,
		111,
		133,
		byte.MaxValue,
		161,
		82,
		105,
		103,
		104,
		165,
		105,
		165,
		111,
		104,
		171,
		105,
		105
	})]
	public NodeList ClassOrInterfaceBody()
	{
		NodeList nodeList = base.emptyNodeList();
		jj_consume_token(99);
		while (true)
		{
			switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
			{
			default:
				jj_la1[27] = jj_gen;
				jj_consume_token(100);
				if ("" != null)
				{
					return nodeList;
				}
				
				throw new IllegalStateException("Missing return statement in function");
			case 11:
			case 13:
			case 15:
			case 18:
			case 19:
			case 22:
			case 24:
			case 26:
			case 29:
			case 31:
			case 38:
			case 39:
			case 40:
			case 41:
			case 45:
			case 46:
			case 47:
			case 48:
			case 50:
			case 51:
			case 52:
			case 55:
			case 59:
			case 62:
			case 63:
			case 65:
			case 66:
			case 67:
			case 68:
			case 69:
			case 70:
			case 71:
			case 72:
			case 73:
			case 74:
			case 75:
			case 94:
			case 99:
			case 103:
			case 107:
			case 110:
				switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
				{
				case 11:
				case 13:
				case 15:
				case 18:
				case 19:
				case 22:
				case 24:
				case 26:
				case 29:
				case 31:
				case 38:
				case 39:
				case 40:
				case 41:
				case 45:
				case 46:
				case 47:
				case 48:
				case 50:
				case 51:
				case 52:
				case 55:
				case 59:
				case 62:
				case 63:
				case 65:
				case 66:
				case 67:
				case 68:
				case 69:
				case 70:
				case 71:
				case 72:
				case 73:
				case 74:
				case 75:
				case 94:
				case 99:
				case 107:
				case 110:
				{
					BodyDeclaration node = ClassOrInterfaceBodyDeclaration();
					nodeList.add(node);
					break;
				}
				case 103:
					jj_consume_token(103);
					break;
				default:
					jj_la1[28] = jj_gen;
					jj_consume_token(-1);
					
					throw new ParseException();
				}
				break;
			}
		}
	}

	
	
		[LineNumberTable(new byte[]
	{
		167,
		221,
		135,
		98,
		105,
		byte.MaxValue,
		161,
		73,
		100,
		109,
		140,
		byte.MaxValue,
		161,
		70,
		100,
		103,
		105,
		162,
		111,
		104,
		235,
		69,
		159,
		3,
		162,
		111,
		130,
		105,
		103,
		235,
		69,
		175,
		105,
		113
	})]
	public Pair Parameters()
	{
		NodeList nodeList = base.emptyNodeList();
		ReceiverParameter b = null;
		jj_consume_token(97);
		switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
		{
		case 11:
		case 13:
		case 15:
		case 18:
		case 22:
		case 24:
		case 26:
		case 29:
		case 31:
		case 38:
		case 40:
		case 41:
		case 45:
		case 46:
		case 47:
		case 48:
		case 50:
		case 51:
		case 52:
		case 55:
		case 59:
		case 63:
		case 65:
		case 66:
		case 67:
		case 68:
		case 69:
		case 70:
		case 71:
		case 72:
		case 73:
		case 74:
		case 75:
		case 94:
		case 107:
			if (jj_2_19(int.MaxValue))
			{
				b = ReceiverParameter();
			}
			else
			{
				switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
				{
				case 11:
				case 13:
				case 15:
				case 18:
				case 22:
				case 24:
				case 26:
				case 29:
				case 31:
				case 38:
				case 40:
				case 41:
				case 45:
				case 46:
				case 47:
				case 48:
				case 50:
				case 51:
				case 52:
				case 55:
				case 59:
				case 63:
				case 65:
				case 66:
				case 67:
				case 68:
				case 69:
				case 70:
				case 71:
				case 72:
				case 73:
				case 74:
				case 75:
				case 94:
				case 107:
					break;
				default:
					jj_la1[51] = jj_gen;
					jj_consume_token(-1);
					
					throw new ParseException();
				}
				Parameter obj = Parameter();
				nodeList = base.add(nodeList, obj);
			}
			while (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 104)
			{
				jj_consume_token(104);
				Parameter obj = Parameter();
				nodeList = base.add(nodeList, obj);
			}
			jj_la1[52] = jj_gen;
			break;
		default:
			jj_la1[53] = jj_gen;
			break;
		}
		jj_consume_token(98);
		if ("" != null)
		{
			Pair result = new Pair(nodeList, b);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
		[LineNumberTable(new byte[]
	{
		164,
		74,
		135,
		169,
		byte.MaxValue,
		161,
		82,
		106,
		162,
		111,
		133,
		byte.MaxValue,
		161,
		82,
		105,
		103,
		104,
		165,
		105,
		165,
		111,
		104,
		171,
		105,
		105
	})]
	public NodeList RecordBody()
	{
		NodeList nodeList = base.emptyNodeList();
		jj_consume_token(99);
		while (true)
		{
			switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
			{
			default:
				jj_la1[29] = jj_gen;
				jj_consume_token(100);
				if ("" != null)
				{
					return nodeList;
				}
				
				throw new IllegalStateException("Missing return statement in function");
			case 11:
			case 13:
			case 15:
			case 18:
			case 19:
			case 22:
			case 24:
			case 26:
			case 29:
			case 31:
			case 38:
			case 39:
			case 40:
			case 41:
			case 45:
			case 46:
			case 47:
			case 48:
			case 50:
			case 51:
			case 52:
			case 55:
			case 59:
			case 62:
			case 63:
			case 65:
			case 66:
			case 67:
			case 68:
			case 69:
			case 70:
			case 71:
			case 72:
			case 73:
			case 74:
			case 75:
			case 94:
			case 99:
			case 103:
			case 107:
			case 110:
				switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
				{
				case 11:
				case 13:
				case 15:
				case 18:
				case 19:
				case 22:
				case 24:
				case 26:
				case 29:
				case 31:
				case 38:
				case 39:
				case 40:
				case 41:
				case 45:
				case 46:
				case 47:
				case 48:
				case 50:
				case 51:
				case 52:
				case 55:
				case 59:
				case 62:
				case 63:
				case 65:
				case 66:
				case 67:
				case 68:
				case 69:
				case 70:
				case 71:
				case 72:
				case 73:
				case 74:
				case 75:
				case 94:
				case 99:
				case 107:
				case 110:
				{
					BodyDeclaration node = RecordBodyDeclaration();
					nodeList.add(node);
					break;
				}
				case 103:
					jj_consume_token(103);
					break;
				default:
					jj_la1[30] = jj_gen;
					jj_consume_token(-1);
					
					throw new ParseException();
				}
				break;
			}
		}
	}

	
	
	
	public ClassOrInterfaceType AnnotatedClassOrInterfaceType()
	{
		new NodeList();
		NodeList firstAnnotations = Annotations();
		ClassOrInterfaceType result = ClassOrInterfaceType(firstAnnotations);
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		162, 254, 166, 103, 103, 166, 159, 3, 162, 111,
		130, 104, 150, 104, 110, 159, 3, 103, 162, 175,
		159, 3, 103, 162, 175, 127, 7
	})]
	public EnumConstantDeclaration EnumConstantDeclaration()
	{
		NodeList nodeList = new NodeList();
		NodeList arguments = base.emptyNodeList();
		NodeList classBody = base.emptyNodeList();
		JavaToken firstChoice = JavaToken.___003C_003EINVALID;
		while (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 107)
		{
			AnnotationExpr annotationExpr = Annotation();
			nodeList = base.add(nodeList, annotationExpr);
			firstChoice = base.orIfInvalid(firstChoice, annotationExpr);
		}
		jj_la1[21] = jj_gen;
		SimpleName name = SimpleName();
		firstChoice = base.orIfInvalid(firstChoice, token());
		if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 97)
		{
			arguments = Arguments();
		}
		else
		{
			jj_la1[22] = jj_gen;
		}
		if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 99)
		{
			classBody = ClassOrInterfaceBody();
		}
		else
		{
			jj_la1[23] = jj_gen;
		}
		if ("" != null)
		{
			com.github.javaparser.ast.body.EnumConstantDeclaration.___003Cclinit_003E();
			EnumConstantDeclaration result = new EnumConstantDeclaration(base.range(firstChoice, token()), nodeList, name, arguments, classBody);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 32, 63, 103, 108, 108, 147, 78, 8, 100,
		103, 75, 34
	})]
	private bool jj_2_4(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_4()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003d;
			}
		}
		catch
		{
			//try-fault
			jj_save(3, xla);
			throw;
		}
		jj_save(3, xla);
		return (byte)result != 0;
		IL_003d:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(3, xla);
		}
	}

	
	
		[LineNumberTable(new byte[]
	{
		165,
		183,
		105,
		140,
		byte.MaxValue,
		161,
		85,
		106,
		103,
		191,
		11,
		104,
		165,
		111,
		109,
		109,
		109,
		109,
		109,
		109,
		109,
		109,
		109,
		141,
		byte.MaxValue,
		161,
		74,
		91,
		104,
		162,
		111,
		104,
		235,
		71,
		111,
		104,
		171,
		105
	})]
	public BodyDeclaration ClassOrInterfaceBodyDeclaration()
	{
		BodyDeclaration result;
		if (jj_2_17(2))
		{
			result = InitializerDeclaration();
		}
		else
		{
			switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
			{
			case 11:
			case 13:
			case 15:
			case 18:
			case 19:
			case 22:
			case 24:
			case 26:
			case 29:
			case 31:
			case 38:
			case 39:
			case 40:
			case 41:
			case 45:
			case 46:
			case 47:
			case 48:
			case 50:
			case 51:
			case 52:
			case 55:
			case 59:
			case 62:
			case 63:
			case 65:
			case 66:
			case 67:
			case 68:
			case 69:
			case 70:
			case 71:
			case 72:
			case 73:
			case 74:
			case 75:
			case 94:
			case 107:
			case 110:
				break;
			default:
				jj_la1[39] = jj_gen;
				jj_consume_token(-1);
				
				throw new ParseException();
			}
			ModifierHolder modifier = Modifiers();
			int num = ((jj_ntk != -1) ? jj_ntk : jj_ntk_f());
			if (num == 19 || num == 39)
			{
				result = ClassOrInterfaceDeclaration(modifier);
			}
			else
			{
				jj_la1[37] = jj_gen;
				if (jj_2_12(int.MaxValue))
				{
					result = RecordDeclaration(modifier);
				}
				else if (jj_2_13(int.MaxValue))
				{
					result = EnumDeclaration(modifier);
				}
				else if (jj_2_14(int.MaxValue))
				{
					result = AnnotationTypeDeclaration(modifier);
				}
				else if (jj_2_15(int.MaxValue))
				{
					result = ConstructorDeclaration(modifier);
				}
				else if (jj_2_16(int.MaxValue))
				{
					result = FieldDeclaration(modifier);
				}
				else
				{
					switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
					{
					case 13:
					case 15:
					case 18:
					case 24:
					case 26:
					case 31:
					case 38:
					case 40:
					case 48:
					case 50:
					case 52:
					case 62:
					case 65:
					case 66:
					case 67:
					case 68:
					case 69:
					case 70:
					case 71:
					case 72:
					case 73:
					case 74:
					case 75:
					case 94:
					case 107:
					case 110:
						break;
					default:
						jj_la1[38] = jj_gen;
						jj_consume_token(-1);
						
						throw new ParseException();
					}
					result = MethodDeclaration(modifier);
				}
			}
		}
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
		[LineNumberTable(new byte[]
	{
		179,
		111,
		103,
		105,
		byte.MaxValue,
		161,
		134,
		110,
		103,
		162,
		175,
		105,
		105
	})]
	public NodeList Arguments()
	{
		NodeList result = base.emptyNodeList();
		jj_consume_token(97);
		switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
		{
		case 13:
		case 15:
		case 18:
		case 24:
		case 26:
		case 28:
		case 31:
		case 38:
		case 40:
		case 42:
		case 43:
		case 48:
		case 50:
		case 52:
		case 53:
		case 54:
		case 56:
		case 60:
		case 62:
		case 65:
		case 66:
		case 67:
		case 68:
		case 69:
		case 70:
		case 71:
		case 72:
		case 73:
		case 74:
		case 75:
		case 76:
		case 77:
		case 82:
		case 89:
		case 90:
		case 92:
		case 94:
		case 97:
		case 107:
		case 111:
		case 112:
		case 122:
		case 123:
		case 124:
		case 125:
			result = ArgumentList();
			break;
		default:
			jj_la1[124] = jj_gen;
			break;
		}
		jj_consume_token(98);
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
		
	[LineNumberTable(new byte[]
	{
		163, 112, 167, 103, 103, 159, 3, 103, 162, 175,
		127, 5
	})]
	public TypeParameter TypeParameter(NodeList annotations)
	{
		NodeList typeBound = base.emptyNodeList();
		SimpleName name = SimpleName();
		JavaToken begin = token();
		if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 27)
		{
			typeBound = TypeBound();
		}
		else
		{
			jj_la1[25] = jj_gen;
		}
		if ("" != null)
		{
			com.github.javaparser.ast.type.TypeParameter.___003Cclinit_003E();
			TypeParameter result = new TypeParameter(base.range(begin, token()), name, typeBound, annotations);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
		[LineNumberTable(new byte[]
	{
		163, 155, 135, 105, 103, 168, 159, 6, 162, 111,
		130, 108, 103, 138, 105
	})]
	public NodeList TypeBound()
	{
		NodeList nodeList = base.emptyNodeList();
		jj_consume_token(27);
		ClassOrInterfaceType node = AnnotatedClassOrInterfaceType();
		nodeList.add(node);
		while (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 128)
		{
			jj_consume_token(128);
			node = AnnotatedClassOrInterfaceType();
			nodeList.add(node);
		}
		jj_la1[26] = jj_gen;
		if ("" != null)
		{
			return nodeList;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
		[LineNumberTable(new byte[]
	{
		164,
		219,
		105,
		140,
		byte.MaxValue,
		161,
		85,
		106,
		103,
		191,
		11,
		104,
		165,
		111,
		109,
		109,
		109,
		109,
		109,
		109,
		109,
		109,
		109,
		141,
		byte.MaxValue,
		161,
		74,
		91,
		104,
		162,
		111,
		104,
		235,
		71,
		111,
		104,
		171,
		105
	})]
	public BodyDeclaration RecordBodyDeclaration()
	{
		BodyDeclaration result;
		if (jj_2_10(2))
		{
			result = InitializerDeclaration();
		}
		else
		{
			switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
			{
			case 11:
			case 13:
			case 15:
			case 18:
			case 19:
			case 22:
			case 24:
			case 26:
			case 29:
			case 31:
			case 38:
			case 39:
			case 40:
			case 41:
			case 45:
			case 46:
			case 47:
			case 48:
			case 50:
			case 51:
			case 52:
			case 55:
			case 59:
			case 62:
			case 63:
			case 65:
			case 66:
			case 67:
			case 68:
			case 69:
			case 70:
			case 71:
			case 72:
			case 73:
			case 74:
			case 75:
			case 94:
			case 107:
			case 110:
				break;
			default:
				jj_la1[33] = jj_gen;
				jj_consume_token(-1);
				
				throw new ParseException();
			}
			ModifierHolder modifier = Modifiers();
			int num = ((jj_ntk != -1) ? jj_ntk : jj_ntk_f());
			if (num == 19 || num == 39)
			{
				result = ClassOrInterfaceDeclaration(modifier);
			}
			else
			{
				jj_la1[31] = jj_gen;
				if (jj_2_5(int.MaxValue))
				{
					result = EnumDeclaration(modifier);
				}
				else if (jj_2_6(int.MaxValue))
				{
					result = AnnotationTypeDeclaration(modifier);
				}
				else if (jj_2_7(int.MaxValue))
				{
					result = CompactConstructorDeclaration(modifier);
				}
				else if (jj_2_8(int.MaxValue))
				{
					result = ConstructorDeclaration(modifier);
				}
				else if (jj_2_9(int.MaxValue))
				{
					result = FieldDeclaration(modifier);
				}
				else
				{
					switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
					{
					case 13:
					case 15:
					case 18:
					case 24:
					case 26:
					case 31:
					case 38:
					case 40:
					case 48:
					case 50:
					case 52:
					case 62:
					case 65:
					case 66:
					case 67:
					case 68:
					case 69:
					case 70:
					case 71:
					case 72:
					case 73:
					case 74:
					case 75:
					case 94:
					case 107:
					case 110:
						break;
					default:
						jj_la1[32] = jj_gen;
						jj_consume_token(-1);
						
						throw new ParseException();
					}
					result = MethodDeclaration(modifier);
				}
			}
		}
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 32, 123, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_10(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_10()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(9, xla);
			throw;
		}
		jj_save(9, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(9, xla);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		170, 13, 102, 98, 159, 3, 105, 105, 162, 175,
		103, 105, 127, 4
	})]
	public InitializerDeclaration InitializerDeclaration()
	{
		JavaToken firstChoice = JavaToken.___003C_003EINVALID;
		int isStatic = 0;
		if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 51)
		{
			jj_consume_token(51);
			isStatic = 1;
			firstChoice = token();
		}
		else
		{
			jj_la1[63] = jj_gen;
		}
		BlockStmt blockStmt = Block();
		firstChoice = base.orIfInvalid(firstChoice, blockStmt);
		if ("" != null)
		{
			com.github.javaparser.ast.body.InitializerDeclaration.___003Cclinit_003E();
			InitializerDeclaration result = new InitializerDeclaration(base.range(firstChoice, token()), (byte)isStatic != 0, blockStmt);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 32, 73, 103, 108, 108, 147, 78, 8, 100,
		103, 75, 34
	})]
	private bool jj_2_5(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_5()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003d;
			}
		}
		catch
		{
			//try-fault
			jj_save(4, xla);
			throw;
		}
		jj_save(4, xla);
		return (byte)result != 0;
		IL_003d:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(4, xla);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 32, 83, 103, 108, 108, 147, 78, 8, 100,
		103, 75, 34
	})]
	private bool jj_2_6(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_6()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003d;
			}
		}
		catch
		{
			//try-fault
			jj_save(5, xla);
			throw;
		}
		jj_save(5, xla);
		return (byte)result != 0;
		IL_003d:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(5, xla);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 32, 93, 103, 108, 108, 147, 78, 8, 100,
		103, 75, 34
	})]
	private bool jj_2_7(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_7()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003d;
			}
		}
		catch
		{
			//try-fault
			jj_save(6, xla);
			throw;
		}
		jj_save(6, xla);
		return (byte)result != 0;
		IL_003d:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(6, xla);
		}
	}

	
	
	
	[LineNumberTable(new byte[]
	{
		165, 85, 140, 109, 103, 98, 103, 103, 134, 159,
		3, 103, 115, 162, 207, 104, 127, 2, 159, 6,
		105, 104, 170, 159, 3, 162, 111, 130, 105, 104,
		236, 69, 175, 105, 104, 109, 199, 104, 105, 99,
		139, 127, 49
	})]
	public CompactConstructorDeclaration CompactConstructorDeclaration(ModifierHolder modifier)
	{
		RangedList rangedList = new RangedList(base.emptyNodeList());
		new Pair(base.emptyNodeList(), null);
		NodeList nodeList = base.emptyNodeList();
		ExplicitConstructorInvocationStmt explicitConstructorInvocationStmt = null;
		base.emptyNodeList();
		JavaToken firstChoice = modifier.begin;
		_ = JavaToken.___003C_003EINVALID;
		if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 110)
		{
			rangedList = TypeParameters();
			firstChoice = base.orIfInvalid(firstChoice, rangedList.range.getBegin());
		}
		else
		{
			jj_la1[34] = jj_gen;
		}
		SimpleName name = SimpleName();
		firstChoice = base.orIfInvalid(firstChoice, rangedList.range.getBegin());
		firstChoice = base.orIfInvalid(firstChoice, token());
		if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 58)
		{
			jj_consume_token(58);
			ReferenceType obj = AnnotatedReferenceType();
			nodeList = base.add(nodeList, obj);
			while (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 104)
			{
				jj_consume_token(104);
				obj = AnnotatedReferenceType();
				nodeList = base.add(nodeList, obj);
			}
			jj_la1[35] = jj_gen;
		}
		else
		{
			jj_la1[36] = jj_gen;
		}
		jj_consume_token(99);
		JavaToken begin = token();
		if (jj_2_11(int.MaxValue))
		{
			explicitConstructorInvocationStmt = ExplicitConstructorInvocation();
		}
		NodeList nodeList2 = Statements();
		jj_consume_token(100);
		if (explicitConstructorInvocationStmt != null)
		{
			nodeList2 = base.prepend(nodeList2, explicitConstructorInvocationStmt);
		}
		if ("" != null)
		{
			com.github.javaparser.ast.body.CompactConstructorDeclaration.___003Cclinit_003E();
			TokenRange obj2 = base.range(firstChoice, token());
			NodeList modifiers = modifier.modifiers;
			NodeList annotations = modifier.annotations;
			NodeList list = rangedList.list;
			NodeList thrownExceptions = nodeList;
			BlockStmt.___003Cclinit_003E();
			CompactConstructorDeclaration result = new CompactConstructorDeclaration(obj2, modifiers, annotations, list, name, thrownExceptions, new BlockStmt(base.range(begin, token()), nodeList2));
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 32, 103, 103, 108, 108, 147, 78, 8, 100,
		103, 75, 34
	})]
	private bool jj_2_8(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_8()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003d;
			}
		}
		catch
		{
			//try-fault
			jj_save(7, xla);
			throw;
		}
		jj_save(7, xla);
		return (byte)result != 0;
		IL_003d:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(7, xla);
		}
	}

	
	
	
	[LineNumberTable(new byte[]
	{
		169, 33, 140, 109, 103, 98, 103, 103, 134, 159,
		3, 103, 115, 162, 207, 104, 127, 2, 104, 159,
		6, 105, 104, 170, 159, 3, 162, 111, 130, 105,
		104, 236, 69, 175, 105, 104, 109, 199, 104, 105,
		99, 139, 127, 73
	})]
	public ConstructorDeclaration ConstructorDeclaration(ModifierHolder modifier)
	{
		RangedList rangedList = new RangedList(base.emptyNodeList());
		new Pair(base.emptyNodeList(), null);
		NodeList nodeList = base.emptyNodeList();
		ExplicitConstructorInvocationStmt explicitConstructorInvocationStmt = null;
		base.emptyNodeList();
		JavaToken firstChoice = modifier.begin;
		_ = JavaToken.___003C_003EINVALID;
		if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 110)
		{
			rangedList = TypeParameters();
			firstChoice = base.orIfInvalid(firstChoice, rangedList.range.getBegin());
		}
		else
		{
			jj_la1[57] = jj_gen;
		}
		SimpleName name = SimpleName();
		firstChoice = base.orIfInvalid(firstChoice, rangedList.range.getBegin());
		firstChoice = base.orIfInvalid(firstChoice, token());
		Pair pair = Parameters();
		if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 58)
		{
			jj_consume_token(58);
			ReferenceType obj = AnnotatedReferenceType();
			nodeList = base.add(nodeList, obj);
			while (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 104)
			{
				jj_consume_token(104);
				obj = AnnotatedReferenceType();
				nodeList = base.add(nodeList, obj);
			}
			jj_la1[58] = jj_gen;
		}
		else
		{
			jj_la1[59] = jj_gen;
		}
		jj_consume_token(99);
		JavaToken begin = token();
		if (jj_2_21(int.MaxValue))
		{
			explicitConstructorInvocationStmt = ExplicitConstructorInvocation();
		}
		NodeList nodeList2 = Statements();
		jj_consume_token(100);
		if (explicitConstructorInvocationStmt != null)
		{
			nodeList2 = base.prepend(nodeList2, explicitConstructorInvocationStmt);
		}
		if ("" != null)
		{
			com.github.javaparser.ast.body.ConstructorDeclaration.___003Cclinit_003E();
			TokenRange obj2 = base.range(firstChoice, token());
			NodeList modifiers = modifier.modifiers;
			NodeList annotations = modifier.annotations;
			NodeList list = rangedList.list;
			NodeList parameters = (NodeList)pair.___003C_003Ea;
			NodeList thrownExceptions = nodeList;
			BlockStmt.___003Cclinit_003E();
			ConstructorDeclaration result = new ConstructorDeclaration(obj2, modifiers, annotations, list, name, parameters, thrownExceptions, new BlockStmt(base.range(begin, token()), nodeList2), (ReceiverParameter)pair.___003C_003Eb);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 32, 113, 103, 108, 108, 147, 78, 8, 100,
		103, 75, 34
	})]
	private bool jj_2_9(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_9()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003d;
			}
		}
		catch
		{
			//try-fault
			jj_save(8, xla);
			throw;
		}
		jj_save(8, xla);
		return (byte)result != 0;
		IL_003d:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(8, xla);
		}
	}

	
	
	
	[LineNumberTable(new byte[]
	{
		166, 58, 166, 109, 104, 168, 159, 3, 162, 111,
		130, 105, 104, 138, 105, 110, 127, 15
	})]
	public FieldDeclaration FieldDeclaration(ModifierHolder modifier)
	{
		NodeList nodeList = new NodeList();
		com.github.javaparser.ast.type.Type type = Type(base.emptyNodeList());
		VariableDeclarator node = VariableDeclarator(type);
		nodeList.add(node);
		while (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 104)
		{
			jj_consume_token(104);
			node = VariableDeclarator(type);
			nodeList.add(node);
		}
		jj_la1[40] = jj_gen;
		jj_consume_token(103);
		JavaToken begin = base.orIfInvalid(modifier.begin, type);
		if ("" != null)
		{
			com.github.javaparser.ast.body.FieldDeclaration.___003Cclinit_003E();
			FieldDeclaration result = new FieldDeclaration(base.range(begin, token()), modifier.modifiers, modifier.annotations, nodeList);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	
	[LineNumberTable(new byte[]
	{
		167, 94, 172, 141, 103, 103, 130, 136, 159, 3,
		103, 117, 162, 175, 104, 127, 0, 110, 108, 104,
		168, 191, 11, 162, 111, 130, 109, 159, 7, 159,
		6, 105, 104, 170, 159, 3, 162, 111, 130, 105,
		104, 236, 69, 175, 159, 11, 103, 162, 105, 162,
		111, 104, 139, 126, 127, 51
	})]
	public MethodDeclaration MethodDeclaration(ModifierHolder modifier)
	{
		RangedList rangedList = new RangedList(base.emptyNodeList());
		new Pair(base.emptyNodeList(), null);
		object obj = new ArrayList(0);
		NodeList nodeList = base.emptyNodeList();
		BlockStmt body = null;
		JavaToken firstChoice = modifier.begin;
		if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 110)
		{
			rangedList = TypeParameters();
			firstChoice = base.orIfInvalid(firstChoice, rangedList.range.getBegin());
		}
		else
		{
			jj_la1[46] = jj_gen;
		}
		NodeList nodeList2 = Annotations();
		modifier.annotations.addAll(nodeList2);
		firstChoice = base.orIfInvalid(firstChoice, base.nodeListBegin(nodeList2));
		com.github.javaparser.ast.type.Type type = ResultType(base.emptyNodeList());
		firstChoice = base.orIfInvalid(firstChoice, type);
		SimpleName name = SimpleName();
		Pair pair = Parameters();
		int num2;
		while (true)
		{
			int num = ((jj_ntk != -1) ? jj_ntk : jj_ntk_f());
			if (num != 101 && num != 107)
			{
				jj_la1[47] = jj_gen;
				num2 = ((jj_ntk != -1) ? jj_ntk : jj_ntk_f());
				break;
			}
			ArrayType.ArrayBracketPair arrayBracketPair = ArrayBracketPair(ArrayType.Origin.___003C_003ENAME);
			object obj2 = obj;
			obj = base.add(obj: arrayBracketPair, list: (obj2 == null) ? null : ((obj2 as List) ?? throw new java.lang.IncompatibleClassChangeError()));
		}
		if (num2 == 58)
		{
			jj_consume_token(58);
			ReferenceType obj4 = AnnotatedReferenceType();
			nodeList = base.add(nodeList, obj4);
			while (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 104)
			{
				jj_consume_token(104);
				obj4 = AnnotatedReferenceType();
				nodeList = base.add(nodeList, obj4);
			}
			jj_la1[48] = jj_gen;
		}
		else
		{
			jj_la1[49] = jj_gen;
		}
		switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
		{
		case 99:
			body = Block();
			break;
		case 103:
			jj_consume_token(103);
			break;
		default:
			jj_la1[50] = jj_gen;
			jj_consume_token(-1);
			
			throw new ParseException();
		}
		com.github.javaparser.ast.type.Type partialType = type;
		object obj5 = obj;
		type = base.juggleArrayType(partialType, (obj5 == null) ? null : ((obj5 as List) ?? throw new java.lang.IncompatibleClassChangeError()));
		if ("" != null)
		{
			com.github.javaparser.ast.body.MethodDeclaration.___003Cclinit_003E();
			MethodDeclaration result = new MethodDeclaration(base.range(firstChoice, token()), modifier.modifiers, modifier.annotations, rangedList.list, type, name, (NodeList)pair.___003C_003Ea, nodeList, body, (ReceiverParameter)pair.___003C_003Eb);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	
	public ReferenceType AnnotatedReferenceType()
	{
		NodeList annotations = Annotations();
		ReferenceType result = ReferenceType(annotations);
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 32, 133, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_11(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_11()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(10, xla);
			throw;
		}
		jj_save(10, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(10, xla);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		169,
		115,
		130,
		98,
		103,
		102,
		112,
		159,
		3,
		103,
		108,
		162,
		175,
		105,
		112,
		104,
		142,
		byte.MaxValue,
		161,
		77,
		104,
		109,
		103,
		105,
		201,
		159,
		3,
		103,
		115,
		162,
		175,
		105,
		110,
		104,
		105,
		162,
		111,
		104,
		171,
		127,
		12
	})]
	public ExplicitConstructorInvocationStmt ExplicitConstructorInvocation()
	{
		int isThis = 0;
		Expression expression = null;
		RangedList rangedList = new RangedList(null);
		JavaToken firstChoice = JavaToken.___003C_003EINVALID;
		NodeList arguments;
		if (jj_2_23(int.MaxValue))
		{
			if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 110)
			{
				rangedList = TypeArguments();
				firstChoice = rangedList.range.getBegin();
			}
			else
			{
				jj_la1[60] = jj_gen;
			}
			jj_consume_token(56);
			firstChoice = base.orIfInvalid(firstChoice, token());
			isThis = 1;
			arguments = Arguments();
			jj_consume_token(103);
		}
		else
		{
			switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
			{
			case 13:
			case 15:
			case 18:
			case 24:
			case 26:
			case 28:
			case 31:
			case 38:
			case 40:
			case 42:
			case 43:
			case 48:
			case 50:
			case 52:
			case 53:
			case 56:
			case 60:
			case 62:
			case 65:
			case 66:
			case 67:
			case 68:
			case 69:
			case 70:
			case 71:
			case 72:
			case 73:
			case 74:
			case 75:
			case 76:
			case 77:
			case 82:
			case 89:
			case 90:
			case 92:
			case 94:
			case 97:
			case 107:
			case 110:
				break;
			default:
				jj_la1[62] = jj_gen;
				jj_consume_token(-1);
				
				throw new ParseException();
			}
			if (jj_2_22(int.MaxValue))
			{
				expression = PrimaryExpressionWithoutSuperSuffix();
				jj_consume_token(105);
				firstChoice = base.orIfInvalid(firstChoice, expression);
			}
			if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 110)
			{
				rangedList = TypeArguments();
				firstChoice = base.orIfInvalid(firstChoice, rangedList.range.getBegin());
			}
			else
			{
				jj_la1[61] = jj_gen;
			}
			jj_consume_token(53);
			firstChoice = base.orIfInvalid(firstChoice, token());
			arguments = Arguments();
			jj_consume_token(103);
		}
		if ("" != null)
		{
			ExplicitConstructorInvocationStmt.___003Cclinit_003E();
			ExplicitConstructorInvocationStmt result = new ExplicitConstructorInvocationStmt(base.range(firstChoice, token()), rangedList.list, (byte)isThis != 0, expression, arguments);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
		
	public NodeList Statements()
	{
		NodeList nodeList = base.emptyNodeList();
		while (jj_2_24(2))
		{
			Statement obj = BlockStatement();
			nodeList = base.add(nodeList, obj);
		}
		if ("" != null)
		{
			return nodeList;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 32, 193, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_17(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_17()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(16, xla);
			throw;
		}
		jj_save(16, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(16, xla);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 32, 143, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_12(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_12()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(11, xla);
			throw;
		}
		jj_save(11, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(11, xla);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 32, 153, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_13(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_13()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(12, xla);
			throw;
		}
		jj_save(12, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(12, xla);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 32, 163, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_14(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_14()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(13, xla);
			throw;
		}
		jj_save(13, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(13, xla);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 32, 173, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_15(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_15()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(14, xla);
			throw;
		}
		jj_save(14, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(14, xla);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 32, 183, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_16(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_16()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(15, xla);
			throw;
		}
		jj_save(15, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(15, xla);
		}
	}

	
	
		
	[LineNumberTable(new byte[]
	{
		170,
		45,
		109,
		141,
		byte.MaxValue,
		59,
		73,
		104,
		162,
		111,
		104,
		171,
		105
	})]
	public com.github.javaparser.ast.type.Type Type(NodeList annotations)
	{
		com.github.javaparser.ast.type.Type result;
		if (jj_2_25(int.MaxValue))
		{
			result = ReferenceType(annotations);
		}
		else
		{
			int num = ((jj_ntk != -1) ? jj_ntk : jj_ntk_f());
			if (num != 13 && num != 15 && num != 18 && num != 24 && num != 31 && num != 38 && num != 40 && num != 50)
			{
				jj_la1[64] = jj_gen;
				jj_consume_token(-1);
				
				throw new ParseException();
			}
			result = PrimitiveType(annotations);
		}
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	
	[LineNumberTable(new byte[]
	{
		166, 97, 98, 103, 159, 3, 105, 103, 162, 175,
		127, 42
	})]
	public VariableDeclarator VariableDeclarator(com.github.javaparser.ast.type.Type partialType)
	{
		Expression initializer = null;
		Pair pair = VariableDeclaratorId();
		if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 109)
		{
			jj_consume_token(109);
			initializer = VariableInitializer();
		}
		else
		{
			jj_la1[41] = jj_gen;
		}
		if ("" != null)
		{
			com.github.javaparser.ast.body.VariableDeclarator.___003Cclinit_003E();
			VariableDeclarator result = new VariableDeclarator(base.range((Node)pair.___003C_003Ea, token()), base.juggleArrayType(partialType, (List)pair.___003C_003Eb), (SimpleName)pair.___003C_003Ea, initializer);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
		[LineNumberTable(new byte[]
	{
		166, 141, 103, 103, 167, 191, 11, 162, 111, 130,
		108, 159, 4, 104, 159, 3, 113
	})]
	public Pair VariableDeclaratorId()
	{
		object obj = new ArrayList(0);
		SimpleName simpleName = SimpleName();
		token();
		while (true)
		{
			int num = ((jj_ntk != -1) ? jj_ntk : jj_ntk_f());
			if (num != 101 && num != 107)
			{
				jj_la1[42] = jj_gen;
				if (storeTokens)
				{
					simpleName.setTokenRange(((TokenRange)simpleName.getTokenRange().get()).withEnd(token()));
				}
				break;
			}
			ArrayType.ArrayBracketPair arrayBracketPair = ArrayBracketPair(ArrayType.Origin.___003C_003ENAME);
			object obj2 = obj;
			obj = base.add(obj: arrayBracketPair, list: (obj2 == null) ? null : ((obj2 as List) ?? throw new java.lang.IncompatibleClassChangeError()));
		}
		if ("" != null)
		{
			Pair result = new Pair(simpleName, obj);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		166, 174, 159, 161, 134, 103, 226, 111, 103, 162,
		111, 104, 139, 105
	})]
	public Expression VariableInitializer()
	{
		Expression result;
		switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
		{
		case 99:
			result = ArrayInitializer();
			break;
		case 13:
		case 15:
		case 18:
		case 24:
		case 26:
		case 28:
		case 31:
		case 38:
		case 40:
		case 42:
		case 43:
		case 48:
		case 50:
		case 52:
		case 53:
		case 54:
		case 56:
		case 60:
		case 62:
		case 65:
		case 66:
		case 67:
		case 68:
		case 69:
		case 70:
		case 71:
		case 72:
		case 73:
		case 74:
		case 75:
		case 76:
		case 77:
		case 82:
		case 89:
		case 90:
		case 92:
		case 94:
		case 97:
		case 107:
		case 111:
		case 112:
		case 122:
		case 123:
		case 124:
		case 125:
			result = Expression();
			break;
		default:
			jj_la1[43] = jj_gen;
			jj_consume_token(-1);
			
			throw new ParseException();
		}
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	
	
	public ArrayType.ArrayBracketPair ArrayBracketPair(ArrayType.Origin origin)
	{
		JavaToken __003C_003EINVALID = JavaToken.___003C_003EINVALID;
		NodeList annotations = Annotations();
		jj_consume_token(101);
		__003C_003EINVALID = base.orIfInvalid(__003C_003EINVALID, token());
		jj_consume_token(102);
		if ("" != null)
		{
			ArrayType.ArrayBracketPair result = new ArrayType.ArrayBracketPair(base.range(__003C_003EINVALID, token()), origin, annotations);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		166,
		252,
		167,
		105,
		103,
		byte.MaxValue,
		161,
		134,
		111,
		103,
		169,
		201,
		105,
		103,
		235,
		69,
		175,
		159,
		3,
		105,
		162,
		175,
		105,
		127,
		3
	})]
	public ArrayInitializerExpr ArrayInitializer()
	{
		NodeList nodeList = base.emptyNodeList();
		jj_consume_token(99);
		JavaToken begin = token();
		switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
		{
		case 13:
		case 15:
		case 18:
		case 24:
		case 26:
		case 28:
		case 31:
		case 38:
		case 40:
		case 42:
		case 43:
		case 48:
		case 50:
		case 52:
		case 53:
		case 54:
		case 56:
		case 60:
		case 62:
		case 65:
		case 66:
		case 67:
		case 68:
		case 69:
		case 70:
		case 71:
		case 72:
		case 73:
		case 74:
		case 75:
		case 76:
		case 77:
		case 82:
		case 89:
		case 90:
		case 92:
		case 94:
		case 97:
		case 99:
		case 107:
		case 111:
		case 112:
		case 122:
		case 123:
		case 124:
		case 125:
		{
			Expression obj = VariableInitializer();
			nodeList = base.add(nodeList, obj);
			while (jj_2_18(2))
			{
				jj_consume_token(104);
				obj = VariableInitializer();
				nodeList = base.add(nodeList, obj);
			}
			break;
		}
		default:
			jj_la1[44] = jj_gen;
			break;
		}
		if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 104)
		{
			jj_consume_token(104);
		}
		else
		{
			jj_la1[45] = jj_gen;
		}
		jj_consume_token(100);
		if ("" != null)
		{
			ArrayInitializerExpr.___003Cclinit_003E();
			ArrayInitializerExpr result = new ArrayInitializerExpr(base.range(begin, token()), nodeList);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		172,
		199,
		98,
		103,
		103,
		byte.MaxValue,
		160,
		85,
		79,
		105,
		103,
		103,
		159,
		1,
		159,
		14,
		105,
		104,
		106,
		165,
		105,
		159,
		3,
		103,
		162,
		175,
		byte.MaxValue,
		160,
		214,
		80,
		103,
		162,
		105,
		162,
		111,
		104,
		139,
		127,
		11,
		162,
		111,
		104,
		235,
		70,
		175,
		105
	})]
	public Expression Expression()
	{
		
		RangedList rangedList = new RangedList(null);
		Expression expression = ConditionalExpression();
		switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
		{
		case 108:
		case 109:
		case 115:
		case 133:
		case 134:
		case 135:
		case 136:
		case 137:
		case 138:
		case 139:
		case 140:
		case 141:
		case 142:
		case 143:
			if (jj_2_32(2))
			{
				AssignExpr.Operator @operator = AssignmentOperator();
				Expression value = Expression();
				AssignExpr.___003Cclinit_003E();
				expression = new AssignExpr(base.range(expression, token()), expression, value, @operator);
				break;
			}
			switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
			{
			case 115:
			{
				jj_consume_token(115);
				Statement lambdaBody = LambdaBody();
				expression = base.generateLambda(expression, lambdaBody);
				break;
			}
			case 108:
				jj_consume_token(108);
				if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 110)
				{
					rangedList = TypeArguments();
				}
				else
				{
					jj_la1[75] = jj_gen;
				}
				switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
				{
				case 26:
				case 48:
				case 52:
				case 65:
				case 66:
				case 67:
				case 68:
				case 69:
				case 70:
				case 71:
				case 72:
				case 73:
				case 74:
				case 75:
				case 94:
					Identifier();
					break;
				case 42:
					jj_consume_token(42);
					break;
				default:
					jj_la1[76] = jj_gen;
					jj_consume_token(-1);
					
					throw new ParseException();
				}
				MethodReferenceExpr.___003Cclinit_003E();
				expression = new MethodReferenceExpr(base.range(expression, token()), expression, rangedList.list, this.token.image);
				break;
			default:
				jj_la1[77] = jj_gen;
				jj_consume_token(-1);
				
				throw new ParseException();
			}
			break;
		default:
			jj_la1[78] = jj_gen;
			break;
		}
		if ("" != null)
		{
			return expression;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 32, 203, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_18(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_18()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(17, xla);
			throw;
		}
		jj_save(17, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(17, xla);
		}
	}

	
	
		
	[LineNumberTable(new byte[]
	{
		172, 12, 159, 161, 10, 105, 113, 226, 89, 104,
		162, 111, 104, 139, 105
	})]
	public com.github.javaparser.ast.type.Type ResultType(NodeList annotations)
	{
		com.github.javaparser.ast.type.Type result;
		switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
		{
		case 62:
			jj_consume_token(62);
			VoidType.___003Cclinit_003E();
			result = new VoidType(base.tokenRange());
			break;
		case 13:
		case 15:
		case 18:
		case 24:
		case 26:
		case 31:
		case 38:
		case 40:
		case 48:
		case 50:
		case 52:
		case 65:
		case 66:
		case 67:
		case 68:
		case 69:
		case 70:
		case 71:
		case 72:
		case 73:
		case 74:
		case 75:
		case 94:
			result = Type(annotations);
			break;
		default:
			jj_la1[73] = jj_gen;
			jj_consume_token(-1);
			
			throw new ParseException();
		}
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		181,
		141,
		135,
		105,
		135,
		103,
		105,
		byte.MaxValue,
		26,
		70,
		226,
		59,
		98,
		107,
		126,
		109,
		138
	})]
	public BlockStmt Block()
	{
		//Discarded unreachable code: IL_004a
		base.emptyNodeList();
		jj_consume_token(99);
		JavaToken begin = token();
		ParseException ex;
		try
		{
			NodeList statements = Statements();
			jj_consume_token(100);
			if ("" != null)
			{
				BlockStmt.___003Cclinit_003E();
				return new BlockStmt(base.range(begin, token()), statements);
			}
		}
		catch (ParseException x)
		{
			ex = ByteCodeHelper.MapException<ParseException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_005c;
		}
		goto IL_00a4;
		IL_005c:
		ParseException p = ex;
		base.recover(100, p);
		BlockStmt.___003Cclinit_003E();
		BlockStmt blockStmt = new BlockStmt(base.range(begin, token()), new NodeList());
		blockStmt.setParsed(Node.Parsedness.___003C_003EUNPARSABLE);
		if ("" != null)
		{
			return blockStmt;
		}
		goto IL_00a4;
		IL_00a4:
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
		
	[LineNumberTable(new byte[]
	{
		170,
		100,
		103,
		byte.MaxValue,
		161,
		13,
		74,
		168,
		108,
		126,
		242,
		86,
		168,
		205,
		108,
		byte.MaxValue,
		1,
		69,
		111,
		104,
		139,
		125
	})]
	public ReferenceType ReferenceType(NodeList annotations)
	{
		object obj = new ArrayList(0);
		com.github.javaparser.ast.type.Type type;
		switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
		{
		case 13:
		case 15:
		case 18:
		case 24:
		case 31:
		case 38:
		case 40:
		case 50:
			type = PrimitiveType(annotations);
			do
			{
				ArrayType.ArrayBracketPair arrayBracketPair = ArrayBracketPair(ArrayType.Origin.___003C_003ETYPE);
				object obj4 = obj;
				obj = base.add(obj: arrayBracketPair, list: (obj4 == null) ? null : ((obj4 as List) ?? throw new java.lang.IncompatibleClassChangeError()));
			}
			while (jj_2_26(int.MaxValue));
			break;
		case 26:
		case 48:
		case 52:
		case 65:
		case 66:
		case 67:
		case 68:
		case 69:
		case 70:
		case 71:
		case 72:
		case 73:
		case 74:
		case 75:
		case 94:
			type = ClassOrInterfaceType(annotations);
			while (jj_2_27(int.MaxValue))
			{
				ArrayType.ArrayBracketPair arrayBracketPair = ArrayBracketPair(ArrayType.Origin.___003C_003ETYPE);
				object obj2 = obj;
				obj = base.add(obj: arrayBracketPair, list: (obj2 == null) ? null : ((obj2 as List) ?? throw new java.lang.IncompatibleClassChangeError()));
			}
			break;
		default:
			jj_la1[65] = jj_gen;
			jj_consume_token(-1);
			
			throw new ParseException();
		}
		if ("" != null)
		{
			return (ReferenceType)ArrayType.wrapInArrayTypes(type, (List)obj);
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 32, 213, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_19(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_19()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(18, xla);
			throw;
		}
		jj_save(18, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(18, xla);
		}
	}

	
	
	
	public ReceiverParameter ReceiverParameter()
	{
		base.emptyNodeList();
		NodeList annotations = Annotations();
		com.github.javaparser.ast.type.Type type = Type(base.emptyNodeList());
		Name name = ReceiverParameterId();
		if ("" != null)
		{
			com.github.javaparser.ast.body.ReceiverParameter.___003Cclinit_003E();
			ReceiverParameter result = new ReceiverParameter(base.range(type, token()), annotations, type, name);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		168, 200, 130, 103, 103, 109, 191, 11, 103, 105,
		98, 162, 175, 104, 111, 127, 48
	})]
	public Parameter Parameter()
	{
		int isVarArgs = 0;
		NodeList varArgsAnnotations = base.emptyNodeList();
		ModifierHolder modifierHolder = Modifiers();
		com.github.javaparser.ast.type.Type type = Type(base.emptyNodeList());
		int num = ((jj_ntk != -1) ? jj_ntk : jj_ntk_f());
		if (num == 106 || num == 107)
		{
			varArgsAnnotations = Annotations();
			jj_consume_token(106);
			isVarArgs = 1;
		}
		else
		{
			jj_la1[56] = jj_gen;
		}
		Pair pair = VariableDeclaratorId();
		JavaToken begin = base.orIfInvalid(modifierHolder.begin, type);
		if ("" != null)
		{
			com.github.javaparser.ast.body.Parameter.___003Cclinit_003E();
			Parameter result = new Parameter(base.range(begin, token()), modifierHolder.modifiers, modifierHolder.annotations, base.juggleArrayType(type, (List)pair.___003C_003Eb), (byte)isVarArgs != 0, varArgsAnnotations, (SimpleName)pair.___003C_003Ea);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	
	public Name ReceiverParameterId()
	{
		Name qualifier = null;
		if (jj_2_20(int.MaxValue))
		{
			qualifier = Name();
			jj_consume_token(105);
		}
		jj_consume_token(56);
		if ("" != null)
		{
			com.github.javaparser.ast.expr.Name.___003Cclinit_003E();
			Name result = new Name(base.tokenRange(), qualifier, this.token.image);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 32, 223, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_20(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_20()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(19, xla);
			throw;
		}
		jj_save(19, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(19, xla);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 32, 233, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_21(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_21()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(20, xla);
			throw;
		}
		jj_save(20, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(20, xla);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 32, 253, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_23(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_23()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(22, xla);
			throw;
		}
		jj_save(22, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(22, xla);
		}
	}

	
	
		[LineNumberTable(new byte[]
	{
		171,
		30,
		139,
		105,
		108,
		byte.MaxValue,
		161,
		89,
		90,
		103,
		167,
		159,
		3,
		162,
		111,
		130,
		105,
		103,
		233,
		69,
		175,
		108,
		108,
		105
	})]
	public RangedList TypeArguments()
	{
		RangedList rangedList = new RangedList(new NodeList());
		jj_consume_token(110);
		rangedList.beginAt(token());
		switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
		{
		case 13:
		case 15:
		case 18:
		case 24:
		case 26:
		case 31:
		case 38:
		case 40:
		case 48:
		case 50:
		case 52:
		case 65:
		case 66:
		case 67:
		case 68:
		case 69:
		case 70:
		case 71:
		case 72:
		case 73:
		case 74:
		case 75:
		case 94:
		case 107:
		case 113:
		{
			com.github.javaparser.ast.type.Type t = TypeArgument();
			rangedList.add(t);
			while (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 104)
			{
				jj_consume_token(104);
				t = TypeArgument();
				rangedList.add(t);
			}
			jj_la1[67] = jj_gen;
			break;
		}
		default:
			jj_la1[68] = jj_gen;
			break;
		}
		jj_consume_token(146);
		rangedList.endAt(token());
		if ("" != null)
		{
			return rangedList;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 32, 243, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_22(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_22()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(21, xla);
			throw;
		}
		jj_save(21, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(21, xla);
		}
	}

	
	
	
	public Expression PrimaryExpressionWithoutSuperSuffix()
	{
		Expression expression = PrimaryPrefix();
		while (jj_2_41(int.MaxValue))
		{
			expression = PrimarySuffixWithoutSuper(expression);
		}
		if ("" != null)
		{
			return expression;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 33, 7, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_24(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_24()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(23, xla);
			throw;
		}
		jj_save(23, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(23, xla);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		181,
		196,
		141,
		103,
		104,
		126,
		109,
		103,
		104,
		126,
		109,
		104,
		105,
		159,
		1,
		byte.MaxValue,
		161,
		130,
		119,
		103,
		162,
		114,
		104,
		171,
		223,
		8,
		226,
		61,
		98,
		112,
		143
	})]
	public Statement BlockStatement()
	{
		//Discarded unreachable code: IL_02cd
		ParseException ex;
		try
		{
			Statement result;
			if (jj_2_52(int.MaxValue))
			{
				ModifierHolder modifier = Modifiers();
				ClassOrInterfaceDeclaration classOrInterfaceDeclaration = ClassOrInterfaceDeclaration(modifier);
				LocalClassDeclarationStmt.___003Cclinit_003E();
				result = new LocalClassDeclarationStmt(base.range(classOrInterfaceDeclaration, token()), classOrInterfaceDeclaration);
			}
			else if (jj_2_53(int.MaxValue))
			{
				ModifierHolder modifier = Modifiers();
				RecordDeclaration recordDeclaration = RecordDeclaration(modifier);
				LocalRecordDeclarationStmt.___003Cclinit_003E();
				result = new LocalRecordDeclarationStmt(base.range(recordDeclaration, token()), recordDeclaration);
			}
			else if (jj_2_54(int.MaxValue))
			{
				VariableDeclarationExpr variableDeclarationExpr = VariableDeclarationExpression();
				jj_consume_token(103);
				ExpressionStmt.___003Cclinit_003E();
				result = new ExpressionStmt(base.range(variableDeclarationExpr, token()), variableDeclarationExpr);
			}
			else
			{
				switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
				{
				case 12:
				case 13:
				case 14:
				case 15:
				case 18:
				case 21:
				case 23:
				case 24:
				case 26:
				case 28:
				case 31:
				case 32:
				case 34:
				case 38:
				case 40:
				case 42:
				case 43:
				case 48:
				case 49:
				case 50:
				case 52:
				case 53:
				case 54:
				case 55:
				case 56:
				case 57:
				case 60:
				case 61:
				case 62:
				case 64:
				case 65:
				case 66:
				case 67:
				case 68:
				case 69:
				case 70:
				case 71:
				case 72:
				case 73:
				case 74:
				case 75:
				case 76:
				case 77:
				case 82:
				case 89:
				case 90:
				case 92:
				case 94:
				case 97:
				case 99:
				case 103:
				case 107:
				case 122:
				case 123:
					break;
				default:
					jj_la1[134] = jj_gen;
					jj_consume_token(-1);
					
					throw new ParseException();
				}
				result = Statement();
			}
			if ("" != null)
			{
				return result;
			}
		}
		catch (ParseException x)
		{
			ex = ByteCodeHelper.MapException<ParseException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_02e3;
		}
		goto IL_030b;
		IL_02e3:
		ParseException p = ex;
		TokenRange tokenRange = base.recoverStatement(103, 99, 100, p);
		if ("" != null)
		{
			return new UnparsableStmt(tokenRange);
		}
		goto IL_030b;
		IL_030b:
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 33, 17, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_25(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_25()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(24, xla);
			throw;
		}
		jj_save(24, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(24, xla);
		}
	}

	
	
		
	[LineNumberTable(new byte[]
	{
		171, 209, 159, 80, 105, 119, 165, 105, 119, 165,
		105, 119, 165, 105, 119, 165, 105, 119, 165, 105,
		119, 162, 105, 119, 162, 105, 119, 162, 111, 104,
		139, 105
	})]
	public PrimitiveType PrimitiveType(NodeList annotations)
	{
		PrimitiveType result;
		switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
		{
		case 13:
			jj_consume_token(13);
			com.github.javaparser.ast.type.PrimitiveType.___003Cclinit_003E();
			result = new PrimitiveType(base.tokenRange(), com.github.javaparser.ast.type.PrimitiveType.Primitive.___003C_003EBOOLEAN, annotations);
			break;
		case 18:
			jj_consume_token(18);
			com.github.javaparser.ast.type.PrimitiveType.___003Cclinit_003E();
			result = new PrimitiveType(base.tokenRange(), com.github.javaparser.ast.type.PrimitiveType.Primitive.___003C_003ECHAR, annotations);
			break;
		case 15:
			jj_consume_token(15);
			com.github.javaparser.ast.type.PrimitiveType.___003Cclinit_003E();
			result = new PrimitiveType(base.tokenRange(), com.github.javaparser.ast.type.PrimitiveType.Primitive.___003C_003EBYTE, annotations);
			break;
		case 50:
			jj_consume_token(50);
			com.github.javaparser.ast.type.PrimitiveType.___003Cclinit_003E();
			result = new PrimitiveType(base.tokenRange(), com.github.javaparser.ast.type.PrimitiveType.Primitive.___003C_003ESHORT, annotations);
			break;
		case 38:
			jj_consume_token(38);
			com.github.javaparser.ast.type.PrimitiveType.___003Cclinit_003E();
			result = new PrimitiveType(base.tokenRange(), com.github.javaparser.ast.type.PrimitiveType.Primitive.___003C_003EINT, annotations);
			break;
		case 40:
			jj_consume_token(40);
			com.github.javaparser.ast.type.PrimitiveType.___003Cclinit_003E();
			result = new PrimitiveType(base.tokenRange(), com.github.javaparser.ast.type.PrimitiveType.Primitive.___003C_003ELONG, annotations);
			break;
		case 31:
			jj_consume_token(31);
			com.github.javaparser.ast.type.PrimitiveType.___003Cclinit_003E();
			result = new PrimitiveType(base.tokenRange(), com.github.javaparser.ast.type.PrimitiveType.Primitive.___003C_003EFLOAT, annotations);
			break;
		case 24:
			jj_consume_token(24);
			com.github.javaparser.ast.type.PrimitiveType.___003Cclinit_003E();
			result = new PrimitiveType(base.tokenRange(), com.github.javaparser.ast.type.PrimitiveType.Primitive.___003C_003EDOUBLE, annotations);
			break;
		default:
			jj_la1[72] = jj_gen;
			jj_consume_token(-1);
			
			throw new ParseException();
		}
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 33, 27, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_26(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_26()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(25, xla);
			throw;
		}
		jj_save(25, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(25, xla);
		}
	}

	
	
		
	[LineNumberTable(new byte[]
	{
		170, 241, 135, 102, 103, 103, 105, 199, 127, 2,
		167, 201, 105, 104, 103, 105, 199, 127, 3, 137,
		105
	})]
	public ClassOrInterfaceType ClassOrInterfaceType(NodeList firstAnnotations)
	{
		RangedList rangedList = new RangedList(null);
		new NodeList();
		SimpleName name = SimpleName();
		JavaToken begin = token();
		if (jj_2_28(2))
		{
			rangedList = TypeArguments();
		}
		com.github.javaparser.ast.type.ClassOrInterfaceType.___003Cclinit_003E();
		ClassOrInterfaceType classOrInterfaceType = new ClassOrInterfaceType(base.range(begin, token()), null, name, rangedList.list, firstAnnotations);
		rangedList = new RangedList(null);
		while (jj_2_29(2))
		{
			jj_consume_token(105);
			NodeList annotations = Annotations();
			name = SimpleName();
			if (jj_2_30(2))
			{
				rangedList = TypeArguments();
			}
			com.github.javaparser.ast.type.ClassOrInterfaceType.___003Cclinit_003E();
			classOrInterfaceType = new ClassOrInterfaceType(base.range(begin, token()), classOrInterfaceType, name, rangedList.list, annotations);
			rangedList = new RangedList(null);
		}
		if ("" != null)
		{
			return classOrInterfaceType;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 33, 37, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_27(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_27()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(26, xla);
			throw;
		}
		jj_save(26, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(26, xla);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 33, 47, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_28(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_28()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(27, xla);
			throw;
		}
		jj_save(27, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(27, xla);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 33, 57, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_29(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_29()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(28, xla);
			throw;
		}
		jj_save(28, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(28, xla);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 33, 67, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_30(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_30()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(29, xla);
			throw;
		}
		jj_save(29, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(29, xla);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		171,
		102,
		103,
		byte.MaxValue,
		161,
		86,
		88,
		104,
		162,
		104,
		162,
		111,
		104,
		139,
		105
	})]
	public com.github.javaparser.ast.type.Type TypeArgument()
	{
		NodeList nodeList = Annotations();
		com.github.javaparser.ast.type.Type result;
		switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
		{
		case 13:
		case 15:
		case 18:
		case 24:
		case 26:
		case 31:
		case 38:
		case 40:
		case 48:
		case 50:
		case 52:
		case 65:
		case 66:
		case 67:
		case 68:
		case 69:
		case 70:
		case 71:
		case 72:
		case 73:
		case 74:
		case 75:
		case 94:
			result = Type(nodeList);
			break;
		case 113:
			result = Wildcard(nodeList);
			break;
		default:
			jj_la1[69] = jj_gen;
			jj_consume_token(-1);
			
			throw new ParseException();
		}
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
		
	[LineNumberTable(new byte[]
	{
		171, 153, 98, 130, 102, 105, 103, 191, 14, 159,
		11, 105, 103, 104, 162, 105, 103, 104, 162, 111,
		104, 235, 69, 175, 127, 5
	})]
	public WildcardType Wildcard(NodeList firstAnnotations)
	{
		ReferenceType extendedType = null;
		ReferenceType superType = null;
		new NodeList();
		jj_consume_token(113);
		JavaToken begin = token();
		int num = ((jj_ntk != -1) ? jj_ntk : jj_ntk_f());
		if (num == 27 || num == 53)
		{
			switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
			{
			case 27:
			{
				jj_consume_token(27);
				NodeList annotations = Annotations();
				extendedType = ReferenceType(annotations);
				break;
			}
			case 53:
			{
				jj_consume_token(53);
				NodeList annotations = Annotations();
				superType = ReferenceType(annotations);
				break;
			}
			default:
				jj_la1[70] = jj_gen;
				jj_consume_token(-1);
				
				throw new ParseException();
			}
		}
		else
		{
			jj_la1[71] = jj_gen;
		}
		if ("" != null)
		{
			WildcardType.___003Cclinit_003E();
			WildcardType result = new WildcardType(base.range(begin, token()), extendedType, superType, firstAnnotations);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		172, 120, 159, 160, 96, 105, 165, 105, 165, 105,
		165, 105, 165, 105, 165, 105, 165, 105, 165, 105,
		165, 105, 162, 105, 162, 105, 162, 105, 162, 105,
		162, 105, 162, 105, 162, 111, 104, 139, 116, 105
	})]
	public string Identifier()
	{
		switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
		{
		case 72:
			jj_consume_token(72);
			break;
		case 66:
			jj_consume_token(66);
			break;
		case 67:
			jj_consume_token(67);
			break;
		case 68:
			jj_consume_token(68);
			break;
		case 69:
			jj_consume_token(69);
			break;
		case 70:
			jj_consume_token(70);
			break;
		case 71:
			jj_consume_token(71);
			break;
		case 73:
			jj_consume_token(73);
			break;
		case 74:
			jj_consume_token(74);
			break;
		case 75:
			jj_consume_token(75);
			break;
		case 26:
			jj_consume_token(26);
			break;
		case 52:
			jj_consume_token(52);
			break;
		case 65:
			jj_consume_token(65);
			break;
		case 48:
			jj_consume_token(48);
			break;
		case 94:
			jj_consume_token(94);
			break;
		default:
			jj_la1[74] = jj_gen;
			jj_consume_token(-1);
			
			throw new ParseException();
		}
		string image = this.token.image;
		base.setTokenKind(94);
		if ("" != null)
		{
			return image;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 33, 77, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_31(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_31()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(30, xla);
			throw;
		}
		jj_save(30, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(30, xla);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		173, 132, 103, 159, 3, 105, 103, 105, 103, 123,
		162, 175, 105
	})]
	public Expression ConditionalExpression()
	{
		Expression expression = ConditionalOrExpression();
		if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 113)
		{
			jj_consume_token(113);
			Expression thenExpr = Expression();
			jj_consume_token(114);
			Expression elseExpr = Expression();
			ConditionalExpr.___003Cclinit_003E();
			expression = new ConditionalExpr(base.range(expression, token()), expression, thenExpr, elseExpr);
		}
		else
		{
			jj_la1[80] = jj_gen;
		}
		if ("" != null)
		{
			return expression;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 33, 87, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_32(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_32()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(31, xla);
			throw;
		}
		jj_save(31, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(31, xla);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		173, 49, 159, 160, 81, 105, 102, 165, 108, 102,
		165, 108, 102, 165, 108, 102, 165, 108, 102, 165,
		108, 102, 165, 108, 102, 165, 108, 102, 165, 108,
		102, 162, 108, 102, 162, 108, 102, 162, 108, 102,
		162, 111, 104, 139, 105
	})]
	public AssignExpr.Operator AssignmentOperator()
	{
		AssignExpr.Operator result;
		switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
		{
		case 109:
			jj_consume_token(109);
			result = AssignExpr.Operator.___003C_003EASSIGN;
			break;
		case 135:
			jj_consume_token(135);
			result = AssignExpr.Operator.___003C_003EMULTIPLY;
			break;
		case 136:
			jj_consume_token(136);
			result = AssignExpr.Operator.___003C_003EDIVIDE;
			break;
		case 140:
			jj_consume_token(140);
			result = AssignExpr.Operator.___003C_003EREMAINDER;
			break;
		case 133:
			jj_consume_token(133);
			result = AssignExpr.Operator.___003C_003EPLUS;
			break;
		case 134:
			jj_consume_token(134);
			result = AssignExpr.Operator.___003C_003EMINUS;
			break;
		case 141:
			jj_consume_token(141);
			result = AssignExpr.Operator.___003C_003ELEFT_SHIFT;
			break;
		case 142:
			jj_consume_token(142);
			result = AssignExpr.Operator.___003C_003ESIGNED_RIGHT_SHIFT;
			break;
		case 143:
			jj_consume_token(143);
			result = AssignExpr.Operator.___003C_003EUNSIGNED_RIGHT_SHIFT;
			break;
		case 137:
			jj_consume_token(137);
			result = AssignExpr.Operator.___003C_003EBINARY_AND;
			break;
		case 139:
			jj_consume_token(139);
			result = AssignExpr.Operator.___003C_003EXOR;
			break;
		case 138:
			jj_consume_token(138);
			result = AssignExpr.Operator.___003C_003EBINARY_OR;
			break;
		default:
			jj_la1[79] = jj_gen;
			jj_consume_token(-1);
			
			throw new ParseException();
		}
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		182,
		75,
		98,
		byte.MaxValue,
		161,
		134,
		110,
		103,
		121,
		162,
		103,
		162,
		114,
		104,
		139,
		105
	})]
	public Statement LambdaBody()
	{
		
		Statement result;
		switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
		{
		case 13:
		case 15:
		case 18:
		case 24:
		case 26:
		case 28:
		case 31:
		case 38:
		case 40:
		case 42:
		case 43:
		case 48:
		case 50:
		case 52:
		case 53:
		case 54:
		case 56:
		case 60:
		case 62:
		case 65:
		case 66:
		case 67:
		case 68:
		case 69:
		case 70:
		case 71:
		case 72:
		case 73:
		case 74:
		case 75:
		case 76:
		case 77:
		case 82:
		case 89:
		case 90:
		case 92:
		case 94:
		case 97:
		case 107:
		case 111:
		case 112:
		case 122:
		case 123:
		case 124:
		case 125:
		{
			Expression expression = Expression();
			ExpressionStmt.___003Cclinit_003E();
			result = new ExpressionStmt(base.range(expression, token()), expression);
			break;
		}
		case 99:
			result = Block();
			break;
		default:
			jj_la1[136] = jj_gen;
			jj_consume_token(-1);
			
			throw new ParseException();
		}
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		173, 164, 167, 159, 3, 162, 111, 130, 105, 103,
		159, 5, 105
	})]
	public Expression ConditionalOrExpression()
	{
		Expression expression = ConditionalAndExpression();
		while (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 121)
		{
			jj_consume_token(121);
			Expression right = ConditionalAndExpression();
			BinaryExpr.___003Cclinit_003E();
			expression = new BinaryExpr(base.range(expression, token()), expression, right, BinaryExpr.Operator.___003C_003EOR);
		}
		jj_la1[81] = jj_gen;
		if ("" != null)
		{
			return expression;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		173, 209, 167, 159, 3, 162, 111, 130, 105, 103,
		159, 5, 105
	})]
	public Expression ConditionalAndExpression()
	{
		Expression expression = InclusiveOrExpression();
		while (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 120)
		{
			jj_consume_token(120);
			Expression right = InclusiveOrExpression();
			BinaryExpr.___003Cclinit_003E();
			expression = new BinaryExpr(base.range(expression, token()), expression, right, BinaryExpr.Operator.___003C_003EAND);
		}
		jj_la1[82] = jj_gen;
		if ("" != null)
		{
			return expression;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		173, 249, 167, 159, 6, 162, 111, 130, 108, 103,
		159, 5, 105
	})]
	public Expression InclusiveOrExpression()
	{
		Expression expression = ExclusiveOrExpression();
		while (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 129)
		{
			jj_consume_token(129);
			Expression right = ExclusiveOrExpression();
			BinaryExpr.___003Cclinit_003E();
			expression = new BinaryExpr(base.range(expression, token()), expression, right, BinaryExpr.Operator.___003C_003EBINARY_OR);
		}
		jj_la1[83] = jj_gen;
		if ("" != null)
		{
			return expression;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		174, 33, 167, 159, 6, 162, 111, 130, 108, 103,
		159, 5, 105
	})]
	public Expression ExclusiveOrExpression()
	{
		Expression expression = AndExpression();
		while (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 130)
		{
			jj_consume_token(130);
			Expression right = AndExpression();
			BinaryExpr.___003Cclinit_003E();
			expression = new BinaryExpr(base.range(expression, token()), expression, right, BinaryExpr.Operator.___003C_003EXOR);
		}
		jj_la1[84] = jj_gen;
		if ("" != null)
		{
			return expression;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		174, 73, 167, 159, 6, 162, 111, 130, 108, 103,
		159, 5, 105
	})]
	public Expression AndExpression()
	{
		Expression expression = EqualityExpression();
		while (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 128)
		{
			jj_consume_token(128);
			Expression right = EqualityExpression();
			BinaryExpr.___003Cclinit_003E();
			expression = new BinaryExpr(base.range(expression, token()), expression, right, BinaryExpr.Operator.___003C_003EBINARY_AND);
		}
		jj_la1[85] = jj_gen;
		if ("" != null)
		{
			return expression;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		174, 118, 167, 191, 11, 162, 111, 133, 159, 11,
		105, 102, 162, 105, 102, 162, 111, 104, 139, 103,
		159, 1, 105
	})]
	public Expression EqualityExpression()
	{
		Expression expression = InstanceOfExpression();
		while (true)
		{
			int num = ((jj_ntk != -1) ? jj_ntk : jj_ntk_f());
			if (num != 116 && num != 119)
			{
				break;
			}
			BinaryExpr.Operator @operator;
			switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
			{
			case 116:
				jj_consume_token(116);
				@operator = BinaryExpr.Operator.___003C_003EEQUALS;
				break;
			case 119:
				jj_consume_token(119);
				@operator = BinaryExpr.Operator.___003C_003ENOT_EQUALS;
				break;
			default:
				jj_la1[87] = jj_gen;
				jj_consume_token(-1);
				
				throw new ParseException();
			}
			Expression right = InstanceOfExpression();
			BinaryExpr.___003Cclinit_003E();
			expression = new BinaryExpr(base.range(expression, token()), expression, right, @operator);
		}
		jj_la1[86] = jj_gen;
		if ("" != null)
		{
			return expression;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		174,
		186,
		103,
		159,
		6,
		105,
		109,
		103,
		159,
		6,
		byte.MaxValue,
		161,
		62,
		89,
		103,
		123,
		162,
		111,
		104,
		235,
		70,
		175,
		105
	})]
	public Expression InstanceOfExpression()
	{
		Expression expression = RelationalExpression();
		if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 37)
		{
			jj_consume_token(37);
			if (jj_2_33(int.MaxValue))
			{
				PatternExpr patternExpr = PatternExpression();
				InstanceOfExpr.___003Cclinit_003E();
				expression = new InstanceOfExpr(base.range(expression, token()), expression, patternExpr.getType(), patternExpr);
			}
			else
			{
				switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
				{
				case 13:
				case 15:
				case 18:
				case 24:
				case 26:
				case 31:
				case 38:
				case 40:
				case 48:
				case 50:
				case 52:
				case 65:
				case 66:
				case 67:
				case 68:
				case 69:
				case 70:
				case 71:
				case 72:
				case 73:
				case 74:
				case 75:
				case 94:
				case 107:
					break;
				default:
					jj_la1[88] = jj_gen;
					jj_consume_token(-1);
					
					throw new ParseException();
				}
				ReferenceType type = AnnotatedReferenceType();
				InstanceOfExpr.___003Cclinit_003E();
				expression = new InstanceOfExpr(base.range(expression, token()), expression, type, null);
			}
		}
		else
		{
			jj_la1[89] = jj_gen;
		}
		if ("" != null)
		{
			return expression;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		175,
		11,
		167,
		byte.MaxValue,
		30,
		69,
		162,
		111,
		133,
		159,
		30,
		105,
		102,
		162,
		108,
		102,
		162,
		105,
		102,
		162,
		105,
		102,
		162,
		111,
		104,
		139,
		103,
		159,
		1,
		105
	})]
	public Expression RelationalExpression()
	{
		Expression expression = ShiftExpression();
		while (true)
		{
			int num = ((jj_ntk != -1) ? jj_ntk : jj_ntk_f());
			if (num != 110 && num != 117 && num != 118 && num != 146)
			{
				break;
			}
			BinaryExpr.Operator @operator;
			switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
			{
			case 110:
				jj_consume_token(110);
				@operator = BinaryExpr.Operator.___003C_003ELESS;
				break;
			case 146:
				jj_consume_token(146);
				@operator = BinaryExpr.Operator.___003C_003EGREATER;
				break;
			case 118:
				jj_consume_token(118);
				@operator = BinaryExpr.Operator.___003C_003ELESS_EQUALS;
				break;
			case 117:
				jj_consume_token(117);
				@operator = BinaryExpr.Operator.___003C_003EGREATER_EQUALS;
				break;
			default:
				jj_la1[91] = jj_gen;
				jj_consume_token(-1);
				
				throw new ParseException();
			}
			Expression right = ShiftExpression();
			BinaryExpr.___003Cclinit_003E();
			expression = new BinaryExpr(base.range(expression, token()), expression, right, @operator);
		}
		jj_la1[90] = jj_gen;
		if ("" != null)
		{
			return expression;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 33, 97, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_33(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_33()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(32, xla);
			throw;
		}
		jj_save(32, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(32, xla);
		}
	}

	
	
	
	public PatternExpr PatternExpression()
	{
		ReferenceType referenceType = AnnotatedReferenceType();
		SimpleName name = SimpleName();
		if ("" != null)
		{
			PatternExpr.___003Cclinit_003E();
			PatternExpr result = new PatternExpr(base.range(referenceType, token()), referenceType, name);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		175, 71, 167, 204, 159, 6, 108, 102, 162, 111,
		105, 102, 104, 105, 102, 136, 104, 171, 103, 159,
		1, 105
	})]
	public Expression ShiftExpression()
	{
		Expression expression = AdditiveExpression();
		while (jj_2_34(1))
		{
			BinaryExpr.Operator @operator;
			if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 132)
			{
				jj_consume_token(132);
				@operator = BinaryExpr.Operator.___003C_003ELEFT_SHIFT;
			}
			else
			{
				jj_la1[92] = jj_gen;
				if (jj_2_35(1))
				{
					RSIGNEDSHIFT();
					@operator = BinaryExpr.Operator.___003C_003ESIGNED_RIGHT_SHIFT;
				}
				else
				{
					if (!jj_2_36(1))
					{
						jj_consume_token(-1);
						
						throw new ParseException();
					}
					RUNSIGNEDSHIFT();
					@operator = BinaryExpr.Operator.___003C_003EUNSIGNED_RIGHT_SHIFT;
				}
			}
			Expression right = AdditiveExpression();
			BinaryExpr.___003Cclinit_003E();
			expression = new BinaryExpr(base.range(expression, token()), expression, right, @operator);
		}
		if ("" != null)
		{
			return expression;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		175, 116, 167, 191, 11, 162, 111, 133, 159, 11,
		105, 102, 162, 105, 102, 162, 111, 104, 139, 103,
		159, 1, 105
	})]
	public Expression AdditiveExpression()
	{
		Expression expression = MultiplicativeExpression();
		while (true)
		{
			int num = ((jj_ntk != -1) ? jj_ntk : jj_ntk_f());
			if (num != 124 && num != 125)
			{
				break;
			}
			BinaryExpr.Operator @operator;
			switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
			{
			case 124:
				jj_consume_token(124);
				@operator = BinaryExpr.Operator.___003C_003EPLUS;
				break;
			case 125:
				jj_consume_token(125);
				@operator = BinaryExpr.Operator.___003C_003EMINUS;
				break;
			default:
				jj_la1[94] = jj_gen;
				jj_consume_token(-1);
				
				throw new ParseException();
			}
			Expression right = MultiplicativeExpression();
			BinaryExpr.___003Cclinit_003E();
			expression = new BinaryExpr(base.range(expression, token()), expression, right, @operator);
		}
		jj_la1[93] = jj_gen;
		if ("" != null)
		{
			return expression;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 33, 107, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_34(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_34()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(33, xla);
			throw;
		}
		jj_save(33, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(33, xla);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 33, 117, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_35(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_35()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(34, xla);
			throw;
		}
		jj_save(34, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(34, xla);
		}
	}

	
	
	
	public void RSIGNEDSHIFT()
	{
		if (getToken(1).kind != 146 || getToken(1).realKind != 145)
		{
			jj_consume_token(-1);
			
			throw new ParseException();
		}
		jj_consume_token(146);
		jj_consume_token(146);
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 33, 127, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_36(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_36()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(35, xla);
			throw;
		}
		jj_save(35, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(35, xla);
		}
	}

	
	
	
	public void RUNSIGNEDSHIFT()
	{
		if (getToken(1).kind != 146 || getToken(1).realKind != 144)
		{
			jj_consume_token(-1);
			
			throw new ParseException();
		}
		jj_consume_token(146);
		jj_consume_token(146);
		jj_consume_token(146);
	}

	
	
	[LineNumberTable(new byte[]
	{
		175, 164, 167, 223, 22, 162, 111, 133, 159, 22,
		105, 102, 162, 105, 102, 162, 108, 102, 162, 111,
		104, 139, 103, 159, 1, 105
	})]
	public Expression MultiplicativeExpression()
	{
		Expression expression = UnaryExpression();
		while (true)
		{
			int num = ((jj_ntk != -1) ? jj_ntk : jj_ntk_f());
			if (num != 126 && num != 127 && num != 131)
			{
				break;
			}
			BinaryExpr.Operator @operator;
			switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
			{
			case 126:
				jj_consume_token(126);
				@operator = BinaryExpr.Operator.___003C_003EMULTIPLY;
				break;
			case 127:
				jj_consume_token(127);
				@operator = BinaryExpr.Operator.___003C_003EDIVIDE;
				break;
			case 131:
				jj_consume_token(131);
				@operator = BinaryExpr.Operator.___003C_003EREMAINDER;
				break;
			default:
				jj_la1[96] = jj_gen;
				jj_consume_token(-1);
				
				throw new ParseException();
			}
			Expression right = UnaryExpression();
			BinaryExpr.___003Cclinit_003E();
			expression = new BinaryExpr(base.range(expression, token()), expression, right, @operator);
		}
		jj_la1[95] = jj_gen;
		if ("" != null)
		{
			return expression;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		175, 228, 102, 159, 161, 137, 103, 165, 103, 197,
		159, 11, 105, 109, 162, 105, 109, 162, 111, 104,
		139, 103, 122, 226, 107, 103, 162, 111, 104, 139,
		105
	})]
	public Expression UnaryExpression()
	{
		_ = JavaToken.___003C_003EINVALID;
		Expression result;
		switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
		{
		case 122:
			result = PreIncrementExpression();
			break;
		case 123:
			result = PreDecrementExpression();
			break;
		case 124:
		case 125:
		{
			UnaryExpr.Operator @operator;
			JavaToken begin;
			switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
			{
			case 124:
				jj_consume_token(124);
				@operator = UnaryExpr.Operator.___003C_003EPLUS;
				begin = token();
				break;
			case 125:
				jj_consume_token(125);
				@operator = UnaryExpr.Operator.___003C_003EMINUS;
				begin = token();
				break;
			default:
				jj_la1[97] = jj_gen;
				jj_consume_token(-1);
				
				throw new ParseException();
			}
			result = UnaryExpression();
			UnaryExpr.___003Cclinit_003E();
			result = new UnaryExpr(base.range(begin, token()), result, @operator);
			break;
		}
		case 13:
		case 15:
		case 18:
		case 24:
		case 26:
		case 28:
		case 31:
		case 38:
		case 40:
		case 42:
		case 43:
		case 48:
		case 50:
		case 52:
		case 53:
		case 54:
		case 56:
		case 60:
		case 62:
		case 65:
		case 66:
		case 67:
		case 68:
		case 69:
		case 70:
		case 71:
		case 72:
		case 73:
		case 74:
		case 75:
		case 76:
		case 77:
		case 82:
		case 89:
		case 90:
		case 92:
		case 94:
		case 97:
		case 107:
		case 111:
		case 112:
			result = UnaryExpressionNotPlusMinus();
			break;
		default:
			jj_la1[98] = jj_gen;
			jj_consume_token(-1);
			
			throw new ParseException();
		}
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	
	public Expression PreIncrementExpression()
	{
		_ = JavaToken.___003C_003EINVALID;
		jj_consume_token(122);
		JavaToken begin = token();
		Expression expression = UnaryExpression();
		UnaryExpr.___003Cclinit_003E();
		UnaryExpr result = new UnaryExpr(base.range(begin, token()), expression, UnaryExpr.Operator.___003C_003EPREFIX_INCREMENT);
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	
	public Expression PreDecrementExpression()
	{
		jj_consume_token(123);
		JavaToken begin = token();
		Expression expression = UnaryExpression();
		UnaryExpr.___003Cclinit_003E();
		UnaryExpr result = new UnaryExpr(base.range(begin, token()), expression, UnaryExpr.Operator.___003C_003EPREFIX_DECREMENT);
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		176,
		104,
		102,
		191,
		14,
		159,
		11,
		105,
		109,
		162,
		105,
		109,
		162,
		111,
		104,
		139,
		103,
		122,
		165,
		111,
		109,
		140,
		byte.MaxValue,
		161,
		62,
		103,
		103,
		162,
		103,
		162,
		111,
		104,
		203,
		105
	})]
	public Expression UnaryExpressionNotPlusMinus()
	{
		_ = JavaToken.___003C_003EINVALID;
		int num = ((jj_ntk != -1) ? jj_ntk : jj_ntk_f());
		Expression expression;
		if (num == 111 || num == 112)
		{
			UnaryExpr.Operator @operator;
			JavaToken begin;
			switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
			{
			case 112:
				jj_consume_token(112);
				@operator = UnaryExpr.Operator.___003C_003EBITWISE_COMPLEMENT;
				begin = token();
				break;
			case 111:
				jj_consume_token(111);
				@operator = UnaryExpr.Operator.___003C_003ELOGICAL_COMPLEMENT;
				begin = token();
				break;
			default:
				jj_la1[99] = jj_gen;
				jj_consume_token(-1);
				
				throw new ParseException();
			}
			expression = UnaryExpression();
			UnaryExpr.___003Cclinit_003E();
			expression = new UnaryExpr(base.range(begin, token()), expression, @operator);
		}
		else
		{
			jj_la1[100] = jj_gen;
			if (jj_2_37(int.MaxValue))
			{
				expression = CastExpression();
			}
			else
			{
				switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
				{
				case 13:
				case 15:
				case 18:
				case 24:
				case 26:
				case 28:
				case 31:
				case 38:
				case 40:
				case 42:
				case 43:
				case 48:
				case 50:
				case 52:
				case 53:
				case 56:
				case 60:
				case 62:
				case 65:
				case 66:
				case 67:
				case 68:
				case 69:
				case 70:
				case 71:
				case 72:
				case 73:
				case 74:
				case 75:
				case 76:
				case 77:
				case 82:
				case 89:
				case 90:
				case 92:
				case 94:
				case 97:
				case 107:
					expression = PostfixExpression();
					break;
				case 54:
					expression = SwitchExpression();
					break;
				default:
					jj_la1[101] = jj_gen;
					jj_consume_token(-1);
					
					throw new ParseException();
				}
			}
		}
		if ("" != null)
		{
			return expression;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 33, 137, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_37(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_37()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(36, xla);
			throw;
		}
		jj_save(36, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(36, xla);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		176,
		245,
		134,
		103,
		105,
		103,
		103,
		105,
		104,
		105,
		104,
		159,
		2,
		byte.MaxValue,
		161,
		13,
		90,
		105,
		170,
		159,
		6,
		162,
		111,
		130,
		108,
		104,
		140,
		105,
		104,
		105,
		159,
		36,
		157,
		162,
		111,
		104,
		171,
		106
	})]
	public Expression CastExpression()
	{
		_ = JavaToken.___003C_003EINVALID;
		NodeList list = base.emptyNodeList();
		jj_consume_token(97);
		JavaToken begin = token();
		NodeList annotations = Annotations();
		CastExpr result;
		if (jj_2_39(2))
		{
			PrimitiveType type = PrimitiveType(annotations);
			jj_consume_token(98);
			Expression expression = UnaryExpression();
			CastExpr.___003Cclinit_003E();
			result = new CastExpr(base.range(begin, token()), type, expression);
		}
		else
		{
			switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
			{
			case 13:
			case 15:
			case 18:
			case 24:
			case 26:
			case 31:
			case 38:
			case 40:
			case 48:
			case 50:
			case 52:
			case 65:
			case 66:
			case 67:
			case 68:
			case 69:
			case 70:
			case 71:
			case 72:
			case 73:
			case 74:
			case 75:
			case 94:
				break;
			default:
				jj_la1[104] = jj_gen;
				jj_consume_token(-1);
				
				throw new ParseException();
			}
			ReferenceType referenceType = ReferenceType(annotations);
			list = base.add(list, referenceType);
			while (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 128)
			{
				jj_consume_token(128);
				referenceType = AnnotatedReferenceType();
				list = base.add(list, referenceType);
			}
			jj_la1[103] = jj_gen;
			jj_consume_token(98);
			Expression expression = UnaryExpressionNotPlusMinus();
			if (list.size() > 1)
			{
				CastExpr.___003Cclinit_003E();
				TokenRange obj = base.range(begin, token());
				com.github.javaparser.ast.type.IntersectionType.___003Cclinit_003E();
				result = new CastExpr(obj, new IntersectionType(base.range(list.get(0), list.get(list.size() - 1)), list), expression);
			}
			else
			{
				CastExpr.___003Cclinit_003E();
				result = new CastExpr(base.range(begin, token()), referenceType, expression);
			}
		}
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		176, 202, 103, 108, 159, 11, 105, 102, 162, 105,
		102, 162, 111, 104, 139, 218, 105
	})]
	public Expression PostfixExpression()
	{
		Expression expression = PrimaryExpression();
		if (jj_2_38(2))
		{
			UnaryExpr.Operator @operator;
			switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
			{
			case 122:
				jj_consume_token(122);
				@operator = UnaryExpr.Operator.___003C_003EPOSTFIX_INCREMENT;
				break;
			case 123:
				jj_consume_token(123);
				@operator = UnaryExpr.Operator.___003C_003EPOSTFIX_DECREMENT;
				break;
			default:
				jj_la1[102] = jj_gen;
				jj_consume_token(-1);
				
				throw new ParseException();
			}
			UnaryExpr.___003Cclinit_003E();
			expression = new UnaryExpr(base.range(expression, token()), expression, @operator);
		}
		if ("" != null)
		{
			return expression;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		183, 85, 135, 105, 103, 105, 103, 105, 169, 191,
		11, 162, 114, 130, 103, 139, 105, 127, 4
	})]
	public SwitchExpr SwitchExpression()
	{
		NodeList nodeList = base.emptyNodeList();
		jj_consume_token(54);
		JavaToken begin = token();
		jj_consume_token(97);
		Expression selector = Expression();
		jj_consume_token(98);
		jj_consume_token(99);
		while (true)
		{
			int num = ((jj_ntk != -1) ? jj_ntk : jj_ntk_f());
			if (num != 16 && num != 22)
			{
				break;
			}
			SwitchEntry obj = SwitchEntry();
			nodeList = base.add(nodeList, obj);
		}
		jj_la1[141] = jj_gen;
		jj_consume_token(100);
		if ("" != null)
		{
			SwitchExpr.___003Cclinit_003E();
			SwitchExpr result = new SwitchExpr(base.range(begin, token()), selector, nodeList);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	
	public Expression PrimaryExpression()
	{
		Expression expression = PrimaryPrefix();
		while (jj_2_40(2))
		{
			expression = PrimarySuffix(expression);
		}
		if ("" != null)
		{
			return expression;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 33, 147, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_38(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_38()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(37, xla);
			throw;
		}
		jj_save(37, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(37, xla);
		}
	}

	private bool jj_2_39(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_39()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(38, xla);
			throw;
		}
		jj_save(38, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(38, xla);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		177,
		115,
		130,
		103,
		103,
		103,
		98,
		162,
		98,
		98,
		byte.MaxValue,
		120,
		74,
		104,
		165,
		105,
		115,
		165,
		105,
		115,
		159,
		17,
		105,
		159,
		3,
		103,
		162,
		175,
		104,
		159,
		3,
		103,
		98,
		162,
		175,
		99,
		159,
		11,
		159,
		5,
		165,
		105,
		159,
		3,
		103,
		162,
		175,
		byte.MaxValue,
		160,
		214,
		80,
		103,
		162,
		105,
		162,
		111,
		104,
		139,
		127,
		14,
		165,
		111,
		104,
		235,
		69,
		105,
		104,
		159,
		3,
		105,
		127,
		2,
		165,
		111,
		109,
		103,
		105,
		127,
		7,
		109,
		103,
		105,
		159,
		7,
		byte.MaxValue,
		161,
		134,
		111,
		104,
		105,
		124,
		165,
		111,
		104,
		235,
		71,
		105,
		165,
		111,
		109,
		110,
		105,
		105,
		127,
		2,
		112,
		104,
		105,
		159,
		3,
		103,
		162,
		175,
		byte.MaxValue,
		160,
		214,
		80,
		103,
		162,
		105,
		162,
		111,
		104,
		139,
		120,
		159,
		19,
		byte.MaxValue,
		160,
		72,
		80,
		104,
		104,
		159,
		3,
		103,
		98,
		162,
		175,
		99,
		159,
		2,
		137,
		162,
		111,
		104,
		203,
		106
	})]
	public Expression PrimaryPrefix()
	{
		
		RangedList rangedList = new RangedList(null);
		NodeList arguments = base.emptyNodeList();
		NodeList parameters = base.emptyNodeList();
		int num = 0;
		_ = 0;
		
		
		Expression result;
		switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
		{
		case 28:
		case 43:
		case 60:
		case 76:
		case 77:
		case 82:
		case 89:
		case 90:
		case 92:
			result = Literal();
			break;
		case 56:
			jj_consume_token(56);
			ThisExpr.___003Cclinit_003E();
			result = new ThisExpr(base.tokenRange(), null);
			break;
		case 53:
		{
			jj_consume_token(53);
			SuperExpr.___003Cclinit_003E();
			SuperExpr superExpr = new SuperExpr(base.tokenRange(), null);
			switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
			{
			case 105:
			{
				jj_consume_token(105);
				if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 110)
				{
					rangedList = TypeArguments();
				}
				else
				{
					jj_la1[105] = jj_gen;
				}
				SimpleName name = SimpleName();
				if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 97)
				{
					arguments = Arguments();
					num = 1;
				}
				else
				{
					jj_la1[106] = jj_gen;
				}
				if (num != 0)
				{
					MethodCallExpr.___003Cclinit_003E();
					result = new MethodCallExpr(base.range(superExpr, token()), superExpr, rangedList.list, name, arguments);
				}
				else
				{
					FieldAccessExpr.___003Cclinit_003E();
					result = new FieldAccessExpr(base.range(superExpr, token()), superExpr, base.emptyNodeList(), name);
				}
				break;
			}
			case 108:
				jj_consume_token(108);
				if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 110)
				{
					rangedList = TypeArguments();
				}
				else
				{
					jj_la1[107] = jj_gen;
				}
				switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
				{
				case 26:
				case 48:
				case 52:
				case 65:
				case 66:
				case 67:
				case 68:
				case 69:
				case 70:
				case 71:
				case 72:
				case 73:
				case 74:
				case 75:
				case 94:
					Identifier();
					break;
				case 42:
					jj_consume_token(42);
					break;
				default:
					jj_la1[108] = jj_gen;
					jj_consume_token(-1);
					
					throw new ParseException();
				}
				MethodReferenceExpr.___003Cclinit_003E();
				result = new MethodReferenceExpr(base.range(superExpr, token()), superExpr, rangedList.list, this.token.image);
				break;
			default:
				jj_la1[109] = jj_gen;
				jj_consume_token(-1);
				
				throw new ParseException();
			}
			break;
		}
		case 97:
		{
			jj_consume_token(97);
			JavaToken begin = token();
			if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 98)
			{
				jj_consume_token(98);
				LambdaExpr.___003Cclinit_003E();
				result = new LambdaExpr(base.range(begin, token()), parameters, new BlockStmt(), isEnclosingParameters: true);
				break;
			}
			jj_la1[110] = jj_gen;
			if (jj_2_42(int.MaxValue))
			{
				parameters = LambdaParameters();
				jj_consume_token(98);
				LambdaExpr.___003Cclinit_003E();
				result = new LambdaExpr(base.range(begin, token()), parameters, new BlockStmt(), isEnclosingParameters: true);
				break;
			}
			if (jj_2_43(int.MaxValue))
			{
				parameters = InferredLambdaParameters();
				jj_consume_token(98);
				LambdaExpr.___003Cclinit_003E();
				result = new LambdaExpr(base.range(begin, token()), parameters, new BlockStmt(), isEnclosingParameters: true);
				break;
			}
			switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
			{
			case 13:
			case 15:
			case 18:
			case 24:
			case 26:
			case 28:
			case 31:
			case 38:
			case 40:
			case 42:
			case 43:
			case 48:
			case 50:
			case 52:
			case 53:
			case 54:
			case 56:
			case 60:
			case 62:
			case 65:
			case 66:
			case 67:
			case 68:
			case 69:
			case 70:
			case 71:
			case 72:
			case 73:
			case 74:
			case 75:
			case 76:
			case 77:
			case 82:
			case 89:
			case 90:
			case 92:
			case 94:
			case 97:
			case 107:
			case 111:
			case 112:
			case 122:
			case 123:
			case 124:
			case 125:
				break;
			default:
				jj_la1[111] = jj_gen;
				jj_consume_token(-1);
				
				throw new ParseException();
			}
			result = Expression();
			jj_consume_token(98);
			EnclosedExpr.___003Cclinit_003E();
			result = new EnclosedExpr(base.range(begin, token()), result);
			break;
		}
		case 42:
			result = AllocationExpression(null);
			break;
		default:
			jj_la1[115] = jj_gen;
			if (jj_2_44(int.MaxValue))
			{
				com.github.javaparser.ast.type.Type type = ResultType(base.emptyNodeList());
				jj_consume_token(105);
				jj_consume_token(19);
				ClassExpr.___003Cclinit_003E();
				result = new ClassExpr(base.range(type, token()), type);
			}
			else if (jj_2_45(int.MaxValue))
			{
				com.github.javaparser.ast.type.Type type = AnnotatedType();
				jj_consume_token(108);
				if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 110)
				{
					rangedList = TypeArguments();
				}
				else
				{
					jj_la1[112] = jj_gen;
				}
				switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
				{
				case 26:
				case 48:
				case 52:
				case 65:
				case 66:
				case 67:
				case 68:
				case 69:
				case 70:
				case 71:
				case 72:
				case 73:
				case 74:
				case 75:
				case 94:
					Identifier();
					break;
				case 42:
					jj_consume_token(42);
					break;
				default:
					jj_la1[113] = jj_gen;
					jj_consume_token(-1);
					
					throw new ParseException();
				}
				TypeExpr.___003Cclinit_003E();
				TypeExpr typeExpr = new TypeExpr(base.range(type, type), type);
				MethodReferenceExpr.___003Cclinit_003E();
				result = new MethodReferenceExpr(base.range(typeExpr, token()), typeExpr, rangedList.list, this.token.image);
			}
			else
			{
				int num2 = ((jj_ntk != -1) ? jj_ntk : jj_ntk_f());
				if (num2 != 26 && num2 != 48 && num2 != 52 && num2 != 65 && num2 != 66 && num2 != 67 && num2 != 68 && num2 != 69 && num2 != 70 && num2 != 71 && num2 != 72 && num2 != 73 && num2 != 74 && num2 != 75 && num2 != 94)
				{
					jj_la1[116] = jj_gen;
					jj_consume_token(-1);
					
					throw new ParseException();
				}
				SimpleName name = SimpleName();
				JavaToken begin = token();
				if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 97)
				{
					arguments = Arguments();
					num = 1;
				}
				else
				{
					jj_la1[114] = jj_gen;
				}
				if (num != 0)
				{
					MethodCallExpr.___003Cclinit_003E();
					result = new MethodCallExpr(base.range(begin, token()), null, null, name, arguments);
				}
				else
				{
					result = new NameExpr(name);
				}
			}
			break;
		}
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 33, 167, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_40(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_40()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(39, xla);
			throw;
		}
		jj_save(39, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(39, xla);
		}
	}

	
	
	
	[LineNumberTable(new byte[]
	{
		178, 155, 105, 141, 159, 3, 105, 105, 127, 0,
		162, 111, 104, 171, 105
	})]
	public Expression PrimarySuffix(Expression scope)
	{
		Expression result;
		if (jj_2_46(2))
		{
			result = PrimarySuffixWithoutSuper(scope);
		}
		else
		{
			if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) != 105)
			{
				jj_la1[117] = jj_gen;
				jj_consume_token(-1);
				
				throw new ParseException();
			}
			jj_consume_token(105);
			jj_consume_token(53);
			SuperExpr.___003Cclinit_003E();
			result = new SuperExpr(base.range(scope, token()), base.scopeToName(scope));
		}
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 33, 177, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_41(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_41()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(40, xla);
			throw;
		}
		jj_save(40, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(40, xla);
		}
	}

	
	
	
	[LineNumberTable(new byte[]
	{
		178, 179, 103, 103, 130, 159, 17, 105, 159, 11,
		105, 127, 0, 165, 104, 165, 111, 112, 159, 3,
		103, 162, 175, 104, 159, 3, 103, 98, 162, 175,
		99, 159, 8, 191, 4, 104, 235, 70, 105, 103,
		105, 122, 162, 111, 104, 139, 105
	})]
	public Expression PrimarySuffixWithoutSuper(Expression scope)
	{
		RangedList rangedList = new RangedList(null);
		NodeList arguments = base.emptyNodeList();
		int num = 0;
		Expression index;
		switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
		{
		case 105:
			jj_consume_token(105);
			switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
			{
			case 56:
				jj_consume_token(56);
				ThisExpr.___003Cclinit_003E();
				index = new ThisExpr(base.range(scope, token()), base.scopeToName(scope));
				break;
			case 42:
				index = AllocationExpression(scope);
				break;
			default:
				jj_la1[120] = jj_gen;
				if (jj_2_47(int.MaxValue))
				{
					if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 110)
					{
						rangedList = TypeArguments();
					}
					else
					{
						jj_la1[118] = jj_gen;
					}
					SimpleName name = SimpleName();
					if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 97)
					{
						arguments = Arguments();
						num = 1;
					}
					else
					{
						jj_la1[119] = jj_gen;
					}
					if (num != 0)
					{
						MethodCallExpr.___003Cclinit_003E();
						index = new MethodCallExpr(base.range(scope, token()), scope, rangedList.list, name, arguments);
					}
					else
					{
						FieldAccessExpr.___003Cclinit_003E();
						index = new FieldAccessExpr(base.range(scope, token()), scope, rangedList.list, name);
					}
					break;
				}
				jj_consume_token(-1);
				
				throw new ParseException();
			}
			break;
		case 101:
			jj_consume_token(101);
			index = Expression();
			jj_consume_token(102);
			ArrayAccessExpr.___003Cclinit_003E();
			index = new ArrayAccessExpr(base.range(scope, token()), scope, index);
			break;
		default:
			jj_la1[121] = jj_gen;
			jj_consume_token(-1);
			
			throw new ParseException();
		}
		if ("" != null)
		{
			return index;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		179, 6, 159, 91, 105, 124, 165, 105, 124, 165,
		105, 124, 165, 105, 127, 3, 165, 105, 127, 3,
		162, 105, 127, 3, 194, 103, 162, 103, 162, 111,
		104, 139, 105
	})]
	public Expression Literal()
	{
		Expression result;
		switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
		{
		case 77:
			jj_consume_token(77);
			IntegerLiteralExpr.___003Cclinit_003E();
			result = new IntegerLiteralExpr(base.tokenRange(), this.token.image);
			break;
		case 76:
			jj_consume_token(76);
			LongLiteralExpr.___003Cclinit_003E();
			result = new LongLiteralExpr(base.tokenRange(), this.token.image);
			break;
		case 82:
			jj_consume_token(82);
			DoubleLiteralExpr.___003Cclinit_003E();
			result = new DoubleLiteralExpr(base.tokenRange(), this.token.image);
			break;
		case 89:
			jj_consume_token(89);
			CharLiteralExpr.___003Cclinit_003E();
			result = new CharLiteralExpr(base.tokenRange(), base.unquote(this.token.image));
			break;
		case 90:
			jj_consume_token(90);
			StringLiteralExpr.___003Cclinit_003E();
			result = new StringLiteralExpr(base.tokenRange(), base.unquote(this.token.image));
			break;
		case 92:
			jj_consume_token(92);
			TextBlockLiteralExpr.___003Cclinit_003E();
			result = new TextBlockLiteralExpr(base.tokenRange(), base.unTripleQuote(this.token.image));
			break;
		case 28:
		case 60:
			result = BooleanLiteral();
			break;
		case 43:
			result = NullLiteral();
			break;
		default:
			jj_la1[122] = jj_gen;
			jj_consume_token(-1);
			
			throw new ParseException();
		}
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 33, 187, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_42(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_42()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(41, xla);
			throw;
		}
		jj_save(41, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(41, xla);
		}
	}

	
	
		[LineNumberTable(new byte[]
	{
		168, 110, 130, 103, 169, 159, 3, 162, 111, 130,
		105, 103, 139, 105
	})]
	public NodeList LambdaParameters()
	{
		
		Parameter obj = Parameter();
		NodeList nodeList = base.add(null, obj);
		while (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 104)
		{
			jj_consume_token(104);
			obj = Parameter();
			nodeList = base.add(nodeList, obj);
		}
		jj_la1[54] = jj_gen;
		if ("" != null)
		{
			return nodeList;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 33, 197, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_43(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_43()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(42, xla);
			throw;
		}
		jj_save(42, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(42, xla);
		}
	}

	
	
		[LineNumberTable(new byte[]
	{
		168, 163, 130, 103, 191, 49, 159, 3, 162, 111,
		130, 105, 103, 159, 54, 105
	})]
	public NodeList InferredLambdaParameters()
	{
		
		Pair pair = VariableDeclaratorId();
		com.github.javaparser.ast.body.Parameter.___003Cclinit_003E();
		NodeList nodeList = base.add(null, new Parameter(base.range((Node)pair.___003C_003Ea, (Node)pair.___003C_003Ea), new NodeList(), base.emptyNodeList(), new UnknownType(), isVarArgs: false, base.emptyNodeList(), (SimpleName)pair.___003C_003Ea));
		while (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 104)
		{
			jj_consume_token(104);
			pair = VariableDeclaratorId();
			NodeList list = nodeList;
			com.github.javaparser.ast.body.Parameter.___003Cclinit_003E();
			nodeList = base.add(list, new Parameter(base.range((Node)pair.___003C_003Ea, (Node)pair.___003C_003Ea), new NodeList(), base.emptyNodeList(), new UnknownType(), isVarArgs: false, base.emptyNodeList(), (SimpleName)pair.___003C_003Ea));
		}
		jj_la1[55] = jj_gen;
		if ("" != null)
		{
			return nodeList;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	
	[LineNumberTable(new byte[]
	{
		179,
		240,
		103,
		130,
		102,
		102,
		105,
		117,
		159,
		3,
		103,
		162,
		175,
		103,
		byte.MaxValue,
		161,
		13,
		74,
		105,
		107,
		229,
		82,
		105,
		223,
		19,
		107,
		197,
		104,
		105,
		199,
		127,
		11,
		162,
		111,
		104,
		235,
		69,
		114,
		104,
		139,
		106
	})]
	public Expression AllocationExpression(Expression scope)
	{
		RangedList rangedList = new RangedList(null);
		NodeList anonymousClassBody = null;
		JavaToken __003C_003EINVALID = JavaToken.___003C_003EINVALID;
		new NodeList();
		jj_consume_token(42);
		__003C_003EINVALID = ((scope != null) ? base.orIfInvalid(__003C_003EINVALID, scope) : token());
		if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 110)
		{
			rangedList = TypeArguments();
		}
		else
		{
			jj_la1[126] = jj_gen;
		}
		NodeList nodeList = Annotations();
		Expression result;
		switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
		{
		case 13:
		case 15:
		case 18:
		case 24:
		case 31:
		case 38:
		case 40:
		case 50:
		{
			PrimitiveType type = PrimitiveType(nodeList);
			result = ArrayCreation(__003C_003EINVALID, type);
			break;
		}
		case 26:
		case 48:
		case 52:
		case 65:
		case 66:
		case 67:
		case 68:
		case 69:
		case 70:
		case 71:
		case 72:
		case 73:
		case 74:
		case 75:
		case 94:
		{
			ClassOrInterfaceType classOrInterfaceType = ClassOrInterfaceType(nodeList);
			switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
			{
			case 101:
			case 107:
				result = ArrayCreation(__003C_003EINVALID, classOrInterfaceType);
				break;
			case 97:
			{
				NodeList arguments = Arguments();
				if (jj_2_48(2))
				{
					anonymousClassBody = ClassOrInterfaceBody();
				}
				ObjectCreationExpr.___003Cclinit_003E();
				result = new ObjectCreationExpr(base.range(__003C_003EINVALID, token()), scope, classOrInterfaceType, rangedList.list, arguments, anonymousClassBody);
				break;
			}
			default:
				jj_la1[127] = jj_gen;
				jj_consume_token(-1);
				
				throw new ParseException();
			}
			break;
		}
		default:
			jj_la1[128] = jj_gen;
			jj_consume_token(-1);
			
			throw new ParseException();
		}
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 33, 207, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_44(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_44()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(43, xla);
			throw;
		}
		jj_save(43, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(43, xla);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 33, 217, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_45(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_45()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(44, xla);
			throw;
		}
		jj_save(44, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(44, xla);
		}
	}

	
	
	
	public com.github.javaparser.ast.type.Type AnnotatedType()
	{
		NodeList annotations = Annotations();
		com.github.javaparser.ast.type.Type result = Type(annotations);
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 33, 227, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_46(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_46()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(45, xla);
			throw;
		}
		jj_save(45, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(45, xla);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 33, 237, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_47(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_47()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(46, xla);
			throw;
		}
		jj_save(46, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(46, xla);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		179, 64, 159, 11, 105, 114, 162, 105, 114, 162,
		111, 104, 139, 105
	})]
	public Expression BooleanLiteral()
	{
		BooleanLiteralExpr result;
		switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
		{
		case 60:
			jj_consume_token(60);
			BooleanLiteralExpr.___003Cclinit_003E();
			result = new BooleanLiteralExpr(base.tokenRange(), value: true);
			break;
		case 28:
			jj_consume_token(28);
			BooleanLiteralExpr.___003Cclinit_003E();
			result = new BooleanLiteralExpr(base.tokenRange(), value: false);
			break;
		default:
			jj_la1[123] = jj_gen;
			jj_consume_token(-1);
			
			throw new ParseException();
		}
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	
	public Expression NullLiteral()
	{
		jj_consume_token(43);
		if ("" != null)
		{
			NullLiteralExpr.___003Cclinit_003E();
			NullLiteralExpr result = new NullLiteralExpr(base.tokenRange());
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
		[LineNumberTable(new byte[]
	{
		179, 178, 135, 103, 168, 159, 3, 162, 111, 130,
		105, 103, 138, 105
	})]
	public NodeList ArgumentList()
	{
		NodeList nodeList = base.emptyNodeList();
		Expression node = Expression();
		nodeList.add(node);
		while (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 104)
		{
			jj_consume_token(104);
			node = Expression();
			nodeList.add(node);
		}
		jj_la1[125] = jj_gen;
		if ("" != null)
		{
			return nodeList;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		180,
		85,
		98,
		98,
		103,
		102,
		102,
		103,
		167,
		104,
		105,
		127,
		4,
		byte.MaxValue,
		161,
		134,
		110,
		103,
		162,
		178,
		127,
		15,
		105,
		118,
		238,
		69,
		159,
		3,
		103,
		162,
		178,
		127,
		9
	})]
	public ArrayCreationExpr ArrayCreation(JavaToken begin, com.github.javaparser.ast.type.Type type)
	{
		Expression obj = null;
		ArrayInitializerExpr arrayInitializerExpr = null;
		NodeList nodeList = base.emptyNodeList();
		object obj2 = new ArrayList();
		new NodeList();
		JavaToken javaToken = JavaToken.___003C_003EINVALID;
		ArrayList arrayList = new ArrayList();
		do
		{
			NodeList nodeList2 = Annotations();
			jj_consume_token(101);
			javaToken = ((!nodeList2.isEmpty()) ? base.orIfInvalid(javaToken, nodeList2.get(0)) : token());
			switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
			{
			case 13:
			case 15:
			case 18:
			case 24:
			case 26:
			case 28:
			case 31:
			case 38:
			case 40:
			case 42:
			case 43:
			case 48:
			case 50:
			case 52:
			case 53:
			case 54:
			case 56:
			case 60:
			case 62:
			case 65:
			case 66:
			case 67:
			case 68:
			case 69:
			case 70:
			case 71:
			case 72:
			case 73:
			case 74:
			case 75:
			case 76:
			case 77:
			case 82:
			case 89:
			case 90:
			case 92:
			case 94:
			case 97:
			case 107:
			case 111:
			case 112:
			case 122:
			case 123:
			case 124:
			case 125:
				obj = Expression();
				break;
			default:
				jj_la1[129] = jj_gen;
				break;
			}
			object obj3 = obj2;
			obj2 = base.add(obj: nodeList2, list: (obj3 == null) ? null : ((obj3 as List) ?? throw new java.lang.IncompatibleClassChangeError()));
			nodeList = base.add(nodeList, obj);
			
			obj = null;
			jj_consume_token(102);
			((List)arrayList).add((object)base.range(javaToken, token()));
		}
		while (jj_2_49(2));
		if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 99)
		{
			arrayInitializerExpr = ArrayInitializer();
		}
		else
		{
			jj_la1[130] = jj_gen;
		}
		if ("" != null)
		{
			ArrayCreationExpr result = base.juggleArrayCreation(base.range(begin, token()), arrayList, type, nodeList, (List)obj2, arrayInitializerExpr);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 33, 247, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_48(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_48()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(47, xla);
			throw;
		}
		jj_save(47, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(47, xla);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 34, 1, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_49(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_49()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(48, xla);
			throw;
		}
		jj_save(48, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(48, xla);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 34, 11, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_50(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_50()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(49, xla);
			throw;
		}
		jj_save(49, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(49, xla);
		}
	}

	
	
	
	public LabeledStmt LabeledStatement()
	{
		SimpleName label = SimpleName();
		JavaToken begin = token();
		jj_consume_token(114);
		Statement statement = Statement();
		if ("" != null)
		{
			LabeledStmt.___003Cclinit_003E();
			LabeledStmt result = new LabeledStmt(base.range(begin, token()), label, statement);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		181, 87, 130, 105, 103, 103, 159, 3, 105, 103,
		162, 178, 105, 127, 4
	})]
	public AssertStmt AssertStatement()
	{
		Expression message = null;
		jj_consume_token(12);
		JavaToken begin = token();
		Expression check = Expression();
		if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 114)
		{
			jj_consume_token(114);
			message = Expression();
		}
		else
		{
			jj_la1[133] = jj_gen;
		}
		jj_consume_token(103);
		if ("" != null)
		{
			AssertStmt.___003Cclinit_003E();
			AssertStmt result = new AssertStmt(base.range(begin, token()), check, message);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 34, 21, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_51(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_51()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(50, xla);
			throw;
		}
		jj_save(50, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(50, xla);
		}
	}

	
	
	
	public YieldStmt YieldStatement()
	{
		jj_consume_token(65);
		JavaToken begin = token();
		Expression expression = Expression();
		jj_consume_token(103);
		if ("" != null)
		{
			YieldStmt.___003Cclinit_003E();
			YieldStmt result = new YieldStmt(base.range(begin, token()), expression);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	
	public EmptyStmt EmptyStatement()
	{
		jj_consume_token(103);
		if ("" != null)
		{
			EmptyStmt.___003Cclinit_003E();
			EmptyStmt result = new EmptyStmt(base.tokenRange());
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		182,
		142,
		135,
		105,
		140,
		159,
		161,
		129,
		103,
		229,
		104,
		103,
		byte.MaxValue,
		160,
		81,
		79,
		159,
		160,
		81,
		105,
		126,
		165,
		105,
		126,
		229,
		78,
		103,
		103,
		123,
		162,
		114,
		104,
		235,
		69,
		178,
		162,
		114,
		104,
		171,
		105,
		127,
		3
	})]
	public ExpressionStmt StatementExpression()
	{
		new RangedList(null);
		Expression expression;
		if (jj_2_55(2))
		{
			expression = PreIncrementExpression();
		}
		else
		{
			switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
			{
			case 123:
				expression = PreDecrementExpression();
				break;
			case 13:
			case 15:
			case 18:
			case 24:
			case 26:
			case 28:
			case 31:
			case 38:
			case 40:
			case 42:
			case 43:
			case 48:
			case 50:
			case 52:
			case 53:
			case 56:
			case 60:
			case 62:
			case 65:
			case 66:
			case 67:
			case 68:
			case 69:
			case 70:
			case 71:
			case 72:
			case 73:
			case 74:
			case 75:
			case 76:
			case 77:
			case 82:
			case 89:
			case 90:
			case 92:
			case 94:
			case 97:
			case 107:
				expression = PrimaryExpression();
				switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
				{
				case 109:
				case 122:
				case 123:
				case 133:
				case 134:
				case 135:
				case 136:
				case 137:
				case 138:
				case 139:
				case 140:
				case 141:
				case 142:
				case 143:
					switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
					{
					case 122:
						jj_consume_token(122);
						UnaryExpr.___003Cclinit_003E();
						expression = new UnaryExpr(base.range(expression, token()), expression, UnaryExpr.Operator.___003C_003EPOSTFIX_INCREMENT);
						break;
					case 123:
						jj_consume_token(123);
						UnaryExpr.___003Cclinit_003E();
						expression = new UnaryExpr(base.range(expression, token()), expression, UnaryExpr.Operator.___003C_003EPOSTFIX_DECREMENT);
						break;
					case 109:
					case 133:
					case 134:
					case 135:
					case 136:
					case 137:
					case 138:
					case 139:
					case 140:
					case 141:
					case 142:
					case 143:
					{
						AssignExpr.Operator @operator = AssignmentOperator();
						Expression value = Expression();
						AssignExpr.___003Cclinit_003E();
						expression = new AssignExpr(base.range(expression, token()), expression, value, @operator);
						break;
					}
					default:
						jj_la1[137] = jj_gen;
						jj_consume_token(-1);
						
						throw new ParseException();
					}
					break;
				default:
					jj_la1[138] = jj_gen;
					break;
				}
				break;
			default:
				jj_la1[139] = jj_gen;
				jj_consume_token(-1);
				
				throw new ParseException();
			}
		}
		jj_consume_token(103);
		if ("" != null)
		{
			ExpressionStmt.___003Cclinit_003E();
			ExpressionStmt result = new ExpressionStmt(base.range(expression, token()), expression);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		183, 30, 135, 105, 103, 105, 103, 105, 169, 191,
		11, 162, 114, 130, 103, 139, 105, 127, 4
	})]
	public SwitchStmt SwitchStatement()
	{
		NodeList nodeList = base.emptyNodeList();
		jj_consume_token(54);
		JavaToken begin = token();
		jj_consume_token(97);
		Expression selector = Expression();
		jj_consume_token(98);
		jj_consume_token(99);
		while (true)
		{
			int num = ((jj_ntk != -1) ? jj_ntk : jj_ntk_f());
			if (num != 16 && num != 22)
			{
				break;
			}
			SwitchEntry obj = SwitchEntry();
			nodeList = base.add(nodeList, obj);
		}
		jj_la1[140] = jj_gen;
		jj_consume_token(100);
		if ("" != null)
		{
			SwitchStmt.___003Cclinit_003E();
			SwitchStmt result = new SwitchStmt(base.range(begin, token()), selector, nodeList);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		184, 21, 130, 105, 103, 105, 103, 105, 103, 159,
		3, 105, 103, 162, 178, 127, 5
	})]
	public IfStmt IfStatement()
	{
		Statement elseStmt = null;
		jj_consume_token(34);
		JavaToken begin = token();
		jj_consume_token(97);
		Expression condition = Expression();
		jj_consume_token(98);
		Statement thenStmt = Statement();
		if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 25)
		{
			jj_consume_token(25);
			elseStmt = Statement();
		}
		else
		{
			jj_la1[146] = jj_gen;
		}
		if ("" != null)
		{
			IfStmt.___003Cclinit_003E();
			IfStmt result = new IfStmt(base.range(begin, token()), condition, thenStmt, elseStmt);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	
	public WhileStmt WhileStatement()
	{
		jj_consume_token(64);
		JavaToken begin = token();
		jj_consume_token(97);
		Expression condition = Expression();
		jj_consume_token(98);
		Statement body = Statement();
		if ("" != null)
		{
			WhileStmt.___003Cclinit_003E();
			WhileStmt result = new WhileStmt(base.range(begin, token()), condition, body);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		184, 75, 105, 103, 103, 105, 105, 103, 105, 105,
		127, 4
	})]
	public DoStmt DoStatement()
	{
		jj_consume_token(23);
		JavaToken begin = token();
		Statement body = Statement();
		jj_consume_token(64);
		jj_consume_token(97);
		Expression condition = Expression();
		jj_consume_token(98);
		jj_consume_token(103);
		if ("" != null)
		{
			DoStmt.___003Cclinit_003E();
			DoStmt result = new DoStmt(base.range(begin, token()), body, condition);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		184,
		98,
		98,
		98,
		103,
		167,
		105,
		104,
		105,
		109,
		103,
		105,
		140,
		byte.MaxValue,
		161,
		145,
		122,
		byte.MaxValue,
		161,
		142,
		121,
		103,
		162,
		178,
		105,
		byte.MaxValue,
		161,
		134,
		110,
		103,
		162,
		178,
		105,
		byte.MaxValue,
		161,
		134,
		110,
		103,
		162,
		178,
		162,
		114,
		104,
		171,
		105,
		104,
		99,
		159,
		7,
		127,
		8
	})]
	public Statement ForStatement()
	{
		VariableDeclarationExpr variableDeclarationExpr = null;
		Expression expression = null;
		NodeList initialization = base.emptyNodeList();
		NodeList update = base.emptyNodeList();
		jj_consume_token(32);
		JavaToken begin = token();
		jj_consume_token(97);
		if (jj_2_56(int.MaxValue))
		{
			variableDeclarationExpr = VariableDeclarationExpression();
			jj_consume_token(114);
			expression = Expression();
		}
		else
		{
			switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
			{
			case 11:
			case 13:
			case 15:
			case 18:
			case 22:
			case 24:
			case 26:
			case 28:
			case 29:
			case 31:
			case 38:
			case 40:
			case 41:
			case 42:
			case 43:
			case 45:
			case 46:
			case 47:
			case 48:
			case 50:
			case 51:
			case 52:
			case 53:
			case 54:
			case 55:
			case 56:
			case 59:
			case 60:
			case 62:
			case 63:
			case 65:
			case 66:
			case 67:
			case 68:
			case 69:
			case 70:
			case 71:
			case 72:
			case 73:
			case 74:
			case 75:
			case 76:
			case 77:
			case 82:
			case 89:
			case 90:
			case 92:
			case 94:
			case 97:
			case 103:
			case 107:
			case 111:
			case 112:
			case 122:
			case 123:
			case 124:
			case 125:
				break;
			default:
				jj_la1[150] = jj_gen;
				jj_consume_token(-1);
				
				throw new ParseException();
			}
			switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
			{
			case 11:
			case 13:
			case 15:
			case 18:
			case 22:
			case 24:
			case 26:
			case 28:
			case 29:
			case 31:
			case 38:
			case 40:
			case 41:
			case 42:
			case 43:
			case 45:
			case 46:
			case 47:
			case 48:
			case 50:
			case 51:
			case 52:
			case 53:
			case 54:
			case 55:
			case 56:
			case 59:
			case 60:
			case 62:
			case 63:
			case 65:
			case 66:
			case 67:
			case 68:
			case 69:
			case 70:
			case 71:
			case 72:
			case 73:
			case 74:
			case 75:
			case 76:
			case 77:
			case 82:
			case 89:
			case 90:
			case 92:
			case 94:
			case 97:
			case 107:
			case 111:
			case 112:
			case 122:
			case 123:
			case 124:
			case 125:
				initialization = ForInit();
				break;
			default:
				jj_la1[147] = jj_gen;
				break;
			}
			jj_consume_token(103);
			switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
			{
			case 13:
			case 15:
			case 18:
			case 24:
			case 26:
			case 28:
			case 31:
			case 38:
			case 40:
			case 42:
			case 43:
			case 48:
			case 50:
			case 52:
			case 53:
			case 54:
			case 56:
			case 60:
			case 62:
			case 65:
			case 66:
			case 67:
			case 68:
			case 69:
			case 70:
			case 71:
			case 72:
			case 73:
			case 74:
			case 75:
			case 76:
			case 77:
			case 82:
			case 89:
			case 90:
			case 92:
			case 94:
			case 97:
			case 107:
			case 111:
			case 112:
			case 122:
			case 123:
			case 124:
			case 125:
				expression = Expression();
				break;
			default:
				jj_la1[148] = jj_gen;
				break;
			}
			jj_consume_token(103);
			switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
			{
			case 13:
			case 15:
			case 18:
			case 24:
			case 26:
			case 28:
			case 31:
			case 38:
			case 40:
			case 42:
			case 43:
			case 48:
			case 50:
			case 52:
			case 53:
			case 54:
			case 56:
			case 60:
			case 62:
			case 65:
			case 66:
			case 67:
			case 68:
			case 69:
			case 70:
			case 71:
			case 72:
			case 73:
			case 74:
			case 75:
			case 76:
			case 77:
			case 82:
			case 89:
			case 90:
			case 92:
			case 94:
			case 97:
			case 107:
			case 111:
			case 112:
			case 122:
			case 123:
			case 124:
			case 125:
				update = ForUpdate();
				break;
			default:
				jj_la1[149] = jj_gen;
				break;
			}
		}
		jj_consume_token(98);
		Statement body = Statement();
		if (variableDeclarationExpr != null && "" != null)
		{
			ForEachStmt.___003Cclinit_003E();
			ForEachStmt result = new ForEachStmt(base.range(begin, token()), variableDeclarationExpr, expression, body);
			
			return result;
		}
		if ("" != null)
		{
			ForStmt.___003Cclinit_003E();
			ForStmt result2 = new ForStmt(base.range(begin, token()), initialization, expression, update, body);
			
			return result2;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		185,
		251,
		130,
		105,
		103,
		byte.MaxValue,
		160,
		69,
		80,
		103,
		162,
		178,
		105,
		127,
		3
	})]
	public BreakStmt BreakStatement()
	{
		SimpleName label = null;
		jj_consume_token(14);
		JavaToken begin = token();
		int num = ((jj_ntk != -1) ? jj_ntk : jj_ntk_f());
		if (num == 26 || num == 48 || num == 52 || num == 65 || num == 66 || num == 67 || num == 68 || num == 69 || num == 70 || num == 71 || num == 72 || num == 73 || num == 74 || num == 75 || num == 94)
		{
			label = SimpleName();
		}
		else
		{
			jj_la1[153] = jj_gen;
		}
		jj_consume_token(103);
		if ("" != null)
		{
			BreakStmt.___003Cclinit_003E();
			BreakStmt result = new BreakStmt(base.range(begin, token()), label);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		186,
		51,
		130,
		105,
		103,
		byte.MaxValue,
		160,
		69,
		80,
		103,
		162,
		178,
		105,
		127,
		3
	})]
	public ContinueStmt ContinueStatement()
	{
		SimpleName label = null;
		jj_consume_token(21);
		JavaToken begin = token();
		int num = ((jj_ntk != -1) ? jj_ntk : jj_ntk_f());
		if (num == 26 || num == 48 || num == 52 || num == 65 || num == 66 || num == 67 || num == 68 || num == 69 || num == 70 || num == 71 || num == 72 || num == 73 || num == 74 || num == 75 || num == 94)
		{
			label = SimpleName();
		}
		else
		{
			jj_la1[154] = jj_gen;
		}
		jj_consume_token(103);
		if ("" != null)
		{
			ContinueStmt.___003Cclinit_003E();
			ContinueStmt result = new ContinueStmt(base.range(begin, token()), label);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		186,
		90,
		130,
		105,
		103,
		byte.MaxValue,
		161,
		134,
		110,
		103,
		162,
		178,
		105,
		127,
		3
	})]
	public ReturnStmt ReturnStatement()
	{
		Expression expression = null;
		jj_consume_token(49);
		JavaToken begin = token();
		switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
		{
		case 13:
		case 15:
		case 18:
		case 24:
		case 26:
		case 28:
		case 31:
		case 38:
		case 40:
		case 42:
		case 43:
		case 48:
		case 50:
		case 52:
		case 53:
		case 54:
		case 56:
		case 60:
		case 62:
		case 65:
		case 66:
		case 67:
		case 68:
		case 69:
		case 70:
		case 71:
		case 72:
		case 73:
		case 74:
		case 75:
		case 76:
		case 77:
		case 82:
		case 89:
		case 90:
		case 92:
		case 94:
		case 97:
		case 107:
		case 111:
		case 112:
		case 122:
		case 123:
		case 124:
		case 125:
			expression = Expression();
			break;
		default:
			jj_la1[155] = jj_gen;
			break;
		}
		jj_consume_token(103);
		if ("" != null)
		{
			ReturnStmt.___003Cclinit_003E();
			ReturnStmt result = new ReturnStmt(base.range(begin, token()), expression);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	
	public ThrowStmt ThrowStatement()
	{
		jj_consume_token(57);
		JavaToken begin = token();
		Expression expression = Expression();
		jj_consume_token(103);
		if ("" != null)
		{
			ThrowStmt.___003Cclinit_003E();
			ThrowStmt result = new ThrowStmt(base.range(begin, token()), expression);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	
	public SynchronizedStmt SynchronizedStatement()
	{
		jj_consume_token(55);
		JavaToken begin = token();
		jj_consume_token(97);
		Expression expression = Expression();
		jj_consume_token(98);
		BlockStmt body = Block();
		if ("" != null)
		{
			SynchronizedStmt.___003Cclinit_003E();
			SynchronizedStmt result = new SynchronizedStmt(base.range(begin, token()), expression, body);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		186, 219, 135, 98, 199, 231, 71, 105, 104, 159,
		3, 103, 162, 178, 168, 159, 3, 162, 114, 133,
		105, 104, 105, 104, 105, 110, 185, 159, 6, 162,
		114, 130, 108, 104, 139, 104, 104, 105, 104, 105,
		159, 11, 142, 127, 26, 127, 5, 103, 101, 159,
		3, 105, 103, 162, 178, 127, 8
	})]
	public TryStmt TryStatement()
	{
		NodeList resources = base.emptyNodeList();
		BlockStmt finallyBlock = null;
		NodeList nodeList = base.emptyNodeList();
		NodeList nodeList2 = base.emptyNodeList();
		jj_consume_token(61);
		JavaToken begin = token();
		if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 97)
		{
			resources = ResourceSpecification();
		}
		else
		{
			jj_la1[156] = jj_gen;
		}
		BlockStmt tryBlock = Block();
		while (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 17)
		{
			jj_consume_token(17);
			JavaToken begin2 = token();
			jj_consume_token(97);
			ModifierHolder modifierHolder = Modifiers();
			JavaToken begin3 = modifierHolder.begin;
			ReferenceType node = ReferenceType(base.emptyNodeList());
			nodeList2.add(node);
			begin3 = base.orIfInvalid(begin3, token());
			while (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 129)
			{
				jj_consume_token(129);
				node = AnnotatedReferenceType();
				nodeList2.add(node);
			}
			jj_la1[158] = jj_gen;
			Pair pair = VariableDeclaratorId();
			JavaToken end = token();
			jj_consume_token(98);
			BlockStmt body = Block();
			com.github.javaparser.ast.type.Type type;
			if (nodeList2.size() > 1)
			{
				UnionType.___003Cclinit_003E();
				type = new UnionType(base.range(nodeList2.get(0), nodeList2.get(nodeList2.size() - 1)), nodeList2);
			}
			else
			{
				type = (com.github.javaparser.ast.type.Type)nodeList2.get(0);
			}
			com.github.javaparser.ast.body.Parameter.___003Cclinit_003E();
			Parameter parameter = new Parameter(base.range(begin3, end), modifierHolder.modifiers, modifierHolder.annotations, type, isVarArgs: false, base.emptyNodeList(), (SimpleName)pair.___003C_003Ea);
			NodeList list = nodeList;
			CatchClause.___003Cclinit_003E();
			nodeList = base.add(list, new CatchClause(base.range(begin2, token()), parameter, body));
			nodeList2 = base.emptyNodeList();
		}
		jj_la1[157] = jj_gen;
		if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 30)
		{
			jj_consume_token(30);
			finallyBlock = Block();
		}
		else
		{
			jj_la1[159] = jj_gen;
		}
		if ("" != null)
		{
			TryStmt.___003Cclinit_003E();
			TryStmt result = new TryStmt(base.range(begin, token()), resources, tryBlock, nodeList, finallyBlock);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		180, 209, 105, 140, 159, 3, 103, 165, 114, 105,
		140, 159, 161, 129, 103, 165, 103, 229, 106, 103,
		165, 103, 165, 103, 165, 103, 165, 103, 165, 103,
		165, 103, 162, 103, 162, 103, 162, 103, 162, 103,
		162, 103, 162, 114, 104, 235, 69, 223, 3, 226,
		61, 97, 111, 143
	})]
	public Statement Statement()
	{
		//Discarded unreachable code: IL_0311
		ParseException ex;
		try
		{
			Statement result;
			if (jj_2_50(2))
			{
				result = LabeledStatement();
			}
			else if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 12)
			{
				result = AssertStatement();
			}
			else
			{
				jj_la1[131] = jj_gen;
				if (jj_2_51(3))
				{
					result = YieldStatement();
				}
				else
				{
					switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
					{
					case 99:
						result = Block();
						break;
					case 103:
						result = EmptyStatement();
						break;
					case 13:
					case 15:
					case 18:
					case 24:
					case 26:
					case 28:
					case 31:
					case 38:
					case 40:
					case 42:
					case 43:
					case 48:
					case 50:
					case 52:
					case 53:
					case 56:
					case 60:
					case 62:
					case 65:
					case 66:
					case 67:
					case 68:
					case 69:
					case 70:
					case 71:
					case 72:
					case 73:
					case 74:
					case 75:
					case 76:
					case 77:
					case 82:
					case 89:
					case 90:
					case 92:
					case 94:
					case 97:
					case 107:
					case 122:
					case 123:
						result = StatementExpression();
						break;
					case 54:
						result = SwitchStatement();
						break;
					case 34:
						result = IfStatement();
						break;
					case 64:
						result = WhileStatement();
						break;
					case 23:
						result = DoStatement();
						break;
					case 32:
						result = ForStatement();
						break;
					case 14:
						result = BreakStatement();
						break;
					case 21:
						result = ContinueStatement();
						break;
					case 49:
						result = ReturnStatement();
						break;
					case 57:
						result = ThrowStatement();
						break;
					case 55:
						result = SynchronizedStatement();
						break;
					case 61:
						result = TryStatement();
						break;
					default:
						jj_la1[132] = jj_gen;
						jj_consume_token(-1);
						
						throw new ParseException();
					}
				}
			}
			if ("" != null)
			{
				return result;
			}
		}
		catch (ParseException x)
		{
			ex = ByteCodeHelper.MapException<ParseException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0323;
		}
		goto IL_0348;
		IL_0323:
		ParseException p = ex;
		TokenRange tokenRange = base.recoverStatement(103, 99, 100, p);
		if ("" != null)
		{
			return new UnparsableStmt(tokenRange);
		}
		goto IL_0348;
		IL_0348:
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 34, 31, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_52(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_52()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(51, xla);
			throw;
		}
		jj_save(51, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(51, xla);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 34, 41, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_53(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_53()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(52, xla);
			throw;
		}
		jj_save(52, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(52, xla);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 34, 51, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_54(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_54()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(53, xla);
			throw;
		}
		jj_save(53, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(53, xla);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		182, 28, 134, 103, 109, 104, 168, 159, 3, 162,
		114, 130, 105, 104, 138, 111, 127, 16
	})]
	public VariableDeclarationExpr VariableDeclarationExpression()
	{
		NodeList nodeList = new NodeList();
		ModifierHolder modifierHolder = Modifiers();
		com.github.javaparser.ast.type.Type type = Type(base.emptyNodeList());
		VariableDeclarator node = VariableDeclarator(type);
		nodeList.add(node);
		while (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 104)
		{
			jj_consume_token(104);
			node = VariableDeclarator(type);
			nodeList.add(node);
		}
		jj_la1[135] = jj_gen;
		JavaToken begin = base.orIfInvalid(modifierHolder.begin, type);
		if ("" != null)
		{
			VariableDeclarationExpr.___003Cclinit_003E();
			VariableDeclarationExpr result = new VariableDeclarationExpr(base.range(begin, token()), modifierHolder.modifiers, modifierHolder.annotations, nodeList);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 34, 61, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_55(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_55()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(54, xla);
			throw;
		}
		jj_save(54, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(54, xla);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		183,
		133,
		98,
		103,
		167,
		98,
		98,
		159,
		17,
		105,
		103,
		103,
		169,
		159,
		3,
		162,
		114,
		130,
		105,
		103,
		235,
		69,
		105,
		103,
		162,
		114,
		104,
		139,
		159,
		14,
		105,
		103,
		127,
		1,
		165,
		105,
		byte.MaxValue,
		161,
		137,
		110,
		104,
		105,
		111,
		127,
		5,
		117,
		165,
		104,
		111,
		105,
		117,
		165,
		104,
		111,
		105,
		117,
		162,
		114,
		104,
		235,
		69,
		114,
		104,
		139,
		106
	})]
	public SwitchEntry SwitchEntry()
	{
		
		NodeList nodeList = base.emptyNodeList();
		NodeList nodeList2 = base.emptyNodeList();
		
		
		JavaToken begin;
		switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
		{
		case 16:
		{
			jj_consume_token(16);
			begin = token();
			Expression obj = ConditionalExpression();
			nodeList = base.add(nodeList, obj);
			while (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 104)
			{
				jj_consume_token(104);
				obj = ConditionalExpression();
				nodeList = base.add(nodeList, obj);
			}
			jj_la1[142] = jj_gen;
			break;
		}
		case 22:
			jj_consume_token(22);
			begin = token();
			break;
		default:
			jj_la1[143] = jj_gen;
			jj_consume_token(-1);
			
			throw new ParseException();
		}
		SwitchEntry result;
		switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
		{
		case 114:
			jj_consume_token(114);
			nodeList2 = Statements();
			com.github.javaparser.ast.stmt.SwitchEntry.___003Cclinit_003E();
			result = new SwitchEntry(base.range(begin, token()), nodeList, com.github.javaparser.ast.stmt.SwitchEntry.Type.___003C_003ESTATEMENT_GROUP, nodeList2);
			break;
		case 115:
			jj_consume_token(115);
			switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
			{
			case 13:
			case 15:
			case 18:
			case 24:
			case 26:
			case 28:
			case 31:
			case 38:
			case 40:
			case 42:
			case 43:
			case 48:
			case 50:
			case 52:
			case 53:
			case 54:
			case 56:
			case 60:
			case 62:
			case 65:
			case 66:
			case 67:
			case 68:
			case 69:
			case 70:
			case 71:
			case 72:
			case 73:
			case 74:
			case 75:
			case 76:
			case 77:
			case 82:
			case 89:
			case 90:
			case 92:
			case 94:
			case 97:
			case 107:
			case 111:
			case 112:
			case 122:
			case 123:
			case 124:
			case 125:
			{
				Expression expression = Expression();
				jj_consume_token(103);
				TokenRange tokenRange = base.range(begin, token());
				NodeList nodeList3 = nodeList2;
				ExpressionStmt.___003Cclinit_003E();
				nodeList3.add(new ExpressionStmt((TokenRange)expression.getTokenRange().get(), expression));
				com.github.javaparser.ast.stmt.SwitchEntry.___003Cclinit_003E();
				result = new SwitchEntry(tokenRange, nodeList, com.github.javaparser.ast.stmt.SwitchEntry.Type.___003C_003EEXPRESSION, nodeList2);
				break;
			}
			case 99:
			{
				BlockStmt node2 = Block();
				TokenRange tokenRange = base.range(begin, token());
				nodeList2.add(node2);
				com.github.javaparser.ast.stmt.SwitchEntry.___003Cclinit_003E();
				result = new SwitchEntry(tokenRange, nodeList, com.github.javaparser.ast.stmt.SwitchEntry.Type.___003C_003EBLOCK, nodeList2);
				break;
			}
			case 57:
			{
				ThrowStmt node = ThrowStatement();
				TokenRange tokenRange = base.range(begin, token());
				nodeList2.add(node);
				com.github.javaparser.ast.stmt.SwitchEntry.___003Cclinit_003E();
				result = new SwitchEntry(tokenRange, nodeList, com.github.javaparser.ast.stmt.SwitchEntry.Type.___003C_003ETHROWS_STATEMENT, nodeList2);
				break;
			}
			default:
				jj_la1[144] = jj_gen;
				jj_consume_token(-1);
				
				throw new ParseException();
			}
			break;
		default:
			jj_la1[145] = jj_gen;
			jj_consume_token(-1);
			
			throw new ParseException();
		}
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 34, 71, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_56(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_56()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(55, xla);
			throw;
		}
		jj_save(55, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(55, xla);
		}
	}

	
	
		[LineNumberTable(new byte[]
	{
		185,
		121,
		109,
		103,
		147,
		byte.MaxValue,
		161,
		134,
		110,
		103,
		162,
		114,
		104,
		171,
		105
	})]
	public NodeList ForInit()
	{
		NodeList nodeList;
		if (jj_2_57(int.MaxValue))
		{
			VariableDeclarationExpr node = VariableDeclarationExpression();
			nodeList = new NodeList();
			nodeList.add(node);
		}
		else
		{
			switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
			{
			case 13:
			case 15:
			case 18:
			case 24:
			case 26:
			case 28:
			case 31:
			case 38:
			case 40:
			case 42:
			case 43:
			case 48:
			case 50:
			case 52:
			case 53:
			case 54:
			case 56:
			case 60:
			case 62:
			case 65:
			case 66:
			case 67:
			case 68:
			case 69:
			case 70:
			case 71:
			case 72:
			case 73:
			case 74:
			case 75:
			case 76:
			case 77:
			case 82:
			case 89:
			case 90:
			case 92:
			case 94:
			case 97:
			case 107:
			case 111:
			case 112:
			case 122:
			case 123:
			case 124:
			case 125:
				break;
			default:
				jj_la1[151] = jj_gen;
				jj_consume_token(-1);
				
				throw new ParseException();
			}
			nodeList = ExpressionList();
		}
		if ("" != null)
		{
			return nodeList;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
		
	public NodeList ForUpdate()
	{
		NodeList result = ExpressionList();
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 34, 81, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_57(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_57()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(56, xla);
			throw;
		}
		jj_save(56, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(56, xla);
		}
	}

	
	
		[LineNumberTable(new byte[]
	{
		185, 200, 134, 103, 168, 159, 3, 162, 114, 130,
		105, 103, 138, 105
	})]
	public NodeList ExpressionList()
	{
		NodeList nodeList = new NodeList();
		Expression node = Expression();
		nodeList.add(node);
		while (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 104)
		{
			jj_consume_token(104);
			node = Expression();
			nodeList.add(node);
		}
		jj_la1[152] = jj_gen;
		if ("" != null)
		{
			return nodeList;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
		
	public NodeList ResourceSpecification()
	{
		jj_consume_token(97);
		NodeList result = Resources();
		if (jj_2_58(2))
		{
			jj_consume_token(103);
		}
		jj_consume_token(98);
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
		
	public NodeList Resources()
	{
		NodeList nodeList = new NodeList();
		Expression node = Resource();
		nodeList.add(node);
		while (jj_2_59(2))
		{
			jj_consume_token(103);
			node = Resource();
			nodeList.add(node);
		}
		if ("" != null)
		{
			return nodeList;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 34, 91, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_58(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_58()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(57, xla);
			throw;
		}
		jj_save(57, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(57, xla);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		187,
		148,
		141,
		140,
		byte.MaxValue,
		161,
		62,
		103,
		103,
		162,
		114,
		104,
		171,
		105
	})]
	public Expression Resource()
	{
		Expression result;
		if (jj_2_60(int.MaxValue))
		{
			result = VariableDeclarationExpression();
		}
		else
		{
			switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
			{
			case 13:
			case 15:
			case 18:
			case 24:
			case 26:
			case 28:
			case 31:
			case 38:
			case 40:
			case 42:
			case 43:
			case 48:
			case 50:
			case 52:
			case 53:
			case 56:
			case 60:
			case 62:
			case 65:
			case 66:
			case 67:
			case 68:
			case 69:
			case 70:
			case 71:
			case 72:
			case 73:
			case 74:
			case 75:
			case 76:
			case 77:
			case 82:
			case 89:
			case 90:
			case 92:
			case 94:
			case 97:
			case 107:
				break;
			default:
				jj_la1[160] = jj_gen;
				jj_consume_token(-1);
				
				throw new ParseException();
			}
			result = PrimaryExpression();
		}
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 34, 101, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_59(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_59()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(58, xla);
			throw;
		}
		jj_save(58, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(58, xla);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 34, 111, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_60(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_60()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(59, xla);
			throw;
		}
		jj_save(59, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(59, xla);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 52, 173, 119, 102, 104, 113, 231, 61, 230,
		69
	})]
	public sealed override Token getToken(int index)
	{
		Token token = ((!jj_lookingAhead) ? this.token : jj_scanpos);
		for (int i = 0; i < index; i++)
		{
			if (token.next == null)
			{
				token.next = token_source.getNextToken();
			}
			token = token.next;
		}
		return token;
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 34, 121, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_61(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_61()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(60, xla);
			throw;
		}
		jj_save(60, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(60, xla);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 34, 131, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_62(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_62()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(61, xla);
			throw;
		}
		jj_save(61, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(61, xla);
		}
	}

	
	
		[LineNumberTable(new byte[]
	{
		188, 107, 134, 103, 168, 159, 3, 162, 114, 130,
		105, 103, 138, 105
	})]
	public NodeList MemberValuePairs()
	{
		NodeList nodeList = new NodeList();
		MemberValuePair node = MemberValuePair();
		nodeList.add(node);
		while (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 104)
		{
			jj_consume_token(104);
			node = MemberValuePair();
			nodeList.add(node);
		}
		jj_la1[162] = jj_gen;
		if ("" != null)
		{
			return nodeList;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 34, 141, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_63(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_63()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(62, xla);
			throw;
		}
		jj_save(62, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(62, xla);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		188, 172, 109, 140, 159, 161, 134, 103, 226, 111,
		103, 162, 114, 104, 171, 105
	})]
	public Expression MemberValue()
	{
		Expression result;
		if (jj_2_64(int.MaxValue))
		{
			result = Annotation();
		}
		else
		{
			switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
			{
			case 99:
				result = MemberValueArrayInitializer();
				break;
			case 13:
			case 15:
			case 18:
			case 24:
			case 26:
			case 28:
			case 31:
			case 38:
			case 40:
			case 42:
			case 43:
			case 48:
			case 50:
			case 52:
			case 53:
			case 54:
			case 56:
			case 60:
			case 62:
			case 65:
			case 66:
			case 67:
			case 68:
			case 69:
			case 70:
			case 71:
			case 72:
			case 73:
			case 74:
			case 75:
			case 76:
			case 77:
			case 82:
			case 89:
			case 90:
			case 92:
			case 94:
			case 97:
			case 107:
			case 111:
			case 112:
			case 122:
			case 123:
			case 124:
			case 125:
				result = ConditionalExpression();
				break;
			default:
				jj_la1[163] = jj_gen;
				jj_consume_token(-1);
				
				throw new ParseException();
			}
		}
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	
	public MemberValuePair MemberValuePair()
	{
		SimpleName name = SimpleName();
		JavaToken begin = token();
		jj_consume_token(109);
		Expression value = MemberValue();
		if ("" != null)
		{
			com.github.javaparser.ast.expr.MemberValuePair.___003Cclinit_003E();
			MemberValuePair result = new MemberValuePair(base.range(begin, token()), name, value);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 34, 151, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_64(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_64()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(63, xla);
			throw;
		}
		jj_save(63, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(63, xla);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		188,
		248,
		167,
		105,
		103,
		byte.MaxValue,
		161,
		134,
		111,
		103,
		168,
		201,
		105,
		103,
		234,
		69,
		178,
		159,
		3,
		105,
		162,
		178,
		105,
		127,
		3
	})]
	public Expression MemberValueArrayInitializer()
	{
		NodeList nodeList = base.emptyNodeList();
		jj_consume_token(99);
		JavaToken begin = token();
		switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
		{
		case 13:
		case 15:
		case 18:
		case 24:
		case 26:
		case 28:
		case 31:
		case 38:
		case 40:
		case 42:
		case 43:
		case 48:
		case 50:
		case 52:
		case 53:
		case 54:
		case 56:
		case 60:
		case 62:
		case 65:
		case 66:
		case 67:
		case 68:
		case 69:
		case 70:
		case 71:
		case 72:
		case 73:
		case 74:
		case 75:
		case 76:
		case 77:
		case 82:
		case 89:
		case 90:
		case 92:
		case 94:
		case 97:
		case 99:
		case 107:
		case 111:
		case 112:
		case 122:
		case 123:
		case 124:
		case 125:
		{
			Expression node = MemberValue();
			nodeList.add(node);
			while (jj_2_65(2))
			{
				jj_consume_token(104);
				node = MemberValue();
				nodeList.add(node);
			}
			break;
		}
		default:
			jj_la1[164] = jj_gen;
			break;
		}
		if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 104)
		{
			jj_consume_token(104);
		}
		else
		{
			jj_la1[165] = jj_gen;
		}
		jj_consume_token(100);
		if ("" != null)
		{
			ArrayInitializerExpr.___003Cclinit_003E();
			ArrayInitializerExpr result = new ArrayInitializerExpr(base.range(begin, token()), nodeList);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 34, 161, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_65(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_65()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(64, xla);
			throw;
		}
		jj_save(64, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(64, xla);
		}
	}

	
	
		[LineNumberTable(new byte[]
	{
		189,
		114,
		135,
		169,
		byte.MaxValue,
		161,
		70,
		103,
		162,
		114,
		133,
		byte.MaxValue,
		161,
		70,
		102,
		103,
		105,
		165,
		105,
		165,
		114,
		104,
		171,
		105,
		105
	})]
	public NodeList AnnotationTypeBody()
	{
		NodeList nodeList = base.emptyNodeList();
		jj_consume_token(99);
		while (true)
		{
			switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
			{
			default:
				jj_la1[166] = jj_gen;
				jj_consume_token(100);
				if ("" != null)
				{
					return nodeList;
				}
				
				throw new IllegalStateException("Missing return statement in function");
			case 11:
			case 13:
			case 15:
			case 18:
			case 19:
			case 22:
			case 24:
			case 26:
			case 29:
			case 31:
			case 38:
			case 39:
			case 40:
			case 41:
			case 45:
			case 46:
			case 47:
			case 48:
			case 50:
			case 51:
			case 52:
			case 55:
			case 59:
			case 63:
			case 65:
			case 66:
			case 67:
			case 68:
			case 69:
			case 70:
			case 71:
			case 72:
			case 73:
			case 74:
			case 75:
			case 94:
			case 103:
			case 107:
				switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
				{
				case 11:
				case 13:
				case 15:
				case 18:
				case 19:
				case 22:
				case 24:
				case 26:
				case 29:
				case 31:
				case 38:
				case 39:
				case 40:
				case 41:
				case 45:
				case 46:
				case 47:
				case 48:
				case 50:
				case 51:
				case 52:
				case 55:
				case 59:
				case 63:
				case 65:
				case 66:
				case 67:
				case 68:
				case 69:
				case 70:
				case 71:
				case 72:
				case 73:
				case 74:
				case 75:
				case 94:
				case 107:
				{
					BodyDeclaration obj = AnnotationBodyDeclaration();
					nodeList = base.addWhenNotNull(nodeList, obj);
					break;
				}
				case 103:
					jj_consume_token(103);
					break;
				default:
					jj_la1[167] = jj_gen;
					jj_consume_token(-1);
					
					throw new ParseException();
				}
				break;
			}
		}
	}

	
	
		[LineNumberTable(new byte[]
	{
		189, 248, 103, 109, 141, 191, 11, 104, 165, 114,
		109, 141, 159, 161, 62, 104, 226, 89, 104, 162,
		114, 104, 235, 69, 105
	})]
	public BodyDeclaration AnnotationBodyDeclaration()
	{
		ModifierHolder modifier = Modifiers();
		BodyDeclaration result;
		if (jj_2_66(int.MaxValue))
		{
			result = AnnotationTypeMemberDeclaration(modifier);
		}
		else
		{
			int num = ((jj_ntk != -1) ? jj_ntk : jj_ntk_f());
			if (num == 19 || num == 39)
			{
				result = ClassOrInterfaceDeclaration(modifier);
			}
			else
			{
				jj_la1[168] = jj_gen;
				if (jj_2_67(int.MaxValue))
				{
					result = EnumDeclaration(modifier);
				}
				else
				{
					switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
					{
					case 107:
						result = AnnotationTypeDeclaration(modifier);
						break;
					case 13:
					case 15:
					case 18:
					case 24:
					case 26:
					case 31:
					case 38:
					case 40:
					case 48:
					case 50:
					case 52:
					case 65:
					case 66:
					case 67:
					case 68:
					case 69:
					case 70:
					case 71:
					case 72:
					case 73:
					case 74:
					case 75:
					case 94:
						result = FieldDeclaration(modifier);
						break;
					default:
						jj_la1[169] = jj_gen;
						jj_consume_token(-1);
						
						throw new ParseException();
					}
				}
			}
		}
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 34, 171, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_66(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_66()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(65, xla);
			throw;
		}
		jj_save(65, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(65, xla);
		}
	}

	
	
	
	[LineNumberTable(new byte[]
	{
		190, 71, 162, 109, 103, 105, 105, 159, 3, 103,
		162, 178, 105, 110, 127, 17
	})]
	public AnnotationMemberDeclaration AnnotationTypeMemberDeclaration(ModifierHolder modifier)
	{
		Expression defaultValue = null;
		com.github.javaparser.ast.type.Type type = Type(base.emptyNodeList());
		SimpleName name = SimpleName();
		jj_consume_token(97);
		jj_consume_token(98);
		if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 22)
		{
			defaultValue = DefaultValue();
		}
		else
		{
			jj_la1[170] = jj_gen;
		}
		jj_consume_token(103);
		JavaToken begin = base.orIfInvalid(modifier.begin, type);
		if ("" != null)
		{
			AnnotationMemberDeclaration.___003Cclinit_003E();
			AnnotationMemberDeclaration result = new AnnotationMemberDeclaration(base.range(begin, token()), modifier.modifiers, modifier.annotations, type, name, defaultValue);
			
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 34, 181, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_67(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_67()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(66, xla);
			throw;
		}
		jj_save(66, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(66, xla);
		}
	}

	
	
	
	public Expression DefaultValue()
	{
		jj_consume_token(22);
		Expression result = MemberValue();
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 34, 191, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_68(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_68()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(67, xla);
			throw;
		}
		jj_save(67, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(67, xla);
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		190, 139, 199, 112, 105, 103, 105, 111, 105, 159,
		28, 159, 41, 105, 103, 104, 104, 105, 127, 2,
		165, 105, 103, 104, 159, 6, 105, 104, 169, 159,
		3, 162, 114, 130, 105, 104, 235, 69, 178, 105,
		123, 165, 105, 103, 104, 159, 6, 105, 104, 169,
		159, 3, 162, 114, 130, 105, 104, 235, 69, 178,
		105, 123, 165, 105, 103, 104, 105, 122, 165, 105,
		103, 104, 105, 104, 169, 159, 3, 162, 114, 130,
		105, 104, 139, 105, 123, 162, 114, 104, 171, 105
	})]
	public ModuleDirective ModuleDirective()
	{
		NodeList nodeList = base.emptyNodeList();
		ModuleDirective result;
		if (jj_2_68(int.MaxValue))
		{
			jj_consume_token(66);
			JavaToken begin = token();
			jj_consume_token(75);
			JavaToken javaToken = token();
			base.setTokenKind(94);
			jj_consume_token(103);
			ModuleRequiresDirective.___003Cclinit_003E();
			TokenRange obj = base.range(begin, token());
			NodeList modifiers = new NodeList();
			com.github.javaparser.ast.expr.Name.___003Cclinit_003E();
			result = new ModuleRequiresDirective(obj, modifiers, new Name(base.range(javaToken, javaToken), null, javaToken.getText()));
		}
		else
		{
			switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
			{
			case 66:
			{
				jj_consume_token(66);
				JavaToken begin = token();
				ModifierHolder modifierHolder = Modifiers();
				Name name = Name();
				jj_consume_token(103);
				ModuleRequiresDirective.___003Cclinit_003E();
				result = new ModuleRequiresDirective(base.range(begin, token()), modifierHolder.modifiers, name);
				break;
			}
			case 73:
			{
				jj_consume_token(73);
				JavaToken begin = token();
				Name name = Name();
				if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 67)
				{
					jj_consume_token(67);
					Name node = Name();
					nodeList.add(node);
					while (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 104)
					{
						jj_consume_token(104);
						node = Name();
						nodeList.add(node);
					}
					jj_la1[171] = jj_gen;
				}
				else
				{
					jj_la1[172] = jj_gen;
				}
				jj_consume_token(103);
				ModuleExportsDirective.___003Cclinit_003E();
				result = new ModuleExportsDirective(base.range(begin, token()), name, nodeList);
				break;
			}
			case 70:
			{
				jj_consume_token(70);
				JavaToken begin = token();
				Name name = Name();
				if (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 67)
				{
					jj_consume_token(67);
					Name node = Name();
					nodeList.add(node);
					while (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 104)
					{
						jj_consume_token(104);
						node = Name();
						nodeList.add(node);
					}
					jj_la1[173] = jj_gen;
				}
				else
				{
					jj_la1[174] = jj_gen;
				}
				jj_consume_token(103);
				ModuleOpensDirective.___003Cclinit_003E();
				result = new ModuleOpensDirective(base.range(begin, token()), name, nodeList);
				break;
			}
			case 71:
			{
				jj_consume_token(71);
				JavaToken begin = token();
				Name name = Name();
				jj_consume_token(103);
				ModuleUsesDirective.___003Cclinit_003E();
				result = new ModuleUsesDirective(base.range(begin, token()), name);
				break;
			}
			case 74:
			{
				jj_consume_token(74);
				JavaToken begin = token();
				Name name = Name();
				jj_consume_token(68);
				Name node = Name();
				nodeList.add(node);
				while (((jj_ntk != -1) ? jj_ntk : jj_ntk_f()) == 104)
				{
					jj_consume_token(104);
					node = Name();
					nodeList.add(node);
				}
				jj_la1[175] = jj_gen;
				jj_consume_token(103);
				ModuleProvidesDirective.___003Cclinit_003E();
				result = new ModuleProvidesDirective(base.range(begin, token()), name, nodeList);
				break;
			}
			default:
				jj_la1[176] = jj_gen;
				jj_consume_token(-1);
				
				throw new ParseException();
			}
		}
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 34, 201, 103, 108, 108, 147, 79, 9, 100,
		103, 76, 34
	})]
	private bool jj_2_69(int xla)
	{
		jj_la = xla;
		jj_scanpos = this.token;
		jj_lastpos = this.token;
		int result;
		try
		{
			try
			{
				result = ((!jj_3_69()) ? 1 : 0);
			}
			catch (LookaheadSuccess)
			{
				goto IL_003e;
			}
		}
		catch
		{
			//try-fault
			jj_save(68, xla);
			throw;
		}
		jj_save(68, xla);
		return (byte)result != 0;
		IL_003e:
		LookaheadSuccess lookaheadSuccess2 = null;
		try
		{
			return true;
		}
		finally
		{
			jj_save(68, xla);
		}
	}

	
	
	private bool jj_3_1()
	{
		if (jj_scan_token(103))
		{
			return true;
		}
		return false;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		208, 53, 133, 105, 110, 104, 107, 103, 130, 137,
		117, 108, 103
	})]
	private void jj_save(int index, int xla)
	{
		JJCalls jJCalls = jj_2_rtns[index];
		while (jJCalls.gen > jj_gen)
		{
			if (jJCalls.next == null)
			{
				jJCalls.next = new JJCalls();
				jJCalls = jJCalls.next;
				break;
			}
			jJCalls = jJCalls.next;
		}
		jJCalls.gen = jj_gen + xla - jj_la;
		jJCalls.first = this.token;
		jJCalls.arg = xla;
	}

	
	
	private bool jj_3_2()
	{
		if (jj_3R_61())
		{
			return true;
		}
		return false;
	}

	
	[LineNumberTable(new byte[]
	{
		208, 38, 8, 103, 107, 103, 107, 103, 107, 103,
		107, 103, 107, 103, 107, 103, 107, 103, 107, 103,
		104, 103, 104, 103, 104, 103, 104, 103, 104, 103,
		234, 78
	})]
	private bool jj_3_3()
	{
		Token token = jj_scanpos;
		if (jj_3R_62())
		{
			jj_scanpos = token;
			if (jj_3R_63())
			{
				jj_scanpos = token;
				if (jj_3R_64())
				{
					jj_scanpos = token;
					if (jj_3R_65())
					{
						jj_scanpos = token;
						if (jj_3R_66())
						{
							jj_scanpos = token;
							if (jj_3R_67())
							{
								jj_scanpos = token;
								if (jj_3R_68())
								{
									jj_scanpos = token;
									if (jj_3R_69())
									{
										jj_scanpos = token;
										if (jj_3R_70())
										{
											jj_scanpos = token;
											if (jj_3R_71())
											{
												jj_scanpos = token;
												if (jj_3R_72())
												{
													jj_scanpos = token;
													if (jj_3R_73())
													{
														jj_scanpos = token;
														if (jj_3R_74())
														{
															jj_scanpos = token;
															if (jj_3R_75())
															{
																return true;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		return false;
	}

	
	
	private bool jj_3_4()
	{
		if (jj_scan_token(104))
		{
			return true;
		}
		if (jj_3R_76())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_5()
	{
		if (jj_scan_token(26))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_6()
	{
		if (jj_scan_token(107))
		{
			return true;
		}
		if (jj_scan_token(39))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_7()
	{
		Token token = jj_scanpos;
		if (jj_3R_77())
		{
			jj_scanpos = token;
		}
		if (jj_3R_78())
		{
			return true;
		}
		if (jj_scan_token(99))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_8()
	{
		Token token = jj_scanpos;
		if (jj_3R_79())
		{
			jj_scanpos = token;
		}
		if (jj_3R_78())
		{
			return true;
		}
		if (jj_scan_token(97))
		{
			return true;
		}
		return false;
	}

	
	[LineNumberTable(new byte[]
	{
		208, 48, 43, 106, 170, 103, 145, 103, 106, 103,
		106, 103, 172
	})]
	private bool jj_3_9()
	{
		if (jj_3R_80())
		{
			return true;
		}
		if (jj_3R_78())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_81());
		jj_scanpos = token;
		token = jj_scanpos;
		if (jj_scan_token(104))
		{
			jj_scanpos = token;
			if (jj_scan_token(109))
			{
				jj_scanpos = token;
				if (jj_scan_token(103))
				{
					return true;
				}
			}
		}
		return false;
	}

	
	
	private bool jj_3_10()
	{
		if (jj_3R_82())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_11()
	{
		if (jj_3R_83())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_12()
	{
		if (jj_scan_token(48))
		{
			return true;
		}
		if (jj_3R_84())
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_85())
		{
			jj_scanpos = token;
		}
		if (jj_3R_86())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_13()
	{
		if (jj_scan_token(26))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_14()
	{
		if (jj_scan_token(107))
		{
			return true;
		}
		if (jj_scan_token(39))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_15()
	{
		Token token = jj_scanpos;
		if (jj_3R_87())
		{
			jj_scanpos = token;
		}
		if (jj_3R_78())
		{
			return true;
		}
		if (jj_scan_token(97))
		{
			return true;
		}
		return false;
	}

	
	[LineNumberTable(new byte[]
	{
		208, 50, 71, 106, 170, 103, 145, 103, 106, 103,
		106, 103, 172
	})]
	private bool jj_3_16()
	{
		if (jj_3R_80())
		{
			return true;
		}
		if (jj_3R_78())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_88());
		jj_scanpos = token;
		token = jj_scanpos;
		if (jj_scan_token(104))
		{
			jj_scanpos = token;
			if (jj_scan_token(109))
			{
				jj_scanpos = token;
				if (jj_scan_token(103))
				{
					return true;
				}
			}
		}
		return false;
	}

	
	
	private bool jj_3_17()
	{
		if (jj_3R_82())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_18()
	{
		if (jj_scan_token(104))
		{
			return true;
		}
		if (jj_3R_89())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_19()
	{
		if (jj_3R_90())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_20()
	{
		if (jj_3R_91())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_21()
	{
		if (jj_3R_83())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_22()
	{
		if (jj_3R_92())
		{
			return true;
		}
		if (jj_scan_token(105))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_23()
	{
		Token token = jj_scanpos;
		if (jj_3R_93())
		{
			jj_scanpos = token;
		}
		if (jj_scan_token(56))
		{
			return true;
		}
		if (jj_scan_token(97))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_24()
	{
		if (jj_3R_94())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_25()
	{
		Token token = jj_scanpos;
		if (jj_3R_95())
		{
			jj_scanpos = token;
			if (jj_3R_96())
			{
				return true;
			}
		}
		return false;
	}

	
	
	private bool jj_3_26()
	{
		if (jj_3R_97())
		{
			return true;
		}
		if (jj_scan_token(101))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_27()
	{
		if (jj_3R_97())
		{
			return true;
		}
		if (jj_scan_token(101))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_28()
	{
		if (jj_3R_98())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_29()
	{
		if (jj_scan_token(105))
		{
			return true;
		}
		if (jj_3R_97())
		{
			return true;
		}
		if (jj_3R_84())
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3_30())
		{
			jj_scanpos = token;
		}
		return false;
	}

	
	
	private bool jj_3_30()
	{
		if (jj_3R_98())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_31()
	{
		if (jj_scan_token(105))
		{
			return true;
		}
		if (jj_3R_78())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_32()
	{
		if (jj_3R_99())
		{
			return true;
		}
		if (jj_3R_100())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_33()
	{
		if (jj_3R_101())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_34()
	{
		Token token = jj_scanpos;
		if (jj_3R_102())
		{
			jj_scanpos = token;
			if (jj_3_35())
			{
				jj_scanpos = token;
				if (jj_3_36())
				{
					return true;
				}
			}
		}
		if (jj_3R_417())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_35()
	{
		if (jj_3R_103())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_36()
	{
		if (jj_3R_104())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_37()
	{
		if (jj_3R_105())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_38()
	{
		Token token = jj_scanpos;
		if (jj_3R_106())
		{
			jj_scanpos = token;
			if (jj_3R_107())
			{
				return true;
			}
		}
		return false;
	}

	
	
	private bool jj_3_39()
	{
		if (jj_3R_108())
		{
			return true;
		}
		if (jj_scan_token(98))
		{
			return true;
		}
		if (jj_3R_185())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_40()
	{
		if (jj_3R_109())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_41()
	{
		if (jj_3R_110())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_42()
	{
		if (jj_3R_111())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_43()
	{
		if (jj_3R_112())
		{
			return true;
		}
		if (jj_scan_token(104))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_44()
	{
		if (jj_3R_113())
		{
			return true;
		}
		if (jj_scan_token(105))
		{
			return true;
		}
		if (jj_scan_token(19))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_45()
	{
		if (jj_3R_114())
		{
			return true;
		}
		if (jj_scan_token(108))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_46()
	{
		if (jj_3R_110())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_47()
	{
		Token token = jj_scanpos;
		if (jj_3R_115())
		{
			jj_scanpos = token;
		}
		if (jj_3R_78())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_48()
	{
		if (jj_3R_116())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_49()
	{
		if (jj_3R_97())
		{
			return true;
		}
		if (jj_scan_token(101))
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_117())
		{
			jj_scanpos = token;
		}
		if (jj_scan_token(102))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_50()
	{
		if (jj_3R_118())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_51()
	{
		if (jj_3R_119())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_52()
	{
		if (jj_3R_120())
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_scan_token(19))
		{
			jj_scanpos = token;
			if (jj_scan_token(39))
			{
				return true;
			}
		}
		return false;
	}

	
	
	private bool jj_3_53()
	{
		if (jj_3R_120())
		{
			return true;
		}
		if (jj_scan_token(48))
		{
			return true;
		}
		if (jj_3R_84())
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_121())
		{
			jj_scanpos = token;
		}
		if (jj_3R_86())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_54()
	{
		if (jj_3R_122())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_55()
	{
		if (jj_3R_123())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_56()
	{
		if (jj_3R_122())
		{
			return true;
		}
		if (jj_scan_token(114))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_57()
	{
		if (jj_3R_120())
		{
			return true;
		}
		if (jj_3R_80())
		{
			return true;
		}
		if (jj_3R_78())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_58()
	{
		if (jj_scan_token(103))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_59()
	{
		if (jj_scan_token(103))
		{
			return true;
		}
		if (jj_3R_124())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_60()
	{
		if (jj_3R_120())
		{
			return true;
		}
		if (jj_3R_80())
		{
			return true;
		}
		if (jj_3R_125())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_61()
	{
		if (jj_scan_token(107))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_62()
	{
		if (jj_scan_token(97))
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_126())
		{
			jj_scanpos = token;
			if (jj_scan_token(98))
			{
				return true;
			}
		}
		return false;
	}

	
	
	private bool jj_3_63()
	{
		if (jj_scan_token(97))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_64()
	{
		if (jj_scan_token(107))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_65()
	{
		if (jj_scan_token(104))
		{
			return true;
		}
		if (jj_3R_127())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_66()
	{
		if (jj_3R_80())
		{
			return true;
		}
		if (jj_3R_78())
		{
			return true;
		}
		if (jj_scan_token(97))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_67()
	{
		if (jj_scan_token(26))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_68()
	{
		if (jj_scan_token(66))
		{
			return true;
		}
		if (jj_scan_token(75))
		{
			return true;
		}
		if (jj_scan_token(103))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3_69()
	{
		if (jj_3R_94())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_203()
	{
		if (jj_scan_token(99))
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_363())
		{
			jj_scanpos = token;
		}
		token = jj_scanpos;
		if (jj_scan_token(104))
		{
			jj_scanpos = token;
		}
		if (jj_scan_token(100))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_186()
	{
		if (jj_3R_122())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_187()
	{
		if (jj_3R_229())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_100()
	{
		if (jj_3R_163())
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_224())
		{
			jj_scanpos = token;
		}
		return false;
	}

	
	
	private bool jj_3R_122()
	{
		if (jj_3R_120())
		{
			return true;
		}
		if (jj_3R_80())
		{
			return true;
		}
		if (jj_3R_125())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_184());
		jj_scanpos = token;
		return false;
	}

	
	
	private bool jj_3R_269()
	{
		if (jj_3R_324())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_362());
		jj_scanpos = token;
		return false;
	}

	
	
	private bool jj_3R_330()
	{
		if (jj_scan_token(121))
		{
			return true;
		}
		if (jj_3R_269())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_369()
	{
		if (jj_3R_203())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_120()
	{
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3_3());
		jj_scanpos = token;
		return false;
	}

	
	
	private bool jj_3R_80()
	{
		Token token = jj_scanpos;
		if (jj_3R_131())
		{
			jj_scanpos = token;
			if (jj_3R_132())
			{
				return true;
			}
		}
		return false;
	}

	
	
	private bool jj_3R_125()
	{
		if (jj_3R_112())
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_188())
		{
			jj_scanpos = token;
		}
		return false;
	}

	
	
	private bool jj_3R_97()
	{
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_149());
		jj_scanpos = token;
		return false;
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 52, 134, 113, 110, 109, 159, 15, 190, 145,
		104, 105, 121, 139, 112, 127, 3
	})]
	private bool jj_scan_token(int kind)
	{
		if (jj_scanpos == jj_lastpos)
		{
			jj_la--;
			if (jj_scanpos.next == null)
			{
				Token obj = jj_scanpos;
				Token nextToken = token_source.getNextToken();
				Token token = obj;
				Token obj2 = nextToken;
				token.next = nextToken;
				nextToken = obj2;
				Token obj3 = nextToken;
				jj_scanpos = nextToken;
				jj_lastpos = obj3;
			}
			else
			{
				Token nextToken = jj_scanpos.next;
				Token obj4 = nextToken;
				jj_scanpos = nextToken;
				jj_lastpos = obj4;
			}
		}
		else
		{
			jj_scanpos = jj_scanpos.next;
		}
		if (jj_rescan)
		{
			int num = 0;
			Token next = this.token;
			while (next != null && next != jj_scanpos)
			{
				num++;
				next = next.next;
			}
			if (next != null)
			{
				jj_add_error_token(kind, num);
			}
		}
		if (jj_scanpos.kind != kind)
		{
			return true;
		}
		if (jj_la == 0 && jj_scanpos == jj_lastpos)
		{
			throw Throwable.___003Cunmap_003E(jj_ls);
		}
		return false;
	}

	
	
	private bool jj_3R_117()
	{
		if (jj_3R_100())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_229()
	{
		if (jj_3R_142())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3_40());
		jj_scanpos = token;
		return false;
	}

	private bool jj_3R_166()
	{
		return false;
	}

	
	
	private bool jj_3R_363()
	{
		if (jj_3R_89())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3_18());
		jj_scanpos = token;
		return false;
	}

	private bool jj_3R_165()
	{
		return false;
	}

	
	
	private bool jj_3R_89()
	{
		Token token = jj_scanpos;
		if (jj_3R_139())
		{
			jj_scanpos = token;
			if (jj_3R_140())
			{
				return true;
			}
		}
		return false;
	}

	
	
	private bool jj_3R_324()
	{
		if (jj_3R_350())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_384());
		jj_scanpos = token;
		return false;
	}

	
	
	private bool jj_3R_362()
	{
		if (jj_scan_token(120))
		{
			return true;
		}
		if (jj_3R_324())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_149()
	{
		if (jj_3R_128())
		{
			return true;
		}
		return false;
	}

	
	[LineNumberTable(new byte[]
	{
		208, 36, 190, 108, 138, 103, 104, 103, 104, 103,
		170
	})]
	private bool jj_3R_128()
	{
		if (jj_scan_token(107))
		{
			return true;
		}
		if (jj_3R_91())
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_264())
		{
			jj_scanpos = token;
			if (jj_3R_265())
			{
				jj_scanpos = token;
				if (jj_3R_266())
				{
					return true;
				}
			}
		}
		return false;
	}

	
	
	private bool jj_3R_249()
	{
		if (jj_3R_308())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_250()
	{
		if (jj_3R_135())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_251()
	{
		if (jj_3R_309())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_252()
	{
		if (jj_3R_310())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_253()
	{
		if (jj_3R_311())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_254()
	{
		if (jj_3R_312())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_255()
	{
		if (jj_3R_313())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_256()
	{
		if (jj_3R_314())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_257()
	{
		if (jj_3R_315())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_258()
	{
		if (jj_3R_316())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_259()
	{
		if (jj_3R_317())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_260()
	{
		if (jj_3R_318())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_261()
	{
		if (jj_3R_319())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_262()
	{
		if (jj_3R_320())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_263()
	{
		if (jj_3R_321())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_398()
	{
		if (jj_3R_130())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_113()
	{
		Token token = jj_scanpos;
		if (jj_3R_181())
		{
			jj_scanpos = token;
			if (jj_3R_182())
			{
				return true;
			}
		}
		return false;
	}

	
	
	private bool jj_3R_84()
	{
		if (jj_3R_78())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_86()
	{
		if (jj_scan_token(97))
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_138())
		{
			jj_scanpos = token;
		}
		if (jj_scan_token(98))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_436()
	{
		if (jj_3R_133())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_437()
	{
		if (jj_scan_token(58))
		{
			return true;
		}
		if (jj_3R_164())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_446());
		jj_scanpos = token;
		return false;
	}

	
	
	private bool jj_3R_438()
	{
		if (jj_3R_135())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_130()
	{
		if (jj_scan_token(110))
		{
			return true;
		}
		if (jj_3R_97())
		{
			return true;
		}
		if (jj_3R_192())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_193());
		jj_scanpos = token;
		if (jj_scan_token(146))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_118()
	{
		if (jj_3R_84())
		{
			return true;
		}
		if (jj_scan_token(114))
		{
			return true;
		}
		if (jj_3R_215())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_308()
	{
		if (jj_scan_token(12))
		{
			return true;
		}
		if (jj_3R_100())
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_364())
		{
			jj_scanpos = token;
		}
		if (jj_scan_token(103))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_133()
	{
		if (jj_3R_97())
		{
			return true;
		}
		if (jj_scan_token(101))
		{
			return true;
		}
		if (jj_scan_token(102))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_119()
	{
		if (jj_scan_token(65))
		{
			return true;
		}
		if (jj_3R_100())
		{
			return true;
		}
		if (jj_scan_token(103))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_135()
	{
		if (jj_scan_token(99))
		{
			return true;
		}
		if (jj_3R_195())
		{
			return true;
		}
		if (jj_scan_token(100))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_309()
	{
		if (jj_scan_token(103))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_310()
	{
		Token token = jj_scanpos;
		if (jj_3_55())
		{
			jj_scanpos = token;
			if (jj_3R_343())
			{
				jj_scanpos = token;
				if (jj_3R_344())
				{
					return true;
				}
			}
		}
		if (jj_scan_token(103))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_164()
	{
		if (jj_3R_97())
		{
			return true;
		}
		if (jj_3R_194())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_446()
	{
		if (jj_scan_token(104))
		{
			return true;
		}
		if (jj_3R_164())
		{
			return true;
		}
		return false;
	}

	
	[LineNumberTable(new byte[]
	{
		208, 40, 188, 108, 108, 106, 108, 172, 103, 145,
		108
	})]
	private bool jj_3R_311()
	{
		if (jj_scan_token(54))
		{
			return true;
		}
		if (jj_scan_token(97))
		{
			return true;
		}
		if (jj_3R_100())
		{
			return true;
		}
		if (jj_scan_token(98))
		{
			return true;
		}
		if (jj_scan_token(99))
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_450());
		jj_scanpos = token;
		if (jj_scan_token(100))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_350()
	{
		if (jj_3R_375())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_399());
		jj_scanpos = token;
		return false;
	}

	
	
	private bool jj_3R_384()
	{
		if (jj_scan_token(129))
		{
			return true;
		}
		if (jj_3R_350())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_312()
	{
		if (jj_scan_token(34))
		{
			return true;
		}
		if (jj_scan_token(97))
		{
			return true;
		}
		if (jj_3R_100())
		{
			return true;
		}
		if (jj_scan_token(98))
		{
			return true;
		}
		if (jj_3R_215())
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_451())
		{
			jj_scanpos = token;
		}
		return false;
	}

	
	
	private bool jj_3R_313()
	{
		if (jj_scan_token(64))
		{
			return true;
		}
		if (jj_scan_token(97))
		{
			return true;
		}
		if (jj_3R_100())
		{
			return true;
		}
		if (jj_scan_token(98))
		{
			return true;
		}
		if (jj_3R_215())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_314()
	{
		if (jj_scan_token(23))
		{
			return true;
		}
		if (jj_3R_215())
		{
			return true;
		}
		if (jj_scan_token(64))
		{
			return true;
		}
		if (jj_scan_token(97))
		{
			return true;
		}
		if (jj_3R_100())
		{
			return true;
		}
		if (jj_scan_token(98))
		{
			return true;
		}
		if (jj_scan_token(103))
		{
			return true;
		}
		return false;
	}

	
	[LineNumberTable(new byte[]
	{
		208, 44, 139, 108, 140, 103, 104, 103, 138, 108,
		106
	})]
	private bool jj_3R_315()
	{
		if (jj_scan_token(32))
		{
			return true;
		}
		if (jj_scan_token(97))
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_365())
		{
			jj_scanpos = token;
			if (jj_3R_366())
			{
				return true;
			}
		}
		if (jj_scan_token(98))
		{
			return true;
		}
		if (jj_3R_215())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_316()
	{
		if (jj_scan_token(14))
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_345())
		{
			jj_scanpos = token;
		}
		if (jj_scan_token(103))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_317()
	{
		if (jj_scan_token(21))
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_346())
		{
			jj_scanpos = token;
		}
		if (jj_scan_token(103))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_318()
	{
		if (jj_scan_token(49))
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_347())
		{
			jj_scanpos = token;
		}
		if (jj_scan_token(103))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_319()
	{
		if (jj_scan_token(57))
		{
			return true;
		}
		if (jj_3R_100())
		{
			return true;
		}
		if (jj_scan_token(103))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_320()
	{
		if (jj_scan_token(55))
		{
			return true;
		}
		if (jj_scan_token(97))
		{
			return true;
		}
		if (jj_3R_100())
		{
			return true;
		}
		if (jj_scan_token(98))
		{
			return true;
		}
		if (jj_3R_135())
		{
			return true;
		}
		return false;
	}

	
	[LineNumberTable(new byte[]
	{
		208, 49, 128, 140, 103, 111, 106, 103, 104, 103,
		138
	})]
	private bool jj_3R_321()
	{
		if (jj_scan_token(61))
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_348())
		{
			jj_scanpos = token;
		}
		if (jj_3R_135())
		{
			return true;
		}
		token = jj_scanpos;
		if (jj_3R_452())
		{
			jj_scanpos = token;
			if (jj_3R_453())
			{
				return true;
			}
		}
		return false;
	}

	
	
	private bool jj_3R_194()
	{
		Token token = jj_scanpos;
		if (jj_3R_232())
		{
			jj_scanpos = token;
			if (jj_3R_233())
			{
				return true;
			}
		}
		return false;
	}

	
	
	private bool jj_3R_364()
	{
		if (jj_scan_token(114))
		{
			return true;
		}
		if (jj_3R_100())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_61()
	{
		if (jj_3R_97())
		{
			return true;
		}
		if (jj_scan_token(44))
		{
			return true;
		}
		if (jj_3R_91())
		{
			return true;
		}
		if (jj_scan_token(103))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_375()
	{
		if (jj_3R_392())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_407());
		jj_scanpos = token;
		return false;
	}

	
	
	private bool jj_3R_399()
	{
		if (jj_scan_token(130))
		{
			return true;
		}
		if (jj_3R_375())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_91()
	{
		if (jj_3R_78())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3_31());
		jj_scanpos = token;
		return false;
	}

	
	
	private bool jj_3R_264()
	{
		if (jj_scan_token(97))
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_322())
		{
			jj_scanpos = token;
		}
		if (jj_scan_token(98))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_265()
	{
		if (jj_scan_token(97))
		{
			return true;
		}
		if (jj_3R_127())
		{
			return true;
		}
		if (jj_scan_token(98))
		{
			return true;
		}
		return false;
	}

	private bool jj_3R_266()
	{
		return false;
	}

	
	
	private bool jj_3R_322()
	{
		if (jj_3R_349())
		{
			return true;
		}
		return false;
	}

	
	[LineNumberTable(new byte[]
	{
		208, 35, 150, 103, 107, 103, 107, 103, 107, 103,
		107, 103, 107, 103, 107, 103, 107, 103, 107, 103,
		107, 103, 107, 103, 107, 103, 104, 103, 104, 103,
		104, 103, 104, 103, 104, 103, 234, 81
	})]
	private bool jj_3R_215()
	{
		Token token = jj_scanpos;
		if (jj_3_50())
		{
			jj_scanpos = token;
			if (jj_3R_249())
			{
				jj_scanpos = token;
				if (jj_3_51())
				{
					jj_scanpos = token;
					if (jj_3R_250())
					{
						jj_scanpos = token;
						if (jj_3R_251())
						{
							jj_scanpos = token;
							if (jj_3R_252())
							{
								jj_scanpos = token;
								if (jj_3R_253())
								{
									jj_scanpos = token;
									if (jj_3R_254())
									{
										jj_scanpos = token;
										if (jj_3R_255())
										{
											jj_scanpos = token;
											if (jj_3R_256())
											{
												jj_scanpos = token;
												if (jj_3R_257())
												{
													jj_scanpos = token;
													if (jj_3R_258())
													{
														jj_scanpos = token;
														if (jj_3R_259())
														{
															jj_scanpos = token;
															if (jj_3R_260())
															{
																jj_scanpos = token;
																if (jj_3R_261())
																{
																	jj_scanpos = token;
																	if (jj_3R_262())
																	{
																		jj_scanpos = token;
																		if (jj_3R_263())
																		{
																			return true;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		return false;
	}

	
	
	private bool jj_3R_349()
	{
		if (jj_3R_373())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_374());
		jj_scanpos = token;
		return false;
	}

	
	
	private bool jj_3R_127()
	{
		Token token = jj_scanpos;
		if (jj_3R_189())
		{
			jj_scanpos = token;
			if (jj_3R_190())
			{
				jj_scanpos = token;
				if (jj_3R_191())
				{
					return true;
				}
			}
		}
		return false;
	}

	
	
	private bool jj_3R_126()
	{
		if (jj_3R_78())
		{
			return true;
		}
		if (jj_scan_token(109))
		{
			return true;
		}
		return false;
	}

	
	[LineNumberTable(new byte[]
	{
		208, 49, 144, 103, 109, 103, 109, 103, 109, 103,
		109, 103, 109, 103, 109, 103, 109, 103, 109, 103,
		109, 103, 106, 103, 106, 103, 106, 103, 106, 103,
		106, 103, 236, 79
	})]
	private bool jj_3R_78()
	{
		Token token = jj_scanpos;
		if (jj_scan_token(72))
		{
			jj_scanpos = token;
			if (jj_scan_token(66))
			{
				jj_scanpos = token;
				if (jj_scan_token(67))
				{
					jj_scanpos = token;
					if (jj_scan_token(68))
					{
						jj_scanpos = token;
						if (jj_scan_token(69))
						{
							jj_scanpos = token;
							if (jj_scan_token(70))
							{
								jj_scanpos = token;
								if (jj_scan_token(71))
								{
									jj_scanpos = token;
									if (jj_scan_token(73))
									{
										jj_scanpos = token;
										if (jj_scan_token(74))
										{
											jj_scanpos = token;
											if (jj_scan_token(75))
											{
												jj_scanpos = token;
												if (jj_scan_token(26))
												{
													jj_scanpos = token;
													if (jj_scan_token(52))
													{
														jj_scanpos = token;
														if (jj_scan_token(65))
														{
															jj_scanpos = token;
															if (jj_scan_token(48))
															{
																jj_scanpos = token;
																if (jj_scan_token(94))
																{
																	return true;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		return false;
	}

	
	
	private bool jj_3R_138()
	{
		Token token = jj_scanpos;
		if (jj_3R_200())
		{
			jj_scanpos = token;
			if (jj_3R_201())
			{
				return true;
			}
		}
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_202());
		jj_scanpos = token;
		return false;
	}

	
	
	private bool jj_3R_392()
	{
		if (jj_3R_402())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_411());
		jj_scanpos = token;
		return false;
	}

	
	
	private bool jj_3R_407()
	{
		if (jj_scan_token(128))
		{
			return true;
		}
		if (jj_3R_392())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_200()
	{
		if (jj_3R_90())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_201()
	{
		if (jj_3R_111())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_202()
	{
		if (jj_scan_token(104))
		{
			return true;
		}
		if (jj_3R_111())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_195()
	{
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3_24());
		jj_scanpos = token;
		return false;
	}

	
	
	private bool jj_3R_373()
	{
		if (jj_3R_84())
		{
			return true;
		}
		if (jj_scan_token(109))
		{
			return true;
		}
		if (jj_3R_127())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_374()
	{
		if (jj_scan_token(104))
		{
			return true;
		}
		if (jj_3R_373())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_90()
	{
		if (jj_3R_97())
		{
			return true;
		}
		if (jj_3R_80())
		{
			return true;
		}
		if (jj_3R_141())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_111()
	{
		if (jj_3R_120())
		{
			return true;
		}
		if (jj_3R_80())
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_179())
		{
			jj_scanpos = token;
		}
		if (jj_3R_112())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_402()
	{
		if (jj_3R_410())
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_414())
		{
			jj_scanpos = token;
		}
		return false;
	}

	
	
	private bool jj_3R_411()
	{
		Token token = jj_scanpos;
		if (jj_3R_415())
		{
			jj_scanpos = token;
			if (jj_3R_416())
			{
				return true;
			}
		}
		if (jj_3R_402())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_415()
	{
		if (jj_scan_token(116))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_416()
	{
		if (jj_scan_token(119))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_338()
	{
		if (jj_scan_token(104))
		{
			return true;
		}
		if (jj_3R_111())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_144()
	{
		if (jj_3R_120())
		{
			return true;
		}
		if (jj_3R_213())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_145()
	{
		if (jj_3R_120())
		{
			return true;
		}
		if (jj_3R_214())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_146()
	{
		if (jj_3R_122())
		{
			return true;
		}
		if (jj_scan_token(103))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_147()
	{
		if (jj_3R_215())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_189()
	{
		if (jj_3R_128())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_190()
	{
		if (jj_3R_230())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_191()
	{
		if (jj_3R_163())
		{
			return true;
		}
		return false;
	}

	
	[LineNumberTable(new byte[]
	{
		208, 39, 150, 103, 104, 103, 138, 106, 103, 111,
		103, 111, 103, 111, 106
	})]
	private bool jj_3R_213()
	{
		Token token = jj_scanpos;
		if (jj_3R_247())
		{
			jj_scanpos = token;
			if (jj_3R_248())
			{
				return true;
			}
		}
		if (jj_3R_84())
		{
			return true;
		}
		token = jj_scanpos;
		if (jj_3R_283())
		{
			jj_scanpos = token;
		}
		token = jj_scanpos;
		if (jj_3R_284())
		{
			jj_scanpos = token;
		}
		token = jj_scanpos;
		if (jj_3R_285())
		{
			jj_scanpos = token;
		}
		if (jj_3R_116())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_230()
	{
		if (jj_scan_token(99))
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_391())
		{
			jj_scanpos = token;
		}
		token = jj_scanpos;
		if (jj_scan_token(104))
		{
			jj_scanpos = token;
		}
		if (jj_scan_token(100))
		{
			return true;
		}
		return false;
	}

	
	[LineNumberTable(new byte[]
	{
		208, 40, 216, 108, 138, 103, 111, 106, 103, 111,
		106
	})]
	private bool jj_3R_214()
	{
		if (jj_scan_token(48))
		{
			return true;
		}
		if (jj_3R_84())
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_286())
		{
			jj_scanpos = token;
		}
		if (jj_3R_86())
		{
			return true;
		}
		token = jj_scanpos;
		if (jj_3R_426())
		{
			jj_scanpos = token;
		}
		if (jj_3R_427())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_163()
	{
		if (jj_3R_217())
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_277())
		{
			jj_scanpos = token;
		}
		return false;
	}

	
	
	private bool jj_3R_62()
	{
		if (jj_scan_token(47))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_63()
	{
		if (jj_scan_token(51))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_64()
	{
		if (jj_scan_token(46))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_65()
	{
		if (jj_scan_token(45))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_66()
	{
		if (jj_scan_token(29))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_67()
	{
		if (jj_scan_token(11))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_68()
	{
		if (jj_scan_token(55))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_69()
	{
		if (jj_scan_token(41))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_70()
	{
		if (jj_scan_token(59))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_71()
	{
		if (jj_scan_token(63))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_72()
	{
		if (jj_scan_token(52))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_73()
	{
		if (jj_scan_token(75))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_74()
	{
		if (jj_scan_token(22))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_75()
	{
		if (jj_3R_128())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_121()
	{
		if (jj_3R_130())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_184()
	{
		if (jj_scan_token(104))
		{
			return true;
		}
		if (jj_3R_125())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_391()
	{
		if (jj_3R_127())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3_65());
		jj_scanpos = token;
		return false;
	}

	
	
	private bool jj_3R_112()
	{
		if (jj_3R_84())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_180());
		jj_scanpos = token;
		return false;
	}

	
	
	private bool jj_3R_339()
	{
		if (jj_scan_token(104))
		{
			return true;
		}
		if (jj_3R_112())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_410()
	{
		if (jj_3R_413())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_418());
		jj_scanpos = token;
		return false;
	}

	
	
	private bool jj_3R_414()
	{
		if (jj_scan_token(37))
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_420())
		{
			jj_scanpos = token;
			if (jj_3R_421())
			{
				return true;
			}
		}
		return false;
	}

	
	
	private bool jj_3R_420()
	{
		if (jj_3R_101())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_421()
	{
		if (jj_3R_164())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_101()
	{
		if (jj_3R_164())
		{
			return true;
		}
		if (jj_3R_84())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_179()
	{
		if (jj_3R_97())
		{
			return true;
		}
		if (jj_scan_token(106))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_432()
	{
		if (jj_scan_token(99))
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_444());
		jj_scanpos = token;
		if (jj_scan_token(100))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_377()
	{
		if (jj_3R_100())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_378()
	{
		if (jj_3R_135())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_413()
	{
		if (jj_3R_417())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3_34());
		jj_scanpos = token;
		return false;
	}

	
	[LineNumberTable(new byte[]
	{
		208, 39, 112, 103, 104, 103, 104, 103, 104, 103,
		202, 106
	})]
	private bool jj_3R_418()
	{
		Token token = jj_scanpos;
		if (jj_3R_422())
		{
			jj_scanpos = token;
			if (jj_3R_423())
			{
				jj_scanpos = token;
				if (jj_3R_424())
				{
					jj_scanpos = token;
					if (jj_3R_425())
					{
						return true;
					}
				}
			}
		}
		if (jj_3R_413())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_422()
	{
		if (jj_scan_token(110))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_423()
	{
		if (jj_scan_token(146))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_424()
	{
		if (jj_scan_token(118))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_425()
	{
		if (jj_scan_token(117))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_141()
	{
		Token token = jj_scanpos;
		if (jj_3R_204())
		{
			jj_scanpos = token;
		}
		if (jj_scan_token(56))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_247()
	{
		if (jj_scan_token(19))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_248()
	{
		if (jj_scan_token(39))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_283()
	{
		if (jj_3R_130())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_284()
	{
		if (jj_3R_331())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_285()
	{
		if (jj_3R_332())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_116()
	{
		if (jj_scan_token(99))
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_183());
		jj_scanpos = token;
		if (jj_scan_token(100))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_444()
	{
		Token token = jj_scanpos;
		if (jj_3R_460())
		{
			jj_scanpos = token;
			if (jj_scan_token(103))
			{
				return true;
			}
		}
		return false;
	}

	
	
	private bool jj_3R_343()
	{
		if (jj_3R_280())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_344()
	{
		if (jj_3R_229())
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_371())
		{
			jj_scanpos = token;
		}
		return false;
	}

	
	
	private bool jj_3R_460()
	{
		if (jj_3R_466())
		{
			return true;
		}
		return false;
	}

	
	[LineNumberTable(new byte[]
	{
		208, 40, 118, 138, 103, 104, 103, 104, 103, 104,
		103, 104, 103, 234, 69
	})]
	private bool jj_3R_466()
	{
		if (jj_3R_120())
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_470())
		{
			jj_scanpos = token;
			if (jj_3R_471())
			{
				jj_scanpos = token;
				if (jj_3R_472())
				{
					jj_scanpos = token;
					if (jj_3R_473())
					{
						jj_scanpos = token;
						if (jj_3R_474())
						{
							return true;
						}
					}
				}
			}
		}
		return false;
	}

	
	
	private bool jj_3R_123()
	{
		if (jj_scan_token(122))
		{
			return true;
		}
		if (jj_3R_185())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_331()
	{
		if (jj_scan_token(27))
		{
			return true;
		}
		if (jj_3R_333())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_447());
		jj_scanpos = token;
		return false;
	}

	
	
	private bool jj_3R_332()
	{
		if (jj_scan_token(35))
		{
			return true;
		}
		if (jj_3R_333())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_448());
		jj_scanpos = token;
		return false;
	}

	
	
	private bool jj_3R_280()
	{
		if (jj_scan_token(123))
		{
			return true;
		}
		if (jj_3R_185())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_371()
	{
		Token token = jj_scanpos;
		if (jj_3R_388())
		{
			jj_scanpos = token;
			if (jj_3R_389())
			{
				jj_scanpos = token;
				if (jj_3R_390())
				{
					return true;
				}
			}
		}
		return false;
	}

	
	
	private bool jj_3R_388()
	{
		if (jj_scan_token(122))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_389()
	{
		if (jj_scan_token(123))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_390()
	{
		if (jj_3R_99())
		{
			return true;
		}
		if (jj_3R_100())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_417()
	{
		if (jj_3R_419())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_428());
		jj_scanpos = token;
		return false;
	}

	
	
	private bool jj_3R_204()
	{
		if (jj_3R_91())
		{
			return true;
		}
		if (jj_scan_token(105))
		{
			return true;
		}
		return false;
	}

	
	[LineNumberTable(new byte[]
	{
		208, 50, 252, 103, 107, 103, 107, 103, 107, 103,
		107, 103, 107, 103, 107, 103, 104, 103, 104, 103,
		104, 103, 104, 103, 104, 103, 234, 76
	})]
	private bool jj_3R_99()
	{
		Token token = jj_scanpos;
		if (jj_3R_151())
		{
			jj_scanpos = token;
			if (jj_3R_152())
			{
				jj_scanpos = token;
				if (jj_3R_153())
				{
					jj_scanpos = token;
					if (jj_3R_154())
					{
						jj_scanpos = token;
						if (jj_3R_155())
						{
							jj_scanpos = token;
							if (jj_3R_156())
							{
								jj_scanpos = token;
								if (jj_3R_157())
								{
									jj_scanpos = token;
									if (jj_3R_158())
									{
										jj_scanpos = token;
										if (jj_3R_159())
										{
											jj_scanpos = token;
											if (jj_3R_160())
											{
												jj_scanpos = token;
												if (jj_3R_161())
												{
													jj_scanpos = token;
													if (jj_3R_162())
													{
														return true;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		return false;
	}

	
	
	private bool jj_3R_102()
	{
		if (jj_scan_token(132))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_103()
	{
		jj_lookingAhead = true;
		jj_semLA = ((getToken(1).kind == 146 && getToken(1).realKind == 145) ? true : false);
		jj_lookingAhead = false;
		if (!jj_semLA || jj_3R_165())
		{
			return true;
		}
		if (jj_scan_token(146))
		{
			return true;
		}
		if (jj_scan_token(146))
		{
			return true;
		}
		return false;
	}

	
	[LineNumberTable(new byte[]
	{
		208, 35, 52, 103, 127, 17, 103, 114, 111, 111,
		111
	})]
	private bool jj_3R_104()
	{
		jj_lookingAhead = true;
		jj_semLA = ((getToken(1).kind == 146 && getToken(1).realKind == 144) ? true : false);
		jj_lookingAhead = false;
		if (!jj_semLA || jj_3R_166())
		{
			return true;
		}
		if (jj_scan_token(146))
		{
			return true;
		}
		if (jj_scan_token(146))
		{
			return true;
		}
		if (jj_scan_token(146))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_470()
	{
		if (jj_3R_482())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_471()
	{
		if (jj_3R_213())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_472()
	{
		if (jj_3R_379())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_473()
	{
		if (jj_3R_380())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_474()
	{
		if (jj_3R_382())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_482()
	{
		if (jj_3R_80())
		{
			return true;
		}
		if (jj_3R_84())
		{
			return true;
		}
		if (jj_scan_token(97))
		{
			return true;
		}
		if (jj_scan_token(98))
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_485())
		{
			jj_scanpos = token;
		}
		if (jj_scan_token(103))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_419()
	{
		if (jj_3R_185())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_440());
		jj_scanpos = token;
		return false;
	}

	
	
	private bool jj_3R_428()
	{
		Token token = jj_scanpos;
		if (jj_3R_441())
		{
			jj_scanpos = token;
			if (jj_3R_442())
			{
				return true;
			}
		}
		if (jj_3R_419())
		{
			return true;
		}
		return false;
	}

	
	[LineNumberTable(new byte[]
	{
		208, 42, 129, 108, 138, 103, 111, 108, 103, 111,
		103, 113, 103, 111, 108
	})]
	private bool jj_3R_379()
	{
		if (jj_scan_token(26))
		{
			return true;
		}
		if (jj_3R_84())
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_429())
		{
			jj_scanpos = token;
		}
		if (jj_scan_token(99))
		{
			return true;
		}
		token = jj_scanpos;
		if (jj_3R_430())
		{
			jj_scanpos = token;
		}
		token = jj_scanpos;
		if (jj_scan_token(104))
		{
			jj_scanpos = token;
		}
		token = jj_scanpos;
		if (jj_3R_431())
		{
			jj_scanpos = token;
		}
		if (jj_scan_token(100))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_380()
	{
		if (jj_scan_token(107))
		{
			return true;
		}
		if (jj_scan_token(39))
		{
			return true;
		}
		if (jj_3R_84())
		{
			return true;
		}
		if (jj_3R_432())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_382()
	{
		if (jj_3R_80())
		{
			return true;
		}
		if (jj_3R_125())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_435());
		jj_scanpos = token;
		if (jj_scan_token(103))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_450()
	{
		if (jj_3R_376())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_441()
	{
		if (jj_scan_token(124))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_442()
	{
		if (jj_scan_token(125))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_286()
	{
		if (jj_3R_130())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_426()
	{
		if (jj_3R_332())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_427()
	{
		if (jj_scan_token(99))
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_439());
		jj_scanpos = token;
		if (jj_scan_token(100))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_397()
	{
		if (jj_3R_130())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_433()
	{
		if (jj_scan_token(58))
		{
			return true;
		}
		if (jj_3R_164())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_445());
		jj_scanpos = token;
		return false;
	}

	
	
	private bool jj_3R_434()
	{
		if (jj_3R_83())
		{
			return true;
		}
		return false;
	}

	
	[LineNumberTable(new byte[]
	{
		208, 42, 75, 103, 104, 103, 138, 103, 104, 103,
		138
	})]
	private bool jj_3R_376()
	{
		Token token = jj_scanpos;
		if (jj_3R_393())
		{
			jj_scanpos = token;
			if (jj_3R_394())
			{
				return true;
			}
		}
		token = jj_scanpos;
		if (jj_3R_395())
		{
			jj_scanpos = token;
			if (jj_3R_396())
			{
				return true;
			}
		}
		return false;
	}

	
	
	private bool jj_3R_445()
	{
		if (jj_scan_token(104))
		{
			return true;
		}
		if (jj_3R_164())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_83()
	{
		Token token = jj_scanpos;
		if (jj_3R_136())
		{
			jj_scanpos = token;
			if (jj_3R_137())
			{
				return true;
			}
		}
		return false;
	}

	
	[LineNumberTable(new byte[]
	{
		208, 41, 204, 103, 104, 103, 104, 103, 104, 103,
		202
	})]
	private bool jj_3R_185()
	{
		Token token = jj_scanpos;
		if (jj_3R_225())
		{
			jj_scanpos = token;
			if (jj_3R_226())
			{
				jj_scanpos = token;
				if (jj_3R_227())
				{
					jj_scanpos = token;
					if (jj_3R_228())
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	
	
	private bool jj_3R_440()
	{
		Token token = jj_scanpos;
		if (jj_3R_454())
		{
			jj_scanpos = token;
			if (jj_3R_455())
			{
				jj_scanpos = token;
				if (jj_3R_456())
				{
					return true;
				}
			}
		}
		if (jj_3R_185())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_485()
	{
		if (jj_3R_489())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_454()
	{
		if (jj_scan_token(126))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_455()
	{
		if (jj_scan_token(127))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_456()
	{
		if (jj_scan_token(131))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_489()
	{
		if (jj_scan_token(22))
		{
			return true;
		}
		if (jj_3R_127())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_333()
	{
		if (jj_3R_97())
		{
			return true;
		}
		if (jj_3R_148())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_447()
	{
		if (jj_scan_token(104))
		{
			return true;
		}
		if (jj_3R_333())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_351()
	{
		if (jj_3R_376())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_136()
	{
		Token token = jj_scanpos;
		if (jj_3R_196())
		{
			jj_scanpos = token;
		}
		if (jj_scan_token(56))
		{
			return true;
		}
		if (jj_3R_197())
		{
			return true;
		}
		if (jj_scan_token(103))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_137()
	{
		Token token = jj_scanpos;
		if (jj_3R_198())
		{
			jj_scanpos = token;
		}
		token = jj_scanpos;
		if (jj_3R_199())
		{
			jj_scanpos = token;
		}
		if (jj_scan_token(53))
		{
			return true;
		}
		if (jj_3R_197())
		{
			return true;
		}
		if (jj_scan_token(103))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_196()
	{
		if (jj_3R_98())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_197()
	{
		if (jj_scan_token(97))
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_234())
		{
			jj_scanpos = token;
		}
		if (jj_scan_token(98))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_98()
	{
		if (jj_scan_token(110))
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_150())
		{
			jj_scanpos = token;
		}
		if (jj_scan_token(146))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_225()
	{
		if (jj_3R_123())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_226()
	{
		if (jj_3R_280())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_227()
	{
		Token token = jj_scanpos;
		if (jj_3R_281())
		{
			jj_scanpos = token;
			if (jj_3R_282())
			{
				return true;
			}
		}
		if (jj_3R_185())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_228()
	{
		if (jj_3R_219())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_198()
	{
		if (jj_3R_92())
		{
			return true;
		}
		if (jj_scan_token(105))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_199()
	{
		if (jj_3R_98())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_93()
	{
		if (jj_3R_98())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_448()
	{
		if (jj_scan_token(104))
		{
			return true;
		}
		if (jj_3R_333())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_92()
	{
		if (jj_3R_142())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_143());
		jj_scanpos = token;
		return false;
	}

	
	
	private bool jj_3R_281()
	{
		if (jj_scan_token(124))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_282()
	{
		if (jj_scan_token(125))
		{
			return true;
		}
		return false;
	}

	
	[LineNumberTable(new byte[]
	{
		208, 43, 18, 103, 104, 103, 104, 103, 104, 103,
		202
	})]
	private bool jj_3R_219()
	{
		Token token = jj_scanpos;
		if (jj_3R_270())
		{
			jj_scanpos = token;
			if (jj_3R_271())
			{
				jj_scanpos = token;
				if (jj_3R_272())
				{
					jj_scanpos = token;
					if (jj_3R_273())
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	
	
	private bool jj_3R_393()
	{
		if (jj_scan_token(16))
		{
			return true;
		}
		if (jj_3R_163())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_403());
		jj_scanpos = token;
		return false;
	}

	
	
	private bool jj_3R_394()
	{
		if (jj_scan_token(22))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_395()
	{
		if (jj_scan_token(114))
		{
			return true;
		}
		if (jj_3R_195())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_396()
	{
		if (jj_scan_token(115))
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_404())
		{
			jj_scanpos = token;
			if (jj_3R_405())
			{
				jj_scanpos = token;
				if (jj_3R_406())
				{
					return true;
				}
			}
		}
		return false;
	}

	
	
	private bool jj_3R_403()
	{
		if (jj_scan_token(104))
		{
			return true;
		}
		if (jj_3R_163())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_429()
	{
		if (jj_3R_332())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_430()
	{
		if (jj_3R_76())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3_4());
		jj_scanpos = token;
		return false;
	}

	
	
	private bool jj_3R_431()
	{
		if (jj_scan_token(103))
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_443());
		jj_scanpos = token;
		return false;
	}

	
	
	private bool jj_3R_404()
	{
		if (jj_3R_100())
		{
			return true;
		}
		if (jj_scan_token(103))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_405()
	{
		if (jj_3R_135())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_406()
	{
		if (jj_3R_319())
		{
			return true;
		}
		return false;
	}

	
	[LineNumberTable(new byte[]
	{
		208, 37, 184, 103, 104, 103, 104, 103, 104, 103,
		202
	})]
	private bool jj_3R_94()
	{
		Token token = jj_scanpos;
		if (jj_3R_144())
		{
			jj_scanpos = token;
			if (jj_3R_145())
			{
				jj_scanpos = token;
				if (jj_3R_146())
				{
					jj_scanpos = token;
					if (jj_3R_147())
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	
	
	private bool jj_3R_76()
	{
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_129());
		jj_scanpos = token;
		if (jj_3R_84())
		{
			return true;
		}
		token = jj_scanpos;
		if (jj_3R_457())
		{
			jj_scanpos = token;
		}
		token = jj_scanpos;
		if (jj_3R_458())
		{
			jj_scanpos = token;
		}
		return false;
	}

	
	
	private bool jj_3R_443()
	{
		Token token = jj_scanpos;
		if (jj_3R_459())
		{
			jj_scanpos = token;
			if (jj_scan_token(103))
			{
				return true;
			}
		}
		return false;
	}

	
	
	private bool jj_3R_459()
	{
		if (jj_3R_276())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_276()
	{
		Token token = jj_scanpos;
		if (jj_3_17())
		{
			jj_scanpos = token;
			if (jj_3R_329())
			{
				return true;
			}
		}
		return false;
	}

	
	
	private bool jj_3R_134()
	{
		if (jj_scan_token(51))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_270()
	{
		Token token = jj_scanpos;
		if (jj_3R_325())
		{
			jj_scanpos = token;
			if (jj_3R_326())
			{
				return true;
			}
		}
		if (jj_3R_185())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_271()
	{
		if (jj_3R_105())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_272()
	{
		if (jj_3R_327())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_273()
	{
		if (jj_3R_328())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_325()
	{
		if (jj_scan_token(112))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_326()
	{
		if (jj_scan_token(111))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_105()
	{
		if (jj_scan_token(97))
		{
			return true;
		}
		if (jj_3R_97())
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3_39())
		{
			jj_scanpos = token;
			if (jj_3R_167())
			{
				return true;
			}
		}
		return false;
	}

	
	
	private bool jj_3R_327()
	{
		if (jj_3R_229())
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3_38())
		{
			jj_scanpos = token;
		}
		return false;
	}

	
	[LineNumberTable(new byte[]
	{
		208, 41, 146, 108, 108, 106, 108, 172, 103, 145,
		108
	})]
	private bool jj_3R_328()
	{
		if (jj_scan_token(54))
		{
			return true;
		}
		if (jj_scan_token(97))
		{
			return true;
		}
		if (jj_3R_100())
		{
			return true;
		}
		if (jj_scan_token(98))
		{
			return true;
		}
		if (jj_scan_token(99))
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_351());
		jj_scanpos = token;
		if (jj_scan_token(100))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_129()
	{
		if (jj_3R_128())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_457()
	{
		if (jj_3R_197())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_458()
	{
		if (jj_3R_116())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_451()
	{
		if (jj_scan_token(25))
		{
			return true;
		}
		if (jj_3R_215())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_131()
	{
		if (jj_3R_194())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_132()
	{
		if (jj_3R_108())
		{
			return true;
		}
		return false;
	}

	
	[LineNumberTable(new byte[]
	{
		208, 47, 73, 103, 107, 103, 107, 103, 104, 103,
		104, 103, 104, 103, 104, 103, 104, 103, 234, 72
	})]
	private bool jj_3R_108()
	{
		Token token = jj_scanpos;
		if (jj_3R_168())
		{
			jj_scanpos = token;
			if (jj_3R_169())
			{
				jj_scanpos = token;
				if (jj_3R_170())
				{
					jj_scanpos = token;
					if (jj_3R_171())
					{
						jj_scanpos = token;
						if (jj_3R_172())
						{
							jj_scanpos = token;
							if (jj_3R_173())
							{
								jj_scanpos = token;
								if (jj_3R_174())
								{
									jj_scanpos = token;
									if (jj_3R_175())
									{
										return true;
									}
								}
							}
						}
					}
				}
			}
		}
		return false;
	}

	
	
	private bool jj_3R_95()
	{
		if (jj_3R_108())
		{
			return true;
		}
		if (jj_3R_97())
		{
			return true;
		}
		if (jj_scan_token(101))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_96()
	{
		if (jj_3R_148())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_106()
	{
		if (jj_scan_token(122))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_107()
	{
		if (jj_scan_token(123))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_192()
	{
		if (jj_3R_84())
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_231())
		{
			jj_scanpos = token;
		}
		return false;
	}

	
	
	private bool jj_3R_193()
	{
		if (jj_scan_token(104))
		{
			return true;
		}
		if (jj_3R_97())
		{
			return true;
		}
		if (jj_3R_192())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_232()
	{
		if (jj_3R_108())
		{
			return true;
		}
		if (jj_3R_288())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_288());
		jj_scanpos = token;
		return false;
	}

	
	
	private bool jj_3R_233()
	{
		if (jj_3R_148())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_289());
		jj_scanpos = token;
		return false;
	}

	
	
	private bool jj_3R_167()
	{
		if (jj_3R_194())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_218());
		jj_scanpos = token;
		if (jj_scan_token(98))
		{
			return true;
		}
		if (jj_3R_219())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_288()
	{
		if (jj_3R_133())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_148()
	{
		if (jj_3R_84())
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3_28())
		{
			jj_scanpos = token;
		}
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3_29());
		jj_scanpos = token;
		return false;
	}

	
	
	private bool jj_3R_289()
	{
		if (jj_3R_133())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_218()
	{
		if (jj_scan_token(128))
		{
			return true;
		}
		if (jj_3R_164())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_231()
	{
		if (jj_3R_287())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_287()
	{
		if (jj_scan_token(27))
		{
			return true;
		}
		if (jj_3R_333())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_334());
		jj_scanpos = token;
		return false;
	}

	
	
	private bool jj_3R_365()
	{
		if (jj_3R_122())
		{
			return true;
		}
		if (jj_scan_token(114))
		{
			return true;
		}
		if (jj_3R_100())
		{
			return true;
		}
		return false;
	}

	
	[LineNumberTable(new byte[]
	{
		208, 44, 163, 103, 111, 108, 103, 111, 108, 103,
		111
	})]
	private bool jj_3R_366()
	{
		Token token = jj_scanpos;
		if (jj_3R_385())
		{
			jj_scanpos = token;
		}
		if (jj_scan_token(103))
		{
			return true;
		}
		token = jj_scanpos;
		if (jj_3R_462())
		{
			jj_scanpos = token;
		}
		if (jj_scan_token(103))
		{
			return true;
		}
		token = jj_scanpos;
		if (jj_3R_463())
		{
			jj_scanpos = token;
		}
		return false;
	}

	
	
	private bool jj_3R_385()
	{
		if (jj_3R_400())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_462()
	{
		if (jj_3R_100())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_463()
	{
		if (jj_3R_468())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_400()
	{
		Token token = jj_scanpos;
		if (jj_3R_408())
		{
			jj_scanpos = token;
			if (jj_3R_409())
			{
				return true;
			}
		}
		return false;
	}

	
	
	private bool jj_3R_468()
	{
		if (jj_3R_412())
		{
			return true;
		}
		return false;
	}

	
	[LineNumberTable(new byte[]
	{
		208, 45, 71, 103, 107, 103, 107, 103, 104, 103,
		104, 103, 104, 103, 104, 103, 104, 103, 234, 72
	})]
	private bool jj_3R_142()
	{
		Token token = jj_scanpos;
		if (jj_3R_205())
		{
			jj_scanpos = token;
			if (jj_3R_206())
			{
				jj_scanpos = token;
				if (jj_3R_207())
				{
					jj_scanpos = token;
					if (jj_3R_208())
					{
						jj_scanpos = token;
						if (jj_3R_209())
						{
							jj_scanpos = token;
							if (jj_3R_210())
							{
								jj_scanpos = token;
								if (jj_3R_211())
								{
									jj_scanpos = token;
									if (jj_3R_212())
									{
										return true;
									}
								}
							}
						}
					}
				}
			}
		}
		return false;
	}

	
	
	private bool jj_3R_109()
	{
		Token token = jj_scanpos;
		if (jj_3_46())
		{
			jj_scanpos = token;
			if (jj_3R_176())
			{
				return true;
			}
		}
		return false;
	}

	
	
	private bool jj_3R_334()
	{
		if (jj_scan_token(128))
		{
			return true;
		}
		if (jj_3R_333())
		{
			return true;
		}
		return false;
	}

	
	[LineNumberTable(new byte[]
	{
		208,
		44,
		byte.MaxValue,
		106
	})]
	private bool jj_3R_143()
	{
		if (jj_3R_110())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_110()
	{
		Token token = jj_scanpos;
		if (jj_3R_177())
		{
			jj_scanpos = token;
			if (jj_3R_178())
			{
				return true;
			}
		}
		return false;
	}

	
	
	private bool jj_3R_408()
	{
		if (jj_3R_122())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_409()
	{
		if (jj_3R_412())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_412()
	{
		if (jj_3R_100())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_484());
		jj_scanpos = token;
		return false;
	}

	
	
	private bool jj_3R_205()
	{
		if (jj_3R_235())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_206()
	{
		if (jj_scan_token(56))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_207()
	{
		if (jj_scan_token(53))
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_236())
		{
			jj_scanpos = token;
			if (jj_3R_237())
			{
				return true;
			}
		}
		return false;
	}

	
	[LineNumberTable(new byte[]
	{
		208, 46, 0, 140, 103, 104, 103, 104, 103, 104,
		103, 202
	})]
	private bool jj_3R_208()
	{
		if (jj_scan_token(97))
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_238())
		{
			jj_scanpos = token;
			if (jj_3R_239())
			{
				jj_scanpos = token;
				if (jj_3R_240())
				{
					jj_scanpos = token;
					if (jj_3R_241())
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	
	
	private bool jj_3R_209()
	{
		if (jj_3R_242())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_210()
	{
		if (jj_3R_113())
		{
			return true;
		}
		if (jj_scan_token(105))
		{
			return true;
		}
		if (jj_scan_token(19))
		{
			return true;
		}
		return false;
	}

	
	[LineNumberTable(new byte[]
	{
		208, 46, 131, 106, 140, 103, 111, 103, 104, 103,
		140
	})]
	private bool jj_3R_211()
	{
		if (jj_3R_114())
		{
			return true;
		}
		if (jj_scan_token(108))
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_243())
		{
			jj_scanpos = token;
		}
		token = jj_scanpos;
		if (jj_3R_244())
		{
			jj_scanpos = token;
			if (jj_scan_token(42))
			{
				return true;
			}
		}
		return false;
	}

	
	
	private bool jj_3R_212()
	{
		if (jj_3R_84())
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_245())
		{
			jj_scanpos = token;
		}
		return false;
	}

	
	[LineNumberTable(new byte[]
	{
		208, 48, 189, 103, 107, 103, 107, 103, 104, 103,
		104, 103, 104, 103, 104, 103, 104, 103, 234, 72
	})]
	private bool jj_3R_235()
	{
		Token token = jj_scanpos;
		if (jj_3R_291())
		{
			jj_scanpos = token;
			if (jj_3R_292())
			{
				jj_scanpos = token;
				if (jj_3R_293())
				{
					jj_scanpos = token;
					if (jj_3R_294())
					{
						jj_scanpos = token;
						if (jj_3R_295())
						{
							jj_scanpos = token;
							if (jj_3R_296())
							{
								jj_scanpos = token;
								if (jj_3R_297())
								{
									jj_scanpos = token;
									if (jj_3R_298())
									{
										return true;
									}
								}
							}
						}
					}
				}
			}
		}
		return false;
	}

	
	
	private bool jj_3R_236()
	{
		if (jj_scan_token(105))
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_299())
		{
			jj_scanpos = token;
		}
		if (jj_3R_84())
		{
			return true;
		}
		token = jj_scanpos;
		if (jj_3R_300())
		{
			jj_scanpos = token;
		}
		return false;
	}

	
	
	private bool jj_3R_237()
	{
		if (jj_scan_token(108))
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_301())
		{
			jj_scanpos = token;
		}
		token = jj_scanpos;
		if (jj_3R_302())
		{
			jj_scanpos = token;
			if (jj_scan_token(42))
			{
				return true;
			}
		}
		return false;
	}

	
	
	private bool jj_3R_183()
	{
		Token token = jj_scanpos;
		if (jj_3R_223())
		{
			jj_scanpos = token;
			if (jj_scan_token(103))
			{
				return true;
			}
		}
		return false;
	}

	
	
	private bool jj_3R_150()
	{
		if (jj_3R_216())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_246());
		jj_scanpos = token;
		return false;
	}

	
	
	private bool jj_3R_299()
	{
		if (jj_3R_98())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_300()
	{
		if (jj_3R_197())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_223()
	{
		if (jj_3R_276())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_484()
	{
		if (jj_scan_token(104))
		{
			return true;
		}
		if (jj_3R_100())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_216()
	{
		if (jj_3R_97())
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_267())
		{
			jj_scanpos = token;
			if (jj_3R_268())
			{
				return true;
			}
		}
		return false;
	}

	
	
	private bool jj_3R_246()
	{
		if (jj_scan_token(104))
		{
			return true;
		}
		if (jj_3R_216())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_301()
	{
		if (jj_3R_98())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_302()
	{
		if (jj_3R_78())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_238()
	{
		if (jj_scan_token(98))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_239()
	{
		if (jj_3R_303())
		{
			return true;
		}
		if (jj_scan_token(98))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_240()
	{
		if (jj_3R_304())
		{
			return true;
		}
		if (jj_scan_token(98))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_241()
	{
		if (jj_3R_100())
		{
			return true;
		}
		if (jj_scan_token(98))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_439()
	{
		Token token = jj_scanpos;
		if (jj_3R_449())
		{
			jj_scanpos = token;
			if (jj_scan_token(103))
			{
				return true;
			}
		}
		return false;
	}

	
	
	private bool jj_3R_303()
	{
		if (jj_3R_111())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_338());
		jj_scanpos = token;
		return false;
	}

	
	
	private bool jj_3R_267()
	{
		if (jj_3R_80())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_268()
	{
		if (jj_3R_323())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_449()
	{
		if (jj_3R_461())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_461()
	{
		Token token = jj_scanpos;
		if (jj_3_10())
		{
			jj_scanpos = token;
			if (jj_3R_467())
			{
				return true;
			}
		}
		return false;
	}

	
	
	private bool jj_3R_304()
	{
		if (jj_3R_112())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_339());
		jj_scanpos = token;
		return false;
	}

	
	
	private bool jj_3R_323()
	{
		if (jj_scan_token(113))
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_370())
		{
			jj_scanpos = token;
		}
		return false;
	}

	
	[LineNumberTable(new byte[]
	{
		208, 51, 60, 140, 103, 111, 106, 103, 104, 103,
		138
	})]
	private bool jj_3R_242()
	{
		if (jj_scan_token(42))
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_305())
		{
			jj_scanpos = token;
		}
		if (jj_3R_97())
		{
			return true;
		}
		token = jj_scanpos;
		if (jj_3R_306())
		{
			jj_scanpos = token;
			if (jj_3R_307())
			{
				return true;
			}
		}
		return false;
	}

	
	
	private bool jj_3R_114()
	{
		if (jj_3R_97())
		{
			return true;
		}
		if (jj_3R_80())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_243()
	{
		if (jj_3R_98())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_244()
	{
		if (jj_3R_78())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_345()
	{
		if (jj_3R_84())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_370()
	{
		Token token = jj_scanpos;
		if (jj_3R_386())
		{
			jj_scanpos = token;
			if (jj_3R_387())
			{
				return true;
			}
		}
		return false;
	}

	
	
	private bool jj_3R_245()
	{
		if (jj_3R_197())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_386()
	{
		if (jj_scan_token(27))
		{
			return true;
		}
		if (jj_3R_97())
		{
			return true;
		}
		if (jj_3R_194())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_387()
	{
		if (jj_scan_token(53))
		{
			return true;
		}
		if (jj_3R_97())
		{
			return true;
		}
		if (jj_3R_194())
		{
			return true;
		}
		return false;
	}

	
	[LineNumberTable(new byte[]
	{
		208, 47, 26, 138, 103, 107, 103, 104, 103, 104,
		103, 104, 103, 104, 103, 104, 103, 234, 71
	})]
	private bool jj_3R_467()
	{
		if (jj_3R_120())
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_475())
		{
			jj_scanpos = token;
			if (jj_3R_476())
			{
				jj_scanpos = token;
				if (jj_3R_477())
				{
					jj_scanpos = token;
					if (jj_3R_478())
					{
						jj_scanpos = token;
						if (jj_3R_479())
						{
							jj_scanpos = token;
							if (jj_3R_480())
							{
								jj_scanpos = token;
								if (jj_3R_481())
								{
									return true;
								}
							}
						}
					}
				}
			}
		}
		return false;
	}

	
	
	private bool jj_3R_176()
	{
		if (jj_scan_token(105))
		{
			return true;
		}
		if (jj_scan_token(53))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_82()
	{
		Token token = jj_scanpos;
		if (jj_3R_134())
		{
			jj_scanpos = token;
		}
		if (jj_3R_135())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_475()
	{
		if (jj_3R_213())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_476()
	{
		if (jj_3R_379())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_477()
	{
		if (jj_3R_380())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_478()
	{
		if (jj_3R_483())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_479()
	{
		if (jj_3R_381())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_480()
	{
		if (jj_3R_382())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_481()
	{
		if (jj_3R_383())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_168()
	{
		if (jj_scan_token(13))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_169()
	{
		if (jj_scan_token(18))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_170()
	{
		if (jj_scan_token(15))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_171()
	{
		if (jj_scan_token(50))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_172()
	{
		if (jj_scan_token(38))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_173()
	{
		if (jj_scan_token(40))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_174()
	{
		if (jj_scan_token(31))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_175()
	{
		if (jj_scan_token(24))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_346()
	{
		if (jj_3R_84())
		{
			return true;
		}
		return false;
	}

	
	[LineNumberTable(new byte[]
	{
		208, 48, 116, 103, 111, 106, 103, 111, 108, 103,
		111, 106, 108
	})]
	private bool jj_3R_483()
	{
		Token token = jj_scanpos;
		if (jj_3R_486())
		{
			jj_scanpos = token;
		}
		if (jj_3R_84())
		{
			return true;
		}
		token = jj_scanpos;
		if (jj_3R_487())
		{
			jj_scanpos = token;
		}
		if (jj_scan_token(99))
		{
			return true;
		}
		token = jj_scanpos;
		if (jj_3R_488())
		{
			jj_scanpos = token;
		}
		if (jj_3R_195())
		{
			return true;
		}
		if (jj_scan_token(100))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_177()
	{
		if (jj_scan_token(105))
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_220())
		{
			jj_scanpos = token;
			if (jj_3R_221())
			{
				jj_scanpos = token;
				if (jj_3R_222())
				{
					return true;
				}
			}
		}
		return false;
	}

	
	
	private bool jj_3R_178()
	{
		if (jj_scan_token(101))
		{
			return true;
		}
		if (jj_3R_100())
		{
			return true;
		}
		if (jj_scan_token(102))
		{
			return true;
		}
		return false;
	}

	
	[LineNumberTable(new byte[]
	{
		208, 40, 237, 103, 111, 106, 106, 103, 111, 108,
		103, 111, 106, 108
	})]
	private bool jj_3R_381()
	{
		Token token = jj_scanpos;
		if (jj_3R_397())
		{
			jj_scanpos = token;
		}
		if (jj_3R_84())
		{
			return true;
		}
		if (jj_3R_86())
		{
			return true;
		}
		token = jj_scanpos;
		if (jj_3R_433())
		{
			jj_scanpos = token;
		}
		if (jj_scan_token(99))
		{
			return true;
		}
		token = jj_scanpos;
		if (jj_3R_434())
		{
			jj_scanpos = token;
		}
		if (jj_3R_195())
		{
			return true;
		}
		if (jj_scan_token(100))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_220()
	{
		if (jj_scan_token(56))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_221()
	{
		if (jj_3R_242())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_222()
	{
		Token token = jj_scanpos;
		if (jj_3R_274())
		{
			jj_scanpos = token;
		}
		if (jj_3R_84())
		{
			return true;
		}
		token = jj_scanpos;
		if (jj_3R_275())
		{
			jj_scanpos = token;
		}
		return false;
	}

	
	[LineNumberTable(new byte[]
	{
		208, 35, 206, 103, 111, 106, 106, 106, 138, 103,
		145, 103, 111, 103, 104, 103, 140
	})]
	private bool jj_3R_383()
	{
		Token token = jj_scanpos;
		if (jj_3R_398())
		{
			jj_scanpos = token;
		}
		if (jj_3R_97())
		{
			return true;
		}
		if (jj_3R_113())
		{
			return true;
		}
		if (jj_3R_84())
		{
			return true;
		}
		if (jj_3R_86())
		{
			return true;
		}
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_436());
		jj_scanpos = token;
		token = jj_scanpos;
		if (jj_3R_437())
		{
			jj_scanpos = token;
		}
		token = jj_scanpos;
		if (jj_3R_438())
		{
			jj_scanpos = token;
			if (jj_scan_token(103))
			{
				return true;
			}
		}
		return false;
	}

	
	
	private bool jj_3R_77()
	{
		if (jj_3R_130())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_79()
	{
		if (jj_3R_130())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_347()
	{
		if (jj_3R_100())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_274()
	{
		if (jj_3R_98())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_275()
	{
		if (jj_3R_197())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_81()
	{
		if (jj_3R_133())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_115()
	{
		if (jj_3R_98())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_181()
	{
		if (jj_scan_token(62))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_182()
	{
		if (jj_3R_80())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_486()
	{
		if (jj_3R_130())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_487()
	{
		if (jj_scan_token(58))
		{
			return true;
		}
		if (jj_3R_164())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_490());
		jj_scanpos = token;
		return false;
	}

	
	
	private bool jj_3R_488()
	{
		if (jj_3R_83())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_490()
	{
		if (jj_scan_token(104))
		{
			return true;
		}
		if (jj_3R_164())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_291()
	{
		if (jj_scan_token(77))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_292()
	{
		if (jj_scan_token(76))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_293()
	{
		if (jj_scan_token(82))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_294()
	{
		if (jj_scan_token(89))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_295()
	{
		if (jj_scan_token(90))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_296()
	{
		if (jj_scan_token(92))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_297()
	{
		if (jj_3R_336())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_298()
	{
		if (jj_3R_337())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_336()
	{
		Token token = jj_scanpos;
		if (jj_3R_367())
		{
			jj_scanpos = token;
			if (jj_3R_368())
			{
				return true;
			}
		}
		return false;
	}

	
	
	private bool jj_3R_337()
	{
		if (jj_scan_token(43))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_367()
	{
		if (jj_scan_token(60))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_368()
	{
		if (jj_scan_token(28))
		{
			return true;
		}
		return false;
	}

	
	[LineNumberTable(new byte[]
	{
		208, 49, 95, 138, 103, 107, 103, 104, 103, 104,
		103, 104, 103, 104, 103, 104, 103, 234, 71
	})]
	private bool jj_3R_329()
	{
		if (jj_3R_120())
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_355())
		{
			jj_scanpos = token;
			if (jj_3R_356())
			{
				jj_scanpos = token;
				if (jj_3R_357())
				{
					jj_scanpos = token;
					if (jj_3R_358())
					{
						jj_scanpos = token;
						if (jj_3R_359())
						{
							jj_scanpos = token;
							if (jj_3R_360())
							{
								jj_scanpos = token;
								if (jj_3R_361())
								{
									return true;
								}
							}
						}
					}
				}
			}
		}
		return false;
	}

	
	
	private bool jj_3R_355()
	{
		if (jj_3R_213())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_356()
	{
		if (jj_3R_214())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_357()
	{
		if (jj_3R_379())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_358()
	{
		if (jj_3R_380())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_359()
	{
		if (jj_3R_381())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_360()
	{
		if (jj_3R_382())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_361()
	{
		if (jj_3R_383())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_348()
	{
		if (jj_3R_372())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_452()
	{
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_464());
		jj_scanpos = token;
		token = jj_scanpos;
		if (jj_3R_465())
		{
			jj_scanpos = token;
		}
		return false;
	}

	
	
	private bool jj_3R_453()
	{
		if (jj_scan_token(30))
		{
			return true;
		}
		if (jj_3R_135())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_372()
	{
		if (jj_scan_token(97))
		{
			return true;
		}
		if (jj_3R_401())
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3_58())
		{
			jj_scanpos = token;
		}
		if (jj_scan_token(98))
		{
			return true;
		}
		return false;
	}

	
	[LineNumberTable(new byte[]
	{
		208, 50, 12, 108, 108, 106, 170, 103, 145, 106,
		108, 106
	})]
	private bool jj_3R_464()
	{
		if (jj_scan_token(17))
		{
			return true;
		}
		if (jj_scan_token(97))
		{
			return true;
		}
		if (jj_3R_120())
		{
			return true;
		}
		if (jj_3R_194())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_469());
		jj_scanpos = token;
		if (jj_3R_112())
		{
			return true;
		}
		if (jj_scan_token(98))
		{
			return true;
		}
		if (jj_3R_135())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_465()
	{
		if (jj_scan_token(30))
		{
			return true;
		}
		if (jj_3R_135())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_85()
	{
		if (jj_3R_130())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_234()
	{
		if (jj_3R_290())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_469()
	{
		if (jj_scan_token(129))
		{
			return true;
		}
		if (jj_3R_164())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_290()
	{
		if (jj_3R_100())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_335());
		jj_scanpos = token;
		return false;
	}

	
	
	private bool jj_3R_87()
	{
		if (jj_3R_130())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_88()
	{
		if (jj_3R_133())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_335()
	{
		if (jj_scan_token(104))
		{
			return true;
		}
		if (jj_3R_100())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_224()
	{
		Token token = jj_scanpos;
		if (jj_3_32())
		{
			jj_scanpos = token;
			if (jj_3R_278())
			{
				jj_scanpos = token;
				if (jj_3R_279())
				{
					return true;
				}
			}
		}
		return false;
	}

	
	
	private bool jj_3R_435()
	{
		if (jj_scan_token(104))
		{
			return true;
		}
		if (jj_3R_125())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_278()
	{
		if (jj_scan_token(115))
		{
			return true;
		}
		if (jj_3R_352())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_279()
	{
		if (jj_scan_token(108))
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_353())
		{
			jj_scanpos = token;
		}
		token = jj_scanpos;
		if (jj_3R_354())
		{
			jj_scanpos = token;
			if (jj_scan_token(42))
			{
				return true;
			}
		}
		return false;
	}

	
	
	private bool jj_3R_352()
	{
		Token token = jj_scanpos;
		if (jj_3R_377())
		{
			jj_scanpos = token;
			if (jj_3R_378())
			{
				return true;
			}
		}
		return false;
	}

	
	
	private bool jj_3R_353()
	{
		if (jj_3R_98())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_354()
	{
		if (jj_3R_78())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_188()
	{
		if (jj_scan_token(109))
		{
			return true;
		}
		if (jj_3R_89())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_401()
	{
		if (jj_3R_124())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3_59());
		jj_scanpos = token;
		return false;
	}

	
	
	private bool jj_3R_151()
	{
		if (jj_scan_token(109))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_152()
	{
		if (jj_scan_token(135))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_153()
	{
		if (jj_scan_token(136))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_154()
	{
		if (jj_scan_token(140))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_155()
	{
		if (jj_scan_token(133))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_156()
	{
		if (jj_scan_token(134))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_157()
	{
		if (jj_scan_token(141))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_158()
	{
		if (jj_scan_token(142))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_159()
	{
		if (jj_scan_token(143))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_160()
	{
		if (jj_scan_token(137))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_161()
	{
		if (jj_scan_token(139))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_162()
	{
		if (jj_scan_token(138))
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_305()
	{
		if (jj_3R_98())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_306()
	{
		if (jj_3R_108())
		{
			return true;
		}
		if (jj_3R_340())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_307()
	{
		if (jj_3R_148())
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3R_341())
		{
			jj_scanpos = token;
			if (jj_3R_342())
			{
				return true;
			}
		}
		return false;
	}

	
	
	private bool jj_3R_340()
	{
		if (jj_3_49())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3_49());
		jj_scanpos = token;
		token = jj_scanpos;
		if (jj_3R_369())
		{
			jj_scanpos = token;
		}
		return false;
	}

	
	
	private bool jj_3R_341()
	{
		if (jj_3R_340())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_342()
	{
		if (jj_3R_197())
		{
			return true;
		}
		Token token = jj_scanpos;
		if (jj_3_48())
		{
			jj_scanpos = token;
		}
		return false;
	}

	
	
	private bool jj_3R_124()
	{
		Token token = jj_scanpos;
		if (jj_3R_186())
		{
			jj_scanpos = token;
			if (jj_3R_187())
			{
				return true;
			}
		}
		return false;
	}

	
	
	private bool jj_3R_180()
	{
		if (jj_3R_133())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_217()
	{
		if (jj_3R_269())
		{
			return true;
		}
		Token token;
		do
		{
			token = jj_scanpos;
		}
		while (!jj_3R_330());
		jj_scanpos = token;
		return false;
	}

	
	
	private bool jj_3R_277()
	{
		if (jj_scan_token(113))
		{
			return true;
		}
		if (jj_3R_100())
		{
			return true;
		}
		if (jj_scan_token(114))
		{
			return true;
		}
		if (jj_3R_100())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_139()
	{
		if (jj_3R_203())
		{
			return true;
		}
		return false;
	}

	
	
	private bool jj_3R_140()
	{
		if (jj_3R_100())
		{
			return true;
		}
		return false;
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 52, 25, 232, 25, 167, 240, 92, 109, 103,
		231, 160, 113, 236, 126, 139, 103, 237, 159, 85,
		110, 118, 107, 103, 103, 106, 41, 134, 108, 45,
		134
	})]
	public GeneratedJavaParser(Provider stream)
	{
		jj_lookingAhead = false;
		jj_la1 = new int[181];
		jj_2_rtns = new JJCalls[69];
		jj_rescan = false;
		jj_gc = 0;
		jj_ls = new LookaheadSuccess(null);
		jj_expentries = new ArrayList();
		jj_kind = -1;
		jj_lasttokens = new int[100];
		jj_input_stream = new SimpleCharStream(stream, 1, 1);
		GeneratedJavaParserTokenManager.___003Cclinit_003E();
		token_source = new GeneratedJavaParserTokenManager(jj_input_stream);
		this.token = new Token();
		jj_ntk = -1;
		jj_gen = 0;
		for (int i = 0; i < 181; i++)
		{
			jj_la1[i] = -1;
		}
		for (int i = 0; i < (nint)jj_2_rtns.LongLength; i++)
		{
			jj_2_rtns[i] = new JJCalls();
		}
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 52, 57, 104, 144, 142, 104, 182, 113, 107,
		103, 103, 106, 41, 134, 108, 45, 134
	})]
	public override void ReInit(Provider stream)
	{
		if (jj_input_stream == null)
		{
			jj_input_stream = new SimpleCharStream(stream, 1, 1);
		}
		else
		{
			jj_input_stream.reInit(stream, 1, 1);
		}
		if (token_source == null)
		{
			GeneratedJavaParserTokenManager.___003Cclinit_003E();
			token_source = new GeneratedJavaParserTokenManager(jj_input_stream);
		}
		token_source.ReInit(jj_input_stream);
		this.token = new Token();
		jj_ntk = -1;
		jj_gen = 0;
		for (int i = 0; i < 181; i++)
		{
			jj_la1[i] = -1;
		}
		for (int i = 0; i < (nint)jj_2_rtns.LongLength; i++)
		{
			jj_2_rtns[i] = new JJCalls();
		}
	}

	
	[LineNumberTable(new byte[]
	{
		208, 52, 242, 107, 107, 105, 105, 135, 109, 115,
		106, 112, 132, 112, 135, 112, 135, 112, 135, 112,
		234, 50, 9, 233, 85, 106, 101, 108, 105, 242,
		60, 230, 71, 103, 102, 104, 113, 112, 52, 166
	})]
	public virtual ParseException generateParseException()
	{
		jj_expentries.clear();
		bool[] array = new bool[148];
		if (jj_kind >= 0)
		{
			array[jj_kind] = true;
			jj_kind = -1;
		}
		for (int i = 0; i < 181; i++)
		{
			if (jj_la1[i] != jj_gen)
			{
				continue;
			}
			for (int j = 0; j < 32; j++)
			{
				if ((jj_la1_0[i] & (1 << j)) != 0)
				{
					array[j] = true;
				}
				if ((jj_la1_1[i] & (1 << j)) != 0)
				{
					array[32 + j] = true;
				}
				if ((jj_la1_2[i] & (1 << j)) != 0)
				{
					array[64 + j] = true;
				}
				if ((jj_la1_3[i] & (1 << j)) != 0)
				{
					array[96 + j] = true;
				}
				if ((jj_la1_4[i] & (1 << j)) != 0)
				{
					array[128 + j] = true;
				}
			}
		}
		for (int i = 0; i < 148; i++)
		{
			if (array[i])
			{
				jj_expentry = new int[1];
				jj_expentry[0] = i;
				jj_expentries.add(jj_expentry);
			}
		}
		jj_endpos = 0;
		jj_rescan_token();
		jj_add_error_token(0, 0);
		int[][] array2 = new int[jj_expentries.size()][];
		for (int j = 0; j < jj_expentries.size(); j++)
		{
			array2[j] = (int[])jj_expentries.get(j);
		}
		ParseException result = new ParseException(this.token, array2, GeneratedJavaParserConstants.tokenImage, (token_source != null) ? GeneratedJavaParserTokenManager.___003C_003ElexStateNames[token_source.curLexState] : null);
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		208, 52, 201, 101, 161, 107, 127, 1, 107, 145,
		107, 48, 198, 127, 5, 108, 99, 110, 112, 99,
		226, 61, 232, 70, 100, 114, 162, 133, 99, 103,
		176
	})]
	private void jj_add_error_token(int kind, int pos)
	{
		if (pos >= 100)
		{
			return;
		}
		if (pos == jj_endpos + 1)
		{
			int[] array = jj_lasttokens;
			int num = jj_endpos;
			jj_endpos = num + 1;
			array[num] = kind;
		}
		else
		{
			if (jj_endpos == 0)
			{
				return;
			}
			jj_expentry = new int[jj_endpos];
			for (int i = 0; i < jj_endpos; i++)
			{
				jj_expentry[i] = jj_lasttokens[i];
			}
			Iterator iterator = jj_expentries.iterator();
			while (iterator.hasNext())
			{
				int[] array2 = (int[])iterator.next();
				if ((nint)array2.LongLength != (nint)jj_expentry.LongLength)
				{
					continue;
				}
				int num2 = 1;
				for (int j = 0; j < (nint)jj_expentry.LongLength; j++)
				{
					if (array2[j] != jj_expentry[j])
					{
						num2 = 0;
						break;
					}
				}
				if (num2 != 0)
				{
					jj_expentries.add(jj_expentry);
					break;
				}
			}
			if (pos != 0)
			{
				jj_endpos = pos;
				jj_lasttokens[jj_endpos - 1] = kind;
			}
		}
	}

	
	[LineNumberTable(new byte[]
	{
		208, 53, 44, 103, 138, 137, 113, 108, 108, 108,
		127, 160, 192, 108, 108, 108, 108, 108, 108, 108,
		108, 108, 108, 108, 108, 108, 108, 108, 108, 108,
		108, 108, 108, 108, 108, 108, 108, 108, 108, 108,
		108, 108, 108, 108, 108, 108, 108, 108, 108, 108,
		108, 108, 108, 108, 108, 108, 108, 108, 108, 108,
		108, 108, 108, 108, 108, 108, 108, 108, 108, 108,
		108, 105, 105, 105, 105, 105, 105, 105, 105, 105,
		105, 167, 103, 113, 227, 159, 174, 233, 160, 84,
		103
	})]
	private void jj_rescan_token()
	{
		jj_rescan = true;
		for (int i = 0; i < 69; i++)
		{
			try
			{
				JJCalls jJCalls = jj_2_rtns[i];
				do
				{
					if (jJCalls.gen > jj_gen)
					{
						jj_la = jJCalls.arg;
						jj_scanpos = jJCalls.first;
						jj_lastpos = jJCalls.first;
						switch (i)
						{
						case 0:
							jj_3_1();
							break;
						case 1:
							jj_3_2();
							break;
						case 2:
							jj_3_3();
							break;
						case 3:
							jj_3_4();
							break;
						case 4:
							jj_3_5();
							break;
						case 5:
							jj_3_6();
							break;
						case 6:
							jj_3_7();
							break;
						case 7:
							jj_3_8();
							break;
						case 8:
							jj_3_9();
							break;
						case 9:
							jj_3_10();
							break;
						case 10:
							jj_3_11();
							break;
						case 11:
							jj_3_12();
							break;
						case 12:
							jj_3_13();
							break;
						case 13:
							jj_3_14();
							break;
						case 14:
							jj_3_15();
							break;
						case 15:
							jj_3_16();
							break;
						case 16:
							jj_3_17();
							break;
						case 17:
							jj_3_18();
							break;
						case 18:
							jj_3_19();
							break;
						case 19:
							jj_3_20();
							break;
						case 20:
							jj_3_21();
							break;
						case 21:
							jj_3_22();
							break;
						case 22:
							jj_3_23();
							break;
						case 23:
							jj_3_24();
							break;
						case 24:
							jj_3_25();
							break;
						case 25:
							jj_3_26();
							break;
						case 26:
							jj_3_27();
							break;
						case 27:
							jj_3_28();
							break;
						case 28:
							jj_3_29();
							break;
						case 29:
							jj_3_30();
							break;
						case 30:
							jj_3_31();
							break;
						case 31:
							jj_3_32();
							break;
						case 32:
							jj_3_33();
							break;
						case 33:
							jj_3_34();
							break;
						case 34:
							jj_3_35();
							break;
						case 35:
							jj_3_36();
							break;
						case 36:
							jj_3_37();
							break;
						case 37:
							jj_3_38();
							break;
						case 38:
							jj_3_39();
							break;
						case 39:
							jj_3_40();
							break;
						case 40:
							jj_3_41();
							break;
						case 41:
							jj_3_42();
							break;
						case 42:
							jj_3_43();
							break;
						case 43:
							jj_3_44();
							break;
						case 44:
							jj_3_45();
							break;
						case 45:
							jj_3_46();
							break;
						case 46:
							jj_3_47();
							break;
						case 47:
							jj_3_48();
							break;
						case 48:
							jj_3_49();
							break;
						case 49:
							jj_3_50();
							break;
						case 50:
							jj_3_51();
							break;
						case 51:
							jj_3_52();
							break;
						case 52:
							jj_3_53();
							break;
						case 53:
							jj_3_54();
							break;
						case 54:
							jj_3_55();
							break;
						case 55:
							jj_3_56();
							break;
						case 56:
							jj_3_57();
							break;
						case 57:
							jj_3_58();
							break;
						case 58:
							jj_3_59();
							break;
						case 59:
							jj_3_60();
							break;
						case 60:
							jj_3_61();
							break;
						case 61:
							jj_3_62();
							break;
						case 62:
							jj_3_63();
							break;
						case 63:
							jj_3_64();
							break;
						case 64:
							jj_3_65();
							break;
						case 65:
							jj_3_66();
							break;
						case 66:
							jj_3_67();
							break;
						case 67:
							jj_3_68();
							break;
						case 68:
							jj_3_69();
							break;
						}
					}
					jJCalls = jJCalls.next;
				}
				while (jJCalls != null);
			}
			catch (LookaheadSuccess)
			{
				goto IL_049c;
			}
			continue;
		IL_049c:
			;
			
		}
		jj_rescan = false;
	}

	
	private static void jj_la1_init_0()
	{
		jj_la1_0 = new int[181]
		{
			608700416, 67633152, 608700416, 1, 0, 0, 541067264, 524288, 0, 134217728,
			0, 0, 0, 0, 0, 0, 67108864, 0, -1521702912, -1521702912,
			0, 0, 0, 0, 0, 134217728, 0, -1521702912, -1521702912, -1521702912,
			-1521702912, 524288, -2063294464, -1521702912, 0, 0, 0, 524288, -2063294464, -1521702912,
			0, 0, 0, -1794859008, -1794859008, 0, 0, 0, 0, 0,
			0, -1522227200, 0, -1522227200, 0, 0, 0, 0, 0, 0,
			0, 0, -1794859008, 0, -2130403328, -2063294464, -2063294464, 0, -2063294464, -2063294464,
			134217728, 134217728, -2130403328, -2063294464, 67108864, 0, 67108864, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, -2063294464, 0,
			0, 0, 0, 0, 0, 0, 0, 0, -1794859008, 0,
			0, -1794859008, 0, 0, -2063294464, 0, 0, 0, 67108864, 0,
			0, -1794859008, 0, 67108864, 0, 268435456, 67108864, 0, 0, 0,
			0, 0, 268435456, 268435456, -1794859008, 0, 0, 0, -2063294464, -1794859008,
			0, 4096, -1784356864, 0, -1784352768, 0, -1794859008, 0, 0, -1794859008,
			4259840, 4259840, 0, 4259840, -1794859008, 0, 33554432, -1253791744, -1794859008, -1794859008,
			-1253791744, -1794859008, 0, 67108864, 67108864, -1794859008, 0, 131072, 0, 1073741824,
			-1794859008, 67108864, 0, -1794859008, -1794859008, 0, -1521702912, -1521702912, 524288, -2063294464,
			4194304, 0, 0, 0, 0, 0, 0, 0, 0, -1794859008,
			67633152
		};
	}

	
	private static void jj_la1_init_1()
	{
		jj_la1_1 = new int[181]
		{
			-2003180912, 65664, -2003180912, 0, 524288, 0, -2003246592, 128, 0, 0,
			8, 0, 8, 0, 0, 8, 1114112, 0, -929176640, -929176640,
			0, 0, 0, 0, 0, 0, 0, -929176640, -929176640, -929176640,
			-929176640, 128, 1075118400, -929176640, 0, 0, 67108864, 128, 1075118400, -929176640,
			0, 0, 0, 1366625600, 1366625600, 0, 0, 0, 0, 67108864,
			0, -2002918592, 0, -2002918592, 0, 0, 0, 0, 0, 67108864,
			0, 0, 1362431296, 524288, 262464, 1376576, 1376576, 0, 1376576, 1376576,
			2097152, 2097152, 262464, 1075118400, 1114112, 0, 1115136, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 1376576, 32,
			0, 0, 0, 0, 0, 0, 0, 0, 1366625600, 0,
			0, 1366625600, 0, 0, 1376576, 0, 0, 0, 1115136, 0,
			0, 1366625600, 0, 1115136, 0, 287312896, 1114112, 0, 0, 0,
			16778240, 0, 268437504, 268435456, 1366625600, 0, 0, 0, 1376576, 1366625600,
			0, 0, 1945570629, 0, 1945570629, 0, 1366625600, 0, 0, 1362431296,
			0, 0, 0, 0, 1400180032, 0, 0, -637669568, 1366625600, 1366625600,
			-637669568, 1366625600, 0, 1114112, 1114112, 1366625600, 0, 0, 0, 0,
			1362431296, 1114112, 0, 1366625600, 1366625600, 0, -2002918464, -2002918464, 128, 1376576,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 1362431296,
			128
		};
	}

	
	private static void jj_la1_init_2()
	{
		jj_la1_2 = new int[181]
		{
			2336, 288, 2336, 0, 0, 0, 2048, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 1073745918, 0, 1073745918, 1073745918,
			0, 0, 0, 0, 0, 0, 0, 1073745918, 1073745918, 1073745918,
			1073745918, 0, 1073745918, 1073745918, 0, 0, 0, 0, 1073745918, 1073745918,
			0, 0, 0, 1443119102, 1443119102, 0, 0, 0, 0, 0,
			0, 1073745918, 0, 1073745918, 0, 0, 0, 0, 0, 0,
			0, 0, 1443119102, 0, 0, 1073745918, 1073745918, 0, 1073745918, 1073745918,
			0, 0, 0, 1073745918, 1073745918, 0, 1073745918, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 1073745918, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 1443119102, 0,
			0, 1443119102, 0, 0, 1073745918, 0, 0, 0, 1073745918, 0,
			0, 1443119102, 0, 1073745918, 0, 369373184, 1073745918, 0, 0, 0,
			0, 0, 369373184, 0, 1443119102, 0, 0, 0, 1073745918, 1443119102,
			0, 0, 1443119103, 0, 1443119103, 0, 1443119102, 0, 0, 1443119102,
			0, 0, 0, 0, 1443119102, 0, 0, 1443119102, 1443119102, 1443119102,
			1443119102, 1443119102, 0, 1073745918, 1073745918, 1443119102, 0, 0, 0, 0,
			1443119102, 1073745918, 0, 1443119102, 1443119102, 0, 1073745918, 1073745918, 0, 1073745918,
			0, 0, 8, 0, 8, 0, 1732, 32, 1732, 1443119102,
			0
		};
	}

	
	private static void jj_la1_init_3()
	{
		jj_la1_3 = new int[181]
		{
			2176, 2176, 2176, 0, 0, 512, 2048, 0, 16384, 0,
			0, 16384, 0, 256, 256, 0, 2048, 256, 18568, 18568,
			128, 2048, 2, 8, 256, 0, 0, 18568, 18568, 18568,
			18568, 0, 18432, 18432, 16384, 256, 0, 0, 18432, 18432,
			256, 8192, 2080, 1006733322, 1006733322, 256, 16384, 2080, 256, 0,
			136, 2048, 256, 2048, 256, 256, 3072, 16384, 256, 0,
			16384, 16384, 18434, 0, 0, 0, 2048, 256, 133120, 131072,
			0, 0, 0, 0, 0, 16384, 0, 528384, 536576, 8192,
			131072, 33554432, 16777216, 0, 0, 0, 9437184, 9437184, 2048, 0,
			6307840, 6307840, 0, 805306368, 805306368, -1073741824, -1073741824, 805306368, 1006733314, 98304,
			98304, 2050, 201326592, 0, 0, 16384, 2, 16384, 0, 4608,
			4, 1006733314, 16384, 0, 2, 2, 0, 512, 16384, 2,
			0, 544, 0, 0, 1006733314, 256, 16384, 2082, 0, 1006733314,
			8, 0, 201328778, 262144, 201328778, 256, 1006733322, 201334784, 201334784, 134219778,
			0, 0, 256, 0, 1006733322, 786432, 0, 1006733314, 1006733314, 1006733314,
			1006733442, 1006733314, 256, 0, 0, 1006733314, 2, 0, 0, 0,
			2050, 0, 256, 1006733322, 1006733322, 256, 2176, 2176, 0, 2048,
			0, 256, 0, 256, 0, 256, 0, 0, 0, 18434,
			2048
		};
	}

	
	private static void jj_la1_init_4()
	{
		jj_la1_4 = new int[181]
		{
			0, 0, 0, 524288, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 1, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 65504, 65504,
			0, 0, 0, 2, 4, 1, 0, 0, 0, 0,
			262144, 262144, 16, 0, 0, 8, 8, 0, 0, 0,
			0, 0, 0, 1, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 65504, 65504, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 2, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0
		};
	}

	internal virtual Token getCurrentToken()
	{
		return this.token;
	}

	
	
	
	internal virtual void setTabSize(int size)
	{
		jj_input_stream.setTabSize(size);
	}

	internal override GeneratedJavaParserTokenManager getTokenSource()
	{
		return token_source;
	}

	
	
	[LineNumberTable(new byte[]
	{
		19,
		98,
		103,
		98,
		135,
		98,
		194,
		201,
		139,
		109,
		231,
		70,
		byte.MaxValue,
		161,
		70,
		87,
		162,
		110,
		133,
		159,
		161,
		73,
		104,
		106,
		229,
		87,
		104,
		191,
		74,
		106,
		106,
		165,
		106,
		106,
		165,
		106,
		106,
		165,
		106,
		106,
		197,
		105,
		165,
		105,
		165,
		110,
		104,
		235,
		69,
		110,
		104,
		171,
		159,
		13,
		104,
		162,
		108,
		162,
		110,
		104,
		139,
		byte.MaxValue,
		44,
		70,
		226,
		59,
		98,
		106,
		127,
		16,
		109,
		138
	})]
	public CompilationUnit CompilationUnit()
	{
		//Discarded unreachable code: IL_057f
		PackageDeclaration packageDeclaration = null;
		NodeList nodeList = base.emptyNodeList();
		
		NodeList nodeList2 = base.emptyNodeList();
		
		ModuleDeclaration module = null;
		ParseException ex;
		try
		{
			while (jj_2_1(2))
			{
				jj_consume_token(103);
			}
			if (jj_2_2(int.MaxValue))
			{
				packageDeclaration = PackageDeclaration();
			}
			while (true)
			{
				switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
				{
				default:
					jj_la1[0] = jj_gen;
					switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
					{
					case 0:
						jj_consume_token(0);
						break;
					case 147:
						jj_consume_token(147);
						break;
					default:
						jj_la1[3] = jj_gen;
						jj_consume_token(-1);
						
						throw new ParseException();
					}
					if ("" != null)
					{
						com.github.javaparser.ast.CompilationUnit.___003Cclinit_003E();
						return new CompilationUnit(base.range(token_source.getHomeToken(), token()), packageDeclaration, nodeList, nodeList2, module);
					}
					goto end_IL_003e;
				case 11:
				case 19:
				case 22:
				case 26:
				case 29:
				case 36:
				case 39:
				case 41:
				case 45:
				case 46:
				case 47:
				case 48:
				case 51:
				case 52:
				case 55:
				case 59:
				case 63:
				case 69:
				case 72:
				case 75:
				case 103:
				case 107:
					switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
					{
					case 36:
					{
						ImportDeclaration obj5 = ImportDeclaration();
						nodeList = base.add(nodeList, obj5);
						break;
					}
					case 11:
					case 19:
					case 22:
					case 26:
					case 29:
					case 39:
					case 41:
					case 45:
					case 46:
					case 47:
					case 48:
					case 51:
					case 52:
					case 55:
					case 59:
					case 63:
					case 69:
					case 72:
					case 75:
					case 103:
					case 107:
					{
						ModifierHolder modifier = Modifiers();
						switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
						{
						case 19:
						case 39:
						{
							ClassOrInterfaceDeclaration obj4 = ClassOrInterfaceDeclaration(modifier);
							nodeList2 = base.add(nodeList2, obj4);
							break;
						}
						case 48:
						{
							RecordDeclaration obj3 = RecordDeclaration(modifier);
							nodeList2 = base.add(nodeList2, obj3);
							break;
						}
						case 26:
						{
							EnumDeclaration obj2 = EnumDeclaration(modifier);
							nodeList2 = base.add(nodeList2, obj2);
							break;
						}
						case 107:
						{
							AnnotationDeclaration obj = AnnotationTypeDeclaration(modifier);
							nodeList2 = base.add(nodeList2, obj);
							break;
						}
						case 69:
						case 72:
							module = ModuleDeclaration(modifier);
							break;
						case 103:
							jj_consume_token(103);
							break;
						default:
							jj_la1[1] = jj_gen;
							jj_consume_token(-1);
							
							throw new ParseException();
						}
						break;
					}
					default:
						jj_la1[2] = jj_gen;
						jj_consume_token(-1);
						
						throw new ParseException();
					}
					break;
				}
				continue;
				end_IL_003e:
				break;
			}
		}
		catch (ParseException x)
		{
			ex = ByteCodeHelper.MapException<ParseException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0595;
		}
		goto IL_05ee;
		IL_0595:
		ParseException p = ex;
		base.recover(0, p);
		com.github.javaparser.ast.CompilationUnit.___003Cclinit_003E();
		CompilationUnit compilationUnit = new CompilationUnit(base.range(token_source.getHomeToken(), token()), null, new NodeList(), new NodeList(), null);
		compilationUnit.setParsed(Node.Parsedness.___003C_003EUNPARSABLE);
		if ("" != null)
		{
			return compilationUnit;
		}
		goto IL_05ee;
		IL_05ee:
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
		
	[LineNumberTable(new byte[]
	{
		170,
		183,
		134,
		103,
		104,
		114,
		172,
		103,
		105,
		byte.MaxValue,
		161,
		62,
		89,
		165,
		111,
		162,
		127,
		3
	})]
	public IntersectionType IntersectionType(NodeList annotations)
	{
		JavaToken __003C_003EINVALID = JavaToken.___003C_003EINVALID;
		NodeList list = base.emptyNodeList();
		ReferenceType referenceType = ReferenceType(annotations);
		__003C_003EINVALID = base.orIfInvalid(__003C_003EINVALID, referenceType);
		list = base.add(list, referenceType);
		jj_consume_token(128);
		while (true)
		{
			referenceType = AnnotatedReferenceType();
			list = base.add(list, referenceType);
			switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
			{
			case 13:
			case 15:
			case 18:
			case 24:
			case 26:
			case 31:
			case 38:
			case 40:
			case 48:
			case 50:
			case 52:
			case 65:
			case 66:
			case 67:
			case 68:
			case 69:
			case 70:
			case 71:
			case 72:
			case 73:
			case 74:
			case 75:
			case 94:
			case 107:
				continue;
			}
			jj_la1[66] = jj_gen;
			if ("" != null)
			{
				com.github.javaparser.ast.type.IntersectionType.___003Cclinit_003E();
				IntersectionType result = new IntersectionType(base.range(__003C_003EINVALID, token()), list);
				
				return result;
			}
			
			throw new IllegalStateException("Missing return statement in function");
		}
	}

	
	
	
	public BlockStmt BlockParseStart()
	{
		BlockStmt result = Block();
		jj_consume_token(0);
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		191,
		77,
		105,
		140,
		byte.MaxValue,
		161,
		74,
		104,
		103,
		162,
		114,
		104,
		171,
		104,
		105
	})]
	public Statement BlockStatementParseStart()
	{
		Statement result;
		if (jj_2_69(3))
		{
			result = BlockStatement();
		}
		else
		{
			switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
			{
			case 13:
			case 15:
			case 18:
			case 24:
			case 26:
			case 28:
			case 31:
			case 38:
			case 40:
			case 42:
			case 43:
			case 48:
			case 50:
			case 52:
			case 53:
			case 56:
			case 60:
			case 62:
			case 65:
			case 66:
			case 67:
			case 68:
			case 69:
			case 70:
			case 71:
			case 72:
			case 73:
			case 74:
			case 75:
			case 76:
			case 77:
			case 82:
			case 89:
			case 90:
			case 92:
			case 94:
			case 97:
			case 107:
			case 110:
				break;
			default:
				jj_la1[179] = jj_gen;
				jj_consume_token(-1);
				
				throw new ParseException();
			}
			result = ExplicitConstructorInvocation();
		}
		jj_consume_token(0);
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	
	public ImportDeclaration ImportDeclarationParseStart()
	{
		ImportDeclaration result = ImportDeclaration();
		jj_consume_token(0);
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	
	public Expression ExpressionParseStart()
	{
		Expression result = Expression();
		jj_consume_token(0);
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	
	public AnnotationExpr AnnotationParseStart()
	{
		AnnotationExpr result = Annotation();
		jj_consume_token(0);
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
		
	public BodyDeclaration AnnotationBodyDeclarationParseStart()
	{
		BodyDeclaration result = AnnotationBodyDeclaration();
		jj_consume_token(0);
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
		
	public BodyDeclaration ClassOrInterfaceBodyDeclarationParseStart()
	{
		BodyDeclaration result = ClassOrInterfaceBodyDeclaration();
		jj_consume_token(0);
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	
	public ClassOrInterfaceType ClassOrInterfaceTypeParseStart()
	{
		ClassOrInterfaceType result = AnnotatedClassOrInterfaceType();
		jj_consume_token(0);
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	
	public com.github.javaparser.ast.type.Type ResultTypeParseStart()
	{
		NodeList annotations = Annotations();
		com.github.javaparser.ast.type.Type result = ResultType(annotations);
		jj_consume_token(0);
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	
	public VariableDeclarationExpr VariableDeclarationExpressionParseStart()
	{
		VariableDeclarationExpr result = VariableDeclarationExpression();
		jj_consume_token(0);
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	
	public ExplicitConstructorInvocationStmt ExplicitConstructorInvocationParseStart()
	{
		ExplicitConstructorInvocationStmt result = ExplicitConstructorInvocation();
		jj_consume_token(0);
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	
	public Name NameParseStart()
	{
		Name result = Name();
		jj_consume_token(0);
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	
	public SimpleName SimpleNameParseStart()
	{
		SimpleName result = SimpleName();
		jj_consume_token(0);
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	
	public Parameter ParameterParseStart()
	{
		Parameter result = Parameter();
		jj_consume_token(0);
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	
	public PackageDeclaration PackageDeclarationParseStart()
	{
		PackageDeclaration result = PackageDeclaration();
		jj_consume_token(0);
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
		[LineNumberTable(new byte[]
	{
		191, 228, 103, 191, 27, 104, 162, 104, 162, 104,
		162, 114, 104, 139, 104, 105
	})]
	public TypeDeclaration TypeDeclarationParseStart()
	{
		ModifierHolder modifier = Modifiers();
		TypeDeclaration result;
		switch ((jj_ntk != -1) ? jj_ntk : jj_ntk_f())
		{
		case 19:
		case 39:
			result = ClassOrInterfaceDeclaration(modifier);
			break;
		case 26:
			result = EnumDeclaration(modifier);
			break;
		case 107:
			result = AnnotationTypeDeclaration(modifier);
			break;
		default:
			jj_la1[180] = jj_gen;
			jj_consume_token(-1);
			
			throw new ParseException();
		}
		jj_consume_token(0);
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	[LineNumberTable(new byte[]
	{
		191,
		byte.MaxValue,
		103,
		104,
		104,
		105
	})]
	public ModuleDeclaration ModuleDeclarationParseStart()
	{
		ModifierHolder modifier = Modifiers();
		ModuleDeclaration result = ModuleDeclaration(modifier);
		jj_consume_token(0);
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	
	public ModuleDirective ModuleDirectiveParseStart()
	{
		ModuleDirective result = ModuleDirective();
		jj_consume_token(0);
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	
	public TypeParameter TypeParameterParseStart()
	{
		NodeList annotations = Annotations();
		TypeParameter result = TypeParameter(annotations);
		jj_consume_token(0);
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	
	public MethodDeclaration MethodDeclarationParseStart()
	{
		ModifierHolder modifier = Modifiers();
		MethodDeclaration result = MethodDeclaration(modifier);
		jj_consume_token(0);
		if ("" != null)
		{
			return result;
		}
		
		throw new IllegalStateException("Missing return statement in function");
	}

	
	
	
	public GeneratedJavaParser(string sDSL)
		: this(new StringProvider(sDSL))
	{
	}

	
	
	
	public virtual void ReInit(string sDSL)
	{
		ReInit(new StringProvider(sDSL));
	}

	
	
	[LineNumberTable(new byte[]
	{
		208, 52, 80, 232, 159, 162, 167, 240, 92, 109,
		103, 231, 160, 113, 236, 126, 139, 103, 237, 159,
		140, 103, 107, 103, 103, 121, 127, 0
	})]
	public GeneratedJavaParser(GeneratedJavaParserTokenManager tm)
	{
		jj_lookingAhead = false;
		jj_la1 = new int[181];
		jj_2_rtns = new JJCalls[69];
		jj_rescan = false;
		jj_gc = 0;
		jj_ls = new LookaheadSuccess(null);
		jj_expentries = new ArrayList();
		jj_kind = -1;
		jj_lasttokens = new int[100];
		token_source = tm;
		this.token = new Token();
		jj_ntk = -1;
		jj_gen = 0;
		for (int i = 0; i < 181; i++)
		{
			jj_la1[i] = -1;
		}
		for (int i = 0; i < (nint)jj_2_rtns.LongLength; i++)
		{
			jj_2_rtns[i] = new JJCalls();
		}
	}

	
	
	
	public virtual void ReInit(GeneratedJavaParserTokenManager tm)
	{
		token_source = tm;
		this.token = new Token();
		jj_ntk = -1;
		jj_gen = 0;
		for (int i = 0; i < 181; i++)
		{
			jj_la1[i] = -1;
		}
		for (int i = 0; i < (nint)jj_2_rtns.LongLength; i++)
		{
			jj_2_rtns[i] = new JJCalls();
		}
	}

	
	
	public sealed override Token getNextToken()
	{
		if (this.token.next != null)
		{
			this.token = this.token.next;
		}
		else
		{
			Token obj = this.token;
			Token nextToken = token_source.getNextToken();
			Token token = obj;
			token.next = nextToken;
			this.token = nextToken;
		}
		jj_ntk = -1;
		jj_gen++;
		return this.token;
	}

	public bool trace_enabled()
	{
		return false;
	}

	public void enable_tracing()
	{
	}

	public void disable_tracing()
	{
	}

	
	static GeneratedJavaParser()
	{
		jj_la1_init_0();
		jj_la1_init_1();
		jj_la1_init_2();
		jj_la1_init_3();
		jj_la1_init_4();
	}
}
