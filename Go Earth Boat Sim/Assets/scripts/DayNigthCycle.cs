using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNigthCycle : MonoBehaviour
{
    public GameObject sunCenter;
    public GameObject Boat;
    public Material skyBox;
    public Material skyBox1;
    public Gradient skyBoxColor;

    public Gradient sunColor;
    public Material sunMat;

    public Gradient directionalLigth;
    public GameObject directionalLightObj;

    public Gradient ambient;
    public GameObject directionalLigthCenterPoint;

    public float timeMultiplier = 1;
    private float currentTime;
    private float oldXrot = 0;

    private void FixedUpdate()
    {     
        DayNightEffects(InGameTime());
    }

    private float InGameTime()
    {
        currentTime += Time.deltaTime * timeMultiplier;
        currentTime %= 24; //clamp to 24
        return currentTime / 24;
    }

    private void DayNightEffects(float time)
    {
        //lerp between the two skyboxes TODO dosent work yet
        RenderSettings.skybox.Lerp(skyBox, skyBox1, 0.5f);
        DynamicGI.UpdateEnvironment();

        skyBox.SetColor("_Tint", skyBoxColor.Evaluate(time));

        //RenderSettings.skybox.Lerp(skyBox, skyBox1, 0.5f);
        //DynamicGI.UpdateEnvironment();

        //change sun with time
        sunMat.SetColor("_Color", sunColor.Evaluate(time));
        sunMat.SetColor("_EmissionColor", sunColor.Evaluate(time));

        //rotate the light
        float xrot = time - oldXrot;
        directionalLigthCenterPoint.transform.Rotate(new Vector3(xrot * 360, 0, 0));
        oldXrot = time;

        //change directional light color
        directionalLightObj.GetComponent<Light>().color = directionalLigth.Evaluate(time);

        //change ambient light
        RenderSettings.ambientLight = ambient.Evaluate(time);


    }

}
