using Sitecore.Diagnostics;
using Sitecore.Events;
using Community.Foundation.RemoteCacheKick.Events;
using Sitecore.Shell.Framework.Commands;

namespace Community.Foundation.RemoteCacheKick.Commands
{
    public class ClearRemoteCacheCommand : Command
    {
        public override void Execute(CommandContext context)
        {
            // Raise the local event
            Event.RaiseEvent("cache:clear");

            // Add some data to the Event Queue, which will be consumed by other instances and then raised as events on those instances.
            Sitecore.Eventing.EventManager.QueueEvent<RemoteCacheClearEvent>(new RemoteCacheClearEvent());

            Log.Info("RemoteCacheClearHandler - triggered cache:clear and cache:clear:remote", this);
            Sitecore.Context.ClientPage.ClientResponse.Alert("Requested Remote Cache Clear");
        }
    }
}
