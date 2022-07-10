using System;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast.comments;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;

namespace com.github.javaparser;

public class GeneratedJavaParserTokenManager :  GeneratedJavaParserConstants
{
		private List tokens;

	private CommentsCollection commentsCollection;

	private JavaToken homeToken;

		private Stack tokenWorkStack;

	private bool storeTokens;

	private bool yieldSupported;

	
	internal static long[] jjbitVec0;

	
	internal static long[] jjbitVec1;

	
	internal static long[] jjbitVec2;

	
	internal static long[] jjbitVec3;

	
	internal static long[] jjbitVec4;

	
	internal static long[] jjbitVec5;

	
	internal static long[] jjbitVec6;

	
	internal static long[] jjbitVec8;

	
	internal static long[] jjbitVec9;

	
	internal static long[] jjbitVec10;

	
	internal static long[] jjbitVec11;

	
	internal static long[] jjbitVec12;

	
	internal static long[] jjbitVec13;

	
	internal static long[] jjbitVec14;

	
	internal static long[] jjbitVec15;

	
	internal static long[] jjbitVec16;

	
	internal static long[] jjbitVec17;

	
	internal static long[] jjbitVec18;

	
	internal static long[] jjbitVec19;

	
	internal static long[] jjbitVec20;

	
	internal static long[] jjbitVec21;

	
	internal static long[] jjbitVec22;

	
	internal static long[] jjbitVec23;

	
	internal static long[] jjbitVec24;

	
	internal static long[] jjbitVec25;

	
	internal static long[] jjbitVec26;

	
	internal static long[] jjbitVec27;

	
	internal static long[] jjbitVec28;

	
	internal static long[] jjbitVec29;

	
	internal static long[] jjbitVec30;

	
	internal static long[] jjbitVec31;

	
	internal static long[] jjbitVec32;

	
	internal static long[] jjbitVec33;

	
	internal static long[] jjbitVec34;

	
	internal static long[] jjbitVec35;

	
	internal static long[] jjbitVec36;

	
	internal static long[] jjbitVec37;

	
	internal static long[] jjbitVec38;

	
	internal static long[] jjbitVec39;

	
	internal static long[] jjbitVec40;

	
	internal static long[] jjbitVec41;

	
	internal static long[] jjbitVec42;

	
	internal static long[] jjbitVec43;

	
	internal static long[] jjbitVec44;

	
	internal static long[] jjbitVec45;

	
	internal static long[] jjbitVec46;

	
	internal static long[] jjbitVec47;

	
	internal static long[] jjbitVec48;

	
	internal static long[] jjbitVec49;

	
	internal static long[] jjbitVec50;

	
	internal static long[] jjbitVec51;

	
	internal static long[] jjbitVec52;

	
	internal static long[] jjbitVec53;

	
	internal static long[] jjbitVec54;

	
	internal static long[] jjbitVec55;

	
	internal static long[] jjbitVec56;

	
	internal static long[] jjbitVec57;

	
	internal static long[] jjbitVec58;

	
	internal static long[] jjbitVec59;

	
	internal static long[] jjbitVec60;

	
	internal static long[] jjbitVec61;

	
	internal static long[] jjbitVec62;

	
	internal static long[] jjbitVec63;

	
	internal static long[] jjbitVec64;

	
	internal static long[] jjbitVec65;

	
	internal static long[] jjbitVec66;

	
	internal static long[] jjbitVec67;

	
	internal static long[] jjbitVec68;

	
	internal static long[] jjbitVec69;

	
	internal static long[] jjbitVec70;

	
	internal static long[] jjbitVec71;

	
	internal static long[] jjbitVec72;

	
	internal static long[] jjbitVec73;

	
	internal static long[] jjbitVec74;

	
	internal static long[] jjbitVec75;

	
	internal static long[] jjbitVec76;

	
	internal static long[] jjbitVec77;

	
	internal static long[] jjbitVec78;

	
	internal static long[] jjbitVec79;

	
	internal static long[] jjbitVec80;

	
	internal static long[] jjbitVec81;

	
	internal static long[] jjbitVec82;

	
	internal static long[] jjbitVec83;

	
	internal static long[] jjbitVec84;

	
	internal static long[] jjbitVec85;

	
	internal static long[] jjbitVec86;

	
	internal static long[] jjbitVec87;

	
	internal static long[] jjbitVec88;

	
	internal static long[] jjbitVec89;

	
	internal static long[] jjbitVec90;

	
	internal static long[] jjbitVec91;

	
	internal static long[] jjbitVec92;

	
	internal static long[] jjbitVec93;

	internal static string[] ___003C_003EjjstrLiteralImages;

	
	internal static int[] jjnextStates;

	internal int curLexState;

	internal int defaultLexState;

	internal int jjnewStateCnt;

	internal int jjround;

	internal int jjmatchedPos;

	internal int jjmatchedKind;

	internal static string[] ___003C_003ElexStateNames;

	internal static int[] ___003C_003EjjnewLexState;

	
	internal static long[] jjtoToken;

	
	internal static long[] jjtoSkip;

	
	internal static long[] jjtoSpecial;

	
	internal static long[] jjtoMore;

	protected internal SimpleCharStream input_stream;

	
	private int[] jjrounds;

	
	private int[] jjstateSet;

	
	private StringBuilder jjimage;

	private StringBuilder image;

	private int jjimageLen;

	private int lengthOfMatch;

	protected internal int curChar;

	
	public static string[] jjstrLiteralImages
	{
		
		get
		{
			return ___003C_003EjjstrLiteralImages;
		}
	}

	
	public static string[] lexStateNames
	{
		
		get
		{
			return ___003C_003ElexStateNames;
		}
	}

	
	public static int[] jjnewLexState
	{
		
		get
		{
			return ___003C_003EjjnewLexState;
		}
	}

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
	
	internal virtual void reset()
	{
		tokens = new ArrayList();
		commentsCollection = new CommentsCollection();
		homeToken = null;
	}

		internal virtual List getTokens()
	{
		if (storeTokens)
		{
			return tokens;
		}
		return null;
	}

	internal virtual CommentsCollection getCommentsCollection()
	{
		return commentsCollection;
	}

	
	public virtual void setStoreTokens(bool storeTokens)
	{
		int num = ((this.storeTokens = storeTokens) ? 1 : 0);
	}

	public virtual void setYieldSupported()
	{
		yieldSupported = true;
	}

	internal virtual JavaToken getHomeToken()
	{
		return homeToken;
	}

	
	
