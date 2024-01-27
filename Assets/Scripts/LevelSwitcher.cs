using System.Collections.Generic;
using UnityEngine;

public class LevelSwitcher : MonoBehaviour
{
  public List<GameObject> toDeactivate;
  public List<GameObject> toActivate;

  public void ExecuteSwitch()
  {
    foreach (GameObject o in toDeactivate)
    {
      o.SetActive(false);
    }

    foreach (GameObject o in toActivate)
    {
      o.SetActive(true);
    }
  }

  public void RevertSwitch()
  {
    foreach (GameObject o in toDeactivate)
    {
      o.SetActive(true);
    }

    foreach (GameObject o in toActivate)
    {
      o.SetActive(false);
    }
  }
}