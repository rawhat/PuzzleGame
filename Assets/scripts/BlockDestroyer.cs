using UnityEngine;
using System.Collections;

public class BlockDestroyer : MonoBehaviour {

    void OnTriggerExit(Collider obj)
    {
        Debug.Log("Hello!");
        if (obj.gameObject.CompareTag("RoadPiece"))
            Destroy(obj.gameObject);
    }
}
