using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    [SerializeField] private int _speed;
    [SerializeField] private Transform _pipeTransform;
    void Update()
    {
        _pipeTransform.Translate(Vector2.left*_speed*Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Deleter"))
        {
            Destroy(gameObject);
        }
    }
}
