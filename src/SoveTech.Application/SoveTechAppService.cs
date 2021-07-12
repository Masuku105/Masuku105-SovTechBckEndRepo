using System;
using System.Collections.Generic;
using System.Text;
using SoveTech.Localization;
using Volo.Abp.Application.Services;

namespace SoveTech
{
    /* Inherit your application services from this class.
     */
    public abstract class SoveTechAppService : ApplicationService
    {
        protected SoveTechAppService()
        {
            LocalizationResource = typeof(SoveTechResource);
        }
    }
}
