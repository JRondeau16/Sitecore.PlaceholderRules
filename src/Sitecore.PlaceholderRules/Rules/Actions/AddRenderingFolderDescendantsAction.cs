using System.Linq;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Rules.Actions;

namespace Sitecore.PlaceholderRules.Rules.Actions
{
    public class AddRenderingFolderDescendantsAction<T> : RuleAction<T> where T : PlaceholderSettingsRuleContext
    {
        public string RenderingFolderItemId { get; set; }

        public override void Apply(T ruleContext)
        {
            if (!ID.IsID(RenderingFolderItemId)) return;

            var folder = ruleContext.Args.ContentDatabase.GetItem(RenderingFolderItemId);
            if (folder == null) return;

            var renderings = folder.Axes.GetDescendants().Where(ItemUtil.IsRenderingItem);

            foreach (var rendering in renderings.Where(r => ruleContext.Args.PlaceholderRenderings.All(x => x.ID != r.ID)))
            {
                ruleContext.Args.PlaceholderRenderings.Add(rendering);
            }
        }
    }
}
