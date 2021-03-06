using UnityEngine;

public class MeshManager:IMeshManager{

    readonly IObjectPublisher publisher;
    public Cell[,] Mesh { get; private set; }
    

    public MeshManager(IObjectPublisher objectPublisher) {
        publisher = objectPublisher;
        Mesh  = new Cell[Constants.WIDTH, Constants.HEIGHT];
    }

    public void AddBall(BallType type, int col)
    {
        int freeRow = GetFreeRow(col);
        if (freeRow >= 0)
        {      //START_POSITION.y + (freeRow * MESH_SIZE)
            var position = new Vector3(Constants.START_POSITION.x + 
                (Constants.MESH_SIZE * col), Constants.START_HIGH , Constants.START_POSITION.z);
            var ball = publisher.CreateBall(type,position);
            var cell = new Cell(ball);
            Mesh[col, freeRow] = cell;
        }
    }


    private int GetFreeRow(int col)
    {
        for (int i = 0; i < Constants.HEIGHT; i++)
        {
            if (Mesh[col, i] == null)
            {
                return i;
            }
        }
        return -1;
    }
}