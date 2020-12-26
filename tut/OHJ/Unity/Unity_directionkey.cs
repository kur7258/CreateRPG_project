using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject toriPrefab;

    private void Awake()
    {
        Instantiate(toriPrefab);
    }
}
