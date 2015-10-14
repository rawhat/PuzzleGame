using UnityEngine;
using System.Collections;
using DG.Tweening;

public class SnapObject : MonoBehaviour {

    private bool blockMoved = false;

    void OnTriggerStay(Collider obj)
    {
        if (obj.gameObject.CompareTag("RoadPiece") && !Input.GetMouseButton(1) && !blockMoved)
        {
            blockMoved = true;
            obj.gameObject.GetComponent<BlockController>().enabled = false;
            obj.gameObject.GetComponent<BlockFallMover>().enabled = false;
            Vector2 currPieceDimensions = this.transform.localScale;
            Vector2 nextPieceDimensions = obj.transform.localScale;
            Vector3 targetPosition = new Vector3(transform.position.x, transform.position.y + (currPieceDimensions.y / 2) + (nextPieceDimensions.y / 2), 1f);
            obj.transform.DOMove(targetPosition, 1f);
        }
    }
}
