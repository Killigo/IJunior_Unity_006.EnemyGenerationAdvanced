using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hunter : Character
{
    private Prey _prey;

    private void Update()
    {
        Move(_prey.transform.position);
    }

    public void SetTarget(Prey prey)
    {
        _prey = prey;
    }
}
