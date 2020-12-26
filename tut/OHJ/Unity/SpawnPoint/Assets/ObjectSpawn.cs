using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawn : MonoBehaviour
{
    [SerializeField]
    private int objetSpawnCount = 30;
    [SerializeField]
    private GameObject[] prefabArray;
    [SerializeField]
    private Transform[] spawnPointArray;
    private int currentObjetCount = 0;
    private float objectSpawnTime = 0.0f;

    private void Update()
    {
        //갯수초과 안하기 위해서
        if(currentObjetCount + 1 > objetSpawnCount)
        {
            return;
        }

        objectSpawnTime += Time.deltaTime;//실제시간

        //0.5초마다 나타나게 할려고
        if(objectSpawnTime >= 0.5f)
        {
            int prefabIndex = Random.Range(0, prefabArray.Length);//랜덤으로 오렌지 생성
            int spawnIndex = Random.Range(0, spawnPointArray.Length);// 랜덤으로 둘중((6, 4, 0), (-6, -4, 0)) 한 곳에서 생성

            Vector3 position = spawnPointArray[spawnIndex].position;
            GameObject clone = Instantiate(prefabArray[prefabIndex], position, Quaternion.identity);

            Vector3 moveDirection = (spawnIndex == 0 ? Vector3.right : Vector3.left);//(-6, -4, 0)이면 오른쪽이동 아니면(6, 4, 0) 왼쪽이동 
            clone.GetComponent<Movement2D>().Setup(moveDirection);//움직이게 하는 코드

            currentObjetCount++;//한개 했음
            objectSpawnTime = 0.0f;//시간초기화
        }
    }
}
