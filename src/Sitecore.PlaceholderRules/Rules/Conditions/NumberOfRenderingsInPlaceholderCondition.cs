using System;
using System.Linq;
using Sitecore.Diagnostics;
using Sitecore.Rules.Conditions;

namespace Sitecore.PlaceholderRules.Rules.Conditions
{
    public class NumberOfRenderingsInPlaceholderCondition<T> : IntegerComparisonCondition<T> where T : PlaceholderSettingsRuleContext
    {
        protected override bool Execute(T ruleContext)
        {
            var renderings = ruleContext.GetRenderings().ToArray();

            var renderingCount = renderings
                .Count(
                    x =>
                    x.Placeholder.Equals(ruleContext.FullPlaceholderKey ?? ruleContext.PlaceholderKey,
                                            StringComparison.InvariantCultureIgnoreCase));

            var result = Compare(renderingCount);
            Log.Debug($"Found {renderingCount} matching renderings out of {renderings.Length} total. Returning comparison result {result}.");
            return result;
        }
    }
}