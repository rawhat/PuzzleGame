using UnityEngine;
using System.Collections;
using DG.Tweening;

public class FallingBlockController : MonoBehaviour {

    public GameObject[] blocks;
    public float edgeBuffer;
    public float fallingTime;

    private float panelHeight;
    private float panelWidth;

    void Start()
    {
        panelWidth = (Camera.main.pixelWidth / 3f) - edgeBuffer;
        StartCoroutine(DropNewBlock());
    }

    IEnumerator DropNewBlock()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            Vector3 spawnLocation = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(panelWidth, 2 * panelWidth), Camera.main.pixelHeight));
            spawnLocation.z = 1f;
            GameObject newBlock = (GameObject) Instantiate(blocks[Random.Range(0, blocks.Length)], spawnLocation, new Quaternion());
        }
    }
}
