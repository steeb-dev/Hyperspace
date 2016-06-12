using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class NetworkManager : MonoBehaviour {

    int x = (Screen.width / 2) - 100;
    int y = (Screen.height / 2) - 350;

    // Use this for initialization
    void Start () {
        NetworkManagerHUD hudManager = this.gameObject.GetComponent<NetworkManagerHUD>();
        hudManager.offsetX = x;
        hudManager.offsetY = y;
    }

}
