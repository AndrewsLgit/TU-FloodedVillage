using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "MapData", menuName = "Scriptable Objects/MapData")]
public class MapData : ScriptableObject
{
    #region Private Variables
    
    private Dictionary<byte, Dictionary<byte, Cell>> _mapData;
    
    private int[,] _levelDesign;
    
    [Header("Tile Prefabs")]
    [SerializeField] private static GameObject _emptyTilePrefab;
    [SerializeField] private static GameObject _waterTilePrefab;
    [SerializeField] private static GameObject _sandTilePrefab;
    [SerializeField] private static GameObject _seedsTilePrefab;
    [SerializeField] private static GameObject _villagerTilePrefab;

    #endregion

    #region Public Variables

    public Dictionary<byte, Dictionary<byte, Cell>>  m_mapData => _mapData;
    public int[,] m_levelDesign => _levelDesign;
    
    public enum TileType
    {
        Empty = 0,
        Water,
        Sand,
        Seeds,
        Villager,
    }

    #endregion
    
    #region Unity API

    private void OnEnable()
    {
        _mapData = new Dictionary<byte, Dictionary<byte, Cell>>();
        _levelDesign = new int[0, 0];
        
        _emptyTilePrefab = Resources.Load<GameObject>("Prefabs/EmptyCellPrefab");
        _waterTilePrefab = Resources.Load<GameObject>("Prefabs/WaterPrefab");
        _sandTilePrefab = Resources.Load<GameObject>("Prefabs/SandPrefab");
        _seedsTilePrefab = Resources.Load<GameObject>("Prefabs/SeedsPrefab");
        _villagerTilePrefab = Resources.Load<GameObject>("Prefabs/VillagerPrefab");
    }
    
    #endregion

    #region Utils

    public GameObject GetPrefab(TileType tileType)
    {
        return (tileType) switch
        {
            TileType.Seeds => _seedsTilePrefab,
            TileType.Water => _waterTilePrefab,
            TileType.Sand => _sandTilePrefab,
            TileType.Villager => _villagerTilePrefab,
            _ => _emptyTilePrefab
        };
    }

    public void UpdateMapData(Dictionary<byte, Dictionary<byte, Cell>> newMapData)
    {
        Debug.Log($"Updating map data for {this}");
        _mapData = newMapData;
        foreach (var data in _mapData)
        {
            Debug.Log($"Map data for {this}: {data.Key}, {data.Value}");
        }
    }

    public void UpdateLevelDesignData(int[,] lvlDesign)
    {
        _levelDesign = lvlDesign;
        foreach (var data in lvlDesign)
        {
            Debug.Log($"Level design data updated! \n Design: {lvlDesign}:{data}");
        }
    }
    
    #endregion
}
