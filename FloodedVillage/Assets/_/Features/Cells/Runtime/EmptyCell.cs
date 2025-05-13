using UnityEngine;

public class EmptyCell : Cell
{
    // public EmptyCell(Vector3 cellPos, GameObject cell) : base(cellPos,  cell)
    // {
    //     _tileType = MapData.TileType.Empty;
    // }

    protected override void Reaction()
    {
        Info($"I should turn into water!");
    }
}
