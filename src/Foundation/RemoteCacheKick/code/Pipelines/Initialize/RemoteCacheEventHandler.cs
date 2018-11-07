using Community.Foundation.RemoteCacheKick.Events;
using Sitecore.Pipelines;
using System;

namespace Community.Foundation.RemoteCacheKick.Pipelines.Initialize
{
    public class RemoteCacheEventHandler
    {
        public virtual void Initialize(PipelineArgs args)
        {
            var action = new Action<RemoteCacheClearEvent>(RaiseRemoteEvent);
            Sitecore.Eventing.EventManager.Subscribe<RemoteCacheClearEvent>(action);
        }

        private void RaiseRemoteEvent(RemoteCacheClearEvent myEvent)
        {
            Sitecore.Events.Event.RaiseEvent("cache:clear:remote");
        }
    }
}
