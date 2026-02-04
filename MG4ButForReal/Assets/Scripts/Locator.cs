using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locator : MonoBehaviour
{
public static Locator Instance { get; private set; }
public Birb birb {get; private set;}
private void Awake() 
{
    if (Instance != null && Instance != this) 
    {
        Destroy(this);
        return;
    }
    Instance = this;
    GameObject birs = GameObject.FindWithTag("Player");
    birb = birs.GetComponent<Birb>();
}

}
