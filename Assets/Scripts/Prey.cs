using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prey : Character
{
    [SerializeField] private Transform _waypointsContainer;

    private int _currentWaipoint = 0;
    private Transform[] _waypoints;

    private void Awake()
    {
        _waypoints = new Transform[_waypointsContainer.childCount];

        for (int i = 0; i < _waypoints.Length; i++)
        {
            _waypoints[i] = _waypointsContainer.GetChild(i);
        }
    }

    private void Update()
    {
        if (transform.position == _waypoints[_currentWaipoint].position)
        {
            _currentWaipoint = (_currentWaipoint + 1) % _waypoints.Length;
        }

        Move(_waypoints[_currentWaipoint].position);
    }
}