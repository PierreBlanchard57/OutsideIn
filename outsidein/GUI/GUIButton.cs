using Godot;
using System;
using static System.Net.Mime.MediaTypeNames;

public partial class GUIButton : TextureButton
{
    public override void _Ready()
    {
        TextureNormal = getMergedImage("res://assets/MainMenu/button_background.png", "res://assets/MainMenu/"+GetMeta("text")+".png");
        TextureHover = getMergedImage("res://assets/MainMenu/button_background_hovered.png", "res://assets/MainMenu/" + GetMeta("text") + "_hover.png");
    }
    private ImageTexture getMergedImage(string background,string text)
    {
        var bg = GD.Load<Texture2D>(background).GetImage();
        var txt = GD.Load<Texture2D>(text).GetImage();
        bg.BlendRect(txt, new Rect2I(Vector2I.Zero, txt.GetSize()), Vector2I.Zero);
        var res = ImageTexture.CreateFromImage(bg);
        return res;
    }
}
