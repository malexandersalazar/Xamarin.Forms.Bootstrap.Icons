namespace Xamarin.Forms.Bootstrap.Icons
{
    public class IconSource : FontImageSource
    {
        public static readonly BindableProperty IconProperty =
            BindableProperty.Create("Icon", typeof(Icon), typeof(IconSource));

        public Icon Icon
        {
            get { return (Icon)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public IconSource() => FontFamily = "BootstrapIcons";

        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (nameof(Icon).Equals(propertyName))
                Glyph = char.ConvertFromUtf32((int)Icon).ToString();
        }
    }
}