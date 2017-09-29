using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffMiniMap : MonoBehaviour {

    public GameObject MiniMap;
    public void OnMiniMap()
    {
        MiniMap.SetActive(true);
    }
    public void OffMiniMap()
    {
        MiniMap.SetActive(false);
    }
}
