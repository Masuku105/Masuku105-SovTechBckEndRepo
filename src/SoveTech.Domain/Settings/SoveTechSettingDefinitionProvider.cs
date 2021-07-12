using Volo.Abp.Settings;

namespace SoveTech.Settings
{
    public class SoveTechSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(SoveTechSettings.MySetting1));
        }
    }
}
