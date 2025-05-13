using UnityEngine;

public class SeedsCell : Cell
{
    // public SeedsCell(Vector3 cellPos, GameObject cell) : base(cellPos,  cell)
    // {
    //     _tileType = MapData.TileType.Seeds;
    // }

    protected override void Reaction()
    {
        Info($"I will grow into crops!");
    }
    
}
