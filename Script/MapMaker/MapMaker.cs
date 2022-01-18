using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEditor;
using UnityEngine;

public class MapMaker : EditorWindow
{
    [MenuItem("MapMaker/Start")]
    private static void MapMakerCrotroller()
    {
        EditorWindow window = GetWindow<MapMaker>("MapMaker");
        window.Show();
    }

    //[MenuItem("CONTEXT/Rigidbody/Init")]
    //private static void Rightbody()
    //{
    //    Debug.Log("Rightbody");
    //}

    string xStr;
    string yStr;
    string errorText;

    private void OnGUI()
    {
        GUILayout.BeginHorizontal();
        GUILayout.Label("X");
        xStr = GUILayout.TextField(xStr);
        GUILayout.Label("Y");
        yStr = GUILayout.TextField(yStr);
        //Assert.IsEmpty(yStr, "YֵΪ��");
        //ֻ��������
        if (!string.IsNullOrEmpty(xStr))
            xStr = Regex.Replace(xStr, "[^\\d+]", "");
        if (!string.IsNullOrEmpty(yStr))
            yStr = Regex.Replace(yStr, "[^\\d+]", "");
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        if (GUILayout.Button("���ɵ�ͼ"))
        {
            if (string.IsNullOrEmpty(xStr) || string.IsNullOrEmpty(yStr))
            {
                errorText = "������X��Y";
            }
            else
            {
                Debug.Log(xStr + ":" + yStr);
                Debug.Log("��ʼ���ɵ�ͼ");
                int x = int.Parse(xStr);
                int y = int.Parse(yStr);
                GameObject map = new GameObject("Map");
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {

                    }
                }
            }
        }
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Label(errorText);
        GUILayout.EndHorizontal();

        GUILayout.Space(30);

        GUILayout.BeginHorizontal();
        if (GUILayout.Button("����"))
        {
            Debug.Log("��ʼ�����ͼ");
        }
        GUILayout.EndHorizontal();
    }
}
