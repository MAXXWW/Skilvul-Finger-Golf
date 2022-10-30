using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    [SerializeField] float speed;
    float timer;

    private void Update()
    {
        if (timer > 1)
        {
            timer = 0;
        }

        timer += Time.deltaTime * speed;
        var z = Mathf.Lerp(0, 360, timer);
        this.transform.localRotation = Quaternion.Euler(0, 0, z);
    }
}
