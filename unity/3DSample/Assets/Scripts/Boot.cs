using UnityEngine;

public class Boot
{
  private readonly bool _isInitialized = false;
  
  public Boot()
  {
    if (_isInitialized)
    {
      return;
    }
    
    _isInitialized = true;
    Debug.Log("Boot constructor");
  }
}
