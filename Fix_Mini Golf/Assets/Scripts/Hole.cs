using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    bool entered = false;

    public bool Entered { get => entered; set => entered = value; }

    private void OnTriggerEnter(Collider other)
    {
        Entered = true;
    }
}
