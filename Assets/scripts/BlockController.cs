﻿using UnityEngine;
using System.Collections;
using DG.Tweening;

public class BlockController : MonoBehaviour {

	private Vector3 screenPoint;
	private Vector3 offset;

    void Start() { }

	void OnMouseDown()
	{
		screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        gameObject.transform.DOPause();
	}

	void OnMouseDrag()
	{
		Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
		transform.position = curPosition;
	}

    void OnMouseUp()
    {
        gameObject.transform.DOPlay();
    }
}
