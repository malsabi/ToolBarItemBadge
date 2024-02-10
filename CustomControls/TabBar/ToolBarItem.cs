using System.Windows.Input;

namespace ToolBarItemBadge.CustomControls;

public class ToolBarItem : BindableObject
{
    public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(ToolBarItem), string.Empty);
    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    public static readonly BindableProperty TextFontSizeProperty = BindableProperty.Create(nameof(TextFontSize), typeof(double), typeof(ToolBarItem), 15.0);
    public double TextFontSize
    {
        get => (double)GetValue(TextFontSizeProperty);
        set => SetValue(TextFontSizeProperty, value);
    }

    public static readonly BindableProperty TextColorProperty = BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(ToolBarItem), Colors.White);
    public Color TextColor
    {
        get => (Color)GetValue(TextColorProperty);
        set => SetValue(TextColorProperty, value);
    }

    public static readonly BindableProperty IconProperty = BindableProperty.Create(nameof(Icon), typeof(ImageSource), typeof(ToolBarItem));
    public ImageSource Icon
    {
        get => (ImageSource)GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }

    public static readonly BindableProperty BadgeValueProperty = BindableProperty.Create(nameof(BadgeValue), typeof(string), typeof(ToolBarItem), string.Empty);
    public string BadgeValue
    {
        get => (string)GetValue(BadgeValueProperty);
        set => SetValue(BadgeValueProperty, value);
    }

    public static readonly BindableProperty BadgeTextColorProperty = BindableProperty.Create(nameof(BadgeTextColor), typeof(Color), typeof(ToolBarItem), Colors.White);
    public Color BadgeTextColor
    {
        get => (Color)GetValue(BadgeTextColorProperty);
        set => SetValue(BadgeTextColorProperty, value);
    }

    public static readonly BindableProperty BadgeStrokeColorProperty = BindableProperty.Create(nameof(BadgeStrokeColor), typeof(Color), typeof(ToolBarItem), Colors.White);
    public Color BadgeStrokeColor
    {
        get => (Color)GetValue(BadgeStrokeColorProperty);
        set => SetValue(BadgeStrokeColorProperty, value);
    }

    public static readonly BindableProperty BadgeBackgroundProperty = BindableProperty.Create(nameof(BadgeBackground), typeof(Color), typeof(ToolBarItem), Colors.Orange);
    public Color BadgeBackground
    {
        get => (Color)GetValue(BadgeBackgroundProperty);
        set => SetValue(BadgeBackgroundProperty, value);
    }

    public static readonly BindableProperty CommandProperty = BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(ToolBarItem));
    public ICommand Command
    {
        get => (ICommand)GetValue(CommandProperty);
        set => SetValue(CommandProperty, value);
    }
}