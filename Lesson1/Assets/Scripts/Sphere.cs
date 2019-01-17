using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour {

    [SerializeField]
    float gravity = 9.8f;
    bool moveUp = false;
    Vector3 startPosition;
    float startTime;
    float startSpeed = 0;

	void Start () {
        startPosition = transform.position;
        startTime = Time.time;
	}
	
	void Update () {
        //каждый кусок движения рассматривается отдельно
        var delta = Time.time - startTime;
        var oldPosition = transform.position.y;
        if (moveUp) {
            transform.position = new Vector3(startPosition.x, startPosition.y + startSpeed * delta - (gravity * BasicSphere.Square(delta)) / 2, startPosition.z);
        } else {
            transform.position = new Vector3(startPosition.x, startPosition.y - (gravity * BasicSphere.Square(delta)) / 2, startPosition.z);
        }
        //проверяем, если шарик летит вверх, отключаем скорость подъёма
        if(moveUp && transform.position.y - oldPosition < 0) {
            moveUp = false;
            Start();
        }
	}
    private void OnCollisionEnter(Collision collision) {
        if (startSpeed == 0) {
            startSpeed = gravity * Time.time;
        }
        Start();
        moveUp = true;
    }

}
