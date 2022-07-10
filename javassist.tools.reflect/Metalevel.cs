namespace javassist.tools.reflect;

public interface Metalevel
{
	virtual ClassMetaobject _getClass();

	virtual Metaobject _getMetaobject();

	virtual void _setMetaobject(Metaobject m);
}
