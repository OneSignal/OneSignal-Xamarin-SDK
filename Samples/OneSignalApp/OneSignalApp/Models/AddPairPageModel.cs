using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace OneSignalApp.Models
{
   public class AddPairPageModel : INotifyPropertyChanged
   {
      public event EventHandler PageCompleted;
      public event PropertyChangedEventHandler PropertyChanged;

      public string TitleLabel { get; }
      public string KeyLabel { get; }
      public string ValueLabel { get; }

      private string _key;
      public string Key
      {
         get => _key;
         set
         {
            if (_key != value)
            {
               _key = value;
               OnPropertyChanged();
            }
         }
      }

      private string _value;
      public string Value
      {
         get => _value;
         set
         {
            if (_value != value)
            {
               _value = value;
               OnPropertyChanged();
            }
         }
      }

      public string ErrorMessage
      {
         get
         {
            if (String.IsNullOrWhiteSpace(Key))
            {
               return $"${KeyLabel} must be specified";
            }

            if (String.IsNullOrWhiteSpace(Value))
            {
               return $"${ValueLabel} must be specified";
            }

            return "";
         }
      }

      public AddPairPageModel(string titleLabel = "Add KVP", string keyLabel = "Key", string valueLabel = "Value")
      {
         TitleLabel = titleLabel;
         KeyLabel = keyLabel;
         ValueLabel = valueLabel;
      }

      public void Complete()
      {
         PageCompleted?.Invoke(this, EventArgs.Empty);
      }

      private void OnPropertyChanged([CallerMemberName] string name = "") =>
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
   }
}
