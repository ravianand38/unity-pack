using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PublicHelper.ChangeColor(this.gameObject, Color.blue,true);
        }
    }
}
