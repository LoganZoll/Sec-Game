using Godot;
using System;

public partial class QuitButton : Button
{
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Pressed += OnPressed;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	private void OnPressed()
	{
		GetTree().Quit();
	}
}
