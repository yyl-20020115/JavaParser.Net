using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.util.report.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.util.report.qual.$ProxyReportUse", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.util.report.qual.ReportUse" })]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class ReportUseAttribute : AnnotationAttributeBase, ReportUse
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ReportUseAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public ReportUseAttribute()
		: base(ClassLiteral<ReportUse>.Value)
	{
	}
}
