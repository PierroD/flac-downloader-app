using FlacDownloader.Classes;
using FlacDownloader.Enums;
using FlacDownloader.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace FlacDownloader.Views
{
    public partial class UC_Search : UserControl
    {
        public delegate void GoToEventHandler(object sender, GoToObject goToObject);
        public event GoToEventHandler GoTo;

        public delegate void AddOrRemoveToDownloadQueueEventHandler(object sender, int number);
        public event AddOrRemoveToDownloadQueueEventHandler AddOrRemoveToDownloadQueue;

        protected virtual void OnGoTo(object sender, GoToObject goToObject)
        {
            uC_MusicPlayer.PauseMusic();
            GoTo?.Invoke(this, goToObject);
        }

        protected virtual void OnAddOrRemoveToDownloadQueue(object sender, int number)
        {
            AddOrRemoveToDownloadQueue?.Invoke(this, 1);
        }

        public UC_Search()
        {
            InitializeComponent();
            LoadAppColor();
        }

        private int nextIndex = 0;
        private string previousSearchText = String.Empty;
        private SearchByEnum previousSearchByEnum = SearchByEnum.None;
        private bool isFirstResult = true;

        private void UC_Search_Load(object sender, EventArgs e)
        {
            LoadAppColor();
        }

        public void LoadAppColor()
        {
            this.BackColor = AppColors.backgroundSecondaryColor;
            comboBoxSearchBy.FillColor = AppColors.backgroundSecondaryColor;
            comboBoxSearchBy.BorderColor = AppColors.textColor;
            comboBoxSearchBy.ForeColor = AppColors.textColor;
            comboBoxSearchBy.FocusedState.BorderColor = AppColors.textColor;
            textBoxSearch.FillColor = AppColors.backgroundSecondaryColor;
            textBoxSearch.BorderColor = AppColors.textColor;
            textBoxSearch.ForeColor = AppColors.textColor;
            textBoxSearch.FocusedState.BorderColor = AppColors.textColor;
            buttonSearchClear.FillColor = AppColors.primaryColor;
            buttonSearchClear.ForeColor = AppColors.backgroundSecondaryColor;
            labelResults.ForeColor = AppColors.textColor;
            UserControlHelper.CallEventOnAllPanels(flowLayoutPanelResults, "LoadAppColor", null);

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            buttonSearchClear.Visible = textBoxSearch.Text.Trim() != String.Empty;
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (textBoxSearch.Text != String.Empty)
                {
                    Search(textBoxSearch.Text, (SearchByEnum)Enum.Parse(typeof(SearchByEnum), comboBoxSearchBy.Text.Length <= 0 ? "None" : comboBoxSearchBy.Text));
                }
            }
        }

        private void buttonSearchClear_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = String.Empty;
        }

        private void comboBoxSearchBy_Click(object sender, EventArgs e)
        {
            comboBoxSearchBy.Items.Clear();

            foreach (SearchByEnum parameter in Enum.GetValues(typeof(SearchByEnum)))
            {
                if (parameter == SearchByEnum.None)
                {
                    comboBoxSearchBy.Items.Add(String.Empty);
                    continue;
                }
                comboBoxSearchBy.Items.Add(parameter.ToString());
            }
        }

        private async void Search(string searchText, SearchByEnum searchBy)
        {
            if (AppSettings.apiUrl == String.Empty) {
                MessageBox.Show("The API Url is empty, make sure to set it in the config before searching again", "Error - API Url is empty",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            APIResponse<SearchResponse> response = await HttpClientExtensions.Search(textBoxSearch.Text, searchBy, this.nextIndex);

            if (this.previousSearchByEnum != searchBy || this.previousSearchText != searchText)
            {
                flowLayoutPanelResults.Controls.Clear();
                this.isFirstResult = true;
            }
            this.previousSearchByEnum = searchBy;
            this.previousSearchText = searchText;
            DisplayResults(response);
        }

        private void DisplayResults(APIResponse<SearchResponse> apiResponse)
        {
            flowLayoutPanelResults.SuspendLayout();
            List<UserControl> searchResults = LoadSearchResult(apiResponse.data);
            flowLayoutPanelResults.Controls.AddRange(searchResults.ToArray());
            flowLayoutPanelResults.ResumeLayout();
            this.ResumeLayout();

            this.nextIndex = apiResponse.next != null ? int.Parse(apiResponse.next.Substring(apiResponse.next.Length - 2)) : 0;
            labelResults.Text = $"Results : {this.nextIndex}/{apiResponse.total}";
        }

        private List<UserControl> LoadSearchResult(List<SearchResponse> searchResponses)
        {
            List<UserControl> searchResults = new List<UserControl>();
            if (searchResponses.Count <= 0)
            {
                return searchResults;
            }

            foreach (SearchResponse searchResponse in searchResponses)
            {
                if (isFirstResult)
                {
                    UC_SearchFirstResult firstSearchResult = new UC_SearchFirstResult(searchResponse);
                    firstSearchResult.PlayMusicStart += OnMusicSelected;
                    firstSearchResult.GoTo += OnGoTo;
                    firstSearchResult.AddOrRemoveToDownloadQueue += OnAddOrRemoveToDownloadQueue;
                    searchResults.Add(firstSearchResult);
                    isFirstResult = false;
                    continue;
                }
                UC_SearchResult searchResult = new UC_SearchResult(searchResponse);
                searchResult.PlayMusicStart += OnMusicSelected;
                searchResult.GoTo += OnGoTo;
                searchResult.AddOrRemoveToDownloadQueue += OnAddOrRemoveToDownloadQueue;
                searchResults.Add(searchResult);
            }
            return searchResults;
        }

        public bool IsMusicWorkerBusy => uC_MusicPlayer.IsMusicWorkerBusy;
        public void killWorker() { uC_MusicPlayer.killWorker(); }

        private void OnMusicSelected(object sender, SearchResponse searchResponse)
        {
            MusicSelected musicSelected = new MusicSelected(searchResponse.album.cover_medium, searchResponse.title, searchResponse.artist.name, searchResponse.preview);
            uC_MusicPlayer.OnMusicSelected(musicSelected);
        }

    }
}
