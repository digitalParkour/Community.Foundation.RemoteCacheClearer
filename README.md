﻿Sitecore - Remote Cache Kick
==============

Summary
--------------
Adds a button to the publish ribbon so users (with access) can clear the remote server caches.

![alt text](https://github.com/digitalParkour/Community.Foundation.RemoteCacheKick/raw/master/screenshots/Button.png "Custom cache clear button in publish ribbon")

Implementation
--------------
A custom remote event is used to broadcast the button click.
An event handler is used to respond to the remote event and clear server cache.

Installation
--------------
Either:
* Install Sitecore package. See [Releases](https://github.com/digitalParkour/Community.Foundation.RemoteCacheKick/releases).
	> To install on CD servers, copy files (config and dlls) to CD servers.
Or:
1. Include this project in your Helix style solution
2. Update NuGet references to match target sitecore version
3. Sync unicorn data or install sitecore package
    > Expects Unicorn 4+ in your solution.
    > If not using Unicorn, disable Foundation.RemoteCacheKick.Serialization.config