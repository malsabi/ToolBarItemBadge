using System.Collections.ObjectModel;

namespace ToolBarItemBadge.CustomControls;

public partial class TabBar : Grid
{
    public static readonly BindableProperty ToolBarItemsProperty = BindableProperty.Create(nameof(ToolBarItems), typeof(ObservableCollection<ToolBarItem>), typeof(TabBar), defaultValue: new ObservableCollection<ToolBarItem>());
    public ObservableCollection<ToolBarItem> ToolBarItems
    {
        get => (ObservableCollection<ToolBarItem>)GetValue(ToolBarItemsProperty);
        set => SetValue(ToolBarItemsProperty, value);
    }

    public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(TabBar));
    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public static readonly BindableProperty TitleFontSizeProperty = BindableProperty.Create(nameof(TitleFontSize), typeof(double), typeof(TabBar));
    public double TitleFontSize
    {
        get => (double)GetValue(TitleFontSizeProperty);
        set => SetValue(TitleFontSizeProperty, value);
    }

    public static readonly BindableProperty TitleColorProperty = BindableProperty.Create(nameof(TitleColorProperty), typeof(Color), typeof(TabBar));
    public Color TitleColor
    {
        get => (Color)GetValue(TitleColorProperty);
        set => SetValue(TitleColorProperty, value);
    }

    public static readonly BindableProperty TitleMarginProperty = BindableProperty.Create(nameof(TitleMargin), typeof(Thickness), typeof(TabBar));
    public Thickness TitleMargin
    {
        get => (Thickness)GetValue(TitleMarginProperty);
        set => SetValue(TitleMarginProperty, value);
    }

    public static readonly BindableProperty TitleHorizontalOptionsProperty = BindableProperty.Create(nameof(TitleHorizontalOptions), typeof(LayoutOptions), typeof(TabBar));
    public LayoutOptions TitleHorizontalOptions
    {
        get => (LayoutOptions)GetValue(TitleHorizontalOptionsProperty);
        set => SetValue(TitleHorizontalOptionsProperty, value);
    }

    public static readonly BindableProperty TitleVerticalOptionsProperty = BindableProperty.Create(nameof(TitleVerticalOptions), typeof(LayoutOptions), typeof(TabBar));
    public LayoutOptions TitleVerticalOptions
    {
        get => (LayoutOptions)GetValue(TitleVerticalOptionsProperty);
        set => SetValue(TitleVerticalOptionsProperty, value);
    }

    public TabBar()
	{
		InitializeComponent();
    }
}