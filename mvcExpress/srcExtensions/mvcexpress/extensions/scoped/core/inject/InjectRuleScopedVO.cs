// Licensed under the MIT license: http://www.opensource.org/licenses/mit-license.php
namespace  mvcexpress.extensions.scoped.core.inject {
using mvcexpress.core.inject.InjectRuleVO;

/**
 * FOR INTERNAL USE ONLY.
 * Value Object to keep injection rules - what have to be injected there.
 * @author Raimundas Banevicius (http://mvcexpress.org/)
 *
 * @version scoped.1.0.beta2
 */
public class InjectRuleScopedVO extends InjectRuleVO {

	/** FOR INTERNAL USE ONLY. Scope name for injection. */
	public var scopeName:String;

	CONFIG::debug
	override public function toString():String {
		return "[InjectRuleVO varName=" + varName + " injectClassAndName=" + injectId + " scopeName=" + scopeName + "]";
	}
}
}