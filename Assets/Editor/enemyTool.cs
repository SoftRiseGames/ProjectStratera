using UnityEngine;

using UnityEditor;

[CustomEditor(typeof(EnemyEditor))]
public class enemyTool : Editor
{

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        EnemyEditor enemyEditor = (EnemyEditor)target;
        if (GUILayout.Button("Spawner"))
        {
            enemyEditor.artis();
        }
    }
}
