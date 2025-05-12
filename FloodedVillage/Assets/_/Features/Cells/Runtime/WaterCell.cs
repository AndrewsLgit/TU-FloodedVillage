using UnityEngine;

public class WaterCell : Cell
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    protected override void Reaction()
    {
        Info($"Turning next cell into water!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
