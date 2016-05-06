using UnityEngine;
using System.Collections;

public class oscillate : MonoBehaviour {

    public float randOffset;
    public float Increment;

    private float offset;
    private float r;

	// Use this for initialization
	void Start () {

        offset = 0;

	}
	
	// Update is called once per frame
	void Update () {

        r = Random.Range(0, randOffset);

        offset += Increment + Mathf.Tan(r);

        Vector3 yPos = new Vector3(this.transform.position.x, Mathf.Sin(offset), this.transform.position.z);
        this.transform.position = yPos;

	}
}
