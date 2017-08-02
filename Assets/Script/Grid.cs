using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using System;

public class Grid : MonoBehaviour {
	public static Grid controll;
	public int x;
	public int y;
	public int posX;
	public int posY;

	public string[] coordinatess;

	void Awake()
	{
		controll = this;
	}
	// Use this for initialization
	void Start () {
		
		GetComponent<Button>().onClick.AddListener(onClick_btn_grid);
		coordinatess = transform.gameObject.name.Split ('-');
		posX = Convert.ToInt32 (coordinatess[0]);
		posY = Convert.ToInt32 (coordinatess[1]);	}

	// Update is called once per frame
	void Update () {
		
	}
	public void onClick_btn_grid()
	{
		if (ChessScript.controll.selectobject == true)
		{
			ChessScript.controll.selectplayer.transform.SetParent (transform);
			ChessScript.controll.selectplayer.transform.localPosition = Vector2.zero;
//			ChessScript.controll.Flag_newcoordinatesx - ChessScript.controll.Flag_coordinatesx;
//			posX = x - ChessScript.controll.Flag_newcoordinatesx;
//			posY = y - ChessScript.controll.Flag_newcoordinatesy;
//
//			ChessScript.controll.SelectFlagPosition = posX + "-" + posY;
//
//			transform.SetParent (GameObject.Find (ChessScript.controll.SelectFlagPosition).transform);
//			GetComponent<RectTransform> ().localPosition = Vector2.zero;
//			Debug.Log ("ccc");
//			ChessScript.controll.player.FlagMove ();
//
//			ChessScript.controll.player = null;
//			ChessScript.controll.type = TYPE.None;
			ChessScript.controll.selectobject = false;
		}
		else 
		{
			
		}
//		ChessScript.controll.player.x = 0;
//		ChessScript.controll.player.y = 0;
	}

//	public virtual void FlagMove ()
//	{
//		if (ChessScript.controll.player != null) {
//			Debug.Log ("ccc");
//			ChessScript.controll.player.FlagMove ();
//		}
//	}
}
