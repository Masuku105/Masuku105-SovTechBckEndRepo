using SoveTech.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace SoveTech.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class SoveTechPageModel : AbpPageModel
    {
        protected SoveTechPageModel()
        {
            LocalizationResourceType = typeof(SoveTechResource);
        }
    }
}