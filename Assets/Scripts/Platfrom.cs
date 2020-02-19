using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platfrom : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector3.left * 10 * Time.deltaTime);
    }
}
