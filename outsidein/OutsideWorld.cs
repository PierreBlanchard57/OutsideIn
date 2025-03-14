using Godot;
using System;

public partial class OutsideWorld : Node2D
{
    public const int WORLD_HEIGHT = 20;
    public const int WORLD_WIDTH = 40;
    public const float TILE_SIZE = 16;
    public override void _Ready()
    {
        Camera2D camera = GetNode<Camera2D>("Camera2D");
        Utils.scaleTileMapToViewport(WORLD_WIDTH, WORLD_HEIGHT, GetViewport(),camera, GetNode<TileMapLayer>("OutsideTileMap"));
    }
    public override void _Process(double delta)
    {
        if (Input.IsActionJustPressed("escape"))
        {
            GD.Print("Escape Pressed!");
        }
    }
}
