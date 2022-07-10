using IKVM.Attributes;

namespace com.github.javaparser.ast.nodeTypes.modifiers;


public interface NodeWithAccessModifiers : NodeWithPublicModifier, NodeWithModifiers, NodeWithPrivateModifier, NodeWithProtectedModifier
{
}
