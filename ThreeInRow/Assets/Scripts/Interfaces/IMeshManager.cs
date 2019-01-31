

public interface IMeshManager {
    Cell[,] Mesh { get; }
    void AddBall(BallType type, int col);
    
}