using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core.Movement.Sys3D;

public class Player : MonoBehaviour
{
    [SerializeField, Range(0f, 10f)]
    float moveSpeed = 0f;

    void Update()
    {
        Movement3D.DeltaMovement(transform, moveSpeed);
    }
}
