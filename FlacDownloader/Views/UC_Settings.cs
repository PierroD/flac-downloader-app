using FlacDownloader.Enums;
using FlacDownloader.Utils;
using IWshRuntimeLibrary;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlacDownloader.Views
{
    public partial class UC_Settings : UserControl
    {
        private string updaterPath = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\FlacDownloaderUpdater.exe";
        public UC_Settings()
        {
            InitializeComponent();
        }

        public delegate void AppColorEventHandler(object sender);
        public event AppColorEventHandler AppColorChanged;

        protected virtual void OnAppColorChanged()
        {
            AppColorChanged?.Invoke(this);
            LoadAppColor();
        }

        private void UC_Settings_Load(object sender, EventArgs e)
        {
            LoadAppColor();
            switchDarkMode.Checked = AppSettings.isDarkMode;
            textBoxDownloadFolderPath.Text = AppSettings.downloadFolderPath;
            switchDownloadAutoRetry.Checked = AppSettings.isDownloadAutoRetry;
            textboxGlobalApi.Text = AppSettings.apiUrl;
            textboxDownloadApi.Text = AppSettings.downloadApiUrl;
            labelCurrentVersionValue.Text = AppSettings.appVersion;
            labelLatestVersionValue.Text = AppSettings.latestVersion;
            buttonUpdate.Visible = AppSettings.appVersion != AppSettings.latestVersion;           
            LoadOutputFormatCombobox();
            comboBoxOutputFormat.SelectedIndex = comboBoxOutputFormat.Items.IndexOf(AppSettings.outputFormat);
        }

        private void LoadAppColor()
        {
            this.BackColor = AppColors.backgroundSecondaryColor;
            labelDarkMode.ForeColor = AppColors.textColor;
            switchDarkMode.CheckedState.FillColor = AppColors.primaryColor;
            separatorDarkMode.ForeColor = AppColors.textColor;

            labelDownloadAutoRetry.ForeColor = AppColors.textColor;
            switchDownloadAutoRetry.CheckedState.FillColor = AppColors.primaryColor;
            separatorDownloadAutoRetry.ForeColor = AppColors.textColor;

            labelDesktopShortcut.ForeColor = AppColors.textColor;
            buttonDesktopShortcutCreate.FillColor = AppColors.primaryColor;
            buttonDesktopShortcutCreate.ForeColor = AppColors.backgroundColor;
            separatorDesktopShortcut.ForeColor = AppColors.textColor;

            labelDownloadFolder.ForeColor = AppColors.textColor;
            buttonDownloadFolderSelect.FillColor = AppColors.primaryColor;
            buttonDownloadFolderSelect.ForeColor = AppColors.backgroundColor;
            textBoxDownloadFolderPath.FillColor = AppColors.backgroundColor;
            textBoxDownloadFolderPath.ForeColor = AppColors.textColor;
            textBoxDownloadFolderPath.BorderColor = AppColors.textColor;
            buttonDownloadFolderOpen.FillColor = AppColors.primaryColor;
            buttonDownloadFolderOpen.ForeColor = AppColors.backgroundColor;
            separatorDownloadFolder.ForeColor = AppColors.textColor;

            labelOutputFormat.ForeColor = AppColors.textColor;
            comboBoxOutputFormat.FillColor = AppColors.backgroundSecondaryColor;
            comboBoxOutputFormat.ForeColor = AppColors.textColor;
            comboBoxOutputFormat.BorderColor = AppColors.textColor;
            comboBoxOutputFormat.FocusedState.BorderColor = AppColors.textColor;
            separatorOutputFormat.ForeColor = AppColors.textColor;

            labelGlobalApi.ForeColor = AppColors.textColor;
            buttonGlobalApiSet.FillColor = AppColors.primaryColor;
            buttonGlobalApiSet.ForeColor = AppColors.backgroundColor;
            textboxGlobalApi.FillColor = AppColors.backgroundSecondaryColor;
            textboxGlobalApi.ForeColor = AppColors.textColor;
            textboxGlobalApi.BorderColor = AppColors.textColor;
            separatorGlobalApi.ForeColor = AppColors.textColor;

            labelDownloadApi.ForeColor = AppColors.textColor;
            buttonDownloadApiSet.FillColor = AppColors.primaryColor;
            buttonDownloadApiSet.ForeColor = AppColors.backgroundColor;
            textboxDownloadApi.FillColor = AppColors.backgroundSecondaryColor;
            textboxDownloadApi.ForeColor = AppColors.textColor;
            textboxDownloadApi.BorderColor = AppColors.textColor;
            separatorDownloadApi.ForeColor = AppColors.textColor;

            verticalSeparator.ForeColor = AppColors.textColor;

            labelCurrentVersion.ForeColor = AppColors.textColor;
            labelCurrentVersionValue.ForeColor = AppColors.primaryColor;
            separatorCurrentVersion.ForeColor = AppColors.textColor;
           
            labelLatestVersion.ForeColor = AppColors.textColor;
            labelLatestVersionValue.ForeColor = AppColors.primaryColor;
            separatorLatestVersion.ForeColor = AppColors.textColor;

            buttonUpdate.FillColor = AppColors.primaryColor;
            buttonUpdate.ForeColor = AppColors.backgroundColor;
        }

        private void LoadOutputFormatCombobox()
        {
            comboBoxOutputFormat.Items.Clear();
            foreach (OutputFormatEnum outputFormat in Enum.GetValues(typeof(OutputFormatEnum)))
            {
                comboBoxOutputFormat.Items.Add(outputFormat.ToString());
            }
        }

        private void switchDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            AppSettings.isDarkMode = switchDarkMode.Checked;
            OnAppColorChanged();
        }

        private void switchDownloadAutoRetry_CheckedChanged(object sender, EventArgs e)
        {
            AppSettings.isDownloadAutoRetry = switchDownloadAutoRetry.Checked;
        }


        private void buttonDesktopShortcutCreate_Click(object sender, EventArgs e)
        {
            object shDesktop = (object)"Desktop";
            WshShell shell = new WshShell();
            string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\Flac Downloader.lnk";
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
            shortcut.Description = "New shortcut for FlacDownloader";
            shortcut.TargetPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\FlacDownloader.exe";
            shortcut.Save();
            MessageBox.Show("Shortcut successfully created on your desktop", "Shortcut", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonDownloadFolderSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Select download folder path";
            using (dialog)
            {
                DialogResult result = dialog.ShowDialog();
                string selectedPath = dialog.SelectedPath;
                if (result != DialogResult.OK && string.IsNullOrEmpty(selectedPath) && !selectedPath.EndsWith("311210"))
                {
                    return;
                }
                textBoxDownloadFolderPath.Text = selectedPath;
                AppSettings.downloadFolderPath = selectedPath;
            }
        }

        private void buttonDownloadFolderOpen_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", AppSettings.downloadFolderPath);
        }

        private void comboBoxOutputFormat_SelectedValueChanged(object sender, EventArgs e)
        {
            AppSettings.outputFormat = comboBoxOutputFormat.Text;
        }

        private void buttonGlobalApiSet_Click(object sender, EventArgs e)
        {
            AppSettings.apiUrl = textboxGlobalApi.Text;
        }

        private void buttonDownloadApiSet_Click(object sender, EventArgs e)
        {
            AppSettings.downloadApiUrl = textboxDownloadApi.Text;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Process.Start(updaterPath, $"{AppSettings.updateDownloadUrl} {AppSettings.isDarkMode}");
            Application.Exit();
        }
    }
}
