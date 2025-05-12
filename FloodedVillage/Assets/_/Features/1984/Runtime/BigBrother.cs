using UnityEngine;

public class BigBrother : MonoBehaviour
{
   #region Debug

   [SerializeField, Header("Debug")]
   protected bool m_isVerbose;

   protected void Info(string message)
   {
      if (!m_isVerbose) return;
      Debug.Log($"FROM: {this} | INFO: {message}");
   }
   
   #endregion
}
