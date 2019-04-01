using Sitecore.Rules;

namespace Sitecore.PlaceholderRules.Rules
{
    public class EnhancedRuleContext : RuleContext
    {
        public bool StopProcessingThisRuleset { get; set; }
        public bool StopProcessingAfterThisRuleset { get; set; }
    }
}