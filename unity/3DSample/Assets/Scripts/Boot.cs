using UnityEngine;

public class Boot
{
  private readonly bool _IsInitialized = false;
  
  public Boot()
  {
    if (_IsInitialized)
    {
      return;
    }
    
    _IsInitialized = true;
    Debug.Log("Boot constructor");
  }
}
