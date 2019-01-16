using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere1 : MonoBehaviour {

    [SerializeField]
    float gravity = 9;
    float startSpeed = 0;
    float startTime = 0;
    Vector3 startPoint;

	void Start () {
        startPoint = transform.position;
	}
	
	void Update () {
        var time = Time.time - startTime;
        transform.position = new Vector3(startPoint.x, startPoint.y + (startSpeed * time) - (gravity * Square(time))/2, startPoint.z);
	}
    private void OnCollisionEnter(Collision collision) {
        if (startTime == 0) {
            startSpeed = gravity * Time.time;
        }
        startPoint = transform.position;
        startTime = Time.time;
    }
    private static float Square(float arg) {
        return arg * arg;
    }
}
