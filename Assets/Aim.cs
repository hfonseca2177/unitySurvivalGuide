using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{

    [SerializeField] GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 directionToAim = target.transform.position - transform.position;
        Debug.DrawLine(transform.position, directionToAim, Color.red);
        Quaternion targetRotation = transform.rotation = Quaternion.LookRotation(directionToAim);
        transform.Rotate(new Vector3(90, 0, 0));
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime);

    }
}
