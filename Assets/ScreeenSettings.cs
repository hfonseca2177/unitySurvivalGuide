using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ScreenSettings : GameSettings
{
    
    public AspectRatio[] aspectsRatioAvailable;

    
    public ScreenSettings(string name)
    {
        this.name = name;
        this.description = string.Empty;
        this.currentValue = string.Empty;
        this.defaultValue = string.Empty;
    }

}
