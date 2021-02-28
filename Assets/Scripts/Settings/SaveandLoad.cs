using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveandLoad : MonoBehaviour
{
    public Dropdown loadLives;
    public InputField loadName;
    public Slider loadSpeed;

    
    public void saveSettings()
    {
        PlayerPrefs.SetInt("SavedLives", loadLives.value);
        PlayerPrefs.SetFloat("SavedSpeed", loadSpeed.value);
        PlayerPrefs.SetString("SavedName", loadName.text);

        Debug.Log("Settings Saved");
    }
    public void loadSettings()
    {
        loadLives.value = PlayerPrefs.GetInt("SavedLives", 1);
        loadSpeed.value = PlayerPrefs.GetFloat("SavedSpeed", 2);
        loadName.text = PlayerPrefs.GetString("SavedName", "Pepe");
        Debug.Log("Settings Loaded");
    }

/*
    public void UpdateUI()
    {
        loadLives.value = DropdownLives.numLives;
        loadName.text = InputName.frogName;
        loadSpeed.value = SliderCarSpeed.carSpeed;

    }
*/
}
