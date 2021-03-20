using Prism.Commands;
using Prism.Mvvm;
using Prism.Services;
using Syncfusion.SfCalendar.XForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace XammySFCalendar.ViewModels
{
    public class JCalendarViewModel : BindableBase
    {
        private readonly IPageDialogService _pageDialogService;
        public CalendarEventCollection CalendarInlineEvents { get; set; } = new CalendarEventCollection();
        public DelegateCommand RefreshCommand { get; }
        private bool _IsRefreshing;
        public bool IsRefreshing
        {
            get { return _IsRefreshing; }
            set { SetProperty(ref _IsRefreshing, value); }
        }
        public JCalendarViewModel(IPageDialogService pageDialogService)
        {
            _pageDialogService = pageDialogService;
            RefreshCommand = new DelegateCommand(Refresh);
            PageLoad();

        }

        Color ConvertColor(string color="Transparent")
        {
            return Color.FromName(color);
        }

        void Refresh()
        {
            PageLoad();
            _IsRefreshing = false;
        }


        void PageLoad()
        {
            List<EventList> list = new List<EventList>();

            list.Add(new EventList(DateTime.Now.AddDays(-1), DateTime.Now.AddDays(-1).AddHours(3), "Netflix & Chill", Color.DarkBlue));
            list.Add(new EventList(DateTime.Now.AddDays(1), DateTime.Now.AddDays(1).AddHours(3), "Netflix & Chill", Color.DarkRed));
            list.Add(new EventList(DateTime.Now.AddDays(1), DateTime.Now.AddDays(1).AddHours(3), "Netflix & Chill", Color.DarkGreen));

            list.Add(new EventList(DateTime.Now.AddDays(2), DateTime.Now.AddDays(2).AddHours(3), "Netflix & Chill", Color.DarkBlue));
            list.Add(new EventList(DateTime.Now.AddDays(3), DateTime.Now.AddDays(3).AddHours(3), "Netflix & Chill", Color.DarkRed));
            list.Add(new EventList(DateTime.Now.AddDays(4), DateTime.Now.AddDays(4).AddHours(3), "Netflix & Chill", Color.DarkGreen));

            list.Add(new EventList(DateTime.Now.AddDays(5), DateTime.Now.AddDays(5).AddHours(3), "Netflix & Chill", Color.DarkBlue));
            list.Add(new EventList(DateTime.Now.AddDays(5), DateTime.Now.AddDays(5).AddHours(3), "Netflix & Chill", Color.DarkRed));
            list.Add(new EventList(DateTime.Now.AddDays(6), DateTime.Now.AddDays(6).AddHours(3), "Netflix & Chill", Color.DarkGreen));
                                                                                                 
            list.Add(new EventList(DateTime.Now.AddDays(7), DateTime.Now.AddDays(7).AddHours(3), "Netflix & Chill", Color.DarkBlue));
            list.Add(new EventList(DateTime.Now.AddDays(8), DateTime.Now.AddDays(8).AddHours(3), "Netflix & Chill", Color.DarkRed));
            list.Add(new EventList(DateTime.Now.AddDays(9), DateTime.Now.AddDays(9).AddHours(3), "Netflix & Chill", Color.DarkGreen));
                                                                                                 
            list.Add(new EventList(DateTime.Now.AddDays(10), DateTime.Now.AddDays(10).AddHours(3), "Netflix & Chill", Color.DarkBlue));
            list.Add(new EventList(DateTime.Now.AddDays(10), DateTime.Now.AddDays(10).AddHours(3), "Netflix & Chill", Color.DarkRed));
            list.Add(new EventList(DateTime.Now.AddDays(10), DateTime.Now.AddDays(10).AddHours(3), "Netflix & Chill", Color.DarkGreen));


            foreach (var item in list)
            {
                CalendarInlineEvent event1 = new CalendarInlineEvent();
                event1.StartTime =item.StartTime;
                event1.EndTime = item.EndTime;
                event1.Subject = item.Subject;
                event1.Color = item.Color;

                CalendarInlineEvents.Add(event1);
            }

        }
    }
    public class EventList
    {
        private DateTime dateTime1;
        private DateTime dateTime2;
        private string v;
        private Color darkBlue;

        public EventList(DateTime dateTime1, DateTime dateTime2, string v, Color darkBlue)
        {
            this.dateTime1 = dateTime1;
            this.dateTime2 = dateTime2;
            this.v = v;
            this.darkBlue = darkBlue;
        }

        public DateTime StartTime
        {
            get { return dateTime1; }
            set { dateTime1 = value; }
        }
        public DateTime EndTime
        {
            get { return dateTime2; }
            set { dateTime2 = value; }
        }
        public string Subject
        {
            get { return v; }
            set { v = value; }
        }
        public Color Color
        {
            get { return darkBlue; }
            set { darkBlue = value; }
        }
    }
}
