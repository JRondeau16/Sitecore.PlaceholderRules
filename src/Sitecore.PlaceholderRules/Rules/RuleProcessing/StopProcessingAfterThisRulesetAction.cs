using Sitecore.Rules;

namespace Sitecore.PlaceholderRules.Rules.RuleProcessing
{
    public class StopProcessingAfterThisRulesetAction : RuleContext
    {
        public bool StopProcessingThisRuleset { get; set; }
        public bool StopProcessingAfterThisRuleset { get; set; }
    }
}