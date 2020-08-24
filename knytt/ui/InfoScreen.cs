using Godot;
using YKnyttLib;

public class InfoScreen : CanvasLayer
{
    public KnyttWorld<string> World { get; private set; }

    public void initialize(KnyttWorld<string> world)
    {
        this.World = world;
        var info = GDKnyttAssetManager.loadTexture(world.WorldDirectory + "/Info.png");
        GetNode<TextureRect>("InfoRect").Texture = info;
        GetNode<SlotButton>("Slot1Button").BaseFile = "user://Saves/" + world.WorldDirectoryName;
        GetNode<SlotButton>("Slot2Button").BaseFile = "user://Saves/" + world.WorldDirectoryName;
        GetNode<SlotButton>("Slot3Button").BaseFile = "user://Saves/" + world.WorldDirectoryName;
    }

    public void _on_BackButton_pressed()
    {
        GetNodeOrNull<AudioStreamPlayer>("../MenuClickPlayer")?.Play();
        this.QueueFree();
    }

    public void closeOtherSlots(int slot)
    {
        closeSlotIfNot(GetNode<SlotButton>("Slot1Button"), slot);
        closeSlotIfNot(GetNode<SlotButton>("Slot2Button"), slot);
        closeSlotIfNot(GetNode<SlotButton>("Slot3Button"), slot);
    }

    private void closeSlotIfNot(SlotButton sb, int slot)
    {
        if (sb.slot != slot) { sb.close(); }
    }

    public void _on_SlotButton_StartGame(bool new_save, string filename, int slot)
    {
        string fname = new_save ? World.WorldDirectory + "/DefaultSavegame.ini" : filename;
        KnyttSave<string> save = new KnyttSave<string>(World, GDKnyttAssetManager.loadTextFile(fname), slot);
        World.CurrentSave = save;
        GDKnyttDataStore.World = World;
        GetTree().ChangeScene("res://knytt/GDKnyttGame.tscn");
        this.QueueFree();
    }

}
