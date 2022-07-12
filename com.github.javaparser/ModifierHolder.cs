
using com.github.javaparser.ast;
using com.github.javaparser.utils;

using java.lang;

namespace com.github.javaparser;

internal class ModifierHolder
{
	
		internal NodeList modifiers;

	
		internal NodeList annotations;

	
	internal JavaToken begin;

	
		
	
	internal ModifierHolder(JavaToken begin, NodeList modifiers, NodeList annotations)
	{
		this.begin = begin;
		this.modifiers = (NodeList)Utils.assertNotNull(modifiers);
		this.annotations = annotations;
	}
}
