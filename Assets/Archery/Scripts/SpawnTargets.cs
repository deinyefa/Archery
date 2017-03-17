using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTargets : MonoBehaviour {

    public GameObject[] spawnPoints;
    public GameObject target;

    private GameObject currentPoint;
    private GameObject newTarget;

	// Use this for initialization
	void Start () {
        StartCoroutine(SpawnTarget(5.0f));
	}

    IEnumerator SpawnTarget (float waitTime)
    {
        while (true)
        {
            // get random spawn point
            currentPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

            // remove old target
            DestroyObject(newTarget, waitTime);

            // instantiate new target
            newTarget = Instantiate(target, currentPoint.transform.position, Quaternion.identity);
            newTarget.transform.parent = currentPoint.gameObject.transform;
            newTarget.transform.rotation = currentPoint.transform.rotation;
            yield return new WaitForSeconds(waitTime);
        }
    }
}
