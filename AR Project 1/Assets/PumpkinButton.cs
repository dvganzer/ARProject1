using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;

    public void Instantiate()
    {
        Instantiate(prefab);
    }
}
