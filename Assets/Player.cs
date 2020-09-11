using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 _startPosition;
    public float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        _startPosition = new Vector3(0, 0, 0);       
    }

    // Update is called once per frame
    void Update()
    {
        playerCommandsHandler();
        movementHandler();
    }

    private void playerCommandsHandler()
    {
        //pause/slow/resume effect
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Time.timeScale = 0;
        }
        else if (Input.GetKeyUp(KeyCode.F))
        {
            Time.timeScale = 0.5f;
        }
        else if (Input.GetKeyUp(KeyCode.R))
        {
            Time.timeScale = 1;
        }
        else if (Input.GetKeyUp(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0, 1));
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            transform.Rotate(new Vector3(1, 0));
        }
    }

        void movementHandler()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontalInput,verticalInput, 0) * movementSpeed * Time.deltaTime);
    }    
}
