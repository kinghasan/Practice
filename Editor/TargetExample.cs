using UnityEditor;
using UnityEngine;

public class TargetExample
{
    [DrawGizmo(GizmoType.Active | GizmoType.Selected)]
    //��һ��������Ҫָ��Ŀ���࣬Ŀ������Ҫ�����ڳ���������
    private static void MyCustomOnDrawGizmos(GizmosExample target, GizmoType gizmoType)
    {
        var color = Gizmos.color;
        Gizmos.color = Color.red;
        //targetΪ���ظ�����Ķ���
        Gizmos.DrawCube(target.transform.position, Vector3.one);
        Gizmos.color = color;
    }
}
