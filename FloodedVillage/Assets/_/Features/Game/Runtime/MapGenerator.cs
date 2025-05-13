using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class MapGenerator : BigBrother
{
    
    #region Private Variables
    
    [Header("Data")]
    [SerializeField] private MapData _mapData;
    
    //private Cell[,] _cells;
    //[Header("Map Settings")]
    private int[,] _levelDesign;
    private Dictionary<byte, Dictionary<byte, Cell>> _cells;
    private Vector2Int _mapDimensions;
    
    #endregion
    
    #region Unity API
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _cells = new Dictionary<byte, Dictionary<byte, Cell>>();
        _levelDesign = new int[,]
        {
            {0,1,0,2,0},
            {0,1,1,0,0},
            {0,1,0,2,2},
            {0,1,2,0,0},
            {0,1,0,0,5},
        };
        
        var dimensions = _levelDesign.Length / _levelDesign.GetLength(0);
        Info($"{dimensions} created");
        _mapDimensions = new Vector2Int(dimensions, dimensions);
        //_cells = new Cell[_mapDimensions.x, _mapDimensions.y];

        _mapData.UpdateMapData(GenerateMapCells());
        _mapData.UpdateLevelDesignData(_levelDesign);
    }
    
    #endregion
    
    #region Main Methods

    private Dictionary<byte, Dictionary<byte, Cell>> GenerateMapCells()
    {
        Vector3 cellPos = new Vector3();
        
        for (var i = 0; i < _levelDesign.GetLength(0); i++)
        {
            _cells.Add((byte)i, new Dictionary<byte, Cell>());
            for (var j = 0; j < _levelDesign.GetLength(1); j++)
            {
                (cellPos.x, cellPos.y) = (j, i);

                Info($"Cell is of type {(MapData.TileType)_levelDesign[i, j]}");
                Cell instanceCell = null;
                var tileType = (MapData.TileType)_levelDesign[i, j];
                var prefab = _mapData.GetPrefab(tileType);
                switch (tileType)
                {
                    case MapData.TileType.Seeds:
                        //instanceCell = new SeedsCell(cellPos, prefab);
                        instanceCell = Instantiate(prefab, cellPos, Quaternion.identity).GetComponent<Cell>();
                        break;
                    case MapData.TileType.Water:
                        //instanceCell = new WaterCell(cellPos, prefab);
                        //instanceCell = Instantiate(_waterTilePrefab, cellPos, Quaternion.identity);
                        instanceCell = Instantiate(prefab, cellPos, Quaternion.identity).GetComponent<Cell>();
                        break;
                    case MapData.TileType.Sand:
                        //instanceCell = new SandCell(cellPos, prefab);
                        //instanceCell = Instantiate(_dirtTilePrefab, cellPos, Quaternion.identity);
                        instanceCell = Instantiate(prefab, cellPos, Quaternion.identity).GetComponent<Cell>();
                        break;
                    // case TileType.Pirate:
                    //     instanceCell = Instantiate(_pirateTilePrefab, cellPos, Quaternion.identity);
                    //     break;
                    case MapData.TileType.Villager:
                        //instanceCell = new VillagerCell(cellPos, prefab);
                        //instanceCell = Instantiate(_villagerTilePrefab, cellPos, Quaternion.identity);
                        instanceCell = Instantiate(prefab, cellPos, Quaternion.identity).GetComponent<Cell>();
                        break;
                    default:
                        //instanceCell = new EmptyCell(cellPos, prefab);
                        //instanceCell = Instantiate(_emptyTilePrefab, cellPos, Quaternion.identity);
                        instanceCell = Instantiate(prefab, cellPos, Quaternion.identity).GetComponent<Cell>();
                        break;
                }
                
                instanceCell.transform.SetParent(gameObject.transform);
                instanceCell.gameObject.name = $"{i}:{j}|{instanceCell.GetType().Name}";
                
                Info($"Adding {instanceCell.name} to map");
                _cells[(byte)i].Add((byte)j, instanceCell);
            }
        }
        return _cells;
    }
    #endregion
}
