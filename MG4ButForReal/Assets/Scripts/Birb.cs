using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birb : MonoBehaviour
{
    [SerializeField] Rigidbody2D _birb;
    [SerializeField] private int _jump;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space))
        {
            _birb.AddForce(Vector2.up*_jump,ForceMode2D.Impulse);
        }
    }
}
