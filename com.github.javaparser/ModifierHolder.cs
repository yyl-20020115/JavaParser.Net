using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.utils;
using IKVM.Attributes;
using java.lang;

namespace com.github.javaparser;

internal class ModifierHolder
{
	
		internal NodeList modifiers;

	
		internal NodeList annotations;

	
	internal JavaToken begin;

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	internal ModifierHolder(JavaToken begin, NodeList modifiers, NodeList annotations)
	{
		this.begin = begin;
		this.modifiers = (NodeList)Utils.assertNotNull(modifiers);
		this.annotations = annotations;
	}
}
