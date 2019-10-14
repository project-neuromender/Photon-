using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
using Photon.Realtime;

public class PlayerListing : MonoBehaviour
{
    [SerializeField]
    private Text _text;

    public Player Player { get; private set; }
    public PlayerInputField PlayerInputField { get; private set; }

    public void SetPlayerInfo(Player player)
    {
        Player = player;
        _text.text = player.NickName;
    }

    public void SetPlayerInfo1(PlayerInputField player)
    {
        PlayerInputField = player;
        _text.text = PhotonNetwork.NickName;
    }
}

