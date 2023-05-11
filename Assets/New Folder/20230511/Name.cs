using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Name : MonoBehaviour
{
    public string stringValue;
    
    private void Awake()
    {
     
    }
    private void OnEnable()
    {
    
    }
    private void Start()
    {
        Debug.Log(stringValue);
    }
}
