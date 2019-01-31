
using UnityEngine;

public class BallsUpdater:IBallsUpdater
{
    private IMeshManager meshManager;

    public BallsUpdater(IMeshManager manager)
    {
        meshManager = manager;
    }
    public void FrameUpdate(){                                      //very hardcore code
        float delta = Time.deltaTime;
        for (int col = 0; col < Constants.WIDTH; col++) {           //for getting position
            for (int row = 0; row < Constants.HEIGHT; row++) {
                Cell cell = meshManager.Mesh[col, row];
                if (cell != null && cell.isFall) {                  //check not null balls, what falls
                    var position = cell.ball.transform.position;
                    var height = row * Constants.MESH_SIZE;         //final height
                    cell.ySpeed += Constants.GRAVIY * delta;
                    if(position.y - cell.ySpeed*delta <= height) {  //finish fall
                        cell.ball.transform.position = new Vector3(position.x, height, position.z);
                        cell.isFall = false;
                    } else {
                        cell.ball.transform.position = new Vector3(position.x,position.y - (float)(cell.ySpeed * delta), position.z);
                    }
                }
            }
        }
    }
}
/*
 *         foreach (Cell cell in meshManager.Mesh) {

            if(cell != null) {
                var position = cell.ball.transform.position;
                cell.ball.transform.position = new Vector3(position.x, position.y - delta, position.z);
            }
        }
        */
