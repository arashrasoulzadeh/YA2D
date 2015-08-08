//version 0.1
//by Arash Rasoulzadeh
//contact me : arashrasoulzadeh@gmail.com


using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEditor;

[Serializable]
public class YA2D_engine : ScriptableObject
{
    public static float ver = 0.1f;

    //menu itesm

    [MenuItem("YA2D/Create/Side Scroll Camera")]
    public static void menu_create_sidescrollcamera()
    {
        func_createsidescrollcamera();
    }


    [MenuItem("YA2D/About")]
    public static void About()
    {
        EditorUtility.DisplayDialog("YA2D", "Yet Another 2D framework. \n\n arashrasoulzadeh@gmail.com \n\nversion:" + ver + " | darkeliden.github.io/YA2D ", "okay");
    }

















    //functions

    public static void func_createsidescrollcamera()
    {
        GameObject a = new GameObject();
        a.AddComponent<Camera>();
        a.AddComponent<YA2D_sidescrollcamera>();
        a.name = "side Scroll Camera";

        //  Instantiate(a);
    }





    //costum editors

    [CustomEditor(typeof(YA2D_sidescrollcamera))]
    public class editor_sidescrollcamera : Editor
    {

        public YA2D_sidescrollcamera scc;

        void OnEnable()
        {
            scc = target as YA2D_sidescrollcamera;
        }

        override public void OnInspectorGUI()
        {

            GUILayout.Label("Please transform camera in x direction to get the leftend and rightend of camera and set values using set button.\n\nif you using prespective camera,please set manualy\n\n", statics_getguilayout());

 


            
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Target : ");
            EditorGUILayout.ObjectField(scc.Target, typeof(GameObject));

            EditorGUILayout.EndHorizontal();


            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Left end : ");
            EditorGUILayout.TextField(scc.left + "");
            if (GUILayout.Button("Set"))
            { scc.left = scc.GetComponentInParent<Camera>().transform.position.x; }
            EditorGUILayout.EndHorizontal();


            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Right end : ");
            EditorGUILayout.TextField(scc.right + "");
            if (GUILayout.Button("Set"))
            { scc.right = scc.GetComponentInParent<Camera>().transform.position.x; }
            EditorGUILayout.EndHorizontal();

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Default FOV : ");
            EditorGUILayout.TextField(scc.mainfov + "");
            if (GUILayout.Button("Set"))
            { scc.mainfov = scc.GetComponentInParent<Camera>().fieldOfView; }
            EditorGUILayout.EndHorizontal();


            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Zoom FOV : ");
            EditorGUILayout.TextField(scc.zoomfov + "");
            if (GUILayout.Button("Set"))
            { scc.right = scc.GetComponentInParent<Camera>().fieldOfView; }
            EditorGUILayout.EndHorizontal();




        



            if (GUILayout.Button("Reset"))
            {
                scc.right = scc.GetComponentInParent<Camera>().transform.position.x;
                scc.left = scc.GetComponentInParent<Camera>().transform.position.x;
                scc.mainfov = scc.GetComponentInParent<Camera>().fieldOfView;
                scc.zoomfov = scc.GetComponentInParent<Camera>().fieldOfView;

            }

        }

    }





    //statics
    public static GUIStyle statics_getguilayout()
    {
        GUIStyle style = new GUIStyle();
        style.wordWrap = true;
        return style;
    }


}




