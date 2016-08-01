using UnityEditor;
using UnityEngine;
using System.Collections;

[CustomEditor(typeof(LevelEditor))]
public class LevelEditorInspector : Editor
{
	public LevelEditor current {
		get {
			return (LevelEditor)target;
		}
	}

	public override void OnInspectorGUI()
	{
		DrawDefaultInspector();

		if (GUILayout.Button("Reset")) {
			current.Reset();
		}
		if (GUILayout.Button("Grow")) {
			current.Grow();
		}
		if (GUILayout.Button("Shrink")) {
			current.Shrink();
		}
		if (GUILayout.Button("Grow Area")) {
			current.GrowArea();
		}
		if (GUILayout.Button("Shrink Area")) {
			current.ShrinkArea();
		}
		if (GUILayout.Button("Save")) {
			current.Save();
		}
		if (GUILayout.Button("Load")) {
			current.Load();
		}
		if (GUI.changed) {
			current.UpdateMarker();
		}
	}

	void OnSceneGUI()
	{
		Event e = Event.current;
		switch(e.type)
		{
		case EventType.keyDown:
			{
				if(Event.current.keyCode == (KeyCode.A))
				{
					current.MoveMarkerLeft();
				}
				if(Event.current.keyCode == (KeyCode.D))
				{
					current.MoveMarkerRight();
				}
				if(Event.current.keyCode == (KeyCode.W))
				{
					current.MoveMarkerUp();
				}
				if(Event.current.keyCode == (KeyCode.S))
				{
					current.MoveMarkerDown();
				}
				break;
			}
		}
	}
}
