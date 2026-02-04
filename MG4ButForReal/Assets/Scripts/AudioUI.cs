using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AudioUI : MonoBehaviour
{
    [SerializeField] AudioSource _flap;
    [SerializeField] AudioSource _point;
    [SerializeField] AudioSource _ohNo;
    [SerializeField] TMP_Text _score;
    // Start is called before the first frame update
    void Start()
    {
        Locator.Instance.birb.flapped+=Flapping;
        Locator.Instance.birb.point+=UpdatePoints;
        Locator.Instance.birb.dead+=Dead;
    }
    void Flapping()
    {
        _flap.Play();
    }
    void UpdatePoints()
    {
        _point.Play();
        _score.text="Score: "+Locator.Instance.birb.points;
    }
    void Dead()
    {
        _ohNo.Play();
    }
}
