using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject toriPrefab;

    private void Awake()
    {
        Instantiate(toriPrefab, new Vector3(0, 0, 0), Quaternion.Euler(0, 0, 45)); //Quaternion.Euler(0, 0, 45): 45도로 기움
        Instantiate(toriPrefab, new Vector3(4, 0, 0), Quaternion.identity);

        GameObject clone = Instantiate(toriPrefab, Vector3.zero, Quaternion.identity);
        clone.name = "tori3"; //이름
        clone.GetComponent<SpriteRenderer>().color = Color.black; //색상
        clone.transform.position = new Vector3(8, 0, 0); //위치
        clone.transform.localScale = new Vector3(3, 4, 1); //크기
    }
}
