using UnityEngine;
using System.Collections;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Rook : Player {

	public string[] coordinate;

	protected override void onClick_selectchess()
	{
		Debug.Log ("ss");
		base.onClick_selectchess ();


		ChessScript.controll.selectplayer = this;
		coordinate = transform.parent.gameObject.name.Split ('-');
		ChessScript.controll.Flag_coordinatesx = Convert.ToInt32 (coordinate[0]);
		ChessScript.controll.Flag_coordinatesy = Convert.ToInt32 (coordinate[1]);


//		if (x == 0)
//		{
//			posY = ChessScript.controll.onClickpositiony;
//		} 
//		else if (y == 0) 
//		{
//			posX = ChessScript.controll.onClickpositionx;
//		}
		Debug.Log ("posY" + posY);
		Debug.Log ("posY" + posY);
//		Debug.Log ("newposX" + newposX);
//		Debug.Log ("newposY" + newposY);
//		ChessScript.controll.SelectFlagPosition = (posX) + "-" + (posY);
	}
}