	[LineNumberTable(new byte[]
	{
		171, 206, 232, 147, 240, 107, 139, 139, 231, 171,
		51, 103, 231, 161, 39, 112, 112, 107, 236, 159,
		174, 103
	})]
	public GeneratedJavaParserTokenManager(SimpleCharStream stream)
	{
		tokens = new ArrayList();
		commentsCollection = new CommentsCollection();
		tokenWorkStack = new Stack();
		yieldSupported = false;
		curLexState = 0;
		defaultLexState = 0;
		jjrounds = new int[152];
		jjstateSet = new int[304];
		jjimage = new StringBuilder();
		image = jjimage;
		input_stream = stream;
	}

	
	
	
	public virtual void ReInit(SimpleCharStream stream)
	{
		int num = 0;
		jjnewStateCnt = num;
		jjmatchedPos = num;
		curLexState = defaultLexState;
		input_stream = stream;
		ReInitRounds();
	}

	
	[LineNumberTable(new byte[]
	{
		171,
		0,
		130,
		226,
		71,
		byte.MaxValue,
		7,
		74,
		226,
		56,
		129,
		103,
		103,
		103,
		103,
		103,
		130,
		108,
		108,
		199,
		191,
		1,
		107,
		103,
		103,
		133,
		107,
		103,
		103,
		146,
		202,
		107,
		103,
		103,
		146,
		202,
		107,
		103,
		167,
		144,
		107,
		117,
		159,
		3,
		103,
		103,
		103,
		111,
		114,
		103,
		130,
		159,
		6,
		159,
		3,
		103,
		99,
		164,
		103,
		143,
		169,
		103,
		114,
		183,
		102,
		111,
		114,
		98,
		139,
		124,
		133,
		129,
		109,
		109,
		99,
		131,
		108,
		247,
		75,
		226,
		55,
		97,
		99,
		120,
		116,
		102,
		165,
		134,
		100,
		108,
		152
	})]
	public virtual Token getNextToken()
	{
		Token token = null;
		int num = 0;
		Token token2;
		while (true)
		{
			try
			{
				curChar = input_stream.beginToken();
			}
			catch (System.Exception x)
			{
				if (ByteCodeHelper.MapException<java.lang.Exception>(x, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				break;
			}
			image = jjimage;
			image.setLength(0);
			jjimageLen = 0;
			while (true)
			{
				switch (curLexState)
				{
				case 0:
					jjmatchedKind = int.MaxValue;
					jjmatchedPos = 0;
					num = jjMoveStringLiteralDfa0_0();
					break;
				case 1:
					jjmatchedKind = int.MaxValue;
					jjmatchedPos = 0;
					num = jjMoveStringLiteralDfa0_1();
					if (jjmatchedPos == 0 && jjmatchedKind > 10)
					{
						jjmatchedKind = 10;
					}
					break;
				case 2:
					jjmatchedKind = int.MaxValue;
					jjmatchedPos = 0;
					num = jjMoveStringLiteralDfa0_2();
					if (jjmatchedPos == 0 && jjmatchedKind > 10)
					{
						jjmatchedKind = 10;
					}
					break;
				case 3:
					jjmatchedKind = int.MaxValue;
					jjmatchedPos = 0;
					num = jjMoveStringLiteralDfa0_3();
					break;
				}
				if (jjmatchedKind != int.MaxValue)
				{
					if (jjmatchedPos + 1 < num)
					{
						input_stream.backup(num - jjmatchedPos - 1);
					}
					if ((jjtoToken[jjmatchedKind >> 6] & (1L << jjmatchedKind)) != 0)
					{
						token2 = jjFillToken();
						token2.specialToken = token;
						TokenLexicalActions(token2);
						if (___003C_003EjjnewLexState[jjmatchedKind] != -1)
						{
							curLexState = ___003C_003EjjnewLexState[jjmatchedKind];
						}
						CommonTokenAction(token2);
						return token2;
					}
					if ((jjtoSkip[jjmatchedKind >> 6] & (1L << jjmatchedKind)) != 0)
					{
						break;
					}
					MoreLexicalActions();
					if (___003C_003EjjnewLexState[jjmatchedKind] != -1)
					{
						curLexState = ___003C_003EjjnewLexState[jjmatchedKind];
					}
					num = 0;
					jjmatchedKind = int.MaxValue;
					try
					{
						curChar = input_stream.readChar();
					}
					catch (IOException)
					{
						goto IL_02b4;
					}
					continue;
				}
				goto IL_02bd;
				IL_02bd:
				int num2 = input_stream.getEndLine();
				int num3 = input_stream.getEndColumn();
				string text = null;
				int num4 = 0;
				try
				{
					input_stream.readChar();
					input_stream.backup(1);
				}
				catch (IOException)
				{
					goto IL_02fd;
				}
				goto IL_0343;
				IL_02b4:
				
				goto IL_02bd;
				IL_0343:
				if (num4 == 0)
				{
					input_stream.backup(1);
					text = ((num > 1) ? input_stream.getImage() : "");
				}
				int eOFSeen = num4;
				int lexState = curLexState;
				int errorLine = num2;
				int errorColumn = num3;
				string errorAfter = text;
				int num5 = curChar;
				
				throw new TokenMgrException((byte)eOFSeen != 0, lexState, errorLine, errorColumn, errorAfter, num5, 0);
				IL_02fd:
				
				num4 = 1;
				text = ((num > 1) ? input_stream.getImage() : "");
				if (curChar == 10 || curChar == 13)
				{
					num2++;
					num3 = 0;
				}
				else
				{
					num3++;
				}
				goto IL_0343;
			}
			if ((jjtoSpecial[jjmatchedKind >> 6] & (1L << jjmatchedKind)) != 0)
			{
				token2 = jjFillToken();
				if (token == null)
				{
					token = token2;
				}
				else
				{
					token2.specialToken = token;
					Token token3 = token;
					Token token4 = token2;
					Token token5 = token3;
					token5.next = token4;
					token = token4;
				}
				SkipLexicalActions(token2);
			}
			else
			{
				SkipLexicalActions(null);
			}
			if (___003C_003EjjnewLexState[jjmatchedKind] != -1)
			{
				curLexState = ___003C_003EjjnewLexState[jjmatchedKind];
			}
		}
		
		jjmatchedKind = 0;
		jjmatchedPos = -1;
		token2 = jjFillToken();
		token2.specialToken = token;
		CommonTokenAction(token2);
		return token2;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	private int jjStopStringLiteralDfa_0(int pos, long active0, long active1, long active2)
	{
		switch (pos)
		{
		case 0:
			if ((active0 & -2048) != 0 || (active1 & 0xFFFu) != 0)
			{
				jjmatchedKind = 94;
				return 152;
			}
			if ((active1 & 0x8000000u) != 0)
			{
				return 153;
			}
			if ((active1 & 0x60000000000L) != 0)
			{
				return 2;
			}
			if ((active0 & 0x80u) != 0 || (active1 & long.MinValue) != 0 || (active2 & 0x100u) != 0)
			{
				return 67;
			}
			return -1;
		case 1:
			if ((active1 & 0x8000000u) != 0)
			{
				if (jjmatchedPos != 1)
				{
					jjmatchedKind = 90;
					jjmatchedPos = 1;
				}
				return -1;
			}
			if ((active0 & 0x401800000L) != 0 || (active1 & 8) != 0)
			{
				return 152;
			}
			if ((active0 & 0x80u) != 0)
			{
				return 69;
			}
			if ((active0 & -17205037056L) != 0 || (active1 & 0xFF7u) != 0)
			{
				if (jjmatchedPos != 1)
				{
					jjmatchedKind = 94;
					jjmatchedPos = 1;
				}
				return 152;
			}
			return -1;
		case 2:
			if ((active1 & 0x8000000u) != 0)
			{
				if (jjmatchedPos < 1)
				{
					jjmatchedKind = 90;
					jjmatchedPos = 1;
				}
				return -1;
			}
			if ((active0 & -2305848253377153024L) != 0 || (active1 & 0xFF7u) != 0)
			{
				if (jjmatchedPos != 2)
				{
					jjmatchedKind = 94;
					jjmatchedPos = 2;
				}
				return 152;
			}
			if ((active0 & 0x200004C100000000L) != 0)
			{
				return 152;
			}
			return -1;
		case 3:
			if ((active0 & 0x5100090206058000L) != 0 || (active1 & 0xF0u) != 0)
			{
				return 152;
			}
			if ((active0 & -8142522724989110272L) != 0 || (active1 & 0xF07u) != 0)
			{
				if (jjmatchedPos != 3)
				{
					jjmatchedKind = 94;
					jjmatchedPos = 3;
				}
				return 152;
			}
			return -1;
		case 4:
			if ((active0 & 0x6240000F01A4000L) != 0 || (active1 & 0x43u) != 0)
			{
				return 152;
			}
			if ((active0 & -8585001392406513664L) != 0 || (active1 & 0xF04u) != 0)
			{
				if (jjmatchedPos != 4)
				{
					jjmatchedKind = 94;
					jjmatchedPos = 4;
				}
				return 152;
			}
			return -1;
		case 5:
			if ((active0 & 0x44B821001001000L) != 0 || (active1 & 0x100u) != 0)
			{
				return 152;
			}
			if ((active0 & -8606255019833939968L) != 0 || (active1 & 0xE04u) != 0)
			{
				jjmatchedKind = 94;
				jjmatchedPos = 5;
				return 152;
			}
			return -1;
		case 6:
			if ((active0 & -8606307797604235264L) != 0 || (active1 & 0xC04u) != 0)
			{
				jjmatchedKind = 94;
				jjmatchedPos = 6;
				return 152;
			}
			if ((active0 & 0x300048402000L) != 0 || (active1 & 0x200u) != 0)
			{
				return 152;
			}
			return -1;
		case 7:
			if ((active0 & -9218868437225306112L) != 0 || (active1 & 0x404u) != 0)
			{
				return 152;
			}
			if ((active0 & 0x88040A800000000L) != 0 || (active1 & 0x800u) != 0)
			{
				jjmatchedKind = 94;
				jjmatchedPos = 7;
				return 152;
			}
			return -1;
		case 8:
			if ((active0 & 0x80002800000000L) != 0 || (active1 & 0x800u) != 0)
			{
				jjmatchedKind = 94;
				jjmatchedPos = 8;
				return 152;
			}
			if ((active0 & 0x800408000000000L) != 0)
			{
				return 152;
			}
			return -1;
		case 9:
			if ((active0 & 0x2800000000L) != 0 || (active1 & 0x800u) != 0)
			{
				return 152;
			}
			if ((active0 & 0x80000000000000L) != 0)
			{
				jjmatchedKind = 94;
				jjmatchedPos = 9;
				return 152;
			}
			return -1;
		case 10:
			if ((active0 & 0x80000000000000L) != 0)
			{
				jjmatchedKind = 94;
				jjmatchedPos = 10;
				return 152;
			}
			return -1;
		default:
			return -1;
		}
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		164, 175, 98, 107, 98, 105, 166, 124, 102, 141,
		174, 191, 162, 31, 112, 109, 141, 104, 232, 69,
		112, 101, 101, 99, 106, 133, 106, 127, 4, 141,
		100, 98, 205, 144, 101, 99, 142, 144, 103, 135,
		106, 111, 138, 101, 99, 140, 106, 106, 106, 108,
		106, 125, 109, 175, 109, 191, 3, 112, 101, 101,
		99, 106, 133, 115, 173, 112, 101, 101, 99, 105,
		133, 115, 172, 112, 101, 101, 99, 106, 133, 115,
		174, 112, 101, 101, 99, 105, 133, 112, 101, 101,
		99, 106, 133, 109, 175, 115, 173, 117, 168, 115,
		173, 115, 175, 115, 173, 115, 191, 4, 115, 173,
		109, 191, 4, 109, 191, 4, 109, 191, 4, 109,
		191, 4, 109, 191, 4, 109, 191, 4, 115, 191,
		4, 115, 191, 4, 115, 191, 4, 115, 173, 109,
		173, 115, 173, 115, 173, 115, 191, 4, 115, 191,
		4, 115, 191, 4, 115, 173, 117, 168, 115, 175,
		115, 173, 115, 191, 4, 115, 173, 106, 101, 101,
		99, 106, 133, 115, 191, 4, 115, 223, 4, 115,
		173, 112, 101, 101, 99, 106, 133, 115, 191, 4,
		115, 191, 4, 109, 175, 109, 101, 100, 98, 104,
		133, 109, 191, 4, 122, 167, 109, 191, 4, 112,
		101, 101, 99, 105, 133, 115, 207, 115, 173, 115,
		207, 123, 168, 115, 175, 115, 175, 115, 173, 115,
		175, 115, 175, 115, 175, 115, 175, 115, 175, 115,
		173, 115, 173, 112, 101, 101, 99, 106, 133, 115,
		175, 112, 101, 101, 99, 106, 133, 112, 101, 101,
		99, 106, 133, 115, 175, 115, 173, 106, 101, 101,
		99, 106, 133, 112, 101, 101, 99, 106, 133, 115,
		175, 112, 101, 101, 99, 106, 133, 115, 173, 112,
		101, 101, 99, 106, 133, 115, 175, 112, 101, 101,
		99, 106, 133, 112, 101, 101, 99, 106, 133, 109,
		175, 115, 175, 115, 175, 115, 175, 115, 175, 115,
		173, 115, 175, 115, 175, 115, 173, 112, 101, 101,
		99, 106, 133, 115, 175, 112, 101, 101, 99, 106,
		133, 115, 175, 123, 168, 112, 101, 101, 99, 109,
		133, 115, 178, 123, 168, 115, 175, 115, 181, 115,
		176, 109, 191, 7, 115, 175, 115, 181, 115, 176,
		115, 191, 7, 112, 101, 101, 99, 106, 133, 115,
		213, 112, 101, 101, 99, 104, 133, 115, 175, 115,
		181, 115, 181, 109, 176, 115, 191, 4, 112, 98,
		101, 99, 106, 130, 112, 210, 103, 101, 144, 177,
		191, 162, 31, 109, 106, 106, 126, 109, 175, 144,
		101, 99, 143, 109, 191, 4, 144, 101, 99, 143,
		109, 191, 4, 109, 175, 115, 175, 109, 175, 123,
		168, 112, 173, 109, 175, 115, 173, 109, 175, 115,
		175, 115, 173, 109, 191, 4, 109, 191, 4, 109,
		191, 4, 109, 191, 4, 115, 191, 4, 115, 191,
		4, 115, 191, 4, 115, 173, 112, 173, 109, 175,
		115, 173, 109, 191, 4, 115, 191, 4, 115, 191,
		4, 115, 191, 4, 115, 173, 109, 191, 4, 112,
		101, 101, 99, 106, 133, 112, 101, 101, 99, 106,
		133, 109, 191, 4, 115, 191, 4, 115, 223, 4,
		115, 173, 112, 101, 101, 99, 106, 133, 109, 191,
		4, 109, 191, 4, 115, 191, 4, 115, 191, 4,
		109, 191, 4, 100, 98, 126, 133, 103, 167, 109,
		175, 123, 168, 109, 175, 109, 175, 115, 175, 109,
		175, 109, 175, 115, 178, 109, 181, 109, 181, 109,
		181, 115, 181, 109, 181, 115, 191, 4, 115, 175,
		115, 175, 115, 173, 109, 181, 115, 191, 4, 109,
		181, 115, 191, 4, 112, 101, 101, 99, 106, 133,
		115, 175, 123, 168, 109, 181, 115, 191, 4, 109,
		181, 115, 181, 115, 175, 115, 181, 115, 176, 115,
		175, 115, 181, 115, 176, 115, 181, 109, 181, 115,
		191, 7, 115, 175, 115, 178, 112, 178, 112, 178,
		106, 210, 103, 165, 106, 102, 109, 112, 177, 223,
		79, 116, 205, 113, 101, 101, 99, 106, 133, 145,
		100, 130, 148, 101, 99, 207, 116, 191, 4, 113,
		101, 101, 99, 106, 133, 113, 101, 100, 98, 126,
		130, 117, 132, 148, 135, 136, 103, 103, 134, 101,
		103, 103, 109, 100, 98, 124
	})]
	private int jjMoveNfa_0(int startState, int curPos)
	{
		int num = 0;
		jjnewStateCnt = 152;
		int num2 = 1;
		jjstateSet[0] = startState;
		int num3 = int.MaxValue;
		while (true)
		{
			int num4 = jjround + 1;
			GeneratedJavaParserTokenManager generatedJavaParserTokenManager = this;
			int num5 = num4;
			generatedJavaParserTokenManager.jjround = num4;
			if (num5 == int.MaxValue)
			{
				ReInitRounds();
			}
			if (curChar < 64)
			{
				long num6 = 1L << curChar;
				do
				{
					int[] array = jjstateSet;
					num2 += -1;
					switch (array[num2])
					{
					case 153:
						if ((-17179878401L & num6) != 0)
						{
							jjCheckNAddStates(0, 3);
						}
						else if (curChar == 34 && num3 > 90)
						{
							num3 = 90;
						}
						break;
					case 54:
					case 152:
						if ((0x3FF00100FFFC1FFL & num6) != 0)
						{
							if (num3 > 94)
							{
								num3 = 94;
							}
							jjCheckNAddTwoStates(54, 60);
						}
						break;
					case 67:
						if (curChar == 42)
						{
							int[] array15 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num20 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array15[num20] = 69;
						}
						else if (curChar == 47)
						{
							if (num3 > 5)
							{
								num3 = 5;
							}
							jjCheckNAdd(68);
						}
						break;
					case 0:
						if ((0x3FF000000000000L & num6) != 0)
						{
							if (num3 > 77)
							{
								num3 = 77;
							}
							jjCheckNAddStates(4, 18);
						}
						else if ((0x100001200L & num6) != 0)
						{
							if (num3 > 1)
							{
								num3 = 1;
							}
						}
						else if (curChar == 47)
						{
							jjAddStates(19, 20);
						}
						else if (curChar == 36)
						{
							if (num3 > 94)
							{
								num3 = 94;
							}
							jjCheckNAddTwoStates(54, 60);
						}
						else if (curChar == 34)
						{
							jjCheckNAddStates(0, 3);
						}
						else if (curChar == 39)
						{
							jjAddStates(21, 23);
						}
						else if (curChar == 46)
						{
							int[] array2 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num7 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array2[num7] = 2;
						}
						if (curChar == 48)
						{
							jjAddStates(24, 31);
						}
						break;
					case 1:
						if (curChar == 46)
						{
							int[] array11 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num16 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array11[num16] = 2;
						}
						break;
					case 2:
						if ((0x3FF000000000000L & num6) != 0)
						{
							if (num3 > 82)
							{
								num3 = 82;
							}
							jjCheckNAddStates(32, 35);
						}
						break;
					case 3:
						if ((0x3FF000000000000L & num6) != 0)
						{
							jjCheckNAddTwoStates(3, 4);
						}
						break;
					case 4:
						if ((0x3FF000000000000L & num6) != 0)
						{
							if (num3 > 82)
							{
								num3 = 82;
							}
							jjCheckNAddTwoStates(5, 10);
						}
						break;
					case 6:
						if ((0x280000000000L & num6) != 0)
						{
							jjCheckNAdd(7);
						}
						break;
					case 7:
						if ((0x3FF000000000000L & num6) != 0)
						{
							if (num3 > 82)
							{
								num3 = 82;
							}
							jjCheckNAddStates(36, 38);
						}
						break;
					case 8:
						if ((0x3FF000000000000L & num6) != 0)
						{
							jjCheckNAddTwoStates(8, 9);
						}
						break;
					case 9:
						if ((0x3FF000000000000L & num6) != 0)
						{
							if (num3 > 82)
							{
								num3 = 82;
							}
							jjCheckNAddTwoStates(7, 10);
						}
						break;
					case 11:
						if ((0x3FF000000000000L & num6) != 0)
						{
							if (num3 > 82)
							{
								num3 = 82;
							}
							jjCheckNAddStates(39, 42);
						}
						break;
					case 12:
						if (curChar == 39)
						{
							jjAddStates(21, 23);
						}
						break;
					case 13:
						if ((-549755823105L & num6) != 0)
						{
							jjCheckNAdd(14);
						}
						break;
					case 14:
						if (curChar == 39 && num3 > 89)
						{
							num3 = 89;
						}
						break;
					case 16:
						if ((0x8400000000L & num6) != 0)
						{
							jjCheckNAdd(14);
						}
						break;
					case 17:
						if ((0xFF000000000000L & num6) != 0)
						{
							jjCheckNAddTwoStates(18, 14);
						}
						break;
					case 18:
						if ((0xFF000000000000L & num6) != 0)
						{
							jjCheckNAdd(14);
						}
						break;
					case 19:
						if ((0xF000000000000L & num6) != 0)
						{
							int[] array8 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num13 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array8[num13] = 20;
						}
						break;
					case 20:
						if ((0xFF000000000000L & num6) != 0)
						{
							jjCheckNAdd(18);
						}
						break;
					case 22:
						if (curChar == 53)
						{
							int[] array5 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num10 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array5[num10] = 23;
						}
						break;
					case 24:
						if (curChar == 53)
						{
							int[] array3 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num8 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array3[num8] = 25;
						}
						break;
					case 26:
						if (curChar == 48)
						{
							int[] array27 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num32 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array27[num32] = 24;
						}
						break;
					case 27:
						if (curChar == 48)
						{
							int[] array24 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num29 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array24[num29] = 26;
						}
						break;
					case 30:
						if (curChar == 48)
						{
							int[] array23 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num28 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array23[num28] = 22;
						}
						break;
					case 31:
						if (curChar == 48)
						{
							int[] array22 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num27 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array22[num27] = 30;
						}
						break;
					case 34:
						if ((0x3FF000000000000L & num6) != 0)
						{
							int[] array20 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num25 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array20[num25] = 35;
						}
						break;
					case 35:
						if ((0x3FF000000000000L & num6) != 0)
						{
							int[] array18 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num23 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array18[num23] = 36;
						}
						break;
					case 36:
						if ((0x3FF000000000000L & num6) != 0)
						{
							int[] array16 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num21 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array16[num21] = 37;
						}
						break;
					case 37:
						if ((0x3FF000000000000L & num6) != 0)
						{
							jjCheckNAdd(14);
						}
						break;
					case 38:
						if (curChar == 34)
						{
							jjCheckNAddStates(0, 3);
						}
						break;
					case 39:
						if ((-17179878401L & num6) != 0)
						{
							jjCheckNAddStates(0, 3);
						}
						break;
					case 41:
						if ((0x8400000000L & num6) != 0)
						{
							jjCheckNAddStates(0, 3);
						}
						break;
					case 43:
						if ((0x3FF000000000000L & num6) != 0)
						{
							int[] array13 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num18 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array13[num18] = 44;
						}
						break;
					case 44:
						if ((0x3FF000000000000L & num6) != 0)
						{
							int[] array12 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num17 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array12[num17] = 45;
						}
						break;
					case 45:
						if ((0x3FF000000000000L & num6) != 0)
						{
							int[] array10 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num15 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array10[num15] = 46;
						}
						break;
					case 46:
						if ((0x3FF000000000000L & num6) != 0)
						{
							jjCheckNAddStates(0, 3);
						}
						break;
					case 48:
						if (curChar == 34 && num3 > 90)
						{
							num3 = 90;
						}
						break;
					case 49:
						if ((0xFF000000000000L & num6) != 0)
						{
							jjCheckNAddStates(43, 47);
						}
						break;
					case 50:
						if ((0xFF000000000000L & num6) != 0)
						{
							jjCheckNAddStates(0, 3);
						}
						break;
					case 51:
						if ((0xF000000000000L & num6) != 0)
						{
							int[] array6 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num11 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array6[num11] = 52;
						}
						break;
					case 52:
						if ((0xFF000000000000L & num6) != 0)
						{
							jjCheckNAdd(50);
						}
						break;
					case 53:
						if (curChar == 36)
						{
							if (num3 > 94)
							{
								num3 = 94;
							}
							jjCheckNAddTwoStates(54, 60);
						}
						break;
					case 56:
						if ((0x3FF000000000000L & num6) != 0)
						{
							int[] array26 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num31 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array26[num31] = 57;
						}
						break;
					case 57:
						if ((0x3FF000000000000L & num6) != 0)
						{
							int[] array25 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num30 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array25[num30] = 58;
						}
						break;
					case 58:
					case 64:
						if ((0x3FF000000000000L & num6) != 0)
						{
							jjCheckNAdd(59);
						}
						break;
					case 59:
						if ((0x3FF000000000000L & num6) != 0)
						{
							if (num3 > 94)
							{
								num3 = 94;
							}
							jjCheckNAddTwoStates(54, 60);
						}
						break;
					case 62:
						if ((0x3FF000000000000L & num6) != 0)
						{
							int[] array21 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num26 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array21[num26] = 63;
						}
						break;
					case 63:
						if ((0x3FF000000000000L & num6) != 0)
						{
							int[] array19 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num24 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array19[num24] = 64;
						}
						break;
					case 66:
						if (curChar == 47)
						{
							jjAddStates(19, 20);
						}
						break;
					case 68:
						if ((-9217 & num6) != 0)
						{
							if (num3 > 5)
							{
								num3 = 5;
							}
							jjCheckNAdd(68);
						}
						break;
					case 69:
						if (curChar == 42)
						{
							int[] array17 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num22 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array17[num22] = 70;
						}
						break;
					case 70:
						if ((-140737488355329L & num6) != 0 && num3 > 6)
						{
							num3 = 6;
						}
						break;
					case 71:
						if (curChar == 42)
						{
							int[] array14 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num19 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array14[num19] = 69;
						}
						break;
					case 72:
						if ((0x3FF000000000000L & num6) != 0)
						{
							if (num3 > 77)
							{
								num3 = 77;
							}
							jjCheckNAddStates(4, 18);
						}
						break;
					case 73:
						if ((0x3FF000000000000L & num6) != 0)
						{
							jjCheckNAddTwoStates(73, 74);
						}
						break;
					case 74:
					case 110:
						if ((0x3FF000000000000L & num6) != 0)
						{
							jjCheckNAdd(75);
						}
						break;
					case 76:
						if ((0x3FF000000000000L & num6) != 0)
						{
							jjCheckNAddTwoStates(76, 77);
						}
						break;
					case 77:
					case 121:
						if ((0x3FF000000000000L & num6) != 0 && num3 > 77)
						{
							num3 = 77;
						}
						break;
					case 78:
						if ((0x3FF000000000000L & num6) != 0)
						{
							jjCheckNAddTwoStates(78, 79);
						}
						break;
					case 79:
						if ((0x3FF000000000000L & num6) != 0)
						{
							jjCheckNAddTwoStates(80, 10);
						}
						break;
					case 81:
						if ((0x280000000000L & num6) != 0)
						{
							jjCheckNAdd(82);
						}
						break;
					case 82:
						if ((0x3FF000000000000L & num6) != 0)
						{
							jjCheckNAddStates(48, 50);
						}
						break;
					case 83:
						if ((0x3FF000000000000L & num6) != 0)
						{
							jjCheckNAddTwoStates(83, 84);
						}
						break;
					case 84:
						if ((0x3FF000000000000L & num6) != 0)
						{
							jjCheckNAddTwoStates(82, 10);
						}
						break;
					case 85:
						if ((0x3FF000000000000L & num6) != 0)
						{
							jjCheckNAddStates(51, 54);
						}
						break;
					case 86:
						if ((0x3FF000000000000L & num6) != 0)
						{
							jjCheckNAddTwoStates(86, 87);
						}
						break;
					case 87:
						if ((0x3FF000000000000L & num6) != 0)
						{
							jjCheckNAdd(88);
						}
						break;
					case 89:
						if ((0x280000000000L & num6) != 0)
						{
							jjCheckNAdd(90);
						}
						break;
					case 90:
						if ((0x3FF000000000000L & num6) != 0)
						{
							if (num3 > 82)
							{
								num3 = 82;
							}
							jjCheckNAddStates(55, 57);
						}
						break;
					case 91:
						if ((0x3FF000000000000L & num6) != 0)
						{
							jjCheckNAddTwoStates(91, 92);
						}
						break;
					case 92:
						if ((0x3FF000000000000L & num6) != 0)
						{
							if (num3 > 82)
							{
								num3 = 82;
							}
							jjCheckNAddTwoStates(90, 10);
						}
						break;
					case 93:
						if ((0x3FF000000000000L & num6) != 0)
						{
							if (num3 > 82)
							{
								num3 = 82;
							}
							jjCheckNAddStates(58, 61);
						}
						break;
					case 94:
						if ((0x3FF000000000000L & num6) != 0)
						{
							jjCheckNAddTwoStates(94, 95);
						}
						break;
					case 95:
						if ((0x3FF000000000000L & num6) != 0)
						{
							jjCheckNAdd(96);
						}
						break;
					case 96:
						if (curChar == 46)
						{
							if (num3 > 82)
							{
								num3 = 82;
							}
							jjCheckNAddStates(62, 64);
						}
						break;
					case 97:
						if ((0x3FF000000000000L & num6) != 0)
						{
							if (num3 > 82)
							{
								num3 = 82;
							}
							jjCheckNAddStates(65, 68);
						}
						break;
					case 98:
						if ((0x3FF000000000000L & num6) != 0)
						{
							jjCheckNAddTwoStates(98, 99);
						}
						break;
					case 99:
						if ((0x3FF000000000000L & num6) != 0)
						{
							if (num3 > 82)
							{
								num3 = 82;
							}
							jjCheckNAddTwoStates(100, 10);
						}
						break;
					case 101:
						if ((0x280000000000L & num6) != 0)
						{
							jjCheckNAdd(102);
						}
						break;
					case 102:
						if ((0x3FF000000000000L & num6) != 0)
						{
							if (num3 > 82)
							{
								num3 = 82;
							}
							jjCheckNAddStates(69, 71);
						}
						break;
					case 103:
						if ((0x3FF000000000000L & num6) != 0)
						{
							jjCheckNAddTwoStates(103, 104);
						}
						break;
					case 104:
						if ((0x3FF000000000000L & num6) != 0)
						{
							if (num3 > 82)
							{
								num3 = 82;
							}
							jjCheckNAddTwoStates(102, 10);
						}
						break;
					case 105:
						if ((0x3FF000000000000L & num6) != 0)
						{
							if (num3 > 82)
							{
								num3 = 82;
							}
							jjCheckNAddStates(72, 75);
						}
						break;
					case 106:
						if (curChar == 48)
						{
							jjAddStates(24, 31);
						}
						break;
					case 108:
						if ((0x3FF000000000000L & num6) != 0)
						{
							jjCheckNAddStates(76, 78);
						}
						break;
					case 109:
						if ((0x3FF000000000000L & num6) != 0)
						{
							jjCheckNAddTwoStates(109, 110);
						}
						break;
					case 111:
						if ((0xFF000000000000L & num6) != 0)
						{
							jjCheckNAddStates(79, 81);
						}
						break;
					case 112:
						if ((0xFF000000000000L & num6) != 0)
						{
							jjCheckNAddTwoStates(112, 113);
						}
						break;
					case 113:
						if ((0xFF000000000000L & num6) != 0)
						{
							jjCheckNAdd(75);
						}
						break;
					case 115:
						if ((0x3000000000000L & num6) != 0)
						{
							jjCheckNAddStates(82, 84);
						}
						break;
					case 116:
						if ((0x3000000000000L & num6) != 0)
						{
							jjCheckNAddTwoStates(116, 117);
						}
						break;
					case 117:
						if ((0x3000000000000L & num6) != 0)
						{
							jjCheckNAdd(75);
						}
						break;
					case 119:
						if ((0x3FF000000000000L & num6) != 0)
						{
							if (num3 > 77)
							{
								num3 = 77;
							}
							jjCheckNAddTwoStates(120, 121);
						}
						break;
					case 120:
						if ((0x3FF000000000000L & num6) != 0)
						{
							jjCheckNAddTwoStates(120, 121);
						}
						break;
					case 122:
						if ((0xFF000000000000L & num6) != 0)
						{
							if (num3 > 77)
							{
								num3 = 77;
							}
							jjCheckNAddTwoStates(123, 124);
						}
						break;
					case 123:
						if ((0xFF000000000000L & num6) != 0)
						{
							jjCheckNAddTwoStates(123, 124);
						}
						break;
					case 124:
						if ((0xFF000000000000L & num6) != 0 && num3 > 77)
						{
							num3 = 77;
						}
						break;
					case 126:
						if ((0x3000000000000L & num6) != 0)
						{
							if (num3 > 77)
							{
								num3 = 77;
							}
							jjCheckNAddTwoStates(127, 128);
						}
						break;
					case 127:
						if ((0x3000000000000L & num6) != 0)
						{
							jjCheckNAddTwoStates(127, 128);
						}
						break;
					case 128:
						if ((0x3000000000000L & num6) != 0 && num3 > 77)
						{
							num3 = 77;
						}
						break;
					case 130:
						if ((0x3FF000000000000L & num6) != 0)
						{
							jjCheckNAddStates(85, 87);
						}
						break;
					case 131:
						if ((0x3FF000000000000L & num6) != 0)
						{
							jjCheckNAddTwoStates(131, 132);
						}
						break;
					case 132:
						if ((0x3FF000000000000L & num6) != 0)
						{
							jjCheckNAdd(133);
						}
						break;
					case 133:
						if (curChar == 46)
						{
							int[] array9 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num14 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array9[num14] = 134;
						}
						break;
					case 134:
						if ((0x3FF000000000000L & num6) != 0)
						{
							jjCheckNAddStates(88, 90);
						}
						break;
					case 135:
						if ((0x3FF000000000000L & num6) != 0)
						{
							jjCheckNAddTwoStates(135, 136);
						}
						break;
					case 136:
						if ((0x3FF000000000000L & num6) != 0)
						{
							jjCheckNAdd(137);
						}
						break;
					case 138:
						if ((0x280000000000L & num6) != 0)
						{
							int[] array7 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num12 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array7[num12] = 139;
						}
						break;
					case 139:
						if ((0x3FF000000000000L & num6) != 0)
						{
							if (num3 > 82)
							{
								num3 = 82;
							}
							jjCheckNAddStates(91, 93);
						}
						break;
					case 140:
						if ((0x3FF000000000000L & num6) != 0)
						{
							jjCheckNAddTwoStates(140, 141);
						}
						break;
					case 141:
					case 151:
						if ((0x3FF000000000000L & num6) != 0)
						{
							if (num3 > 82)
							{
								num3 = 82;
							}
							jjCheckNAdd(10);
						}
						break;
					case 143:
						if ((0x3FF000000000000L & num6) != 0)
						{
							jjCheckNAddStates(94, 97);
						}
						break;
					case 144:
						if ((0x3FF000000000000L & num6) != 0)
						{
							jjCheckNAddTwoStates(144, 145);
						}
						break;
					case 145:
						if ((0x3FF000000000000L & num6) != 0)
						{
							jjCheckNAddTwoStates(146, 147);
						}
						break;
					case 146:
						if (curChar == 46)
						{
							jjCheckNAdd(147);
						}
						break;
					case 148:
						if ((0x280000000000L & num6) != 0)
						{
							int[] array4 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num9 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array4[num9] = 149;
						}
						break;
					case 149:
						if ((0x3FF000000000000L & num6) != 0)
						{
							if (num3 > 82)
							{
								num3 = 82;
							}
							jjCheckNAddStates(98, 100);
						}
						break;
					case 150:
						if ((0x3FF000000000000L & num6) != 0)
						{
							jjCheckNAddTwoStates(150, 151);
						}
						break;
					}
				}
				while (num2 != num);
			}
			else if (curChar < 128)
			{
				long num6 = 1L << (curChar & 0x3F);
				do
				{
					int[] array28 = jjstateSet;
					num2 += -1;
					switch (array28[num2])
					{
					case 153:
						if ((-268435457 & num6) != 0)
						{
							jjCheckNAddStates(0, 3);
						}
						else if (curChar == 92)
						{
							int[] array54 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num58 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array54[num58] = 42;
						}
						if (curChar == 92)
						{
							jjAddStates(101, 103);
						}
						break;
					case 152:
						if ((-8646911290859585538L & num6) != 0)
						{
							if (num3 > 94)
							{
								num3 = 94;
							}
							jjCheckNAddTwoStates(54, 60);
						}
						else if (curChar == 92)
						{
							int[] array37 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num41 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array37[num41] = 55;
						}
						break;
					case 0:
						if ((0x7FFFFFE87FFFFFEL & num6) != 0)
						{
							if (num3 > 94)
							{
								num3 = 94;
							}
							jjCheckNAddTwoStates(54, 60);
						}
						else if (curChar == 92)
						{
							int[] array47 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num51 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array47[num51] = 61;
						}
						break;
					case 3:
						if (curChar == 95)
						{
							jjAddStates(104, 105);
						}
						break;
					case 5:
						if ((0x2000000020L & num6) != 0)
						{
							jjAddStates(106, 107);
						}
						break;
					case 8:
						if (curChar == 95)
						{
							jjAddStates(108, 109);
						}
						break;
					case 10:
						if ((0x5000000050L & num6) != 0 && num3 > 82)
						{
							num3 = 82;
						}
						break;
					case 13:
						if ((-268435457 & num6) != 0)
						{
							jjCheckNAdd(14);
						}
						break;
					case 15:
						if (curChar == 92)
						{
							jjCheckNAddStates(110, 112);
						}
						break;
					case 16:
						if ((0x14404410000000L & num6) != 0)
						{
							jjCheckNAdd(14);
						}
						break;
					case 21:
						if (curChar == 92)
						{
							jjAddStates(113, 114);
						}
						break;
					case 23:
						if ((0x800000008L & num6) != 0)
						{
							jjCheckNAddTwoStates(16, 29);
						}
						break;
					case 25:
						if ((0x800000008L & num6) != 0)
						{
							jjCheckNAdd(14);
						}
						break;
					case 28:
						if (curChar == 117)
						{
							int[] array56 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num60 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array56[num60] = 27;
						}
						break;
					case 29:
						if (curChar == 92)
						{
							int[] array53 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num57 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array53[num57] = 28;
						}
						break;
					case 32:
						if (curChar == 117)
						{
							int[] array51 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num55 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array51[num55] = 31;
						}
						break;
					case 33:
						if (curChar == 117)
						{
							int[] array50 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num54 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array50[num54] = 34;
						}
						break;
					case 34:
						if ((0x7E0000007EL & num6) != 0)
						{
							int[] array48 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num52 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array48[num52] = 35;
						}
						break;
					case 35:
						if ((0x7E0000007EL & num6) != 0)
						{
							int[] array45 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num49 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array45[num49] = 36;
						}
						break;
					case 36:
						if ((0x7E0000007EL & num6) != 0)
						{
							int[] array41 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num45 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array41[num45] = 37;
						}
						break;
					case 37:
						if ((0x7E0000007EL & num6) != 0)
						{
							jjCheckNAdd(14);
						}
						break;
					case 39:
						if ((-268435457 & num6) != 0)
						{
							jjCheckNAddStates(0, 3);
						}
						break;
					case 40:
						if (curChar == 92)
						{
							jjAddStates(101, 103);
						}
						break;
					case 41:
						if ((0x14404410000000L & num6) != 0)
						{
							jjCheckNAddStates(0, 3);
						}
						break;
					case 42:
						if (curChar == 117)
						{
							int[] array32 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num36 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array32[num36] = 43;
						}
						break;
					case 43:
						if ((0x7E0000007EL & num6) != 0)
						{
							int[] array29 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num33 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array29[num33] = 44;
						}
						break;
					case 44:
						if ((0x7E0000007EL & num6) != 0)
						{
							int[] array57 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num61 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array57[num61] = 45;
						}
						break;
					case 45:
						if ((0x7E0000007EL & num6) != 0)
						{
							int[] array55 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num59 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array55[num59] = 46;
						}
						break;
					case 46:
						if ((0x7E0000007EL & num6) != 0)
						{
							jjCheckNAddStates(0, 3);
						}
						break;
					case 47:
						if (curChar == 92)
						{
							int[] array52 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num56 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array52[num56] = 42;
						}
						break;
					case 53:
						if ((0x7FFFFFE87FFFFFEL & num6) != 0)
						{
							if (num3 > 94)
							{
								num3 = 94;
							}
							jjCheckNAddTwoStates(54, 60);
						}
						break;
					case 54:
						if ((-8646911290859585538L & num6) != 0)
						{
							if (num3 > 94)
							{
								num3 = 94;
							}
							jjCheckNAddTwoStates(54, 60);
						}
						break;
					case 55:
						if (curChar == 117)
						{
							int[] array46 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num50 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array46[num50] = 56;
						}
						break;
					case 56:
						if ((0x7E0000007EL & num6) != 0)
						{
							int[] array43 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num47 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array43[num47] = 57;
						}
						break;
					case 57:
						if ((0x7E0000007EL & num6) != 0)
						{
							int[] array40 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num44 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array40[num44] = 58;
						}
						break;
					case 58:
					case 64:
						if ((0x7E0000007EL & num6) != 0)
						{
							jjCheckNAdd(59);
						}
						break;
					case 59:
						if ((0x7E0000007EL & num6) != 0)
						{
							if (num3 > 94)
							{
								num3 = 94;
							}
							jjCheckNAddTwoStates(54, 60);
						}
						break;
					case 60:
						if (curChar == 92)
						{
							int[] array38 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num42 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array38[num42] = 55;
						}
						break;
					case 61:
						if (curChar == 117)
						{
							int[] array36 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num40 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array36[num40] = 62;
						}
						break;
					case 62:
						if ((0x7E0000007EL & num6) != 0)
						{
							int[] array35 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num39 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array35[num39] = 63;
						}
						break;
					case 63:
						if ((0x7E0000007EL & num6) != 0)
						{
							int[] array34 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num38 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array34[num38] = 64;
						}
						break;
					case 65:
						if (curChar == 92)
						{
							int[] array33 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num37 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array33[num37] = 61;
						}
						break;
					case 68:
					{
						if (num3 > 5)
						{
							num3 = 5;
						}
						int[] array30 = jjstateSet;
						num4 = jjnewStateCnt;
						generatedJavaParserTokenManager = this;
						int num34 = num4;
						generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
						array30[num34] = 68;
						break;
					}
					case 70:
						if (num3 > 6)
						{
							num3 = 6;
						}
						break;
					case 73:
						if (curChar == 95)
						{
							jjAddStates(115, 116);
						}
						break;
					case 75:
						if ((0x100000001000L & num6) != 0 && num3 > 76)
						{
							num3 = 76;
						}
						break;
					case 76:
						if (curChar == 95)
						{
							jjAddStates(117, 118);
						}
						break;
					case 78:
						if (curChar == 95)
						{
							jjAddStates(119, 120);
						}
						break;
					case 80:
						if ((0x2000000020L & num6) != 0)
						{
							jjAddStates(121, 122);
						}
						break;
					case 83:
						if (curChar == 95)
						{
							jjAddStates(123, 124);
						}
						break;
					case 86:
						if (curChar == 95)
						{
							jjAddStates(125, 126);
						}
						break;
					case 88:
						if ((0x2000000020L & num6) != 0)
						{
							jjAddStates(127, 128);
						}
						break;
					case 91:
						if (curChar == 95)
						{
							jjAddStates(129, 130);
						}
						break;
					case 94:
						if (curChar == 95)
						{
							jjAddStates(131, 132);
						}
						break;
					case 98:
						if (curChar == 95)
						{
							jjAddStates(133, 134);
						}
						break;
					case 100:
						if ((0x2000000020L & num6) != 0)
						{
							jjAddStates(135, 136);
						}
						break;
					case 103:
						if (curChar == 95)
						{
							jjAddStates(137, 138);
						}
						break;
					case 107:
						if ((0x100000001000000L & num6) != 0)
						{
							int[] array49 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num53 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array49[num53] = 108;
						}
						break;
					case 108:
						if ((0x7E0000007EL & num6) != 0)
						{
							jjCheckNAddStates(76, 78);
						}
						break;
					case 109:
						if ((0x7E8000007EL & num6) != 0)
						{
							jjCheckNAddTwoStates(109, 110);
						}
						break;
					case 110:
						if ((0x7E0000007EL & num6) != 0)
						{
							jjCheckNAdd(75);
						}
						break;
					case 112:
						if (curChar == 95)
						{
							jjAddStates(139, 140);
						}
						break;
					case 114:
						if ((0x400000004L & num6) != 0)
						{
							int[] array44 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num48 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array44[num48] = 115;
						}
						break;
					case 116:
						if (curChar == 95)
						{
							jjAddStates(141, 142);
						}
						break;
					case 118:
						if ((0x100000001000000L & num6) != 0)
						{
							int[] array42 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num46 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array42[num46] = 119;
						}
						break;
					case 119:
						if ((0x7E0000007EL & num6) != 0)
						{
							if (num3 > 77)
							{
								num3 = 77;
							}
							jjCheckNAddTwoStates(120, 121);
						}
						break;
					case 120:
						if ((0x7E8000007EL & num6) != 0)
						{
							jjCheckNAddTwoStates(120, 121);
						}
						break;
					case 121:
						if ((0x7E0000007EL & num6) != 0 && num3 > 77)
						{
							num3 = 77;
						}
						break;
					case 123:
						if (curChar == 95)
						{
							jjAddStates(143, 144);
						}
						break;
					case 125:
						if ((0x400000004L & num6) != 0)
						{
							int[] array39 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num43 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array39[num43] = 126;
						}
						break;
					case 127:
						if (curChar == 95)
						{
							jjAddStates(145, 146);
						}
						break;
					case 129:
						if ((0x100000001000000L & num6) != 0)
						{
							jjCheckNAddTwoStates(130, 133);
						}
						break;
					case 130:
						if ((0x7E0000007EL & num6) != 0)
						{
							jjCheckNAddStates(85, 87);
						}
						break;
					case 131:
						if ((0x7E8000007EL & num6) != 0)
						{
							jjCheckNAddTwoStates(131, 132);
						}
						break;
					case 132:
						if ((0x7E0000007EL & num6) != 0)
						{
							jjCheckNAdd(133);
						}
						break;
					case 134:
						if ((0x7E0000007EL & num6) != 0)
						{
							jjCheckNAddStates(88, 90);
						}
						break;
					case 135:
						if ((0x7E8000007EL & num6) != 0)
						{
							jjCheckNAddTwoStates(135, 136);
						}
						break;
					case 136:
						if ((0x7E0000007EL & num6) != 0)
						{
							jjCheckNAdd(137);
						}
						break;
					case 137:
						if ((0x1000000010000L & num6) != 0)
						{
							jjAddStates(147, 148);
						}
						break;
					case 140:
						if (curChar == 95)
						{
							jjAddStates(149, 150);
						}
						break;
					case 142:
						if ((0x100000001000000L & num6) != 0)
						{
							int[] array31 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num35 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array31[num35] = 143;
						}
						break;
					case 143:
						if ((0x7E0000007EL & num6) != 0)
						{
							jjCheckNAddStates(94, 97);
						}
						break;
					case 144:
						if ((0x7E8000007EL & num6) != 0)
						{
							jjCheckNAddTwoStates(144, 145);
						}
						break;
					case 145:
						if ((0x7E0000007EL & num6) != 0)
						{
							jjCheckNAddTwoStates(146, 147);
						}
						break;
					case 147:
						if ((0x1000000010000L & num6) != 0)
						{
							jjAddStates(151, 152);
						}
						break;
					case 150:
						if (curChar == 95)
						{
							jjAddStates(153, 154);
						}
						break;
					}
				}
				while (num2 != num);
			}
			else
			{
				int num62 = curChar >> 8;
				int num63 = num62 >> 6;
				long num64 = 1L << (num62 & 0x3F);
				int num65 = (curChar & 0xFF) >> 6;
				long num66 = 1L << (curChar & 0x3F);
				do
				{
					int[] array58 = jjstateSet;
					num2 += -1;
					switch (array58[num2])
					{
					case 39:
					case 153:
						if (jjCanMove_1(num62, num63, num65, num64, num66))
						{
							jjCheckNAddStates(0, 3);
						}
						break;
					case 54:
					case 152:
						if (jjCanMove_3(num62, num63, num65, num64, num66))
						{
							if (num3 > 94)
							{
								num3 = 94;
							}
							jjCheckNAddTwoStates(54, 60);
						}
						break;
					case 0:
						if (jjCanMove_0(num62, num63, num65, num64, num66) && num3 > 1)
						{
							num3 = 1;
						}
						if (jjCanMove_2(num62, num63, num65, num64, num66))
						{
							if (num3 > 94)
							{
								num3 = 94;
							}
							jjCheckNAddTwoStates(54, 60);
						}
						break;
					case 13:
						if (jjCanMove_1(num62, num63, num65, num64, num66))
						{
							int[] array59 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num67 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array59[num67] = 14;
						}
						break;
					case 53:
						if (jjCanMove_2(num62, num63, num65, num64, num66))
						{
							if (num3 > 94)
							{
								num3 = 94;
							}
							jjCheckNAddTwoStates(54, 60);
						}
						break;
					case 68:
						if (jjCanMove_1(num62, num63, num65, num64, num66))
						{
							if (num3 > 5)
							{
								num3 = 5;
							}
							int[] array60 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num68 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array60[num68] = 68;
						}
						break;
					case 70:
						if (jjCanMove_1(num62, num63, num65, num64, num66) && num3 > 6)
						{
							num3 = 6;
						}
						break;
					default:
						if (num63 != 0 && num64 != 0 && num65 != 0 && num66 != 0)
						{
						}
						break;
					}
				}
				while (num2 != num);
			}
			if (num3 != int.MaxValue)
			{
				jjmatchedKind = num3;
				jjmatchedPos = curPos;
				num3 = int.MaxValue;
			}
			curPos++;
			num2 = jjnewStateCnt;
			jjnewStateCnt = num;
			num = 152 - jjnewStateCnt;
			if (num2 == num)
			{
				return curPos;
			}
			try
			{
				curChar = input_stream.readChar();
			}
			catch (IOException)
			{
				break;
			}
		}
		
		return curPos;
	}

	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	private int jjStopAtPos(int pos, int kind)
	{
		jjmatchedKind = kind;
		jjmatchedPos = pos;
		return pos + 1;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		161, 22, 220, 226, 61, 97, 107, 130, 191, 161,
		128, 107, 169, 148, 114, 170, 111, 171, 114, 170,
		114, 170, 151, 114, 170, 137, 107, 135, 148, 111,
		106, 111, 106, 111, 106, 111, 106, 105, 109, 105,
		109, 108, 109, 108, 109, 108, 109, 108, 109, 108,
		109, 111, 173, 111, 106, 140, 107, 135, 148, 151,
		148, 151, 114, 175, 151, 149, 148, 151, 151, 140,
		104, 137, 104, 111, 155, 145, 155, 152, 151, 151,
		151, 152, 151, 111, 234, 69
	})]
	private int jjMoveStringLiteralDfa1_0(long active0, long active1, long active2)
	{
		try
		{
			curChar = input_stream.readChar();
		}
		catch (IOException)
		{
			goto IL_0019;
		}
		switch (curChar)
		{
		case 10:
			if ((active0 & 4) != 0)
			{
				return jjStopAtPos(1, 2);
			}
			break;
		case 34:
			return jjMoveStringLiteralDfa2_0(active0, 0L, active1, 134217728L, active2, 0L);
		case 38:
			if ((active1 & 0x100000000000000L) != 0)
			{
				return jjStopAtPos(1, 120);
			}
			break;
		case 42:
			if ((active0 & 0x80u) != 0)
			{
				return jjStartNfaWithStates_0(1, 7, 69);
			}
			break;
		case 43:
			if ((active1 & 0x400000000000000L) != 0)
			{
				return jjStopAtPos(1, 122);
			}
			break;
		case 45:
			if ((active1 & 0x800000000000000L) != 0)
			{
				return jjStopAtPos(1, 123);
			}
			break;
		case 46:
			return jjMoveStringLiteralDfa2_0(active0, 0L, active1, 4398046511104L, active2, 0L);
		case 58:
			if ((active1 & 0x100000000000L) != 0)
			{
				return jjStopAtPos(1, 108);
			}
			break;
		case 60:
			if ((active2 & 0x10u) != 0)
			{
				jjmatchedKind = 132;
				jjmatchedPos = 1;
			}
			return jjMoveStringLiteralDfa2_0(active0, 0L, active1, 0L, active2, 8192L);
		case 61:
			if ((active1 & 0x10000000000000L) != 0)
			{
				return jjStopAtPos(1, 116);
			}
			if ((active1 & 0x20000000000000L) != 0)
			{
				return jjStopAtPos(1, 117);
			}
			if ((active1 & 0x40000000000000L) != 0)
			{
				return jjStopAtPos(1, 118);
			}
			if ((active1 & 0x80000000000000L) != 0)
			{
				return jjStopAtPos(1, 119);
			}
			if ((active2 & 0x20u) != 0)
			{
				return jjStopAtPos(1, 133);
			}
			if ((active2 & 0x40u) != 0)
			{
				return jjStopAtPos(1, 134);
			}
			if ((active2 & 0x80u) != 0)
			{
				return jjStopAtPos(1, 135);
			}
			if ((active2 & 0x100u) != 0)
			{
				return jjStopAtPos(1, 136);
			}
			if ((active2 & 0x200u) != 0)
			{
				return jjStopAtPos(1, 137);
			}
			if ((active2 & 0x400u) != 0)
			{
				return jjStopAtPos(1, 138);
			}
			if ((active2 & 0x800u) != 0)
			{
				return jjStopAtPos(1, 139);
			}
			if ((active2 & 0x1000u) != 0)
			{
				return jjStopAtPos(1, 140);
			}
			break;
		case 62:
			if ((active1 & 0x8000000000000L) != 0)
			{
				return jjStopAtPos(1, 115);
			}
			if ((active2 & 0x20000u) != 0)
			{
				jjmatchedKind = 145;
				jjmatchedPos = 1;
			}
			return jjMoveStringLiteralDfa2_0(active0, 0L, active1, 0L, active2, 114688L);
		case 97:
			return jjMoveStringLiteralDfa2_0(active0, 19791477932032L, active1, 0L, active2, 0L);
		case 98:
			return jjMoveStringLiteralDfa2_0(active0, 2048L, active1, 0L, active2, 0L);
		case 101:
			return jjMoveStringLiteralDfa2_0(active0, 848822980837376L, active1, 4L, active2, 0L);
		case 102:
			if ((active0 & 0x400000000L) != 0)
			{
				return jjStartNfaWithStates_0(1, 34, 152);
			}
			break;
		case 104:
			return jjMoveStringLiteralDfa2_0(active0, 505529058172600320L, active1, 1L, active2, 0L);
		case 105:
			return jjMoveStringLiteralDfa2_0(active0, 1610612736L, active1, 18L, active2, 0L);
		case 108:
			return jjMoveStringLiteralDfa2_0(active0, 2181562368L, active1, 0L, active2, 0L);
		case 109:
			return jjMoveStringLiteralDfa2_0(active0, 103079215104L, active1, 0L, active2, 0L);
		case 110:
			return jjMoveStringLiteralDfa2_0(active0, 962139783168L, active1, 0L, active2, 0L);
		case 111:
			if ((active0 & 0x800000u) != 0)
			{
				jjmatchedKind = 23;
				jjmatchedPos = 1;
			}
			else if ((active1 & 8) != 0)
			{
				return jjStartNfaWithStates_0(1, 67, 152);
			}
			return jjMoveStringLiteralDfa2_0(active0, -4611684906010927104L, active1, 256L, active2, 0L);
		case 112:
			return jjMoveStringLiteralDfa2_0(active0, 0L, active1, 96L, active2, 0L);
		case 114:
			return jjMoveStringLiteralDfa2_0(active0, 4035330819240247296L, active1, 3072L, active2, 0L);
		case 115:
			return jjMoveStringLiteralDfa2_0(active0, 4096L, active1, 128L, active2, 0L);
		case 116:
			return jjMoveStringLiteralDfa2_0(active0, 6755399441055744L, active1, 0L, active2, 0L);
		case 117:
			return jjMoveStringLiteralDfa2_0(active0, 9156732836118528L, active1, 0L, active2, 0L);
		case 119:
			return jjMoveStringLiteralDfa2_0(active0, 18014398509481984L, active1, 0L, active2, 0L);
		case 120:
			return jjMoveStringLiteralDfa2_0(active0, 134217728L, active1, 512L, active2, 0L);
		case 121:
			return jjMoveStringLiteralDfa2_0(active0, 36028797018996736L, active1, 0L, active2, 0L);
		case 124:
			if ((active1 & 0x200000000000000L) != 0)
			{
				return jjStopAtPos(1, 121);
			}
			break;
		}
		return jjStartNfa_0(0, active0, active1, active2);
		IL_0019:
		
		jjStopStringLiteralDfa_0(0, active0, active1, active2);
		return 1;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		161, 154, 123, 108, 220, 226, 61, 97, 109, 130,
		191, 161, 20, 112, 170, 115, 170, 109, 109, 112,
		173, 141, 107, 135, 150, 157, 153, 153, 150, 154,
		150, 153, 153, 153, 157, 157, 146, 111, 111, 153,
		153, 143, 104, 135, 154, 153, 111, 175, 111, 239,
		69
	})]
	private int jjMoveStringLiteralDfa2_0(long old0, long active0, long old1, long active1, long old2, long active2)
	{
		if (((active0 &= old0) | (active1 &= old1) | (active2 &= old2)) == 0)
		{
			return jjStartNfa_0(0, old0, old1, old2);
		}
		try
		{
			curChar = input_stream.readChar();
		}
		catch (IOException)
		{
			goto IL_0040;
		}
		switch (curChar)
		{
		case 34:
			if ((active1 & 0x8000000u) != 0)
			{
				return jjStopAtPos(2, 91);
			}
			break;
		case 46:
			if ((active1 & 0x40000000000L) != 0)
			{
				return jjStopAtPos(2, 106);
			}
			break;
		case 61:
			if ((active2 & 0x2000u) != 0)
			{
				return jjStopAtPos(2, 141);
			}
			if ((active2 & 0x4000u) != 0)
			{
				return jjStopAtPos(2, 142);
			}
			break;
		case 62:
			if ((active2 & 0x10000u) != 0)
			{
				jjmatchedKind = 144;
				jjmatchedPos = 2;
			}
			return jjMoveStringLiteralDfa3_0(active0, 0L, active1, 0L, active2, 32768L);
		case 97:
			return jjMoveStringLiteralDfa3_0(active0, 578712552117895168L, active1, 2048L, active2, 0L);
		case 98:
			return jjMoveStringLiteralDfa3_0(active0, 140737488355328L, active1, 0L, active2, 0L);
		case 99:
			return jjMoveStringLiteralDfa3_0(active0, 299067162755072L, active1, 0L, active2, 0L);
		case 100:
			return jjMoveStringLiteralDfa3_0(active0, 0L, active1, 256L, active2, 0L);
		case 101:
			return jjMoveStringLiteralDfa3_0(active0, 16384L, active1, 226L, active2, 0L);
		case 102:
			return jjMoveStringLiteralDfa3_0(active0, 4194304L, active1, 0L, active2, 0L);
		case 105:
			return jjMoveStringLiteralDfa3_0(active0, 4701793195346886656L, active1, 1L, active2, 0L);
		case 108:
			return jjMoveStringLiteralDfa3_0(active0, -9223363240493318144L, active1, 0L, active2, 0L);
		case 110:
			return jjMoveStringLiteralDfa3_0(active0, 36029898144350208L, active1, 0L, active2, 0L);
		case 111:
			return jjMoveStringLiteralDfa3_0(active0, 1196270798512128L, active1, 1024L, active2, 0L);
		case 112:
			return jjMoveStringLiteralDfa3_0(active0, 9007302333956096L, active1, 512L, active2, 0L);
		case 113:
			return jjMoveStringLiteralDfa3_0(active0, 0L, active1, 4L, active2, 0L);
		case 114:
			if ((active0 & 0x100000000L) != 0)
			{
				return jjStartNfaWithStates_0(2, 32, 152);
			}
			return jjMoveStringLiteralDfa3_0(active0, 436849163854938112L, active1, 0L, active2, 0L);
		case 115:
			return jjMoveStringLiteralDfa3_0(active0, 137472579584L, active1, 0L, active2, 0L);
		case 116:
			if ((active0 & 0x4000000000L) != 0)
			{
				jjmatchedKind = 38;
				jjmatchedPos = 2;
			}
			return jjMoveStringLiteralDfa3_0(active0, 565707456806912L, active1, 16L, active2, 0L);
		case 117:
			return jjMoveStringLiteralDfa3_0(active0, 1152921504690733056L, active1, 0L, active2, 0L);
		case 119:
			if ((active0 & 0x40000000000L) != 0)
			{
				return jjStartNfaWithStates_0(2, 42, 152);
			}
			break;
		case 121:
			if ((active0 & 0x2000000000000000L) != 0)
			{
				return jjStartNfaWithStates_0(2, 61, 152);
			}
			break;
		}
		return jjStartNfa_0(1, active0, active1, active2);
		IL_0040:
		
		jjStopStringLiteralDfa_0(1, active0, active1, active2);
		return 2;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	private int jjStartNfaWithStates_0(int pos, int kind, int state)
	{
		jjmatchedKind = kind;
		jjmatchedPos = pos;
		try
		{
			curChar = input_stream.readChar();
		}
		catch (IOException)
		{
			goto IL_0027;
		}
		return jjMoveNfa_0(state, pos + 1);
		IL_0027:
		
		return pos + 1;
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	private int jjStartNfa_0(int pos, long active0, long active1, long active2)
	{
		int result = jjMoveNfa_0(jjStopStringLiteralDfa_0(pos, active0, active1, active2), pos + 1);
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		161, 237, 123, 108, 220, 226, 61, 97, 109, 130,
		191, 160, 156, 112, 173, 153, 150, 153, 114, 175,
		108, 111, 108, 111, 108, 111, 111, 111, 153, 114,
		175, 109, 175, 153, 153, 111, 111, 153, 111, 175,
		138, 104, 135, 157, 111, 111, 157, 108, 111, 153,
		111, 111, 109, 111, 150, 153, 157, 221
	})]
	private int jjMoveStringLiteralDfa3_0(long old0, long active0, long old1, long active1, long old2, long active2)
	{
		if (((active0 &= old0) | (active1 &= old1) | (active2 &= old2)) == 0)
		{
			return jjStartNfa_0(1, old0, old1, old2);
		}
		try
		{
			curChar = input_stream.readChar();
		}
		catch (IOException)
		{
			goto IL_0040;
		}
		switch (curChar)
		{
		case 61:
			if ((active2 & 0x8000u) != 0)
			{
				return jjStopAtPos(3, 143);
			}
			break;
		case 97:
			return jjMoveStringLiteralDfa4_0(active0, -9223372033092468736L, active1, 0L, active2, 0L);
		case 98:
			return jjMoveStringLiteralDfa4_0(active0, 16777216L, active1, 0L, active2, 0L);
		case 99:
			return jjMoveStringLiteralDfa4_0(active0, 36028797019095040L, active1, 0L, active2, 0L);
		case 100:
			if ((active0 & 0x4000000000000000L) != 0)
			{
				return jjStartNfaWithStates_0(3, 62, 152);
			}
			break;
		case 101:
			if ((active0 & 0x8000u) != 0)
			{
				return jjStartNfaWithStates_0(3, 15, 152);
			}
			if ((active0 & 0x10000u) != 0)
			{
				return jjStartNfaWithStates_0(3, 16, 152);
			}
			if ((active0 & 0x2000000u) != 0)
			{
				return jjStartNfaWithStates_0(3, 25, 152);
			}
			if ((active0 & 0x1000000000000000L) != 0)
			{
				return jjStartNfaWithStates_0(3, 60, 152);
			}
			return jjMoveStringLiteralDfa4_0(active0, 9007749144776704L, active1, 0L, active2, 0L);
		case 103:
			if ((active0 & 0x10000000000L) != 0)
			{
				return jjStartNfaWithStates_0(3, 40, 152);
			}
			break;
		case 104:
			if ((active1 & 0x10u) != 0)
			{
				return jjStartNfaWithStates_0(3, 68, 152);
			}
			break;
		case 105:
			return jjMoveStringLiteralDfa4_0(active0, 4505798650626048L, active1, 0L, active2, 0L);
		case 107:
			return jjMoveStringLiteralDfa4_0(active0, 17592186044416L, active1, 0L, active2, 0L);
		case 108:
			if ((active0 & 0x80000000000L) != 0)
			{
				return jjStartNfaWithStates_0(3, 43, 152);
			}
			return jjMoveStringLiteralDfa4_0(active0, 140771848101888L, active1, 3L, active2, 0L);
		case 109:
			if ((active0 & 0x4000000u) != 0)
			{
				return jjStartNfaWithStates_0(3, 26, 152);
			}
			break;
		case 110:
			if ((active1 & 0x20u) != 0)
			{
				jjmatchedKind = 69;
				jjmatchedPos = 3;
			}
			return jjMoveStringLiteralDfa4_0(active0, 576460752303423488L, active1, 2112L, active2, 0L);
		case 111:
			if ((active0 & 0x200000000L) != 0)
			{
				return jjStartNfaWithStates_0(3, 33, 152);
			}
			return jjMoveStringLiteralDfa4_0(active0, 432627107923755008L, active1, 512L, active2, 0L);
		case 114:
			if ((active0 & 0x40000u) != 0)
			{
				return jjStartNfaWithStates_0(3, 18, 152);
			}
			return jjMoveStringLiteralDfa4_0(active0, 1125899906842624L, active1, 0L, active2, 0L);
		case 115:
			if ((active0 & 0x100000000000000L) != 0)
			{
				return jjStartNfaWithStates_0(3, 56, 152);
			}
			if ((active1 & 0x80u) != 0)
			{
				return jjStartNfaWithStates_0(3, 71, 152);
			}
			return jjMoveStringLiteralDfa4_0(active0, 270008320L, active1, 0L, active2, 0L);
		case 116:
			return jjMoveStringLiteralDfa4_0(active0, 20336704508397568L, active1, 0L, active2, 0L);
		case 117:
			return jjMoveStringLiteralDfa4_0(active0, 562949953421312L, active1, 260L, active2, 0L);
		case 118:
			return jjMoveStringLiteralDfa4_0(active0, 35184372088832L, active1, 1024L, active2, 0L);
		}
		return jjStartNfa_0(2, active0, active1, active2);
		IL_0040:
		
		jjStopStringLiteralDfa_0(2, active0, active1, active2);
		return 3;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		162, 67, 122, 108, 220, 226, 61, 97, 109, 130,
		191, 80, 149, 149, 108, 175, 108, 111, 105, 111,
		149, 108, 111, 149, 153, 111, 175, 140, 104, 135,
		150, 146, 111, 111, 153, 108, 111, 106, 111, 153,
		108, 111, 108, 111, 111, 111, 149, 146, 149, 143,
		104, 135, 213
	})]
	private int jjMoveStringLiteralDfa4_0(long old0, long active0, long old1, long active1, long old2, long active2)
	{
		if (((active0 &= old0) | (active1 &= old1) | (active2 & old2)) == 0)
		{
			return jjStartNfa_0(2, old0, old1, old2);
		}
		try
		{
			curChar = input_stream.readChar();
		}
		catch (IOException)
		{
			goto IL_003f;
		}
		switch (curChar)
		{
		case 97:
			return jjMoveStringLiteralDfa5_0(active0, 52913997086720L, active1, 0L);
		case 99:
			return jjMoveStringLiteralDfa5_0(active0, 22517998136852480L, active1, 0L);
		case 100:
			if ((active1 & 2) != 0)
			{
				return jjStartNfaWithStates_0(4, 65, 152);
			}
			break;
		case 101:
			if ((active0 & 0x10000000u) != 0)
			{
				return jjStartNfaWithStates_0(4, 28, 152);
			}
			if ((active1 & 1) != 0)
			{
				return jjStartNfaWithStates_0(4, 64, 152);
			}
			return jjMoveStringLiteralDfa5_0(active0, 70403103924224L, active1, 0L);
		case 104:
			if ((active0 & 0x20000u) != 0)
			{
				return jjStartNfaWithStates_0(4, 17, 152);
			}
			return jjMoveStringLiteralDfa5_0(active0, 36028797018963968L, active1, 0L);
		case 105:
			return jjMoveStringLiteralDfa5_0(active0, 2392537304137728L, active1, 1028L);
		case 107:
			if ((active0 & 0x4000u) != 0)
			{
				return jjStartNfaWithStates_0(4, 14, 152);
			}
			break;
		case 108:
			if ((active0 & 0x20000000u) != 0)
			{
				jjmatchedKind = 29;
				jjmatchedPos = 4;
			}
			return jjMoveStringLiteralDfa5_0(active0, 1090519040L, active1, 256L);
		case 110:
			return jjMoveStringLiteralDfa5_0(active0, 134217728L, active1, 0L);
		case 114:
			if ((active0 & 0x20000000000000L) != 0)
			{
				return jjStartNfaWithStates_0(4, 53, 152);
			}
			return jjMoveStringLiteralDfa5_0(active0, 845043405428736L, active1, 512L);
		case 115:
			if ((active0 & 0x80000u) != 0)
			{
				return jjStartNfaWithStates_0(4, 19, 152);
			}
			if ((active1 & 0x40u) != 0)
			{
				return jjStartNfaWithStates_0(4, 70, 152);
			}
			return jjMoveStringLiteralDfa5_0(active0, 576460752303423488L, active1, 2048L);
		case 116:
			if ((active0 & 0x100000u) != 0)
			{
				return jjStartNfaWithStates_0(4, 20, 152);
			}
			if ((active0 & 0x80000000u) != 0)
			{
				return jjStartNfaWithStates_0(4, 31, 152);
			}
			if ((active0 & 0x4000000000000L) != 0)
			{
				return jjStartNfaWithStates_0(4, 50, 152);
			}
			return jjMoveStringLiteralDfa5_0(active0, long.MinValue, active1, 0L);
		case 117:
			return jjMoveStringLiteralDfa5_0(active0, 4194304L, active1, 0L);
		case 118:
			return jjMoveStringLiteralDfa5_0(active0, 2199023255552L, active1, 0L);
		case 119:
			if ((active0 & 0x200000000000000L) != 0)
			{
				jjmatchedKind = 57;
				jjmatchedPos = 4;
			}
			return jjMoveStringLiteralDfa5_0(active0, 288230376151711744L, active1, 0L);
		}
		return jjStartNfa_0(3, active0, active1, 0L);
		IL_003f:
		
		jjStopStringLiteralDfa_0(3, active0, active1, 0L);
		return 4;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		162, 144, 114, 108, 220, 226, 61, 97, 109, 130,
		191, 68, 146, 111, 111, 111, 111, 149, 111, 111,
		150, 108, 111, 111, 111, 112, 175, 149, 149, 114,
		175, 153, 146, 149, 111, 111, 149, 149, 111, 175,
		108, 111, 111, 111, 217
	})]
	private int jjMoveStringLiteralDfa5_0(long old0, long active0, long old1, long active1)
	{
		if (((active0 &= old0) | (active1 &= old1)) == 0)
		{
			return jjStartNfa_0(3, old0, old1, 0L);
		}
		try
		{
			curChar = input_stream.readChar();
		}
		catch (IOException)
		{
			goto IL_0037;
		}
		switch (curChar)
		{
		case 97:
			return jjMoveStringLiteralDfa6_0(active0, 10240L, active1, 0L);
		case 99:
			if ((active0 & 0x800000000000L) != 0)
			{
				return jjStartNfaWithStates_0(5, 47, 152);
			}
			if ((active0 & 0x8000000000000L) != 0)
			{
				return jjStartNfaWithStates_0(5, 51, 152);
			}
			return jjMoveStringLiteralDfa6_0(active0, 70368744177664L, active1, 0L);
		case 100:
			if ((active0 & 0x1000000000000L) != 0)
			{
				return jjStartNfaWithStates_0(5, 48, 152);
			}
			return jjMoveStringLiteralDfa6_0(active0, 134217728L, active1, 1024L);
		case 101:
			if ((active0 & 0x1000000u) != 0)
			{
				return jjStartNfaWithStates_0(5, 24, 152);
			}
			if ((active0 & 0x20000000000L) != 0)
			{
				return jjStartNfaWithStates_0(5, 41, 152);
			}
			if ((active1 & 0x100u) != 0)
			{
				return jjStartNfaWithStates_0(5, 72, 152);
			}
			break;
		case 102:
			return jjMoveStringLiteralDfa6_0(active0, 549755813888L, active1, 0L);
		case 103:
			return jjMoveStringLiteralDfa6_0(active0, 17592186044416L, active1, 0L);
		case 104:
			if ((active0 & 0x40000000000000L) != 0)
			{
				return jjStartNfaWithStates_0(5, 54, 152);
			}
			break;
		case 105:
			return jjMoveStringLiteralDfa6_0(active0, -8646911284551352320L, active1, 2048L);
		case 108:
			return jjMoveStringLiteralDfa6_0(active0, 1077936128L, active1, 0L);
		case 109:
			return jjMoveStringLiteralDfa6_0(active0, 34359738368L, active1, 0L);
		case 110:
			if ((active0 & 0x2000000000000L) != 0)
			{
				return jjStartNfaWithStates_0(5, 49, 152);
			}
			return jjMoveStringLiteralDfa6_0(active0, 137441050624L, active1, 0L);
		case 114:
			return jjMoveStringLiteralDfa6_0(active0, 36028797018963968L, active1, 4L);
		case 115:
			if ((active0 & 0x400000000000000L) != 0)
			{
				return jjStartNfaWithStates_0(5, 58, 152);
			}
			break;
		case 116:
			if ((active0 & 0x1000u) != 0)
			{
				return jjStartNfaWithStates_0(5, 12, 152);
			}
			if ((active0 & 0x1000000000L) != 0)
			{
				return jjStartNfaWithStates_0(5, 36, 152);
			}
			return jjMoveStringLiteralDfa6_0(active0, 4538783999459328L, active1, 512L);
		}
		return jjStartNfa_0(4, active0, active1, 0L);
		IL_0037:
		
		jjStopStringLiteralDfa_0(4, active0, active1, 0L);
		return 5;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		162, 209, 114, 108, 220, 226, 61, 97, 109, 130,
		191, 88, 149, 149, 111, 111, 111, 111, 153, 149,
		149, 111, 175, 149, 108, 111, 109, 175, 108, 111,
		153, 146, 108, 239, 69
	})]
	private int jjMoveStringLiteralDfa6_0(long old0, long active0, long old1, long active1)
	{
		if (((active0 &= old0) | (active1 &= old1)) == 0)
		{
			return jjStartNfa_0(4, old0, old1, 0L);
		}
		try
		{
			curChar = input_stream.readChar();
		}
		catch (IOException)
		{
			goto IL_0037;
		}
		switch (curChar)
		{
		case 97:
			return jjMoveStringLiteralDfa7_0(active0, 549755813888L, active1, 0L);
		case 99:
			return jjMoveStringLiteralDfa7_0(active0, 137438955520L, active1, 0L);
		case 101:
			if ((active0 & 0x100000000000L) != 0)
			{
				return jjStartNfaWithStates_0(6, 44, 152);
			}
			if ((active0 & 0x200000000000L) != 0)
			{
				return jjStartNfaWithStates_0(6, 45, 152);
			}
			return jjMoveStringLiteralDfa7_0(active0, 576460786663161856L, active1, 1028L);
		case 102:
			return jjMoveStringLiteralDfa7_0(active0, 4503599627370496L, active1, 0L);
		case 108:
			return jjMoveStringLiteralDfa7_0(active0, long.MinValue, active1, 0L);
		case 110:
			if ((active0 & 0x2000u) != 0)
			{
				return jjStartNfaWithStates_0(6, 13, 152);
			}
			break;
		case 111:
			return jjMoveStringLiteralDfa7_0(active0, 36028797018963968L, active1, 0L);
		case 115:
			if ((active0 & 0x8000000u) != 0)
			{
				return jjStartNfaWithStates_0(6, 27, 152);
			}
			if ((active1 & 0x200u) != 0)
			{
				return jjStartNfaWithStates_0(6, 73, 152);
			}
			break;
		case 116:
			if ((active0 & 0x400000u) != 0)
			{
				return jjStartNfaWithStates_0(6, 22, 152);
			}
			return jjMoveStringLiteralDfa7_0(active0, 70368744177664L, active1, 2048L);
		case 117:
			return jjMoveStringLiteralDfa7_0(active0, 2097152L, active1, 0L);
		case 121:
			if ((active0 & 0x40000000u) != 0)
			{
				return jjStartNfaWithStates_0(6, 30, 152);
			}
			break;
		}
		return jjStartNfa_0(5, active0, active1, 0L);
		IL_0037:
		
		jjStopStringLiteralDfa_0(5, active0, active1, 0L);
		return 6;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		163, 4, 114, 108, 220, 226, 61, 97, 109, 130,
		191, 60, 149, 108, 111, 111, 111, 149, 146, 149,
		111, 175, 105, 111, 109, 175, 108, 239, 69
	})]
	private int jjMoveStringLiteralDfa7_0(long old0, long active0, long old1, long active1)
	{
		if (((active0 &= old0) | (active1 &= old1)) == 0)
		{
			return jjStartNfa_0(5, old0, old1, 0L);
		}
		try
		{
			curChar = input_stream.readChar();
		}
		catch (IOException)
		{
			goto IL_0037;
		}
		switch (curChar)
		{
		case 99:
			return jjMoveStringLiteralDfa8_0(active0, 549755813888L, active1, 0L);
		case 101:
			if ((active0 & 0x200000u) != 0)
			{
				return jjStartNfaWithStates_0(7, 21, 152);
			}
			if ((active0 & long.MinValue) != 0)
			{
				return jjStartNfaWithStates_0(7, 63, 152);
			}
			return jjMoveStringLiteralDfa8_0(active0, 70506183131136L, active1, 0L);
		case 105:
			return jjMoveStringLiteralDfa8_0(active0, 0L, active1, 2048L);
		case 110:
			return jjMoveStringLiteralDfa8_0(active0, 612489583682125824L, active1, 0L);
		case 112:
			if ((active0 & 0x10000000000000L) != 0)
			{
				return jjStartNfaWithStates_0(7, 52, 152);
			}
			break;
		case 115:
			if ((active1 & 4) != 0)
			{
				return jjStartNfaWithStates_0(7, 66, 152);
			}
			if ((active1 & 0x400u) != 0)
			{
				return jjStartNfaWithStates_0(7, 74, 152);
			}
			break;
		case 116:
			if ((active0 & 0x800u) != 0)
			{
				return jjStartNfaWithStates_0(7, 11, 152);
			}
			break;
		}
		return jjStartNfa_0(6, active0, active1, 0L);
		IL_0037:
		
		jjStopStringLiteralDfa_0(6, active0, active1, 0L);
		return 7;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		163, 45, 114, 108, 220, 226, 61, 97, 109, 130,
		191, 64, 114, 175, 114, 175, 149, 149, 111, 111,
		149, 210
	})]
	private int jjMoveStringLiteralDfa8_0(long old0, long active0, long old1, long active1)
	{
		if (((active0 &= old0) | (active1 &= old1)) == 0)
		{
			return jjStartNfa_0(6, old0, old1, 0L);
		}
		try
		{
			curChar = input_stream.readChar();
		}
		catch (IOException)
		{
			goto IL_0037;
		}
		switch (curChar)
		{
		case 100:
			if ((active0 & 0x400000000000L) != 0)
			{
				return jjStartNfaWithStates_0(8, 46, 152);
			}
			break;
		case 101:
			if ((active0 & 0x8000000000L) != 0)
			{
				return jjStartNfaWithStates_0(8, 39, 152);
			}
			break;
		case 105:
			return jjMoveStringLiteralDfa9_0(active0, 36028797018963968L, active1, 0L);
		case 111:
			return jjMoveStringLiteralDfa9_0(active0, 137438953472L, active1, 0L);
		case 116:
			if ((active0 & 0x800000000000000L) != 0)
			{
				return jjStartNfaWithStates_0(8, 59, 152);
			}
			return jjMoveStringLiteralDfa9_0(active0, 34359738368L, active1, 0L);
		case 118:
			return jjMoveStringLiteralDfa9_0(active0, 0L, active1, 2048L);
		}
		return jjStartNfa_0(7, active0, active1, 0L);
		IL_0037:
		
		jjStopStringLiteralDfa_0(7, active0, active1, 0L);
		return 8;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		163, 78, 114, 108, 220, 226, 61, 97, 109, 131,
		191, 10, 109, 176, 111, 176, 111, 176, 213
	})]
	private int jjMoveStringLiteralDfa9_0(long old0, long active0, long old1, long active1)
	{
		if (((active0 &= old0) | (active1 &= old1)) == 0)
		{
			return jjStartNfa_0(7, old0, old1, 0L);
		}
		try
		{
			curChar = input_stream.readChar();
		}
		catch (IOException)
		{
			goto IL_0037;
		}
		switch (curChar)
		{
		case 101:
			if ((active1 & 0x800u) != 0)
			{
				return jjStartNfaWithStates_0(9, 75, 152);
			}
			break;
		case 102:
			if ((active0 & 0x2000000000L) != 0)
			{
				return jjStartNfaWithStates_0(9, 37, 152);
			}
			break;
		case 115:
			if ((active0 & 0x800000000L) != 0)
			{
				return jjStartNfaWithStates_0(9, 35, 152);
			}
			break;
		case 122:
			return jjMoveStringLiteralDfa10_0(active0, 36028797018963968L, active1, 0L);
		}
		return jjStartNfa_0(8, active0, active1, 0L);
		IL_0037:
		
		jjStopStringLiteralDfa_0(8, active0, active1, 0L);
		return 9;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		163, 107, 113, 108, 220, 226, 61, 97, 110, 131,
		177, 209
	})]
	private int jjMoveStringLiteralDfa10_0(long old0, long active0, long old1, long active1)
	{
		if (((active0 &= old0) | (active1 & old1)) == 0)
		{
			return jjStartNfa_0(8, old0, old1, 0L);
		}
		try
		{
			curChar = input_stream.readChar();
		}
		catch (IOException)
		{
			goto IL_0036;
		}
		if (curChar == 101)
		{
			return jjMoveStringLiteralDfa11_0(active0, 36028797018963968L);
		}
		return jjStartNfa_0(9, active0, 0L, 0L);
		IL_0036:
		
		jjStopStringLiteralDfa_0(9, active0, 0L, 0L);
		return 10;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		163, 124, 106, 110, 220, 226, 61, 97, 110, 131,
		177, 111, 240, 69
	})]
	private int jjMoveStringLiteralDfa11_0(long old0, long active0)
	{
		if ((active0 &= old0) == 0)
		{
			return jjStartNfa_0(9, old0, 0L, 0L);
		}
		try
		{
			curChar = input_stream.readChar();
		}
		catch (IOException)
		{
			goto IL_0031;
		}
		if (curChar == 100 && (active0 & 0x80000000000000L) != 0)
		{
			return jjStartNfaWithStates_0(11, 55, 152);
		}
		return jjStartNfa_0(10, active0, 0L, 0L);
		IL_0031:
		
		jjStopStringLiteralDfa_0(10, active0, 0L, 0L);
		return 11;
	}

	
	private void ReInitRounds()
	{
		jjround = -2147483647;
		int num = 152;
		while (true)
		{
			int num2 = num;
			num += -1;
			if (num2 > 0)
			{
				jjrounds[num] = int.MinValue;
				continue;
			}
			break;
		}
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	private void jjCheckNAddStates(int start, int end)
	{
		int num;
		do
		{
			jjCheckNAdd(jjnextStates[start]);
			num = start;
			start++;
		}
		while (num != end);
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	private void jjCheckNAddTwoStates(int state1, int state2)
	{
		jjCheckNAdd(state1);
		jjCheckNAdd(state2);
	}

	
	
	private void jjCheckNAdd(int state)
	{
		if (jjrounds[state] != jjround)
		{
			int[] array = jjstateSet;
			int num = jjnewStateCnt;
			jjnewStateCnt = num + 1;
			array[num] = state;
			jjrounds[state] = jjround;
		}
	}

	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	private void jjAddStates(int start, int end)
	{
		int num2;
		do
		{
			int[] array = jjstateSet;
			int num = jjnewStateCnt;
			jjnewStateCnt = num + 1;
			array[num] = jjnextStates[start];
			num2 = start;
			start++;
		}
		while (num2 != end);
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	private static bool jjCanMove_1(int hiByte, int i1, int i2, long l1, long l2)
	{
		if (hiByte == 0)
		{
			return (jjbitVec8[i2] & l2) != 0;
		}
		if ((jjbitVec6[i1] & l1) != 0)
		{
			return true;
		}
		return false;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		170, 137, 191, 161, 240, 146, 146, 146, 146, 146,
		146, 146, 146, 146, 146, 146, 146, 146, 146, 146,
		146, 146, 146, 146, 146, 146, 146, 146, 146, 146,
		146, 146, 146, 146, 146, 146, 146, 146, 146, 146,
		146, 146, 146, 146, 146, 146, 146, 146, 146, 146,
		146, 146, 146, 146, 146, 109, 98
	})]
	private static bool jjCanMove_3(int hiByte, int i1, int i2, long l1, long l2)
	{
		switch (hiByte)
		{
		case 0:
			return (jjbitVec59[i2] & l2) != 0;
		case 2:
			return (jjbitVec11[i2] & l2) != 0;
		case 3:
			return (jjbitVec60[i2] & l2) != 0;
		case 4:
			return (jjbitVec61[i2] & l2) != 0;
		case 5:
			return (jjbitVec62[i2] & l2) != 0;
		case 6:
			return (jjbitVec63[i2] & l2) != 0;
		case 7:
			return (jjbitVec64[i2] & l2) != 0;
		case 8:
			return (jjbitVec65[i2] & l2) != 0;
		case 9:
			return (jjbitVec66[i2] & l2) != 0;
		case 10:
			return (jjbitVec67[i2] & l2) != 0;
		case 11:
			return (jjbitVec68[i2] & l2) != 0;
		case 12:
			return (jjbitVec69[i2] & l2) != 0;
		case 13:
			return (jjbitVec70[i2] & l2) != 0;
		case 14:
			return (jjbitVec71[i2] & l2) != 0;
		case 15:
			return (jjbitVec72[i2] & l2) != 0;
		case 16:
			return (jjbitVec73[i2] & l2) != 0;
		case 18:
			return (jjbitVec26[i2] & l2) != 0;
		case 19:
			return (jjbitVec74[i2] & l2) != 0;
		case 20:
			return (jjbitVec6[i2] & l2) != 0;
		case 22:
			return (jjbitVec28[i2] & l2) != 0;
		case 23:
			return (jjbitVec75[i2] & l2) != 0;
		case 24:
			return (jjbitVec76[i2] & l2) != 0;
		case 25:
			return (jjbitVec77[i2] & l2) != 0;
		case 26:
			return (jjbitVec78[i2] & l2) != 0;
		case 27:
			return (jjbitVec79[i2] & l2) != 0;
		case 28:
			return (jjbitVec80[i2] & l2) != 0;
		case 29:
			return (jjbitVec81[i2] & l2) != 0;
		case 31:
			return (jjbitVec36[i2] & l2) != 0;
		case 32:
			return (jjbitVec82[i2] & l2) != 0;
		case 33:
			return (jjbitVec38[i2] & l2) != 0;
		case 44:
			return (jjbitVec83[i2] & l2) != 0;
		case 45:
			return (jjbitVec84[i2] & l2) != 0;
		case 46:
			return (jjbitVec41[i2] & l2) != 0;
		case 48:
			return (jjbitVec85[i2] & l2) != 0;
		case 49:
			return (jjbitVec43[i2] & l2) != 0;
		case 77:
			return (jjbitVec44[i2] & l2) != 0;
		case 159:
			return (jjbitVec45[i2] & l2) != 0;
		case 164:
			return (jjbitVec46[i2] & l2) != 0;
		case 166:
			return (jjbitVec86[i2] & l2) != 0;
		case 167:
			return (jjbitVec48[i2] & l2) != 0;
		case 168:
			return (jjbitVec87[i2] & l2) != 0;
		case 169:
			return (jjbitVec88[i2] & l2) != 0;
		case 170:
			return (jjbitVec89[i2] & l2) != 0;
		case 171:
			return (jjbitVec90[i2] & l2) != 0;
		case 215:
			return (jjbitVec53[i2] & l2) != 0;
		case 250:
			return (jjbitVec54[i2] & l2) != 0;
		case 251:
			return (jjbitVec91[i2] & l2) != 0;
		case 253:
			return (jjbitVec56[i2] & l2) != 0;
		case 254:
			return (jjbitVec92[i2] & l2) != 0;
		case 255:
			return (jjbitVec93[i2] & l2) != 0;
		default:
			if ((jjbitVec9[i1] & l1) != 0)
			{
				return true;
			}
			return false;
		}
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	private static bool jjCanMove_0(int hiByte, int i1, int i2, long l1, long l2)
	{
		return hiByte switch
		{
			0 => (jjbitVec0[i2] & l2) != 0, 
			22 => (jjbitVec1[i2] & l2) != 0, 
			24 => (jjbitVec2[i2] & l2) != 0, 
			32 => (jjbitVec3[i2] & l2) != 0, 
			48 => (jjbitVec4[i2] & l2) != 0, 
			254 => (jjbitVec5[i2] & l2) != 0, 
			_ => false, 
		};
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		170, 27, 191, 161, 240, 146, 146, 146, 146, 146,
		146, 146, 146, 146, 146, 146, 146, 146, 146, 146,
		146, 146, 146, 146, 146, 146, 146, 146, 146, 146,
		146, 146, 146, 146, 146, 146, 146, 146, 146, 146,
		146, 146, 146, 146, 146, 146, 146, 146, 146, 146,
		146, 146, 146, 146, 146, 109, 98
	})]
	private static bool jjCanMove_2(int hiByte, int i1, int i2, long l1, long l2)
	{
		switch (hiByte)
		{
		case 0:
			return (jjbitVec10[i2] & l2) != 0;
		case 2:
			return (jjbitVec11[i2] & l2) != 0;
		case 3:
			return (jjbitVec12[i2] & l2) != 0;
		case 4:
			return (jjbitVec13[i2] & l2) != 0;
		case 5:
			return (jjbitVec14[i2] & l2) != 0;
		case 6:
			return (jjbitVec15[i2] & l2) != 0;
		case 7:
			return (jjbitVec16[i2] & l2) != 0;
		case 8:
			return (jjbitVec17[i2] & l2) != 0;
		case 9:
			return (jjbitVec18[i2] & l2) != 0;
		case 10:
			return (jjbitVec19[i2] & l2) != 0;
		case 11:
			return (jjbitVec20[i2] & l2) != 0;
		case 12:
			return (jjbitVec21[i2] & l2) != 0;
		case 13:
			return (jjbitVec22[i2] & l2) != 0;
		case 14:
			return (jjbitVec23[i2] & l2) != 0;
		case 15:
			return (jjbitVec24[i2] & l2) != 0;
		case 16:
			return (jjbitVec25[i2] & l2) != 0;
		case 18:
			return (jjbitVec26[i2] & l2) != 0;
		case 19:
			return (jjbitVec27[i2] & l2) != 0;
		case 20:
			return (jjbitVec6[i2] & l2) != 0;
		case 22:
			return (jjbitVec28[i2] & l2) != 0;
		case 23:
			return (jjbitVec29[i2] & l2) != 0;
		case 24:
			return (jjbitVec30[i2] & l2) != 0;
		case 25:
			return (jjbitVec31[i2] & l2) != 0;
		case 26:
			return (jjbitVec32[i2] & l2) != 0;
		case 27:
			return (jjbitVec33[i2] & l2) != 0;
		case 28:
			return (jjbitVec34[i2] & l2) != 0;
		case 29:
			return (jjbitVec35[i2] & l2) != 0;
		case 31:
			return (jjbitVec36[i2] & l2) != 0;
		case 32:
			return (jjbitVec37[i2] & l2) != 0;
		case 33:
			return (jjbitVec38[i2] & l2) != 0;
		case 44:
			return (jjbitVec39[i2] & l2) != 0;
		case 45:
			return (jjbitVec40[i2] & l2) != 0;
		case 46:
			return (jjbitVec41[i2] & l2) != 0;
		case 48:
			return (jjbitVec42[i2] & l2) != 0;
		case 49:
			return (jjbitVec43[i2] & l2) != 0;
		case 77:
			return (jjbitVec44[i2] & l2) != 0;
		case 159:
			return (jjbitVec45[i2] & l2) != 0;
		case 164:
			return (jjbitVec46[i2] & l2) != 0;
		case 166:
			return (jjbitVec47[i2] & l2) != 0;
		case 167:
			return (jjbitVec48[i2] & l2) != 0;
		case 168:
			return (jjbitVec49[i2] & l2) != 0;
		case 169:
			return (jjbitVec50[i2] & l2) != 0;
		case 170:
			return (jjbitVec51[i2] & l2) != 0;
		case 171:
			return (jjbitVec52[i2] & l2) != 0;
		case 215:
			return (jjbitVec53[i2] & l2) != 0;
		case 250:
			return (jjbitVec54[i2] & l2) != 0;
		case 251:
			return (jjbitVec55[i2] & l2) != 0;
		case 253:
			return (jjbitVec56[i2] & l2) != 0;
		case 254:
			return (jjbitVec57[i2] & l2) != 0;
		case 255:
			return (jjbitVec58[i2] & l2) != 0;
		default:
			if ((jjbitVec9[i1] & l1) != 0)
			{
				return true;
			}
			return false;
		}
	}

	
	
	
	private int jjMoveStringLiteralDfa1_1(long active0)
	{
		try
		{
			curChar = input_stream.readChar();
		}
		catch (IOException)
		{
			goto IL_0019;
		}
		if (curChar == 47)
		{
			if ((active0 & 0x100u) != 0)
			{
				return jjStopAtPos(1, 8);
			}
			return 2;
		}
		return 2;
		IL_0019:
		
		return 1;
	}

	
	
	
	private int jjMoveStringLiteralDfa1_2(long active0)
	{
		try
		{
			curChar = input_stream.readChar();
		}
		catch (IOException)
		{
			goto IL_0019;
		}
		if (curChar == 47)
		{
			if ((active0 & 0x200u) != 0)
			{
				return jjStopAtPos(1, 9);
			}
			return 2;
		}
		return 2;
		IL_0019:
		
		return 1;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	private int jjStopStringLiteralDfa_3(int pos, long active0, long active1)
	{
		switch (pos)
		{
		case 0:
			if ((active1 & 0x10000000u) != 0)
			{
				jjmatchedKind = 93;
				return -1;
			}
			return -1;
		case 1:
			if ((active1 & 0x10000000u) != 0)
			{
				if (jjmatchedPos == 0)
				{
					jjmatchedKind = 93;
					jjmatchedPos = 0;
				}
				return -1;
			}
			return -1;
		default:
			return -1;
		}
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		169, 98, 98, 103, 98, 105, 166, 124, 102, 141,
		173, 189, 101, 165, 111, 197, 100, 101, 144, 176,
		189, 101, 99, 106, 191, 0, 101, 197, 103, 165,
		106, 102, 109, 112, 177, 182, 118, 133, 148, 135,
		136, 103, 103, 134, 101, 103, 103, 105, 100, 98,
		124
	})]
	private int jjMoveNfa_3(int startState, int curPos)
	{
		int num = 0;
		jjnewStateCnt = 3;
		int num2 = 1;
		jjstateSet[0] = startState;
		int num3 = int.MaxValue;
		while (true)
		{
			int num4 = jjround + 1;
			GeneratedJavaParserTokenManager generatedJavaParserTokenManager = this;
			int num5 = num4;
			generatedJavaParserTokenManager.jjround = num4;
			if (num5 == int.MaxValue)
			{
				ReInitRounds();
			}
			if (curChar < 64)
			{
				_ = 1L << curChar;
				do
				{
					int[] array = jjstateSet;
					num2 += -1;
					switch (array[num2])
					{
					case 0:
						if (num3 > 93)
						{
							num3 = 93;
						}
						break;
					case 1:
						if (curChar == 34 && num3 > 93)
						{
							num3 = 93;
						}
						break;
					}
				}
				while (num2 != num);
			}
			else if (curChar < 128)
			{
				_ = 1L << (curChar & 0x3F);
				do
				{
					int[] array2 = jjstateSet;
					num2 += -1;
					switch (array2[num2])
					{
					case 0:
						if (num3 > 93)
						{
							num3 = 93;
						}
						if (curChar == 92)
						{
							int[] array3 = jjstateSet;
							num4 = jjnewStateCnt;
							generatedJavaParserTokenManager = this;
							int num6 = num4;
							generatedJavaParserTokenManager.jjnewStateCnt = num4 + 1;
							array3[num6] = 1;
						}
						break;
					case 2:
						if (num3 > 93)
						{
							num3 = 93;
						}
						break;
					}
				}
				while (num2 != num);
			}
			else
			{
				int num7 = curChar >> 8;
				int num8 = num7 >> 6;
				long num9 = 1L << (num7 & 0x3F);
				int num10 = (curChar & 0xFF) >> 6;
				long num11 = 1L << (curChar & 0x3F);
				do
				{
					int[] array4 = jjstateSet;
					num2 += -1;
					if (array4[num2] == 0)
					{
						if (jjCanMove_1(num7, num8, num10, num9, num11) && num3 > 93)
						{
							num3 = 93;
						}
					}
					else if (num8 != 0 && num9 != 0 && num10 != 0 && num11 != 0)
					{
					}
				}
				while (num2 != num);
			}
			if (num3 != int.MaxValue)
			{
				jjmatchedKind = num3;
				jjmatchedPos = curPos;
				num3 = int.MaxValue;
			}
			curPos++;
			num2 = jjnewStateCnt;
			jjnewStateCnt = num;
			num = 3 - jjnewStateCnt;
			if (num2 == num)
			{
				return curPos;
			}
			try
			{
				curChar = input_stream.readChar();
			}
			catch (IOException)
			{
				break;
			}
		}
		
		return curPos;
	}

	
	
	
	private int jjMoveStringLiteralDfa1_3(long active1)
	{
		try
		{
			curChar = input_stream.readChar();
		}
		catch (IOException)
		{
			goto IL_0019;
		}
		if (curChar == 34)
		{
			return jjMoveStringLiteralDfa2_3(active1, 268435456L);
		}
		return jjStartNfa_3(0, 0L, active1);
		IL_0019:
		
		jjStopStringLiteralDfa_3(0, 0L, active1);
		return 1;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		169, 78, 106, 107, 220, 226, 61, 97, 107, 130,
		177, 108, 234, 69
	})]
	private int jjMoveStringLiteralDfa2_3(long old1, long active1)
	{
		if ((active1 &= old1) == 0)
		{
			return jjStartNfa_3(0, 0L, old1);
		}
		try
		{
			curChar = input_stream.readChar();
		}
		catch (IOException)
		{
			goto IL_002e;
		}
		if (curChar == 34 && (active1 & 0x10000000u) != 0)
		{
			return jjStopAtPos(2, 92);
		}
		return jjStartNfa_3(1, 0L, active1);
		IL_002e:
		
		jjStopStringLiteralDfa_3(1, 0L, active1);
		return 2;
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	private int jjStartNfa_3(int pos, long active0, long active1)
	{
		int result = jjMoveNfa_3(jjStopStringLiteralDfa_3(pos, active0, active1), pos + 1);
		
		return result;
	}

	
	[LineNumberTable(new byte[]
	{
		169, 220, 109, 114, 108, 108, 109, 109, 109, 109,
		136, 104, 105, 104, 137
	})]
	protected internal virtual Token jjFillToken()
	{
		string text = ___003C_003EjjstrLiteralImages[jjmatchedKind];
		string text2 = ((text != null) ? text : input_stream.getImage());
		int beginLine = input_stream.getBeginLine();
		int beginColumn = input_stream.getBeginColumn();
		int endLine = input_stream.getEndLine();
		int endColumn = input_stream.getEndColumn();
		Token token = Token.newToken(jjmatchedKind);
		token.kind = jjmatchedKind;
		token.image = text2;
		token.beginLine = beginLine;
		token.endLine = endLine;
		token.beginColumn = beginColumn;
		token.endColumn = endColumn;
		return token;
	}

	
	
	[LineNumberTable(new byte[]
	{
		39, 109, 104, 163, 112, 114, 151, 104, 178, 104,
		172, 109, 103, 108, 133
	})]
	private void CommonTokenAction(Token token)
	{
		do
		{
			tokenWorkStack.push(token);
			token = token.specialToken;
		}
		while (token != null);
		while (!tokenWorkStack.empty())
		{
			token = (Token)tokenWorkStack.pop();
			Token token2 = token;
			JavaToken.___003Cclinit_003E();
			token2.javaToken = new JavaToken(token, tokens);
			if (storeTokens)
			{
				tokens.add(token.javaToken);
			}
			if (homeToken == null)
			{
				homeToken = token.javaToken;
			}
			if (TokenTypes.isComment(token.kind))
			{
				Comment comment = GeneratedJavaParserTokenManagerBase.createCommentFromToken(token);
				commentsCollection.addComment(comment);
			}
		}
	}

	
	[LineNumberTable(new byte[]
	{
		160, 158, 191, 161, 136, 139, 103, 143, 143, 104,
		150, 147, 107, 147, 107, 154, 140, 140, 104, 147,
		104, 151, 140, 104, 151, 104, 150, 104, 151, 104,
		150, 140, 104, 154, 104, 150, 107, 154, 140, 140,
		140, 140, 107, 147, 147, 147, 147, 147, 151, 150,
		150, 150, 150, 147, 150, 144, 154, 150, 150, 154,
		147, 150, 144, 143, 140, 107, 154, 140, 140
	})]
	private int jjMoveStringLiteralDfa0_0()
	{
		switch (curChar)
		{
		case 10:
		{
			int result50 = jjStopAtPos(0, 3);
			
			return result50;
		}
		case 13:
		{
			jjmatchedKind = 4;
			int result49 = jjMoveStringLiteralDfa1_0(4L, 0L, 0L);
			
			return result49;
		}
		case 26:
		{
			int result48 = jjStopAtPos(0, 147);
			
			return result48;
		}
		case 33:
		{
			jjmatchedKind = 111;
			int result47 = jjMoveStringLiteralDfa1_0(0L, 36028797018963968L, 0L);
			
			return result47;
		}
		case 34:
		{
			int result46 = jjMoveStringLiteralDfa1_0(0L, 134217728L, 0L);
			
			return result46;
		}
		case 37:
		{
			jjmatchedKind = 131;
			int result45 = jjMoveStringLiteralDfa1_0(0L, 0L, 4096L);
			
			return result45;
		}
		case 38:
		{
			jjmatchedKind = 128;
			int result44 = jjMoveStringLiteralDfa1_0(0L, 72057594037927936L, 512L);
			
			return result44;
		}
		case 40:
		{
			int result43 = jjStopAtPos(0, 97);
			
			return result43;
		}
		case 41:
		{
			int result42 = jjStopAtPos(0, 98);
			
			return result42;
		}
		case 42:
		{
			jjmatchedKind = 126;
			int result41 = jjMoveStringLiteralDfa1_0(0L, 0L, 128L);
			
			return result41;
		}
		case 43:
		{
			jjmatchedKind = 124;
			int result40 = jjMoveStringLiteralDfa1_0(0L, 288230376151711744L, 32L);
			
			return result40;
		}
		case 44:
		{
			int result39 = jjStopAtPos(0, 104);
			
			return result39;
		}
		case 45:
		{
			jjmatchedKind = 125;
			int result38 = jjMoveStringLiteralDfa1_0(0L, 578712552117108736L, 64L);
			
			return result38;
		}
		case 46:
		{
			jjmatchedKind = 105;
			int result37 = jjMoveStringLiteralDfa1_0(0L, 4398046511104L, 0L);
			
			return result37;
		}
		case 47:
		{
			jjmatchedKind = 127;
			int result36 = jjMoveStringLiteralDfa1_0(128L, 0L, 256L);
			
			return result36;
		}
		case 58:
		{
			jjmatchedKind = 114;
			int result35 = jjMoveStringLiteralDfa1_0(0L, 17592186044416L, 0L);
			
			return result35;
		}
		case 59:
		{
			int result34 = jjStopAtPos(0, 103);
			
			return result34;
		}
		case 60:
		{
			jjmatchedKind = 110;
			int result33 = jjMoveStringLiteralDfa1_0(0L, 18014398509481984L, 8208L);
			
			return result33;
		}
		case 61:
		{
			jjmatchedKind = 109;
			int result32 = jjMoveStringLiteralDfa1_0(0L, 4503599627370496L, 0L);
			
			return result32;
		}
		case 62:
		{
			jjmatchedKind = 146;
			int result31 = jjMoveStringLiteralDfa1_0(0L, 9007199254740992L, 245760L);
			
			return result31;
		}
		case 63:
		{
			int result30 = jjStopAtPos(0, 113);
			
			return result30;
		}
		case 64:
		{
			int result29 = jjStopAtPos(0, 107);
			
			return result29;
		}
		case 91:
		{
			int result28 = jjStopAtPos(0, 101);
			
			return result28;
		}
		case 93:
		{
			int result27 = jjStopAtPos(0, 102);
			
			return result27;
		}
		case 94:
		{
			jjmatchedKind = 130;
			int result26 = jjMoveStringLiteralDfa1_0(0L, 0L, 2048L);
			
			return result26;
		}
		case 97:
		{
			int result25 = jjMoveStringLiteralDfa1_0(6144L, 0L, 0L);
			
			return result25;
		}
		case 98:
		{
			int result24 = jjMoveStringLiteralDfa1_0(57344L, 0L, 0L);
			
			return result24;
		}
		case 99:
		{
			int result23 = jjMoveStringLiteralDfa1_0(4128768L, 0L, 0L);
			
			return result23;
		}
		case 100:
		{
			int result22 = jjMoveStringLiteralDfa1_0(29360128L, 0L, 0L);
			
			return result22;
		}
		case 101:
		{
			int result21 = jjMoveStringLiteralDfa1_0(234881024L, 512L, 0L);
			
			return result21;
		}
		case 102:
		{
			int result20 = jjMoveStringLiteralDfa1_0(8321499136L, 0L, 0L);
			
			return result20;
		}
		case 103:
		{
			int result19 = jjMoveStringLiteralDfa1_0(8589934592L, 0L, 0L);
			
			return result19;
		}
		case 105:
		{
			int result18 = jjMoveStringLiteralDfa1_0(1082331758592L, 0L, 0L);
			
			return result18;
		}
		case 108:
		{
			int result17 = jjMoveStringLiteralDfa1_0(1099511627776L, 0L, 0L);
			
			return result17;
		}
		case 109:
		{
			int result16 = jjMoveStringLiteralDfa1_0(0L, 256L, 0L);
			
			return result16;
		}
		case 110:
		{
			int result15 = jjMoveStringLiteralDfa1_0(15393162788864L, 0L, 0L);
			
			return result15;
		}
		case 111:
		{
			int result14 = jjMoveStringLiteralDfa1_0(0L, 96L, 0L);
			
			return result14;
		}
		case 112:
		{
			int result13 = jjMoveStringLiteralDfa1_0(263882790666240L, 1024L, 0L);
			
			return result13;
		}
		case 114:
		{
			int result12 = jjMoveStringLiteralDfa1_0(844424930131968L, 4L, 0L);
			
			return result12;
		}
		case 115:
		{
			int result11 = jjMoveStringLiteralDfa1_0(70931694131085312L, 0L, 0L);
			
			return result11;
		}
		case 116:
		{
			int result10 = jjMoveStringLiteralDfa1_0(4539628424389459968L, 2056L, 0L);
			
			return result10;
		}
		case 117:
		{
			int result9 = jjMoveStringLiteralDfa1_0(0L, 128L, 0L);
			
			return result9;
		}
		case 118:
		{
			int result8 = jjMoveStringLiteralDfa1_0(-4611686018427387904L, 0L, 0L);
			
			return result8;
		}
		case 119:
		{
			int result7 = jjMoveStringLiteralDfa1_0(0L, 17L, 0L);
			
			return result7;
		}
		case 121:
		{
			int result6 = jjMoveStringLiteralDfa1_0(0L, 2L, 0L);
			
			return result6;
		}
		case 123:
		{
			int result5 = jjStopAtPos(0, 99);
			
			return result5;
		}
		case 124:
		{
			jjmatchedKind = 129;
			int result4 = jjMoveStringLiteralDfa1_0(0L, 144115188075855872L, 1024L);
			
			return result4;
		}
		case 125:
		{
			int result3 = jjStopAtPos(0, 100);
			
			return result3;
		}
		case 126:
		{
			int result2 = jjStopAtPos(0, 112);
			
			return result2;
		}
		default:
		{
			int result = jjMoveNfa_0(0, 0);
			
			return result;
		}
		}
	}

	
	
	private int jjMoveStringLiteralDfa0_1()
	{
		if (curChar == 42)
		{
			int result = jjMoveStringLiteralDfa1_1(256L);
			
			return result;
		}
		return 1;
	}

	
	
	private int jjMoveStringLiteralDfa0_2()
	{
		if (curChar == 42)
		{
			int result = jjMoveStringLiteralDfa1_2(512L);
			
			return result;
		}
		return 1;
	}

	
	
	private int jjMoveStringLiteralDfa0_3()
	{
		if (curChar == 34)
		{
			int result = jjMoveStringLiteralDfa1_3(268435456L);
			
			return result;
		}
		int result2 = jjMoveNfa_3(0, 0);
		
		return result2;
	}

	
	
	[LineNumberTable(new byte[]
	{
		171, 153, 191, 14, 116, 115, 184, 119, 118, 107,
		107, 108, 130, 119, 118, 107, 107, 108, 194
	})]
	internal virtual void TokenLexicalActions(Token matchedToken)
	{
		switch (jjmatchedKind)
		{
		case 65:
			image.append(___003C_003EjjstrLiteralImages[65]);
			lengthOfMatch = java.lang.String.instancehelper_length(___003C_003EjjstrLiteralImages[65]);
			if (!yieldSupported)
			{
				matchedToken.kind = 94;
			}
			break;
		case 144:
			image.append(___003C_003EjjstrLiteralImages[144]);
			lengthOfMatch = java.lang.String.instancehelper_length(___003C_003EjjstrLiteralImages[144]);
			matchedToken.kind = 146;
			matchedToken.realKind = 144;
			input_stream.backup(2);
			break;
		case 145:
			image.append(___003C_003EjjstrLiteralImages[145]);
			lengthOfMatch = java.lang.String.instancehelper_length(___003C_003EjjstrLiteralImages[145]);
			matchedToken.kind = 146;
			matchedToken.realKind = 145;
			input_stream.backup(1);
			break;
		}
	}

	
	internal virtual void SkipLexicalActions(Token matchedToken)
	{
		_ = jjmatchedKind;
	}

	
	
	internal virtual void MoreLexicalActions()
	{
		int num = jjimageLen;
		int num2 = jjmatchedPos + 1;
		lengthOfMatch = num2;
		jjimageLen = num + num2;
		if (jjmatchedKind == 6)
		{
			image.append(input_stream.getSuffix(jjimageLen));
			jjimageLen = 0;
			input_stream.backup(1);
		}
	}

	
	
	
	public virtual void SwitchTo(int lexState)
	{
		if (lexState >= 4 || lexState < 0)
		{
			string message = new StringBuilder().append("Error: Ignoring invalid lexical state : ").append(lexState).append(". State unchanged.")
				.ToString();
			
			throw new TokenMgrException(message, 2);
		}
		curLexState = lexState;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		171, 211, 232, 147, 235, 107, 139, 139, 231, 171,
		51, 103, 231, 161, 39, 112, 112, 107, 236, 159,
		179, 103, 105
	})]
	public GeneratedJavaParserTokenManager(SimpleCharStream stream, int lexState)
	{
		tokens = new ArrayList();
		commentsCollection = new CommentsCollection();
		tokenWorkStack = new Stack();
		yieldSupported = false;
		curLexState = 0;
		defaultLexState = 0;
		jjrounds = new int[152];
		jjstateSet = new int[304];
		jjimage = new StringBuilder();
		image = jjimage;
		ReInit(stream);
		SwitchTo(lexState);
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual void ReInit(SimpleCharStream stream, int lexState)
	{
		ReInit(stream);
		SwitchTo(lexState);
	}

	[LineNumberTable(new byte[]
	{
		163,
		150,
		191,
		7,
		191,
		0,
		191,
		4,
		191,
		14,
		191,
		0,
		191,
		7,
		191,
		1,
		191,
		0,
		191,
		25,
		191,
		14,
		191,
		7,
		191,
		21,
		191,
		4,
		191,
		25,
		191,
		21,
		191,
		25,
		191,
		21,
		191,
		28,
		191,
		28,
		191,
		28,
		191,
		28,
		191,
		22,
		191,
		19,
		191,
		11,
		191,
		28,
		191,
		18,
		191,
		22,
		191,
		21,
		191,
		25,
		191,
		28,
		191,
		22,
		191,
		18,
		191,
		25,
		191,
		25,
		191,
		0,
		191,
		28,
		191,
		21,
		191,
		18,
		191,
		21,
		191,
		25,
		191,
		7,
		191,
		22,
		191,
		21,
		191,
		7,
		191,
		7,
		191,
		11,
		191,
		28,
		191,
		21,
		191,
		28,
		191,
		28,
		191,
		28,
		191,
		21,
		191,
		14,
		191,
		11,
		191,
		19,
		191,
		22,
		191,
		21,
		191,
		28,
		191,
		14,
		191,
		21,
		191,
		4,
		191,
		28,
		191,
		21,
		191,
		22,
		191,
		25,
		191,
		21,
		191,
		28,
		191,
		28,
		191,
		28,
		191,
		25,
		191,
		22,
		191,
		22,
		191,
		18,
		191,
		22,
		191,
		21,
		191,
		28,
		191,
		25,
		191,
		21,
		191,
		14,
		191,
		25,
		191,
		7,
		191,
		28,
		191,
		21,
		191,
		28,
		191,
		22,
		191,
		21,
		191,
		21,
		191,
		21,
		191,
		21,
		191,
		21,
		191,
		19,
		191,
		21,
		byte.MaxValue,
		28,
		165,
		14,
		byte.MaxValue,
		164,
		155,
		117,
		byte.MaxValue,
		163,
		218,
		162,
		19,
		byte.MaxValue,
		12,
		72,
		byte.MaxValue,
		162,
		199,
		72,
		191,
		10,
		190,
		190
	})]
	static GeneratedJavaParserTokenManager()
	{
		jjbitVec0 = new long[4] { 0L, 0L, 4294967328L, 0L };
		jjbitVec1 = new long[4] { 0L, 0L, 1L, 0L };
		jjbitVec2 = new long[4] { 16384L, 0L, 0L, 0L };
		jjbitVec3 = new long[4] { 144036023255039L, 6442450944L, 0L, 0L };
		jjbitVec4 = new long[4] { 1L, 0L, 0L, 0L };
		jjbitVec5 = new long[4] { 0L, 0L, 0L, -9223372036854775808L };
		jjbitVec6 = new long[4] { -2L, -1L, -1L, -1L };
		jjbitVec8 = new long[4] { 0L, 0L, -1L, -1L };
		jjbitVec9 = new long[4] { -4503598551400446L, -8193L, -17388175097857L, 1297036696969281535L };
		jjbitVec10 = new long[4] { 0L, 0L, 297242231151001600L, -36028797027352577L };
		jjbitVec11 = new long[4] { -1L, -1L, -1L, 88094074470339L };
		jjbitVec12 = new long[4] { 0L, -4837147474772623360L, -17179879616L, -18014398509481985L };
		jjbitVec13 = new long[4] { -1L, -1L, -1021L, -1L };
		jjbitVec14 = new long[4] { -281474976710657L, -8547991553L, 33023L, 1979120929931264L };
		jjbitVec15 = new long[4] { -4294965248L, -351843720886273L, -1L, -7205547885240254465L };
		jjbitVec16 = new long[4] { 281474976514048L, -8192L, 563224831328255L, 301749971126844416L };
		jjbitVec17 = new long[4] { 1168302407679L, 8791831609343L, 4602678814877679616L, 0L };
		jjbitVec18 = new long[4] { 2594073385365405680L, -562932790263808L, 2577745637692514273L, 1733604397398638592L };
		jjbitVec19 = new long[4] { 247132830528276448L, 7881300924956672L, 2589004636761079776L, 144678150914244608L };
		jjbitVec20 = new long[4] { 2589004636760940512L, 562965791113216L, 288167810662516712L, 144115188075921408L };
		jjbitVec21 = new long[4] { 2594071186342010848L, 13002342400L, 2589567586714640353L, 1688863818907648L };
		jjbitVec22 = new long[4] { 2882303761516978144L, -288230361111969792L, 3457638613854978016L, 127L };
		jjbitVec23 = new long[4] { -9219431387180826626L, 127L, 2309762420256548246L, 4026531935L };
		jjbitVec24 = new long[4] { 1L, 35184372088575L, 7936L, 0L };
		jjbitVec25 = new long[4] { -9223363240761753601L, -8514196127940608L, -4294950909L, -576460752303480641L };
		jjbitVec26 = new long[4] { -1L, -3263218177L, 9168765891372858879L, -8388803L };
		jjbitVec27 = new long[4] { -12713985L, 134217727L, -4294901761L, 4557642822898941951L };
		jjbitVec28 = new long[4] { -1L, -105553116266497L, -4160749570L, 144053615424700415L };
		jjbitVec29 = new long[4] { 1125895612129279L, 527761286627327L, 4503599627370495L, 411041792L };
		jjbitVec30 = new long[4] { -4294967296L, 72057594037927935L, -274877906944097L, 18014398509481983L };
		jjbitVec31 = new long[4] { 2147483647L, 8796093022142464L, -263882790666241L, 1023L };
		jjbitVec32 = new long[4] { -4286578689L, 2097151L, 549755813888L, 0L };
		jjbitVec33 = new long[4] { 4503599627370464L, 4064L, -288019261329244168L, 274877906943L };
		jjbitVec34 = new long[4] { 68719476735L, 4611686018360336384L, 511L, 28110114275721216L };
		jjbitVec35 = new long[4] { -1L, -1L, -1L, 0L };
		jjbitVec36 = new long[4] { -3233808385L, 4611686017001275199L, 6908521828386340863L, 2295745090394464220L };
		jjbitVec37 = new long[4] { -9223372036854775808L, -9222809086900305919L, -3758161920L, 0L };
		jjbitVec38 = new long[4] { -864764451093480316L, -4294949920L, 511L, 0L };
		jjbitVec39 = new long[4] { -140737488355329L, -2147483649L, -1L, 3509778554814463L };
		jjbitVec40 = new long[4] { -245465970900993L, 141836999983103L, 9187201948305063935L, 2139062143L };
		jjbitVec41 = new long[4] { 140737488355328L, 0L, 0L, 0L };
		jjbitVec42 = new long[4] { 2251241253188403424L, -2L, -4823449601L, -576460752303423489L };
		jjbitVec43 = new long[4] { -422212465066016L, -1L, 576460748008488959L, -281474976710656L };
		jjbitVec44 = new long[4] { -1L, -1L, 18014398509481983L, 0L };
		jjbitVec45 = new long[4] { -1L, -1L, -1L, 8796093022207L };
		jjbitVec46 = new long[4] { -1L, -1L, 8191L, 4611686018427322368L };
		jjbitVec47 = new long[4] { 13198434443263L, -9223231299366420481L, -3221225473L, 281474976710655L };
		jjbitVec48 = new long[4] { -12893290496L, -1L, 71916856549571071L, -36028797018963968L };
		jjbitVec49 = new long[4] { 72057628397664187L, 4503599627370495L, 4503599627370492L, 2953235455648202752L };
		jjbitVec50 = new long[4] { -281200098804736L, 2305843004918726783L, 2251799813685232L, 8935422993945886720L };
		jjbitVec51 = new long[4] { 2199023255551L, -4287426849551675401L, 4495436853045886975L, 7890092085477381L };
		jjbitVec52 = new long[4] { -141291530846594L, -281200233021441L, -1L, 34359738367L };
		jjbitVec53 = new long[4] { -1L, -1L, -281406257233921L, 1152921504606845055L };
		jjbitVec54 = new long[4] { -1L, -211106232532993L, -1L, 67108863L };
		jjbitVec55 = new long[4] { 6881498030004502655L, -37L, 1125899906842623L, -524288L };
		jjbitVec56 = new long[4] { 4611686018427387903L, -65536L, -196609L, 2305561534236983551L };
		jjbitVec57 = new long[4] { 6755399441055744L, -9286475208138752L, -1L, 2305843009213693951L };
		jjbitVec58 = new long[4] { -8646911293141286896L, -274743689218L, 9223372036854775807L, 425688104188L };
		jjbitVec59 = new long[4] { 0L, 0L, 297277419818057727L, -36028797027352577L };
		jjbitVec60 = new long[4] { -1L, -4836865999795912705L, -17179879616L, -18014398509481985L };
		jjbitVec61 = new long[4] { -1L, -1L, -773L, -1L };
		jjbitVec62 = new long[4] { -281474976710657L, -8547991553L, -4611686018427485953L, 1979120929931446L };
		jjbitVec63 = new long[4] { -3892377537L, -65970697666561L, -1L, -6917531227739127809L };
		jjbitVec64 = new long[4] { -32768L, -6145L, 1125899906842623L, 306244774661193727L };
		jjbitVec65 = new long[4] { 70368744177663L, 8792066490367L, 4602678814877679616L, -1048576L };
		jjbitVec66 = new long[4] { -1L, -281681135140865L, -881018876128026641L, 1733885649045453215L };
		jjbitVec67 = new long[4] { -3211631683292264466L, 18014125208779143L, -869759877059461138L, -143270973599040577L };
		jjbitVec68 = new long[4] { -869759877059600402L, 844217442122143L, -4323518207764871188L, 144396388183129543L };
		jjbitVec69 = new long[4] { -2017614832085377041L, 281264647060959L, -869196927105900561L, 1970115463626207L };
		jjbitVec70 = new long[4] { -139281L, -287949109465154081L, 3457638613854978028L, 3658904103781503L };
		jjbitVec71 = new long[4] { -8646911284551352322L, 67076095L, 4323434403644581270L, 4093591391L };
		jjbitVec72 = new long[4] { -4422530440275951615L, -527765581332737L, 2305843009196916703L, 64L };
		jjbitVec73 = new long[4] { -1L, -64513L, -3221225473L, -576460752303480641L };
		jjbitVec74 = new long[4] { -12713985L, 3892314111L, -4294901761L, 4557642822898941951L };
		jjbitVec75 = new long[4] { 9007194961862655L, 3905461007941631L, -1L, 4394700505087L };
		jjbitVec76 = new long[4] { -4227893248L, 72057594037927935L, -272678883688449L, 18014398509481983L };
		jjbitVec77 = new long[4] { 1152657619668697087L, 8796093022207936L, -263882790666241L, 67044351L };
		jjbitVec78 = new long[4] { -4026531841L, -6917529029788565505L, 4611405093273535487L, 0L };
		jjbitVec79 = new long[4] { -1L, 4494803601395711L, -1L, 4503599627370495L };
		jjbitVec80 = new long[4] { 72057594037927935L, 4611686018427380735L, 511L, 288230376151121920L };
		jjbitVec81 = new long[4] { -1L, -1L, -1L, -288230376151711745L };
		jjbitVec82 = new long[4] { -9223235697412868096L, -9222527753657516031L, -3758161920L, 562821641207808L };
		jjbitVec83 = new long[4] { -140737488355329L, -2147483649L, -1L, 4494940973301759L };
		jjbitVec84 = new long[4] { -245465970900993L, -9223230199854792705L, 9187201948305063935L, -2155905153L };
		jjbitVec85 = new long[4] { 2251518330118602976L, -2L, -4722786305L, -576460752303423489L };
		jjbitVec86 = new long[4] { 17592185987071L, -4615908143078047745L, -1L, 1125899906842623L };
		jjbitVec87 = new long[4] { 72058693549555711L, 4503599627370495L, -1L, 2954361351327121471L };
		jjbitVec88 = new long[4] { -211106232532993L, 2305843004919775231L, -1L, 9223372032626884609L };
		jjbitVec89 = new long[4] { 36028797018963967L, -252201583360655361L, -1L, 35184368733388807L };
		jjbitVec90 = new long[4] { -141291530846594L, -281200233021441L, -1L, 288010473826156543L };
		jjbitVec91 = new long[4] { 6881498031078244479L, -37L, 1125899906842623L, -524288L };
		jjbitVec92 = new long[4] { 7036870122864639L, -9286475208138752L, -1L, -6917529027641081857L };
		jjbitVec93 = new long[4] { -8646911293074243568L, -274743689218L, 9223372036854775807L, 1008806742219095292L };
		___003C_003EjjstrLiteralImages = new string[148]
		{
			"", null, null, null, null, null, null, null, null, null,
			null, "abstract", "assert", "boolean", "break", "byte", "case", "catch", "char", "class",
			"const", "continue", "default", "do", "double", "else", "enum", "extends", "false", "final",
			"finally", "float", "for", "goto", "if", "implements", "import", "instanceof", "int", "interface",
			"long", "native", "new", "null", "package", "private", "protected", "public", "record", "return",
			"short", "static", "strictfp", "super", "switch", "synchronized", "this", "throw", "throws", "transient",
			"true", "try", "void", "volatile", "while", "yield", "requires", "to", "with", "open",
			"opens", "uses", "module", "exports", "provides", "transitive", null, null, null, null,
			null, null, null, null, null, null, null, null, null, null,
			null, null, null, null, null, null, null, "(", ")", "{",
			"}", "[", "]", ";", ",", ".", "...", "@", "::", "=",
			"<", "!", "~", "?", ":", "->", "==", ">=", "<=", "!=",
			"&&", "||", "++", "--", "+", "-", "*", "/", "&", "|",
			"^", "%", "<<", "+=", "-=", "*=", "/=", "&=", "|=", "^=",
			"%=", "<<=", ">>=", ">>>=", ">>>", ">>", ">", "\u001a"
		};
		jjnextStates = new int[155]
		{
			39, 40, 47, 48, 73, 74, 75, 76, 77, 78,
			79, 80, 10, 86, 87, 88, 94, 95, 96, 67,
			71, 13, 15, 21, 107, 111, 114, 118, 122, 125,
			129, 142, 3, 4, 5, 10, 8, 10, 11, 7,
			8, 10, 11, 39, 40, 50, 47, 48, 83, 10,
			85, 82, 83, 10, 85, 91, 10, 93, 90, 91,
			10, 93, 97, 100, 10, 98, 99, 100, 10, 103,
			10, 105, 102, 103, 10, 105, 109, 110, 75, 112,
			113, 75, 116, 117, 75, 131, 132, 133, 135, 136,
			137, 140, 141, 10, 144, 145, 146, 147, 150, 151,
			10, 41, 49, 51, 3, 4, 6, 7, 8, 9,
			16, 17, 19, 32, 33, 73, 74, 76, 77, 78,
			79, 81, 82, 83, 84, 86, 87, 89, 90, 91,
			92, 94, 95, 98, 99, 101, 102, 103, 104, 112,
			113, 116, 117, 123, 124, 127, 128, 138, 139, 140,
			141, 148, 149, 150, 151
		};
		___003C_003ElexStateNames = new string[4] { "DEFAULT", "IN_JAVADOC_COMMENT", "IN_MULTI_LINE_COMMENT", "IN_TEXT_BLOCK" };
		___003C_003EjjnewLexState = new int[148]
		{
			-1, -1, -1, -1, -1, -1, 1, 2, 0, 0,
			-1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
			-1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
			-1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
			-1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
			-1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
			-1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
			-1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
			-1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
			-1, 3, 0, -1, -1, -1, -1, -1, -1, -1,
			-1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
			-1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
			-1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
			-1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
			-1, -1, -1, -1, -1, -1, -1, -1
		};
		jjtoToken = new long[3] { -2047L, -7146815489L, 1048575L };
		jjtoSkip = new long[3] { 830L, 0L, 0L };
		jjtoSpecial = new long[3] { 830L, 0L, 0L };
		jjtoMore = new long[3] { 1216L, 671088640L, 0L };
	}
}
