

using UnityEngine;

public class CapsController: MonoBehaviour
{
    public static CapsController Instance { get; private set; }

    private GameObject[] _caps;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            this._caps = LocateCaps();
        }
        else
        {
            Destroy(gameObject);
        }        
    }

    private GameObject[] LocateCaps()
    {
        GameObject[] allCaps = GameObject.FindGameObjectsWithTag("caps");
        return allCaps;
    }

    public void ShuffleCaps()
    {
        foreach (GameObject _cap in this._caps)
        {
            _cap.GetComponent<MeshRenderer>().material.color = GenerateRandomColor();
            _cap.transform.position = GenerateRandomPosition();
        }
    }

    private Color GenerateRandomColor()
    {
        Color randomColor = new Color(Random.value, Random.value, Random.value);
        return randomColor;
    }

    private Vector3 GenerateRandomPosition()
    {
        Vector3 randomPosition = new Vector3(Random.Range(0, 5), Random.Range(0, 5), Random.Range(0, 5));
        return randomPosition;
    }
}
