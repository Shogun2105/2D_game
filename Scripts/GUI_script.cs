using Godot;
using System;


public class Gui : MarginContainer
{
	private Tween _tween;
	private Label _numberLabel;
	private TextureProgress _bar;

	public override void _Ready()
	{
		// C# doesn't have an onready feature, this works just the same.
		_bar = (TextureProgress) GetNode("Bars/LifeBar/TextureProgress");
		_tween = (Tween) GetNode("Tween");
		_numberLabel = (Label) GetNode("Bars/LifeBar/Count/Background/Number");
	}
}
