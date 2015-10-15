using UnityEngine;
using System.Collections;
using DG.Tweening;

public class BlockFallMover : MonoBehaviour {

    public float minSpeed;
    public float maxSpeed;

    private Vector3 panelBottom;

	void Start () {
        panelBottom = Camera.main.ScreenToWorldPoint(new Vector3(0f, 0f, 1f));
        transform.DOMove(new Vector3(transform.position.x, panelBottom.y, 1f), Random.Range(minSpeed, maxSpeed)).SetEase(Ease.Linear).OnComplete(()=>Destroy(gameObject));
	}
	
}
