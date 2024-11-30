using BepInEx;
using UnityEngine;

namespace DisableBackgroundNoise
{
   [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
   public class Plugin : BaseUnityPlugin
   {
	void Start()
	{
            HarmonyPatches.ApplyHarmonyPatches();
            GameObject.Find("Environment Objects/LocalObjects_Prefab/Forest/Environment/WeatherDayNight/AudioBirds").SetActive(false);
            GameObject.Find("Environment Objects/LocalObjects_Prefab/Forest/Environment/WeatherDayNight/AudioSpookyWind").SetActive(false);
            GameObject.Find("Environment Objects/LocalObjects_Prefab/Forest/Environment/WeatherDayNight/AudioCrickets").SetActive(false);
        }
    }
}
