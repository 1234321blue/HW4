using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _pipe;
    int random;
    private float timer;
    [SerializeField] private float _spawnTime;
    
    // Start is called before the first frame update
    void Start()
    {
        Locator.Instance.birb.dead+=StopSpawn;
        random = Random.Range(-2,3);
    }

    // Update is called once per frame
    void Update()
    {
        timer+=Time.deltaTime;
        SpawnPipes();
        
    }
    void SpawnPipes()
    {
        Vector3 _spawnposition = new Vector3(5,random,0);
        if(timer>=_spawnTime)
        {
            Instantiate(_pipe,_spawnposition,Quaternion.identity);
            timer=0;
            random = Random.Range(-2,3);
        }
    }
    void StopSpawn()
    {
        enabled = false;
    }
}
