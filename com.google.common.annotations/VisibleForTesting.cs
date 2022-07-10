using IKVM.Attributes;
using java.lang.annotation;

namespace com.google.common.annotations;

[Modifiers(Modifiers.Public | Modifiers.Interface | Modifiers.Abstract | Modifiers.Annotation)]
[Implements(new string[] { "java.lang.annotation.Annotation" })]
public interface VisibleForTesting : Annotation
{
}
