using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetListener : MonoBehaviour
{

    public int points;

    // Start is called before the first frame update
    void Start()
    {
        points = 0;
        Debug.ClearDeveloperConsole();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddPoint()
    {
        points++;
        Debug.Log(points);
    }
}
