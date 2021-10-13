# Fork changes

* Made into a package
  * can be imported from Unity Package Manager via git url
  * this required the file structure to be reorganized and assembly definition files to be added
  * author info in package.json has been filled with original author's info found on their public github profile
  * package name, displayName and version were chosen arbitrarily
* Added alpha slider
* Added setter to `Color` so it can be assigned to at any time
* Added backup color preview
  * Displays the color that was originally passed, for comparison with currently picked color
  * Can be clicked to "undo" the color change
  * Can be set via exposed `RevertColor` field
* Added `SetColor` method
  * It will update both `Color` and `RevertColor` to given color
* Increased height of preview color rectangle a bit
* Fixed "unreachable code" warning
* Updated original example to demonstrate `SetColor` capability
  * Example scenes can be imported from Package Manager's interface

See commit messages for complete list of changes.

Original readme below:

---

unity-immediate-color-picker
=================

Color picker for Unity in immediate GUI mode.

![Demo](https://raw.githubusercontent.com/mattatz/unity-immediate-color-picker/master/Captures/Demo.gif)

## Usage

in a MonoBehaviour,

```cs

IMColorPicker colorPicker;

void OnGUI()
{
    if(colorPicker == null)
    {
        colorPicker = new IMColorPicker();
    }
    colorPicker.DrawWindow(); // draw color picker UI with GUI.Window
    colorPicker.DrawColorPicker(); // or draw color picker UI only
}

```

You can use color presets with IMColorPreset(ScriptableObject).

```cs

public IMColorPreset preset;
IMColorPicker colorPicker;

void OnGUI()
{
    if(colorPicker == null)
    {
        colorPicker = new IMColorPicker(preset);
    }
    // ...
}

```

See example scenes for details.
