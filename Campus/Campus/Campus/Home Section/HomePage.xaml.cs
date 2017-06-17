using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Campus.Services;
using Campus.Modal;
using Campus.Admin_Section;
using Xamarin.Forms;

namespace Campus.Home_Section
{
    public partial class HomePage : ContentPage
    {
        TodoItemManager manager;

        public HomePage()
        {
            InitializeComponent();
            manager = TodoItemManager.DefaultManager;
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Set syncItems to true in order to synchronize the data on startup when running in offline mode
            await RefreshItems(true, syncItems: true);
        }
        private async void Onannouncementtapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new AnouncementsPage())
            {
                BarBackgroundColor = Color.Teal
            });
        }

        //private async void Onlogoutclicked(object sender, EventArgs e)
        //{
        //    await Navigation.PopModalAsync();
        //}

        //private void ToolbarItem_Clicked(object sender, EventArgs e)
        //{
        //    DisplayAlert("Message","Under Construction","ok");
        //}
        async Task CompleteItem(TodoItem item)
        {
            item.Done = true;
            await manager.SaveTaskAsync(item);
            todoList.ItemsSource = await manager.GetTodoItemsAsync();
        }

        // Event handlers
        public async void OnSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var todo = e.SelectedItem as TodoItem;
            if (Device.OS != TargetPlatform.iOS && todo != null)
            {
                // Not iOS - the swipe-to-delete is discoverable there
                if (Device.OS == TargetPlatform.Android)
                {
                    //await DisplayAlert(todo.Name, "Press-and-hold to complete task " + todo.Name, "Got it!");
                    await Navigation.PushModalAsync(new NavigationPage(new ViewNotificationPage(todo)));
                }
                else
                {
                    // Windows, not all platforms support the Context Actions yet
                    //if (await DisplayAlert("Mark completed?", "Do you wish to complete " + todo.Name + "?", "Complete", "Cancel"))
                    //{
                    //    await CompleteItem(todo);
                    //}
                }
            }

            // prevents background getting highlighted
            todoList.SelectedItem = null;
        }

        // http://developer.xamarin.com/guides/cross-platform/xamarin-forms/working-with/listview/#context
        public async void OnComplete(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            var todo = mi.CommandParameter as TodoItem;
            await CompleteItem(todo);
        }

        // http://developer.xamarin.com/guides/cross-platform/xamarin-forms/working-with/listview/#pulltorefresh
        public async void OnRefresh(object sender, EventArgs e)
        {
            var list = (ListView)sender;
            Exception error = null;
            try
            {
                await RefreshItems(false, true);
            }
            catch (Exception ex)
            {
                error = ex;
            }
            finally
            {
                list.EndRefresh();
            }

            if (error != null)
            {
                //await DisplayAlert("Refresh Error", "Couldn't refresh data (" + error.Message + ")", "OK");
            }
        }

        public async void OnSyncItems(object sender, EventArgs e)
        {
            await RefreshItems(true, true);
        }

        private async Task RefreshItems(bool showActivityIndicator, bool syncItems)
        {
            using (var scope = new ActivityIndicatorScope(syncIndicator, showActivityIndicator))
            {
                var table = await manager.GetTodoItemsAsync(syncItems);
                todoList.ItemsSource = table.Where(student => student.Area == "Global");                 
            }
        }

        private class ActivityIndicatorScope : IDisposable
        {
            private bool showIndicator;
            private ActivityIndicator indicator;
            private Task indicatorDelay;

            public ActivityIndicatorScope(ActivityIndicator indicator, bool showIndicator)
            {
                this.indicator = indicator;
                this.showIndicator = showIndicator;

                if (showIndicator)
                {
                    indicatorDelay = Task.Delay(2000);
                    SetIndicatorActivity(true);
                }
                else
                {
                    indicatorDelay = Task.FromResult(0);
                }
            }

            private void SetIndicatorActivity(bool isActive)
            {
                this.indicator.IsVisible = isActive;
                this.indicator.IsRunning = isActive;
            }

            public void Dispose()
            {
                if (showIndicator)
                {
                    indicatorDelay.ContinueWith(t => SetIndicatorActivity(false), TaskScheduler.FromCurrentSynchronizationContext());
                }
            }
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await RefreshItems(true, syncItems: true);
        }
    }
}
