using SoveTech.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SoveTech.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class SoveTechController : AbpController
    {
        protected SoveTechController()
        {
            LocalizationResource = typeof(SoveTechResource);
        }
    }
}