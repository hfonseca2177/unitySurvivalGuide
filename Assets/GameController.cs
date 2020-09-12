using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    public GameSettings[] gameSettings;
    [SerializeField]
    public GameHiddenSettings[] gameHiddenSettings;
    [SerializeField]
    public ScreenSettings screenSettings;

    // Start is called before the first frame update
    void Start()
    {
        createGameOptions();
        ShuffleCaps();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {            
            ShuffleCaps();
        }
    }

    private void ShuffleCaps()
    {   
        Debug.Log("shuffling...");
        CapsController.Instance.ShuffleCaps();
    }

    private void createGameOptions()
    {
        gameSettings = new GameSettings[]
        {
            new GameSettings("Resolution", "Screen resolution", "1090 x 820"),
            new GameSettings("Mutiplayer Nick"),
            new GameSettings("Antialiasing", "Use anti-aliasing", "disabled"),
            new GameSettings("Keep udated", "Keep addos updated?", "enabled"),
        };

        gameHiddenSettings = new GameHiddenSettings[]
        {
            new GameHiddenSettings("Old option"),
            new GameHiddenSettings("Deprecated option", true, false)
        };
        gameHiddenSettings[0].ResetValue();
        screenSettings = new ScreenSettings("Screen Ratio adjustment");
        screenSettings.aspectsRatioAvailable = new AspectRatio[]
        {
            new AspectRatio("16:4", 16f,4f),
            new AspectRatio("50:16", 50f,16f)
        };
    }

   
}
