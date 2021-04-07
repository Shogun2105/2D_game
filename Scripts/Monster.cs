using Godot;
using System;

public class Monster : KinematicBody2D
{
	private float moveSpeed = 200f;

	private float gravity = 20f;

	private Vector2 movement;

	private AnimatedSprite animation;

	public bool moveLeft;

	public bool isFrog;

	private float min_X,max_X;
	public int counter=0;
	
	public override void _Ready()
	{
		animation = GetNode<AnimatedSprite>("Animation");
		
	}

	public override void _PhysicsProcess(float delta)
	{
		animation.Play("Walk");
		movement = MoveAndSlide(movement);
		counter++;
		if (counter>100)
		{
			movement.x = -moveSpeed;
			animation.FlipH = false;
			if(counter >200)
			{
				counter = 0;
			}
		}
		else
		{
			animation.FlipH = true;
			movement.x = moveSpeed;
		}
	}
}
