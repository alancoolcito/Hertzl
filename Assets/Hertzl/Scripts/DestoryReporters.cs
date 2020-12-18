using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryReporters : MonoBehaviour
{
    public GameObject Reporter1;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    public void KillThemAll()
    {
        Destroy(Reporter1);
    }
}
