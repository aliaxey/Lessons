using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//так я делал на флеше раньше)
public class SimpleSphere : MonoBehaviour {
   [SerializeField]
    float gravity = -9.8f;
    float speed = 0;

	void Start () {
    }
	
	void Update () {
        var dt = Time.deltaTime;
        speed += gravity * dt;
        var currentPos = transform.position;
        currentPos.y += speed * dt;
        transform.position = currentPos;
	}
    private void OnCollisionEnter() {
        speed = -speed;
    }
}
