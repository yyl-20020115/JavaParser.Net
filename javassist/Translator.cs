using IKVM.Attributes;

namespace javassist;

public interface Translator
{
	[Throws(new string[] { "javassist.NotFoundException", "javassist.CannotCompileException" })]
	virtual void start(ClassPool cp);

	[Throws(new string[] { "javassist.NotFoundException", "javassist.CannotCompileException" })]
	virtual void onLoad(ClassPool cp, string str);
}
