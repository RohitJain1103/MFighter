using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotonConnect : MonoBehaviour {

    string versionName = "0.1";

    [SerializeField]
    private GameObject section1, section2, section3;

    public void Awake(){
        Debug.Log("Sending the request to the photon server");   // Debug sending request
        PhotonNetwork.ConnectUsingSettings(versionName);         // Send the request to photon server with the versionName variable
    }

    // PHOTON CALLBACK 
    private void OnConnectedToMaster() {
        Debug.Log("Connected to the master");                    // Debug connected to the master
        PhotonNetwork.JoinLobby(TypedLobby.Default);             // join the lobby
    }

    // PHOTON CALLBACK
    private void OnJoinedLobby() {
        Debug.Log("On Joined the lobby");                        // Debug the lobby is joined
        section1.SetActive(false);
        section3.SetActive(false);
        section2.SetActive(true);
    }

    // PHOTON CALLBACK
    private void OnDisconnectedFromPhoton() {
        Debug.Log("Disconnected from the photon services.");    // Debug disconnected from the photon services check your internet connection perhaps
        section1.SetActive(false);
        section2.SetActive(false);
        section3.SetActive(true);
    }

}



/*
 * TODO:
 * 1. Handle the logic when the connection gets re-established(Also keep care of saving the game state as well)
 * 2. Do something during the period when the client is about to lose the connection
 * 3. Similarly do something during the period when we are just about to connect
 */
  

    /* DOUBT:
     * 1. Does the photon callback gets called everywhere possible(searches everywhere) or on the gameobject which calls it?
     * 
     */ 