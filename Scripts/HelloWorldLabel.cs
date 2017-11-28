using Godot;
using System;

public class HelloWorldLabel : RichTextLabel
{
	private const string BaseText = "Hello World";

	private int Counter = 0;

    public override void _Ready()
    {
		this.AddText(BaseText);
    }

	private void _on_Timer_timeout()
	{
		Counter++;
		this.Clear();
		this.AddText($"{BaseText} {Counter}");
	    // Replace with function body
	}
//    public override void _Process(float delta)
//    {
//        // Called every frame. Delta is time since last frame.
//        // Update game logic here.
//        
//    }
}
