using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.util.report.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.util.report.qual.$ProxyReportOverride", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.util.report.qual.ReportOverride" })]
[AttributeUsage(AttributeTargets.Method)]
public sealed class ReportOverrideAttribute : AnnotationAttributeBase, ReportOverride
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ReportOverrideAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public ReportOverrideAttribute()
		: base(ClassLiteral<ReportOverride>.Value)
	{
	}
}
