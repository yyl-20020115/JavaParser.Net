using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.util.report.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.util.report.qual.$ProxyReportCall", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.util.report.qual.ReportCall" })]
[AttributeUsage(AttributeTargets.Method)]
public sealed class ReportCallAttribute : AnnotationAttributeBase, ReportCall
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ReportCallAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public ReportCallAttribute()
		: base(ClassLiteral<ReportCall>.Value)
	{
	}
}
