using System.Runtime.CompilerServices;
using com.github.javaparser.ast.comments;
using IKVM.Attributes;
using java.lang;

namespace com.github.javaparser;

public abstract class GeneratedJavaParserTokenManagerBase
{
	internal static Comment createCommentFromToken(Token token)
	{
		string image = token.image;
		if (token.kind == 8)
		{
			JavadocComment.___003Cclinit_003E();
			JavadocComment result = new JavadocComment(tokenRange(token), String.instancehelper_substring(image, 3, String.instancehelper_length(image) - 2));
			
			return result;
		}
		if (token.kind == 9)
		{
			BlockComment.___003Cclinit_003E();
			BlockComment result2 = new BlockComment(tokenRange(token), String.instancehelper_substring(image, 2, String.instancehelper_length(image) - 2));
			
			return result2;
		}
		if (token.kind == 5)
		{
			LineComment.___003Cclinit_003E();
			LineComment result3 = new LineComment(tokenRange(token), String.instancehelper_substring(image, 2));
			
			return result3;
		}
		
		throw new AssertionError("Unexpectedly got passed a non-comment token.");
	}

	
	
	
	private static TokenRange tokenRange(Token token)
	{
		JavaToken javaToken = token.javaToken;
		TokenRange result = new TokenRange(javaToken, javaToken);
		
		return result;
	}

	
	
	internal GeneratedJavaParserTokenManagerBase()
	{
	}
}
