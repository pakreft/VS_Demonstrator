using UnityEngine;

public static class GameData
{
    // ----- Variables -----
    // >>> Object Highlighting
    private static Outline.Mode outlineMode = Outline.Mode.OutlineAll;
    private static Color outlineColor = Color.yellow;
    private static float outlineWidth = 2;
    private static bool precomputeOutline = false;
    
    // ----- Getter and Setter -----
    // >>> Object Highlighting
    public static Outline.Mode GetOutlineMode() { return outlineMode; }
    public static Color GetOutlineColor() { return outlineColor; }
    public static float GetOutlineWidth() { return outlineWidth; }
    public static bool GetPrecomputeOutline() { return precomputeOutline; }
}