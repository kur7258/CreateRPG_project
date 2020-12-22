using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private float moveSpeed = 5.0f;
    private Vector3 moveDirection = Vector3.zero;

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");//오른쪽(d, 방향키), 왼쪽(a, 방향키)
        float y = Input.GetAxisRaw("Vertical");//위쪽(w, 방향키), 아래쪽(s, 방향키)

        moveDirection = new Vector3(x, y, 0);

        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}
