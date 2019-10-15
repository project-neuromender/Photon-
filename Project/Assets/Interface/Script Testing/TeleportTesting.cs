using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;
using Valve.VR.Extras;
using Valve.VR.InteractionSystem;

public class TeleportTesting : MonoBehaviour
{
    public SteamVR_LaserPointer laserPointer;
    public GameObject player;
    public Transform Teleport_Location;
    public Transform Teleport_Location1;

    void Awake()
    {
        laserPointer.PointerClick += PointerClick;
    }

    public void PointerClick(object sender, PointerEventArgs e)
    {
        if (e.target.name == "Leave Room")
        {
            Debug.Log("Button was clicked");
            Button();
        }
    }

    public void Button()
    {
        //Debug.Log("Button was clicked");
        SceneManager.LoadScene("Rooms");
    }

    /*public void Teleport(Collider other)
    {
        if ((other.gameObject.tag = "Player") && Input.GetKeyDown(KeyCode.E))
        { }
    }*/

    void OnTriggerStay(Collider other)
    {
        if ((other.gameObject.tag == "Player") && Input.GetKeyDown(KeyCode.E))
        {
            player.transform.position = Teleport_Location.transform.position;
        }
    }
}
