using UnityEngine;

public class Constants
{
    #region ConstantsMesh
    public static readonly int HEIGHT = 5;
    public static readonly int WIDTH = 5;
    public static readonly float MESH_SIZE = 1;
    public static readonly Vector3 START_POSITION = new Vector3(0, 0, 0);
    public static readonly float START_HIGH = START_POSITION.y + 8;//(HEIGHT * MESH_SIZE);
    public static readonly float GRAVIY = 9.8f;
    #endregion
}