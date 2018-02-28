using UnityEngine;
using UnityEngine.UI; //To access Text object
using System.Collections;

public class TextController : MonoBehaviour {
	
	//Provides access to the Text object
	public Text text;
	
	//Enum for each state
	private enum States {Cell, Mirror, Sheets_0, Lock_0, Cell_Mirror, Sheets_1, Lock_1, Freedom};
	
	//State object
	private States myState;
	  
	// Use this for initialization
	void Start () {
		//Initialize state to cell
		myState = States.Cell;
	}
	
	// Update is called once per frame
	void Update () {
		print(myState);
		if(myState == States.Cell)					{state_cell();} 
		else if ( myState == States.Sheets_0)		{state_sheets_0();}
		else if ( myState == States.Sheets_1)		{state_sheets_1();}  
		else if ( myState == States.Lock_0)			{state_lock_0();}
		else if ( myState == States.Lock_1) 		{state_lock_1();}
		else if ( myState == States.Mirror) 		{state_mirror ();}
		else if ( myState == States.Cell_Mirror)	{state_cell_mirror();}
		else if ( myState == States.Freedom) 		{state_freedom();}
		else { print ("Error: Something went wrong. Current State = " + myState);}
	}
	void state_cell (){
		text.text = "You've been framed! You were thrown into a prison" + 
					" cell, and now you need to escape. There are some dirty sheets" + 
					" on the bed, a mirror on the wall, and the door" +
					" is locked from the outside. Be careful not to attract the" +
					" attention of the prison guards.\n\n" +
					"Press S to view sheets, M to view the mirror, and L to try" +
					" the lock.";

		if(Input.GetKeyDown (KeyCode.S))		{myState = States.Sheets_0;}
		else if(Input.GetKeyDown (KeyCode.M))	{myState = States.Mirror;}
		else if(Input.GetKeyDown (KeyCode.L))	{myState = States.Lock_0;}
	}
	void state_sheets_0 (){
		text.text = "Ugh! These sheets are dirty. The pleasures of prison life, " + 
					" I suppose. \n\n" + 
					"Press R to Return to roaming your cell";	
		if(Input.GetKeyDown (KeyCode.R))		{myState = States.Cell;}
	}
	void state_sheets_1 (){
		text.text = "Yup, the sheets are still dirty... You really need to get out" + 
					" of here. \n\n" + 
					"Press R to Return to roaming your cell";	
		if(Input.GetKeyDown (KeyCode.R))		{myState = States.Cell_Mirror;}
	}
	void state_mirror(){
		text.text = "The dirty old mirror on the wall seems loose.\n\n" + 
					"Press T to Take the mirror, or R to Return to your cell";
		if(Input.GetKeyDown(KeyCode.T))			{myState = States.Cell_Mirror;}	
		else if(Input.GetKeyDown (KeyCode.R))	{myState = States.Cell;}
	}
	void state_cell_mirror(){
		text.text = "You are still in your cell, and you STILL want to escape!" + 
					" There are some dirty sheets on the bed, a mark where the" + 
					" mirror was, and that pesky door is still firmly locked! \n\n " +
					"Press S to view the Sheets, L to view the Lock, or R to put the Mirror back and take a nap";
		if(Input.GetKeyDown(KeyCode.S))			{myState = States.Sheets_1;}	
		else if(Input.GetKeyDown (KeyCode.L))	{myState = States.Lock_1;}
		else if(Input.GetKeyDown (KeyCode.R))	{myState = States.Cell;}
	}

	void state_lock_0 (){
		text.text = "This is a combination lock and you don't know the combination." + 
					" If only you could see the dirty fingerprints on the" +
					" lock. Maybe that would help. \n\n" + 
					"Press R to Return to roaming your cell";
		if(Input.GetKeyDown (KeyCode.R))		{myState = States.Cell;}
	}
	void state_lock_1 (){
		text.text = "You carefully put the mirror throught the bars, and turn it around" + 
					" so you can see the lock. You can just make out the fingerprints around" +
					" the buttons. You press the dirty buttons, and hear a click \n\n" + 
					"Press O to Open or R to Return to roaming your cell";
		if (Input.GetKeyDown (KeyCode.O)) 		{myState = States.Freedom;}
		else if(Input.GetKeyDown (KeyCode.R))	{myState = States.Cell_Mirror;}
	}
	void state_freedom (){
		text.text = "You are free! Hurry run!\n\n" +
					"Press P to Play Again.";
		if(Input.GetKeyDown (KeyCode.P))		{myState = States.Cell;} 
	}
}
