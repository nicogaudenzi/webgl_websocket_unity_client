using UnityEngine;
using System.Runtime.InteropServices;

public class WebSocketSender : MonoBehaviour
{

    [DllImport("__Internal")]
    private static extern void WebSocketInit(string url, string protocol);

    [DllImport("__Internal")]
    private static extern void WebSocketSend(string message);

    void Start()
    {
        WebSocketInit("ws://0.0.0.0:5678", "hunterX");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            WebSocketSend("Pew!Pew!Pew!");
        }
    }
}