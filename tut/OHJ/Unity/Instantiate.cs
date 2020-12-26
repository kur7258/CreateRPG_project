using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//여러개 생성
/*public class Instantiate : MonoBehaviour
{
    [SerializeField]
    private GameObject orangePrefab;

    private void Awake()
    {
        for(int i = 0; i<10; ++i)
        {
            Vector3     position = new Vector3(-4.5f + i, 0, 0);
            Quaternion  rotation = Quaternion.Euler(0, 0, i * 10);

            Instantiate(orangePrefab, position, rotation);
        }
    }
}*/

//격자모양 만들기
/*public class Instantiate : MonoBehaviour
{
    [SerializeField]
    private GameObject orangePrefab;

    private void Awake()
    {
        for (int y = 0; y < 10; ++y)
        {
            for (int x = 0; x < 10; ++x)
            {
                Vector3 position = new Vector3(-4.5f + x, 4.5f - y, 0);
                Instantiate(orangePrefab, position, Quaternion.identity);
            }
        }
    }
}*/

//대각선(54: if (x == y)), X형태(54: if (x == y || x + y == 9)), 마름모(54: if (x + y == 4 || x - y == 5 || y - x ==5 || x = y == 14))로 만들기
//사진이 커서 안보이면 크기조정하든가 좌표지정 잘 하든가
/*public class Instantiate : MonoBehaviour
{
    [SerializeField]
    private GameObject orangePrefab;

    private void Awake()
    {
        for (int y = 0; y < 10; ++y)
        {
            for (int x = 0; x < 10; ++x)
            {
                //if (x == y || x + y == 9)
                if (x + y == 4 || x - y == 5 || y - x ==5 || x + y == 14)
                {
                    continue;
                }
                Vector3 position = new Vector3(-4.5f + x, 4.5f - y, 0);
                Instantiate(orangePrefab, position, Quaternion.identity);
            }
        }
    }
}*/

//랜덤함수
/*public class Instantiate : MonoBehaviour
{
    [SerializeField]
    private GameObject[] orangePrefab;

    private void Awake()
    {
        for (int i = 0; i < 10; ++i)
        {
            int index = Random.Range(0, orangePrefab.Length);
            Vector3 position = new Vector3(-4.5f + i, 0, 0);

            Instantiate(orangePrefab[index], position, Quaternion.identity);
        }
    }
}*/

//랜덤으로 위치 지정
/*public class Instantiate : MonoBehaviour
{
    [SerializeField]
    private int I = 30;

    [SerializeField]
    private GameObject[] orangePrefab;

    private void Awake()
    {
        for (int i = 0; i < I; ++i)
        {
            int index = Random.Range(0, orangePrefab.Length);
            float x = Random.Range(-7.5f, 7.5f);
            float y = Random.Range(-4.5f, 4.5f);
            Vector3 position = new Vector3(x, y, 0);

            Instantiate(orangePrefab[index], position, Quaternion.identity);
        }
    }
}*/
