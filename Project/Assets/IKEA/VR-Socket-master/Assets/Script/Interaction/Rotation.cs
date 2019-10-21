using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Rotation : Interactable
{
    //float rotSpeed = 60.0f;
    //GameObject target;
    //float startingRotationX;
    //float startingRotationY;
    // float speed = 50.0f;
    //public float moveSpeed;

    float speed = 5F;

     void Update()
    {
        transform.Rotate (speed, 0, 0);
    }












    /*void Start()
    {
    }*/


    /*void Update() {
        transform.rotation = new Quaternion(startingRotationX, transform.rotation.y, transform.rotation.z, transform.rotation.w);
    }


    /*void Start()
    {
        startingRotationY = transform.rotation.y;
    }


    void Update()
    {
        transform.rotation = new Quaternion(transform.rotation.x, startingRotationY, transform.rotation.z, transform.rotation.w);
    }*/






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
