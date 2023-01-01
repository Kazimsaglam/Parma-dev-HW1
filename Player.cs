using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static  Player Instance;

    public float rotateSpeed = 90f;

    private void Awake() => Instance = this;

    private void Update()
    {
        transform.Rotate(rotateSpeed * Time.deltaTime, 0, 0);
    }

}
