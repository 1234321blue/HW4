using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birb : MonoBehaviour
{
    [SerializeField] Rigidbody2D _birb;
    [SerializeField] private int _jump;
    // Start is called before the first frame update
    public delegate void Flapped();
    public event Flapped flapped;
    public delegate void Scored();
    public event Scored point;
    public delegate void End();
    public event End dead;
    public int points;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space))
        {
            _birb.AddForce(Vector2.up*_jump,ForceMode2D.Impulse);
            flapped?.Invoke();
        }
    }
    void OnTriggerExit2D (Collider2D collision)
    {
        points++;
        point?.Invoke();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        dead?.Invoke();
        gameObject.SetActive(false);
    }
}
