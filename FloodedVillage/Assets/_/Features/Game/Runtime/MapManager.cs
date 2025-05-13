using UnityEngine;

public class MapManager : BigBrother
{
    
    #region Private Variables
    
    [Header("Map Settings")]
    [SerializeField] private Vector2Int _mapDimensions;
    [SerializeField] private int[,] _levelDesign;

    
    private Cell[,] _cells;
    private Ray2D _ray;
    private Camera _camera;
    
    #endregion
    
    #region Unity API
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _camera = Camera.main;
        _cells = new Cell[_mapDimensions.x, _mapDimensions.y];

        _levelDesign = new int[,]
        {
            {0,1,0,0,0},
            {0,1,0,0,0},
            {0,1,0,0,0},
            {0,1,0,0,0},
            {0,1,0,0,0},
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    #endregion
    
    #region Main Methods
    
    private void GenerateMap()
    {
        GameObject instance = null;
        Vector3 cellPosition = new Vector3();
        Vector2Int pos = new Vector2Int();
        int size = _mapDimensions.x * _mapDimensions.y;
        
        for (int i = 0; i < size; i++)
        {
            //pos = Get2DCoordinates(_mapDimensions, i);
            cellPosition.x = pos.x;
            cellPosition.z = pos.y;
            instance = Instantiate(m_prefab, cellPosition, Quaternion.identity);
            instance.transform.SetParent(gameObject.transform);
            instance.name = $"2DTileX{cellPosition.x}Y{cellPosition.z}";
            
            //Debug.Log($"{instance.name} instance index: {GetIndexFrom2DCoordinates(pos, m_mapDimensions)} || Loop i: {i}");
        }
    }
    
    #endregion
    
    #region Utils
    
    private Vector2Int Get2DCoordinates(Vector2Int dimensions, int i)
    {
        //Debug.Log($"X: {i%dimensions.x}, Y: {i/dimensions.x}");
        return new Vector2Int(i%dimensions.x, i/dimensions.x);
    }
    
    #endregion
}
