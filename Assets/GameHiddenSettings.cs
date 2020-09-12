using UnityEngine;

[System.Serializable]
public class GameHiddenSettings : GameSettings
{

    protected bool _visible = false;
    protected bool _deprecated = false;

    public GameHiddenSettings(string name)
    {
        this.name = name;
        this.description = string.Empty;
        this.currentValue = string.Empty;
        this.defaultValue = string.Empty;
    }

    public GameHiddenSettings(string name, bool deprecated, bool visible): this(name)
    {
        this._visible = visible;
        this._deprecated = deprecated;
    }

    public override void ResetValue()
    {
        
        if (_deprecated)
        {
            throw new System.Exception("Deprecated option");
        }
        else
        {
            Debug.Log("Should not be reseting a hidden setting");
            base.ResetValue();
        }
    }
}
