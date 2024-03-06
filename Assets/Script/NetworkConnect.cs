using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using Unity.Netcode;
using UnityEngine;

public class NetworkConnect : MonoBehaviour
{
    public void HostSession()
    {
        NetworkManager.Singleton.StartServer();
    }

    public void JoinSession()
    {
        NetworkManager.Singleton.StartClient();
    }
}
