using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using UnityEngine;

public class Player : MonoBehaviour 
{
	public int camp;	//顏色
	public string kind;    //陣營

	public int posX;
	public int posY;

	public int x = 0;
	public int y = 0;

	public int xx;
	public int yy;

//	public string SelectFlagPosition_x_y;
//	public TYPE types;

	// Use this for initialization
	void Start () 
	{
		GetComponent<Button>().onClick.AddListener (onClick_selectchess);

//		SelectFlagPosition_x_y = posX +"-"+ posY;
//		GetComponent<Button>().onClick.AddListener (onClick_selectchess);
//    	name = GetComponent<Button>().targetGraphic.ToString();
//		flagtype ();
	}

//	public void flagtype()
//	{
//		if (SelectFlagPosition_x_y == "7-1" || SelectFlagPosition_x_y == "2-1") {
//			types = TYPE.Kinght;
//		} else if (SelectFlagPosition_x_y == "1-1" || SelectFlagPosition_x_y == "8-1") {
//			types = TYPE.Rook;
//		} else if (SelectFlagPosition_x_y == "1-2" || SelectFlagPosition_x_y == "2-2" || SelectFlagPosition_x_y == "3-2" || SelectFlagPosition_x_y == "4-2"
//			|| SelectFlagPosition_x_y == "5-2"|| SelectFlagPosition_x_y == "6-2" || SelectFlagPosition_x_y == "7-2" || SelectFlagPosition_x_y == "8-2") {
//			types = TYPE.Pawn;
//		} else if (SelectFlagPosition_x_y == "4-1") {
//			types = TYPE.Queen;
//		}
//		else if (SelectFlagPosition_x_y == "5-1") {
//			types = TYPE.King;
//		}
//		else if (SelectFlagPosition_x_y == "3-1" || SelectFlagPosition_x_y == "6-1") {
//			types = TYPE.Bishop;
//		}
//	}
	
	// Update is called once per frame
//	public virtual void FlagMove()
//	{
//		Debug.Log ("abc");
//		ChessScript.controll.onClickpositionx = x;
//		ChessScript.controll.onClickpositiony = y;

//		newposX = ChessScript.controll.onClickpositionx;
//		newposY = ChessScript.controll.onClickpositiony;
//		x = ChessScript.controll.onClickpositionx - posX;
//		y = ChessScript.controll.onClickpositiony - posY;
//		Debug.Log ("x" + x);
//		Debug.Log ("y" + y);

//		btn_selectchess.GetComponent<Image> ().color = Color.white;
//		if (types == TYPE.Rook) 
//		{
//			Rook r = new Rook ();
//			r.FlagMove ();
//		}
//		else if (types == TYPE.Pawn) 
//		{
//			if (y == 1) 
//			{
//				posY = posY + y;
//			}
//		}
//		else if (types == TYPE.Kinght) 
//		{
//			if (x == 2 && y == 1 || x == -2 && y == 1 || x == -2 && y == -1 || x == 2 && y == -1 || x == 1 && y == 2|| x == -1 && y == 2|| x == 1 && y == -2|| x == -1 && y == -2) {
//				posX = newposX;
//				posY = newposY;
//			}	
//		}
//		else if (types == TYPE.Queen) 
//		{
//
//		}
//		else if (types == TYPE.King) 
//		{
//			
//		}
//		else if (types == TYPE.Bishop) 
//		{
//			if (x == 1 && y == 1 || x == 2 && y == 2 || x == 3 && y == 3 || x == 4 && y == 4 || x == 5 && y == 5|| x == 6 && y == 6|| x == 7 && y == 7
//				||x == -1 && y == -1 || x == -2 && y == -2 || x == -3 && y == -3 || x == 4 && y == -4 || x == -5 && y == -5|| x == -6 && y == -6|| x == -7 && y == -7) 
//			{
//				posX = newposX;
//				posY = newposY;
//			}
//		}

//		StartCoroutine (movpos());
//	}

//	public IEnumerator movpos()
//	{
//		yield return new WaitForSeconds(0.2f);
//		ChessScript.controll.SelectFlagPosition = (posX) + "-" + (posY);
//		transform.SetParent (GameObject.Find (ChessScript.controll.SelectFlagPosition).transform);
//		GetComponent<RectTransform> ().localPosition = new Vector3 (0, 0, 0);
//	}

	protected virtual void onClick_selectchess()
	{
		Debug.Log ("abc");
		if (ChessScript.controll.selectobject == false) 
		{
//			ChessScript.controll.player = GetComponent<Player> ();
//			FlagMove ();
//			ChessScript.controll.onClickpositionx = posX;
//			ChessScript.controll.onClickpositiony = posY;

//			ChessScript.controll.SelectFlagPosition = posX + "-" + posY;
//			playerselect ();
			GetComponent<Button> ().image.color = Color.gray;

			ChessScript.controll.selectobject = true;
		}
		else 
		{
			
//			transform.SetParent (GameObject.Find (ChessScript.controll.SelectFlagPosition).transform);
//			GetComponent<RectTransform> ().localPosition = new Vector3 (0, 0, 0);
		}
	}
		
//	public void playerselect()
//	{
//		GetComponent<Button> ().image.color = Color.white;
//		TYPE ststus = types;
//		switch (ststus)
//			{
//		case TYPE.None:
//			ChessScript.controll.type = TYPE.None;
//				break;
//		case TYPE.King:
//			ChessScript.controll.type = TYPE.King;
//			break;
//		case TYPE.Queen:
//			ChessScript.controll.type = TYPE.Queen;
//			break;
//		case TYPE.Kinght:
//			ChessScript.controll.type = TYPE.Kinght;
//				break;
//		case TYPE.Bishop:
//			ChessScript.controll.type = TYPE.Bishop;
//			break;
//		case TYPE.Rook:
//			ChessScript.controll.type = TYPE.Rook;
//			break;
//		case TYPE.Pawn:
//			ChessScript.controll.type = TYPE.Pawn;
//				break;
//		}
//	}
}
	public enum TYPE : int
	{
		None=0,
		King=1, 
		Queen=2, 
		Bishop=3, 
		Rook=4, 
		Kinght=5, 
		Pawn=6 
	}
	public enum color
	{
		White,
		Black
	}


//	public enum TYPE : int
//	{
//		None=0,
//		King=1, 
//		Queen=2, 
//		Bishop=3, 
//		Rook=4, 
//		Kinght=5, 
//		Pawn=6 
//	}
//	public enum color
//	{
//		White,
//		Black
//	}
 