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
		if(myState == States.Cell){
			state_cell();
		} else if ( myState == States.Sheets_0){
			state_sheets_0();
		}
	}
	void state_cell (){
		text.text = "You've been framed! You were thrown into a prison" + 
					" cell, and now you need to escape. There are some dirty sheets" + 
					" on the bed, a mirror on the wall, and the door" +
					" is locked from the outside. Be careful not to attract the" +
					" attention of the prison guards.\n\n" +
					"Press S to view sheets, M to view the mirror, and L to try" +
					" the lock.";

		if(Input.GetKeyDown (KeyCode.S)){
			myState = States.Sheets_0;
		}
	}
	void state_sheets_0 (){
		text.text = "Ugh! These sheets are dirty. The pleasures of prison life, " + 
					" I suppose. \n\n" + 
					"Press R to Return to roaming your cell";
		
		if(Input.GetKeyDown (KeyCode.R)){
			myState = States.Cell;
		}
	}
}
