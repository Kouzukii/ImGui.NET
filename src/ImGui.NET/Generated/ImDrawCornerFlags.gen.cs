namespace ImGuiNET
{
    [System.Flags]
    public enum ImDrawCornerFlags
    {
        None = 0,
        TopLeft = 1,
        TopRight = 2,
        BotLeft = 4,
        BotRight = 8,
        Top = 3,
        Bot = 12,
        Left = 5,
        Right = 10,
        All = 15,
    }
}
