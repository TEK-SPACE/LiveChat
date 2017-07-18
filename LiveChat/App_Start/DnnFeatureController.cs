using DotNetNuke.Entities.Controllers;
using DotNetNuke.Entities.Modules;

namespace MyDnn.Modules.Support.LiveChat
{
    public class DnnFeatureController : IUpgradeable
    {
        public string UpgradeModule(string version)
        {
            SetUrlFriendly();

            return "Update mydnn support livechat!.";
        }

        private static void SetUrlFriendly()
        {
            HostController.Instance.Update("AUM_DoNotRewriteRegEx", "/signalr", true);
        }
    }
}