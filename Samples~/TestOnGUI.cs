using UnityEngine;
using imColorPicker;

namespace imColorPickerTest
{
    public class TestOnGUI : MonoBehaviour
    {
        [SerializeField] IMColorPreset preset;
        [SerializeField] Color color;

        IMColorPicker colorPicker;
        [SerializeField] bool window;

        void OnGUI()
        {
            if (colorPicker == null)
            {
                colorPicker = new IMColorPicker(color, preset);
                colorPicker.SetWindowPosition(150, 20);
            }

            window = GUILayout.Toggle(window, "Window");

            if (window)
            {
                colorPicker.DrawWindow();
            }
            else
            {
                colorPicker.DrawColorPicker();
            }

            color = colorPicker.Color;

            using (new GUILayout.VerticalScope())
            {
                GUILayout.Space(30);
                GUILayout.Label("Change picker's color:");
                if (GUILayout.Button("Red")) colorPicker.SetColor(new Color(.9f, .1f, .1f));
                if (GUILayout.Button("Yellow")) colorPicker.SetColor(Color.yellow);
                if (GUILayout.Button("Dark green")) colorPicker.SetColor(new Color(.1f, .4f, .1f));
                if (GUILayout.Button("Semi-transparent")) colorPicker.SetColor(new Color(.5f, .5f, .5f, .5f));
            }
        }
    }
}
