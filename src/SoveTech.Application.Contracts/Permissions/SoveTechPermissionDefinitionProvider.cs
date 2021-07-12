using SoveTech.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace SoveTech.Permissions
{
    public class SoveTechPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(SoveTechPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(SoveTechPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<SoveTechResource>(name);
        }
    }
}
