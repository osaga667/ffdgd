using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayerMovement : Movement
{
    [SerializeField] float horizontalSpeed;
    [SerializeField] float verticleSpeed;
    [SerializeField] float movementLimitX;

    public override void Move(Vector3 direction)
    {
        direction.x *= horizontalSpeed;
        if (Mathf.Abs(direction.x * Time.deltaTime + transform.position.x) > movementLimitX)
        {
            direction.x = 0;
        }
        transform.Translate(new Vector3(direction.x, 0, verticleSpeed) * Time.deltaTime);
    }
}
