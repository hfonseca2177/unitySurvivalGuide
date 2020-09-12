

[System.Serializable]
public class GameSettings
{
    public string name;
    public string description;
    public string currentValue;
    public string defaultValue;

    public GameSettings(string name, string description, string defaultValue){
        this.name = name;
        this.description = description;
        this.currentValue = defaultValue;
        this.defaultValue = defaultValue;
    }

    public GameSettings(string name): this(name, string.Empty, string.Empty)
    {        
    }

    public GameSettings(): this(string.Empty, string.Empty, string.Empty)
    {        
    }


    public virtual void ResetValue()
    {
        this.currentValue = defaultValue;
    }
}
