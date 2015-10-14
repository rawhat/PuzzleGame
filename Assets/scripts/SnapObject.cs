using UnityEngine;
using System.Collections;
using DG.Tweening;

public class SnapObject : MonoBehaviour {

   private bool blockMoved = false;
   public int blocksAdded = 1;

    void OnTriggerStay(Collider obj)
    {
        if (obj.gameObject.CompareTag("RoadPiece") && !Input.GetMouseButton(1) && !blockMoved)
        {
            blockMoved = true;
            Destroy(obj.gameObject.GetComponent<BlockController>());
            Destroy(obj.gameObject.GetComponent<BlockFallMover>());
            obj.gameObject.transform.DOKill();
            Vector2 currPieceDimensions = blocksAdded * this.transform.localScale;
            Vector2 nextPieceDimensions = obj.transform.localScale;
            Vector3 targetPosition = new Vector3(transform.position.x, transform.position.y + (currPieceDimensions.y / 2) + (nextPieceDimensions.y / 2), 1f);
            blocksAdded+=1;
            obj.transform.DOMove(targetPosition, 1f);
            obj.tag = "Untagged";
            increaseTriggerHeight();
            blockMoved = false;
        }

    }

    void increaseTriggerHeight()
    {
        BoxCollider trigger = GetComponent<BoxCollider>();
        trigger.center = new Vector3(0f, blocksAdded * 0.5f, 0f);
    }
}
