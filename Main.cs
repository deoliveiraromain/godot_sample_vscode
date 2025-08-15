using Godot;
using System;

public partial class Main : Node2D
{
    private Sprite2D _sprite;
    private Vector2 _startPosition = new Vector2(-100, 300);

    public override void _Ready()
    {
        GD.Print("Hello World");
        _sprite = GetNode<Sprite2D>("Icon");
        _sprite.Position = _startPosition;
    }

    public override void _Process(double delta)
    {
        _sprite.Position += new Vector2(450.0f * (float)delta, 0.0f);
        // Récupère la largeur de la fenêtre où le jeu est affiché
        if (_sprite.Position.X > GetViewport().GetVisibleRect().Size.X + _sprite.Texture.GetWidth())
        {
            _sprite.Position = _startPosition;
        }
    }
}
