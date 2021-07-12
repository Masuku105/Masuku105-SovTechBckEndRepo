using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace SoveTech.Web
{
    [Dependency(ReplaceServices = true)]
    public class SoveTechBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "SoveTech";
    }
}
