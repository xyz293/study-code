using System.IO;
using UnityEditor;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.Build;
using UnityEditor.PackageManager;
using UnityEngine;

namespace Unity.UOS.Launcher
{
    public class PackageResourcesManager
    {
        private const string ResourceFolder = "UOSLauncherEncrypt";
        private const string  PackageResourcesRelativePath = "/Package Resources/UOSLauncherEncrypt.unitypackage";
        private const string DefineSymbol = "UNITY_UOS_SECURITY";
        private static string _packageRelativePath = "";
        
        [InitializeOnLoadMethod]
        private static void Init()
        {
            Events.registeringPackages += RegisteringPackagesEventHandler;
            Check();
        }
        
        static void RegisteringPackagesEventHandler(PackageRegistrationEventArgs packageRegistrationEventArgs)
        {
            foreach (var removedPackage in packageRegistrationEventArgs.removed)
            {
                if (removedPackage.name == KnownService.Launcher.name)
                {
                    RemoveDefineSymbolsForAllTarget();
                }
            }
        }
        private static void AddDefineSymbolsForAllTarget()
        {
            DefineSymbols.Add(BuildTargetGroup.iOS, DefineSymbol);
            DefineSymbols.Add(BuildTargetGroup.Android, DefineSymbol);
            DefineSymbols.Add(BuildTargetGroup.WebGL, DefineSymbol);
            DefineSymbols.Add(BuildTargetGroup.Standalone, DefineSymbol);
            DefineSymbols.Add(NamedBuildTarget.Server, DefineSymbol);

#if TUANJIE_1_0_OR_NEWER
            DefineSymbols.Add(BuildTargetGroup.WeixinMiniGame, DefineSymbol);
            DefineSymbols.Add(BuildTargetGroup.OpenHarmony, DefineSymbol);
            DefineSymbols.Add(BuildTargetGroup.HMIAndroid, DefineSymbol);
#endif
        }
        
        private static void RemoveDefineSymbolsForAllTarget()
        {
            DefineSymbols.Remove(BuildTargetGroup.iOS, DefineSymbol);
            DefineSymbols.Remove(BuildTargetGroup.Android, DefineSymbol);
            DefineSymbols.Remove(BuildTargetGroup.WebGL, DefineSymbol);
            DefineSymbols.Remove(BuildTargetGroup.Standalone, DefineSymbol);
            DefineSymbols.Remove(NamedBuildTarget.Server, DefineSymbol);

#if TUANJIE_1_0_OR_NEWER
            DefineSymbols.Remove(BuildTargetGroup.WeixinMiniGame, DefineSymbol);
            DefineSymbols.Remove(BuildTargetGroup.OpenHarmony, DefineSymbol);
            DefineSymbols.Remove(BuildTargetGroup.HMIAndroid, DefineSymbol);
#endif
        }
        
        public static void Check()
        {
            var packageAbsolutePath = GetPackageFullPath() + PackageResourcesRelativePath;
            var path = GetResourceFullPath();
            if (string.IsNullOrEmpty(path))
            {
                AssetDatabase.ImportPackage(packageAbsolutePath, false);
            }
            else
            {
                AddDefineSymbolsForAllTarget();
            }
        }

        public static string GetResourceFullPath()
        {
            var packagePath = Path.GetFullPath("Assets/..");
            if (Directory.Exists(packagePath))
            {
                var folderPath = "";
                // Search default location
                folderPath = packagePath + "/Assets/" + ResourceFolder;
                if (Directory.Exists(folderPath))
                {
                    return folderPath;
                }

                // Search for potential alternative locations in the user project
                string[] matchingPaths = Directory.GetDirectories(packagePath, ResourceFolder, SearchOption.AllDirectories);
                if (matchingPaths.Any())
                {
                    folderPath = packagePath + matchingPaths[0];
                    return folderPath;
                }
            }

            return "";
        }

        public static string GetPackageRelativePath()
        {
            if (!string.IsNullOrEmpty(_packageRelativePath)) return _packageRelativePath;
            var possiblePath = new List<string>()
            {
                "Packages/cn.unity.uos.launcher",
                // dev path
                "Assets/UOSLauncher",
                "Assets/UOS Launcher"
            };
            foreach (var path in possiblePath)
            {
                if (Directory.Exists(path))
                {
                    _packageRelativePath = path;
                }
            }

            if (string.IsNullOrEmpty(_packageRelativePath))
            {
                _packageRelativePath = possiblePath[0];
            }
            return _packageRelativePath;
        }

        static string GetPackageFullPath()
        {
            // Check for potential package
            string packagePath = Path.GetFullPath("Packages/cn.unity.uos.launcher");
            if (Directory.Exists(packagePath))
            {
                return packagePath;
            }

            packagePath = Path.GetFullPath("Assets/..");
            if (Directory.Exists(packagePath))
            {
                // Search default location for development package
                if (Directory.Exists(packagePath + "/Assets/Package Resources"))
                {
                    return packagePath + "/Assets";
                }
                if (Directory.Exists(packagePath + "/Assets/UOS Launcher/Package Resources"))
                {
                    return packagePath + "/Assets/UOS Launcher";
                }
                
                if (Directory.Exists(packagePath + "/Assets/UOSLauncher/Package Resources"))
                {
                    return packagePath + "/Assets/UOSLauncher";
                }
            }
            return null;
        }
    }
}