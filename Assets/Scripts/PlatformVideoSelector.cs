using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlatformVideoSelector : MonoBehaviour
{
    public TextMeshProUGUI platform;
    public video videoPlayer;

    void Start()
    {
        if(platform != null)
            platform.text = "Platform: " + Application.platform.ToString();
    }

    public void PlayVideoBasedOnPlatform()
    {
        var runtimePlatform = Application.platform;

        switch (runtimePlatform)
        {
            
            case RuntimePlatform.IPhonePlayer:
                break;
           
            case RuntimePlatform.Android:
                break;
            case RuntimePlatform.WebGLPlayer:
                break;
        }
    }
}
