using System.Runtime.CompilerServices;
using com.github.javaparser.ast.comments;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util;

namespace com.github.javaparser.metamodel;

public class CommentMetaModel : NodeMetaModel
{
	public PropertyMetaModel contentPropertyMetaModel;

	
		
	
	internal CommentMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<Comment>.Value, "Comment", "com.github.javaparser.ast.comments", isAbstract: true, hasWildcard: false)
	{
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
	
	protected internal CommentMetaModel(Optional superNodeMetaModel, Class type, string name, string packageName, bool isAbstract, bool hasWildcard)
		: base(superNodeMetaModel, type, name, packageName, isAbstract, hasWildcard)
	{
	}
}
