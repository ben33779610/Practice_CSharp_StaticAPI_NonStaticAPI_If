using UnityEngine;

public class Player : Creature
{
	public Player()  
	{
		Hp = 200;
		Atk = 20;
	}

	private  void Attack()
	{
		if (Input.GetKeyDown(KeyCode.A))
		{
		}
	}
	private void Injury()
	{
	}



}
