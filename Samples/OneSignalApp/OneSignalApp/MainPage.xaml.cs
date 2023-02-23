using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OneSignalApp
{

   public partial class MainPage : ContentPage
   {
      public MainPage()
      {
         InitializeComponent();
         BindingContext = new Models.MainPageModel(this);
      }
   }
}
