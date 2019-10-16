using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;
using Valve.VR.Extras;
using Valve.VR.InteractionSystem;
using Photon.Pun;
using Photon.Realtime;

public class TeleportTesting : MonoBehaviourPunCallbacks
{
    public SteamVR_LaserPointer laserPointer;
    public GameObject player;
    public Transform Teleport_Location;
    public Transform Teleport_Location1;

    private SteamVR_Behaviour_Pose pose = null;
    public SteamVR_Action_Boolean Teleport;


    void Awake()
    {        
        if (photonView.IsMine)
        {
            laserPointer.PointerClick += PointerClick;
            pose = GetComponent<SteamVR_Behaviour_Pose>();
        }        
    }

    public void PointerClick(object sender, PointerEventArgs e)
    {
        if (e.target.name == "Leave Room")
        {
            Debug.Log("Button was clicked");
            Button();
        }
    }

    private void Update()
    {
        if (photonView.IsMine)
        {
            if (Teleport.GetLastStateUp(pose.inputSource))
            {
                TeleportRunning();
            }
        }
    }

    public void Button()
    {
        //Debug.Log("Button was clicked");
        PhotonNetwork.LeaveRoom();
        SceneManager.LoadScene("Rooms");
    }

    void TeleportRunning()
    {
        if ((gameObject.tag == "Player"))
        {
            player.transform.position = Teleport_Location.transform.position;
        }
        Debug.Log("Teleport Running");
    }

    /*public void Teleport(Collider other)
    {
        if ((other.gameObject.tag = "Player") && Input.GetKeyDown(KeyCode.E))
        { }
    }

    void OnTriggerStay(Collider other)
    {
        if ((other.gameObject.tag == "Player") && Input.GetKeyDown(KeyCode.E))
        {
            player.transform.position = Teleport_Location.transform.position;
        }
    }*/
}
