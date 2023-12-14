﻿using MaterialSkin;

namespace Teste.Topaz.Desktop.ControlSkin;

public interface IMaterialControl
{
    int Depth { get; set; }
    MaterialSkinManager SkinManager { get; }
    MouseState MouseState { get; set; }

}

public enum MouseState
{
    HOVER,
    DOWN,
    OUT
}