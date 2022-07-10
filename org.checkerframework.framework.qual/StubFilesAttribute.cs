using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.framework.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.framework.qual.$ProxyStubFiles", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.framework.qual.StubFiles" })]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class StubFilesAttribute : AnnotationAttributeBase, StubFiles
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public StubFilesAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private StubFilesAttribute()
		: base(ClassLiteral<StubFiles>.Value)
	{
	}

	[HideFromJava]
	public StubFilesAttribute(string[] value)
		: this()
	{
		setValue("value", value);
	}

	private string[] value()
	{
		return (string[])getValue("value");
	}

	string[] StubFiles.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
