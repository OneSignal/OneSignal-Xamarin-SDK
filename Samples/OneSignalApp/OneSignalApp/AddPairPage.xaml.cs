﻿using System;
using System.Collections.Generic;
using OneSignalApp.Models;
using Xamarin.Forms;

namespace OneSignalApp
{   
   public partial class AddPairPage : ContentPage
   {   
      public AddPairPage ()
      {
         InitializeComponent ();
      }

      void CancelButton_Clicked(System.Object sender, System.EventArgs e)
      {
         Navigation.PopModalAsync();
      }

      void OkayButton_Clicked(System.Object sender, System.EventArgs e)
      {
         var pageModel = BindingContext as AddPairPageModel;
         if (pageModel == null)
            return;

         var errorMessage = pageModel.ErrorMessage;
         if (String.IsNullOrWhiteSpace(errorMessage))
         {
            pageModel.Complete();
            Navigation.PopModalAsync();
         }
         else
         {
            DisplayAlert("Error", errorMessage, "OK");
         }
      }
   }
}

