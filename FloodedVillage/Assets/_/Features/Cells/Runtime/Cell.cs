using UnityEngine;

public abstract class Cell : BigBrother
{
    
    #region Unity API
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Info($"Instantiated {this.GetType().Name}");
    }
    
    #endregion
    
    #region Main Methods

    protected abstract void Reaction();

    #endregion
}
