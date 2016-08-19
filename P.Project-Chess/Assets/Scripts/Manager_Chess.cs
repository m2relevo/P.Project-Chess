using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Manager_Chess : MonoBehaviour
{
	//Arrays for easy *poof* of objects and reference
	private List<GameObject> Board = new List<GameObject>();
	private List<GameObject> Pieces_White = new List<GameObject>();
	private List<GameObject> Pieces_Black = new List<GameObject>();

	//Board legnth(X) and Width(Y) for board size
	private int Board_Length;
	private int Board_Width;

	//Game Objects for board and board pieces
	public GameObject Board_Whitetile;
	public GameObject Board_Blacktile;

    public GameObject White_Pawn;
    public GameObject White_Rook;
    public GameObject White_Knight;
    public GameObject White_King;
    public GameObject White_Queen;
    public GameObject White_Bishop;

    public GameObject Black_Pawn;
    public GameObject Black_Rook;
    public GameObject Black_Knight;
    public GameObject Black_King;
    public GameObject Black_Queen;
    public GameObject Black_Bishop;

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
                Chess_BlackPieces(x, y);
                Chess_WhitePieces(x, y);
			}
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void Chess_Tile (int BoardX, int BoardY)
	{
        if (BoardY % 2 == 0)//Board Even Y
        {
            if (BoardX % 2 == 1)//Board Odd X
            {
                GameObject Tile_White = Instantiate(Board_Whitetile, new Vector3(0f + BoardX, 0f + BoardY, 0f), Quaternion.identity) as GameObject;
                Board.Add(Tile_White);
            }

            if (BoardX % 2 == 0)//Board Even X
            {
                GameObject Tile_Black = Instantiate(Board_Blacktile, new Vector3(0f + BoardX, 0f + BoardY, 0f), Quaternion.identity) as GameObject;
                Board.Add(Tile_Black);
            }
        }

        if (BoardY % 2 == 1)//Board Even Y
        {
            if (BoardX % 2 == 0)//Board Even X
            {
                GameObject Tile_White = Instantiate(Board_Whitetile, new Vector3(0f + BoardX, 0f + BoardY, 0f), Quaternion.identity) as GameObject;
                Board.Add(Tile_White);
            }

            if (BoardX % 2 == 1)//Board Odd X
            {
                GameObject Tile_Black = Instantiate(Board_Blacktile, new Vector3(0f + BoardX, 0f + BoardY, 0f), Quaternion.identity) as GameObject;
                Board.Add(Tile_Black);
            }
        }
	}

    void Chess_BlackPieces(int BoardX, int BoardY)
    {
        if (BoardY == 0)
        {
            if (BoardX == 0)//Spawn First Black Rook (0,0)
            {
                GameObject Pieces_Black_Rook = Instantiate(Black_Rook, new Vector3(0f + BoardX, 0f + BoardY, 1f), Quaternion.identity) as GameObject;
                Pieces_Black.Add(Pieces_Black_Rook);
            }

            if (BoardX == 7)//Spawn Second Black Rook (0,7)
            {
                GameObject Pieces_Black_Rook = Instantiate(Black_Rook, new Vector3(0f + BoardX, 0f + BoardY, 1f), Quaternion.identity) as GameObject;
                Pieces_Black.Add(Pieces_Black_Rook);
            }
        }

        if (BoardY == 1)
        {
            GameObject Pieces_Black_Pawn = Instantiate(Black_Pawn, new Vector3(0f + BoardX, 0f + BoardY, 1f), Quaternion.identity) as GameObject;
            Pieces_Black.Add(Pieces_Black_Pawn);
        }
    }

    void Chess_WhitePieces(int BoardX, int BoardY)
    {

    }
}
