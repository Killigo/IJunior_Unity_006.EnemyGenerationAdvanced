using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoint : MonoBehaviour
{
    [SerializeField] private Prey _prey;
    [SerializeField] private Hunter _hunter;


    private void Start()
    {
        var hunter = Instantiate(_hunter, transform.position, Quaternion.identity);
        hunter.SetTarget(_prey);
    }
}
