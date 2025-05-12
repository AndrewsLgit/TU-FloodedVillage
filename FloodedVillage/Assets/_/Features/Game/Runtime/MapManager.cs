using UnityEngine;

public class MapManager : BigBrother
{
    
    #region Private Variables
    
    [SerializeField] private Vector2Int _mapDimensions;
    
    private Cell[,] _cells;
    private int[,] _levelDesign;
    private Ray2D _ray;
    private Camera _camera;
    
    #endregion
    
    #region Unity API
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _camera = Camera.main;
        _cells = new Cell[_mapDimensions.x, _mapDimensions.y];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    #endregion
    
    #region Main Methods
    
    
    
    #endregion
}
