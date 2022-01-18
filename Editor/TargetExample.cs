using UnityEditor;
using UnityEngine;

public class TargetExample
{
    [DrawGizmo(GizmoType.Active | GizmoType.Selected)]
    //第一个参数需要指定目标类，目标类需要挂载在场景对象中
    private static void MyCustomOnDrawGizmos(GizmosExample target, GizmoType gizmoType)
    {
        var color = Gizmos.color;
        Gizmos.color = Color.red;
        //target为挂载该组件的对象
        Gizmos.DrawCube(target.transform.position, Vector3.one);
        Gizmos.color = color;
    }
}
