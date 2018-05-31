using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotonButtonsBehaviour : MonoBehaviour {

    [SerializeField]
    private InputField createServerInputField, joinServerInputField;

    public void OnClick_CreateServer(){
        // grab the text from the createServerInputField(check for blank text etc etc)
        if (createServerInputField.text.Length > 0) {
            PhotonNetwork.CreateRoom(createServerInputField.text, new RoomOptions() { MaxPlayers = 4 }, null);
        }
    }

    public void OnClick_JoinServer() {
        PhotonNetwork.JoinRoom(joinServerInputField.text);
    }

    private void OnJoinedRoom(){
        Debug.Log("We are connected to the room");
        PhotonNetwork.LoadLevel("MainGame");
    }

}


/*
 *      TODO:
 *      1. Check for the server name length. The user may do weird stuff sometimes. 
 *      2. For LoadLevel think of making a separate script. He did it!
 * 
 *      DOUBT:
 *      1. Check if the same named server is already present. If it is prompt the user to join the server. Why didn't
 *      the guy incorporate this.
 *      
 *      2. Research more about the lobby names and the default lobby thing!
 * 
 */
