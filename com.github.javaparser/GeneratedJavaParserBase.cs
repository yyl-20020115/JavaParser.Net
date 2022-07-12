
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.comments;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.type;
using com.github.javaparser.utils;

using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser;

internal abstract class GeneratedJavaParserBase
{
	
	private sealed class ___003C_003EAnon0 : Consumer
	{
		private readonly GeneratedJavaParserBase arg_00241;

		private readonly Node arg_00242;

		private readonly Node arg_00243;

		internal ___003C_003EAnon0(GeneratedJavaParserBase P_0, Node P_1, Node P_2)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024propagateRangeGrowthOnRight_00240(arg_00242, arg_00243, (Node)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

		internal List problems;

	internal bool storeTokens;

	
	internal abstract void ReInit(Provider provider);

	internal abstract GeneratedJavaParserTokenManager getTokenSource();

	
	
	internal virtual TokenRange tokenRange()
	{
		if (storeTokens)
		{
			TokenRange.___003Cclinit_003E();
			TokenRange result = new TokenRange(token(), token());
			
			return result;
		}
		return null;
	}

	internal abstract JavaToken token();

	
	
	
	internal virtual JavaToken orIfInvalid(JavaToken firstChoice, JavaToken secondChoice)
	{
		if (storeTokens)
		{
			Utils.assertNotNull(firstChoice);
			Utils.assertNotNull(secondChoice);
			if (firstChoice.valid() || secondChoice.invalid())
			{
				return firstChoice;
			}
			return secondChoice;
		}
		return null;
	}

	internal abstract Token getNextToken();

	
	
	
	internal virtual TokenRange range(JavaToken begin, JavaToken end)
	{
		if (storeTokens)
		{
			TokenRange result = new TokenRange(begin, end);
			
			return result;
		}
		return null;
	}

	
	
	
	private string makeMessageForParseException(ParseException exception)
	{
		StringBuilder stringBuilder = new StringBuilder("Parse error. Found ");
		StringBuilder stringBuilder2 = new StringBuilder();
		int num = 0;
		TreeSet treeSet = new TreeSet();
		for (int i = 0; i < (nint)exception.expectedTokenSequences.LongLength; i++)
		{
			if (num < (nint)exception.expectedTokenSequences[i].LongLength)
			{
				num = exception.expectedTokenSequences[i].Length;
			}
			for (int j = 0; j < (nint)exception.expectedTokenSequences[i].LongLength; j++)
			{
				treeSet.add(exception.tokenImage[exception.expectedTokenSequences[i][j]]);
			}
		}
		Iterator iterator = treeSet.iterator();
		while (iterator.hasNext())
		{
			string str = (string)iterator.next();
			stringBuilder2.append(" ").append(str);
		}
		Token next = exception.currentToken.next;
		for (int j = 0; j < num; j++)
		{
			string image = next.image;
			string str2 = ParseException.add_escapes(image);
			if (j != 0)
			{
				stringBuilder.append(" ");
			}
			if (next.kind == 0)
			{
				stringBuilder.append(exception.tokenImage[0]);
				break;
			}
			str2 = new StringBuilder().append("\"").append(str2).append("\"")
				.ToString();
			string text = exception.tokenImage[next.kind];
			if (String.instancehelper_equals(text, str2))
			{
				stringBuilder.append(text);
			}
			else
			{
				stringBuilder.append(" ").append(str2).append(" ")
					.append(text);
			}
			next = next.next;
		}
		if (exception.expectedTokenSequences.Length != 0)
		{
			int j = exception.expectedTokenSequences.Length;
			stringBuilder.append(", expected").append((j != 1) ? " one of " : "").append(stringBuilder2.ToString());
		}
		string result = stringBuilder.ToString();
		
		return result;
	}

	
	internal abstract Token getToken(int index);

	
		
	
	internal virtual NodeList add(NodeList list, Node obj)
	{
		if (list == null)
		{
			list = new NodeList();
		}
		list.add(obj);
		return list;
	}

	
	
	
	internal virtual TokenRange range(Node begin, Node end)
	{
		if (storeTokens)
		{
			TokenRange.___003Cclinit_003E();
			TokenRange result = new TokenRange(((TokenRange)begin.getTokenRange().get()).getBegin(), ((TokenRange)end.getTokenRange().get()).getEnd());
			
			return result;
		}
		return null;
	}

	
	
	
	private void propagateRangeGrowthOnRight(Node node, Node endNode)
	{
		if (storeTokens)
		{
			node.getParentNode().ifPresent(new ___003C_003EAnon0(this, node, endNode));
			node.setTokenRange(range(node, endNode));
		}
	}

	
	
	
	internal virtual Expression generateLambda(Expression ret, Statement lambdaBody)
	{
		if (ret is EnclosedExpr)
		{
			Expression inner = ((EnclosedExpr)ret).getInner();
			SimpleName name = ((NameExpr)inner).getName();
			NodeList list = new NodeList();
			Parameter.___003Cclinit_003E();
			NodeList parameters = add(list, new Parameter((TokenRange)ret.getTokenRange().orElse(null), new NodeList(), new NodeList(), new UnknownType(), isVarArgs: false, new NodeList(), name));
			LambdaExpr.___003Cclinit_003E();
			ret = new LambdaExpr(range(ret, lambdaBody), parameters, lambdaBody, isEnclosingParameters: true);
		}
		else if (ret is NameExpr)
		{
			SimpleName name2 = ((NameExpr)ret).getName();
			NodeList list2 = new NodeList();
			Parameter.___003Cclinit_003E();
			NodeList parameters2 = add(list2, new Parameter((TokenRange)ret.getTokenRange().orElse(null), new NodeList(), new NodeList(), new UnknownType(), isVarArgs: false, new NodeList(), name2));
			LambdaExpr.___003Cclinit_003E();
			ret = new LambdaExpr(range(ret, lambdaBody), parameters2, lambdaBody, isEnclosingParameters: false);
		}
		else if (ret is LambdaExpr)
		{
			((LambdaExpr)ret).setBody(lambdaBody);
			propagateRangeGrowthOnRight(ret, lambdaBody);
		}
		else if (ret is CastExpr)
		{
			CastExpr castExpr = (CastExpr)ret;
			Expression expression = generateLambda(castExpr.getExpression(), lambdaBody);
			castExpr.setExpression(expression);
		}
		else
		{
			addProblem("Failed to parse lambda expression! Please create an issue at https://github.com/javaparser/javaparser/issues");
		}
		return ret;
	}

	
	
	
	internal virtual void addProblem(string message)
	{
		List list = problems;
		Problem.___003Cclinit_003E();
		list.add(new Problem(message, tokenRange(), null));
	}

	
	
	
	internal virtual Name scopeToName(Expression scope)
	{
		if (scope.isNameExpr())
		{
			SimpleName name = scope.asNameExpr().getName();
			Name.___003Cclinit_003E();
			Name result = new Name((TokenRange)name.getTokenRange().orElse(null), null, name.getIdentifier());
			
			return result;
		}
		if (scope.isFieldAccessExpr())
		{
			FieldAccessExpr fieldAccessExpr = scope.asFieldAccessExpr();
			Name.___003Cclinit_003E();
			Name result2 = new Name((TokenRange)fieldAccessExpr.getTokenRange().orElse(null), scopeToName(fieldAccessExpr.getScope()), fieldAccessExpr.getName().getIdentifier());
			
			return result2;
		}
		string s = new StringBuilder().append("Unexpected expression type: ").append(Object.instancehelper_getClass(scope).getSimpleName()).ToString();
		
		throw new IllegalStateException(s);
	}

	
	
	
	
	private void lambda_0024propagateRangeGrowthOnRight_00240(Node node, Node endNode, Node nodeParent)
	{
		if (((TokenRange)node.getTokenRange().get()).getEnd().equals(((TokenRange)nodeParent.getTokenRange().get()).getEnd()))
		{
			propagateRangeGrowthOnRight(nodeParent, endNode);
		}
	}

	
	
	internal GeneratedJavaParserBase()
	{
		problems = new ArrayList();
	}

	
	
	
	internal virtual void reset(Provider provider)
	{
		ReInit(provider);
		problems = new ArrayList();
		getTokenSource().reset();
	}

	
		
	public virtual List getTokens()
	{
		List tokens = getTokenSource().getTokens();
		
		return tokens;
	}

	
	
	internal virtual CommentsCollection getCommentsCollection()
	{
		CommentsCollection commentsCollection = getTokenSource().getCommentsCollection();
		
		return commentsCollection;
	}

	
	
	
	internal virtual TokenRange range(Node begin, JavaToken end)
	{
		if (storeTokens)
		{
			TokenRange.___003Cclinit_003E();
			TokenRange result = new TokenRange(((TokenRange)begin.getTokenRange().get()).getBegin(), end);
			
			return result;
		}
		return null;
	}

	
	
	
	internal virtual TokenRange range(JavaToken begin, Node end)
	{
		if (storeTokens)
		{
			TokenRange.___003Cclinit_003E();
			TokenRange result = new TokenRange(begin, ((TokenRange)end.getTokenRange().get()).getEnd());
			
			return result;
		}
		return null;
	}

	
	
	
	internal virtual JavaToken orIfInvalid(JavaToken firstChoice, Node secondChoice)
	{
		if (storeTokens)
		{
			JavaToken result = orIfInvalid(firstChoice, ((TokenRange)secondChoice.getTokenRange().get()).getBegin());
			
			return result;
		}
		return null;
	}

	
		
	
	internal virtual JavaToken nodeListBegin(NodeList l)
	{
		if (!storeTokens || l.isEmpty())
		{
			return JavaToken.___003C_003EINVALID;
		}
		JavaToken begin = ((TokenRange)l.get(0).getTokenRange().get()).getBegin();
		
		return begin;
	}

	
	
	
	internal virtual void setTokenKind(int newKind)
	{
		token().setKind(newKind);
	}

	
	
	
	internal virtual void setStoreTokens(bool storeTokens)
	{
		int num = ((this.storeTokens = storeTokens) ? 1 : 0);
		getTokenSource().setStoreTokens((byte)num != 0);
	}

	
	
	
	internal virtual TokenRange recover(int recoveryTokenType, ParseException p)
	{
		JavaToken javaToken = null;
		if (p.currentToken != null)
		{
			javaToken = token();
		}
		Token nextToken;
		do
		{
			nextToken = getNextToken();
		}
		while (nextToken.kind != recoveryTokenType && nextToken.kind != 0);
		JavaToken javaToken2 = token();
		TokenRange tokenRange = null;
		if (javaToken != null && javaToken2 != null)
		{
			tokenRange = range(javaToken, javaToken2);
		}
		List list = problems;
		Problem.___003Cclinit_003E();
		list.add(new Problem(makeMessageForParseException(p), tokenRange, p));
		return tokenRange;
	}

	
	
	
	internal virtual TokenRange recoverStatement(int recoveryTokenType, int lBraceType, int rBraceType, ParseException p)
	{
		JavaToken javaToken = null;
		if (p.currentToken != null)
		{
			javaToken = this.token();
		}
		int num = 0;
		Token nextToken;
		TokenRange tokenRange;
		do
		{
			Token token = getToken(1);
			if (token != null && token.kind == rBraceType && num == 0)
			{
				tokenRange = range(javaToken, this.token());
				List list = problems;
				Problem.___003Cclinit_003E();
				list.add(new Problem(makeMessageForParseException(p), tokenRange, p));
				return tokenRange;
			}
			nextToken = getNextToken();
			if (nextToken.kind == lBraceType)
			{
				num++;
			}
			else if (nextToken.kind == rBraceType)
			{
				num += -1;
			}
		}
		while ((nextToken.kind != recoveryTokenType || num != 0) && nextToken.kind != 0);
		JavaToken javaToken2 = this.token();
		tokenRange = null;
		if (javaToken != null && javaToken2 != null)
		{
			tokenRange = range(javaToken, javaToken2);
		}
		List list2 = problems;
		Problem.___003Cclinit_003E();
		list2.add(new Problem(makeMessageForParseException(p), tokenRange, p));
		return tokenRange;
	}

	
		
	internal virtual NodeList emptyNodeList()
	{
		NodeList result = new NodeList();
		
		return result;
	}

	
		
	
	internal virtual NodeList addWhenNotNull(NodeList list, Node obj)
	{
		if (obj == null)
		{
			return list;
		}
		NodeList result = add(list, obj);
		
		return result;
	}

	
		
	
	internal virtual NodeList prepend(NodeList list, Node obj)
	{
		if (list == null)
		{
			list = new NodeList();
		}
		list.addFirst(obj);
		return list;
	}

	
		
	
	internal virtual List add(List list, object obj)
	{
		object obj2 = list;
		if ((List)obj2 == null)
		{
			obj2 = new LinkedList();
		}
		object obj3 = obj2;
		((obj3 == null) ? null : ((obj3 as List) ?? throw new java.lang.IncompatibleClassChangeError())).add(obj);
		object obj4 = obj2;
		return (obj4 == null) ? null : ((obj4 as List) ?? throw new java.lang.IncompatibleClassChangeError());
	}

	
		
	
	internal virtual ArrayCreationExpr juggleArrayCreation(TokenRange range, List levelRanges, Type type, NodeList dimensions, List arrayAnnotations, ArrayInitializerExpr arrayInitializerExpr)
	{
		NodeList nodeList = new NodeList();
		for (int i = 0; i < arrayAnnotations.size(); i++)
		{
			ArrayCreationLevel.___003Cclinit_003E();
			nodeList.add(new ArrayCreationLevel((TokenRange)levelRanges.get(i), (Expression)dimensions.get(i), (NodeList)arrayAnnotations.get(i)));
		}
		ArrayCreationExpr result = new ArrayCreationExpr(range, type, nodeList, arrayInitializerExpr);
		
		return result;
	}

	
		
	
	internal virtual Type juggleArrayType(Type partialType, List additionalBrackets)
	{
		Pair pair = ArrayType.unwrapArrayTypes(partialType);
		Type type = (Type)pair.___003C_003Ea;
		List list = (List)pair.___003C_003Eb;
		Type result = ArrayType.wrapInArrayTypes(type, additionalBrackets, list).clone();
		
		return result;
	}

	
	
	
	internal virtual string unquote(string s)
	{
		string result = String.instancehelper_substring(s, 1, String.instancehelper_length(s) - 1);
		
		return result;
	}

	
	
	
	internal virtual string unTripleQuote(string s)
	{
		int num = 3;
		if (String.instancehelper_charAt(s, num) == '\r')
		{
			num++;
		}
		if (String.instancehelper_charAt(s, num) == '\n')
		{
			num++;
		}
		string result = String.instancehelper_substring(s, num, String.instancehelper_length(s) - 3);
		
		return result;
	}

	
	
	internal virtual void setYieldSupported()
	{
		getTokenSource().setYieldSupported();
	}
}
