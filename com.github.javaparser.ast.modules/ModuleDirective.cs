using System.ComponentModel;

using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;

using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.modules;

public abstract class ModuleDirective : Node
{
	
	
	protected internal new static void ___003Cclinit_003E()
	{
	}

	
	
	
	public ModuleDirective(TokenRange tokenRange)
		: base(tokenRange)
	{
		customInitialization();
	}

	
	
	public new virtual ModuleDirectiveMetaModel getMetaModel()
	{
		return JavaParserMetaModel.___003C_003EmoduleDirectiveMetaModel;
	}

	
	
	public new virtual ModuleDirective clone()
	{
		return (ModuleDirective)accept(new CloneVisitor(), null);
	}

	
	
	
	public ModuleDirective()
		: this(null)
	{
	}

	public virtual bool isModuleExportsStmt()
	{
		return false;
	}

	
	
	public virtual ModuleExportsDirective asModuleExportsStmt()
	{
		string s = CodeGenerationUtils.f("%s is not an ModuleExportsDirective", this);
		
		throw new IllegalStateException(s);
	}

	public virtual bool isModuleOpensStmt()
	{
		return false;
	}

	
	
	public virtual ModuleOpensDirective asModuleOpensStmt()
	{
		string s = CodeGenerationUtils.f("%s is not an ModuleOpensDirective", this);
		
		throw new IllegalStateException(s);
	}

	public virtual bool isModuleProvidesStmt()
	{
		return false;
	}

	
	
	public virtual ModuleProvidesDirective asModuleProvidesStmt()
	{
		string s = CodeGenerationUtils.f("%s is not an ModuleProvidesDirective", this);
		
		throw new IllegalStateException(s);
	}

	public virtual bool isModuleRequiresStmt()
	{
		return false;
	}

	
	
	public virtual ModuleRequiresDirective asModuleRequiresStmt()
	{
		string s = CodeGenerationUtils.f("%s is not an ModuleRequiresDirective", this);
		
		throw new IllegalStateException(s);
	}

	public virtual bool isModuleUsesStmt()
	{
		return false;
	}

	
	
	public virtual ModuleUsesDirective asModuleUsesStmt()
	{
		string s = CodeGenerationUtils.f("%s is not an ModuleUsesDirective", this);
		
		throw new IllegalStateException(s);
	}

		
	public virtual void ifModuleExportsStmt(Consumer action)
	{
	}

		
	public virtual void ifModuleOpensStmt(Consumer action)
	{
	}

		
	public virtual void ifModuleProvidesStmt(Consumer action)
	{
	}

		
	public virtual void ifModuleRequiresStmt(Consumer action)
	{
	}

		
	public virtual void ifModuleUsesStmt(Consumer action)
	{
	}

	
		
	public virtual Optional toModuleExportsStmt()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toModuleOpensStmt()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toModuleProvidesStmt()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toModuleRequiresStmt()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	
		
	public virtual Optional toModuleUsesStmt()
	{
		Optional result = Optional.empty();
		
		return result;
	}

	public virtual bool isModuleExportsDirective()
	{
		return false;
	}

	
	
	public virtual ModuleExportsDirective asModuleExportsDirective()
	{
		string s = CodeGenerationUtils.f("%s is not ModuleExportsDirective, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	
		
	public virtual Optional toModuleExportsDirective()
	{
		Optional result = Optional.empty();
		
		return result;
	}

		
	public virtual void ifModuleExportsDirective(Consumer action)
	{
	}

	public virtual bool isModuleOpensDirective()
	{
		return false;
	}

	
	
	public virtual ModuleOpensDirective asModuleOpensDirective()
	{
		string s = CodeGenerationUtils.f("%s is not ModuleOpensDirective, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	
		
	public virtual Optional toModuleOpensDirective()
	{
		Optional result = Optional.empty();
		
		return result;
	}

		
	public virtual void ifModuleOpensDirective(Consumer action)
	{
	}

	public virtual bool isModuleProvidesDirective()
	{
		return false;
	}

	
	
	public virtual ModuleProvidesDirective asModuleProvidesDirective()
	{
		string s = CodeGenerationUtils.f("%s is not ModuleProvidesDirective, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	
		
	public virtual Optional toModuleProvidesDirective()
	{
		Optional result = Optional.empty();
		
		return result;
	}

		
	public virtual void ifModuleProvidesDirective(Consumer action)
	{
	}

	public virtual bool isModuleRequiresDirective()
	{
		return false;
	}

	
	
	public virtual ModuleRequiresDirective asModuleRequiresDirective()
	{
		string s = CodeGenerationUtils.f("%s is not ModuleRequiresDirective, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	
		
	public virtual Optional toModuleRequiresDirective()
	{
		Optional result = Optional.empty();
		
		return result;
	}

		
	public virtual void ifModuleRequiresDirective(Consumer action)
	{
	}

	public virtual bool isModuleUsesDirective()
	{
		return false;
	}

	
	
	public virtual ModuleUsesDirective asModuleUsesDirective()
	{
		string s = CodeGenerationUtils.f("%s is not ModuleUsesDirective, it is %s", this, Object.instancehelper_getClass(this).getSimpleName());
		
		throw new IllegalStateException(s);
	}

	
		
	public virtual Optional toModuleUsesDirective()
	{
		Optional result = Optional.empty();
		
		return result;
	}

		
	public virtual void ifModuleUsesDirective(Consumer action)
	{
	}

	
	
	
	
	public virtual NodeMetaModel _003Cbridge_003EgetMetaModel()
	{
		ModuleDirectiveMetaModel metaModel = getMetaModel();
		
		return metaModel;
	}

	
	
	
	
	public new virtual Node _003Cbridge_003Eclone()
	{
		ModuleDirective result = clone();
		
		return result;
	}

	
	
	
	
	
	public override object _003Cbridge_003Eclone()
	{
		ModuleDirective result = clone();
		
		return result;
	}

	
	static ModuleDirective()
	{
		Node.___003Cclinit_003E();
	}
}
