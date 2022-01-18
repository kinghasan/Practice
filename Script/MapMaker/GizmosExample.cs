using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmosExample : MonoBehaviour
{
    //����Ч��һֱ��ʾ
    private void OnDrawGizmos()
    {
        var color = Gizmos.color;
        Gizmos.color = Color.yellow;
        Gizmos.DrawCube(transform.position, Vector3.one);
        Gizmos.color = color;
    }
    //����Ч����ѡ�ж���ʱ��ʾ
    private void OnDrawGizmosSelected()
    {
        var color = Gizmos.color;
        Gizmos.color = Color.white;
        Gizmos.DrawWireCube(transform.position, Vector3.one);
        Gizmos.color = color;
    }
}
