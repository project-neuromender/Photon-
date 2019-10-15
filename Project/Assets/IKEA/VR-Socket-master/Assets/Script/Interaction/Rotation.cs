using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    GameObject target;

     void Start()
    {
        target= GameObject.Find("Table plane");
    }
   
    void Update()
    {
        Vector3 targetPosition = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z); 
    }

    /*public float moveSpeed;

    void Update()
    {
        float v = Input.GetAxis("Vertical") * moveSpeed;
        transform.Translate(new Vector3(0, 0, v) * Time.deltaTime);
    }*/
}
