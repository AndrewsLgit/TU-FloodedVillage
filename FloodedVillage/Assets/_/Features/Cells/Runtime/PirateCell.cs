using UnityEngine;

public class PirateCell : Cell
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    protected override void Reaction()
    {
        Info($"Water! We can leave!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
