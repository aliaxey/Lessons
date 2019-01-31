
using UnityEngine;

public class Cell{
    public GameObject ball { get; set; }
    public bool isFall { get; set; }
    public double ySpeed;

    public Cell(GameObject ball)
    {
        this.ball = ball;
        isFall = true;
        ySpeed = 0;
    }

}