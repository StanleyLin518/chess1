using UnityEngine;
using System.Collections;
using UnityEngine.UI; 
using System;
using System.Collections.Generic;

public class ChessScript : MonoBehaviour {
	public static ChessScript controll;

//	public Player player = new Player();
	public GameObject grids;
	public Grid[] CheckGrids;
	public int Flag_coordinatesx;
	public int Flag_coordinatesy;

	public List<Image> FlagUseGrid = new List<Image> ();

	public bool selectobject;
	public TYPE type;
	public Player selectplayer;

	void Awake()
	{
		controll = this;
	}

	void Start () 
	{
		CheckGrids = grids.GetComponentsInChildren<Grid> (); 
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

}
