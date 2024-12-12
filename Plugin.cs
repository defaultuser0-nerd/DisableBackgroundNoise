using BepInEx;
using System;
using UnityEngine;

namespace DisableBackgroundNoise
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        void Start()
        {
            HarmonyPatches.ApplyHarmonyPatches();
            GorillaTagger.OnPlayerSpawned(Initialized);
        }

        void Initialized()
        {
            GameObject.Find("Environment Objects/LocalObjects_Prefab/Forest/Environment/WeatherDayNight/AudioBirds").SetActive(false);
            GameObject.Find("Environment Objects/LocalObjects_Prefab/Forest/Environment/WeatherDayNight/AudioSpookyWind").SetActive(false);
            GameObject.Find("Environment Objects/LocalObjects_Prefab/Forest/Environment/WeatherDayNight/AudioCrickets").SetActive(false);
            GameObject.Find("Environment Objects/LocalObjects_Prefab/Forest/Environment/WeatherDayNight/rain").SetActive(false);
            Debug.Log("Removed Background Noise")
        }
    }
}
