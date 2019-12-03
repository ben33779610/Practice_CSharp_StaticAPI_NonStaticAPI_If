using UnityEngine;
public class Player : Creature
{
	public Player()  
	{
		Hp = 200;
		Atk = 5;
	}
	public Zombie zom ;
	

	private  void Attack()
	{
		if (dead||zom.dead) return;
		
		if (Input.GetKeyDown(KeyCode.A))
		{
			int num = Random.Range(1, 5);
			print("玩家攻擊了殭屍造成了<color=#0000ff>"+num*Atk+"</color>點的傷害");
			zom.Injury(num * Atk);
			zom.Dead();
		}
		
	}
	public void Injury(int d1)
	{
		Hp -= d1;
	}

	public void Dead()
	{
		if (Hp < 0)
		{
			print("<color=#38040E>玩家死亡</color>");
			dead = true;
		}
	}


	private void Update()
	{
		Attack();

	}

}
