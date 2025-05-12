using UnityEngine;

public class VillagerCell : Cell
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    protected override void Reaction()
    {
        Info($"I'm gonna drown!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
