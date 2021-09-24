using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuControler : MonoBehaviour
{
    public GameObject HUD;

    public void StartGameButton()
    {
        GetComponent<Animator>().SetBool("mainButtons", true);
        HUD.GetComponent<Animator>().SetTrigger("show");
    }

    public void SettingsButton()
    {
        GetComponent<Animator>().SetBool("settingButtons", true);
        GetComponent<Animator>().SetBool("mainButtons", true);       
    }

    public void ExitGameButton()
    {
        Application.Quit();
    }

    public void BackButton()
    {
        GetComponent<Animator>().SetBool("settingButtons", false);
        GetComponent<Animator>().SetBool("mainButtons", false);
    }
   
}
