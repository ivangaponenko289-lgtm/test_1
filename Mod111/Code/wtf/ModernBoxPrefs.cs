using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public static class ModernBoxPrefs
{
    public static bool Updates { get; set; } = true;
    public static float[] EraProgress { get; set; } = new float[4] { 100, 120, 0, 700 };

    public static void Save()
    {
        PlayerPrefs.SetInt("MB_Updates", Updates ? 1 : 0);
        for (int i = 0; i < EraProgress.Length; i++)
            PlayerPrefs.SetFloat($"MB_Era_{i}", EraProgress[i]);
        PlayerPrefs.Save();
    }

    public static void Load()
    {
        Updates = PlayerPrefs.GetInt("MB_Updates", 1) == 1;

        ModernBoxLogger.Log($"ModernBoxPrefs: Updates = {Updates}");

        if (PlayerPrefs.HasKey("MB_Era_0"))
        {
            for (int i = 0; i < EraProgress.Length; i++)
            {
                EraProgress[i] = PlayerPrefs.GetFloat($"MB_Era_{i}");
            }
        }

        string eraValues = string.Join(", ", EraProgress.Select(f => f.ToString()));
        ModernBoxLogger.Log($"ModernBoxPrefs: EraProgress = [{eraValues}]");
    }
}