using UnityEngine;
using System.Collections;

public class BlockMover : MonoBehaviour {

    public float minSpeed;
    public float maxSpeed;
    public float maxLifetime;

    private float lifetime;
    private float panelBottom;
    private float speed;

	void Start () {
        lifetime = 0f;
        panelBottom = -Camera.main.pixelHeight;
        speed = Random.Range(minSpeed, maxSpeed);
	}
	
	void Update () {
        lifetime += Time.deltaTime;

        if (lifetime >= maxLifetime)
            Destroy(this.gameObject);
        else
        {
            Vector3 currentPos = transform.position;
            if (transform.position.y <= panelBottom)
                Destroy(this.gameObject);
            currentPos.y -= speed * Time.deltaTime;
            transform.position = currentPos;
        }
	}
}
