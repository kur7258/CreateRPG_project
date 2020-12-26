using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    private float moveSpeed = 5.0f;//속도
    private Vector3 moveDirection;//방향설정

    public void Setup(Vector3 direction)
    {
        moveDirection = direction;
    }

    private void Update()
    {
        transform.position += moveDirection * moveSpeed * Time.deltaTime;//컴성능에 따라 프레임차이는 있어도 도달하는데 걸리는 시간은 같게 움직이게 함
    }
}
