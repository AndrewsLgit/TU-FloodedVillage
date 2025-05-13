using UnityEngine;

public class SandCell : Cell
{
    // public SandCell(Vector3 cellPos, GameObject cell) : base(cellPos,  cell)
    // {
    //     _tileType = MapData.TileType.Sand;
    // }

    protected override void Reaction()
    {
        Info($"Cell turned into water");
        Destroy(this.gameObject);
        // TODO: Turn dirt cell into water after
    }
}
