using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Level : MonoBehaviour
{
	[SerializeField]
	GameObject tilePrefab;
	public Dictionary<Point, Tile> tiles = new Dictionary<Point, Tile>();

	public void Load(LevelData data)
	{
		for(int i = 0; i < data.Tiles.Count; i++)
		{
			GameObject instance = Instantiate(tilePrefab) as GameObject;
			Tile t = instance.GetComponent<Tile>();
			t.Load(data.Tiles[i]);
			tiles.Add(t.pos, t);
		}
	}
}
