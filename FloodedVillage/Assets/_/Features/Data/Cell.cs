using UnityEngine;

// TODO: REMOVE CONSTRUCTOR AND USE AN INITIALIZER INSTEAD
public abstract class Cell : BigBrother
{
    #region Private Variables

    private Cell _cellPrefab;
    private MapData _mapData;
    protected MapData.TileType _tileType;

    #endregion
    
    #region Unity API
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Info($"Instantiated {this.GetType().Name}");
        //_cellPrefab = this.gameObject;
    }
    
    #endregion
    
    #region Main Methods

    // protected Cell(Vector3 cellPos, GameObject cellPrefab)
    // {
    //     Instantiate(cellPrefab, cellPos, Quaternion.identity);
    //     this.gameObject.name = $"{cellPos.x}:{cellPos.y}|{this.GetType().Name}";
    // }

    protected abstract void Reaction();
    //public abstract void Initialize(Vector3 cellPos);

    #endregion
}
