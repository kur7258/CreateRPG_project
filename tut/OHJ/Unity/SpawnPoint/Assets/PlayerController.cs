using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private KeyCode keyCodeFire = KeyCode.Space;//스페이스바 누르면 총알? 날아감
    [SerializeField]
    private GameObject bulletPrefab;
    private float moveSpeed = 3.0f;
    private Vector3 lastMoveDirection = Vector3.right;//초반은 오른쪽으로

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        transform.position += new Vector3(x, y, 0) * moveSpeed * Time.deltaTime;

        //마지막방향키에 따라 날아가는 방향이 다름
        if(x != 0 || y != 0)
        {
            lastMoveDirection = new Vector3(x, y, 0);
        }

        if(Input.GetKeyDown(keyCodeFire))
        {
            GameObject clone = Instantiate(bulletPrefab, transform.position, Quaternion.identity);

            clone.name = "Bullet";//총알이름
            clone.transform.localScale = Vector3.one * 0.5f;//총알크기
            clone.GetComponent<SpriteRenderer>().color = Color.red;//총알 색깔

            clone.GetComponent<Movement2D>().Setup(lastMoveDirection);//총알 나가게하는 코드
        }
    }
}
