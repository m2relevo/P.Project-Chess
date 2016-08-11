using UnityEngine;
using System.Collections;

public class Manager_Chess : MonoBehaviour
{
	//Arrays for easy *poof* of objects and reference
	public GameObject[] Board;
	public GameObject[] Pieces_White;
	public GameObject[] Pieces_Black;

	//Board legnth(X) and Width(Y) for board size
	public int Board_Length;
	public int Board_Width;

	//Game Objects for board and board pieces
	public GameObject Board_Test;

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

				object BoardTest = Instantiate(Board_Test, new Vector3(0f+x, 0f+y, 0f), Quaternion.identity);
			}
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
