using UnityEngine;
using System.Collections;

public class BattleController : StateMachine
{
	public CameraRig cameraRig;
	public Level level;
	public LevelData levelData;
	public Transform tileSelectionIndicator;
	public Point pos;

	// Use this for initialization
	void Start()
	{
		ChangeState<InitBattleState>();
	}
}
