using System.Windows.Controls;
using System.Windows;

namespace ContentsControls
{
    /// <summary>
    /// Контрол для отображения списка параметров с простым тестом в заголовке
    /// </summary>
    public partial class SimplePropertyRowContentControl : UserControl
    {
        public SimplePropertyRowContentControl() : base()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Отображаемое имя свойства
        /// </summary>
        public string PropertyTitle
        {
            get { return (string)GetValue(PropertyTitleProperty); }
            set { SetValue(PropertyTitleProperty, value); }
        }

        /// <summary>
        /// Ширина области с заголовком свойства в формате сетки Grid
        /// </summary>
        public GridLength TitleWidth
        {
            get { return (GridLength)GetValue(TitleWidthProperty); }
            set { SetValue(TitleWidthProperty, value); }
        }

        /// <summary>
        /// Содержимое области с заголовком свойства
        /// </summary>
        public object TitleContent
        {
            get { return (object)GetValue(TitleContentProperty); }
            set { SetValue(TitleContentProperty, value); }
        }

        /// <summary>
        /// Ширина области с содержимым в формате сетки Grid
        /// </summary>
        public GridLength ContentWidth
        {
            get { return (GridLength)GetValue(ContentWidthProperty); }
            set { SetValue(ContentWidthProperty, value); }
        }

        public static readonly DependencyProperty PropertyTitleProperty
            = DependencyProperty.Register(
                  "PropertyTitle",
                  typeof(string),
                  typeof(UserControl),
                  new UIPropertyMetadata(string.Empty));

        public static readonly DependencyProperty TitleWidthProperty = DependencyProperty.Register(
                  "TitleWidth",
                  typeof(GridLength),
                  typeof(UserControl),
                  new UIPropertyMetadata(new GridLength(1, GridUnitType.Auto)));

        public static readonly DependencyProperty ContentWidthProperty = DependencyProperty.Register(
                  "ContentWidth",
                  typeof(GridLength),
                  typeof(UserControl),
                  new UIPropertyMetadata(new GridLength(1, GridUnitType.Auto)));

        public static readonly DependencyProperty TitleContentProperty = DependencyProperty.Register(
                  "TitleContent",
                  typeof(object),
                  typeof(UserControl),
                  new PropertyMetadata(null));
    }
}
