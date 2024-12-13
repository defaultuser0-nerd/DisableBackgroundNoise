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
            GameObject.Find("Environment Objects/LocalObjects_Prefab/Forest/Environment/WeatherDayNight/AudioBirds").SetActive(false); // disables the birds
            GameObject.Find("Environment Objects/LocalObjects_Prefab/Forest/Environment/WeatherDayNight/AudioSpookyWind").SetActive(false); // disables the spooky wind from halloween so its more future proof
            GameObject.Find("Environment Objects/LocalObjects_Prefab/Forest/Environment/WeatherDayNight/AudioCrickets").SetActive(false); // disables the crickets
            GameObject.Find("Environment Objects/LocalObjects_Prefab/Forest/Environment/WeatherDayNight/rain").SetActive(false); // disables the rain
            Debug.Log("Removed Background Noise"); // logs when it disables
        }
    }
}
