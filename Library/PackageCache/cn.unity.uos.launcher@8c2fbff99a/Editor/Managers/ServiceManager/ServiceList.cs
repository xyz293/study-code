using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace Unity.UOS.Launcher
{
    public class ServiceList
    {
        public static readonly List<ServiceConfig> List = new List<ServiceConfig>()
        {
            new ServiceConfig()
            {
                name = "cn.unity.uos.cdn",
                displayName = "CDN",
                description = "Asset Management & Delivery",
                gitUrl = "https://e.coding.net/unitychina/uos/UosCdnSDK.git",
                homePage = "https://uos.unity.cn/product/cdn",
                updateNotificationLevel = "NORMAL",
                docUrl = "https://uos.unity.cn/doc/cdn",
                versionUrl = "https://unitychina.coding.net/api/user/unitychina/project/uos/shared-depot/UosCdnSDK/git/blob/master/package.json",
                devPortalPath = "/services/{Settings.AppID}/asset/bucket",
                enableNotification = "您正在开通 UOS CDN 服务， 服务提供免费 100GB 试用流量， 超出后将开启自动计费， 刊例价格如下：按流量计费： 0.15元/GB.",
                launched = true,
            },
            new ServiceConfig()
            {
                name = "cn.unity.uos.multiverse",
                displayName = "Multiverse",
                description = "Game Server Hosting",
                homePage = "https://uos.unity.cn/product/multiverse",
                gitUrl = "https://e.coding.net/unitychina/multiverse/multiverse-sdk.git?path=/unity",
                updateNotificationLevel = "NORMAL",
                docUrl = "https://uos.unity.cn/doc/multiverse",
                versionUrl =
                    "https://unitychina.coding.net/api/user/unitychina/project/multiverse/shared-depot/multiverse-sdk/git/blob/main/unity/package.json",
                devPortalPath = "/services/{Settings.AppID}/multiverse/settings",
                launched = true,
                enableUpload = true,
                uploadNotification = "Build Multiverse Dedicated Server Image"
            },
            new ServiceConfig()
            {
                name = "cn.unity.uos.transport.kcp2k",
                displayName = "Kcp2k protocol",
                description = "Kcp2k protocol",
                gitUrl = "https://e.coding.net/unitychina/uos/Transport.git?path=/kcp2k",
                serviceType = ServiceType.Library.ToString(),
                launched = true,
            },
            new ServiceConfig()
            {
                name = "cn.unity.uos.sync.relay",
                displayName = "Sync - Relay",
                gitUrl = "https://e.coding.net/unitychina/uos/SyncRelaySDK.git",
                description = "Multiplayer Networking Solutions",
                homePage = "https://uos.unity.cn/product/sync",
                docUrl = "https://uos.unity.cn/doc/sync/relay-netcode#prepare",
                versionUrl = "https://unitychina.coding.net/api/user/unitychina/project/uos/shared-depot/SyncRelaySDK/git/blob/master/package.json",
                devPortalPath = "/services/{Settings.AppID}/sync/profiles",
                launched = true,
                dependencies = new []{"cn.unity.uos.transport.kcp2k"},
            },
            new ServiceConfig()
            {
                name = "cn.unity.uos.sync.realtime",
                displayName = "Sync - Realtime",
                description = "Multiplayer Networking Solutions",
                homePage = "https://uos.unity.cn/product/sync",
                docUrl = "https://uos.unity.cn/doc/sync/realtime#prepare",
                devPortalPath = "/services/{Settings.AppID}/sync/profiles",
                launched = true,
                gitUrl = "https://e.coding.net/unitychina/uos/SyncRealtimeSDK.git",
                versionUrl = "https://unitychina.coding.net/api/user/unitychina/project/uos/shared-depot/SyncRealtimeSDK/git/blob/master/package.json",
                dependencies = new []{"cn.unity.uos.transport.kcp2k"},
            },
            new ServiceConfig()
            {
                name = "com.google.external-dependency-manager",
                displayName = "EDM4U",
                description = "EDM4U",
                gitUrl = "https://e.coding.net/unitychina/uos/EDM4U.git",
                serviceType = ServiceType.Library.ToString(),
                launched = true,
            },
            new ServiceConfig()
            {
                name = "com.taptap.sdk.core",
                displayName = "TapTap Core",
                description = "TapTap Core Component",
                gitUrl = "https://e.coding.net/unitychina/uos/TapSDKCore.git",
                serviceType = ServiceType.Library.ToString(),
                launched = true,
            },
            new ServiceConfig()
            {
                name = "com.taptap.sdk.login",
                displayName = "TapTap Login",
                description = "TapTap Login Component",
                gitUrl = "https://e.coding.net/unitychina/uos/TapSDKLogin.git",
                serviceType = ServiceType.Library.ToString(),
                launched = true,
            }, 
            new ServiceConfig()
            {
                name = "cn.unity.uos.passport.core",
                displayName = "Passport Core",
                description = "Passport Core Component",
                gitUrl = "https://e.coding.net/unitychina/uos/PassportCore.git",
                serviceType = ServiceType.Library.ToString(),
                homePage = "https://uos.unity.cn/product/passport",
                docUrl = "https://uos.unity.cn/doc/passport",
                devPortalPath = "/services/{Settings.AppID}/passport",
                launched = true,
            },
            new ServiceConfig()
            {
                name = "cn.unity.uos.passport.login",
                displayName = "Passport Login",
                description = "Passport Player ID and Login Component",
                gitUrl = "https://e.coding.net/unitychina/uos/PassportLoginSDK.git",
                homePage = "https://uos.unity.cn/product/passport",
                docUrl = "https://uos.unity.cn/doc/passport/login#unityRegistry",
                devPortalPath = "/services/{Settings.AppID}/passport",
                dependencies = new []{"cn.unity.uos.passport.core"},
                launched = true,
                versionUrl = "https://unitychina.coding.net/api/user/unitychina/project/uos/shared-depot/PassportLoginSDK/git/blob/main/package.json",
                forceUpdateVersion = "2.0.5",
                sampleUrl = "https://uos.unity.cn/doc/passport/tutorial"
            },
            new ServiceConfig()
            {
                name = "cn.unity.uos.passport.feature",
                displayName = "Passport Feature",
                description = "Passport Game Features",
                gitUrl = "https://e.coding.net/unitychina/uos/PassportFeatureSDK.git",
                homePage = "https://uos.unity.cn/product/passport",
                docUrl = "https://uos.unity.cn/doc/passport",
                devPortalPath = "/services/{Settings.AppID}/passport",
                dependencies = new []{"cn.unity.uos.passport.core"},
                launched = true,
                versionUrl = "https://unitychina.coding.net/api/user/unitychina/project/uos/shared-depot/PassportFeatureSDK/git/blob/main/package.json",
                sampleUrl = "https://uos.unity.cn/doc/passport/tutorial"
            },
            new ServiceConfig()
            {
                name = "cn.unity.uos.func.stateful",
                displayName = "Func - Stateful",
                description = "Logic Server Hosting",
                gitUrl = "https://e.coding.net/unitychina/uos/FuncStatefulSDK.git",
                homePage = "https://uos.unity.cn/product/func",
                docUrl = "https://uos.unity.cn/doc/func/stateful#profile",
                versionUrl = "https://unitychina.coding.net/api/user/unitychina/project/uos/shared-depot/FuncStatefulSDK/git/blob/main/package.json",
                devPortalPath = "/services/{Settings.AppID}/func/profiles",
                launched = true,
            },
            new ServiceConfig()
            {
                name = "cn.unity.uos.func.stateless",
                displayName = "Func - Stateless",
                description = "Cloud Function",
                homePage = "https://uos.unity.cn/product/func",
                docUrl = "https://uos.unity.cn/doc/func/stateless#function",
                devPortalPath = "/services/{Settings.AppID}/func/stateless",
                launched = true,
                gitUrl = "https://e.coding.net/unitychina/uos/FuncStatelessSDK.git",
                versionUrl = "https://unitychina.coding.net/api/user/unitychina/project/uos/shared-depot/FuncStatelessSDK/git/blob/main/package.json"
            },
            new ServiceConfig()
            {
                name = "cn.unity.uos.crud.storage",
                displayName = "CRUD - Storage",
                description = "Various types of databases",
                homePage = "https://uos.unity.cn/product/crud",
                docUrl = "https://uos.unity.cn/doc/crud/storage",
                devPortalPath = "/services/{Settings.AppID}/crud/storage/management",
                launched = true,
            },
            new ServiceConfig()
            {
                name = "cn.unity.uos.cloudsave",
                displayName = "CRUD - Save",
                gitUrl = "https://e.coding.net/unitychina/uos/CloudSaveSDK.git",
                description = "Game Save and Player Data Storage",
                homePage = "https://uos.unity.cn/product/crud",
                docUrl = "https://uos.unity.cn/doc/crud/save",
                versionUrl =
                    "https://unitychina.coding.net/api/user/unitychina/project/uos/shared-depot/CloudSaveSDK/git/blob/master/package.json",
                devPortalPath = "/services/{Settings.AppID}/crud/save",
                launched = true,
                forceUpdateVersion = "2.2.2"
            },
            new ServiceConfig()
            {
                name = "cn.unity.uos.matchmaking.server",
                displayName = "Matchmaking Server",
                description = "To Make Matches Accurately and Fast",
                gitUrl = "https://e.coding.net/unitychina/uos/matchmaking-server-sdk.git?path=/unity",
                updateNotificationLevel = "NORMAL",
                versionUrl = "https://unitychina.coding.net/api/user/unitychina/project/uos/shared-depot/matchmaking-server-sdk/git/blob/master/unity/package.json",
                docUrl = "https://uos.unity.cn/doc/multiverse/match-server-sdk",
                devPortalPath = "/services/{Settings.AppID}/{SubType}/match",
                launched = true,
            },
            new ServiceConfig()
            {
                name = "cn.unity.uos.matchmaking",
                displayName = "Matchmaking Client",
                description = "To Make Matches Accurately and Fast",
                gitUrl = "https://e.coding.net/unitychina/uos/MatchmakingSDK.git",
                updateNotificationLevel = "NORMAL",
                docUrl = "https://uos.unity.cn/doc/multiverse/match-conception",
                versionUrl = "https://unitychina.coding.net/api/user/unitychina/project/uos/shared-depot/MatchmakingSDK/git/blob/master/package.json",
                devPortalPath = "/services/{Settings.AppID}/{SubType}/match",
                launched = true,
            },
            new ServiceConfig()
            {
                name = "cn.unity.uos.config",
                displayName = "Remote Config",
                description = "Update Live Game Content Remotely",
                gitUrl = "https://e.coding.net/unitychina/uos/RemoteConfigSDK.git",
                updateNotificationLevel = "NORMAL",
                docUrl = "https://uos.unity.cn/doc/remote-config#concept",
                versionUrl =
                    "https://unitychina.coding.net/api/user/unitychina/project/uos/shared-depot/RemoteConfigSDK/git/blob/master/package.json",
                devPortalPath = "/services/{Settings.AppID}/config#config",
                launched = true,
                forceUpdateVersion = "1.1.2"
            },
            new ServiceConfig()
            {
                name = "cn.unity.uos.hello",
                displayName = "Hello",
                description = "Real-Time Communication",
                homePage = "https://uos.unity.cn/product/hello",
                launched = true,
                docUrl = "https://uos.unity.cn/doc/hello",
                gitUrl = "https://e.coding.net/unitychina/uos/HelloSdk.git",
                versionUrl =
                    "https://unitychina.coding.net/api/user/unitychina/project/uos/shared-depot/HelloSdk/git/blob/master/package.json",
                devPortalPath = "/services/{Settings.AppID}/hello",
                enableServiceUrl = "https://uos.unity.cn/services/{Settings.AppID}",
            },
            new ServiceConfig()
            {
                name = "cn.unity.uos.push",
                displayName = "Push",
                description = "Real-time notifications and chat service",
                homePage = "https://uos.unity.cn/product/push",
                launched = true,
                docUrl = "https://uos.unity.cn/doc/push",
                gitUrl = "https://e.coding.net/unitychina/uos/PushSDK.git",
                versionUrl =
                    "https://unitychina.coding.net/api/user/unitychina/project/uos/shared-depot/PushSDK/git/blob/master/package.json",
                devPortalPath = "/services/{Settings.AppID}/push",
                dependencies = new []{"cn.unity.uos.transport.kcp2k"},
            },
            new ServiceConfig()
            {
                name = "cn.unity.uos.safe",
                displayName = "Safe",
                description = "Game Package Protection",
                homePage = "https://uos.unity.cn/product/safe",
                launched = true,
                docUrl = "https://uos.unity.cn/doc/safe",
                gitUrl = "https://e.coding.net/unitychina/uos/SafeSDK.git",
                versionUrl =
                    "https://unitychina.coding.net/api/user/unitychina/project/uos/shared-depot/SafeSDK/git/blob/master/package.json",
                devPortalPath = "/services/{Settings.AppID}/safe",
            },
            new ServiceConfig()
            {
                name = "cn.unity.uos.upr",
                displayName = "UPR",
                description = "Performance Optimization",
                homePage = "https://upr.unity.cn",
                launched = true,
            },
            new ServiceConfig()
            {
                name = "cn.unity.uos.device",
                displayName = "Device",
                gitUrl = "https://e.coding.net/unitychina/uos/DeviceSDK.git",
                description = "Real Device Testing",
                homePage = "https://device.unity.cn",
                docUrl = "https://uos.unity.cn/doc/device/client-sdk",
                devPortalPath = "/services/{Settings.AppID}/device/packages",
                versionUrl = "https://unitychina.coding.net/api/user/unitychina/project/uos/shared-depot/DeviceSDK/git/blob/master/package.json",
                launched = true,
            },
            new ServiceConfig()
            {
                name = "cn.unity.uos.stacktrace",
                displayName = "Stacktrace",
                gitUrl = "https://e.coding.net/unitychina/uos/StacktraceSDK.git",
                description = "App Crash Stacktrace Retrieval",
                homePage = "https://uos.unity.cn/product/stacktrace",
                docUrl = "https://uos.unity.cn/doc/stacktrace/client-sdk",
                devPortalPath = "/services/{Settings.AppID}/stacktrace/record",
                versionUrl = "https://unitychina.coding.net/api/user/unitychina/project/uos/shared-depot/StacktraceSDK/git/blob/master/package.json",
                launched = true,
            },
            new ServiceConfig()
            {
                name = "cn.unity.uos.baking",
                displayName = "Baking",
                gitUrl = "https://e.coding.net/unitychina/uos/UOSBaking.git",
                description = "Cloud Distributed Baking",
                homePage = "https://uos.unity.cn/product/baking",
                docUrl = "https://uos.unity.cn/doc/baking/",
                devPortalPath = "/services/{Settings.AppID}/baking",
                versionUrl = "https://unitychina.coding.net/api/user/unitychina/project/uos/shared-depot/UOSBaking/git/blob/main/package.json",
                launched = true,
            },
            new ServiceConfig()
            {
                name = "cn.unity.uos.metrics",
                displayName = "Metrics",
                gitUrl = "https://e.coding.net/unitychina/uos/MetricsSDK.git",
                description = "UOS Metrics",
                // homePage = "https://uos.unity.cn/product/metrics",
                // docUrl = "https://uos.unity.cn/doc/metrics/",
                devPortalPath = "/services/{Settings.AppID}/metrics",
                versionUrl = "https://unitychina.coding.net/api/user/unitychina/project/uos/shared-depot/MetricsSDK/git/blob/master/package.json",
                launched = true,
                internalTesting = true,
                enableServiceUrl = "https://uos.unity.cn/contact-us",
                statusReason = "此服务默认关闭，请点击后「联系我们」以获取体验资格"
            },
            new ServiceConfig()
            {
                name = "cn.unity.uos.wind",
                displayName = "Wind",
                gitUrl = "https://e.coding.net/unitychina/uos/WindSDK.git",
                description = "UOS Wind",
                devPortalPath = "/services/{Settings.AppID}/wind",
                versionUrl = "https://unitychina.coding.net/api/user/unitychina/project/uos/shared-depot/WindSDK/git/blob/master/package.json",
                launched = true,
                enableServiceUrl = "https://uos.unity.cn",
                statusReason = "请至UOS开发者平台开启此服务"
            }
        };

        public static async Task InitLatestVersion()
        {
            foreach (var service in List)
            {
                await PackageUpgradeManager.GetLatestVersion(service);
            }
        }
    }
}