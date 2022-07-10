using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.util.report.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.util.report.qual.$ProxyReportCreation", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.util.report.qual.ReportCreation" })]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class ReportCreationAttribute : AnnotationAttributeBase, ReportCreation
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ReportCreationAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public ReportCreationAttribute()
		: base(ClassLiteral<ReportCreation>.Value)
	{
	}
}
