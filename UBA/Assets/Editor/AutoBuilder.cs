using UnityEditor;
using UnityEngine;
using System;

public static class AutoBuilder
{

    private static string GetProjectName()
    {
        string[] s = Application.dataPath.Split('/');
        string projectName = s[s.Length - 2];
        Debug.Log("project Name: " + projectName);
        return projectName;
    }

    [MenuItem("AutoBuilder/Build Android")]
    static void PerformAndroidBuild()
    {

        string formattedTimeStamp =
            System.DateTime.Now.Day.ToString()      + "-" +
            System.DateTime.Now.Month.ToString()    + "-" +
            System.DateTime.Now.Year.ToString()     + "[" +
            System.DateTime.Now.Hour.ToString()     + ":" +
            System.DateTime.Now.Minute.ToString()   + "]";

        Debug.Log(formattedTimeStamp);

        EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.Android);
        BuildPipeline.BuildPlayer(

            new string [] {"Assets/Scenes/MainScene.unity"}, 
            "Builds/Android/" + GetProjectName() + "-" + formattedTimeStamp + ".apk", 
            BuildTarget.Android, 
            BuildOptions.None

        );

    }

}