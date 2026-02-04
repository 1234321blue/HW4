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

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Deleter")
        {
        Destroy(gameObject);
        } 
    }
}
