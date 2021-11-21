using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace WorkWithMedia
{
    /// <summary>
    /// Класс для вызовв диалогов.
    /// </summary>
    public class DefaultDialogService 
    {
        /// <summary>
        /// Путь к файлу.
        /// </summary>
        public string FilePath { get; private set; }

        /// <summary>
        /// Открытие файла.
        /// </summary>
        /// <returns> Выбран ли файл. </returns>
        public bool OpenFileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Media file";
            // You can use different expansion of media files(jpeg, png, mkv, and etc.)
            openFileDialog.Filter = "Media file (*.mp4)|*.mp4| Media file (*.mkv)|*.mkv|Media file (*.png)|*.png";
            if (openFileDialog.ShowDialog() == true)
            {
                FilePath = openFileDialog.FileName;
                return true;
            }
            return false;
        }

    }
}
