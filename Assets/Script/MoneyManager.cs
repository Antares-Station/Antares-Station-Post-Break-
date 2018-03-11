using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour {

	public static int money;

	Text text;


	void Start () 
	{
		text = GetComponent<Text> ();

		money = 0;
	}

	void Update () 
	{
		if (money < 0)
			money = 0;

		text.text = "" + money;
	}

	public static void AddPoints (int pointsToAdd)
	{
		money += pointsToAdd;
	}
}
