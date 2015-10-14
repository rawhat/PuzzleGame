using UnityEngine;
using System.Collections;

public class KillAfterLifetime : MonoBehaviour {

    public float maxLifetime;

    public float lifetime = 0f;

	void Update () {
        lifetime += Time.deltaTime;
        if (lifetime >= maxLifetime)
            Destroy(this.gameObject);
	}
}
