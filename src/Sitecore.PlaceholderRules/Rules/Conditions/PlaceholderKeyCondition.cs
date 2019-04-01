using Sitecore.Rules.Conditions;

namespace Sitecore.PlaceholderRules.Rules.Conditions
{
    public class PlaceholderKeyCondition<T> : StringOperatorCondition<T> where T : PlaceholderSettingsRuleContext
    {
        public string Value { get; set; }

        protected override bool Execute(T ruleContext)
        {
            return Compare(ruleContext.PlaceholderKey, Value);
        }
    }
}