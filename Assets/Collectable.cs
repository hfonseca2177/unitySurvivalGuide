using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    Renderer ownRenderer;

    // Start is called before the first frame update
    void Start()
    {
        ownRenderer = GetComponent<Renderer>();
        StartCoroutine(ChangeColorBehavior());        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }

    IEnumerator ChangeColorBehavior()
    {
        while (true)
        {
            Color currentColor = ownRenderer.material.color;
            Color nextColor;
            if(currentColor.Equals(Color.blue))
            { 
                nextColor = Color.green;
            }else if (currentColor.Equals(Color.red))
            {
                nextColor = Color.blue;
            }
            else
            {
                nextColor = Color.red;
            }

            ownRenderer.material.color = nextColor;
            yield return new WaitForSeconds(3.0f);
           
        }
    }
}
