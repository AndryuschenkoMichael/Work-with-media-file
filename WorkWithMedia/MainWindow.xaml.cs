using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace WorkWithMedia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CommandBinding_OnExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            DefaultDialogService service = new DefaultDialogService();
            if (service.OpenFileDialog())
            {
                if (service.FilePath.ToLower().EndsWith(".png"))
                {
                    PlayMenuItem.IsEnabled = false;
                    PauseMenuItem.IsEnabled = false;
                    TimeSlider.Visibility = Visibility.Hidden;
                }
                else
                {
                    PlayMenuItem.IsEnabled = true;
                    PauseMenuItem.IsEnabled = true;
                    TimeSlider.Visibility = Visibility.Visible;
                }
                
                CustomPlayer.Source = new Uri(service.FilePath);
            }
        }

        private void PlayMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            CustomPlayer.LoadedBehavior = MediaState.Play;
        }

        private void PauseMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            CustomPlayer.LoadedBehavior = MediaState.Pause;
        }

        private void CustomPlayer_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (CustomPlayer.LoadedBehavior == MediaState.Pause)
            {
                CustomPlayer.LoadedBehavior = MediaState.Play;
            } else if (CustomPlayer.LoadedBehavior == MediaState.Play)
            {
                CustomPlayer.LoadedBehavior = MediaState.Pause;
            }
        }

        private void TimeSlider_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int SliderValue = (int)TimeSlider.Value;
            
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, SliderValue);
            CustomPlayer.Position = ts;
            CustomPlayer.LoadedBehavior = MediaState.Play;
        }

        private void MenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void CustomPlayer_OnMediaOpened(object sender, RoutedEventArgs e)
        {
            try
            {
                TimeSlider.Visibility = Visibility.Visible;
                TimeSlider.Maximum = CustomPlayer.NaturalDuration.TimeSpan.TotalMilliseconds;
            }
            catch
            {
                TimeSlider.Visibility = Visibility.Hidden;
            }
        }
    }
}