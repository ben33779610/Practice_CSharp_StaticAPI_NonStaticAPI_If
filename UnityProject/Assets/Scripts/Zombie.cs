using UnityEngine;

public class Zombie : Creature
{

	public Zombie()
	{
		Hp = 100;
		Atk = 10;
	}

	public Player player ;
	private void Attack()
	{
		if (dead||player.dead) return;
		if (Input.GetKeyDown(KeyCode.B))
		{
			
			print("殭屍攻擊了玩家造成了<color=#A8100D>" +  Atk + "</color>點的傷害");
			auoS.PlayOneShot(auoC, 1);
			player.Injury(Atk);
			player.Dead();
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
			print("<color=#38040E>殭屍死亡</color>");
			dead = true;
		}
	}

	private void Update()
	{
		Attack();
	}

}
