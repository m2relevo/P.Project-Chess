using UnityEngine;
using System.Collections;

public class Manager_Chess : MonoBehaviour
{
	//Arrays for easy *poof* of objects and reference
	private GameObject[] Board;
	private GameObject[] Pieces_White;
	private GameObject[] Pieces_Black;

	//Board legnth(X) and Width(Y) for board size
	private int Board_Length;
	private int Board_Width;

	//Game Objects for board and board pieces
	public GameObject Board_Whitetile;
	public GameObject Board_Blacktile;

	void Awake()
	{
		Board_Width = 8;
		Board_Length = 8;
	}

	// Use this for initialization
	void Start ()
	{
		for (int x = 0; x < Board_Width; x++)
		{
			Debug.Log ("Board Width = " + Board_Width + "|| X = " + x);

			for (int y = 0; y < Board_Length; y++)
			{
				Debug.Log ("Board Length = " + Board_Length + "|| Y = " + y);
				Chess_Tile (x, y);
			}
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void Chess_Tile (int BoardX, int BoardY)
	{
		if(BoardX % 2 == 1 && BoardY % 2 == 0)//Board Odd X
		{
			object Tile_White = Instantiate (Board_Whitetile, new Vector3 (0f + BoardX, 0f + BoardY, 0f), Quaternion.identity);
		}

		if(BoardX % 2 == 0 && BoardY % 2 == 1)//Board Odd X
		{
			object Tile_Black = Instantiate (Board_Whitetile, new Vector3 (0f + BoardX, 0f + BoardY, 0f), Quaternion.identity);
		}

		if (BoardX % 2 == 0 && BoardY % 2 == 1)//Board Even X
		{
			object Tile_White = Instantiate (Board_Whitetile, new Vector3 (0f + BoardX, 0f + BoardY, 0f), Quaternion.identity);
		}

		if(BoardX % 2 == 1 && BoardY % 2 == 0)//Board Odd X
		{
			object Tile_Black = Instantiate (Board_Blacktile, new Vector3 (0f + BoardX, 0f + BoardY, 0f), Quaternion.identity);
		}
	}
}
