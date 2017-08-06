using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rook : Player {

	public string[] coordinate;

	protected override void onClick_selectchess()
	{
		Debug.Log ("ss");

        if (ChessScript.Instance.Turn_Camp == Force)
        {
            ChessScript.Instance.selectplayer = this;
            coordinate = transform.parent.gameObject.name.Split('-');
            ChessScript.Instance.Flag_coordinatesx = Convert.ToInt32(coordinate[0]);
            ChessScript.Instance.Flag_coordinatesy = Convert.ToInt32(coordinate[1]);

            int x = Convert.ToInt32(coordinate[0]);
            int y = Convert.ToInt32(coordinate[1]);
        }
        else
        {
            base.onClick_selectchess();
        }


//		if (x == 0)
//		{
//			posY = ChessScript.controll.onClickpositiony;
//		} 
//		else if (y == 0) 
//		{
//			posX = ChessScript.controll.onClickpositionx;
//		}
        Debug.Log ("posX" + posX);
		Debug.Log ("posY" + posY);
//		Debug.Log ("newposX" + newposX);
//		Debug.Log ("newposY" + newposY);
//		ChessScript.controll.SelectFlagPosition = (posX) + "-" + (posY);
	}
}
