using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : BigBrother
{

    #region Private Variables

    private MapData _mapData;
    private Ray2D _ray;
    private Camera _camera;

    #endregion
    
    #region Unity API
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _camera = Camera.main;

    }

    // Update is called once per frame
    void Update()
    {
        CheckClick();
        
        // TODO: Add rule application when pressing space
        
        //_ray = _camera.ScreenPointToRay(Mouse.current.position.ReadValue());
        // if ((Physics2D.Raycast(_ray, out RaycastHit hit) && hit.collider.gameObject.CompareTag("Ground")) && Input.GetMouseButtonDown(0))
        // {
        //     _target = hit.collider.gameObject.transform;
        //     Vector2Int pos = new Vector2Int((int)_target.position.x, (int)_target.position.z);
        //     //var posNeighbors = GetCellNeighbors(pos, m_mapDimensions);
        //     /*Debug.Log($"X{pos.x},Y{pos.y} at index {GetIndexFrom2DCoordinates(pos, m_mapDimensions)} has living neighbors? {posNeighbors.Length}");
        //     for (int i = 0; i < posNeighbors.Length; i++)
        //     {
        //         Debug.Log($"{pos} has neighbor {i} {posNeighbors[i]}");
        //     }*/
        //     int index = GetIndexFrom2DCoordinates(pos, m_mapDimensions);
        //     m_levelDesign[index] = m_levelDesign[index] == 0 ? (byte)1 : (byte)0;
        //     GenerateMap(m_levelDesign);
        // }
    }
    
    #endregion
    
    #region Main Methods

    private void CheckClick()
    {
        Cell cell = null;
        var hit = Physics2D.Raycast(Mouse.current.position.ReadValue(), Vector2.zero);
        //Debug.Log($"Ray info: {_ray2D}");
        if (!hit.collider) return;
        if (!hit.transform.CompareTag("Sand")) return;
        
        cell = hit.transform.GetComponent<Cell>();
    }
    
    #endregion
}
