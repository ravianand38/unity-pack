using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instatiate : MonoBehaviour
{
    public Transform prefab;
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            Instantiate(prefab, new Vector3(i * .5F, 12, 0), Quaternion.identity);
        }
    }

}
