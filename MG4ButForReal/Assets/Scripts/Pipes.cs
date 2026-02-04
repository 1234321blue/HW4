using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    [SerializeField] private int _speed;
    [SerializeField] private Transform _pipeTransform;
    void Update()
    {
        if(gameObject.tag=="Score")
        {
        _pipeTransform.Translate(Vector2.left*_speed*Time.deltaTime);
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if(gameObject.tag=="Score")
        {
        //get point
        Debug.Log("got point");
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(gameObject.tag=="Pipes")
        {
        //stop game event
        Debug.Log("dead");
        } 
    }
}
