using Sitecore.Rules;
using Sitecore.Rules.Actions;

namespace Sitecore.PlaceholderRules.Rules.RuleProcessing
{
    public class StopProcessingAfterThisRulesetAction<T> : RuleAction<T> where T : EnhancedRuleContext
    {
        public override void Apply(T ruleContext)
        {
            ruleContext.StopProcessingAfterThisRuleset = true;
        }
    }
}