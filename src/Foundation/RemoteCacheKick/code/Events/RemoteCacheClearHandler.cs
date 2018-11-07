using Sitecore.Caching;
using Sitecore.Diagnostics;
using Sitecore.Reflection;
using System;

namespace Community.Foundation.RemoteCacheKick.Events
{
    public class RemoteCacheClearHandler
    {
        public void ClearCache(object sender, EventArgs args)
        {
            Assert.ArgumentNotNull(sender, "sender");
            Assert.ArgumentNotNull(args, "args");
            Log.Info("RemoteCacheClearHandler - executing", this);


            ICacheInfo[] allCaches = CacheManager.GetAllCaches();
            for (int i = 0; i < (int)allCaches.Length; i++)
            {
                allCaches[i].Clear();
            }
            TypeUtil.ClearSizeCache();


            Log.Info("RemoteCacheClearHandler - done.", this);
        }
        
    }
}
