using UnityEngine;
using KyleDulce.SocketIo;

public class SocketDemo : MonoBehaviour
{
    Socket s;

    void Start()
    {
        s = SocketIo.establishSocketConnection("ws://localhost:3000");
        s.connect();
        s.on("testEvent", call);
    }

    void call(string d) {
        Debug.Log("RECEIVED EVENT: " + d);
        s.emit("testEvent", "test");
    }
}