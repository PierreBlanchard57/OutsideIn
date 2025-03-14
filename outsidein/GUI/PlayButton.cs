using Godot;
using System;

public partial class PlayButton : GUIButton
{
    public override void _Pressed()
    {
        GetTree().ChangeSceneToFile("res://1_1.tscn");
    }
}
