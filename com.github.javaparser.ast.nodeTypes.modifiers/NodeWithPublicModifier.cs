


namespace com.github.javaparser.ast.nodeTypes.modifiers;


public interface NodeWithPublicModifier : NodeWithModifiers
{

	public new static class __DefaultMethods
	{
		public unsafe static bool isPublic(NodeWithPublicModifier P_0)
		{

			return _003Cdefault_003EisPublic(P_0);
		}

		public unsafe static Node setPublic(NodeWithPublicModifier P_0, bool P_1)
		{

			return _003Cdefault_003EsetPublic(P_0, P_1);
		}

		static Node _003Cdefault_003EsetPublic(NodeWithPublicModifier P_0, bool P_1)
		{
			Node result = P_0.setModifier(Modifier.Keyword.___003C_003EPUBLIC, P_1);

			return result;
		}

		static bool _003Cdefault_003EisPublic(NodeWithPublicModifier P_0)
		{
			bool result = P_0.hasModifier(Modifier.Keyword.___003C_003EPUBLIC);

			return result;
		}

	}

	Node setPublic(bool set);
	bool isPublic();
}