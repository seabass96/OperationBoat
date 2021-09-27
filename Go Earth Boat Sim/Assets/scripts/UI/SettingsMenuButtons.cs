using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SettingsMenuButtons : MonoBehaviour
{
    private Resolution[] res;
    public Dropdown resDropdown;
    public AudioMixer mixer;
    public Toggle fullscreenToggle;

    private void Start()
    {
        res = Screen.resolutions;
        resDropdown.ClearOptions();

        List<string> options = new List<string>();
        int currentRes = 0;
        for (int i = 0; i < res.Length; i++)
        {
            string option = res[i].width + " x " + res[i].height;
            options.Add(option);

            //sets the current screen size as the option shown
            if (res[i].width == Screen.currentResolution.width &&
            res[i].height == Screen.currentResolution.height)
            {
                currentRes = i;
            }
        }

        resDropdown.AddOptions(options);
        resDropdown.value = currentRes;
        resDropdown.RefreshShownValue();

        if (Screen.fullScreen == true) fullscreenToggle.isOn = true;

    }

    public void Fullscreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }

    public void setQuality(int index)
    {
        QualitySettings.SetQualityLevel(index);
    }

    public void setScreenResolution(int index)
    {
        Screen.SetResolution(res[index].width, res[index].height, Screen.fullScreen);
    }

    public void SetVolume(float volume)
    {
        mixer.SetFloat("Volume", volume);     
    }
    
}
