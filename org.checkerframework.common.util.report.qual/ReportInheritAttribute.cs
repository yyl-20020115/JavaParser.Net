using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.util.report.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.util.report.qual.$ProxyReportInherit", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.util.report.qual.ReportInherit" })]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class ReportInheritAttribute : AnnotationAttributeBase, ReportInherit
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ReportInheritAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public ReportInheritAttribute()
		: base(ClassLiteral<ReportInherit>.Value)
	{
	}
}
