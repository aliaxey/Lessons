using UnityEngine;
using System.Collections;

public class ObjectPubisher : IObjectPublisher {
    private readonly IObjectCreator creator;

    public ObjectPubisher(IObjectCreator objectCreator) {
        creator = objectCreator;
    }
    public GameObject CreateBall(BallType type,Vector3 position) {
        Object ball = creator.CreateNewBall(type);
        return Publish(ball, position);
    }
    private GameObject Publish(Object obj, Vector3 position) {
        return Object.Instantiate(obj, position, Quaternion.identity) as GameObject;
    }
}
