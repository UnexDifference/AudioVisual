using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitVisualizer : MonoBehaviour
{

    public GameObject visualizerObject;
    public int amount;
    public Vector2 position;
    public Vector2 offset = new Vector2(1, 0);

    void Start()
    {
        for( int i = 0; i < amount; i++)
        {
            GameObject instantiatedObject = Instantiate(visualizerObject);
            position += offset;
            instantiatedObject.transform.position = position;

        }   
    }

    
}
