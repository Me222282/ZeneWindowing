namespace Zene.Windowing
{
    public delegate void FileDropEventHandler(object sender, FileDropEventArgs e);

    public delegate void TextInputEventHandler(object sender, TextInputEventArgs e);

    public delegate void KeyEventHandler(object sender, KeyEventArgs e);

    public delegate void ScrolEventHandler(object sender, ScrollEventArgs e);

    public delegate void MouseEventHandler(object sender, MouseEventArgs e);

    public delegate void VectorIEventHandler(object sender, VectorIEventArgs e);

    public delegate void VectorEventHandler(object sender, VectorEventArgs e);

    public delegate void FocusedEventHandler(object sender, FocusedEventArgs e);
}
