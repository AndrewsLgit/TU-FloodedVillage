using UnityEngine;

public class VillagerCell : Cell
{
    // public VillagerCell(Vector3 cellPos, GameObject cell) : base(cellPos,  cell)
    // {
    //     _tileType = MapData.TileType.Villager;
    // }

    protected override void Reaction()
    {
        Info($"I'm gonna drown!");
    }
}
