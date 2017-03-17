using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTargets : MonoBehaviour {

    public GameObject[] spawnPoints;
    public GameObject target;
    public float newTargetWaitTime;

    private GameObject currentPoint;
    private GameObject newTarget;

	// Use this for initialization
	void Start () {
        StartCoroutine(SpawnTarget(newTargetWaitTime));
	}

    IEnumerator SpawnTarget (float waitTime)
    {
        while (true)
        {
            // get random spawn point
            currentPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

            DestroyObject(newTarget, newTargetWaitTime);

            // instantiate new target
            newTarget = Instantiate(target, currentPoint.transform.position, Quaternion.identity);
            newTarget.transform.parent = currentPoint.gameObject.transform;
            yield return new WaitForSeconds(waitTime);
        }
    }
}
