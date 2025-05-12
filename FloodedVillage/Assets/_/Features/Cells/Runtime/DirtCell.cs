using UnityEngine;

public class DirtCell : Cell
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    protected override void Reaction()
    {
        Info($"Cell turned into water");
        Destroy(this.gameObject);
        // TODO: Turn dirt cell into water after
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
