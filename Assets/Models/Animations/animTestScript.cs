using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animTestScript : MonoBehaviour
{
    public float speed = 3;


    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
