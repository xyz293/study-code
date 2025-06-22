using System.Collections.Generic;
using UnityEditor;

namespace Unity.UOS.Launcher
{
    public class WeixinMinigameDefineSymbol
    {
        private const string DefineSymbol = "UNITY_WEIXINMINIGAME";
        private static bool _isWeixinMinigame;
        
        public static bool IsWeixinMinigame()
        {
            #if !UNITY_WEBGL
            return false;
            #endif
            string currentDefines = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.WebGL);
            HashSet<string> defines = new HashSet<string>(currentDefines.Split(';'));
            _isWeixinMinigame = defines.Contains(DefineSymbol);
            return _isWeixinMinigame;
        }

        public static void SetValue(bool enableWeixinMinigame)
        {
            if (enableWeixinMinigame == _isWeixinMinigame) return;
            _isWeixinMinigame = enableWeixinMinigame;
            if (enableWeixinMinigame)
            {
                DefineSymbols.Add(BuildTargetGroup.WebGL, DefineSymbol);
            }
            else
            {
                DefineSymbols.Remove(BuildTargetGroup.WebGL, DefineSymbol);
            }
        }

        public static bool DisplayDialog()
        {
            var result =
                EditorUtility.DisplayDialog("Switch Target", "Before using Weixin Minigame, you need to switch the build target to WebGL firstly. ", "Switch to WebGL", "Cancel");
            if (result)
            {
                SwitchBuildTarget();
                SetValue(true);
            }

            return result;
        }

        private static void SwitchBuildTarget()
        {
            EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.WebGL, BuildTarget.WebGL);
        }
    }
}
