using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.util.report.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.util.report.qual.$ProxyReportWrite", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.util.report.qual.ReportWrite" })]
[AttributeUsage(AttributeTargets.Field)]
public sealed class ReportWriteAttribute : AnnotationAttributeBase, ReportWrite
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ReportWriteAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public ReportWriteAttribute()
		: base(ClassLiteral<ReportWrite>.Value)
	{
	}
}
