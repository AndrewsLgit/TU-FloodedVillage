using UnityEngine;

public class WaterCell : Cell
{
    // public WaterCell(Vector3 cellPos, GameObject cell) : base(cellPos,  cell)
    // {
    //     _tileType = MapData.TileType.Water;
    // }

    protected override void Reaction()
    {
        Info($"Turning next cell into water!");
    }
}
