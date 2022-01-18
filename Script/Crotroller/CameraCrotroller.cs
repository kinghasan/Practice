using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCrotroller : MonoBehaviour
{
    public Transform m_Player;
    private Vector3 m_Offset;

    private void Awake()
    {
        //m_Offset = transform.position - m_Player.position;
        m_Offset = new Vector3(0, 5, -7);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetposition = m_Player.position + m_Player.TransformDirection(m_Offset);
        transform.position = targetposition;
    }
}
