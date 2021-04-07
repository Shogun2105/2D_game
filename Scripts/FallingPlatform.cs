using Godot;
using System;

public class FallingPlatform : KinematicBody2D
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }

	public void _on_FallingPlatformArea_body_entered(object body)
	{
		if(body.ToString() == "player")
		{
			var anim = GetNode<AnimatedSprite>("AnimatedSprite");
			anim.Play();
			var timer = GetNode<Timer>("Timer");
			timer.Start();
		}
	}
	
	public void _on_Timer_timeout()
	{
		var platform = GetNode<CollisionShape2D>("CollisionShape2D");
		platform.SetDeferred("disabled", true);
		var return_timer = GetNode<Timer>("ReturnTimer");
		return_timer.Start();
	}
	
	public void _on_ReturnTimer_timeout()
	{
		var anim = GetNode<AnimatedSprite>("AnimatedSprite");
		anim.Stop();
		anim.SetFrame(0);
		var platform = GetNode<CollisionShape2D>("CollisionShape2D");
		platform.SetDeferred("disabled", false);
	}
}


