using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Rotation : Interactable
{
    //float rotSpeed = 60.0f;
    //GameObject target;
    float startingRotationZ;
    // float speed = 50.0f;

   void Start()
    {
        startingRotationZ = transform.rotation.z;
    }


    void Update() {
        transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y, startingRotationZ, transform.rotation.w);
    }

    /* void Update()
   {
       transform.Rotate(Vector3.right * speed * Time.deltaTime);
   }*/

    /*void Start()
   {
       target= GameObject.Find("Table plane");
   }

   void Update()
   {
       Vector3 targetPosition = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z); 
   }*/



    /*public float moveSpeed;

    /*void Update()
    {
        float v = Input.GetAxis("Vertical") * moveSpeed;
        transform.Translate(new Vector3(0, 0, v) * Time.deltaTime);
    }*/




    /* void Update()
     {
       transform.Rotate(0, rotSpeed * Time.deltaTime, 0, Space.World);   dah cuba
     }*/


}
