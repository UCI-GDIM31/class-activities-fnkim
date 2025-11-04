using System;
using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{

    public float speed = 2.0f;
    private Transform _playerTransform;

    public void EnableChase(Transform player)
    {
        enabled = true;
        _playerTransform = player;
    }
    public void Disable()
    {
        enabled = false;
    }


    void Update()
    {
     //   transform.position = Vector3.MoveTowards(transform.position, _playerTransform.position, speed * Time.deltaTime);
    }

}
