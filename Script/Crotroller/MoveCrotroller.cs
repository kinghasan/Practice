using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCrotroller : MonoBehaviour
{
    private float m_MoveSpeed;

    private void Start()
    {
        m_MoveSpeed = 3;
    }

    // Update is called once per frame
    void Update()
    {
        float x = 0, y = 0, z = 0;
        if (Input.GetKey(KeyCode.W))
        {
            z += m_MoveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            z -= m_MoveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            x -= m_MoveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            x += m_MoveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            x *= 2;
            y *= 2;
            z *= 2;
        }

        transform.Translate(new Vector3(x, y, z), Space.Self);
    }
}
