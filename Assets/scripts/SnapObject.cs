using UnityEngine;
using System.Collections;
using DG.Tweening;

public class SnapObject : MonoBehaviour {

    void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.CompareTag("RoadPiece"))
        {
            obj.gameObject.GetComponent<BlockController>().enabled = false;
            Vector2 currPieceDimensions = this.transform.localScale;
            Vector2 nextPieceDimensions = obj.transform.localScale;
            Vector3 targetPosition = new Vector3(transform.position.x, transform.position.y + (currPieceDimensions.y / 2) + (nextPieceDimensions.y / 2));
            obj.transform.DOMove(targetPosition, 1f);
        }
    }
}
