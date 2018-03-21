//Author: Evan Brooks
//Date: 3/19/2018
//Subject: Text Class

//Import namespaces for needed functionality
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{

	//Global variable / 'field'
	public Text textMain;

	//Setup enumeration 'States' to use for gamestate options
	private enum States
	{
		introduction,
		phase0,
		phase1,
		speak,
		touch,
		light,
		phase2,
		phase3,
		where,
		why,
		who,
		phase4,
		phase5,
		gameover
	}

	//Setup variable of States type to hold gameStates
	private States gameState;

	// Use this for initialization 
	void Start()
	{
		//Start game with State introduction
		gameState = States.introduction;
	}

	// Update is called once per frame
	void Update()
	{
		//Game State Engine
		//Refactoring code for brevity

		#region State Machine

		//Format: 'if gameState equals X State than call X method'
		if (gameState == States.introduction)	{ state_introduction(); }
		else if (gameState == States.phase0)	{ state_phase0(); }
		else if (gameState == States.phase1)	{ state_phase1(); }
		else if (gameState == States.speak)		{ state_speak(); }
		else if (gameState == States.touch)		{ state_touch(); }
		else if (gameState == States.light)		{ state_light(); }
		else if (gameState == States.phase2)	{ state_phase_2(); }
		else if (gameState == States.phase3)	{ state_phase_3(); }
		else if (gameState == States.where)		{ state_where(); }
		else if (gameState == States.why)		{ state_why(); }
		else if (gameState == States.who)		{ state_who(); }
		else if (gameState == States.phase4)	{ state_phase_4(); }
		else if (gameState == States.phase5)	{ state_phase_5(); }
		else if (gameState == States.gameover)	{ state_gameover(); }

		#endregion
	}

	/* Introduction States______________________________________________________________________________________________________________*/
	/*__________________________________________________________________________________________________________________________________*/

	#region Introduction

	//This method runs when the gameState variable is equal to its namesake gameState
	void state_introduction()
	{
		//Output text to the Text_Main txtbox
		textMain.text = "Welcome to Prison. \n\n" + //2 new lines
						"Press [SPACE] to continue";

		//If input X is pressed, set gameState variable to State Y
		if (Input.GetKeyDown(KeyCode.Space))
		{
			gameState = States.phase0;
		}
	}

	void state_phase0()
	{
		textMain.text = "A flash. Conciousness. Suddenly you can feel again . . . think again. A chill. Your bare back " +
						"presses against something. Its familiar. Metal. Slowly, your eyes open- blinking to adjust " +
						"as a dingy yellow light filters through. A drab room of dark steel and rust comes into " +
						"focus. Four walls. No windows. No doors. A box. A prison . . . \n\n" + //2 new lines
						"[SPACE] Continue";

		if (Input.GetKeyDown(KeyCode.Space))
		{
			gameState = States.phase1;
		}
	}

	#endregion

	/* Phase One States_________________________________________________________________________________________________________________*/
	/*__________________________________________________________________________________________________________________________________*/

	#region Phase One

	void state_phase1()
	{
		textMain.text = "A way out. You need a way out. You stand up and begin to think. . . \n\n" + //2 new lines
						"[1] Call for help. \n" +
						"[2] Touch the walls. \n" +
						"[3] Touch the light.";

		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			gameState = States.speak;
		}
		else if (Input.GetKeyDown(KeyCode.Alpha2)) {
			gameState = States.touch;
		}
		else if (Input.GetKeyDown(KeyCode.Alpha3))
		{
			gameState = States.light;
		}
	}

	void state_speak()
	{
		textMain.text = "You listen to the stiff quietness of the empty room and wonder if anyone \n" +
						"can hear or see you. Wondering if you should try to speak, you swallow and lick \n" +
						"your dry lips. It is worth a shot. With hesitation you start: \n\n" + //2 new lines
						"'Hello?' \n\n" + //2 new lines
						"[SPACE] Continue";

		if (Input.GetKeyDown(KeyCode.Space))
		{
			gameState = States.phase2;
		}
	}

	void state_touch()
	{
		textMain.text = "You look across the barren walls corroded with rust and scarred with \n" +
						"scratches. Nowhere is there any indication of entry, but you decide to feel \n" +
						"the walls for switches. Moving around the room, you slide your hands across \n" +
						"each wall searching for something, anything. Battered . . . but nothing gives \n\n" + //2 new lines
						"[1] Try something else.";

		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			gameState = States.phase1;
		}
	}

	void state_light()
	{
		textMain.text = "You look at the glowing light embedded in the rusted ceiling above. \n" +
						"Being the only prominent feature of the room, you decide to touch it. \n" +
						"With arms outstreched above your head, you press the glowing panel with \n" +
						"your fingers. Warm to the touch . . . but nothing else. \n\n" + //2 new lines
						"[1] Try something else.";

		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			gameState = States.phase1;
		}

	}

	#endregion

	/* Phase Two and Three States_______________________________________________________________________________________________________*/
	/*__________________________________________________________________________________________________________________________________*/

	#region Phase Two + Three

	void state_phase_2()
	{
		textMain.text = "A sharp whine splits the air and you shake in sudden surprise. A deep hum \n" +
						"follows the noise and a synthetic voice begins to speak . . . concise and cold: \n\n" + //2 new lines
						"'Prisoner 3248, your detenion is not yet over. Please remain quiet.' \n\n" +
						"[SPACE] Continue";

		//If spacebar is pressed, output new text to Text_Main txtbox
		if (Input.GetKeyDown(KeyCode.Space))
		{
			gameState = States.phase3;
		}
	}

	void state_phase_3()
	{
		textMain.text = "The whine stops, but the humming persists. Its listening. You decide you must \n" +
						"say something, but you pick your words carefully. . . \n\n" + //2 new lines
						"[1] Where am I? \n" +
						"[2] Why am I here? \n" +
						"[3] Who are you?";

		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			gameState = States.where;
		}
		else if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			gameState = States.why;
		}
		else if (Input.GetKeyDown(KeyCode.Alpha3))
		{
			gameState = States.who;
		}
	}

	void state_where()
	{
		textMain.text = "You wonder if 'it' will tell you where you are. You could be anywhere . . . \n" +
						"there was simply no way to tell and it was worth an ask. You decide to put the \n" +
						"question simply and ask: \n\n" + //2 new lines
						"'Where am I?' \n\n" + //2 new lines
						"Again the whine splits the air and the voice responds coldly: \n\n" + //2 new lines
						"'Detention Facility 322.' \n\n" + //2 new lines
						"[1] Ask something else.";

		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			gameState = States.phase3;
		}
	}

	void state_why()
	{
		textMain.text = "You cannot believe it. 'Prisoner'? '3248'? What happened? You try to collect \n" +
						"your memory, but nothing comes back to you. You decide to find out why you are \n" +
						"here and ask: \n\n" + //2 new lines
						"'Why am I here?' \n\n" + //2 new lines
						"The whine again. The splitting air. The voice replies: \n\n" + //2 new lines
						"'Convicted of Penalty 8745' \n\n" + //2 new lines
						"[1] Ask something else.";

		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			gameState = States.phase3;
		}
	}

	void state_who()
	{
		textMain.text = "That voice. It wasn't human. Is it automated? Is it an AI? You consider the \n" +
						"possibility of self-awareness and wonder if 'it' can address such a question. \n" +
						"You decide to find out: \n\n" + //2 new lines
						"'Who are you?' \n\n" + //2 new lines
						"Splitting whine. It lingers. Your ears pop. The voice stutters: \n\n" + //2 new lines
						"'Wh-who-o a-am I-I-I?' \n\n" + //2 new lines
						"[SPACE] Continue";

		if (Input.GetKeyDown(KeyCode.Space))
		{
			gameState = States.phase4;
		}
	}

	#endregion

	/* Phase Four and Five States_______________________________________________________________________________________________________*/
	/*__________________________________________________________________________________________________________________________________*/

	#region Phase Four + Five

	void state_phase_4()
	{
		textMain.text = "Suddenly the whine stops. The humming stops. Quiet. The air is still again \n" +
						"and you look around . . . waiting. The light dims. It shuts off. Darkness. \n" +
						"You feel cold. The darkness presses against you as the confines of the box \n" +
						"feel greater than ever. \n\n" + //2 new lines
						"[SPACE] Continue";

		if (Input.GetKeyDown(KeyCode.Space))
		{
			gameState = States.phase5;
		}

	}

	void state_phase_5()
	{
		textMain.text = "Just as the pressure of the silence and the darkness seems to consume you \n" +
						"a bright streak of blue light cut through one of the walls- from top to bottom. \n" +
						"The light slowly began to widen into a band as the wall seemed to pull itself apart. \n" +
						"You raise your hand and shield your eyes as bright light begins to flood the room \n" +
						"accompanied by a rush of warm air. The light begans to settle, and you drop your \n" +
						"hand to see the room empty into a sterile white hallway. . . \n\n" +
						"[SPACE] Escape.";

		if (Input.GetKeyDown(KeyCode.Space))
		{
			gameState = States.gameover;
		}
	}

	#endregion

	/* Phase Gameover___________________________________________________________________________________________________________________*/
	/*__________________________________________________________________________________________________________________________________*/

	#region Phase Gameover

	void state_gameover()
	{
		textMain.text = "Game Over! \n\n" + //2 new lines
						"[SPACE] Play Again. \n" +
						"[E] Exit Game. \n";

		if (Input.GetKeyDown(KeyCode.Space))
		{
			gameState = States.introduction;
		}
		else if (Input.GetKeyDown(KeyCode.E))
		{
			Application.Quit();
		}
	}

	#endregion

}
