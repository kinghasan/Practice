using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmosExample : MonoBehaviour
{
    //绘制效果一直显示
    private void OnDrawGizmos()
    {
        var color = Gizmos.color;
        Gizmos.color = Color.yellow;
        Gizmos.DrawCube(transform.position, Vector3.one);
        Gizmos.color = color;
    }
    //绘制效果在选中对象时显示
    private void OnDrawGizmosSelected()
    {
        var color = Gizmos.color;
        Gizmos.color = Color.white;
        Gizmos.DrawWireCube(transform.position, Vector3.one);
        Gizmos.color = color;
    }
}
