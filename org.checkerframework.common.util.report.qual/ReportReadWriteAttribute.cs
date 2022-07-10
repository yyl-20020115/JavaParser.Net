using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.util.report.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.util.report.qual.$ProxyReportReadWrite", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.util.report.qual.ReportReadWrite" })]
[AttributeUsage(AttributeTargets.Field)]
public sealed class ReportReadWriteAttribute : AnnotationAttributeBase, ReportReadWrite
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ReportReadWriteAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public ReportReadWriteAttribute()
		: base(ClassLiteral<ReportReadWrite>.Value)
	{
	}
}
