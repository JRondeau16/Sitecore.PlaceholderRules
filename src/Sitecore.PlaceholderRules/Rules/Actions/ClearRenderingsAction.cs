using Sitecore.Rules.Actions;

namespace Sitecore.PlaceholderRules.Rules.Actions
{
    public class ClearRenderingsAction<T> : RuleAction<T> where T : PlaceholderSettingsRuleContext
    {
        public override void Apply(T ruleContext)
        {
            ruleContext.Args.PlaceholderRenderings.Clear();
        }
    }
}
